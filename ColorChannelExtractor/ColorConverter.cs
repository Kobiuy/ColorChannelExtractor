using ColorChannelExtractor.ColorProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ColorChannelExtractor
{
	public static class ColorConverter
	{
		public static (Color Y, Color Cb, Color Cr) ConvertToYCbCr(this Color color)
		{
			double Y = color.R / 255f * 0.299 + color.G / 255f * 0.587 + color.B / 255f * 0.114f;
			double Cb = (color.B / 255f - Y) / 1.772f + 0.5f;
			double Cr = (color.R / 255f - Y) / 1.402f + 0.5f;
			Color colorY = Color.FromArgb(color.A, (int)(Y * 255), (int)(Y * 255), (int)(Y * 255));
			Color colorCb = Color.FromArgb(color.A, 127, (int)(255 - Cb * 255), (int)(Cb * 255));
			Color colorCr = Color.FromArgb(color.A, (int)(Cr * 255), (int)(255 - Cr * 255), 127);

			return (colorY, colorCb, colorCr);
		}
		public static (Color H, Color S, Color V) ConvertToHSV(this Color color)
		{
			var v = GetScalledColor(color);
			(var R, var G, var B) = (v.X, v.Y, v.Z);
			var V = MathF.Max(R, MathF.Max(G, B));
			var minC = MathF.Min(R, MathF.Min(G, B));
			var C = (V - minC);
			var L = (V - minC) / 2;
			double H = 0;
			double S = 0;
			if (C == 0)
			{
				H = 0;
			}
			else if (V == R)
			{
				H = 60 * (((G - B) / C) % 6);
			}
			else if (V == G)
			{
				H = 60 * (((B - R) / C) + 2);
			}
			else if (V == B)
			{
				H = 60 * (((R - G) / C) + 4);
			}
			H = Math.Abs(H);
			if (V != 0)
			{
				S = C / V;
			}
			return (Color.FromArgb(color.A, (int)(H / 360 * 255), (int)(H / 360 * 255), (int)(H / 360 * 255)), Color.FromArgb(color.A, (int)(S * 255), (int)(S * 255), (int)(S * 255)), Color.FromArgb(color.A, (int)(V * 255), (int)(V * 255), (int)(V * 255)));
		}
		public static (Color, Color, Color) ConvertToLab(this Color color, IColorProfile colorProfile, string iluminant, float gamma)
		{
			Vector3 linearRGB = InverseGammaCorrection(GetScalledColor(color), gamma);

			Matrix4x4 transformationMatrix = GetTransformationMatrix(colorProfile, iluminant);

			Vector3 XYZ = new Vector3(
				linearRGB.X * transformationMatrix.M11 + linearRGB.Y * transformationMatrix.M12 + linearRGB.Z * transformationMatrix.M13,
				linearRGB.X * transformationMatrix.M21 + linearRGB.Y * transformationMatrix.M22 + linearRGB.Z * transformationMatrix.M23,
				linearRGB.X * transformationMatrix.M31 + linearRGB.Y * transformationMatrix.M32 + linearRGB.Z * transformationMatrix.M33
			);
			XYZ = new Vector3(XYZ.X * 100, XYZ.Y * 100, XYZ.Z * 100);
			(float whiteX, float whiteY) = ((float, float))Data.iluminants[iluminant];
			float X = whiteX / whiteY * 100;
			float Z = CalculateZ(whiteX, whiteY) * 100;
			float Y = 100;
			float YYR = XYZ.Y / Y;
			float L;
			float a;
			float b;

			var XX = XYZ.X / X;
			var ZZ = XYZ.Z / Z;
			var YY = YYR;
			XX = XX < 0 ? -MathF.Cbrt(XX) : MathF.Cbrt(XX);
			ZZ = ZZ < 0 ? -MathF.Cbrt(XYZ.Z / Z) : MathF.Cbrt(XYZ.Z / Z);
			YY = YYR < 0 ? -MathF.Cbrt(YYR) : MathF.Cbrt(YYR);

			if (YYR > 0.008856)
			{
				L = 116 * YY - 16;
			}
			else
			{
				L = (float)(903.3 * YYR);
			}

			a = (500 * (XX - YY));
			b = 200 * (YY - ZZ);
			L = Math.Clamp(L, 0, 100);
			L = L * 2.55F;

			a = Math.Clamp(a, -127, 127);
			b = Math.Clamp(b, -127, 127);
			Color colorL = Color.FromArgb(color.A, (int)(L), (int)(L), (int)(L));
			Color colorA = Color.FromArgb(color.A, (int)(127 + a), (int)(127 - a), 127);
			Color colorB = Color.FromArgb(color.A, (int)(127 + b), 127, (int)(127 - b));
			return (colorL, colorA, colorB);
		}
		private static Matrix4x4 GetTransformationMatrix(IColorProfile colorProfile, string iluminant)
		{
			(var redX, var redY) = ((float, float))colorProfile.GetRedPrimary();
			(var greenX, var greenY) = ((float, float))colorProfile.GetGreenPrimary();
			(var blueX, var blueY) = ((float, float))colorProfile.GetBluePrimary();
			(var whiteX, var whiteY) = ((float, float))Data.iluminants[iluminant];

			float redZ = CalculateZ(redX, redY);
			float greenZ = CalculateZ(greenX, greenY);
			float blueZ = CalculateZ(blueX, blueY);

			float whiteZ = CalculateZ(whiteX, whiteY);
			Vector3 whitePointXYZ = new Vector3(
				whiteX / whiteY,
				1.0f,
				whiteZ
			);

			Matrix4x4 chromacityMatrix = new Matrix4x4(
				redX / redY, greenX / greenY, blueX / blueY, 0.0f,
				1.0f, 1.0f, 1.0f, 0.0f,
				redZ, greenZ, blueZ, 0.0f,
				0.0f, 0.0f, 0.0f, 1.0f
			);

			Matrix4x4 invertedChromaciyMatrix;
			Matrix4x4.Invert(chromacityMatrix, out invertedChromaciyMatrix);
			Vector3 S = Vector3.Transform(whitePointXYZ, invertedChromaciyMatrix);

			Matrix4x4 transformationMatrix = new Matrix4x4(
				chromacityMatrix.M11 * S.X, chromacityMatrix.M12 * S.Y, chromacityMatrix.M13 * S.Z, 0.0f,
				chromacityMatrix.M21 * S.X, chromacityMatrix.M22 * S.Y, chromacityMatrix.M23 * S.Z, 0.0f,
				chromacityMatrix.M31 * S.X, chromacityMatrix.M32 * S.Y, chromacityMatrix.M33 * S.Z, 0.0f,
				0.0f, 0.0f, 0.0f, 1.0f
			);


			return transformationMatrix;
		}

		private static float CalculateZ(float x, float y)
		{
			return (1 - x - y) / y;
		}

		public static Vector3 GetScalledColor(this Color color)
		{
			return new Vector3(color.R / 255f, color.G / 255f, color.B / 255f);
		}
		public static Vector3 InverseGammaCorrection(this Vector3 color, float gamma)
		{
			return new Vector3(MathF.Pow(color.X, gamma), MathF.Pow(color.Y, gamma), MathF.Pow(color.Z, gamma));
		}
	}
}

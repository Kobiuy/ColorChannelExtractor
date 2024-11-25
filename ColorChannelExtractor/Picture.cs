using ColorChannelExtractor.ColorProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChannelExtractor
{
	public class Picture : IConvertable
	{
		private ComboBox _predColorProfileCombobox;
		private ComboBox _predIluminantCombobox;
		private NumericUpDown _gammaUpDown;
		public Bitmap _bitmap { get; private set; }
		public Picture(string path)
		{
			_bitmap = new Bitmap(path);
		}
		public Picture(string path, ComboBox predColorProfileCombobox, ComboBox predIluminantCombobox, NumericUpDown gammaUpDown) : this(path)
		{
			_predColorProfileCombobox = predColorProfileCombobox;
			_predIluminantCombobox = predIluminantCombobox;
			_gammaUpDown = gammaUpDown;
		}

		public (Bitmap C0, Bitmap C1, Bitmap C2) ConvertToYCbCr()
		{
			Bitmap channelY = new Bitmap(_bitmap.Width, _bitmap.Height);
			Bitmap channelCb = new Bitmap(_bitmap.Width, _bitmap.Height);
			Bitmap channelCr = new Bitmap(_bitmap.Width, _bitmap.Height);
			for (int x = 0; x < _bitmap.Width; x++)
			{
				for (int y = 0; y < _bitmap.Height; y++)
				{
					var YCbCr = _bitmap.GetPixel(x, y).ConvertToYCbCr();
					channelY.SetPixel(x, y, YCbCr.Y);
					channelCb.SetPixel(x, y, YCbCr.Cb);
					channelCr.SetPixel(x, y, YCbCr.Cr);
				}
			}
			return (channelY, channelCb, channelCr);
		}

		public (Bitmap C0, Bitmap C1, Bitmap C2) ConvertToHSV()
		{
			Bitmap channelH = new Bitmap(_bitmap.Width, _bitmap.Height);
			Bitmap channelS = new Bitmap(_bitmap.Width, _bitmap.Height);
			Bitmap channelV = new Bitmap(_bitmap.Width, _bitmap.Height);
			for (int x = 0; x < _bitmap.Width; x++)
			{
				for (int y = 0; y < _bitmap.Height; y++)
				{
					var HSV = _bitmap.GetPixel(x, y).ConvertToHSV();
					channelH.SetPixel(x, y, HSV.H);
					channelS.SetPixel(x, y, HSV.S);
					channelV.SetPixel(x, y, HSV.V);
				}
			}
			return (channelH, channelS, channelV);
		}

		public (Bitmap C0, Bitmap C1, Bitmap C2) ConvertToLab()
		{
			Bitmap channelL = new Bitmap(_bitmap.Width, _bitmap.Height);
			Bitmap channela = new Bitmap(_bitmap.Width, _bitmap.Height);
			Bitmap channelb = new Bitmap(_bitmap.Width, _bitmap.Height);
			for (int x = 0; x < _bitmap.Width; x++)
			{
				for (int y = 0; y < _bitmap.Height; y++)
				{
					var Lab = _bitmap.GetPixel(x, y).ConvertToLab(Data.colorProfiles[(String)_predColorProfileCombobox.SelectedItem], (string)_predIluminantCombobox.SelectedItem, (float)_gammaUpDown.Value);
					channelL.SetPixel(x, y, Lab.Item1);
					channela.SetPixel(x, y, Lab.Item2);
					channelb.SetPixel(x, y, Lab.Item3);
				}
			}
			return (channelL, channela, channelb);
		}
	}
}

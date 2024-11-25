using ColorChannelExtractor.ColorProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChannelExtractor
{
	public static class Data
	{
		public static Dictionary<string, (double, double)> iluminants = new Dictionary<string, (double, double)>()
		{   {"A",(0.44757, 0.40744) }, {"B",(0.34840, 0.35160) }, {"C",(0.31006, 0.31615) },
			{ "D50",(0.34567, 0.35850) }, {"D55",(0.33242, 0.34743) }, {"D65",(0.31273, 0.32902) },
			{"D75", (0.29902, 0.31485)}, {"9300K",(0.28480, 0.29320)}, {"E",(0.33333, 0.33333)},
			{ "F2",(0.37207, 0.37512)}, {"F7",(0.31285, 0.32918)}, {"F11",(0.38054, 0.37691)}};
		public static Dictionary<string, IColorProfile> colorProfiles = new Dictionary<string, IColorProfile>()
		{
			{"sRGB", new SRGB()},
			{"Adobe RGB", new AdobeRGB()},
			{"Apple RGB", new AppleRGB()},
			{"CIE RGB", new CIERGB()},
			{"Wide Gamut", new WideGamut()}
		};
	}
}

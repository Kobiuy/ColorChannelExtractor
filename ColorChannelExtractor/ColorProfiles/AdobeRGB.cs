using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChannelExtractor.ColorProfiles
{
	internal class AdobeRGB : IColorProfile
	{
		public (double, double) GetBluePrimary()
		{
			return (0.1500, 0.0600);
		}

		public double GetGamma()
		{
			return 2.2;
		}

		public (double, double) GetGreenPrimary()
		{
			return (0.2100, 0.7100);
		}

		public (double, double) GetRedPrimary()
		{
			return (0.6400, 0.3300);
		}
	}
}

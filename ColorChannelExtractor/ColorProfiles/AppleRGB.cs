using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChannelExtractor.ColorProfiles
{
	internal class AppleRGB : IColorProfile
	{
		public (double, double) GetBluePrimary()
		{
			return (0.1550, 0.0700);
		}

		public double GetGamma()
		{
			return 1.8;
		}

		public (double, double) GetGreenPrimary()
		{
			return (0.2800, 0.5950);
		}

		public (double, double) GetRedPrimary()
		{
			return (0.6250, 0.3400);
		}
	}
}

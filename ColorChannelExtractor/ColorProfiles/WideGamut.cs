using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChannelExtractor.ColorProfiles
{
	internal class WideGamut : IColorProfile
	{
		public (double, double) GetBluePrimary()
		{
			return (0.0700, 0.0800);
		}

		public double GetGamma()
		{
			return 2.2;
		}

		public (double, double) GetGreenPrimary()
		{
			return (0.1700, 0.7970);
		}

		public (double, double) GetRedPrimary()
		{
			return (0.7347, 0.2653);
		}
	}
}

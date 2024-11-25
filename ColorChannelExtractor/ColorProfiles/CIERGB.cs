using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChannelExtractor.ColorProfiles
{
	internal class CIERGB : IColorProfile
	{
		public (double, double) GetBluePrimary()
		{
			return (0.1666, 0.0089);
		}

		public double GetGamma()
		{
			return 2.2;
		}

		public (double, double) GetGreenPrimary()
		{
			return (0.2738, 0.7174);
		}

		public (double, double) GetRedPrimary()
		{
			return (0.7347, 0.2650);
		}
	}
}

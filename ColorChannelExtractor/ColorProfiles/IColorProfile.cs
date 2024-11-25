using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChannelExtractor.ColorProfiles
{
    public interface IColorProfile
    {
        public (double, double) GetRedPrimary();
        public (double, double) GetGreenPrimary();
        public (double, double) GetBluePrimary();
        public double GetGamma();
    }


}

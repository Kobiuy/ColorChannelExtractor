using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChannelExtractor
{
	internal interface IConvertable
	{
		public (Bitmap C0, Bitmap C1, Bitmap C2) ConvertToYCbCr();
		public (Bitmap C0, Bitmap C1, Bitmap C2) ConvertToHSV();

		public (Bitmap C0, Bitmap C1, Bitmap C2) ConvertToLab();

	}
}

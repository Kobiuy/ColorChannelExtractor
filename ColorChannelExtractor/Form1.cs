using System.Drawing.Imaging;

namespace ColorChannelExtractor
{
	public partial class Form1 : Form
	{
		private Picture _mainImage;
		private string _mainImagePath;
		private (Bitmap C1, Bitmap C2, Bitmap C3) _channels;
		private enum Format
		{
			HSV, YCbCr, LAB
		}
		public Form1()
		{
			InitializeComponent();
			predColorProfileCombobox.Items.AddRange(Data.colorProfiles.Keys.ToArray());
			predIluminantCombobox.Items.AddRange(Data.iluminants.Keys.ToArray());
			colorProfileCombobox.SelectedIndex = 0;
			predColorProfileCombobox.SelectedIndex = 0;
			predIluminantCombobox.SelectedIndex = 0;

		}

		private Dictionary<int, Func<Picture, (Bitmap C1, Bitmap C2, Bitmap C3)>> conversions = new Dictionary<int, Func<Picture, (Bitmap C1, Bitmap C2, Bitmap C3)>>()
		{
			{0, (Picture image)=>{ return image.ConvertToYCbCr(); } },
			{1, (Picture image)=>{ return image.ConvertToHSV(); } },
			{2, (Picture image)=>{ return image.ConvertToLab(); } },

		};

		private void loadImageButton_Click(object sender, EventArgs e)
		{
			var fileDialog = new OpenFileDialog();
			fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
			fileDialog.Title = "Select normal map file";
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				_mainImagePath = fileDialog.FileName;
				_mainImage = new Picture(_mainImagePath, predColorProfileCombobox, predIluminantCombobox, gammaUpDown);
				originalPicturebox.Image = _mainImage._bitmap;
				originalPicturebox.Refresh();
				separateChannelsButton.Enabled = true;
			}
		}

		private void separateChannelsButton_Click(object sender, EventArgs e)
		{
			_channels = conversions[colorProfileCombobox.SelectedIndex](_mainImage);
			channel1Picturebox.Image = _channels.C1;
			channel2Picturebox.Image = _channels.C2;
			channel3Picturebox.Image = _channels.C3;
			channel1Picturebox.Refresh();
			channel2Picturebox.Refresh();
			channel3Picturebox.Refresh();
			saveButton.Enabled = true;

		}

		private void colorProfileCombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			labSettingsGroupbox.Enabled = colorProfileCombobox.SelectedIndex == 2;
		}

		private void predColorProfileCombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var colorProfile = Data.colorProfiles[(string)predColorProfileCombobox.SelectedItem];

			var (greenX, greenY) = colorProfile.GetGreenPrimary();
			greenPrimaryXUpDown.Value = (decimal)greenX;
			greenPrimaryYUpDown.Value = (decimal)greenY;

			var (blueX, blueY) = colorProfile.GetBluePrimary();
			bluePrimaryXUpDown.Value = (decimal)blueX;
			bluePrimaryYUpDown.Value = (decimal)blueY;

			var (redX, redY) = colorProfile.GetRedPrimary();
			redPrimaryXUpDown.Value = (decimal)redX;
			redPrimaryYUpDown.Value = (decimal)redY;

			gammaUpDown.Value = (decimal)colorProfile.GetGamma();
		}



		private void predIluminantCombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var (whiteX, whiteY) = Data.iluminants[(string)predIluminantCombobox.SelectedItem];
			whitePrimaryXUpDown.Value = (decimal)whiteX;
			whitePrimaryYUpDown.Value = (decimal)whiteY;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				_channels.C1.Save(dialog.FileName + "_C1.JPG", ImageFormat.Jpeg);
				_channels.C2.Save(dialog.FileName + "_C2.JPG", ImageFormat.Jpeg);
				_channels.C3.Save(dialog.FileName + "_C3.JPG", ImageFormat.Jpeg);
			}
		}
	}
}

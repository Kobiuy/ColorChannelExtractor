namespace ColorChannelExtractor
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			mainTable = new TableLayoutPanel();
			topTable = new TableLayoutPanel();
			originalPicturebox = new PictureBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			loadImageButton = new Button();
			colorProfileCombobox = new ComboBox();
			separateChannelsButton = new Button();
			labSettingsGroupbox = new GroupBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			predIluminantCombobox = new ComboBox();
			predColorProfileCombobox = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			tableLayoutPanel3 = new TableLayoutPanel();
			whitePrimaryYUpDown = new NumericUpDown();
			whitePrimaryXUpDown = new NumericUpDown();
			bluePrimaryYUpDown = new NumericUpDown();
			bluePrimaryXUpDown = new NumericUpDown();
			greenPrimaryYUpDown = new NumericUpDown();
			greenPrimaryXUpDown = new NumericUpDown();
			redPrimaryYUpDown = new NumericUpDown();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			redPrimaryXUpDown = new NumericUpDown();
			gammaUpDown = new NumericUpDown();
			saveButton = new Button();
			bottomTable = new TableLayoutPanel();
			channel3Picturebox = new PictureBox();
			channel2Picturebox = new PictureBox();
			channel1Picturebox = new PictureBox();
			mainTable.SuspendLayout();
			topTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)originalPicturebox).BeginInit();
			flowLayoutPanel1.SuspendLayout();
			labSettingsGroupbox.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)whitePrimaryYUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)whitePrimaryXUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)bluePrimaryYUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)bluePrimaryXUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)greenPrimaryYUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)greenPrimaryXUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)redPrimaryYUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)redPrimaryXUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)gammaUpDown).BeginInit();
			bottomTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)channel3Picturebox).BeginInit();
			((System.ComponentModel.ISupportInitialize)channel2Picturebox).BeginInit();
			((System.ComponentModel.ISupportInitialize)channel1Picturebox).BeginInit();
			SuspendLayout();
			// 
			// mainTable
			// 
			mainTable.ColumnCount = 1;
			mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			mainTable.Controls.Add(topTable, 0, 0);
			mainTable.Controls.Add(bottomTable, 0, 1);
			mainTable.Dock = DockStyle.Fill;
			mainTable.Location = new Point(0, 0);
			mainTable.Name = "mainTable";
			mainTable.RowCount = 2;
			mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			mainTable.Size = new Size(1182, 853);
			mainTable.TabIndex = 0;
			// 
			// topTable
			// 
			topTable.ColumnCount = 2;
			topTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			topTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			topTable.Controls.Add(originalPicturebox, 0, 0);
			topTable.Controls.Add(flowLayoutPanel1, 1, 0);
			topTable.Dock = DockStyle.Fill;
			topTable.Location = new Point(3, 3);
			topTable.Name = "topTable";
			topTable.RowCount = 1;
			topTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			topTable.Size = new Size(1176, 420);
			topTable.TabIndex = 0;
			// 
			// originalPicturebox
			// 
			originalPicturebox.BorderStyle = BorderStyle.FixedSingle;
			originalPicturebox.Dock = DockStyle.Fill;
			originalPicturebox.Location = new Point(3, 3);
			originalPicturebox.Name = "originalPicturebox";
			originalPicturebox.Size = new Size(582, 414);
			originalPicturebox.SizeMode = PictureBoxSizeMode.Zoom;
			originalPicturebox.TabIndex = 0;
			originalPicturebox.TabStop = false;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(loadImageButton);
			flowLayoutPanel1.Controls.Add(colorProfileCombobox);
			flowLayoutPanel1.Controls.Add(separateChannelsButton);
			flowLayoutPanel1.Controls.Add(labSettingsGroupbox);
			flowLayoutPanel1.Controls.Add(saveButton);
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(591, 3);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(582, 414);
			flowLayoutPanel1.TabIndex = 2;
			// 
			// loadImageButton
			// 
			loadImageButton.Location = new Point(3, 3);
			loadImageButton.Name = "loadImageButton";
			loadImageButton.Size = new Size(151, 29);
			loadImageButton.TabIndex = 2;
			loadImageButton.Text = "Load Image";
			loadImageButton.UseVisualStyleBackColor = true;
			loadImageButton.Click += loadImageButton_Click;
			// 
			// colorProfileCombobox
			// 
			colorProfileCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
			colorProfileCombobox.FormattingEnabled = true;
			colorProfileCombobox.Items.AddRange(new object[] { "YCbCr", "HSV", "LAB" });
			colorProfileCombobox.Location = new Point(3, 38);
			colorProfileCombobox.Name = "colorProfileCombobox";
			colorProfileCombobox.Size = new Size(151, 28);
			colorProfileCombobox.TabIndex = 1;
			colorProfileCombobox.SelectedIndexChanged += colorProfileCombobox_SelectedIndexChanged;
			// 
			// separateChannelsButton
			// 
			separateChannelsButton.Enabled = false;
			separateChannelsButton.Location = new Point(3, 72);
			separateChannelsButton.Name = "separateChannelsButton";
			separateChannelsButton.Size = new Size(151, 29);
			separateChannelsButton.TabIndex = 3;
			separateChannelsButton.Text = "Separate Channels";
			separateChannelsButton.UseVisualStyleBackColor = true;
			separateChannelsButton.Click += separateChannelsButton_Click;
			// 
			// labSettingsGroupbox
			// 
			labSettingsGroupbox.Controls.Add(tableLayoutPanel1);
			labSettingsGroupbox.Enabled = false;
			flowLayoutPanel1.SetFlowBreak(labSettingsGroupbox, true);
			labSettingsGroupbox.Location = new Point(3, 107);
			labSettingsGroupbox.Name = "labSettingsGroupbox";
			labSettingsGroupbox.Size = new Size(404, 294);
			labSettingsGroupbox.TabIndex = 4;
			labSettingsGroupbox.TabStop = false;
			labSettingsGroupbox.Text = "Lab Settings";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 23);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
			tableLayoutPanel1.Size = new Size(398, 268);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(predIluminantCombobox, 1, 1);
			tableLayoutPanel2.Controls.Add(predColorProfileCombobox, 1, 0);
			tableLayoutPanel2.Controls.Add(label1, 0, 0);
			tableLayoutPanel2.Controls.Add(label2, 0, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(392, 74);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// predIluminantCombobox
			// 
			predIluminantCombobox.Dock = DockStyle.Fill;
			predIluminantCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
			predIluminantCombobox.FormattingEnabled = true;
			predIluminantCombobox.Location = new Point(199, 40);
			predIluminantCombobox.Name = "predIluminantCombobox";
			predIluminantCombobox.Size = new Size(190, 28);
			predIluminantCombobox.TabIndex = 3;
			predIluminantCombobox.SelectedIndexChanged += predIluminantCombobox_SelectedIndexChanged;
			// 
			// predColorProfileCombobox
			// 
			predColorProfileCombobox.Dock = DockStyle.Fill;
			predColorProfileCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
			predColorProfileCombobox.FormattingEnabled = true;
			predColorProfileCombobox.Location = new Point(199, 3);
			predColorProfileCombobox.Name = "predColorProfileCombobox";
			predColorProfileCombobox.Size = new Size(190, 28);
			predColorProfileCombobox.TabIndex = 2;
			predColorProfileCombobox.SelectedIndexChanged += predColorProfileCombobox_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(190, 37);
			label1.TabIndex = 0;
			label1.Text = "Predefined color profile";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Fill;
			label2.Location = new Point(3, 37);
			label2.Name = "label2";
			label2.Size = new Size(190, 37);
			label2.TabIndex = 1;
			label2.Text = "Predefined iluminant";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 3;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
			tableLayoutPanel3.Controls.Add(whitePrimaryYUpDown, 2, 4);
			tableLayoutPanel3.Controls.Add(whitePrimaryXUpDown, 1, 4);
			tableLayoutPanel3.Controls.Add(bluePrimaryYUpDown, 2, 3);
			tableLayoutPanel3.Controls.Add(bluePrimaryXUpDown, 1, 3);
			tableLayoutPanel3.Controls.Add(greenPrimaryYUpDown, 2, 2);
			tableLayoutPanel3.Controls.Add(greenPrimaryXUpDown, 1, 2);
			tableLayoutPanel3.Controls.Add(redPrimaryYUpDown, 2, 1);
			tableLayoutPanel3.Controls.Add(label6, 0, 1);
			tableLayoutPanel3.Controls.Add(label5, 2, 0);
			tableLayoutPanel3.Controls.Add(label4, 1, 0);
			tableLayoutPanel3.Controls.Add(label3, 0, 0);
			tableLayoutPanel3.Controls.Add(label7, 0, 2);
			tableLayoutPanel3.Controls.Add(label8, 0, 3);
			tableLayoutPanel3.Controls.Add(label9, 0, 4);
			tableLayoutPanel3.Controls.Add(label10, 1, 5);
			tableLayoutPanel3.Controls.Add(redPrimaryXUpDown, 1, 1);
			tableLayoutPanel3.Controls.Add(gammaUpDown, 2, 5);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 83);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 6;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel3.Size = new Size(392, 182);
			tableLayoutPanel3.TabIndex = 1;
			// 
			// whitePrimaryYUpDown
			// 
			whitePrimaryYUpDown.DecimalPlaces = 4;
			whitePrimaryYUpDown.Dock = DockStyle.Fill;
			whitePrimaryYUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			whitePrimaryYUpDown.Location = new Point(265, 123);
			whitePrimaryYUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
			whitePrimaryYUpDown.Name = "whitePrimaryYUpDown";
			whitePrimaryYUpDown.Size = new Size(124, 27);
			whitePrimaryYUpDown.TabIndex = 17;
			// 
			// whitePrimaryXUpDown
			// 
			whitePrimaryXUpDown.DecimalPlaces = 4;
			whitePrimaryXUpDown.Dock = DockStyle.Fill;
			whitePrimaryXUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			whitePrimaryXUpDown.Location = new Point(132, 123);
			whitePrimaryXUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
			whitePrimaryXUpDown.Name = "whitePrimaryXUpDown";
			whitePrimaryXUpDown.Size = new Size(127, 27);
			whitePrimaryXUpDown.TabIndex = 16;
			// 
			// bluePrimaryYUpDown
			// 
			bluePrimaryYUpDown.DecimalPlaces = 4;
			bluePrimaryYUpDown.Dock = DockStyle.Fill;
			bluePrimaryYUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			bluePrimaryYUpDown.Location = new Point(265, 93);
			bluePrimaryYUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
			bluePrimaryYUpDown.Name = "bluePrimaryYUpDown";
			bluePrimaryYUpDown.Size = new Size(124, 27);
			bluePrimaryYUpDown.TabIndex = 15;
			// 
			// bluePrimaryXUpDown
			// 
			bluePrimaryXUpDown.DecimalPlaces = 4;
			bluePrimaryXUpDown.Dock = DockStyle.Fill;
			bluePrimaryXUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			bluePrimaryXUpDown.Location = new Point(132, 93);
			bluePrimaryXUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
			bluePrimaryXUpDown.Name = "bluePrimaryXUpDown";
			bluePrimaryXUpDown.Size = new Size(127, 27);
			bluePrimaryXUpDown.TabIndex = 14;
			// 
			// greenPrimaryYUpDown
			// 
			greenPrimaryYUpDown.DecimalPlaces = 4;
			greenPrimaryYUpDown.Dock = DockStyle.Fill;
			greenPrimaryYUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			greenPrimaryYUpDown.Location = new Point(265, 63);
			greenPrimaryYUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
			greenPrimaryYUpDown.Name = "greenPrimaryYUpDown";
			greenPrimaryYUpDown.Size = new Size(124, 27);
			greenPrimaryYUpDown.TabIndex = 13;
			// 
			// greenPrimaryXUpDown
			// 
			greenPrimaryXUpDown.DecimalPlaces = 4;
			greenPrimaryXUpDown.Dock = DockStyle.Fill;
			greenPrimaryXUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			greenPrimaryXUpDown.Location = new Point(132, 63);
			greenPrimaryXUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
			greenPrimaryXUpDown.Name = "greenPrimaryXUpDown";
			greenPrimaryXUpDown.Size = new Size(127, 27);
			greenPrimaryXUpDown.TabIndex = 12;
			// 
			// redPrimaryYUpDown
			// 
			redPrimaryYUpDown.DecimalPlaces = 4;
			redPrimaryYUpDown.Dock = DockStyle.Fill;
			redPrimaryYUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			redPrimaryYUpDown.Location = new Point(265, 33);
			redPrimaryYUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
			redPrimaryYUpDown.Name = "redPrimaryYUpDown";
			redPrimaryYUpDown.Size = new Size(124, 27);
			redPrimaryYUpDown.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Dock = DockStyle.Fill;
			label6.Location = new Point(3, 30);
			label6.Name = "label6";
			label6.Size = new Size(123, 30);
			label6.TabIndex = 5;
			label6.Text = "Red primary";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Dock = DockStyle.Fill;
			label5.Location = new Point(265, 0);
			label5.Name = "label5";
			label5.Size = new Size(124, 30);
			label5.TabIndex = 4;
			label5.Text = "Y";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Dock = DockStyle.Fill;
			label4.Location = new Point(132, 0);
			label4.Name = "label4";
			label4.Size = new Size(127, 30);
			label4.TabIndex = 3;
			label4.Text = "X";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Fill;
			label3.Location = new Point(3, 0);
			label3.Name = "label3";
			label3.Size = new Size(123, 30);
			label3.TabIndex = 2;
			label3.Text = "Chromaticity";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Dock = DockStyle.Fill;
			label7.Location = new Point(3, 60);
			label7.Name = "label7";
			label7.Size = new Size(123, 30);
			label7.TabIndex = 6;
			label7.Text = "Green primary";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Dock = DockStyle.Fill;
			label8.Location = new Point(3, 90);
			label8.Name = "label8";
			label8.Size = new Size(123, 30);
			label8.TabIndex = 7;
			label8.Text = "Blue primary";
			label8.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Dock = DockStyle.Fill;
			label9.Location = new Point(3, 120);
			label9.Name = "label9";
			label9.Size = new Size(123, 30);
			label9.TabIndex = 8;
			label9.Text = "White primary";
			label9.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Dock = DockStyle.Fill;
			label10.Location = new Point(132, 150);
			label10.Name = "label10";
			label10.Size = new Size(127, 32);
			label10.TabIndex = 9;
			label10.Text = "Gamma";
			label10.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// redPrimaryXUpDown
			// 
			redPrimaryXUpDown.DecimalPlaces = 4;
			redPrimaryXUpDown.Dock = DockStyle.Fill;
			redPrimaryXUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			redPrimaryXUpDown.Location = new Point(132, 33);
			redPrimaryXUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
			redPrimaryXUpDown.Name = "redPrimaryXUpDown";
			redPrimaryXUpDown.Size = new Size(127, 27);
			redPrimaryXUpDown.TabIndex = 10;
			redPrimaryXUpDown.ThousandsSeparator = true;
			// 
			// gammaUpDown
			// 
			gammaUpDown.DecimalPlaces = 4;
			gammaUpDown.Dock = DockStyle.Fill;
			gammaUpDown.Location = new Point(265, 153);
			gammaUpDown.Name = "gammaUpDown";
			gammaUpDown.Size = new Size(124, 27);
			gammaUpDown.TabIndex = 18;
			// 
			// saveButton
			// 
			saveButton.Enabled = false;
			saveButton.Location = new Point(413, 3);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(163, 29);
			saveButton.TabIndex = 5;
			saveButton.Text = "Save Result";
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// bottomTable
			// 
			bottomTable.ColumnCount = 3;
			bottomTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
			bottomTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
			bottomTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
			bottomTable.Controls.Add(channel3Picturebox, 2, 0);
			bottomTable.Controls.Add(channel2Picturebox, 1, 0);
			bottomTable.Controls.Add(channel1Picturebox, 0, 0);
			bottomTable.Dock = DockStyle.Fill;
			bottomTable.Location = new Point(3, 429);
			bottomTable.Name = "bottomTable";
			bottomTable.RowCount = 1;
			bottomTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			bottomTable.Size = new Size(1176, 421);
			bottomTable.TabIndex = 1;
			// 
			// channel3Picturebox
			// 
			channel3Picturebox.BorderStyle = BorderStyle.FixedSingle;
			channel3Picturebox.Dock = DockStyle.Fill;
			channel3Picturebox.Location = new Point(786, 3);
			channel3Picturebox.Name = "channel3Picturebox";
			channel3Picturebox.Size = new Size(387, 415);
			channel3Picturebox.SizeMode = PictureBoxSizeMode.Zoom;
			channel3Picturebox.TabIndex = 3;
			channel3Picturebox.TabStop = false;
			// 
			// channel2Picturebox
			// 
			channel2Picturebox.BorderStyle = BorderStyle.FixedSingle;
			channel2Picturebox.Dock = DockStyle.Fill;
			channel2Picturebox.Location = new Point(394, 3);
			channel2Picturebox.Name = "channel2Picturebox";
			channel2Picturebox.Size = new Size(386, 415);
			channel2Picturebox.SizeMode = PictureBoxSizeMode.Zoom;
			channel2Picturebox.TabIndex = 2;
			channel2Picturebox.TabStop = false;
			// 
			// channel1Picturebox
			// 
			channel1Picturebox.BorderStyle = BorderStyle.FixedSingle;
			channel1Picturebox.Dock = DockStyle.Fill;
			channel1Picturebox.Location = new Point(3, 3);
			channel1Picturebox.Name = "channel1Picturebox";
			channel1Picturebox.Size = new Size(385, 415);
			channel1Picturebox.SizeMode = PictureBoxSizeMode.Zoom;
			channel1Picturebox.TabIndex = 1;
			channel1Picturebox.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1182, 853);
			Controls.Add(mainTable);
			Name = "Form1";
			Text = "Color Channel Extractor ";
			mainTable.ResumeLayout(false);
			topTable.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)originalPicturebox).EndInit();
			flowLayoutPanel1.ResumeLayout(false);
			labSettingsGroupbox.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)whitePrimaryYUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)whitePrimaryXUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)bluePrimaryYUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)bluePrimaryXUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)greenPrimaryYUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)greenPrimaryXUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)redPrimaryYUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)redPrimaryXUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)gammaUpDown).EndInit();
			bottomTable.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)channel3Picturebox).EndInit();
			((System.ComponentModel.ISupportInitialize)channel2Picturebox).EndInit();
			((System.ComponentModel.ISupportInitialize)channel1Picturebox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainTable;
		private TableLayoutPanel topTable;
		private TableLayoutPanel bottomTable;
		private PictureBox originalPicturebox;
		private ComboBox colorProfileCombobox;
		private PictureBox channel3Picturebox;
		private PictureBox channel2Picturebox;
		private PictureBox channel1Picturebox;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button loadImageButton;
		private Button separateChannelsButton;
		private GroupBox labSettingsGroupbox;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private Label label1;
		private Label label2;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private ComboBox predIluminantCombobox;
		private ComboBox predColorProfileCombobox;
		private NumericUpDown whitePrimaryYUpDown;
		private NumericUpDown whitePrimaryXUpDown;
		private NumericUpDown bluePrimaryYUpDown;
		private NumericUpDown bluePrimaryXUpDown;
		private NumericUpDown greenPrimaryYUpDown;
		private NumericUpDown greenPrimaryXUpDown;
		private NumericUpDown redPrimaryYUpDown;
		private NumericUpDown redPrimaryXUpDown;
		private NumericUpDown gammaUpDown;
		private Button saveButton;
	}
}

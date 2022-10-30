namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetData = new System.Windows.Forms.Button();
            this.GetScreenshot = new System.Windows.Forms.Button();
            this.PlotTime = new System.Windows.Forms.Button();
            this.PlotXY = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PlotOptionsLabel = new System.Windows.Forms.Label();
            this.ColorPicker = new System.Windows.Forms.Button();
            this.TestName = new System.Windows.Forms.TextBox();
            this.TestNameLabel = new System.Windows.Forms.Label();
            this.ChannelsLabel = new System.Windows.Forms.Label();
            this.ChannelList = new System.Windows.Forms.CheckedListBox();
            this.x1 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lineStyle = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.TextBox();
            this.lineWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.markerSize = new System.Windows.Forms.NumericUpDown();
            this.marker = new System.Windows.Forms.ComboBox();
            this.xlabel = new System.Windows.Forms.TextBox();
            this.ylabel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imageDisplay = new System.Windows.Forms.PictureBox();
            this.Browse = new System.Windows.Forms.Button();
            this.colorDisplay = new System.Windows.Forms.Button();
            this.imageRight = new System.Windows.Forms.Button();
            this.imageLeft = new System.Windows.Forms.Button();
            this.imageSelector = new System.Windows.Forms.ComboBox();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markerSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(9, 78);
            this.GetData.Margin = new System.Windows.Forms.Padding(2);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(87, 47);
            this.GetData.TabIndex = 0;
            this.GetData.Text = "Get Data";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // GetScreenshot
            // 
            this.GetScreenshot.Location = new System.Drawing.Point(9, 130);
            this.GetScreenshot.Margin = new System.Windows.Forms.Padding(2);
            this.GetScreenshot.Name = "GetScreenshot";
            this.GetScreenshot.Size = new System.Drawing.Size(87, 47);
            this.GetScreenshot.TabIndex = 2;
            this.GetScreenshot.Text = "Get Screenshot";
            this.GetScreenshot.UseVisualStyleBackColor = true;
            this.GetScreenshot.Click += new System.EventHandler(this.GetScreenshot_Click);
            // 
            // PlotTime
            // 
            this.PlotTime.Location = new System.Drawing.Point(9, 194);
            this.PlotTime.Margin = new System.Windows.Forms.Padding(2);
            this.PlotTime.Name = "PlotTime";
            this.PlotTime.Size = new System.Drawing.Size(87, 47);
            this.PlotTime.TabIndex = 4;
            this.PlotTime.Text = "Plot (Time)";
            this.PlotTime.UseVisualStyleBackColor = true;
            this.PlotTime.Click += new System.EventHandler(this.PlotTime_Click);
            // 
            // PlotXY
            // 
            this.PlotXY.Location = new System.Drawing.Point(9, 246);
            this.PlotXY.Margin = new System.Windows.Forms.Padding(2);
            this.PlotXY.Name = "PlotXY";
            this.PlotXY.Size = new System.Drawing.Size(87, 47);
            this.PlotXY.TabIndex = 5;
            this.PlotXY.Text = "Plot (XY)";
            this.PlotXY.UseVisualStyleBackColor = true;
            this.PlotXY.Click += new System.EventHandler(this.PlotXY_Click);
            // 
            // PlotOptionsLabel
            // 
            this.PlotOptionsLabel.AutoSize = true;
            this.PlotOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotOptionsLabel.Location = new System.Drawing.Point(136, 130);
            this.PlotOptionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlotOptionsLabel.Name = "PlotOptionsLabel";
            this.PlotOptionsLabel.Size = new System.Drawing.Size(64, 13);
            this.PlotOptionsLabel.TabIndex = 6;
            this.PlotOptionsLabel.Text = "Plot Options";
            // 
            // ColorPicker
            // 
            this.ColorPicker.Location = new System.Drawing.Point(138, 146);
            this.ColorPicker.Margin = new System.Windows.Forms.Padding(2);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(44, 26);
            this.ColorPicker.TabIndex = 7;
            this.ColorPicker.Text = "Color";
            this.ColorPicker.UseVisualStyleBackColor = true;
            this.ColorPicker.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // TestName
            // 
            this.TestName.Location = new System.Drawing.Point(9, 55);
            this.TestName.Margin = new System.Windows.Forms.Padding(2);
            this.TestName.Name = "TestName";
            this.TestName.Size = new System.Drawing.Size(87, 20);
            this.TestName.TabIndex = 8;
            // 
            // TestNameLabel
            // 
            this.TestNameLabel.AutoSize = true;
            this.TestNameLabel.Location = new System.Drawing.Point(24, 40);
            this.TestNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TestNameLabel.Name = "TestNameLabel";
            this.TestNameLabel.Size = new System.Drawing.Size(59, 13);
            this.TestNameLabel.TabIndex = 9;
            this.TestNameLabel.Text = "Test Name";
            // 
            // ChannelsLabel
            // 
            this.ChannelsLabel.AutoSize = true;
            this.ChannelsLabel.Location = new System.Drawing.Point(141, 7);
            this.ChannelsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChannelsLabel.Name = "ChannelsLabel";
            this.ChannelsLabel.Size = new System.Drawing.Size(51, 13);
            this.ChannelsLabel.TabIndex = 10;
            this.ChannelsLabel.Text = "Channels";
            // 
            // ChannelList
            // 
            this.ChannelList.BackColor = System.Drawing.SystemColors.Window;
            this.ChannelList.FormattingEnabled = true;
            this.ChannelList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ChannelList.Location = new System.Drawing.Point(140, 27);
            this.ChannelList.Margin = new System.Windows.Forms.Padding(2);
            this.ChannelList.Name = "ChannelList";
            this.ChannelList.Size = new System.Drawing.Size(55, 64);
            this.ChannelList.TabIndex = 11;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(9, 298);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(21, 21);
            this.x1.TabIndex = 12;
            this.x1.Text = "1";
            this.x1.UseVisualStyleBackColor = true;
            this.x1.Click += new System.EventHandler(this.x1_Click);
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(75, 298);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(21, 21);
            this.x4.TabIndex = 13;
            this.x4.Text = "4";
            this.x4.UseVisualStyleBackColor = true;
            this.x4.Click += new System.EventHandler(this.x4_Click);
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(53, 298);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(21, 21);
            this.x3.TabIndex = 14;
            this.x3.Text = "3";
            this.x3.UseVisualStyleBackColor = true;
            this.x3.Click += new System.EventHandler(this.x3_Click);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(31, 298);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(21, 21);
            this.x2.TabIndex = 15;
            this.x2.Text = "2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.x2_Click);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(31, 319);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(21, 21);
            this.y2.TabIndex = 19;
            this.y2.Text = "2";
            this.y2.UseVisualStyleBackColor = true;
            this.y2.Click += new System.EventHandler(this.y2_Click);
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(53, 319);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(21, 21);
            this.y3.TabIndex = 18;
            this.y3.Text = "3";
            this.y3.UseVisualStyleBackColor = true;
            this.y3.Click += new System.EventHandler(this.y3_Click);
            // 
            // y4
            // 
            this.y4.Location = new System.Drawing.Point(75, 319);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(21, 21);
            this.y4.TabIndex = 17;
            this.y4.Text = "4";
            this.y4.UseVisualStyleBackColor = true;
            this.y4.Click += new System.EventHandler(this.y4_Click);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(9, 319);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(21, 21);
            this.y1.TabIndex = 16;
            this.y1.Text = "1";
            this.y1.UseVisualStyleBackColor = true;
            this.y1.Click += new System.EventHandler(this.y1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Y";
            // 
            // lineStyle
            // 
            this.lineStyle.FormattingEnabled = true;
            this.lineStyle.Location = new System.Drawing.Point(139, 198);
            this.lineStyle.Name = "lineStyle";
            this.lineStyle.Size = new System.Drawing.Size(57, 21);
            this.lineStyle.TabIndex = 23;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(237, 238);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(330, 20);
            this.title.TabIndex = 24;
            // 
            // lineWidth
            // 
            this.lineWidth.DecimalPlaces = 1;
            this.lineWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lineWidth.Location = new System.Drawing.Point(139, 238);
            this.lineWidth.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.lineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lineWidth.Name = "lineWidth";
            this.lineWidth.Size = new System.Drawing.Size(57, 20);
            this.lineWidth.TabIndex = 25;
            this.lineWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Line Width";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Line Style";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Marker";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Marker Size";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // markerSize
            // 
            this.markerSize.DecimalPlaces = 1;
            this.markerSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.markerSize.Location = new System.Drawing.Point(139, 319);
            this.markerSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.markerSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.markerSize.Name = "markerSize";
            this.markerSize.Size = new System.Drawing.Size(57, 20);
            this.markerSize.TabIndex = 29;
            this.markerSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // marker
            // 
            this.marker.FormattingEnabled = true;
            this.marker.Location = new System.Drawing.Point(139, 280);
            this.marker.Name = "marker";
            this.marker.Size = new System.Drawing.Size(57, 21);
            this.marker.TabIndex = 28;
            // 
            // xlabel
            // 
            this.xlabel.Location = new System.Drawing.Point(237, 280);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(330, 20);
            this.xlabel.TabIndex = 32;
            // 
            // ylabel
            // 
            this.ylabel.Location = new System.Drawing.Point(237, 319);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(330, 20);
            this.ylabel.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Title";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "X Label";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Y Label";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageDisplay
            // 
            this.imageDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageDisplay.Location = new System.Drawing.Point(237, 16);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(330, 179);
            this.imageDisplay.TabIndex = 37;
            this.imageDisplay.TabStop = false;
            this.imageDisplay.Click += new System.EventHandler(this.imageDisplay_Click);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(9, 7);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(87, 30);
            this.Browse.TabIndex = 38;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // colorDisplay
            // 
            this.colorDisplay.Enabled = false;
            this.colorDisplay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.colorDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorDisplay.Location = new System.Drawing.Point(183, 147);
            this.colorDisplay.Name = "colorDisplay";
            this.colorDisplay.Size = new System.Drawing.Size(14, 24);
            this.colorDisplay.TabIndex = 39;
            this.colorDisplay.UseVisualStyleBackColor = true;
            // 
            // imageRight
            // 
            this.imageRight.Location = new System.Drawing.Point(492, 197);
            this.imageRight.Name = "imageRight";
            this.imageRight.Size = new System.Drawing.Size(75, 23);
            this.imageRight.TabIndex = 40;
            this.imageRight.Text = ">";
            this.imageRight.UseVisualStyleBackColor = true;
            this.imageRight.Click += new System.EventHandler(this.imageRight_Click);
            // 
            // imageLeft
            // 
            this.imageLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.imageLeft.Location = new System.Drawing.Point(411, 197);
            this.imageLeft.Name = "imageLeft";
            this.imageLeft.Size = new System.Drawing.Size(75, 23);
            this.imageLeft.TabIndex = 41;
            this.imageLeft.Text = "<";
            this.imageLeft.UseVisualStyleBackColor = true;
            this.imageLeft.Click += new System.EventHandler(this.imageLeft_Click);
            // 
            // imageSelector
            // 
            this.imageSelector.FormattingEnabled = true;
            this.imageSelector.Location = new System.Drawing.Point(267, 198);
            this.imageSelector.Name = "imageSelector";
            this.imageSelector.Size = new System.Drawing.Size(138, 21);
            this.imageSelector.TabIndex = 42;
            this.imageSelector.SelectedValueChanged += new System.EventHandler(this.imageSelector_SelectedValueChanged);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(237, 197);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(24, 23);
            this.refresh.TabIndex = 43;
            this.refresh.Text = "🗘";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.imageSelector);
            this.Controls.Add(this.imageLeft);
            this.Controls.Add(this.imageRight);
            this.Controls.Add(this.colorDisplay);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.imageDisplay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.markerSize);
            this.Controls.Add(this.marker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lineWidth);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lineStyle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.ChannelList);
            this.Controls.Add(this.ChannelsLabel);
            this.Controls.Add(this.TestNameLabel);
            this.Controls.Add(this.TestName);
            this.Controls.Add(this.ColorPicker);
            this.Controls.Add(this.PlotOptionsLabel);
            this.Controls.Add(this.PlotXY);
            this.Controls.Add(this.PlotTime);
            this.Controls.Add(this.GetScreenshot);
            this.Controls.Add(this.GetData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(616, 405);
            this.MinimumSize = new System.Drawing.Size(616, 405);
            this.Name = "Form1";
            this.Text = "Oscilloscope";
            ((System.ComponentModel.ISupportInitialize)(this.lineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markerSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.Button GetScreenshot;
        private System.Windows.Forms.Button PlotTime;
        private System.Windows.Forms.Button PlotXY;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label PlotOptionsLabel;
        private System.Windows.Forms.Button ColorPicker;
        private System.Windows.Forms.TextBox TestName;
        private System.Windows.Forms.Label TestNameLabel;
        private System.Windows.Forms.Label ChannelsLabel;
        private System.Windows.Forms.CheckedListBox ChannelList;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lineStyle;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.NumericUpDown lineWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown markerSize;
        private System.Windows.Forms.ComboBox marker;
        private System.Windows.Forms.TextBox xlabel;
        private System.Windows.Forms.TextBox ylabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox imageDisplay;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button colorDisplay;
        private System.Windows.Forms.Button imageRight;
        private System.Windows.Forms.Button imageLeft;
        private System.Windows.Forms.ComboBox imageSelector;
        private System.Windows.Forms.Button refresh;
    }
}


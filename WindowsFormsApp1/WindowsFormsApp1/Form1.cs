using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using Utilities.Plot;
using MediaDevices;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const string DefaultTestName = "Test";

        public Form1()
        {
            InitializeComponent();

            ChannelList.Items.Clear();
            ChannelList.Items.Add(1);
            ChannelList.Items.Add(2);
            ChannelList.Items.Add(3);
            ChannelList.Items.Add(4);

            lineStyle.Items.Clear();
            lineStyle.Items.Add("solid");
            lineStyle.Items.Add("dotted");
            lineStyle.Items.Add("dashed");
            lineStyle.Items.Add("dashdot");
            lineStyle.SelectedItem = "solid";

            marker.Items.Clear();
            marker.Items.Add("none");
            marker.Items.Add(".");
            marker.Items.Add(",");
            marker.Items.Add("o");
            marker.Items.Add("+");
            marker.Items.Add("x");
            marker.SelectedItem = "none";

            Color defaultColor = ColorTranslator.FromHtml("#0072BD");
            colorDisplay.BackColor = defaultColor;
            colorDisplay.FlatAppearance.BorderColor = defaultColor;

            SelectXChannel(1);
            SelectYChannel(2);
        }

        private void GetData_Click(object sender, EventArgs e)
        {
            Device instrument = Device.phone; // Implement Oscilloscope

            if (current == string.Empty) Locate();
            string saveLocation = Path.Combine(current, TestName.Text == string.Empty ? DefaultTestName : TestName.Text, "Data");
            Directory.CreateDirectory(saveLocation);

            IEnumerable<MediaDevice> devices = MediaDevice.GetDevices();
            try
            {
                using (var device = devices.First(d => d.FriendlyName == instrument.deviceName))
                {
                    device.Connect();

                    for (int i = 0; i < ChannelList.CheckedItems.Count; ++i)
                    {
                        int channel = (int)ChannelList.CheckedItems[i];
                        string fileName = instrument.channelPrefix + channel + ".csv";
                        string path = Path.Combine(instrument.channelLocation, fileName);
                        if (device.FileExists(path))
                        {
                            device.DownloadFile(path, Path.Combine(saveLocation, fileName));
                        }
                        else
                        {
                            MessageBox.Show($"No Data Found for channel {channel}");
                        }
                    }
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No Devices Found");
            }
        }

        private void GetScreenshot_Click(object sender, EventArgs e)
        {
            Device instrument = Device.oscilloscopeRS2000; // Implement Oscilloscope

            if (current == string.Empty) Locate();
            string saveLocation = Path.Combine(current, TestName.Text == string.Empty ? DefaultTestName : TestName.Text);
            Directory.CreateDirectory(saveLocation);

            IEnumerable<MediaDevice> devices = MediaDevice.GetDevices();
            try
            {
                using (var device = devices.First(d => d.FriendlyName == instrument.deviceName))
                {
                    device.Connect();
                    string path = Path.Combine(instrument.screenshotLocation, instrument.screenshotName);
                    if (device.FileExists(path))
                    {
                        device.DownloadFile(path, Path.Combine(saveLocation, instrument.screenshotName));
                    }
                    else
                    {
                        MessageBox.Show("No Screenshot Found");
                    }
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No Devices Found");
            }
        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                colorDisplay.BackColor = color;
                colorDisplay.FlatAppearance.BorderColor = color;
            }
        }

        private void ChannelList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PlotTime_Click(object sender, EventArgs e)
        {
            if (current == string.Empty) Locate();

            PlotOptions options = PlotOptions.defaultOptions;
            ParsePlotOptions(ref options);

            string testName = TestName.Text == string.Empty ? DefaultTestName : TestName.Text;
            StringBuilder channels = new StringBuilder();
            string seperator = string.Empty;
            for (int i = 0; i < ChannelList.CheckedItems.Count; ++i, seperator = ",")
            {
                int channel = (int)ChannelList.CheckedItems[i];
                channels.Append(seperator + channel);
            }
            string[] cParams = new string[5]
            {
                Path.Combine(current, testName),
                testName,
                channels.ToString(),
                "\"{}\"",
                $"\"{JsonSerializer.Serialize(options).Replace("\"", "\\\"")}\""
            };

            // MessageBox.Show(string.Join(" ", cParams));

            //@"PythonScripts/Plot/dist/Plot.exe";
            ProcessStartInfo backend = new ProcessStartInfo(Path.Combine(System.Windows.Forms.Application.StartupPath, @"PythonScripts\Plot\dist\Plot.exe"));
            backend.Arguments = string.Join(" ", cParams);
            var proc = System.Diagnostics.Process.Start(backend);
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            Locate();
        }

        private void ParsePlotOptions(ref PlotOptions options)
        {
            if (title.Text != string.Empty) options.title = title.Text;
            if (xlabel.Text != string.Empty) options.xlabel = xlabel.Text;
            if (ylabel.Text != string.Empty) options.ylabel = ylabel.Text;
            options.Color = HexConverter(colorDisplay.BackColor);
            options.LineStyle = (string)lineStyle.SelectedItem;
            options.LineWidth = (float)lineWidth.Value;
            options.Marker = (string)marker.SelectedItem;
            options.MarkerSize = (float)markerSize.Value;
        }

        private static String HexConverter(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        string current = string.Empty;
        private void Locate()
        {
            FolderPicker fp = new FolderPicker();
            if (fp.ShowDialog(IntPtr.Zero) == true)
            {
                current = fp.ResultPath;
                LoadImages();
            }
            else current = string.Empty;
        }

        private struct ImageWrapper
        {
            public string fullName { get; set; }
            public string name { get; set; }
            public override string ToString()
            {
                return name;
            }
        }

        private void LoadImages()
        {
            string path = Path.Combine(current, TestName.Text, "plots");
            if (!Directory.Exists(path)) return;
            imageSelector.Items.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] files = dirInfo.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                imageSelector.Items.Add(new ImageWrapper()
                {
                    fullName = files[i].FullName,
                    name = files[i].Name
                });
            }
            if (imageSelector.Items.Count != 0) imageSelector.SelectedIndex = 0;
        }

        private void PlotXY_Click(object sender, EventArgs e)
        {
            if (current == string.Empty) Locate();

            PlotOptions options = PlotOptions.defaultOptions;
            ParsePlotOptions(ref options);

            Dictionary<string, string[]> combos = new Dictionary<string, string[]>();
            combos.Add(selectedXChannel, new string[1] { selectedYChannel });

            string testName = TestName.Text == string.Empty ? DefaultTestName : TestName.Text;
            string[] cParams = new string[5]
            {
                Path.Combine(current, testName),
                testName,
                "\"\"",
                $"\"{JsonSerializer.Serialize(combos).Replace("\"", "\\\"")}\"",
                $"\"{JsonSerializer.Serialize(options).Replace("\"", "\\\"")}\""
            };

            // MessageBox.Show(string.Join(" ", cParams));

            //@"PythonScripts/Plot/dist/Plot.exe";
            ProcessStartInfo backend = new ProcessStartInfo(Path.Combine(System.Windows.Forms.Application.StartupPath, @"PythonScripts\Plot\dist\Plot.exe"));
            backend.Arguments = string.Join(" ", cParams);
            var proc = System.Diagnostics.Process.Start(backend);
        }

        private string selectedXChannel;
        private void SelectXChannel(int channel)
        {
            selectedXChannel = channel.ToString();
            switch (channel)
            {
                case 1:
                    x1.Enabled = false;
                    x2.Enabled = true;
                    x3.Enabled = true;
                    x4.Enabled = true;
                    break;
                case 2:
                    x1.Enabled = true;
                    x2.Enabled = false;
                    x3.Enabled = true;
                    x4.Enabled = true;
                    break;
                case 3:
                    x1.Enabled = true;
                    x2.Enabled = true;
                    x3.Enabled = false;
                    x4.Enabled = true;
                    break;
                case 4:
                    x1.Enabled = true;
                    x2.Enabled = true;
                    x3.Enabled = true;
                    x4.Enabled = false;
                    break;
            }
        }

        private string selectedYChannel;
        private void SelectYChannel(int channel)
        {
            selectedYChannel = channel.ToString();
            switch (channel)
            {
                case 1:
                    y1.Enabled = false;
                    y2.Enabled = true;
                    y3.Enabled = true;
                    y4.Enabled = true;
                    break;
                case 2:
                    y1.Enabled = true;
                    y2.Enabled = false;
                    y3.Enabled = true;
                    y4.Enabled = true;
                    break;
                case 3:
                    y1.Enabled = true;
                    y2.Enabled = true;
                    y3.Enabled = false;
                    y4.Enabled = true;
                    break;
                case 4:
                    y1.Enabled = true;
                    y2.Enabled = true;
                    y3.Enabled = true;
                    y4.Enabled = false;
                    break;
            }
        }

        private void x1_Click(object sender, EventArgs e)
        {
            SelectXChannel(1);
        }

        private void x2_Click(object sender, EventArgs e)
        {
            SelectXChannel(2);
        }

        private void x3_Click(object sender, EventArgs e)
        {
            SelectXChannel(3);
        }

        private void x4_Click(object sender, EventArgs e)
        {
            SelectXChannel(4);
        }

        private void y1_Click(object sender, EventArgs e)
        {
            SelectYChannel(1);
        }

        private void y2_Click(object sender, EventArgs e)
        {
            SelectYChannel(2);
        }

        private void y3_Click(object sender, EventArgs e)
        {
            SelectYChannel(3);
        }

        private void y4_Click(object sender, EventArgs e)
        {
            SelectYChannel(4);
        }

        private void imageSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            imageDisplay.ImageLocation = ((ImageWrapper)imageSelector.SelectedItem).fullName;
            imageDisplay.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void imageLeft_Click(object sender, EventArgs e)
        {
            int index = (imageSelector.SelectedIndex - 1) % imageSelector.Items.Count;
            if (index < 0) index += imageSelector.Items.Count;
            imageSelector.SelectedIndex = index;
        }

        private void imageRight_Click(object sender, EventArgs e)
        {
            imageSelector.SelectedIndex = (imageSelector.SelectedIndex + 1) % imageSelector.Items.Count;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadImages();
        }

        private void imageDisplay_Click(object sender, EventArgs e)
        {
            // TODO:: open image in viewer
        }
    }
}

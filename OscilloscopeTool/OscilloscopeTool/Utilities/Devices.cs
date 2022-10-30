using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    struct Device
    {
        public enum Type
        { 
            oscilloscope
        }
        public string deviceName { get; set; }
        public string screenshotLocation { get; set; }
        public string screenshotName { get; set; }
        public string channelLocation { get; set; }
        public string channelPrefix { get; set; }

        public static Device oscilloscopeRS2000 = new Device  // Check Internal Storage
        {
            deviceName = @"Rohde&Schwarz RTB2002",
            screenshotLocation = @"Internal storage/Live Data",
            screenshotName = "SCREENSHOT.png",
            channelLocation = @"Internal storage/Live Data/Channel",
            channelPrefix = @"CH"
        };

        public static Device phone = new Device
        {
            deviceName = @"HUAWEI Mate X2",
            screenshotLocation = @"Internal storage/Live Data",
            screenshotName = "SCREENSHOT.png",
            channelLocation = @"Internal storage/Live Data/Channel",
            channelPrefix = @"CH"
        };
    }
}

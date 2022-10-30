using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Utilities.Plot
{
    struct PlotOptions
    {
        public string Color { get; set; }
        public string LineStyle { get; set; }
        public float LineWidth { get; set; }
        public string Marker { get; set; }
        public string MarkerEdgeColor { get; set; }
        public string MarkerFaceColor { get; set; }
        public float MarkerSize { get; set; }
        public string xlabel { get; set; }
        public string ylabel { get; set; }
        public string title { get; set; }

        public static PlotOptions defaultOptions = new PlotOptions
        {
            Color = "#0072BD",
            LineStyle = "-",
            LineWidth = 0.5f,
            Marker = "none",
            MarkerEdgeColor = "auto",
            MarkerFaceColor = "none",
            MarkerSize = 6,
            xlabel = "Default",
            ylabel = "Default",
            title = "Default",
        };
    }
}

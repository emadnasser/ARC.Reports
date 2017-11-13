using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using DevExpress.BarCodes;

namespace DevExpress.Web.Demos {
    public class BarCodeVisualizationModel {
        public BarCodeVisualizationModel() {
            BarCode = Symbology.Codabar;

            VertAlign = StringAlignment.Center;
            HorzAlign = StringAlignment.Center;
            BarCodeAngle = 0;
            BarCodeForeColor = Color.Black;
            BarCodeBackColor = Color.White;
            TopCaptionText = "top caption";
            TopCaptionAlignment = StringAlignment.Center;
            TopCaptionForeColor = Color.Black;
            BottomCaptionText = "bottom caption";
            BottomCaptionAlignment = StringAlignment.Center;
            BottomCaptionForeColor = Color.Black;
        }

        public string[] FontFamilyNames = new string[] {
            "Arial",
            "Arial Black",
            "Comic Sans MS",
            "Courier New",
            "Georgia",
            "Lucida Sans Unicode",
            "Times New Roman",
            "Trebuchet MS",
            "Verdana",
            "MS Mincho",
            "MS PMincho",
            "SimSun",
            "SimSun-ExtB",
            "Calibri",
        };
        
        public Symbology BarCode { get; set; }
        public bool ShowViewText { get; set; }
        public string BarCodeText { get; set; }
        public StringAlignment VertAlign { get; set; }
        public StringAlignment HorzAlign { get; set; }
        public string FontName { get; set; }
        public int BarCodeAngle { get; set; }
        public Color BarCodeForeColor { get; set; }
        public Color BarCodeBackColor { get; set; }
        public bool ShowTopCaption { get; set; }
        public string TopCaptionText { get; set; }
        public StringAlignment TopCaptionAlignment { get; set; }
        public Color TopCaptionForeColor { get; set; }
        public string TopCaptionFontName { get; set; }
        public bool ShowBottomCaption { get; set; }
        public string BottomCaptionText { get; set; }
        public StringAlignment BottomCaptionAlignment { get; set; }
        public Color BottomCaptionForeColor { get; set; }
        public string BottomCaptionFontName { get; set; }
        public string Description { get; private set; }

        public void SetDescription(string desc) {
            Description = desc;
        }
    }

}

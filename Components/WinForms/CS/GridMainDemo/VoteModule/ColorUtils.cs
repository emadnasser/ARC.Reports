using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DevExpress.VoteApp {
    public class HSLColor {
        const double scale = 240.0;
        double hue = 1.0;
        double saturation = 1.0;
        double luminosity = 1.0;
        public HSLColor() { }
        public HSLColor(Color color) : this(color.R, color.G, color.B) { }
        public HSLColor(int red, int green, int blue) {
            SetRGB(red, green, blue);
        }
        public HSLColor(double hue, double saturation, double luminosity) {
            this.Hue = hue;
            this.Saturation = saturation;
            this.Luminosity = luminosity;
        }
        public static Color Darken(Color color, double amount) { //0..1
            HSLColor hslColor = new HSLColor(color);
            hslColor.Luminosity *= amount; 
            return hslColor;
        }
        public static Color Lighter(Color color, double amount) { //1..2
            HSLColor hslColor = new HSLColor(color);
            hslColor.Luminosity *= amount;
            return hslColor;
        }
        public double Hue {
            get { return hue * scale; }
            set { hue = Check(value / scale); }
        }
        public double Saturation {
            get { return saturation * scale; }
            set { saturation = Check(value / scale); }
        }
        public double Luminosity {
            get { return luminosity * scale; }
            set { luminosity = Check(value / scale); }
        }
        double Check(double value) {
            if(value < 0.0)
                value = 0.0;
            else if(value > 1.0)
                value = 1.0;
            return value;
        }
        public void SetRGB(int red, int green, int blue) {
            HSLColor hslColor = (HSLColor)Color.FromArgb(red, green, blue);
            this.hue = hslColor.hue;
            this.saturation = hslColor.saturation;
            this.luminosity = hslColor.luminosity;
        }

        public override string ToString() {
            return String.Format("H: {0:#0.##} S: {1:#0.##} L: {2:#0.##}", Hue, Saturation, Luminosity);
        }

        public static implicit operator Color(HSLColor hslColor) {
            double r = 0, g = 0, b = 0;
            if(hslColor.luminosity != 0) {
                if(hslColor.saturation == 0)
                    r = g = b = hslColor.luminosity;
                else {
                    double temp2 = GetTemp2(hslColor);
                    double temp1 = 2.0 * hslColor.luminosity - temp2;

                    r = GetColorComponent(temp1, temp2, hslColor.hue + 1.0 / 3.0);
                    g = GetColorComponent(temp1, temp2, hslColor.hue);
                    b = GetColorComponent(temp1, temp2, hslColor.hue - 1.0 / 3.0);
                }
            }
            return Color.FromArgb((int)(255 * r), (int)(255 * g), (int)(255 * b));
        }

        static double GetColorComponent(double temp1, double temp2, double temp3) {
            temp3 = MoveIntoRange(temp3);
            if(temp3 < 1.0 / 6.0)
                return temp1 + (temp2 - temp1) * 6.0 * temp3;
            else if(temp3 < 0.5)
                return temp2;
            else if(temp3 < 2.0 / 3.0)
                return temp1 + ((temp2 - temp1) * ((2.0 / 3.0) - temp3) * 6.0);
            else
                return temp1;
        }
        static double MoveIntoRange(double temp3) {
            if(temp3 < 0.0)
                temp3 += 1.0;
            else if(temp3 > 1.0)
                temp3 -= 1.0;
            return temp3;
        }
        static double GetTemp2(HSLColor hslColor) {
            double temp2;
            if(hslColor.luminosity < 0.5)  
                temp2 = hslColor.luminosity * (1.0 + hslColor.saturation);
            else
                temp2 = hslColor.luminosity + hslColor.saturation - (hslColor.luminosity * hslColor.saturation);
            return temp2;
        }

        public static implicit operator HSLColor(Color color) {
            HSLColor hslColor = new HSLColor();
            hslColor.hue = color.GetHue() / 360.0; 
            hslColor.luminosity = color.GetBrightness();
            hslColor.saturation = color.GetSaturation();
            return hslColor;
        }

    }
}

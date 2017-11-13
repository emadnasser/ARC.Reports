using System;
using System.Drawing;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	public class ColorMaker {
		private Color startColor, endColor;

		internal ColorMaker() {
			startColor = SystemColors.ControlDark;
			endColor = SystemColors.Window;
		}

		internal ColorMaker(Color StartColor,Color EndColor) {
			startColor = StartColor;
			endColor = EndColor;
		}

		internal Color ProduceColor(int Brightness) {
			Color c;
			int r, g, b, a;

			if(Brightness > 100)
				Brightness = 100;

			if(Brightness < 0)
				Brightness = 0;

			r = startColor.R + (endColor.R - startColor.R) * Brightness / 100;
			g = startColor.G + (endColor.G - startColor.G) * Brightness / 100;
			b = startColor.B + (endColor.B - startColor.B) * Brightness / 100;
			a = startColor.A + (endColor.A - startColor.A) * Brightness / 100;

			c = Color.FromArgb(a, r, g, b);

			return c;
		}
	}
}

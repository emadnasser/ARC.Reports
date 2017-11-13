﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public static class ColorEditorDemoHelper {
        const int CountColors = 40;

        public static ColorEditorDemoOptions Options { get; set; }
        public static Action<ColorEditSettings> ColorEditSettingsMethod {
            get {
                return CreateColorEditSettingsMethod();
            }
        }
        public static List<SelectListItem> GetPalettes() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = Palette.Default.ToString(), Value = Palette.Default.ToString(), Selected = true },
                new SelectListItem() { Text = Palette.Gray.ToString(), Value = Palette.Gray.ToString()},
                new SelectListItem() { Text = Palette.Red.ToString(), Value = Palette.Red.ToString()},
                new SelectListItem() { Text = Palette.Green.ToString(), Value = Palette.Green.ToString()},
                new SelectListItem() { Text = Palette.Blue.ToString(), Value = Palette.Blue.ToString()}
            };
        }
        public static List<SelectListItem> GetColumnCountList() {
            List<SelectListItem> listColumnCount = new List<SelectListItem>();
            for(int i = 10; i < 30; i += 5) {
                listColumnCount.Add(new SelectListItem() { Text = i.ToString(), Value = i.ToString() });
            }

            return listColumnCount;
        }
        public static ColorEditItemCollection CreatePalette(Palette typePalette) {
            ColorEditItemCollection palette = new ColorEditItemCollection();

            if(typePalette == Palette.Default)
                palette.CreateDefaultItems(true);
            else {
                int step = 256 / CountColors;

                for(int i = 0; i < CountColors; i++)
                    palette.Add(GetHue(typePalette, i * step));
            }

            return palette;
        }

        static Color GetHue(Palette typePalette, int value) {
            Color color = Color.Empty;
            switch(typePalette) {
                case Palette.Red:
                    color = Color.FromArgb(value, 0, 0);
                    break;
                case Palette.Green:
                    color = Color.FromArgb(0, value, 0);
                    break;
                case Palette.Blue:
                    color = Color.FromArgb(0, 0, value);
                    break;
                case Palette.Gray:
                    color = Color.FromArgb(value, value, value);
                    break;
            }
            return color;
        }
        static Action<ColorEditSettings> CreateColorEditSettingsMethod() {
            return settings => {
                settings.Properties.EnableCustomColors = Options.EnableCustomColors;
                settings.Properties.ColumnCount = Options.ColumnCount;
                settings.Properties.Items.Assign(ColorEditorDemoHelper.CreatePalette(Options.Palettes));
            };
        }
    }
}

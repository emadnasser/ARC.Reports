using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace DevExpress.Web.Demos {
    public class BinaryImageDemoOptions {
        public BinaryImageDemoOptions() {
            AvalibleSizes = GenerateAvalibleSizes();
        }
        public ImageSizeMode ImageSizeMode { get; set; }
        private string sizeKey = "640x480";
        public string ImageSize {
            get {
                return sizeKey;
            }
            set {
                sizeKey = value;
            }
        }
        public Unit Width { get { return AvalibleSizes[ImageSize].Width; } }
        public Unit Height { get { return AvalibleSizes[ImageSize].Height; } }

        public IDictionary<string, BinaryImageDemoSize> AvalibleSizes { get; private set; }

        static IDictionary<string, BinaryImageDemoSize> GenerateAvalibleSizes() {
            return new Dictionary<string, BinaryImageDemoSize> {
                { "640x480", new BinaryImageDemoSize { Width = 640, Height = 480, Text = "640 x 480 px" }},
                { "400x400", new BinaryImageDemoSize { Width = 400, Height = 400, Text = "400 x 400 px" }},
                { "300x0", new BinaryImageDemoSize { Width = 300, Height = 0, Text = "Width = 300 px" }}
            };
        }
    }
    public class BinaryImageDemoSize {
        public string Text { get; set; }
        public Unit Width { get; set; }
        public Unit Height { get; set; }
    }
}

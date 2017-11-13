using DevExpress.Demos.OpenWeatherService;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DevExpress.XtraMap.Demos {
    /// <summary>
    /// Summary description for DemoUtils.
    /// </summary>
    public class DemoUtils {
        const string key = DevExpress.Map.Native.DXBingKeyVerifier.BingKeyWinMapMainDemo;
        public static string ComplexDateExpression { get { return @"CONVERT(CONVERT(yr, 'System.String') + '/' + CONVERT(mon, 'System.String') + '/' + CONVERT(day, 'System.String') + ' ' + CONVERT(hr, 'System.String') + ':' + CONVERT(min, 'System.String'), 'System.DateTime')"; } }

        public static XDocument LoadXml(string name) {
            try {
                return XDocument.Load("file:\\\\" + GetRelativePath(name));
            } catch {
                return null;
            }
        }
        internal static void SetBingMapDataProviderKey(BingMapDataProvider provider) {
            if(provider != null) provider.BingKey = key;
        }
        internal static void SetBingMapDataProviderKey(BingMapDataProviderBase provider) {
            if(provider != null) provider.BingKey = key;
        }
        public static string GetRelativePath(string name) {
            name = "Data\\" + name;
            string path = System.Windows.Forms.Application.StartupPath;
            string s = "\\";
            for (int i = 0; i <= 10; i++) {
                if (System.IO.File.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            return "";
        }
        public static string GetRelativeDirectoryPath(string name) {
            name = "Data\\" + name;
            string path = System.Windows.Forms.Application.StartupPath;
            string s = "\\";
            for (int i = 0; i <= 10; i++) {
                if (System.IO.Directory.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            return "";
        }
        public static Image GetBackGroundImage(MapControl map, Rectangle galleryRect, float opacity) {
            using (MemoryStream stream = new MemoryStream()) {
                try {
                    map.ExportToImage(stream, ImageFormat.Png);
                    using (Image image = Image.FromStream(stream)) {
                        Bitmap result = new Bitmap(galleryRect.Width, galleryRect.Height);
                        using (Graphics g = Graphics.FromImage(result)) {
                            ColorMatrix matrix = new ColorMatrix() { Matrix33 = opacity };
                            ImageAttributes attributes = new ImageAttributes();
                            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                            g.DrawImage(image, new Rectangle(0, 0, result.Width, result.Height), galleryRect.X, galleryRect.Y, galleryRect.Width, galleryRect.Height, GraphicsUnit.Pixel, attributes);
                        }
                        return result;
                    }
                } catch {
                    return null;
                }
            }
        }
        public static Image GetInflatedImage(string imageUri, int inflateX, int inflateY) {
            using (Image image = Image.FromFile(imageUri)) {
                Rectangle rect = new Rectangle(new Point(0, 0), image.Size);
                rect.Inflate(inflateX, inflateY);
                Bitmap result = new Bitmap(rect.Width, rect.Height);
                using (Graphics g = Graphics.FromImage(result)) {
                    g.FillRectangle(Brushes.White, new Rectangle(0, 0, result.Width, result.Height));
                    g.DrawImage(image, new Rectangle(inflateX, inflateY, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
                    return result;
                }
            }
        }
        public static object[] GetOSMBaseLayers() {
            List<object> result = new List<object>();
            result.Add(OpenStreetMapKind.Basic);
            result.Add(OpenStreetMapKind.CycleMap);
            result.Add(OpenStreetMapKind.Hot);
            result.Add(OpenStreetMapKind.GrayScale);
            result.Add(OpenStreetMapKind.Transport);
            return result.ToArray();
        }
        public static object[] GetOSMOverlays() {
            List<object> result = new List<object>();
            result.Add("None");
            result.Add(OpenStreetMapKind.SeaMarks);
            result.Add(OpenStreetMapKind.HikingRoutes);
            result.Add(OpenStreetMapKind.CyclingRoutes);
            result.Add(OpenStreetMapKind.PublicTransport);
            return result.ToArray();
        }
        public static Dictionary<String, Image> CreateFlagsDictionary() {
            Dictionary<String, Image> flags = new Dictionary<string, Image>();
            String path = DemoUtils.GetRelativeDirectoryPath("\\Images\\Flags");
            string[] fileEntries = string.IsNullOrEmpty(path) ? new string[0] : Directory.GetFiles(path).Where(entry => entry.EndsWith(".png")).ToArray();
            foreach(string fileName in fileEntries) {
                string key = fileName.Substring(fileName.LastIndexOf(@"\") + 1).Remove(2, 4);
                flags.Add(key, Image.FromFile(fileName));
            }
            return flags;
        }
        public static Image GetRotatedImage(Image inputImage, double angleDegrees) {
            Color backgroundColor = Color.Transparent;
            bool upsizeOk = false;
            bool clipOk = true;
            if(angleDegrees == 0f)
                return (Bitmap)inputImage.Clone();

            int oldWidth = inputImage.Width;
            int oldHeight = inputImage.Height;
            int newWidth = oldWidth;
            int newHeight = oldHeight;
            float scaleFactor = 1f;

            if(upsizeOk || !clipOk) {
                double angleRadians = angleDegrees * Math.PI / 180d;
                double cos = Math.Abs(Math.Cos(angleRadians));
                double sin = Math.Abs(Math.Sin(angleRadians));
                newWidth = (int)Math.Round(oldWidth * cos + oldHeight * sin);
                newHeight = (int)Math.Round(oldWidth * sin + oldHeight * cos);
            }
            if(!upsizeOk && !clipOk) {
                scaleFactor = Math.Min((float)oldWidth / newWidth, (float)oldHeight / newHeight);
                newWidth = oldWidth;
                newHeight = oldHeight;
            }
            Bitmap newBitmap = new Bitmap(newWidth, newHeight, backgroundColor == Color.Transparent ?
                                             PixelFormat.Format32bppArgb : PixelFormat.Format24bppRgb);
            newBitmap.SetResolution(inputImage.HorizontalResolution, inputImage.VerticalResolution);
            using(Graphics graphicsObject = Graphics.FromImage(newBitmap)) {
                graphicsObject.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsObject.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphicsObject.SmoothingMode = SmoothingMode.HighQuality;
                if(backgroundColor != Color.Transparent)
                    graphicsObject.Clear(backgroundColor);
                graphicsObject.TranslateTransform(newWidth / 2f, newHeight / 2f);
                if(scaleFactor != 1f)
                    graphicsObject.ScaleTransform(scaleFactor, scaleFactor);
                graphicsObject.RotateTransform((float)angleDegrees);
                graphicsObject.TranslateTransform(-oldWidth / 2f, -oldHeight / 2f);
                graphicsObject.DrawImage(inputImage, 0, 0);
            }
            return newBitmap;
        }
    }
    public class DemoWeatherItemFactory : DefaultMapItemFactory {
        protected override void InitializeItem(MapItem item, object obj) {
            CityWeather cityWeather = obj as CityWeather;
            MapCustomElement element = item as MapCustomElement;
            if (element == null || cityWeather == null) 
                return;
            element.ImageUri = new Uri(cityWeather.WeatherIconPath);
        }
    }
    public class InvariantImageRepositoryItem : RepositoryItemCheckEdit {
        protected override Image TransformPicture(Image image) {
            return image;
        }
    }
    public class HotelRoomTooltipHelper {
        HotelImagesGenerator imageGenerator = new HotelImagesGenerator();
        SuperToolTip superToolTip = new SuperToolTip();
        ToolTipTitleItem titleItem = new ToolTipTitleItem();
        ToolTipItem contentItem = new ToolTipItem() { ImageToTextDistance = 0 };

        public HotelRoomTooltipHelper() {
            this.superToolTip.Items.Add(titleItem);
            this.superToolTip.Items.Add(contentItem);
        }

        string CalculateTitle(int category, string tooltip) {
            return category == 4 ? string.Format("Room: {0}", tooltip) : tooltip;
        }
        public SuperToolTip CalculateSuperTooltip(MapItem item, string tooltip) {
            if (item == null)
                return null;
            MapItemAttribute attr = item.Attributes["CATEGORY"];
            if(attr == null)
                return null;
            titleItem.Text = CalculateTitle((int)attr.Value, tooltip);
            attr = item.Attributes["IMAGE"];
            contentItem.Image = attr != null ? (Image)attr.Value : imageGenerator.GetItemImage(item);
            return superToolTip;
        }
        public void UpdateHotelIndex(int index) {
            imageGenerator.HotelIndex = index;
        }
    }
    public class HotelImagesGenerator {
        class PathsIndexPair {
            public string[] Paths { get; set; }
            public int Index { get; set; }
        }

        const int ImageWidth = 200;
        static readonly string[] Categories = new string[] { "Restaurant", "MeetingRoom", "Bathroom", "Bedroom", "Outofdoors", "ServiceRoom", "Pool", "Lobby" };

        int hotelIndex = 0;
        List<PathsIndexPair> filesWithIndices = new List<PathsIndexPair>();
        
        public int HotelIndex {
            get { return hotelIndex; }
            set {
                hotelIndex = value;
                UpdateIndices();
            }
        }
        
        public HotelImagesGenerator() {
            foreach (string category in Categories)
                filesWithIndices.Add(new PathsIndexPair() { Index = 0, Paths = GetAvailableFiles(category) });
        }
        void UpdateIndices() {
            filesWithIndices[0].Index = hotelIndex * 2;
            filesWithIndices[1].Index = 0;
            filesWithIndices[2].Index = hotelIndex * 4;
            filesWithIndices[6].Index = hotelIndex;
        }
        string[] GetAvailableFiles(string category) {
            string path = DemoUtils.GetRelativeDirectoryPath("\\Images\\Hotels\\");
            return Directory.GetFiles(path).Where(p => p.StartsWith(path + category)).ToArray();
        }
        Image GetImage(int category, string name, int roomCat) {
            if(category == 4)
                filesWithIndices[3].Index = roomCat;
            return GetCategoryImage(filesWithIndices[category - 1]);
        }
        Image GetCategoryImage(PathsIndexPair pathsWithIndex) {
            if (pathsWithIndex.Paths.Length == 0)
                return null;
            int index = pathsWithIndex.Index % pathsWithIndex.Paths.Length;
            pathsWithIndex.Index++;
            return new Bitmap(pathsWithIndex.Paths[index]);
        }
        Image ScaleImage(Image srcImg) {
            double ratio = (double)srcImg.Width / srcImg.Height;
            int newHeight = (int)((double)ImageWidth / ratio);
            Image resImg = new Bitmap(ImageWidth, newHeight);
            Graphics.FromImage(resImg).DrawImage(srcImg, 0, 0, ImageWidth, newHeight);
            return resImg;
        }
        public Image GetItemImage(MapItem item) {
            Image image = GetImage((int)item.Attributes["CATEGORY"].Value, item.Attributes["NAME"].Value.ToString(), (int)item.Attributes["ROOMCAT"].Value);
            if (image == null)
                return null;
            image = ScaleImage(image);
            item.Attributes.Add(new MapItemAttribute() { Name = "IMAGE", Value = image });
            return image;
        }
    }
    public static class ColorHelper {
        public static void UpdateColor(Image image, UserLookAndFeel lookAndFeel) {
            Color foreColor = GetForeColor(lookAndFeel);
            SetColor((Bitmap)image, foreColor);
        }
        public static Color GetForeColor(UserLookAndFeel lookAndFeel) {
            Color ret = SystemColors.ControlText;
            if(lookAndFeel.ActiveStyle != ActiveLookAndFeelStyle.Skin) return ret;
            return MapSkins.GetSkin(lookAndFeel).Properties.GetColor(MapSkins.PropPanelTextColor);
        }
        static void SetColor(Bitmap bmp, Color color) {
            for(int i = 0; i < bmp.Width; i++)
                for(int j = 0; j < bmp.Height; j++)
                    if(bmp.GetPixel(i, j).A > 0)
                        bmp.SetPixel(i, j, color);
        }
    }
    public class FlagsRepository {
        Dictionary<string, Image> calloutImages = new Dictionary<string, Image>();
        Dictionary<string, Image> gridImages = new Dictionary<string, Image>();

        public FlagsRepository() {
            calloutImages = DemoUtils.CreateFlagsDictionary();
            gridImages = DemoUtils.CreateFlagsDictionary();
        }

        public Image GetFlag(string country, bool forCallout) {
            return forCallout ? calloutImages[country] : gridImages[country];
        }
        public bool Contains(string country) {
            return calloutImages.ContainsKey(country);
        }
    }
}

using DevExpress.Utils;
using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace DevExpress.VoteApp {
    public class Helpers {
        public const string USMap = "USAStates.shp";
        public const string USCountyMap = "USACounties.shp";
        public const string DataFolder = "data\\voteappdata\\";
        public static string FindFile(string fileName) {
            return FilesHelper.FindingFileName(Application.StartupPath, DataFolder + fileName);
        }
        static string GetCandidatePhotoName(string name) {
            switch(name.ToLower()) {
                case "barack obama": return "BarackObama.jpg";
                case "mitt romney": return "MittRomney.jpg";
                case "donald trump": return "DonaldTrump.jpg";
                case "hillary clinton": return "HillaryClinton.jpg";
            }
            return null;
        }
        static Bitmap GetCachedImage(string name) {
            return cachedImages.ContainsKey(name) ? cachedImages[name] : null;
        }
        static Bitmap UpdateCachedImage(string name, Bitmap image) {
            cachedImages[name] = image;
            return image;
        }
        static Dictionary<string, Bitmap> cachedImages = new Dictionary<string, Bitmap>();
        public static Bitmap GetCandidatePhoto(string name) {
            var res = GetCachedImage(name);
            if(res != null) return res;
            var file = GetCandidatePhotoName(name);
            if(file == null) return null;
            file = FindFile(file);
            if(!File.Exists(file)) return null;
            return UpdateCachedImage(name, (Bitmap)Bitmap.FromFile(file));
        }
        public static string GetUSMap(bool dbf = false) {
            string fileName = dbf ? Path.GetFileNameWithoutExtension(USMap) + ".dbf" : USMap;
            return FindFile(fileName);
        }
        public static string GetUSCountyMap(bool dbf = false) {
            string fileName = dbf ? Path.GetFileNameWithoutExtension(USCountyMap) + ".dbf": USCountyMap;
            return FindFile(fileName);
        }
        public static void SaveToJSON(object data, string fileName) {
            var json = new JavaScriptSerializer().Serialize(data);
            using(var sw = new StreamWriter(fileName, false)) {
                sw.WriteLine(json);
            }

        }
        public static T LoadFromJSON<T>(string fileName) {
            if(!File.Exists(fileName)) return default(T);
            var data = "";
            using(var sr = new StreamReader(fileName)) {
                data = sr.ReadToEnd();
            }
            return new JavaScriptSerializer().Deserialize<T>(data);
        }
        public static decimal GetPercent(int value, int total) {
            if(total == 0 || value == 0) return 0;
            return value / (decimal)total;
        }
    }
    public class VoteHelpers {
        public const string US2012Results = @"US2012Results.json";
        public const string US2016Results = @"US2016Results.json";
        public static ElectionData LoadResults2012() {
            string data = Helpers.FindFile(US2012Results);
            if(string.IsNullOrEmpty(data)) return null;
            return Helpers.LoadFromJSON<ElectionData>(data);
        }
        public static ElectionData LoadResults2016() {
            string data = Helpers.FindFile(US2016Results);
            if(string.IsNullOrEmpty(data)) return null;
            return Helpers.LoadFromJSON<ElectionData>(data);
        }
    }
    public class LoadedMapInfo {
        public LoadedMapInfo() {
            AllItems = new List<MapItem>();
            VisibleItems = new List<MapItem>();
        }
        public List<MapItem> AllItems { get; set; }
        public List<MapItem> VisibleItems { get; set; }
        public VectorItemsLayer Layer { get; set; }
        public MapItemStorage VisibleItemsStorage { get; set; }
        internal void SetupVisibleItemsLayerStorage() {
            DestroyStorage();
            VisibleItemsStorage = new MapItemStorage();
            VisibleItemsStorage.Items.AddRange(VisibleItems);
            Layer.Data = VisibleItemsStorage;
        }

        internal void DestroyStorage() {
            if(Layer != null) Layer.Data = null;
            if(VisibleItemsStorage != null) {
                VisibleItemsStorage.Items.Clear();
                VisibleItemsStorage.Dispose();
                VisibleItemsStorage = null;
                FixMapBug(VisibleItems);
                VisibleItems.Clear();
            }
        }

        private void FixMapBug(List<MapItem> visibleItems) {
            foreach(var item in visibleItems) {
                var fi = typeof(MapShape).GetField("title", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                if(fi != null) fi.SetValue(item, null);
            }
        }

        internal void DestroyLayer() {
            if(Layer != null) {
                Layer.Dispose();
                Layer = null;
            }
        }
    }
    public class MouseEventSourceInfo {
        public enum MouseEventSource { Mouse, Touch, Pen }
        [DllImport("user32.dll")]
        static extern uint GetMessageExtraInfo();
        public static MouseEventSource GetMouseEventSource() {
            uint info = GetMessageExtraInfo();
            bool penOrTouch = ((info & SIGNATURE_MASK) == MI_WP_SIGNATURE);
            if(!penOrTouch) return MouseEventSource.Mouse;
            return ((info & TOUCH_MASK) == TOUCH_MASK) ? MouseEventSource.Touch : MouseEventSource.Pen;
        }
        public static bool IsTouchEvent() {
            return GetMouseEventSource() == MouseEventSource.Touch;
        }
        const uint TOUCH_MASK = 0x80;
        const uint MI_WP_SIGNATURE = 0xFF515700;
        const uint SIGNATURE_MASK = 0xFFFFFF00;
    }

}

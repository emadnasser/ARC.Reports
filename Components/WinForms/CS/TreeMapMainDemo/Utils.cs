using System.Data;
using System.Drawing;

namespace DevExpress.XtraTreeMap.Demos {
    public static class Utils {
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
        public static DataTable CreateDataSet(string xmlFileName) {
            string filePath = Utils.GetRelativePath(xmlFileName);
            if (!string.IsNullOrWhiteSpace(filePath)) {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(filePath);
                if (dataSet.Tables.Count > 0)
                    return dataSet.Tables[0];
            }
            return null;
        }
        public static readonly Color[] SelectionPalette = {
            Color.FromArgb(170, 97, 150, 211),
            Color.FromArgb(170, 234, 127, 56),
            Color.FromArgb(170, 252, 195, 25),
            Color.FromArgb(170, 76, 107, 194),
            Color.FromArgb(170, 111, 174, 73),
            Color.FromArgb(170, 48, 91, 143),
            Color.FromArgb(170, 155, 76, 26),
            Color.FromArgb(170, 150, 117, 10),
            Color.FromArgb(170, 46, 66, 119),
            Color.FromArgb(170, 68, 105, 47),
            Color.FromArgb(170, 127, 171, 220),
            Color.FromArgb(170, 238, 153, 92),
            Color.FromArgb(170, 252, 208, 58),
            Color.FromArgb(170, 103, 129, 195)
        };
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using DevExpress.Utils;

namespace XtraPrintingDemos.Tutorial1 {
    public static class TutorialHelper {
        static string GetRelativePathCore(string name) {
            return FilesHelper.FindingFileName(Application.StartupPath, "Data\\" + name);
        }
        public static string GetRelativePath(string path) {
            if(Assembly.GetEntryAssembly() != Assembly.GetExecutingAssembly())
                return path;
            int index = path.LastIndexOf(@"\") + 1;
            return GetRelativePathCore(path.Substring(index));
        }

        public static Image CreateImage(byte[] b) {
            if(b == null || b.Length == 0) return null;
            using(MemoryStream s = new MemoryStream(b)) {
                try {
                    return Image.FromStream(s);
                } catch(ArgumentException) {
                    return null;
                }
            }
        }

        public static class ProductsHelper {
            const string NameColumn = "ProductName";
            const string PriceColumn = "UnitPrice";
            const string DiscontinuedColumn = "Discontinued";
            const string IconColumn = "Icon_25";
            static DataView currentData;
            static Dictionary<ProductColumn, RectangleF> columns = new Dictionary<ProductColumn, RectangleF>(4);

            static ProductsHelper() {
                const float Height = 26f;
                float left = 0f;
                foreach(ProductColumn column in Enum.GetValues(typeof(ProductColumn))) {
                    float width = 0f;
                    switch(column) {
                        case ProductColumn.Name:
                            width = 325f;
                            break;

                        case ProductColumn.Price:
                            width = 100f;
                            break;

                        case ProductColumn.Discontinued:
                            width = 123f;
                            break;

                        case ProductColumn.Icon:
                            width = 75f;
                            break;
                    }

                    columns[column] = new RectangleF(left, 0f, width, Height);
                    left += width;
                }
            }

            static DataView Data {
                get {
                    if(currentData == null) {
                        using(DataSet ds = new DataSet()) {
                            ds.ReadXml(GetRelativePath(@"..\..\..\Data\ProductsForPrintingLessons.xml"));
                            using(DataViewManager dvm = new DataViewManager(ds))
                                currentData = dvm.CreateDataView(ds.Tables[0]);
                        }
                    }

                    return currentData;
                }
            }

            static Dictionary<int, Image> images = new Dictionary<int, Image>();
            static Image GetDataIconByIndex(int index) {
                Image result = null;
                if(!images.TryGetValue(index, out result)) {
                    using(MemoryStream stream = new MemoryStream(Data[index][IconColumn] as byte[]))
                        images.Add(index, Image.FromStream(stream));
                }
                return result;
            }

            public static Product GetProductByIndex(int index) {
                index = index % Data.Count;
                DataRowView row = Data[index];
                return new Product(
                    row[NameColumn] as string,
                    (decimal)row[PriceColumn],
                    (bool)row[DiscontinuedColumn],
                    GetDataIconByIndex(index));
            }

            public enum ProductColumn {
                Name,
                Price,
                Discontinued,
                Icon,
            }

            public static RectangleF GetBoundsForColumn(ProductColumn column) {
                RectangleF result = RectangleF.Empty;
                columns.TryGetValue(column, out result);
                return result;
            }

            public struct Product {
                string _name;
                decimal _price;
                bool _discontinued;
                Image _icon;

                public Product(string name, decimal price, bool discontinued, Image icon) {
                    _name = name;
                    _price = price;
                    _discontinued = discontinued;
                    _icon = icon;
                }

                public string Name {
                    get { return _name; }
                }
                public decimal Price {
                    get { return _price; }
                }
                public bool Discontinued {
                    get { return _discontinued; }
                }
                public Image Icon {
                    get { return _icon; }
                }
            }
        }
    }
}

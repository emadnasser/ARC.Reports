using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for ColumnFormat.
    /// </summary>
    public partial class ColumnFormat : TutorialControl {
        public ColumnFormat() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        //<treeList1>
        private void InitData() {
            FillData();
            CreateColumn(treeList1, "Currency format", "Payment", 0, DevExpress.Utils.FormatType.Numeric, "c");
            CreateColumn(treeList1, "Hexadecimal format", "Lenght", 1, DevExpress.Utils.FormatType.Numeric, "x");
            CreateColumn(treeList1, "LongDate format", "PurchaseDate", 2, DevExpress.Utils.FormatType.DateTime, "D");
            CreateColumn(treeList1, "Custom Format", "Number", 3, DevExpress.Utils.FormatType.Custom, "B2");
            treeList1.BestFitColumns();
        }

        private void CreateColumn(TreeList tl, string caption, string field, int visibleindex, DevExpress.Utils.FormatType formatType, string formatString) {
            DevExpress.XtraTreeList.Columns.TreeListColumn col = tl.Columns.Add();
            col.Caption = caption;
            col.FieldName = field;
            col.VisibleIndex = visibleindex;
            col.Format.FormatType = formatType;
            if(formatType == DevExpress.Utils.FormatType.Custom)
                col.Format.Format = new BaseFormatter();
            col.Format.FormatString = formatString;
        }
        //</treeList1>

        private void FillData() {
            ColumnFormatRecord[] records = new ColumnFormatRecord[5];
            records[0] = new ColumnFormatRecord(32.35, 100000, DateTime.Parse("5/3/1999", System.Globalization.CultureInfo.InvariantCulture), 10);
            records[1] = new ColumnFormatRecord(20, 65535, DateTime.Parse("10/7/2001", System.Globalization.CultureInfo.InvariantCulture), 65);
            records[2] = new ColumnFormatRecord(100.99, 9999999999, DateTime.Now, 100);
            records[3] = new ColumnFormatRecord(250.5, 10, DateTime.Parse("12/1/2003", System.Globalization.CultureInfo.InvariantCulture), 20);
            records[4] = new ColumnFormatRecord(15, 0, DateTime.Parse("7/7/2002", System.Globalization.CultureInfo.InvariantCulture), 4);

            treeList1.DataSource = records;
        }

        private void ColumnFormat_Load(object sender, System.EventArgs e) {
            treeList1.BestFitColumns();
        }
    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for RowFormat.
    /// </summary>
    public partial class RowFormat : TutorialControl {
        public RowFormat() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        //<vGridControl1>
        private void RowFormat_Load(object sender, System.EventArgs e) {
            InitData();
        }

        private void InitData() {
            FillData();
            CreateRow(vGridControl1, "Currency format", "Payment", 0, DevExpress.Utils.FormatType.Numeric, "c");
            CreateRow(vGridControl1, "Hexadecimal format", "Length", 1, DevExpress.Utils.FormatType.Numeric, "x");
            CreateRow(vGridControl1, "LongDate format", "PurchaseDate", 2, DevExpress.Utils.FormatType.DateTime, "D");
            CreateRow(vGridControl1, "Custom Format", "Number", 3, DevExpress.Utils.FormatType.Custom, "B2");
            vGridControl1.RecordWidth = 150;
        }

        private void CreateRow(VGridControl vg, string caption, string field, int visibleindex, DevExpress.Utils.FormatType formatType, string formatString) {
            DevExpress.XtraVerticalGrid.Rows.EditorRow row = new DevExpress.XtraVerticalGrid.Rows.EditorRow(field);
            vg.Rows.Add(row);
            row.Properties.Caption = caption;
            row.Height = 30;
            row.Properties.Format.FormatType = formatType;
            if(formatType == DevExpress.Utils.FormatType.Custom)
                row.Properties.Format.Format = new BaseFormatter();
            row.Properties.Format.FormatString = formatString;
        }
        //</vGridControl1>

        private void FillData() {
            RowFormatRecord[] records = new RowFormatRecord[5];
            records[0] = new RowFormatRecord(32.35, 100000, DateTime.Parse("5/3/1999", System.Globalization.CultureInfo.InvariantCulture), 10);
            records[1] = new RowFormatRecord(20, 65535, DateTime.Parse("10/7/2001", System.Globalization.CultureInfo.InvariantCulture), 65);
            records[2] = new RowFormatRecord(100.99, 9999999999, DateTime.Now, 100);
            records[3] = new RowFormatRecord(250.5, 10, DateTime.Parse("12/1/2003", System.Globalization.CultureInfo.InvariantCulture), 20);
            records[4] = new RowFormatRecord(15, 0, DateTime.Parse("7/7/2002", System.Globalization.CultureInfo.InvariantCulture), 4);

            vGridControl1.DataSource = records;
        }
    }
}

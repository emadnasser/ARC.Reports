using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridColumnFormat.
	/// </summary>
	public partial class GridColumnFormat : TutorialControl {
		public GridColumnFormat() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

      //<gridControl1>
		private void GridColumnFormat_Load(object sender, System.EventArgs e) {
			CreateGridColumn(gridView1, "Payment (Currency format)", "Payment", 0, DevExpress.Utils.FormatType.Numeric, "c");
			CreateGridColumn(gridView1, "Lenght (Exponential format)", "Lenght", 1, DevExpress.Utils.FormatType.Numeric, "e");
			CreateGridColumn(gridView1, "Lenght (Hexadecimal format)", "Lenght", 2, DevExpress.Utils.FormatType.Numeric, "x");
			CreateGridColumn(gridView1, "PurchaseDate (LongDate format)", "PurchaseDate", 3, DevExpress.Utils.FormatType.DateTime, "D");
			CreateGridColumn(gridView1, "Custom Format", "Number", 4, DevExpress.Utils.FormatType.Custom, "B2");
			InitData();
			gridView1.BestFitColumns();
		}
		private void CreateGridColumn(DevExpress.XtraGrid.Views.Base.ColumnView cv, string caption, string field, int visibleindex, DevExpress.Utils.FormatType formatType, string formatString) {
			DevExpress.XtraGrid.Columns.GridColumn gc = cv.Columns.Add();
			gc.Caption = caption;
			gc.FieldName = field;
			gc.VisibleIndex = visibleindex;
			gc.DisplayFormat.FormatType = formatType;
			if(formatType == DevExpress.Utils.FormatType.Custom) 
				gc.DisplayFormat.Format = new BaseFormatter();
			gc.DisplayFormat.FormatString = formatString;
		}
      //</gridControl1>

		private void InitData() {
			ColumnFormatRecord[] records = new ColumnFormatRecord[5];
            records[0] = new ColumnFormatRecord(32.35, 100000, DateTime.Parse("5/3/2003", System.Globalization.CultureInfo.InvariantCulture), 10);
            records[1] = new ColumnFormatRecord(20, 65535, DateTime.Parse("10/7/2002", System.Globalization.CultureInfo.InvariantCulture), 65);
			records[2] = new ColumnFormatRecord(100.99, 9999999999, DateTime.Now, 100);
            records[3] = new ColumnFormatRecord(250.5, 10, DateTime.Parse("12/1/2001", System.Globalization.CultureInfo.InvariantCulture), 20);
            records[4] = new ColumnFormatRecord(15, 0, DateTime.Parse("4/4/2003", System.Globalization.CultureInfo.InvariantCulture), 4);

			gridControl1.DataSource = records;
		}
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}

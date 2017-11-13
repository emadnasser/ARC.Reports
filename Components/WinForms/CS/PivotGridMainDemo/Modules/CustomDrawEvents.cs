using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {	

	public partial class CustomDrawEvents : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		Color highlightColor;
		DataTable dataSource = new DataTable();
		Random random = new Random();
		object[,] lastCells;
		List<Point> pointDifference;
		const int colorStep = 25;

		List<Point> PointDifference {
			get {
				if(pointDifference == null) {
					object[,] currentState = CellsState;
					pointDifference = new List<Point>();
					for(int i = lastCells.GetLowerBound(0); i <= lastCells.GetUpperBound(0); i++)
						for(int j = lastCells.GetLowerBound(1); j <= lastCells.GetUpperBound(1); j++)
							if(!object.Equals(lastCells[i, j], currentState[i, j]))
								pointDifference.Add(new Point(i, j));
				}
				return pointDifference;
			}
		}
		object[,] LastCells {
			get { return lastCells; }
			set {
				lastCells = value;
				pointDifference = null;
			}
		}

		public CustomDrawEvents() {
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\CustomDrawEvents.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.CustomDrawEvents.xml";

            pivotGridControl1.OptionsCustomization.AllowFilterBySummary = false;
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

		object[,] CellsState {
			get {
				object[,] result = new object[pivotGridControl1.Cells.ColumnCount, pivotGridControl1.Cells.RowCount];
				for(int i = 0; i < pivotGridControl1.Cells.ColumnCount; i++)
					for(int j = 0; j < pivotGridControl1.Cells.RowCount; j++)
						result[i, j] = pivotGridControl1.Cells.GetCellInfo(i, j).Value;
				return result;
			}
		}
		void AddDataSourceRow() {
			dataSource.Rows.Add("Category " + ((dataSource.Rows.Count + 1) % 2).ToString(), "Product " + ((dataSource.Rows.Count + 1) % 10).ToString(),
				DateTime.FromOADate(random.Next(365) + new DateTime(2007, 1, 1).ToOADate()), random.Next(1000));
		}
		void HighlightChanges() {
			highlightColor = Color.Red;
			timer2.Enabled = true;
		}
		Color DecreaseColor(Color color) {
			return System.Drawing.Color.FromArgb(Math.Max(0, (int)color.R - colorStep), 0, 0);
		}

		void CustomDrawEvents_Load(object sender, EventArgs e) {
			dataSource.Columns.Add("Category", typeof(string));
			dataSource.Columns.Add("Product", typeof(string));
			dataSource.Columns.Add("OrderDate", typeof(DateTime));
			dataSource.Columns.Add("Amount", typeof(int));
			for(int i = 0; i < 200; i++)
				AddDataSourceRow();
			
			pivotGridControl1.Fields.Add("Category", PivotArea.RowArea);
			pivotGridControl1.Fields.Add("Product", PivotArea.RowArea);
			pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea).GroupInterval = PivotGroupInterval.DateYear;
			pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea).GroupInterval = PivotGroupInterval.DateQuarter;
			pivotGridControl1.Fields.Add("Amount", PivotArea.DataArea);
			pivotGridControl1.DataSource = dataSource.DefaultView;

			LastCells = CellsState;
		}
        //<pivotGridControl1>	
		void pivotGridControl1_CustomDrawFieldValue(object sender, PivotCustomDrawFieldValueEventArgs e) {
			int index = e.Area == PivotArea.ColumnArea ? pivotGridControl1.Cells.FocusedCell.X : pivotGridControl1.Cells.FocusedCell.Y;
			if(e.MinIndex <= index && index <= e.MaxIndex)
				e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
			else
				e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);
		}
		void pivotGridControl1_CustomDrawCell(object sender, PivotCustomDrawCellEventArgs e) {
			bool highlight = highlightColor.R > 0 && PointDifference.Contains(new Point(e.ColumnIndex, e.RowIndex));
			if((e.ColumnIndex == pivotGridControl1.Cells.FocusedCell.X && e.RowIndex == pivotGridControl1.Cells.FocusedCell.Y) || highlight)
				e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
			else
				e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);
			e.Appearance.ForeColor = highlight ? highlightColor : Color.Black;
			if(e.ColumnIndex == pivotGridControl1.Cells.FocusedCell.X || e.RowIndex == pivotGridControl1.Cells.FocusedCell.Y)
				e.Appearance.BackColor = Color.FromArgb(e.Appearance.BackColor.R - 10, e.Appearance.BackColor.G - 10, e.Appearance.BackColor.B - 10);
		}
        //</pivotGridControl1>

		void timer1_Tick(object sender, EventArgs e) {
			if(pivotGridControl1.IsDragging) return;
			LastCells = CellsState;
			AddDataSourceRow();
			pivotGridControl1.RefreshData();
			HighlightChanges();
		}		
		void timer2_Tick(object sender, EventArgs e) {
			if(pivotGridControl1.IsDragging) return;
			highlightColor = DecreaseColor(highlightColor);
			pivotGridControl1.Invalidate();
			if(highlightColor.R == 0) {
				timer2.Enabled = false;
				LastCells = CellsState;
			}
		}		

		protected override void DoShow() {			
			base.DoShow();
			timer1.Enabled = true;
		}
		protected override void DoHide() {
			timer1.Enabled = false;
			base.DoHide();			
		}

		void pivotGridControl1_FieldAreaChanged(object sender, PivotFieldEventArgs e) {
			LastCells = CellsState;
		}
	}
}

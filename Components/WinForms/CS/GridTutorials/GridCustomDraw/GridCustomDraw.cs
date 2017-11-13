using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Data;
using DevExpress.Utils;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridCustomDraw.
	/// </summary>
	public partial class GridCustomDraw : TutorialControl {
		public GridCustomDraw() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridCustomDraw_Load(object sender, System.EventArgs e) {
			InitData();
		}

		private void InitData() {
			DevExpress.XtraGrid.Design.XViewsPrinting XV = new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1);	
			InitView();
		}

		private void InitView() {
			gridView1.GroupSummary.Add(SummaryItemType.Count, "Product Name", gridView1.Columns["Product Name"]);
			gridView1.GroupSummary.Add(SummaryItemType.Average, "Unit Price", gridView1.Columns["Unit Price"]);
			((GridSummaryItem)gridView1.GroupSummary[gridView1.GroupSummary.Count - 1]).DisplayFormat = "AVG={0:c}";
			gridView1.Columns["Discontinued"].GroupIndex = 0;
			gridView1.ExpandAllGroups();
		}
		
		#region CustomDraw
      //<gridControl1>
		private void gridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e) {
			if(e.Column == null) return;
			Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.AliceBlue, Color.DodgerBlue, 90);
			Brush brushPressed = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.WhiteSmoke, Color.Gray, 90);

			Rectangle r = e.Bounds;
			ControlPaint.DrawBorder3D(e.Graphics, r, (e.Info.State == DevExpress.Utils.Drawing.ObjectState.Pressed ? Border3DStyle.SunkenOuter : Border3DStyle.RaisedInner));
			r.Inflate(-1, -1);
			e.Graphics.FillRectangle((e.Info.State == DevExpress.Utils.Drawing.ObjectState.Pressed ? brushPressed : brush), r);
							
			if(e.Column.AbsoluteIndex == gridView1.FocusedColumn.AbsoluteIndex ) {
				e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
				e.Appearance.ForeColor = Color.Navy;
			} else {
				e.Appearance.Font = AppearanceObject.DefaultFont;
				e.Appearance.ForeColor = SystemColors.WindowText;
			}
            e.Appearance.DrawString(e.Cache, e.Column.GetTextCaption(), e.Info.CaptionRect);

			e.Info.InnerElements.DrawObjects(e.Info, e.Info.Cache, Point.Empty);
			e.Handled = true;
		}
      //</gridControl1>

		private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e) {
			Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.AliceBlue, Color.DodgerBlue, 90);
			Rectangle  r = e.Bounds;
			r.Inflate(-1, -1);
			e.Graphics.FillRectangle(brush, r);
			if(e.Info.ImageIndex > -1) {
				int x = r.X + (r.Width - e.Info.Images.ImageSize.Width) / 2;
				int y = r.Y + (r.Height - e.Info.Images.ImageSize.Height) / 2;
				e.Graphics.DrawImageUnscaled(e.Info.Images.Images[e.Info.ImageIndex], x, y);
			}
			ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner);
			e.Handled = true;
		}

		private void gridView1_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e) {
			Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Gray, Color.WhiteSmoke, 0.0);
			e.Graphics.FillRectangle(brush, e.Bounds);
			e.Handled = true;
		}

		private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
			DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo group = e.Info as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo;
			Rectangle button = group.ButtonBounds, text = group.Bounds;

			Brush brush	= new System.Drawing.Drawing2D.LinearGradientBrush(text, Color.AliceBlue, Color.DodgerBlue, 0.0);
			Brush brushText = Brushes.Black;
			if(e.RowHandle == gridView1.FocusedRowHandle) {
				brush = SystemBrushes.Highlight;
				brushText = SystemBrushes.HighlightText;
			}
			e.Graphics.FillRectangle(brush, text);
			if(!button.IsEmpty) {
				text.Width = text.Right - (button.Right + 4);
				text.X = button.Right + 4;
				int x = button.X;
				int y = text.Y + (text.Height - imageList1.ImageSize.Height) / 2;
				e.Graphics.DrawImageUnscaled(imageList1.Images[(gridView1.GetRowExpanded(e.RowHandle) ? 1 : 0)], x, y);
			}
			string s = gridView1.GetGroupRowDisplayText(e.RowHandle);
			e.Graphics.DrawString(s, e.Appearance.Font, brushText, text, e.Appearance.GetStringFormat());
			e.Handled = true;
		}

		private void gridView1_CustomDrawRowFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
			Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.AliceBlue, Color.DodgerBlue, 90);
			e.Graphics.FillRectangle(brush, e.Bounds);
			e.Handled = true;
		}

		private void gridView1_CustomDrawRowFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e) {
			Brush brush = Brushes.AliceBlue;

			Rectangle r = e.Bounds;
			ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.SunkenOuter);

			r.Inflate(-1, -1);
			e.Graphics.FillRectangle(brush, r);
			
			r.Inflate(-2, 0);
			e.Appearance.DrawString(e.Cache, e.Info.DisplayText, r);
			
			if(e.Column.AbsoluteIndex == 0) {
				int x = r.X + 2;
				int y = r.Y + (r.Height - imageList1.ImageSize.Height) / 2;
				e.Graphics.DrawImageUnscaled(imageList1.Images[2], x, y);
			}
			e.Handled = true;
		}

		private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e) {
			if(e.RowHandle != gridView1.FocusedRowHandle || e.Column.AbsoluteIndex == gridView1.FocusedColumn.AbsoluteIndex) {
				if(e.Column.FieldName == "Category" && gridView1.GetRowCellValue(e.RowHandle, e.Column).Equals(6)) {
					e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
					e.Appearance.ForeColor = Color.Navy;
				}
				if(e.Column.FieldName == "Unit Price" && gridView1.GetRowCellValue(e.RowHandle, e.Column) is System.Decimal)
					if((Decimal)gridView1.GetRowCellValue(e.RowHandle, e.Column) > 30) 
						e.Appearance.BackColor = Color.FromArgb(192, 192, 255);
			}
		}

		private void gridView1_GroupLevelStyle(object sender, DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs e) {
			e.LevelAppearance.BackColor = System.Drawing.Color.AliceBlue;
		}
		#endregion

		private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e) {
			gridView1.InvalidateColumnHeader(null);
			gridView1.InvalidateGroupPanel();
		}

		public override bool ShowLookAndFeel { get { return false;} }
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}

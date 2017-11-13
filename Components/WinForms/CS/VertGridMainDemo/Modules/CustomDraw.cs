using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraVerticalGrid.ViewInfo;
using DevExpress.XtraBars;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraVerticalGrid.Demos {
	public partial class CustomDraw : TutorialControl {
		public CustomDraw() {
			InitializeComponent();
		}

        DataView dv;
        AppearanceDefault app1, app2, app3, app4, app5;
        int bW = 9;
		protected override string BarName { get { return "CustomDraw"; } }
		protected override BarManager Manager { get { return barManager1; } }
		protected override void InitBarInfo() {
			this.BarInfos.Add(new BarInfo("CustomDraw RowValue Cell", new ItemClickEventHandler(MenuItemClick), imageList3.Images[1], true, true, false));
			this.BarInfos.Add(new BarInfo("CustomDraw RowHeader Cell", new ItemClickEventHandler(MenuItemClick), imageList3.Images[2], true, true, false));
			this.BarInfos.Add(new BarInfo("CustomDraw RowHeader Indent", new ItemClickEventHandler(MenuItemClick), imageList3.Images[3], true, true, false));
			this.BarInfos.Add(new BarInfo("CustomDraw Separator", new ItemClickEventHandler(MenuItemClick), imageList3.Images[4], true, true, false));
			this.BarInfos.Add(new BarInfo("CustomDraw TreeButton", new ItemClickEventHandler(MenuItemClick), imageList3.Images[5], true, true, false));
			this.BarInfos.Add(new BarInfo("TreeButton Style", null, imageList3.Images[7], false, false, true, 
				new BarInfo[] { new BarInfo("ExplorerBar Button", new ItemClickEventHandler(ExplorerBarClick), imageList3.Images[6], true, vGridControl1.TreeButtonStyle == DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar, false),
				new BarInfo("TreeView Button", new ItemClickEventHandler(TreeViewClick), imageList3.Images[7], true, vGridControl1.TreeButtonStyle == DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView, false)}, 1));
		}

		void MenuItemClick(object sender, ItemClickEventArgs e) {
			vGridControl1.LayoutChanged();
		}

		void ExplorerBarClick(object sender, ItemClickEventArgs e) {
			GetBarItem(5).Glyph = imageList3.Images[6];
			vGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar;
		}

		void TreeViewClick(object sender, ItemClickEventArgs e) {
			GetBarItem(5).Glyph = imageList3.Images[7];
			vGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView;
		}
		
		#region Init
		private void CustomDraw_Load(object sender, System.EventArgs e) {
			InitData();
			vGridControl1.FocusedRecord = 4;
			vGridControl1.FocusedRow = rowTrademark;
			vGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView;
			CreateAppearances();
		}
		
		private void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\Cars.xml");
			if(DBFileName != "") {
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(DBFileName);
				dv = dataSet.Tables[0].DefaultView;
				vGridControl1.DataSource = dv;
			}
		}
		#endregion
		#region Custom Draw
		
		void CreateAppearances() {
			app1 = new AppearanceDefault(Color.Yellow, Color.Lavender, Color.Lavender, Color.Navy);
			app1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			app1.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
			app2 = new AppearanceDefault(SystemColors.WindowText, Color.FromArgb(234, 230, 221), Color.FromArgb(234, 230, 221), Color.FromArgb(247, 245, 242));
			app2.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
			app3 = new AppearanceDefault(SystemColors.ControlDark, Color.FromArgb(234, 230, 221), Color.FromArgb(234, 230, 221), Color.FromArgb(247, 245, 242));
			app3.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Strikeout);
			app4 = new AppearanceDefault(SystemColors.WindowText, Color.FromArgb(128, 255, 128));
			app5 = new AppearanceDefault(SystemColors.WindowText, Color.FromArgb(192, 192, 255));
		}

		private void vGridControl1_CustomDrawRowValueCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs e) {
			if(!GetBarItemPushed(0)) return;
			Brush brush = null;
			Rectangle r = e.Bounds;
			bool ellipse = false;
			bool isFocusedCell = (e.Row == vGridControl1.FocusedRow);
			bool isInStock = (bool)dv[vGridControl1.LeftVisibleRecord].Row["Is In Stock"];
			
			if(!isInStock && (e.Row.Properties.FieldName == "Price" || e.Row.Properties.FieldName == "Delivery Date"))
				AppearanceHelper.Apply(e.Appearance, app3);
			if(e.Row.Properties.FieldName == "Trademark" || e.Row.Properties.FieldName == "Model")
				AppearanceHelper.Apply(e.Appearance, app2);
			
			if(e.Row is MultiEditorRow && e.CellIndex == 0)
				AppearanceHelper.Apply(e.Appearance, app4);
			if(e.Row is MultiEditorRow && e.CellIndex == 1)
				AppearanceHelper.Apply(e.Appearance, app5);

			if(e.Row.Properties.FieldName == "Liter" && e.CellValue != null) {
				brush = e.Appearance.GetBackBrush(e.Cache);
				if(isFocusedCell) brush = SystemBrushes.Highlight;
				ellipse = true;
			}
			if(brush != null) {
				e.Graphics.FillRectangle(brush, r);
				r.Inflate(-2, 0);
				if(ellipse) {
					Brush ellipseBrush = Brushes.LightSkyBlue;
					if(isFocusedCell) ellipseBrush = Brushes.Yellow;
					e.Graphics.FillEllipse(ellipseBrush, r);
				}
				StringFormat sf = new StringFormat();
				sf.Alignment = StringAlignment.Center;
				sf.LineAlignment = StringAlignment.Center;
				e.Appearance.DrawString(e.Cache, e.CellText, r, sf);
				if(isFocusedCell)
					DevExpress.Utils.Paint.XPaint.Graphics.DrawFocusRectangle(e.Graphics, e.Bounds, SystemColors.WindowText, e.Appearance.BackColor);
				e.Handled = true;
			}
		}

		private bool HasFocusedRow(BaseRow row, BaseRow child) {
			if(!(row is CategoryRow)) return false;
			if(row == child || row == child.ParentRow) return true;
			return false;
		}

		private void vGridControl1_CustomDrawRowHeaderCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs e) {
			if(!GetBarItemPushed(1)) return;
			if(HasFocusedRow(e.Row, vGridControl1.FocusedRow)) 
				AppearanceHelper.Apply(e.Appearance, app1);
			if(e.Row is CategoryRow) {
				e.Appearance.FillRectangle(e.Cache, e.Bounds);
				if(e.ImageIndex != -1)
					e.Graphics.DrawImageUnscaled(imageList1.Images[e.ImageIndex], e.ImageRect);
				e.Appearance.DrawString(e.Cache, e.Caption, e.CaptionRect);
				ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner);
				e.Handled = true;
			}
		}

		private void vGridControl1_CustomDrawRowHeaderIndent(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderIndentEventArgs e) {
			if(!GetBarItemPushed(2)) return;
			AppearanceObject appObject = vGridControl1.Appearance.RowHeaderPanel;
			Rectangle r;
			for(int i = 0; i < e.RowIndents.Count; i++) {
				r = ((IndentInfo)e.RowIndents[i]).Bounds;
				appObject.FillRectangle(e.Cache, r);
			}
			if(HasFocusedRow(e.Row.ParentRow, vGridControl1.FocusedRow) || HasFocusedRow(e.Row, vGridControl1.FocusedRow)) 
				AppearanceHelper.Apply(e.Appearance, app1);
			else AppearanceHelper.Apply(e.Appearance, vGridControl1.Appearance.Category);
			if(e.Row == vGridControl1.FocusedRow && e.Row.ParentRow != null && e.RowIndents.Count > 0)
				e.Graphics.DrawImageUnscaled(imageList1.Images[5], ((IndentInfo)e.RowIndents[0]).Bounds);
			if(e.CategoryIndents.Count > 0) {
				r = ((IndentInfo)e.CategoryIndents[0]).Bounds;
				e.Appearance.FillRectangle(e.Cache, r);
				ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner);
			}
			e.Handled = true;
		}

		private void vGridControl1_CustomDrawSeparator(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawSeparatorEventArgs e) {
			if(!GetBarItemPushed(3)) return;
			if(vGridControl1.FocusedRow is MultiEditorRow) 
				e.SeparatorString = "&";		
			e.Appearance.FillRectangle(e.Cache, e.Bounds);
			Rectangle r = e.Bounds;
			r.X += 1; r.Width -=1;
			e.Appearance.DrawString(e.Cache, e.SeparatorString, r);
			ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner);
			e.Handled = true;
		}

		
		private void vGridControl1_CustomDrawTreeButton(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawTreeButtonEventArgs e) {
			if(!GetBarItemPushed(4)) return;
			Rectangle r = e.Bounds;
			if(e.TreeButtonType == DevExpress.XtraVerticalGrid.TreeButtonType.ExplorerBarButton) {
				r.Y = r.Y + (r.Height - bW) / 2;
				r.X = r.X + (r.Width - bW);
			}
			e.Graphics.DrawImageUnscaled(imageList1.Images[(e.Expanded ? 6 : 7)], r);
			e.Handled = true;
		}

		private void vGridControl1_FocusedRowChanged(object sender, DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs e) {
			BaseRow oldParent = e.OldRow == null ? null : e.OldRow.ParentRow;
			BaseRow newParent = e.Row == null ? null : e.Row.ParentRow;
			if(oldParent != newParent || newParent == null)
				vGridControl1.LayoutChanged();

		}
		#endregion
	}
}

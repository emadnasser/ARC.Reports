using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridDragDropInternal.
	/// </summary>
	public partial class GridDragDropInternal : TutorialControl {
		public GridDragDropInternal() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        GridHitInfo hitInfo = null;
		private void GridDragDropInternal_Load(object sender, System.EventArgs e) {
			InitData();
			gridView1.SetRowExpanded(-1, true);
		}

		private void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\Contacts.xml");
			if(DBFileName != "") {
				DataSet ds = new DataSet();
				ds.ReadXml(DBFileName);
				gridControl1.DataSource = ds.Tables[0];
			}
		}

		
      //<gridControl1>
		private void gridControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
			hitInfo = gridView1.CalcHitInfo(new Point(e.X, e.Y));
			if(hitInfo.RowHandle < 0) hitInfo = null; 
		}

		private void gridControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
			if(hitInfo == null) return;
			if(e.Button != MouseButtons.Left) return;
			Rectangle dragRect = new Rectangle(new Point(
				hitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2,
				hitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);
			if(!dragRect.Contains(new Point(e.X, e.Y))) { 
				if(hitInfo.InRow) {
					gridControl1.DoDragDrop(new object[] {hitInfo.RowHandle, gridControl1}, DragDropEffects.All);
				}
			}
		}
      //</gridControl1>

		private int GetDragObject(object sender, IDataObject data) {
			object[] obj = data.GetData(typeof(object[])) as object[];
				if(obj == null || !sender.Equals(gridControl1)) return -2; 
			if(obj[0] is Int32)
				return (int)obj[0];
			else return -1;
		}

      //<gridControl1>
		private void gridControl1_DragOver(object sender, System.Windows.Forms.DragEventArgs e) {
			GridHitInfo hi = gridView1.CalcHitInfo(gridControl1.PointToClient(new Point(e.X, e.Y)));
			int handle = GetDragObject(sender, e.Data); 
			if(hi.InRow && handle >= 0 && handle != hi.RowHandle) {
				if((e.KeyState & 8) != 0) 
					e.Effect = DragDropEffects.Copy;
				else
					e.Effect = DragDropEffects.Move;
			}
			else e.Effect = DragDropEffects.None;
		}

		private void gridControl1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
			GridHitInfo hi = gridView1.CalcHitInfo(gridControl1.PointToClient(new Point(e.X, e.Y)));
			int handle = GetDragObject(sender, e.Data); 
			if(handle < 0) return;
			if(hi.InRow) {
				DataRowView row = gridView1.GetRow(handle) as DataRowView;
				//the following code determines whether the target row is a group row and if a group row is detected, 
				//it retrieves the actual data row corresponding to it.
				int newHandle = hi.RowHandle;
				if(newHandle < 0) {
					gridView1.SetRowExpanded(newHandle, true, true);
					newHandle = gridView1.GetDataRowHandleByGroupRowHandle(newHandle);
				}
				DataRow rowReciever = gridView1.GetDataRow(newHandle);
				//the following code implements actual data moving or copying
                DataRowView newRow = null;
				if(e.Effect == DragDropEffects.Copy) {
					newRow = ((DataView)gridView1.DataSource).AddNew();
					for(int i = 0; i < gridView1.Columns.Count; i++) 
						newRow.Row[gridView1.Columns[i].FieldName] = row[gridView1.Columns[i].FieldName];
					row = newRow;
				}
				for(int i = 0; i < gridView1.SortInfo.GroupCount; i++) 
					row.Row[gridView1.GroupedColumns[i].FieldName] = rowReciever[gridView1.GroupedColumns[i].FieldName];
                if(newRow != null) newRow.Row["id"] = ((DataView)gridView1.DataSource).Count;
				row.EndEdit();
			}
		}
      //</gridControl1>

		private void gridView1_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e) {
			if(!MouseButtons.Equals(MouseButtons.None))
				e.Cancel = true;
		}
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}

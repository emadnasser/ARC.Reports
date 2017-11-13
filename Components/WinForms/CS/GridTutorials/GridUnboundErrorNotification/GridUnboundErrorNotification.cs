using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridUnboundErrorNotification.
	/// </summary>
	public partial class GridUnboundErrorNotification : TutorialControl {
		public GridUnboundErrorNotification() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridUnboundErrorNotification_Load(object sender, System.EventArgs e) {
			InitData();
			ValidateData();
		}

		private void InitData() {
			ProjectNotes dates = new ProjectNotes();
			dates.Add(new NoteInfo(231, 4, 1, 2006));
			dates.Add(new NoteInfo(232, 6, 3, 2006));
			dates.Add(new NoteInfo(233, 24, 15, 2006));
			dates.Add(new NoteInfo(234, 17, 8, 2005));
			dates.Add(new NoteInfo(237, 29, 2, 2005));
			dates.Add(new NoteInfo(238, 30, 2, 2004));
			gridControl1.DataSource = dates;
		}

        //<gridControl1>
		private string IsValidDate(int day, int month, int year) {
			if(month < 1 || month > 12) return "Month";
			if(day < 1 || day > DateTime.DaysInMonth(year, month)) return "Day";
			if(year < 1980 || year > 2010) return "Year";
			return "";
		}

		private void ValidateData() {
			ProjectNotes notes = gridControl1.DataSource as ProjectNotes;
			foreach(NoteInfo nInfo in notes) {
				string valid = IsValidDate(nInfo.Day, nInfo.Month, nInfo.Year);
				nInfo.ClearErrors();
				if(valid != "") {
					nInfo.NoteError = "Check the date";
					nInfo.SetColumnError(valid, "Invalid " + valid);
				}	
			}
		}
        //</gridControl1>

		private void simpleButton1_Click(object sender, System.EventArgs e) {
			ValidateData();
		}

        //<gridControl1>
		private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
			ValidateData();
		}
        //</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridUnboundColumns.
	/// </summary>
	public partial class GridUnboundColumns : TutorialControl {
		public GridUnboundColumns() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        ArrayList array = null;
		private void GridUnboundColumns_Load(object sender, System.EventArgs e) {
			InitData();
		}
		
		void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\Contacts.xml");
			if(DBFileName != "") {
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(DBFileName);
				array = new ArrayList();
				for(int i = 0; i < dataSet.Tables[0].DefaultView.Count; i++)
					array.Add(Record.CreateRecord());
				gridControl1.DataSource = dataSet.Tables[0].DefaultView;
			}
		}


      //<gridControl1>
		private void bandedGridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
			if(array == null) return;
			if(e.ListSourceRowIndex >= array.Count) return;
			Record rec = array[e.ListSourceRowIndex] as Record;
			if(rec == null) return;
            if(e.Column == bandedGridColumn1) {
                DataRowView row = e.Row as DataRowView;
                e.Value = string.Format("{0} {1}", row["FirstName"], row["LastName"]);
                return;
            }
			switch(e.Column.UnboundType) {
				case UnboundColumnType.DateTime:
					if(e.IsGetData)
						e.Value = rec.Date;
					else rec.Date = (DateTime)e.Value;
					break;
				case UnboundColumnType.Integer:
					if(e.IsGetData)
						e.Value = rec.Count;
					else rec.Count = (Int32)e.Value;
					break;
				case UnboundColumnType.String:
					if(e.IsGetData)
						e.Value = rec.Comment;
					else rec.Comment = e.Value.ToString();
					break;
			}
		}
      //</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }

		public class Record {
			DateTime date;
			int count;
			string comment;

			static Random rnd = new Random();
			public static Record CreateRecord() {
				return new Record(DateTime.Now.AddDays(-rnd.Next(30)), rnd.Next(10) + 1, "Put your comments here...");
			}

			public Record(DateTime date, int count, string comment) {
				this.date = date;
				this.count = count;
				this.comment = comment;
			}

			public int Count { get { return count; } set { count = value; } }
			public DateTime Date { get { return date; } set { date = value; } }
			public string Comment { get { return comment; } set { comment = value; } }
		}
	}
}

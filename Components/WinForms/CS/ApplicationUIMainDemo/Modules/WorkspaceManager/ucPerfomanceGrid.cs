using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DevExpress.ApplicationUI.Demos {
    public partial class ucPerfomanceGrid : UserControl {
        public ucPerfomanceGrid() {
            InitializeComponent();
            gridControl1.DataSource = GetDataTabletFromCSVFile("");
        }
        static DataTable GetDataTabletFromCSVFile(string csv_file_path) {
            string CSVFilePathName = DataLoader.GetRelativePath("PerformanceReport.csv");
            if(string.IsNullOrEmpty(CSVFilePathName)) return null;
            string[] lines = File.ReadAllLines(CSVFilePathName);
            string[] fields;
            fields = lines[0].Split(new char[] { ',' });
            DataTable dataTable = new DataTable();
            for(int i = 0; i < fields.Count(); i++)
                dataTable.Columns.Add(fields[i], typeof(string));
            DataRow row;
            for(int i = 1; i < lines.Count(); i++) {
                fields = lines[i].Split(new char[] { ',' });
                row = dataTable.NewRow();
                for(int f = 0; f < dataTable.Columns.Count; f++) {
                    row[f] = fields[f];
                }
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }
    }
}

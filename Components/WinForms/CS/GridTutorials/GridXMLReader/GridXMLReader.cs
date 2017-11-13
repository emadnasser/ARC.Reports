using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridXMLReader.
    /// </summary>
    public partial class GridXMLReader : TutorialControl {
        public class File {
            public string Name { get; set; }
            public string FullName { get; set; }
        }
        public GridXMLReader() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        List<File> XmlFileNames;
        #region Finding Xml Files
        public static List<File> FindingXmlFiles(string path, string path1) {
            string s = "\\";
            List<File> xmlFiles = new List<File>();
            for(int i = 0; i <= 10; i++) {
                if(System.IO.Directory.Exists(path + s + path1)) {
                    string[] names = System.IO.Directory.GetFiles(path + s + path1);
                    foreach(string name in names) {
                        System.IO.FileInfo fInfo = new System.IO.FileInfo(name);
                        if(fInfo.Extension.ToLower() == ".xml") 
                            xmlFiles.Add(new File { Name = fInfo.Name, FullName = fInfo.FullName });
                    }
                    return xmlFiles;
                }
                else
                    s += "..\\";
            }
            string current = Environment.CurrentDirectory;
            if(path != current)
                return FindingXmlFiles(current, path1);
            XtraMessageBox.Show(string.Format("{0} is not found", path1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return xmlFiles;
        }
        #endregion

        private void GridXMLReader_Load(object sender, System.EventArgs e) {
            XmlFileNames = FindingXmlFiles(Application.StartupPath, "Data\\Xml\\");
            for(int i = 0; i < XmlFileNames.Count; i++)
                comboBoxEdit1.Properties.Items.Add(XmlFileNames[i].Name);
            if(comboBoxEdit1.Properties.Items.Count > 0)
                comboBoxEdit1.SelectedIndex = 0;
        }

        //<comboBoxEdit1>
        private void comboBoxEdit1_SelectedIndexChanged(object sender, System.EventArgs e) {
            FillGridWithData(XmlFileNames[comboBoxEdit1.SelectedIndex].FullName);
        }
        private void FillGridWithData(string s) {
            if(System.IO.File.Exists(s)) {
                DataSet ds = new DataSet();
                ds.ReadXml(s);
                gridControl1.DataSource = ds.Tables[0];
                gridControl1.MainView.PopulateColumns();
            }
            else
                XtraMessageBox.Show(string.Format("File {0} is not found", s), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //</comboBoxEdit1>
    }
}

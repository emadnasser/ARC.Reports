using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.Docs.Text;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    public partial class EncodingDetection : TutorialControlBase {
        const string SRChooseFile = "Choose file...";
        string[] encodingFiles = {
            "english.txt",
            "german.txt",
            "spanish.txt",
            "russian.txt",
            "greek.txt",
            "chinese.txt",
            "japanese.txt"};

        public EncodingDetection() {
            InitializeComponent();
            cbLanguage.Properties.Items.AddRange(encodingFiles);
            cbLanguage.Properties.Items.Add(SRChooseFile);
            cbLanguage.SelectedIndex = 0;
        }
        void LoadFile(string fileName) {
            LoadFileNoDetection(fileName, txtNoDetection);
            LoadFileWithDetection(fileName, txtDetection);
        }
        void LoadFileNoDetection(string path, MemoEdit where) {
            where.Text = File.ReadAllText(path);
        }
        void LoadFileWithDetection(string path, MemoEdit where) {
            EncodingDetector detector = new EncodingDetector();
            byte[] bytes = File.ReadAllBytes(path);
            Encoding encoding = detector.Detect(bytes);
            if(encoding == null)
                encoding = Encoding.Default;
            lblEncoding.Text = encoding.EncodingName + " [" + encoding.BodyName + "]";
            where.Text = encoding.GetString(bytes);
        }
        string userDefinedFileName = String.Empty;
        void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            int selectedIndex = cbLanguage.SelectedIndex;
            if(selectedIndex == -1)
                return;
            string fileName = cbLanguage.Properties.Items[selectedIndex].ToString();
            string fullFileName = String.Empty;
            if(!String.IsNullOrEmpty(userDefinedFileName)) {
                fullFileName = userDefinedFileName;
                this.cbLanguage.Text = Path.GetFileName(userDefinedFileName);
            }
            else
                fullFileName = DemoUtils.GetRelativePath("EncodingFiles\\" + fileName);
            if(!String.IsNullOrEmpty(fullFileName))
                LoadFile(fullFileName);
            this.userDefinedFileName = String.Empty;
        }

        private void btnLoadFile_Click(object sender, EventArgs e) {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Filter = "Text files (*.txt)|*.txt";
            if(ofDialog.ShowDialog() != DialogResult.OK)
                return;
            string fileName = ofDialog.FileName;
            LoadFile(fileName);
            cbLanguage.SelectedIndex = -1;
        }
        void cbLanguage_EditValueChanging(object sender, XtraEditors.Controls.ChangingEventArgs e) {
            this.userDefinedFileName = String.Empty;
            if(Convert.ToString(e.NewValue) == SRChooseFile) {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if(dialog.ShowDialog() != DialogResult.OK) {
                    e.Cancel = true;
                    return;
                }
                this.userDefinedFileName = dialog.FileName;
            }
        }
    }
}

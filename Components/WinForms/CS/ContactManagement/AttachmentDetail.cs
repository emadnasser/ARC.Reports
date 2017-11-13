using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace ContactManagement {
    /// <summary>
    /// Summary description for AttachmentDetail.
    /// </summary>
    public partial class AttachmentDetail : System.Windows.Forms.Form {
        private void SetupBindings() {
            txtOID.DataBindings.Add("Text", theAttachment, "Oid");
            txtAttachmentName.DataBindings.Add("Text", theAttachment, "Name");
            if(theAttachment.Document != null) {
                Stream stream = new MemoryStream();
                stream.Write(theAttachment.Document, 0, theAttachment.Document.Length);
                stream.Position = 0;
                txtDocument.LoadFile(stream, RichTextBoxStreamType.RichText);
            }
        }

        public AttachmentDetail() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public Attachment Attachment {
            set {
                theAttachment = value;
                SetupBindings();
            }
        }

        private void btnLoad_Click(object sender, System.EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Filter = "Rich Text Format(*.rtf)|*.rtf";
            fd.FilterIndex = 0;
            if(fd.ShowDialog(this) == DialogResult.OK) {
                txtDocument.LoadFile(fd.OpenFile(), RichTextBoxStreamType.RichText);
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e) {
            MemoryStream stream = new MemoryStream();
            txtDocument.SaveFile(stream, RichTextBoxStreamType.RichText);
            stream.Close();
            theAttachment.Document = stream.GetBuffer();
            theAttachment.Save();
        }
    }
}

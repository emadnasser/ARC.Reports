using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Pdf;
using DevExpress.XtraEditors;
using DevExpress.XtraPdfViewer;
using DevExpress.Docs.Demos.nwindDataSetTableAdapters;

namespace DevExpress.Docs.Demos {
    public partial class PdfDocumentCreationAPI : TutorialControlBase {
        public override bool NoGap { get { return true; } }

        public PdfDocumentCreationAPI() {
            InitializeComponent();
            Enabled = PdfFileHelper.LoadDocument(pdfViewer, DemoUtils.GetRelativePath("PdfDocumentCreationAPIDemo.pdf"));
        }

        void OnButtonCreateDocumentClick(object sender, EventArgs e) {
            const float imageLocationX = 100;
            const float imageLocationY = 100;
            try {
                using (MemoryStream stream = new MemoryStream()) {
                    using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                        documentProcessor.CreateEmptyDocument(stream);
                        PdfDocument document = documentProcessor.Document;
                        document.Creator = "PDF Document Processor Demo";
                        document.Author = "DevExpress Inc.";
                        document.Keywords = "PDF, document, server, code, generation, creation API";
                        document.Subject = "PDF Document Processor - Document Creation API Demo";
                        document.Title = "PDF Document Creation API";
                        document.Producer = "Developer Express Inc., " + AssemblyInfo.Version;
                        SolidBrush black = (SolidBrush)Brushes.Black;
                        foreach (nwindDataSet.EmployeesRow employee in GetEmployees()) {
                            using (PdfGraphics graphics = documentProcessor.CreateGraphics()) {
                                graphics.UseKerning = true;
                                using (Bitmap image = new Bitmap(new MemoryStream(employee.Photo)))
                                    graphics.DrawImage(image, new RectangleF(imageLocationX, imageLocationY, image.Width / 2.0f, image.Height / 2.0f));
                                using (Font font = new Font("Segoe UI", 32, FontStyle.Bold | FontStyle.Underline)) {
                                    string name = employee.FirstName + " " + employee.LastName;
                                    graphics.DrawString(name, font, black, 300, 90);
                                }
                                using (Font font = new Font("Segoe UI", 20))
                                    graphics.DrawString(employee.Title, font, black, 300, 145);
                                using (Font font = new Font("Segoe UI", 14)) {
                                    graphics.DrawString(employee.HomePhone, font, black, 300, 200);
                                    graphics.DrawString(employee.FirstName.ToLower() + "." + employee.LastName.ToLower()[0] + "@example.com", font, black, 300, 230);
                                }
                                int pageNumber = documentProcessor.RenderNewPage(PdfPaperSize.Letter, graphics);
                                PdfDestination destination = documentProcessor.CreateDestination(pageNumber, imageLocationX, imageLocationY);
                                document.Bookmarks.Add(new PdfBookmark() { Title = employee.FirstName + " " + employee.LastName, Destination = destination });
                            }
                        }

                    }
                    stream.Position = 0;
                    pdfViewer.LoadDocument(stream);
                    pdfViewer.NavigationPaneVisibility = PdfNavigationPaneVisibility.Visible;
                }
                buttonSave.Enabled = true;
            }
            catch {
                XtraMessageBox.Show(PdfFileHelper.DemoOpeningErrorMessage, "Error");
                Enabled = false;
            }
        }
        IEnumerable<nwindDataSet.EmployeesRow> GetEmployees() {
            string path = DemoUtils.GetRelativePath("nwind.mdb");
            nwindDataSet nwindDataSet = new nwindDataSet();
            EmployeesTableAdapter employeesTableAdapter = new EmployeesTableAdapter();
            OleDbConnection connection = new OleDbConnection();
            DemoUtils.SetConnectionString(connection, path);
            employeesTableAdapter.Connection = connection;
            employeesTableAdapter.Fill(nwindDataSet.Employees);
            List<nwindDataSet.EmployeesRow> result = new List<nwindDataSet.EmployeesRow>();
            foreach (nwindDataSet.EmployeesRow employee in nwindDataSet.Employees)
                result.Add(employee);
            return result;
        }

        void OnSaveButtonClick(object sender, EventArgs e) {
            string fileName = PdfFileHelper.SaveFileDialog();
            try {
                pdfViewer.DocumentCreator = "PDF Document Processor Demo";
                pdfViewer.DocumentProducer = "Developer Express Inc., " + AssemblyInfo.Version;
                pdfViewer.SaveDocument(fileName);
            }
            catch {
                XtraMessageBox.Show(String.Format(PdfFileHelper.SaveErrorMessage, fileName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

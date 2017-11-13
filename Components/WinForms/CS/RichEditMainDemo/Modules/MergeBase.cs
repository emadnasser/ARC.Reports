using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.Office.Internal;
using DevExpress.XtraRichEdit.Demos.Forms;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Internal;
using DevExpress.XtraEditors;

namespace DevExpress.XtraRichEdit.Demos {
    public class MergeModuleBase : DevExpress.XtraRichEdit.Demos.TutorialControl {
        static string[] firstName = { "Nancy", "Andrew", "Janet", "Margaret", "Steven", "Michael", "Robert", "Laura", "Anne" };
        static string[] lastName = { "Davolio", "Fuller", "Leverling", "Peacock", "Buchanan", "Suyama", "King", "Callahan", "Dodsworth" };
        static string[] city = { "Seattle", "Tacoma", "Kirkland", "Redmond", "London", "London", "London", "Seattle", "London" };
        static string[] country = { "USA", "USA", "USA", "USA", "UK", "UK", "UK", "USA", "UK" };
        static string[] address = { "507 - 20th Ave. E. Apt. 2A", "908 W. Capital Way", "722 Moss Bay Blvd.", "4110 Old Redmond Rd.", "14 Garrett Hill", "Coventry House Miner Rd.", "Edgeham Hollow Winchester Way", "4726 - 11th Ave. N.E.", "7 Houndstooth Rd." };
        static string[] position = { "Sales Representative", "Vice President, Sales", "Sales Representative", "Sales Representative", "Sales Manager", "Sales Representative", "Sales Representative", "Inside Sales Coordinator", "Sales Representative" };
        static char[] gender = { 'F', 'M', 'F', 'F', 'M', 'M', 'M', 'F', 'F' };
        static string[] phone = { "(206) 555-9857", "(206) 555-9482", "(206) 555-3412", "(206) 555-8122", "(71) 555-4848", "(71) 555-7773", "(71) 555-5598", "(206) 555-1189", "(71) 555-4444" };
        static string[] companyName = { "Consolidated Holdings", "Around the Horn", "North/South", "Island Trading", "White Clover Markets", "Trail's Head Gourmet Provisioners", "The Cracker Box", "The Big Cheese", "Rattlesnake Canyon Grocery", "Split Rail Beer & Ale", "Hungry Coyote Import Store", "Great Lakes Food Market" };

        protected MergeModuleBase() {
        }

        public override RichEditControl PrintingRichEditControl {
            get {
                return SourceRichEditControl;
            }
        }
        protected virtual RichEditControl SourceRichEditControl { get { return null; } }

        protected internal List<Employee> GenerateEmployeeList() {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 10; i++)
                employees.Add(CreateEmployee(i));
            return employees;
        }
        Employee CreateEmployee(int seed) {
            Employee result = new Employee();
            Random rnd = new Random(seed);
            int countryIndex = rnd.Next(0, country.Length);
            result.Country = country[countryIndex];
            result.Address = address[countryIndex];
            result.City = city[countryIndex];
            result.LastName = lastName[rnd.Next(0, lastName.Length)];
            int firstNameIndex = rnd.Next(0, firstName.Length);
            result.FirstName = firstName[firstNameIndex];
            result.Gender = gender[firstNameIndex];
            result.HiringDate = DateTime.Now.AddDays(-(rnd.Next(0, 2000)));
            result.Position = position[rnd.Next(0, position.Length)];
            result.Phone = phone[rnd.Next(0, phone.Length)];
            result.CompanyName = companyName[rnd.Next(0, companyName.Length)];
            result.HRManagerName = String.Format("{0} {1}", firstName[rnd.Next(0, firstName.Length)], lastName[rnd.Next(0, lastName.Length)]);
            return result;
        }

        protected virtual void MergeToNewDocument() {
            MergeFieldsFormBase form = CreateMergeFieldForm();
            if (form.ShowDialog(this) == DialogResult.OK) {
                MailMergeOptions options = SourceRichEditControl.Document.CreateMailMergeOptions();
                CalculateMailMergeOptions(form, options);
                options.MergeMode = MergeMode.NewSection;
                if (form.MergeDestination == MergeDestination.NewTab)
                    MailMergeToNewControl(options);
                else
                    MailMergeToNewFile(options);
            }
        }
        protected virtual MergeFieldsFormBase CreateMergeFieldForm() {
            return null;
        }
        protected virtual void CalculateMailMergeOptions(MergeFieldsFormBase form, MailMergeOptions options) {
        }
        protected void MailMergeToNewControl(MailMergeOptions options) {
            MergeResultingDocumentForm form = new MergeResultingDocumentForm();
            SourceRichEditControl.Document.MailMerge(options, form.Document);
            form.Show(this);
        }
        protected void MailMergeToNewFile(MailMergeOptions options) {
            IDocumentExportManagerService exportManagerService = (IDocumentExportManagerService)SourceRichEditControl.GetService(typeof(IDocumentExportManagerService));
            List<IExporter<DocumentFormat, bool>> exporters = exportManagerService.GetExporters();
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.Filter = CreateExportFilters(exporters);
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.CheckFileExists = false;
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.DereferenceLinks = true;
                saveFileDialog.ValidateNames = true;

                if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
                    return;
                string fileName = saveFileDialog.FileName;
                DocumentFormat documentFormat = GetDocumentFormat(fileName, exporters);
                SourceRichEditControl.Document.MailMerge(options, fileName, documentFormat);

                if (XtraMessageBox.Show("Do you want to open this file?", "Mail Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    Process process = new Process();
                    try {
                        process.StartInfo.FileName = fileName;
                        process.Start();                        
                    }
                    catch { }

                }

            }
        }        
        string CreateExportFilters(List<IExporter<DocumentFormat, bool>> exporters) {
            StringBuilder result = new StringBuilder();
            int count = exporters.Count;
            for (int i = 0; i < count; i++) {
                FileDialogFilter filter = exporters[i].Filter;
                if (filter.Extensions.Count > 0) {
                    if (i > 0)
                        result.Append('|');
                    result.Append(filter.ToString());
                }
            }
            return result.ToString();
        }
        DocumentFormat GetDocumentFormat(string fileName, List<IExporter<DocumentFormat, bool>> exporters) {
            string extension = Path.GetExtension(fileName).TrimStart('.').ToLower();
            if (String.IsNullOrEmpty(extension))
                return DocumentFormat.Rtf;
            int count = exporters.Count;
            for (int i = 0; i < count; i++) {
                FileExtensionCollection extensions = exporters[i].Filter.Extensions;
                if (extensions.IndexOf(extension) >= 0)
                    return exporters[i].Format;
            }
            return DocumentFormat.Rtf;
        }
        public static System.Data.DataTable GetEmployeeDataFromXml() {
            string path = DemoUtils.GetRelativePath("TOC_Employees.xml");
            if (String.IsNullOrEmpty(path))
                return null;
            System.Data.DataSet EmployeeDataDS = new System.Data.DataSet();
            string schemaPath = DemoUtils.GetRelativePath("TOC_EmployeesSchema.xml");
            if (!String.IsNullOrEmpty(schemaPath))
                EmployeeDataDS.ReadXmlSchema(schemaPath);
            EmployeeDataDS.ReadXml(path);
            return EmployeeDataDS.Tables[1];
        }
    }
}

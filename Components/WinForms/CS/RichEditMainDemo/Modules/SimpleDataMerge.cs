using System;
using System.Collections.Generic;
using DevExpress.XtraRichEdit.Demos.Forms;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraBars;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class SimpleDataMergeModule : MergeModuleBase {
        #region Fields
        List<Employee> employees;
        MergeFieldNameInfo[] mergeFieldsNamesInfo;
        #endregion

        public SimpleDataMergeModule() {
            InitializeComponent();
            this.employees = GenerateEmployeeList();
            this.dataNavigator.DataSource = employees;
            this.sourceRichEditControl.Options.MailMerge.DataSource = employees;
            this.mergeFieldsNamesInfo = CreateMergeFieldsNamesInfo();
            RtfLoadHelper.Load("MailMergeSimple.rtf", sourceRichEditControl);
            new RichEditDemoExceptionsHandler(sourceRichEditControl).Install();
        }

        protected override RichEditControl SourceRichEditControl { get { return sourceRichEditControl; } }

        #region MergeFieldNamesInfo generation
        protected internal virtual MergeFieldNameInfo[] CreateMergeFieldsNamesInfo() {
            List<MergeFieldNameInfo> result = new List<MergeFieldNameInfo>();
            result.Add(CreateMergeFieldNameInfo("FirstName"));
            result.Add(CreateMergeFieldNameInfo("LastName"));
            result.Add(CreateMergeFieldNameInfo("HiringDate"));
            result.Add(CreateMergeFieldNameInfo("Address"));
            result.Add(CreateMergeFieldNameInfo("City"));
            result.Add(CreateMergeFieldNameInfo("Country"));
            result.Add(CreateMergeFieldNameInfo("Position"));
            result.Add(CreateMergeFieldNameInfo("CompanyName"));
            result.Add(CreateMergeFieldNameInfo("Gender"));
            result.Add(CreateMergeFieldNameInfo("Phone"));
            result.Add(CreateMergeFieldNameInfo("HRManagerName"));

            return result.ToArray();
        }
        MergeFieldNameInfo CreateMergeFieldNameInfo(string fieldName) {
            string displayName = CreateDisplayName(fieldName);
            return new MergeFieldNameInfo(new MergeFieldName(fieldName, displayName));
        }
        string CreateDisplayName(string fieldName) {
            fieldName = fieldName.Replace('_', ' ');
            fieldName = fieldName.Replace('.', ' ');

            char prevChar = ' ';
            int count = fieldName.Length;
            System.Text.StringBuilder sb = new System.Text.StringBuilder(count);
            for (int i = 0; i < count; i++) {
                char ch = fieldName[i];
                if (Char.IsLower(prevChar) && Char.IsUpper(ch))
                    sb.Append(' ');
                sb.Append(ch);
                prevChar = ch;
            }
            return sb.ToString();
        }
        #endregion

        protected override void CalculateMailMergeOptions(MergeFieldsFormBase form, MailMergeOptions options) {
            if (form.MergeRecords == MergeRecords.FromInterval) {
                options.FirstRecordIndex = Math.Max(0, ((MergeSimpleDataForm)form).StartIndex - 1);
                options.LastRecordIndex = Math.Min(employees.Count - 1, ((MergeSimpleDataForm)form).EndIndex - 1);
            }
            else if (form.MergeRecords == MergeRecords.Current) {
                options.FirstRecordIndex = dataNavigator.Position;
                options.LastRecordIndex = dataNavigator.Position;
            }
        }
        protected override MergeFieldsFormBase CreateMergeFieldForm() {
            return new MergeSimpleDataForm();
        }

        private void mergeToNewDocumentClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            MergeToNewDocument();
        }

        private void sourceRichEditControl_DocumentLoaded(object sender, EventArgs e) {
            this.sourceRichEditControl.Document.Fields.Update();
        }

        private void sourceRichEditControl_CustomizeMergeFields(object sender, CustomizeMergeFieldsEventArgs e) {
            e.MergeFieldsNames = CalculateAllowedFieldsNames();
        }
        MergeFieldName[] CalculateAllowedFieldsNames() {
            List<MergeFieldName> result = new List<MergeFieldName>();
            foreach (MergeFieldNameInfo fieldNameInfo in mergeFieldsNamesInfo) {
                if (fieldNameInfo.CanShow) {
                    MergeFieldName fieldName = fieldNameInfo.FieldName;
                    string displayName = String.Format("{0} ({1})", fieldName.DisplayName, fieldName.Name);
                    result.Add(new MergeFieldName(fieldName.Name, displayName));
                }
            }
            return result.ToArray();
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e) {
            CustomizeMergeFieldsForm form = new CustomizeMergeFieldsForm(mergeFieldsNamesInfo);
            form.ShowDialog(this);
        }
    }
    public class Employee {
        string firstName;
        string lastName;
        DateTime hiringDate;
        string address;
        string city;
        string country;
        string position;
        string companyName;
        char gender;
        string phone;
        string hrManagerName;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime HiringDate { get { return hiringDate; } set { hiringDate = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Country { get { return country; } set { country = value; } }
        public string Position { get { return position; } set { position = value; } }
        public string CompanyName { get { return companyName; } set { companyName = value; } }
        public char Gender { get { return gender; } set { gender = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string HRManagerName { get { return hrManagerName; } set { hrManagerName = value; } }
    }
    public class MergeFieldNameInfo {
        #region Fields
        MergeFieldName fieldName;
        bool canShow;
        #endregion

        public MergeFieldNameInfo(MergeFieldName fieldName) {
            this.fieldName = fieldName;
            this.canShow = true;
        }

        #region Properties
        public MergeFieldName FieldName { get { return fieldName; } }
        public bool CanShow { get { return canShow; } set { canShow = value; } }
        #endregion
    }
}

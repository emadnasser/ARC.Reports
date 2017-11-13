using System;
using System.Collections.Generic;
using System.Windows;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Xpf.Editors;
using DevExpress.XtraRichEdit;
using System.Globalization;

namespace RichEditDemo {
    public partial class DocumentProperties : RichEditDemoModule {
        public DocumentProperties() {
            InitializeComponent();
            OpenXmlLoadHelper.Load(@"DocumentProperties.docx", richEdit);
            Document.Fields.Update();
        }

        #region Properties
        Document Document { get { return richEdit.Document; } }
        #endregion

        void OnDocumentPropertiesChanged(object sender, EventArgs e) {
            Document.Fields.Update();
        }
        void OnCustomPropertiesChanged(object sender, EventArgs e) {
            Document.Fields.Update();
        }
        void OnCalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e) {
            if (e.Arguments.Count == 0 || e.VariableName != "CustomProperty")
                return;

            string name = e.Arguments[0].Value;
            object customProperty = Document.CustomProperties[name];
            if (customProperty != null)
                e.Value = customProperty.ToString();
            e.Handled = true;
        }
        void InsertField(string code) {
            Document.BeginUpdate();
            Field field = Document.Fields.Create(richEdit.Document.CaretPosition, code);
            field.Update();
            Document.EndUpdate();
        }

        #region ItemClick
        void OnCategoryItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            InsertField("DOCPROPERTY Category");
        }
        void OnCreatedItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            InsertField("CREATEDATE");
        }
        void OnCreatorItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            InsertField("AUTHOR");
        }
        void OnDescriptionItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            InsertField("COMMENTS");
        }
        void OnKeywordsItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            InsertField("KEYWORDS");
        }
        void OnLastModifiedByItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            InsertField("LASTSAVEDBY");
        }
        void OnLastPrintedItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            InsertField("PRINTDATE");
        }
        void OnModifiedItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            InsertField("SAVEDATE");
        }
        void OnRevisionItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            InsertField("REVNUM");
        }
        void OnSubjectItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            InsertField("SUBJECT");
        }
        void OnTitleItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            InsertField("TITLE");
        }
        #endregion
    }
}

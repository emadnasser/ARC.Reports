using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.API.Layout;
using DevExpress.XtraRichEdit.Utils;
using System.Globalization;
using DevExpress.XtraEditors;

namespace DevExpress.XtraRichEdit.Demos {
    #region DocumentProperties
    public partial class DocumentProperties : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public DocumentProperties() {
            InitializeComponent();
            OpenXmlLoadHelper.Load(@"DocumentProperties.docx", richEditControl);
            Document.Fields.Update();
        }

        #region Properties
        Document Document { get { return richEditControl.Document; } }
        #endregion

        void RichEditControl_DocumentPropertiesChanged(object sender, EventArgs e) {
            Document.Fields.Update();
        }
        void RichEditControl_CustomPropertiesChanged(object sender, EventArgs e) {
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
            Field field = Document.Fields.Create(richEditControl.Document.CaretPosition, code);
            field.Update();
            Document.EndUpdate();
        }

        #region ItemClick
        void OnCategoryItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("DOCPROPERTY Category");
        }
        void OnCreatedItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("CREATEDATE");
        }
        void OnCreatorItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("AUTHOR");
        }
        void OnDescriptionItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("COMMENTS");
        }
        void OnKeywordsItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("KEYWORDS");
        }
        void OnLastModifiedByItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("LASTSAVEDBY");
        }
        void OnLastPrintedItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("PRINTDATE");
        }
        void OnModifiedItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("SAVEDATE");
        }
        void OnRevisionItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("REVNUM");
        }
        void OnSubjectItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("SUBJECT");
        }
        void OnTitleItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("TITLE");
        }
        #endregion
    }
    #endregion
}

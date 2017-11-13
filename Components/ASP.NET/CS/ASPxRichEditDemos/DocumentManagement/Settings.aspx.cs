using DevExpress.Web;
using DevExpress.Web.Demos;
using DevExpress.Web.Office;
using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RichEditDemoSettings : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"AynRand.docx"));
            PrepareEditors();
        }
    }

    protected void btnApply_Click(object sender, EventArgs e) {
        if(!string.IsNullOrEmpty(DemoRichEdit.DocumentId))
            DocumentManager.FindDocument(DemoRichEdit.DocumentId).Close();
        DemoRichEdit.Settings.Behavior.Copy = (DocumentCapability)cmbCopy.Value;
        DemoRichEdit.Settings.Behavior.CreateNew = (DocumentCapability)cmbCreateNew.Value;
        DemoRichEdit.Settings.Behavior.Cut = (DocumentCapability)cmbCut.Value;
        DemoRichEdit.Settings.Behavior.Drag = (DocumentCapability)cmbDrag.Value;
        DemoRichEdit.Settings.Behavior.Drop = (DocumentCapability)cmbDrop.Value;
        DemoRichEdit.Settings.Behavior.FullScreen = (DocumentCapability)cmbFullScreen.Value;
        DemoRichEdit.Settings.Behavior.Open = (DocumentCapability)cmbOpen.Value;
        DemoRichEdit.Settings.Behavior.PageBreakInsertMode = (PageBreakInsertMode)cmbPageBreakInsertMode.Value;

        DemoRichEdit.Settings.Behavior.Paste = (DocumentCapability)cmbPaste.Value;
        DemoRichEdit.Settings.Behavior.Printing = (DocumentCapability)cmbPrinting.Value;

        DemoRichEdit.Settings.Behavior.Save = (DocumentCapability)cmbSave.Value;
        DemoRichEdit.Settings.Behavior.SaveAs = (DocumentCapability)cmbSaveAs.Value;
        DemoRichEdit.Settings.Behavior.TabMarker = (string)tbTabMarker.Value;

        DemoRichEdit.Settings.DocumentCapabilities.CharacterFormatting = (DocumentCapability)cmbCharacterFormatting.Value;
        DemoRichEdit.Settings.DocumentCapabilities.CharacterStyle = (DocumentCapability)cmbCharacterStyle.Value;
        DemoRichEdit.Settings.DocumentCapabilities.Fields = (DocumentCapability)cmbFields.Value;
        DemoRichEdit.Settings.DocumentCapabilities.Hyperlinks = (DocumentCapability)cmbHyperlinks.Value;
        DemoRichEdit.Settings.DocumentCapabilities.InlinePictures = (DocumentCapability)cmbInlinePictures.Value;
        DemoRichEdit.Settings.DocumentCapabilities.Numbering.Bulleted = (DocumentCapability)cmbNumbering.Value;
        DemoRichEdit.Settings.DocumentCapabilities.Numbering.MultiLevel = (DocumentCapability)cmbNumbering.Value;
        DemoRichEdit.Settings.DocumentCapabilities.Numbering.Simple = (DocumentCapability)cmbNumbering.Value;

        DemoRichEdit.Settings.DocumentCapabilities.ParagraphFormatting = (DocumentCapability)cmbParagraphFormatting.Value;
        DemoRichEdit.Settings.DocumentCapabilities.Paragraphs = (DocumentCapability)cmbParagraphs.Value;
        DemoRichEdit.Settings.DocumentCapabilities.ParagraphStyle = (DocumentCapability)cmbParagraphStyle.Value;
        DemoRichEdit.Settings.DocumentCapabilities.ParagraphTabs = (DocumentCapability)cmbParagraphTabs.Value;
        DemoRichEdit.Settings.DocumentCapabilities.Sections = (DocumentCapability)cmbSections.Value;
        DemoRichEdit.Settings.DocumentCapabilities.TabSymbol = (DocumentCapability)cmbTabSymbol.Value;
        DemoRichEdit.Settings.DocumentCapabilities.Undo = (DocumentCapability)cmbUndo.Value;
        DemoRichEdit.Settings.Behavior.TabMarker = (string)tbTabMarker.Value;
        DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"AynRand.docx"));
    }

    void PrepareEditors() {
        PrepateCombobox(cmbCharacterFormatting, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.CharacterFormatting);
        PrepateCombobox(cmbCharacterStyle, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.CharacterStyle);
        PrepateCombobox(cmbCopy, typeof(DocumentCapability), DemoRichEdit.Settings.Behavior.Copy);
        PrepateCombobox(cmbCreateNew, typeof(DocumentCapability), DemoRichEdit.Settings.Behavior.CreateNew);
        PrepateCombobox(cmbCut, typeof(DocumentCapability), DemoRichEdit.Settings.Behavior.Cut);
        PrepateCombobox(cmbDrag, typeof(DocumentCapability), DemoRichEdit.Settings.Behavior.Drag);
        PrepateCombobox(cmbDrop, typeof(DocumentCapability), DemoRichEdit.Settings.Behavior.Drop);
        PrepateCombobox(cmbFields, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.Fields);
        PrepateCombobox(cmbFullScreen, typeof(DocumentCapability), DemoRichEdit.Settings.Behavior.FullScreen);
        PrepateCombobox(cmbHyperlinks, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.Hyperlinks);
        PrepateCombobox(cmbInlinePictures, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.InlinePictures);
        PrepateCombobox(cmbNumbering, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.Numbering.Simple);
        PrepateCombobox(cmbOpen, typeof(DocumentCapability), DemoRichEdit.Settings.Behavior.Open);
        PrepateCombobox(cmbPageBreakInsertMode, typeof(PageBreakInsertMode), DemoRichEdit.Settings.Behavior.PageBreakInsertMode);
        PrepateCombobox(cmbParagraphFormatting, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.ParagraphFormatting);
        PrepateCombobox(cmbParagraphs, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.Paragraphs);
        PrepateCombobox(cmbParagraphStyle, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.ParagraphStyle);
        PrepateCombobox(cmbParagraphTabs, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.ParagraphTabs);
        PrepateCombobox(cmbPaste, typeof(DocumentCapability), DemoRichEdit.Settings.Behavior.Paste);
        PrepateCombobox(cmbPrinting, typeof(DocumentCapability), DemoRichEdit.Settings.Behavior.Printing);
        PrepateCombobox(cmbSave, typeof(DocumentCapability), DemoRichEdit.Settings.Behavior.Save);
        PrepateCombobox(cmbSaveAs, typeof(DocumentCapability), DemoRichEdit.Settings.Behavior.SaveAs);
        PrepateCombobox(cmbSections, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.Sections);
        PrepateCombobox(cmbTabSymbol, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.TabSymbol);
        PrepateCombobox(cmbUndo, typeof(DocumentCapability), DemoRichEdit.Settings.DocumentCapabilities.Undo);
        tbTabMarker.Value = DemoRichEdit.Settings.Behavior.TabMarker;
    }
    void PrepateCombobox(ASPxComboBox cmb, Type enumType, object value) {
        foreach(var enumValue in Enum.GetValues(enumType)) {
            cmb.Items.Add(Enum.GetName(enumType, enumValue), (int)enumValue);
        }
        cmb.Value = (int)value;
    }
    protected void DemoRichEdit_PreRender(object sender, EventArgs e) {
        DemoRichEdit.Focus();
    }
}

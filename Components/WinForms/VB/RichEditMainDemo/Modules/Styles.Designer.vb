Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class StylesModule
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.FileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.FileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.FileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.FileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.QuickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.PrintItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.PrintPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.UndoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.RedoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.PasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.CutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.CopyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.PasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.GalleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
            Me.ShowDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
            Me.FileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            Me.CommonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            Me.InfoRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup()
            Me.HomeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
            Me.ClipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
            Me.StylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.RichEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.RichEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'richEditControl
            '
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(2, 2)
            Me.richEditControl.MenuManager = Me.RibbonControl1
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.Comments.ShowAllAuthors = False
            Me.richEditControl.Size = New System.Drawing.Size(841, 244)
            Me.richEditControl.TabIndex = 1
            Me.richEditControl.Text = "richEditControl"
            '
            'RibbonControl1
            '
            Me.RibbonControl1.ExpandCollapseItem.Id = 0
            Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.FileNewItem1, Me.FileOpenItem1, Me.FileSaveItem1, Me.FileSaveAsItem1, Me.QuickPrintItem1, Me.PrintItem1, Me.PrintPreviewItem1, Me.UndoItem1, Me.RedoItem1, Me.PasteItem1, Me.CutItem1, Me.CopyItem1, Me.PasteSpecialItem1, Me.GalleryChangeStyleItem1, Me.ShowDocumentPropertiesFormItem1})
            Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.RibbonControl1.MaxItemId = 16
            Me.RibbonControl1.Name = "RibbonControl1"
            Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1, Me.HomeRibbonPage1})
            Me.RibbonControl1.Size = New System.Drawing.Size(845, 141)
            '
            'FileNewItem1
            '
            Me.FileNewItem1.Id = 1
            Me.FileNewItem1.Name = "FileNewItem1"
            '
            'FileOpenItem1
            '
            Me.FileOpenItem1.Id = 2
            Me.FileOpenItem1.Name = "FileOpenItem1"
            '
            'FileSaveItem1
            '
            Me.FileSaveItem1.Id = 3
            Me.FileSaveItem1.Name = "FileSaveItem1"
            '
            'FileSaveAsItem1
            '
            Me.FileSaveAsItem1.Id = 4
            Me.FileSaveAsItem1.Name = "FileSaveAsItem1"
            '
            'QuickPrintItem1
            '
            Me.QuickPrintItem1.Id = 5
            Me.QuickPrintItem1.Name = "QuickPrintItem1"
            '
            'PrintItem1
            '
            Me.PrintItem1.Id = 6
            Me.PrintItem1.Name = "PrintItem1"
            '
            'PrintPreviewItem1
            '
            Me.PrintPreviewItem1.Id = 7
            Me.PrintPreviewItem1.Name = "PrintPreviewItem1"
            '
            'UndoItem1
            '
            Me.UndoItem1.Id = 8
            Me.UndoItem1.Name = "UndoItem1"
            '
            'RedoItem1
            '
            Me.RedoItem1.Id = 9
            Me.RedoItem1.Name = "RedoItem1"
            '
            'PasteItem1
            '
            Me.PasteItem1.Id = 10
            Me.PasteItem1.Name = "PasteItem1"
            '
            'CutItem1
            '
            Me.CutItem1.Id = 11
            Me.CutItem1.Name = "CutItem1"
            '
            'CopyItem1
            '
            Me.CopyItem1.Id = 12
            Me.CopyItem1.Name = "CopyItem1"
            '
            'PasteSpecialItem1
            '
            Me.PasteSpecialItem1.Id = 13
            Me.PasteSpecialItem1.Name = "PasteSpecialItem1"
            '
            'GalleryChangeStyleItem1
            '
            '
            '
            '
            Me.GalleryChangeStyleItem1.Gallery.ColumnCount = 10
            Me.GalleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
            Me.GalleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.GalleryChangeStyleItem1.Id = 14
            Me.GalleryChangeStyleItem1.Name = "GalleryChangeStyleItem1"
            '
            'ShowDocumentPropertiesFormItem1
            '
            Me.ShowDocumentPropertiesFormItem1.Id = 15
            Me.ShowDocumentPropertiesFormItem1.Name = "ShowDocumentPropertiesFormItem1"
            '
            'FileRibbonPage1
            '
            Me.FileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.CommonRibbonPageGroup1, Me.InfoRibbonPageGroup1})
            Me.FileRibbonPage1.Name = "FileRibbonPage1"
            '
            'CommonRibbonPageGroup1
            '
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.UndoItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.RedoItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileNewItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileOpenItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileSaveItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileSaveAsItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.QuickPrintItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.PrintItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.PrintPreviewItem1)
            Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
            '
            'InfoRibbonPageGroup1
            '
            Me.InfoRibbonPageGroup1.ItemLinks.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.InfoRibbonPageGroup1.Name = "InfoRibbonPageGroup1"
            '
            'HomeRibbonPage1
            '
            Me.HomeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ClipboardRibbonPageGroup1, Me.StylesRibbonPageGroup1})
            Me.HomeRibbonPage1.Name = "HomeRibbonPage1"
            '
            'ClipboardRibbonPageGroup1
            '
            Me.ClipboardRibbonPageGroup1.ItemLinks.Add(Me.PasteItem1)
            Me.ClipboardRibbonPageGroup1.ItemLinks.Add(Me.CutItem1)
            Me.ClipboardRibbonPageGroup1.ItemLinks.Add(Me.CopyItem1)
            Me.ClipboardRibbonPageGroup1.ItemLinks.Add(Me.PasteSpecialItem1)
            Me.ClipboardRibbonPageGroup1.Name = "ClipboardRibbonPageGroup1"
            '
            'StylesRibbonPageGroup1
            '
            Me.StylesRibbonPageGroup1.ItemLinks.Add(Me.GalleryChangeStyleItem1)
            Me.StylesRibbonPageGroup1.Name = "StylesRibbonPageGroup1"
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.richEditControl)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 141)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(845, 248)
            Me.panelControl1.TabIndex = 4
            '
            'RichEditBarController1
            '
            Me.RichEditBarController1.BarItems.Add(Me.FileNewItem1)
            Me.RichEditBarController1.BarItems.Add(Me.FileOpenItem1)
            Me.RichEditBarController1.BarItems.Add(Me.FileSaveItem1)
            Me.RichEditBarController1.BarItems.Add(Me.FileSaveAsItem1)
            Me.RichEditBarController1.BarItems.Add(Me.QuickPrintItem1)
            Me.RichEditBarController1.BarItems.Add(Me.PrintItem1)
            Me.RichEditBarController1.BarItems.Add(Me.PrintPreviewItem1)
            Me.RichEditBarController1.BarItems.Add(Me.UndoItem1)
            Me.RichEditBarController1.BarItems.Add(Me.RedoItem1)
            Me.RichEditBarController1.BarItems.Add(Me.PasteItem1)
            Me.RichEditBarController1.BarItems.Add(Me.CutItem1)
            Me.RichEditBarController1.BarItems.Add(Me.CopyItem1)
            Me.RichEditBarController1.BarItems.Add(Me.PasteSpecialItem1)
            Me.RichEditBarController1.BarItems.Add(Me.GalleryChangeStyleItem1)
            Me.RichEditBarController1.BarItems.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.RichEditBarController1.Control = Me.richEditControl
            '
            'StylesModule
            '
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.RibbonControl1)
            Me.Name = "StylesModule"
            Me.Size = New System.Drawing.Size(845, 389)
            CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.RichEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private richEditControl As RichEditControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Friend WithEvents FileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
        Friend WithEvents FileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
        Friend WithEvents FileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
        Friend WithEvents FileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
        Friend WithEvents QuickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
        Friend WithEvents PrintItem1 As DevExpress.XtraRichEdit.UI.PrintItem
        Friend WithEvents PrintPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
        Friend WithEvents UndoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Friend WithEvents RedoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Friend WithEvents PasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
        Friend WithEvents CutItem1 As DevExpress.XtraRichEdit.UI.CutItem
        Friend WithEvents CopyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
        Friend WithEvents PasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
        Friend WithEvents GalleryChangeStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem
        Friend WithEvents HomeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
        Friend WithEvents ClipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
        Friend WithEvents StylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
        Friend WithEvents RichEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Friend WithEvents FileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
        Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
        Friend WithEvents ShowDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem
        Friend WithEvents InfoRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup

	End Class
End Namespace

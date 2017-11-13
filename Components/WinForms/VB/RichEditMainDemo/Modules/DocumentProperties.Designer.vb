Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class DocumentProperties
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DocumentProperties))
			Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
			Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
			Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
			Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
			Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
			Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
			Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
			Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
			Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
			Me.showDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
			Me.insertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
			Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
			Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
			Me.toggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
			Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
			Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
			Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
			Me.infoRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup()
			Me.mailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
			Me.mailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richEditControl
			' 
			Me.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
			Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl.Location = New System.Drawing.Point(0, 141)
			Me.richEditControl.MenuManager = Me.ribbonControl1
			Me.richEditControl.Name = "richEditControl"
			Me.richEditControl.Options.Comments.ShowAllAuthors = False
			Me.richEditControl.Size = New System.Drawing.Size(1300, 467)
			Me.richEditControl.TabIndex = 13
			Me.richEditControl.Text = "richEditControl1"
'			Me.richEditControl.CalculateDocumentVariable += New DevExpress.XtraRichEdit.CalculateDocumentVariableEventHandler(Me.OnCalculateDocumentVariable);
'			Me.richEditControl.DocumentPropertiesChanged += New System.EventHandler(Me.RichEditControl_DocumentPropertiesChanged);
'			Me.richEditControl.CustomPropertiesChanged += New System.EventHandler(Me.RichEditControl_CustomPropertiesChanged);
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.undoItem1, Me.redoItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.showDocumentPropertiesFormItem1, Me.insertMergeFieldItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleViewMergedDataItem1, Me.barSubItem1, Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem7, Me.barButtonItem5, Me.barButtonItem9, Me.barButtonItem6, Me.barButtonItem8, Me.barButtonItem10, Me.barButtonItem11, Me.barButtonItem16})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 38
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.mailingsRibbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBox1})
			Me.ribbonControl1.Size = New System.Drawing.Size(1300, 141)
			' 
			' undoItem1
			' 
			Me.undoItem1.Id = 1
			Me.undoItem1.Name = "undoItem1"
			' 
			' redoItem1
			' 
			Me.redoItem1.Id = 2
			Me.redoItem1.Name = "redoItem1"
			' 
			' fileNewItem1
			' 
			Me.fileNewItem1.Id = 3
			Me.fileNewItem1.Name = "fileNewItem1"
			' 
			' fileOpenItem1
			' 
			Me.fileOpenItem1.Id = 4
			Me.fileOpenItem1.Name = "fileOpenItem1"
			' 
			' fileSaveItem1
			' 
			Me.fileSaveItem1.Id = 5
			Me.fileSaveItem1.Name = "fileSaveItem1"
			' 
			' fileSaveAsItem1
			' 
			Me.fileSaveAsItem1.Id = 6
			Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
			' 
			' quickPrintItem1
			' 
			Me.quickPrintItem1.Id = 7
			Me.quickPrintItem1.Name = "quickPrintItem1"
			' 
			' printItem1
			' 
			Me.printItem1.Id = 8
			Me.printItem1.Name = "printItem1"
			' 
			' printPreviewItem1
			' 
			Me.printPreviewItem1.Id = 9
			Me.printPreviewItem1.Name = "printPreviewItem1"
			' 
			' showDocumentPropertiesFormItem1
			' 
			Me.showDocumentPropertiesFormItem1.Id = 10
			Me.showDocumentPropertiesFormItem1.Name = "showDocumentPropertiesFormItem1"
			' 
			' insertMergeFieldItem1
			' 
			Me.insertMergeFieldItem1.Id = 11
			Me.insertMergeFieldItem1.Name = "insertMergeFieldItem1"
			' 
			' showAllFieldCodesItem1
			' 
			Me.showAllFieldCodesItem1.Id = 12
			Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
			' 
			' showAllFieldResultsItem1
			' 
			Me.showAllFieldResultsItem1.Id = 13
			Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
			' 
			' toggleViewMergedDataItem1
			' 
			Me.toggleViewMergedDataItem1.Id = 14
			Me.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
			' 
			' barSubItem1
			' 
			Me.barSubItem1.Caption = "Insert Document Property"
			Me.barSubItem1.Glyph = (CType(resources.GetObject("barSubItem1.Glyph"), System.Drawing.Image))
			Me.barSubItem1.Id = 16
			Me.barSubItem1.LargeGlyph = (CType(resources.GetObject("barSubItem1.LargeGlyph"), System.Drawing.Image))
			Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem11)})
			Me.barSubItem1.Name = "barSubItem1"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Category"
			Me.barButtonItem1.Id = 17
			Me.barButtonItem1.Name = "barButtonItem1"
'			Me.barButtonItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnCategoryItemClick);
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "Created"
			Me.barButtonItem2.Id = 20
			Me.barButtonItem2.Name = "barButtonItem2"
'			Me.barButtonItem2.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnCreatedItemClick);
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "Creator"
			Me.barButtonItem3.Id = 21
			Me.barButtonItem3.Name = "barButtonItem3"
'			Me.barButtonItem3.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnCreatorItemClick);
			' 
			' barButtonItem4
			' 
			Me.barButtonItem4.Caption = "Description"
			Me.barButtonItem4.Id = 22
			Me.barButtonItem4.Name = "barButtonItem4"
'			Me.barButtonItem4.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnDescriptionItemClick);
			' 
			' barButtonItem5
			' 
			Me.barButtonItem5.Caption = "Keywords"
			Me.barButtonItem5.Id = 24
			Me.barButtonItem5.Name = "barButtonItem5"
'			Me.barButtonItem5.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnKeywordsItemClick);
			' 
			' barButtonItem6
			' 
			Me.barButtonItem6.Caption = "LastModifiedBy"
			Me.barButtonItem6.Id = 26
			Me.barButtonItem6.Name = "barButtonItem6"
'			Me.barButtonItem6.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnLastModifiedByItemClick);
			' 
			' barButtonItem7
			' 
			Me.barButtonItem7.Caption = "LastPrinted"
			Me.barButtonItem7.Id = 27
			Me.barButtonItem7.Name = "barButtonItem7"
'			Me.barButtonItem7.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnLastPrintedItemClick);
			' 
			' barButtonItem8
			' 
			Me.barButtonItem8.Caption = "Modified"
			Me.barButtonItem8.Id = 28
			Me.barButtonItem8.Name = "barButtonItem8"
'			Me.barButtonItem8.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnModifiedItemClick);
			' 
			' barButtonItem9
			' 
			Me.barButtonItem9.Caption = "Revision"
			Me.barButtonItem9.Id = 29
			Me.barButtonItem9.Name = "barButtonItem9"
'			Me.barButtonItem9.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnRevisionItemClick);
			' 
			' barButtonItem10
			' 
			Me.barButtonItem10.Caption = "Subject"
			Me.barButtonItem10.Id = 30
			Me.barButtonItem10.Name = "barButtonItem10"
'			Me.barButtonItem10.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnSubjectItemClick);
			' 
			' barButtonItem11
			' 
			Me.barButtonItem11.Caption = "Title"
			Me.barButtonItem11.Id = 31
			Me.barButtonItem11.Name = "barButtonItem11"
'			Me.barButtonItem11.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnTitleItemClick);
			' 
			' barButtonItem16
			' 
			Me.barButtonItem16.Id = 37
			Me.barButtonItem16.Name = "barButtonItem16"
			' 
			' fileRibbonPage1
			' 
			Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.infoRibbonPageGroup1})
			Me.fileRibbonPage1.Name = "fileRibbonPage1"
			' 
			' commonRibbonPageGroup1
			' 
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
			Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
			' 
			' infoRibbonPageGroup1
			' 
			Me.infoRibbonPageGroup1.ItemLinks.Add(Me.showDocumentPropertiesFormItem1)
			Me.infoRibbonPageGroup1.ItemLinks.Add(Me.barSubItem1)
			Me.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1"
			' 
			' mailingsRibbonPage1
			' 
			Me.mailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.mailMergeRibbonPageGroup1})
			Me.mailingsRibbonPage1.Name = "mailingsRibbonPage1"
			' 
			' mailMergeRibbonPageGroup1
			' 
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.insertMergeFieldItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.toggleViewMergedDataItem1)
			Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			' 
			' richEditBarController1
			' 
			Me.richEditBarController1.BarItems.Add(Me.undoItem1)
			Me.richEditBarController1.BarItems.Add(Me.redoItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
			Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
			Me.richEditBarController1.BarItems.Add(Me.printItem1)
			Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
			Me.richEditBarController1.BarItems.Add(Me.showDocumentPropertiesFormItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertMergeFieldItem1)
			Me.richEditBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
			Me.richEditBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleViewMergedDataItem1)
			Me.richEditBarController1.Control = Me.richEditControl
			' 
			' DocumentProperties
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.richEditControl)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "DocumentProperties"
			Me.Size = New System.Drawing.Size(1300, 608)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents richEditControl As RichEditControl
		Private richEditBarController1 As UI.RichEditBarController
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private undoItem1 As UI.UndoItem
		Private redoItem1 As UI.RedoItem
		Private fileNewItem1 As UI.FileNewItem
		Private fileOpenItem1 As UI.FileOpenItem
		Private fileSaveItem1 As UI.FileSaveItem
		Private fileSaveAsItem1 As UI.FileSaveAsItem
		Private quickPrintItem1 As UI.QuickPrintItem
		Private printItem1 As UI.PrintItem
		Private printPreviewItem1 As UI.PrintPreviewItem
		Private showDocumentPropertiesFormItem1 As UI.ShowDocumentPropertiesFormItem
		Private fileRibbonPage1 As UI.FileRibbonPage
		Private commonRibbonPageGroup1 As UI.CommonRibbonPageGroup
		Private infoRibbonPageGroup1 As UI.InfoRibbonPageGroup
		Private insertMergeFieldItem1 As UI.InsertMergeFieldItem
		Private showAllFieldCodesItem1 As UI.ShowAllFieldCodesItem
		Private showAllFieldResultsItem1 As UI.ShowAllFieldResultsItem
		Private toggleViewMergedDataItem1 As UI.ToggleViewMergedDataItem
		Private mailingsRibbonPage1 As UI.MailingsRibbonPage
		Private mailMergeRibbonPageGroup1 As UI.MailMergeRibbonPageGroup
		Private barSubItem1 As XtraBars.BarSubItem
		Private WithEvents barButtonItem1 As XtraBars.BarButtonItem
		Private WithEvents barButtonItem2 As XtraBars.BarButtonItem
		Private WithEvents barButtonItem3 As XtraBars.BarButtonItem
		Private WithEvents barButtonItem4 As XtraBars.BarButtonItem
		Private WithEvents barButtonItem5 As XtraBars.BarButtonItem
		Private WithEvents barButtonItem6 As XtraBars.BarButtonItem
		Private WithEvents barButtonItem7 As XtraBars.BarButtonItem
		Private WithEvents barButtonItem8 As XtraBars.BarButtonItem
		Private WithEvents barButtonItem9 As XtraBars.BarButtonItem
		Private WithEvents barButtonItem10 As XtraBars.BarButtonItem
		Private WithEvents barButtonItem11 As XtraBars.BarButtonItem
		Private barButtonItem16 As XtraBars.BarButtonItem
		Private repositoryItemComboBox1 As XtraEditors.Repository.RepositoryItemComboBox
	End Class
End Namespace

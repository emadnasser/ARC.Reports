Imports Microsoft.VisualBasic
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports DevExpress.Docs.Demos
Imports DevExpress.DXperience.Demos
Imports DevExpress.Export.Xl
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting.Control
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraSpreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Services.Implementation
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes
Imports Microsoft.Build.Evaluation
Imports Microsoft.CSharp

Namespace DevExpress.Docs.Demos
	#Region "XLExportAPIModule"
	Public Class XLExportAPIModule
		Inherits TutorialControlBase
		Private treeList1 As TreeList
		Private verticalSplitContainerControl1 As SplitContainerControl
		Private xtraTabControl1 As XtraTab.XtraTabControl
		Private xtraTabPage1 As XtraTab.XtraTabPage
		Private richEditControlCS As RichEditControl
		Private xtraTabPage2 As XtraTab.XtraTabPage
		Private richEditControlVB As RichEditControl
		Private codeExampleNameLbl As LabelControl
		Private pnlButtons As PanelControl
		Private WithEvents btnExportToCSV As SimpleButton
		Private WithEvents btnExportToXLS As SimpleButton
		Private WithEvents btnExportToXLSX As SimpleButton

		Private codeEditor_Renamed As ExampleCodeEditor
		Private treeListRootNodeLoading As Boolean = True
		Private chbOpenResultingFile As CheckEdit
		Private examples As List(Of CodeExampleGroup)

		Public Sub New()
			InitializeComponent()

			Dim examplePath As String = CodeExampleDemoUtils.GetExamplePath(ExamplesFolderName)
			Dim examplesCS As Dictionary(Of String, FileInfo) = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp)
			Dim examplesVB As Dictionary(Of String, FileInfo) = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB)

			DisableTabs(examplesCS.Count, examplesVB.Count)
			DisableButtons(examplesCS.Count, examplesVB.Count)
			examples = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB)

			ShowExamplesInTreeList(treeList1, examples)
			Me.codeEditor_Renamed = New ExampleCodeEditor(richEditControlCS, richEditControlVB)
			CurrentExampleLanguage = CodeExampleDemoUtils.DetectExampleLanguage(DemoProjectName)
			ShowFirstExample()
			AddHandler xtraTabControl1.SelectedPageChanged, AddressOf xtraTabControl1_SelectedPageChanged
		End Sub

		Public ReadOnly Property ExamplesFolderName() As String
			Get
				Return "CodeExamples\XLExport"
			End Get
		End Property
		Public ReadOnly Property DemoProjectName() As String
			Get
				Return "DocsMainDemo"
			End Get
		End Property
		Public ReadOnly Property DemoName() As String
			Get
				Return "XL Export demo"
			End Get
		End Property
		Protected ReadOnly Property CodeEditor() As ExampleCodeEditor
			Get
				Return codeEditor_Renamed
			End Get
		End Property

		#Region "InitializeComponent"
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XLExportAPIModule))
			Me.pnlButtons = New DevExpress.XtraEditors.PanelControl()
			Me.btnExportToCSV = New DevExpress.XtraEditors.SimpleButton()
			Me.btnExportToXLS = New DevExpress.XtraEditors.SimpleButton()
			Me.btnExportToXLSX = New DevExpress.XtraEditors.SimpleButton()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.richEditControlCS = New DevExpress.XtraRichEdit.RichEditControl()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.richEditControlVB = New DevExpress.XtraRichEdit.RichEditControl()
			Me.codeExampleNameLbl = New DevExpress.XtraEditors.LabelControl()
			Me.verticalSplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.chbOpenResultingFile = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.pnlButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlButtons.SuspendLayout()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.verticalSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.verticalSplitContainerControl1.SuspendLayout()
			CType(Me.chbOpenResultingFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pnlButtons
			' 
			Me.pnlButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlButtons.Controls.Add(Me.chbOpenResultingFile)
			Me.pnlButtons.Controls.Add(Me.btnExportToCSV)
			Me.pnlButtons.Controls.Add(Me.btnExportToXLS)
			Me.pnlButtons.Controls.Add(Me.btnExportToXLSX)
			Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.pnlButtons.Location = New System.Drawing.Point(0, 627)
			Me.pnlButtons.Name = "pnlButtons"
			Me.pnlButtons.Size = New System.Drawing.Size(1000, 67)
			Me.pnlButtons.TabIndex = 9
			' 
			' btnExportToCSV
			' 
			Me.btnExportToCSV.Image = (CType(resources.GetObject("btnExportToCSV.Image"), System.Drawing.Image))
			Me.btnExportToCSV.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
			Me.btnExportToCSV.Location = New System.Drawing.Point(192, 6)
			Me.btnExportToCSV.Name = "btnExportToCSV"
			Me.btnExportToCSV.Size = New System.Drawing.Size(90, 59)
			Me.btnExportToCSV.TabIndex = 2
			Me.btnExportToCSV.Text = "Export to CSV"
'			Me.btnExportToCSV.Click += New System.EventHandler(Me.btnExportToCSV_Click);
			' 
			' btnExportToXLS
			' 
			Me.btnExportToXLS.Image = (CType(resources.GetObject("btnExportToXLS.Image"), System.Drawing.Image))
			Me.btnExportToXLS.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
			Me.btnExportToXLS.Location = New System.Drawing.Point(96, 6)
			Me.btnExportToXLS.Name = "btnExportToXLS"
			Me.btnExportToXLS.Size = New System.Drawing.Size(90, 59)
			Me.btnExportToXLS.TabIndex = 1
			Me.btnExportToXLS.Text = "Export to XLS"
'			Me.btnExportToXLS.Click += New System.EventHandler(Me.btnExportToXLS_Click);
			' 
			' btnExportToXLSX
			' 
			Me.btnExportToXLSX.Image = (CType(resources.GetObject("btnExportToXLSX.Image"), System.Drawing.Image))
			Me.btnExportToXLSX.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
			Me.btnExportToXLSX.Location = New System.Drawing.Point(0, 6)
			Me.btnExportToXLSX.Name = "btnExportToXLSX"
			Me.btnExportToXLSX.Size = New System.Drawing.Size(90, 59)
			Me.btnExportToXLSX.TabIndex = 0
			Me.btnExportToXLSX.Text = "Export to XLSX"
'			Me.btnExportToXLSX.Click += New System.EventHandler(Me.btnExportToXLSX_Click);
			' 
			' treeList1
			' 
			Me.treeList1.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline)
			Me.treeList1.Appearance.FocusedCell.Options.UseFont = True
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(223, 694)
			Me.treeList1.TabIndex = 8
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.AppearancePage.PageClient.BackColor = System.Drawing.Color.Transparent
			Me.xtraTabControl1.AppearancePage.PageClient.BackColor2 = System.Drawing.Color.Transparent
			Me.xtraTabControl1.AppearancePage.PageClient.BorderColor = System.Drawing.Color.Transparent
			Me.xtraTabControl1.AppearancePage.PageClient.Options.UseBackColor = True
			Me.xtraTabControl1.AppearancePage.PageClient.Options.UseBorderColor = True
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 44)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(1000, 583)
			Me.xtraTabControl1.TabIndex = 12
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.xtraTabPage1.Appearance.HeaderActive.Options.UseFont = True
			Me.xtraTabPage1.Controls.Add(Me.richEditControlCS)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(994, 555)
			Me.xtraTabPage1.Text = "C#"
			' 
			' richEditControlCS
			' 
			Me.richEditControlCS.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
			Me.richEditControlCS.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControlCS.EnableToolTips = True
			Me.richEditControlCS.Location = New System.Drawing.Point(0, 0)
			Me.richEditControlCS.Name = "richEditControlCS"
			Me.richEditControlCS.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never
			Me.richEditControlCS.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
			Me.richEditControlCS.Size = New System.Drawing.Size(994, 555)
			Me.richEditControlCS.TabIndex = 14
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.xtraTabPage2.Appearance.HeaderActive.Options.UseFont = True
			Me.xtraTabPage2.Controls.Add(Me.richEditControlVB)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(994, 555)
			Me.xtraTabPage2.Text = "VB"
			' 
			' richEditControlVB
			' 
			Me.richEditControlVB.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
			Me.richEditControlVB.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControlVB.EnableToolTips = True
			Me.richEditControlVB.Location = New System.Drawing.Point(0, 0)
			Me.richEditControlVB.Name = "richEditControlVB"
			Me.richEditControlVB.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never
			Me.richEditControlVB.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
			Me.richEditControlVB.Size = New System.Drawing.Size(994, 555)
			Me.richEditControlVB.TabIndex = 15
			' 
			' codeExampleNameLbl
			' 
			Me.codeExampleNameLbl.Appearance.Font = New System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.codeExampleNameLbl.Dock = System.Windows.Forms.DockStyle.Top
			Me.codeExampleNameLbl.Location = New System.Drawing.Point(0, 0)
			Me.codeExampleNameLbl.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
			Me.codeExampleNameLbl.Name = "codeExampleNameLbl"
			Me.codeExampleNameLbl.Padding = New System.Windows.Forms.Padding(0, 0, 0, 12)
			Me.codeExampleNameLbl.Size = New System.Drawing.Size(238, 44)
			Me.codeExampleNameLbl.TabIndex = 10
			Me.codeExampleNameLbl.Text = "Examples not found"
			' 
			' verticalSplitContainerControl1
			' 
			Me.verticalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.verticalSplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
			Me.verticalSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.verticalSplitContainerControl1.Name = "verticalSplitContainerControl1"
			Me.verticalSplitContainerControl1.Panel1.Controls.Add(Me.xtraTabControl1)
			Me.verticalSplitContainerControl1.Panel1.Controls.Add(Me.codeExampleNameLbl)
			Me.verticalSplitContainerControl1.Panel1.Controls.Add(Me.pnlButtons)
			Me.verticalSplitContainerControl1.Panel1.Text = "Panel1"
			Me.verticalSplitContainerControl1.Panel2.Controls.Add(Me.treeList1)
			Me.verticalSplitContainerControl1.Panel2.MinSize = 223
			Me.verticalSplitContainerControl1.Panel2.Text = "Panel2"
			Me.verticalSplitContainerControl1.Size = New System.Drawing.Size(1228, 694)
			Me.verticalSplitContainerControl1.SplitterPosition = 223
			Me.verticalSplitContainerControl1.TabIndex = 0
			Me.verticalSplitContainerControl1.Text = "verticalSplitContainerControl1"
			' 
			' chbOpenResultingFile
			' 
			Me.chbOpenResultingFile.EditValue = True
			Me.chbOpenResultingFile.Location = New System.Drawing.Point(292, 6)
			Me.chbOpenResultingFile.Name = "chbOpenResultingFile"
			Me.chbOpenResultingFile.Properties.Caption = "Open resulting file"
			Me.chbOpenResultingFile.Size = New System.Drawing.Size(235, 19)
			Me.chbOpenResultingFile.TabIndex = 3
			' 
			' XLExportAPIModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.verticalSplitContainerControl1)
			Me.Name = "XLExportAPIModule"
			Me.Size = New System.Drawing.Size(1228, 694)
			CType(Me.pnlButtons, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlButtons.ResumeLayout(False)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.verticalSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.verticalSplitContainerControl1.ResumeLayout(False)
			CType(Me.chbOpenResultingFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Property CurrentExampleLanguage() As ExampleLanguage
			Get
				Return CType(xtraTabControl1.SelectedTabPageIndex, ExampleLanguage)
			End Get
			Set(ByVal value As ExampleLanguage)
				Me.codeEditor_Renamed.CurrentExampleLanguage = value
				xtraTabControl1.SelectedTabPageIndex = If((value = ExampleLanguage.Csharp), 0, 1)
			End Set
		End Property

		Private Sub RunExample(ByVal fileName As String, ByVal documentFormat As XlDocumentFormat)
			CodeEditor.BeforeCompile()
			Dim evaluator As XLExportExampleCodeEvaluator = CreateEvaluator()
			evaluator.Control = Me
			Dim imagePath As String = DemoUtils.GetRelativeDirectoryPath("Images")
			Dim result As CodeEvaluationResult = evaluator.ExecuteCodeAndGenerateDocument(codeEditor_Renamed.CurrentCodeEditor.Text, New Object() { fileName, documentFormat, imagePath })
			CodeEditor.AfterCompile(result <> CodeEvaluationResult.CompileErrors)
			If result = CodeEvaluationResult.Success Then
				ShowFile(fileName)
			End If
		End Sub

		Private Function CreateEvaluator() As XLExportExampleCodeEvaluator
			If CurrentExampleLanguage = ExampleLanguage.VB Then
				Return New XLExportVBExampleCodeEvaluator()
			End If
			Return New XLExportCSExampleCodeEvaluator()
		End Function

		Private Sub DisableTabs(ByVal examplesCSCount As Integer, ByVal examplesVBCount As Integer)
			If examplesCSCount = 0 Then
				xtraTabControl1.TabPages(CInt(Fix(ExampleLanguage.Csharp))).PageEnabled = False
			End If
			If examplesVBCount = 0 Then
				xtraTabControl1.TabPages(CInt(Fix(ExampleLanguage.VB))).PageEnabled = False
			End If
		End Sub

		Private Sub DisableButtons(ByVal examplesCSCount As Integer, ByVal examplesVBCount As Integer)
			If examplesCSCount = 0 AndAlso examplesVBCount = 0 Then
				btnExportToCSV.Enabled = False
				btnExportToXLS.Enabled = False
				btnExportToXLSX.Enabled = False
			End If
		End Sub

		Private Sub ShowFirstExample()
			treeList1.ExpandAll()
			If treeList1.Nodes.Count > 0 Then
				treeList1.FocusedNode = treeList1.MoveFirst().FirstNode
			End If
		End Sub

		Private Sub OnNewExampleSelected(ByVal sender As Object, ByVal e As FocusedNodeChangedEventArgs)
			Dim newExample As CodeExample = TryCast((TryCast(sender, TreeList)).GetDataRecordByNode(e.Node), CodeExample)
			Dim oldExample As CodeExample = TryCast((TryCast(sender, TreeList)).GetDataRecordByNode(e.OldNode), CodeExample)

			If newExample Is Nothing Then
				Return
			End If

			Dim exampleCode As String = codeEditor_Renamed.ShowExample(oldExample, newExample)
			codeExampleNameLbl.Text = CodeExampleDemoUtils.ConvertStringToMoreHumanReadableForm(newExample.RegionName) & " example"
			EnableButtons(newExample.RegionName)
		End Sub

		Private Sub EnableButtons(ByVal exampleName As String)
			btnExportToXLS.Enabled = Not XLExportForbiddenXLSExamples.Examples.Contains(exampleName)
			btnExportToCSV.Enabled = Not XLExportForbiddenCSVExamples.Examples.Contains(exampleName)
		End Sub

		Private Sub ShowExamplesInTreeList(ByVal treeList As TreeList, ByVal examples As List(Of CodeExampleGroup))
			treeList.OptionsPrint.UsePrintStyles = True
			AddHandler treeList.FocusedNodeChanged, AddressOf OnNewExampleSelected
			treeList.OptionsView.ShowColumns = False
			treeList.OptionsView.ShowIndicator = False

			AddHandler treeList.VirtualTreeGetChildNodes, AddressOf treeList_VirtualTreeGetChildNodes
			AddHandler treeList.VirtualTreeGetCellValue, AddressOf treeList_VirtualTreeGetCellValue

			Dim col1 As New TreeListColumn()
			col1.VisibleIndex = 0
			col1.OptionsColumn.AllowEdit = False
			col1.OptionsColumn.AllowMove = False
			col1.OptionsColumn.ReadOnly = True
			treeList.Columns.AddRange(New TreeListColumn() { col1 })

			treeList.DataSource = New Object()
			treeList.ExpandAll()
		End Sub

		Private Sub treeList_VirtualTreeGetCellValue(ByVal sender As Object, ByVal args As VirtualTreeGetCellValueInfo)
			Dim group As CodeExampleGroup = TryCast(args.Node, CodeExampleGroup)
			If group IsNot Nothing Then
				args.CellData = group.Name
			End If

			Dim example As CodeExample = TryCast(args.Node, CodeExample)
			If example IsNot Nothing Then
				args.CellData = example.RegionName
			End If
		End Sub

		Private Sub treeList_VirtualTreeGetChildNodes(ByVal sender As Object, ByVal args As VirtualTreeGetChildNodesInfo)
			If treeListRootNodeLoading Then
				args.Children = examples
				treeListRootNodeLoading = False
			Else
				If args.Node Is Nothing Then
					Return
				End If
				Dim group As CodeExampleGroup = TryCast(args.Node, CodeExampleGroup)
				If group IsNot Nothing Then
					args.Children = group.Examples
				End If
			End If
		End Sub

		Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As XtraTab.TabPageChangedEventArgs)
			Dim value As ExampleLanguage = CType(xtraTabControl1.SelectedTabPageIndex, ExampleLanguage)
			If codeEditor_Renamed IsNot Nothing Then
				Me.codeEditor_Renamed.CurrentExampleLanguage = value
			End If
		End Sub

		Private Sub ShowFirstExample(ByVal treelist As TreeList)
			treelist.ExpandAll()
			If treelist.Nodes.Count > 0 Then
				treelist.FocusedNode = treelist.MoveFirst().FirstNode
			End If
		End Sub

		Private Function GetSaveFileName(ByVal filter As String, ByVal defaulName As String) As String
			Dim sfDialog As New SaveFileDialog()
			sfDialog.Filter = filter
			sfDialog.FileName = defaulName
			If sfDialog.ShowDialog() <> DialogResult.OK Then
				Return Nothing
			End If
			Return sfDialog.FileName
		End Function
		Private Sub ShowFile(ByVal fileName As String)
			If (Not File.Exists(fileName)) Then
				Return
			End If
			If chbOpenResultingFile.Checked Then
				Process.Start(fileName)
			End If
		End Sub

		Private Sub btnExportToXLSX_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportToXLSX.Click
			Dim fileName As String = GetSaveFileName("Excel Workbook files(*.xlsx)|*.xlsx", "Document.xlsx")
			If String.IsNullOrEmpty(fileName) Then
				Return
			End If
			RunExample(fileName, XlDocumentFormat.Xlsx)
		End Sub

		Private Sub btnExportToXLS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportToXLS.Click
			Dim fileName As String = GetSaveFileName("Excel 97-2003 Workbook files(*.xls)|*.xls", "Document.xls")
			If String.IsNullOrEmpty(fileName) Then
				Return
			End If
			RunExample(fileName, XlDocumentFormat.Xls)
		End Sub

		Private Sub btnExportToCSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportToCSV.Click
			Dim fileName As String = GetSaveFileName("CSV (Comma delimited files)(*.csv)|*.csv", "Document.csv")
			If String.IsNullOrEmpty(fileName) Then
				Return
			End If
			RunExample(fileName, XlDocumentFormat.Csv)
		End Sub
	End Class
	#End Region
	#Region "XLExportExampleCodeEvaluator"
	Public MustInherit Class XLExportExampleCodeEvaluator
		Inherits XLExportExampleCodeEvaluatorBase
		Private privateControl As XtraUserControl
		Public Property Control() As XtraUserControl
			Get
				Return privateControl
			End Get
			Set(ByVal value As XtraUserControl)
				privateControl = value
			End Set
		End Property

		Protected Overrides Sub ShowErrorMessage(ByVal message As String)
			If Control Is Nothing Then
				XtraMessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Else
				XtraMessageBox.Show(Control.LookAndFeel, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			End If
		End Sub
	End Class
	#End Region
	#Region "XLExportCSExampleCodeEvaluator"
	Public Class XLExportCSExampleCodeEvaluator
		Inherits XLExportExampleCodeEvaluator

		Private Const codeStart_Renamed As String = "using System;" & Constants.vbCrLf & "using System.Collections.Generic;" & Constants.vbCrLf & "using System.IO;" & Constants.vbCrLf & "using System.Text;" & Constants.vbCrLf & "using System.Diagnostics;" & Constants.vbCrLf & "using System.Xml;" & Constants.vbCrLf & "using System.Data;" & Constants.vbCrLf & "using System.Drawing;" & Constants.vbCrLf & "using System.Windows.Forms;" & Constants.vbCrLf & "using System.Globalization;" & Constants.vbCrLf & "using DevExpress.Export.Xl;" & Constants.vbCrLf & "using DevExpress.XtraExport.Csv;" & Constants.vbCrLf & "using DevExpress.Spreadsheet;" & Constants.vbCrLf & "using DevExpress.Utils;" & Constants.vbCrLf & "namespace XLExportExampleCode { " & Constants.vbCrLf & "public class ExampleItem { " & Constants.vbCrLf & "        public static void Process(string filePath, XlDocumentFormat documentFormat, string imagesPath) { " & Constants.vbCrLf & "            using (FileStream stream = new FileStream(filePath, FileMode.Create)) { " & Constants.vbCrLf & Constants.vbCrLf

		Private Const codeEnd_Renamed As String = "       " & Constants.vbCrLf & " }" & Constants.vbCrLf & "       " & Constants.vbCrLf & " }" & Constants.vbCrLf & "    }" & Constants.vbCrLf & "}" & Constants.vbCrLf

		Protected Overrides ReadOnly Property CodeStart() As String
			Get
				Return codeStart_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property CodeEnd() As String
			Get
				Return codeEnd_Renamed
			End Get
		End Property

		Protected Overrides Function GetCodeDomProvider() As CodeDomProvider
			Return New CSharpCodeProvider()
		End Function
	End Class
	#End Region
	#Region "XLExportVBExampleCodeEvaluator"
	Public Class XLExportVBExampleCodeEvaluator
		Inherits XLExportExampleCodeEvaluator

		Private Const codeStart_Renamed As String = "Imports Microsoft.VisualBasic" & Constants.vbCrLf & "Imports System" & Constants.vbCrLf & "Imports DevExpress.Spreadsheet" & Constants.vbCrLf & "Imports DevExpress.Export.Xl" & Constants.vbCrLf & "Imports DevExpress.XtraExport.Csv" & Constants.vbCrLf & "Imports System.Drawing" & Constants.vbCrLf & "Imports System.Windows.Forms" & Constants.vbCrLf & "Imports DevExpress.Utils" & Constants.vbCrLf & "Imports System.IO" & Constants.vbCrLf & "Imports System.Text" & Constants.vbCrLf & "Imports System.Diagnostics" & Constants.vbCrLf & "Imports System.Xml" & Constants.vbCrLf & "Imports System.Data" & Constants.vbCrLf & "Imports System.Collections.Generic" & Constants.vbCrLf & "Imports System.Globalization" & Constants.vbCrLf & "Namespace XLExportExampleCode" & Constants.vbCrLf & "	Public Class ExampleItem" & Constants.vbCrLf & "		Public Shared Sub Process(ByVal filePath As String, ByVal documentFormat As XlDocumentFormat, ByVal imagesPath As String)" & Constants.vbCrLf & "          Using stream As New FileStream(filePath, FileMode.Create)" & Constants.vbCrLf & Constants.vbCrLf

		Private Const codeEnd_Renamed As String = Constants.vbCrLf & "		End Using" & Constants.vbCrLf & Constants.vbCrLf & "		End Sub" & Constants.vbCrLf & "	End Class" & Constants.vbCrLf & "End Namespace" & Constants.vbCrLf

		Protected Overrides ReadOnly Property CodeStart() As String
			Get
				Return codeStart_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property CodeEnd() As String
			Get
				Return codeEnd_Renamed
			End Get
		End Property
		Protected Overrides Function GetCodeDomProvider() As CodeDomProvider
			Return New Microsoft.VisualBasic.VBCodeProvider()
		End Function
	End Class
	#End Region
End Namespace

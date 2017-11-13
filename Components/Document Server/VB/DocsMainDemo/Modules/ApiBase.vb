Imports Microsoft.VisualBasic
Imports DevExpress.DXperience.Demos
Imports System.Collections.Generic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting.Control
Imports System.IO
Imports System
Imports System.Drawing
Imports DevExpress.XtraTreeList.Columns
Imports System.Text.RegularExpressions
Imports System.ComponentModel
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.Utils
Imports System.Windows.Forms
Imports DevExpress.Docs.Demos
Imports Microsoft.Build.Evaluation
Imports System.Text
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports System.Diagnostics
Imports System.Globalization
Imports DevExpress.XtraSpreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Services.Implementation

Namespace DevExpress.Docs.Demos
	Public Class ApiModuleBase
		Inherits TutorialControlBase
		Private treeList1 As TreeList
		Private spreadsheetPreviewControl As PrintControl
		Private link As PrintableComponentLinkBase
		Private horizontalSplitContainerControl1 As SplitContainerControl
		Private verticalSplitContainerControl1 As SplitContainerControl
		#Region "components"
		Private xtraTabControl1 As XtraTab.XtraTabControl
		Private xtraTabPage1 As XtraTab.XtraTabPage
		Private richEditControlCS As RichEditControl
		Private xtraTabPage2 As XtraTab.XtraTabPage
		Private richEditControlVB As RichEditControl
		#End Region
		Private codeExampleNameLbl As LabelControl

		Private codeEditor_Renamed As ExampleCodeEditor
		Private components As IContainer
		Private evaluator As ExampleEvaluatorByTimer
		Private treeListRootNodeLoading As Boolean = True
		Private examples As List(Of CodeExampleGroup)

		Public Sub New()
			InitializeComponent()
			CreateDemoComponent()
			AddHandler Me.Disposed, AddressOf SpreadsheetAPIModule_Disposed

			Me.spreadsheetPreviewControl.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()
			Me.link = New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(Me.spreadsheetPreviewControl.PrintingSystem)

			Dim examplePath As String = CodeExampleDemoUtils.GetExamplePath(ExamplesFolderName)
			Dim examplesCS As Dictionary(Of String, FileInfo) = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp)
			Dim examplesVB As Dictionary(Of String, FileInfo) = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB)

			DisableTabs(examplesCS.Count, examplesVB.Count)
			examples = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB)

			RearrangeExamples(examples)

			ShowExamplesInTreeList(treeList1, examples)
			Me.codeEditor_Renamed = New ExampleCodeEditor(richEditControlCS, richEditControlVB)
			CurrentExampleLanguage = CodeExampleDemoUtils.DetectExampleLanguage(DemoProjectName)
			Me.evaluator = CreateEvaluator()
			ShowFirstExample()
			AddHandler xtraTabControl1.SelectedPageChanged, AddressOf xtraTabControl1_SelectedPageChanged
		End Sub
		Protected Overridable Function CreateEvaluator() As ExampleEvaluatorByTimer
			Return Nothing
		End Function
		Protected Overridable Sub CreateDemoComponent()

		End Sub
		Protected Overridable Function GetEvaluationParameter() As Object
			Return Nothing
		End Function

		Protected Overridable Sub RearrangeExamples(ByVal examples As List(Of CodeExampleGroup))
		End Sub

		Private Property CurrentExampleLanguage() As ExampleLanguage
			Get
				Return CType(xtraTabControl1.SelectedTabPageIndex, ExampleLanguage)
			End Get
			Set(ByVal value As ExampleLanguage)
				Me.codeEditor_Renamed.CurrentExampleLanguage = value
				xtraTabControl1.SelectedTabPageIndex = If((value = ExampleLanguage.Csharp), 0, 1)
			End Set
		End Property
		Public Overridable ReadOnly Property ExamplesFolderName() As String
			Get
				Return String.Empty
			End Get
		End Property
		Public Overridable ReadOnly Property DemoProjectName() As String
			Get
				Return String.Empty
			End Get
		End Property

		Protected ReadOnly Property CodeEditor() As ExampleCodeEditor
			Get
				Return codeEditor_Renamed
			End Get
		End Property
		Protected ReadOnly Property PrintableComponentLink() As PrintableComponentLinkBase
			Get
				Return link
			End Get
		End Property

		Private Sub DisableTabs(ByVal examplesCSCount As Integer, ByVal examplesVBCount As Integer)
			If examplesCSCount = 0 Then
				xtraTabControl1.TabPages(CInt(Fix(ExampleLanguage.Csharp))).PageEnabled = False
			End If
			If examplesVBCount = 0 Then
				xtraTabControl1.TabPages(CInt(Fix(ExampleLanguage.VB))).PageEnabled = False
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
			Dim args As New CodeEvaluationEventArgs()
			InitializeCodeEvaluationEventArgs(args)
			evaluator.ForceCompile(args)
		End Sub
		Private Sub InitializeCodeEvaluationEventArgs(ByVal e As CodeEvaluationEventArgs)
			e.Result = True
			e.Code = codeEditor_Renamed.CurrentCodeEditor.Text
			e.Language = CurrentExampleLanguage
			e.EvaluationParameter = GetEvaluationParameter()
		End Sub
		Public Sub OnExampleEvaluatorQueryEvaluate(ByVal sender As Object, ByVal e As CodeEvaluationEventArgs)
			e.Result = False
			If codeEditor_Renamed.RichEditTextChanged Then ' && compileComplete) {
				Dim span As TimeSpan = DateTime.Now - codeEditor_Renamed.LastExampleCodeModifiedTime

				If span < TimeSpan.FromMilliseconds(1000) Then 'CompileTimeIntervalInMilliseconds 1900
					codeEditor_Renamed.ResetLastExampleModifiedTime()
					Return
				End If
				'e.Result = true;
				InitializeCodeEvaluationEventArgs(e)
			End If
		End Sub

		#Region "InitializeComponent"
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.spreadsheetPreviewControl = New DevExpress.XtraPrinting.Control.PrintControl()
			Me.link = New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(Me.components)
			Me.horizontalSplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.richEditControlCS = New DevExpress.XtraRichEdit.RichEditControl()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.richEditControlVB = New DevExpress.XtraRichEdit.RichEditControl()
			Me.codeExampleNameLbl = New DevExpress.XtraEditors.LabelControl()
			Me.verticalSplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.horizontalSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.horizontalSplitContainerControl1.SuspendLayout()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.verticalSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.verticalSplitContainerControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline)
			Me.treeList1.Appearance.FocusedCell.Options.UseFont = True
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(218, 694)
			Me.treeList1.TabIndex = 8
			' 
			' spreadsheetPreviewControl
			' 
			Me.spreadsheetPreviewControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetPreviewControl.IsMetric = False
			Me.spreadsheetPreviewControl.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetPreviewControl.Name = "spreadsheetPreviewControl"
			Me.spreadsheetPreviewControl.Size = New System.Drawing.Size(1005, 340)
			Me.spreadsheetPreviewControl.TabIndex = 5
			Me.spreadsheetPreviewControl.TooltipFont = New System.Drawing.Font("Tahoma", 8.25F)
			' 
			' link
			' 
			Me.link.PrintingSystemBase = Nothing
			' 
			' horizontalSplitContainerControl1
			' 
			Me.horizontalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.horizontalSplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
			Me.horizontalSplitContainerControl1.Horizontal = False
			Me.horizontalSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.horizontalSplitContainerControl1.Name = "horizontalSplitContainerControl1"
			Me.horizontalSplitContainerControl1.Panel1.Controls.Add(Me.xtraTabControl1)
			Me.horizontalSplitContainerControl1.Panel1.Controls.Add(Me.codeExampleNameLbl)
			Me.horizontalSplitContainerControl1.Panel1.Text = "Panel1"
			Me.horizontalSplitContainerControl1.Panel2.Controls.Add(Me.spreadsheetPreviewControl)
			Me.horizontalSplitContainerControl1.Panel2.Text = "Panel2"
			Me.horizontalSplitContainerControl1.Size = New System.Drawing.Size(1005, 694)
			Me.horizontalSplitContainerControl1.SplitterPosition = 340
			Me.horizontalSplitContainerControl1.TabIndex = 2
			Me.horizontalSplitContainerControl1.Text = "splitContainerControl1"
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
			Me.xtraTabControl1.Size = New System.Drawing.Size(1005, 305)
			Me.xtraTabControl1.TabIndex = 12
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.xtraTabPage1.Appearance.HeaderActive.Options.UseFont = True
			Me.xtraTabPage1.Controls.Add(Me.richEditControlCS)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(999, 277)
			Me.xtraTabPage1.Text = "C#"
			' 
			' richEditControlCS
			' 
			Me.richEditControlCS.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
			Me.richEditControlCS.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControlCS.Location = New System.Drawing.Point(0, 0)
			Me.richEditControlCS.Name = "richEditControlCS"
			Me.richEditControlCS.Options.Fields.UseCurrentCultureDateTimeFormat = False
			Me.richEditControlCS.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
			Me.richEditControlCS.Options.MailMerge.KeepLastParagraph = False
			Me.richEditControlCS.Size = New System.Drawing.Size(999, 277)
			Me.richEditControlCS.TabIndex = 14
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.xtraTabPage2.Appearance.HeaderActive.Options.UseFont = True
			Me.xtraTabPage2.Controls.Add(Me.richEditControlVB)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(999, 277)
			Me.xtraTabPage2.Text = "VB"
			' 
			' richEditControlVB
			' 
			Me.richEditControlVB.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
			Me.richEditControlVB.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControlVB.Location = New System.Drawing.Point(0, 0)
			Me.richEditControlVB.Name = "richEditControlVB"
			Me.richEditControlVB.Options.Fields.UseCurrentCultureDateTimeFormat = False
			Me.richEditControlVB.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
			Me.richEditControlVB.Options.MailMerge.KeepLastParagraph = False
			Me.richEditControlVB.Size = New System.Drawing.Size(999, 277)
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
			Me.codeExampleNameLbl.Size = New System.Drawing.Size(72, 44)
			Me.codeExampleNameLbl.TabIndex = 10
			Me.codeExampleNameLbl.Text = "label1"
			' 
			' verticalSplitContainerControl1
			' 
			Me.verticalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.verticalSplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
			Me.verticalSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.verticalSplitContainerControl1.Name = "verticalSplitContainerControl1"
			Me.verticalSplitContainerControl1.Panel1.Controls.Add(Me.horizontalSplitContainerControl1)
			Me.verticalSplitContainerControl1.Panel1.Text = "Panel1"
			Me.verticalSplitContainerControl1.Panel2.Controls.Add(Me.treeList1)
			Me.verticalSplitContainerControl1.Panel2.Text = "Panel2"
			Me.verticalSplitContainerControl1.Size = New System.Drawing.Size(1228, 694)
			Me.verticalSplitContainerControl1.SplitterPosition = 218
			Me.verticalSplitContainerControl1.TabIndex = 0
			Me.verticalSplitContainerControl1.Text = "verticalSplitContainerControl1"
			' 
			' ApiModuleBase
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.verticalSplitContainerControl1)
			Me.Name = "ApiModuleBase"
			Me.Size = New System.Drawing.Size(1228, 694)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.horizontalSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.horizontalSplitContainerControl1.ResumeLayout(False)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.verticalSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.verticalSplitContainerControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub ShowExamplesInTreeList(ByVal treeList As TreeList, ByVal examples As List(Of CodeExampleGroup))
'			#Region "InitializeTreeList"
			treeList.OptionsPrint.UsePrintStyles = True
			AddHandler treeList.FocusedNodeChanged, AddressOf OnNewExampleSelected
			treeList.OptionsView.ShowColumns = False
			treeList.OptionsView.ShowIndicator = False

			AddHandler treeList.VirtualTreeGetChildNodes, AddressOf treeList_VirtualTreeGetChildNodes
			AddHandler treeList.VirtualTreeGetCellValue, AddressOf treeList_VirtualTreeGetCellValue
'			#End Region
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
		Private Sub SpreadsheetAPIModule_Disposed(ByVal sender As Object, ByVal e As EventArgs)
			If evaluator IsNot Nothing Then
				evaluator.Dispose()
				evaluator = Nothing
			End If
			If link IsNot Nothing Then
				link.Dispose()
				link = Nothing
			End If
		End Sub
	End Class
	#Region "SpreadsheetExampleEvaluatorByTimer"
	Public Class SpreadsheetExampleEvaluatorByTimer
		Inherits ExampleEvaluatorByTimer
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function GetExampleCodeEvaluator(ByVal language As ExampleLanguage) As ExampleCodeEvaluator
			If language = ExampleLanguage.VB Then
				Return New SpreadsheetVbExampleCodeEvaluator()
			End If
			Return New SpreadsheetCSExampleCodeEvaluator()
		End Function
	End Class
	#End Region
End Namespace

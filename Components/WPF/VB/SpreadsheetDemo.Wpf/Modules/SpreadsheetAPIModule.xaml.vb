Imports System
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraRichEdit
Imports System.Text
Imports System.IO
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports System.Text.RegularExpressions
Imports DevExpress.DXperience.Demos
Imports DevExpress.Xpf.Grid
Imports System.Collections
Imports DevExpress.Xpf.DemoBase.Helpers.TextColorizer
Imports System.Reflection

Namespace SpreadsheetDemo
    Partial Public Class SpreadsheetAPIModule
        Inherits SpreadsheetDemoModule

        Private codeEditor As ExampleCodeEditor
        Private evaluator As ExampleEvaluatorByTimer
        Private richEditControlVBLoaded As Boolean = False
        Private richEditControlCsLoaded As Boolean = False

        Public Sub New()
            InitializeComponent()
            Dim examplePath As String = DemoUtils.GetRelativeDirectoryPath("CodeExamples")
            Dim examplesCS As Dictionary(Of String, FileInfo) = SuppressExamples(CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp))
            Dim examplesVB As Dictionary(Of String, FileInfo) = SuppressExamples(CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB))
            DisableTabs(examplesCS.Count, examplesVB.Count)
            Dim examples As List(Of CodeExampleGroup) = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB)
            ShowExamplesInTreeList(treeList1, examples)

            AddHandler richEditControlCS.Loaded, AddressOf richEditControlCS_Loaded
            AddHandler richEditControlVB.Loaded, AddressOf richEditControlVB_Loaded
            Dim language As CodeLanguage = DevExpress.Xpf.DemoBase.Helpers.DemoHelper.GetDemoLanguage(System.Reflection.Assembly.GetExecutingAssembly())
            CurrentExampleLanguage = If(Object.Equals(language, CodeLanguage.CS), ExampleLanguage.Csharp, ExampleLanguage.VB)
            Me.evaluator = New SpreadsheetExampleEvaluatorByTimer(True)

            AddHandler Me.evaluator.QueryEvaluate, AddressOf OnExampleEvaluatorQueryEvaluate
            AddHandler Me.evaluator.OnBeforeCompile, AddressOf evaluator_OnBeforeCompile
            AddHandler Me.evaluator.OnAfterCompile, AddressOf evaluator_OnAfterCompile
        End Sub

        Private Function SuppressExamples(ByVal examples As Dictionary(Of String, FileInfo)) As Dictionary(Of String, FileInfo)
            examples.Remove("PrintingActions")
            Return examples
        End Function

        Private Sub evaluator_OnAfterCompile(ByVal sender As Object, ByVal args As OnAfterCompileEventArgs)
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            For Each sheet As Worksheet In workbook.Worksheets
                sheet.PrintOptions.PrintGridlines = True
            Next sheet

            Dim active As Worksheet = workbook.Worksheets.ActiveWorksheet
            Dim usedRange As Range = active.GetUsedRange()
            active.SelectedCell = usedRange(usedRange.RowCount * usedRange.ColumnCount - 1).Offset(1, 1)
            active.Visible = True

            If codeEditor IsNot Nothing Then
                codeEditor.AfterCompile(args.Result)
            End If
            spreadsheetControl1.EndUpdate()
        End Sub

        Private Sub evaluator_OnBeforeCompile(ByVal sender As Object, ByVal args As EventArgs)
            spreadsheetControl1.BeginUpdate()
            If codeEditor IsNot Nothing Then
                codeEditor.BeforeCompile()
            End If

            Dim workbook As IWorkbook = spreadsheetControl1.Document
            workbook.Options.Culture = DefaultCulture
            Dim loaded As Boolean = workbook.LoadDocument(DemoUtils.GetRelativePath("Document.xlsx"))
            System.Diagnostics.Debug.Assert(loaded)
        End Sub

        Private Sub richEditControlCS_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            If richEditControlVBLoaded AndAlso (Not richEditControlCsLoaded) Then
                CreateCodeEditor()
            End If
            richEditControlCsLoaded = True
        End Sub

        Private Sub richEditControlVB_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            If richEditControlCsLoaded AndAlso (Not richEditControlVBLoaded) Then
                CreateCodeEditor()
            End If
            richEditControlVBLoaded = True
        End Sub

        Private Sub DisableTabs(ByVal examplesCSCount As Integer, ByVal examplesVBCount As Integer)
            If examplesCSCount = 0 Then
                tabControl.GetTabItem(CInt(ExampleLanguage.Csharp)).IsEnabled = False
            End If
            If examplesVBCount = 0 Then
                tabControl.GetTabItem(CInt(ExampleLanguage.VB)).IsEnabled = False
            End If
        End Sub

        Private Sub CreateCodeEditor()
            System.Diagnostics.Debug.Assert(codeEditor Is Nothing)

            richEditControlCS.Tag = "Cs"
            richEditControlVB.Tag = "Vb"
            Me.codeEditor = New ExampleCodeEditor(richEditControlCS, richEditControlVB)
            Me.codeEditor.CurrentExampleLanguage = CurrentExampleLanguage

            ShowFirstExample()
        End Sub

        Private Sub ShowExamplesInTreeList(ByVal treeList1 As TreeListControl, ByVal examples As List(Of CodeExampleGroup))
            treeList1.ItemsSource = examples
        End Sub

        Private Sub ShowFirstExample()
            treeList1.View.ExpandAllNodes()

            If treeList1.View.Nodes.Count > 0 Then
                treeList1.View.FocusedNode = treeList1.View.Nodes(0).Nodes.First()
            End If
        End Sub

        Private Property CurrentExampleLanguage() As ExampleLanguage
            Get
                Return CType(tabControl.SelectedIndex, ExampleLanguage)
            End Get
            Set(ByVal value As ExampleLanguage)
                If codeEditor IsNot Nothing Then
                    Me.codeEditor.CurrentExampleLanguage = value
                End If
                tabControl.SelectedIndex = If(value = ExampleLanguage.Csharp, 0, 1)
            End Set
        End Property
        Private Sub OnNewExampleSelected(ByVal sender As Object, ByVal e As CurrentItemChangedEventArgs)
            Dim newExample As CodeExample = TryCast(e.NewItem, CodeExample)
            Dim oldExample As CodeExample = TryCast(e.OldItem, CodeExample)

            If newExample Is Nothing Then
                Return
            End If

            If codeEditor Is Nothing Then
                Return
            End If

            Dim exampleCode As String = codeEditor.ShowExample(oldExample, newExample)
            codeExampleNameLbl.Content = CodeExampleDemoUtils.ConvertStringToMoreHumanReadableForm(newExample.RegionName) & " example"

            Dim args As New CodeEvaluationEventArgs()
            InitializeCodeEvaluationEventArgs(args)
            evaluator.ForceCompile(args)
        End Sub
        Private Sub InitializeCodeEvaluationEventArgs(ByVal e As CodeEvaluationEventArgs)
            e.Result = True
            If codeEditor Is Nothing Then
                Return
            End If

            e.Code = codeEditor.CurrentCodeEditor.Text
            e.Language = CurrentExampleLanguage
            e.EvaluationParameter = spreadsheetControl1.Document
        End Sub
        Private Sub OnExampleEvaluatorQueryEvaluate(ByVal sender As Object, ByVal e As CodeEvaluationEventArgs)
            e.Result = False
            If (codeEditor IsNot Nothing) AndAlso codeEditor.RichEditTextChanged Then
                Dim span As TimeSpan = Date.Now.Subtract(codeEditor.LastExampleCodeModifiedTime)

                If span < TimeSpan.FromMilliseconds(1000) Then
                    codeEditor.ResetLastExampleModifiedTime()
                    Return
                End If
                InitializeCodeEvaluationEventArgs(e)
            End If
        End Sub

        Private Sub tabControl_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Core.TabControlSelectionChangedEventArgs)
            Dim value As ExampleLanguage = CType(e.NewSelectedIndex, ExampleLanguage)

            If Me.codeEditor IsNot Nothing Then
                Me.codeEditor.CurrentExampleLanguage = value
            End If
        End Sub

        Private Sub view_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.TreeList.TreeListCustomColumnDisplayTextEventArgs)

            If e.Node.HasChildren AndAlso TypeOf e.Node.Content Is CodeExampleGroup Then
                e.DisplayText = (TryCast(e.Node.Content, CodeExampleGroup)).Name
            End If
        End Sub
    End Class
    #Region "SpreadsheetExampleEvaluatorByTimer"
    Public Class SpreadsheetExampleEvaluatorByTimer
        Inherits ExampleEvaluatorByTimer

        Public Sub New(ByVal runTimer As Boolean)
            MyBase.New(runTimer)
        End Sub

        Protected Overrides Function GetExampleCodeEvaluator(ByVal language As ExampleLanguage) As ExampleCodeEvaluator
            If language = ExampleLanguage.VB Then
                Return New SpreadsheetVbExampleCodeEvaluator()
            End If
            Return New SpreadsheetCSExampleCodeEvaluator()
        End Function
    End Class
    #End Region

    Public Class CodeExampleGroupChildrenSelector
        Implements IChildNodesSelector

        Private Function IChildNodesSelector_SelectChildren(ByVal item As Object) As IEnumerable Implements IChildNodesSelector.SelectChildren
            If TypeOf item Is CodeExampleGroup Then
                Return DirectCast(item, CodeExampleGroup).Examples
            End If
            Return Nothing
        End Function
    End Class
End Namespace

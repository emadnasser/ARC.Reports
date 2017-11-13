Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Nodes.Operations
Imports DevExpress.XtraTreeList.StyleFormatConditions

Namespace Examples
    <CodeExampleClass("Data binding", "Examples.vb"), CodeExampleHighlightTokens("TreeListColumn", "IVirtualTreeListData", "TreeList", "VirtualTreeGetCellValueInfo", "List", "IList", "Data", "TreeListNode")>
    Public NotInheritable Class DataBindingExamples
        Private Sub New()
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim treeList As New TreeList()
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            Dim panel As New PanelControl()
            panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            panel.Dock = DockStyle.Top
            panel.Parent = sampleHost
            panel.Height = 30
            Dim button As New SimpleButton()
            button.Text = "Append node"
            button.Dock = DockStyle.Top
            button.Parent = panel
            Return New Object() {treeList, button}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            For Each control As Control In sampleHost.Controls
                control.Dispose()
            Next control
            sampleHost.Controls.Clear()
        End Sub
        <CodeExampleCase("Unbound mode", New Type() {GetType(DataBindingHelper)})>
        Public Shared Sub InitializeDataUnboundMode(ByVal treeList As TreeList, ByVal button As SimpleButton)
            Dim column As TreeListColumn = treeList.Columns.AddVisible("Node")
            column.Caption = "Node"
            Dim res As Boolean = DataBindingHelper.AppendNode(treeList, 10)
            AddHandler button.Click, Sub(sender, e) treeList.AppendNode(New Object() {"Custom node"}, -1)
        End Sub
        <CodeExampleCase("Virtual mode", New Type() {GetType(VirtualData)})>
        Public Shared Sub InitializeDataVirtualMode(ByVal treeList As TreeList, ByVal button As SimpleButton)
            button.Parent.Visible = False
            Dim column As TreeListColumn = treeList.Columns.AddVisible("Node")
            column.Caption = "Node"
            treeList.DataSource = New VirtualData()
        End Sub
        <CodeExampleCase("Bound mode", New Type() {GetType(DataBindingHelper)})>
        Public Shared Sub InitializeDataBoundMode(ByVal treeList As TreeList, ByVal button As SimpleButton)
            treeList.ParentFieldName = "ParentID"
            treeList.KeyFieldName = "ID"
            treeList.DataSource = DataBindingHelper.GetDataSource(10)
            AddHandler button.Click, Sub(sender, e)
                                         treeList.AppendNode(New Object() {0, treeList.AllNodesCount, "Custom node"}, -1)
                                     End Sub
        End Sub
        <CodeExampleNestedClass>
        Public Class VirtualData
            Implements DevExpress.XtraTreeList.TreeList.IVirtualTreeListData
            Private Const countChildren As Integer = 10
            Private parentIDCore As Integer
            Public Sub New()
                parentIDCore = 0
            End Sub
            Public Sub New(ByVal value As String, ByVal parentID As Integer)
                parentIDCore = parentID
                Node = value
            End Sub
            Public Property Node() As String
            Public Sub VirtualTreeGetCellValue(ByVal info As VirtualTreeGetCellValueInfo) Implements DevExpress.XtraTreeList.TreeList.IVirtualTreeListData.VirtualTreeGetCellValue
                info.CellData = (CType(info.Node, VirtualData)).Node
            End Sub
            Public Sub VirtualTreeGetChildNodes(ByVal info As VirtualTreeGetChildNodesInfo) Implements DevExpress.XtraTreeList.TreeList.IVirtualTreeListData.VirtualTreeGetChildNodes
                Dim list As IList = New List(Of VirtualData)()
                Dim startIndex As Integer = (parentIDCore * countChildren) + 1
                For i As Integer = startIndex To countChildren + startIndex
                    list.Add(New VirtualData("Node" & i, i))
                Next i
                info.Children = list
            End Sub
            Public Sub VirtualTreeSetCellValue(ByVal info As VirtualTreeSetCellValueInfo) Implements DevExpress.XtraTreeList.TreeList.IVirtualTreeListData.VirtualTreeSetCellValue
                CType(info.Node, VirtualData).Node = info.NewCellData.ToString()
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public NotInheritable Class DataBindingHelper
            'Unbound mode
            Private Sub New()
            End Sub
            Public Shared Function AppendNode(ByVal treeList As TreeList, ByVal countNode As Integer) As Boolean
                For i As Integer = 1 To countNode
                    Dim parentNode As TreeListNode = treeList.AppendNode(New Object() {"Node" & i}, -1)
                    AppendNodeChild(treeList, parentNode, i * countNode, countNode)
                Next i
                Return True
            End Function
            Private Shared Sub AppendNodeChild(ByVal treeList As TreeList, ByVal parentNode As TreeListNode, ByVal startIndex As Integer, ByVal countNode As Integer)
                For i As Integer = startIndex + 1 To countNode + startIndex
                    treeList.AppendNode(New Object() {"Node" & i}, parentNode)
                Next i
            End Sub
            'Bound mode
            Public Shared Function GetDataSource(ByVal countNode As Integer) As List(Of Data)
                Dim list As New List(Of Data)()
                Dim startIndex As Integer = 1
                For i As Integer = startIndex To countNode
                    list.Add(New Data(0, i, "Node" & i))
                    list.AddRange(GetDataSource(i, i * countNode, countNode))
                Next i
                Return list
            End Function
            Private Shared Function GetDataSource(ByVal parentID As Integer, ByVal startIndex As Integer, ByVal countNode As Integer) As List(Of Data)
                Dim list As New List(Of Data)()
                For i As Integer = startIndex + 1 To countNode + startIndex
                    list.Add(New Data(parentID, i, "Node" & i))
                Next i
                Return list
            End Function
            Public Class Data
                Public Sub New()
                End Sub
                Public Sub New(ByVal parentID As Integer, ByVal id As Integer, ByVal value As String)
                    Me.ParentID = parentID
                    Me.ID = id
                    Node = value
                End Sub
                Public Property ParentID() As Integer
                Public Property ID() As Integer
                Public Property Node() As String
            End Class
        End Class
    End Class
    <CodeExampleClass("Nodes iterator", "Examples.vb"), CodeExampleHighlightTokens("TreeListColumn", "TreeListOperation", "Data", "TreeListNode", "List", "IList")>
    Public NotInheritable Class NodesIteratorExamples
        Private Sub New()
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim treeList As New TreeList()
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            Return New Object() {treeList, sampleHost}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            For Each control As Control In sampleHost.Controls
                control.Dispose()
            Next control
            sampleHost.Controls.Clear()
        End Sub
        <CodeExampleCase("Create custom operation", New Type() {GetType(DataSourceHelper), GetType(OperationCollapseAllButThis)})>
        Public Shared Sub CollapseAllButThis(ByVal treeList As TreeList, ByVal sampleHost As XtraUserControl)
            Dim column As TreeListColumn = treeList.Columns.AddVisible("Node")
            column.Caption = "Node"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            AddHandler treeList.BeforeExpand, Sub(sender, e)
                                                  Dim op As New OperationCollapseAllButThis(e.Node)
                                                  treeList.BeginUpdate()
                                                  If e.Node.ParentNode Is Nothing Then
                                                      treeList.NodesIterator.DoOperation(op)
                                                  Else
                                                      treeList.NodesIterator.DoLocalOperation(op, e.Node.ParentNode.Nodes)
                                                  End If
                                                  treeList.EndUpdate()
                                              End Sub
        End Sub
        <CodeExampleCase("Create custom delegate", New Type() {GetType(DataSourceHelper)}), CodeExampleUnderlineTokens("CellValueChanged")>
        Public Shared Sub RecursiveCellChecking(ByVal treeList As TreeList, ByVal sampleHost As XtraUserControl)
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            Dim column As TreeListColumn = treeList.Columns("Check")
            AddHandler column.RealColumnEdit.EditValueChanged, Sub(sender, e)
                                                                   treeList.BeginUpdate()
                                                                   treeList.BeginSort()
                                                                   treeList.CloseEditor()
                                                               End Sub
            AddHandler treeList.CellValueChanged, Sub(sender, e)
                                                      treeList.NodesIterator.DoLocalOperation(Sub(node) node(e.Column) = e.Value, e.Node.Nodes)
                                                      Dim parent As TreeListNode = e.Node.ParentNode
                                                      Dim value As Boolean = Object.Equals(e.Value, True)
                                                      Do While parent IsNot Nothing
                                                          Dim check As Boolean = True
                                                          If Not value Then
                                                              check = value
                                                          Else
                                                              treeList.NodesIterator.DoLocalOperation(Sub(node)
                                                                                                          If Object.Equals(node(e.Column), False) Then
                                                                                                              check = False
                                                                                                          End If
                                                                                                      End Sub, parent.Nodes)
                                                          End If
                                                          parent("Check") = check
                                                          parent = parent.ParentNode
                                                      Loop
                                                      treeList.EndSort()
                                                      treeList.EndUpdate()
                                                  End Sub
        End Sub
        <CodeExampleNestedClass>
        Public Class OperationCollapseAllButThis
            Inherits TreeListOperation
            Private nodeCore As TreeListNode
            Public Sub New(ByVal node As TreeListNode)
                nodeCore = node
            End Sub
            Public Overrides Function NeedsVisitChildren(ByVal node As TreeListNode) As Boolean
                Return True
            End Function
            Public Overrides Function CanContinueIteration(ByVal node As TreeListNode) As Boolean
                Return True
            End Function
            Public Overrides ReadOnly Property NeedsFullIteration() As Boolean
                Get
                    Return False
                End Get
            End Property
            Public Overrides Sub Execute(ByVal node As TreeListNode)
                If node Is nodeCore Then
                    Return
                End If
                node.Expanded = False
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public NotInheritable Class DataSourceHelper
            Private Sub New()
            End Sub
            Public Shared Function GetDataSource(ByVal parentID As Integer, ByVal startIndex As Integer, ByVal countNode As Integer) As List(Of Data)
                Return GetDataSourceCore(parentID, startIndex, countNode, 0)
            End Function
            Private Shared Function GetDataSourceCore(ByVal parentID As Integer, ByVal startIndex As Integer, ByVal countNode As Integer, ByVal level As Integer) As List(Of Data)
                Dim list As New List(Of Data)()
                If level > 2 Then
                    Return list
                End If
                For i As Integer = startIndex To startIndex + countNode - 1
                    list.Add(New Data(parentID, i, "Node" & i))
                    list.AddRange(GetDataSourceCore(i, i * countNode + 1, countNode, level + 1))
                Next i
                Return list
            End Function
            Public Class Data
                Public Sub New(ByVal parentID As Integer, ByVal id As Integer, ByVal value As String)
                    Me.ParentID = parentID
                    Me.ID = id
                    Node = value
                End Sub
                Private privateParentID As Integer
                Public Property ParentID() As Integer
                    Get
                        Return privateParentID
                    End Get
                    Private Set(ByVal value As Integer)
                        privateParentID = value
                    End Set
                End Property
                Private privateID As Integer
                Public Property ID() As Integer
                    Get
                        Return privateID
                    End Get
                    Private Set(ByVal value As Integer)
                        privateID = value
                    End Set
                End Property
                Public Property Node() As String
                Public Property Check() As Boolean
            End Class
        End Class
    End Class

    <CodeExampleClass("Customization via code", "Examples.vb"), CodeExampleHighlightTokens("TreeListColumn", "TreeListBand", "Color", "SummaryItemType", "Math", "Data", "Bitmap", "List", "RepositoryItemTextEdit", "FilterEditorViewMode", "FixedStyle", "TreeListMultiSelectMode", "FormatConditionRuleValue", "FormatCondition", "TreeListFormatRule", "FormatConditionRule2ColorScale", "FormatConditionRuleDataBar", "Rectangle", "SolidBrush", "IndicatorObjectPainter", "ImageCollection"), CodeExampleUnderlineTokens("BeginUpdate", "EndUpdate")>
    Public NotInheritable Class CustomizationExamples
        Private Sub New()
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim treeList As New TreeList()
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            Return New Object() {treeList}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            For Each control As Control In sampleHost.Controls
                control.Dispose()
            Next control
            sampleHost.Controls.Clear()
        End Sub
        <CodeExampleCase("Custom node height", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub CustomNodeHeigth(ByVal treeList As TreeList)
            Dim column As TreeListColumn = treeList.Columns.AddVisible("Value1")
            column.Caption = "Value"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.OptionsBehavior.AutoNodeHeight = False
            treeList.OptionsBehavior.Editable = False
            treeList.RowHeight = 30
            AddHandler treeList.CalcNodeHeight, Sub(sender, e)
                                                    If e.Node.Id Mod 2 <> 0 Then
                                                        e.NodeHeight = e.NodeHeight * 2
                                                    End If
                                                End Sub
        End Sub
        <CodeExampleCase("Customizing columns via code", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub CustomizingColumns(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            column3.OptionsColumn.AllowEdit = True
            column2.OptionsColumn.AllowEdit = column3.OptionsColumn.AllowEdit
            column1.OptionsColumn.AllowEdit = column2.OptionsColumn.AllowEdit
            column3.OptionsColumn.AllowMove = False
            column3.OptionsColumn.AllowMoveToCustomizationForm = False
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.OptionsBehavior.Editable = False
            treeList.OptionsCustomization.AllowColumnMoving = True
            treeList.OptionsCustomization.AllowColumnResizing = True
            treeList.OptionsCustomization.CustomizationFormSearchBoxVisible = True
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
        <CodeExampleCase("Customizing bands via code", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub CustomizingBands(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            Dim column4 As TreeListColumn = treeList.Columns.AddVisible("Value4")
            Dim column5 As TreeListColumn = treeList.Columns.AddVisible("Value5")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            column4.Caption = "Column4"
            column5.Caption = "Column5"
            treeList.OptionsView.AllowBandColumnsMultiRow = True
            treeList.OptionsView.ShowBandsMode = DevExpress.Utils.DefaultBoolean.True
            Dim band1 As TreeListBand = treeList.Bands.AddBand("Band1")
            Dim band2 As TreeListBand = treeList.Bands.AddBand("Band2")
            band2.OptionsBand.AllowMove = False
            band2.OptionsBand.AllowSize = False
            band2.OptionsBand.ShowInCustomizationForm = False
            Dim band3 As TreeListBand = band1.Bands.AddBand("Band3")
            Dim band4 As TreeListBand = band1.Bands.AddBand("Band4")
            band2.Columns.Add(column2)
            band3.Columns.Add(column1)
            column1.RowIndex = 0
            band3.Columns.Add(column3)
            column3.RowIndex = 0
            band3.Columns.Add(column5)
            column5.RowIndex = 1
            band4.Columns.Add(column4)
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.OptionsBehavior.Editable = False
            treeList.OptionsCustomization.AllowBandResizing = True
            treeList.OptionsCustomization.AllowBandMoving = True
            treeList.OptionsCustomization.AllowChangeBandParent = True
            treeList.OptionsCustomization.AllowChangeColumnParent = True
            treeList.OptionsCustomization.ShowBandsInCustomizationForm = True
            treeList.OptionsCustomization.AllowColumnMoving = True
            treeList.OptionsCustomization.AllowColumnResizing = True
            treeList.OptionsCustomization.CustomizationFormSearchBoxVisible = True
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
        <CodeExampleCase("Binding select image", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub BindingSelectImage(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            treeList.ImageIndexFieldName = "ImageIndex"
            treeList.SelectImageList = DataSourceHelper.Images
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.OptionsBehavior.Editable = False
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
        <CodeExampleCase("Binding node checkboxes", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub BindingCheckBoxes(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            treeList.CheckBoxFieldName = "Value3"
            treeList.OptionsView.ShowCheckBoxes = True
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.OptionsBehavior.Editable = False
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
        <CodeExampleCase("Customizing rows via code", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub CustomizingRows(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.OptionsBehavior.Editable = False
            treeList.Appearance.OddRow.BackColor = Color.Honeydew
            treeList.Appearance.EvenRow.BackColor = Color.SeaShell
            treeList.OptionsView.EnableAppearanceEvenRow = True
            treeList.OptionsView.EnableAppearanceOddRow = True
            treeList.OptionsView.ShowIndentAsRowStyle = False
            treeList.RowHeight = 35
            treeList.OptionsBehavior.AutoNodeHeight = False
            treeList.OptionsBehavior.ResizeNodes = True
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
        <CodeExampleCase("Show summary via code", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub ShowSummary(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.OptionsView.ShowRowFooterSummary = True
            treeList.OptionsView.ShowSummaryFooter = True
            column1.AllNodesSummary = True
            column1.RowFooterSummary = SummaryItemType.Count
            column1.SummaryFooter = SummaryItemType.Count
            column2.AllNodesSummary = True
            column2.RowFooterSummary = SummaryItemType.Max
            column2.SummaryFooter = SummaryItemType.Max
            column3.AllNodesSummary = True
            column3.RowFooterSummary = SummaryItemType.Min
            column3.SummaryFooter = SummaryItemType.Min
            treeList.FooterPanelHeight = 50
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
        <CodeExampleCase("Customizing treeList via code", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub CustomizingTreeList(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.IndicatorWidth = 20
            treeList.TreeLevelWidth = 20
            treeList.ColumnPanelRowHeight = 25
            treeList.OptionsBehavior.Editable = False
            treeList.OptionsBehavior.AllowRecursiveNodeChecking = True
            treeList.OptionsBehavior.AllowIncrementalSearch = True
            treeList.OptionsView.ShowVertLines = False
            treeList.OptionsView.ShowHorzLines = False
            treeList.OptionsView.ShowIndicator = False
            treeList.OptionsView.ShowColumns = True
            treeList.OptionsView.ShowCheckBoxes = True
            treeList.OptionsView.ShowCaption = True
            treeList.Caption = "TreeList"
            treeList.CaptionHeight = 20
            treeList.OptionsView.AutoWidth = True
            treeList.TopVisibleNodeIndex = 10
            treeList.ExpandAll()
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
		<CodeExampleCase("Custom cell edit", New Type() { GetType(DataSourceHelper) }), CodeExampleUnderlineTokens("CustomNodeCellEdit")>
        Public Shared Sub CustomCellEdit(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            AddHandler treeList.CustomNodeCellEdit, Sub(sender, e)
                                                        If e.Column IsNot column3 Then
                                                            Return
                                                        End If
                                                        If e.Node.Id Mod 2 = 0 Then
                                                            e.RepositoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
                                                        End If
                                                    End Sub
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
        <CodeExampleCase("Customizing find panel via code", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub CustomizingFindPanel(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.OptionsFind.AllowFindPanel = True
            treeList.OptionsFind.AlwaysVisible = True
            treeList.OptionsFind.FindMode = FindMode.Always
            treeList.OptionsFind.FindNullPrompt = "Enter text to search..."
            treeList.OptionsFind.FindDelay = 1000
            treeList.OptionsFind.ClearFindOnClose = True
            treeList.OptionsFind.HighlightFindResults = True
            treeList.OptionsFind.ShowClearButton = True
            treeList.OptionsFind.ShowCloseButton = False
            treeList.OptionsFind.ShowFindButton = True
            treeList.OptionsFind.FindFilterColumns = "*"
            treeList.OptionsBehavior.EnableFiltering = False
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
        <CodeExampleCase("Customizing columns filter via code", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub CustomizingColumnsFilter(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            column3.OptionsFilter.AllowFilter = False
            treeList.OptionsBehavior.EnableFiltering = True
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.OptionsFilter.AllowColumnMRUFilterList = True
            treeList.OptionsFilter.AllowFilterEditor = True
            treeList.OptionsFilter.AllowMRUFilterList = True
            treeList.OptionsFilter.ColumnFilterPopupRowCount = 10
            treeList.OptionsFilter.FilterMode = FilterMode.Standard
            treeList.OptionsFilter.MRUColumnFilterListCount = 10
            treeList.OptionsFilter.MRUFilterListPopupCount = 10
            treeList.OptionsFilter.ShowAllValuesInCheckedFilterPopup = True
            treeList.OptionsFilter.ShowAllValuesInFilterPopup = True
            treeList.OptionsFilter.DefaultFilterEditorView = FilterEditorViewMode.Text
            treeList.OptionsBehavior.ExpandNodesOnFiltering = True
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
        <CodeExampleCase("Customizing fixed bands via code", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub CustomizingFixedBands(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            treeList.OptionsView.ShowBandsMode = DevExpress.Utils.DefaultBoolean.True
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            Dim column4 As TreeListColumn = treeList.Columns.AddVisible("Value4")
            Dim column5 As TreeListColumn = treeList.Columns.AddVisible("Value5")
            column1.Caption = "Column1"
            column1.RowIndex = 0
            column2.Caption = "Column2"
            column2.RowIndex = 1
            column3.Caption = "Column3"
            column4.Caption = "Column4"
            column5.Caption = "Column5"
            Dim band1 As TreeListBand = treeList.Bands.AddBand("Band1")
            Dim band2 As TreeListBand = treeList.Bands.AddBand("Band2")
            Dim band3 As TreeListBand = treeList.Bands.AddBand("Band3")
            Dim band4 As TreeListBand = treeList.Bands.AddBand("Band4")
            band1.Columns.Add(column1)
            band1.Columns.Add(column2)
            band2.Columns.Add(column3)
            band3.Columns.Add(column4)
            band4.Columns.Add(column5)
            band1.Fixed = FixedStyle.Left
            band4.Fixed = FixedStyle.Right
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.OptionsBehavior.Editable = False
            treeList.OptionsView.AutoWidth = False
            treeList.OptionsCustomization.AllowBandResizing = True
            treeList.OptionsCustomization.AllowBandMoving = True
            treeList.OptionsCustomization.AllowChangeBandParent = True
            treeList.OptionsCustomization.AllowChangeColumnParent = True
            treeList.OptionsCustomization.AllowColumnMoving = True
            treeList.OptionsCustomization.AllowColumnResizing = True
            treeList.OptionsView.AllowBandColumnsMultiRow = True
            treeList.FixedLineWidth = 2
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
        <CodeExampleCase("Customizing fixed columns via code", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub CustomizingFixedColumns(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            Dim column4 As TreeListColumn = treeList.Columns.AddVisible("Value4")
            Dim column5 As TreeListColumn = treeList.Columns.AddVisible("Value5")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            column4.Caption = "Column4"
            column5.Caption = "Column5"
            column1.Fixed = FixedStyle.Left
            column2.Fixed = FixedStyle.Right
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.OptionsBehavior.Editable = False
            treeList.OptionsView.AutoWidth = False
            treeList.OptionsCustomization.AllowChangeColumnParent = True
            treeList.OptionsCustomization.AllowColumnMoving = True
            treeList.OptionsCustomization.AllowColumnResizing = True
            treeList.FixedLineWidth = 2
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
        <CodeExampleCase("Customizing selection via code", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub CustomizingSelection(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            Dim column4 As TreeListColumn = treeList.Columns.AddVisible("Value4")
            Dim column5 As TreeListColumn = treeList.Columns.AddVisible("Value5")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            column4.Caption = "Column4"
            column5.Caption = "Column5"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            treeList.OptionsSelection.MultiSelect = True
            treeList.OptionsSelection.MultiSelectMode = TreeListMultiSelectMode.CellSelect
            treeList.OptionsSelection.SelectNodesOnRightClick = False
            treeList.OptionsSelection.UseIndicatorForSelection = True
            treeList.OptionsSelection.InvertSelection = False
            treeList.OptionsBehavior.Editable = False
            treeList.OptionsBehavior.KeepSelectedOnClick = True
            treeList.BestFitColumns()
            treeList.EndUpdate()
        End Sub
        <CodeExampleCase("Customizing conditional formatting via code", New Type() {GetType(DataSourceHelper)})>
        Public Shared Sub CustomizingConditionalFormatting(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            treeList.OptionsMenu.ShowConditionalFormattingItem = True
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value6")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)

            Dim ruleValue As New FormatConditionRuleValue()
            ruleValue.Condition = FormatCondition.Expression
            ruleValue.Value1 = 5
            ruleValue.Expression = "[Value3] == false"
            ruleValue.Appearance.BackColor = Color.LightGreen
            treeList.FormatRules.Add(column3, ruleValue)

            Dim rule1 As New TreeListFormatRule()
            Dim rule2ColorScale As New FormatConditionRule2ColorScale()
            rule1.Column = column2
            rule1.ColumnApplyTo = column1
            rule2ColorScale.PredefinedName = "White, Red"
            rule1.Rule = rule2ColorScale
            treeList.FormatRules.Add(rule1)

            Dim rule2 As New TreeListFormatRule()
            Dim ruleDataBar As New FormatConditionRuleDataBar()
            rule2.Column = column2
            rule2.ApplyToRow = True
            ruleDataBar.PredefinedName = "Blue Gradient"
            rule2.Rule = ruleDataBar
            treeList.FormatRules.Add(rule2)
            treeList.EndUpdate()
        End Sub
		<CodeExampleCase("Custom draw", New Type() { GetType(DataSourceHelper) }), CodeExampleUnderlineTokens("CustomDrawNodeCell", "CustomDrawNodeIndent", "CustomDrawColumnHeader", "CustomDrawNodeIndicator")>
        Public Shared Sub CustomDraw(ByVal treeList As TreeList)
            treeList.BeginUpdate()
            Dim column1 As TreeListColumn = treeList.Columns.AddVisible("Value1")
            Dim column2 As TreeListColumn = treeList.Columns.AddVisible("Value2")
            Dim column3 As TreeListColumn = treeList.Columns.AddVisible("Value3")
            column1.Caption = "Column1"
            column2.Caption = "Column2"
            column3.Caption = "Column3"
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10)
            AddHandler treeList.CustomDrawNodeCell, Sub(sender, e)
                                                        Dim cellIndex As Integer = e.Column.AbsoluteIndex + e.Node.Id
                                                        If cellIndex Mod 2 <> 0 AndAlso (Not e.Node.Selected) Then
                                                            e.Appearance.BackColor = Color.LightYellow
                                                        End If
                                                    End Sub
            AddHandler treeList.CustomDrawNodeIndent, Sub(sender, e)
                                                          If e.Node.Id Mod 2 = 0 Then
                                                              e.Appearance.BackColor = Color.LightYellow
                                                          End If
                                                      End Sub
            AddHandler treeList.CustomDrawColumnHeader, Sub(sender, e)
                                                            e.DefaultDraw()
                                                            If e.Pressed AndAlso e.HotTrack Then
                                                                Return
                                                            End If
                                                            If e.Column Is Nothing OrElse e.Column.AbsoluteIndex Mod 2 = 0 Then
                                                                Dim realBounds As Rectangle = Rectangle.Inflate(e.Bounds, -1, -1)
                                                                Using brush As New SolidBrush(Color.LightYellow)
                                                                    e.Graphics.FillRectangle(brush, realBounds)
                                                                End Using
                                                                e.Appearance.DrawString(e.Cache, e.Caption, e.CaptionRect)
                                                            End If
                                                        End Sub
            AddHandler treeList.CustomDrawNodeIndicator, Sub(sender, e)
                                                             e.DefaultDraw()
                                                             If e.Node.Id Mod 2 <> 0 Then
                                                                 Using brush As New SolidBrush(Color.LightYellow)
                                                                     e.Graphics.FillRectangle(brush, Rectangle.Inflate(e.Bounds, -1, -1))
                                                                 End Using
                                                                 Dim painter As DevExpress.Utils.Drawing.IndicatorObjectPainter = TryCast(e.Painter, DevExpress.Utils.Drawing.IndicatorObjectPainter)
                                                                 If DevExpress.Utils.ImageCollection.IsImageListImageExists(painter.ImageList, e.ImageIndex) Then
                                                                     Dim size As Size = DevExpress.Utils.ImageCollection.GetImageListSize(painter.ImageList)
                                                                     Dim offsetX As Integer = CInt((e.Bounds.Width - size.Width) / 2)
                                                                     Dim offsetY As Integer = CInt((e.Bounds.Height - size.Height) / 2)
                                                                     Dim realBounds As Rectangle = Rectangle.Inflate(e.Bounds, -offsetX, -offsetY)
                                                                     DevExpress.Utils.ImageCollection.DrawImageListImage(e.Cache, painter.ImageList, e.ImageIndex, realBounds)
                                                                 End If

                                                             End If
                                                         End Sub
            treeList.EndUpdate()
        End Sub
        <CodeExampleNestedClass>
        Public NotInheritable Class DataSourceHelper
            Private Sub New()
            End Sub
            Public Shared Function GetDataSource(ByVal parentID As Integer, ByVal startIndex As Integer, ByVal countNode As Integer) As List(Of Data)
                Return GetDataSourceCore(parentID, startIndex, countNode, 0)
            End Function
            Private Shared Function GetDataSourceCore(ByVal parentID As Integer, ByVal startIndex As Integer, ByVal countNode As Integer, ByVal level As Integer) As List(Of Data)
                Dim list As New List(Of Data)()
                If level > 2 Then
                    Return list
                End If
                For i As Integer = startIndex To startIndex + countNode - 1
                    list.Add(New Data(parentID, i, i, level, countNode))
                    list.AddRange(GetDataSourceCore(i, i * countNode + 1, countNode, level + 1))
                Next i
                Return list
            End Function
            Private Shared imagesCore As DevExpress.Utils.ImageCollection
            Public Shared ReadOnly Property Images() As DevExpress.Utils.ImageCollection
                Get
                    If imagesCore Is Nothing Then
                        imagesCore = New DevExpress.Utils.ImageCollection()
                        AddImage(Color.LightCoral, imagesCore)
                        AddImage(Color.LightGreen, imagesCore)
                        AddImage(Color.LightSkyBlue, imagesCore)
                    End If
                    Return imagesCore
                End Get
            End Property
            Private Shared Sub AddImage(ByVal color As Color, ByVal images As DevExpress.Utils.ImageCollection)
                Dim bmp As New Bitmap(16, 16)
                Using g As Graphics = Graphics.FromImage(bmp)
                    g.Clear(color)
                End Using
                images.AddImage(bmp)
            End Sub
            Public Class Data
                Public Sub New(ByVal parentID As Integer, ByVal id As Integer, ByVal value As Integer, ByVal level As Integer, ByVal countNode As Integer)
                    Me.ParentID = parentID
                    Me.ID = id
                    Value1 = "[Row" & value & "; Column1]"
                    Value2 = "[Row" & value & "; Column2]"
                    Value4 = "[Row" & value & "; Column4]"
                    Value5 = "[Row" & value & "; Column5]"
                    Value6 = CDbl(value) / Math.Pow(countNode, level)
                    Value3 = value Mod 2 = 0
                    ImageIndex = level
                End Sub
                Private privateParentID As Integer
                Public Property ParentID() As Integer
                    Get
                        Return privateParentID
                    End Get
                    Private Set(ByVal value As Integer)
                        privateParentID = value
                    End Set
                End Property
                Private privateID As Integer
                Public Property ID() As Integer
                    Get
                        Return privateID
                    End Get
                    Private Set(ByVal value As Integer)
                        privateID = value
                    End Set
                End Property
                Public Property Value1() As String
                Public Property Value2() As String
                Public Property Value3() As Boolean
                Public Property Value4() As String
                Public Property Value5() As String
                Public Property Value6() As Double
                Public Property ImageIndex() As Integer
            End Class
        End Class
    End Class
End Namespace

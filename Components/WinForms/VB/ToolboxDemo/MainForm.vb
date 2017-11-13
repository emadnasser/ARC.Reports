Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.XtraSpreadsheet.Commands
Imports DevExpress.XtraToolbox
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Utils.About

Namespace ToolboxDemo
    Partial Public Class MainForm
        Inherits RibbonForm

        Public Sub New()
            UAlgo.Default.DoEventObject(UAlgo.kDemo, UAlgo.pWinForms, Me) 'DEMO_REMOVE
            InitializeComponent()
            InitializeToolbox()
            Toolbox.SelectedGroupIndex = 0
            LoadDocument("Data\ToolboxDemoData.xlsx")
        End Sub
        Protected Sub LoadDocument(ByVal fileName As String)
            Dim filePath As String = FilesHelper.FindingFileName(Application.StartupPath, fileName)
            Spreadsheet.Document.LoadDocument(filePath)
        End Sub
        Protected Sub InitializeToolbox()
            Toolbox.Groups.Add(ToolboxGroupChartColumn)
            Toolbox.Groups.Add(ToolboxGroupChartBar)
            Toolbox.Groups.Add(ToolboxGroupChartArea)
        End Sub
        Public ReadOnly Property Toolbox() As ToolboxControl
            Get
                Return toolboxControl
            End Get
        End Property
        Public ReadOnly Property Spreadsheet() As SpreadsheetControl
            Get
                Return spreadsheetControl
            End Get
        End Property

        Private toolboxGroupChartColumn_Renamed As ToolboxGroup
        Protected ReadOnly Property ToolboxGroupChartColumn() As ToolboxGroup
            Get
                If toolboxGroupChartColumn_Renamed IsNot Nothing Then
                    Return toolboxGroupChartColumn_Renamed
                Else
                    toolboxGroupChartColumn_Renamed = GetToolboxGroupFromData(ToolboxData.ChartColumn, "Column")
                    Return toolboxGroupChartColumn_Renamed
                End If
            End Get
        End Property

        Private toolboxGroupChartBar_Renamed As ToolboxGroup
        Protected ReadOnly Property ToolboxGroupChartBar() As ToolboxGroup
            Get
                If toolboxGroupChartBar_Renamed IsNot Nothing Then
                    Return toolboxGroupChartBar_Renamed
                Else
                    toolboxGroupChartBar_Renamed = GetToolboxGroupFromData(ToolboxData.ChartBar, "Bar")
                    Return toolboxGroupChartBar_Renamed
                End If
            End Get
        End Property

        Private toolboxGroupChartArea_Renamed As ToolboxGroup
        Protected ReadOnly Property ToolboxGroupChartArea() As ToolboxGroup
            Get
                If toolboxGroupChartArea_Renamed IsNot Nothing Then
                    Return toolboxGroupChartArea_Renamed
                Else
                    toolboxGroupChartArea_Renamed = GetToolboxGroupFromData(ToolboxData.ChartArea, "Area")
                    Return toolboxGroupChartArea_Renamed
                End If
            End Get
        End Property
        Protected Function GetToolboxGroupFromData(ByVal data As Dictionary(Of ToolboxDataKey, String), ByVal name As String) As ToolboxGroup
            Dim group As New ToolboxGroup(name)
            Dim lastCategoryName As String = String.Empty
            For Each key As ToolboxDataKey In data.Keys
                Dim item As New ToolboxItem()
                Dim command As SpreadsheetCommand = Spreadsheet.CreateCommand(key.Id)
                item.Caption = command.MenuCaption
                item.Image = command.LargeImage
                item.Tag = key.ChartType
                item.BeginGroup = lastCategoryName <> data(key)
                lastCategoryName = data(key)
                item.BeginGroupCaption = If(item.BeginGroup, lastCategoryName, String.Empty)
                group.Items.Add(item)
            Next key
            Return group
        End Function
        Protected Function CanDropItem(ByVal loc As Point) As Boolean
            Return ClientBounds.Contains(loc) AndAlso Spreadsheet.GetCellFromPoint(loc) IsNot Nothing
        End Function
        Protected Sub OnToolboxDragItemDrop(ByVal sender As Object, ByVal e As ToolboxDragItemDropEventArgs) Handles toolboxControl.DragItemDrop
            If Not CanDropItem(Spreadsheet.PointToClient(Cursor.Position)) Then
                Return
            End If
            Dim pt As Point = GetCenterPoint(Cursor.Position)
            Spreadsheet.BeginUpdate()
            Try
                Dim chart As Chart = Spreadsheet.ActiveWorksheet.Charts.Add(CType(e.Item.Tag, ChartType), Spreadsheet.ActiveWorksheet("C4:D15"))
                chart.TopLeftCell = Spreadsheet.GetCellFromPoint(New PointF(pt.X - HorizontalIndent, pt.Y - VerticalIndent))
                chart.BottomRightCell = Spreadsheet.GetCellFromPoint(New PointF(pt.X + HorizontalIndent, pt.Y + VerticalIndent))
            Catch
                Spreadsheet.CancelUpdate()
            Finally
                Spreadsheet.EndUpdate()
            End Try

        End Sub
        Protected ReadOnly Property ClientBounds() As Rectangle
            Get
                Return Spreadsheet.Bounds
            End Get
        End Property
        Protected ReadOnly Property VerticalIndent() As Integer
            Get
                Return 150
            End Get
        End Property
        Protected ReadOnly Property HorizontalIndent() As Integer
            Get
                Return 200
            End Get
        End Property
        Protected Function GetCenterPoint(ByVal point As Point) As Point
            Dim pt As Point = Spreadsheet.PointToClient(Cursor.Position)
            If pt.X + HorizontalIndent >= ClientBounds.Right Then
                pt.X -= HorizontalIndent + 20
            End If
            If pt.X - HorizontalIndent <= ClientBounds.Left Then
                pt.X += HorizontalIndent + 20
            End If
            If pt.Y + VerticalIndent >= ClientBounds.Bottom Then
                pt.Y -= VerticalIndent + 20
            End If
            If pt.Y - VerticalIndent <= ClientBounds.Top Then
                pt.Y += VerticalIndent + 20
            End If
            Return pt
        End Function
        Protected Sub OnToolboxDragItemMove(ByVal sender As Object, ByVal e As ToolboxDragItemMoveEventArgs) Handles toolboxControl.DragItemMove
            e.DragDropEffects = If(CanDropItem(Spreadsheet.PointToClient(Cursor.Position)), DragDropEffects.Move, DragDropEffects.None)
        End Sub
        Protected Sub OnToolboxDragItemStart(ByVal sender As Object, ByVal e As ToolboxDragItemStartEventArgs) Handles toolboxControl.DragItemStart
            Dim item As ToolboxItem = TryCast(e.Item, ToolboxItem)
            If item Is Nothing Then
                Return
            End If
            e.Image = item.Image
            e.Handled = True
        End Sub
        Protected Sub OnToolboxStateChanged(ByVal sender As Object, ByVal e As ToolboxStateChangedEventArgs) Handles toolboxControl.StateChanged
            Toolbox.OptionsView.ShowMenuButton = Toolbox.OptionsMinimizing.State = ToolboxState.Minimized
        End Sub
    End Class
End Namespace

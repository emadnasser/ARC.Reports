Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.IO
Imports System.Reflection
Imports DevExpress.Data
Imports DevExpress.Utils
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel
Imports System.Collections

Namespace PivotGridOlapBrowser.Helpers
    Friend Interface IXRControlCreatable
        Function CreateControl() As XRControl
    End Interface
    Friend Interface IInitializable
        Function Initialize(ByVal control As Control) As Boolean
    End Interface
    Public Class XRPivotGridEx
        Inherits XRPivotGrid
        Implements IInitializable
        Private Const PivotName As String = "xrPivot"

        Public Shared Function Create(ByVal browser As BrowserPivot) As XRPivotGridEx
            Dim xrPivot As New XRPivotGridEx()
            xrPivot.Initialize(browser, True)
            Return xrPivot
        End Function

        Private pivot As BrowserPivot
        Private Function Initialize(ByVal pivot As BrowserPivot, ByVal loadLayout As Boolean) As Boolean
            Me.pivot = pivot
            If pivot Is Nothing Then
                Return False
            End If
            Me.Name = PivotName
            If loadLayout Then
                Me.LoadLayout(pivot)
            End If
            LoadDataSource(pivot)
            LoadCollapsedState(pivot)
            Return True
        End Function
        Private Sub LoadLayout(ByVal pivot As BrowserPivot)
            Using stream As New MemoryStream()
                pivot.SaveLayoutToStream(stream)
                stream.Position = 0
                Me.RestoreLayoutCore(New XmlXtraSerializer(), stream, OptionsLayoutBase.FullLayout)
            End Using
        End Sub
        Private Sub LoadDataSource(ByVal pivot As BrowserPivot)
            Dim pivotDataSource As IPivotGridDataSource = TryCast(pivot.DataSourceClone, IPivotGridDataSource)
            If pivotDataSource IsNot Nothing Then
                Me.Data.PivotDataSource = pivotDataSource
            End If
        End Sub
        Private Sub LoadCollapsedState(ByVal pivot As BrowserPivot)
            Using stream As New MemoryStream()
                pivot.SaveCollapsedStateToStream(stream)
                stream.Position = 0
                Me.Data.LoadCollapsedStateFromStream(stream)
            End Using
        End Sub

#Region "IInitializable Members"
        Private Function Initialize(ByVal control As Control) As Boolean Implements IInitializable.Initialize
            Return Me.Initialize(TryCast(control, BrowserPivot), False)
        End Function
#End Region
    End Class

    Public Class XRChartEx
        Inherits XRChart
        Implements IInitializable
        Private Const ChartName As String = "xrChart"

        Public Shared Function Create(ByVal chart As BrowserChart) As XRChartEx
            Dim xrChart As New XRChartEx()
            xrChart.Initialize(chart)
            Return xrChart
        End Function

        Private Function Initialize(ByVal chart As BrowserChart) As Boolean
            If chart Is Nothing Then
                Return False
            End If
            Name = ChartName
            CType(Me, IChartContainer).Chart.Assign((CType(chart, IChartContainer)).Chart)
            Return True
        End Function
#Region "IInitializable Members"
        Private Function IInitializable_Initialize(ByVal control As Control) As Boolean Implements IInitializable.Initialize
            Return Initialize(TryCast(control, BrowserChart))
        End Function
#End Region
    End Class

    Public Class XRGridEx
        Inherits XRTable
        Implements IInitializable
        Private Const GridName As String = "xrGrid"
        Private Const DefaultRowHeight As Single = 25
        Public Shared Function Create(ByVal grid As BrowserGrid) As XRGridEx
            Dim xrGrid As New XRGridEx()
            xrGrid.Initialize(grid)
            Return xrGrid
        End Function

        Private grid As BrowserGrid

        Private Function Initialize(ByVal grid As BrowserGrid) As Boolean
            Me.grid = grid
            If grid Is Nothing Then
                Return False
            End If
            Me.Name = GridName

            Dim gridData As DataSet = FillDatasetFromGrid(CType(grid.MainView, GridView))
            PrepareCells(gridData.Tables(0))
            Return True
        End Function

#Region "Convert grid to report objects"
        Private Function FillDatasetFromGrid(ByVal gridView As GridView) As DataSet
            Dim ds As New DataSet()
            Dim dataTable As DataTable = ds.Tables.Add()

            For Each gridColumn As GridColumn In gridView.Columns
                If (IsColumnVisible(gridColumn)) Then
                    dataTable.Columns.Add(New DataColumn(gridColumn.GetCaption()))
                End If
            Next
            For i As Integer = 0 To gridView.RowCount - 1
                Dim rowHandle As Integer = gridView.GetVisibleRowHandle(i)
                If (Not gridView.IsGroupRow(rowHandle)) Then
                    Dim drillDownRow As PivotDrillDownDataRow = CType(gridView.GetRow(rowHandle), PivotDrillDownDataRow)
                    Dim values As New ArrayList()
                    For Each gridColumn As GridColumn In gridView.Columns
                        If (IsColumnVisible(gridColumn)) Then
                            values.Add(drillDownRow(gridColumn.FieldName))
                        End If
                    Next
                    dataTable.Rows.Add(values.ToArray())
                End If
            Next i
            Return ds
        End Function
        Private Function IsColumnVisible(gridColumn As GridColumn) As Boolean
            Return gridColumn.Visible And gridColumn.GroupIndex < 0
        End Function
        Private Sub PrepareCells(ByVal dataTable As DataTable)
            Dim colCount As Integer = dataTable.Columns.Count
            Dim rowCount As Integer = dataTable.Rows.Count

            Me.HeightF = DefaultRowHeight * (rowCount + 1)
            Me.Borders = BorderSide.All
            Me.BeginInit()
            Me.Rows.Clear()
            Dim row As New XRTableRow()
            ' Header
            For i As Integer = 0 To colCount - 1
                Dim cell As New XRTableCell()
                cell.Text = dataTable.Columns(i).Caption
                cell.TextAlignment = TextAlignment.MiddleCenter
                row.Cells.Add(cell)
            Next i
            Me.Rows.Add(row)
            ' Content
            For i As Integer = 0 To rowCount - 1
                row = New XRTableRow()
                For j As Integer = 0 To colCount - 1
                    Dim cell As New XRTableCell()
                    cell.Text = dataTable.Rows(i)(j).ToString()
                    cell.TextAlignment = TextAlignment.MiddleCenter
                    row.Cells.Add(cell)
                Next j
                Me.Rows.Add(row)
            Next i
            Me.AdjustSize()
            Me.EndInit()
        End Sub
#End Region

#Region "IInitializable Members"
        Private Function IInitializable_Initialize(ByVal control As Control) As Boolean Implements IInitializable.Initialize
            Return Me.Initialize(TryCast(control, BrowserGrid))
        End Function
#End Region
    End Class

    Public Class BrowserReport
        Inherits XtraReport
        Private Const DefaultControlHeight As Single = 250

        Private ReadOnly reportControls As List(Of Control)
        Private ReadOnly relationDic As Dictionary(Of String, Control)

        Public Sub New(ByVal reportControls As List(Of Control))
            MyBase.New()
            Me.reportControls = reportControls
            Dim xrControls As List(Of XRControl) = ReportControlsFactory.Create(Me.reportControls)
            Me.relationDic = New Dictionary(Of String, Control)()
            For i As Integer = 0 To Me.reportControls.Count - 1
                If String.IsNullOrEmpty(xrControls(i).Name) Then
                    Continue For
                End If
                Me.relationDic.Add(xrControls(i).Name, Me.reportControls(i))
            Next i
            AddControls(xrControls)
        End Sub
        Protected Overrides Sub OnBeforePrint(ByVal e As System.Drawing.Printing.PrintEventArgs)
            MyBase.OnBeforePrint(e)
            Dim detail As DetailBand = GetDetail()
            For Each control As XRControl In detail.Controls
                Dim baseControl As Control = Nothing
                If (Not relationDic.TryGetValue(control.Name, baseControl)) Then
                    Continue For
                End If
                Dim initializableControl As IInitializable = TryCast(control, IInitializable)
                If initializableControl IsNot Nothing Then
                    initializableControl.Initialize(baseControl)
                    Continue For
                End If
            Next control
        End Sub
        Private Sub AddControls(ByVal xrControls As List(Of XRControl))
            Dim detail As DetailBand = GetDetail()
            For Each xrControl As XRControl In xrControls
                Me.Add(detail, xrControl)
            Next xrControl
        End Sub
        Private Sub Add(ByVal detail As DetailBand, ByVal xrControl As XRControl)
            InitSize(detail, xrControl)
            detail.Controls.Add(xrControl)
        End Sub
        Private Sub InitSize(ByVal detail As DetailBand, ByVal xrControl As XRControl)
            xrControl.LocationF = New PointF(0, detail.HeightF)
            If xrControl.HeightF < DefaultControlHeight Then
                xrControl.HeightF = DefaultControlHeight
            End If
            xrControl.WidthF = PageWidth - (Margins.Left + Margins.Right)
            detail.HeightF += xrControl.HeightF
        End Sub
        Private Function GetDetail() As DetailBand
            Dim detail As DetailBand = CType(Me.Bands(BandKind.Detail), DetailBand)
            If detail Is Nothing Then
                InitBands()
                detail = CType(Me.Bands(BandKind.Detail), DetailBand)
            End If
            Return detail
        End Function
        Private Sub InitBands()
            ' Create bands
            Dim detail As New DetailBand()
            Dim pageHeader As New PageHeaderBand()
            Dim reportFooter As New ReportFooterBand()
            detail.Height = 20
            reportFooter.Height = 380
            pageHeader.Height = 20
            ' Place the bands onto a report
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {detail, pageHeader, reportFooter})
        End Sub
        Protected Overrides Function CreateClone() As XtraReport
            Return New BrowserReport(reportControls)
        End Function
    End Class

    Public NotInheritable Class PivotReportGenerator
        Private Sub New()
        End Sub
        Public Shared Function GenerateReport(ByVal reportControls As List(Of Control)) As XtraReport
            Dim rep As New BrowserReport(reportControls)
            Return rep
        End Function
    End Class

    Public NotInheritable Class ReportControlsFactory
        Private Sub New()
        End Sub
        Public Shared Function Create(ByVal reportControls As List(Of Control)) As List(Of XRControl)
            Dim xrControls As New List(Of XRControl)()
            For Each control As Control In reportControls
                Dim xrControlCreatable As IXRControlCreatable = TryCast(control, IXRControlCreatable)
                If xrControlCreatable Is Nothing Then
                    Continue For
                End If

                Dim xrControl As XRControl = xrControlCreatable.CreateControl()
                xrControl.Name += Convert.ToString(xrControls.Count)
                xrControls.Add(xrControl)
            Next control
            Return xrControls
        End Function
    End Class
End Namespace

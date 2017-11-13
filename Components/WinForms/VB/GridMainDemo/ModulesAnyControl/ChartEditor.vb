Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.CustomEditor
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ChartEditor
        Inherits TutorialControl

        Private query As String = "SELECT Employees.EmployeeID, Categories.CategoryName, Sum([Order Details].Quantity) AS SumOfQuantity FROM Categories INNER JOIN (Products INNER JOIN ((Employees INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID) ON Categories.CategoryID = Products.CategoryID GROUP BY Employees.EmployeeID, Categories.CategoryName;"
        Private queryName As String = "SalesByCategory"
        Private ds As New DataSet()
        Private ReadOnly Property CurrentGrid() As GridControl
            Get
                Return gridControl1
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\ModulesAnyControl\ChartEditor.vb;VB\GridMainDemo\ModulesAnyControl\AnyChartEditor.vb"
            TutorialInfo.WhatsThisXMLFile = "ChartEditor.xml"
            InitNWindData()
            Dim photoEditor As New RepositoryItemPictureEdit()
            photoEditor.Caption.Appearance.BackColor = Color.FromArgb(200, Color.White)
            photoEditor.Caption.Appearance.ForeColor = Color.FromArgb(40,40,40)
            photoEditor.Caption.Text = "{FirstName} <b>{LastName}</b>"
            gridControl1.RepositoryItems.Add(photoEditor)
            colPhoto.ColumnEdit = photoEditor


        End Sub
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Employees", connectionString)
            SetWaitDialogCaption(My.Resources.LoadingEmployees)
            oleDbDataAdapter.Fill(ds, "Employees")
            CurrentGrid.DataSource = ds.Tables("Employees")

            oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter(query, connectionString)
            oleDbDataAdapter.Fill(ds, queryName)
        End Sub
        Private ReadOnly Property ChartSeries() As SeriesBase
            Get
                Return chartControl1.Series(0)
            End Get
        End Property
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitChartTypeEdit()
            ChartSeries.ArgumentDataMember = "CategoryName"
            ChartSeries.ValueDataMembers.AddRange("Quantity")
            '<gridControl1>
            CreateChartEdit(colChart, chartControl1)
            '</gridControl1>
        End Sub
        '<icbChartType>
        Private Sub InitChartTypeEdit()
            icbChartType.Properties.Items.Add(New ImageComboBoxItem("Pie", GetType(DevExpress.XtraCharts.PieSeriesView), -1))
            icbChartType.Properties.Items.Add(New ImageComboBoxItem("Doughnut", GetType(DevExpress.XtraCharts.DoughnutSeriesView), -1))
            icbChartType.Properties.Items.Add(New ImageComboBoxItem("Bar", GetType(DevExpress.XtraCharts.StackedBarSeriesView), -1))
            icbChartType.Properties.Items.Add(New ImageComboBoxItem("Line", GetType(DevExpress.XtraCharts.LineSeriesView), -1))
            icbChartType.Properties.Items.Add(New ImageComboBoxItem("Funnel", GetType(DevExpress.XtraCharts.FunnelSeriesView), -1))
            icbChartType.Properties.Items.Add(New ImageComboBoxItem("Area", GetType(DevExpress.XtraCharts.StackedAreaSeriesView), -1))
            icbChartType.Properties.Items.Add(New ImageComboBoxItem("Spline Area", GetType(DevExpress.XtraCharts.StackedSplineAreaSeriesView), -1))
            icbChartType.EditValue = ChartSeries.View.GetType()
        End Sub
        '</icbChartType>
        '<gridControl1>
        Private Shared Sub CreateChartEdit(ByVal column As GridColumn, ByVal chartControl As ChartControl)
            If column.ColumnEdit IsNot Nothing Then
                Return
            End If
            Dim item As New RepositoryItemAnyControl()
            item.Control = New EmbeddedChartControl(chartControl)
            column.View.GridControl.RepositoryItems.Add(item)
            CType(column.View, GridView).OptionsSelection.EnableAppearanceHideSelection = False
            column.OptionsColumn.AllowEdit = False
            column.OptionsFilter.AllowFilter = False
            column.OptionsColumn.AllowGroup = Utils.DefaultBoolean.False
            column.OptionsColumn.AllowSort = Utils.DefaultBoolean.False
            column.ColumnEdit = item
        End Sub

        Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDataEventArgs) Handles advBandedGridView1.CustomUnboundColumnData
            If e.IsGetData Then
                e.Value = GetChartData(e.Row)
            End If
        End Sub
        Private chartData As New Dictionary(Of Integer, List(Of EmployeeSalesByCategoryChartData))()
        Private Function GetChartData(ByVal val As Object) As Object
            Dim row_Renamed As DataRowView = TryCast(val, DataRowView)
            If row_Renamed Is Nothing Then
                Return Nothing
            End If
            Dim key As Integer = DirectCast(row_Renamed("EmployeeID"), Integer)
            If Not chartData.ContainsKey(key) Then
                chartData.Add(key, GetEmployeeSalesByCategoryChartData(key))
            End If
            Return chartData(key)
        End Function
        Private Function GetEmployeeSalesByCategoryChartData(ByVal key As Integer) As List(Of EmployeeSalesByCategoryChartData)
            Dim ret As New List(Of EmployeeSalesByCategoryChartData)()
            For Each row_Renamed As DataRow In ds.Tables(queryName).Rows
                If key.Equals(row_Renamed("EmployeeID")) Then
                    ret.Add(New EmployeeSalesByCategoryChartData() With {.CategoryName = row_Renamed("CategoryName").ToString(), .Quantity = DirectCast(row_Renamed("SumOfQuantity"), Double)})
                End If
            Next row_Renamed
            Return ret
        End Function
        '</gridControl1>
        '<icbChartType>
        Private Sub icbChartType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbChartType.SelectedIndexChanged
            Dim viewType As Type = TryCast(icbChartType.EditValue, Type)
            ChartSeries.View.Dispose()
            ChartSeries.View = TryCast(Activator.CreateInstance(viewType), SeriesViewBase)
            Dim edit As RepositoryItemAnyControl = TryCast(colChart.ColumnEdit, RepositoryItemAnyControl)
            If edit IsNot Nothing Then
                edit.RefreshControl()
            End If


        End Sub
        '</icbChartType>
        '<gridControl1>
        Public Class EmployeeSalesByCategoryChartData
            Public Property CategoryName() As String
            Public Property Quantity() As Double
        End Class
        '</gridControl1>
        Private Sub advBandedGridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDisplayTextEventArgs) Handles advBandedGridView1.CustomColumnDisplayText
            If e.Column Is colHireDate OrElse e.Column Is colHomePhone Then
                e.DisplayText = String.Format("{0}: {1:d}", e.Column.GetCaption(), e.Value)
            End If
        End Sub

        Private Sub advBandedGridView1_CustomDrawCell(ByVal sender As Object, ByVal e As Views.Base.RowCellCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawCell
            If e.Column Is colPhoto Then
                Dim cell = TryCast(e.Cell, DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo)
                Dim pic As PictureEditViewInfo = TryCast(cell.ViewInfo, PictureEditViewInfo)
                'if(pic != null) pic.CaptionText = advBandedGridView1.GetRowCellDisplayText(e.RowHandle, colFirstName) + "  " + advBandedGridView1.GetRowCellDisplayText(e.RowHandle, colLastName);
            End If
        End Sub
    End Class
End Namespace

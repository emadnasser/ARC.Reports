Imports System
Imports System.Linq
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.ASPxPivotGrid

Partial Public Class UserControls_ProductsPivotGrid
    Inherits ViewUserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        PivotGrid.CellTemplate = New CellTemplate()
        PivotGrid.Fields("State").ValueTemplate = New StateFieldValueTemplate()

        ApplyFilter()
        If Not IsPostBack Then
            PivotGrid.CollapseAll()
        End If
    End Sub
    Protected Sub ApplyFilter()
        If OwnerPage IsNot Nothing Then
            PivotGrid.Prefilter.CriteriaString = Filter.GetExpression(False)
        End If
    End Sub

    Public Overrides Property SelectedItemID() As Long
        Get
            Return DataProvider.emptyEntryID
        End Get
        Set(ByVal value As Long)
        End Set
    End Property
    Public Overrides Sub Update()
        ApplyFilter()
    End Sub

    Protected Sub SalesDataSource_Selecting(ByVal sender As Object, ByVal e As DevExpress.Data.Linq.LinqServerModeDataSourceSelectEventArgs)
        e.KeyExpression = "Id"
        e.QueryableSource = DataProvider.OrderItems
    End Sub

    Private Class StateFieldValueTemplate
        Implements ITemplate

        Private Sub ITemplate_InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
            Dim templateContainer = CType(container, PivotGridFieldValueTemplateContainer)
            Dim cell = templateContainer.CreateFieldValue()
            templateContainer.Controls.Add(cell)

            Dim stateDisplayName = DemoUtils.GetStateDisplayName(templateContainer.Text)
            If Not String.IsNullOrEmpty(stateDisplayName) Then
                cell.TextControl.Text = stateDisplayName
            End If
        End Sub
    End Class
    Private Class CellTemplate
        Implements ITemplate

        Private Sub ITemplate_InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
            Dim cellContainer = CType(container, PivotGridCellTemplateContainer)
            Dim field = cellContainer.DataField
            If field Is Nothing OrElse field.Caption <> "Percentage" Then
                cellContainer.Controls.Add(New LiteralControl(cellContainer.Text))
                Return
            End If
            Dim table = New Table() With {.CssClass = "progressBarTable"}
            cellContainer.Controls.Add(table)
            Dim row = New TableRow()
            table.Rows.Add(row)

            Dim cell = New TableCell() With {.CssClass = "progressBarCell"}
            row.Cells.Add(cell)

            Dim val = Convert.ToDecimal(cellContainer.Value) * 100
            cell.Controls.Add(New ASPxProgressBar() With {.Width = Unit.Percentage(100), .Height = 10, .Value = val, .ShowPosition = False})

            cell = New TableCell() With {.CssClass = "progressValueCell", .Text = String.Format("{0:N}%", val)}
            row.Cells.Add(cell)
        End Sub
    End Class
End Class

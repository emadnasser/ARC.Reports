Imports System
Imports System.Drawing
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Linq
Imports DataAccess
Imports DevExpress.Web
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPivotGrid

Partial Public Class Sales
    Inherits BasePage

    Public Overrides ReadOnly Property RangeControl() As IRangeControl
        Get
            Return FooterRangeControl
        End Get
    End Property

    Protected Sub SalesDataSource_Selecting(ByVal sender As Object, ByVal e As DevExpress.Data.Linq.LinqServerModeDataSourceSelectEventArgs)
        e.QueryableSource = SalesProvider.DataTable.Where(Function(s) s.SaleDate >= SalesStartDate AndAlso s.SaleDate <= SalesEndDate)
    End Sub
    Protected Sub SalesPivotGrid_Init(ByVal sender As Object, ByVal e As EventArgs)
        TryCast(sender, ASPxPivotGrid).CellTemplate = New CellTemplate()
    End Sub
End Class
Friend Class CellTemplate
    Implements ITemplate

    Private Sub ITemplate_InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
        Dim templateContainer As PivotGridCellTemplateContainer = CType(container, PivotGridCellTemplateContainer)
        Dim field As DevExpress.Web.ASPxPivotGrid.PivotGridField = templateContainer.DataField

        If field IsNot Nothing AndAlso field.ID = "fieldTotalCostPercents" Then
            Dim bar As New ASPxProgressBar()
            bar.CssClass = "pvProgressBar"
            bar.IndicatorStyle.CssClass = "indicator"
            bar.Position = 100 * Convert.ToDecimal(templateContainer.Value)
            bar.DisplayFormatString = "0.#"
            ' The settings are defined in the Init event to override ASPxProgressBar skin's settings specified in the MetropolisBlue theme
            AddHandler bar.Init, Sub(s, e) TryCast(s, ASPxProgressBar).ShowPosition = True
            templateContainer.Controls.Add(bar)
        Else
            templateContainer.Controls.Add(New LiteralControl(templateContainer.Text))
        End If
    End Sub
End Class

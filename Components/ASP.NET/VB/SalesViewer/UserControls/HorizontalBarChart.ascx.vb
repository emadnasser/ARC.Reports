Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DataAccess
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class HorizontalBarChart
    Inherits SimpleChartControlBase

    Private AbbreviationType As AbbreviationType = AbbreviationType.NoAbbreviation

    Public Property CrosshairLabelPattern() As String
        Get
            Return WebChartControl.SeriesTemplate.CrosshairLabelPattern
        End Get
        Set(ByVal value As String)
            WebChartControl.SeriesTemplate.CrosshairLabelPattern = value
        End Set
    End Property

    Protected Overrides ReadOnly Property WebChartControl() As WebChartControl
        Get
            Return ChartControl
        End Get
    End Property

    Private Sub CreateLegend(ByVal length As Integer)
        Dim firstColumn As New Panel()
        Dim secondColumn As New Panel()
        LegendHolder.Controls.Add(firstColumn)
        LegendHolder.Controls.Add(secondColumn)
        For i As Integer = 0 To length - 1
            Dim cell As New Panel()
            Dim colorDiv As New Panel()
            colorDiv.CssClass = "colorDiv"
            colorDiv.BackColor = PaletteHelper.GetCommonPalletePointColor(i)
            Dim text As New LiteralControl(GetPointName(i))
            cell.Controls.Add(colorDiv)
            cell.Controls.Add(text)
            If i Mod 2 = 0 Then
                firstColumn.Controls.Add(cell)
            Else
                secondColumn.Controls.Add(cell)
            End If
        Next i
    End Sub

    Protected Overrides Sub AfterSetData(ByVal data As IEnumerable(Of ChartData))
        If data.Any() Then
            AbbreviationType = If(data.Max(Function(x) x.Value) > 1000000, AbbreviationType.Millions, AbbreviationType.Thousands)
            LegendHolder.Visible = ShowLegend
            If ShowLegend Then
                CreateLegend(data.Count())
            End If
        End If
    End Sub

    Protected Sub ChartControl_CustomDrawAxisLabel(ByVal sender As Object, ByVal e As CustomDrawAxisLabelEventArgs)
        If TypeOf e.Item.Axis Is AxisY Then
            e.Item.Text = ScaleHelper.GetCurrencyAbbreviationMask(e.Item.Text, AbbreviationType)
        End If
    End Sub
End Class

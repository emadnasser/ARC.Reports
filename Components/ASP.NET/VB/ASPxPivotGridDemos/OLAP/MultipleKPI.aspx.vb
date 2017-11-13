Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.XtraPivotGrid

Partial Public Class OLAP_MultipleKPI
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim [error] As String = OLAPConnector.TryConnect(ASPxPivotGrid1)
		If String.IsNullOrEmpty([error]) Then
			Dim kpiTable As New Table()
			kpiTable.Width = New Unit(520)
			Dim kpis As List(Of String) = ASPxPivotGrid1.GetOLAPKPIList()
			For Each kpi As String In kpis
				Dim kpiValue As PivotOLAPKPIValue = ASPxPivotGrid1.GetOLAPKPIValue(kpi)

				Dim row As New TableRow()

				Dim name As New TableCell()
				name.Text = kpi
				name.Width = New Unit(200)
				row.Cells.Add(name)

				Dim value As New TableCell()
				value.Text = String.Format("{0:c}", kpiValue.Value)
				value.Width = New Unit(110)
				value.HorizontalAlign = HorizontalAlign.Right
				row.Cells.Add(value)

				Dim goal As New TableCell()
				goal.Text = String.Format("{0:c}", kpiValue.Goal)
				goal.Width = New Unit(110)
				goal.HorizontalAlign = HorizontalAlign.Right
				row.Cells.Add(goal)

				Dim status As New TableCell()
				status.Controls.Add(GetKPIImage(kpi, PivotKPIType.Status, kpiValue.Status))
				status.Width = New Unit(50)
				status.HorizontalAlign = HorizontalAlign.Center
				row.Cells.Add(status)

				Dim trend As New TableCell()
				trend.Controls.Add(GetKPIImage(kpi, PivotKPIType.Trend, kpiValue.Trend))
				trend.Width = New Unit(50)
				trend.HorizontalAlign = HorizontalAlign.Center
				row.Cells.Add(trend)

				kpiTable.Rows.Add(row)
			Next kpi
			ASPxRoundPanel1.Controls.Add(kpiTable)
			ASPxRoundPanel1.Visible = True
		Else
			Dim errorPanel As Control = OLAPConnector.CreateErrorPanel([error])
			ASPxPivotGrid1.Parent.Controls.AddAt(0, errorPanel)
		End If
	End Sub

	Private Function GetKPIImage(ByVal kpi As String, ByVal kpiType As PivotKPIType, ByVal value As Integer) As Image
		Dim image As New Image()
		Dim graphic As PivotKPIGraphic = ASPxPivotGrid1.GetOLAPKPIServerGraphic(kpi, kpiType)
		Dim imageProps As ImageProperties = ASPxPivotGrid1.GetKPIImage(graphic, kpiType, value)
		imageProps.AssignToControl(image, False)
		Return image
	End Function
End Class

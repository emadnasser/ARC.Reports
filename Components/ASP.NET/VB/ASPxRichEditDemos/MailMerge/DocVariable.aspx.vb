Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Linq
Imports DevExpress.Web.Demos
Imports System.Collections.Generic
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraCharts.Web

Partial Public Class RichEditDemoDocVariable
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			RichEditDemoUtils.HideFileTab(DemoRichEdit)
			DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "NORTHWIND.docx"))
			DemoRichEdit.ActiveTabIndex = 3
		End If
	End Sub
	Protected Sub DemoRichEdit_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		DemoRichEdit.Focus()
	End Sub

	Protected Sub DemoRichEdit_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
		Select Case e.VariableName
			Case "Chart"
				Dim sales = GetSales(e.Arguments(0).Value)
				Dim chart As DocumentImageSource = DocumentImageSource.FromStream(CreateChart(sales))
				Dim srv As New RichEditDocumentServer()
				srv.Document.Images.Append(chart)
				e.Value = srv.Document
				e.Handled = True
			Case "CommonSales"
				Dim commonSales = GetCommonSales(e.Arguments(0).Value)
				e.Value = commonSales.ToString("C")
				e.Handled = True
			Case Else
		End Select
	End Sub

	Private Function GetSales(ByVal categoryName As String) As IEnumerable(Of Sales_by_Category)
		Dim context = New NorthwindDataContextExt()
		Return context.Sales_by_Categories.Where(Function(s) s.CategoryName = categoryName)
	End Function

	Private Function GetCommonSales(ByVal categoryName As String) As Decimal
		Return GetSales(categoryName).Sum(Function(s) s.ProductSales.Value)
	End Function

	Private Function CreateChart(ByVal sales As IEnumerable(Of Sales_by_Category)) As Stream
		Dim cc = New WebChartControl()
		cc.Width = System.Web.UI.WebControls.Unit.Pixel(600)
		cc.Height = System.Web.UI.WebControls.Unit.Pixel(400)
		cc.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
		Dim series = New DevExpress.XtraCharts.Series("Products", DevExpress.XtraCharts.ViewType.Bar)
		series.DataSource = sales
		series.ArgumentDataMember = "ProductName"
		series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
		series.ValueDataMembers.AddRange(New String() { "ProductSales" })
		cc.Series.Add(series)
		Controls.Add(cc)
		cc.DataBind()
		Dim stream As New MemoryStream()
		cc.ExportToImage(stream, System.Drawing.Imaging.ImageFormat.Png)
		stream.Position = 0
		Return stream
	End Function
End Class

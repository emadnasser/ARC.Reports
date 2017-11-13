Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Threading
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class PagingAndScrolling_FixedRows
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		VerticalGrid.Settings.VerticalScrollBarMode = If(chbEnableVerticalScrolling.Checked, ScrollBarMode.Visible, ScrollBarMode.Hidden)
		VerticalGrid.Settings.RecordWidth = If(Utils.IsLargeTheme, 200, 185)

		Dim rowsToFix() As String = { "PhotoUrl", "Brand", "Model" }
		For Each row In rowsToFix
			VerticalGrid.Rows(row).Fixed = chbEnableFixedRows.Checked
		Next row

		Dim headphones = HeadphonesDataProvider.SelectHeadphones().Take(4)
		VerticalGrid.DataSource = headphones
		VerticalGrid.DataBind()
	End Sub
End Class

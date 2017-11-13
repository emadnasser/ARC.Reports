Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Threading
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class PagingAndScrolling_Categories
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsCallback Then
			Thread.Sleep(1000)
		End If

		VerticalGrid.SettingsBehavior.AllowExpandAnimation = chbEnableAnimation.Checked
		VerticalGrid.SettingsBehavior.AllowRowExpanding = chbAllowExpanding.Checked
		VerticalGrid.Settings.MergeHeaderIndents = chbShowIndents.Checked
		VerticalGrid.Settings.ShowCategoryIndents = VerticalGrid.Settings.MergeHeaderIndents
		VerticalGrid.Settings.RecordWidth = If(Utils.IsLargeTheme, 200, 185)

		Dim rowLoadingMode = If(chbEnableCallbackMode.Checked, VerticalGridRowLoadingMode.Callback, VerticalGridRowLoadingMode.Full)
		If (Not VerticalGrid.Settings.RowLoadingMode.Equals(rowLoadingMode)) AndAlso rowLoadingMode.Equals(VerticalGridRowLoadingMode.Callback) Then ' TODO VG instant vb
			CollapseCategoriesForCallbackMode()
		End If

		VerticalGrid.Settings.RowLoadingMode = rowLoadingMode
		Dim headphones = HeadphonesDataProvider.SelectHeadphones().Take(4)
		VerticalGrid.DataSource = headphones
		VerticalGrid.DataBind()
	End Sub

	Protected Sub CollapseCategoriesForCallbackMode()
		Dim categories = VerticalGrid.Rows.OfType(Of VerticalGridCategoryRow)()
		For Each category In categories
			category.Expanded = False
		Next category
	End Sub
End Class

Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class Filtering_HeaderFilter
	Inherits Page
	Private Shared WideThemes() As String = { "iOS", "Material", "Metropolis", "MetropolisBlue", "Moderno", "Mulberry", "SoftOrange" }

	Protected ReadOnly Property HeaderFilterMode() As GridHeaderFilterMode
		Get
			Return CType(cmbHeaderFilterMode.Value, GridHeaderFilterMode)
		End Get
	End Property
	Private ReadOnly Property IsWideHeaderFilterPopupContent() As Boolean
		Get
			Return Object.Equals(HeaderFilterMode, GridHeaderFilterMode.DateRangeCalendar) AndAlso WideThemes.Contains(Utils.CurrentTheme)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		grid.DataColumns("VisitDate").SettingsHeaderFilter.Mode = HeaderFilterMode
		grid.SettingsPopup.HeaderFilter.Width = If(IsWideHeaderFilterPopupContent, 360, 300)
		grid.SettingsPopup.HeaderFilter.Height = If(IsWideHeaderFilterPopupContent, 510, 320)
	End Sub
End Class

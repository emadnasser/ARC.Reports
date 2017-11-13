Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class FilteringAndSorting_DateRangeHeaderFilter
	Inherits Page
	Private Shared WideThemes() As String = { "Metropolis", "MetropolisBlue", "Moderno", "Mulberry", "SoftOrange" }

	Protected ReadOnly Property HeaderFilterMode() As GridHeaderFilterMode
		Get
			Return CType(cmbHeaderFilterMode.Value, GridHeaderFilterMode)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		CardView.Columns("VisitDate").SettingsHeaderFilter.Mode = HeaderFilterMode
		CardView.SettingsPopup.HeaderFilter.Width = GetHeaderFilterPopupWidth()
	End Sub
	Private Function GetHeaderFilterPopupWidth() As Integer
		Return If(Object.Equals(HeaderFilterMode, GridHeaderFilterMode.DateRangeCalendar) AndAlso WideThemes.Contains(Utils.CurrentTheme), 360, 300)
	End Function
End Class

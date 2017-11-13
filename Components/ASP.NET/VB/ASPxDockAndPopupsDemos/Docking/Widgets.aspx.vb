Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class Docking_Widgets
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim widgetNames() As String = { "DateTime", "Mail", "News", "Trading", "Weather", "Calendar" }
		repeater.DataSource = widgetNames
		repeater.DataBind()
	End Sub

	Protected Function GetClientButtonClickHandler(ByVal container As RepeaterItem) As String
		Return String.Format("function(s, e) {{ ShowWidgetPanel('{0}') }}", container.DataItem)
	End Function
End Class

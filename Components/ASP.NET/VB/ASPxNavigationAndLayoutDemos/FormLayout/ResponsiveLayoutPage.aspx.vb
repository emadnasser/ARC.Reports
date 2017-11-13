Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.Demos

Partial Public Class FormLayout_ResponsiveLayoutPage
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Overrides Sub FrameworkInitialize()
		MyBase.FrameworkInitialize()
		DevExpress.Web.ASPxWebControl.GlobalTheme = "Moderno"
		Utils.ResetThemeParameters()
	End Sub
End Class

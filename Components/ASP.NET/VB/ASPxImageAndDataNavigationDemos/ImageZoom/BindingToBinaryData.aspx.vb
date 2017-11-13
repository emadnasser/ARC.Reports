Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class ImageZoom_BindingToBinaryData
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		VerticalGrid.DataSource = HeadphonesDataProvider.SelectHeadphones()
		VerticalGrid.DataBind()
	End Sub
End Class

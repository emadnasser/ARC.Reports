Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Demos
Imports DevExpress.CodeParser

Partial Public Class TabControl_ClientSide
	Inherits Page
	Private Const CSharpCode As String = "protected override void OnLoad(EventArgs e) {" & Constants.vbLf & "    base.OnLoad(e);" & Constants.vbLf & "    StyleOptimizer.Instance.RegisterChildControls(Page);" & Constants.vbLf & "}" & Constants.vbLf

	Private Const VBCode As String = "Protected Overrides Sub OnLoad(ByVal e As EventArgs)" & Constants.vbLf & "    MyBase.OnLoad(e)" & Constants.vbLf & "    StyleOptimizer.Instance.RegisterChildControls(Page)" & Constants.vbLf & "End Sub" & Constants.vbLf


	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		CSharpCodeHolder.InnerHtml = CodeFormatter.GetFormattedCode(TokenLanguage.CSharp, CSharpCode)
		VBCodeHolder.InnerHtml = CodeFormatter.GetFormattedCode(TokenLanguage.Basic, VBCode)
	End Sub
End Class


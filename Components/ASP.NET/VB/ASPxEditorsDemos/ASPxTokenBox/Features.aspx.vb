Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ASPxTokenBox_Features
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxTokenBox1.IncrementalFilteringMode = CType(ddlIncrementalFilteringMode.Value, IncrementalFilteringMode)
		ASPxTokenBox1.ShowDropDownOnFocus = CType(ddlShowDropDownOnFocus.Value, ShowDropDownOnFocusMode)
		ASPxTokenBox1.AllowCustomTokens = chAllowCustomTokens.Checked

		If (Not IsPostBack) Then
			ASPxTokenBox1.Tokens.Add("Julia Evans")
			ASPxTokenBox1.Tokens.Add("Kevin Collins")
			ASPxTokenBox1.Tokens.Add("Diana Martin")
		End If
	End Sub
End Class

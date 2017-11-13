Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Threading
Imports System.Globalization
Imports DevExpress.Web

Partial Public Class Accessibility_Localization
	Inherits System.Web.UI.Page
	Protected Overrides Sub InitializeCulture()
		If (Not String.IsNullOrEmpty(GetDXCurrentLanguageValue())) Then
			'for regional server standards 
			Culture = GetDXCurrentLanguageValue()
			'for DevExpress localizable strings 
			UICulture = GetDXCurrentLanguageValue()
		End If
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not String.IsNullOrEmpty(GetDXCurrentLanguageValue())) Then
			LanguageComboBox.SelectedItem = LanguageComboBox.Items.FindByValue(GetDXCurrentLanguageValue())
		Else
			LanguageComboBox.SelectedIndex = 0
		End If
	End Sub

	Protected Function GetDXCurrentLanguageValue() As String
		Return If(Request.Cookies("DXCurrentLanguage") Is Nothing, "", Request.Cookies("DXCurrentLanguage").Value)
	End Function
End Class

Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.Threading
Imports System.Web.UI

Partial Public Class ASPxSpinEdit_Features
	Inherits Page
	Private ReadOnly Property CultureName() As String
		Get
			Return If(Request.Params("cult") = "it-IT", "it-IT", "en-US")
		End Get
	End Property
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		cmbCultureSelector.SelectedIndex = If(CultureName = "it-IT", 1, 0)
	End Sub
	Protected Overrides Sub InitializeCulture()
		Dim culture As New CultureInfo(CultureName)
		Thread.CurrentThread.CurrentCulture = culture
		Thread.CurrentThread.CurrentUICulture = culture
	End Sub
End Class

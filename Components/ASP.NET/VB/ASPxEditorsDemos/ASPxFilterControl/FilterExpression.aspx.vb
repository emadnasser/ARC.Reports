Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos
Imports System.Configuration

Partial Public Class ASPxFilterControl_FilterExpression
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ASPxFilterControl1.FilterExpression = "[Price] < 500000"
		End If

		UpdateDataViewFilterExpression()
	End Sub

	Protected Sub ASPxDataView1_CustomCallback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
		UpdateDataViewFilterExpression()
	End Sub

	Protected Sub ASPxFilterControl1_CustomJSProperties(ByVal sender As Object, ByVal e As CustomJSPropertiesEventArgs)
		e.Properties("cpFilterExpression") = ASPxFilterControl1.GetFilterExpressionForDataSet()
	End Sub

	Protected Sub UpdateDataViewFilterExpression()
		UpdateDataSourceFilterExpression()
		ASPxDataView1.DataBind()
	End Sub

	Protected Sub UpdateDataSourceFilterExpression()
		If ASPxFilterControl1.IsFilterExpressionValid() Then
			Dim filterExpression As String = ASPxFilterControl1.GetFilterExpressionForDataSet()
			ASPxLabel1.Text = filterExpression
			HomesDataSource.FilterExpression = filterExpression
		Else
			ASPxLabel1.Text = "Filter expression is not valid"
		End If
		If String.IsNullOrEmpty(ASPxLabel1.Text) Then
			ASPxLabel1.Text = "Filter expression is empty"
		End If
	End Sub
End Class

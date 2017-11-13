Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Features_DateRangePicker
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		deEnd.DateRangeSettings.MinDayCount = Convert.ToInt32(seMinDayCount.Value)
		Dim maxDayCount As Integer = Convert.ToInt32(seMaxDayCount.Value)
		If maxDayCount > 0 AndAlso maxDayCount < deEnd.DateRangeSettings.MinDayCount Then
			maxDayCount = deEnd.DateRangeSettings.MinDayCount
		End If
		deEnd.DateRangeSettings.MaxDayCount = maxDayCount
		seMaxDayCount.Value = deEnd.DateRangeSettings.MaxDayCount
	End Sub
	Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack AndAlso ASPxEdit.ValidateEditorsInContainer(Me) Then
			Page.ClientScript.RegisterStartupScript(Me.GetType(), "alert", "<script type=""text/javascript"">alert('The form has been submitted successfully.');</script>")
		End If
	End Sub
End Class

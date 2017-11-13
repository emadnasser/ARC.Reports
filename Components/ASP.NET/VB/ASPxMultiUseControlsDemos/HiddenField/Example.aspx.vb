Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI


Partial Public Class HiddenField_Example
	Inherits Page
	Private Enum ViewType
		season
		month
		preview
	End Enum
	Private Shared seasons() As String = { "Winter", "Spring", "Summer", "Autumn" }
	Private Shared months()() As String = { New String(){ "December", "January", "February" }, New String(){ "March", "April", "May" }, New String(){ "June", "July", "August" }, New String(){ "September", "October", "November" } }

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ResetAnswers()
		End If
		LoadView()
	End Sub

	Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
		Response.Redirect(Request.Url.PathAndQuery, True)
	End Sub

	Private Sub LoadView()
		mvVoting.ActiveViewIndex = CInt(Fix(hfAnswers("questionIndex")))
		Select Case CType(mvVoting.ActiveViewIndex, ViewType)
			Case ViewType.season
				LoadSeasons()
			Case ViewType.month
				LoadMonths()
			Case ViewType.preview
				LoadPreview()
		End Select
	End Sub

	Private Sub LoadSeasons()
		rblSeasons.Items.Clear()
		rblSeasons.Items.AddRange(seasons)
		rblSeasons.SelectedIndex = CInt(Fix(hfAnswers("season")))
	End Sub

	Private Sub LoadMonths()
		rblMonths.Items.Clear()
		rblMonths.Items.AddRange(months(CInt(Fix(hfAnswers("season")))))
		rblMonths.SelectedIndex = CInt(Fix(hfAnswers("month")))
	End Sub

	Private Sub LoadPreview()
		Dim seasonIndex As Integer = CInt(Fix(hfAnswers("season")))
		Dim monthIndex As Integer = CInt(Fix(hfAnswers("month")))
		lblSelectedSeason.Text = seasons(seasonIndex)
		lblSelectedMonth.Text = months(seasonIndex)(monthIndex)
	End Sub

	Private Sub ResetAnswers()
		hfAnswers("questionIndex") = 0
		hfAnswers("season") = 0
		hfAnswers("month") = 0
	End Sub
End Class

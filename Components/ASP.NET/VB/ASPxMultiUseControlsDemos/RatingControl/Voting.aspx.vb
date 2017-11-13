Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports System.Threading
Imports System.Collections.Generic

Partial Public Class RatingControl_Example
	Inherits Page
	Private votingValues As New List(Of Integer)(New Integer() { 5, 4, 3, 2, 4, 3, 5, 3 })

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim values As Array = System.Enum.GetValues(GetType(RatingControlItemFillPrecision))
			For Each value As Object In values
				cmbPrecision.Items.Add(value.ToString())
			Next value
			cmbPrecision.Value = allRating.FillPrecision.ToString()
		End If
		allRating.FillPrecision = CType(cmbPrecision.SelectedIndex, RatingControlItemFillPrecision)

		If (Not IsCallback) Then
			allRating.Value = GetRating()
			lbAllVotes.Text = String.Format("{0} votes ({1})", votingValues.Count, allRating.Value.ToString("0.##"))
		End If
	End Sub

	Protected Sub cbVoting_Callback(ByVal sender As Object, ByVal e As CallbackEventArgs)
		' Intentionally pauses server-side processing, 
		' to demonstrate the Rating Control functionality.
		Thread.Sleep(1000)
		Dim ratingValue As Decimal = GetRating()
		e.Result = String.Format("{0} {1} {1:0.##}", votingValues.Count, ratingValue)
	End Sub

	Public Function GetRating() As Decimal
		If myRating.Value > 0 Then
			Me.votingValues.Add(CInt(Fix(myRating.Value)))
		End If

		Dim sum As Decimal = 0
		For Each value As Integer In votingValues
			sum += value
		Next value
		Return sum / votingValues.Count
	End Function
End Class

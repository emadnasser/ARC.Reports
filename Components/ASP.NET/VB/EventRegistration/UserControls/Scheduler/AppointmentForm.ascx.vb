Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.XtraScheduler
Imports DevExpress.Web
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal
Imports System.Collections
Imports System.Collections.Generic
Imports DevExpress.XtraScheduler.Localization

Partial Public Class UserControls_AppointmentForm
	Inherits SchedulerFormControl
	Private Shared ReadOnly Levels As New Dictionary(Of Integer, String)()
	Shared Sub New()
		Levels.Add(1, "Beginner (100)")
		Levels.Add(2, "Intermediate (200)")
		Levels.Add(3, "Expert (300)")
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		lblAttending.Visible = Page.Items("attending") IsNot Nothing
	End Sub

	Protected Overrides Sub PrepareChildControls()

		MyBase.PrepareChildControls()
	End Sub

	Protected Overrides Function GetChildControls() As Control()
		Dim result As New List(Of Control)(MyBase.GetChildControls())
		result.AddRange(GetChildRatingControls())
		Return result.ToArray()
	End Function


	Protected Function GetChildRatingControls() As ASPxRatingControl()
		Dim ratingControls() As ASPxRatingControl = { rating }
		Return ratingControls
	End Function

	Protected Overrides Function GetChildEditors() As ASPxEditBase()
		Dim edits() As ASPxEditBase = { lblLocation, lblDescription, lblSpeaker, lblDay, lblTime, lblCategory }

		Return edits
	End Function
	Protected Overrides Function GetChildButtons() As ASPxButton()
		Dim buttons() As ASPxButton = { }
		Return buttons
	End Function
	Public Function rcGetToolTip() As String
		Return Levels(CInt(Fix(rating.Value)))
	End Function
End Class

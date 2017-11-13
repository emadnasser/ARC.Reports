Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports EventRegistration
Imports System.IO

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private ReadOnly Property SessionsRotator() As FeaturedSessionsRotator
		Get
			Return CurrentData.FeaturedSessionsRotator
		End Get
	End Property
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		doRegister.Visible = Not CurrentData.RegistrationInfo.Completed

		repeaterStar.DataSource = GetRandomShowsStars()
		repeaterStar.DataBind()

		ShowFeaturedSession(SessionsRotator.Current)
	End Sub
	Protected Sub btnRegister_Click(ByVal sender As Object, ByVal e As EventArgs)
		Response.Redirect("~/Registration.aspx")
	End Sub
	Protected Function GetStarPhotoUrl(ByVal photoFileName As String) As String
		Return ResolveClientUrl(Path.Combine(DataHelper.StarsPhotoFolder, photoFileName))
	End Function
	Private Function GetRandomShowsStars() As IEnumerable(Of Speaker)
		Return DataHelper.Data.Speakers.OrderBy(Function(speaker) Guid.NewGuid()).Take(2)
	End Function
	Protected Sub ShowFeaturedSession(ByVal session As Session)
		lblPreviewTitle.Text = session.Subject
		lblPreviewDescription.Text = session.Description
		lblPreviewSpeakerName.Text = session.Speaker
		lblPreviewSpeakerDescr.Text = session.SpeakerDescription
		If session.Image <> String.Empty Then
			imgSessionPreview.ImageUrl = Path.Combine(DataHelper.FeaturedSessionsFolder, session.Image)
		End If
		btnAttendSession.PostBackUrl = "~/Schedule.aspx?attend=" & session.Id
	End Sub
	Protected Sub ASPxCallbackPanel1_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
		Dim featuredSession As Session = Nothing
		Select Case e.Parameter
			Case "Next"
				featuredSession = SessionsRotator.Next
			Case "Prev"
				featuredSession = SessionsRotator.Prev
			Case Else
				Throw New NotImplementedException()
		End Select
		ShowFeaturedSession(featuredSession)
	End Sub
End Class

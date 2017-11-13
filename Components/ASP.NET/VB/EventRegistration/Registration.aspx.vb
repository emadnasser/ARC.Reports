Imports Microsoft.VisualBasic
Imports System
Imports EventRegistration
Imports System.Globalization
Imports System.Web.Script.Serialization

Partial Public Class Registration
	Inherits System.Web.UI.Page
	Private Const RegistrationDataFieldName As String = "RegData"
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If CurrentData.RegistrationInfo.Completed Then
			InitAlreadyRegistred()
		Else
			If IsCallback Then
				DeserializeData()
			End If

			If pc.ActiveTabPage.Name = "Confirmation" Then
				If CurrentData.RegistrationDate.Millisecond = 0 Then
					CurrentData.RegistrationDate = DateTime.Now
				End If
				LoadRegInfo()
			End If

			If pc.ActiveTabPage.Name = "Finish" Then
				CurrentData.RegistrationInfo.Completed = True
			End If

			SerializeData()
		End If
	End Sub
	Private Function GetDataFromHiddenField(ByVal serializer As JavaScriptSerializer) As PersonalData
		Return serializer.Deserialize(Of PersonalData)(TryCast(hfRegInfo.Get(RegistrationDataFieldName), String))
	End Function
	Private Sub DeserializeData()
		Dim serializer As New JavaScriptSerializer()
		CurrentData.RegistrationInfo = GetDataFromHiddenField(serializer)
	End Sub
	Private Sub SerializeData()
		Dim serializer As New JavaScriptSerializer()
		hfRegInfo.Set(RegistrationDataFieldName, serializer.Serialize(CurrentData.RegistrationInfo))
	End Sub
	Private Sub InitAlreadyRegistred()
		LoadRegInfo()
		pc.ActiveTabPage = pc.TabPages(2)
		pc.ShowTabs = False
		pc.TabPages(0).ClientEnabled = False
		pc.TabPages(1).ClientEnabled = False
		pc.TabPages(3).ClientEnabled = False
		btnBack.Visible = False
		btnNext.Visible = False
		btnFinish.Visible = False
		lblConfimInfo.Text = "You are already registered"
		pc.CssClass &= " alreadyRegistered"
	End Sub
	Private Sub LoadRegInfo()
		Dim regData As PersonalData = CurrentData.RegistrationInfo
		lblConfirmRegistrant.Text = String.Format("{0} ({1})", regData.FullName, regData.CompanyName)
		lblConfirmAddress.Text = String.Format("{0}, {1}", regData.City, regData.Address)
		lblConfirmPhone.Text = regData.Phone
		lblConfirmMail.Text = regData.Email
		lblRegDate.Text = CurrentData.RegistrationDate.ToString("g", CultureInfo.CreateSpecificCulture("en-us"))
	End Sub
	Protected Sub pc_Init(ByVal sender As Object, ByVal e As EventArgs)
		InitRegistrationFields()
	End Sub
	Protected Sub InitRegistrationFields()
		Dim year As Integer = DateTime.Now.Year
		Do While year - DateTime.Now.Year < 10
			cmbCardYear.Items.Add(year.ToString(), year)
			year += 1
		Loop
	End Sub

	Protected Sub btnGoToSchedule_Click(ByVal sender As Object, ByVal e As EventArgs)
		Response.Redirect("~/Schedule.aspx")
	End Sub
End Class

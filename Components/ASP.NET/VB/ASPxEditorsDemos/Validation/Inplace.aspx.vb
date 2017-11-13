Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Internal
Imports DevExpress.Web

Partial Public Class Validation_Inplace
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ApplySettings()
	End Sub

	Private ReadOnly Property ErrorDisplayMode() As ErrorDisplayMode
		Get
			Return CType(System.Enum.Parse(GetType(ErrorDisplayMode), rblErrorDisplayMode.Value.ToString()), ErrorDisplayMode)
		End Get
	End Property
	Private ReadOnly Property ValidateOnLeave() As Boolean
		Get
			Return chbValidateOnLeave.Checked
		End Get
	End Property
	Private ReadOnly Property SetFocusOnError() As Boolean
		Get
			Return chbSetFocusOnError.Checked
		End Get
	End Property

	Protected Sub OnSettingsChanged(ByVal sender As Object, ByVal e As EventArgs)
		ApplySettings()
	End Sub
	Private Sub ApplySettings()
		ApplySettingsInContainer(serverContainer)
	End Sub
	Private Sub ApplySettingsInContainer(ByVal container As Control)
		For Each child As Control In container.Controls
			Dim edit As ASPxEdit = TryCast(child, ASPxEdit)
			If edit IsNot Nothing Then
				edit.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode
				edit.ValidationSettings.ValidateOnLeave = ValidateOnLeave
				edit.ValidationSettings.SetFocusOnError = SetFocusOnError
			Else
				ApplySettingsInContainer(child)
			End If
		Next child
	End Sub

	Protected Sub NameTextBox_Validation(ByVal sender As Object, ByVal e As ValidationEventArgs)
		If (TryCast(e.Value, String)).Length < 2 Then
			e.IsValid = False
		End If
	End Sub
	Protected Sub AgeTextBox_Validation(ByVal sender As Object, ByVal e As ValidationEventArgs)
		If CommonUtils.IsNullValue(e.Value) OrElse (CStr(e.Value) = "") Then
			Return
		End If
		Dim strAge As String = (CStr(e.Value)).TrimStart("0"c)
		If strAge.Length = 0 Then
			Return
		End If
		Dim age As UInt32 = 0
		If (Not UInt32.TryParse(strAge, age)) OrElse age < 18 Then
			e.IsValid = False
		End If
	End Sub
	Protected Sub ArrivalDateEdit_Validation(ByVal sender As Object, ByVal e As ValidationEventArgs)
		If Not(TypeOf e.Value Is DateTime) Then
			Return
		End If
		Dim selectedDate As DateTime = CDate(e.Value)
		Dim currentDate As DateTime = DateTime.Now
		If selectedDate.Year <> currentDate.Year OrElse selectedDate.Month <> currentDate.Month Then
			e.IsValid = False
		End If
	End Sub

End Class

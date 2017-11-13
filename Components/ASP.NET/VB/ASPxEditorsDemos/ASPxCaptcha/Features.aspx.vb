Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class ASPxCaptcha_Features
	Inherits Page
	Private Const MaxCharacterSetLength As Integer = 50
	Private Const CaptchaCssPostfixSessionKey As String = "6aad54c0-25ef-11df-8a39-0800200c9a66"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Session(CaptchaCssPostfixSessionKey) = Captcha.CssPostfix
			tbCharacterSet.Text = Captcha.CharacterSet
			seCodeLength.Value = Captcha.CodeLength
			cbFontFamily.Value = Captcha.ChallengeImage.FontFamily
			InitializeAppearanceEditors()
		End If
		If Captcha.CssPostfix <> CStr(Session(CaptchaCssPostfixSessionKey)) Then
			InitializeAppearanceEditors()
			Captcha.IsValid = True
			Session(CaptchaCssPostfixSessionKey) = Captcha.CssPostfix
		End If
	End Sub

	Protected Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim parseResult As Integer = 0
		If tbCharacterSet.IsValid Then
			Captcha.CharacterSet = tbCharacterSet.Text
		End If
		If Integer.TryParse(seCodeLength.Text, parseResult) Then
			Captcha.CodeLength = parseResult
		End If
		Captcha.ChallengeImage.FontFamily = cbFontFamily.Value.ToString()
		Captcha.ChallengeImage.ForegroundColor = ceForegroundColor.Color
		Captcha.ChallengeImage.BackgroundColor = ceBackgroundColor.Color
		Captcha.ChallengeImage.BorderColor = ceBorderColor.Color
		If Integer.TryParse(seBorderWidth.Text, parseResult) Then
			Captcha.ChallengeImage.BorderWidth = parseResult
		End If
		Captcha.ValidationSettings.SetFocusOnError = chbSetFocusOnError.Checked
		Captcha.IsValid = True
	End Sub

	Protected Sub InitializeAppearanceEditors()
		ceForegroundColor.Color = Captcha.ChallengeImage.ForegroundColor
		ceBackgroundColor.Color = Captcha.ChallengeImage.BackgroundColor
		ceBorderColor.Color = Captcha.ChallengeImage.BorderColor
		seBorderWidth.Value = Captcha.ChallengeImage.BorderWidth
	End Sub
End Class

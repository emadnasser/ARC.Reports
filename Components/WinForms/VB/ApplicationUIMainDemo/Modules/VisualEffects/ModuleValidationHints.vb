Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Utils.VisualEffects

Namespace DevExpress.ApplicationUI.Demos.VisualEffects
    Partial Public Class ModuleValidationHints
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
            Me.CausesValidation = False
            Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
            AddHandler tePassword.Validating, AddressOf OnPasswordValidating
            AddHandler tePhone.Validating, AddressOf OnPhoneValidating
            AddHandler teAge.Validating, AddressOf OnAgeValidating
            teName.Tag = vhName
            teUserName.Tag = vhUserName
            tePassword.Tag = vhPassword
            teAddress.Tag = vhAddress
            teAge.Tag = vhAge
            teEMail.Tag = vhEMail
            tePhone.Tag = vhPhone
        End Sub
        Private Sub OnAgeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            vhAge.Properties.State = CalcTextEditValidationState(teAge, e)
        End Sub
        Private Function CalcTextEditValidationState(ByVal edit As DevExpress.XtraEditors.TextEdit, ByVal e As CancelEventArgs) As ValidationHintState
            If edit.EditValue Is Nothing OrElse String.IsNullOrEmpty(edit.Text) Then
                Return ValidationHintState.Indeterminate
            End If
            Return If(e.Cancel, ValidationHintState.Invalid, ValidationHintState.Valid)
        End Function
        Private Sub OnPhoneValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            vhPhone.Properties.State = CalcTextEditValidationState(tePhone, e)
        End Sub
        Private Sub OnCheckButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkButton.Click
            dataLayoutControl.ValidateChildren()
        End Sub
        Private Sub OnInvalidValue(ByVal sender As Object, ByVal e As XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles teName.InvalidValue, teUserName.InvalidValue, tePassword.InvalidValue, teAge.InvalidValue, teEMail.InvalidValue, tePhone.InvalidValue, teAddress.InvalidValue
            Dim editor As Control = TryCast(sender, Control)
            If editor Is Nothing Then
                Return
            End If
            If editor Is tePassword Then
                OnInvalidPasswordValue(e)
            End If
            If editor Is teEMail Then
                OnInvalidEMailValue(e)
            End If
            If editor Is tePhone Then
                OnInvalidPhoneValue(e)
            End If
            Dim hint As ValidationHint = TryCast(editor.Tag, ValidationHint)
            If hint IsNot Nothing Then
                hint.Properties.InvalidState.Text = e.ErrorText
                e.ErrorText = Nothing
            End If
        End Sub
        Private Sub OnPasswordValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            If tePassword.EditValue IsNot Nothing AndAlso tePassword.EditValue.ToString().Length < 8 Then
                e.Cancel = True
            End If
        End Sub
        Private Sub OnInvalidPhoneValue(ByVal e As XtraEditors.Controls.InvalidValueExceptionEventArgs)
            If e.ErrorText = "Invalid Value" Then
                e.ErrorText = "Invalid phone number."
            End If
        End Sub
        Private Sub OnInvalidEMailValue(ByVal e As XtraEditors.Controls.InvalidValueExceptionEventArgs)
            If e.ErrorText = "Invalid Value" Then
                e.ErrorText = "Invalid e-mail."
            End If
        End Sub
        Private Sub OnInvalidPasswordValue(ByVal e As XtraEditors.Controls.InvalidValueExceptionEventArgs)
            If e.ErrorText = "Invalid Value" Then
                e.ErrorText = "Your password must be at least 8 characters."
            End If
        End Sub
    End Class
    Public Class Customer
        Public Sub New()
        End Sub

        <Required(ErrorMessage:="This field is required.")> _
        Public Property Name() As String
        <Required(ErrorMessage:="This field is required.")> _
        Public Property UserName() As String
        <DataType(DataType.Password, ErrorMessage:="Invalid password."), Required(ErrorMessage:="This field is required.")> _
        Public Property Password() As String
        <Range(20, 120, ErrorMessage:="Enter the age between 20 and 100.")> _
        Public Property Age() As Integer
        <Required(ErrorMessage:="This field is required.")> _
        Public Property EMail() As String
        Public Property Phone() As String
        Public Property Address() As String
    End Class
End Namespace

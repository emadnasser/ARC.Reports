Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.ApplicationUI.Demos

	Partial Public Class StartupMDIDemos
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			Sample = Nothing
		End Sub
		Private fSample As Form = Nothing
		Private Property Sample() As Form
			Get
				Return fSample
			End Get
			Set(ByVal value As Form)
				fSample = value
				sbStart.Enabled = fSample Is Nothing
				sbClose.Enabled = fSample IsNot Nothing
			End Set
		End Property
		Protected Overridable Function CreateSample() As Form
			Return Nothing
		End Function
		Private Sub sbStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbStart.Click
			Sample = CreateSample()
			If Sample Is Nothing Then
				Return
			End If
			AddHandler Sample.Closed, AddressOf Sample_Close
			Sample.Show()
		End Sub
		Private Sub Sample_Close(ByVal sender As Object, ByVal e As EventArgs)
			RemoveHandler Sample.Closed, AddressOf Sample_Close
			Sample.Dispose()
			Sample = Nothing
		End Sub
		Private Sub CloseSample()
			If Sample IsNot Nothing Then
				Sample.Close()
			End If
		End Sub
		Private Sub sbClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbClose.Click
			CloseSample()
		End Sub
		Protected Overrides Sub DoVisibleChanged(ByVal visible As Boolean)
			MyBase.DoVisibleChanged(visible)
			CloseSample()
		End Sub
	End Class
	Public Class TabbedMDIStart
		Inherits StartupMDIDemos
		Protected Overrides Function CreateSample() As Form
			Return New frmTabbedMDI()
		End Function
	End Class
End Namespace

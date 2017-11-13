Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Utils
Imports DevExpress.Utils.KeyboardHandler

Namespace DevExpress.XtraRichEdit.Demos.Forms
	Public Class PopupFormBase
		Inherits DevExpress.XtraEditors.XtraForm
		Private editValue_Renamed As Object
		Private range_Renamed As DocumentRange
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Overridable ReadOnly Property EditValue() As Object
			Get
				Return editValue_Renamed
			End Get
		End Property
		Public Property Range() As DocumentRange
			Get
				Return range_Renamed
			End Get
			Set
				range_Renamed = Value
			End Set
		End Property

		Private Event onCommit_Renamed As EventHandler
		Public Custom Event Commit As EventHandler
			AddHandler(ByVal value As EventHandler)
				AddHandler onCommit_Renamed, value
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				RemoveHandler onCommit_Renamed, value
			End RemoveHandler
				RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
				End RaiseEvent
		End Event
		Protected Sub RaiseCommitEvent()
			If Not onCommit_RenamedEvent Is Nothing Then
				RaiseEvent onCommit_Renamed(Me, EventArgs.Empty)
			End If
		End Sub

		Private Sub InitializeComponent()
			Me.SuspendLayout()
			' 
			' PopupFormBase
			' 
			Me.AutoSize = True
			Me.ClientSize = New System.Drawing.Size(268, 248)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.KeyPreview = True
			Me.MaximizeBox = False
			Me.Name = "PopupFormBase"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
'			Me.Deactivate += New System.EventHandler(Me.PopupFormBase_Deactivate);
'			Me.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.PopupFormBase_KeyDown);
			Me.ResumeLayout(False)

		End Sub
		Protected Overridable Sub SetEditValueCore(ByVal value As Object)
			Me.editValue_Renamed = value
		End Sub
		Protected Overridable Sub SetEditValue()
		End Sub
		Private Sub PopupFormBase_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
			If e.KeyData = Keys.Escape Then
				Close()
			ElseIf e.KeyData = Keys.Enter Then
				OnCommit()
			End If
		End Sub
		Protected Overridable Sub OnCommit()
			SetEditValue()
			RaiseCommitEvent()
			Close()
		End Sub
		Private Sub PopupFormBase_Deactivate(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Deactivate
			Close()
		End Sub
	End Class
End Namespace

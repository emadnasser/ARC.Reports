Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraEditors.Calendar
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraRichEdit.Demos.Forms
	Public Partial Class SelectDateForm
		Inherits PopupFormBase
		Private dateTimeChanged As Boolean
		Public Sub New()
			InitializeComponent()
			Me.dateNavigator1.DateTime = DateTime.Now
		End Sub

		Protected Overrides Sub SetEditValue()
			SetEditValueCore(Me.dateNavigator1.DateTime)
		End Sub
        Private Sub dateNavigator1_EditDateModified(ByVal sender As Object, ByVal e As EventArgs) Handles dateNavigator1.DateTimeChanged
            If dateTimeChanged Then
                OnCommit()
            End If
        End Sub
		Private Sub dateNavigator_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dateNavigator1.MouseClick
			Dim hitInfo As CalendarHitInfo = Me.dateNavigator1.GetHitInfo(e)
            If hitInfo.HitTest = CalendarHitInfoType.MonthNumber Then
                dateTimeChanged = True
            End If
		End Sub
	End Class
End Namespace

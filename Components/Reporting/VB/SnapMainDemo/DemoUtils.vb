Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports DevExpress.Snap
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit

Namespace SnapDemos
	Public Class SnapDemoExceptionsHandler
		Private ReadOnly control As SnapControl
		Public Sub New(ByVal control As SnapControl)
			Me.control = control
		End Sub
		Public Sub Install()
			If control IsNot Nothing Then
				AddHandler control.UnhandledException, AddressOf OnSnapControlUnhandledException
			End If
		End Sub

		Protected Overridable Sub OnSnapControlUnhandledException(ByVal sender As Object, ByVal e As RichEditUnhandledExceptionEventArgs)
			Try
				If e.Exception IsNot Nothing Then
					Throw e.Exception
				End If
			Catch ex As RichEditUnsupportedFormatException
				XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
				e.Handled = True
			Catch ex As ExternalException
				XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
				e.Handled = True
			Catch ex As IOException
				XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
				e.Handled = True
			End Try
		End Sub
	End Class
End Namespace

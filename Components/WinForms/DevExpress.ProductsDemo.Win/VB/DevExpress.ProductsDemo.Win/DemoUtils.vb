Imports System.Text
Imports DevExpress.XtraRichEdit
Imports System.Runtime.InteropServices
Imports DevExpress.Utils

Namespace DevExpress.ProductsDemo.Win.Modules
	Public Class DemoUtils
		Public Shared Function GetRelativePath(ByVal name As String) As String
			name = "Data\" & name
			Return FilesHelper.FindingFileName(Application.StartupPath, name)
		End Function
	End Class

	Public Class RichEditDemoExceptionsHandler
		Private ReadOnly control As RichEditControl
		Public Sub New(ByVal control As RichEditControl)
			Me.control = control
		End Sub
		Public Sub Install()
			If control IsNot Nothing Then
				AddHandler control.UnhandledException, AddressOf OnRichEditControlUnhandledException
			End If
		End Sub

		Protected Overridable Sub OnRichEditControlUnhandledException(ByVal sender As Object, ByVal e As RichEditUnhandledExceptionEventArgs)
			Try
				If e.Exception IsNot Nothing Then
					Throw e.Exception
				End If
			Catch ex As RichEditUnsupportedFormatException
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
				e.Handled = True
			Catch ex As ExternalException
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
				e.Handled = True
			Catch ex As System.IO.IOException
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
				e.Handled = True
			End Try
		End Sub
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraBars.Demos.DockingDemo
	Partial Public Class ucOutput
		Inherits XtraUserControl
		Public Sub New()
			InitializeComponent()
			comboBox.SelectedIndex = 0
			textBox.ContextMenu = New ContextMenu()
		End Sub
		Private Sub comboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox.SelectedIndexChanged
			If comboBox.SelectedIndex = 0 Then
                textBox.Text = " ------ Build started: Project: VisualStudioInspiredUIDemo, Configuration: Debug .NET ------" & Constants.vbCrLf & Constants.vbCrLf & " Preparing resources..." & Constants.vbCrLf & " Updating references..." & Constants.vbCrLf & " Performing main compilation..." & Constants.vbCrLf & Constants.vbCrLf & " Build complete -- 0 errors, 0 warnings" & Constants.vbCrLf & " Building satellite assemblies..." & Constants.vbCrLf & Constants.vbCrLf & Constants.vbCrLf & " ---------------------- Done ----------------------" & Constants.vbCrLf & Constants.vbCrLf & "     Build: 1 succeeded, 0 failed, 0 skipped"
            Else
                textBox.Text = " 'DefaultDomain': Loaded 'd:\winnt\microsoft.net\framework\v1.0.3705\mscorlib.dll', No symbols loaded." & Constants.vbCrLf & " 'VisualStudioInspiredUIDemo': Loaded 'C:\BarDemos\CS\DockingDemo\bin\Debug\DockingDemo.exe', Symbols loaded."
            End If
		End Sub
		Private Sub textBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBox.KeyDown
			e.Handled = True
		End Sub
	End Class
End Namespace

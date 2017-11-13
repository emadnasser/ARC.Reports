Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Office.Utils

Namespace DevExpress.XtraRichEdit.Demos.Forms
	Public Partial Class SelectManagerForm
		Inherits SelectProductForm
		Private ReadOnly infos As List(Of String)
		Private ReadOnly managers As List(Of String)
		Public Sub New(ByVal managers As List(Of String), ByVal infos As List(Of String))
			MyBase.New(managers)
			Guard.ArgumentNotNull(infos, "infos")
			If managers.Count <> infos.Count Then
				Exceptions.ThrowArgumentException("infos", infos)
			End If
			Me.infos = infos
			Me.managers = managers
			InitializeComponent()
		End Sub

		Protected Overrides Sub SetEditValueCore(ByVal value As Object)
			Dim item As String = CStr(value)
			Dim index As Integer = managers.IndexOf(item)
			If index < 0 Then
				Return
			End If
			MyBase.SetEditValueCore(String.Format("{0}, {1}", item, infos(index)))
		End Sub
	End Class
End Namespace

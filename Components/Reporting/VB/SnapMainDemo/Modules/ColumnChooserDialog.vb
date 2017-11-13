Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.Snap.Core.API

Namespace SnapDemos.Modules
	Partial Public Class ColumnChooserDialog
		Inherits Form

		Private fieldList() As DataFieldInfo
		Private result_Renamed As List(Of DataFieldInfo)

		Public Sub New()
			fieldList = Nothing
			result_Renamed = Nothing
			InitializeComponent()
		End Sub

		Public Sub SetFieldList(ByVal fieldList As IEnumerable(Of DataFieldInfo))
			Me.fieldList = fieldList.ToArray()
			panel1.Controls.Clear()
			If fieldList Is Nothing Then
				Return
			End If
			Me.Height = 117 + 24 * fieldList.Count()
			Dim i As Integer = 0
			For Each field As DataFieldInfo In fieldList
				panel1.Controls.Add(New CheckBox() With {.Text = String.Join(".", field.DataPaths), .Top = 4 + 24 * (i), .AutoSize = True, .Checked = True})
				i += 1
			Next field
		End Sub

		Public ReadOnly Property Result() As List(Of DataFieldInfo)
			Get
				Return result_Renamed
			End Get
		End Property

		Private Sub buttonOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOk.Click
			Me.result_Renamed = New List(Of DataFieldInfo)(fieldList.Length)
			For i As Integer = 0 To fieldList.Length - 1
				Dim chk As CheckBox = TryCast(panel1.Controls(i), CheckBox)
				If chk IsNot Nothing AndAlso chk.Checked Then
					Me.result_Renamed.Add(fieldList(i))
				End If
			Next i
			Close()
		End Sub

		Private Sub buttonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCancel.Click
			Me.result_Renamed = Nothing
			Close()
		End Sub
	End Class
End Namespace

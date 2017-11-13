Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Namespace DevExpress.XtraScheduler.Demos
	Public Class Medic
		<Key> _
		Public Property Id() As Int64
		Public Property Name() As String
		Public Property Phone() As String
		Public Property PhotoBytes() As Byte()
		Private privateDepartmentId? As Int64
		Public Property DepartmentId() As Int64?
			Get
				Return privateDepartmentId
			End Get
			Set(ByVal value? As Int64)
				privateDepartmentId = value
			End Set
		End Property

		Public Sub SetPhoto(ByVal image As Image)
			If image Is Nothing Then
				PhotoBytes = Nothing
				Return
			End If
			Using stream As New MemoryStream()
				image.Save(stream, ImageFormat.Jpeg)
				PhotoBytes = stream.ToArray()
			End Using
		End Sub

		Public Function GetPhoto() As Image
			If PhotoBytes Is Nothing Then
				Return Nothing
			End If
			Using stream As New MemoryStream(PhotoBytes)
				Return Image.FromStream(stream)
			End Using
		End Function
	End Class
End Namespace

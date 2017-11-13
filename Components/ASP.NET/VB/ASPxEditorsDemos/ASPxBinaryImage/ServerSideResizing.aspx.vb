Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class ServerSideResizing
	Inherits System.Web.UI.Page
	Private Const ImageFileName As String = "~\ASPxBinaryImage\Images\people_1200px.jpg"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		BinaryImage.ContentBytes = GetByteArrayFromImage()

		Dim value As String = CStr(ComboBoxSize.Value)
		BinaryImage.Width = Convert.ToInt32(value.Split("x"c)(0))
		BinaryImage.Height = Convert.ToInt32(value.Split("x"c)(1))

		BinaryImage.ImageSizeMode = CType(ComboBoxImageSizeMode.Value, ImageSizeMode)
	End Sub

	Protected Function GetByteArrayFromImage() As Byte()
		Dim byteArray() As Byte = Nothing
		Using stream As New FileStream(Server.MapPath(ImageFileName), FileMode.Open, FileAccess.Read)
			byteArray = New Byte(stream.Length - 1){}
			stream.Read(byteArray, 0, CInt(Fix(stream.Length)))
		End Using
		Return byteArray
	End Function
End Class

Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Linq

Partial Public Class Rows_FocusedRow
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not String.IsNullOrEmpty(Request.Params("Photo"))) Then
			PostImage(Request.Params("Photo"))
		End If
	End Sub

	Private Sub PostImage(ByVal id As String)
		Dim image() As Byte = FindImage(id)
		WriteBinaryImage(image)
	End Sub
	Private Sub WriteBinaryImage(ByVal image() As Byte)
		If image IsNot Nothing Then
			Response.ContentType = "image/jpeg"
			Using ms As New MemoryStream(image)
				Using bmp As Bitmap = CType(Bitmap.FromStream(ms), Bitmap)
					bmp.Save(Response.OutputStream, ImageFormat.Jpeg)
				End Using
			End Using
		Else
			Response.ContentType = "image/gif"
		End If
		Response.End()
	End Sub
	Private Function FindImage(ByVal id As String) As Byte()
		Using context As New NorthwindContext()
			Dim employeeId As Integer = Convert.ToInt32(id)
			Dim employee = context.Employees.Single(Function(em) em.EmployeeID = employeeId)
			Return employee.Photo
		End Using
	End Function

End Class

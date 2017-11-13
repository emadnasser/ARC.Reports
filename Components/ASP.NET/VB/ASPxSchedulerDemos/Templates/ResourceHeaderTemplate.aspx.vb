Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Linq
Imports DevExpress.Web.Demos

Partial Public Class Templates_ResourceHeaderTemplate
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not String.IsNullOrEmpty(Request.Params("Image"))) Then
			PostImage(Request.Params("Image"))
		End If

'        
'            The following code utilizes the DataHelper class, which is implemented
'            solely for the ASPxScheduler Demo project.
'            It is intended to hide unnecessary details and clarify the main idea.
'            For the recommended data binding techniques, please refer to the
'            Data Binding section modules:
'              ~/DataBinding/BoundMode.aspx for MS Access database
'              ~/DataBinding/ListBoundMode.aspx for the object with IBindingList interface.
'              ~/DataBinding/XPOBoundMode.aspx for XPO data framework.
'        
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxScheduler1)
		SchedulerDemoUtils.ApplyWorkTime(Me, ASPxScheduler1)
		DataHelper.SetupDefaultMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource)
		DataHelper.SetupStatuses(ASPxScheduler1)
		DataHelper.SetupLabels(ASPxScheduler1)
		ASPxScheduler1.DataBind()
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
					Dim thumb As New Bitmap(bmp, New Size(120, 120))
					thumb.Save(Response.OutputStream, ImageFormat.Jpeg)
				End Using
			End Using
		Else
			Response.ContentType = "image/gif"
		End If
		Response.End()
	End Sub
	Private Function FindImage(ByVal id As String) As Byte()
		If (Not Utils.IsSiteMode) Then
			Using context = New MedicsSchedulingDBContext()
				Dim medicID As Integer = Convert.ToInt32(id)
				Return context.Medics.Single(Function(medic) medic.ID.Equals(medicID)).PhotoBytes
			End Using
		Else
			' Site Mode support
			Dim virtualPath As String = String.Format("~/App_Data/resource_{0}.jpg", id)
			Dim path As String = Page.MapPath(virtualPath)
			Dim fi As New FileInfo(path)
			If (Not fi.Exists) Then
				virtualPath = "~/App_Data/resource_1.jpg"
				path = Page.MapPath(virtualPath)
				fi = New FileInfo(path)
			End If
			Using stream As FileStream = fi.OpenRead()
				Dim bytes(stream.Length - 1) As Byte
				stream.Read(bytes, 0, CInt(Fix(stream.Length)))
				Return bytes
			End Using
		End If
	End Function
End Class

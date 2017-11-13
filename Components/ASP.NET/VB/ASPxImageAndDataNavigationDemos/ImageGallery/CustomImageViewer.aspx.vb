Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ImageGallery_CustomImageViewer
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Sub cb_Callback(ByVal source As Object, ByVal e As DevExpress.Web.CallbackEventArgs)
		Dim item As ImageGalleryItem = imageGallery.Items(Integer.Parse(e.Parameter))
		e.Result = ResolveUrl(item.ImageUrl)
	End Sub
	Protected Sub imageGallery_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		imageGallery.JSProperties("cpCount") = imageGallery.Items.Count
	End Sub
End Class

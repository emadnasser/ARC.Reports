<%@ WebHandler Language="vb" Class="ThumbnailsImageHandler" %>

Imports System
Imports System.Web

Public Class ThumbnailsImageHandler
	Implements IHttpHandler

	Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
		If context.Request.QueryString("img") Is Nothing Then
			Return
		End If
		Dim filePath As String = context.Request.MapPath("~/App_Data/Thumbnails/" & context.Request.QueryString("img"))
		Dim response As System.Web.HttpResponse = context.Response
		response.Buffer = True
		response.ClearContent()
		response.ClearHeaders()
		response.Cache.SetCacheability(System.Web.HttpCacheability.Public)
		response.ContentType = "image/png"
		response.AddHeader("Content-Type", response.ContentType)
		response.WriteFile(filePath)
		response.End()
	End Sub

	Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
		Get
			Return False
		End Get
	End Property
End Class
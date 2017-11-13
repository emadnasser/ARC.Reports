<%@ WebHandler Language="C#" Class="ThumbnailsImageHandler" %>

using System;
using System.Web;

public class ThumbnailsImageHandler : IHttpHandler {

    public void ProcessRequest(HttpContext context) {
        if(context.Request.QueryString["img"] == null)
            return;
        string filePath = context.Request.MapPath("~/App_Data/Thumbnails/" + context.Request.QueryString["img"]);
        System.Web.HttpResponse response = context.Response;
        response.Buffer = true;
        response.ClearContent();
        response.ClearHeaders();
        response.Cache.SetCacheability(System.Web.HttpCacheability.Public);
        response.ContentType = "image/png";
        response.AddHeader("Content-Type", response.ContentType);
        response.WriteFile(filePath);
        response.End();
    }

    public bool IsReusable {
        get { return false; }
    }
}
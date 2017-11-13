using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DevExpress.Web.Demos {
    public static class CloudProviderRequestMonitor {
        const string AmazonLogKey = "MVCxAmazonProviderDemoLog";
        const string AzureLogKey = "MVCxAzureProviderDemoLog";
        const string DropboxLogKey = "MVCxDropboxProviderDemoLog";

        public static void TraceEvent(string senderName, FileManagerCloudProviderRequestEventArgs e, FileManagerProviderType type) {
            var request = e.Request;
            StringBuilder builder = new StringBuilder();
            builder.Append("<table cellspacing=\"0\" cellpadding=\"0\" border=\"0\">");
            int firstColumnWidth = GetFirstColumnWidth(type);
            AppendRow(builder, "Sender", senderName, firstColumnWidth);
            AppendRow(builder, "Method", request.Method, firstColumnWidth);
            AppendRow(builder, "Date", DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss.FFF"), firstColumnWidth);
            switch(type) {
                case FileManagerProviderType.Dropbox:
                    AppendRow(builder, "Url", request.RequestUri.ToString(), firstColumnWidth);
                    if(request.Headers["Dropbox-API-Arg"] != null)
                        AppendRow(builder, "Dropbox-API-Arg", request.Headers["Dropbox-API-Arg"], firstColumnWidth);
                    AppendRow(builder, "ContentType", request.Headers["Content-Type"], firstColumnWidth);
                    AppendRow(builder, "ContentLength", request.ContentLength.ToString(), firstColumnWidth);
                    break;
                case FileManagerProviderType.Azure:
                    AppendRow(builder, "Url header", request.RequestUri.ToString(), firstColumnWidth);
                    AppendRow(builder, "x-ms-date header", request.Headers["x-ms-date"], firstColumnWidth);
                    break;
                case FileManagerProviderType.Amazon:
                    AppendRow(builder, "Url", request.RequestUri.ToString(), firstColumnWidth);
                    AppendRow(builder, "X-Amz-Date header", request.Headers["X-Amz-Date"], firstColumnWidth);
                    AppendRow(builder, "Content-Type header", request.Headers["Content-Type"], firstColumnWidth);
                    AppendRow(builder, "X-Amz-Content-SHA256 header", request.Headers["X-Amz-Content-SHA256"], firstColumnWidth);
                    break;
            }

            builder.Append("</table><br />");
            HttpContext.Current.Session[GetLogKey(type)] = builder.ToString() + GetLogPartialHtml(type);
        }

        static void AppendRow(StringBuilder builder, string name, string content, int firstColumnWidth) {
            builder.Append("<tr valign=\"top\"><td style=\"width: " + firstColumnWidth.ToString() + "px\">");
            if(!String.IsNullOrEmpty(name))
                builder.AppendFormat("<b>{0}:</b>", HttpUtility.HtmlEncode(name));
            builder.AppendFormat("<td>{0}</td></tr>", HttpUtility.HtmlEncode(content));
        }

        static int GetFirstColumnWidth(FileManagerProviderType type) {
            switch(type) {
                case FileManagerProviderType.Amazon:
                    return 200;
                case FileManagerProviderType.Azure:
                    return 150;
                case FileManagerProviderType.Dropbox:
                    return 120;
            }
            return 0;
        }

        public static string GetLogPartialHtml(FileManagerProviderType type) {
            var logHtml = HttpContext.Current.Session[GetLogKey(type)];
            return logHtml == null ? string.Empty : logHtml.ToString();
        }
        public static string GetLogHtml(FileManagerProviderType type) {
            var partialHtml = GetLogPartialHtml(type);
            if(string.IsNullOrEmpty(partialHtml))
                return string.Empty;
            return
                "<div class=\"EventLogPanel\" style=\"width: 100%\">" +
                    "<div runat=\"server\" id=\"EventLog\" class=\"EventLog\" style=\"width: 100%; height: 250px;\">" +
                        partialHtml +
                    "</div>" +
                "</div>";
        }
        public static void ClearLog(FileManagerProviderType type) {
            HttpContext.Current.Session[GetLogKey(type)] = string.Empty;
        }

        static string GetLogKey(FileManagerProviderType type) {
            switch(type) {
                case FileManagerProviderType.Amazon:
                    return AmazonLogKey;
                case FileManagerProviderType.Azure:
                    return AzureLogKey;
                case FileManagerProviderType.Dropbox:
                    return DropboxLogKey;
            }
            return string.Empty;
        }

    }
}

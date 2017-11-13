using System;
using System.ComponentModel;
using System.Reflection;
using System.Web;

public enum Resolution {
    [Description("Desktop")]
    Default,
    [Description("Tablet Landscape")]
    TabletLandscape,
    [Description("Tablet Portrait")]
    TabletPortrait,
    [Description("Mobile Landscape")]
    MobileLandscape,
    [Description("Mobile Portrait")]
    MobilePortrait
}

public static class DemoUtils {
    public const string DefaultTheme = "Default";
    public const string CurrentThemeCookieKey = "DXBSCurrentTheme";

    public static string CurrentTheme {
        get {
            if(HttpContext.Current.Request.Cookies[CurrentThemeCookieKey] != null)
                return HttpContext.Current.Request.Cookies[CurrentThemeCookieKey].Value;
            return DefaultTheme;
        }
    }

    public static Resolution CurrentResolution {
        get {
            var res = HttpContext.Current.Request.QueryString["resolution"];
            if(string.IsNullOrEmpty(res))
                return Resolution.Default;
            return (Resolution)Enum.Parse(typeof(Resolution), res);
        }
    }

    public static string GetResolutionDescription(Resolution res) {
        FieldInfo fi = typeof(Resolution).GetField(res.ToString());
        DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
        if(attributes != null && attributes.Length > 0)
            return attributes[0].Description;
        return res.ToString();
    }

    public static bool IsMobileDevice {
        get {
            return HttpContext.Current.Request.Browser["IsMobileDevice"] == "true";
        }
    }

    public static bool IsFrame {
        get {
            return !string.IsNullOrEmpty(HttpContext.Current.Request.QueryString["frame"]);
        }
    }
    public static bool IsFrameContainer {
        get {
            return !string.IsNullOrEmpty(HttpContext.Current.Request.QueryString["url"]);
        }
    }

    public static string StartDemoUrl {
        get { return "GridView"; }
    }

    public static string QRCodeLinkUrl {
        get { return HttpContext.Current.Request.Url.LocalPath; }
    }

    public static string QRCodeImageUrl {
        get {
            return string.Format("{0}://{1}{2}", HttpContext.Current.Request.Url.Scheme,
                HttpContext.Current.Request.Url.Authority, QRCodeLinkUrl);
        }
    }

    public static string FrameUrl {
        get {
            return AddQuery(HttpContext.Current.Request.QueryString["url"], "&frame=true&resolution=" + CurrentResolution.ToString());
        }
    }

    static string AddQuery(string url, string query) {
        return url + (url.Contains("?") ? "&" : "?") + query;
    }
}

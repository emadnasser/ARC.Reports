using System.Web;

public static class ReportDesignerUrlLogic {
    public const string QueryArgument = "fromDesigner=true";

    public static string CleanUrl(string redirectUrl, bool encode) {
        string garbageArgument = QueryArgument;
        if(encode) {
            garbageArgument = HttpUtility.UrlEncode(garbageArgument);
        }
        string result = redirectUrl.Replace(garbageArgument, "");
        result = RemoveGarbageFromEnd(result, encode);
        return result;
    }

    static string RemoveGarbageFromEnd(string result, bool encode) {
        string[] garbageEnds = GenerateGarbageEnds(encode);
        foreach(string garbageEnd in garbageEnds) {
            if(result.EndsWith(garbageEnd)) {
                result = result.Substring(0, result.Length - garbageEnd.Length);
            }
        }
        return result;
    }

    static string[] GenerateGarbageEnds(bool encode) {
        var result = new[] { "&", "?" };
        if(encode) {
            for(int i = 0; i < result.Length; i++) {
                result[i] = HttpUtility.UrlEncode(result[i]);
            }
        }
        return result;
    }
}

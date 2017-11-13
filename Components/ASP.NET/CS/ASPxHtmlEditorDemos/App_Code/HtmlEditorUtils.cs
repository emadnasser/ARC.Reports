using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI;
using DevExpress.Web.ASPxHtmlEditor;

public static class HtmlEditorUtils {

    const string htmlLocation = "~/App_Data/Html";
    static readonly ICollection<string> darkThemeNames = new string[] { "BlackGlass", "PlasticBlue", "RedWine" };    

    public static void SetHtml(Page page, ASPxHtmlEditor htmlEditor, string htmlFileName) {
        string resolvedPath = page.MapPath(Path.Combine(htmlLocation, htmlFileName));
        htmlEditor.Html = File.ReadAllText(resolvedPath);
    }
    public static string GetHtml(Page page, string htmlFileName) {
        string resolvedPath = page.MapPath(Path.Combine(htmlLocation, htmlFileName));
        return File.ReadAllText(resolvedPath); 
    }
    public static string GetHtml(Page page, string htmlFileName, bool demoPageIsInRootFolder) {
        string result = GetHtml(page, htmlFileName);
        return demoPageIsInRootFolder ? result : result.Replace("UploadFiles/", "../UploadFiles/"); 
    }

    public static bool IsDarkTheme(string themeName) {
        return darkThemeNames.Contains(themeName);
    }

}

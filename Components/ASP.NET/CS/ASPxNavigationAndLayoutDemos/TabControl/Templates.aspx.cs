using System;
using System.IO;
using System.Web.UI;

public partial class TabControl_Templates : Page {
    const string htmlLocation = "~/App_Data/Html";
    public string GetHtml(string htmlFileName) {
        string resolvedPath = MapPath(Path.Combine(htmlLocation, htmlFileName));
        return File.ReadAllText(resolvedPath);
    }
    public string GetImageUrl(string name) {
        return "../TabControl/Images/" + name + ".jpg";
    }
}

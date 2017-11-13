using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class FileManager_Templates : System.Web.UI.Page
{
    Dictionary<string, string> extensionsDisplayName;

    Dictionary<string, string> ExtensionsDisplayName {
        get {
            if(extensionsDisplayName == null)
                extensionsDisplayName = System.Xml.Linq.XDocument.Load(MapPath("~/Content/FileManager/ExtensionsDisplayName.xml")).Descendants("Extension").ToDictionary(n => n.Attribute("Extension").Value, n => n.Attribute("DisplayName").Value);
            return extensionsDisplayName;
        }
    }

    public string GetFileType(FileManagerFile file) {
        return ExtensionsDisplayName[file.Extension];
    }
    public string GetSize(FileManagerFile file) {
        return file.Length / 1024 + " Kb";
    }
}

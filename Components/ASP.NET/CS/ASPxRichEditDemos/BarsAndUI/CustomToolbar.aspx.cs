using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BarsAndUI_CustomToolbar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DemoToolbar.AutoSeparators = DevExpress.Web.AutoSeparatorMode.None;
        DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"Example.rtf"));
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Features_FindAndReplace : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Features/FindAndReplace.html");
    }
}
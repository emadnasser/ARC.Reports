﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class Navigation_TreeView : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsCallback)
            Thread.Sleep(1000);
    }
}


﻿using System;
using System.Web.UI;

public partial class Common_Compliance : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            treeView.DataBind();
            treeView.ExpandAll();
        }
    }
}
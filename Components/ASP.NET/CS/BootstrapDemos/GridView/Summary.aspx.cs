﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class GridView_Summary : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            GridView1.ExpandRow(1);
        }
    }
}
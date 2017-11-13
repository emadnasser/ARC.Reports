using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DemoItem : System.Web.UI.UserControl {
    public string Title { get; set; }
    public string HeaderID { get { return string.IsNullOrEmpty(Title) ? string.Empty : Title.ToLowerInvariant().Replace(' ', '-').Replace(",", ""); } }

    public bool IsDatabaseCreated { get; set; }

    [PersistenceMode(PersistenceMode.InnerProperty)]
    public PlaceHolder Description { get; set; }

    [PersistenceMode(PersistenceMode.InnerProperty)]
    public PlaceHolder Example { get; set; }

    [PersistenceMode(PersistenceMode.InnerProperty)]
    public PlaceHolder CreateDataBaseControl { get; set; }

    [PersistenceMode(PersistenceMode.InnerProperty)]
    public PlaceHolder CodeASPX { get; set; }

    [PersistenceMode(PersistenceMode.InnerProperty)]
    public PlaceHolder CodeCS { get; set; }

    [PersistenceMode(PersistenceMode.InnerProperty)]
    public PlaceHolder CodeJS { get; set; }

    protected void Page_Init(object sender, EventArgs e) {
        if(Description != null)
            phDescription.Controls.Add(Description);
        if(CreateDataBaseControl != null)
            phCreateDatabase.Controls.Add(CreateDataBaseControl);
        if(Example != null)
            phExample.Controls.Add(Example);
        if(CodeASPX != null)
            phCodeAspx.Controls.Add(CodeASPX);
        if(CodeCS != null)
            phCodeCs.Controls.Add(CodeCS);
        if(CodeJS != null)
            phCodeJs.Controls.Add(CodeJS);
        langgroup.Visible = CodeCS != null || CodeJS != null;
        btnCS.Visible = CodeCS != null;
        btnJS.Visible = CodeJS != null;
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(CreateDataBaseControl != null) {
            phExample.Visible = IsDatabaseCreated;
            phCreateDatabase.Visible = !IsDatabaseCreated;
            phCode.Visible = IsDatabaseCreated;
        }
    }
}

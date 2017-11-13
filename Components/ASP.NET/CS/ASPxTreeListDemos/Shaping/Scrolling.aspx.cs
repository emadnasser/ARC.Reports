using System;
using DevExpress.Web;

public partial class Shaping_Scrolling : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            foreach(string name in Enum.GetNames(typeof(ScrollBarMode))) {
                HorzScrollCombo.Items.Add(name);
                VertScrollCombo.Items.Add(name);
            }
            HorzScrollCombo.Text = ScrollBarMode.Auto.ToString();
            VertScrollCombo.Text = ScrollBarMode.Auto.ToString();

            treeList.DataBind();
            treeList.ExpandAll();
        }

        treeList.Settings.HorizontalScrollBarMode = (ScrollBarMode)Enum.Parse(typeof(ScrollBarMode), HorzScrollCombo.Text);
        treeList.Settings.VerticalScrollBarMode = (ScrollBarMode)Enum.Parse(typeof(ScrollBarMode), VertScrollCombo.Text);
    }
}

using System;
using System.Web.UI;
using DevExpress.Web;

public partial class PagingAndScrolling_Scrolling : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            foreach(string name in Enum.GetNames(typeof(ScrollBarMode))) {
                HorzScrollCombo.Items.Add(name);
                VertScrollCombo.Items.Add(name);
            }
            HorzScrollCombo.Text = ScrollBarMode.Hidden.ToString();
            VertScrollCombo.Text = ScrollBarMode.Auto.ToString();
        }

        Grid.Settings.HorizontalScrollBarMode = (ScrollBarMode)Enum.Parse(typeof(ScrollBarMode), HorzScrollCombo.Text);
        Grid.Settings.VerticalScrollBarMode = (ScrollBarMode)Enum.Parse(typeof(ScrollBarMode), VertScrollCombo.Text);

        for(int i = 7; i < Grid.Columns.Count; i++)
            Grid.Columns[i].Visible = Grid.Settings.HorizontalScrollBarMode != ScrollBarMode.Hidden;
    }
}

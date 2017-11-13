using System;
using System.Web.UI;
using System.Linq;
using DevExpress.Web;
using System.Web.UI.WebControls;

public partial class PagingAndScrolling_Scrolling : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            foreach(string name in Enum.GetNames(typeof(ScrollBarMode))) {
                HorzScrollCombo.Items.Add(name);
                VertScrollCombo.Items.Add(name);
            }
            HorzScrollCombo.Text = ScrollBarMode.Auto.ToString();
            VertScrollCombo.Text = ScrollBarMode.Auto.ToString();
        }

        var horizontalScrollBarMode = (ScrollBarMode)Enum.Parse(typeof(ScrollBarMode), HorzScrollCombo.Text);
        VerticalGrid.Settings.HorizontalScrollBarMode = horizontalScrollBarMode;
        VerticalGrid.Settings.VerticalScrollBarMode = (ScrollBarMode)Enum.Parse(typeof(ScrollBarMode), VertScrollCombo.Text);

        var horzScrollingEnabled = !horizontalScrollBarMode.Equals(ScrollBarMode.Hidden);
        var itemCount = horzScrollingEnabled ? 10 : 4;
        VerticalGrid.DataSource = HeadphonesDataProvider.SelectHeadphones().Take(itemCount);
        VerticalGrid.DataBind();
    }
}

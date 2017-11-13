using System;
using System.Web.UI;
using DevExpress.Web;

public partial class DataBinding_Live : Page {

    protected string GetIconImageUrl(GridViewDataItemTemplateContainer container) {
        Quote quote = (Quote)grid.GetRow(container.VisibleIndex);
        return String.Format("Images/{0}.gif", quote.Change >= 0 ? "Up" : "Down");
    }

    protected string GetPercentageText(GridViewDataItemTemplateContainer container) {
        Quote quote = (Quote)grid.GetRow(container.VisibleIndex);
        return quote.Change.ToString("P");
    }

}

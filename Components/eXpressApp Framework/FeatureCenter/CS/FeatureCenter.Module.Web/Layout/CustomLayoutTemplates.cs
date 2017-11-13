using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Web.Layout;
using DevExpress.Web;

namespace FeatureCenter.Module.Web.Layout {
    public class CustomLayoutItemTemplate : LayoutItemTemplate {
        protected override Control CreateCaptionControl(LayoutItemTemplateContainer layoutItemTemplateContainer) {
            Table table = new Table();
            table.Rows.Add(new TableRow());
            table.Rows[0].Cells.Add(new TableCell());
            table.Rows[0].Cells.Add(new TableCell());
            Control baseControl = base.CreateCaptionControl(layoutItemTemplateContainer);
            table.Rows[0].Cells[0].Controls.Add(baseControl);
            HtmlAnchor anchor = new HtmlAnchor();
            anchor.InnerHtml = "<b>?</b>";
            anchor.HRef = "#";
            anchor.Title = string.Format("Description for the '{0}' item", layoutItemTemplateContainer.ViewItem.Caption);
            table.Rows[0].Cells[1].Controls.Add(anchor);
            return table;
        }
    }
    public class CustomLayoutGroupTemplate : LayoutGroupTemplate {
        protected override void LayoutContentControls(LayoutGroupTemplateContainer layoutGroupTemplateContainer, IList<Control> controlsToLayout) {
            if(layoutGroupTemplateContainer.ShowCaption) {
                Panel panel = new Panel();
                panel.Style.Add(HtmlTextWriterStyle.Padding, "10px 5px 10px 5px");
                ASPxRoundPanel roundPanel = new ASPxRoundPanel();
                roundPanel.Width = Unit.Percentage(100);
                roundPanel.HeaderText = layoutGroupTemplateContainer.Caption;
                if(layoutGroupTemplateContainer.HasHeaderImage) {
                    ASPxImageHelper.SetImageProperties(roundPanel.HeaderImage, layoutGroupTemplateContainer.HeaderImageInfo);
                }
                foreach(Control control in controlsToLayout) {
                    roundPanel.Controls.Add(control);
                }
                panel.Controls.Add(roundPanel);
                layoutGroupTemplateContainer.Controls.Add(panel);
            }
            else {
                foreach(Control control in controlsToLayout) {
                    layoutGroupTemplateContainer.Controls.Add(control);
                }
            }
        }
    }
    public class CustomLayoutTabbedGroupTemplate : TabbedGroupTemplate {
        protected override ASPxPageControl CreatePageControl(TabbedGroupTemplateContainer tabbedGroupTemplateContainer) {
            ASPxPageControl pageControl = base.CreatePageControl(tabbedGroupTemplateContainer);
            pageControl.TabPosition = TabPosition.Left;
            pageControl.ContentStyle.Paddings.Padding = Unit.Pixel(10);
            return pageControl;
        }
    }
}

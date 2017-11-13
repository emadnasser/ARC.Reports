using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.Demos;

public partial class UserControls_DemoTabs : System.Web.UI.UserControl {
    protected void Page_Load(object sender, EventArgs e) {
        var index = 0;
        if(Utils.CurrentDemoPage != null) {
            foreach(SourceCodePage page in Utils.GetCurrentSourceCodePages()) {
                var tab = DemoPageControl.TabPages.Add(page.Title, page.Title);
                var codeViewer = (CodeViewerControl)LoadControl("~\\UserControls\\CodeViewer.ascx");
                codeViewer.SourceCodePage = page;
                codeViewer.Index = index;
                DemosModel currentModel = DemosModel.Instance;
                if (currentModel != null)
                    codeViewer.DisableTextWrap = DemosModel.Instance.DisableTextWrap;
                tab.Controls.Add(codeViewer);
                index++;
            }
        }
    }
}

using System.Web.UI;
using DevExpress.Data;
using DevExpress.Web.ASPxTreeList;

public partial class Summary_Custom : Page {
    protected void treeList_CustomSummaryCalculate(object sender, TreeListCustomSummaryEventArgs e) {
        switch(e.SummaryProcess) {
            case CustomSummaryProcess.Start:
                e.Value = (decimal)0;
                break;
            case CustomSummaryProcess.Calculate:
                if(e.Node.Selected)
                    e.Value = (decimal)e.Value + (decimal)e.Node["Budget"];
                break;
        }
    }
}

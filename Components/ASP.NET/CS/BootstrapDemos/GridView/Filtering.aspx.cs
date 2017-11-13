using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class GridView_Filtering : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        
    }

    const int QuantityFilterStep = 10;
    const int TotalFilterStep = 100;

    protected void GridView2_HeaderFilterFillItems(object sender, ASPxGridViewHeaderFilterEventArgs e) {
        switch(e.Column.FieldName) {
            case "Total":
                PrepareTotalFilterItems(e);
                break;
            case "Quantity":
                PrepareQuantityFilterItems(e);
                break;
        }
    }

    protected virtual void PrepareTotalFilterItems(ASPxGridViewHeaderFilterEventArgs e) {
        e.Values.Clear();
        e.AddShowAll();
        for(int i = 0; i < 10; i++) {
            double start = TotalFilterStep * i;
            double end = start + TotalFilterStep - 0.01;
            e.AddValue(string.Format("from {0:c} to {1:c}", start, end), "", string.Format("[Total] >= {0} and [Total] <= {1}", start, end));
        }
        e.AddValue(string.Format("> {0:c}", 1000), "", "[Total] > 1000");
    }

    protected virtual void PrepareQuantityFilterItems(ASPxGridViewHeaderFilterEventArgs e) {
        int max = e.Values.Max(v => {
            int value = 0;
            if(int.TryParse(v.Value, out value))
                return value;
            return 0;
        });
        e.Values.Clear();
        e.AddShowAll();
        for(int i = 0; i < max / QuantityFilterStep + 1; i++) {
            int start = QuantityFilterStep * i;
            int end = start + QuantityFilterStep - 1;
            e.AddValue(string.Format("from {0} to {1}", start, end), "", string.Format("[Quantity] >= {0} and [Quantity] <= {1}", start, end));
        }
    }
}

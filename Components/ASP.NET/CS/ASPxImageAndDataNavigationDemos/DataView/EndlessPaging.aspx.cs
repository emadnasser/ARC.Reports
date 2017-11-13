using System;
using DevExpress.Web;

public partial class DataView_EndlessPaging: System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            PrepareControls();
        if(IsCallback) {
            // Intentionally pauses server-side processing, 
            // to demonstrate the Loading Panel functionality.
            System.Threading.Thread.Sleep(500);
        }
    }
    protected void cmbEndlessPagingMode_SelectedIndexChanged(object sender, EventArgs e) {
        DataViewEndlessPagingMode mode = (DataViewEndlessPagingMode)Enum.Parse(typeof(DataViewEndlessPagingMode), cmbEndlessPagingMode.Text);
        dataView.PagerSettings.EndlessPagingMode = mode;
    }
    void PrepareControls() {
        cmbEndlessPagingMode.Items.Add(Enum.GetName(typeof(DataViewEndlessPagingMode), DataViewEndlessPagingMode.OnClick));
        cmbEndlessPagingMode.Items.Add(Enum.GetName(typeof(DataViewEndlessPagingMode), DataViewEndlessPagingMode.OnScroll));
        cmbEndlessPagingMode.SelectedIndex = 0;
        dataView.PagerSettings.EndlessPagingMode = DataViewEndlessPagingMode.OnClick;
        dataView.PagerSettings.EllipsisMode = PagerEllipsisMode.None;
    }
}

using System;
using System.Web.UI;
using DevExpress.Xpo;
using DevExpress.Web.Demos;
using DevExpress.Web;

public partial class ASPxGridLookup_FilterServerMode : Page {
    static ASPxGridLookup_FilterServerMode() {
        PersonDataGenerator.Register();

    }
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsCallback && !IsPostBack)
            RadioButtonList.SelectedIndex = 0;
        UpdateFilteringMode();
        GridLookup.GridView.Width = 370;
    }
    protected void ASPxGridLookup_Init(object sender, EventArgs e) {
        bool ready = DatabaseGenerator.IsReady(CreateDatabaseControl.TableKey);
        CreateDatabaseControl.Visible = !ready;
        Demo.Visible = ready;
        Session session = XpoHelper.GetNewSession();
        XpoDataSource.Session = session;
    }
    protected void UpdateFilteringMode() {
        switch (RadioButtonList.SelectedItem.Value.ToString()) {
            case "StartsWith":
                GridLookup.IncrementalFilteringMode = IncrementalFilteringMode.StartsWith;
                GridLookup.GridViewProperties.Settings.ShowFilterRow = false;
                GridLookupCaptionLabel.Text = "Start typing to invoke filtering:";
                break;
            case "Contains":
                GridLookup.IncrementalFilteringMode = IncrementalFilteringMode.Contains;
                GridLookup.GridViewProperties.Settings.ShowFilterRow = false;
                GridLookupCaptionLabel.Text = "Start typing to invoke filtering:";
                break;
            case "Filter Row":
                GridLookup.IncrementalFilteringMode = IncrementalFilteringMode.None;
                GridLookup.GridViewProperties.Settings.ShowFilterRow = true;
                GridLookupCaptionLabel.Text = "Type within the grid filter row to start filtering:";
                break;
        }
    }
}






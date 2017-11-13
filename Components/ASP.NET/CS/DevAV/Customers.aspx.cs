using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class Customers : MasterDetailPage {
    DetailUserControl detailUC;
    public override FilterBag FilterBag { get { return DemoUtils.CustomerFilter; } }
    public override string PageName { get { return "Customers"; } }
    public override MasterUserControl MasterUC { get { return Customers_Master as MasterUserControl; } }
    public override DetailUserControl DetailUC { get { return detailUC; } }

    public override void OnFilterChanged() {
        Update();
    }

    protected void DetailsCallbackPanel_Callback(object sender, CallbackEventArgsBase e) {
        var args = DemoUtils.DeserializeCallbackArgs(e.Parameter);
        if(args.Count == 0)
            return;
        var callbackName = args[0];
        if(callbackName == "SaveEditForm") {
            CustomerEmployeeEditForm.SaveChanges(args[2]);
            UpdateDetail();
        }
    }

    protected void Page_Init(object sender, EventArgs e) {
        var viewMode = DemoUtils.IsContactImageSliderMode ? "Contacts" : "Stores";
        this.detailUC = LoadControl(string.Format("~/UserControls/ViewControls/{0}ImageSlider.ascx", viewMode)) as DetailUserControl;
        DetailsCallbackPanel.Controls.Add(DetailUC);
    }

    public override IEnumerable<FilterControlColumn> GetFilterColumns() {
        var result = new ArrayList();
        result.Add(new FilterControlTextColumn() { PropertyName = "BillingAddress.City", DisplayName = "City" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Name" });
        result.Add(new FilterControlTextColumn() { PropertyName = "BillingAddress.Line", DisplayName = "Address" });
        result.Add(new FilterControlTextColumn() { PropertyName = "BillingAddress.State", DisplayName = "State" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Phone" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Fax" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Website" });
        result.Add(new FilterControlSpinEditColumn() { PropertyName = "AnnualRevenue" });
        result.Add(new FilterControlComboBoxColumn() { PropertyName = "Status" }, typeof(CustomerStatus));
        result.Add(new FilterControlSpinEditColumn() { PropertyName = "TotalStores" });
        result.Add(new FilterControlSpinEditColumn() { PropertyName = "TotalEmployees" });
        return result.OfType<FilterControlColumn>();
    }

    protected void Customers_Master_Load(object sender, EventArgs e) {
        var selectedCustomer = DataProvider.Customers.FirstOrDefault(c => c.Id == SelectedItemID);
        if(selectedCustomer == null) {
            ImageSliderMenuContainer.Visible = false;
        }
        else {
            ImageSliderMenuContainer.Visible = true;
            SliderMenu.Items[0].Text = DemoUtils.IsContactImageSliderMode ? "Contacts" : "Stores";
            SliderMenu.Items[0].Items[DemoUtils.IsContactImageSliderMode ? 1 : 0].Selected = true;
            CustomerNameText.InnerHtml = selectedCustomer.Name;
        }
    }
}

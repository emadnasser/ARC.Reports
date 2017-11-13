using System.Collections.Generic;
using System.Linq;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class UserControls_ViewControls_StoresImageSlider : DetailUserControl {
    protected Customer SelectedCustomer { get { return DataProvider.Customers.FirstOrDefault(c => c.Id == OwnerPage.SelectedItemID); } }

    public override void Update() {
        var customer = SelectedCustomer;
        if(customer != null) {
            List<CustomerStore> storeList = new List<CustomerStore>();
            foreach (var employee in customer.Employees) {
                var store = employee.CustomerStore;
                if(storeList.Find(s => s.Address.Equals(store.Address)) == null)
                    storeList.Add(store);
            }
            ImageSlider.DataSource = storeList;
        }
        ImageSlider.DataBind();
    }

    protected string GetThumbnailImageUrl(ImageSliderItemTemplateContainer container) {
        var store = container.Item.DataItem as CustomerStore;
        return DemoUtils.ImageLoader.CrestImageVirtPath(store.Crest.Id);
    }
}

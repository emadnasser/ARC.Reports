using System;
using System.Linq;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class UserControls_ViewControls_ContactsImageSlider : DetailUserControl {
    protected Customer SelectedCustomer { get { return DataProvider.Customers.FirstOrDefault(c => c.Id == OwnerPage.SelectedItemID); } }

    public override void Update() {
        var customer = SelectedCustomer;
        if(customer != null)
            ImageSlider.DataSource = customer.Employees;
        ImageSlider.DataBind();
    }

    protected void EditImage_Load(object sender, EventArgs e) {
        var image = sender as ASPxImage;
        var container = image.NamingContainer as ImageSliderItemTemplateContainer;
        var customerEmployee = container.Item.DataItem as CustomerEmployee;
        if(customerEmployee != null)
            image.JSProperties["cpCustomerEmployeeID"] = customerEmployee.Id;
    }

    protected string GetThumbnailImageUrl(ImageSliderItemTemplateContainer container) {
        var customerEmployee = (CustomerEmployee)container.Item.DataItem;
        return DemoUtils.ImageLoader.CustomerEmployeeImageVirtPath(customerEmployee.Id);
    }
}

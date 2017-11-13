using System;
using System.Linq;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class UserControls_ViewControls_Products_Detail : DetailUserControl {
    protected Product SelectedProduct { get { return DataProvider.Products.FirstOrDefault(p => p.Id == OwnerPage.SelectedItemID); } }

    public override void Update() {
        var product = SelectedProduct;
        if(product == null) {
            DetailsPageControl.Visible = false;
            DetailsHeaderLabel.Text = "None";
            DetailsLeadEngineerText.InnerHtml = "None";
            DetailsSupportTechText.InnerHtml = "None";
            DetailsDescriptionText.InnerHtml = "None";
            DetailsImage.ImageUrl = string.Empty;
            ProductRaitingControl.Value = 0;
        }
        else {
            DetailsPageControl.Visible = true;
            DetailsHeaderLabel.Text = product.Name;
            DetailsLeadEngineerText.InnerHtml = product.Engineer.FullName;
            DetailsSupportTechText.InnerHtml = product.Support.FullName;
            DetailsDescriptionText.InnerHtml = product.Description;
            DetailsImage.ImageUrl = DemoUtils.ImageLoader.ProductMainImageVirtPath(product.Id);
            ProductRaitingControl.Value = (Decimal)product.ConsumerRating;
            ProductImageSlider.ImageSourceFolder = DemoUtils.ImageLoader.ProductThumbVirtPath(product.Id);
        }
        ((ChartUserControl)SalesOpportunitiesChart).SelectedItemID = product != null ? product.Id : DataProvider.emptyEntryID;
    }

    protected void ProductImageUpload_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
        DemoUtils.ImageLoader.AddProductImage(SelectedProduct, e.UploadedFile.FileBytes);
    }
}

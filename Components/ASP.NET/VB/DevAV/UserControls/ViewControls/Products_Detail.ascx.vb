Imports System
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class UserControls_ViewControls_Products_Detail
    Inherits DetailUserControl

    Protected ReadOnly Property SelectedProduct() As Product
        Get
            Return DataProvider.Products.FirstOrDefault(Function(p) p.Id = OwnerPage.SelectedItemID)
        End Get
    End Property

    Public Overrides Sub Update()
        Dim product = SelectedProduct
        If product Is Nothing Then
            DetailsPageControl.Visible = False
            DetailsHeaderLabel.Text = "None"
            DetailsLeadEngineerText.InnerHtml = "None"
            DetailsSupportTechText.InnerHtml = "None"
            DetailsDescriptionText.InnerHtml = "None"
            DetailsImage.ImageUrl = String.Empty
            ProductRaitingControl.Value = 0
        Else
            DetailsPageControl.Visible = True
            DetailsHeaderLabel.Text = product.Name
            DetailsLeadEngineerText.InnerHtml = product.Engineer.FullName
            DetailsSupportTechText.InnerHtml = product.Support.FullName
            DetailsDescriptionText.InnerHtml = product.Description
            DetailsImage.ImageUrl = DemoUtils.ImageLoader.ProductMainImageVirtPath(product.Id)
            ProductRaitingControl.Value = CDec(product.ConsumerRating)
            ProductImageSlider.ImageSourceFolder = DemoUtils.ImageLoader.ProductThumbVirtPath(product.Id)
        End If
        CType(SalesOpportunitiesChart, ChartUserControl).SelectedItemID = If(product IsNot Nothing, product.Id, DataProvider.emptyEntryID)
    End Sub

    Protected Sub ProductImageUpload_FileUploadComplete(ByVal sender As Object, ByVal e As FileUploadCompleteEventArgs)
        DemoUtils.ImageLoader.AddProductImage(SelectedProduct, e.UploadedFile.FileBytes)
    End Sub
End Class

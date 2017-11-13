using System;
using System.Linq;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;

namespace DashboardMainDemo.Dashboards {
    public partial class ProductDetails : Dashboard {
        public ProductDetails() {
            InitializeComponent();
        }
        void ProductDetails_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e) {
            XmlFileConnectionParameters parameters = e.ConnectionParameters as XmlFileConnectionParameters;
            parameters.FileName = DataLoader.GetProductDetailsXmlDataSource();
        }

        void ProductDetails_DashboardLoading(object sender, EventArgs e) {
            BoundImageDashboardItem primaryImage = this.Items["primaryImage"] as BoundImageDashboardItem;
            if(primaryImage != null)
                primaryImage.UriPattern = DataLoader.GetImagesFolder() + "\\{0}.jpg";
            BoundImageDashboardItem secondaryImage = this.Items["secondaryImage"] as BoundImageDashboardItem;
            if(secondaryImage != null)
                secondaryImage.UriPattern = DataLoader.GetImagesFolder() + "\\{0} Secondary.jpg";
        }
    }
}

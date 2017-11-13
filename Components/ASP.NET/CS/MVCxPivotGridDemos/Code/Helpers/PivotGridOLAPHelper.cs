using DevExpress.XtraPivotGrid.Data;

namespace DevExpress.Web.Demos {
    public class PivotGridOLAPDemosHelper {
        const string ProviderDownloadUrl = "http://www.microsoft.com/downloads/details.aspx?FamilyID=50b97994-8453-4998-8226-fa42ec403d17#ASOLEDB";
        public static string OLAPConnectionString {
            get { 
                if(!OLAPMetaGetter.IsProviderAvailable)
                    return null;
                return @"Provider=msolap;Initial Catalog=Northwind;Cube Name=Northwind;Data Source=|DataDirectory|\Northwind.cub;";
            }
        }
        public static string NoProviderErrorString {
            get {
                return "To connect to olap cubes, you should have Microsoft SQL Server 2005<br />" +
                       "Analysis Services 9.0 (or newer) OLE DB Provider installed on your system. You can get<br />" +
                       "the latest version of this provider here:<br />" +
                       "<a href=\"" + ProviderDownloadUrl + "\" target=\"_blank\">" + ProviderDownloadUrl + "</a>.";
            }
        }
    }
}

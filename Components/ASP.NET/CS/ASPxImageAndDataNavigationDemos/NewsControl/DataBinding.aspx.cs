using System;
using System.Web.UI;
using System.Threading;
using DevExpress.Web;
using System.ComponentModel;

public partial class NewsControl_DataBinding : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(IsCallback) {
            // Intentionally pauses server-side processing, 
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(500);
        }
    }

    protected void ASPxCallback1_Callback(object sender, CallbackEventArgs e) {
        int newsID = int.Parse(e.Parameter);
        IHierarchicalDataSource dataSource = XmlDataSource1 as IHierarchicalDataSource;
        HierarchicalDataSourceView view = dataSource.GetHierarchicalView("");
        IHierarchicalEnumerable enumerable = view.Select();
        int index = 1;
        string text = "";

        foreach(object obj in enumerable) {
            if(newsID == index) {
                IHierarchyData data = enumerable.GetHierarchyData(obj);
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(data);
                PropertyDescriptor descriptor = properties.Find("Text", true);
                text = descriptor.GetValue(obj).ToString();
                break;
            }
            index++;
        }
        e.Result = text;
    }
}

using System;
using DevExpress.Web;
using System.Web.UI;

public partial class CallbackPanel_CustomJavaScriptProperties : Page {
    protected void CallbackPanel_Callback(object sender, CallbackEventArgsBase e) {
        string[] parameters = e.Parameter.Split(':');
        int currentPageIndex = int.Parse(parameters[0]);
        if(parameters[1] == "next")
            currentPageIndex++;
        else
            currentPageIndex--;
        MultiView.ActiveViewIndex = currentPageIndex;

        // Intentionally pauses server-side processing,
        // to demonstrate the Loading Panel functionality.    
        System.Threading.Thread.Sleep(1000);
    }

    protected void rpFilmCollection_CustomJSProperties(object sender,
        CustomJSPropertiesEventArgs e) {
        e.Properties["cpPageIndex"] = MultiView.ActiveViewIndex;
        e.Properties["cpPageCount"] = MultiView.Views.Count;
    }
}

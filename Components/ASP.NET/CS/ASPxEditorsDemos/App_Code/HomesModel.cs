using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;

public class HomesDataProvider {
    const string HomesDataFile = "~/App_Data/Homes.xml";

    static DataSet Homes { get; set; }
    static HttpServerUtility Server { get { return HttpContext.Current.Server; } }

    public static DataSet GetHomes() {
        if(Homes == null) {
            Homes = new DataSet();
            Homes.ReadXml(Server.MapPath(HomesDataFile));
        }
        return Homes;
    }
}

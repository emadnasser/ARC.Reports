using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

namespace DevExpress.Web.Demos {
    public static class Cameras {
        public static IEnumerable GetData(string selectCommand = null) {
            using(var context = new DataContext()) {
                string sqlQuery = "SELECT * FROM Cameras" + selectCommand;
                return context.Cameras.SqlQuery(sqlQuery).ToList();
            }
        }
    }
}

using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

namespace DevExpress.Web.Demos {
    public static class FishCatalog {
        public static IEnumerable GetData() {
            using(var context = new FishContext())
                return context.BioLives.ToList();
        }
    }
}

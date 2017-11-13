using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult LinkedControls() {
            ViewData["Categories"] = NorthwindDataProvider.GetCategories();
            return DemoView("LinkedControls");
        }
        public ActionResult LinkedControlsPartial() {
            FilterProducts();
            return PartialView();
        }

        public ActionResult LinkedControlsCustomActionPartial() {
            FilterProducts();
            return PartialView("LinkedControlsPartial");
        }

        private void FilterProducts() {
            using (var context = new NorthwindContext()) {
                var selectedCategories = new JavaScriptSerializer().Deserialize<int[]>(Request["categories"]).OfType<int>();
                var filteredProducts = context.Products.Where(product => selectedCategories.Contains((int)product.CategoryID));
                ViewData["Products"] = filteredProducts.ToList();
            }
        }
    }
}

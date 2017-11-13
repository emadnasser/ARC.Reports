using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MiscellaneousController : DemoController {
        public ActionResult DrillDown(string category) {
            object model;
            ChartDrillDownDemoOptions options = new ChartDrillDownDemoOptions();
            options.ShowLabels = true;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            ViewData[ChartDemoHelper.CategoryKey] = category;
            if (string.IsNullOrEmpty(category))
                model = NorthwindDataProvider.GetCategoriesMin();
            else {
                model = NorthwindDataProvider.GetProducts(category);
            }
            return DemoView("DrillDown", model);
        }
        public ActionResult DrillDownPartial([Bind] ChartDrillDownDemoOptions options, string category) {
            ViewData[ChartDemoHelper.CategoryKey] = category;
            if (string.IsNullOrEmpty(category))
                switch (options.SummaryFunction) {
                    case Summary.Average:
                        return PartialView("DrillDownPartial", NorthwindDataProvider.GetCategoriesAverage());
                    case Summary.Min:
                        return PartialView("DrillDownPartial", NorthwindDataProvider.GetCategoriesMin());
                    default:
                        return PartialView("DrillDownPartial", NorthwindDataProvider.GetCategoriesMax());
                }
            else
                return PartialView("DrillDownCategoryPartial", NorthwindDataProvider.GetProducts(category));
        }
        [HttpPost]
        public ActionResult DrillDown([Bind] ChartDrillDownDemoOptions options, string category) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            ViewData[ChartDemoHelper.CategoryKey] = category;
            if (string.IsNullOrEmpty(category)) {
                switch (options.SummaryFunction) {
                    case Summary.Average:
                        return DemoView("DrillDown", NorthwindDataProvider.GetCategoriesAverage());
                    case Summary.Min:
                        return DemoView("DrillDown", NorthwindDataProvider.GetCategoriesMin());
                    default:
                        return DemoView("DrillDown", NorthwindDataProvider.GetCategoriesMax());
                }
            }
            else
                return DemoView("DrillDown", NorthwindDataProvider.GetProducts(category));
        }
    }
}

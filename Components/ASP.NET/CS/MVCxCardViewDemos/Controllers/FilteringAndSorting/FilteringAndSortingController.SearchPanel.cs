﻿using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringAndSortingController: DemoController {
        public ActionResult SearchPanel() {
            return DemoView("SearchPanel", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult SearchPanelPartial() {
            return PartialView("SearchPanelPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}

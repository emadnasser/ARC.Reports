using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web.Mvc;
using System.Linq;

namespace DevExpress.Web.Demos {
    public partial class MiscellaneousController : DemoController {
        [HttpGet]
        public ActionResult ToolTip() {
            ChartToolTipDemoOptions options = new ChartToolTipDemoOptions();
            var model = NorthwindDataProvider.GetEmployeesOrders();
            Dictionary<string, int> toolTipImageDictionary = new Dictionary<string, int>();
            foreach (EmployeeOrder employee in model) {
                toolTipImageDictionary[employee.LastName] = Convert.ToInt32(employee.Id);
            }
            options.ToolTipImages = toolTipImageDictionary;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("ToolTip", model);
        }
        [HttpPost]
        public ActionResult ToolTip([Bind] ChartToolTipDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            var model = NorthwindDataProvider.GetEmployeesOrders();
            Dictionary<string, int> toolTipImageDictionary = new Dictionary<string, int>();
            foreach (EmployeeOrder employee in model) {
                toolTipImageDictionary[employee.LastName] = Convert.ToInt32(employee.Id);
            }
            options.ToolTipImages = toolTipImageDictionary;
            return DemoView("ToolTip", model);
        }

        public ActionResult ShowImage(int id) {
            byte[] imageData = NorthwindDataProvider.GetEmployeePhoto(id).ToArray();
            return File(imageData, "image/jpg");
        }
    }
}

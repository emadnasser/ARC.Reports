using System.Web.Mvc;
using System;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    [ValidateInput(false)]
    public partial class CustomizationController: DemoController {
        public override string Name { get { return "Customization"; } }

        public ActionResult Index() {
            return RedirectToAction("CustomForms");
        }
        public ActionResult CarImage() {
            if(Request.QueryString[SchedulerDemoHelper.ImageQueryKey] != null) {
                int carId = int.Parse(Request.QueryString[SchedulerDemoHelper.ImageQueryKey]);
                Response.ContentType = "image";
                var photo = CarsDataProvider.GetCarPictureById(carId);
                if(photo != null)
                    Response.BinaryWrite(photo.ToArray());
                Response.End();
            }
            return null;
        }
    }
}

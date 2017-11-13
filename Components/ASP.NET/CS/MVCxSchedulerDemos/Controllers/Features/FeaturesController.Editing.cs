﻿using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public ActionResult Editing() {
            return DemoView("Editing", SchedulerDataHelper.EditableDataObject);
        }
        public ActionResult EditingPartial() {
            return PartialView("EditingPartial", SchedulerDataHelper.EditableDataObject);
        }
        [ValidateInput(false)]
        public ActionResult EditingPartialEditAppointment() {
            try {
                SchedulerDataHelper.UpdateEditableDataObject();
            }
            catch(Exception e) {
                ViewData["SchedulerErrorText"] = e.Message;
            }
            return PartialView("EditingPartial", SchedulerDataHelper.EditableDataObject);
        }
    }
}
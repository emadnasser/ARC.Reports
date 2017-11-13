using System.Collections.Generic;
using System.Web.Mvc;
using DevExpress.Web.ASPxRichEdit;

namespace DevExpress.Web.Demos {
    public class RibbonCustomizationDemoOptions {
        public RibbonCustomizationDemoOptions() {
            ShowStatusBar = true;
        }

        public RichEditRibbonMode RibbonMode { get; set; }
        public bool ShowStatusBar { get; set; }

        public bool IsExternalRibbonMode { get { return RibbonMode == RichEditRibbonMode.ExternalRibbon; } }
        public static List<SelectListItem> GetSelectModes() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "None", Value = "None" },
                new SelectListItem() { Text = "Ribbon", Value = "Ribbon", Selected = true },
                new SelectListItem() { Text = "External Ribbon", Value = "ExternalRibbon" },
                new SelectListItem() { Text = "One Line Ribbon", Value="OneLineRibbon" },
                new SelectListItem() { Text = "Auto", Value="Auto" }
            };
        }
    }
}

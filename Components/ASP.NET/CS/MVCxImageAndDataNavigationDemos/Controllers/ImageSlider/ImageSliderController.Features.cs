using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageSliderController : DemoController {
        public ActionResult Features() {
            if(TempData["Options"] == null)
                TempData["Options"] = new ImageSliderFeaturesDemoOptions();
            return DemoView("Features");
        }
        [HttpPost]
        public ActionResult Features(ImageSliderFeaturesDemoOptions options) {
            ImageSliderFeaturesDemoOptions predefinedOptions = !string.IsNullOrEmpty(options.PredefinedScenario) 
                ? new ImageSliderFeaturesDemoOptions() { PredefinedScenario = options.PredefinedScenario }
                : null;
            switch(options.PredefinedScenario) {
                case "FillAndCropDots":
                    predefinedOptions.SettingsImageArea.ImageSizeMode = ImageSizeMode.FillAndCrop;
                    predefinedOptions.SettingsImageArea.NavigationButtonVisibility = ElementVisibilityMode.Always;
                    predefinedOptions.SettingsImageArea.ItemTextVisibility = ElementVisibilityMode.Always;
                    predefinedOptions.SettingsNavigationBar.Mode =  DevExpress.Web.NavigationBarMode.Dots;
                    break;
                case "VerticalScrolling":
                    predefinedOptions.SettingsImageArea.NavigationDirection = NavigationDirection.Vertical;
                    predefinedOptions.SettingsImageArea.ImageSizeMode = ImageSizeMode.FillAndCrop;
                    predefinedOptions.SettingsImageArea.NavigationButtonVisibility = ElementVisibilityMode.Faded;
                    predefinedOptions.SettingsImageArea.ItemTextVisibility = ElementVisibilityMode.None;
                    predefinedOptions.SettingsNavigationBar.Position = NavigationBarPosition.Left;
                    predefinedOptions.SettingsNavigationBar.ThumbnailsModeNavigationButtonVisibility = ElementVisibilityMode.Faded;
                    break;
                default: 
                    break;
            }
            TempData["Options"] = predefinedOptions ?? options;
            if(predefinedOptions != null)
                return RedirectToAction("Features");
            return DemoView("Features");
        }
    }
}

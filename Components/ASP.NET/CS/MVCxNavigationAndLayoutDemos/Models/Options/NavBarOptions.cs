namespace DevExpress.Web.Demos {
    public class NavBarFeaturesDemoOptions {
        public NavBarFeaturesDemoOptions() {
            AllowExpanding = true;
            AllowSelectItem = true;
            AutoCollapse = true;
            EnableHotTrack = true;
            EnableAnimation = true;
            SaveStateToCookies = true;
        }

        public bool AllowExpanding { get; set; }
        public bool AllowSelectItem { get; set; }
        public bool AutoCollapse { get; set; }
        public bool EnableAnimation { get; set; }
        public bool EnableHotTrack { get; set; }
        public bool SaveStateToCookies { get; set; }
    }
}

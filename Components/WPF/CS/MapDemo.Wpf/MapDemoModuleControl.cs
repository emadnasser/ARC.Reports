using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.Map;

namespace MapDemo {
    public class MapDemoModule : DemoModule {
        public MapDemoModule() {
        }

        public override void Leave() {
            foreach(MapControl map in DemoUtils.FindMap(this))
                map.HideToolTip();
            base.Leave();
        }

        public override bool AllowRtl { get { return false; } }
    }
}

using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.UI;
using Windows.UI.Xaml.Controls;

namespace FeatureDemo.Common {
    public interface IResetScrollViewService {
        void Reset();
    }
    public class ResetScrollViewService : ServiceBase, IResetScrollViewService {
        public void Reset() {
            ((ScrollViewer)AssociatedObject).Do(x => x.ChangeView(0, 0, null, true));
        }
    }
}

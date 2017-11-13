using System;
using DevExpress.Mvvm.UI;
using Windows.UI.Xaml;

namespace HybridApp.Common {
    public interface IWaitIndicatorService {
        void Activate(bool active, Action executeMethod = null, bool deactivateAfterExecute = false);
    }
    public class WaitIndicatorService : ServiceBase, IWaitIndicatorService {
        public WaitIndicatorService() {
            executeTimer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(100) };
            executeTimer.Tick += Execute;
        }
        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register("IsActive", typeof(bool), typeof(WaitIndicatorService), new PropertyMetadata(false));
        public bool IsActive {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
        public static readonly DependencyProperty IsInitialActiveProperty =
            DependencyProperty.Register("IsInitialActive", typeof(bool), typeof(WaitIndicatorService), new PropertyMetadata(true));
        public bool IsInitialActive {
            get { return (bool)GetValue(IsInitialActiveProperty); }
            set { SetValue(IsInitialActiveProperty, value); }
        }
        bool initialActiviteOccures = false;
        DispatcherTimer executeTimer;
        Action executeMethod;
        bool deactivateAfterExecute;
        void Execute(object sender, object e) {
            executeTimer.Stop();
            if(executeMethod != null) {
                executeMethod();
                if(deactivateAfterExecute)
                    SetValue(IsActiveProperty, false);
            }
        }
        void IWaitIndicatorService.Activate(bool active, Action executeMethod, bool deactivateAfterExecute) {
            SetValue(IsActiveProperty, active);
            if(!initialActiviteOccures && active == false) {
                SetValue(IsInitialActiveProperty, false);
                initialActiviteOccures = true;
            }
            if(active) {
                this.executeMethod = executeMethod;
                this.deactivateAfterExecute = deactivateAfterExecute;
                executeTimer.Start();
            }
        }
    }
}

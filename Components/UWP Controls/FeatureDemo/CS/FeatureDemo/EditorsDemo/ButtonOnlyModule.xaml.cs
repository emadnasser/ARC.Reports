using DevExpress.Mvvm;
using FeatureDemo.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace EditorsDemo {
    public class ButtonsOnlyModuleViewModel : ViewModelBase {

        public DateTime DropDownDate {
            get { return GetProperty(() => DropDownDate); }
            set { SetProperty(() => DropDownDate, value); }
        }

        public DateTime SplitDate {
            get { return GetProperty(() => SplitDate); }
            set { SetProperty(() => SplitDate, value); }
        }
    }
    public sealed partial class ButtonOnlyModule : UserControl {
        public ButtonOnlyModule() {
            DataContext = new ButtonsOnlyModuleViewModel() { DropDownDate = DateTime.Now, SplitDate = DateTime.Now };
            this.InitializeComponent();
        }
    }
}

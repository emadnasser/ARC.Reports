using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.SalesDemo.Wpf.Helpers;
using System;
using System.Windows.Media.Imaging;

namespace DevExpress.SalesDemo.Wpf.ViewModel {
    public class NavigationItemViewModel {
        public static NavigationItemViewModel Create(ModuleType moduleType, string caption, string description, BitmapImage glyph) {
            var res = ViewModelSource.Create(() => new NavigationItemViewModel());
            res.moduleType = moduleType;
            res.Caption = caption;
            res.Description = description;
            res.Glyph = glyph;
            return res;
        }
        protected NavigationItemViewModel() {
            if(this.IsInDesignMode())
                InitializeInDesignMode();
            ViewInjectionManager.Default.RegisterNavigatedEventHandler(this, () => IsActive = true);
            ViewInjectionManager.Default.RegisterNavigatedAwayEventHandler(this, () => IsActive = false);
        }
        void InitializeInDesignMode() {
            Caption = "Sales";
            Description = "Revenue" + Environment.NewLine + "Snapshots";
            Glyph = ResourceImageHelper.GetResourceImage("Sales.png");
        }

        ModuleType moduleType;
        public virtual string Caption { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual BitmapImage Glyph { get; protected set; }
        public virtual bool IsActive { get; set; }

        public void Activate() {
            if(IsActive) return;
            ViewInjectionManager.Default.Navigate(Regions.Navigation, moduleType);
        }
        protected void OnIsActiveChanged() {
            if(IsActive)
                ViewInjectionManager.Default.Navigate(Regions.Main, moduleType);
        }
    }
}

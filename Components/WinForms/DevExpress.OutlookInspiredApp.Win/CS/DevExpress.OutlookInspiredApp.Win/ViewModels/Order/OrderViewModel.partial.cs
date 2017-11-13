namespace DevExpress.DevAV.ViewModels {
    using System;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;

    partial class OrderViewModel {
        public event EventHandler EntityChanged;
        protected override void OnEntityChanged() {
            base.OnEntityChanged();
            this.RaiseCanExecuteChanged(x => x.Customize());
            RaiseEntityChanged();
        }
        public event EventHandler CustomizeFilter;
        [Command]
        public void Customize() {
            RaiseCustomizeFilter();
        }
        public bool CanCustomize() {
            return Entity != null;
        }
        void RaiseEntityChanged() {
            EventHandler handler = EntityChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseCustomizeFilter() {
            EventHandler handler = CustomizeFilter;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        public override void Delete() {
            MessageBoxService.ShowMessage("To ensure data integrity, the Sales module doesn't allow records to be deleted. Record deletion is supported by the Employees module.", "Delete Sale", MessageButton.OK);
        }
    }
    public partial class SynchronizedOrderViewModel : OrderViewModel {
        protected override bool EnableSelectedItemSynchronization {
            get { return true; }
        }
        protected override bool EnableEntityChangedSynchronization {
            get { return true; }
        }
    }
}

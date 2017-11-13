using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraBars.Docking2010;
using DevExpress.Utils.MVVM.UI;
using DevExpress.Snap;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.OrderViewDocumentType)]
    public partial class OrderView : BaseViewWithWinUIButtons {
        public OrderView() {
            InitializeComponent();
            dataLayoutControl.SetupLayoutControl();
            viewItems.SetupCollectionGrid();
            if (!mvvmContext.IsDesignMode) {
                SetupSnapControl();
                InitBindings();
            }
        }
        void InitBindings() {
            var fluentAPI = mvvmContext.OfType<OrderViewModel>();
            fluentAPI.SetObjectDataSourceBinding(orderBindingSource, x => x.Entity, x => x.Update());
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[0], x => x.Close(), "Cancel");
            fluentAPI.BindCommand(backWindowsUIButtonPanel.Buttons[0] as WindowsUIButton, x => x.Close());
            fluentAPI.SetBinding(snapControl, s => s.DataSource, x => x.Entity);
            fluentAPI.SetBinding(invoiceNumberSimpleLabelItem, l => l.Text, x => x.Entity.InvoiceNumber, v => string.Format("#{0}", v));
            fluentAPI.SetTrigger(x => x.Entity, (x) =>
            {
                snapControl.Document.Fields.Update();
            });
            float zoomDelta = 0.10f;
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[2], (x, t) => x.ZoomIn(t), p => zoomDelta, "ZoomIn");
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[3], (x, t) => x.ZoomOut(t), p => zoomDelta, "ZoomOut");
            fluentAPI.WithEvent<SnapControl, EventArgs>(snapControl, "ZoomChanged").
                SetBinding(x => x.ZoomFactor,
                            args => snapControl.ActiveView.ZoomFactor,
                            (snap, v) => snap.ActiveView.ZoomFactor = v);
        }
        void SetupSnapControl() {
            snapControl.LoadTemplate();
        }
    }
}

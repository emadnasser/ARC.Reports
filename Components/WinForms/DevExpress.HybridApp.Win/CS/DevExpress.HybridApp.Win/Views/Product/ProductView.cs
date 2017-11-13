using DevExpress.DevAV.ViewModels;
using DevExpress.Utils.MVVM.UI;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraPdfViewer;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.ProductViewDocumentType)]
    public partial class ProductView : BaseViewWithWinUIButtons {
        public ProductView() {
            InitializeComponent();
            dataLayoutControl.SetupLayoutControl();
            PopulateEnums();
            if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
            var fluentAPI = mvvmContext.OfType<ProductViewModel>();
            fluentAPI.SetTrigger(x => x.Entity, t =>
            {
                if(t.Brochure != null)
                    pdfViewer.LoadDocument(t.Brochure);
                bool isNew = fluentAPI.ViewModel.IsNew();
                productNameLayoutControlItem.Visibility =
                    pdfLayoutControlItem.Visibility =
                    productSimpleLabelItem.Visibility = isNew ? LayoutVisibility.Never : LayoutVisibility.Always;
                ItemForName.Visibility = isNew ? LayoutVisibility.Always : LayoutVisibility.Never;
            });
            fluentAPI.SetObjectDataSourceBinding(productBindingSource, x => x.Entity, x => x.Update());
            fluentAPI.BindCommand(backWindowsUIButtonPanel.Buttons[0] as WindowsUIButton, x => x.Close());
            fluentAPI.SetBinding(cbSupport.Properties, r => r.DataSource, x => x.LookUpEmployees.Entities);
            fluentAPI.SetBinding(cbProductEngineer.Properties, r => r.DataSource, x => x.LookUpEmployees.Entities);
            fluentAPI.SetBinding(productNameLabelControl, l => l.Text, x => x.Entity.Name);
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[0], x => x.SaveAndClose());
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[1], x => x.Close(), "Cancel");
            float zoomDelta = 10f;
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[3], (x, t) => x.ZoomIn(t), p => zoomDelta, "ZoomIn");
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[4], (x, t) => x.ZoomOut(t), p => zoomDelta, "ZoomOut");
            fluentAPI.WithEvent<PdfViewer, PdfZoomChangedEventArgs>(pdfViewer, "ZoomChanged").
                SetBinding(x => x.ZoomFactor,
                            args => args.ZoomFactor,
                            (viewer, v) => viewer.ZoomFactor = v);
        }
        void PopulateEnums() {
            CategoryImageComboBoxEdit.Properties.Items.AddEnum<ProductCategory>();
        }
    }
}

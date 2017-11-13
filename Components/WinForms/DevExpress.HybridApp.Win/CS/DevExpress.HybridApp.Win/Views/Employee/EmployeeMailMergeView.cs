using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.MVVM.UI;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Docking2010;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.EmployeeMailMergeViewDocumentType)]
    public partial class EmployeeMailMergeView : BaseViewWithWinUIButtons {
        public EmployeeMailMergeView() {
            InitializeComponent();
            snapControl.DataSources.Add("", employeeBindingSource);
            snapControl.Options.SnapMailMergeVisualOptions.DataSourceName = "";
        }

        private void InitBinding() {
            var fluentAPI = mvvmContext.OfType<EmployeeMailMergeViewModel>();
            fluentAPI.SetObjectDataSourceBinding(employeeBindingSource, x => x.Entities);
            fluentAPI.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(advBandedGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as Employee,
                (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            fluentAPI.SetBinding(snapControl.Options.SnapMailMergeVisualOptions, op => op.CurrentRecordIndex, x => x.SelectedEntityIndex);
            fluentAPI.SetTrigger(x => x.SelectedTemplate, template => { UpdateTemplate(template);});
            fluentAPI.SetItemsSourceBinding(cbMailTemplate.Properties,
                prop => prop.Items, x => x.Templates,
                (item, template) => object.Equals(item.Value, template),
                template => new ImageComboBoxItem(template.Name, template));
            fluentAPI.SetBinding(cbMailTemplate, cb => cb.EditValue, x => x.SelectedTemplate);
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).ImageUri = ToolbarExtension.GetImageUri("ZoomIn");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).Click += (s, e) => Zoom(true);
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).ImageUri = ToolbarExtension.GetImageUri("ZoomOut");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).Click += (s, e) => Zoom(false);
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[3]).ImageUri = ToolbarExtension.GetImageUri("Print");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[3]).Click += (s, e) => Print();
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[5], x => x.Close(), "Cancel");
            UpdateTemplate(fluentAPI.ViewModel.SelectedTemplate);
        }

        static float minZoomFactor = 0.3f;
        static float maxZoomFactor = 1.7f;
        static float stepZoomFactor = 0.1f;
        private void Zoom(bool zoomIn) {
            float zoom = zoomIn ? stepZoomFactor : -stepZoomFactor;
            snapControl.ActiveView.ZoomFactor += zoom;
        }

        private void Print() {
            snapControl.Print();
        }

        private void UpdateTemplate(TemplateViewModel template) {
            int index = snapControl.Options.SnapMailMergeVisualOptions.CurrentRecordIndex;
            snapControl.LoadDocumentTemplate(template.Template, DevExpress.Snap.Core.API.SnapDocumentFormat.Snap);
            snapControl.Options.SnapMailMergeVisualOptions.CurrentRecordIndex = index;
        }

        private void EmployeeMailMergeView_Load(object sender, EventArgs e) {
            if (!mvvmContext.IsDesignMode) {
                InitBinding();
            }
        }

        private void snapControl_ZoomChanged(object sender, EventArgs e) {
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).Enabled = snapControl.ActiveView.ZoomFactor < maxZoomFactor;
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).Enabled = snapControl.ActiveView.ZoomFactor > minZoomFactor;
        }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DevExpress.Utils.Filtering;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.XtraGrid.Demos {
    public partial class LayoutViewFilter : TutorialControl {
        public LayoutViewFilter() {
            CreateWaitDialog();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\ModulesLayoutView\\LayoutViewFilter.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.FilteringUI.xml";
            //
            InitializeComponent();
            InitVehiclesData();
        }
        List<VehiclesData.Model> models;
        List<VehiclesData.Trademark> trademarks;
        protected override void InitMDBData(string connectionString) {
            VehiclesData.InitMDBDataAndCreateEditors(connectionString, gridControl, out models, out trademarks);
            // Bind grid to data
            modelBindingSource.DataSource = models;
            #region Retrieving the Filtering UI editors into the AccordionControl
            filteringUIContext.RetrieveFields();
            accordionControl.ExpandAll();
            #endregion
        }
        #region Obtaining required additional data for Filtering UI editors
        //<accordionControl>
        void filteringUIContext_QueryRangeData(object sender, QueryRangeDataEventArgs e) {
            if(e.PropertyPath == "Price") {
                e.Result.Minimum = models.Min(m => m.Price);
                e.Result.Maximum = models.Max(m => m.Price);
            }
        }
        void filteringUIContext_QueryLookupData(object sender, QueryLookupDataEventArgs e) {
            if(e.PropertyPath == "Trademark")
                e.Result.DataSource = trademarks;
        }
        //</accordionControl>
        #endregion
        #region  Applying Context's FilterCriteria
        int criteriaChangedFromFilteringUI = 0;
        void filteringUIContext_FilterCriteriaChanged(object sender, FilterCriteriaChangedEventArgs e) {
            criteriaChangedFromFilteringUI++;
            layoutView.ActiveFilterCriteria = e.FilterCriteria;
            criteriaChangedFromFilteringUI--;
        }
        void layoutView_ColumnFilterChanged(object sender, System.EventArgs e) {
            if(criteriaChangedFromFilteringUI > 0)
                return;
            if(layoutView.ActiveFilter.IsEmpty)
                filteringUIContext.ClearFilterCriteria();
        }
        #endregion
    }
    // Metadata For Filtering Model
    //<accordionControl>
    public class FilteringModel {
        const string Main = "Main Parameters";
        [Display(GroupName = Main)]
        [FilterLookup(10, ValueMember = "ID", DisplayMember = "Name")]
        public int Trademark { get; set; }
        [Display(Name = "Model Available", GroupName = Main)]
        [FilterBooleanChoice(false)]
        public bool InStock { get; set; }
        [Display(GroupName = Main)]
        [FilterRange(0, 170000), DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(GroupName = Main)]
        [EnumDataType(typeof(VehiclesData.Category))]
        public int Category { get; set; }
    }
    //</accordionControl>
}

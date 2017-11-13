using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos
{
    public partial class OutlineGroupingSubtotal : SpreadsheetRibbonTutorialControlBase
    {

        public OutlineGroupingSubtotal()
        {
            InitializeComponent();
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("OutlineGrouping_template.xlsx"));
        }

        #region Properties
        protected internal override RibbonPage SelectedRibbonPage { get { return dataRibbonPage1; } }
        #endregion
    }
}

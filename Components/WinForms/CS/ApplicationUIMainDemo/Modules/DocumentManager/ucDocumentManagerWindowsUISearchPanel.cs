using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Views;

namespace DevExpress.ApplicationUI.Demos {
    public partial class ucDocumentManagerWindowsUISearchPanel : UserControl {
        public ucDocumentManagerWindowsUISearchPanel() {
            InitializeComponent();
            windowsUIView.QueryControl += new QueryControlEventHandler(OnQueryControl);
            windowsUIView.CustomizeSearchItems += new CustomizeSearchItemsEventHandler(OnCustomizeSearchItems);
            windowsUIView.NavigatedFrom += new NavigationEventHandler(OnNavigatedFrom);
            windowsUIView.NavigatedTo += new NavigationEventHandler(OnNavigatedTo);
            ucProductsGridDocument.SearchTags =
                SalesPerformanceDataGenerator.Current.FilterTotalSales.Select(x => x.Category).Distinct().ToArray();
            ucChartProductItemDocument.SearchTags =
                SalesPerformanceDataGenerator.Current.MonthlySales.Select(x => x.Product).Distinct().ToArray();
            ucChoroplethMapItemDocument.SearchTags = new string[] { "Map" };
            ucCategorySalesDocument.SearchTags = new string[] { "Revenue" };
            salesInCalifornia.Tag = "California";
            salesInMontana.Tag = "Montana";
            salesInTexas.Tag = "Texas";
        }
        void OnCustomizeSearchItems(object sender, CustomizeSearchItemsEventArgs e) {
            List<string> content = new List<string>();
            content.Add(e.SourceContainer.Tag as string);
            if(e.Source == ucProductsGridDocument)
                content.AddRange(typeof(DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem).GetProperties().Select(x => x.ToString()).ToArray());
            e.Content = content;
            e.Image = GetResourceImage(e.Source);
        }
        Image GetResourceImage(IComponent component) {
            string name = null;
            if(component is Document)
                name = ((Document)component).ControlName;
            if(component is IContentContainer)
                name = ((IContentContainer)component).Name;
            if(component is BaseTile)
                name = ((BaseTile)component).Name;
            if(string.IsNullOrEmpty(name)) return null;
            return DevExpress.Utils.ResourceImageHelper.CreateImageFromResourcesEx(string.Format("DevExpress.ApplicationUI.Demos.Images.{0}.png", name), typeof(ucDocumentManagerWindowsUISearchPanel).Assembly) as Image;
        }
        void OnNavigatedTo(object sender, XtraBars.Docking2010.Views.WindowsUI.NavigationEventArgs e) {
            if(e.Target == null || e.Target.Tag == null || e.Target == tileContainer) return;
            SalesPerformanceDataGenerator.Current.Filter = e.Target.Tag.ToString();
        }
        void OnNavigatedFrom(object sender, XtraBars.Docking2010.Views.WindowsUI.NavigationEventArgs e) {
            if(e.Source == salesByState)
                e.Source.Tag = SalesPerformanceDataGenerator.Current.Filter;
        }
        void OnQueryControl(object sender, XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            if(string.IsNullOrEmpty(e.Document.ControlTypeName))
                e.Control = new Control();
            else
                e.Control = Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)) as Control;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using DevExpress.Web;

public partial class SiteMaster : System.Web.UI.MasterPage {
    Dictionary<string, string> ReportNames = new Dictionary<string, string>();

    protected BasePage BasePage { get { return Page as BasePage; } }
    protected FilterBag FilterBag { get { return BasePage.FilterBag; } }

    protected void Page_Init(object sender, EventArgs e) {
        SetupPage();
        LoadFilterControlColumns();
    }

    protected void Page_Load(object sender, EventArgs e) {
        SearchBox.Visible = BasePage.HasSearchPanel;
        if(!IsPostBack)
            UpdateFilterControlExpression();
        LoadFilterNavBarItems();
    }

    public void SetupPage() {
        BasePage.Title = BasePage.PageName + " - DevAV Demo | ASP.NET Controls by DevExpress";

        NavigationMenu.Items[0].Image.Url = string.Format("~/Content/Images/LogoMenuIcons/{0}.png", BasePage.PageName);
        SplitterPane contentPane = Splitter.GetPaneByName("MainContentPane");
        if(contentPane != null) {
            contentPane.ScrollBars = BasePage.ContentHasScroll ? ScrollBars.Auto : ScrollBars.None;
            contentPane.PaneStyle.CssClass = BasePage.ContentHasBorder ? "mainContentPane frame" : "mainContentPane";
        }
        ReadOnlyPopup.Visible = DemoUtils.IsSiteMode;
    }

    protected void MainCallbackPanel_Callback(object sender, CallbackEventArgsBase e) {
        var args = DemoUtils.DeserializeCallbackArgs(e.Parameter);
        if(args.Count == 0)
            return;
        if(args[0] == "SaveEditForm")
            BasePage.SaveEditFormChanges(args[2]);
        if(args[0] == "DeleteEntry")
            BasePage.DeleteEntry(args[1]);
        if(args[0] == "FilterChanged") {
            FilterBag.FilterControlExpression = args[1];
            UpdateFilterControlExpression();
            MainCallbackPanel.JSProperties["cpSelectedFilterNavBarItemName"] = FilterBag.GetActiveFilterName();
            BasePage.OnFilterChanged();
        }
    }

    protected void UpdateFilterControlExpression() {
        FilterControl.FilterExpression = FilterBag.FilterControlExpression;
    }

    protected void LoadFilterControlColumns() {
        foreach(var column in BasePage.GetFilterColumns())
            FilterControl.Columns.Add(column);
    }

    protected void LoadFilterNavBarItems() {
        var filterItems = FilterBag.GetFilterItems();
        foreach(var g in filterItems.GroupBy(p => p.Value.IsCustom)) {
            var groupName = g.Key ? "Custom" : "Favorites";
            var group = FilterNavBar.Groups.FindByName(groupName);
            group.Items.Clear();
            foreach(var pair in g) {
                var filterItem = pair.Value;
                var item = group.Items.Add(filterItem.Name, pair.Key);
                if(FilterBag.GetIsActiveFilter(filterItem.Expression))
                    item.Selected = true;
            }
        }
        FilterNavBar.JSProperties["cpFilterExpressions"] = filterItems.ToDictionary(p => p.Key, p => p.Value.Expression);
    }

    protected void SaveFilterButton_Click(object sender, EventArgs e) {
        var filterItem = FilterBag.CreateCustomFilter(CustomFilterTextBox.Text, FilterControl.FilterExpression);
        FilterBag.FilterControlExpression = filterItem.Expression;
        UpdateFilterControlExpression();
        FilterPopup.ShowOnPageLoad = false;
        LoadFilterNavBarItems();
        BasePage.OnFilterChanged();
    }

    protected void EditMessagePopup_CustomJSProperties(object sender, CustomJSPropertiesEventArgs e) {
        e.Properties["cpEmployeeEditMessageTemplate"] = EmployeeEditMessageTemplate;
        e.Properties["cpEditMessageTemplate"] = EditMessageTemplate;
    }

    protected string EmployeeEditMessageTemplate { get { return "This sample web application does not allow you to <<Operation>> records into the database."; } }
    protected string EditMessageTemplate { get { return EmployeeEditMessageTemplate + " To see how DevExpress ASP.NET Controls can help you build amazing data entry forms, navigate to the Employees Module."; } }

    protected void HiddenField_Init(object sender, EventArgs e) {
        DemoUtils.RegisterStateHiddenField(HiddenField);
    }

    protected void ToolbarMenu_ItemDataBound(object source, MenuItemEventArgs e) {
        var item = e.Item;
        IHierarchyData itemHierarchyData = (IHierarchyData)item.DataItem;
        var element = (XmlElement)itemHierarchyData.Item;

        var attr = element.Attributes["BeginGroup"];
        if(attr != null)
            e.Item.BeginGroup = attr.Value == "True";
        attr = element.Attributes["Checked"];
        if(attr != null)
            e.Item.Checked = attr.Value == "True";
        attr = element.Attributes["DropDownMode"];
        if(attr != null)
            e.Item.DropDownMode = attr.Value == "True";
        attr = element.Attributes["UrlDisabled"];
        if(attr != null)
            e.Item.Image.UrlDisabled = attr.Value;
        attr = element.Attributes["ReportName"];
        if(attr != null)
            ReportNames[e.Item.Name] = attr.Value;
        BasePage.PrepareToolbarItem(e.Item); //TODO rename 
    }
    protected void ToolbarMenu_CustomJSProperties(object sender, CustomJSPropertiesEventArgs e) {
        e.Properties["cpReportNames"] = ReportNames;
    }
    protected void PageViewerPopup_CustomJSProperties(object sender, CustomJSPropertiesEventArgs e) {
        var reportTypes = Enum.GetValues(typeof(ReportType)).OfType<ReportType>();
        e.Properties["cpReportDisplayNames"] = reportTypes.ToDictionary(r => r.ToString(), r => DemoUtils.GetReportDisplayName(r));
    }
    protected void ToolbarMenuDataSource_Init(object sender, EventArgs e) {
        ToolbarMenuDataSource.XPath = string.Format("Pages/{0}/Item", BasePage.PageName);
    }

    protected void CustomFilterTextBox_Load(object sender, EventArgs e) {
        CustomFilterTextBox.ClientEnabled = SaveCustomFilterCheckBox.Checked;
    }
}

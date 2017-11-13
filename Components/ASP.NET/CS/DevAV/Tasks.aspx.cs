using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class Tasks : BasePage {
    ViewUserControl viewControl;

    public override FilterBag FilterBag { get { return DemoUtils.TaskFilter; } }
    public override string PageName { get { return "Tasks"; } }

    protected ViewUserControl ViewControl { get { return viewControl; } }

    public override void OnFilterChanged() {
        ViewControl.Update();
    }

    public override void SaveEditFormChanges(string parameters) {
        ViewControl.SelectedItemID = TaskEditForm.SaveChanges(parameters);
    }
    public override void DeleteEntry(string taskID) {
        DataProvider.DeleteTask(long.Parse(taskID));
        OnFilterChanged(); //TODO Rename Function
    }

    protected void Page_Init(object sender, EventArgs e) {
        LoadUserControlView();
    }

    public override void PrepareToolbarItem(DevExpress.Web.MenuItem item) {
        base.PrepareToolbarItem(item);
        if(item.Name == "GridView")
            item.Checked = DemoUtils.IsTaskGridViewMode;
        if(item.Name == "CardsView")
            item.Checked = !DemoUtils.IsTaskGridViewMode;
    }

    void LoadUserControlView() {
        var viewMode = DemoUtils.IsTaskGridViewMode ? "GridView" : "CardView";
        this.viewControl = LoadControl(string.Format("~/UserControls/ViewControls/Tasks{0}.ascx", viewMode)) as ViewUserControl;
        MainContentContainer.Controls.Add(ViewControl);
    }

    public override IEnumerable<FilterControlColumn> GetFilterColumns() {
        var result = new ArrayList();
        result.Add(new FilterControlTextColumn() { PropertyName = "Subject" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Description" });
        result.Add(new FilterControlDateColumn() { PropertyName = "StartDate" });
        result.Add(new FilterControlDateColumn() { PropertyName = "DueDate" });

        result.Add(new FilterControlComboBoxColumn() { PropertyName = "Status" }, typeof(EmployeeTaskStatus));
        result.Add(new FilterControlComboBoxColumn() { PropertyName = "Priority" }, typeof(EmployeeTaskPriority));

        var spinColumn = result.Add<FilterControlSpinEditColumn>(new FilterControlSpinEditColumn() { PropertyName = "Completion" });
        spinColumn.PropertiesSpinEdit.MinValue = 0;
        spinColumn.PropertiesSpinEdit.MaxValue = 100;
        spinColumn.PropertiesSpinEdit.NumberType = SpinEditNumberType.Integer;

        return result.OfType<FilterControlColumn>();
    }
}

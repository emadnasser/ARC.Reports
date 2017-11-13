using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class Employees : MasterDetailPage {
    MasterUserControl masterUC;
    DetailUserControl detailUC;

    public override FilterBag FilterBag { get { return DemoUtils.EmployeeFilter; } }
    public override string PageName { get { return "Employees"; } }
    public override MasterUserControl MasterUC { get { return masterUC; } }
    public override DetailUserControl DetailUC { get { return detailUC; } }

    protected void Page_Init(object sender, EventArgs e) {
        LoadUserControls();
    }

    public override void PrepareToolbarItem(DevExpress.Web.MenuItem item) {
        base.PrepareToolbarItem(item);
        if(item.Name == "ColumnsCustomization")
            item.ClientEnabled = DemoUtils.IsEmployeeGridViewMode;
        if(item.Name == "GridView")
            item.Checked = DemoUtils.IsEmployeeGridViewMode;
        if(item.Name == "CardsView")
            item.Checked = !DemoUtils.IsEmployeeGridViewMode;
    }

    protected void LoadUserControls() {
        var viewMode = DemoUtils.IsEmployeeGridViewMode ? "GridView" : "CardView";
        this.masterUC = LoadControl(string.Format("~/UserControls/ViewControls/Employees{0}_Master.ascx", viewMode)) as MasterUserControl;
        this.detailUC = LoadControl(string.Format("~/UserControls/ViewControls/Employees{0}_Detail.ascx", viewMode)) as DetailUserControl;
        MasterContainer.Controls.Add(MasterUC);
        DetailsCallbackPanel.Controls.Add(DetailUC);
    }

    protected void DetailsCallbackPanel_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e) { // TODO refactor
        var args = DemoUtils.DeserializeCallbackArgs(e.Parameter);
        if(args.Count == 0)
            return;
        var callbackName = args[0];
        if(callbackName == "SaveEditForm")
            GetEditForm(args[1]).SaveChanges(args[2]);
        if(callbackName == "DeleteEntry") {
            long entryID = long.Parse(args[2]);
            if(entryID == DataProvider.emptyEntryID)
                return;
            switch(args[1]) {
                case "Task":
                    DataProvider.DeleteTask(entryID);
                    break;
                case "Evaluation":
                    DataProvider.DeleteEvaluation(entryID);
                    break;
            }
        }
        UpdateDetail();
    }

    public override void OnFilterChanged() {
        Update();
    }
    public override void SaveEditFormChanges(string parameters) {
        MasterUC.SelectedItemID = EmployeeEditForm.SaveChanges(parameters); // TODO rename SaveChanges
    }
    public override void DeleteEntry(string employeeID) {
        DataProvider.DeleteEmployee(long.Parse(employeeID));
        MasterUC.Update();
    }

    public override IEnumerable<FilterControlColumn> GetFilterColumns() {
        var result = new ArrayList();
        result.Add(new FilterControlTextColumn() { PropertyName = "FirstName" });
        result.Add(new FilterControlTextColumn() { PropertyName = "LastName" });
        result.Add(new FilterControlTextColumn() { PropertyName = "FullName" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Address" });
        result.Add(new FilterControlDateColumn() { PropertyName = "BirthDate" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Department" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Email" });
        result.Add(new FilterControlDateColumn() { PropertyName = "HireDate" });
        result.Add(new FilterControlTextColumn() { PropertyName = "HomePhone" });
        result.Add(new FilterControlTextColumn() { PropertyName = "MobilePhone" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Prefix" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Skype" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Title" });
        result.Add(new FilterControlComboBoxColumn() { PropertyName = "Status" }, typeof(EmployeeStatus));
        return result.OfType<FilterControlColumn>();
    }

    EditFormUserControl GetEditForm(string name) {
        if(name == "Task")
            return TaskEditForm;
        if(name == "Evaluation")
            return EvaluationEditForm;
        return null;
    }
}

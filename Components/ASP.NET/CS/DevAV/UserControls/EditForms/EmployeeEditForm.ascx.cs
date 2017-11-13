using System;
using System.Linq;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class UserControls_EditForms_EmployeeEditForm : EditFormUserControl {
    protected void Page_Init(object sender, EventArgs e) {
        DemoUtils.BindComboBoxToEnum(PrefixComboBox, typeof(PersonPrefix));
        DemoUtils.BindComboBoxToEnum(StateComboBox, typeof(StateEnum));
        DemoUtils.BindComboBoxToEnum(DeptComboBox, typeof(EmployeeDepartment));
    }

    public override long SaveChanges(string args) {
        var callbackArgs = DemoUtils.DeserializeCallbackArgs(args);
        Employee employee = null;
        if(callbackArgs[0] == "New")
            employee = DataProvider.CreateEmployee();
        else if(callbackArgs[0] == "Edit") {
            long id = long.Parse(callbackArgs[1]);
            employee = DataProvider.Employees.FirstOrDefault(e => e.Id == id);
        }
        if(employee == null)
            return DataProvider.emptyEntryID;

        employee.FirstName = FirstNameTextBox.Text;
        employee.LastName = LastNameTextBox.Text;
        if(PrefixComboBox.Value != null)
            employee.Prefix = (PersonPrefix)Enum.Parse(typeof(PersonPrefix), PrefixComboBox.Value.ToString());
        employee.Title = TitleTextBox.Text;
        employee.Address.Line = AddressTextBox.Text;
        employee.Address.City = CityTextBox.Text;
        if(StateComboBox.Value != null)
            employee.Address.State = (StateEnum)Enum.Parse(typeof(StateEnum), StateComboBox.Value.ToString());
        employee.Address.ZipCode = ZipCodeTextBox.Text;
        employee.HomePhone = HomeNumberTextBox.Text;
        employee.Email = EmailTextBox.Text;
        employee.MobilePhone = MobileNumberTextBox.Text;
        employee.Skype = SkypeTextBox.Text;
        employee.HireDate = HireDateEdit.Date;
        employee.FullName = employee.FirstName + " " + employee.LastName;
        if(DeptComboBox.Value != null)
            employee.Department = (EmployeeDepartment)Enum.Parse(typeof(EmployeeDepartment), DeptComboBox.Value.ToString());
        DataProvider.SaveChanges();
        DemoUtils.ImageLoader.CreateDefaultEmployeeImage(employee.Id);

        return employee.Id;
    }

    protected void EmployeeEditPopup_WindowCallback(object source, PopupWindowCallbackArgs e) {
        long id = long.Parse(e.Parameter);
        var employee = DataProvider.Employees.FirstOrDefault(em => em.Id == id);
        if(employee == null)
            return;
        FirstNameTextBox.Text = employee.FirstName;
        LastNameTextBox.Text = employee.LastName;
        PrefixComboBox.Value = employee.Prefix.ToString();
        TitleTextBox.Text = employee.Title;
        AddressTextBox.Text = employee.Address.Line;
        CityTextBox.Text = employee.Address.City;
        StateComboBox.Value = employee.Address.State.ToString();
        ZipCodeTextBox.Text = employee.Address.ZipCode;
        HomeNumberTextBox.Value = employee.HomePhone;
        EmailTextBox.Value = employee.Email;
        MobileNumberTextBox.Value = employee.MobilePhone;
        SkypeTextBox.Value = employee.Skype;
        HireDateEdit.Value = employee.HireDate;
        DeptComboBox.Value = employee.Department.ToString(); // TODO refactor

        EmployeeEditPopup.JSProperties["cpEmployeeID"] = employee.Id;
        EmployeeEditPopup.JSProperties["cpHeaderText"] = string.Format("Edit Employee ({0} {1})", employee.FirstName, employee.LastName);
    }
}

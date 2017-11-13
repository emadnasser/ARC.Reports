using System;
using System.Linq;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class UserControls_EditForms_CusomerEmployeeEditForm : EditFormUserControl {
    protected void Page_Init(object sender, EventArgs e) {
        DemoUtils.BindComboBoxToEnum(PrefixComboBox, typeof(PersonPrefix));
        DemoUtils.BindComboBoxToEnum(StateComboBox, typeof(StateEnum));
        foreach(var customerStore in DataProvider.GetCustomerStores()) {
            var addressLine = customerStore.AddressLine;
            if(StoreComboBox.Items.IndexOfText(addressLine) != -1)
                continue;
            StoreComboBox.Items.Add(new ListEditItem(addressLine, customerStore.Id));
        }
    }

    public override long SaveChanges(string args) {
        long id = long.Parse(DemoUtils.DeserializeCallbackArgs(args)[0]);
        if(id == DataProvider.emptyEntryID)
            return DataProvider.emptyEntryID;
        var customerEmployee = DataProvider.CustomerEmployees.FirstOrDefault(e => e.Id == id);
        if(customerEmployee == null)
            return DataProvider.emptyEntryID;
        customerEmployee.FirstName = FirstNameTextBox.Text;
        customerEmployee.LastName = LastNameTextBox.Text;
        customerEmployee.FullName = customerEmployee.FirstName + " " + customerEmployee.LastName;
        customerEmployee.IsPurchaseAuthority = PurchaseAuthorityCheckBox.Checked;
        if(PrefixComboBox.Value != null)
            customerEmployee.Prefix = (PersonPrefix)Enum.Parse(typeof(PersonPrefix), PrefixComboBox.Value.ToString());
        customerEmployee.Position = PositionTextBox.Text;
        if(StoreComboBox.Value != null) {
            long storeID = long.Parse(StoreComboBox.Value.ToString());
            customerEmployee.CustomerStore = DataProvider.GetCustomerStores().FirstOrDefault(s => s.Id == storeID);
        }
        customerEmployee.CustomerStore.Phone = BusinessPhoneTextBox.Text;
        customerEmployee.Email = EmailTextBox.Text;
        customerEmployee.MobilePhone = MobileNumberTextBox.Text;
        DataProvider.SaveChanges();
        return customerEmployee.Id;
    }

    protected void CustomerEmployeeEditPopup_WindowCallback(object source, PopupWindowCallbackArgs e) {
        long id = long.Parse(e.Parameter);
        var customerEmployee = DataProvider.CustomerEmployees.FirstOrDefault(em => em.Id == id);
        if(customerEmployee == null)
            return;
        FirstNameTextBox.Text = customerEmployee.FirstName;
        LastNameTextBox.Text = customerEmployee.LastName;
        PrefixComboBox.Value = customerEmployee.Prefix.ToString();
        PositionTextBox.Text = customerEmployee.Position;
        StoreComboBox.Text = customerEmployee.CustomerStore.AddressLine;
        AddressTextBox.Text = customerEmployee.Address.Line;
        CityTextBox.Text = customerEmployee.Address.City;
        StateComboBox.Value = customerEmployee.Address.State.ToString();
        ZipCodeTextBox.Text = customerEmployee.Address.ZipCode;
        BusinessPhoneTextBox.Value = customerEmployee.CustomerStore.Phone;
        EmailTextBox.Value = customerEmployee.Email;
        MobileNumberTextBox.Value = customerEmployee.MobilePhone;
        PurchaseAuthorityCheckBox.Checked = customerEmployee.IsPurchaseAuthority;

        CustomerEmployeeEditPopup.JSProperties["cpCustomerEmployeeID"] = customerEmployee.Id;
        CustomerEmployeeEditPopup.JSProperties["cpHeaderText"] = string.Format("Edit Customer Contact ({0} {1})", customerEmployee.FirstName, customerEmployee.LastName);
    }
}

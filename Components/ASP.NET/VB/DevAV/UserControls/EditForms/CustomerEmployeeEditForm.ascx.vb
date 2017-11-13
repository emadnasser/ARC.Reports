Imports System
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class UserControls_EditForms_CusomerEmployeeEditForm
    Inherits EditFormUserControl

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        DemoUtils.BindComboBoxToEnum(PrefixComboBox, GetType(PersonPrefix))
        DemoUtils.BindComboBoxToEnum(StateComboBox, GetType(StateEnum))
        For Each customerStore In DataProvider.GetCustomerStores()
            Dim addressLine = customerStore.AddressLine
            If StoreComboBox.Items.IndexOfText(addressLine) <> -1 Then
                Continue For
            End If
            StoreComboBox.Items.Add(New ListEditItem(addressLine, customerStore.Id))
        Next customerStore
    End Sub

    Public Overrides Function SaveChanges(ByVal args As String) As Long

        Dim id_Renamed As Long = Long.Parse(DemoUtils.DeserializeCallbackArgs(args)(0))
        If id_Renamed = DataProvider.emptyEntryID Then
            Return DataProvider.emptyEntryID
        End If
        Dim customerEmployee = DataProvider.CustomerEmployees.FirstOrDefault(Function(e) e.Id = id_Renamed)
        If customerEmployee Is Nothing Then
            Return DataProvider.emptyEntryID
        End If
        customerEmployee.FirstName = FirstNameTextBox.Text
        customerEmployee.LastName = LastNameTextBox.Text
        customerEmployee.FullName = customerEmployee.FirstName & " " & customerEmployee.LastName
        customerEmployee.IsPurchaseAuthority = PurchaseAuthorityCheckBox.Checked
        If PrefixComboBox.Value IsNot Nothing Then
            customerEmployee.Prefix = DirectCast(System.Enum.Parse(GetType(PersonPrefix), PrefixComboBox.Value.ToString()), PersonPrefix)
        End If
        customerEmployee.Position = PositionTextBox.Text
        If StoreComboBox.Value IsNot Nothing Then
            Dim storeID As Long = Long.Parse(StoreComboBox.Value.ToString())
            customerEmployee.CustomerStore = DataProvider.GetCustomerStores().FirstOrDefault(Function(s) s.Id = storeID)
        End If
        customerEmployee.CustomerStore.Phone = BusinessPhoneTextBox.Text
        customerEmployee.Email = EmailTextBox.Text
        customerEmployee.MobilePhone = MobileNumberTextBox.Text
        DataProvider.SaveChanges()
        Return customerEmployee.Id
    End Function

    Protected Sub CustomerEmployeeEditPopup_WindowCallback(ByVal source As Object, ByVal e As PopupWindowCallbackArgs)

        Dim id_Renamed As Long = Long.Parse(e.Parameter)
        Dim customerEmployee = DataProvider.CustomerEmployees.FirstOrDefault(Function(em) em.Id = id_Renamed)
        If customerEmployee Is Nothing Then
            Return
        End If
        FirstNameTextBox.Text = customerEmployee.FirstName
        LastNameTextBox.Text = customerEmployee.LastName
        PrefixComboBox.Value = customerEmployee.Prefix.ToString()
        PositionTextBox.Text = customerEmployee.Position
        StoreComboBox.Text = customerEmployee.CustomerStore.AddressLine
        AddressTextBox.Text = customerEmployee.Address.Line
        CityTextBox.Text = customerEmployee.Address.City
        StateComboBox.Value = customerEmployee.Address.State.ToString()
        ZipCodeTextBox.Text = customerEmployee.Address.ZipCode
        BusinessPhoneTextBox.Value = customerEmployee.CustomerStore.Phone
        EmailTextBox.Value = customerEmployee.Email
        MobileNumberTextBox.Value = customerEmployee.MobilePhone
        PurchaseAuthorityCheckBox.Checked = customerEmployee.IsPurchaseAuthority

        CustomerEmployeeEditPopup.JSProperties("cpCustomerEmployeeID") = customerEmployee.Id
        CustomerEmployeeEditPopup.JSProperties("cpHeaderText") = String.Format("Edit Customer Contact ({0} {1})", customerEmployee.FirstName, customerEmployee.LastName)
    End Sub
End Class

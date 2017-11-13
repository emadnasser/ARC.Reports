Imports System
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class UserControls_EditForms_EmployeeEditForm
    Inherits EditFormUserControl

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        DemoUtils.BindComboBoxToEnum(PrefixComboBox, GetType(PersonPrefix))
        DemoUtils.BindComboBoxToEnum(StateComboBox, GetType(StateEnum))
        DemoUtils.BindComboBoxToEnum(DeptComboBox, GetType(EmployeeDepartment))
    End Sub

    Public Overrides Function SaveChanges(ByVal args As String) As Long
        Dim callbackArgs = DemoUtils.DeserializeCallbackArgs(args)
        Dim employee As Employee = Nothing
        If callbackArgs(0) = "New" Then
            employee = DataProvider.CreateEmployee()
        ElseIf callbackArgs(0) = "Edit" Then

            Dim id_Renamed As Long = Long.Parse(callbackArgs(1))
            employee = DataProvider.Employees.FirstOrDefault(Function(e) e.Id = id_Renamed)
        End If
        If employee Is Nothing Then
            Return DataProvider.emptyEntryID
        End If

        employee.FirstName = FirstNameTextBox.Text
        employee.LastName = LastNameTextBox.Text
        If PrefixComboBox.Value IsNot Nothing Then
            employee.Prefix = DirectCast(System.Enum.Parse(GetType(PersonPrefix), PrefixComboBox.Value.ToString()), PersonPrefix)
        End If
        employee.Title = TitleTextBox.Text
        employee.Address.Line = AddressTextBox.Text
        employee.Address.City = CityTextBox.Text
        If StateComboBox.Value IsNot Nothing Then
            employee.Address.State = DirectCast(System.Enum.Parse(GetType(StateEnum), StateComboBox.Value.ToString()), StateEnum)
        End If
        employee.Address.ZipCode = ZipCodeTextBox.Text
        employee.HomePhone = HomeNumberTextBox.Text
        employee.Email = EmailTextBox.Text
        employee.MobilePhone = MobileNumberTextBox.Text
        employee.Skype = SkypeTextBox.Text
        employee.HireDate = HireDateEdit.Date
        employee.FullName = employee.FirstName & " " & employee.LastName
        If DeptComboBox.Value IsNot Nothing Then
            employee.Department = DirectCast(System.Enum.Parse(GetType(EmployeeDepartment), DeptComboBox.Value.ToString()), EmployeeDepartment)
        End If
        DataProvider.SaveChanges()
        DemoUtils.ImageLoader.CreateDefaultEmployeeImage(employee.Id)

        Return employee.Id
    End Function

    Protected Sub EmployeeEditPopup_WindowCallback(ByVal source As Object, ByVal e As PopupWindowCallbackArgs)

        Dim id_Renamed As Long = Long.Parse(e.Parameter)
        Dim employee = DataProvider.Employees.FirstOrDefault(Function(em) em.Id = id_Renamed)
        If employee Is Nothing Then
            Return
        End If
        FirstNameTextBox.Text = employee.FirstName
        LastNameTextBox.Text = employee.LastName
        PrefixComboBox.Value = employee.Prefix.ToString()
        TitleTextBox.Text = employee.Title
        AddressTextBox.Text = employee.Address.Line
        CityTextBox.Text = employee.Address.City
        StateComboBox.Value = employee.Address.State.ToString()
        ZipCodeTextBox.Text = employee.Address.ZipCode
        HomeNumberTextBox.Value = employee.HomePhone
        EmailTextBox.Value = employee.Email
        MobileNumberTextBox.Value = employee.MobilePhone
        SkypeTextBox.Value = employee.Skype
        HireDateEdit.Value = employee.HireDate
        DeptComboBox.Value = employee.Department.ToString() ' TODO refactor

        EmployeeEditPopup.JSProperties("cpEmployeeID") = employee.Id
        EmployeeEditPopup.JSProperties("cpHeaderText") = String.Format("Edit Employee ({0} {1})", employee.FirstName, employee.LastName)
    End Sub
End Class

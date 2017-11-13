using System;
using System.Web.UI;

public partial class FormLayout_DataBindingToSingleObject : Page {
    private const string DataObjectName = "Person";
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            formLayout.DataSource = GetData();
            formLayout.DataBind();
        }        
    }

    protected void submitButton_Click(object sender, EventArgs e) {
        UpdateData(
            (string)formLayout.GetNestedControlValueByFieldName("FirstName"),
            (string)formLayout.GetNestedControlValueByFieldName("LastName"),
            (Gender)formLayout.GetNestedControlValueByFieldName("Gender"),
            (DateTime?)formLayout.GetNestedControlValueByFieldName("BirthDate"),
            (string)formLayout.GetNestedControlValueByFieldName("Country"),
            (string)formLayout.GetNestedControlValueByFieldName("Address"),
            (string)formLayout.GetNestedControlValueByFieldName("PhoneNumber"));
                         
    }

    private void UpdateData(string firstName, string lastName, Gender gender, DateTime? birthDate, string country, string address, string phoneNumber) {
        Person person = GetData();
        person.FirstName = firstName;
        person.LastName = lastName;
        person.Gender = gender;
        person.BirthDate = birthDate;
        person.Country = country;
        person.Address = address;
        person.PhoneNumber = phoneNumber;
    }

    private Person GetData() {
        if (Session[DataObjectName] == null) {
            Session[DataObjectName] = new Person() {
                FirstName = "John",
                LastName = "Smith",
                Gender = Gender.Male,
                BirthDate = new DateTime(1970, 5, 3),
                Country = "United States",
                Address = "City Center Plaza 516 Main St.",
                PhoneNumber = "(503) 555-6874"
            };
        }
        return (Person)Session[DataObjectName];
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Data.Filtering;
using DevExpress.Data.Helpers;
using DevExpress.Web;
using DevExpress.Web.Data;
using DevExpress.Xpo;

public partial class Contacts : System.Web.UI.Page {
    static Contacts() { GetAddressFunction.Register(); }

    protected string SearchText { get { return Utils.GetSearchText(this); } }

    protected void Page_PreInit(object sender, EventArgs e) {
        Utils.ApplyTheme(this);
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            ContactForm.Visible = false;
        BindCardView();
    }

    protected void ContactCountryEditor_Load(object sender, EventArgs e) {
        if(ContactFormPanel.IsCallback || IsPostBack && !IsCallback) {
            var combo = (ASPxComboBox)sender;
            combo.DataSource = CountryDataSource;
            combo.DataBindItems();
        }
    }

    protected void ContactCityEditor_Callback(object sender, CallbackEventArgsBase e) {
        if(string.IsNullOrEmpty(e.Parameter)) 
            return;
        var combo = (ASPxComboBox)sender;
        CitiesDataSource.CommandParameters[0].DefaultValue = e.Parameter;
        combo.DataSource = CitiesDataSource;
        combo.DataBindItems();
    }

    protected void ContactDataView_CustomCallback(object sender, ASPxCardViewCustomCallbackEventArgs e) {
        if(string.IsNullOrEmpty(e.Parameters))
            return;
        var args = e.Parameters.Split('|');
        if(args[0] == "Delete" && args.Length == 2) {
            int id;
            if(!int.TryParse(args[1], out id))
                return;
            DemoModel.DataProvider.DeleteContact(id);
            BindCardView();
        }
        if(args[0] == "SaveContact") {
            var name = ContactNameEditor.Text;
            var email = ContactEmailEditor.Text;
            var address = ContactAddressEditor.Text;
            var country = ContactCountryEditor.Text;
            var city = ContactCityEditor.Text;
            var phone = ContactPhoneEditor.Text;
            
            int id;
            bool needUpdatePhoto;
            if(args.Length == 4 && args[1] == "Edit" && int.TryParse(args[2], out id) && bool.TryParse(args[3], out needUpdatePhoto)) {
                var photoUrl = needUpdatePhoto ? Utils.SaveContactPhoto(ContactPhotoImage.ContentBytes) : DataProviderBase.NoUpdateContactPhoto;
                DemoModel.DataProvider.UpdateContact(id, name, email, address, country, city, phone, photoUrl);
            }
            else if(args.Length == 2 && args[1] == "New")
                DemoModel.DataProvider.AddContact(name, email, address, country, city, phone, Utils.SaveContactPhoto(ContactPhotoImage.ContentBytes));

            BindCardView();
        }
    }

    protected void ContactPhotoImage_CustomCallback(object sender, CallbackEventArgsBase e) {
        ContactPhotoImage.JSProperties["cpContactInfoUpdating"] = false;
        
        var args = e.Parameter.Split('|');
        if(args[0] == "Edit" && args.Length == 2) {
            int id;
            if(!int.TryParse(args[1], out id)) 
                return;
            
            var contact = DemoModel.DataProvider.Contacts.FirstOrDefault(c => c.ID == id);
            if(contact == null) 
                return;
            
            var dict = new Dictionary<string, object>();
            dict["Name"] = contact.Name;
            dict["Email"] = contact.Email;
            dict["Address"] = contact.Address;
            dict["City"] = contact.City;
            dict["Country"] = contact.Country;
            dict["Phone"] = contact.Phone;
            ContactPhotoImage.Value = Utils.GetContactPhotoContentBytes(contact.PhotoUrl);

            ContactPhotoImage.JSProperties["cpContactInfo"] = dict;
            ContactPhotoImage.JSProperties["cpContactInfoUpdating"] = true;
            ContactPhotoImage.JSProperties["cpNeedUpdateContactPhoto"] = false;
            
        }
    }

    void BindCardView() {
        ContactCardView.DataSource = SelectContacts();
        ContactCardView.DataBind();
    }

    List<Contact> SelectContacts() {
        var result = DemoModel.DataProvider.Contacts.AsQueryable();
        var showCollectedAdresses = Convert.ToInt32(FindAddressBookList().Value) == 1;
        result = result.Where(c => object.Equals(c.Collected, showCollectedAdresses));

        if(!string.IsNullOrEmpty(SearchText))
            result = ApplySearch(result);

        var sortedFieldName = FindSortByCombo().Value.ToString();
        var isDescending = Convert.ToInt32(FindSortDirectionCombo().Value) == 1;
        result = Utils.MakeContactsOrderBy(result, sortedFieldName, isDescending);
        return result.ToList();
    }

    IQueryable<Contact> ApplySearch(IQueryable<Contact> contacts) {
        var text = SearchText.ToLower();
        return contacts.Where(c => 
            c.Name != null && c.Name.ToLower().Contains(text) ||
            c.Address != null && c.Address.ToLower().Contains(text) ||
            c.City != null && c.City.ToLower().Contains(text) ||
            c.Country != null && c.Country.ToLower().Contains(text)
        );
    }
    ASPxRadioButtonList FindAddressBookList() {
        return ContactViewBar.Groups.FindByName("AddressBooks").FindControl("AddressBookList") as ASPxRadioButtonList;
    }

    ASPxComboBox FindSortByCombo() {
        return ContactViewBar.Groups.FindByName("Sort").FindControl("SortByCombo") as ASPxComboBox;
    }

    ASPxComboBox FindSortDirectionCombo() {
        return ContactViewBar.Groups.FindByName("Sort").FindControl("SortDirectionCombo") as ASPxComboBox;
    }

    protected string GetContactImageUrl(CardViewCardBaseTemplateContainer container) {
        var photoUrl = GetDataItemProperty<string>(container, "PhotoUrl");
        return Utils.GetContactPhotoUrl(photoUrl);
    }

    protected void EditContactImage_Load(object sender, EventArgs e) {
        PrepareContactCommandImage((ASPxImage)sender);
    }

    protected void DeleteContactImage_Load(object sender, EventArgs e) {
        PrepareContactCommandImage((ASPxImage)sender);
    }

    protected void PrepareContactCommandImage(ASPxImage image) {
        var container = (CardViewCardBaseTemplateContainer)image.NamingContainer;
        image.JSProperties["cpContactKey"] = GetDataItemProperty<int>(container, "ID");
    }

    T GetDataItemProperty<T>(CardViewCardBaseTemplateContainer container, string propertyName) {
        var dataRow = (WebDescriptorRowBase)container.DataItem;
        return (T)dataRow[propertyName];
    }
}

using System;
using System.Data;
using System.Web.UI;
using DevExpress.Web;
using System.Linq;

public partial class ASPxComboBox_ClientAPI : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            CmbCountry.Value = "Mexico";
            FillCityCombo("Mexico");
        }
    }
    protected void CmbCity_Callback(object source, CallbackEventArgsBase e) {
        FillCityCombo(e.Parameter);
    }

    protected void FillCityCombo(string countryName) {
        if (string.IsNullOrEmpty(countryName)) return;

        using(var context = new WorldCitiesContext()) {
            var country = context.Countries.SingleOrDefault(c => c.CountryName == countryName);
            CmbCity.DataSource = context.Cities.Where(c => c.Country.CountryName == countryName).OrderBy(c => c.CityName).ToList();
            CmbCity.DataBind();
            CmbCity.Value = country.City.CityName;
        }
    }
}

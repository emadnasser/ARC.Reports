using System;
using System.Data;
using System.Collections.Generic;
using System.Web.UI;
using System.Linq;
using DevExpress.Web;


public partial class GridEditing_CascadingComboBoxes : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            grid.StartEdit(3);
    }

    protected void grid_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e) {
        if(!grid.IsEditing || e.Column.FieldName != "City") return;
        if(e.KeyValue == DBNull.Value || e.KeyValue == null) return;
        object val = grid.GetRowValuesByKeyValue(e.KeyValue, "Country");
        if(val == DBNull.Value) return;
        string country = (string)val;

        ASPxComboBox combo = e.Editor as ASPxComboBox;
        FillCityCombo(combo, country);

        combo.Callback += new CallbackEventHandlerBase(cmbCity_OnCallback);
    }

    protected void FillCityCombo(ASPxComboBox cmb, string country) {
        if(string.IsNullOrEmpty(country)) return;

        List<string> cities = GetCities(country);
        cmb.Items.Clear();
        foreach (string city in cities)
            cmb.Items.Add(city);
    }
    List<string> GetCities(string country) {
        using(var context = new WorldCitiesContext())
            return context.Cities.Where(c => c.Country.CountryName == country).OrderBy(c => c.CityName).Select(c => c.CityName).ToList();
    }

    void cmbCity_OnCallback(object source, CallbackEventArgsBase e) {
        FillCityCombo(source as ASPxComboBox, e.Parameter);
    }
}

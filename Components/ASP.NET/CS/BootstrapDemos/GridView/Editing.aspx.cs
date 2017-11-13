using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class GridView_Editing : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            GridView1.StartEdit(1);
            GridView3.StartEdit(1);
            GridView4.StartEdit(3);
        }
    }
    protected void grid_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e) {
        ASPxGridView grid = (ASPxGridView)sender;
        if(!grid.IsEditing || e.Column.FieldName != "City")
            return;
        if(e.KeyValue == DBNull.Value || e.KeyValue == null)
            return;
        object val = grid.GetRowValuesByKeyValue(e.KeyValue, "Country");
        if(val == DBNull.Value)
            return;
        string country = (string)val;

        ASPxComboBox combo = e.Editor as ASPxComboBox;
        FillCityCombo(combo, country);

        combo.Callback += new CallbackEventHandlerBase(cmbCity_OnCallback);
    }

    protected void FillCityCombo(ASPxComboBox cmb, string country) {
        if(string.IsNullOrEmpty(country))
            return;

        List<string> cities = GetCities(country);
        cmb.Items.Clear();
        foreach(string city in cities)
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

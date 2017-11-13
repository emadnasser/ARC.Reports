using System;
using System.Web.UI;


public partial class HiddenField_Example : Page {
    enum ViewType { season, month, preview };
    static string[] seasons = new string[4] { 
        "Winter", "Spring", "Summer", "Autumn" 
    };
    static string[][] months = new string[4][] { 
        new string[]{ "December", "January", "February" },
        new string[]{ "March", "April", "May" }, 
        new string[]{ "June", "July", "August" }, 
        new string[]{ "September", "October", "November" } 
    };

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            ResetAnswers();
        LoadView();
    }

    protected void btnSubmit_Click(object sender, EventArgs e) {
        Response.Redirect(Request.Url.PathAndQuery, true);
    }

    void LoadView() {
        mvVoting.ActiveViewIndex = (int)hfAnswers["questionIndex"];
        switch((ViewType)mvVoting.ActiveViewIndex) {
            case ViewType.season:
                LoadSeasons();
                break;
            case ViewType.month:
                LoadMonths();
                break;
            case ViewType.preview:
                LoadPreview();
                break;
        }
    }

    void LoadSeasons() {
        rblSeasons.Items.Clear();
        rblSeasons.Items.AddRange(seasons);
        rblSeasons.SelectedIndex = (int)hfAnswers["season"];
    }

    void LoadMonths() {
        rblMonths.Items.Clear();
        rblMonths.Items.AddRange(months[(int)hfAnswers["season"]]);
        rblMonths.SelectedIndex = (int)hfAnswers["month"];
    }

    void LoadPreview() {
        int seasonIndex = (int)hfAnswers["season"];
        int monthIndex = (int)hfAnswers["month"];
        lblSelectedSeason.Text = seasons[seasonIndex];
        lblSelectedMonth.Text = months[seasonIndex][monthIndex];
    }

    void ResetAnswers() {
        hfAnswers["questionIndex"] = 0;
        hfAnswers["season"] = 0;
        hfAnswers["month"] = 0;
    }
}

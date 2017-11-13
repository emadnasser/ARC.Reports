using System;
using EventRegistration;
using System.Globalization;
using System.Web.Script.Serialization;

public partial class Registration : System.Web.UI.Page {
    const string RegistrationDataFieldName = "RegData";
    protected void Page_Load(object sender, EventArgs e) {
        if(CurrentData.RegistrationInfo.Completed)
            InitAlreadyRegistred();
        else {
            if(IsCallback)
                DeserializeData();

            if(pc.ActiveTabPage.Name == "Confirmation") {
                if(CurrentData.RegistrationDate.Millisecond == 0)
                    CurrentData.RegistrationDate = DateTime.Now;
                LoadRegInfo();
            }

            if(pc.ActiveTabPage.Name == "Finish")
                CurrentData.RegistrationInfo.Completed = true;

            SerializeData();
        }
    }
    PersonalData GetDataFromHiddenField(JavaScriptSerializer serializer) {
        return serializer.Deserialize<PersonalData>(hfRegInfo.Get(RegistrationDataFieldName) as string);
    }
    void DeserializeData() {
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        CurrentData.RegistrationInfo = GetDataFromHiddenField(serializer);
    }
    void SerializeData() {
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        hfRegInfo.Set(RegistrationDataFieldName, serializer.Serialize(CurrentData.RegistrationInfo));
    }
    void InitAlreadyRegistred() {
        LoadRegInfo();
        pc.ActiveTabPage = pc.TabPages[2];
        pc.ShowTabs = false;
        pc.TabPages[0].ClientEnabled = false;
        pc.TabPages[1].ClientEnabled = false;
        pc.TabPages[3].ClientEnabled = false;
        btnBack.Visible = false;
        btnNext.Visible = false;
        btnFinish.Visible = false;
        lblConfimInfo.Text = "You are already registered";
        pc.CssClass += " alreadyRegistered";
    }
    void LoadRegInfo() {
        PersonalData regData = CurrentData.RegistrationInfo;
        lblConfirmRegistrant.Text = string.Format("{0} ({1})", regData.FullName, regData.CompanyName);
        lblConfirmAddress.Text = string.Format("{0}, {1}", regData.City, regData.Address);
        lblConfirmPhone.Text = regData.Phone;
        lblConfirmMail.Text = regData.Email;
        lblRegDate.Text = CurrentData.RegistrationDate.ToString("g", CultureInfo.CreateSpecificCulture("en-us"));
    }
    protected void pc_Init(object sender, EventArgs e) {
        InitRegistrationFields();
    }
    protected void InitRegistrationFields() {
        for(int year = DateTime.Now.Year; year - DateTime.Now.Year < 10; year++)
            cmbCardYear.Items.Add(year.ToString(), year);
    }

    protected void btnGoToSchedule_Click(object sender, EventArgs e) {
        Response.Redirect("~/Schedule.aspx");
    }
}

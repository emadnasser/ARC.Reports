using System;
using System.Collections.Generic;
using System.Linq;
using EventRegistration;
using System.IO;

public partial class _Default : System.Web.UI.Page {
    FeaturedSessionsRotator SessionsRotator { get { return CurrentData.FeaturedSessionsRotator; } }
    protected void Page_Load(object sender, EventArgs e) {
        doRegister.Visible = !CurrentData.RegistrationInfo.Completed;
        
        repeaterStar.DataSource = GetRandomShowsStars();
        repeaterStar.DataBind();

        ShowFeaturedSession(SessionsRotator.Current);
    }
    protected void btnRegister_Click(object sender, EventArgs e) {
        Response.Redirect("~/Registration.aspx");
    }
    protected string GetStarPhotoUrl(string photoFileName) {
        return ResolveClientUrl(Path.Combine(DataHelper.StarsPhotoFolder, photoFileName));
    }
    IEnumerable<Speaker> GetRandomShowsStars() {
        return DataHelper.Data.Speakers.OrderBy(speaker => Guid.NewGuid()).Take(2);
    }
    protected void ShowFeaturedSession(Session session) {
        lblPreviewTitle.Text = session.Subject;
        lblPreviewDescription.Text = session.Description;
        lblPreviewSpeakerName.Text = session.Speaker;
        lblPreviewSpeakerDescr.Text = session.SpeakerDescription;
        if(session.Image != string.Empty)
            imgSessionPreview.ImageUrl = Path.Combine(DataHelper.FeaturedSessionsFolder, session.Image);
        btnAttendSession.PostBackUrl = "~/Schedule.aspx?attend=" + session.Id;
    }
    protected void ASPxCallbackPanel1_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e) {
        Session featuredSession = null;
        switch(e.Parameter) {
            case "Next":
                featuredSession = SessionsRotator.Next;
                break;
            case "Prev":
                featuredSession = SessionsRotator.Prev;
                break;
            default:
                throw new NotImplementedException();
        }
        ShowFeaturedSession(featuredSession);
    }
}

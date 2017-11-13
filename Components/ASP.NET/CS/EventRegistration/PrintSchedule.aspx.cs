using System;
using System.Collections.Generic;
using System.Linq;
using EventRegistration;

public partial class PrintSchedule : System.Web.UI.Page {
    public List<Session> AllSessions {
        get {
            return CurrentData.Sessions.ToList();
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsCallback)
            CurrentData.PrintingStatus = null;
        ReportViewer1.Report = new ScheduleReport(SelectAppointments(CurrentData.PrintingStatus));
    }

    List<Session> SelectAppointments(string print) {
        if(print == "All")
            return AllSessions;

        List<Session> selectedSessions = new List<Session>();
        selectedSessions = AllSessions.FindAll(s => s.Interest >= 1);
        return selectedSessions.Count == 0
            ? AllSessions
            : selectedSessions;
    }
    protected void cbChangePrintingStatus_Callback(object source, DevExpress.Web.CallbackEventArgs e) {
        CurrentData.PrintingStatus = e.Parameter;
    }
}

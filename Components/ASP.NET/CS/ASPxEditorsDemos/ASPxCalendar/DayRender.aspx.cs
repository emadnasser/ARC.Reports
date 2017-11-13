using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.UI;
using System.Xml;
using System.Web;
using DevExpress.Web;
using System.Drawing;

public partial class ASPxCalendar_DayRender : Page {
    XmlDocument xml;

    protected void Page_Load(object sender, EventArgs e) {
        this.xml = new XmlDocument();
        this.xml.Load(MapPath("~/App_Data/CalendarNotes.xml"));
    }

    protected void ASPxCalendar_DayCellInitialize(object sender, CalendarDayCellInitializeEventArgs e) {
        if(GetNoteNodes(e.Date).Count > 0) {
            e.IsWeekend = false;
            e.NavigateUrl = string.Format("javascript:ShowNotes('{0}')", GetDateString(e.Date));
        } else {
            e.IsWeekend = true;
        }        
    }

    protected void ASPxCalendar_DayCellPrepared(object sender, CalendarDayCellPreparedEventArgs e) {
        if(GetNoteNodes(e.Date).Count > 0) {
            e.TextControl.ForeColor = Color.Black;
            e.TextControl.Font.Bold = true;
        }
    }

    protected void ASPxCallback1_Callback(object source, DevExpress.Web.CallbackEventArgs e) {
        e.Result = GetNote(e.Parameter);
    }

    string GetDateString(DateTime date) {
        return date.ToString("M/d/yyyy", CultureInfo.InvariantCulture);
    }

    string GetNote(string dateString) {
        List<string> list = new List<string>();
        foreach(XmlNode node in GetNoteNodes(dateString)) {
            list.Add(HttpUtility.HtmlEncode(node.Attributes["Text"].Value));
        }
        return dateString + "|" + String.Join("<br/><br/>", list.ToArray());
    }

    XmlNodeList GetNoteNodes(DateTime date) {
        return GetNoteNodes(GetDateString(date));
    }

    XmlNodeList GetNoteNodes(string dateString) {
        return this.xml.SelectNodes(string.Format("//Notes/Note[@Date='{0}']", dateString));
    }
}

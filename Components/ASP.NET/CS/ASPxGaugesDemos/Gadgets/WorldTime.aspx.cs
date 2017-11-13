using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.ASPxGauges;
using DevExpress.Web.ASPxGauges.Base;
using DevExpress.XtraGauges.Core.Model;

public partial class Gadgets_WorldTime : Page {
    Dictionary<string, int> timeShifts;
    protected void Page_Load(object sender, EventArgs e) {
        timeShifts = new Dictionary<string, int>();
        timeShifts.Add("Washington", -4);
        timeShifts.Add("Paris", +1);
        timeShifts.Add("Moscow", +4);
        timeShifts.Add("London", +0);
        timeShifts.Add("Tokyo", +9);
        timeShifts.Add("Rome", +1);
        UpdateWorldTime();        
    }
    protected void OnTimerCallback(object source, CallbackEventArgsBase e) {
        UpdateWorldTime();
    }
    protected void UpdateWorldTime() {
        UpdateClock(Washington);
        UpdateClock(Paris);
        UpdateClock(Moscow);
        UpdateClock(London);
        UpdateClock(Tokyo);
        UpdateClock(Rome);
    }
    //
    protected void UpdateClock(ASPxGaugeControl gaugeControl) {
        DateTime time = DateTime.UtcNow.AddHours(timeShifts[gaugeControl.ID]);
        ICircularGauge cGauge = gaugeControl.Gauges[0] as ICircularGauge;
        if(cGauge != null) {
            UpdateScales(time, cGauge.Scales[0], cGauge.Scales[1]);
        }
    }
    protected void UpdateScales(DateTime dt, IArcScale h, IArcScale m) {
        int hour = dt.Hour < 12 ? dt.Hour : dt.Hour - 12;
        int min = dt.Minute;
        int sec = dt.Second;
        h.Value = (float)hour + (float)(min) / 60.0f;
        m.Value = ((float)min + (float)(sec) / 60.0f) / 5f;
    }
}

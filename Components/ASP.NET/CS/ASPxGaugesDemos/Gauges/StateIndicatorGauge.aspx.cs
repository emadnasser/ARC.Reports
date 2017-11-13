using System;
using System.Web.UI;
using DevExpress.Web;

public partial class StateIndicatorGaugePage : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsCallback) {
            indicator1.StateIndex = (int)state1.Number;
            indicator2.StateIndex = (int)state2.Number;
            indicator3.StateIndex = (int)state3.Number;
            indicator4.StateIndex = (int)state4.Number;
            indicator5.StateIndex = (int)state5.Number;
            indicator6.StateIndex = (int)state6.Number;
        }
    }
    protected void OnGauge1CustomCallback(object source, CallbackEventArgsBase e) {
        indicator1.StateIndex = (int)state1.Number;
    }
    protected void OnGauge2CustomCallback(object source, CallbackEventArgsBase e) {
        indicator2.StateIndex = (int)state2.Number;
    }
    protected void OnGauge3CustomCallback(object source, CallbackEventArgsBase e) {
        indicator3.StateIndex = (int)state3.Number;
    }
    protected void OnGauge4CustomCallback(object source, CallbackEventArgsBase e) {
        indicator4.StateIndex = (int)state4.Number;
    }
    protected void OnGauge5CustomCallback(object source, CallbackEventArgsBase e) {
        indicator5.StateIndex = (int)state5.Number;
    }
    protected void OnGauge6CustomCallback(object source, CallbackEventArgsBase e) {
        indicator6.StateIndex = (int)state6.Number;
    }
}

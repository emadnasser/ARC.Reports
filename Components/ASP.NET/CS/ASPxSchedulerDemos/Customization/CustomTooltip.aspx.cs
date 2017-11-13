using System;
using System.Web.UI;
using DevExpress.Web.ASPxScheduler.Internal;
using DevExpress.Web.ASPxScheduler;

public partial class Customization_CustomTooltip : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        /*
			The following code utilizes the DataHelper class, which is implemented
			solely for the ASPxScheduler Demo project.
			It is intended to hide unnecessary details and clarify the main idea.
			For the recommended data binding techniques, please refer to the
			Data Binding section modules:
			  ~/DataBinding/BoundMode.aspx for MS Access database
			  ~/DataBinding/ListBoundMode.aspx for the object with IBindingList interface.
			  ~/DataBinding/XPOBoundMode.aspx for XPO data framework.
		*/
        SchedulerDemoUtils.ApplyDefaults(this, ASPxScheduler1);
        SchedulerDemoUtils.ApplyWorkTime(this, ASPxScheduler1);
        DevExpress.Web.ASPxWebControl.RegisterBaseScript(Page);
        DataHelper.SetupDefaultMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource);
        DataHelper.SetupStatuses(ASPxScheduler1);
        DataHelper.SetupLabels(ASPxScheduler1);
        ASPxScheduler1.DataBind();
    }

    protected void OnSchedulerBeforeExecuteCallbackCommand(object sender, DevExpress.Web.ASPxScheduler.SchedulerCallbackCommandEventArgs e) {
        if(e.CommandId == "EnableToolTipCallback") {
            e.Command = new EnableToolTipCallback(ASPxScheduler1);
        }
    }
}
public class EnableToolTipCallback : SchedulerCallbackCommand {
    public EnableToolTipCallback(ASPxScheduler control)
        : base(control) {
    }
    public override void Execute(string parameters) {
        base.Execute(parameters);
        string[] args = parameters.Split(new char[] { '=' });
        if(args[0] == "selection") {
            if(args[1] == "false")
                Control.OptionsToolTips.ShowSelectionToolTip = false;
            else if(args[1] == "true")
                Control.OptionsToolTips.ShowSelectionToolTip = true;
        } else if(args[0] == "appointment") {
            if(args[1] == "false")
                Control.OptionsToolTips.ShowAppointmentToolTip = false;
            else if(args[1] == "true")
                Control.OptionsToolTips.ShowAppointmentToolTip = true;
        } else if(args[0] == "drag") {
            if(args[1] == "false")
                Control.OptionsToolTips.ShowAppointmentDragToolTip = false;
            else if(args[1] == "true")
                Control.OptionsToolTips.ShowAppointmentDragToolTip = true;
        }
        Control.ApplyChanges(ASPxSchedulerChangeAction.All);
    }

    public override string Id {
        get { return "EnableToolTipCallback"; }
    }

    protected override void ParseParameters(string parameters) {
        //do nothing
    }

    protected override void ExecuteCore() {
        //do nothing
    }
}

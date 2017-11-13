using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;
using DevExpress.Web;

public partial class UserForms_CustomSelectionTooltip : ASPxSchedulerToolTipBase {
    public override string ClassName { get { return "ASPxClientSelectionToolTip"; } }
    public override bool ToolTipShowStem { get { return false; } }
    public override bool ToolTipResetPositionByTimer { get { return false; } }
    //public override bool ToolTipCloseOnClick { get { return true; } }

    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);
    }
    protected override Control[] GetChildControls() {
        Control[] controls = new Control[] { lblInterval, tbSubject, btnCreate, lblShowMenu, imgCloseButton};
        return controls;
    }
}

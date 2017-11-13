using System;
using System.Web.UI;
using DevExpress.Web;
using System.Web.UI.WebControls;

public partial class PopupControl_Features : Page {
    const int defaulOpacity = 100;
    PopupHorizontalAlign CurrentPopupHorizontalAlign {
        get {
            return (PopupHorizontalAlign)Enum.Parse(typeof(PopupHorizontalAlign),
                ddlPopupHorizontalAlign.SelectedItem.Value.ToString());
        }
    }

    PopupVerticalAlign CurrentPopupVerticalAlign {
        get {
            return (PopupVerticalAlign)Enum.Parse(typeof(PopupVerticalAlign),
                ddlPopupVerticalAlign.SelectedItem.Value.ToString());
        }
    }

    DragElement CurrentDragElement {
        get {
            return (DragElement)Enum.Parse(typeof(DragElement),
                ddlDragElement.SelectedItem.Value.ToString());
        }
    }

    ResizingMode CurrentResizingMode {
        get {
            return (ResizingMode)Enum.Parse(typeof(ResizingMode),
                ddlResizeMode.SelectedItem.Value.ToString());
        }
    }

    ShowSizeGrip CurrentShowSizeGripMode {
        get {
            return (ShowSizeGrip)Enum.Parse(typeof(ShowSizeGrip),
                ddlShowSizeGrip.SelectedItem.Value.ToString());
        }
    }

    CloseAction CurrentCloseAction {
        get {
            return (CloseAction)Enum.Parse(typeof(CloseAction),
                ddlCloseAction.SelectedItem.Value.ToString());
        }
    }

    PopupAction CurrentPopupAction {
        get {
            return (PopupAction)Enum.Parse(typeof(PopupAction),
                ddlPopupAction.SelectedItem.Value.ToString());
        }
    }

    ScrollBars CurrentScrollBars {
        get {
            return (ScrollBars)Enum.Parse(typeof(ScrollBars),
                ddlScrollBars.SelectedItem.Value.ToString());
        }
    }

    AnimationType CurrentPopupAnimationType {
        get {
            return (AnimationType)Enum.Parse(typeof(AnimationType),
                ddlPopupAnimationType.SelectedItem.Value.ToString());
        }
    }
    AnimationType CurrentCloseAnimationType {
        get {
            return (AnimationType)Enum.Parse(typeof(AnimationType),
                ddlCloseAnimationType.SelectedItem.Value.ToString());
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            return;
        pcMain.Width = 330;
        pcMain.Height = 250;
        pcMain.AllowDragging = cbAllowDragging.Checked;
        pcMain.ShowCloseButton = cbShowCloseButton.Checked;
        pcMain.ShowFooter = cbShowFooter.Checked;
        pcMain.ShowHeader = cbShowHeader.Checked;
        pcMain.ShowShadow = cbShowShadow.Checked;
        pcMain.AllowResize = cbAllowResize.Checked;
        pcMain.PopupHorizontalAlign = CurrentPopupHorizontalAlign;
        pcMain.PopupVerticalAlign = CurrentPopupVerticalAlign;
        pcMain.DragElement = CurrentDragElement;
        pcMain.ResizingMode = CurrentResizingMode;
        pcMain.ShowSizeGrip = CurrentShowSizeGripMode;
        pcMain.CloseAction = CurrentCloseAction;
        pcMain.CloseOnEscape = cbCloseOnEscape.Checked;
        pcMain.PopupAction = CurrentPopupAction;
        pcMain.ScrollBars = CurrentScrollBars;
        pcMain.PopupAnimationType = CurrentPopupAnimationType;
        pcMain.CloseAnimationType = CurrentCloseAnimationType;
    }

    protected void ddlCloseAction_SelectedIndexChanged(object sender, EventArgs e) {
        hlHide.Visible = pcMain.CloseAction == CloseAction.None;
    }

    protected void ddlPopupAction_SelectedIndexChanged(object sender, EventArgs e) {
        hlShow.Visible = pcMain.PopupAction == PopupAction.None;
        lblCursor.Style[HtmlTextWriterStyle.Cursor] = hlShow.Visible ?
            string.Empty : "pointer";
    }

    protected void ddlScrollBars_SelectedIndexChanged(object sender, EventArgs e) {
        if(CurrentScrollBars == ScrollBars.Horizontal)
            pcMain.Height = Unit.Empty;
        if(CurrentScrollBars == ScrollBars.Vertical)
            pcMain.Width = 372;
    }

    protected void Button1_Click(object sender, EventArgs e) {
        int result = 0;

        lblPopupHorizontalOffsetError.Visible = 
            !int.TryParse(tbPopupHorizontalOffset.Text, out result);
        if(!lblPopupHorizontalOffsetError.Visible)
            pcMain.PopupHorizontalOffset = result;

        lblPopupVerticalOffsetError.Visible = 
            !int.TryParse(tbPopupVerticalOffset.Text, out result);
        if(!lblPopupVerticalOffsetError.Visible)
            pcMain.PopupVerticalOffset = result;

        lblAppearAfterError.Visible = 
            !int.TryParse(tbAppearAfter.Text, out result) || result < 0;
        if(!lblAppearAfterError.Visible) 
            pcMain.AppearAfter = result;

        lblDisappearAfterError.Visible =
            !int.TryParse(tbDisappearAfter.Text, out result) || result < 0;
        if(!lblDisappearAfterError.Visible) 
            pcMain.DisappearAfter = result;

        lblOpacityError.Visible = 
            !int.TryParse(tbOpacity.Text, out result) || result < 0 || result > 100;
        if(!lblOpacityError.Visible) 
            pcMain.Opacity = result;
    }

}

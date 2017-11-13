using System;
using DevExpress.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewsControl_Features : Page {

    PagerEllipsisMode CurrentEllipsisMode {
        get {
            return (PagerEllipsisMode)Enum.Parse(typeof(PagerEllipsisMode), 
                ddlEllipsisMode.SelectedItem.Value.ToString());
        }
    }

    PagerPosition CurrentPagerPosition {
        get {
            return (PagerPosition)Enum.Parse(typeof(PagerPosition),
                ddlPosition.SelectedItem.Value.ToString());
        }
    }

    PagerPageSizePosition CurrentPageSizePosition {
        get {
            return (PagerPageSizePosition)Enum.Parse(typeof(PagerPageSizePosition),
                ddlPageSizeItemPosition.SelectedItem.Value.ToString());
        }
    }

    DataViewEndlessPagingMode CurrentEndlessPagingMode {
        get {
            return (DataViewEndlessPagingMode)Enum.Parse(typeof(DataViewEndlessPagingMode),
                cbEndlessPagerMode.SelectedItem.Value.ToString());
        }
    }

    DateHorizontalPosition CurrentDateHorizontalPosition {
        get {
            return (DateHorizontalPosition)Enum.Parse(typeof(DateHorizontalPosition),
                ddlDateHorizontalPosition.SelectedItem.Value.ToString());
        }
    }

    DateVerticalPosition CurrentDateVerticalPosition {
        get {
            return (DateVerticalPosition)Enum.Parse(typeof(DateVerticalPosition),
                ddlDateVerticalPosition.SelectedItem.Value.ToString());
        }
    }

    HeadlineImagePosition CurrentImagePosition {
        get {
            return (HeadlineImagePosition)Enum.Parse(typeof(HeadlineImagePosition),
                ddlImagePosition.SelectedItem.Value.ToString());
        }
    }

    TailImagePosition CurrentTailImagePosition {
        get {
            return (TailImagePosition)Enum.Parse(typeof(TailImagePosition),
                ddlTailImagePosition.SelectedItem.Value.ToString());
        }
    }

    TailPosition CurrentTailPosition {
        get {
            return (TailPosition)Enum.Parse(typeof(TailPosition),
                ddlTailPosition.SelectedItem.Value.ToString());
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        SetProperties();
    }

    protected void Button1_Click(object sender, EventArgs e) {
        int result = 0;
        lblMaxLengthError.Visible = !int.TryParse(tbMaxLength.Text, out result) || result < 0;
        if(!lblMaxLengthError.Visible)
            newsControl.ItemSettings.MaxLength = result;
    }

    void SetProperties() {
        newsControl.ShowBackToTop = cbShowBackToTop.Checked;
        newsControl.PagerSettings.ShowDisabledButtons = cbShowDisabledButtons.Checked;
        newsControl.PagerSettings.ShowNumericButtons = cbShowNumericButtons.Checked;
        newsControl.PagerSettings.ShowSeparators = cbShowSeparators.Checked;
        newsControl.PagerSettings.PageSizeItemSettings.Visible = cbShowPageSizeItem.Checked;
        newsControl.PagerSettings.PageSizeItemSettings.Position = CurrentPageSizePosition;
        newsControl.PagerSettings.EndlessPagingMode = CurrentEndlessPagingMode;
        newsControl.ItemSettings.ShowContentAsLink = cbShowContentAsLink.Checked;
        newsControl.ItemSettings.ShowContentInToolTip = cbShowContentInToolTip.Checked;
        newsControl.ItemSettings.ShowHeaderAsLink = cbShowHeaderAsLink.Checked;
        newsControl.ItemSettings.ShowImageAsLink = cbShowImageAsLink.Checked;
        newsControl.PagerSettings.EllipsisMode = CurrentEllipsisMode;
        newsControl.PagerSettings.Position = CurrentPagerPosition;
        newsControl.ItemSettings.DateHorizontalPosition = CurrentDateHorizontalPosition;
        newsControl.ItemSettings.DateVerticalPosition = CurrentDateVerticalPosition;
        newsControl.ItemSettings.ImagePosition = CurrentImagePosition;
        newsControl.ItemSettings.TailImagePosition = CurrentTailImagePosition;
        newsControl.ItemSettings.TailPosition = CurrentTailPosition;

        if(cbShowPageSizeItem.Checked)
            newsControl.PagerAlign = DevExpress.Web.PagerAlign.Justify;
    }

}

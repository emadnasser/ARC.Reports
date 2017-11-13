using System;
using System.Web.UI;
using DevExpress.Web;

public partial class ImageSlider_Features : Page {
    bool CurrentEnableLoopNavigation {
        get { return chEnableLoopNavigation.Checked; }
        set { chEnableLoopNavigation.Checked = value; }
    }
    bool CurrentNavigationBarVisible {
        get { return chShowNavigationBar.Checked; }
        set { chShowNavigationBar.Checked = value; }
    }
    ElementVisibilityMode CurrentItemTextVisibility {
        get { return (ElementVisibilityMode)ddlItemTextVisibility.Value; }
        set { ddlItemTextVisibility.Value = (int)value; }
    }
    NavigationBarPosition CurrentNavigationBarPosition {
        get { return (NavigationBarPosition)ddlNavigationBarPosition.Value; }
        set { ddlNavigationBarPosition.Value = (int)value; }
    }
    NavigationBarMode CurrentNavigationBarMode {
        get { return (NavigationBarMode)ddlThumbnailBarMode.Value; }
        set { ddlThumbnailBarMode.Value = (int)value; }
    }
    NavigationBarPagingMode CurrentNavigationBarPagingMode {
        get { return (NavigationBarPagingMode)ddlNavigationBarPagingMode.Value; }
        set { ddlNavigationBarPagingMode.Value = (int)value; }
    }
    ElementVisibilityMode CurrentNavigationButtonVisibilityMode {
        get { return (ElementVisibilityMode)ddlNavigationButtonsVisibility.Value; }
        set { ddlNavigationButtonsVisibility.Value = (int)value; }
    }
    ElementVisibilityMode CurrentNbNavigationButtonVisibilityMode {
        get { return (ElementVisibilityMode)ddlNbNavigationButtonsVisibility.Value; }
        set { ddlNbNavigationButtonsVisibility.Value = (int)value; }
    }
    ThumbnailNavigationBarButtonPosition CurrentThumbnailsNavigationButtonPosition {
        get { return (ThumbnailNavigationBarButtonPosition)ddlNbNavigationButtonsPosition.Value; }
        set { ddlNbNavigationButtonsPosition.Value = (int)value; }
    }
    AnimationType CurrentAnimationType {
        get { return (AnimationType)ddlAnimationType.Value; }
        set { ddlAnimationType.Value = (int)value; }
    }
    NavigationDirection CurrentNavigationDirection {
        get { return (NavigationDirection)ddlNavigationDirection.Value; }
        set { ddlNavigationDirection.Value = (int)value; }
    }
    ImageSizeMode CurrentImageSizeMode {
        get { return (ImageSizeMode)ddlImageSizeMode.Value; }
        set { ddlImageSizeMode.Value = (int)value; }
    }
    bool EnablePagingGestures {
        get { return chEnablePagingGestures.Checked; }
        set { chEnablePagingGestures.Checked = value; }
    }
    bool AllowMouseWheel {
        get { return chAllowMouseWheel.Checked; }
        set { chAllowMouseWheel.Checked = value; }
    }
    AutoBoolean EnablePagingByClick {
        get { return (AutoBoolean)ddlEnablePagingByClick.Value; }
        set { ddlEnablePagingByClick.Value = (int)value; }
    }
    ImageLoadMode ImageLoadMode {
        get { return (ImageLoadMode)ddlImageLoadMode.Value; }
        set { ddlImageLoadMode.Value = (int)value; }
    }
    ExtremeItemClickMode CurretnExtremeItemClickMode {
        get { return (ExtremeItemClickMode)ddlExtremeItemClickMode.Value; }
        set { ddlExtremeItemClickMode.Value = (int)value; }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            SelectPredefinedScenario(1);
        UpdateImageSliderProperties();
    }

    protected void cbPredefinedScenarios_SelectedIndexChanged(object sender, EventArgs e) {
        SelectPredefinedScenario(Convert.ToInt32(cbPredefinedScenarios.Value));
        UpdateImageSliderProperties();
    }
    protected void GeneralValueChanged(object sender, EventArgs e) {
        cbPredefinedScenarios.Value = "(Custom)";
    }
    void SelectPredefinedScenario(int index) {
        switch(index) {
            case 1:
            CurrentAnimationType = AnimationType.Slide;
            CurrentNavigationDirection = NavigationDirection.Horizontal;
            CurrentImageSizeMode = ImageSizeMode.ActualSizeOrFit;
            CurrentNavigationButtonVisibilityMode = ElementVisibilityMode.OnMouseOver;
            CurrentItemTextVisibility = ElementVisibilityMode.OnMouseOver;

            CurrentNavigationBarVisible = true;
            CurrentNavigationBarMode = NavigationBarMode.Thumbnails;
            CurrentNavigationBarPosition = NavigationBarPosition.Bottom;
            CurrentNbNavigationButtonVisibilityMode = ElementVisibilityMode.OnMouseOver;
            break;
            case 2: // Fill and Crop, Dots
            CurrentNavigationDirection = NavigationDirection.Horizontal;
            CurrentImageSizeMode = ImageSizeMode.FillAndCrop;
            CurrentNavigationButtonVisibilityMode = ElementVisibilityMode.Always;
            CurrentItemTextVisibility = ElementVisibilityMode.Always;

            CurrentNavigationBarVisible = true;
            CurrentNavigationBarMode = NavigationBarMode.Dots;
            CurrentNavigationBarPosition = NavigationBarPosition.Bottom;
            break;
            case 3: // Vertical Scrolling
            CurrentAnimationType = AnimationType.Slide;
            CurrentNavigationDirection = NavigationDirection.Vertical;
            CurrentImageSizeMode = ImageSizeMode.FillAndCrop;
            CurrentNavigationButtonVisibilityMode = ElementVisibilityMode.Faded;
            CurrentItemTextVisibility = ElementVisibilityMode.None;

            CurrentNavigationBarVisible = true;
            CurrentNavigationBarMode = NavigationBarMode.Thumbnails;
            CurrentNavigationBarPosition = NavigationBarPosition.Left;
            CurrentNbNavigationButtonVisibilityMode = ElementVisibilityMode.Faded;
            break;
        }
    }
    void UpdateImageSliderProperties() {
        imageSlider.ShowNavigationBar = CurrentNavigationBarVisible;

        imageSlider.SettingsImageArea.EnableLoopNavigation = CurrentEnableLoopNavigation;
        imageSlider.SettingsImageArea.AnimationType = CurrentAnimationType;
        imageSlider.SettingsImageArea.NavigationDirection = CurrentNavigationDirection;
        imageSlider.SettingsImageArea.ImageSizeMode = CurrentImageSizeMode;
        imageSlider.SettingsImageArea.NavigationButtonVisibility = CurrentNavigationButtonVisibilityMode;
        imageSlider.SettingsImageArea.ItemTextVisibility = CurrentItemTextVisibility;

        imageSlider.SettingsNavigationBar.Position = CurrentNavigationBarPosition;
        imageSlider.SettingsNavigationBar.Mode = CurrentNavigationBarMode;
        imageSlider.SettingsNavigationBar.ThumbnailsModeNavigationButtonVisibility = CurrentNbNavigationButtonVisibilityMode;
        imageSlider.SettingsNavigationBar.PagingMode = CurrentNavigationBarPagingMode;
        imageSlider.SettingsNavigationBar.ThumbnailsNavigationButtonPosition = CurrentThumbnailsNavigationButtonPosition;

        imageSlider.SettingsBehavior.AllowMouseWheel = AllowMouseWheel;
        imageSlider.SettingsBehavior.EnablePagingByClick = EnablePagingByClick;
        imageSlider.SettingsBehavior.EnablePagingGestures = EnablePagingGestures;
        imageSlider.SettingsBehavior.ImageLoadMode = ImageLoadMode;
        imageSlider.SettingsBehavior.ExtremeItemClickMode = CurretnExtremeItemClickMode;
    }

}

using System;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Drawing;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;

public partial class Customization_CustomAppointments : System.Web.UI.Page {
    const int CustomImagesOccurenceIndex = 0;
    const int CustomImagesExceptionIndex = 1;
    const int CustomImagesBizTripIndex = 2;
    const int CustomImagesHolidayIndex = 3;
    const string ImagePath = "~/Content/CustomAppointments/";
    ImagePropertiesCollection customImages;

    public Customization_CustomAppointments() {
        this.customImages = CreateCustomImages();
    }

    bool IsCustomText { get { return chkCustomText.Checked; } }
    bool IsDefaultImages { get { return rbListCustomImages.SelectedIndex == 0; } }
    bool IsExternalImages { get { return rbListCustomImages.SelectedIndex == 1; } }
    bool IsCustomImages { get { return rbListCustomImages.SelectedIndex == 2; } }

    ImagePropertiesCollection CustomImages { get { return customImages; } }
    AppointmentDisplayOptions DisplayOptions { get { return ASPxScheduler1.ActiveView.GetAppointmentDisplayOptions(); } }

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
        DataHelper.SetupDefaultMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource);
        DataHelper.SetupStatuses(ASPxScheduler1);
        DataHelper.SetupLabels(ASPxScheduler1);
        ASPxScheduler1.DataBind();

        InitializeSchedulerControl();
    }
    protected void InitializeSchedulerControl() {
        if(IsExternalImages)
            InitializeExternalImages();
        ApplyOptions();
    }
    protected void ApplyOptions() {
        ASPxScheduler1.BeginUpdate();
        try {
            AppointmentDisplayOptions options = ASPxScheduler1.ActiveView.GetAppointmentDisplayOptions();
            options.TimeDisplayType = (AppointmentTimeDisplayType)cbTime.Value;
            options.StatusDisplayType = (AppointmentStatusDisplayType)cbStatus.Value;
            options.StartTimeVisibility = (AppointmentTimeVisibility)cbStartTime.Value;
            options.EndTimeVisibility = (AppointmentTimeVisibility)cbEndTime.Value;
            options.ContinueArrowDisplayType = (AppointmentContinueArrowDisplayType)cbContinueArrow.Value;
            options.ShowRecurrence = chkRecurrence.Checked;
        } finally {
            ASPxScheduler1.EndUpdate();
        }
        ASPxScheduler1.ApplyChanges(ASPxSchedulerChangeAction.RenderAppointments);
    }
    protected void InitializeExternalImages() {
        AppointmentImages images = ASPxScheduler1.Images.Appointment;
        images.DayClock.Url = ImagePath + "ExternalDayClock.png";
        images.NightClock.Url = ImagePath + "ExternalNightClock.png";
        images.Recurrence.Url = ImagePath + "ExternalRecurrence.png";
        images.NoRecurrence.Url = ImagePath + "ExternalException.png";
    }
    protected ImagePropertiesCollection CreateCustomImages() {
        ImagePropertiesCollection images = new ImagePropertiesCollection();
        AddCustomImage(images, "CustomReccurence.png");
        AddCustomImage(images, "CustomException.png");
        AddCustomImage(images, "CustomBizTrip.png");
        AddCustomImage(images, "CustomHoliday.png");
        return images;
    }
    protected void AddCustomImage(ImagePropertiesCollection target, string fileName) {
        string url = ImagePath + fileName;
        ImageProperties image = new ImageProperties(url);
        image.Width = Unit.Pixel(15);
        image.Height = Unit.Pixel(15);
        target.Add(image);
    }
    protected void ASPxSchedulerControl1_InitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e) {
        if(IsCustomText) {
            Appointment apt = e.Appointment;
            e.Text = String.Format("[{0}] {1}", apt.Location, apt.Subject);
            e.Description = String.Format("Details: {0}", apt.Description);
        }
    }
    protected void ASPxSchedulerControl1_InitAppointmentImages(object sender, DevExpress.Web.ASPxScheduler.AppointmentImagesEventArgs e) {
        if(IsCustomImages) {
            Appointment apt = e.Appointment;
            DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfoCollection c = e.ImageInfoList;

            c.Clear();
            c.Images = CustomImages;

            if(e.Appointment.IsRecurring)
                AddRecurrentAppointmentImages(c, e.Appointment.IsException);
            else
                AddNotRecurrentAppointmentImages(c);

            if(DisplayOptions.ShowReminder && apt.HasReminder)
                AddImageByType(c, AppointmentImageType.Reminder);
        }
    }
    void AddNotRecurrentAppointmentImages(DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfoCollection c) {
        AddImageByIndex(c, CustomImagesBizTripIndex);
        AddImageByIndex(c, CustomImagesHolidayIndex);
    }
    void AddRecurrentAppointmentImages(DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfoCollection c, bool isException) {
        if(!DisplayOptions.ShowRecurrence)
            return;
        if(isException) {
            AddImageByIndex(c, CustomImagesExceptionIndex);
            AddImageByUrl(c, "~/Content/CustomAppointments/Warning.png", Unit.Pixel(24), Unit.Pixel(24));
        } else
            AddImageByIndex(c, CustomImagesOccurenceIndex);
    }
    void AddImageByIndex(DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfoCollection c, int index) {
        DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfo info = new DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfo();
        info.ImageIndex = index;
        c.Add(info);
    }
    void AddImageByUrl(DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfoCollection c, string url, Unit width, Unit height) {
        ImageProperties imageProperties = new ImageProperties(url);
        imageProperties.Width = width;
        imageProperties.Height = height;
        DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfo info = new DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfo();
        info.ImageProperties = imageProperties;
        c.Add(info);
    }
    void AddImageByType(DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfoCollection c, AppointmentImageType type) {
        c.AddStandard(type);
    }

    protected void ASPxScheduler1_ActiveViewChanged(object sender, EventArgs e) {
        ApplyOptions();
    }
}

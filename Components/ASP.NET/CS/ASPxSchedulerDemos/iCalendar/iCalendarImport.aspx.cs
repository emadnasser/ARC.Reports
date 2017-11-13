using System;
using System.IO;
using System.Web.UI;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;
using DevExpress.Web;
using DevExpress.XtraScheduler.iCalendar;

public partial class iCalendar_iCalendarImport : System.Web.UI.Page {
    #region Page_Load
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
        DataHelper.SetupCustomEventsMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource);
        DataSource1.AttachTo(ASPxScheduler1);
        
    }
    #endregion
    protected void ASPxUploadControl1_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e) {
        ASPxUploadControl uploadControl = (ASPxUploadControl)sender;
        UploadedFile uploadedFile = uploadControl.UploadedFiles[0];
        if(!IsFileNameCorrect(uploadedFile.FileName)) {
            e.IsValid = false;
            e.ErrorText = "Incorrect file type";
            return;
        }
        if(uploadedFile.IsValid)
            Session["UploadedFile"] = GetBytes(uploadedFile.FileContent);
    }
    protected void ASPxScheduler1_BeforeExecuteCallbackCommand(object sender, SchedulerCallbackCommandEventArgs e) {
        if(e.CommandId == ImportAppointmentsCallbackCommand.CommandId)
            e.Command = new ImportAppointmentsCallbackCommand((ASPxScheduler)sender);
    }
    #region IsFileNameCorrect
    bool IsFileNameCorrect(string fileName) {
        int length = fileName.Length;
        return fileName.Substring(length - 4, 4) == ".ics";
    }
    #endregion
    #region GetBytes
    byte[] GetBytes(Stream stream) {
        stream.Position = 0;
        byte[] buf = new byte[stream.Length];
        stream.Read(buf, 0, (int)stream.Length);
        return buf;
    }
    #endregion

    #region ImportAppointmentsCallbackCommand
    class ImportAppointmentsCallbackCommand : SchedulerCallbackCommand {
        public const string CommandId = "IMPRTAPT";

        public ImportAppointmentsCallbackCommand(ASPxScheduler control)
            : base(control) {
        }

        public override string Id { get { return CommandId; } }

        protected override void ParseParameters(string parameters) {
            // do nothing
        }
        protected override void ExecuteCore() {
            using(Stream stream = GetStream()) {
                if(stream == null)
                    return;
                iCalendar_iCalendarImport page = Control.Page as iCalendar_iCalendarImport;
                if(page != null && page.ASPxCheckBox1.Checked)
                    Control.Storage.Appointments.Clear();
                iCalendarImporter importer = new iCalendarImporter(Control.Storage);
                importer.Import(stream);
                Control.Page.Session["UploadedFile"] = null;
            }
        }
        Stream GetStream() {
            byte[] buf = Control.Page.Session["UploadedFile"] as byte[];
            if (buf == null)
                return null;
            Stream stream = new MemoryStream(buf);
            return stream;
        }
    }
    #endregion
}

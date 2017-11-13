using System;
using DevExpress.Utils.About;
using DevExpress.XtraReports.Web.Native.ClientControls.Services;

namespace DevExpress.Web.Demos {
    public class DemoLoggingService : ExtendedLoggingService {
        public DemoLoggingService() : base(() => DefaultLoggingService.Instance) { }
        public override void LogException(Exception exception, string message) {
            base.LogException(exception, message);
            UAlgo.Default.DoEventException(exception);
        }
    }
}

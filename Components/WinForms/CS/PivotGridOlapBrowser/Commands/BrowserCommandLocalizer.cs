using System;
using System.Collections.Generic;
using System.Text;

namespace PivotGridOlapBrowser.Commands {
    public class BrowserLocalizer {
        static BrowserLocalizer() {
        }
        public static string GetString(BrowserCommandStringId id) {
            switch(id) {
                case BrowserCommandStringId.Caption_ConnectTo:
                    return "Connect To...";
                case BrowserCommandStringId.Caption_CreateReport:
                    return "Create Report...";
                case BrowserCommandStringId.Caption_ShowChartFromPivot:
                    return "Show Chart From Pivot...";
                case BrowserCommandStringId.Caption_ShowTotals:
                    return "Show Totals";
                case BrowserCommandStringId.Caption_ShowSelection:
                    return "Show Selection Only";
                case BrowserCommandStringId.Caption_ChartViewSet:
                    return "Chart View: ";
                default:
                    return "Custom...";
            }
        }
        public static string GetString(BrowserStringId id) {
            switch(id) {
                case BrowserStringId.Msg_IsNotValid:
                    return "'{0}' is not a valid value for '{1}'";
                case BrowserStringId.Msg_InternalError:
                    return "An internal error occurred.";
                default:
                    return "An undefined error occurred.";
            }
        }
        public static string GetFailedString(BrowserCommandStringId id) {
            switch(id) {
                case BrowserCommandStringId.Caption_ConnectTo:
                    return "Failed to connect to the datasource.";
                case BrowserCommandStringId.Caption_ShowChartFromPivot:
                    return "This data can not be shown in a chart control.";
                default:
                    return "Unexpected exception.";
            }
        }
    }
}

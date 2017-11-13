using System;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Commands;

namespace PivotGridOlapBrowser.Commands.Services {
    #region Exceptions
    public static class Exceptions {
        public static void ThrowArgumentException(string propName, object val) {
            string valueStr = (val != null) ? val.ToString() : "null";
            string s = String.Format(BrowserLocalizer.GetString(BrowserStringId.Msg_IsNotValid), valueStr, propName);
            throw new ArgumentException(s);
        }
        public static void ThrowInternalException() {
            throw new Exception(BrowserLocalizer.GetString(BrowserStringId.Msg_InternalError));
        }
        public static void ThrowArgumentNullException(string propName) {
            throw new ArgumentNullException(propName);
        }
        public static void ThrowInvalidOperationException(BrowserStringId id) {
            throw new InvalidOperationException(BrowserLocalizer.GetString(id));
        }
    }
    #endregion

    #region IBrowserCommandFactoryService
    public interface IBrowserCommandFactoryService {
        BrowserCommand CreateCommand(BrowserCommandId id);
    }
    #endregion    

    #region BrowserCommandConstructorTable
    public class BrowserCommandConstructorTable : Dictionary<BrowserCommandId, ConstructorInfo> {
    }
    #endregion
    #region BrowserCommandFactoryService
    public class BrowserCommandFactoryService : IBrowserCommandFactoryService {
        #region Fields
        readonly PivotGridBrowser control;
        static readonly Type[] constructorParametersInterface = new Type[] { typeof(PivotGridBrowser) };
        readonly BrowserCommandConstructorTable commandConstructorTable;
        #endregion

        public BrowserCommandFactoryService(PivotGridBrowser control) {
            Guard.ArgumentNotNull(control, "control");
            this.control = control;
            this.commandConstructorTable = CreateCommandConstructorTable();
        }

        public PivotGridBrowser Control { get { return control; } }

        protected internal BrowserCommandConstructorTable CreateCommandConstructorTable() {
            BrowserCommandConstructorTable result = new BrowserCommandConstructorTable();
            PopulateConstructorTable(result);
            return result;
        }
        protected void AddCommandConstructor(BrowserCommandConstructorTable table, BrowserCommandId commandId, Type commandType) {
            ConstructorInfo ci = GetConstructorInfo(commandType);
            if (ci == null)
                Exceptions.ThrowArgumentException("commandType", commandType);
            table.Add(commandId, ci);
        }
        protected internal virtual ConstructorInfo GetConstructorInfo(Type commandType) {
            return commandType.GetConstructor(constructorParametersInterface);
        }
        protected internal virtual void PopulateConstructorTable(BrowserCommandConstructorTable table) {
            AddCommandConstructor(table, BrowserCommandId.ConnectTo, typeof(ConnectToCommand));
            AddCommandConstructor(table, BrowserCommandId.CreateReport, typeof(CreateReportCommand));
            AddCommandConstructor(table, BrowserCommandId.ShowChartFromPivot, typeof(ShowChartFromPivotCommand));
            AddCommandConstructor(table, BrowserCommandId.ShowTotals, typeof(ShowTotalsCommand));
            AddCommandConstructor(table, BrowserCommandId.ShowSelection, typeof(ShowSelectionCommand));
            AddCommandConstructor(table, BrowserCommandId.ChartViewSet, typeof(ChartViewSetCommand));
            AddCommandConstructor(table, BrowserCommandId.ChartView, typeof(ChartViewCommand));
        }

        #region ICommandFactoryService Members
        public virtual BrowserCommand CreateCommand(BrowserCommandId commandId) {
            ConstructorInfo ci = null;
            if (commandConstructorTable.TryGetValue(commandId, out ci))
                return (BrowserCommand)ci.Invoke(new object[] { Control });
            else {
                Exceptions.ThrowArgumentException("commandId", commandId);
                return null;
            }
        }
        #endregion
    }
    #endregion
}

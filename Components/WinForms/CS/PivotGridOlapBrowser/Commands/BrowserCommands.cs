using DevExpress.Utils;
using DevExpress.Utils.Commands;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PivotGridOlapBrowser.Commands {
    public enum BrowserStringId {
        Msg_IsNotValid,
        Msg_InternalError
    }
    public enum BrowserCommandStringId {
        Caption_None = -1,
        Caption_ConnectTo = 0,
        Caption_CreateReport = 1,
        Caption_ShowChartFromPivot = 2,
        Caption_ShowTotals = 3,
        Caption_ShowSelection = 4,
        Caption_ChartViewSet = 5,
        Caption_ChartView = 6
    }
    #region BrowserCommandId
    [Serializable, StructLayout(LayoutKind.Sequential), ComVisible(false)]
    public struct BrowserCommandId : IConvertToInt<BrowserCommandId>, IEquatable<BrowserCommandId> {
        public static readonly BrowserCommandId None = new BrowserCommandId(-1);
        public static readonly BrowserCommandId ConnectTo = new BrowserCommandId(0);
        public static readonly BrowserCommandId CreateReport = new BrowserCommandId(1);
        public static readonly BrowserCommandId ShowChartFromPivot = new BrowserCommandId(2);
        public static readonly BrowserCommandId ShowTotals = new BrowserCommandId(3);
        public static readonly BrowserCommandId ShowSelection = new BrowserCommandId(4);
        public static readonly BrowserCommandId ChartViewSet = new BrowserCommandId(5);
        public static readonly BrowserCommandId ChartView = new BrowserCommandId(6);
     

        readonly int id;

        public BrowserCommandId(int value) {
            this.id = value;
        }
        public override bool Equals(object obj) {
            return ((obj is BrowserCommandId) && (this.id == ((BrowserCommandId)obj).id));
        }
        public override int GetHashCode() {
            return id.GetHashCode();
        }
        public override string ToString() {
            return id.ToString();
        }
        public static bool operator ==(BrowserCommandId id1, BrowserCommandId id2) {
            return id1.id == id2.id;
        }
        public static bool operator !=(BrowserCommandId id1, BrowserCommandId id2) {
            return id1.id != id2.id;
        }

        #region IConvertToInt<BrowserCommandId> Members
        int IConvertToInt<BrowserCommandId>.ToInt() {
            return id;
        }
        BrowserCommandId IConvertToInt<BrowserCommandId>.FromInt(int value) {
            return new BrowserCommandId(value);
        }
        #endregion

        #region IEquatable<BrowserCommandId> Members
        public bool Equals(BrowserCommandId other) {
            return this.id == other.id;
        }
        #endregion
    }
    #endregion

    #region BrowserCommand (abstract class)
    public abstract class BrowserCommand : Command {
        readonly PivotGridBrowser control;
                
        public BrowserCommand(PivotGridBrowser control) {
            this.control = control;
        }
        public PivotGridBrowser Control { get { return control; } }
        public abstract BrowserCommandId Id { get; }
        public override string MenuCaption { get { return BrowserLocalizer.GetString(MenuCaptionStringId); } }
        public override string Description { get { return BrowserLocalizer.GetString(DescriptionStringId); } }
        public string CommandFailedString { get { return BrowserLocalizer.GetFailedString(MenuCaptionStringId); } }
        public override void Execute() {
            if(ExecuteCore() == false)
                OnCommandFailed();
        }
        public override void ForceExecute(ICommandUIState state) {
            // do nothing
        }
        protected internal abstract BrowserCommandStringId MenuCaptionStringId { get; }
        protected internal BrowserCommandStringId DescriptionStringId { get { return MenuCaptionStringId; } }
        protected internal abstract bool? ExecuteCore();
        protected override void UpdateUIStateCore(ICommandUIState state) {
            bool? isCommandActual = null;
            if(Control != null)
                isCommandActual = Control.GetIsCommandActual(Id);
            state.Enabled = isCommandActual == true;
            state.Visible = state.Enabled;
        }
        protected virtual void OnCommandFailed() {
            if(Control != null)
                Control.OnCommandFailed(Id, CommandFailedString);
        }
    }
    #endregion

    public class ConnectToCommand : BrowserCommand {
        public ConnectToCommand(PivotGridBrowser control) 
            : base(control) {
        }
        public override BrowserCommandId Id { get { return BrowserCommandId.ConnectTo; } }
        protected internal override BrowserCommandStringId MenuCaptionStringId { get { return BrowserCommandStringId.Caption_ConnectTo; } }
        protected internal override bool? ExecuteCore() {
            return Control.ShowConnectionDialog();
        }
        protected override void UpdateUIStateCore(ICommandUIState state) {
            state.Enabled = state.Visible = true;
        }
    }

    public class CreateReportCommand : BrowserCommand {
        public CreateReportCommand(PivotGridBrowser control)
            : base(control) {
        }
        public override BrowserCommandId Id { get { return BrowserCommandId.CreateReport; } }
        protected internal override BrowserCommandStringId MenuCaptionStringId { get { return BrowserCommandStringId.Caption_CreateReport; } }
        protected internal override bool? ExecuteCore() {
            return Control.ShowReport();
        }
    }

    public class ShowChartFromPivotCommand : BrowserCommand {
        public ShowChartFromPivotCommand(PivotGridBrowser control) 
            : base(control) {
        }
        public override BrowserCommandId Id { get { return BrowserCommandId.ShowChartFromPivot; } }
        protected internal override BrowserCommandStringId MenuCaptionStringId { get { return BrowserCommandStringId.Caption_ShowChartFromPivot; } }
        protected internal override bool? ExecuteCore() {
            return Control.ShowChartFromPivot();
        }
    }

    public class ShowTotalsCommand : BrowserCommand {
        public ShowTotalsCommand(PivotGridBrowser control)
            : base(control) {
        }
        public override BrowserCommandId Id { get { return BrowserCommandId.ShowTotals; } }
        protected internal override BrowserCommandStringId MenuCaptionStringId { get { return BrowserCommandStringId.Caption_ShowTotals; } }
        protected internal override bool? ExecuteCore() {
            return null;
        }
        protected override void UpdateUIStateCore(ICommandUIState state) {
            base.UpdateUIStateCore(state);
            state.Checked = Control.ShowTotals;
        }
    }

    public class ShowSelectionCommand : BrowserCommand {
        public ShowSelectionCommand(PivotGridBrowser control)
            : base(control) {
        }
        public override BrowserCommandId Id { get { return BrowserCommandId.ShowSelection; } }
        protected internal override BrowserCommandStringId MenuCaptionStringId { get { return BrowserCommandStringId.Caption_ShowSelection; } }
        protected internal override bool? ExecuteCore() {
            return null;
        }
        protected override void UpdateUIStateCore(ICommandUIState state) {
            base.UpdateUIStateCore(state);
            state.Enabled = Control.ShowSelection.HasValue;
            state.Checked = Control.ShowSelection == (bool?)true;
        }
    }

    public class ChartViewSetCommand : BrowserCommand {
        public ChartViewSetCommand(PivotGridBrowser control)
            : base(control) {
        }
        public override BrowserCommandId Id { get { return BrowserCommandId.ChartViewSet; } }
        protected internal override BrowserCommandStringId MenuCaptionStringId { get { return BrowserCommandStringId.Caption_ChartViewSet; } }
        protected internal override bool? ExecuteCore() {
            return null;
        }
    }

    public class ChartViewCommand : BrowserCommand {
        public ChartViewCommand(PivotGridBrowser control)
            : base(control) {
        }
        public override BrowserCommandId Id { get { return BrowserCommandId.ChartView; } }
        protected internal override BrowserCommandStringId MenuCaptionStringId { get { return BrowserCommandStringId.Caption_ChartView; } }
        protected internal override bool? ExecuteCore() {
            return null;
        }
        protected override void UpdateUIStateCore(ICommandUIState state) {
            base.UpdateUIStateCore(state);
            state.EditValue = Control.ChartViewType;
        }
    }
}

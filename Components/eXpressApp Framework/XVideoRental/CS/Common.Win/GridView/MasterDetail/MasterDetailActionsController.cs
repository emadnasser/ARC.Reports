using System;
using System.Collections.Generic;
using System.Linq;
using Common.Win;
using Common.Win.ColumnView.Design;
using Common.Win.Common;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraGrid;

[assembly: OnlineRepoLocation("http://goo.gl/ldvj1")]
[assembly: OnlineRepoLocation("http://goo.gl/0zfgc")]

namespace Common.Win.GridView.MasterDetail {
    public class MasterDetailActionsController : ViewController<ListView> {
        readonly Dictionary<string, BoolList> _enabledBoolLists = new Dictionary<string, BoolList>();
        readonly Dictionary<string, BoolList> _activeBoolLists = new Dictionary<string, BoolList>();


        bool _disposing;

        protected override void OnFrameAssigned() {
            base.OnFrameAssigned();
            Frame.Disposing += FrameOnDisposing;
        }

        void FrameOnDisposing(object sender, EventArgs eventArgs) {
            Frame.Disposing -= FrameOnDisposing;
            _disposing = true;
        }

        bool CanClone() {
            return !_disposing && GridListEditor != null && GridListEditor.Grid != null && GridListEditor.Grid.FocusedView != null && ((IMasterDetailColumnView)GridListEditor.Grid.FocusedView).Window == null;
        }

        void SubscribeToActionStateResultChange() {
            foreach (var action in GetActions(Frame).Where(@base => !IsExcluded(@base))) {
                ActionBase action1 = action;
                action.Enabled.ResultValueChanged += (sender, args) => {
                    if (CanClone())
                        CloneBoolList(action1.Id, action1.Enabled, _enabledBoolLists);
                };
                action.Active.ResultValueChanged += (sender, args) => {
                    if (CanClone())
                        CloneBoolList(action1.Id, action1.Active, _activeBoolLists);
                };
            }
        }

        IEnumerable<ActionBase> GetActions(Frame frame) {
            return frame.Controllers.Cast<Controller>().SelectMany(controller => controller.Actions);
        }

        protected override void OnDeactivated() {
            base.OnDeactivated();
            _activeBoolLists.Clear();
            _enabledBoolLists.Clear();
        }

        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            if(GridListEditor != null && GridListEditor.ColumnView is IMasterDetailColumnView) {
                var gridView = ((IMasterDetailColumnView)GridListEditor.ColumnView);
                if (gridView.MasterFrame == null && HasRules) {
                    if (((IModelListViewMasterDetail)View.Model).MasterDetails.SynchronizeActions) {
                        SubscribeToActionStateResultChange();
                        PushExecutionToNestedFrame();
                        if (HasRules && gridView.MasterFrame == null) {
                            CloneActionState(Frame, _activeBoolLists, _enabledBoolLists);
                            GridListEditor.ColumnView.GridControl.FocusedViewChanged += OnFocusedViewChanged;
                        }
                    }
                }
            }

        }

        void OnFocusedViewChanged(object sender, ViewFocusEventArgs e) {
            if (GridListEditor != null) {
                Frame frame = Frame;
                var activeBoolLists = new Dictionary<string, BoolList>();
                var enableBoolLists = new Dictionary<string, BoolList>();
                if(GridListEditor.Grid.MainView != e.View && GridListEditor.Grid.FocusedView != null) {
                    frame = ((IMasterDetailColumnView)GridListEditor.Grid.FocusedView).Window;
                }
                CloneActionState(frame, activeBoolLists, enableBoolLists);
                if (GridListEditor.Grid.MainView == e.View) {
                    activeBoolLists = _activeBoolLists;
                    enableBoolLists = _enabledBoolLists;
                }
                foreach (var action in GetActions(Frame)) {
                    SyncStates(action.Id, action.Active, activeBoolLists);
                    SyncStates(action.Id, action.Enabled, enableBoolLists);
                }
            }
        }


        void SyncStates(string id, BoolList boolList, Dictionary<string, BoolList> boolLists) {
            var list = boolLists[id];
            if (list.GetKeys().FirstOrDefault() != null) {
                boolList.BeginUpdate();
                boolList.Clear();
                foreach (var key in list.GetKeys()) {
                    boolList.SetItemValue(key, list[key]);
                }
                boolList.EndUpdate();
            }
        }

        void CloneActionState(Frame frame, Dictionary<string, BoolList> active, Dictionary<string, BoolList> enable) {
            foreach (var action in GetActions(frame)) {
                CloneBoolList(action.Id, action.Active, active);
                CloneBoolList(action.Id, action.Enabled, enable);
            }
        }

        void CloneBoolList(string id, BoolList boolList, Dictionary<string, BoolList> boolLists) {
            boolLists[id] = new BoolList();
            boolLists[id].BeginUpdate();
            foreach (var key in boolList.GetKeys()) {
                boolLists[id].SetItemValue(key, boolList[key]);
            }
            boolLists[id].EndUpdate();
        }

        void PushExecutionToNestedFrame() {
            foreach (var action in GetActions(Frame)) {
                action.Executing +=
                    (sender, args) =>
                    PushExecutionToNestedFrameCore((ActionBase)sender, () => args.Cancel = true);

            }
        }

        public virtual bool HasRules {
            get {
                if (GridListEditor == null)
                    return false;
                var masterDetailViewController = Frame.GetController<MasterDetailViewController>();
                return masterDetailViewController != null && masterDetailViewController.IsMasterDetail();
            }
        }

        WinColumnsListEditor GridListEditor {
            get { return View != null ? (View).Editor as WinColumnsListEditor : null; }
        }

        void PushExecutionToNestedFrameCore(ActionBase action, Action cancelAction) {
            var xpandXafGridView = GridListEditor != null ? (IMasterDetailColumnView)GridListEditor.Grid.FocusedView : null;
            if (xpandXafGridView != null && xpandXafGridView.MasterFrame != null) {
                var controller = Controller(action.Controller, xpandXafGridView);
                if (controller != action.Controller) {
                    cancelAction.Invoke();
                    (controller.Actions[action.Id]).DoExecute();
                }
            }
        }

        Controller Controller(Controller sender, IMasterDetailColumnView xpandXafGridView) {
            return xpandXafGridView.Window.Controllers.Cast<Controller>().FirstOrDefault(controller1 => sender.GetType() == controller1.GetType());
        }

        protected virtual bool IsExcluded(ActionBase action) {
            return false;
        }
    }
}

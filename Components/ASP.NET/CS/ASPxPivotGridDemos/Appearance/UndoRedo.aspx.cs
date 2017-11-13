using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxPivotGrid;
using System.Collections.Generic;
using System.Web.SessionState;

public partial class UndoRedo : Page {

    PivotStateController _stateController;
    PivotStateController StateController {
        get {
            if(_stateController == null)
                _stateController = new PivotStateController(ASPxPivotGrid1, Session);
            return _stateController;
        }
    }

    bool HasStateController { get { return _stateController != null; } }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack && !IsCallback) {
            StateController.ClearState();
            SaveCurrentStateAndUpdateControlsState();
        }
    }

    void SaveCurrentStateAndUpdateControlsState() {
        StateController.SaveCurrentState();
        CommitStateChanges();
    }
    void CommitStateChanges() {
        SetUpdateButtonsJSProperties();
        StateController.SaveStateToSession(Session);
    }

    void SetUpdateButtonsJSProperties() {
        ASPxPivotGrid1.JSProperties["cpIsUndoEnabled"] = StateController.CanLoadPrevState;
        ASPxPivotGrid1.JSProperties["cpIsRedoEnabled"] = StateController.CanLoadNextState;
    }

    protected void ASPxPivotGrid1_GridLayout(object sender, EventArgs e) {
        if(!HasStateController && !ASPxPivotGrid1.IsPrefilterPopupVisible)
            SaveCurrentStateAndUpdateControlsState();
    }

    protected void ASPxPivotGrid1_CustomCallback(object sender, PivotGridCustomCallbackEventArgs e) {
        if(e.Parameters == "UNDO")
            StateController.LoadPrevState();
        else if(e.Parameters == "REDO")
            StateController.LoadNextState();
        CommitStateChanges();
    }

    class PivotStateController {
        StateStorage _storage;
        const string SessionStateStorageKey = "StateStorage";

        public PivotStateController(ASPxPivotGrid _pivotGrid, HttpSessionState session) {
            PivotGrid = _pivotGrid;
            this._storage = (StateStorage)session[SessionStateStorageKey];
            if(this._storage == null)
                this._storage = new StateStorage();
        }


        StateStorage Storage { get { return _storage; } }
        ASPxPivotGrid PivotGrid { get; set; }

        public bool CanLoadPrevState { get { return !Storage.IsFirstLocation; } }
        public bool CanLoadNextState { get { return !Storage.IsLastLocation; } }

        public void ClearState() {
            Storage.Clear();
        }

        public void SaveCurrentState() {
            string layoutState = PivotGrid.SaveLayoutToString();
            string collapsedState = PivotGrid.SaveCollapsedStateToString();
            Storage.AddNewState(new StateRecord(layoutState, collapsedState));
        }

        public void LoadPrevState() {
            StateRecord state = Storage.GetPrevState();
            LoadState(state);
        }

        public void LoadNextState() {
            StateRecord state = Storage.GetNextState();
            LoadState(state);
        }

        void LoadState(StateRecord state) {
            if(state == null)
				return;
			PivotGrid.LoadLayoutFromString(state.LayoutState);
            PivotGrid.LoadCollapsedStateFromString(state.CollapsedState);
        }

        public void SaveStateToSession(HttpSessionState session) {
            session[SessionStateStorageKey] = _storage;
        }
    }

    [Serializable]
    class StateStorage {
        List<StateRecord> _records;
        public StateStorage() {
            _records = new List<StateRecord>();
            ClearState();
        }

        public void Clear() {
            ClearState();
        }
        void ClearState() {
            Records.Clear();
            CurrentLocation = -1;
        }
        public List<StateRecord> Records { get { return _records; } }
        public int CurrentLocation { get; set; }
        bool IsEmpty { get { return CurrentLocation == -1; } }
        public bool IsFirstLocation {
            get {
                if(IsEmpty)
                    return true;
                return CurrentLocation == 0;
            }
        }
        public bool IsLastLocation {
            get {
                if(IsEmpty)
                    return true;
                return CurrentLocation == Records.Count - 1;
            }
        }
        public void AddNewState(StateRecord state) {
            if(!IsEmpty && CurrentLocation != Records.Count - 1)
                Records.RemoveRange(CurrentLocation + 1, Records.Count - (CurrentLocation + 1));
            Records.Insert(++CurrentLocation, state);
        }
        public StateRecord GetPrevState() {
            if(IsEmpty || IsFirstLocation)
                return null;
            CurrentLocation--;
            return Records[CurrentLocation];
        }
        public StateRecord GetNextState() {
            if(IsEmpty || IsLastLocation)
                return null;
            CurrentLocation++;
            return Records[CurrentLocation];
        }
    }

    [Serializable]
    public class StateRecord {
        public StateRecord(string layoutState, string collapsedState) {
            LayoutState = layoutState;
            CollapsedState = collapsedState;
        }
        public string LayoutState { get; set; }
        public string CollapsedState { get; set; }
    }
}

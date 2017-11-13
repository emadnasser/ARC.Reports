using System;
using System.Web.UI;
using DevExpress.Web;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxPivotGrid;


public partial class OLAP_Drilldown : Page
{
    string errorText, isPopupError;
	bool isConnecting;

	protected void Page_Load(object sender, EventArgs e) {
		isConnecting = true;
        string error = OLAPConnector.TryConnect(pivotGrid);
		isConnecting = false;
        if(!string.IsNullOrEmpty(error)) {
            Control errorPanel = OLAPConnector.CreateErrorPanel(error);
            pivotGrid.Parent.Controls.AddAt(0, errorPanel);
        }
        isPopupError = "false";
        errorText = string.Empty;
        AddDrillDownGridView();
        pivotGrid.ClientSideEvents.CellClick = GetJSCellClickHandler();
        ASPxPopupControl1.ClientSideEvents.Closing = GetJSPopupClosingHandler();
	}
    void AddDrillDownGridView() {
        ASPxGridView gridView = CreateDrillDownGridView();
        BindDrillDownGridView(gridView);
    }
    ASPxGridView CreateDrillDownGridView() {
        ASPxGridView gridView = new ASPxGridView();
        gridView.ID = "ASPxGridView1";
        gridView.ClientInstanceName = "DrillDownGridView";
        gridView.SettingsLoadingPanel.Mode = GridViewLoadingPanelMode.ShowOnStatusBar;
        gridView.ClientSideEvents.EndCallback = GetJSEndCallbackHandler();
        gridView.CustomJSProperties += new ASPxGridViewClientJSPropertiesEventHandler(gridView_CustomJSProperties);
        ASPxPopupControl1.Controls.Add(gridView);
        return gridView;
    }

    void gridView_CustomJSProperties(object sender, ASPxGridViewClientJSPropertiesEventArgs e) {
        e.Properties.Add("cpIsPopupError", isPopupError);
        e.Properties.Add("cpErrorText", errorText);
    }
    bool HasDrillDownGridView {
        get { return IsPopupShown.Value == "true"; }
    }
    bool IsDrillDownGridViewInitializing {
        get { return IsPopupShowing.Value == "true"; }
    }
    void BindDrillDownGridView(ASPxGridView gridView) {
        if(!HasDrillDownGridView)
            return;
        if(IsDrillDownGridViewInitializing) {
            gridView.Columns.Clear();
            gridView.AutoGenerateColumns = true;
            gridView.PageIndex = 0;
        }
        gridView.DataSource = pivotGrid.CreateDrillDownDataSource(Int32.Parse(ColumnIndex.Value), Int32.Parse(RowIndex.Value));
        gridView.DataBind();
        CorrectColumnCaptions(gridView);
    }
    void CorrectColumnCaptions(ASPxGridView gridView) {
        for(int i = 0; i < gridView.Columns.Count; i++) {
            gridView.Columns[i].Caption = GetHeaderText(gridView.Columns[i].ToString());
        }
    }
    protected string GetHeaderText(string columnName) {
        for(int i = 0; i < pivotGrid.Fields.Count; i++) {
            if(pivotGrid.Fields[i].OLAPDrillDownColumnName == columnName)
                return pivotGrid.Fields[i].Caption;
        }
        return columnName;
    }
    protected string GetJSCellClickHandler() {
        return string.Format(@"function (s, e) {{
    var func = function(){{
        if(typeof(DrillDownGridView) == 'undefined') {{
            setTimeout(func, 10);
            return;
        }}
        var columnIndex = document.getElementById('{0}'),
            rowIndex = document.getElementById('{1}'),
            isPopupShowing = document.getElementById('{2}'),
            isPopupShown = document.getElementById('{3}');
        columnIndex.value = e.ColumnIndex;
        rowIndex.value = e.RowIndex; 
        isPopupShowing.value = 'true';
        isPopupShown.value = 'true';
        ShowDrillDown(); 
        DrillDownGridView.Refresh();
    }};
    func();
}}", ColumnIndex.ClientID, RowIndex.ClientID, IsPopupShowing.ClientID, IsPopupShown.ClientID);
    }
    protected string GetJSPopupClosingHandler() {
        return string.Format(@"function (s, e) {{
    var columnIndex = document.getElementById('{0}');
    var rowIndex = document.getElementById('{1}');
    var isPopupShown = document.getElementById('{2}');
    columnIndex.value = '';
    rowIndex.value = '';
    isPopupShown.value = 'false';
}}", ColumnIndex.ClientID, RowIndex.ClientID, IsPopupShown.ClientID);
    }
    protected string GetJSEndCallbackHandler() {
        return string.Format(@"function (s, e) {{
    var isPopupShowing = document.getElementById('{0}');
    isPopupShowing.value='false';
    if(DrillDownGridView.cpIsPopupError == 'true') {{
        DrillDownWindow.Hide();
        document.getElementById('errorText').innerHTML = DrillDownGridView.cpErrorText;
        ASPxPopupControl2.ShowAtElementByID('{1}');
    }} else {{
    DrillDownWindow.SetSize(0, 100, 100);
    }}
}}", IsPopupShowing.ClientID, pivotGrid.ClientID);
    }
	protected void pivotGrid_QueryException(object sender, PivotQueryExceptionEventArgs e) {
		if(isConnecting)
			return;
		e.Handled = true;
		errorText = e.Exception.Message;
		isPopupError = "true";		
	}
}


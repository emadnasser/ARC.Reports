Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxPivotGrid


Partial Public Class OLAP_Drilldown
	Inherits Page
	Private errorText, isPopupError As String
	Private isConnecting As Boolean

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		isConnecting = True
		Dim [error] As String = OLAPConnector.TryConnect(pivotGrid)
		isConnecting = False
		If (Not String.IsNullOrEmpty([error])) Then
			Dim errorPanel As Control = OLAPConnector.CreateErrorPanel([error])
			pivotGrid.Parent.Controls.AddAt(0, errorPanel)
		End If
		isPopupError = "false"
		errorText = String.Empty
		AddDrillDownGridView()
		pivotGrid.ClientSideEvents.CellClick = GetJSCellClickHandler()
		ASPxPopupControl1.ClientSideEvents.Closing = GetJSPopupClosingHandler()
	End Sub
	Private Sub AddDrillDownGridView()
		Dim gridView As ASPxGridView = CreateDrillDownGridView()
		BindDrillDownGridView(gridView)
	End Sub
	Private Function CreateDrillDownGridView() As ASPxGridView
		Dim gridView As New ASPxGridView()
		gridView.ID = "ASPxGridView1"
		gridView.ClientInstanceName = "DrillDownGridView"
		gridView.SettingsLoadingPanel.Mode = GridViewLoadingPanelMode.ShowOnStatusBar
		gridView.ClientSideEvents.EndCallback = GetJSEndCallbackHandler()
		AddHandler gridView.CustomJSProperties, AddressOf gridView_CustomJSProperties
		ASPxPopupControl1.Controls.Add(gridView)
		Return gridView
	End Function

	Private Sub gridView_CustomJSProperties(ByVal sender As Object, ByVal e As ASPxGridViewClientJSPropertiesEventArgs)
		e.Properties.Add("cpIsPopupError", isPopupError)
		e.Properties.Add("cpErrorText", errorText)
	End Sub
	Private ReadOnly Property HasDrillDownGridView() As Boolean
		Get
			Return IsPopupShown.Value = "true"
		End Get
	End Property
	Private ReadOnly Property IsDrillDownGridViewInitializing() As Boolean
		Get
			Return IsPopupShowing.Value = "true"
		End Get
	End Property
	Private Sub BindDrillDownGridView(ByVal gridView As ASPxGridView)
		If (Not HasDrillDownGridView) Then
			Return
		End If
		If IsDrillDownGridViewInitializing Then
			gridView.Columns.Clear()
			gridView.AutoGenerateColumns = True
			gridView.PageIndex = 0
		End If
		gridView.DataSource = pivotGrid.CreateDrillDownDataSource(Int32.Parse(ColumnIndex.Value), Int32.Parse(RowIndex.Value))
		gridView.DataBind()
		CorrectColumnCaptions(gridView)
	End Sub
	Private Sub CorrectColumnCaptions(ByVal gridView As ASPxGridView)
		For i As Integer = 0 To gridView.Columns.Count - 1
			gridView.Columns(i).Caption = GetHeaderText(gridView.Columns(i).ToString())
		Next i
	End Sub
	Protected Function GetHeaderText(ByVal columnName As String) As String
		For i As Integer = 0 To pivotGrid.Fields.Count - 1
			If pivotGrid.Fields(i).OLAPDrillDownColumnName = columnName Then
				Return pivotGrid.Fields(i).Caption
			End If
		Next i
		Return columnName
	End Function
	Protected Function GetJSCellClickHandler() As String
		Return String.Format("function (s, e) {{" & ControlChars.CrLf & "    var func = function(){{" & ControlChars.CrLf & "        if(typeof(DrillDownGridView) == 'undefined') {{" & ControlChars.CrLf & "            setTimeout(func, 10);" & ControlChars.CrLf & "            return;" & ControlChars.CrLf & "        }}" & ControlChars.CrLf & "        var columnIndex = document.getElementById('{0}')," & ControlChars.CrLf & "            rowIndex = document.getElementById('{1}')," & ControlChars.CrLf & "            isPopupShowing = document.getElementById('{2}')," & ControlChars.CrLf & "            isPopupShown = document.getElementById('{3}');" & ControlChars.CrLf & "        columnIndex.value = e.ColumnIndex;" & ControlChars.CrLf & "        rowIndex.value = e.RowIndex; " & ControlChars.CrLf & "        isPopupShowing.value = 'true';" & ControlChars.CrLf & "        isPopupShown.value = 'true';" & ControlChars.CrLf & "        ShowDrillDown(); " & ControlChars.CrLf & "        DrillDownGridView.Refresh();" & ControlChars.CrLf & "    }};" & ControlChars.CrLf & "    func();" & ControlChars.CrLf & "}}", ColumnIndex.ClientID, RowIndex.ClientID, IsPopupShowing.ClientID, IsPopupShown.ClientID)
	End Function
	Protected Function GetJSPopupClosingHandler() As String
		Return String.Format("function (s, e) {{" & ControlChars.CrLf & "    var columnIndex = document.getElementById('{0}');" & ControlChars.CrLf & "    var rowIndex = document.getElementById('{1}');" & ControlChars.CrLf & "    var isPopupShown = document.getElementById('{2}');" & ControlChars.CrLf & "    columnIndex.value = '';" & ControlChars.CrLf & "    rowIndex.value = '';" & ControlChars.CrLf & "    isPopupShown.value = 'false';" & ControlChars.CrLf & "}}", ColumnIndex.ClientID, RowIndex.ClientID, IsPopupShown.ClientID)
	End Function
	Protected Function GetJSEndCallbackHandler() As String
		Return String.Format("function (s, e) {{" & ControlChars.CrLf & "    var isPopupShowing = document.getElementById('{0}');" & ControlChars.CrLf & "    isPopupShowing.value='false';" & ControlChars.CrLf & "    if(DrillDownGridView.cpIsPopupError == 'true') {{" & ControlChars.CrLf & "        DrillDownWindow.Hide();" & ControlChars.CrLf & "        document.getElementById('errorText').innerHTML = DrillDownGridView.cpErrorText;" & ControlChars.CrLf & "        ASPxPopupControl2.ShowAtElementByID('{1}');" & ControlChars.CrLf & "    }} else {{" & ControlChars.CrLf & "    DrillDownWindow.SetSize(0, 100, 100);" & ControlChars.CrLf & "    }}" & ControlChars.CrLf & "}}", IsPopupShowing.ClientID, pivotGrid.ClientID)
	End Function
	Protected Sub pivotGrid_QueryException(ByVal sender As Object, ByVal e As PivotQueryExceptionEventArgs)
		If isConnecting Then
			Return
		End If
		e.Handled = True
		errorText = e.Exception.Message
		isPopupError = "true"
	End Sub
End Class


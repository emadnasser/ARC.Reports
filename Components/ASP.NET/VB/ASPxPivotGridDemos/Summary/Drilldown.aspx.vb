Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Features_Click
	Inherits Page
	Private bounded As Boolean
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim columnIndexValue As String = ColumnIndex.Value, rowIndexValue As String = RowIndex.Value
		If (Not String.IsNullOrEmpty(columnIndexValue)) AndAlso (Not String.IsNullOrEmpty(rowIndexValue)) AndAlso ASPxPopupControl1.ShowOnPageLoad Then
			BindGridView(columnIndexValue, rowIndexValue)
		End If
		ASPxPivotGrid1.ClientSideEvents.CellClick = GetJSCellClickHandler()
		ASPxPopupControl1.ClientSideEvents.Closing = GetJSPopupClosingHandler()

		If ASPxGridView1.IsCallback AndAlso (Not String.IsNullOrEmpty(columnIndexValue)) AndAlso (Not String.IsNullOrEmpty(rowIndexValue)) Then
			ASPxGridView1.JSProperties.Add("cpShowDrillDownWindow", False)
		End If
	End Sub
	Protected Sub ASPxGridView1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomCallbackEventArgs)
		Dim param() As String = e.Parameters.Split("|"c)
		If param(0) <> "D" Then
			Return
		End If
		BindGridView(ColumnIndex.Value, RowIndex.Value)
		ASPxGridView1.PageIndex = 0

		If e.Parameters = "D" Then
			ASPxGridView1.JSProperties("cpShowDrillDownWindow") = True
		End If
	End Sub
	Protected Sub BindGridView(ByVal columnIndex As String, ByVal rowIndex As String)
		If bounded Then
			Return
		End If
		bounded = True
		ASPxGridView1.DataSource = ASPxPivotGrid1.CreateDrillDownDataSource(Int32.Parse(columnIndex), Int32.Parse(rowIndex))
		ASPxGridView1.DataBind()
	End Sub
	Protected Function GetJSCellClickHandler() As String
		Return String.Format("function (s, e) {{" & ControlChars.CrLf & "    var columnIndex = document.getElementById('{0}')," & ControlChars.CrLf & "        rowIndex = document.getElementById('{1}');" & ControlChars.CrLf & "    columnIndex.value = e.ColumnIndex;" & ControlChars.CrLf & "    rowIndex.value = e.RowIndex;" & ControlChars.CrLf & "    GridView.PerformCallback('D');" & ControlChars.CrLf & "    ShowDrillDown();" & ControlChars.CrLf & "}}", ColumnIndex.ClientID, RowIndex.ClientID)
	End Function
	Protected Function GetJSPopupClosingHandler() As String
		Return String.Format("function (s, e) {{" & ControlChars.CrLf & "    var columnIndex = document.getElementById('{0}')," & ControlChars.CrLf & "        rowIndex = document.getElementById('{1}');" & ControlChars.CrLf & "    columnIndex.value = '';" & ControlChars.CrLf & "    rowIndex.value = '';" & ControlChars.CrLf & "    GridView.SetVisible(false);" & ControlChars.CrLf & "    " & ControlChars.CrLf & "}}", ColumnIndex.ClientID, RowIndex.ClientID)
	End Function
End Class

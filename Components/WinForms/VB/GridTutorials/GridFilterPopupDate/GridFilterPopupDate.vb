Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors.Helpers

Namespace DevExpress.XtraGrid.Demos.Tutorials
	Partial Public Class GridFilterPopupDate
		Inherits TutorialControl
		Private pnlHint As DevExpress.Utils.Frames.NotePanel8_1
		Public Sub New()
			InitializeComponent()
			UpdateHint()
		End Sub

		Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawGroupRow
			Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
			If info Is Nothing Then
			Return
			End If
			info.GroupText = info.GroupText.Replace("1 items", "1 item")
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			gridControl1.DataSource = OutlookData.CreateDataTable()
			gridView1.ActiveFilterString = "IsOutlookIntervalLastWeek([Received]) Or IsOutlookIntervalYesterday([Received]) Or IsOutlookIntervalToday([Received])"
		End Sub
		'<cbeFilterPopupMode>
		Private Sub cbeFilterPopupMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeFilterPopupMode.SelectedIndexChanged
            Select Case (cbeFilterPopupMode.SelectedIndex)
                Case 0 : colReceived.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Date
                Case 1 : colReceived.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
                Case 2 : colReceived.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt
            End Select
            '<skip>
            UpdateHint()
            '</skip>
        End Sub
		Private Sub gridView1_ShowFilterPopupDate(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FilterPopupDateEventArgs) Handles gridView1.ShowFilterPopupDate
            If cbeFilterPopupMode.SelectedIndex <> 3 Then
                Return
            End If
			If e.Column Is colReceived Then
				e.List.Clear()
				Dim crit As CriteriaOperator = New OperandProperty(e.Column.FieldName)

				For i As Integer = 1 To 7
					e.List.Add(New FilterDateElement(GetDayName(i), String.Empty, (crit >= DateTime.Today.AddDays(-i)) And (crit < DateTime.Today.AddDays(-i + 1))))
				Next i
			End If
		End Sub
		Private Function GetDayName(ByVal i As Integer) As String
			If i = 1 Then
			Return "Yesterday"
			End If
			If i = 2 Then
			Return "The day before yesterday"
			End If
			Return String.Format("Last {0:dddd}", DateTime.Today.AddDays(-i))
		End Function
		'</cbeFilterPopupMode>
		Private Sub UpdateHint()
			CreatePanelHint()
            Dim hints() As String = {"Date: the filter dropdown includes all the available check boxes to select date ranges: Today, Yesterday, Earlier this Week, etc.", "DateSmart: the filter dropdown includes the Today, Yesterday, Earlier this Week and other check boxes. However, if there is no underlying data that would fall into a specific date range, the corresponding check box is hidden.", "DateAlt: this mode is equivalent to DateSmart, but with a different set of filters: Today, This week, This month, Next month, etc.", "Custom: the filter dropdown is populated manually via the ShowFilterPopupDate event."}
			pnlHint.Text = hints(cbeFilterPopupMode.SelectedIndex)
		End Sub

		Private Sub CreatePanelHint()
			If pnlHint IsNot Nothing Then
			Return
			End If
			Me.pnlHint = New DevExpress.Utils.Frames.NotePanel8_1()
			Me.pnlHint.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
			Me.pnlHint.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pnlHint.MaxRows = 10
			Me.pnlHint.Parent = panelControl1
			Me.pnlHint.BringToFront()
		End Sub
	End Class
End Namespace

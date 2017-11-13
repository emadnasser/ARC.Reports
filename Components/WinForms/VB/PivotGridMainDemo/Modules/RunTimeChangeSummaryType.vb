Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Utils.Menu

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class RunTimeChangeSummaryType
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\RunTimeChangeSummaryType.vb"
            TutorialInfo.WhatsThisXMLFile = "RunTimeChangeSummaryType.xml"

			' TODO: Add any initialization after the InitializeComponent call
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			CreateDataFields()
		End Sub
		Public Overrides ReadOnly Property ViewOptionsControl() As PivotGridControl
			Get
				Return pivotGridControl1
			End Get
		End Property
		Public Overrides ReadOnly Property ExportControl() As PivotGridControl
			Get
				Return pivotGridControl1
			End Get
		End Property


		'<checkEdit1>
		'<checkEdit2>
		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
			CreateDataFields()
		End Sub

		Private Sub checkEdit2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit2.CheckedChanged
			CreateDataFields()
		End Sub

		Private Sub CreateDataFields()
			pivotGridControl1.BeginUpdate()

			For i As Integer = pivotGridControl1.Fields.Count -1 To 0 Step -1
				If pivotGridControl1.Fields(i).Area = PivotArea.DataArea Then
					pivotGridControl1.Fields.RemoveAt(i)
				End If
			Next i
			If checkEdit1.Checked Then
				For summaryType As Integer = 0 To 3
					Dim field As PivotGridField = pivotGridControl1.Fields.Add("Discount", PivotArea.DataArea)
					field.Options.ShowSummaryTypeName = True
					field.Options.AllowRunTimeSummaryChange = False
					field.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
					field.CellFormat.FormatString = "##0.##"
					field.SummaryType = CType(summaryType, PivotSummaryType)
				Next summaryType
				pivotGridControl1.Fields("ProductName").Width = 350
			Else
				Dim field As PivotGridField = pivotGridControl1.Fields.Add("Discount", PivotArea.DataArea)
				field.Options.ShowSummaryTypeName = True
				field.Options.AllowRunTimeSummaryChange = True
				field.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
				field.CellFormat.FormatString = "##0.##"

				pivotGridControl1.Fields("ProductName").Width = 200
			End If

			pivotGridControl1.EndUpdate()
		End Sub
		'</checkEdit2>
		'</checkEdit1>

		Private Sub pivotGridControl1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
			If e.MenuType = PivotGridMenuType.HeaderSummaries Then
				HideCustomMenuItem(e.Menu)
			End If
		End Sub

		Private Sub HideCustomMenuItem(ByVal menu As DevExpress.Utils.Menu.DXPopupMenu)
			For i As Integer = menu.Items.Count - 1 To 0 Step -1
				' Menu item tag list can be found in
				' http://devexpress.com/Help/?document=xtrapivotgrid/devexpressxtrapivotgridpivotgridcontrol_menuitemclicktopic.htm
				If Object.Equals(menu.Items(i).Tag, PivotSummaryType.Custom) Then
					menu.Items.RemoveAt(i)
					Return
				End If
			Next i
		End Sub
	End Class
End Namespace

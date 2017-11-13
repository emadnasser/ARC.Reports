Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars.Docking

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class MailMergeModuleBase
		Inherits SpreadSheetTutorialControlBase
		Private spreadsheetControl1 As SpreadsheetControl
		Private book As IWorkbook
		Private culture As CultureInfo

		Protected Sub New()
			Me.culture = DefaultCulture
			InitializeComponent()
			Me.spreadsheetControl1.Options.Culture = culture
			ribbonPageDemoGroup.Visible = ShowHideCommentsItem
			spreadsheetDockManager1.ForceInitialize()
			filteringDockPanel.Visibility = If(ShowFilterPanel, DockVisibility.Visible, DockVisibility.Hidden)
			mailMergeParametersDockPanel.Visibility = If(ShowParametersPanel, DockVisibility.Visible, DockVisibility.Hidden)
			spreadsheetControl1.BeginUpdate()
			book = spreadsheetControl1.Document
			LoadTemplate(spreadsheetControl1)
			LoadData(book)
			spreadsheetControl1.CreateCommand(Commands.SpreadsheetCommandId.MailMergeShowRanges).Execute()
			spreadsheetControl1.Document.History.Clear()
			spreadsheetControl1.EndUpdate()
		End Sub
		Protected Overridable ReadOnly Property ShowHideCommentsItem() As Boolean
			Get
				Return True
			End Get
		End Property
		Protected Overridable ReadOnly Property ShowFilterPanel() As Boolean
			Get
				Return True
			End Get
		End Property
		Protected Overridable ReadOnly Property ShowParametersPanel() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected ReadOnly Property ShowSalesManagers() As Boolean
			Get
				Return checkEdit0.Checked
			End Get
		End Property
		Protected ReadOnly Property ShowInsideSalesCoordinators() As Boolean
			Get
				Return checkEdit1.Checked
			End Get
		End Property
		Protected ReadOnly Property ShowSalesRepresentatives() As Boolean
			Get
				Return checkEdit2.Checked
			End Get
		End Property
		Protected Overrides Sub DoShow()
			ribbonControl1.SelectedPage = mailMergeRibbonPage1
			spreadsheetBarController1.Control.Focus()

			MyBase.DoShow()
		End Sub
		Private Sub hideCommentsCheckItem_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles hideCommentsCheckItem.CheckedChanged
			HideComments(book, (Not hideCommentsCheckItem.Checked))
		End Sub
		Private Sub checkEdit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit0.CheckedChanged, checkEdit1.CheckedChanged, checkEdit2.CheckedChanged
			ChangeFilter(book)
		End Sub

		Protected Overridable Sub LoadTemplate(ByVal spreadsheetControl As SpreadsheetControl)
		End Sub
		Protected Overridable Sub LoadData(ByVal book As IWorkbook)
		End Sub
		Protected Overridable Sub ChangeFilter(ByVal book As IWorkbook)
			Throw New NotImplementedException()
		End Sub
		Protected Overridable Sub HideComments(ByVal book As IWorkbook, ByVal visible As Boolean)
			Throw New NotImplementedException()
		End Sub
	End Class
End Namespace

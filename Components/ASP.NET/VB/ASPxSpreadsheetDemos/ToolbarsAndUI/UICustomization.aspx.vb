Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Spreadsheet
Imports DevExpress.Web
Imports DevExpress.Web.ASPxSpreadsheet
Imports DevExpress.Web.Demos

Partial Public Class ToolbarsAndUI_UICustomization
	Inherits System.Web.UI.Page
	Private ReadOnly Property CurrentRibbonMode() As SpreadsheetRibbonMode
		Get
			Return CType(System.Enum.Parse(GetType(SpreadsheetRibbonMode), RibbonMode.SelectedItem.Value.ToString()), SpreadsheetRibbonMode)
		End Get
	End Property
	Private ReadOnly Property CurrentWorksheet() As Worksheet
		Get
			Return Spreadsheet.Document.Worksheets.ActiveWorksheet
		End Get
	End Property
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not Page.IsPostBack) Then
			SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
			Dim filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "DietAndExersiseJournal.xlsx")
			Spreadsheet.Open(filePath)
		Else
			ApplySpreadsheetSettings()
		End If
	End Sub

	Protected Sub CallbackPanel_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
		If (Not String.IsNullOrEmpty(e.Parameter)) Then
			ApplyDocumentSettings(e.Parameter)
		End If
		ApplySpreadsheetSettings()
	End Sub

	Private Sub ApplyDocumentSettings(ByVal parameter As String)
		If parameter = "headings" Then
			CurrentWorksheet.ActiveView.ShowHeadings = Not CurrentWorksheet.ActiveView.ShowHeadings
		ElseIf parameter = "grid" Then
			CurrentWorksheet.ActiveView.ShowGridlines = Not CurrentWorksheet.ActiveView.ShowGridlines
		End If
	End Sub

	Private Sub ApplySpreadsheetSettings()
		Spreadsheet.RibbonMode = CurrentRibbonMode
		Spreadsheet.ShowFormulaBar = ShowFormulaBar.Checked
		Spreadsheet.ShowSheetTabs = ShowSheetTabs.Checked

		If CurrentRibbonMode.Equals(SpreadsheetRibbonMode.ExternalRibbon) Then
			ExternalRibbon.Visible = True
			AttachExternalRibbonToSpreadsheet()
		Else
			ExternalRibbon.Visible = False
			Spreadsheet.Height = System.Web.UI.WebControls.Unit.Pixel(550)
		End If
	End Sub

	Private Sub AttachExternalRibbonToSpreadsheet()
		Spreadsheet.AssociatedRibbonID = ExternalRibbon.ID
		Spreadsheet.CreateDefaultRibbonTabs(True)
		ExternalRibbon.Tabs(0).Visible = False
		Spreadsheet.Height = System.Web.UI.WebControls.Unit.Pixel(350)
	End Sub

End Class

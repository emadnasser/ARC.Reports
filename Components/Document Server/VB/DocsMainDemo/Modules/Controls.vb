Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Drawing
Imports System.Diagnostics
Imports DevExpress.XtraBars
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting.Control

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetTutorialControl
		Inherits TutorialControlBase
		Implements IDXMenuManager
		#Region "Static"
		Public Shared Function GetSaveFileName(ByVal defaulName As String) As String
			Return GetSaveFileName("Xlsx files(*.xlsx)|*.xlsx|All files (*.*)|*.*", defaulName)
		End Function
		Public Shared Function GetSaveFileName(ByVal filter As String, ByVal defaulName As String) As String
			Dim sfDialog As New SaveFileDialog()
			sfDialog.Filter = filter
			sfDialog.FileName = defaulName
			If sfDialog.ShowDialog() <> DialogResult.OK Then
				Return Nothing
			End If
			Return sfDialog.FileName
		End Function
		Public Shared Sub ShowFile(ByVal fileName As String, ByVal control As TutorialControlBase)
			If (Not File.Exists(fileName)) Then
				Return
			End If
			Dim dResult As DialogResult = XtraMessageBox.Show(control.LookAndFeel, control, String.Format("Do you want to open the resulting file?", fileName), control.TutorialName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If dResult = DialogResult.Yes Then
				Process.Start(fileName)
			End If
		End Sub
		#End Region
		#Region "Fields"
		Private menu As LookAndFeelMenu
		Private fMenuManager As IDXMenuManager
		Private spreadsheetTutorialPanel_Renamed As PanelControl
		Private defaultCulture_Renamed As New CultureInfo("en-US")
		#End Region

		Public Sub New()
			InitializeComponent()
			AddHandler fitToPageCheckEdit_Renamed.CheckedChanged, AddressOf fitToPageCheckEdit_CheckedChanged
			CanShowBorders = True
		End Sub

		#Region "Properties"
		Public Property DemoMainMenu() As LookAndFeelMenu
			Get
				Return menu
			End Get
			Set(ByVal value As LookAndFeelMenu)
				If menu Is value Then
					Return
				End If
				Me.menu = value
			End Set
		End Property
		Public Property MenuManager() As IDXMenuManager
			Get
				Return fMenuManager
			End Get
			Set(ByVal value As IDXMenuManager)
				fMenuManager = value
			End Set
		End Property
		Public Overridable ReadOnly Property ShowOptions() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overridable ReadOnly Property DefaultFileName() As String
			Get
				Return ""
			End Get
		End Property
		Protected Overridable ReadOnly Property DefaultSaveFileFilter() As String
			Get
				Return "Excel Workbook(*.xlsx)|*.xlsx|Excel 97-2003 Workbook(*.xls)|*.xls|CSV (Comma delimited)(*.csv)|*.csv|PDF(*.pdf)|*.pdf"
			End Get
		End Property
		Protected ReadOnly Property SpreadsheetTutorialPanel() As PanelControl
			Get
				Return spreadsheetTutorialPanel_Renamed
			End Get
		End Property
		Protected ReadOnly Property FitToPageCheckEdit() As CheckEdit
			Get
				Return fitToPageCheckEdit_Renamed
			End Get
		End Property
		Protected Property CanShowBorders() As Boolean
			Get
				Return Me.spreadsheetPreview1.CanShowBorders
			End Get
			Set(ByVal value As Boolean)
				Me.spreadsheetPreview1.CanShowBorders = value
			End Set
		End Property
		Public ReadOnly Property DefaultCulture() As CultureInfo
			Get
				Return defaultCulture_Renamed
			End Get
		End Property
		#End Region

		Protected Overridable Function CreateEmptyBook() As IWorkbook
			Dim book As IWorkbook = New Workbook()
			book.Options.Culture = DefaultCulture
			Return book
		End Function
		Public Overridable Function CreateBook() As IWorkbook
			Return CreateEmptyBook()
		End Function
		Private Sub ShowPopupMenu(ByVal menu As DXPopupMenu, ByVal control As Control, ByVal pos As Point) Implements IDXMenuManager.ShowPopupMenu
			MenuManagerHelper.ShowMenu(menu, LookAndFeel, fMenuManager, control, pos)
		End Sub
		Private Function Clone(ByVal newForm As Form) As IDXMenuManager Implements IDXMenuManager.Clone
			Return Me
		End Function
		Private Sub DisposeManager() Implements IDXMenuManager.DisposeManager
		End Sub
		Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
			Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
			If be IsNot Nothing Then
				be.MenuManager = manager
			End If
		End Sub
		#Region "Print and Export"
		Protected Sub RefreshPreview()
			Dim book As IWorkbook = CreateBook()
			book.Worksheets(0).PrintOptions.FitToPage = fitToPageCheckEdit_Renamed.Checked
			Me.spreadsheetPreview1.Workbook = book
			Me.spreadsheetPreview1.UpdatePreview()
		End Sub
		#End Region

		Private Sub saveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveButton.Click
			Dim fileName As String = GetSaveFileName(DefaultSaveFileFilter, DefaultFileName)
			Dim book As IWorkbook = CreateBook()
			If (Not String.IsNullOrEmpty(fileName)) Then
				Dim ext As String = Path.GetExtension(fileName)
				If ext = ".xls" Then
					book.SaveDocument(fileName, DocumentFormat.Xls)
				ElseIf ext = ".csv" Then
					book.SaveDocument(fileName, DocumentFormat.Csv)
				ElseIf ext = ".pdf" Then
					book.ExportToPdf(fileName)
				Else
					book.SaveDocument(fileName, DocumentFormat.OpenXml)
				End If
			End If
			ShowFile(fileName, Me)
		End Sub
		Private Sub fitToPageCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			RefreshPreview()
		End Sub
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraSpellChecker

Namespace DevExpress.XtraScheduler.Demos

	Partial Public Class frmMain
		Inherits DevExpress.DXperience.Demos.RibbonMainForm
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
		End Sub

		#Region "Properties"
		Protected Overrides ReadOnly Property DemoName() As String
			Get
				Return "XtraScheduler Main Demo (" & DemoUtils.GetLanguageString() & " code)"
			End Get
		End Property
		#End Region

		Protected Overrides Sub ShowAbout()
			SchedulerControl.About()
		End Sub
		Protected Overrides ReadOnly Property ProductName() As String
			Get
				Return "XtraScheduler"
			End Get
		End Property
		Protected Overrides Sub SetFormParam()
			Me.Icon = ResourceImageHelper.CreateIconFromResources("AppIcon.ico", GetType(frmMain).Assembly)
		End Sub
		Protected Overrides Sub ShowModule(ByVal name As String, ByVal groupControl As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
			DemosInfo.DoShowModule(name, groupControl, caption, TryCast(RibbonMenuManager, SchedulerRibbonMenuManager))
		End Sub

		Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
			Return New SchedulerRibbonMenuManager(Me)
		End Function

		Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim culture As CultureInfo = CultureInfo.InvariantCulture
			sharedDictionaryStorage.Dictionaries.Clear()
			Dim dictionary As New SpellCheckerISpellDictionary(DemoUtils.GetFileRelativePath("american.xlg"), DemoUtils.GetFileRelativePath("english.aff"), culture)
			dictionary.AlphabetPath = DemoUtils.GetFileRelativePath("EnglishAlphabet.txt")
			sharedDictionaryStorage.Dictionaries.Add(dictionary)
			Dim customDictionary As New SpellCheckerCustomDictionary(DemoUtils.GetFileRelativePath("CustomEnglish.dic"), culture)
			sharedDictionaryStorage.Dictionaries.Add(customDictionary)
		End Sub
	End Class

	Public Class CheckBarItemWithPrintColorSchema
		Inherits CheckBarItem
		Private printColorSchema_Renamed As PrintColorSchema
		Public Sub New(ByVal manager As BarManager, ByVal text As String, ByVal handler As ItemClickEventHandler, ByVal printColorSchema As PrintColorSchema)
			MyBase.New(manager, text, handler)
			Me.printColorSchema_Renamed = printColorSchema
		End Sub
		Public ReadOnly Property PrintColorSchema() As PrintColorSchema
			Get
				Return printColorSchema_Renamed
			End Get
		End Property
	End Class

	Public Interface IDemoSchedulerReport
		Sub UpdateActiveReport()
	End Interface

	Public Class SchedulerRibbonMenuManager
		Inherits RibbonMenuManager
		#Region "Fields"
		Private fSchedulerControl As SchedulerControl
		Private fSchedulerReport As IDemoSchedulerReport

		Private bbiPageSetup As BarButtonItem
		Private bbiLoadPageSetup As BarButtonItem
		Private bbiSavePageSetup As BarButtonItem

		Private bsiReports As BarSubItem
		Private cbiPrintColorSchemaBW As BarItem
		Private cbiPrintColorSchemaGS As BarItem
		Private cbiPrintColorSchemaFC As BarItem
		#End Region

		Public Sub New(ByVal form As RibbonMainForm)
			MyBase.New(form)
			CreatePageSetupMenu(form)
			CreateReportsMenu(form)
			EnableReportsMenu()
		End Sub

		#Region "Properties"
		Public Property SchedulerControl() As SchedulerControl
			Get
				Return fSchedulerControl
			End Get
			Set(ByVal value As SchedulerControl)
				fSchedulerControl = value
			End Set
		End Property
		Public Property SchedulerReport() As IDemoSchedulerReport
			Get
				Return fSchedulerReport
			End Get
			Set(ByVal value As IDemoSchedulerReport)
				fSchedulerReport = value
				EnableReportsMenu()
			End Set
		End Property
		#End Region

		Protected Friend Overridable Sub EnableReportsMenu()
			ShowReservGroup1(SchedulerReport IsNot Nothing)
		End Sub
		Protected Friend Overridable Sub CreatePageSetupMenu(ByVal form As RibbonMainForm)
			bbiPageSetup = CreateButtonItem("Page Setup", "PageSetup", AddressOf bbiPageSetup_Click)
			Dim ribbon As RibbonControl = form.Ribbon
			Dim printExportGroup As RibbonPageGroup = form.PrintExportGroup
			AddBarItemInRibbon(ribbon, printExportGroup, bbiPageSetup, True)
			bbiLoadPageSetup = CreateButtonItem("Load Page Setup", "LoadPageSetup", AddressOf bbiLoadPageSetup_Click)
			AddBarItemInRibbon(ribbon, printExportGroup, bbiLoadPageSetup)
			bbiSavePageSetup = CreateButtonItem("Save Page Setup", "SavePageSetup", AddressOf bbiSavePageSetup_Click)
			AddBarItemInRibbon(ribbon, printExportGroup, bbiSavePageSetup)
		End Sub
		Protected Friend Overridable Function CreateButtonItem(ByVal caption As String, ByVal imageName As String, ByVal clickHandler As ItemClickEventHandler) As BarButtonItem
			Dim item As New BarButtonItem(Me.Manager, caption)
			MainFormHelper.SetBarButtonImage(item, imageName)
			'bbiAlphaBlendingAdjustment.Glyph = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.XtraScheduler.Demos.Images.Blending.png", typeof(frmMain).Assembly);
			AddHandler item.ItemClick, clickHandler
			Return item
		End Function
		Protected Friend Overridable Sub AddBarItemInRibbon(ByVal ribbon As RibbonControl, ByVal group As RibbonPageGroup, ByVal item As BarItem)
			AddBarItemInRibbon(ribbon, group, item, False)
		End Sub
		Private Sub AddBarItemInRibbon(ByVal ribbon As RibbonControl, ByVal group As RibbonPageGroup, ByVal item As BarItem, ByVal beginGroup As Boolean)
			ribbon.Items.Add(item)
			group.ItemLinks.Add(item, beginGroup)
		End Sub
		Private Sub bbiPageSetup_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Try
				SchedulerControl.ShowPrintOptionsForm()
			Catch ex As Exception
				XtraMessageBox.Show(ex.Message, Application.ProductName)
			End Try
		End Sub
		Private Sub bbiLoadPageSetup_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim dlg As New OpenFileDialog()
			Try
				dlg.CheckPathExists = True
				dlg.Filter = "XML files (*.xml) | *.xml"
				Dim result As DialogResult = dlg.ShowDialog()
				If result <> DialogResult.OK Then
					Return
				End If
				SchedulerControl.PrintStyles.FromXml(dlg.FileName, Application.ProductName)
			Catch ex As Exception
				XtraMessageBox.Show(ex.Message, Application.ProductName)

			Finally
				dlg.Dispose()
			End Try
		End Sub
		Private Sub bbiSavePageSetup_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim dlg As New SaveFileDialog()
			Try
				dlg.Filter = "XML files (*.xml) | *.xml"
				Dim result As DialogResult = dlg.ShowDialog()
				If result <> DialogResult.OK Then
					Return
				End If
				SchedulerControl.PrintStyles.ToXml(dlg.FileName, Application.ProductName)
			Catch ex As Exception
				XtraMessageBox.Show(ex.Message, Application.ProductName)
			Finally
				dlg.Dispose()
			End Try
		End Sub

		Protected Friend Overridable Sub CreateReportsMenu(ByVal form As RibbonMainForm)
			bsiReports = New BarSubItem(Me.Manager, "Print Color Schemas")
			AddHandler bsiReports.Popup, AddressOf OnPopupReports
			MainFormHelper.SetBarButtonImage(bsiReports, "PrintColorSchemas")
			Dim ribbon As RibbonControl = form.Ribbon

			Dim reportsGroup As RibbonPageGroup = form.ReservGroup1
			reportsGroup.Text = "Reports"
			AddBarItemInRibbon(ribbon, reportsGroup, bsiReports)

			cbiPrintColorSchemaFC = New CheckBarItemWithPrintColorSchema(Me.Manager, "Full Color", AddressOf cbiPrintColorSchema_Click, PrintColorSchema.FullColor)
			cbiPrintColorSchemaGS = New CheckBarItemWithPrintColorSchema(Me.Manager, "Grayscale", AddressOf cbiPrintColorSchema_Click, PrintColorSchema.GrayScale)
			cbiPrintColorSchemaBW = New CheckBarItemWithPrintColorSchema(Me.Manager, "Black And White", AddressOf cbiPrintColorSchema_Click, PrintColorSchema.BlackAndWhite)

			AddCheckBarItemInSubItem(ribbon, bsiReports, cbiPrintColorSchemaFC)
			AddCheckBarItemInSubItem(ribbon, bsiReports, cbiPrintColorSchemaGS)
			AddCheckBarItemInSubItem(ribbon, bsiReports, cbiPrintColorSchemaBW)
		End Sub
		Protected Friend Overridable Sub AddCheckBarItemInSubItem(ByVal ribbon As RibbonControl, ByVal subItem As BarSubItem, ByVal item As BarItem)
			ribbon.Items.Add(item)
			subItem.ItemLinks.Add(item)
		End Sub
		Private Sub OnPopupReports(ByVal sender As Object, ByVal e As EventArgs)
			Dim items As BarSubItem = TryCast(sender, BarSubItem)
			If items Is Nothing Then
				Return
			End If
			For Each item As BarItemLink In items.ItemLinks
				Dim aItem As CheckBarItemWithPrintColorSchema = TryCast(item.Item, CheckBarItemWithPrintColorSchema)
				If aItem IsNot Nothing Then
					aItem.Checked = aItem.PrintColorSchema.Equals(DemoUtils.ReportPrintColorSchema)
				End If
			Next item
		End Sub
		Private Sub cbiPrintColorSchema_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim schemaItem As CheckBarItemWithPrintColorSchema = CType(e.Item, CheckBarItemWithPrintColorSchema)
			If SchedulerReport IsNot Nothing Then
				DemoUtils.ReportPrintColorSchema = schemaItem.PrintColorSchema
				SchedulerReport.UpdateActiveReport()
			End If
		End Sub
	End Class
End Namespace



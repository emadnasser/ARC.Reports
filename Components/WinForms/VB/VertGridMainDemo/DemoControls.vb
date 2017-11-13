Imports System.Collections
Imports System.Threading
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraExport
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraVerticalGrid.Demos
	Public Class TutorialControl
		Inherits TutorialControlBase

		Private fDescription As DevExpress.Utils.Frames.NotePanel = Nothing

		Public Sub New()
		End Sub

		Public ReadOnly Property VertGridRibbonMenuManager() As VGridRibbonMenuManager
			Get
				Return TryCast(RibbonMenuManager, VGridRibbonMenuManager)
			End Get
		End Property
		Protected Overrides Sub AllowExport()
			EnabledPrintExportActions(True, ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.XLS Or ExportFormats.RTF Or ExportFormats.Text Or ExportFormats.XLSX, False)
		End Sub
		Public Overrides ReadOnly Property AllowPrintOptions() As Boolean
			Get
				Return ExportControl IsNot Nothing
			End Get
		End Property
		Protected Overridable Sub OnOptionsChanged(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

        Protected Overrides Sub SetControlManager(ByVal ctrl As Windows.Forms.Control, ByVal manager As BarManager)
            Dim vGrid As DevExpress.XtraVerticalGrid.VGridControlBase = TryCast(ctrl, DevExpress.XtraVerticalGrid.VGridControlBase)
            If vGrid IsNot Nothing Then
                vGrid.MenuManager = manager
            End If
        End Sub

		Public Property Description() As DevExpress.Utils.Frames.NotePanel
			Get
				Return fDescription
			End Get
			Set(ByVal value As DevExpress.Utils.Frames.NotePanel)
				fDescription = value
				OnSetDescription("")
			End Set
		End Property

		Protected Overridable Sub OnSetDescription(ByVal fDescription As String)
			If fDescription = String.Empty Then
				Return
			End If
			Description.Text = String.Format(fDescription)
		End Sub

		Public Overridable ReadOnly Property ExportControl() As VGridControlBase
			Get
				Return Nothing
			End Get
		End Property
		Public Overridable ReadOnly Property ViewOptionsControl() As VGridControlBase
			Get
				Return Nothing
			End Get
		End Property
		Private Sub HideCustomization(ByVal collection As ControlCollection)
            For Each ctrl As Windows.Forms.Control In collection
                HideCustomization(ctrl.Controls)
                If TypeOf ctrl Is VGridControlBase Then
                    CType(ctrl, VGridControlBase).DestroyCustomization()
                End If
            Next ctrl
		End Sub
		Protected Overrides Sub DoHide()
			HideCustomization(Me.Controls)
		End Sub

		Protected Overridable Sub InitNWindData()
			Dim DBFileName As String = String.Empty
			DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
			If DBFileName <> String.Empty Then
				InitMDBData("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName)
			End If
		End Sub
		Protected Overridable Sub InitMDBData(ByVal connectionString As String)
		End Sub
		#Region "Print and Export"
		Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
			If ExportControl Is Nothing Then
				Return
			End If
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			If ext = "rtf" Then
				ExportControl.ExportToRtf(filename)
			End If
			If ext = "pdf" Then
				ExportControl.ExportToPdf(filename)
			End If
			If ext = "mht" Then
				ExportControl.ExportToMht(filename, New MhtExportOptions())
			End If
			If ext = "html" Then
				ExportControl.ExportToHtml(filename)
			End If
			If ext = "txt" Then
				ExportControl.ExportToText(filename)
			End If
			If ext = "xls" Then
				ExportControl.ExportToXls(filename)
			End If
			If ext = "xlsx" Then
				ExportControl.ExportToXlsx(filename)
			End If
			Cursor.Current = currentCursor
		End Sub
		Protected Overrides Sub ExportToPDF()
			ExportTo("pdf", "PDF document (*.pdf)|*.pdf")
		End Sub
		Protected Overrides Sub ExportToHTML()
			ExportTo("html", "HTML document (*.html)|*.html")
		End Sub
		Protected Overrides Sub ExportToMHT()
			ExportTo("mht", "MHT document (*.mht)|*.mht")
		End Sub
		Protected Overrides Sub ExportToXLS()
			ExportTo("xls", "XLS document (*.xls)|*.xls")
		End Sub
		Protected Overrides Sub ExportToXLSX()
			ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx")
		End Sub
		Protected Overrides Sub ExportToRTF()
			ExportTo("rtf", "RTF document (*.rtf)|*.rtf")
		End Sub
		Protected Overrides Sub ExportToText()
			ExportTo("txt", "Text document (*.txt)|*.txt")
		End Sub
		Protected Overrides Sub PrintPreview()
			If Me.ExportControl IsNot Nothing Then
				If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
					Me.ExportControl.ShowRibbonPrintPreview()
				Else
					Me.ExportControl.ShowPrintPreview()
				End If
			End If
		End Sub
		#End Region
	End Class
	Public Class VGridRibbonMenuManager
		Inherits RibbonMenuManager

		Private currentVGrid As VGridControlBase = Nothing
		Private bsiViewOptions As BarSubItem
		Public Sub New(ByVal form As RibbonMainForm)
			MyBase.New(form)
			CreateOptionsMenu(form.ReservGroup1, form.Ribbon)
		End Sub
		Private Sub CreateOptionsMenu(ByVal ribbonPageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
			ribbonPageGroup.Text = "Options"
			bsiViewOptions = New BarSubItem()
			bsiViewOptions.Caption = "View" & vbLf & " Options"
			MainFormHelper.SetBarButtonImage(bsiViewOptions, "View")
			ribbonControl.Items.Add(bsiViewOptions)
			ribbonPageGroup.ItemLinks.Add(bsiViewOptions)
		End Sub
		Public Sub RefreshOptionsMenu(ByVal vGrid As VGridControlBase)
			currentVGrid = vGrid
			ShowReservGroup1(vGrid IsNot Nothing)
			LookAndFeelMenu.ClearOptionItems(Manager)
			LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, New ItemClickEventHandler(AddressOf miViewOptions_Click), Manager)
		End Sub
		Private ReadOnly Property ViewOptions() As Object
			Get
				If currentVGrid Is Nothing Then
					Return Nothing
				End If
				Return currentVGrid.OptionsView
			End Get
		End Property
		Private Sub miViewOptions_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim item As OptionBarItem = TryCast(e.Item, OptionBarItem)
			If currentVGrid IsNot Nothing AndAlso item IsNot Nothing Then
				DevExpress.Utils.SetOptions.SetOptionValueByString(item.Caption, ViewOptions, item.Checked)
				LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions)
			End If
		End Sub
	End Class
End Namespace

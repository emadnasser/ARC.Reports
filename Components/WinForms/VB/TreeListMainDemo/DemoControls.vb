Imports System.Collections
Imports System.Threading
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraTreeList.Demos
	Public Class TutorialControl
		Inherits TutorialControlBase

		Private fDescription As DevExpress.Utils.Frames.NotePanel = Nothing
		Public Sub New()
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
		Public ReadOnly Property TreeListRibbonMenuManager() As TreeListRibbonMenuManager
			Get
				Return TryCast(RibbonMenuManager, TreeListRibbonMenuManager)
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

		Public Overridable ReadOnly Property ExportControl() As TreeList
			Get
				Return Nothing
			End Get
		End Property
		Public Overridable ReadOnly Property ViewOptionsControl() As TreeList
			Get
				Return Nothing
			End Get
		End Property

		Protected Overrides Sub DoHide()
            For Each ctrl As Windows.Forms.Control In Me.Controls
                If TypeOf ctrl Is TreeList Then
                    CType(ctrl, TreeList).DestroyCustomization()
                End If
            Next ctrl
		End Sub

        Protected Overrides Sub SetControlManager(ByVal ctrl As Windows.Forms.Control, ByVal manager As BarManager)
            Dim treeList As DevExpress.XtraTreeList.TreeList = TryCast(ctrl, DevExpress.XtraTreeList.TreeList)
            If treeList IsNot Nothing Then
                treeList.MenuManager = manager
            End If
        End Sub
		#Region "Print and Export"
		Private thread As Thread
		Private [stop] As Boolean
		Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
			If ExportControl Is Nothing Then
				Return
			End If
			[stop] = False
			thread = New Thread(New ThreadStart(AddressOf StartExport))
			thread.Start()
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
			EndExport()
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
		Private Sub StartExport()
			System.Threading.Thread.Sleep(400)
			If [stop] Then
				Return
			End If
			Dim progressForm As New ExportForm(Me.ParentForm)
			progressForm.Show()
			Try
				Do While Not [stop]
					Application.DoEvents()
					System.Threading.Thread.Sleep(100)
				Loop
			Catch
			End Try
			progressForm.Dispose()
		End Sub
		Private Sub EndExport()
			[stop] = True
			thread.Join()
		End Sub
		#End Region
	End Class
	Public Class TreeListRibbonMenuManager
		Inherits RibbonMenuManager

		Private currentTreeList As TreeList = Nothing
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
		Public Sub RefreshOptionsMenu(ByVal treeList As TreeList)
			currentTreeList = treeList
			ShowReservGroup1(treeList IsNot Nothing)
			LookAndFeelMenu.ClearOptionItems(Manager)
			LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, New ItemClickEventHandler(AddressOf miViewOptions_Click), Manager)
		End Sub
		Private ReadOnly Property ViewOptions() As Object
			Get
				If currentTreeList Is Nothing Then
					Return Nothing
				End If
				Return currentTreeList.OptionsView
			End Get
		End Property
		Private Sub miViewOptions_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim item As OptionBarItem = TryCast(e.Item, OptionBarItem)
			If currentTreeList IsNot Nothing AndAlso item IsNot Nothing Then
				DevExpress.Utils.SetOptions.SetOptionValueByString(item.Caption, ViewOptions, item.Checked)
				LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions)
			End If
		End Sub
    End Class
    Public Class DemosHelper
        Public Shared Sub ShowDescriptionForm(ByVal location As System.Drawing.Point, ByVal description As String, ByVal caption As String)
            Dim frm As New XtraForm() With {.FormBorderStyle = FormBorderStyle.FixedToolWindow, .ShowInTaskbar = False, .StartPosition = FormStartPosition.Manual, .Text = caption}
            Dim tb As New TextBox() With {.Multiline = True, .Dock = DockStyle.Fill, .ScrollBars = ScrollBars.Vertical, .ReadOnly = True, .Text = description}
            frm.Controls.Add(tb)
            frm.Location = DevExpress.Utils.ControlUtils.CalcLocation(location, location, frm.Size)
            AddHandler frm.Shown, Function(sender, e) Deselect(sender, e, tb)
            frm.ShowDialog()
        End Sub
        Private Shared Function Deselect(ByVal sender As Object, ByVal e As Object, ByVal tb As TextBox) As Boolean
            tb.DeselectAll()
            Return True
        End Function
    End Class
End Namespace

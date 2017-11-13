Imports Microsoft.VisualBasic
Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections
Imports System.Data
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos
	Public Class ViewOptionsChangedEventArgs
		Inherits EventArgs
		Public Sub New(ByVal name As String, ByVal value As Boolean)
			Me.Name = name
			Me.Value = value
		End Sub
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateValue As Boolean
		Public Property Value() As Boolean
			Get
				Return privateValue
			End Get
			Set(ByVal value As Boolean)
				privateValue = value
			End Set
		End Property
	End Class
	Public Class PivotGridRibbonMenuManager
		Inherits RibbonMenuManager
		Private currentPivotGrid As PivotGridControl = Nothing
		Private bsiViewOptions As BarSubItem

        Public ReadOnly Property PivotGrid() As PivotGridControl
            Get
                Return CurrentPivotGrid
            End Get
        End Property

        Public Event ViewOptionsChanged As EventHandler(Of ViewOptionsChangedEventArgs)
		Public Sub New(ByVal form As RibbonMainForm)
			MyBase.New(form)
			CreateOptionsMenu(form.ReservGroup1, form.Ribbon)
		End Sub
		Private Sub CreateOptionsMenu(ByVal ribbonPageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
			ribbonPageGroup.Text = "Options"
			bsiViewOptions = New BarSubItem()
			bsiViewOptions.Caption = "View" & Constants.vbLf & " Options"
			MainFormHelper.SetBarButtonImage(bsiViewOptions, "View")
			ribbonControl.Items.Add(bsiViewOptions)
			ribbonPageGroup.ItemLinks.Add(bsiViewOptions)
		End Sub
		Public Sub RefreshOptionsMenu(ByVal pivotGrid As PivotGridControl)
			currentPivotGrid = pivotGrid
			ShowReservGroup1(pivotGrid IsNot Nothing)
			LookAndFeelMenu.ClearOptionItems(Manager)
			LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, New ItemClickEventHandler(AddressOf miViewOptions_Click), Manager)
		End Sub
		Private ReadOnly Property ViewOptions() As Object
			Get
				If currentPivotGrid Is Nothing Then
					Return Nothing
				End If
				Return currentPivotGrid.OptionsView
			End Get
		End Property
		Private Sub miViewOptions_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim item As OptionBarItem = TryCast(e.Item, OptionBarItem)
			If currentPivotGrid IsNot Nothing AndAlso item IsNot Nothing Then
				If currentPivotGrid.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Tree AndAlso item.Caption.Equals("ShowRowTotals") Then
                    XtraMessageBox.Show("The ShowRowTotals option must be enabled when the 'Tree' row area mode is used.")
				Else
					DevExpress.Utils.SetOptions.SetOptionValueByString(item.Caption, ViewOptions, item.Checked)
					RaiseViewOptionsChanged(item.Caption, item.Checked)
				End If
				LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions)
			End If
		End Sub
		Private Sub RaiseViewOptionsChanged(ByVal name As String, ByVal value As Boolean)
			RaiseEvent ViewOptionsChanged(Me, New ViewOptionsChangedEventArgs(name, value))
		End Sub
	End Class
	Public Class TutorialControl
		Inherits TutorialControlBase
        Private fDescription As System.Windows.Forms.Control = Nothing
		Private red_Renamed, green_Renamed, blue_Renamed As Color
		Private DefaultBlue As Color = Color.FromArgb(39, 63, 133), DefaultRed As Color = Color.FromArgb(169, 7, 7), DefaultGreen As Color = Color.FromArgb(42, 93, 1)
		Private Shared imlCategory As Object = Nothing
		Private Shared imlHeaders As Object = Nothing

		Private Shared CategoryNames() As String = {"Beverages", "Condiments", "Confections", "Dairy Products", "Grains/Cereals", "Meat/Poultry", "Produce", "Seafood"}
		Public Shared Function GetCategoryIndexByName(ByVal name As Object) As Integer
			If name IsNot Nothing Then
				For i As Integer = 0 To CategoryNames.Length - 1
					If CategoryNames(i) = name.ToString() Then
						Return i
					End If
				Next i
			End If
			Return -1
		End Function
		Public Shared ReadOnly Property CategoryImageList() As Object
			Get
				If imlCategory Is Nothing Then
					imlCategory = ImageHelper.CreateImageCollectionFromResourcesEx("DevExpress.XtraPivotGrid.Demos.Images.categories.bmp", GetType(TutorialControl).Assembly, New Size(16, 16), Color.Magenta)
				End If
				Return imlCategory
			End Get
		End Property
		Public Shared ReadOnly Property HeadersImageList() As Object
			Get
				If imlHeaders Is Nothing Then
					imlHeaders = ImageHelper.CreateImageCollectionFromResourcesEx("DevExpress.XtraPivotGrid.Demos.Images.headers.bmp", GetType(TutorialControl).Assembly, New Size(16, 16), Color.Magenta)
				End If
				Return imlHeaders
			End Get
		End Property

		Public Sub New()
		End Sub

		Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
			Dim grid As DevExpress.XtraPivotGrid.PivotGridControl = TryCast(ctrl, DevExpress.XtraPivotGrid.PivotGridControl)
			If grid IsNot Nothing Then
				grid.MenuManager = manager
			End If
		End Sub

        Public Property Description() As System.Windows.Forms.Control
            Get
                Return fDescription
            End Get
            Set(ByVal value As System.Windows.Forms.Control)
                fDescription = value
                OnSetDescription("")
            End Set
        End Property

		Protected Overridable Sub OnSetDescription(ByVal fDescription As String)
			If fDescription Is String.Empty Then
				Return
			End If
			Description.Text = String.Format(fDescription)
		End Sub
		Protected Overrides Sub AllowExport()
			EnabledPrintExportActions(True, ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.XLS Or ExportFormats.RTF Or ExportFormats.Text Or ExportFormats.XLSX, False)
		End Sub
		Public Overrides ReadOnly Property AllowPrintOptions() As Boolean
			Get
				Return ExportControl IsNot Nothing
			End Get
		End Property
		Public Overridable ReadOnly Property ExportControl() As PivotGridControl
			Get
				Return Nothing
			End Get
		End Property
		Public Overridable ReadOnly Property ViewOptionsControl() As PivotGridControl
			Get
				Return Nothing
			End Get
		End Property
		Public Overridable ReadOnly Property ShowLookAndFeelMenu() As Boolean
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property Red() As Color
			Get
				If red_Renamed.IsEmpty Then
					If LookAndFeel.ActiveStyle = ActiveLookAndFeelStyle.Skin Then
						red_Renamed = EditorsSkins.GetSkin(LookAndFeel).Colors.GetColor(EditorsSkins.SkinFilterControlGroupOperatorTextColor)
					End If
					If red_Renamed.IsEmpty OrElse red_Renamed = Color.Black Then
						red_Renamed = DefaultRed
					End If
				End If
				Return red_Renamed
			End Get
		End Property

		Public ReadOnly Property Blue() As Color
			Get
				If blue_Renamed.IsEmpty Then
					If LookAndFeel.ActiveStyle = ActiveLookAndFeelStyle.Skin Then
						blue_Renamed = EditorsSkins.GetSkin(LookAndFeel).Colors.GetColor(EditorsSkins.SkinFilterControlFieldNameTextColor)
					End If
					If blue_Renamed.IsEmpty OrElse blue_Renamed = Color.Black Then
						blue_Renamed = DefaultBlue
					End If
				End If
				Return blue_Renamed
			End Get
		End Property

		Public ReadOnly Property Green() As Color
			Get
				If green_Renamed.IsEmpty Then
					If LookAndFeel.ActiveStyle = ActiveLookAndFeelStyle.Skin Then
						green_Renamed = EditorsSkins.GetSkin(LookAndFeel).Colors.GetColor(EditorsSkins.SkinFilterControlOperatorTextColor)
					End If
					If green_Renamed.IsEmpty OrElse green_Renamed = Color.Black Then
						green_Renamed = DefaultGreen
					End If
				End If
				Return green_Renamed
			End Get
		End Property

		Protected Overrides Sub OnStyleChanged()
			MyBase.OnStyleChanged()
			red_Renamed = Color.Empty
			blue_Renamed = Color.Empty
			green_Renamed = Color.Empty
		End Sub

		Protected Overridable ReadOnly Property HideCustFormWhenSwitchDemo() As Boolean
			Get
				Return True
			End Get
		End Property
		Protected Overrides Sub DoHide()
			If HideCustFormWhenSwitchDemo Then
				FindPivotGridAndHideCustForm(Me)
			End If
		End Sub
		Private Sub FindPivotGridAndHideCustForm(ByVal control As Control)
			If control.Controls Is Nothing Then
				Return
			End If
			For Each ctrl As Control In control.Controls
				FindPivotGridAndHideCustForm(ctrl)
				Dim pivot As PivotGridControl = TryCast(ctrl, PivotGridControl)
				If pivot Is Nothing Then
					Continue For
				End If
				pivot.DestroyCustomization()
			Next ctrl
		End Sub

		Private dvTutorial As DataView = Nothing
		Protected Function GetNWindData(ByVal tableName As String) As DataView
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\nwind.mdb")
			If DBFileName <> "" Then
				Dim ds As New DataSet()
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
				Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tableName, con)
				SetWaitDialogCaption(String.Format("Loading {0}...", tableName))
				oleDbDataAdapter.Fill(ds, tableName)

				dvTutorial = ds.Tables(tableName).DefaultView
				Return dvTutorial
			End If
			Return Nothing
		End Function

		Public Function GetDataRowByIndex(ByVal index As Integer) As DataRowView
			If dvTutorial IsNot Nothing Then
				Return dvTutorial(index)
			End If
			Return Nothing
		End Function

		Protected Sub UpdateListBoxColor(ByVal listBox As BaseListBoxControl)
			If listBox.Parent.BackColor <> Color.Transparent Then
				listBox.BackColor = listBox.Parent.BackColor
			Else
				listBox.Appearance.Options.UseBackColor = False
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
            Try
			If ext = "rtf" Then
				ExportControl.ExportToRtf(filename)
			End If
			If ext = "pdf" Then
				ExportControl.ExportToPdf(filename)
			End If
			If ext = "mht" Then
				ExportControl.ExportToMht(filename)
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
            Finally
			EndExport()
			Cursor.Current = currentCursor
            End Try
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
			If ExportControl IsNot Nothing Then
				If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
					ExportControl.ShowRibbonPrintPreview()
				Else
					ExportControl.ShowPrintPreview()
				End If
			End If
		End Sub
		Private Sub StartExport()
			Thread.Sleep(400)
			If [stop] Then
				Return
			End If
			Dim progressForm As New ExportForm(Me.FindForm())
			progressForm.Show()
			Try
				Do While Not [stop]
					Application.DoEvents()
					Thread.Sleep(100)
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

	Public Class DemoFormatCondition
		Private fCondition As PivotGridStyleFormatCondition = Nothing
		Public Sub New(ByVal fCondition As PivotGridStyleFormatCondition)
			Me.fCondition = fCondition
		End Sub
		Public ReadOnly Property StyleCondition() As PivotGridStyleFormatCondition
			Get
				Return fCondition
			End Get
		End Property
		Public Overrides Function ToString() As String
			If StyleCondition Is Nothing Then
				Return "Empty condition"
			End If
			If (Not Comparer.Equals(StyleCondition.Condition, FormatConditionEnum.None)) Then
				If StyleCondition.Condition = FormatConditionEnum.Between OrElse StyleCondition.Condition = FormatConditionEnum.NotBetween Then
					Return String.Format("{0} {1:c}, {2:c}", StyleCondition.Condition, StyleCondition.Value1, StyleCondition.Value2)
				Else
					Return String.Format("{0} {1:c}", StyleCondition.Condition, StyleCondition.Value1)
				End If
			End If
			Return String.Format("Condition Item - Index {0}", Index)
		End Function
		Public ReadOnly Property Index() As Integer
			Get
				Return StyleCondition.PivotGrid.FormatConditions.IndexOf(StyleCondition)
			End Get
		End Property
	End Class
End Namespace

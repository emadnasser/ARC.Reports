Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports System.Drawing.Printing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils.Menu
Imports System.Collections

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Partial Public Class PrintControl
		Inherits RibbonApplicationUserControl
		Public Sub New()
            InitializeComponent()
            splitContainer1.Panel1MinSize = layoutControlGroup1.MinSize.Width + 6
			Me.ddbOrientation.DropDownControl = CreateOrientationGallery()
			Me.ddbMargins.DropDownControl = CreateMarginsGallery()
			Me.ddbPaperSize.DropDownControl = CreatePageSizeGallery()
			Me.ddbCollate.DropDownControl = CreateCollateGallery()
			Me.ddbPrinter.DropDownControl = CreatePrintersGallery()
			Me.ddbDuplex.DropDownControl = CreateDuplexGallery()
		End Sub
		Private Function GetZoomValue() As Integer
			If zoomTrackBarControl1.Value <= 40 Then
                Return 10 + 90 * (zoomTrackBarControl1.Value - 0) \ 40
			Else
                Return 100 + 400 * (zoomTrackBarControl1.Value - 40) \ 40
			End If
		End Function
		Private Function ZoomValueToValue(ByVal zoomValue As Integer) As Integer
			If zoomValue < 100 Then
				Return Math.Min(80, Math.Max(0, (zoomValue - 10) * 40 \ 90))
			End If
			Return Math.Min(80, Math.Max(0, (zoomValue - 100) * 40 \ 400 + 40))
		End Function
		Private rtfText_Renamed As String
		Public Property RtfText() As String
			Get
				Return rtfText_Renamed
			End Get
			Set(ByVal value As String)
				rtfText_Renamed = value
				InitPrintingSystem()
			End Set
		End Property
		Private Sub zoomTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles zoomTrackBarControl1.EditValueChanged
			zoomTextEdit.EditValue = GetZoomValue()
		End Sub
		Protected Overrides Sub OnVisibleChanged(ByVal e As EventArgs)
			MyBase.OnVisibleChanged(e)
			If Visible Then
				InitPrintingSystem()
			End If
		End Sub
		Private Sub InitPrintingSystem()
			Dim manager As BarManager = GetManager()
			CType(Me.ddbOrientation.DropDownControl, GalleryDropDown).Manager = manager
			CType(Me.ddbMargins.DropDownControl, GalleryDropDown).Manager = manager
			CType(Me.ddbPaperSize.DropDownControl, GalleryDropDown).Manager = manager
			CType(Me.ddbCollate.DropDownControl, GalleryDropDown).Manager = manager
			CType(Me.ddbPrinter.DropDownControl, GalleryDropDown).Manager = manager
			CType(Me.ddbDuplex.DropDownControl, GalleryDropDown).Manager = manager
			Dim ps As New PrintingSystem()
			Me.printControl1.PrintingSystem = ps
			AddHandler ps.StartPrint, AddressOf OnStartPrint
			Dim link As New Link(ps)
			link.RtfReportHeader = RtfText
			link.CreateDocument()
			Me.printButton.Enabled = ps.Pages.Count > 0
			Me.pageButtonEdit.Enabled = ps.Pages.Count > 0
			Me.pageButtonEdit.Properties.DisplayFormat.FormatString = "Page {0} of " & ps.Pages.Count
            Me.pageButtonEdit.EditValue = 1
            UpdatePrintPageSettings()
		End Sub
        Private Function GetManager() As BarManager
			Dim bsvc As BackstageViewControl = TryCast(FindControl(Me, GetType(BackstageViewControl)), BackstageViewControl)
			If bsvc Is Nothing OrElse bsvc.Ribbon Is Nothing Then
				Return Nothing
			End If
			Return bsvc.Ribbon.Manager
        End Function
		Private Function FindControl(ByVal control As Control, ByVal target As Type) As Control
			Dim current As Control = control
			Do While current IsNot Nothing
				If current.GetType() Is target Then
					Return current
				End If
				current = current.Parent
			Loop
			Return Nothing
		End Function
		Private Sub OnStartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
			e.PrintDocument.PrinterSettings.Copies = CShort(Fix(Me.copySpinEdit.Value))
			Dim p As Padding = CType(Me.ddbMargins.Tag, Padding)
			Me.printControl1.PrintingSystem.PageSettings.TopMargin = CInt(Fix(p.Top * 3.9))
			Me.printControl1.PrintingSystem.PageSettings.BottomMargin = CInt(Fix(p.Bottom * 3.9))
			Me.printControl1.PrintingSystem.PageSettings.LeftMargin = CInt(Fix(p.Left * 3.9))
			Me.printControl1.PrintingSystem.PageSettings.RightMargin = CInt(Fix(p.Right * 3.9))
			e.PrintDocument.PrinterSettings.Collate = CBool(Me.ddbCollate.Tag)
			If (CBool(Me.ddbDuplex.Tag)) Then
				e.PrintDocument.PrinterSettings.Duplex = Duplex.Horizontal
			Else
				e.PrintDocument.PrinterSettings.Duplex = Duplex.Simplex
			End If
		End Sub
		Private Sub zoomTextEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles zoomTextEdit.EditValueChanged
			Try
				Dim zoomValue As Integer = Int32.Parse(CStr(zoomTextEdit.EditValue.ToString()))
				Me.zoomTrackBarControl1.Value = ZoomValueToValue(zoomValue)
				Me.printControl1.Zoom = 0.01f * CInt(Fix(zoomValue))
			Catch e1 As Exception
			End Try
		End Sub
		Private Function CreateListBoxGallery() As GalleryDropDown
			Dim res As New GalleryDropDown()
			res.Gallery.FixedImageSize = False
			res.Gallery.ShowItemText = True
			res.Gallery.ColumnCount = 1
			res.Gallery.CheckDrawMode = CheckDrawMode.OnlyImage
			res.Gallery.ShowGroupCaption = False
			res.Gallery.AutoSize = GallerySizeMode.Vertical
			res.Gallery.SizeMode = GallerySizeMode.None
			res.Gallery.ShowScrollBar = ShowScrollBar.Hide
			res.Gallery.ItemCheckMode = ItemCheckMode.SingleRadio

            res.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            res.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            res.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            res.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            res.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            res.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True

            res.Gallery.Groups.Add(New GalleryItemGroup())
			res.Gallery.StretchItems = True

			Return res
		End Function
		Private Function CreateOrientationGallery() As GalleryDropDown
			Dim res As GalleryDropDown = CreateListBoxGallery()
			Dim portraitItem As New GalleryItem()
            portraitItem.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageOrientationPortrait
			portraitItem.Caption = "Portrait Orientation"
			Dim landscapeItem As New GalleryItem()
            landscapeItem.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageOrientationLandscape
			landscapeItem.Caption = "Landscape Orientation"
			res.Gallery.Groups(0).Items.Add(portraitItem)
			res.Gallery.Groups(0).Items.Add(landscapeItem)
			AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnOrientationGalleryItemCheckedChanged
			portraitItem.Checked = True
			Return res
		End Function
		Private Function CreateMarginsGallery() As GalleryDropDown
			Dim res As GalleryDropDown = CreateListBoxGallery()
			Dim normal As New GalleryItem()
            normal.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageMarginsNormal
			normal.Caption = "Normal"
			normal.Description = "Top:" & Constants.vbTab & "25 mm" & Constants.vbTab & "Bottom:" & Constants.vbTab & "25 mm" & Constants.vbLf & "Left:" & Constants.vbTab & "25 mm" & Constants.vbTab & "Right:" & Constants.vbTab & "25 mm"
			normal.Tag = New Padding(25, 25, 25, 25)
			Dim narrow As New GalleryItem()
            narrow.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageMarginsNarrow
			narrow.Caption = "Narrow"
			narrow.Description = "Top:" & Constants.vbTab & "12 mm" & Constants.vbTab & "Bottom:" & Constants.vbTab & "12 mm" & Constants.vbLf & "Left:" & Constants.vbTab & "12 mm" & Constants.vbTab & "Right:" & Constants.vbTab & "12 mm"
			narrow.Tag = New Padding(12, 12, 12, 12)
			Dim moderate As New GalleryItem()
            moderate.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageMarginsModerate
			moderate.Caption = "Moderate"
			moderate.Description = "Top:" & Constants.vbTab & "25 mm" & Constants.vbTab & "Bottom:" & Constants.vbTab & "25 mm" & Constants.vbLf & "Left:" & Constants.vbTab & "19 mm" & Constants.vbTab & "Right:" & Constants.vbTab & "19 mm"
			moderate.Tag = New Padding(19, 25, 19, 25)
			Dim wide As New GalleryItem()
            wide.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageMarginsWide
			wide.Caption = "Wide"
			wide.Description = "Top:" & Constants.vbTab & "25 mm" & Constants.vbTab & "Bottom:" & Constants.vbTab & "25 mm" & Constants.vbLf & "Left:" & Constants.vbTab & "50 mm" & Constants.vbTab & "Right:" & Constants.vbTab & "50 mm"
			wide.Tag = New Padding(50, 25, 50, 25)
			res.Gallery.Groups(0).Items.Add(normal)
			res.Gallery.Groups(0).Items.Add(narrow)
			res.Gallery.Groups(0).Items.Add(moderate)
			res.Gallery.Groups(0).Items.Add(wide)
			AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnMarginsGalleryItemCheckedChanged
			normal.Checked = True
			Return res
		End Function
		Private Function CreatePageSizeGallery() As GalleryDropDown
			Dim res As GalleryDropDown = CreateListBoxGallery()
			Dim letter As New GalleryItem()
            letter.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_Letter
			letter.Caption = "Letter"
			letter.Description = "215 mm x 279 mm"
			letter.Tag = PaperKind.Letter
			Dim tabloid As New GalleryItem()
            tabloid.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_Tabloid
			tabloid.Caption = "Tabloid"
			tabloid.Description = "279 mm x 431 mm"
			tabloid.Tag = PaperKind.Tabloid
			Dim legal As New GalleryItem()
            legal.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_Legal
			legal.Caption = "Legal"
			legal.Description = "215 mm x 355 mm"
			legal.Tag = PaperKind.Legal
			Dim executive As New GalleryItem()
            executive.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_Executive
			executive.Caption = "Executive"
			executive.Description = "184 mm x 266 mm"
			executive.Tag = PaperKind.Executive
			Dim a3 As New GalleryItem()
            a3.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_A3
			a3.Caption = "A3"
			a3.Description = "296 mm x 420 mm"
			a3.Tag = PaperKind.A3
			Dim a4 As New GalleryItem()
            a4.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_A4
			a4.Caption = "A4"
			a4.Description = "210 mm x 296 mm"
			a4.Tag = PaperKind.A4
			Dim a5 As New GalleryItem()
            a5.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_A5
			a5.Caption = "A5"
			a5.Description = "148 mm x 210 mm"
			a5.Tag = PaperKind.A5
			Dim a6 As New GalleryItem()
            a6.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_A6
			a6.Caption = "A6"
			a6.Description = "105 mm x 148 mm"
			a6.Tag = PaperKind.A6
			res.Gallery.Groups(0).Items.Add(letter)
			res.Gallery.Groups(0).Items.Add(tabloid)
			res.Gallery.Groups(0).Items.Add(legal)
			res.Gallery.Groups(0).Items.Add(executive)
			res.Gallery.Groups(0).Items.Add(a3)
			res.Gallery.Groups(0).Items.Add(a4)
			res.Gallery.Groups(0).Items.Add(a5)
			res.Gallery.Groups(0).Items.Add(a6)
			AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnPaperSizeGalleryItemCheckedChanged
			a4.Checked = True
			Return res
		End Function
		Private Function CreateCollateGallery() As GalleryDropDown
			Dim res As GalleryDropDown = CreateListBoxGallery()
			Dim collated As New GalleryItem()
            collated.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.MultiplePagesLarge
			collated.Caption = "Collated"
			collated.Description = "1,2,3   1,2,3  1,2,3"
			collated.Tag = True
			Dim uncollated As New GalleryItem()
            uncollated.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.MultiplePagesLarge
			uncollated.Caption = "Uncollated"
			uncollated.Description = "1,1,1  2,2,2  3,3,3"
			uncollated.Tag = False
			res.Gallery.Groups(0).Items.Add(collated)
			res.Gallery.Groups(0).Items.Add(uncollated)
			AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnCollateGalleryItemCheckedChanged
			collated.Checked = True
			Return res
		End Function
		Private Function CreateDuplexGallery() As GalleryDropDown
			Dim res As GalleryDropDown = CreateListBoxGallery()
			Dim oneSided As New GalleryItem()
            oneSided.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.MultiplePagesLarge
			oneSided.Caption = "Print One Sided"
			oneSided.Description = "Only print on one side of the page"
			oneSided.Tag = False
			Dim twoSided As New GalleryItem()
            twoSided.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.MultiplePagesLarge
			twoSided.Caption = "Manually Print on Both Sides"
			twoSided.Description = "Reload paper when prompted to print the second side"
			twoSided.Tag = False
			res.Gallery.Groups(0).Items.Add(oneSided)
			res.Gallery.Groups(0).Items.Add(twoSided)
			AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnDuplexGalleryItemCheckedChanged
			oneSided.Checked = True
			Return res
		End Function
        Private Sub OnDuplexGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdatePrintPageDuplex(e.Item)
        End Sub
		Private Function CreatePrintersGallery() As GalleryDropDown
			Dim res As GalleryDropDown = CreateListBoxGallery()
			Dim ps As New PrinterSettings()
			Dim defaultPrinter As GalleryItem = Nothing
            Try
                For Each str As String In PrinterSettings.InstalledPrinters
                    Dim item As New GalleryItem()
                    item.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PrintDirectLarge
                    item.Caption = str
                    res.Gallery.Groups(0).Items.Add(item)
                    ps.PrinterName = str
                    If ps.IsDefaultPrinter Then
                        defaultPrinter = item
                    End If
                Next str
            Catch
            End Try
			AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnPrinterGalleryItemCheckedChanged
			If defaultPrinter IsNot Nothing Then
				defaultPrinter.Checked = True
			End If
			Return res
		End Function
        Private Sub OnMarginsGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdatePrintPageMargins(e.Item)
        End Sub
        Private Sub OnPrinterGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdatePrintPagePrinters(e.Item)
        End Sub
        Private Sub OnCollateGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdatePrintPageCollate(e.Item)
        End Sub
        Private Sub OnPaperSizeGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdatePrintPageSize(e.Item)
        End Sub
        Private Sub OnOrientationGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdatePrintPageOrientation(e.Item)
        End Sub
        Public Sub UpdatePrintPageSettings()
            If ddbOrientation.DropDownControl IsNot Nothing Then
                UpdatePrintPageOrientation((CType(ddbOrientation.DropDownControl, GalleryDropDown)).Gallery.GetCheckedItem())
            End If
            If ddbMargins.DropDownControl IsNot Nothing Then
                UpdatePrintPageMargins((CType(ddbMargins.DropDownControl, GalleryDropDown)).Gallery.GetCheckedItem())
            End If
            If ddbPaperSize.DropDownControl IsNot Nothing Then
                UpdatePrintPageSize((CType(ddbPaperSize.DropDownControl, GalleryDropDown)).Gallery.GetCheckedItem())
            End If
            If ddbCollate.DropDownControl IsNot Nothing Then
                UpdatePrintPageCollate((CType(ddbCollate.DropDownControl, GalleryDropDown)).Gallery.GetCheckedItem())
            End If
            If ddbPrinter.DropDownControl IsNot Nothing Then
                UpdatePrintPagePrinters((CType(ddbPrinter.DropDownControl, GalleryDropDown)).Gallery.GetCheckedItem())
            End If
            If ddbDuplex.DropDownControl IsNot Nothing Then
                UpdatePrintPageDuplex((CType(ddbDuplex.DropDownControl, GalleryDropDown)).Gallery.GetCheckedItem())
            End If
        End Sub
        Private Sub UpdatePrintPageOrientation(ByVal item As GalleryItem)
            If item Is Nothing Then
                Return
            End If
            ddbOrientation.Text = item.Caption
            ddbOrientation.Image = item.Image
            If ddbOrientation.DropDownControl IsNot Nothing Then
                Me.printControl1.PrintingSystem.PageSettings.Landscape = (CType(ddbOrientation.DropDownControl, GalleryDropDown)).Gallery.Groups(0).Items(1).Checked
            End If
        End Sub
        Private Sub UpdatePrintPageMargins(ByVal item As GalleryItem)
            If item Is Nothing Then
                Return
            End If
            Me.ddbMargins.Image = item.Image
            Me.ddbMargins.Text = item.Caption
            Me.ddbMargins.Tag = item.Tag
            Dim p As Padding = CType(item.Tag, Padding)
            If Me.printControl1.PrintingSystem IsNot Nothing Then
                Me.printControl1.PrintingSystem.PageSettings.TopMargin = CInt(Fix(p.Top * 3.9))
                Me.printControl1.PrintingSystem.PageSettings.BottomMargin = CInt(Fix(p.Bottom * 3.9))
                Me.printControl1.PrintingSystem.PageSettings.LeftMargin = CInt(Fix(p.Left * 3.9))
                Me.printControl1.PrintingSystem.PageSettings.RightMargin = CInt(Fix(p.Right * 3.9))
            End If
        End Sub
        Private Sub UpdatePrintPageSize(ByVal item As GalleryItem)
            If item Is Nothing Then
                Return
            End If
            Me.ddbPaperSize.Image = item.Image
            Me.ddbPaperSize.Text = item.Caption
            If Me.printControl1.PrintingSystem IsNot Nothing Then
                Me.printControl1.PrintingSystem.PageSettings.PaperKind = CType(item.Tag, PaperKind)
            End If
        End Sub
        Private Sub UpdatePrintPageCollate(ByVal item As GalleryItem)
            If item Is Nothing Then
                Return
            End If
            Me.ddbCollate.Image = item.Image
            Me.ddbCollate.Text = item.Caption
            Me.ddbCollate.Tag = item.Tag
        End Sub
        Private Sub UpdatePrintPagePrinters(ByVal item As GalleryItem)
            If item Is Nothing Then
                Return
            End If
            Me.ddbPrinter.Text = item.Caption
            Me.ddbPrinter.Image = item.Image
        End Sub
        Private Sub UpdatePrintPageDuplex(ByVal item As GalleryItem)
            If item Is Nothing Then
                Return
            End If
            Me.ddbDuplex.Text = item.Caption
            Me.ddbDuplex.Image = item.Image
            Me.ddbDuplex.Tag = item.Tag
        End Sub

		Private Sub pageButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles pageButtonEdit.ButtonClick
			Dim pageIndex As Integer = CInt(Fix(Me.pageButtonEdit.EditValue))
			If e.Button.Kind = ButtonPredefines.Left Then
				If pageIndex > 1 Then
					pageIndex -= 1
				End If
			ElseIf e.Button.Kind = ButtonPredefines.Right Then
				If pageIndex < Me.printControl1.PrintingSystem.Pages.Count Then
					pageIndex += 1
				End If
			End If
			Me.pageButtonEdit.EditValue = pageIndex
		End Sub

		Private Sub pageButtonEdit_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs) Handles pageButtonEdit.EditValueChanging
			Try
				Dim pageIndex As Integer = Int32.Parse(e.NewValue.ToString())
				If pageIndex < 1 Then
					pageIndex = 1
				ElseIf pageIndex > Me.printControl1.PrintingSystem.Pages.Count Then
					pageIndex = Me.printControl1.PrintingSystem.Pages.Count
				End If
				e.NewValue = pageIndex
			Catch e1 As Exception
				e.NewValue = 1
			End Try
		End Sub
		Private Sub UpdatePageButtonsEnabledState(ByVal pageIndex As Integer)
            If Me.pageButtonEdit.Properties.Buttons.Count = 0 Then
                Return
            End If
            Me.pageButtonEdit.Properties.Buttons(0).Enabled = pageIndex <> 1
			Me.pageButtonEdit.Properties.Buttons(1).Enabled = pageIndex <> Me.printControl1.PrintingSystem.Pages.Count
		End Sub
		Private Sub pageButtonEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pageButtonEdit.EditValueChanged
			Dim pageIndex As Integer = CInt(Fix(Me.pageButtonEdit.EditValue))
			Me.printControl1.SelectedPageIndex = pageIndex - 1
			UpdatePageButtonsEnabledState(pageIndex)
		End Sub

        Private Sub printControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs) Handles printControl1.SelectedPageChanged
            Me.pageButtonEdit.EditValue = Me.printControl1.SelectedPageIndex + 1
        End Sub
	End Class
End Namespace

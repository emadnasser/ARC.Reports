Imports Microsoft.VisualBasic
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports System.Drawing.Printing
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPrinting.Control

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetCustomViewModule
		Inherits TutorialControlBase
		#Region "fields"
		Private book As IWorkbook
		Private link As PrintableComponentLinkBase
		#End Region

		Public Sub New()
			InitializeComponent()
			InitPreviewControl()
			InitRadiogroups()
			InitPaperKindBox()
			RefreshPreview()
		End Sub

		Private Sub InitPreviewControl()
			book = New Workbook()
			book.Options.Culture = CultureInfo.InvariantCulture
			book.LoadDocument(DemoUtils.GetRelativePath("CustomView_template.xlsx"))
			previewControl.PrintingSystem = New PrintingSystem()
			link = New PrintableComponentLinkBase(Me.previewControl.PrintingSystem)
			link.Component = book
			book.Unit = DevExpress.Office.DocumentUnit.Inch
			previewControl.PrintingSystem.Graph.PageUnit = System.Drawing.GraphicsUnit.Document
			book.Worksheets(0).Cells(0, 0).Value = String.Empty
			previewControl.ExecCommand(PrintingSystemCommand.ZoomToWholePage)
		End Sub
		Private Sub InitRadiogroups()
			For Each currentValue As PageOrientation In EnumHelper.GetValues(Of PageOrientation)()
				pageOrientationGroup.Properties.Items.Add(New RadioGroupItem(currentValue, currentValue.ToString()))
			Next currentValue
			pageOrientationGroup.SelectedIndex = 2
			viewTypeGroup.Properties.Items.Add(New RadioGroupItem(WorksheetViewType.Normal, "Normal"))
			viewTypeGroup.Properties.Items.Add(New RadioGroupItem(WorksheetViewType.PageBreakPreview, "Page Break Preview"))
			viewTypeGroup.Properties.Items.Add(New RadioGroupItem(WorksheetViewType.PageLayout, "Page Layout"))
			viewTypeGroup.SelectedIndex = 0
		End Sub
		Private Sub InitPaperKindBox()
			For Each currentValue As PaperKind In EnumHelper.GetValues(Of PaperKind)()
				If currentValue <> PaperKind.Custom Then
					paperKindBox.Properties.Items.Add(currentValue)
				End If
			Next currentValue
			paperKindBox.SelectedItem = book.Worksheets(0).ActiveView.PaperKind
		End Sub
		Private Sub RefreshPreview()
			If previewControl IsNot Nothing Then
				link.CreateDocument()
			End If
		End Sub

		Private Sub zoomTrackBar_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles zoomTrackBar.EditValueChanged
			zoomLabel.Text = String.Format("Zoom {0}" & (If(zoomTrackBar.Value > 99, "", "  ")) & "%:", zoomTrackBar.Value)
		End Sub
		Private Sub paperKindBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles paperKindBox.SelectedIndexChanged
			Dim paperKind As PaperKind = CType(paperKindBox.SelectedItem, PaperKind)
			previewControl.PrintingSystem.PageSettings.PaperKind = paperKind
			book.Worksheets(0).ActiveView.PaperKind = paperKind
			RefreshPreview()
		End Sub
		Private Sub pageOrientationGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pageOrientationGroup.SelectedIndexChanged
			Dim orientation As PageOrientation = CType(pageOrientationGroup.Properties.Items(pageOrientationGroup.SelectedIndex).Value, PageOrientation)
			previewControl.PrintingSystem.PageSettings.Landscape = PageOrientation.Landscape.Equals(orientation)
			book.Worksheets(0).ActiveView.Orientation = orientation
			RefreshPreview()
		End Sub
		Private Sub topMarginEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles topMarginEdit.EditValueChanged
			book.Worksheets(0).ActiveView.Margins.Top = CSng(topMarginEdit.Value)
			previewControl.PrintingSystem.PageMargins.Top = CInt(Fix(topMarginEdit.Value * 300))
			RefreshPreview()
		End Sub
		Private Sub bottomMarginEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bottomMarginEdit.EditValueChanged
			book.Worksheets(0).ActiveView.Margins.Bottom = CSng(bottomMarginEdit.Value)
			previewControl.PrintingSystem.PageMargins.Bottom = CInt(Fix(bottomMarginEdit.Value * 300))
			RefreshPreview()
		End Sub
		Private Sub leftMarginEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles leftMarginEdit.EditValueChanged
			book.Worksheets(0).ActiveView.Margins.Left = CSng(leftMarginEdit.Value)
			previewControl.PrintingSystem.PageMargins.Left = CInt(Fix(leftMarginEdit.Value * 300))
			RefreshPreview()
		End Sub
		Private Sub rightMarginEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rightMarginEdit.EditValueChanged
			book.Worksheets(0).ActiveView.Margins.Right = CSng(rightMarginEdit.Value)
			previewControl.PrintingSystem.PageMargins.Right = CInt(Fix(rightMarginEdit.Value * 300))
			RefreshPreview()
		End Sub
		Private Sub headerMarginEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles headerMarginEdit.EditValueChanged
			book.Worksheets(0).ActiveView.Margins.Header = CSng(headerMarginEdit.Value)
		End Sub
		Private Sub footerMarginEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles footerMarginEdit.EditValueChanged
			book.Worksheets(0).ActiveView.Margins.Footer = CSng(footerMarginEdit.Value)
		End Sub
		Private Sub saveButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles saveButton.Click
			Dim fileName As String = SpreadsheetTutorialControl.GetSaveFileName("Xlsx files(*.xlsx)|*.xlsx|All files (*.*)|*.*", "Custom_View")
			If (Not String.IsNullOrEmpty(fileName)) Then
				book.DocumentSettings.R1C1ReferenceStyle = useR1C1StyleCheckEdit.Checked
				Dim sheet As Worksheet = book.Worksheets(0)
				sheet.ActiveView.Zoom = zoomTrackBar.Value
				sheet.ActiveView.ShowGridlines = showGridCheckEdit.Checked
				sheet.ActiveView.ShowHeadings = showHeadingsCheckEdit.Checked
				sheet.ActiveView.TabColor = tabColodEdit.Color
				sheet.ActiveView.ViewType = CType(viewTypeGroup.Properties.Items(viewTypeGroup.SelectedIndex).Value, WorksheetViewType)

				book.SaveDocument(fileName, DocumentFormat.OpenXml)
			End If
			SpreadsheetTutorialControl.ShowFile(fileName, Me)
		End Sub
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports System.Drawing.Imaging

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Partial Public Class ExportControl
		Inherits RibbonApplicationUserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private rtfText_Renamed As String
		Public Property RtfText() As String
			Get
				Return rtfText_Renamed
			End Get
			Set(ByVal value As String)
				rtfText_Renamed = value
			End Set
		End Property
		Private Sub galleryControlGallery1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles exportGallery.Gallery.ItemClick
			If e.Item.Caption.Contains("PDF") Then
				saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf"
			ElseIf e.Item.Caption.Contains("HTML") Then
				saveFileDialog1.Filter = "HTML files (*.html)|*.html"
			ElseIf e.Item.Caption.Contains("MHT") Then
				saveFileDialog1.Filter = "MHT files (*.mht)|*.mht"
			ElseIf e.Item.Caption.Contains("RTF") Then
				saveFileDialog1.Filter = "RTF files (*.rtf)|*.rtf"
			ElseIf e.Item.Caption.Contains("XLS") Then
				saveFileDialog1.Filter = "XLS files (*.xls)|*.xls"
			ElseIf e.Item.Caption.Contains("XLSX") Then
				saveFileDialog1.Filter = "XLSX files (*.xls)|*.xls"
			ElseIf e.Item.Caption.Contains("CSV") Then
				saveFileDialog1.Filter = "CSV files (*.csv)|*.csv"
			ElseIf e.Item.Caption.Contains("Text File") Then
				saveFileDialog1.Filter = "Text files (*.txt)|*.txt"
			ElseIf e.Item.Caption.Contains("Image") Then
				saveFileDialog1.Filter = "BMP files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|Jpeg files (*.jpeg)|*.jpeg|PNG files (*.png)|*.png|Tiff files (*.tiff)|*.tiff|EMF files (*.emf)|.emf|WMF files (*.wmf)|*.wmf"
			End If
			saveFileDialog1.Filter &= "|All files (*.*)|*.*"
			saveFileDialog1.FilterIndex = 0
			If saveFileDialog1.ShowDialog() <> DialogResult.OK Then
				Return
			End If
			Dim ps As New PrintingSystem()
			Dim link As New Link(ps)
			link.RtfReportHeader = RtfText
			link.CreateDocument()
			If e.Item.Caption.Contains("PDF") Then
				ps.ExportToPdf(saveFileDialog1.FileName)
			ElseIf e.Item.Caption.Contains("HTML") Then
				ps.ExportToHtml(saveFileDialog1.FileName)
			ElseIf e.Item.Caption.Contains("MHT") Then
				ps.ExportToMht(saveFileDialog1.FileName)
			ElseIf e.Item.Caption.Contains("RTF") Then
				ps.ExportToRtf(saveFileDialog1.FileName)
			ElseIf e.Item.Caption.Contains("XLS") Then
				ps.ExportToXls(saveFileDialog1.FileName)
			ElseIf e.Item.Caption.Contains("XLSX") Then
				ps.ExportToXlsx(saveFileDialog1.FileName)
			ElseIf e.Item.Caption.Contains("CSV") Then
				ps.ExportToCsv(saveFileDialog1.FileName)
			ElseIf e.Item.Caption.Contains("Text File") Then
				ps.ExportToText(saveFileDialog1.FileName)
			ElseIf e.Item.Caption.Contains("Image") Then
				Dim fmt As ImageFormat = ImageFormat.Bmp
				Select Case saveFileDialog1.FilterIndex
					Case 0
						fmt = ImageFormat.Bmp
					Case 1
						fmt = ImageFormat.Gif
					Case 2
						fmt = ImageFormat.Jpeg
					Case 3
						fmt = ImageFormat.Png
					Case 4
						fmt = ImageFormat.Tiff
					Case 5
						fmt = ImageFormat.Emf
					Case 6
						fmt = ImageFormat.Wmf
				End Select
				ps.ExportToImage(saveFileDialog1.FileName, fmt)
			End If
		End Sub
	End Class
End Namespace

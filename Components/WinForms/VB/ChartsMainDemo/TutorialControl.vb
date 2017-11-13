Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraCharts.Printing
Imports DevExpress.XtraPrinting

Namespace DevExpress.XtraCharts.Demos

	Public Class TutorialControl
		Inherits TutorialControlBase
		Private Class ImageFormatInfo
			Private imageCodecInfo_Renamed As ImageCodecInfo
			Private imageFormat_Renamed As ImageFormat

			Public ReadOnly Property ImageCodecInfo() As ImageCodecInfo
				Get
					Return imageCodecInfo_Renamed
				End Get
			End Property
			Public ReadOnly Property ImageFormat() As ImageFormat
				Get
					Return imageFormat_Renamed
				End Get
			End Property

			Public Sub New(ByVal imageCodecInfo As ImageCodecInfo, ByVal imageFormat As ImageFormat)
				Me.imageCodecInfo_Renamed = imageCodecInfo
				Me.imageFormat_Renamed = imageFormat
			End Sub
		End Class

		Public Property MenuManager() As IDXMenuManager
		Public ReadOnly Property ChartRibbonMenuManager() As ChartRibbonMenuManager
			Get
				Return TryCast(RibbonMenuManager, ChartRibbonMenuManager)
			End Get
		End Property
		Public Overridable ReadOnly Property ChartControl() As ChartControl
			Get
				Return Nothing
			End Get
		End Property
		Public Overridable ReadOnly Property ExportedObject() As Object
			Get
				Return ChartControl
			End Get
		End Property
		Public Overrides ReadOnly Property AllowPrintOptions() As Boolean
			Get
				Return ChartControl IsNot Nothing
			End Get
		End Property

		Private Function GetSupportedImageFormats() As List(Of ImageFormatInfo)
			Dim formats As New List(Of ImageFormat) (New ImageFormat() {ImageFormat.Bmp, ImageFormat.Emf, ImageFormat.Exif, ImageFormat.Gif, ImageFormat.Icon, ImageFormat.Jpeg, ImageFormat.Png, ImageFormat.Tiff, ImageFormat.Wmf})
			Dim result As New List(Of ImageFormatInfo)()
			Dim infos() As ImageCodecInfo = ImageCodecInfo.GetImageEncoders()
			For Each imageFormat As ImageFormat In formats
				For Each imageCodecInfo As ImageCodecInfo In infos
					If imageCodecInfo.FormatID.Equals(imageFormat.Guid) Then
						result.Add(New ImageFormatInfo(imageCodecInfo, imageFormat))
					End If
				Next imageCodecInfo
			Next imageFormat
			Return result
		End Function

		Protected Overrides Sub AllowExport()
			EnabledPrintExportActions(True, ExportFormats.Image Or ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.XLS Or ExportFormats.RTF Or ExportFormats.XLSX, False)
		End Sub
		Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
			Dim chart As ChartControl = ChartControl
			If chart IsNot Nothing Then
				Dim currentCursor As Cursor = Cursor.Current
				Cursor.Current = Cursors.WaitCursor
				chart.OptionsPrint.SizeMode = PrintSizeMode.None
				If ext = "rtf" Then
					chart.ExportToRtf(filename)
				ElseIf ext = "pdf" Then
					chart.OptionsPrint.SizeMode = PrintSizeMode.Zoom
					chart.OptionsPrint.ImageFormat = PrintImageFormat.Metafile
					Dim options As New PdfExportOptions()
					options.ConvertImagesToJpeg = False
					chart.ExportToPdf(filename, options)
				ElseIf ext = "mht" Then
					chart.ExportToMht(filename)
				ElseIf ext = "html" Then
					chart.ExportToHtml(filename)
				ElseIf ext = "xls" Then
					chart.ExportToXls(filename)
				ElseIf ext = "xlsx" Then
					chart.ExportToXlsx(filename)
				End If
				Cursor.Current = currentCursor
			End If
		End Sub
		Protected Overrides Sub ExportToImage()
			Dim chart As ChartControl = ChartControl
			If chart IsNot Nothing Then
				chart.OptionsPrint.SizeMode = PrintSizeMode.None
				Dim formats As List(Of ImageFormatInfo) = GetSupportedImageFormats()
				If formats.Count > 0 Then
					Dim fileFormat As String = String.Empty
					For Each format As ImageFormatInfo In formats
						fileFormat &= String.Format("{0} ({1})|{1}", String.Format("{0} image", format.ImageCodecInfo.FormatDescription), format.ImageCodecInfo.FilenameExtension) & "|"
					Next format
					fileFormat = fileFormat.TrimEnd("|"c)
					Dim filePath As String = MainFormHelper.GetFileName("", fileFormat)
					If (Not String.IsNullOrEmpty(filePath)) Then
						Dim extension As String = System.IO.Path.GetExtension(filePath)
						If (Not String.IsNullOrEmpty(extension)) Then
							extension = extension.ToUpper()
							For Each format As ImageFormatInfo In formats
								If format.ImageCodecInfo.FilenameExtension.Contains(extension) Then
									chart.ExportToImage(filePath, format.ImageFormat)
									Exit For
								End If
							Next format
						End If
					End If
				End If
			End If
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
			Dim chart As ChartControl = ChartControl
			If chart IsNot Nothing Then
				chart.OptionsPrint.SizeMode = PrintSizeMode.Zoom
				chart.OptionsPrint.ImageFormat = PrintImageFormat.Metafile
				If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
					chart.ShowRibbonPrintPreview()
				Else
					chart.ShowPrintPreview()
				End If
			End If
		End Sub
	End Class
End Namespace

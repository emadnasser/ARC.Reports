Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.Spreadsheet
Imports System.Globalization
Imports System.Windows.Forms

Namespace DevExpress.Docs.Demos
	Public Class SpreadsheetPictureGalleryModule
		Inherits SpreadsheetTutorialControl
		Public Sub New()
			FitToPageCheckEdit.Checked = True
			RefreshPreview()
			SpreadsheetTutorialPanel.Dock = DockStyle.Fill
		End Sub

		Protected Overrides ReadOnly Property DefaultFileName() As String
			Get
				Return "Picture_Gallery"
			End Get
		End Property
		Protected Overrides ReadOnly Property DefaultSaveFileFilter() As String
			Get
				Return "Excel Workbook(*.xlsx)|*.xlsx|PDF(*.pdf)|*.pdf"
			End Get
		End Property

		Public Overrides Function CreateBook() As IWorkbook
			Dim book As IWorkbook = New Workbook()
			book.Options.Culture = DefaultCulture
			book.Worksheets(0).ActiveView.Orientation = DevExpress.Spreadsheet.PageOrientation.Landscape
			book.Worksheets(0).ActiveView.PaperKind = System.Drawing.Printing.PaperKind.A4
			book.Worksheets(0).ActiveView.Margins.Left = 300
			book.Worksheets(0).ActiveView.Margins.Top = 300
			book.Worksheets(0).PrintOptions.FitToPage = FitToPageCheckEdit.Checked

			InitializePreviewControl()
			LoadPictures(book)
			Return book
		End Function
		Private Sub LoadPictures(ByVal book As IWorkbook)
			Dim style As Style = book.Styles("Normal")
			style.Fill.BackgroundColor = System.Drawing.Color.FromArgb(128, 128, 128)
			Dim sheet As Worksheet = book.Worksheets(0)
			sheet.Pictures.AddPicture(DemoUtils.GetRelativePath("Images\image1.jpg"), sheet.Range("A3:E13"))
			sheet.Pictures.AddPicture(DemoUtils.GetRelativePath("Images\image4.jpg"), sheet.Range("G3:K13"))
			sheet.Pictures.AddPicture(DemoUtils.GetRelativePath("Images\image5.jpg"), sheet.Range("M3:Q13"))
			sheet.Pictures.AddPicture(DemoUtils.GetRelativePath("Images\image6.jpg"), sheet.Range("A20:E30"))
			sheet.Pictures.AddPicture(DemoUtils.GetRelativePath("Images\image3.jpg"), sheet.Range("G20:K30"))
			sheet.Pictures.AddPicture(DemoUtils.GetRelativePath("Images\image2.jpg"), sheet.Range("M20:Q30"))
		End Sub

		Private Sub InitializePreviewControl()
			CanShowBorders = False
			SpreadsheetTutorialPanel.Location = Point.Empty
		End Sub
	End Class
End Namespace

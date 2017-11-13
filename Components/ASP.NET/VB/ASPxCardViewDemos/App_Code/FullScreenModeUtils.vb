Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Web
Imports System.Web.UI
Imports DevExpress.Web.Internal
Imports DevExpress.XtraPrinting.BarCode

Namespace DevExpress.Web.Demos
	Public Class FullScreenModeResolution
		Public Property Name() As String
		Public Property Width() As Integer
		Public Property Height() As Integer
	End Class
	Public NotInheritable Class FullScreenModeUtils
		Public Shared ReadOnly FullScreenViewerUrl As String = "~/UserControls/FullScreenViewer.aspx"
		Public Shared ReadOnly FullScreenViewerQRCodeUrl As String = "~/UserControls/FullScreenViewerQRCode.aspx"

		Private Shared resolutions_Renamed As List(Of FullScreenModeResolution)

		Private Sub New()
		End Sub
		Public Shared ReadOnly Property Resolutions() As List(Of FullScreenModeResolution)
			Get
				If resolutions_Renamed Is Nothing Then
					resolutions_Renamed = New List(Of FullScreenModeResolution)()
					resolutions_Renamed.Add(New FullScreenModeResolution With {.Name = "Fullscreen", .Width = 0, .Height = 0})
					resolutions_Renamed.Add(New FullScreenModeResolution With {.Name = "1200x800", .Width = 1200, .Height = 800})
					resolutions_Renamed.Add(New FullScreenModeResolution With {.Name = "800x1200", .Width = 800, .Height = 1200})
					resolutions_Renamed.Add(New FullScreenModeResolution With {.Name = "768x576", .Width = 768, .Height = 576})
					resolutions_Renamed.Add(New FullScreenModeResolution With {.Name = "576x768", .Width = 576, .Height = 768})
				End If
				Return resolutions_Renamed
			End Get
		End Property
		Public Shared Function GetUrl(ByVal page As Page, ByVal targetUrl As String, ByVal width As Integer, ByVal height As Integer) As String
			Dim url As String = FullScreenViewerUrl
			If (Not String.IsNullOrEmpty(targetUrl)) Then
				url &= "?url=" & page.ResolveUrl(targetUrl)
				If width > 0 Then
					url &= "&width=" & width.ToString()
				End If
				If height > 0 Then
					url &= "&height=" & height.ToString()
				End If
			End If
			Return url
		End Function
		Public Shared Function GetQRCodeImageUrl(ByVal page As Page, ByVal url As String) As String
			Return String.Format("{0}?url={1}", page.ResolveUrl(FullScreenViewerQRCodeUrl), page.ResolveUrl(url))
		End Function
		Public Shared Function GetQRCodeImage(ByVal url As String) As System.Drawing.Image
			Const imageSize As Integer = 120
			Dim request As HttpRequest = HttpUtils.GetRequest()
			Dim resolvedUrl As String = String.Format("{0}://{1}{2}", request.Url.Scheme, request.Url.Authority, url)

			Dim image = New Bitmap(imageSize, imageSize)
			Using graphicsObj = Graphics.FromImage(image)
				Dim gdiGraphics = New DevExpress.XtraPrinting.GdiGraphicsWrapper(graphicsObj)
				Dim qrcode = New QRCodeGenerator() With {.CompactionMode = QRCodeCompactionMode.Byte}
				Dim rectf = New RectangleF(0, 0, imageSize, imageSize)
				Dim barcodeData = New QRBarCodeData(resolvedUrl)
				qrcode.DrawContent(gdiGraphics, rectf, barcodeData)
			End Using
			Return image
		End Function
	End Class

	Public Class QRBarCodeData
		Implements IBarCodeData
		Private ReadOnly text_Renamed As String
		Private ReadOnly style_Renamed As DevExpress.XtraPrinting.BrickStyle

		Public Sub New(ByVal text As String)
			Me.text_Renamed = text
			Me.style_Renamed = New DevExpress.XtraPrinting.BrickStyle With {.ForeColor = Color.Black, .BackColor = Color.Transparent, .Padding = New DevExpress.XtraPrinting.PaddingInfo()}
		End Sub

		Private ReadOnly Property IBarCodeData_Alignment() As DevExpress.XtraPrinting.TextAlignment Implements IBarCodeData.Alignment
			Get
				Return DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			End Get
		End Property
		Private ReadOnly Property AutoModule() As Boolean Implements IBarCodeData.AutoModule
			Get
				Return True
			End Get
		End Property
		Private ReadOnly Property [Module]() As Double Implements IBarCodeData.Module
			Get
				Return 3.0
			End Get
		End Property
		Private ReadOnly Property IBarCodeData_Orientation() As BarCodeOrientation Implements IBarCodeData.Orientation
			Get
				Return BarCodeOrientation.Normal
			End Get
		End Property
		Private ReadOnly Property ShowText() As Boolean Implements IBarCodeData.ShowText
			Get
				Return False
			End Get
		End Property
		Private ReadOnly Property IBarCodeData_Style() As DevExpress.XtraPrinting.BrickStyle Implements IBarCodeData.Style
			Get
				Return style_Renamed
			End Get
		End Property
		Private ReadOnly Property Text() As String Implements IBarCodeData.Text
			Get
				Return text_Renamed
			End Get
		End Property
	End Class
End Namespace

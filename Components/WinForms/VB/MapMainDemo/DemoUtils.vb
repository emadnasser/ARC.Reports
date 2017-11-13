Imports Microsoft.VisualBasic
Imports DevExpress.Demos.OpenWeatherService
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports System.Xml.Linq

Namespace DevExpress.XtraMap.Demos
	''' <summary>
	''' Summary description for DemoUtils.
	''' </summary>
	Public Class DemoUtils
		Private Const key As String = DevExpress.Map.Native.DXBingKeyVerifier.BingKeyWinMapMainDemo
		Public Shared ReadOnly Property ComplexDateExpression() As String
			Get
				Return "CONVERT(CONVERT(yr, 'System.String') + '/' + CONVERT(mon, 'System.String') + '/' + CONVERT(day, 'System.String') + ' ' + CONVERT(hr, 'System.String') + ':' + CONVERT(min, 'System.String'), 'System.DateTime')"
			End Get
		End Property

		Public Shared Function LoadXml(ByVal name As String) As XDocument
			Try
				Return XDocument.Load("file:\\" & GetRelativePath(name))
			Catch
				Return Nothing
			End Try
		End Function
		Friend Shared Sub SetBingMapDataProviderKey(ByVal provider As BingMapDataProvider)
			If provider IsNot Nothing Then
				provider.BingKey = key
			End If
		End Sub
		Friend Shared Sub SetBingMapDataProviderKey(ByVal provider As BingMapDataProviderBase)
			If provider IsNot Nothing Then
				provider.BingKey = key
			End If
		End Sub
		Public Shared Function GetRelativePath(ByVal name As String) As String
			name = "Data\" & name
			Dim path As String = System.Windows.Forms.Application.StartupPath
			Dim s As String = "\"
			For i As Integer = 0 To 10
				If System.IO.File.Exists(path & s & name) Then
					Return (path & s & name)
				Else
					s &= "..\"
				End If
			Next i
			Return ""
		End Function
		Public Shared Function GetRelativeDirectoryPath(ByVal name As String) As String
			name = "Data\" & name
			Dim path As String = System.Windows.Forms.Application.StartupPath
			Dim s As String = "\"
			For i As Integer = 0 To 10
				If System.IO.Directory.Exists(path & s & name) Then
					Return (path & s & name)
				Else
					s &= "..\"
				End If
			Next i
			Return ""
		End Function
		Public Shared Function GetBackGroundImage(ByVal map As MapControl, ByVal galleryRect As Rectangle, ByVal opacity As Single) As Image
			Using stream As New MemoryStream()
				Try
					map.ExportToImage(stream, ImageFormat.Png)
					Using image As Image = Image.FromStream(stream)
						Dim result As New Bitmap(galleryRect.Width, galleryRect.Height)
						Using g As Graphics = Graphics.FromImage(result)
							Dim matrix As New ColorMatrix() With {.Matrix33 = opacity}
							Dim attributes As New ImageAttributes()
							attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)
							g.DrawImage(image, New Rectangle(0, 0, result.Width, result.Height), galleryRect.X, galleryRect.Y, galleryRect.Width, galleryRect.Height, GraphicsUnit.Pixel, attributes)
						End Using
						Return result
					End Using
				Catch
					Return Nothing
				End Try
			End Using
		End Function
		Public Shared Function GetInflatedImage(ByVal imageUri As String, ByVal inflateX As Integer, ByVal inflateY As Integer) As Image
			Using image As Image = Image.FromFile(imageUri)
				Dim rect As New Rectangle(New Point(0, 0), image.Size)
				rect.Inflate(inflateX, inflateY)
				Dim result As New Bitmap(rect.Width, rect.Height)
				Using g As Graphics = Graphics.FromImage(result)
					g.FillRectangle(Brushes.White, New Rectangle(0, 0, result.Width, result.Height))
					g.DrawImage(image, New Rectangle(inflateX, inflateY, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel)
					Return result
				End Using
			End Using
		End Function
		Public Shared Function GetOSMBaseLayers() As Object()
			Dim result As New List(Of Object)()
			result.Add(OpenStreetMapKind.Basic)
			result.Add(OpenStreetMapKind.CycleMap)
			result.Add(OpenStreetMapKind.Hot)
			result.Add(OpenStreetMapKind.GrayScale)
			result.Add(OpenStreetMapKind.Transport)
			Return result.ToArray()
		End Function
		Public Shared Function GetOSMOverlays() As Object()
			Dim result As New List(Of Object)()
			result.Add("None")
			result.Add(OpenStreetMapKind.SeaMarks)
			result.Add(OpenStreetMapKind.HikingRoutes)
			result.Add(OpenStreetMapKind.CyclingRoutes)
			result.Add(OpenStreetMapKind.PublicTransport)
			Return result.ToArray()
		End Function
		Public Shared Function CreateFlagsDictionary() As Dictionary(Of String, Image)
			Dim flags As New Dictionary(Of String, Image)()
			Dim path As String = DemoUtils.GetRelativeDirectoryPath("\Images\Flags")
			Dim fileEntries() As String = If(String.IsNullOrEmpty(path), New String(){}, Directory.GetFiles(path).Where(Function(entry) entry.EndsWith(".png")).ToArray())
			For Each fileName As String In fileEntries
				Dim key As String = fileName.Substring(fileName.LastIndexOf("\") + 1).Remove(2, 4)
				flags.Add(key, Image.FromFile(fileName))
			Next fileName
			Return flags
		End Function
		Public Shared Function GetRotatedImage(ByVal inputImage As Image, ByVal angleDegrees As Double) As Image
			Dim backgroundColor As Color = Color.Transparent
			Dim upsizeOk As Boolean = False
			Dim clipOk As Boolean = True
			If angleDegrees = 0f Then
				Return CType(inputImage.Clone(), Bitmap)
			End If

			Dim oldWidth As Integer = inputImage.Width
			Dim oldHeight As Integer = inputImage.Height
			Dim newWidth As Integer = oldWidth
			Dim newHeight As Integer = oldHeight
			Dim scaleFactor As Single = 1f

			If upsizeOk OrElse (Not clipOk) Then
				Dim angleRadians As Double = angleDegrees * Math.PI / 180R
				Dim cos As Double = Math.Abs(Math.Cos(angleRadians))
				Dim sin As Double = Math.Abs(Math.Sin(angleRadians))
				newWidth = CInt(Fix(Math.Round(oldWidth * cos + oldHeight * sin)))
				newHeight = CInt(Fix(Math.Round(oldWidth * sin + oldHeight * cos)))
			End If
			If (Not upsizeOk) AndAlso (Not clipOk) Then
				scaleFactor = Math.Min(CSng(oldWidth) / newWidth, CSng(oldHeight) / newHeight)
				newWidth = oldWidth
				newHeight = oldHeight
			End If
			Dim newBitmap As New Bitmap(newWidth, newHeight,If(backgroundColor = Color.Transparent, PixelFormat.Format32bppArgb, PixelFormat.Format24bppRgb))
			newBitmap.SetResolution(inputImage.HorizontalResolution, inputImage.VerticalResolution)
			Using graphicsObject As Graphics = Graphics.FromImage(newBitmap)
				graphicsObject.InterpolationMode = InterpolationMode.HighQualityBicubic
				graphicsObject.PixelOffsetMode = PixelOffsetMode.HighQuality
				graphicsObject.SmoothingMode = SmoothingMode.HighQuality
				If backgroundColor <> Color.Transparent Then
					graphicsObject.Clear(backgroundColor)
				End If
				graphicsObject.TranslateTransform(newWidth / 2f, newHeight / 2f)
				If scaleFactor <> 1f Then
					graphicsObject.ScaleTransform(scaleFactor, scaleFactor)
				End If
				graphicsObject.RotateTransform(CSng(angleDegrees))
				graphicsObject.TranslateTransform(-oldWidth / 2f, -oldHeight / 2f)
				graphicsObject.DrawImage(inputImage, 0, 0)
			End Using
			Return newBitmap
		End Function
	End Class
	Public Class DemoWeatherItemFactory
		Inherits DefaultMapItemFactory
		Protected Overrides Sub InitializeItem(ByVal item As MapItem, ByVal obj As Object)
			Dim cityWeather As CityWeather = TryCast(obj, CityWeather)
			Dim element As MapCustomElement = TryCast(item, MapCustomElement)
			If element Is Nothing OrElse cityWeather Is Nothing Then
				Return
			End If
			element.ImageUri = New Uri(cityWeather.WeatherIconPath)
		End Sub
	End Class
	Public Class InvariantImageRepositoryItem
		Inherits RepositoryItemCheckEdit
		Protected Overrides Function TransformPicture(ByVal image As Image) As Image
			Return image
		End Function
	End Class
	Public Class HotelRoomTooltipHelper
		Private imageGenerator As New HotelImagesGenerator()
		Private superToolTip As New SuperToolTip()
		Private titleItem As New ToolTipTitleItem()
		Private contentItem As New ToolTipItem() With {.ImageToTextDistance = 0}

		Public Sub New()
			Me.superToolTip.Items.Add(titleItem)
			Me.superToolTip.Items.Add(contentItem)
		End Sub

		Private Function CalculateTitle(ByVal category As Integer, ByVal tooltip As String) As String
			Return If(category = 4, String.Format("Room: {0}", tooltip), tooltip)
		End Function
		Public Function CalculateSuperTooltip(ByVal item As MapItem, ByVal tooltip As String) As SuperToolTip
			If item Is Nothing Then
				Return Nothing
			End If
			Dim attr As MapItemAttribute = item.Attributes("CATEGORY")
			If attr Is Nothing Then
				Return Nothing
			End If
			titleItem.Text = CalculateTitle(CInt(Fix(attr.Value)), tooltip)
			attr = item.Attributes("IMAGE")
			contentItem.Image = If(attr IsNot Nothing, CType(attr.Value, Image), imageGenerator.GetItemImage(item))
			Return superToolTip
		End Function
		Public Sub UpdateHotelIndex(ByVal index As Integer)
			imageGenerator.HotelIndex = index
		End Sub
	End Class
	Public Class HotelImagesGenerator
		Private Class PathsIndexPair
			Public Property Paths() As String()
			Public Property Index() As Integer
		End Class

		Private Const ImageWidth As Integer = 200
		Private Shared ReadOnly Categories() As String = { "Restaurant", "MeetingRoom", "Bathroom", "Bedroom", "Outofdoors", "ServiceRoom", "Pool", "Lobby" }

		Private hotelIndex_Renamed As Integer = 0
		Private filesWithIndices As New List(Of PathsIndexPair)()

		Public Property HotelIndex() As Integer
			Get
				Return hotelIndex_Renamed
			End Get
			Set(ByVal value As Integer)
				hotelIndex_Renamed = value
				UpdateIndices()
			End Set
		End Property

		Public Sub New()
			For Each category As String In Categories
				filesWithIndices.Add(New PathsIndexPair() With {.Index = 0, .Paths = GetAvailableFiles(category)})
			Next category
		End Sub
		Private Sub UpdateIndices()
			filesWithIndices(0).Index = hotelIndex_Renamed * 2
			filesWithIndices(1).Index = 0
			filesWithIndices(2).Index = hotelIndex_Renamed * 4
			filesWithIndices(6).Index = hotelIndex_Renamed
		End Sub
		Private Function GetAvailableFiles(ByVal category As String) As String()
			Dim path As String = DemoUtils.GetRelativeDirectoryPath("\Images\Hotels\")
			Return Directory.GetFiles(path).Where(Function(p) p.StartsWith(path & category)).ToArray()
		End Function
		Private Function GetImage(ByVal category As Integer, ByVal name As String, ByVal roomCat As Integer) As Image
			If category = 4 Then
				filesWithIndices(3).Index = roomCat
			End If
			Return GetCategoryImage(filesWithIndices(category - 1))
		End Function
		Private Function GetCategoryImage(ByVal pathsWithIndex As PathsIndexPair) As Image
			If pathsWithIndex.Paths.Length = 0 Then
				Return Nothing
			End If
			Dim index As Integer = pathsWithIndex.Index Mod pathsWithIndex.Paths.Length
			pathsWithIndex.Index += 1
			Return New Bitmap(pathsWithIndex.Paths(index))
		End Function
		Private Function ScaleImage(ByVal srcImg As Image) As Image
			Dim ratio As Double = CDbl(srcImg.Width) / srcImg.Height
			Dim newHeight As Integer = CInt(Fix(CDbl(ImageWidth) / ratio))
			Dim resImg As Image = New Bitmap(ImageWidth, newHeight)
			Graphics.FromImage(resImg).DrawImage(srcImg, 0, 0, ImageWidth, newHeight)
			Return resImg
		End Function
		Public Function GetItemImage(ByVal item As MapItem) As Image
			Dim image As Image = GetImage(CInt(Fix(item.Attributes("CATEGORY").Value)), item.Attributes("NAME").Value.ToString(), CInt(Fix(item.Attributes("ROOMCAT").Value)))
			If image Is Nothing Then
				Return Nothing
			End If
			image = ScaleImage(image)
			item.Attributes.Add(New MapItemAttribute() With {.Name = "IMAGE", .Value = image})
			Return image
		End Function
	End Class
	Public NotInheritable Class ColorHelper
		Private Sub New()
		End Sub
		Public Shared Sub UpdateColor(ByVal image As Image, ByVal lookAndFeel As UserLookAndFeel)
			Dim foreColor As Color = GetForeColor(lookAndFeel)
			SetColor(CType(image, Bitmap), foreColor)
		End Sub
		Public Shared Function GetForeColor(ByVal lookAndFeel As UserLookAndFeel) As Color
			Dim ret As Color = SystemColors.ControlText
			If lookAndFeel.ActiveStyle <> ActiveLookAndFeelStyle.Skin Then
				Return ret
			End If
			Return MapSkins.GetSkin(lookAndFeel).Properties.GetColor(MapSkins.PropPanelTextColor)
		End Function
		Private Shared Sub SetColor(ByVal bmp As Bitmap, ByVal color As Color)
			For i As Integer = 0 To bmp.Width - 1
				For j As Integer = 0 To bmp.Height - 1
					If bmp.GetPixel(i, j).A > 0 Then
						bmp.SetPixel(i, j, color)
					End If
				Next j
			Next i
		End Sub
	End Class
	Public Class FlagsRepository
		Private calloutImages As New Dictionary(Of String, Image)()
		Private gridImages As New Dictionary(Of String, Image)()

		Public Sub New()
			calloutImages = DemoUtils.CreateFlagsDictionary()
			gridImages = DemoUtils.CreateFlagsDictionary()
		End Sub

		Public Function GetFlag(ByVal country As String, ByVal forCallout As Boolean) As Image
			Return If(forCallout, calloutImages(country), gridImages(country))
		End Function
		Public Function Contains(ByVal country As String) As Boolean
			Return calloutImages.ContainsKey(country)
		End Function
	End Class
End Namespace

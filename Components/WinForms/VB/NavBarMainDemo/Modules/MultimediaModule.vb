Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Drawing.Imaging
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Animation
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class AccordionControlMultimediaModule
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
            WorkingFolder = DataPath
            If Not String.IsNullOrEmpty(WorkingFolder) Then
                InitializeContent()
                SetImage(Images(0))
            End If
        End Sub
		Protected Overridable Sub InitializeContent()
			InitializeTileControl()
			UpdateEditors()
		End Sub
		Protected Overridable Sub InitializeTileControl()
            TryCast(tileControl1, ITileControl).ViewInfo.UseAdvancedTextRendering = False
            If TileGroupImages Is Nothing Then
                Return
            End If
            tileControl1.Groups.Clear()
            tileControl1.Groups.Add(TileGroupImages)
        End Sub
        Protected Overridable Sub InitializeImages()
            If String.IsNullOrEmpty(WorkingFolder) Then
                Return
            End If
            Images = New List(Of Image)()
            Dim files() As String = Directory.GetFiles(WorkingFolder, "*.jpg")
            For Each file As String In files
                Dim img As Image = Bitmap.FromFile(file)
                img.Tag = file
                Images.Add(img)
            Next file
            InitializeTileControl()
        End Sub
        Protected Overridable Property Images() As List(Of Image)
        Protected Overridable ReadOnly Property TileControl() As TileControl
            Get
                Return tileControl1
            End Get
        End Property
        Protected Overridable ReadOnly Property PictureEdit() As PictureEdit
            Get
                Return peCurrentImage
            End Get
        End Property
        Protected Overridable ReadOnly Property FilterGroup() As GalleryItemGroup
            Get
                Return galleryFilters.Gallery.Groups(0)
            End Get
        End Property
        Protected Overridable ReadOnly Property PreviewSize() As Size
            Get
                Return galleryFilters.Gallery.ImageSize
            End Get
        End Property
        Private _originalImage As Image
        Protected Overridable Property OriginalImage() As Image
            Get
                Return _originalImage
            End Get
            Set(ByVal value As Image)
                _originalImage = value
                peOriginalImage.Image = _originalImage
                UpdateImageProperties()
            End Set
        End Property

        Private _currentImage As Image
        Protected Overridable Property CurrentImage() As Image
            Get
                Return _currentImage
            End Get
            Set(ByVal value As Image)
                _currentImage = value
                If CurrentImage Is Nothing Then
                    Return
                End If
                PictureEdit.Image = CurrentImage
                CalcCurrentImageZoomPercent(_currentImage)
                UpdateEditors()
            End Set
        End Property
        Private _workingFolder As String
        Protected Overridable Property WorkingFolder() As String
            Get
                Return _workingFolder
            End Get
            Set(ByVal value As String)
                If _workingFolder = value Then
                    Return
                End If
                _workingFolder = value
                InitializeImages()
            End Set
        End Property
        Private group As TileGroup
        Protected Overridable ReadOnly Property TileGroupImages() As TileGroup
            Get
                If group Is Nothing Then
                    group = CreateTileGroupImages()
                End If
                Return group
            End Get
        End Property
        Protected Overridable Sub SetImage(ByVal img As Image)
            OriginalImage = img
            CurrentImage = OriginalImage
            RefreshFilters(OriginalImage)
        End Sub
        Protected Function GetDataDir() As String
            Dim path As String = AppDomain.CurrentDomain.BaseDirectory
            For i As Integer = 0 To 9
                path &= "..\"
                If Directory.Exists(path & "Data") Then
                    Return path & "Data"
                End If
            Next i
            Return String.Empty
        End Function
        Protected ReadOnly Property DataPath() As String
            Get
                Dim _dataPath As String = GetDataDir() & "\AccordionControlData"
                If Directory.Exists(_dataPath) Then
                    Return _dataPath
                End If
                Return String.Empty
            End Get
        End Property
        Protected Overridable Sub UpdateEditors()
            Dim value As Boolean = CurrentImage IsNot Nothing
            tbRed.Enabled = value
            tbGreen.Enabled = value
            tbBlue.Enabled = value
            tbBrightness.Enabled = value
            tbContrast.Enabled = value

            tbRed.Value = tbRed.Properties.Minimum
            tbGreen.Value = tbGreen.Properties.Minimum
            tbBlue.Value = tbBlue.Properties.Minimum
            tbBrightness.Value = tbBrightness.Properties.Minimum
            tbContrast.Value = tbContrast.Properties.Minimum
        End Sub
        Protected Overridable Function CreateTileGroupImages() As TileGroup
            If Images Is Nothing OrElse Images.Count = 0 Then
                Return Nothing
            End If
            Dim g As New TileGroup()
            For Each img As Image In Images
                Dim item As New TileItem() With {.BackgroundImage = img, .BackgroundImageScaleMode = TileItemImageScaleMode.Squeeze, .BackgroundImageAlignment = TileItemContentAlignment.MiddleCenter}
                g.Items.Add(item)
            Next img
            Return g
        End Function
        Protected Overridable Sub RefreshFilters(ByVal img As Image)
            FilterGroup.Items.Clear()
            For Each filter As FilterBase In FilterList
                FilterGroup.Items.Add(CreateGalleryItemFilter(img, filter))
            Next filter
        End Sub
        Protected Overridable Sub UpdateImageProperties()
            ratingImage.Rating = ImageHelper.GetRating(OriginalImage)
            lblSize.Text = ImageHelper.GetSize(OriginalImage)
            lblName.Text = ImageHelper.GetName(OriginalImage)
            lblDimension.Text = ImageHelper.GetDimension(OriginalImage)
        End Sub
        Protected Overridable Function CreateGalleryItemFilter(ByVal img As Image, ByVal filter As FilterBase) As GalleryItem
            Dim item As New GalleryItem() With {.Image = filter.ApplyFilter(img, PreviewSize), .Caption = filter.Name}
            AddHandler item.ItemClick, Sub() PictureEdit.Image = filter.ApplyFilter(img, img.Size)
            Return item
        End Function
        Protected Overridable Sub OnTbRedEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbRed.EditValueChanged
            OnChangeColor()
        End Sub
        Protected Overridable Sub OnTbGreenEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbGreen.EditValueChanged
            OnChangeColor()
        End Sub
        Protected Overridable Sub OnTbBlueEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbBlue.EditValueChanged
            OnChangeColor()
        End Sub
        Protected Overridable Sub OnChangeColor()
            If CurrentImage Is Nothing Then
                Return
            End If
            PictureEdit.Image = UniversalFilter.ApplyFilter(CurrentImage, CurrentImage.Size, tbRed.Value, tbGreen.Value, tbBlue.Value)
        End Sub
        Protected Sub OnBrightnessChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles tbBrightness.EditValueChanging
            If CurrentImage Is Nothing Then
                Return
            End If
            Dim val As Integer = tbBrightness.Value
            PictureEdit.Image = UniversalFilter.ApplyFilter(CurrentImage, CurrentImage.Size, val, val, val)
        End Sub
        Protected Overridable Sub OnContrastChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbContrast.EditValueChanged
            If CurrentImage Is Nothing Then
                Return
            End If
            Dim val As Integer = tbContrast.Value
            PictureEdit.Image = ContrastFilter.ApplyFilter(CurrentImage, CurrentImage.Size, val)
        End Sub
        Protected Overridable Sub OnTileControlItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles tileControl1.ItemClick
            SetImage(e.Item.BackgroundImage)
        End Sub
		#Region "Filters"
        Private _filterList As List(Of FilterBase)
        Protected Overridable ReadOnly Property FilterList() As List(Of FilterBase)
            Get
                If _filterList Is Nothing Then
                    _filterList = New List(Of FilterBase)() From {New PolaroidFilter(), New BGRFilter(), New GBRFilter(), New SepiaFilter(), New GrayScaleFilter(), New NegativeFilter()}
                End If
                Return _filterList
            End Get
        End Property
        Private _universalFilter As UniversalFilter
        Protected Overridable ReadOnly Property UniversalFilter() As UniversalFilter
            Get
                If _universalFilter Is Nothing Then
                    _universalFilter = New UniversalFilter()
                End If
                Return _universalFilter
            End Get
        End Property
        Private _contrastFilter As ContrastFilter
        Protected Overridable ReadOnly Property ContrastFilter() As ContrastFilter
            Get
                If _contrastFilter Is Nothing Then
                    _contrastFilter = New ContrastFilter()
                End If
                Return _contrastFilter
            End Get
        End Property
#End Region
        Protected Overridable Sub CalcCurrentImageZoomPercent(ByVal img As Image)
            If img Is Nothing Then
                Return
            End If
            PictureEdit.Properties.ZoomPercent = Math.Min((CDbl(PictureEdit.Height) / CDbl(img.Height)) * 100, 100)
        End Sub
        Private Sub peCurrentImage_SizeChanged(sender As Object, e As EventArgs) Handles peCurrentImage.SizeChanged
            CalcCurrentImageZoomPercent(CurrentImage)
        End Sub
    End Class
	Public NotInheritable Class ImageHelper
		Private Sub New()
		End Sub
		Public Shared Function GetDimension(ByVal img As Image) As String
			If img Is Nothing Then
				Return "0x0"
			End If
			Return String.Format("{0}x{1}", img.Width, img.Height)
		End Function
		Public Shared Function GetName(ByVal img As Image) As String
			If img Is Nothing Then
				Return String.Empty
			End If
			Return Path.GetFileName(img.Tag.ToString())
		End Function
		Public Shared Function GetSize(ByVal img As Image) As String
			If img Is Nothing Then
				Return "0 KB"
			End If
			Return (New FileInfo(img.Tag.ToString()).Length \ 1024).ToString() & " KB"
        End Function
        Shared rnd As New Random()
		Public Shared Function GetRating(ByVal img As Image) As Integer
			If img Is Nothing Then
				Return 0
			End If
            Return rnd.Next(5)
		End Function
	End Class
	Public Delegate Sub GalleryItemApplyFilter(ByVal name As String, ByVal image As Image, ByVal filter As FilterBase)
	Public Class FilterBase
		Public Overridable ReadOnly Property Name() As String
			Get
				Return String.Empty
			End Get
		End Property
		Public Function ApplyFilter(ByVal image As Image, ByVal size As Size) As Image
			Return ApplyMatrix(image, size, Matrix)
		End Function
		Protected Overridable ReadOnly Property Matrix() As ColorMatrix
			Get
				Return New ColorMatrix()
			End Get
		End Property
		Protected Function ApplyMatrix(ByVal image As Image, ByVal size As Size, ByVal matrix As ColorMatrix) As Bitmap
			Dim src As New Bitmap(image, size)
			Dim dest As New Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb)
			Using graphics As Graphics = Graphics.FromImage(dest)
				Dim bmpAttributes As New ImageAttributes()
				bmpAttributes.SetColorMatrix(matrix)
				graphics.DrawImage(src, New Rectangle(0, 0, src.Width, src.Height), 0, 0, src.Width, src.Height, GraphicsUnit.Pixel, bmpAttributes)
			End Using
			src.Dispose()
			Return dest
		End Function
	End Class
	Public Class PolaroidFilter
		Inherits FilterBase
		Public Overrides ReadOnly Property Name() As String
			Get
				Return "Polaroid"
			End Get
		End Property
		Protected Overrides ReadOnly Property Matrix() As ColorMatrix
			Get
				Return New ColorMatrix(New Single()() { New Single() {1.438f, -0.062f, -0.062f, 0, 0}, New Single() {-0.122f, 1.378f, -0.122f, 0, 0}, New Single() {0.016f, -0.016f, 1.438f, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0.03f, 0.05f, -0.2f, 0, 1} })
			End Get
		End Property
	End Class
	Public Class GrayScaleFilter
		Inherits FilterBase
		Public Overrides ReadOnly Property Name() As String
			Get
				Return "GrayScale"
			End Get
		End Property
		Protected Overrides ReadOnly Property Matrix() As ColorMatrix
			Get
				Return New ColorMatrix(New Single()() { New Single() {.3f,.3f,.3f, 0, 0}, New Single() {.59f,.59f,.59f, 0, 0}, New Single() {.11f,.11f,.11f, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1} })
			End Get
		End Property
	End Class
	Public Class NegativeFilter
		Inherits FilterBase
		Public Overrides ReadOnly Property Name() As String
			Get
				Return "Negative"
			End Get
		End Property
		Protected Overrides ReadOnly Property Matrix() As ColorMatrix
			Get
				Return New ColorMatrix(New Single()() { New Single() {-1, 0, 0, 0, 0}, New Single() {0, -1, 0, 0, 0}, New Single() {0, 0, -1, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {1, 1, 1, 0, 1} })
			End Get
		End Property
	End Class
	Public Class SepiaFilter
		Inherits FilterBase
		Public Overrides ReadOnly Property Name() As String
			Get
				Return "Sepia"
			End Get
		End Property
		Protected Overrides ReadOnly Property Matrix() As ColorMatrix
			Get
				Return New ColorMatrix(New Single()() { New Single() {.393f,.349f,.272f, 0, 0}, New Single() {.769f,.686f,.534f, 0, 0}, New Single() {.189f,.168f,.131f, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1} })
			End Get
		End Property
	End Class
	Public Class BGRFilter
		Inherits FilterBase
		Public Overrides ReadOnly Property Name() As String
			Get
				Return "BGR"
			End Get
		End Property
		Protected Overrides ReadOnly Property Matrix() As ColorMatrix
			Get
				Return New ColorMatrix(New Single()() { New Single() {0, 0, 1, 0, 0}, New Single() {0, 1, 0, 0, 0}, New Single() {1, 0, 0, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1} })
			End Get
		End Property
	End Class
	Public Class GBRFilter
		Inherits FilterBase
		Public Overrides ReadOnly Property Name() As String
			Get
				Return "GBR"
			End Get
		End Property
		Protected Overrides ReadOnly Property Matrix() As ColorMatrix
			Get
				Return New ColorMatrix(New Single()() { New Single() {0, 1, 0, 0, 0}, New Single() {0, 0, 1, 0, 0}, New Single() {1, 0, 0, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1} })
			End Get
		End Property
	End Class
	Public Class UniversalFilter
		Inherits FilterBase
		Public Sub New()
			b = 0
			g = b
			r = g
		End Sub
		Private r, g, b As Integer
		Public Shadows Function ApplyFilter(ByVal image As Image, ByVal size As Size, ByVal r As Integer, ByVal g As Integer, ByVal b As Integer) As Image
			Me.r = r
			Me.g = g
			Me.b = b
			Return ApplyMatrix(image, size, Matrix)
		End Function
		Public Overrides ReadOnly Property Name() As String
			Get
				Return "Universal"
			End Get
		End Property
		Protected Overrides ReadOnly Property Matrix() As ColorMatrix
			Get
				Return New ColorMatrix(New Single()() { New Single() {1 + CSng(r / 255.0f), 0, 0, 0, 0}, New Single() {0, 1 + CSng(g/ 255.0f), 0, 0, 0}, New Single() {0, 0, 1 + CSng(b/ 255.0f), 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0.1f, 0.1f, 0.1f, 0, 1} })
			End Get
		End Property
	End Class
	Public Class ContrastFilter
		Inherits FilterBase
		Public Sub New()
			translate = 0
			scale = translate
		End Sub
		Private scale As Single
		Private translate As Single
		Public Overrides ReadOnly Property Name() As String
			Get
				Return "Contrast"
			End Get
		End Property
		Public Shadows Function ApplyFilter(ByVal image As Image, ByVal size As Size, ByVal val As Integer) As Image
			scale = val
			translate = (-.5f * scale +.5f) * 255.0f
			Return ApplyMatrix(image, size, Matrix)
		End Function
		Protected Overrides ReadOnly Property Matrix() As ColorMatrix
			Get
				Return New ColorMatrix(New Single()() { New Single() {1 + scale / 100, 0, 0, 0, translate}, New Single() {0, 1 + scale / 100, 0, 0, translate}, New Single() {0, 0, 1 + scale / 100, 0, translate}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1} })
			End Get
		End Property
	End Class
End Namespace

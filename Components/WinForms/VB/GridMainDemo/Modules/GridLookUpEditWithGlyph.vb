Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
	Public Class RepositoryItemGridLookUpEditWithGlyph
		Inherits RepositoryItemGridLookUpEdit

		Shared Sub New()
			RegisterGridLookUpEditWithGlyph()
		End Sub
        Private GetImageByValueMethod As ImageByValueEventHandler
        Public Custom Event GetImageByValue As ImageByValueEventHandler
            AddHandler(ByVal value As ImageByValueEventHandler)
                GetImageByValueMethod = value
            End AddHandler
            RemoveHandler(ByVal value As ImageByValueEventHandler)
                GetImageByValueMethod = Nothing
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
                If (Not GetImageByValueMethod Is Nothing) Then
                    GetImageByValueMethod.Invoke(sender, e)
                End If
            End RaiseEvent
        End Event
		Public Function GetImage(ByVal e As ImageByValueEventArgs) As Object
			RaiseEvent GetImageByValue(Me, e)
			Return e.Image
		End Function
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return "GridLookUpEditWithGlyph"
			End Get
		End Property
		Public Shared Sub RegisterGridLookUpEditWithGlyph()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo("GridLookUpEditWithGlyph", GetType(GridLookUpEditWithGlyph), GetType(RepositoryItemGridLookUpEditWithGlyph), GetType(GridLookUpEditWithGlyphBaseViewInfo), New GridEditPainterWithGlyph(), False))
		End Sub
		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			Dim li As RepositoryItemGridLookUpEditWithGlyph = TryCast(item, RepositoryItemGridLookUpEditWithGlyph)
			If li IsNot Nothing Then
                AddHandler Me.GetImageByValue, li.GetImageByValueMethod
			End If
			MyBase.Assign(item)
		End Sub
	End Class
	Public Class GridLookUpEditWithGlyph
		Inherits GridLookUpEdit

		Private image_Renamed As Image
		Shared Sub New()
			RepositoryItemGridLookUpEdit.RegisterGridLookUpEdit()
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return "GridLookUpEditWithGlyph"
			End Get
		End Property
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso image_Renamed IsNot Nothing Then
				image_Renamed.Dispose()
			End If
			Me.image_Renamed = Nothing
			MyBase.Dispose(disposing)
		End Sub
		<System.ComponentModel.DefaultValue(CType(Nothing, Object))> _
		Public Property Image() As Image
			Get
				Return image_Renamed
			End Get
			Set(ByVal value As Image)
				image_Renamed = value
				LayoutChanged()
			End Set
		End Property
	End Class
	Public Class GridLookUpEditWithGlyphBaseViewInfo
		Inherits GridLookUpEditBaseViewInfo

		Private image_Renamed As Image
		Public Shared DefaultImageSize As New Size(32, 16)
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub
		Public Shadows ReadOnly Property OwnerEdit() As GridLookUpEditWithGlyph
			Get
				Return TryCast(MyBase.OwnerEdit, GridLookUpEditWithGlyph)
			End Get
		End Property
		Public Shadows ReadOnly Property Item() As RepositoryItemGridLookUpEditWithGlyph
			Get
				Return TryCast(MyBase.Item, RepositoryItemGridLookUpEditWithGlyph)
			End Get
		End Property
		Public Overrides ReadOnly Property IsExistImage() As Boolean
			Get
				Return True
			End Get
		End Property
		Public Overrides ReadOnly Property ImageSize() As Size
			Get
				Return If(Image Is Nothing, Size.Empty, DefaultImageSize)
			End Get
		End Property
		Public Overrides ReadOnly Property GlyphDrawMode() As DevExpress.Utils.Drawing.TextGlyphDrawModeEnum
			Get
				If ImageSize.IsEmpty Then
					Return DevExpress.Utils.Drawing.TextGlyphDrawModeEnum.Text
				End If
				Return DevExpress.Utils.Drawing.TextGlyphDrawModeEnum.TextGlyph
			End Get
		End Property
		Private requireUpdateImage As Boolean = False
		Protected Overrides Sub OnEditValueChanged()
			MyBase.OnEditValueChanged()
			If Bounds.IsEmpty Then
				Me.requireUpdateImage = True
				Return
			End If
			UpdateImage()
		End Sub
		Public Overrides Sub CalcViewInfo(ByVal g As Graphics)
			If requireUpdateImage OrElse OwnerEdit IsNot Nothing AndAlso OwnerEdit.Image IsNot Nothing Then
				UpdateImage()
			End If
			MyBase.CalcViewInfo(g)
		End Sub
		Public Overrides Sub Reset()
			MyBase.Reset()
			Me.image_Renamed = Nothing
		End Sub

		Private Sub UpdateImage()
			Me.requireUpdateImage = False
			Me.image_Renamed = GetImageCore(EditValue)
		End Sub
		Private Function GetImageCore(ByVal editValue As Object) As Image
			Dim ret As Object = Nothing
			If OwnerEdit IsNot Nothing Then
				ret = OwnerEdit.Image
			End If
			If ret IsNot Nothing Then
				Return CType(ret, Image)
			End If

			If Item IsNot Nothing AndAlso editValue IsNot nullValue AndAlso editValue IsNot Nothing Then
				ret = Item.GetImage(New ImageByValueEventArgs(editValue))
			End If
			If ret Is Nothing Then
				Return Nothing
			End If
			If TypeOf ret Is Image Then
				Return CType(ret, Image)
			End If
			Return ByteImageConverter.FromByteArray(ByteImageConverter.ToByteArray(ret))
		End Function
		Protected Overrides Function CalcGlyphBounds() As Rectangle
			Dim res As Rectangle = MyBase.CalcGlyphBounds()
			If Image IsNot Nothing AndAlso OwnerEdit IsNot Nothing Then
                res.Width = (Image.Size.Width * DefaultImageSize.Height) \ Image.Size.Height
			End If
			Return res
		End Function
		Public ReadOnly Property Image() As Image
			Get
				Return image_Renamed
			End Get
		End Property
	End Class
	Public Class GridEditPainterWithGlyph
		Inherits ButtonEditPainter

		Protected Overrides Sub DrawGlyphCore(ByVal info As ControlGraphicsInfoArgs, ByVal be As ButtonEditViewInfo)
			Dim vi As GridLookUpEditWithGlyphBaseViewInfo = TryCast(be, GridLookUpEditWithGlyphBaseViewInfo)
			If vi.Image Is Nothing Then
				Return
			End If
			info.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			info.Paint.DrawImage(info.Graphics, vi.Image, CalcImageRect(vi.Image.Size, vi.GlyphBounds), New Rectangle(Point.Empty, vi.Image.Size), vi.State <> DevExpress.Utils.Drawing.ObjectState.Disabled)
		End Sub
		Private Function CalcImageRect(ByVal imageSize As Size, ByVal rect As Rectangle) As Rectangle
			Dim dh As Integer = (imageSize.Height * rect.Width) \ imageSize.Width
			Dim dw As Integer = (imageSize.Width * rect.Height) \ imageSize.Height
			If dh > rect.Height Then
				rect.X += (rect.Width - dw) \ 2
				rect.Width = dw
			End If
			If dw > rect.Width Then
				rect.Y += (rect.Height - dh) \ 2
				rect.Height = dh
			End If
			Return rect
		End Function
	End Class
End Namespace

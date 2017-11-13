Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
    Public Class RepositoryItemSearchLookUpEditWithGlyph
        Inherits RepositoryItemSearchLookUpEdit

        Shared Sub New()
            RegisterSearchLookUpEditWithGlyph()
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
                Return "SearchLookUpEditWithGlyph"
            End Get
        End Property
        Public Shared Sub RegisterSearchLookUpEditWithGlyph()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo("SearchLookUpEditWithGlyph", GetType(SearchLookUpEditWithGlyph), GetType(RepositoryItemSearchLookUpEditWithGlyph), GetType(SearchLookUpEditWithGlyphBaseViewInfo), New SearchEditPainterWithGlyph(), False))
        End Sub
        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            Dim li As RepositoryItemSearchLookUpEditWithGlyph = TryCast(item, RepositoryItemSearchLookUpEditWithGlyph)
            If li IsNot Nothing Then
                AddHandler Me.GetImageByValue, li.GetImageByValueMethod
            End If
            MyBase.Assign(item)
        End Sub
        Protected Overrides Sub ClearClick()
            MyBase.ClearClick()
            Dim edit As SearchLookUpEditWithGlyph = TryCast(OwnerEdit, SearchLookUpEditWithGlyph)
            If edit IsNot Nothing Then
                edit.Image = Nothing
                edit.DoValidate()
            End If
        End Sub
    End Class
    Public Class SearchEditPainterWithGlyph
        Inherits ButtonEditPainter

        Protected Overrides Sub DrawGlyphCore(ByVal info As ControlGraphicsInfoArgs, ByVal be As ButtonEditViewInfo)
            Dim vi As SearchLookUpEditWithGlyphBaseViewInfo = TryCast(be, SearchLookUpEditWithGlyphBaseViewInfo)
            If vi.Image Is Nothing Then
                Return
            End If
            If vi.Image.Size.Width > SearchLookUpEditWithGlyphBaseViewInfo.DefaultImageSize.Width * 2 Then
                info.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            End If
            info.Paint.DrawImage(info.Graphics, vi.Image, vi.GlyphBounds, New Rectangle(Point.Empty, vi.Image.Size), vi.State <> DevExpress.Utils.Drawing.ObjectState.Disabled)
        End Sub
    End Class
    Public Class SearchLookUpEditWithGlyphBaseViewInfo
        Inherits SearchLookUpEditBaseViewInfo

        Private image_Renamed As Image
        Public Shared DefaultImageSize As New Size(17, 17)
        Public Sub New(ByVal item As RepositoryItem)
            MyBase.New(item)
        End Sub
        Public Shadows ReadOnly Property OwnerEdit() As SearchLookUpEditWithGlyph
            Get
                Return TryCast(MyBase.OwnerEdit, SearchLookUpEditWithGlyph)
            End Get
        End Property
        Public Shadows ReadOnly Property Item() As RepositoryItemSearchLookUpEditWithGlyph
            Get
                Return TryCast(MyBase.Item, RepositoryItemSearchLookUpEditWithGlyph)
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

            If Item IsNot Nothing AndAlso editValue IsNot nullValue Then
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
        Public ReadOnly Property Image() As Image
            Get
                Return image_Renamed
            End Get
        End Property
    End Class
    Public Class SearchLookUpEditWithGlyph
        Inherits SearchLookUpEdit

        Private image_Renamed As Image
        Shared Sub New()
            RepositoryItemSearchLookUpEditWithGlyph.RegisterSearchLookUpEditWithGlyph()
        End Sub
        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return "SearchLookUpEditWithGlyph"
            End Get
        End Property
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso image_Renamed IsNot Nothing Then
                image_Renamed.Dispose()
            End If
            Me.image_Renamed = Nothing
            MyBase.Dispose(disposing)
        End Sub
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
    Public Delegate Sub ImageByValueEventHandler(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
    Public Class ImageByValueEventArgs
        Inherits EventArgs

        Private value_Renamed As Object
        Private image_Renamed As Object
        Public Sub New(ByVal value As Object)
            Me.value_Renamed = value
        End Sub
        Public ReadOnly Property Value() As Object
            Get
                Return value_Renamed
            End Get
        End Property
        Public Property Image() As Object
            Get
                Return image_Renamed
            End Get
            Set(ByVal value As Object)
                image_Renamed = value
            End Set
        End Property
    End Class
End Namespace

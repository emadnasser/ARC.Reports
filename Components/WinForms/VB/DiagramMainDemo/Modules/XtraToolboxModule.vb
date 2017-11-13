Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Collections
Imports DevExpress.Skins
Imports System.IO
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraToolbox

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class ToolboxModule
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
            cbItemViewMode.Properties.Items.AddRange(System.Enum.GetValues(GetType(ToolboxItemViewMode)))
            cbItemViewMode.SelectedIndex = 0

            cbMinimizingScrollMode.Properties.Items.AddRange(System.Enum.GetValues(GetType(ToolboxMinimizingScrollMode)))
            cbMinimizingScrollMode.SelectedIndex = 0

            cbeItemSelectMode.Properties.Items.AddRange(System.Enum.GetValues(GetType(ToolboxItemSelectMode)))
            cbeItemSelectMode.SelectedIndex = 0

            ceAllowSmoothScrolling.Checked = Toolbox.OptionsBehavior.AllowSmoothScrolling
            UpdateEditors()
            LoadData()
        End Sub
        Public ReadOnly Property Toolbox() As ToolboxControl
            Get
                Return xtraToolboxControl
            End Get
        End Property
        Public ReadOnly Property ContentPanel() As SimpleContentPanel
            Get
                Return gcContent
            End Get
        End Property
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If Toolbox.Groups.Count <= 0 Then
                Return
            End If
            Toolbox.SelectedGroup = Toolbox.Groups(0)
        End Sub
        Protected Sub UpdateEditors()
            seColumnCount.Value = Toolbox.OptionsView.ColumnCount
            ceShowSearchPanel.Checked = Toolbox.OptionsView.ShowSearchPanel
            ceGroupsContentAutoSize.Checked = Toolbox.OptionsView.GroupPanelAutoHeight
        End Sub
        Protected ReadOnly Property IsSmallImages() As Boolean
            Get
                Return cbImageSize.SelectedItem.ToString().Contains("16")
            End Get
        End Property
        Protected ReadOnly Property IsLargeImages() As Boolean
            Get
                Return cbImageSize.SelectedItem.ToString().Contains("32")
            End Get
        End Property
        Private Const idActions As String = "Actions"
        Private Const idArrows As String = "Arrows"
        Private Const idExport As String = "Export"
        Protected ReadOnly Property AllSmallGroups() As Dictionary(Of String, ImageCollection)
            Get
                Dim dic As New Dictionary(Of String, ImageCollection)()
                dic(idActions) = icActionsSmall
                dic(idArrows) = icArrowsSmall
                dic(idExport) = icExportSmall
                Return dic
            End Get
        End Property
        Protected ReadOnly Property AllLargeGroups() As Dictionary(Of String, ImageCollection)
            Get
                Dim dic As New Dictionary(Of String, ImageCollection)()
                dic(idActions) = icActionsLarge
                dic(idArrows) = icArrowsLarge
                dic(idExport) = icExportLarge
                Return dic
            End Get
        End Property
        Protected Sub LoadData()
            Toolbox.Groups.Clear()
            If IsSmallImages Then
                Toolbox.Groups.Add(LoadContentFrom(AllSmallGroups, idActions))
                Toolbox.Groups.Add(LoadContentFrom(AllSmallGroups, idArrows))
                Toolbox.Groups.Add(LoadContentFrom(AllSmallGroups, idExport))
            End If
            If IsLargeImages Then
                Toolbox.Groups.Add(LoadContentFrom(AllLargeGroups, idActions))
                Toolbox.Groups.Add(LoadContentFrom(AllLargeGroups, idArrows))
                Toolbox.Groups.Add(LoadContentFrom(AllLargeGroups, idExport))
            End If
        End Sub
        Protected Function LoadContentFrom(ByVal data As Dictionary(Of String, ImageCollection)) As ToolboxGroup
            Dim group As New ToolboxGroup("All Items")
            For Each key As String In data.Keys
                group.Items.AddRange(LoadContentFrom(data, key, True).Items)
            Next key
            Return group
        End Function
        Protected Function LoadContentFrom(ByVal data As Dictionary(Of String, ImageCollection), ByVal id As String, Optional ByVal beginGroup As Boolean = False) As ToolboxGroup
            Dim group As New ToolboxGroup(id)
            For Each info As DXGalleryImageInfo In data(id).Images.InnerImages
                Dim item As New ToolboxItem()
                item.Caption = GetImageName(info.Name)
                item.Image = info.Image
                item.BeginGroup = beginGroup AndAlso group.Items.Count = 0
                item.BeginGroupCaption = id
                group.Items.Add(item)
            Next info
            Return group
        End Function
        Protected Function GetImageName(ByVal fullName As String) As String
            Dim names() As String = fullName.Split("_"c)
            If names.Length <= 0 Then
                Return fullName
            End If
            Return names(0)
        End Function
        Protected Sub ReloadData()
            Dim selectedGroupIndex As Integer = -1
            selectedGroupIndex = Toolbox.Groups.IndexOf(TryCast(Toolbox.SelectedGroup, ToolboxGroup))
            LoadData()
            If selectedGroupIndex < 0 Then
                Return
            End If
            Toolbox.SelectedGroup = Toolbox.Groups(selectedGroupIndex)
        End Sub
        Protected Sub OnImageSizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbImageSize.SelectedIndexChanged
            Dim sz As Size = Size.Empty
            If IsSmallImages Then
                sz = New Size(16, 16)
            End If
            If IsLargeImages Then
                sz = New Size(32, 32)
            End If
            Toolbox.OptionsView.ItemImageSize = sz
            UpdateToolboxButtons()
            ReloadData()
        End Sub
        Protected Sub UpdateToolboxButtons()
            Toolbox.OptionsView.MenuButtonImage = If(IsSmallImages, imagesSmall.Images(0), imagesLarge.Images(0))
            Toolbox.OptionsView.MoreItemsButtonImage = If(IsSmallImages, imagesSmall.Images(1), imagesLarge.Images(1))
        End Sub
        Protected Sub OnColumnCountChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seColumnCount.EditValueChanged
            Toolbox.OptionsView.ColumnCount = CInt((seColumnCount.Value))
        End Sub
        Protected Sub OnColumnCountMinimizingChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seColumnCountMinimizing.EditValueChanged
            Toolbox.OptionsMinimizing.ColumnCount = CInt((seColumnCountMinimizing.Value))
        End Sub
        Protected Sub OnItemViewModeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbItemViewMode.SelectedIndexChanged
            Toolbox.OptionsView.ItemViewMode = CType(cbItemViewMode.EditValue, ToolboxItemViewMode)
        End Sub
        Protected Sub OnShowSearchPanelChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowSearchPanel.CheckedChanged
            Toolbox.OptionsView.ShowSearchPanel = ceShowSearchPanel.Checked
        End Sub
        Protected Sub OnToolboxDragItemDrop(ByVal sender As Object, ByVal e As ToolboxDragItemDropEventArgs) Handles xtraToolboxControl.DragItemDrop
            Dim pt As Point = ContentPanel.PointToClient(Cursor.Position)
            If Not ContentPanel.Bounds.Contains(pt) Then
                Return
            End If
            Dim indent As Point = Point.Empty
            For Each item As ToolboxItem In e.Items
                Dim info As New ImageInfo()
                info.Image = item.Image
                pt.Offset(-item.Image.Size.Width \ 2, -item.Image.Height \ 2)
                info.Bounds = New Rectangle(pt, item.Image.Size)
                ContentPanel.Images.Add(info)
            Next item
        End Sub
        Protected Sub OnGroupsContentAutoSizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceGroupsContentAutoSize.CheckedChanged
            Toolbox.OptionsView.GroupPanelAutoHeight = ceGroupsContentAutoSize.Checked
        End Sub
        Protected Sub OnXtraToolboxSizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles xtraToolboxControl.SizeChanged
            splitContainerControl1.SplitterPosition = Toolbox.Width
        End Sub
        Protected Sub OnToolboxStateChanged(ByVal sender As Object, ByVal e As ToolboxStateChangedEventArgs) Handles xtraToolboxControl.StateChanged
            Toolbox.OptionsView.ShowMenuButton = Toolbox.OptionsMinimizing.State = ToolboxState.Minimized
            UpdateEditors()
        End Sub
        Protected Sub OnToolboxDragItemMove(ByVal sender As Object, ByVal e As ToolboxDragItemMoveEventArgs) Handles xtraToolboxControl.DragItemMove
            Dim p As Point = ContentPanel.PointToClient(e.Location)
            If ContentPanel.Bounds.Contains(p) Then
                e.DragDropEffects = DragDropEffects.Copy
            Else
                e.DragDropEffects = DragDropEffects.None
            End If
        End Sub
        Protected Sub OnToolboxDragItemStart(ByVal sender As Object, ByVal e As ToolboxDragItemStartEventArgs) Handles xtraToolboxControl.DragItemStart
            e.Image = CreateDragImage(e.Items)
            e.Handled = True
        End Sub
        Protected Function CreateDragImage(ByVal items As IEnumerable(Of IToolboxItem)) As Image
            Dim sz As Size = Toolbox.OptionsView.ItemImageSize
            Dim width As Integer = (sz.Width \ 2) * items.Count() + sz.Width \ 2
            Dim height As Integer = (sz.Height \ 2) * items.Count() + sz.Height \ 2
            Dim bmp As New Bitmap(width, height)
            Dim loc As Point = Point.Empty
            Using g As Graphics = Graphics.FromImage(bmp)
                For Each item As ToolboxItem In items
                    g.DrawImage(item.Image, loc)
                    loc.Offset(sz.Width \ 2, sz.Height \ 2)
                Next item
            End Using
            Return bmp
        End Function
        Protected Sub OnAllowSmoothScrollingChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowSmoothScrolling.CheckedChanged
            Toolbox.OptionsBehavior.AllowSmoothScrolling = ceAllowSmoothScrolling.Checked
        End Sub
        Protected Sub OnItemSelectModeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeItemSelectMode.EditValueChanged
            Toolbox.OptionsBehavior.ItemSelectMode = CType(cbeItemSelectMode.SelectedItem, ToolboxItemSelectMode)
        End Sub
    End Class

    Public Class SimpleContentPanel
        Inherits GroupControl

        Private collection As ImageCollectionCore

        Private hint_Renamed As LabelControl
        Public Sub New()
            collection = CreateImageCollection()
            hint_Renamed = CreateHint()
            SubscribeEvent()
        End Sub
        Public ReadOnly Property Images() As ImageCollectionCore
            Get
                Return collection
            End Get
        End Property
        Public ReadOnly Property Hint() As LabelControl
            Get
                Return hint_Renamed
            End Get
        End Property
        Protected Function CreateImageCollection() As ImageCollectionCore
            Return New ImageCollectionCore()
        End Function
        Protected Function CreateHint() As LabelControl
            Dim lbl As New LabelControl()
            lbl.Text = "Drop item here..."
            Controls.Add(lbl)
            lbl.AutoSizeMode = LabelAutoSizeMode.None
            lbl.Dock = DockStyle.Fill
            lbl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            lbl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            lbl.Appearance.Font = New Font(lbl.Appearance.Font.FontFamily, 15.0F)
            Return lbl
        End Function
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            DrawImages(e)
        End Sub
        Protected Overrides Sub OnLoaded()
            MyBase.OnLoaded()
            Invalidate()
        End Sub
        Protected Sub DrawImages(ByVal e As PaintEventArgs)
            For Each info As ImageInfo In Images
                e.Graphics.DrawImage(info.Image, info.Bounds)
            Next info
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                UnsubscribeEvent()
            End If
            MyBase.Dispose(disposing)
        End Sub
        Protected Sub SubscribeEvent()
            AddHandler collection.ListChanged, AddressOf OnCollectionChanged
        End Sub
        Protected Sub UnsubscribeEvent()
            RemoveHandler collection.ListChanged, AddressOf OnCollectionChanged
        End Sub
        Protected Sub OnCollectionChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
            Invalidate()
            Hint.Visible = False
        End Sub
        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            Invalidate()
        End Sub
    End Class

    Public Class ImageCollectionCore
        Inherits CollectionBase
        Implements IEnumerable(Of ImageInfo)

        Public Overridable Sub Add(ByVal item As ImageInfo)
            Dim index As Integer = List.Add(item)
            RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemAdded, index))
        End Sub
        Default Public Overridable Property Item(ByVal index As Integer) As ImageInfo
            Get
                Return TryCast(List(index), ImageInfo)
            End Get
            Set(ByVal value As ImageInfo)
                If value Is Nothing Then
                    Return
                End If
                List(index) = value
            End Set
        End Property
        Public Overridable Function Remove(ByVal item As ImageInfo) As Boolean
            If Not Contains(item) Then
                Return False
            End If
            List.Remove(item)
            RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemDeleted, -1))
            Return True
        End Function
        Public Overridable Sub Insert(ByVal position As Integer, ByVal item As ImageInfo)
            If Contains(item) Then
                Return
            End If
            List.Insert(position, item)
        End Sub
        Public Overridable Function Contains(ByVal item As ImageInfo) As Boolean
            Return List.Contains(item)
        End Function
        Public Overridable Function IndexOf(ByVal item As ImageInfo) As Integer
            Return List.IndexOf(item)
        End Function
        Private lockUpdate As Integer
        Public Overridable Sub BeginUpdate()
            lockUpdate += 1
        End Sub
        Public Overridable Sub EndUpdate()
            lockUpdate -= 1
            If lockUpdate <> 0 Then
                Return
            End If
            RaiseListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1))
        End Sub
        Protected Overrides Sub OnClear()
            For n As Integer = Count - 1 To 0 Step -1
                RemoveAt(n)
            Next n
        End Sub
        Protected Overrides Sub OnInsertComplete(ByVal position As Integer, ByVal value As Object)
            MyBase.OnInsertComplete(position, value)
            RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemAdded, position))
        End Sub
        Protected Overrides Sub OnRemoveComplete(ByVal position As Integer, ByVal value As Object)
            MyBase.OnRemoveComplete(position, value)
            RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemDeleted, position))
        End Sub
        Protected Overrides Sub OnClearComplete()
            MyBase.OnClearComplete()
            RaiseListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1))
        End Sub
        Protected Overrides Sub OnSetComplete(ByVal index As Integer, ByVal oldValue As Object, ByVal newValue As Object)
            MyBase.OnSetComplete(index, oldValue, newValue)
            RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemChanged, index))
        End Sub
        Protected Overridable Sub RaiseListChanged(ByVal e As ListChangedEventArgs)
            If ListChangedEvent Is Nothing Then
                Return
            End If
            RaiseEvent ListChanged(Me, e)
        End Sub
        Public Event ListChanged As ListChangedEventHandler
        #Region "IEnumerator"
        Private Function IEnumerableGeneric_GetEnumerator() As IEnumerator(Of ImageInfo) Implements IEnumerable(Of ImageInfo).GetEnumerator
            Return List.Cast(Of ImageInfo)().GetEnumerator()
        End Function
        #End Region
    End Class

    Public Class ImageInfo
        Public Sub New()
        End Sub
        Public Property Image() As Image
        Public Property Bounds() As Rectangle
    End Class
End Namespace

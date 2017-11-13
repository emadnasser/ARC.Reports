Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Namespace PhotoViewer
	Partial Public Class ImageCollectionViewer
		Inherits XtraUserControl
		Private filesCore() As String
		Private thumbPathCore As String
		Public Sub New(ByVal files() As String, ByVal thumbPath As String)
			Me.filesCore = files
			Me.thumbPathCore = thumbPath
			InitializeComponent()
			InitializeGallery()
		End Sub
		Public ReadOnly Property Files() As String()
			Get
				Return filesCore
			End Get
		End Property
		Public ReadOnly Property ThumbPath() As String
			Get
				Return thumbPathCore
			End Get
		End Property
		Protected Sub InitializeGallery()
			For Each file As String In Files
				gallery.Gallery.Groups(0).Items.Add(CreateGalleryItem(file))
			Next file
			gallery.Gallery.Groups(0).Items(0).Checked = True
			If Files.Length = 1 Then
				dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
				dockManager.RemovePanel(dockPanel1)
			End If
		End Sub
		Protected Overridable Function CreateGalleryItem(ByVal file As String) As GalleryItem
			Dim item As GalleryItem = New GalleryItem()
			item.Tag = file
			item.Image = ThumbnailHelper.Default.GetThumbnail(file, 208, ThumbPath)
			Return item
		End Function
		Private Sub gallery_ItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs) Handles gallery.Gallery.ItemCheckedChanged
			If e.Item.Checked Then
				If Parent Is Nothing Then
					UpdateImage()
				Else
					gallery.Gallery.ScrollTo(e.Item, True, DevExpress.Utils.VertAlignment.Center)
				End If
			End If
		End Sub
		Private Sub leftLabel_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As GalleryItem = GetCheckedItem()
			Dim itemIndex As Integer = item.GalleryGroup.Items.IndexOf(item)
			itemIndex = Math.Max(0, itemIndex - 1)
			item.GalleryGroup.Items(itemIndex).Checked = True
		End Sub
		Private Sub rightLabel_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As GalleryItem = GetCheckedItem()
			Dim itemIndex As Integer = item.GalleryGroup.Items.IndexOf(item)
			itemIndex = Math.Min(item.GalleryGroup.Items.Count - 1, itemIndex + 1)
			item.GalleryGroup.Items(itemIndex).Checked = True
		End Sub
		Protected Overridable Function GetCheckedItem() As GalleryItem
			For Each item As GalleryItem In gallery.Gallery.Groups(0).Items
				If item.Checked Then
					Return item
				End If
			Next item
			Return Nothing
		End Function
		Private Sub galleryControl1_Gallery_EndScroll(ByVal sender As Object, ByVal e As EventArgs) Handles gallery.Gallery.EndScroll
			BeginInvoke(New MethodInvoker(AddressOf UpdateImage))
		End Sub
		Public Sub UpdateImage()
			pictureEdit.LoadAsync(CStr(GetCheckedItem().Tag))
		End Sub
		Private Sub UpdatePreviewImage()
			If controlContainer2.Controls.Count > 0 Then
				Dim fp As SimpleFilterParams = CType(controlContainer2.Controls(0), SimpleFilterParams)
				fp.ImageToFilter = pictureEdit.Image
			End If
		End Sub
		Public Sub SetFilter(ByVal info As FilterInfo)
			If controlContainer2.Controls.Count > 0 Then
				Dim paramsControl As SimpleFilterParams = TryCast(controlContainer2.Controls(0), SimpleFilterParams)
				If paramsControl IsNot Nothing Then
					RemoveHandler paramsControl.ApplyFilter, AddressOf OnApplyFilter
					controlContainer2.Controls.Remove(paramsControl)
					paramsControl.Dispose()
				End If
				controlContainer2.Controls.Clear()
			End If
			If info IsNot Nothing Then
				Dim pc As SimpleFilterParams = info.CreateParamsControl()
				pc.Dock = DockStyle.Fill
				AddHandler pc.ApplyFilter, AddressOf OnApplyFilter
				dockPanel2.Text = info.Name
				controlContainer2.Controls.Add(pc)
				UpdatePreviewImage()
			End If
		End Sub
		Protected Overrides Sub OnParentChanged(ByVal e As EventArgs)
			MyBase.OnParentChanged(e)
			If Parent Is Nothing AndAlso controlContainer2.Controls.Count > 0 Then
				RemoveHandler (CType(controlContainer2.Controls(0), SimpleFilterParams)).ApplyFilter, AddressOf OnApplyFilter
			End If
		End Sub
		Private Sub OnApplyFilter(ByVal sender As Object, ByVal e As EventArgs)
			Dim paramsControl As SimpleFilterParams = TryCast(controlContainer2.Controls(0), SimpleFilterParams)
			If paramsControl Is Nothing Then
				Return
			End If
            Dim oldImage As Image
            If pictureEdit.Tag Is Nothing Then oldImage = Nothing Else oldImage = pictureEdit.Image
            If pictureEdit.Tag Is Nothing Then
                pictureEdit.Tag = pictureEdit.Image
            End If
            pictureEdit.Image = FilterHelper.ApplyFilter(paramsControl.Filter.Name, pictureEdit.Image, paramsControl.GetParams())
            If oldImage IsNot Nothing Then
                oldImage.Dispose()
            End If
            Dim form As GalleryForm = TryCast(FindForm(), GalleryForm)
            If form IsNot Nothing Then
                form.UpdateCancelButtonEnabledState()
            End If
        End Sub
		Public Sub CancelFilters()
			Dim oldImage As Image = pictureEdit.Image
			If pictureEdit.Tag IsNot Nothing Then
				pictureEdit.Image = CType(pictureEdit.Tag, Image)
				pictureEdit.Tag = Nothing
			End If
		End Sub
		Friend Function IsImageFilterd() As Boolean
			Return pictureEdit.Tag IsNot Nothing
		End Function
		Private Sub pictureEdit_LoadCompleted(ByVal sender As Object, ByVal e As EventArgs) Handles pictureEdit.LoadCompleted
			UpdatePreviewImage()
        End Sub
        Friend Sub SetMenuManager(ByVal ribbonBarManager As RibbonBarManager)
            pictureEdit.MenuManager = ribbonBarManager
        End Sub
    End Class
End Namespace

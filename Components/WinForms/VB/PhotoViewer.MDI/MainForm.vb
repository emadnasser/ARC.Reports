Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo
Imports PhotoViewer.Data
Imports DevExpress.XtraSplashScreen

Namespace PhotoViewer
    Partial Public Class MainForm
        Inherits RibbonForm
Friend lockParentRibbonPageChanged As Integer
        Public Shared HoverSkinImageSize As Size = New Size(116, 86)
        Public Shared SkinImageSize As Size = New Size(58, 43)
        Public Sub New()
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me) 'DEMO_REMOVE
            InitializeComponent()
            mainRibbon.MdiMergeStyle = RibbonMdiMergeStyle.Always
            InitSkins()
            SelectDefaultPage()
            LoadData()
            UpdateItemsEnabledState()
            UpdateAddToLibraryItem(biAddFolder)
            AddHandler tabbedView.DocumentAdded, AddressOf tabbedView_DocumentAdded
            AddHandler tabbedView.DocumentRemoved, AddressOf tabbedView_DocumentRemoved
            AddHandler tabbedView.FloatDocuments.CollectionChanged, AddressOf tabbedView_FloatDocumentsCollectionChanged
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            For Each album As AlbumData In ViewData.Albums
                OpenAlbum(album)
            Next album
            SplashScreenManager.CloseForm()
        End Sub
        Protected Friend Sub UpdateSelectedPictureEdit(ByVal fileName As String)
            selectedPictureEdit.LoadAsync(fileName)
        End Sub
        Private viewData_Renamed As PhotoViewerData
        Private viewDataController As PhotoViewerDataController
        Private lastSelectedGroup As NavBarGroup
        Protected ReadOnly Property ViewData() As PhotoViewerData
            <System.Diagnostics.DebuggerStepThrough()> _
            Get
                If viewData_Renamed Is Nothing Then
                    viewData_Renamed = New PhotoViewerData()
                End If
                Return viewData_Renamed
            End Get
        End Property
        Protected ReadOnly Property DataController() As PhotoViewerDataController
            <System.Diagnostics.DebuggerStepThrough()> _
            Get
                If viewDataController Is Nothing Then
                    viewDataController = New PhotoViewerDataController(ViewData)
                End If
                Return viewDataController
            End Get
        End Property
        Protected ReadOnly Property SelectedAlbum() As AlbumData
            Get
                Dim album As AlbumData
                If CustomizableLink Is Nothing Then album = Nothing Else album = TryCast(CustomizableLink.Item.Tag, AlbumData)
                If album Is Nothing Then
                    If albumGroup.SelectedLink Is Nothing Then album = Nothing Else album = CType(albumGroup.SelectedLink.Item.Tag, AlbumData)
                End If
                Return album
            End Get
        End Property
        Private Sub SaveData()
            DataController.SaveData()
        End Sub
        Private Sub LoadData()
            DataController.LoadData()
            InitNavBar()
        End Sub
        Protected Sub UpdateData()
            UpdateData(False)
        End Sub
        Protected Friend Sub UpdateData(ByVal onlyAlbums As Boolean)
            SaveData()
            InitNavBar(onlyAlbums)
        End Sub
        Private Sub InitSkins()
            SkinHelper.InitSkinGallery(skinGalleryBarItem, True)
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
        End Sub
        Private Sub InitNavBar()
            InitNavBar(False)
        End Sub
        Private Sub InitNavBar(ByVal onlyAlbums As Boolean)
            navBar.SelectedLink = Nothing
            For Each group As NavBarGroup In navBar.Groups
                If onlyAlbums AndAlso group IsNot albumGroup Then
                    Continue For
                End If
                For i As Integer = group.ItemLinks.Count - 1 To 0 Step -1
                    navBar.Items.Remove(group.ItemLinks(i).Item)
                Next i
            Next group
            navBar.BeginUpdate()
            Try
                For Each album As AlbumData In ViewData.Albums
                    Dim item As NavBarItem = CreateAlbumItem(album)
                    navBar.Items.Add(item)
                    albumGroup.ItemLinks.Add(item)
                Next album
                If onlyAlbums Then
                    Return
                End If
                For Each folder As PathData In ViewData.Folders
                    Dim item As NavBarItem = CreateFolderItem(folder)
                    If item IsNot Nothing Then
                        navBar.Items.Add(item)
                        foldersGroup.ItemLinks.Add(item)
                    End If
                Next folder
                For Each file As PathData In ViewData.Others.Files
                    Dim item As NavBarItem = CreateFolderItem(file)
                    If item IsNot Nothing Then
                        navBar.Items.Add(item)
                        othersGroup.ItemLinks.Add(item)
                    End If
                Next file
            Finally
                navBar.EndUpdate()
            End Try
            If navBar.Items.Count > 0 Then
                navBar.SelectedLink = navBar.Items(0).Links(0)
            End If
        End Sub
        Private Sub SelectDefaultPage()
            mainRibbon.SelectedPage = imagePage
        End Sub
        Private Function CreateFolderItem(ByVal folder As PathData) As NavBarItem
            Dim item As NavBarItem = New NavBarItem()
            item.Caption = folder.Name
            item.Hint = folder.Path
            item.Tag = folder
            AddHandler item.LinkClicked, AddressOf OnFolderLinkClicked
            Return item
        End Function
        Private Function CreateAlbumItem(ByVal album As AlbumData) As NavBarItem
            Dim item As NavBarItem = New NavBarItem()
            item.Caption = album.Name
            item.Hint = album.Description
            item.Tag = album
            AddHandler item.LinkClicked, AddressOf OnAlbumLinkClicked
            Return item
        End Function
        Protected Overridable Sub CreateThumbForFiles(ByVal files As List(Of String), ByVal progressText As String)
            Dim pf As ProgressForm = New ProgressForm()
            pf.ProgressControl.Maximum = files.Count
            pf.ProgressControl.ProgressText = progressText
            pf.Show(Me)
            For Each fileName As String In files
                CreateThumbForFile(fileName)
                pf.ProgressControl.Value += 1
                Application.DoEvents()
            Next fileName
            pf.Close()
        End Sub
        Protected Overridable Sub CreateThumbForFile(ByVal fileName As String)
            Dim img As Image = ThumbnailHelper.Default.GetThumbnail(fileName, 208, DataController.ThumbPath)
            If img IsNot Nothing Then
                img.Dispose()
            End If
        End Sub
        Protected Overridable Sub CreateThumbsForFolder(ByVal folder As PathData)
            CreateThumbForFiles(DataController.GetImagesInFolder(folder), "Processing folder")
        End Sub
        Private Sub OnFolderLinkClicked(ByVal sender As Object, ByVal e As NavBarLinkEventArgs)
            If e.Link.Group Is othersGroup Then
                OpenOthers(TryCast(e.Link.Item.Tag, PathData))
            Else
                OpenFolder(TryCast(e.Link.Item.Tag, PathData))
            End If
        End Sub
        Private Sub OnAlbumLinkClicked(ByVal sender As Object, ByVal e As NavBarLinkEventArgs)
            OpenAlbum(TryCast(e.Link.Item.Tag, AlbumData))
        End Sub
        Private Overloads Sub OnFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            SaveData()
        End Sub
        Private Sub OnExitButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles exitButton.Click
            If XtraMessageBox.Show(Me, "Exit Application?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Close()
            End If
        End Sub
        Private Sub OnNewAlbumItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biNewAlbum.ItemClick
            AddAlbum()
        End Sub
        Private Sub OnAddFolderItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biAddFolder.ItemClick
            If folderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                If (Not DataController.IsFolderAdded(folderBrowserDialog1.SelectedPath)) Then
                    Dim p As PathData = New PathData()
                    p.Name = Path.GetFileName(folderBrowserDialog1.SelectedPath)
                    p.Path = folderBrowserDialog1.SelectedPath
                    ViewData.Folders.Add(p)
                    CreateThumbsForFolder(p)
                    UpdateData()
                    navBar.SelectedLink = GetLink(p)
                End If
                UpdateAddToLibraryItem(e.Item)
            End If
        End Sub
        Private Function GetLink(ByVal fileName As String) As NavBarItemLink
            For Each link As NavBarItemLink In othersGroup.ItemLinks
                If (CType(link.Item.Tag, PathData)).Path = fileName Then
                    Return link
                End If
            Next link
            Return Nothing
        End Function
        Private Function GetLinkByTag(ByVal group As NavBarGroup, ByVal tag As Object) As NavBarItemLink
            For Each link As NavBarItemLink In group.ItemLinks
                If link.Item.Tag Is tag Then
                    Return link
                End If
            Next link
            Return Nothing
        End Function
        Private Function GetLink(ByVal album As AlbumData) As NavBarItemLink
            Return GetLinkByTag(albumGroup, album)
        End Function
        Private Function GetLink(ByVal path As PathData) As NavBarItemLink
            Return GetLinkByTag(foldersGroup, path)
        End Function
        Private Sub OnAddFileClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biAddFile.ItemClick
            If imageDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                DataController.AddToOthers(imageDialog.FileNames, Me)
                CreateThumbForFiles(New List(Of String)(imageDialog.FileNames), "Processing files")
                UpdateData()
                Dim lastFileName As String = ViewData.Others.Files(ViewData.Others.Files.Count - 1).Name
                navBar.SelectedLink = GetLink(lastFileName)
            End If
            UpdateAddToLibraryItem(e.Item)
        End Sub
        Private Sub OnNavBarControl1SelectedLinkChanged(ByVal sender As Object, ByVal e As NavBarSelectedLinkChangedEventArgs) Handles navBar.SelectedLinkChanged
            lastSelectedGroup = e.Group
        End Sub
        Private Sub OnNavBarControl1MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBar.MouseDown
            If e.Button = MouseButtons.Right Then
                ShowContextMenu(e.Location)
            End If
        End Sub
        Private Sub ShowContextMenu(ByVal pt As Point)
            Dim hi As NavBarHitInfo = navBar.GetViewInfo().CalcHitInfo(pt)
            If hi.Link Is Nothing Then
                mainRibbon.Manager.SetPopupContextMenu(navBar, Nothing)
                Return
            End If
            customizableLinkCore = hi.Link
            If hi.Group Is albumGroup Then
                mainRibbon.Manager.SetPopupContextMenu(navBar, albumPopupMenu)
            End If
            If hi.Group Is foldersGroup Then
                mainRibbon.Manager.SetPopupContextMenu(navBar, folderPopupMenu)
            End If
            If hi.Group Is othersGroup Then
                mainRibbon.Manager.SetPopupContextMenu(navBar, Nothing)
            End If
        End Sub
        Private Sub OnAboutItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles biAbout.ItemClick
            BarManager.About()
        End Sub
        Private Sub OnSaveImageItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biSaveImage.ItemClick
            XtraMessageBox.Show(Me, "SaveImageItemClick", "PhotoViewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Private Sub OnRibbonControlSelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs) Handles mainRibbon.SelectedPageChanged
            If tabbedView.ActiveDocument IsNot Nothing Then
                Dim galleryForm As GalleryForm = TryCast(tabbedView.ActiveDocument.Form, GalleryForm)
                If galleryForm IsNot Nothing Then
                    galleryForm.OnParentRibbonControlSelectedPageChanged()
                End If
            End If
        End Sub
        Private Sub OnAddToLibraryItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biAddToLibrary.ItemClick
            Dim item As BarItem = TryCast(biAddToLibrary.Tag, BarItem)
            If item IsNot Nothing Then
                item.PerformClick()
            End If
        End Sub
        Private Sub OnGenerateDataItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biGenerateData.ItemClick
            If XtraMessageBox.Show(Me, "Are you sure you want generate data? Current data will be lost.", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) <> System.Windows.Forms.DialogResult.Yes Then
                Return
            End If
            GenerateSampleData()
        End Sub
        Private Sub AddAlbum()
            Dim newAlbum As AlbumData = DataController.AddNewAlbum(Me)
            If newAlbum IsNot Nothing Then
                UpdateData(True)
                navBar.SelectedLink = GetLink(newAlbum)
            End If
        End Sub
        Private Sub EditAlbum(ByVal album As AlbumData)
            AlbumPropertiesForm.EditAlbum(DataController, album, Me)
            Dim document As BaseDocument = Nothing
            If Documents.TryGetValue(album, document) Then
                document.Caption = album.Name
                tabbedView.Controller.Activate(document)
            End If
            UpdateData(True)
        End Sub
        Private Sub RemoveAlbum(ByVal album As AlbumData)
            If DataController.RemoveAlbum(album, Me) Then
                CloseAlbum(album)
                UpdateData()
            End If
        End Sub
        Private Sub RemoveFolder(ByVal folder As PathData)
            If DataController.RemoveFolder(folder, Me) Then
                CloseFolder(folder)
                UpdateData()
            End If
        End Sub
        Private Sub UpdateAlbumButtonsEnabledState()
            biEditAlbum.Enabled = SelectedAlbum IsNot Nothing
            biRemoveAlbum.Enabled = SelectedAlbum IsNot Nothing
        End Sub
        Private Sub UpdateSelectedPictureEdit(ByVal e As GalleryItemEventArgs)
            selectedPictureEdit.LoadAsync(CStr(e.Item.Tag))
        End Sub
        Private Sub UpdateItemsEnabledState()
            UpdateAlbumButtonsEnabledState()
            UpdateCancelButtonEnabledState()
        End Sub
        Private Sub UpdateAddToLibraryItem(ByVal item As BarItem)
            biAddToLibrary.Glyph = item.Glyph
            biAddToLibrary.LargeGlyph = item.LargeGlyph
            biAddToLibrary.SuperTip = item.SuperTip
            biAddToLibrary.Hint = item.Hint
            biAddToLibrary.Tag = item
        End Sub
        Private Sub GenerateSampleData()
            ViewData.FirstRun = True
            DataController.GenerateSampleData()
            UpdateData()
        End Sub
        Friend Sub UpdateCancelButtonEnabledState()
            For Each document As BaseDocument In Documents.Values
                Dim galleryForm As GalleryForm = TryCast(document.Form, GalleryForm)
                If galleryForm IsNot Nothing Then
                    galleryForm.UpdateCancelButtonEnabledState()
                End If
            Next document
        End Sub
        Private Sub OnDateFilterSelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dateFilter.SelectionChanged
            For Each document As BaseDocument In Documents.Values
                Dim galleryForm As GalleryForm = TryCast(document.Form, GalleryForm)
                If galleryForm IsNot Nothing Then
                    galleryForm.FilterGallery(dateFilter.AllowFilter, dateFilter.StartDate, dateFilter.EndDate)
                End If
            Next document
        End Sub
#Region "Documents"
        Private documentsCore As IDictionary(Of Object, BaseDocument) = New Dictionary(Of Object, BaseDocument)()
        Public ReadOnly Property Documents() As IDictionary(Of Object, BaseDocument)
            Get
                Return documentsCore
            End Get
        End Property
        Public Sub CloseAlbum(ByVal album As AlbumData)
            Dim document As BaseDocument = Nothing
            If Documents.TryGetValue(album, document) Then
                tabbedView.Controller.Close(document)
            End If
        End Sub
        Public Sub CloseFolder(ByVal folder As PathData)
            Dim document As BaseDocument = Nothing
            If Documents.TryGetValue(folder, document) Then
                tabbedView.Controller.Close(document)
            End If
        End Sub
        Public Sub OpenOthers(ByVal path As PathData)
            Dim document As BaseDocument = Nothing
            If (Not Documents.TryGetValue(ViewData.Others, document)) Then
                Dim albumForm As AlbumGalleryForm = New AlbumGalleryForm(DataController, ViewData.Others)
                albumForm.MainForm = Me
                albumForm.MdiParent = Me
                albumForm.Show()
                If tabbedView.Documents.TryGetValue(albumForm, document) Then
                    document.Caption = ViewData.Others.Name
                End If
                albumForm.ScrollToFile(path.Path, True)
            Else
                tabbedView.Controller.Activate(document)
            End If
        End Sub
        Public Sub OpenAlbum(ByVal album As AlbumData)
            Dim document As BaseDocument = Nothing
            If (Not Documents.TryGetValue(album, document)) Then
                Dim albumForm As AlbumGalleryForm = New AlbumGalleryForm(DataController, album)
                albumForm.MainForm = Me
                albumForm.MdiParent = Me
                albumForm.Show()
                If tabbedView.Documents.TryGetValue(albumForm, document) Then
                    document.Caption = album.Name
                End If
            Else
                tabbedView.Controller.Activate(document)
            End If
        End Sub
        Public Sub OpenFolder(ByVal folder As PathData)
            Dim document As BaseDocument = Nothing
            If (Not Documents.TryGetValue(folder, document)) Then
                Dim folderForm As FolderGalleryForm = New FolderGalleryForm(DataController, folder)
                folderForm.MainForm = Me
                folderForm.MdiParent = Me
                folderForm.Show()
                If tabbedView.Documents.TryGetValue(folderForm, document) Then
                    document.Caption = folder.Name
                End If
            Else
                tabbedView.Controller.Activate(document)
            End If
        End Sub
        Private Sub tabbedView_DocumentAdded(ByVal sender As Object, ByVal e As DocumentEventArgs)
            RegisterDocument(e.Document)
        End Sub
        Private Sub tabbedView_DocumentRemoved(ByVal sender As Object, ByVal e As DocumentEventArgs)
            UnregisterDocument(e.Document)
        End Sub
        Private Sub tabbedView_FloatDocumentsCollectionChanged(ByVal ea As DevExpress.XtraBars.Docking2010.Base.CollectionChangedEventArgs(Of BaseDocument))
            If ea.ChangedType = DevExpress.XtraBars.Docking2010.Base.CollectionChangedType.ElementAdded Then
                RegisterDocument(ea.Element)
            End If
            If ea.ChangedType = DevExpress.XtraBars.Docking2010.Base.CollectionChangedType.ElementRemoved Then
                UnregisterDocument(ea.Element)
            End If
        End Sub
        Private Sub RegisterDocument(ByVal document As BaseDocument)
            Dim albumForm As AlbumGalleryForm = TryCast(document.Form, AlbumGalleryForm)
            If albumForm IsNot Nothing Then
                Documents.Add(albumForm.Album, document)
            End If
            Dim folderForm As FolderGalleryForm = TryCast(document.Form, FolderGalleryForm)
            If folderForm IsNot Nothing Then
                Documents.Add(folderForm.Folder, document)
            End If
        End Sub
        Private Sub UnregisterDocument(ByVal document As BaseDocument)
            Dim albumForm As AlbumGalleryForm = TryCast(document.Form, AlbumGalleryForm)
            If albumForm IsNot Nothing Then
                Documents.Remove(albumForm.Album)
            End If
            Dim folderForm As FolderGalleryForm = TryCast(document.Form, FolderGalleryForm)
            If folderForm IsNot Nothing Then
                Documents.Remove(folderForm.Folder)
            End If
        End Sub
#End Region ' Documents
#Region "Album PopupMenu"
        Private customizableLinkCore As NavBarItemLink
        Protected ReadOnly Property CustomizableLink() As NavBarItemLink
            Get
                Return customizableLinkCore
            End Get
        End Property
        Private Sub OnRemoveAlbumItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biRemoveAlbum.ItemClick
            If CustomizableLink Is Nothing Then
                Return
            End If
            RemoveAlbum(TryCast(CustomizableLink.Item.Tag, AlbumData))
        End Sub
        Private Sub OnEditAlbumItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biEditAlbum.ItemClick
            If CustomizableLink Is Nothing Then
                Return
            End If
            EditAlbum(TryCast(CustomizableLink.Item.Tag, AlbumData))
        End Sub
        Private Sub OnAlbumPopupMenuCloseUp(ByVal sender As Object, ByVal e As EventArgs) Handles albumPopupMenu.CloseUp
            customizableLinkCore = Nothing
        End Sub
#End Region ' Album PopupMenu
#Region "Folder PopupMenu"
        Private Sub OnRemoveFolderItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biRemoveFolder.ItemClick
            If CustomizableLink Is Nothing Then
                Return
            End If
            Dim folder As PathData = CType(customizableLinkCore.Item.Tag, PathData)
            RemoveFolder(folder)
        End Sub
#End Region ' Folder PopupMenu
        Private viewForm As GalleryForm
        Private lockVisibility As Integer = 0
        Friend Sub StartViewImages(ByVal form As GalleryForm)
            If lockVisibility > 0 Then
                Return
            End If
            lockVisibility += 1
            Try
                If viewForm IsNot Nothing Then
                    viewForm.CloseSelectedTabPage()
                End If
                viewForm = form
                SuspendLayout()
                navBar.Visible = False
                dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                ResumeLayout(True)
                tabbedView.DocumentGroupProperties.ShowTabHeader = False
            Finally
                lockVisibility -= 1
            End Try
        End Sub
        Friend Sub EndViewImages()
            If lockVisibility > 0 Then
                Return
            End If
            lockVisibility += 1
            Try
                SuspendLayout()
                dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
                dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
                navBar.Visible = True
                ResumeLayout(True)
                tabbedView.DocumentGroupProperties.ShowTabHeader = True
            Finally
                viewForm = Nothing
                lockVisibility -= 1
            End Try
        End Sub

        Private Sub BBColorMix_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBColorMix.ItemClick
            Dim form As New DevExpress.XtraEditors.ColorWheel.ColorWheelForm
            form.StartPosition = FormStartPosition.CenterParent
            form.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor
            form.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2
            form.ShowDialog(Me)
        End Sub
    End Class
    Public Class PhotoViewerSplashScreen
        Inherits DemoSplashScreen
        Public Sub New()
            DemoText = "PhotoViewer"
            ProductText = "The XtraBars Suite"
        End Sub
    End Class
End Namespace

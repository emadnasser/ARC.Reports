Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Data
Imports DevExpress.Utils.Helpers
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.WinExplorer
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraNavBar

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class ExplorerView
		Inherits TutorialControl
		Implements IFileSystemNavigationSupports
		Private currentPath_Renamed As String
		Public Sub New()
			InitializeComponent()
			AutoMergeRibbon = True
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Initialize()
		End Sub
		Private Sub Initialize()
			InitializeBreadCrumb()
			InitializeNavBar()
			InitializeAppearance()
			CalcPanels()
			UpdateView()
		End Sub
		Private Sub InitializeBreadCrumb()
			Me.currentPath_Renamed = StartupPath
			BreadCrumb.Path = Me.currentPath_Renamed
			For Each driveInfo As DriveInfo In FileSystemHelper.GetFixedDrives()
				BreadCrumb.Properties.History.Add(New BreadCrumbHistoryItem(driveInfo.RootDirectory.ToString()))
			Next driveInfo
		End Sub
		Private Sub InitializeAppearance()
			Dim item As GalleryItem = rgbiViewStyle.Gallery.GetCheckedItem()
			If item IsNot Nothing Then
				Me.winExplorerView.OptionsView.Style = CType(item.Tag, WinExplorerViewStyle)
			End If
		End Sub
		Private Sub OnBreadCrumbPathChanged(ByVal sender As Object, ByVal e As BreadCrumbPathChangedEventArgs) Handles editBreadCrumb.PathChanged
			Me.currentPath_Renamed = e.Path
			UpdateView()
			UpdateButtons()
		End Sub
		Private Sub OnBreadCrumbNewNodeAdding(ByVal sender As Object, ByVal e As BreadCrumbNewNodeAddingEventArgs) Handles editBreadCrumb.Properties.NewNodeAdding
			e.Node.PopulateOnDemand = True
		End Sub
		Private Sub OnBreadCrumbQueryChildNodes(ByVal sender As Object, ByVal e As BreadCrumbQueryChildNodesEventArgs) Handles editBreadCrumb.Properties.QueryChildNodes
			If e.Node.Caption = "Root" Then
				InitBreadCrumbRootNode(e.Node)
				Return
			End If
			If e.Node.Caption = "Computer" Then
				InitBreadCrumbComputerNode(e.Node)
				Return
			End If
			Dim dir As String = e.Node.Path
			If Not FileSystemHelper.IsDirExists(dir) Then
				Return
			End If
			Dim subDirs() As String = FileSystemHelper.GetSubFolders(dir)
			For i As Integer = 0 To subDirs.Length - 1
				e.Node.ChildNodes.Add(CreateNode(subDirs(i)))
			Next i
		End Sub
		Private Sub InitBreadCrumbRootNode(ByVal node As BreadCrumbNode)
			node.ChildNodes.Add(New BreadCrumbNode("Desktop", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)))
			node.ChildNodes.Add(New BreadCrumbNode("Documents", Environment.GetFolderPath(Environment.SpecialFolder.Recent)))
			node.ChildNodes.Add(New BreadCrumbNode("Music", Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)))
			node.ChildNodes.Add(New BreadCrumbNode("Pictures", Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)))
			node.ChildNodes.Add(New BreadCrumbNode("Video", Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)))
			node.ChildNodes.Add(New BreadCrumbNode("Program Files", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)))
			node.ChildNodes.Add(New BreadCrumbNode("Windows", Environment.GetFolderPath(Environment.SpecialFolder.Windows)))
		End Sub
		Private Sub InitBreadCrumbComputerNode(ByVal node As BreadCrumbNode)
			For Each driveInfo As DriveInfo In FileSystemHelper.GetFixedDrives()
				node.ChildNodes.Add(New BreadCrumbNode(driveInfo.Name, driveInfo.RootDirectory))
			Next driveInfo
		End Sub
		Private Sub OnBreadCrumbValidatePath(ByVal sender As Object, ByVal e As BreadCrumbValidatePathEventArgs) Handles editBreadCrumb.Properties.ValidatePath
			If Not FileSystemHelper.IsDirExists(e.Path) Then
				e.ValidationResult = BreadCrumbValidatePathResult.Cancel
				Return
			End If
			e.ValidationResult = BreadCrumbValidatePathResult.CreateNodes
		End Sub
		Private Sub OnBreadCrumbRootGlyphClick(ByVal sender As Object, ByVal e As EventArgs) Handles editBreadCrumb.Properties.RootGlyphClick
			BreadCrumb.Properties.BreadCrumbMode = BreadCrumbMode.Edit
			BreadCrumb.SelectAll()
		End Sub
		Private Function CreateNode(ByVal path As String) As BreadCrumbNode
			Dim folderName As String = FileSystemHelper.GetDirName(path)
			Return New BreadCrumbNode(folderName, folderName, True)
		End Function
		Protected ReadOnly Property StartupPath() As String
			Get
				Return Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
			End Get
		End Property

		Private Sub UpdateView()
			Dim oldCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			Try
				If Not String.IsNullOrEmpty(Me.currentPath_Renamed) Then
					gridControl.DataSource = FileSystemHelper.GetFileSystemEntries(Me.currentPath_Renamed, GetItemSizeType(ViewStyle), GetItemSize(ViewStyle))
				Else
					gridControl.DataSource = Nothing
				End If
				winExplorerView.RefreshData()
				EnsureSearchEdit()
                BeginInvoke(New MethodInvoker(AddressOf winExplorerView.ClearSelection))
			Finally
				Cursor.Current = oldCursor
			End Try
		End Sub
		Private Sub EnsureSearchEdit()
			EditSearch.Properties.NullText = "Search " & FileSystemHelper.GetDirName(Me.currentPath_Renamed)
			EditSearch.EditValue = Nothing
			Me.winExplorerView.FindFilterText = String.Empty
		End Sub
		Private Sub OnNavPanelLinkClicked(ByVal sender As Object, ByVal e As NavBarLinkEventArgs) Handles navBar.LinkClicked
			BreadCrumb.Path = CStr(e.Link.Item.Tag)
		End Sub
		Private Sub OnShowNavPaneItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ButtonCheckItemNavigationPane.ItemClick
			Dim item As BarCheckItem = CType(e.Item, BarCheckItem)
			Me.liNavPaneRight.Visibility = If(item.Checked, LayoutVisibility.Always, LayoutVisibility.Never)
			Me.navBar.Visible = item.Checked
		End Sub
		Private Sub OnShowFavoritesItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ButtonCheckItemShowFavorites.ItemClick
			Me.groupFavorites.Visible = (CType(e.Item, BarCheckItem)).Checked
		End Sub
		Private Sub OnShowLibrariesItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ButtonCheckItemShowLibraries.ItemClick
			groupLibraries.Visible = (CType(e.Item, BarCheckItem)).Checked
		End Sub
		Private Sub OnShowCheckBoxesItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ButtonItemItemCheckBoxes.ItemClick
			Me.winExplorerView.OptionsView.ShowCheckBoxes = (CType(e.Item, BarCheckItem)).Checked
		End Sub
		Private Sub InitializeNavBar()
			navPanelItemDesktop.Tag = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
			navPanelItemRecent.Tag = Environment.GetFolderPath(Environment.SpecialFolder.Recent)
			navPanelItemDocuments.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			navPanelItemMusic.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
			navPanelItemPictures.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
			navPanelItemVideos.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
			navPanelItemDownloads.Tag = FileSystemHelper.GetDownloadsDir()
			If navPanelItemDownloads.Tag Is Nothing Then
				navPanelItemDownloads.Visible = False
			End If
		End Sub
		Private Sub OnViewStyleGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs) Handles rgbiViewStyle.GalleryItemCheckedChanged
			Dim item As GalleryItem = e.Item
			If Not item.Checked Then
				Return
			End If
			Dim viewStyle As WinExplorerViewStyle = CType(System.Enum.Parse(GetType(WinExplorerViewStyle), item.Tag.ToString()), WinExplorerViewStyle)
			Me.winExplorerView.OptionsView.Style = viewStyle
			FileSystemImageCache.Cache.ClearCache()
			UpdateView()
		End Sub
		Private Sub OnRgbiViewStyleInitDropDown(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs) Handles rgbiViewStyle.GalleryInitDropDownGallery
			e.PopupGallery.SynchWithInRibbonGallery = True
		End Sub
		Private Sub OnEditSearchTextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles EditSearch.TextChanged
			Me.winExplorerView.FindFilterText = EditSearch.Text
		End Sub
		Private Sub OnSelectAllItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles ButtonItemSelectAll.ItemClick
			Me.winExplorerView.SelectAll()
		End Sub
		Private Sub OnSelectNoneItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnSelectNone.ItemClick
			Me.winExplorerView.ClearSelection()
		End Sub
		Private Sub OnInvertSelectionItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles ButtonItemInvertSelection.ItemClick
			For i As Integer = 0 To Me.winExplorerView.RowCount - 1
				Me.winExplorerView.InvertRowSelection(i)
			Next i
		End Sub
		Private Sub OnShowFileNameExtensionsCheckItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles ButtonItemFileNameExtensions.ItemClick
			Dim col As FileSystemEntryCollection = TryCast(gridControl.DataSource, FileSystemEntryCollection)
			If col Is Nothing Then
				Return
			End If
			col.ShowExtensions = (CType(e.Item, BarCheckItem)).Checked
			gridControl.RefreshDataSource()
		End Sub
		Private Sub OnShowHiddenItemsCheckItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles ButtonItemHiddenItems.ItemClick
			btnHideSelectedItems.Enabled = Not(CType(e.Item, BarCheckItem)).Checked
		End Sub
		Private Sub OnHelpButtonItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles ButtonItemHelp.ItemClick
			FileSystemHelper.Run("http://help.devexpress.com")
		End Sub
		Private Sub OnOptionsItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles ButtonItemPropertiesFolder.ItemClick, ButtonItemProperties.ItemClick, ButtonItemOptions.ItemClick, ButtonItemChangeFilderOptions.ItemClick, ContextItemProperties.ItemClick
			Dim entries As IEnumerable(Of FileSystemEntry) = GetSelectedEntries()
			If entries.Count() = 0 Then
				FileSystemHelper.ShellExecuteFileInfo(Me.currentPath_Renamed, ShellExecuteInfoFileType.Properties)
				Return
			End If
			For Each entry As FileSystemEntry In entries
				entry.ShowProperties()
			Next entry
		End Sub
		Private Sub OnWinExplorerViewSelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs) Handles winExplorerView.SelectionChanged
			UpdateButtons()
		End Sub
		Private Sub OnCopyPathItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnCopyItem.ItemClick
			Dim builder As New StringBuilder()
			For Each entry As FileSystemEntry In GetSelectedEntries()
				builder.AppendLine(entry.Path)
			Next entry
			If Not String.IsNullOrEmpty(builder.ToString()) Then
				Clipboard.SetText(builder.ToString())
			End If
		End Sub
		Private Sub OnOpenItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnOpen.ItemClick, ContextItemOpen.ItemClick
			For Each entry As FileSystemEntry In GetSelectedEntries(True)
				entry.DoAction(Me)
			Next entry
		End Sub
		Private Sub OnWinExplorerViewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles winExplorerView.KeyDown
			If e.KeyCode <> Keys.Enter Then
				Return
			End If
			Dim entry As FileSystemEntry = GetSelectedEntries().LastOrDefault()
			If entry IsNot Nothing Then
				entry.DoAction(Me)
			End If
		End Sub
		Private Sub OnWinExplorerViewItemClick(ByVal sender As Object, ByVal e As WinExplorerViewItemClickEventArgs) Handles winExplorerView.ItemClick
			If e.MouseInfo.Button = MouseButtons.Right Then
				itemPopupMenu.ShowPopup(Cursor.Position)
			End If
		End Sub
		Private Sub OnWinExplorerViewItemDoubleClick(ByVal sender As Object, ByVal e As WinExplorerViewItemDoubleClickEventArgs) Handles winExplorerView.ItemDoubleClick
			If e.MouseInfo.Button <> MouseButtons.Left Then
				Return
			End If
			winExplorerView.ClearSelection()
			CType(e.ItemInfo.Row.RowKey, FileSystemEntry).DoAction(Me)
		End Sub
		Private Sub UpdateButtons()
			Dim selEntriesCount As Integer = GetSelectedEntries().Count()
			Me.btnCopyItem.Enabled = selEntriesCount > 0
			Me.btnOpen.Enabled = Me.btnCopyItem.Enabled
            Me.btnUpTo.Enabled = BreadCrumb.CanGoUp
            Me.btnBack.Enabled = BreadCrumb.CanGoBack
            Me.btnForward.Enabled = BreadCrumb.CanGoForward
        End Sub
		Private Sub OnBackButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
            BreadCrumb.GoBack()
        End Sub
		Private Sub OnNextButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnForward.Click
            BreadCrumb.GoForward()
        End Sub
		Private Sub OnUpButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpTo.Click
            BreadCrumb.GoUp()
        End Sub
		Private Sub OnNavigationMenuButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnNavigationHistory.Click
			navigationMenu.ItemLinks.Clear()
			navigationMenu.ItemLinks.AddRange(GetNavigationHistroryItems().ToArray())
			navigationMenu.ShowPopup(PointToScreen(New Point(0, navigationPanel.Bottom)))
		End Sub
        Private Function GetNavigationHistroryItems() As List(Of BarItem)
            Dim list As New List(Of BarItem)()
            Dim history As BreadCrumbHistory = BreadCrumb.GetNavigationHistory()
            For i As Integer = history.Count - 1 To 0 Step -1
                Dim item As BreadCrumbHistoryItem = history(i)
                Dim menuItem As New BarCheckItem()
                menuItem.Tag = i
                menuItem.Caption = FileSystemHelper.GetDirName(item.Path)
                AddHandler menuItem.ItemClick, AddressOf OnNavigationMenuItemClick
                menuItem.Checked = BreadCrumb.GetNavigationHistoryCurrentItemIndex() = i
                list.Add(menuItem)
            Next i
            Return list
        End Function
        Private Sub OnNavigationMenuItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            BreadCrumb.SetNavigationHistoryCurrentItemIndex(CInt(Fix(e.Item.Tag)))
            UpdateButtons()
        End Sub
        Private Function GetSelectedEntries() As List(Of FileSystemEntry)
            Return GetSelectedEntries(False)
        End Function
        Private Function GetSelectedEntries(ByVal sort As Boolean) As List(Of FileSystemEntry)
            Dim list As New List(Of FileSystemEntry)()
            Dim rows() As Integer = winExplorerView.GetSelectedRows()
            For i As Integer = 0 To rows.Length - 1
                list.Add(CType(winExplorerView.GetRow(rows(i)), FileSystemEntry))
            Next i
            If sort Then
                list.Sort(New FileSytemEntryComparer())
            End If
            Return list
        End Function
        Private Function GetItemSize(ByVal viewStyle As WinExplorerViewStyle) As Size
            Select Case viewStyle
                Case WinExplorerViewStyle.ExtraLarge
                    Return New Size(256, 256)
                Case WinExplorerViewStyle.Large
                    Return New Size(96, 96)
                Case WinExplorerViewStyle.Content
                    Return New Size(32, 32)
                Case WinExplorerViewStyle.Small
                    Return New Size(16, 16)
                Case Else
                    Return New Size(96, 96)
            End Select
        End Function
        Private Function GetItemSizeType(ByVal viewStyle As WinExplorerViewStyle) As IconSizeType
            Select Case viewStyle
                Case WinExplorerViewStyle.Large, WinExplorerViewStyle.ExtraLarge
                    Return IconSizeType.ExtraLarge
                Case WinExplorerViewStyle.List, WinExplorerViewStyle.Small
                    Return IconSizeType.Small
                Case WinExplorerViewStyle.Tiles, WinExplorerViewStyle.Medium, WinExplorerViewStyle.Content
                    Return IconSizeType.Large
                Case Else
                    Return IconSizeType.ExtraLarge
            End Select
        End Function
        Private Sub CalcPanels()
            Me.navigationPanel.Location = Point.Empty
            Me.contentPanel.Location = New Point(0, Me.navigationPanel.Bottom - 1)
            Me.contentPanel.Height = Height - Me.navigationPanel.Height + 1
            UpdateNavigationPanelContent()
        End Sub
        Private Sub UpdateNavigationPanelContent()
            EditSearch.Height = BreadCrumb.Height
            BreadCrumb.Location = New Point(BreadCrumb.Location.X, Convert.ToInt32((navigationPanel.Height - BreadCrumb.Height) / 2.0))
            EditSearch.Location = New Point(EditSearch.Location.X, Convert.ToInt32((navigationPanel.Height - EditSearch.Height) / 2.0))
        End Sub
        Public ReadOnly Property BreadCrumb() As BreadCrumbEdit
            Get
                Return editBreadCrumb
            End Get
        End Property
        Public ReadOnly Property ViewStyle() As WinExplorerViewStyle
            Get
                Return Me.winExplorerView.OptionsView.Style
            End Get
        End Property

#Region "IFileSystemNavigationSupports"
        Private ReadOnly Property CurrentPath() As String Implements IFileSystemNavigationSupports.CurrentPath
            Get
                Return currentPath_Renamed
            End Get
        End Property
        Private Sub UpdatePath(ByVal path As String) Implements IFileSystemNavigationSupports.UpdatePath
            BreadCrumb.Path = path
        End Sub
#End Region
    End Class
End Namespace

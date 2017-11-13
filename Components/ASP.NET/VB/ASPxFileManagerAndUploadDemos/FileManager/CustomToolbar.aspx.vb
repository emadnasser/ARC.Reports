Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web.UI
Imports System.Xml.Linq
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class FileManager_CustomToolbar
	Inherits Page
	Private extensionsDisplayName_Renamed As Dictionary(Of String, String)

	Private ReadOnly Property ExtensionsDisplayName() As Dictionary(Of String, String)
		Get
			If extensionsDisplayName_Renamed Is Nothing Then
				extensionsDisplayName_Renamed = XDocument.Load(MapPath("~/Content/FileManager/ExtensionsDisplayName.xml")).Descendants("Extension").ToDictionary(Function(n) n.Attribute("Extension").Value, Function(n) n.Attribute("DisplayName").Value)
			End If
			Return extensionsDisplayName_Renamed
		End Get
	End Property

	Private Property CurrentView() As FileListView
		Get
			Dim view = Session("View")
			Return If(view Is Nothing, FileListView.Thumbnails, CType(Session("View"), FileListView))
		End Get
		Set(ByVal value As FileListView)
			FileManager.SettingsFileList.View = value
			Session("View") = value
		End Set
	End Property
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		FileManager.SettingsFileList.View = CurrentView
		Dim isDetailsView As Boolean = CurrentView.Equals(FileListView.Details)
		SetFileManagerToolbarItemCheckedState("ChangeView-Thumbnails", (Not isDetailsView))
		SetFileManagerToolbarItemCheckedState("ChangeView-Details", isDetailsView)
	End Sub
	Protected Sub ASPxFileManager_CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		CurrentView = CType(System.Enum.Parse(GetType(FileListView), e.Parameter.ToString()), FileListView)
	End Sub
	Protected Sub FileManager_ItemRenaming(ByVal source As Object, ByVal e As FileManagerItemRenameEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub FileManager_ItemMoving(ByVal source As Object, ByVal e As FileManagerItemMoveEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub FileManager_ItemCopying(ByVal source As Object, ByVal e As FileManagerItemCopyEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub FileManager_ItemDeleting(ByVal source As Object, ByVal e As FileManagerItemDeleteEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub PopupControl_WindowCallback(ByVal source As Object, ByVal e As PopupWindowCallbackArgs)
		Select Case e.Parameter
			Case "Files"
				Dim file = FileManager.SelectedFile
				Dim fileInfo = New FileInfo(MapPath(file.FullName))

				PopupControl.JSProperties("cpHeaderText") = Path.GetFileNameWithoutExtension(fileInfo.FullName)
				Type.Text = ExtensionsDisplayName(file.Extension)
				Size.Text = file.Length.ToString("#,#") & " bytes"
				Created.Text = fileInfo.CreationTime.ToString("U")
				Modified.Text = fileInfo.LastWriteTime.ToString("U")
				Accessed.Text = fileInfo.LastAccessTime.ToString("U")
				FormLayout.FindItemOrGroupByName("Contains").Visible = False
				SetFileManagerItemInfo(file)
			Case "Folders"
				Dim folder = FileManager.SelectedFolder
				Dim path = MapPath(folder.FullName)
				Dim directoryInfo = New DirectoryInfo(path)
				Dim filesInfo = directoryInfo.GetFiles("*", SearchOption.AllDirectories)
				Dim folderSize As Long = 0
				For Each info In filesInfo
					folderSize += info.Length
				Next info
				Dim filesCount = filesInfo.Length
				Dim subDirectoriesCount = directoryInfo.GetDirectories("*", SearchOption.AllDirectories).Length

				Type.Text = "Folder"
				Size.Text = folderSize.ToString("#,#") & " bytes"
				Contains.Text = filesCount & " Files, " & subDirectoriesCount & " Folders"
				PopupControl.JSProperties("cpHeaderText") = folder.Name
				Created.Text = Directory.GetCreationTime(path).ToString("U")
				FormLayout.FindItemOrGroupByName("Modified").Visible = False
				FormLayout.FindItemOrGroupByName("Accessed").Visible = False
				SetFileManagerItemInfo(folder)
		End Select
	End Sub

	Private Sub SetFileManagerItemInfo(ByVal item As FileManagerItem)
		PopupControl.JSProperties("cpHeaderText") &= " Properties"
		Name.Text = item.Name
		Location.Text = item.FullName
		RelativeLocation.Text = item.RelativeName
	End Sub
	Private Sub SetFileManagerToolbarItemCheckedState(ByVal commandName As String, ByVal checkedState As Boolean)
		Dim item = FileManager.SettingsToolbar.Items.FindByCommandName(commandName)
		TryCast(item, FileManagerToolbarCustomButton).Checked = checkedState
	End Sub

	Private Sub ValidateSiteEdit(ByVal e As FileManagerActionEventArgsBase)
		e.Cancel = Utils.IsSiteMode
		e.ErrorText = Utils.GetReadOnlyMessageText()
	End Sub
End Class

Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Utils.Helpers
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleBreadCrumbEdit
		Inherits TutorialControl
		Private currentPath As String
		Private properties As RepositoryItemBreadCrumbEdit
		Public Sub New()
            InitializeComponent()
            Me.properties = BreadCrumb.Properties
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleBreadCrumbEdit.vb"
            TutorialInfo.WhatsThisXMLFile = "breadCrumbEdit.xml"
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			InitValues()
		End Sub
		Private Sub InitValues()
			Me.currentPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
			BreadCrumb.Path = Me.currentPath
			For Each driveInfo As DriveInfo In FileSystemHelper.GetFixedDrives()
				BreadCrumb.Properties.History.Add(New BreadCrumbHistoryItem(driveInfo.RootDirectory.ToString()))
			Next driveInfo
			Me.cbeMode.Properties.Items.AddEnum(GetType(BreadCrumbMode))
			Me.cbeMode.EditValue = Me.properties.BreadCrumbMode
			Me.seDropDownRowCount.Value = Me.properties.NodeDropDownRowCount
			Me.ceShowRootGlyph.Checked = Me.properties.ShowRootGlyph
			If Me.cbeImages.Properties.Items.Count > 0 Then
				Me.cbeImages.SelectedIndex = 0
			End If
		End Sub
		' <breadCrumbEdit>
		Private Sub OnBreadCrumbPathChanged(ByVal sender As Object, ByVal e As BreadCrumbPathChangedEventArgs) Handles breadCrumbEdit.Properties.PathChanged
			Me.pathLabel.Text = e.Path
			Me.currentPath = Me.pathLabel.Text
			AddEventEntry("PathChanged", e.Path)
			UpdateControls()
		End Sub
		Private Sub OnBreadCrumbNewNodeAdding(ByVal sender As Object, ByVal e As BreadCrumbNewNodeAddingEventArgs) Handles breadCrumbEdit.Properties.NewNodeAdding
			AddEventEntry("NewNodeAdding", e.Node)
			e.Node.PopulateOnDemand = True
		End Sub
		Private Sub OnBreadCrumbQueryChildNodes(ByVal sender As Object, ByVal e As BreadCrumbQueryChildNodesEventArgs) Handles breadCrumbEdit.Properties.QueryChildNodes
			AddEventEntry("QueryChildNodes", e.Node)
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
		Private Sub OnBreadCrumbValidatePath(ByVal sender As Object, ByVal e As BreadCrumbValidatePathEventArgs) Handles breadCrumbEdit.Properties.ValidatePath
			AddEventEntry("ValidatePath", e.Path)
			If Not FileSystemHelper.IsDirExists(e.Path) Then
				e.ValidationResult = BreadCrumbValidatePathResult.Cancel
				Return
			End If
			e.ValidationResult = BreadCrumbValidatePathResult.CreateNodes
		End Sub
		Private Sub OnBreadCrumbRootGlyphClick(ByVal sender As Object, ByVal e As EventArgs) Handles breadCrumbEdit.Properties.RootGlyphClick
			AddEventEntry("RootGlyphClick", sender)
			BreadCrumb.Properties.BreadCrumbMode = BreadCrumbMode.Edit
			BreadCrumb.SelectAll()
		End Sub
		Private Sub OnBreadCrumbNodeClick(ByVal sender As Object, ByVal e As BreadCrumbNodeClickEventArgs) Handles breadCrumbEdit.Properties.NodeClick
			AddEventEntry("NodeClick", e.Node)
		End Sub
		Private Sub OnBreadCrumbShowUserActionMenu(ByVal sender As Object, ByVal e As BreadCrumbShowUserActionMenuEventArgs) Handles breadCrumbEdit.Properties.ShowUserActionMenu
			AddEventEntry("ShowUserActionMenu", sender)
		End Sub
		Private Sub OnBreadCrumbShownNodeDropdown(ByVal sender As Object, ByVal e As BreadCrumbShownNodeDropDownEventArgs) Handles breadCrumbEdit.Properties.ShownNodeDropdown
			AddEventEntry("ShownNodeDropdown", e.Node)
		End Sub
		Private Sub OnBreadCrumbHiddenNodeDropDown(ByVal sender As Object, ByVal e As BreadCrumbHiddenNodeDropDownEventArgs) Handles breadCrumbEdit.Properties.HiddenNodeDropDown
			AddEventEntry("HiddenNodeDropDown", e.Node)
		End Sub
		Private Sub OnBreadCrumbPathRejected(ByVal sender As Object, ByVal e As BreadCrumbPathRejectedEventArgs) Handles breadCrumbEdit.Properties.PathRejected
			AddEventEntry("PathRejected", e.Path)
		End Sub
		Private Sub OnBreadCrumbSelectedNodeChanged(ByVal sender As Object, ByVal e As BreadCrumbSelectedNodeChangedEventArgs) Handles breadCrumbEdit.Properties.SelectedNodeChanged
			AddEventEntry("SelectedNodeChanged", e.NewNode)
			Me.selNodeValueLabel.Text = If(e.NewNode IsNot Nothing, e.NewNode.ToString(), "(none)")
		End Sub
		Private Sub OnBreadCrumbSelectorClientEmptySpaceClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles breadCrumbEdit.Properties.SelectorClientEmptySpaceClick
			AddEventEntry("SelectorClientEmptySpaceClick", e.Location)
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
		Private Function CreateNode(ByVal path As String) As BreadCrumbNode
			Dim folderName As String = FileSystemHelper.GetDirName(path)
			Return New BreadCrumbNode(folderName, folderName, True)
		End Function
		' </breadCrumbEdit>
		' <btnClearEventLog>
		Private Sub OnClearEventLogClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearEventLog.Click
			Me.eventsLog.Text = String.Empty
		End Sub
		' </btnClearEventLog>
		' <cbeMode>
		Private Sub OnBreadCrumbModeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeMode.SelectedIndexChanged
			Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
			Me.properties.BreadCrumbMode = CType(comboBox.EditValue, BreadCrumbMode)
		End Sub
		' </cbeMode>
		' <seDropDownRowCount>
		Private Sub OnBreadCrumbDropDownRowCountChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seDropDownRowCount.EditValueChanged
            If Me.properties Is Nothing Then
                Return
            End If
            Dim spinEdit As SpinEdit = CType(sender, SpinEdit)
            Me.properties.NodeDropDownRowCount = CInt(Fix(spinEdit.Value))
        End Sub
		' </seDropDownRowCount>
		' <ceShowRootGlyph>
		Private Sub OnShowRootGlyphCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowRootGlyph.CheckedChanged
			Dim checkEdit As CheckEdit = CType(sender, CheckEdit)
			Me.properties.ShowRootGlyph = checkEdit.Checked
		End Sub
		' </ceShowRootGlyph>
		' <cbeImages>
		Private Sub OnBreadCrumbSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeImages.SelectedIndexChanged
			Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
			Me.properties.ImageIndex = comboBox.SelectedIndex
			Me.properties.RootImageIndex = Me.properties.ImageIndex
		End Sub
		' </cbeImages>
		' <btnGoUp>
		Private Sub OnGoUpClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnGoUp.Click
            Me.BreadCrumb.GoUp()
        End Sub
		' </btnGoUp>
		' <btnGoBack>
		Private Sub OnGoBackClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnGoBack.Click
            Me.BreadCrumb.GoBack()
        End Sub
		' </btnGoBack>
		' <btnGoForward>
		Private Sub OnGoForwardClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnGoForward.Click
            Me.BreadCrumb.GoForward()
        End Sub
		' </btnGoForward>

		Private Sub AddEventEntry(ByVal entry As String, ByVal obj As Object)
			Dim val As String = String.Empty
			If obj IsNot Nothing Then
				val = If(TypeOf obj Is BreadCrumbEdit, GetType(BreadCrumbEdit).Name, obj.ToString())
			Else
				val = "(null)"
			End If
			Me.eventsLog.Text = String.Format("{0}: {1}{2}", entry, val, Environment.NewLine) + eventsLog.Text
		End Sub
		Private Sub UpdateControls()
            Me.btnGoBack.Enabled = Me.BreadCrumb.CanGoBack
            Me.btnGoForward.Enabled = Me.BreadCrumb.CanGoForward
            Me.btnGoUp.Enabled = Me.BreadCrumb.CanGoUp
        End Sub
        Private ReadOnly Property BreadCrumb() As BreadCrumbEdit
            Get
                Return breadCrumbEdit
            End Get
        End Property
	End Class
End Namespace

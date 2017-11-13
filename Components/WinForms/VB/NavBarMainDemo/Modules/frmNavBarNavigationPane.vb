Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraNavBar.Demos
	''' <summary>
	''' Summary description for frmNavBarNavigationPane.
	''' </summary>
	Partial Public Class frmNavBarNavigationPane
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			navBarItem1.Tag = MailFilter.Inbox
			navBarItem2.Tag = MailFilter.Outbox
			navBarItem3.Tag = MailFilter.Sent
			navBarItem4.Tag = MailFilter.Deleted
			navBarItem5.Tag = MailFilter.Draft
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub frmNavBarNavigationPane_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            richTextBox1.LoadFile(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Description.rtf"), RichTextBoxStreamType.RichText)
			InitControls()
			InitData()
		End Sub

		Private Sub InitData()
			gridControl1.DataSource = OutlookData.CreateTaskTable()
			gridControl2.DataSource = OutlookData.CreateNotesTable()
			gridControl3.DataSource = OutlookData.CreateJournalTable()
		End Sub

		Private Sub InitControls()
			Dim selectedIndex As Integer = 0
			Dim activeGroup As NavBarGroup = navBarGroup2
			navBarControl1.ActiveGroup = activeGroup
			'litter1.LocationChanged += new EventHandler(splitter1_LocationChanged);
			activeGroup.SelectedLinkIndex = selectedIndex
			navBarControl1_ActiveGroupChanged(navBarControl1, New NavBarGroupEventArgs(activeGroup))
			navBarItem_LinkClicked(navBarControl1, New NavBarLinkEventArgs(activeGroup.ItemLinks(selectedIndex)))
			navBarControl1.OptionsNavPane.AllowOptionsMenuItem = True
		End Sub
		Private Sub splitter1_LocationChanged(ByVal sender As Object, ByVal e As EventArgs)
			CheckNavPaneState()
		End Sub
		Private isProcessingLayout As Boolean = False
		Protected Sub CheckNavPaneState()
			If navBarControl1.OptionsNavPane.IsAnimationInProgress Then
				Return
			End If
			If Not isProcessingLayout Then
				Try
					If navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded Then
						If navBarControl1.Width < navBarControl1.OptionsNavPane.ExpandedWidth Then
							isProcessingLayout = True
							navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed
							Return
						End If
					End If
					If navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed Then
						If navBarControl1.Width > navBarControl1.CalcCollapsedPaneWidth() Then
							isProcessingLayout = True
							navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded
							Return
						End If
					End If
				Finally
					isProcessingLayout = False
				End Try
			End If
		End Sub
		Private Sub navBarControl1_ActiveGroupChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupEventArgs) Handles navBarControl1.ActiveGroupChanged
            ActiveGroupChanged(e.Group.Caption, e.Group.LargeImageIndex)
			If e.Group.Caption = "Folder List" Then
				treeView1.SelectedNode = treeView1.Nodes(0)
				treeView1.ExpandAll()
			End If
		End Sub

        Private Sub ActiveGroupChanged(ByVal caption As String, ByVal index As Integer)
            label1.Text = caption
            pictureBox1.Image = imageList1.Images(index)
            ShowPanel(caption)
        End Sub

		Private Sub navBarItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarItem5.LinkClicked, navBarItem1.LinkClicked, navBarItem2.LinkClicked, navBarItem3.LinkClicked, navBarItem4.LinkClicked
			label2.Text = e.Link.Item.Caption
			pictureBox2.Image = imageList2.Images(e.Link.Item.SmallImageIndex)
			If e.Link.Item.Tag IsNot Nothing Then
				outlookStyle1.MailFilter = CType(e.Link.Item.Tag, MailFilter)
			End If
		End Sub

		Private Sub ShowPanel(ByVal caption As String)
			For Each c As Control In pnlMain.Controls
				If (TypeOf c Is Panel OrElse TypeOf c Is XtraPanel) AndAlso c.Tag IsNot Nothing Then
					c.Dock = DockStyle.Fill
					c.Visible = c.Tag.ToString() = caption
				End If
			Next c
		End Sub

		Private Sub treeView1_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles treeView1.AfterSelect
			Dim action As String = e.Node.Text
			If "InboxOutboxDraftsSent ItemsDeleted Items".IndexOf(action) >= 0 Then
				Dim selectedIndex As Integer = 0
				Dim group As NavBarGroup = navBarGroup2
				For i As Integer = 0 To group.ItemLinks.Count - 1
					If group.ItemLinks(i).Item.Caption = action Then
						selectedIndex = i
						Exit For
					End If
				Next i
				group.SelectedLinkIndex = selectedIndex
				navBarItem_LinkClicked(navBarControl1, New NavBarLinkEventArgs(group.ItemLinks(selectedIndex)))
				action = "Mail"
			End If
			For i As Integer = 0 To navBarControl1.Groups.Count - 1
				If navBarControl1.Groups(i).Caption = action Then
                    ActiveGroupChanged(action, navBarControl1.Groups(i).LargeImageIndex)
					ShowPanel(action)
					Exit For
				End If
			Next i
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If textBox1.Text <> "" OrElse textBox2.Text <> "" Then
				listBox1.Items.Add(textBox1.Text.Trim() & " " & textBox2.Text.Trim())
			End If
				textBox3.Text =""
				textBox2.Text = textBox3.Text
				textBox1.Text = textBox2.Text
		End Sub

		Private Sub linkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
			Process.Start("www.devexpress.com")
		End Sub

		Private Sub gridView1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gridView1.InitNewRow
			Dim row As DataRow = gridView1.GetDataRow(e.RowHandle)
			row("Image") = 0
			row("Check") = False
			row("Date") = Date.Today

		End Sub
	End Class
End Namespace

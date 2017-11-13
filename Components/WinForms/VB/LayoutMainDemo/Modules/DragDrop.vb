Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Dragging
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraLayout.Customization
Imports DevExpress.XtraLayout.Demos.Modules
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraLayout.Demos
	''' <summary>
	''' Summary description for Employees.
	''' </summary>
	Partial Public Class LayoutControlDragDrop
		Inherits TutorialControl
		Implements IDragManager
		Private WithEvents label1 As Label
		Private imageList3 As ImageList
		Private components As IContainer
		Private imageList1 As ImageList
		Private imageList2 As ImageList
		Private layoutControl1 As LayoutControl
		Private layoutControlGroup1 As LayoutControlGroup
		Private layoutControlItem1 As LayoutControlItem
		Private layoutControlItem2 As LayoutControlItem
		Private dragDropLayoutControl1 As DevExpress.XtraLayout.Demos.Modules.DragDropLayoutControl
		Private layoutControlItem3 As LayoutControlItem
		Private dragDropLayoutControl2 As DevExpress.XtraLayout.Demos.Modules.DragDropLayoutControl
		Private layoutControlItem4 As LayoutControlItem
		Private WithEvents listView1 As ListView

		Public Sub New()
			InitializeComponent()

		End Sub
		'common
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(LayoutControlDragDrop))
			Dim listViewItem1 As New System.Windows.Forms.ListViewItem(New String() { "Project"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25F))
			Dim listViewItem2 As New System.Windows.Forms.ListViewItem(New String() { "Deliverable"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25F))
			Dim listViewItem3 As New System.Windows.Forms.ListViewItem(New String() { "Task"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25F))
			Me.label1 = New System.Windows.Forms.Label()
			Me.imageList3 = New System.Windows.Forms.ImageList(Me.components)
			Me.listView1 = New System.Windows.Forms.ListView()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.dragDropLayoutControl2 = New DevExpress.XtraLayout.Demos.Modules.DragDropLayoutControl()
			Me.dragDropLayoutControl1 = New DevExpress.XtraLayout.Demos.Modules.DragDropLayoutControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AllowDrop = True
			Me.label1.ImageIndex = 0
			Me.label1.ImageList = Me.imageList3
			Me.label1.Location = New System.Drawing.Point(421, 7)
			Me.label1.MaximumSize = New System.Drawing.Size(30, 31)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(30, 31)
			Me.label1.TabIndex = 3
'			Me.label1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.label1_DragDrop);
'			Me.label1.DragEnter += New System.Windows.Forms.DragEventHandler(Me.label1_DragEnter);
'			Me.label1.DragLeave += New System.EventHandler(Me.label1_DragLeave);
			' 
			' imageList3
			' 
			Me.imageList3.ImageStream = (CType(resources.GetObject("imageList3.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList3.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList3.Images.SetKeyName(0, "")
			Me.imageList3.Images.SetKeyName(1, "")
			' 
			' listView1
			' 
			Me.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None
			listViewItem1.StateImageIndex = 0
			listViewItem2.Checked = True
			listViewItem2.StateImageIndex = 1
			listViewItem3.Checked = True
			listViewItem3.StateImageIndex = 2
			Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() { listViewItem1, listViewItem2, listViewItem3})
			Me.listView1.Location = New System.Drawing.Point(7, 7)
			Me.listView1.MultiSelect = False
			Me.listView1.Name = "listView1"
			Me.listView1.Scrollable = False
			Me.listView1.Size = New System.Drawing.Size(279, 31)
			Me.listView1.StateImageList = Me.imageList1
			Me.listView1.TabIndex = 2
			Me.listView1.UseCompatibleStateImageBehavior = False
			Me.listView1.View = System.Windows.Forms.View.SmallIcon
'			Me.listView1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.listView1_MouseMove);
'			Me.listView1.GiveFeedback += New System.Windows.Forms.GiveFeedbackEventHandler(Me.listView1_GiveFeedback);
'			Me.listView1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.listView1_MouseDown);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.dragDropLayoutControl2)
			Me.layoutControl1.Controls.Add(Me.dragDropLayoutControl1)
			Me.layoutControl1.Controls.Add(Me.listView1)
			Me.layoutControl1.Controls.Add(Me.label1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(582, 450)
			Me.layoutControl1.TabIndex = 4
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' dragDropLayoutControl2
			' 
			Me.dragDropLayoutControl2.Location = New System.Drawing.Point(297, 49)
			Me.dragDropLayoutControl2.Name = "dragDropLayoutControl2"
			Me.dragDropLayoutControl2.Size = New System.Drawing.Size(279, 370)
			Me.dragDropLayoutControl2.TabIndex = 5
			' 
			' dragDropLayoutControl1
			' 
			Me.dragDropLayoutControl1.Location = New System.Drawing.Point(7, 49)
			Me.dragDropLayoutControl1.Name = "dragDropLayoutControl1"
			Me.dragDropLayoutControl1.Size = New System.Drawing.Size(279, 370)
			Me.dragDropLayoutControl1.TabIndex = 4
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(582, 450)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.AllowHotTrack = False
			Me.layoutControlItem1.Control = Me.listView1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.MaxSize = New System.Drawing.Size(0, 42)
			Me.layoutControlItem1.MinSize = New System.Drawing.Size(31, 42)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem1.Size = New System.Drawing.Size(290, 42)
			Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutControlItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.AllowHotTrack = False
			Me.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
			Me.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.layoutControlItem3.Control = Me.dragDropLayoutControl1
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 42)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem3.Size = New System.Drawing.Size(290, 406)
			Me.layoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem3.Text = "LayoutControl 1"
			Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Bottom
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(77, 20)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.AllowHotTrack = False
			Me.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
			Me.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.layoutControlItem4.Control = Me.dragDropLayoutControl2
			Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem4.Location = New System.Drawing.Point(290, 42)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem4.Size = New System.Drawing.Size(290, 406)
			Me.layoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem4.Text = "LayoutControl 2"
			Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Bottom
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(77, 20)
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.TrimClientAreaToControl = False
			Me.layoutControlItem2.AllowHotTrack = False
			Me.layoutControlItem2.Control = Me.label1
			Me.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(290, 0)
			Me.layoutControlItem2.MinSize = New System.Drawing.Size(31, 31)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem2.Size = New System.Drawing.Size(290, 42)
			Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' LayoutControlDragDrop
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "LayoutControlDragDrop"
			Me.Size = New System.Drawing.Size(582, 450)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		Private dragItem_Renamed As BaseLayoutItem = Nothing
		Private Property DragItem() As BaseLayoutItem Implements IDragManager.DragItem
			Get
				Return dragItem_Renamed
			End Get
			Set(ByVal value As BaseLayoutItem)
				dragItem_Renamed = value
			End Set
		End Property
		Private Sub IDragManager_SetDragCursor(ByVal e As DragDropEffects) Implements IDragManager.SetDragCursor
			SetDragCursor(e)
		End Sub
		Private Sub SetDefaultCursor()
			Cursor = Cursors.Default
		End Sub
		Private Sub SetDragCursor(ByVal e As DragDropEffects)
			If e = DragDropEffects.Move Then
                Cursor = New Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("move.ico"))
			End If
			If e = DragDropEffects.Copy Then
                Cursor = New Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("copy.ico"))
			End If
			If e = DragDropEffects.None Then
				Cursor = Cursors.No
			End If
		End Sub
		Private Function GetDragNode(ByVal data As IDataObject) As LayoutControlItem
			Return TryCast(data.GetData(GetType(LayoutControlItem)), LayoutControlItem)
		End Function
		'ListView1
		Private newItem As ListViewItem = Nothing
		Private Sub listView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listView1.MouseDown
			newItem = listView1.GetItemAt(e.X, e.Y)
		End Sub
		Private Sub listView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listView1.MouseMove
			If newItem Is Nothing OrElse e.Button <> MouseButtons.Left Then
				Return
			End If
			Dim lci As New LayoutControlItem()
			lci.Name = Guid.NewGuid().ToString()
			lci.Control = New TextEdit()
			lci.Control.Name = Guid.NewGuid().ToString()
			lci.Text = newItem.Text
			dragItem_Renamed = lci
			listView1.DoDragDrop(dragItem_Renamed, DragDropEffects.Copy)
		End Sub
		Private Sub listView1_GiveFeedback(ByVal sender As Object, ByVal e As GiveFeedbackEventArgs) Handles listView1.GiveFeedback
			e.UseDefaultCursors = False
		End Sub
		'Label1
		Private Sub label1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles label1.DragDrop
			If CanRecycleDragItem() Then
				Dim control As Control = Nothing
				If TypeOf dragItem_Renamed Is LayoutControlItem Then
					Dim lci As LayoutControlItem = TryCast(dragItem_Renamed, LayoutControlItem)
					control = lci.Control
				End If
				dragItem_Renamed.Parent.Remove(dragItem_Renamed)
				If control IsNot Nothing Then
					control.Parent = Nothing
					control.Dispose()
				End If
				dragItem_Renamed = Nothing
			End If
			SetDefaultLabel()
		End Sub
		Private Sub label1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles label1.DragEnter
			If CanRecycleDragItem() Then
				label1.ImageIndex = 1
				e.Effect = DragDropEffects.Copy
				Cursor = New Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Images.delete.ico"))
			End If
		End Sub
		Private Sub label1_DragLeave(ByVal sender As Object, ByVal e As EventArgs) Handles label1.DragLeave
			SetDefaultLabel()
		End Sub
		Private Sub SetDefaultLabel()
			label1.ImageIndex = 0
			SetDefaultCursor()
		End Sub
		Protected Function CanRecycleDragItem() As Boolean
			If dragItem_Renamed Is Nothing AndAlso TypeOf dragItem_Renamed Is LayoutControlItem Then
				Return False
			End If
			If dragItem_Renamed.Owner Is Nothing Then
				Return False
			End If
			Return True
		End Function
	End Class
End Namespace

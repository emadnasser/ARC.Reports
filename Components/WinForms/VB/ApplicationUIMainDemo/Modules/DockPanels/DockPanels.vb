Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Reflection
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Docking
Imports DevExpress.DXperience.Demos

Namespace DevExpress.ApplicationUI.Demos
	''' <summary>
	''' Summary description for DockPanels.
	''' </summary>
	Partial Public Class DockPanels
		Inherits TutorialControlBase
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private activeIndex As Integer = 0
		'<sbAddPanel>
		Private modulesTypes() As Type = New Type() { Nothing, GetType(SimpleDockPanel), GetType(TabContainer), GetType(HorizontalContainer), GetType(VerticalContainer) }
		Private modules() As BaseControl = New BaseControl() { Nothing, Nothing, Nothing, Nothing, Nothing }
		'</sbAddPanel>
		Private Sub DockPanels_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pnlLeft.Width = sbAutoHide.Width + sbAutoHide.Left * 2
			treeView1.ExpandAll()
			treeView1.SelectedNode = treeView1.Nodes(0).Nodes(0)
			InitDockingStyles()
		End Sub

		Private Sub InitDockingStyles()
			Dim arr As Array = System.Enum.GetValues(GetType(DockingStyle))
			For i As Integer = 0 To arr.Length - 1
				If (Not arr.GetValue(i).Equals(DockingStyle.Fill)) Then
					icbDock.Properties.Items.Add(New ImageComboBoxItem(arr.GetValue(i).ToString(), arr.GetValue(i), -1))
				End If
			Next i
			icbDock.EditValue = DockingStyle.Left
		End Sub

		'<sbAutoHide>
		Private Sub SetRootPanelsVisibility(ByVal control As BaseControl, ByVal visibility As DockVisibility)
			If control IsNot Nothing Then
				For i As Integer = control.Manager.RootPanels.Count - 1 To 0 Step -1
					Dim panel As DockPanel = control.Manager.RootPanels(i)
					If panel Is Nothing OrElse panel.Dock = DockingStyle.Float Then
						Continue For
					End If
					If panel.Count > 0 AndAlso (Not panel.Tabbed) Then
						Dim lastChild As DockPanel = panel(panel.Count - 1)
						For j As Integer = 0 To panel.Count - 2
							panel(j).Visibility = DockVisibility.AutoHide
						Next j
						lastChild.Visibility = DockVisibility.AutoHide
					Else
						panel.Visibility = visibility
					End If
				Next i
			End If
		End Sub
		'</sbAutoHide>

		Private Sub treeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterSelect
			If e.Node.Nodes.Count > 0 Then
				treeView1.SelectedNode = e.Node.Nodes(0)
				Return
			End If
			Dim index As Integer = treeView1.SelectedNode.ImageIndex
			lbCaption.Text = treeView1.SelectedNode.Text
			If modules(index) Is Nothing Then
				Dim constructorInfoObj As ConstructorInfo = modulesTypes(index).GetConstructor(Type.EmptyTypes)
				If constructorInfoObj IsNot Nothing Then
					modules(index) = TryCast(constructorInfoObj.Invoke(Nothing), BaseControl)
					pnlContainer.Controls.Add(modules(index))
					modules(index).Dock = DockStyle.Fill
				Else
					Return
				End If
			End If
			modules(index).BringToFront()
			If modules(activeIndex) IsNot Nothing AndAlso index <> activeIndex Then
				modules(activeIndex).Dispose()
				modules(activeIndex) = Nothing
			End If
			activeIndex = index
			sbAddPanel.Enabled = True
		End Sub

		'<sbAddPanel>
		Private maxPanelCout As Integer = 10
		Private Sub sbAddPanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbAddPanel.Click
			If modules(activeIndex) IsNot Nothing Then
				If modules(activeIndex).Manager.Count < maxPanelCout Then
					modules(activeIndex).Manager.AddPanel(CType(icbDock.EditValue, DockingStyle))
				Else
					sbAddPanel.Enabled = False
				End If
			End If
		End Sub
		'</sbAddPanel>

		'<sbAutoHide>
		Private Sub sbAutoHide_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbAutoHide.Click
			SetRootPanelsVisibility(modules(activeIndex), DockVisibility.AutoHide)
		End Sub

		Private Sub checkAutoHideMouseClick_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles AutoHideMouseClick.CheckedChanged
			If AutoHideMouseClick.Checked Then
				modules(activeIndex).Manager.AutoHiddenPanelShowMode = DevExpress.XtraBars.Docking.AutoHiddenPanelShowMode.MouseClick
			Else
				modules(activeIndex).Manager.AutoHiddenPanelShowMode = DevExpress.XtraBars.Docking.AutoHiddenPanelShowMode.MouseHover
			End If
		End Sub
		'</sbAutoHide>
	End Class
End Namespace

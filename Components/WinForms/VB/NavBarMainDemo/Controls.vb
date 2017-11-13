Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.Linq

Namespace DevExpress.XtraNavBar.Demos
	Public Class TutorialControl
		Inherits TutorialControlBase
'INSTANT VB NOTE: The variable contentPanel was renamed since Visual Basic does not allow class members with the same name:
		Protected contentPanel_Renamed As PanelControl
		Public Sub New()
			Me.contentPanel_Renamed = CreateContentPanel()
			OnAddContentPanel()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			UpdateContentLocation()
			AddHandler SizeChanged, Sub(sender, ee) UpdateContentLocation()
		End Sub
		Protected Overridable Sub OnAddContentPanel()
			Controls.Add(ContentPanel)
			ContentPanel.Padding = New Padding(4)
			ContentPanel.Dock = DockStyle.Fill
			If Not AllowContentBorders Then
				ContentPanel.BorderStyle = BorderStyles.NoBorder
			End If
		End Sub
		Private Sub UpdateContentLocation()
			If DesignMode Then
				Return
			End If
			Dim outerBounds As Rectangle = CalcOuterBounds()
			If outerBounds.IsEmpty Then
				Return
			End If
			Dim xoffset As Integer = (ContentPanel.Width \ 2 - outerBounds.Left - outerBounds.Width \ 2)
			Dim yoffset As Integer = (ContentPanel.Height \ 2 - outerBounds.Top - outerBounds.Height \ 2)

			For Each control As Control In GetContentControls()
				Dim pt As Point = control.Location
				pt.Offset(xoffset, yoffset)
				control.Location = pt
			Next control
		End Sub
		Private Function CalcOuterBounds() As Rectangle
			Dim controls = GetContentControls()
			If controls.Count() = 0 Then
				Return Rectangle.Empty
			End If
			Dim left As Integer = Integer.MaxValue, right As Integer = 0, top As Integer = Integer.MaxValue, bottom As Integer = 0
			For Each control As Control In controls
				If control.Left < left Then
					left = control.Left
				End If
				If control.Right > right Then
					right = control.Right
				End If
				If control.Top < top Then
					top = control.Top
				End If
				If control.Bottom > bottom Then
					bottom = control.Bottom
				End If
			Next control
			Return Rectangle.FromLTRB(left, top, right, bottom)
		End Function
		Private Function GetContentControls() As IEnumerable(Of Control)
			Dim list As New List(Of Control)()
			For Each control As Control In ContentPanel.Controls
				If TypeOf control Is BarDockControl Then
					Continue For
				End If
				list.Add(control)
			Next control
			Return list
		End Function

		Protected Overridable ReadOnly Property AllowContentBorders() As Boolean
			Get
				Return True
			End Get
		End Property
		Protected Overridable Function CreateContentPanel() As PanelControl
			Return New PanelControl()
		End Function
		Protected ReadOnly Property ContentPanel() As PanelControl
			Get
				Return contentPanel_Renamed
			End Get
		End Property
		Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
			Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
			If be IsNot Nothing Then
				be.MenuManager = manager
			End If
		End Sub
		Public Overrides ReadOnly Property AllowPrintOptions() As Boolean
			Get
				Return False
			End Get
		End Property
	End Class
End Namespace

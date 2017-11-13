Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Menu

Namespace DevExpress.XtraTreeMap.Demos
	Partial Public Class TreeMapTutorialControl
		Inherits TutorialControlBase
		Implements IDXMenuManager
		Public Sub New()
			Me.AutoMergeRibbon = True
			Me.SuspendLayout()
			Me.Name = "TreeMapTutorialControl"
			Me.Size = New Size(500, 500)
			Me.ResumeLayout(False)
		End Sub

		Public Overrides Property AutoMergeRibbon() As Boolean
			Get
				Return True
			End Get
			Set(ByVal value As Boolean)
			End Set
		End Property
		Public Overridable ReadOnly Property TreeMapControl() As TreeMapControl
			Get
				Return Nothing
			End Get
		End Property
		Public Property MenuManager() As IDXMenuManager

		Private Function Clone(ByVal newForm As Form) As IDXMenuManager Implements IDXMenuManager.Clone
			Return Me
		End Function
		Private Sub DisposeManager() Implements IDXMenuManager.DisposeManager
		End Sub
		Private Sub ShowPopupMenu(ByVal menu As DXPopupMenu, ByVal control As Control, ByVal pos As Point) Implements IDXMenuManager.ShowPopupMenu
			MenuManagerHelper.ShowMenu(menu, LookAndFeel, MenuManager, control, pos)
		End Sub
	End Class
End Namespace

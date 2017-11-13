Imports System.Collections
Imports System.ComponentModel

Namespace DevExpress.XtraNavBar.Demos
	''' <summary>
	''' Summary description for CustomizableDistances.
	''' </summary>
	Partial Public Class CustomizableDistances
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			SubscribeEvents()
		End Sub
		Private Sub SubscribeEvents()
			AddHandler distanceChanger1.ValueChanged, AddressOf distanceChanger1_ValueChanged
			AddHandler distanceChanger2.ValueChanged, AddressOf distanceChanger2_ValueChanged
			AddHandler distanceChanger3.ValueChanged, AddressOf distanceChanger3_ValueChanged
		End Sub

		Private Sub CustomizableDistances_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pnlHint.Caption = "Customizable Distances Between Groups and Links." & vbCrLf & "  If standard intervals between groups and links don't suit your application's needs, you can use one of the following settings that are offered by the XtraNavBar:" & vbCrLf & "  ExplorerBarGroupInterval - sets the distance between individual groups when the explorer bar view is used;" & vbCrLf & "  LinkInterval - specifies the distance between links;" & vbCrLf & "  ExplorerBarGroupOuterIndent - sets the distance between the control's edges and groups provided that an explorer bar view is applied."
			distanceChanger1.Value = navBarControl1.ExplorerBarGroupInterval
			distanceChanger2.Value = navBarControl1.ExplorerBarGroupOuterIndent
			distanceChanger3.Value = navBarControl1.LinkInterval
		End Sub

		'<distanceChanger1>
		Private Sub distanceChanger1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			navBarControl1.ExplorerBarGroupInterval = If(distanceChanger1.StatusEnabled, distanceChanger1.Value, -1)
		End Sub
		'</distanceChanger1>

		'<distanceChanger2>
		Private Sub distanceChanger2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			navBarControl1.ExplorerBarGroupOuterIndent = If(distanceChanger2.StatusEnabled, distanceChanger2.Value, -1)
		End Sub
		'</distanceChanger2>

		'<distanceChanger3>
		Private Sub distanceChanger3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			navBarControl1.LinkInterval = If(distanceChanger3.StatusEnabled, distanceChanger3.Value, -1)
		End Sub
		'</distanceChanger3>
	End Class
End Namespace

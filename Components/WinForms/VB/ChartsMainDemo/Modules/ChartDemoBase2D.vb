Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu

Namespace DevExpress.XtraCharts.Demos
	Partial Public Class ChartDemoBase2D
		Inherits ChartDemoBase
		Protected seriesSelected As Series = Nothing
		Protected pointSelected As SeriesPoint = Nothing
		Protected selectedAnotherObject As Object = Nothing

		Protected Overridable ReadOnly Property SeriesSelection() As Boolean
			Get
				Return False
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Chart_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			If e.Button <> MouseButtons.Right Then
				Return
			End If
			Dim hitObjects() As Object = ChartControl.HitTest(e.X, e.Y)
			For Each hitObject As Object In hitObjects
				If TypeOf hitObject Is Axis OrElse TypeOf hitObject Is Legend OrElse TypeOf hitObject Is ChartControl OrElse TypeOf hitObject Is XYDiagramPaneBase AndAlso Not(TypeOf ChartControl.Diagram Is GanttDiagram) Then
					Dim popupMenu As DXPopupMenu = ConstructPopupMenu(hitObject, ChartControl)
					MenuManagerHelper.ShowMenu(popupMenu, LookAndFeel, MenuManager, ChartControl, New Point(e.X, e.Y))
					Exit For
				End If
			Next hitObject
		End Sub

		Protected Overrides Sub InitControls()
			ChartControl.SelectionMode = ElementSelectionMode.Single
			AddHandler ChartControl.MouseUp, AddressOf Chart_MouseUp
			AddHandler ChartControl.ObjectHotTracked, AddressOf OnChartControlObjectHotTracked
			AddHandler ChartControl.ObjectSelected, AddressOf OnChartControlObjectSelected
		End Sub
		Protected Overridable Function AllowSelectAnotherObject(ByVal obj As Object) As Boolean
			Return False
		End Function
		Protected Overridable Sub OnChartControlObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs)
			If TypeOf e.Object Is Series Then
				e.Cancel = Not SeriesSelection
			Else
				e.Cancel = Not AllowSelectAnotherObject(e.Object)
			End If
		End Sub
		Protected Overridable Sub OnChartControlObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs)
			If TypeOf e.Object Is Series Then
				e.Cancel = Not SeriesSelection
				If SeriesSelection Then
					Me.seriesSelected = CType(e.Object, Series)
					Me.pointSelected = TryCast(e.AdditionalObject, SeriesPoint)
				End If
			Else
				If AllowSelectAnotherObject(e.Object) Then
					Me.selectedAnotherObject = e.Object
					e.Cancel = False
				Else
					Me.selectedAnotherObject = Nothing
					e.Cancel = True
					ChartControl.ClearSelection(False)
				End If
				If SeriesSelection Then
					Me.seriesSelected = Nothing
					Me.pointSelected = Nothing
				End If
			End If
			UpdateControls()
		End Sub
		Protected Overridable Function ConstructPopupMenu(ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Return DXMenuHelper.ConstructMenu(obj, chartControl)
		End Function
	End Class
End Namespace

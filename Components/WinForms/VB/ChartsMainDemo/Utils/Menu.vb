Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu

Namespace DevExpress.XtraCharts.Demos
	Friend Structure Strings
		Public Structure LegendAlignmentHorizontal
			Public Const leftOutside As String = "Left Outside   "
			Public Const left As String = "Left   "
			Public Const center As String = "Center   "
			Public Const rigth As String = "Right   "
			Public Const rightOutside As String = "Right Outside   "
		End Structure

		Public Structure LegendAlignmentVertical
			Public Const topOutside As String = "Top Outside   "
			Public Const top As String = "Top   "
			Public Const center As String = "Center   "
			Public Const bottom As String = "Bottom   "
			Public Const bottomOutside As String = "Bottom Outside   "
		End Structure

		Public Structure LegendDirection
			Public Const topToBottom As String = "Top To Bottom   "
			Public Const bottomToTop As String = "Bottom To Top   "
			Public Const leftToRight As String = "Left To Right   "
			Public Const rightToLeft As String = "Right To Left   "
		End Structure

		Public Structure Axis
			Public Const reverse As String = "Reverse   "
			Public Const showGridLines As String = "Show Grid Lines   "
			Public Const showMinorGridLines As String = "Show Minor Grid Lines   "
			Public Const interlaced As String = "Interlaced   "
			Public Const showTitle As String = "Show Title   "
			Public Const showLabels As String = "Show Labels   "
		End Structure

		Public Structure Main
			Public Const rotated As String = "Rotated   "
			Public Const axisX As String = "Axis X   "
			Public Const axisY As String = "Axis Y   "
			Public Const legend As String = "Legend   "
		End Structure

		Public Structure Legend
			Public Const alignmentHorizontal As String = "Alignment Horizontal   "
			Public Const alignmentVertical As String = "Alignment Vertical   "
			Public Const direction As String = "Direction   "
			Public Const visible As String = "Visible   "
		End Structure

		Public Structure SecondaryAxes
			Public Const secondaryAxisX As String = "Secondary Axis X"
			Public Const secondaryAxisY As String = "Secondary Axis Y"
		End Structure
	End Structure

	Friend MustInherit Class DXMenuBase
		Inherits DXPopupMenu
		Protected chart As ChartControl

		Public Sub New(ByVal chartControl As ChartControl, ByVal caption As String, ByVal image As Image)
			MyBase.New()
			Me.chart = chartControl
			Me.Caption = caption
			Me.Image = image
		End Sub
	End Class

	Friend MustInherit Class DXCheckItemBase
		Inherits DXMenuCheckItem
		Protected chart As ChartControl

		Public Sub New(ByVal chartControl As ChartControl, ByVal caption As String)
			MyBase.New(caption)
			Me.chart = chartControl
		End Sub
	End Class

	Friend MustInherit Class DXCheckItemMainAxis
		Inherits DXCheckItemBase
		Protected Shared Function GetAxis(ByVal chart As ChartControl, ByVal pane As XYDiagramPaneBase, ByVal isAxisX As Boolean) As Axis2D
			For Each series As Series In chart.Series
				Dim view As XYDiagramSeriesViewBase = TryCast(series.View, XYDiagramSeriesViewBase)
				If view IsNot Nothing AndAlso view.Pane.Equals(pane) Then
					Return If(isAxisX, CType(view.AxisX, Axis2D), CType(view.AxisY, Axis2D))
				End If
			Next series
			Return Nothing
		End Function

		Private ReadOnly pane_Renamed As XYDiagramPaneBase

		Protected ReadOnly Property Pane() As XYDiagramPaneBase
			Get
				Return pane_Renamed
			End Get
		End Property
		Protected MustOverride ReadOnly Property Axis2D() As Axis2D

		Public Sub New(ByVal chartControl As ChartControl, ByVal pane As XYDiagramPaneBase, ByVal caption As String)
			MyBase.New(chartControl, caption)
			Me.pane_Renamed = pane
			Checked = Axis2D.GetVisibilityInPane(Me.Pane)
		End Sub
		Protected Overrides Sub OnCheckedChanged()
			MyBase.OnCheckedChanged()
			Axis2D.SetVisibilityInPane(Checked, Pane)
		End Sub
	End Class

	Friend Class DXMenuLegendAlignmentHorizontal
		Inherits DXMenuBase
		Private Class DXCheckItem
			Inherits DXCheckItemBase
			Private alignment As LegendAlignmentHorizontal

			Public Sub New(ByVal alignment As LegendAlignmentHorizontal, ByVal caption As String, ByVal chartControl As ChartControl)
				MyBase.New(chartControl, caption)
				Me.alignment = alignment
				Checked = Object.Equals(Me.chart.Legend.AlignmentHorizontal, Me.alignment)
			End Sub

			Protected Overrides Sub OnCheckedChanged()
				MyBase.OnCheckedChanged()
				If Checked Then
					Me.chart.Legend.AlignmentHorizontal = Me.alignment
				End If
			End Sub
		End Class

		Public Sub New(ByVal chartControl As ChartControl, ByVal image As Image)
			MyBase.New(chartControl, Strings.Legend.alignmentHorizontal, image)
			Dim item As New DXCheckItem(LegendAlignmentHorizontal.LeftOutside, Strings.LegendAlignmentHorizontal.leftOutside, Me.chart)
			Items.Add(item)

			item = New DXCheckItem(LegendAlignmentHorizontal.Left, Strings.LegendAlignmentHorizontal.left, Me.chart)
			Items.Add(item)

			item = New DXCheckItem(LegendAlignmentHorizontal.Center, Strings.LegendAlignmentHorizontal.center, Me.chart)
			Items.Add(item)

			item = New DXCheckItem(LegendAlignmentHorizontal.Right, Strings.LegendAlignmentHorizontal.rigth, Me.chart)
			Items.Add(item)

			item = New DXCheckItem(LegendAlignmentHorizontal.RightOutside, Strings.LegendAlignmentHorizontal.rightOutside, Me.chart)
			Items.Add(item)
		End Sub
	End Class

	Friend Class DXMenuLegendAlignmentVertical
		Inherits DXMenuBase
		Private Class DXCheckItem
			Inherits DXCheckItemBase
			Private alignment As LegendAlignmentVertical

			Public Sub New(ByVal alignment As LegendAlignmentVertical, ByVal caption As String, ByVal chartControl As ChartControl)
				MyBase.New(chartControl, caption)
				Me.alignment = alignment
				Checked = Object.Equals(Me.chart.Legend.AlignmentVertical, Me.alignment)
			End Sub

			Protected Overrides Sub OnCheckedChanged()
				MyBase.OnCheckedChanged()
				If Checked Then
					Me.chart.Legend.AlignmentVertical = Me.alignment
				End If
			End Sub
		End Class

		Public Sub New(ByVal chartControl As ChartControl, ByVal image As Image)
			MyBase.New(chartControl, Strings.Legend.alignmentVertical, image)
			Dim item As New DXCheckItem(LegendAlignmentVertical.TopOutside, Strings.LegendAlignmentVertical.topOutside, Me.chart)
			Items.Add(item)

			item = New DXCheckItem(LegendAlignmentVertical.Top, Strings.LegendAlignmentVertical.top, Me.chart)
			Items.Add(item)

			item = New DXCheckItem(LegendAlignmentVertical.Center, Strings.LegendAlignmentVertical.center, Me.chart)
			Items.Add(item)

			item = New DXCheckItem(LegendAlignmentVertical.Bottom, Strings.LegendAlignmentVertical.bottom, Me.chart)
			Items.Add(item)

			item = New DXCheckItem(LegendAlignmentVertical.BottomOutside, Strings.LegendAlignmentVertical.bottomOutside, Me.chart)
			Items.Add(item)
		End Sub
	End Class

	Friend Class DXMenuLegendDirection
		Inherits DXMenuBase
		Private Class DXCheckItem
			Inherits DXCheckItemBase
			Private direction As LegendDirection

			Public Sub New(ByVal direction As LegendDirection, ByVal caption As String, ByVal chartControl As ChartControl)
				MyBase.New(chartControl, caption)
				Me.direction = direction
				Checked = Object.Equals(Me.chart.Legend.Direction, Me.direction)
			End Sub

			Protected Overrides Sub OnCheckedChanged()
				MyBase.OnCheckedChanged()
				If Checked Then
					Me.chart.Legend.Direction = Me.direction
				End If
			End Sub
		End Class

		Public Sub New(ByVal chartControl As ChartControl, ByVal image As Image)
			MyBase.New(chartControl, Strings.Legend.direction, image)
			Dim item As New DXCheckItem(LegendDirection.TopToBottom, Strings.LegendDirection.topToBottom, Me.chart)
			Items.Add(item)

			item = New DXCheckItem(LegendDirection.BottomToTop, Strings.LegendDirection.bottomToTop, Me.chart)
			Items.Add(item)

			item = New DXCheckItem(LegendDirection.LeftToRight, Strings.LegendDirection.leftToRight, Me.chart)
			Items.Add(item)

			item = New DXCheckItem(LegendDirection.RightToLeft, Strings.LegendDirection.rightToLeft, Me.chart)
			Items.Add(item)
		End Sub
	End Class

	Friend Class DXMenuLegend
		Inherits DXMenuBase
		Public Sub New(ByVal chartControl As ChartControl, ByVal legendImage As Image, ByVal alignmentHorizontalImage As Image, ByVal alignmentVerticalImage As Image, ByVal directionImage As Image)
			MyBase.New(chartControl, Strings.Main.legend, legendImage)
			Items.Add(New DXMenuLegendAlignmentHorizontal(Me.chart, alignmentHorizontalImage))
			Items.Add(New DXMenuLegendAlignmentVertical(Me.chart, alignmentVerticalImage))
			Items.Add(New DXMenuLegendDirection(Me.chart, directionImage))
		End Sub
	End Class

	Friend MustInherit Class DXMenuAxis
		Inherits DXPopupMenu
		Private MustInherit Class AxisItemBase
			Inherits DXMenuCheckItem
			Protected axis As Axis

			Public Sub New(ByVal axis As Axis, ByVal caption As String)
				MyBase.New(caption)
				Me.axis = axis
			End Sub
		End Class

		Private Class AxisItemInterlaced
			Inherits AxisItemBase
			Public Sub New(ByVal axis As Axis)
				MyBase.New(axis, Strings.Axis.interlaced)
				Checked = Me.axis.Interlaced
			End Sub

			Protected Overrides Sub OnCheckedChanged()
				Me.axis.Interlaced = Checked
			End Sub
		End Class

		Private Class AxisItemReverse
			Inherits AxisItemBase
			Public Sub New(ByVal axis As Axis)
				MyBase.New(axis, Strings.Axis.reverse)
				Checked = Me.axis.Reverse
			End Sub

			Protected Overrides Sub OnCheckedChanged()
				Me.axis.Reverse = Checked
			End Sub
		End Class

		Private Class AxisItemShowGridLines
			Inherits AxisItemBase
			Public Sub New(ByVal axis As Axis)
				MyBase.New(axis, Strings.Axis.showGridLines)
				Checked = Me.axis.GridLines.Visible
			End Sub

			Protected Overrides Sub OnCheckedChanged()
				Me.axis.GridLines.Visible = Checked
			End Sub
		End Class

		Private Class AxisItemShowLabels
			Inherits AxisItemBase
			Public Sub New(ByVal axis As Axis)
				MyBase.New(axis, Strings.Axis.showLabels)
				Checked = Me.axis.Label.Visible
			End Sub

			Protected Overrides Sub OnCheckedChanged()
				Me.axis.Label.Visible = Checked
			End Sub
		End Class

		Private Class AxisItemShowMinorGridLines
			Inherits AxisItemBase
			Public Sub New(ByVal axis As Axis)
				MyBase.New(axis, Strings.Axis.showMinorGridLines)
				Checked = Me.axis.GridLines.MinorVisible
			End Sub

			Protected Overrides Sub OnCheckedChanged()
				Me.axis.GridLines.MinorVisible = Checked
			End Sub
		End Class

		Private Class AxisItemShowTitle
			Inherits AxisItemBase
			Public Sub New(ByVal axis As Axis)
				MyBase.New(axis, Strings.Axis.showTitle)
				Checked = Me.axis.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			End Sub

			Protected Overrides Sub OnCheckedChanged()
				Me.axis.Title.Visibility = If(Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
			End Sub
		End Class

		Public Sub New(ByVal caption As String, ByVal axis As Axis, ByVal image As Image)
			MyBase.New()
			Me.Caption = caption
			Items.Add(New AxisItemInterlaced(axis))
			Items.Add(New AxisItemReverse(axis))
			Items.Add(New AxisItemShowGridLines(axis))
			Items.Add(New AxisItemShowMinorGridLines(axis))
			Items.Add(New AxisItemShowLabels(axis))
			Items.Add(New AxisItemShowTitle(axis))
		End Sub
	End Class

	Friend Class DXMenuAxisX
		Inherits DXMenuAxis
		Public Sub New(ByVal axisX As AxisXBase, ByVal image As Image)
			MyBase.New(Strings.Main.axisX, axisX, image)
		End Sub
	End Class

	Friend Class DXMenuAxisY
		Inherits DXMenuAxis
		Public Sub New(ByVal axisY As AxisYBase, ByVal image As Image)
			MyBase.New(Strings.Main.axisY, axisY, image)
		End Sub
	End Class

	  Friend Class DXMenuMain
		  Inherits DXMenuBase
		Private Class DXCheckItemMainRotated
			Inherits DXCheckItemBase
			Public Sub New(ByVal chartControl As ChartControl)
				MyBase.New(chartControl, Strings.Main.rotated)
				Checked = (CType(chartControl.Diagram, XYDiagram)).Rotated
			End Sub
			Protected Overrides Sub OnCheckedChanged()
				MyBase.OnCheckedChanged()
				If (CType(Me.chart.Diagram, XYDiagram)).Rotated <> Checked Then
					CType(Me.chart.Diagram, XYDiagram).Rotated = Checked
					Me.chart.Animate()
				End If
			End Sub
		End Class

		Protected Class DXCheckItemMainAxisX
			Inherits DXCheckItemMainAxis
			Public Shared Sub CreateMenuItem(ByVal menu As DXMenuMain, ByVal chartControl As ChartControl, ByVal pane As XYDiagramPaneBase)
				If GetAxis(chartControl, pane, True) IsNot Nothing Then
					menu.Items.Add(New DXCheckItemMainAxisX(chartControl, pane))
				End If
			End Sub

			Protected Overrides ReadOnly Property Axis2D() As Axis2D
				Get
					Return GetAxis(chart, Pane, True)
				End Get
			End Property

			Private Sub New(ByVal chartControl As ChartControl, ByVal pane As XYDiagramPaneBase)
				MyBase.New(chartControl, pane, Strings.Main.axisX)
			End Sub
		End Class

		Protected Class DXCheckItemMainAxisY
			Inherits DXCheckItemMainAxis
			Public Shared Sub CreateMenuItem(ByVal menu As DXMenuMain, ByVal chartControl As ChartControl, ByVal pane As XYDiagramPaneBase)
				If GetAxis(chartControl, pane, False) IsNot Nothing Then
					menu.Items.Add(New DXCheckItemMainAxisY(chartControl, pane))
				End If
			End Sub

			Protected Overrides ReadOnly Property Axis2D() As Axis2D
				Get
					Return GetAxis(chart, Pane, False)
				End Get
			End Property

			Private Sub New(ByVal chartControl As ChartControl, ByVal pane As XYDiagramPaneBase)
				MyBase.New(chartControl, pane, Strings.Main.axisY)
			End Sub
		End Class

		Private Class DXCheckItemMainLegend
			Inherits DXCheckItemBase
			Public Sub New(ByVal chartControl As ChartControl)
				MyBase.New(chartControl, Strings.Main.legend)
				Checked = Me.chart.Legend.Visibility <> DefaultBoolean.False
			End Sub
			Protected Overrides Sub OnCheckedChanged()
				MyBase.OnCheckedChanged()
				Me.chart.Legend.Visibility = If(Checked, DefaultBoolean.Default, DefaultBoolean.False)
			End Sub
		End Class

		Private Shared Function GetDefaultPane(ByVal chart As ChartControl) As XYDiagramPaneBase
			Return If(TypeOf chart.Diagram Is XYDiagram, (CType(chart.Diagram, XYDiagram)).DefaultPane, Nothing)
		End Function

		Public Sub New(ByVal chartControl As ChartControl)
			Me.New(chartControl, GetDefaultPane(chartControl))
		End Sub
		Public Sub New(ByVal chartControl As ChartControl, ByVal pane As XYDiagramPaneBase)
			MyBase.New(chartControl, "", Nothing)
			If pane Is Nothing AndAlso TypeOf chart.Diagram Is XYDiagram Then
				pane = GetDefaultPane(chartControl)
			End If
			CreateMenu(Me, chartControl, pane)
		End Sub
		Private Sub CreateMenu(ByVal menu As DXMenuMain, ByVal chartControl As ChartControl, ByVal pane As XYDiagramPaneBase)
			If TypeOf chart.Diagram Is XYDiagram Then
				Items.Add(New DXCheckItemMainRotated(chartControl))
				DXCheckItemMainAxisX.CreateMenuItem(Me, chartControl, pane)
				DXCheckItemMainAxisY.CreateMenuItem(Me, chartControl, pane)
			End If
			Items.Add(New DXCheckItemMainLegend(chartControl))
		End Sub
	  End Class

	Friend Class DXMenuPane
		Inherits DXMenuMain
		Public Sub New(ByVal chartControl As ChartControl, ByVal pane As XYDiagramPaneBase)
			MyBase.New(chartControl, pane)
		End Sub
	End Class

	Friend Class DXMenuGantt
		Inherits DXMenuMain
		Public Sub New(ByVal chartControl As ChartControl)
			MyBase.New(chartControl)
			If TypeOf chart.Diagram Is XYDiagram Then
				Items.RemoveAt(0)
			End If
		End Sub
	End Class

	Friend Class DXMenuSideBySideGantt
		Inherits DXMenuGantt
		Public Sub New(ByVal chartControl As ChartControl)
			MyBase.New(chartControl)
			If TypeOf chart.Diagram Is XYDiagram Then
				Items.RemoveAt(0)
				Items.RemoveAt(0)
			End If
		End Sub
	End Class

	Friend Class DXMenuSecondaryAxes
		Inherits DXMenuMain
		Private Class DXCheckItemMainSecondaryAxisX
			Inherits DXCheckItemBase
			Private ReadOnly Property SecondaryAxisX() As SecondaryAxisX
				Get
					Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
					If diagram IsNot Nothing AndAlso diagram.SecondaryAxesX.Count > 0 Then
						Return diagram.SecondaryAxesX(0)
					End If
					Return Nothing
				End Get
			End Property

			Public Sub New(ByVal chartControl As ChartControl)
				MyBase.New(chartControl, Strings.SecondaryAxes.secondaryAxisX)
				Dim secondSeriesView As XYDiagramSeriesViewBase = If(chart.Series.Count > 1, TryCast(chart.Series(1).View, XYDiagramSeriesViewBase), Nothing)
				If SecondaryAxisX IsNot Nothing AndAlso secondSeriesView IsNot Nothing AndAlso secondSeriesView.AxisX Is SecondaryAxisX Then
					Checked = SecondaryAxisX.Visibility <> DefaultBoolean.False
					Enabled = True
				Else
					Checked = False
					Enabled = False
				End If
			End Sub
			Protected Overrides Sub OnCheckedChanged()
				MyBase.OnCheckedChanged()
				If SecondaryAxisX IsNot Nothing Then
					SecondaryAxisX.Visibility = If(Checked, DefaultBoolean.True, DefaultBoolean.False)
				End If
			End Sub
		End Class

		Private Class DXCheckItemMainSecondaryAxisY
			Inherits DXCheckItemBase
			Private ReadOnly Property SecondaryAxisY() As SecondaryAxisY
				Get
					Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
					If diagram IsNot Nothing AndAlso diagram.SecondaryAxesY.Count > 0 Then
						Return diagram.SecondaryAxesY(0)
					End If
					Return Nothing
				End Get
			End Property

			Public Sub New(ByVal chartControl As ChartControl)
				MyBase.New(chartControl, Strings.SecondaryAxes.secondaryAxisY)
				Dim secondSeriesView As XYDiagramSeriesViewBase = If(chart.Series.Count > 1, TryCast(chart.Series(1).View, XYDiagramSeriesViewBase), Nothing)
				If SecondaryAxisY IsNot Nothing AndAlso secondSeriesView IsNot Nothing AndAlso secondSeriesView.AxisY Is SecondaryAxisY Then
					Checked = SecondaryAxisY.Visibility <> DefaultBoolean.False
					Enabled = True
				Else
					Checked = False
					Enabled = False
				End If
			End Sub
			Protected Overrides Sub OnCheckedChanged()
				MyBase.OnCheckedChanged()
				If SecondaryAxisY IsNot Nothing Then
					SecondaryAxisY.Visibility = If(Checked, DefaultBoolean.True, DefaultBoolean.False)
				End If
			End Sub
		End Class

		Public Sub New(ByVal chartControl As ChartControl)
			MyBase.New(chartControl)
			If TypeOf Me.chart.Diagram Is XYDiagram Then
				Items.Insert(3, New DXCheckItemMainSecondaryAxisY(chartControl))
				Items.Insert(3, New DXCheckItemMainSecondaryAxisX(chartControl))
			End If
		End Sub
	End Class

	Friend NotInheritable Class DXMenuHelper
		Private Shared Function ConstructMainMenu(ByVal mainMenu As DXMenuMain, ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Return ConstructMainMenu(mainMenu, obj, chartControl, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
		End Function
		Private Shared Function ConstructMainMenu(ByVal mainMenu As DXMenuMain, ByVal obj As Object, ByVal chartControl As ChartControl, ByVal legendImage As Image, ByVal alignmentHorizontalImage As Image, ByVal alignmentVerticalImage As Image, ByVal directionImage As Image, ByVal axisXImage As Image, ByVal axisYImage As Image) As DXPopupMenu
			Dim extraMenu As DXPopupMenu
			If TypeOf obj Is Legend Then
				extraMenu = New DXMenuLegend(chartControl, legendImage, alignmentHorizontalImage, alignmentVerticalImage, directionImage)
			ElseIf TypeOf obj Is AxisXBase Then
				extraMenu = New DXMenuAxisX(CType(obj, AxisXBase), axisXImage)
			ElseIf TypeOf obj Is AxisYBase Then
				extraMenu = New DXMenuAxisY(CType(obj, AxisYBase), axisXImage)
			Else
				Return mainMenu
			End If
			For i As Integer = 0 To extraMenu.Items.Count - 1
				If i = 0 Then
					extraMenu.Items(i).BeginGroup = True
				End If
				mainMenu.Items.Add(extraMenu.Items(i))
			Next i
			Return mainMenu
		End Function
		Public Shared Function ConstructMenu(ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Return ConstructMainMenu(New DXMenuMain(chartControl), obj, chartControl)
		End Function
		Public Shared Function ConstructPaneMenu(ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Return ConstructMainMenu(New DXMenuPane(chartControl, TryCast(obj, XYDiagramPaneBase)), obj, chartControl)
		End Function
		Public Shared Function ConstructGanttMenu(ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Return ConstructMainMenu(New DXMenuGantt(chartControl), obj, chartControl)
		End Function
		Public Shared Function ConstructSideBySideGanttMenu(ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Return ConstructMainMenu(New DXMenuSideBySideGantt(chartControl), obj, chartControl)
		End Function
		Public Shared Function ConstructSecondaryAxesMenu(ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Return ConstructMainMenu(New DXMenuSecondaryAxes(chartControl), obj, chartControl)
		End Function

		Private Sub New()
		End Sub
	End Class
End Namespace

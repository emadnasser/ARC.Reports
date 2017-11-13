Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class AnimationDemo
		Inherits ChartDemoBase
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chartControl1
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			ChartControl.AnimationStartMode = ChartAnimationMode.OnDataChanged
			cbSeriesView.Properties.Items.AddRange(AnimationViewTypesItemsGenerator.CreateItems())
			cbSeriesView.SelectedItem = New ComboBoxSeriesViewItem(ViewType.Area)
			UpdateDemoControls(ViewType.Area)
		End Sub

		Private Sub cbSeriesView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSeriesView.SelectedIndexChanged
			barManager1.CloseMenus()
			Dim selectedViewType As ViewType = (CType(cbSeriesView.SelectedItem, ComboBoxSeriesViewItem)).ViewType
			UpdateDemoControls(selectedViewType)
		End Sub
		Private Sub cheShowSeriesLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheShowSeriesLabels.CheckedChanged
			ChangeLabelsVisibility()
		End Sub
		Private Sub sbAnimateChart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbAnimateChart.Click
			ChartControl.Animate()
		End Sub
		Private Sub cbeSeriesAnimation_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeSeriesAnimation.SelectedValueChanged
			SetAnimation(TryCast(cbeSeriesAnimation.EditValue, IAnimationComboBoxItem))
		End Sub
		Private Sub cbePointAnimation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbePointAnimation.SelectedIndexChanged
			SetAnimation(TryCast(cbePointAnimation.EditValue, IAnimationComboBoxItem))
		End Sub
		Private Sub SetAnimation(ByVal comboBoxItem As IAnimationComboBoxItem)
			If comboBoxItem IsNot Nothing Then
				For Each series As Series In ChartControl.Series
					comboBoxItem.ApplyAnimation(series.View)
				Next series
			End If
		End Sub
		Private Sub bbiRotateDiagram_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bbiRotateDiagram.ItemClick
			Dim xyDiagram = TryCast(ChartControl.Diagram, XYDiagram)
			If xyDiagram IsNot Nothing Then
				xyDiagram.Rotated = Not xyDiagram.Rotated
			End If
		End Sub
		Private Sub bbiChangeAxisXDirection_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bbiChangeAxisXDirection.ItemClick
			Dim xyDiagram = TryCast(ChartControl.Diagram, XYDiagram)
			If xyDiagram IsNot Nothing Then
				xyDiagram.AxisX.Reverse = Not xyDiagram.AxisX.Reverse
			End If
		End Sub
		Private Sub bbiChangeAxisYDirection_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bbiChangeAxisYDirection.ItemClick
			Dim xyDiagram = TryCast(ChartControl.Diagram, XYDiagram)
			If xyDiagram IsNot Nothing Then
				xyDiagram.AxisY.Reverse = Not xyDiagram.AxisY.Reverse
			End If
		End Sub
		Private Sub chartControl_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chartControl1.MouseDown
			If e.Button <> MouseButtons.Right Then
				Return
			End If
			If TypeOf ChartControl.Diagram Is XYDiagram Then
				pmContextMenu.ShowPopup(Cursor.Position)
			End If
		End Sub
		Private Sub FillPointAnimationComboBoxEdit(ByVal selectedViewType As ViewType)
			FillAnimationComboBox(cbePointAnimation, Utils.GetPointAnimationTypes(selectedViewType))
		End Sub
		Private Sub FillSeriesAnimationComboBoxEdit(ByVal selectedViewType As ViewType)
			FillAnimationComboBox(cbeSeriesAnimation, Utils.GetSeriesAnimationTypes(selectedViewType))
		End Sub
		Private Sub FillAnimationComboBox(ByVal comboBox As ComboBoxEdit, ByVal animationTypes As List(Of Type))
			Dim comboBoxItems As ComboBoxItemCollection = comboBox.Properties.Items
			comboBoxItems.Clear()
			If animationTypes.Count = 0 Then
				comboBox.Enabled = False
			Else
				comboBox.Enabled = True
				For Each animationType As Type In animationTypes
					comboBoxItems.AddRange(CreateAnimationItems(animationType))
				Next animationType
				comboBoxItems.AddRange(CreateAnimationItems(animationTypes(0), True))
			End If
		End Sub
		Private Sub ChangeLabelsVisibility()
			For Each series As Series In ChartControl.Series
				series.LabelsVisibility = If(cheShowSeriesLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
			Next series
		End Sub
		Private Sub ChangeMarkersVisibility()
			For Each series As Series In ChartControl.Series
				If TypeOf series.View Is RangeAreaSeriesView Then
					Dim rangeAreaView As RangeAreaSeriesView = CType(series.View, RangeAreaSeriesView)
					rangeAreaView.Marker1Visibility = DefaultBoolean.True
					rangeAreaView.Marker2Visibility = DefaultBoolean.True
				ElseIf TypeOf series.View Is RadarRangeAreaSeriesView Then
					Dim rangeAreaView As RadarRangeAreaSeriesView = CType(series.View, RadarRangeAreaSeriesView)
					rangeAreaView.Marker1Visibility = DefaultBoolean.True
					rangeAreaView.Marker2Visibility = DefaultBoolean.True
				ElseIf TypeOf series.View Is PolarRangeAreaSeriesView Then
					Dim rangeAreaView As PolarRangeAreaSeriesView = CType(series.View, PolarRangeAreaSeriesView)
					rangeAreaView.Marker1Visibility = DefaultBoolean.True
					rangeAreaView.Marker2Visibility = DefaultBoolean.True
				ElseIf TypeOf series.View Is LineSeriesView Then
					CType(series.View, LineSeriesView).MarkerVisibility = DefaultBoolean.True
				ElseIf TypeOf series.View Is RadarLineSeriesView Then
					CType(series.View, RadarLineSeriesView).MarkerVisibility = DefaultBoolean.True
				End If
			Next series
		End Sub
		Private Sub UpdateDemoControls(ByVal selectedViewType As ViewType)
			UpdateChart(selectedViewType)
			FillSeriesAnimationComboBoxEdit(selectedViewType)
			FillPointAnimationComboBoxEdit(selectedViewType)
			If cbePointAnimation.Enabled Then
				cbePointAnimation.SelectedIndex = 0
			End If
			If cbeSeriesAnimation.Enabled Then
				cbeSeriesAnimation.SelectedIndex = 0
			End If
			ChangeLabelsVisibility()
			ChangeMarkersVisibility()
		End Sub
		Private Sub UpdateChart(ByVal selectedViewType As ViewType)
			ChartControl.Series.Clear()
			Dim generatedSeries() As Series = SeriesGenerator.GenerateSeries(selectedViewType)
			If generatedSeries IsNot Nothing Then
				ChartControl.Series.AddRange(generatedSeries)
			End If
		End Sub
		Private Function CreateAnimationItems(ByVal type As Type, Optional ByVal isNoneItem As Boolean = False) As List(Of IAnimationComboBoxItem)
			Dim directionProperty As PropertyInfo = type.GetProperty("Direction")
			If directionProperty IsNot Nothing AndAlso (Not isNoneItem) Then
				Dim items As New List(Of IAnimationComboBoxItem)()
				Dim propertyType As Type = directionProperty.PropertyType
				For Each directionValue As Object In System.Enum.GetValues(propertyType)
					items.Add(CreateAnimationItem(type, directionValue, isNoneItem))
				Next directionValue
				Return items
			End If
			Return New List(Of IAnimationComboBoxItem) (New IAnimationComboBoxItem() {CreateAnimationItem(type, Nothing, isNoneItem)})

		End Function
		Private Function CreateAnimationItem(ByVal type As Type, ByVal direction As Object, Optional ByVal isNoneItem As Boolean = False) As IAnimationComboBoxItem
			If type.IsSubclassOf(GetType(XYMarkerAnimationBase)) Then
				Return New ComboBoxXYMarkerAnimationItem(type, isNoneItem, direction)
			ElseIf type.IsSubclassOf(GetType(BarAnimationBase)) Then
				Return New ComboBoxBarAnimationItem(type, isNoneItem, direction)
			ElseIf type.IsSubclassOf(GetType(PieAnimationBase)) Then
				Return New ComboBoxPieAnimationItem(type, isNoneItem, direction)
			ElseIf type.IsSubclassOf(GetType(FunnelAnimationBase)) Then
				Return New ComboBoxFunnelAnimationItem(type, isNoneItem, direction)
			ElseIf type.IsSubclassOf(GetType(CircularMarkerAnimationBase)) Then
				Return New ComboBoxCircularMarkerAnimationItem(type, isNoneItem, direction)
			ElseIf type.IsSubclassOf(GetType(FinancialAnimationBase)) Then
				Return New ComboBoxFinancialPointAnimationItem(type, isNoneItem, direction)
			ElseIf type.IsSubclassOf(GetType(XYSeriesAnimationBase)) Then
				Return New ComboBoxXYSeriesAnimationItem(type, isNoneItem, direction)
			ElseIf type.IsSubclassOf(GetType(CircularSeriesAnimationBase)) Then
				Return New ComboBoxCircularSeriesAnimationItem(type, isNoneItem, direction)
			End If
			Throw New AnimationDemoException(String.Format("Can't create ComboBoxItem. Unknown animation type: {0}", type.Name))
		End Function
	End Class

	#Region "ComboBoxItem classes"
	Friend Interface IAnimationComboBoxItem
		Sub ApplyAnimation(ByVal seriesView As SeriesViewBase)
	End Interface

	Friend MustInherit Class AnimationComboBoxItem(Of TAnimation As AnimationBase, TSeriesView As SeriesViewBase)
		Implements IAnimationComboBoxItem

		Private type As Type
		Private caption As String
		Private isNoneItem As Boolean
		Private direction As Object

		Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
			Me.direction = direction
			Me.caption = GetDisplayName(type, isNoneItem)
			Me.type = type
			Me.isNoneItem = isNoneItem
		End Sub
		Private Function GetDisplayName(ByVal type As Type, ByVal isNoneItem As Boolean) As String
			If isNoneItem Then
				Return "None"
			End If
			Dim attribute As DisplayNameAttribute = TryCast(type.GetCustomAttribute(GetType(DisplayNameAttribute)), DisplayNameAttribute)
			Return If(attribute IsNot Nothing, attribute.DisplayName, type.Name)
		End Function
		Private Function ParseStringByLargeTokens(ByVal sourceString As String) As String
			Dim result As String = ""
			For Each symbol As Char In sourceString
				If Char.IsUpper(symbol) Then
					result &= " "c
				End If
				result &= symbol
			Next symbol
			Return result
		End Function

		Public Sub ApplyAnimation(ByVal seriesView As SeriesViewBase) Implements IAnimationComboBoxItem.ApplyAnimation
			Dim animation As TAnimation = CType(Activator.CreateInstance(type), TAnimation)
			animation.Enabled = Not isNoneItem
			ApplyAnimationInternal(animation, CType(seriesView, TSeriesView))
			If direction IsNot Nothing Then
				Dim directionProperty As PropertyInfo = type.GetProperty("Direction")
				directionProperty.SetValue(animation, direction, Nothing)
			End If
		End Sub
		Public MustOverride Sub ApplyAnimationInternal(ByVal animation As TAnimation, ByVal seriesView As TSeriesView)
		Public Overrides Function ToString() As String
			If direction Is Nothing OrElse isNoneItem Then
				Return caption
			Else
				Return caption & ParseStringByLargeTokens(direction.ToString())
			End If
		End Function
	End Class

	Friend Class ComboBoxXYSeriesAnimationItem
		Inherits AnimationComboBoxItem(Of XYSeriesAnimationBase, LineSeriesView)
		Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
			MyBase.New(type, isNoneItem, direction)
		End Sub
		Public Overrides Sub ApplyAnimationInternal(ByVal animation As XYSeriesAnimationBase, ByVal seriesView As LineSeriesView)
			seriesView.SeriesAnimation = animation
		End Sub
	End Class

	Friend Class ComboBoxXYMarkerAnimationItem
		Inherits AnimationComboBoxItem(Of XYMarkerAnimationBase, PointSeriesViewBase)
		Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
			MyBase.New(type, isNoneItem, direction)
		End Sub
		Public Overrides Sub ApplyAnimationInternal(ByVal animation As XYMarkerAnimationBase, ByVal seriesView As PointSeriesViewBase)
			seriesView.SeriesPointAnimation = animation
		End Sub

	End Class

	Friend Class ComboBoxBarAnimationItem
		Inherits AnimationComboBoxItem(Of BarAnimationBase, BarSeriesView)
		Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
			MyBase.New(type, isNoneItem, direction)
		End Sub
		Public Overrides Sub ApplyAnimationInternal(ByVal animation As BarAnimationBase, ByVal seriesView As BarSeriesView)
			seriesView.Animation = animation
		End Sub
	End Class

	Friend Class ComboBoxPieAnimationItem
		Inherits AnimationComboBoxItem(Of PieAnimationBase, PieSeriesView)
		Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
			MyBase.New(type, isNoneItem, direction)
		End Sub
		Public Overrides Sub ApplyAnimationInternal(ByVal animation As PieAnimationBase, ByVal seriesView As PieSeriesView)
			seriesView.Animation = animation
		End Sub
	End Class

	Friend Class ComboBoxFunnelAnimationItem
		Inherits AnimationComboBoxItem(Of FunnelAnimationBase, FunnelSeriesView)
		Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
			MyBase.New(type, isNoneItem, direction)
		End Sub
		Public Overrides Sub ApplyAnimationInternal(ByVal animation As FunnelAnimationBase, ByVal seriesView As FunnelSeriesView)
			seriesView.Animation = animation
		End Sub
	End Class

	Friend Class ComboBoxCircularMarkerAnimationItem
		Inherits AnimationComboBoxItem(Of CircularMarkerAnimationBase, RadarSeriesViewBase)
		Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
			MyBase.New(type, isNoneItem, direction)
		End Sub
		Public Overrides Sub ApplyAnimationInternal(ByVal animation As CircularMarkerAnimationBase, ByVal seriesView As RadarSeriesViewBase)
			seriesView.SeriesPointAnimation = animation
		End Sub
	End Class

	Friend Class ComboBoxFinancialPointAnimationItem
		Inherits AnimationComboBoxItem(Of FinancialAnimationBase, FinancialSeriesViewBase)
		Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
			MyBase.New(type, isNoneItem, direction)
		End Sub
		Public Overrides Sub ApplyAnimationInternal(ByVal animation As FinancialAnimationBase, ByVal seriesView As FinancialSeriesViewBase)
			seriesView.Animation = animation
		End Sub
	End Class

	Friend Class ComboBoxCircularSeriesAnimationItem
		Inherits AnimationComboBoxItem(Of CircularSeriesAnimationBase, RadarLineSeriesView)
		Public Sub New(ByVal type As Type, ByVal isNoneItem As Boolean, ByVal direction As Object)
			MyBase.New(type, isNoneItem, direction)
		End Sub
		Public Overrides Sub ApplyAnimationInternal(ByVal animation As CircularSeriesAnimationBase, ByVal seriesView As RadarLineSeriesView)
			seriesView.SeriesAnimation = animation
		End Sub
	End Class
	#End Region

	Public Class AnimationDemoException
		Inherits Exception
		Public Sub New(ByVal message As String)
			MyBase.New(message)
		End Sub
	End Class
End Namespace

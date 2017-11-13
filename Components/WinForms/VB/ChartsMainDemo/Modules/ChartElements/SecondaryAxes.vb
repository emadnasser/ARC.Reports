Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu

Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class SecondaryAxesDemo
		Inherits ChartDemoBase2D
		Private Structure AxisItem
			Private ReadOnly axis_Renamed As Axis

			Public ReadOnly Property Axis() As Axis
				Get
					Return axis_Renamed
				End Get
			End Property

			Public Sub New(ByVal axis As Axis)
				Me.axis_Renamed = axis
			End Sub

			Public Overrides Function ToString() As String
				Return axis_Renamed.Name
			End Function
			Public Overrides Overloads Function Equals(ByVal obj As Object) As Boolean
				If Not(TypeOf obj Is AxisItem) Then
					Return False
				End If
				Dim item As AxisItem = CType(obj, AxisItem)
				Return axis_Renamed.Equals(item.axis)
			End Function
			Public Overrides Function GetHashCode() As Integer
				Return axis_Renamed.GetHashCode()
			End Function
		End Structure

		Private Const SecondaryPostfixX As String = " (Secondary Axis X)"
		Private Const SecondaryPostfixY As String = " (Secondary Axis Y)"
		Private Const PrimaryPostfixX As String = " (Primary Axis X)"
		Private Const PrimaryPostfixY As String = " (Primary Axis Y)"
		Private Const LineChart As Integer = 0
		Private Const BarChart As Integer = 1

		Private loading As Boolean
		Private chart As ChartControl

		Private ReadOnly Property Diagram() As XYDiagram
			Get
				Return TryCast(ChartControl.Diagram, XYDiagram)
			End Get
		End Property
		Private ReadOnly Property SecondaryAxisX() As SecondaryAxisX
			Get
				Return If((Diagram IsNot Nothing AndAlso Diagram.SecondaryAxesX.Count > 0), Diagram.SecondaryAxesX(0), Nothing)
			End Get
		End Property
		Private ReadOnly Property SecondaryAxisY() As SecondaryAxisY
			Get
				Return If((Diagram IsNot Nothing AndAlso Diagram.SecondaryAxesY.Count > 0), Diagram.SecondaryAxesY(0), Nothing)
			End Get
		End Property
		Private ReadOnly Property FirstSeries() As Series
			Get
				Return If(ChartControl.Series.Count > 0, ChartControl.Series(0), Nothing)
			End Get
		End Property
		Private ReadOnly Property SecondSeries() As Series
			Get
				Return If(ChartControl.Series.Count > 1, ChartControl.Series(1), Nothing)
			End Get
		End Property
		Private ReadOnly Property SecondSeriesView() As XYDiagramSeriesViewBase
			Get
				Return If(SecondSeries IsNot Nothing, TryCast(SecondSeries.View, XYDiagramSeriesViewBase), Nothing)
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			If Diagram Is Nothing Then
				Return
			End If
			CType(Diagram.AxisX, Axis).Name = "Primary Axis X"
			CType(Diagram.AxisY, Axis).Name = "Primary Axis Y"
			Diagram.SecondaryAxesX.Add(New SecondaryAxisX("Secondary Axis X"))
			Diagram.SecondaryAxesY.Add(New SecondaryAxisY("Secondary Axis Y"))
			Me.cbChartType.Properties.Items.AddRange(New String() { "Line", "Bar" })
			loading = True
			Try
				UpdateChartType()
				If SecondSeries IsNot Nothing Then
					UpdateCBSeriesAxisX(Diagram.AxisX)
					UpdateCBSeriesAxisY(SecondaryAxisY)
				End If
			Finally
				loading = False
			End Try
		End Sub

		Private Sub AttachSecondaryAxisX(ByVal axisX As SecondaryAxisX)
			If axisX Is Nothing OrElse Diagram Is Nothing Then
				Return
			End If
			If SecondSeriesView IsNot Nothing Then
				SecondSeriesView.AxisX = axisX
				axisX.Visibility = DefaultBoolean.True
				If FirstSeries IsNot Nothing Then
					Diagram.AxisX.Title.Text = FirstSeries.Name & PrimaryPostfixX
				End If
				If SecondaryAxisX IsNot Nothing Then
					SecondaryAxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
					SecondaryAxisX.Title.Text = SecondSeries.Name & SecondaryPostfixX
				End If
			End If
		End Sub
		Private Sub AttachSecondaryAxisY(ByVal axisY As SecondaryAxisY)
			If axisY Is Nothing OrElse Diagram Is Nothing Then
				Return
			End If
			If SecondSeriesView IsNot Nothing Then
				SecondSeriesView.AxisY = axisY
				axisY.Visibility = DefaultBoolean.True
				If FirstSeries IsNot Nothing Then
					Diagram.AxisY.Title.Text = FirstSeries.Name & PrimaryPostfixY
				End If
				If SecondaryAxisY IsNot Nothing Then
					SecondaryAxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
					SecondaryAxisY.Title.Text = SecondSeries.Name & SecondaryPostfixY
				End If
			End If
		End Sub
		Private Sub DetachSecondaryAxisX()
			If Diagram Is Nothing Then
				Return
			End If
			If SecondSeriesView IsNot Nothing Then
				If SecondaryAxisX IsNot Nothing Then
					SecondaryAxisX.Visibility = DefaultBoolean.False
				End If
				SecondSeriesView.AxisX = Diagram.AxisX
				If FirstSeries IsNot Nothing Then
					Diagram.AxisX.Title.Text = FirstSeries.Name & ", " & SecondSeries.Name & PrimaryPostfixX
				End If
			End If
		End Sub
		Private Sub DetachSecondaryAxisY()
			If Diagram Is Nothing Then
				Return
			End If
			If SecondSeriesView IsNot Nothing Then
				If SecondaryAxisY IsNot Nothing Then
					SecondaryAxisY.Visibility = DefaultBoolean.False
				End If
				SecondSeriesView.AxisY = Diagram.AxisY
				If FirstSeries IsNot Nothing Then
					Diagram.AxisY.Title.Text = FirstSeries.Name & ", " & SecondSeries.Name & PrimaryPostfixX
				End If
			End If
		End Sub
		Private Sub ChangeSeriesViewType(ByVal viewType As ViewType)
			For Each series As Series In ChartControl.Series
				series.ChangeView(viewType)
			Next series
		End Sub
		Private Sub UpdateChartType()
			Dim selectedIndex As Integer = -1
			For Each series As Series In chart.Series
				If TypeOf series.View Is LineSeriesView Then
					selectedIndex = LineChart
					Exit For
				ElseIf TypeOf series.View Is SideBySideBarSeriesView Then
					selectedIndex = BarChart
				End If
			Next series
			cbChartType.SelectedIndex = selectedIndex
		End Sub
		Private Sub UpdateCBSeriesAxisX(ByVal selectedAxisX As Axis)
			cbSeriesAxisX.Properties.Items.Clear()
			If Diagram Is Nothing Then
				Return
			End If
			cbSeriesAxisX.Properties.Items.Add(New AxisItem(Diagram.AxisX))
			For Each axisX As SecondaryAxisX In Diagram.SecondaryAxesX
				cbSeriesAxisX.Properties.Items.Add(New AxisItem(axisX))
			Next axisX
			cbSeriesAxisX.SelectedItem = New AxisItem(selectedAxisX)
		End Sub
		Private Sub UpdateCBSeriesAxisY(ByVal selectedAxisY As Axis)
			cbSeriesAxisY.Properties.Items.Clear()
			If Diagram Is Nothing Then
				Return
			End If
			cbSeriesAxisY.Properties.Items.Add(New AxisItem(Diagram.AxisY))
			For Each axisY As SecondaryAxisY In Diagram.SecondaryAxesY
				cbSeriesAxisY.Properties.Items.Add(New AxisItem(axisY))
			Next axisY
			cbSeriesAxisY.SelectedItem = New AxisItem(selectedAxisY)
		End Sub
		Private Sub cbChartType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbChartType.SelectedIndexChanged
			If loading Then
				Return
			End If
			If cbChartType.SelectedIndex = LineChart Then
				ChangeSeriesViewType(ViewType.Line)
			ElseIf cbChartType.SelectedIndex = BarChart Then
				ChangeSeriesViewType(ViewType.Bar)
			End If
		End Sub
		Private Sub cbSeriesAxisX_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSeriesAxisX.SelectedIndexChanged
			Dim axisX As SecondaryAxisX = TryCast((CType(cbSeriesAxisX.SelectedItem, AxisItem)).Axis, SecondaryAxisX)
			If axisX IsNot Nothing Then
				AttachSecondaryAxisX(axisX)
			Else
				DetachSecondaryAxisX()
			End If
		End Sub
		Private Sub cbSeriesAxisY_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSeriesAxisY.SelectedIndexChanged
			Dim axisY As SecondaryAxisY = TryCast((CType(cbSeriesAxisY.SelectedItem, AxisItem)).Axis, SecondaryAxisY)
			If axisY IsNot Nothing Then
				AttachSecondaryAxisY(axisY)
			Else
				DetachSecondaryAxisY()
			End If
		End Sub

		Protected Overrides Function ConstructPopupMenu(ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Return DXMenuHelper.ConstructSecondaryAxesMenu(obj, chartControl)
		End Function

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			loading = True
			Try
				UpdateChartType()
				If SecondSeriesView IsNot Nothing Then
					UpdateCBSeriesAxisX(SecondSeriesView.AxisX)
					UpdateCBSeriesAxisY(SecondSeriesView.AxisY)
				End If
			Finally
				loading = False
			End Try
		End Sub
	End Class
End Namespace

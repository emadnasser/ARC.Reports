Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class LegendDemo
	Inherits ChartBasePage
	Private ReadOnly Property Legend() As Legend
		Get
			Return WebChartControl1.Legend
		End Get
	End Property
	Private ReadOnly Property HorizontalDirection() As Boolean
		Get
			Return Legend.Direction = LegendDirection.LeftToRight OrElse Legend.Direction = LegendDirection.RightToLeft
		End Get
	End Property
	Private ReadOnly Property HorizontalAlignmentInside() As Boolean
		Get
			Return Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left OrElse Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center OrElse Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Right
		End Get
	End Property
	Private ReadOnly Property VerticalAlignmentInside() As Boolean
		Get
			Return Legend.AlignmentVertical = LegendAlignmentVertical.Top OrElse Legend.AlignmentVertical = LegendAlignmentVertical.Center OrElse Legend.AlignmentVertical = LegendAlignmentVertical.Bottom
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			InitSeries()
			UpdateEquallySpacedItemsEnable()
			ComboBoxHelper.PrepareComboBox(cbDirection, Legend.Direction)
			ComboBoxHelper.PrepareComboBox(cbVertAlignment, Legend.AlignmentVertical)
			ComboBoxHelper.PrepareComboBox(cbHorAlignment, Legend.AlignmentHorizontal)
			ComboBoxHelper.PrepareLegendPercentComboBox(cbMaxHorPercentage, Legend.MaxHorizontalPercentage)
			ComboBoxHelper.PrepareLegendPercentComboBox(cbMaxVertPercentage, Legend.MaxVerticalPercentage)
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		Select Case e.Parameter
			Case "HorAligment"
				PerformHorAligmentAction()
			Case "VerAligment"
				PerformVerAligmentAction()
			Case "MaxHorPrctg"
				PerformMaxHorPrctgAction()
			Case "MaxVerPrctg"
				PerformMaxVerPrctgAction()
			Case "EqSpaced"
				PerformEqSpacedAction()
			Case "Direction"
				PerformDirectionAction()
		End Select
	End Sub
	Private Sub InitSeries()
		Dim random As New Random()
		For i As Integer = 0 To WebChartControl1.Series.Count - 1
			WebChartControl1.Series(i).Points.Clear()
			Dim points As New List(Of Point)()
			Dim min As Integer = 1
			Dim max As Integer = 10
			Do While points.Count < 5
				Dim point As New Point(random.Next(min, max), random.Next(min, max))
				If (Not points.Contains(point)) Then
					points.Add(point)
					WebChartControl1.Series(i).Points.Add(New SeriesPoint(point.X, point.Y))
				End If
			Loop
		Next i
	End Sub
	Private Sub UpdateEquallySpacedItemsEnable()
		chbEquallySpaced.Checked = Legend.EquallySpacedItems
	End Sub
	Private Sub UpdateLegendMargins()
		If HorizontalAlignmentInside AndAlso VerticalAlignmentInside Then
			WebChartControl1.Legend.Margins.All = 10
		Else
			WebChartControl1.Legend.Margins.All = 5
		End If
	End Sub
	Private Sub PerformHorAligmentAction()
		Legend.AlignmentHorizontal = CType(cbHorAlignment.SelectedIndex, LegendAlignmentHorizontal)
		UpdateLegendMargins()
	End Sub
	Private Sub PerformVerAligmentAction()
		Legend.AlignmentVertical = CType(cbVertAlignment.SelectedIndex, LegendAlignmentVertical)
		UpdateLegendMargins()
	End Sub
	Private Sub PerformMaxHorPrctgAction()
		Legend.MaxHorizontalPercentage = ComboBoxHelper.GetSelectedLegendPercent(cbMaxHorPercentage)
	End Sub
	Private Sub PerformMaxVerPrctgAction()
		Legend.MaxVerticalPercentage = ComboBoxHelper.GetSelectedLegendPercent(cbMaxVertPercentage)
	End Sub
	Private Sub PerformEqSpacedAction()
		If HorizontalDirection Then
			Legend.EquallySpacedItems = chbEquallySpaced.Checked
		End If
	End Sub
	Private Sub PerformDirectionAction()
		Legend.Direction = CType(cbDirection.SelectedIndex, LegendDirection)
		UpdateEquallySpacedItemsEnable()
	End Sub
End Class

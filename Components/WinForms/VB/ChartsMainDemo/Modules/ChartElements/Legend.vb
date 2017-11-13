Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraCharts.Demos.PointLineViews
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class LegendDemo
		Inherits ChartDemoBase2D
		Private WithEvents chart As ChartControl
		Private menuLegendVertItem As DXSubMenuItem
		Private menuLegendHorItem As DXSubMenuItem

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub AddDirectionClickHandlers(ByVal directionItem As DXMenuItem)
			Dim item As DXSubMenuItem = CType(directionItem, DXSubMenuItem)
			AddHandler item.Items(0).Click, AddressOf LegendDirectionItem0Click
			AddHandler item.Items(1).Click, AddressOf LegendDirectionItem1Click
			AddHandler item.Items(2).Click, AddressOf LegendDirectionItem2Click
			AddHandler item.Items(3).Click, AddressOf LegendDirectionItem3Click
		End Sub
		Private Sub LegendDirectionItem0Click(ByVal sender As Object, ByVal e As EventArgs)
			cbEquallySpacedItems.Enabled = False
			cbDirection.SelectedIndex = 0
		End Sub
		Private Sub LegendDirectionItem1Click(ByVal sender As Object, ByVal e As EventArgs)
			cbEquallySpacedItems.Enabled = False
			cbDirection.SelectedIndex = 1
		End Sub
		Private Sub LegendDirectionItem2Click(ByVal sender As Object, ByVal e As EventArgs)
			cbEquallySpacedItems.Enabled = True
			cbDirection.SelectedIndex = 2
		End Sub
		Private Sub LegendDirectionItem3Click(ByVal sender As Object, ByVal e As EventArgs)
			cbEquallySpacedItems.Enabled = True
			cbDirection.SelectedIndex = 3
		End Sub
		Private Sub AddVertAlignmentClickHandlers(ByVal vertItem As DXMenuItem)
			menuLegendVertItem = CType(vertItem, DXSubMenuItem)
			For i As Integer = 0 To menuLegendVertItem.Items.Count - 1
				AddHandler menuLegendVertItem.Items(i).Click, AddressOf LegendVertAlignmentClick
			Next i
		End Sub
		Private Sub AddHorAlignmentClickHandlers(ByVal horItem As DXMenuItem)
			menuLegendHorItem = CType(horItem, DXSubMenuItem)
			For i As Integer = 0 To menuLegendHorItem.Items.Count - 1
				AddHandler menuLegendHorItem.Items(i).Click, AddressOf LegendHorAlignmentClick
			Next i
		End Sub
		Private Sub LegendVertAlignmentClick(ByVal sender As Object, ByVal e As EventArgs)
			cbVertAlign.SelectedIndex = GetCheckedAlign(CType(sender, DXMenuItem), menuLegendVertItem)
		End Sub
		Private Sub LegendHorAlignmentClick(ByVal sender As Object, ByVal e As EventArgs)
			cbHorAlign.SelectedIndex = GetCheckedAlign(CType(sender, DXMenuItem), menuLegendHorItem)
		End Sub
		Private Function GetValueWithoutPercent(ByVal val As String) As String
			Return val.Trim(New Char() { "%"c })
		End Function
		Private Function AddPercentToString(ByVal val As String) As String
			Return val & "%"
		End Function
		Private Sub UpdateEquallySpacedItemsEnable()
			cbEquallySpacedItems.Enabled = ChartControl.Legend.Direction = LegendDirection.LeftToRight OrElse ChartControl.Legend.Direction = LegendDirection.RightToLeft
		End Sub
		Private Function GetCheckedAlign(ByVal sender As DXMenuItem, ByVal item As DXSubMenuItem) As Integer
			If item IsNot Nothing Then
				For index As Integer = 0 To item.Items.Count - 1
					If Object.ReferenceEquals(item.Items(index), sender) Then
						Return index
					End If
				Next index
			End If
			Return -1
		End Function
		Private Sub InitSeries()
			Dim random As New Random()
			For i As Integer = 0 To chart.Series.Count - 1
				chart.Series(i).Points.Clear()
				chart.Series(i).Points.AddRange(RandomPointCalculator.Calculate(random, 5, 1, 10, 1, 10))
			Next i
		End Sub
		Private Sub chart_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.VisibleChanged
			InitSeries()
		End Sub
		Private Sub itemVertAlignment_Click(ByVal sender As Object, ByVal e As EventArgs)
			cbVertAlign.SelectedIndex = CInt(Fix(ChartControl.Legend.AlignmentVertical))
		End Sub
		Private Sub UpdateLegendMargins()
			Dim hAlignment As LegendAlignmentHorizontal = chart.Legend.AlignmentHorizontal
			Dim vAlignment As LegendAlignmentVertical = chart.Legend.AlignmentVertical
			If (Object.Equals(hAlignment, LegendAlignmentHorizontal.Left) OrElse Object.Equals(hAlignment, LegendAlignmentHorizontal.Center) OrElse Object.Equals(hAlignment, LegendAlignmentHorizontal.Right)) AndAlso (Object.Equals(vAlignment, LegendAlignmentVertical.Bottom) OrElse Object.Equals(vAlignment, LegendAlignmentVertical.Center) OrElse Object.Equals(vAlignment, LegendAlignmentVertical.Top)) Then
				chart.Legend.Margins.All = 10
			Else
				chart.Legend.Margins.All = 5
			End If
		End Sub
		Private Sub itemHorAlignment_Click(ByVal sender As Object, ByVal e As EventArgs)
			cbHorAlign.SelectedIndex = CInt(Fix(ChartControl.Legend.AlignmentHorizontal))
		End Sub
		Private Sub cbEquallySpacedItems_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEquallySpacedItems.CheckedChanged
			If chart.Legend.Direction = LegendDirection.LeftToRight OrElse chart.Legend.Direction = LegendDirection.RightToLeft Then
					ChartControl.Legend.EquallySpacedItems = cbEquallySpacedItems.Checked
			End If
		End Sub
		Private Sub cmbMaxHorPercentage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbMaxHorPercentage.SelectedIndexChanged
			Dim value As String = GetValueWithoutPercent(cmbMaxHorPercentage.Text)
			ChartControl.Legend.MaxHorizontalPercentage = Convert.ToDouble(value)
		End Sub
		Private Sub cmbMaxVertPercentage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbMaxVertPercentage.SelectedIndexChanged
			Dim value As String = GetValueWithoutPercent(cmbMaxVertPercentage.Text)
			ChartControl.Legend.MaxVerticalPercentage = Convert.ToDouble(value)
		End Sub
		Private Sub cbDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDirection.SelectedIndexChanged
			Dim edit As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
			If edit IsNot Nothing Then
				ChartControl.Legend.Direction = CType(edit.SelectedIndex, LegendDirection)
				If edit.SelectedIndex = 0 OrElse edit.SelectedIndex = 1 Then
					cbEquallySpacedItems.Enabled = False
				Else
					cbEquallySpacedItems.Enabled = True
				End If
			End If
		End Sub
		Private Sub cbHorAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbHorAlign.SelectedIndexChanged
			Dim edit As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
			If edit IsNot Nothing Then
				ChartControl.Legend.AlignmentHorizontal = CType(edit.SelectedIndex, LegendAlignmentHorizontal)
				UpdateLegendMargins()
			End If
		End Sub
		Private Sub cbVertAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbVertAlign.SelectedIndexChanged
			Dim edit As ComboBoxEdit = TryCast((sender), ComboBoxEdit)
			If edit IsNot Nothing Then
				ChartControl.Legend.AlignmentVertical = CType(edit.SelectedIndex, LegendAlignmentVertical)
				UpdateLegendMargins()
			End If
		End Sub

		Protected Overrides Function ConstructPopupMenu(ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Dim menu As DXPopupMenu = MyBase.ConstructPopupMenu(obj, chartControl)
			If TypeOf obj Is Legend Then
				AddHorAlignmentClickHandlers(menu.Items(4))
				AddVertAlignmentClickHandlers(menu.Items(5))
				AddDirectionClickHandlers(menu.Items(6))
			End If
			Return menu
		End Function
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			CheckEditShowLabelsVisible = False
			UpdateEquallySpacedItemsEnable()
			cbEquallySpacedItems.Checked = chart.Legend.EquallySpacedItems
			cmbMaxHorPercentage.Text = AddPercentToString(ChartControl.Legend.MaxHorizontalPercentage.ToString())
			cmbMaxVertPercentage.Text = AddPercentToString(ChartControl.Legend.MaxVerticalPercentage.ToString())
			cbDirection.SelectedIndex = CInt(Fix(ChartControl.Legend.Direction))
			cbHorAlign.SelectedIndex = CInt(Fix(ChartControl.Legend.AlignmentHorizontal))
			cbVertAlign.SelectedIndex = CInt(Fix(ChartControl.Legend.AlignmentVertical))
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			cbVertAlign.SelectedIndex = CInt(Fix(chart.Legend.AlignmentVertical))
			cbHorAlign.SelectedIndex = CInt(Fix(chart.Legend.AlignmentHorizontal))
			cbDirection.SelectedIndex = CInt(Fix(chart.Legend.Direction))
			cbEquallySpacedItems.Checked = chart.Legend.EquallySpacedItems
		End Sub
	End Class
End Namespace

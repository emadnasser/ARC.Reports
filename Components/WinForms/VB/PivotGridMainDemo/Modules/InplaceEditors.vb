Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class InplaceEditors
		Inherits TutorialControl
		Private lastCells_Renamed(,) As Object
		Private pointDifference_Renamed As List(Of Point)

		Public Property LastCells() As Object(,)
			Get
				Return lastCells_Renamed
			End Get
			Set(ByVal value As Object(,))
				lastCells_Renamed = value
			End Set
		End Property
		Public Property PointDifference() As List(Of Point)
			Get
				Return pointDifference_Renamed
			End Get
			Set(ByVal value As List(Of Point))
				pointDifference_Renamed = value
			End Set
		End Property

		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\InplaceEditors.vb"
            TutorialInfo.WhatsThisXMLFile = "InplaceEditors.xml"
		End Sub
		Public Overrides ReadOnly Property ViewOptionsControl() As PivotGridControl
			Get
				Return pivotGridControl
			End Get
		End Property
		Public Overrides ReadOnly Property ExportControl() As PivotGridControl
			Get
				Return pivotGridControl
			End Get
		End Property
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			pivotGridControl.BeginUpdate()
			pivotGridControl.DataSource = GetNWindData("SalesPerson")
			pivotGridControl.HeaderImages = HeadersImageList
			pivotGridControl.ValueImages = CategoryImageList
			fieldSalesPerson.ImageIndex = 0
			fieldExtendedPrice.ImageIndex = 3
			fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			fieldExtendedPrice.CellFormat.FormatString = "c2"
			pivotGridControl.EndUpdate()
			pivotGridControl.OptionsCustomization.AllowFilterBySummary = False
		End Sub

		Private Sub progressBar_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles repositoryItemProgressBar1.KeyPress
			Dim value As Integer = Convert.ToInt32(pivotGridControl.ActiveEditor.EditValue)
			If e.KeyChar = "+"c Then
				pivotGridControl.ActiveEditor.EditValue = Math.Min(value + 1, 99)
			End If
			If e.KeyChar = "-"c Then
				pivotGridControl.ActiveEditor.EditValue = Math.Max(value - 1, 0)
			End If
			e.Handled = True
		End Sub

		'<pivotGridControl>
		Private Sub pivotGridControl_CustomEditValue(ByVal sender As Object, ByVal e As CustomEditValueEventArgs) Handles pivotGridControl.CustomEditValue
			If Comparer.ReferenceEquals(e.DataField, fieldPercents) Then
				e.Value = Convert.ToDouble(e.Value) * 100f
			End If
		End Sub

		Private Sub pivotGridControl_EditorValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs) Handles pivotGridControl.EditValueChanged
			If Comparer.ReferenceEquals(e.DataField, fieldExtendedPrice) Then
				ChangeCellValue(e, Convert.ToDecimal(e.Value), Convert.ToDecimal(e.Editor.EditValue))
			End If
			If Comparer.ReferenceEquals(e.DataField, fieldPercents) Then
				Dim c0 As Decimal = Convert.ToDecimal(e.GetCellValue(fieldExtendedPrice))
				Dim p0 As Decimal = Convert.ToDecimal(e.Value)
				Dim p1 As Decimal = Convert.ToDecimal(e.Editor.EditValue)
				Dim newValue As Decimal = If((p0 = 0D OrElse p1 = 0D), 0D, c0 * (100D / p0 - 1D) / (100D / p1 - 1D))

				ChangeCellValue(e, c0, newValue)
			End If
		End Sub
		Private Sub ChangeCellValue(ByVal e As EditValueChangedEventArgs, ByVal oldValue As Decimal, ByVal newValue As Decimal)
            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
            If ds.RowCount = 0 Then
                Return
            End If
			Dim difference As Decimal = newValue - oldValue
			Dim factor As Decimal = If((difference = newValue), (difference / ds.RowCount), (difference / oldValue))
			For i As Integer = 0 To ds.RowCount - 1
				Dim value As Decimal = Convert.ToDecimal(ds(i)(fieldExtendedPrice))
				ds(i)(fieldExtendedPrice) = If((value = 0D), factor, value * (1D + factor))
			Next i
		End Sub
		'</pivotGridControl>

		Private Function GetCellsState(ByVal pivot As PivotGridControl) As Object(,)
			Dim result(pivot.Cells.ColumnCount - 1, pivot.Cells.RowCount - 1) As Object
			For i As Integer = 0 To pivot.Cells.ColumnCount - 1
				For j As Integer = 0 To pivot.Cells.RowCount - 1
					result(i, j) = pivot.Cells.GetCellInfo(i, j).Value
				Next j
			Next i
			Return result
		End Function
		Private Function CalculatePointDifference(ByVal lastCells(,) As Object, ByVal currentState(,) As Object) As List(Of Point)
			If lastCells Is Nothing OrElse lastCells.Length = 0 OrElse lastCells.Length <> currentState.Length Then
				Return Nothing
			End If
			Dim pointDifference As New List(Of Point)()
				For i As Integer = lastCells.GetLowerBound(0) To lastCells.GetUpperBound(0)
					For j As Integer = lastCells.GetLowerBound(1) To lastCells.GetUpperBound(1)
						If (Not Object.Equals(lastCells(i, j), currentState(i, j))) Then
							pointDifference.Add(New Point(i, j))
						End If
					Next j
				Next i
			Return pointDifference
		End Function

		Private highlightColor As Color = Color.Red
		Private currentDifferences As New List(Of Point)()
		Private Sub pivotGridControl_CustomAppearance(ByVal sender As Object, ByVal e As PivotCustomAppearanceEventArgs) Handles pivotGridControl.CustomAppearance
			If PointDifference Is Nothing Then
				Return
			End If
			If PointDifference.Count <> 0 Then
				currentDifferences = New List(Of Point)(PointDifference)
			End If
			Dim highlight As Boolean = currentDifferences.Contains(New Point(e.ColumnIndex, e.RowIndex))
			If highlight Then
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
				e.Appearance.ForeColor = highlightColor
			Else
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Regular)
				e.Appearance.ForeColor = ContrastColor(e.Appearance.BackColor)
			End If
		End Sub
		Private Function ContrastColor(ByVal color As Color) As Color
			Dim colorBrightness As Double = (0.3 * color.R + 0.6 * color.G + 0.1 * color.B) / 255
			Dim resComponent As Integer = If(colorBrightness > 0.5, 0, 255)
			Return Color.FromArgb(resComponent, resComponent, resComponent)
		End Function
		Private Function GetFocusedCellInfo(ByVal pivot As PivotGridControl) As PivotCellEventArgs
			Dim focused As Point = pivot.Cells.FocusedCell
			Return pivot.Cells.GetCellInfo(focused.X, focused.Y)
		End Function
		Private Sub pivotGridControl_ShowingEditor(ByVal sender As Object, ByVal e As CancelPivotCellEditEventArgs) Handles pivotGridControl.ShowingEditor
			Dim cellInfo As PivotCellEventArgs = GetFocusedCellInfo(pivotGridControl)
			If cellInfo.RowValueType = PivotGridValueType.GrandTotal OrElse cellInfo.ColumnValueType = PivotGridValueType.GrandTotal Then
				e.Cancel = True
			End If
		End Sub

		Private Sub pivotGridControl_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs) Handles pivotGridControl.FieldValueImageIndex
			If e.Field Is fieldCategoryName AndAlso Comparer.Equals(e.ValueType, PivotGridValueType.Value) Then
				e.ImageIndex = GetCategoryIndexByName(e.Value)
			End If
		End Sub

		Private Sub pivotGridControl_GridLayout(ByVal sender As Object, ByVal e As EventArgs) Handles pivotGridControl.GridLayout
			Dim currentCells(,) As Object = GetCellsState(pivotGridControl)
			PointDifference = CalculatePointDifference(LastCells, currentCells)
			LastCells = currentCells
		End Sub
	End Class
End Namespace

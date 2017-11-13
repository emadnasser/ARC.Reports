Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules

	Partial Public Class CustomDrawEvents
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Private highlightColor As Color
		Private dataSource As New DataTable()
		Private random As New Random()
		Private lastCells_Renamed(,) As Object
		Private pointDifference_Renamed As List(Of Point)
		Private Const colorStep As Integer = 25

		Private ReadOnly Property PointDifference() As List(Of Point)
			Get
				If pointDifference_Renamed Is Nothing Then
					Dim currentState(,) As Object = CellsState
					pointDifference_Renamed = New List(Of Point)()
					For i As Integer = lastCells_Renamed.GetLowerBound(0) To lastCells_Renamed.GetUpperBound(0)
						For j As Integer = lastCells_Renamed.GetLowerBound(1) To lastCells_Renamed.GetUpperBound(1)
							If (Not Object.Equals(lastCells_Renamed(i, j), currentState(i, j))) Then
								pointDifference_Renamed.Add(New Point(i, j))
							End If
						Next j
					Next i
				End If
				Return pointDifference_Renamed
			End Get
		End Property
		Private Property LastCells() As Object(,)
			Get
				Return lastCells_Renamed
			End Get
			Set(ByVal value As Object(,))
				lastCells_Renamed = value
				pointDifference_Renamed = Nothing
			End Set
		End Property

		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\CustomDrawEvents.vb"
            TutorialInfo.WhatsThisXMLFile = "CustomDrawEvents.xml"

			pivotGridControl1.OptionsCustomization.AllowFilterBySummary = False
		End Sub
		Public Overrides ReadOnly Property ViewOptionsControl() As PivotGridControl
			Get
				Return pivotGridControl1
			End Get
		End Property
		Public Overrides ReadOnly Property ExportControl() As PivotGridControl
			Get
				Return pivotGridControl1
			End Get
		End Property

		Private ReadOnly Property CellsState() As Object(,)
			Get
				Dim result(pivotGridControl1.Cells.ColumnCount - 1, pivotGridControl1.Cells.RowCount - 1) As Object
				For i As Integer = 0 To pivotGridControl1.Cells.ColumnCount - 1
					For j As Integer = 0 To pivotGridControl1.Cells.RowCount - 1
						result(i, j) = pivotGridControl1.Cells.GetCellInfo(i, j).Value
					Next j
				Next i
				Return result
			End Get
		End Property
		Private Sub AddDataSourceRow()
			dataSource.Rows.Add("Category " & ((dataSource.Rows.Count + 1) Mod 2).ToString(), "Product " & ((dataSource.Rows.Count + 1) Mod 10).ToString(), DateTime.FromOADate(random.Next(365) + New DateTime(2007, 1, 1).ToOADate()), random.Next(1000))
		End Sub
		Private Sub HighlightChanges()
			highlightColor = Color.Red
			timer2.Enabled = True
		End Sub
		Private Function DecreaseColor(ByVal color As Color) As Color
			Return System.Drawing.Color.FromArgb(Math.Max(0, CInt(Fix(color.R)) - colorStep), 0, 0)
		End Function

		Private Sub CustomDrawEvents_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dataSource.Columns.Add("Category", GetType(String))
			dataSource.Columns.Add("Product", GetType(String))
			dataSource.Columns.Add("OrderDate", GetType(DateTime))
			dataSource.Columns.Add("Amount", GetType(Integer))
			For i As Integer = 0 To 199
				AddDataSourceRow()
			Next i

			pivotGridControl1.Fields.Add("Category", PivotArea.RowArea)
			pivotGridControl1.Fields.Add("Product", PivotArea.RowArea)
			pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea).GroupInterval = PivotGroupInterval.DateYear
			pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea).GroupInterval = PivotGroupInterval.DateQuarter
			pivotGridControl1.Fields.Add("Amount", PivotArea.DataArea)
			pivotGridControl1.DataSource = dataSource.DefaultView

			LastCells = CellsState
		End Sub
		'<pivotGridControl1>	
		Private Sub pivotGridControl1_CustomDrawFieldValue(ByVal sender As Object, ByVal e As PivotCustomDrawFieldValueEventArgs) Handles pivotGridControl1.CustomDrawFieldValue
			Dim index As Integer = If(e.Area = PivotArea.ColumnArea, pivotGridControl1.Cells.FocusedCell.X, pivotGridControl1.Cells.FocusedCell.Y)
			If e.MinIndex <= index AndAlso index <= e.MaxIndex Then
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
			Else
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Regular)
			End If
		End Sub
		Private Sub pivotGridControl1_CustomDrawCell(ByVal sender As Object, ByVal e As PivotCustomDrawCellEventArgs) Handles pivotGridControl1.CustomDrawCell
			Dim highlight As Boolean = highlightColor.R > 0 AndAlso PointDifference.Contains(New Point(e.ColumnIndex, e.RowIndex))
			If (e.ColumnIndex = pivotGridControl1.Cells.FocusedCell.X AndAlso e.RowIndex = pivotGridControl1.Cells.FocusedCell.Y) OrElse highlight Then
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
			Else
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Regular)
			End If
			e.Appearance.ForeColor = If(highlight, highlightColor, Color.Black)
			If e.ColumnIndex = pivotGridControl1.Cells.FocusedCell.X OrElse e.RowIndex = pivotGridControl1.Cells.FocusedCell.Y Then
				e.Appearance.BackColor = Color.FromArgb(e.Appearance.BackColor.R - 10, e.Appearance.BackColor.G - 10, e.Appearance.BackColor.B - 10)
			End If
		End Sub
		'</pivotGridControl1>

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			If pivotGridControl1.IsDragging Then
				Return
			End If
			LastCells = CellsState
			AddDataSourceRow()
			pivotGridControl1.RefreshData()
			HighlightChanges()
		End Sub
		Private Sub timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer2.Tick
			If pivotGridControl1.IsDragging Then
				Return
			End If
			highlightColor = DecreaseColor(highlightColor)
			pivotGridControl1.Invalidate()
			If highlightColor.R = 0 Then
				timer2.Enabled = False
				LastCells = CellsState
			End If
		End Sub

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			timer1.Enabled = True
		End Sub
		Protected Overrides Sub DoHide()
			timer1.Enabled = False
			MyBase.DoHide()
		End Sub

		Private Sub pivotGridControl1_FieldAreaChanged(ByVal sender As Object, ByVal e As PivotFieldEventArgs) Handles pivotGridControl1.FieldAreaChanged
			LastCells = CellsState
		End Sub
	End Class
End Namespace

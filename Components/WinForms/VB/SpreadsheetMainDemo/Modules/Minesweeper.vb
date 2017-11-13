Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.Office
Imports DevExpress.Spreadsheet
Imports FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle
Imports SpreadsheetHorizontalAlignment = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class MinesweeperModule
		Inherits SpreadSheetTutorialControlBase
		Private Enum CellState
			Closed
			Open
			HasMine
		End Enum

		Private ReadOnly closedCellColor As Color = Color.FromArgb(222, 222, 222)
		Private ReadOnly hasMineColor As Color = Color.FromArgb(159, 203, 87)
		Private ReadOnly openCellColor As Color = Color.FromArgb(242, 242, 242)
		Private ReadOnly wrongCellColor As Color = Color.FromArgb(236, 111, 105)

		Private map(,) As Integer
		Private vmap(,) As CellState
		Private mapWidth As Integer
		Private mapHeight As Integer
		Private mines As Integer
		Private book As IWorkbook
		Private sheet As Worksheet
		Private cells As CellCollection
		Private Const Dx As Integer = 3
		Private Const Dy As Integer = 6
		Private previousCell As String
		Private selectedCell As String
		Private closedCells As Integer
		Private isGameOver As Boolean
		Private ReadOnly offsetX() As Integer = {-1, 0, 1, 1, 1, 0, -1, -1}
		Private ReadOnly offsetY() As Integer = {-1, -1, -1, 0, 1, 1, 1, 0}
		Private leftMouseButton As Boolean
		Private rightMouseButton As Boolean
		Private mouseTicks As Long
		Private ReadOnly flag As Bitmap
		Private ReadOnly mine As Bitmap
		Private failedCell As Cell
		Private startTime As DateTime
		Private ReadOnly Property minesString() As String
			Get
				Return " Mines:  " & mines
			End Get
		End Property

		Private ReadOnly Property timerString() As String
			Get
				Return If(timer1.Enabled OrElse isGameOver, " Timer:  " & (DateTime.Now.Subtract(startTime)).ToString("hh\ \:\ mm\ \:\ ss"), " Timer:  00 : 00 : 00")
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			AddHandler Me.spreadsheetControl.PopupMenuShowing, AddressOf spreadsheetControl_PopupMenuShowing
			AddHandler Me.spreadsheetControl.CustomDrawCell, AddressOf SpreadsheetControlCustomDrawCell
			AddHandler Me.spreadsheetControl.MouseDown, AddressOf SpreadsheetControlMouseDown
			AddHandler Me.spreadsheetControl.MouseMove, AddressOf SpreadsheetControlMouseMove
			AddHandler Me.spreadsheetControl.MouseUp, AddressOf SpreadsheetControlMouseUp

			flag = DemoUtils.LoadImageByName("Flag.png")
			mine = DemoUtils.LoadImageByName("Mine.png")

			spreadsheetControl.ReadOnly = True
			spreadsheetControl.BeginUpdate()
			PrepareWorkbook()
			radioGroup1.SelectedIndex = 0
			NewGame()
			spreadsheetControl.EndUpdate()
			Me.spreadsheetControl.Options.Culture = DefaultCulture
			Me.spreadsheetControl.Document.History.Clear()
		End Sub

		Private Sub PrepareMap()
			map = New Integer(mapWidth - 1, mapHeight - 1){}
			vmap = New CellState(mapWidth - 1, mapHeight - 1){}
			Dim rnd As New Random()
			For i As Integer = 0 To mines - 1
				Dim x As Integer
				Dim y As Integer
				Do
					x = rnd.Next(mapWidth)
					y = rnd.Next(mapHeight)
				Loop While map(x, y) = 9
				map(x, y) = 9
				For j As Integer = 0 To 7
					If IsCellExist(x + offsetX(j), y + offsetY(j)) AndAlso map(x + offsetX(j), y + offsetY(j)) <> 9 Then
						map(x + offsetX(j), y + offsetY(j)) += 1
					End If
				Next j
			Next i
			closedCells = mapWidth * mapHeight
		End Sub

		Private Sub SetCellsSize()
			Dim cellSize As Integer = cellSizeTrack.Value

			For i As Integer = 0 To mapWidth - 1
				sheet.Columns(Dx + i).Width = cellSize
			Next i

			For i As Integer = 0 To mapHeight - 1
				sheet.Rows(Dy + i).Height = cellSize
			Next i

			sheet.Columns(Dx - 1).Width = 15
			sheet.Columns(Dx + mapWidth).Width = 15
			sheet.Rows(Dy - 1).Height = 15
			sheet.Rows(Dy + mapHeight).Height = 15


			Dim range As Range = sheet(cells(Dy, Dx).GetReferenceA1() & ":" & cells(Dy + mapHeight - 1, Dx + mapWidth - 1).GetReferenceA1())
			Dim style As Formatting = range.BeginUpdateFormatting()
			Try
				style.Font.Size = 0.6 * cellSizeTrack.Value
			Finally
				range.EndUpdateFormatting(style)
			End Try
			range = sheet(cells(Dy - 1, Dx - 1).GetReferenceA1() & ":" & cells(Dy + mapHeight, Dx + mapWidth).GetReferenceA1())
			style = range.BeginUpdateFormatting()
			Try
				style.Borders.SetOutsideBorders(Color.FromArgb(233, 233, 233), BorderLineStyle.Thin)
			Finally
				range.EndUpdateFormatting(style)
			End Try
		End Sub

		Private Sub PrepareWorkbook()
			book = spreadsheetControl.Document
			book.Unit = DocumentUnit.Point
			sheet = book.Worksheets(0)
			sheet.ActiveView.ShowGridlines = False
			cells = sheet.Cells
			sheet.Columns("A").Width = 20
			sheet.Columns("B").Width = 10.75
			sheet.Columns("C").Width = 62
			sheet.Columns("D").Width = 13
			sheet.Rows(0).Height = 21.5
			sheet.Rows(2).Height = 22.25
			sheet.Rows(3).Height = 14
			sheet.Rows(4).Height = 12.75
			Dim range As Range = sheet("B2:AG2")
			range.Merge()
			Dim style As Formatting = range.BeginUpdateFormatting()
			Try
				style.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
				style.Alignment.Indent = 1
				style.Font.Size = 24
				style.Font.FontStyle = FontStyle.Regular
				style.Font.Name = "Segoe UI"
				style.Font.Color = Color.FromArgb(64, 64, 64)
			Finally
				range.EndUpdateFormatting(style)
			End Try
			cells("B2").Value = "Minesweeper"

			sheet("B3:AG3").Merge()
			sheet("B4:AG4").Merge()

			range = sheet("B3:B4")
			style = range.BeginUpdateFormatting()
			Try
				style.Font.Name = "Segoe UI"
				style.Font.Size = 9.75
				style.Font.Color = Color.FromArgb(64, 64, 64)
				style.Font.FontStyle = FontStyle.Regular
				style.Alignment.Indent = 1
			Finally
				range.EndUpdateFormatting(style)
			End Try

			cells("B3").Value = minesString
			cells("B4").Value = timerString
		End Sub

		Private Sub ClearFieldOfPlay()
			Dim range As Range = sheet(cells(Dy - 1, Dx - 1).GetReferenceA1() & ":" & cells(Dy + mapHeight, Dx + mapWidth).GetReferenceA1())
			sheet.Clear(range)
		End Sub

		Private Sub GenerateWorkbook()
			cells("B3").Value = minesString
			cells("B4").Value = timerString

			SetCellsSize()

			Dim range As Range = sheet(cells(Dy, Dx).GetReferenceA1() & ":" & cells(Dy + mapHeight - 1, Dx + mapWidth - 1).GetReferenceA1())
			Dim style As Formatting = range.BeginUpdateFormatting()
			Try
				style.Borders.SetAllBorders(Color.White, BorderLineStyle.Medium)
				style.Fill.BackgroundColor = closedCellColor
				style.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
				style.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			Finally
				range.EndUpdateFormatting(style)
			End Try
		End Sub

		Private Sub NewGame()
			isGameOver = False
			timer1.Enabled = False
			cells("B4").Value = timerString
			spreadsheetControl.BeginUpdate()
			ClearFieldOfPlay()
			If radioGroup1.SelectedIndex = 0 Then
				mapWidth = 8
				mapHeight = 8
				mines = 9
				cellSizeTrack.Value = 35
			ElseIf radioGroup1.SelectedIndex = 1 Then
				mapWidth = 16
				mapHeight = 16
				mines = 40
				cellSizeTrack.Value = 18
			ElseIf radioGroup1.SelectedIndex = 2 Then
				mapWidth = 30
				mapHeight = 16
				mines = 99
				cellSizeTrack.Value = 18
			End If
			PrepareMap()
			GenerateWorkbook()
			failedCell = Nothing
			spreadsheetControl.EndUpdate()
		End Sub

		Private Sub Button1Click(ByVal sender As Object, ByVal e As EventArgs) Handles NewGameBtn.Click
			NewGame()
		End Sub

		Private Sub RadioGroup1SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
			NewGame()
		End Sub

		Private Sub Timer1Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			cells("B4").Value = timerString
		End Sub

		Private Sub CellSizeTrackValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cellSizeTrack.ValueChanged
			If book Is Nothing Then
				Return
			End If
			spreadsheetControl.BeginUpdate()
			SetCellsSize()
			spreadsheetControl.EndUpdate()
		End Sub

		Private Function IsCellExist(ByVal x As Integer, ByVal y As Integer) As Boolean
			Return Not(x < 0 OrElse y < 0 OrElse x >= mapWidth OrElse y >= mapHeight)
		End Function

		Private Sub SpreadsheetControlMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim cell As Cell = spreadsheetControl.GetCellFromPoint(New PointF(e.X, e.Y))
			If cell Is Nothing Then
				Return
			End If
			If (Not IsCellExist(cell.ColumnIndex - Dx, cell.RowIndex - Dy)) Then
				Return
			End If
			Dim cellReference As String = cell.GetReferenceA1()
			If previousCell = cellReference Then
				Return
			End If
			previousCell = selectedCell
			selectedCell = cellReference
			spreadsheetControl.Refresh()
		End Sub

		Private Sub OpenAllNeighborhood(ByVal cell As Cell)
			Dim x As Integer = cell.ColumnIndex - Dx
			Dim y As Integer = cell.RowIndex - Dy
			For i As Integer = 0 To 7
				If IsCellExist(x + offsetX(i), y + offsetY(i)) Then
					OpenCell(cells(cell.RowIndex + offsetY(i), cell.ColumnIndex + offsetX(i)))
				End If
			Next i
		End Sub

		Private Sub OpenDigit(ByVal cell As Cell)
			Dim x As Integer = cell.ColumnIndex - Dx
			Dim y As Integer = cell.RowIndex - Dy
			cell.Fill.BackgroundColor = openCellColor
			vmap(x, y) = CellState.Open
			If map(x, y) = 0 Then
				OpenAllNeighborhood(cell)
			Else
				cell.Font.Color = Color.FromArgb(52, 52, 52)
				cell.Value = map(x, y)
			End If
			closedCells -= 1
			If closedCells = mines Then
				Win()
			End If
		End Sub

		Private Sub OpenCell(ByVal cell As Cell)
			Dim x As Integer = cell.ColumnIndex - Dx
			Dim y As Integer = cell.RowIndex - Dy
			If vmap(x, y) <> CellState.Closed Then
				Return
			End If
			If map(x, y) = 9 Then
				Failed(cell)
			Else
				OpenDigit(cell)
			End If
		End Sub

		Private Sub Failed(ByVal cell As Cell)
			timer1.Enabled = False
			failedCell = cell
			isGameOver = True
			spreadsheetControl.Refresh()
		End Sub

		Private Sub Win()
			timer1.Enabled = False
			isGameOver = True
			For xi As Integer = 0 To mapWidth - 1
				For yi As Integer = 0 To mapHeight - 1
					If vmap(xi, yi) = CellState.Closed Then
						vmap(xi, yi) = CellState.HasMine
					End If
				Next yi
			Next xi
			mines = 0
			cells("B3").Value = minesString
		End Sub

		Private Sub LeftMouseButtonClick(ByVal cell As Cell)
			OpenCell(cell)
		End Sub

		Private Sub RightMouseButtonClick(ByVal cell As Cell)
			Dim x As Integer = cell.ColumnIndex - Dx
			Dim y As Integer = cell.RowIndex - Dy
			If vmap(x, y) = CellState.HasMine Then
				vmap(x, y) = CellState.Closed
				cell.Fill.BackgroundColor = closedCellColor
				mines += 1
				closedCells += 1
			ElseIf vmap(x, y) = CellState.Closed Then
				vmap(x, y) = CellState.HasMine
				mines -= 1
				closedCells -= 1
			End If
			cells("B3").Value = minesString
		End Sub

		Private Sub MiddleMouseButtonClick(ByVal cell As Cell)
			Dim x As Integer = cell.ColumnIndex - Dx
			Dim y As Integer = cell.RowIndex - Dy
			If vmap(x, y) = CellState.Open Then
				Dim need As Integer = 0
				For i As Integer = 0 To 7
					If IsCellExist(x + offsetX(i), y + offsetY(i)) AndAlso vmap(x + offsetX(i), y + offsetY(i)) = CellState.HasMine Then
						need += 1
					End If
				Next i
				If need = map(x, y) Then
					OpenAllNeighborhood(cell)
				End If
			End If
		End Sub

		Private Sub SpreadsheetControlMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim cell As Cell = spreadsheetControl.GetCellFromPoint(New PointF(e.X, e.Y))
			If cell Is Nothing Then
				Return
			End If
			Dim x As Integer = cell.ColumnIndex - Dx
			Dim y As Integer = cell.RowIndex - Dy
			If (Not IsCellExist(x, y)) Then
				Return
			End If
			If isGameOver Then
				Return
			End If

			If (Not timer1.Enabled) Then
				startTime = DateTime.Now
				timer1.Enabled = True
			End If
			spreadsheetControl.BeginUpdate()

			If e.Button = MouseButtons.Left Then
				leftMouseButton = True
				If rightMouseButton Then
					Dim ts As New TimeSpan(DateTime.Now.Ticks - mouseTicks)
					If ts.Milliseconds < 600 Then
						MiddleMouseButtonClick(cell)
					End If
				Else
					mouseTicks = DateTime.Now.Ticks
					LeftMouseButtonClick(cell)
				End If
			ElseIf e.Button = MouseButtons.Right Then
				rightMouseButton = True
				If leftMouseButton Then
					Dim ts As New TimeSpan(DateTime.Now.Ticks - mouseTicks)
					If ts.Milliseconds < 600 Then
						MiddleMouseButtonClick(cell)
					End If
				Else
					mouseTicks = DateTime.Now.Ticks
					RightMouseButtonClick(cell)
				End If
			ElseIf e.Button = MouseButtons.Middle Then
				MiddleMouseButtonClick(cell)
			End If
			spreadsheetControl.EndUpdate()
			spreadsheetControl.Refresh()
		End Sub

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			spreadsheetControl.Focus()
		End Sub

		Private Sub spreadsheetControl_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
			e.Menu = Nothing
		End Sub

		Private Sub SpreadsheetControlMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				leftMouseButton = False
			ElseIf e.Button = MouseButtons.Right Then
				rightMouseButton = False
			End If
		End Sub

		Private Sub SpreadsheetControlCustomDrawCell(ByVal sender As Object, ByVal e As CustomDrawCellEventArgs)
			e.DrawDefault()
			Dim x As Integer = e.Cell.ColumnIndex - Dx
			Dim y As Integer = e.Cell.RowIndex - Dy
			Dim fillColor As Color = Color.Empty
			Dim image As Image = Nothing
			If IsCellExist(x, y) Then
				If failedCell IsNot Nothing Then
					If map(x, y) = 9 Then
						If e.Cell Is failedCell Then
							fillColor = wrongCellColor
						End If
						image = mine
					End If
				End If
				If vmap(x, y) = CellState.HasMine Then
					fillColor = If(isGameOver AndAlso map(x, y) <> 9, wrongCellColor, hasMineColor)
					image = flag
				End If
			End If
			If e.Cell.GetReferenceA1() = selectedCell Then
				fillColor = If(vmap(x, y) = CellState.HasMine, Color.FromArgb(103, 169, 24), Color.FromArgb(200, 200, 200))
			End If
			If (Not DXColor.IsEmpty(fillColor)) Then
				e.Cache.FillRectangle(fillColor, e.FillBounds)
				e.Cache.DrawRectangle(New Pen(Color.White, 1), e.FillBounds)
			End If
			If image IsNot Nothing Then
				Dim l As Integer = Convert.ToInt32(e.FillBounds.Left + (e.FillBounds.Width + 1 - mine.Width) / 2)
				Dim t As Integer = Convert.ToInt32(e.Bounds.Top + (e.FillBounds.Height + 1 - mine.Height) / 2)
				e.Graphics.DrawImageUnscaled(image, l, t)
			End If
		End Sub
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Reflection
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.XtraGrid.Views.BandedGrid

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class GridTetris
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			gridControl.ForceInitialize()
			gridControl2.ForceInitialize()
			bandedGridView2.Appearance.Row.BackColor = Color.Transparent
			bandedGridView2.Appearance.Empty.BackColor = Color.Transparent
			gridControl2.BackColor = Color.Transparent
			InitRowHeight()
		End Sub
		Private game As TetrisGame
		Private iColunms As Integer = 10
		Private iPrevColumns As Integer = 3
		Private rowHeight As Integer = 0
		Private gameEnd As Boolean = False
		Private dx As Integer = 10

		Protected Overrides ReadOnly Property AllowAppearanceGroup() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			gridControl.Focus()
			If (Not timer1.Enabled) Then
				SetPause()
			End If
		End Sub
		Protected Overrides Sub DoHide()
			If timer1.Enabled Then
				SetPause()
			End If
		End Sub

		Private Function GetImageFromRes(ByVal level As Integer) As Image
            level += 1
            Dim name As String = String.Format("{0}.jpg", level)
			Dim str As System.IO.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(name)
			Return Image.FromStream(str)
		End Function

		Private Sub GridTetris_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitSize()
			game = New TetrisGame()
			AddHandler gridControl2.GotFocus, AddressOf OnGotFocus
			AddHandler game.ChangeScore, AddressOf changeScore
			AddHandler game.ChangeLevel, AddressOf changeLevel
			AddHandler game.CreateFigure, AddressOf createFigure
			ColumnHelper.AddColumns(gridBand1, iColunms)
			ColumnHelper.AddColumns(gridBand2, iPrevColumns)
			gridControl2.DataSource = game.PrevCollection
			InitNew()
		End Sub

		Private Sub InitSize()
			ResizeGrid()
			RecalculatePositions()
		End Sub

        Private Overloads Sub OnGotFocus(ByVal sender As Object, ByVal e As EventArgs)
			gridControl.Focus()
		End Sub


		Private Sub InitRowHeight()
			Dim vi As BandedGridViewInfo = GetBandedGridViewInfo(bandedGridView)
			rowHeight = 19
			bandedGridView2.RowHeight = rowHeight
			bandedGridView.RowHeight = bandedGridView2.RowHeight
		End Sub

		Private Sub ResizeGrid()
			Dim w As Integer = 24
			gridControl.Width = (iColunms + 1) * w + 2
			gridControl2.Width = (iPrevColumns + 1) * w + 2
			Dim vi As BandedGridViewInfo = GetBandedGridViewInfo(bandedGridView)
			If vi.MinRowHeight > rowHeight Then
				rowHeight = vi.MinRowHeight
			End If
			gridControl.Height = rowHeight * MyCollection.rows + vi.BandRowHeight + 2
			gridControl2.Height = rowHeight * 4
			panel1.Left = gridControl.Left + gridControl.Width + 10
			panel1.Width = simpleButton1.Width
		End Sub

		Private Sub InitNew()
			gameEnd = False
			gridControl.DataSource = Nothing
			game.Init()
			gridControl.DataSource = game.Collection
			CreateNewFigure()
			timer2.Stop()
			timer1.Start()
			SetCaption()
		End Sub

		Private Sub changeScore(ByVal sender As Object, ByVal e As EventArgs)
            label1.Text = String.Format("{1}: {0}", game.Score, My.Resources.Score)
        End Sub

        Private Sub changeLevel(ByVal sender As Object, ByVal e As EventArgs)
            label2.Text = String.Format("{1}: {0}", game.Level, My.Resources.Level)
            timer1.Interval = 400 - game.Level * 40
            gridControl.BackgroundImage = GetImageFromRes(game.Level)
        End Sub

        Private Sub createFigure(ByVal sender As Object, ByVal e As EventArgs)
            bandedGridView2.LayoutChanged()
        End Sub

        Private Sub bandedGridView_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles bandedGridView.CustomDrawCell, bandedGridView2.CustomDrawCell
            If e.CellValue Is Nothing Then
                Return
            End If
            Dim IsUnit As Boolean = CBool(e.CellValue)
            Dim b As New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.White, game.LevelColor, 45)
            Dim r As Rectangle = e.Bounds
            If IsUnit Then
                e.Graphics.FillRectangle(b, r)
                r.Inflate(1, 1)
                r.Width -= 1
                r.Height -= 1
                e.Graphics.DrawRectangle(game.LevelPen, r)
            End If
            e.Handled = True
        End Sub

        Private Sub CreateNewFigure()
            game.CreateNewFigure()
            ExitOf()
        End Sub

        Private Sub ExitOf()
            If game.Figure.EndOf Then
                timer1.Stop()
                timer2.Start()
            End If
        End Sub

#Region "Timers"
        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
            If game.Figure.LastRow() Then
                game.Figure.DeleteTotalRows()
                CreateNewFigure()
                GC.Collect()
                Return
            End If
            game.Figure.GoBottom()
        End Sub


        Private Sub timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer2.Tick
            gameEnd = True
            If game.TRow < game.Collection.Count Then
                game.FillRow()
            Else
                timer2.Stop()
                gridBand1.Caption = My.Resources.GameOver
            End If
        End Sub
#End Region

        Private Sub SetCaption()
            gridBand1.Caption = If(timer1.Enabled, My.Resources.Playing, My.Resources.Pause)
        End Sub

		Private Sub SetPause()
			If timer2.Enabled Then
				Return
			End If
			If gameEnd Then
				InitNew()
			Else
				timer1.Enabled = Not timer1.Enabled
				SetCaption()
			End If
		End Sub

		Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridControl.KeyDown, MyBase.KeyDown
			If e.KeyCode = Keys.P OrElse e.KeyCode = Keys.Pause Then
				SetPause()
			End If
			If (Not timer1.Enabled) Then
				Return
			End If
			Application.DoEvents()
			If e.KeyCode = Keys.Left Then
				game.Figure.GoLeft()
			End If
			If e.KeyCode = Keys.Right Then
				game.Figure.GoRight()
			End If
			If e.KeyCode = Keys.Down Then
				game.Figure.GoBottom()
			End If
			If e.KeyCode = Keys.Space Then
				If gameEnd Then
					Return
				End If
				timer1.Stop()
				game.Figure.GoBottom(False)
				game.Figure.DeleteTotalRows()
				timer1.Start()
				CreateNewFigure()
				GC.Collect()
			End If
			If e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.X Then
				game.Figure.Rotate()
			End If
			If e.KeyCode = Keys.Z Then
				game.Figure.Rotate(False)
			End If
			If e.KeyCode = Keys.Insert Then
				game.Level += (If(e.Shift, -1, 1))
			End If
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			InitNew()
			gridControl.Focus()
		End Sub

		Public Shared Function GetBandedGridViewInfo(ByVal gridView As BandedGridView) As BandedGridViewInfo
			Dim propertyInfo As PropertyInfo = gridView.GetType().GetProperty("ViewInfo", BindingFlags.Instance Or BindingFlags.GetProperty Or BindingFlags.NonPublic, Nothing, GetType(BandedGridViewInfo), New Type(){}, Nothing)
			If propertyInfo IsNot Nothing Then
				Return TryCast(propertyInfo.GetValue(gridView, Nothing), BandedGridViewInfo)
			Else
				Return Nothing
			End If
		End Function


		Private Sub RecalculatePositions()
            gridControl.Top = (gridControl.Parent.Height - gridControl.Height) \ 2
            gridControl.Left = (gridControl.Parent.Width - gridControl.Width - panel1.Width - dx) \ 2
			panel1.Top = gridControl.Top
			panel1.Left = gridControl.Left + gridControl.Width + dx
			panel1.Height = gridControl.Height
		End Sub
		Private Sub GridTetris_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
			RecalculatePositions()
		End Sub

		Private Sub panelClient_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
			ControlPaint.DrawBorder3D(e.Graphics, gridControl.Left - dx, gridControl.Top - dx, gridControl.Width + panel1.Width + dx * 3, gridControl.Height + dx * 2, Border3DStyle.Bump)
		End Sub
	End Class
End Namespace


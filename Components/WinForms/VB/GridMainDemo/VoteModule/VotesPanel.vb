Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing

Namespace DevExpress.VoteApp
	Partial Public Class VotesPanel
		Inherits UserControl

		Public Sub New()
			InitializeComponent()
			SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
		End Sub

		Public Property VotesTextSize() As Single
			Get
				Return lbVotesLeft.Font.Size

			End Get
			Set(ByVal value As Single)
				If VotesTextSize = value Then
					Return
				End If
				Dim fo As New Font(lbVotesLeft.Font.FontFamily, value, lbVotesLeft.Font.Style)
				lbVotesLeft.Font = fo
				lbVotesRight.Font = fo
			End Set
		End Property
		<Browsable(True)>
		Public Property VotesTextLeft() As String
			Get
				Return lbVotesLeft.Text
			End Get
			Set(ByVal value As String)
				lbVotesLeft.Text = If(value, "")
			End Set
		End Property
		Public Property VotesTextRight() As String
			Get
				Return lbVotesRight.Text
			End Get
			Set(ByVal value As String)
				lbVotesRight.Text = If(value, "")
			End Set
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Property VotesCountLeft() As Integer
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Property VotesCountRight() As Integer
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Property VotesCountTotal() As Integer

		Public Property ColorLeft() As Color
		Public Property ColorRight() As Color

		Private Sub VotesPanel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
			Dim perLeft = Helpers.GetPercent(VotesCountLeft, VotesCountTotal)
			Dim perRight = Helpers.GetPercent(VotesCountRight, VotesCountTotal)

			If perLeft = 0 AndAlso perRight = 0 Then
				Return
			End If

            Dim bounds_Renamed As Rectangle = DirectCast(sender, Control).ClientRectangle
            Dim cache As New GraphicsCache(e)

			If perLeft > 0 Then
				Dim dem As Rectangle = bounds_Renamed
				dem.Width = CInt(Math.Truncate(Math.Round(dem.Width * perLeft)))
				cache.FillRectangle(cache.GetSolidBrush(ColorLeft), dem)
			End If
			If perRight > 0 Then
				Dim rep As Rectangle = bounds_Renamed
				rep.Width = CInt(Math.Truncate(Math.Round(rep.Width * perRight)))
				rep.X = bounds_Renamed.Right - rep.Width
				cache.FillRectangle(cache.GetSolidBrush(ColorRight), rep)
			End If
			Dim divider As Rectangle = bounds_Renamed
			divider.X += CInt(Math.Truncate(bounds_Renamed.Width * 0.5D)) - 1
			divider.Width = 3
			cache.FillRectangle(cache.GetSolidBrush(Color.FromArgb(200, Color.White)), divider)

		End Sub
	End Class
End Namespace

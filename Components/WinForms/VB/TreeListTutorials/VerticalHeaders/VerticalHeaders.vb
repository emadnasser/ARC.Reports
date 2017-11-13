Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for VerticalHeaders.
	''' </summary>
	Public Partial Class VerticalHeaders
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			radioButton2.Checked = True
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
		Private vertical As Boolean = False
		Private diagonal As Boolean = False

		Private Sub InitData()
			Dim xv As DevExpress.XtraTreeList.Design.XViews = New DevExpress.XtraTreeList.Design.XViews(treeList1)
		End Sub

		'<treeList1>
		Private Sub treeList1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawColumnHeaderEventArgs) Handles treeList1.CustomDrawColumnHeader
			Dim r As Rectangle = e.CaptionRect
			e.Caption = ""
			e.Painter.DrawObject(e.ObjectArgs)
			If Not e.Column Is Nothing Then
				Dim state As System.Drawing.Drawing2D.GraphicsState = e.Graphics.Save()
				Dim sf As StringFormat = New StringFormat()
				sf.Trimming = StringTrimming.EllipsisCharacter
				sf.FormatFlags = sf.FormatFlags Or StringFormatFlags.NoWrap
				If vertical Then
					sf.FormatFlags = sf.FormatFlags Or StringFormatFlags.DirectionVertical
				End If
				If diagonal Then
				r = Transform(e.Graphics, 30, r)
				End If
                e.Graphics.DrawString(e.Column.GetCaption(), e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), r, sf)
				e.Graphics.Restore(state)
			End If
			e.Handled = True
		End Sub
		'</treeList1>

		Private Function Transform(ByVal g As Graphics, ByVal degree As Integer, ByVal r As Rectangle) As Rectangle
			g.RotateTransform(degree)
			Dim cos As Single = CSng(Math.Round(Math.Cos(degree * (Math.PI / 180)), 2))
			Dim sin As Single = CSng(Math.Round(Math.Sin(degree * (Math.PI / 180)), 2))
			Dim r1 As Rectangle = r
			r1.X = CInt(Fix(r.X * cos + r.Y * sin))
			r1.Y = CInt(Fix(r.X * (-sin) + r.Y * cos))
			Return r1
		End Function


		Private Sub SetParameters(ByVal sender As Object, ByVal vertical As Boolean, ByVal diagonal As Boolean, ByVal h As Integer)
			Dim rb As RadioButton = TryCast(sender, RadioButton)
			If rb.Checked Then
				Me.vertical = vertical
				Me.diagonal = diagonal
				treeList1.ColumnPanelRowHeight = h
			End If
		End Sub

		Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged
			SetParameters(sender, False, False, -1)
		End Sub

		Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton2.CheckedChanged
			SetParameters(sender, True, False, 70)
		End Sub

		Private Sub radioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton3.CheckedChanged
			SetParameters(sender, False, True, 50)
		End Sub
	End Class
End Namespace

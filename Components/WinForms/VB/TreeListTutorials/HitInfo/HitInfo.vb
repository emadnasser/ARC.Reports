Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for HitInfo.
	''' </summary>
	Public Partial Class HitInfo
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
		Private Sub InitData()
			Dim xv As DevExpress.XtraTreeList.Design.XViews = New DevExpress.XtraTreeList.Design.XViews(treeList1)
		End Sub

		'<treeList1>
		Private Sub ShowHitInfo(ByVal hi As DevExpress.XtraTreeList.TreeListHitInfo)
			lbHitTest.Text = hi.HitInfoType.ToString()
			If hi.Column Is Nothing Then
				lbColumn.Text = "No column"
			Else
                lbColumn.Text = hi.Column.GetCaption()
			End If
			If hi.Node Is Nothing Then
				lbNode.Text = "-1"
			Else
				lbNode.Text = hi.Node.Id.ToString()
			End If
			If hi.Column Is Nothing OrElse hi.Node Is Nothing Then
				lbCellValue.Text = " "
			Else
				lbCellValue.Text = hi.Node.GetDisplayText(hi.Column.AbsoluteIndex)
			End If
		End Sub

		Private Sub treeList1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treeList1.MouseMove
			ShowHitInfo(treeList1.CalcHitInfo(New Point(e.X, e.Y)))
		End Sub
		'</treeList1>
	End Class
End Namespace

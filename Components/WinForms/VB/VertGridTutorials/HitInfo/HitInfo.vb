Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
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
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
		Private Sub HitInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
		End Sub

		'<vGridControl1>
		Private Sub vGridControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles vGridControl1.MouseMove
			ShowHitInfo(vGridControl1.CalcHitInfo(New Point(e.X, e.Y)))
		End Sub

		Private Sub ShowHitInfo(ByVal hi As DevExpress.XtraVerticalGrid.VGridHitInfo)
			lbHitTest.Text = hi.HitInfoType.ToString()
			If hi.Row Is Nothing Then
				lbRow.Text = "No row"
			Else
				If TypeOf hi.Row Is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow Then
					If hi.CellIndex <> -1 Then
						lbRow.Text = hi.Row.GetRowProperties(hi.CellIndex).Caption
					End If
				Else
					lbRow.Text = hi.Row.Properties.Caption
				End If
			End If
			If hi.HitInfoType = DevExpress.XtraVerticalGrid.HitInfoTypeEnum.ValueCell Then
				If TypeOf hi.Row Is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow Then
					lbCellValue.Text = vGridControl1.GetCellValue(TryCast(hi.Row, DevExpress.XtraVerticalGrid.Rows.MultiEditorRow), hi.RecordIndex, hi.CellIndex).ToString()
				Else
					lbCellValue.Text = vGridControl1.GetCellValue(hi.Row, hi.RecordIndex).ToString()
				End If
			Else
				lbCellValue.Text = " "
			End If
		End Sub
		'</vGridControl1>
	End Class
End Namespace

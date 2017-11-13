Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	''' <summary>
	''' Summary description for CellInfo.
	''' </summary>
	Partial Public Class CellInfo
		Inherits DevExpress.XtraEditors.XtraUserControl
		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()
			' TODO: Add any initialization after the InitForm call
		End Sub

		Public Sub Init(ByVal info As PivotGridHitInfo)
			If info Is Nothing OrElse info.CellInfo Is Nothing Then
				Me.Visible = False
				Return
			End If
			Me.Visible = True
			textEdit1.Text = info.CellInfo.DisplayText
			textEdit2.Text = String.Format("{0}", info.CellInfo.Value)
			textEdit3.Text = String.Format("{0}, {1}", info.CellInfo.ColumnIndex, info.CellInfo.RowIndex)
			textEdit4.Text = If(info.CellInfo.DataField IsNot Nothing, info.CellInfo.DataField.ToString(), "")
		End Sub
	End Class
End Namespace

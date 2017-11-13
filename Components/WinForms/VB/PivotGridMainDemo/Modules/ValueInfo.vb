Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	''' <summary>
	''' Summary description for ValueInfo.
	''' </summary>
	Partial Public Class ValueInfo
		Inherits DevExpress.XtraEditors.XtraUserControl
		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()
			' TODO: Add any initialization after the InitForm call
		End Sub

		Public Sub Init(ByVal info As PivotGridHitInfo)
			If info Is Nothing OrElse info.ValueInfo Is Nothing Then
				Me.Visible = False
				Return
			End If
			Me.Visible = True
			textEdit1.Text = String.Format("{0}", info.ValueInfo.Value)
			textEdit2.Text = String.Format("{0}", info.ValueInfo.Field)
			textEdit3.Text = String.Format("{0}", info.ValueInfo.ValueType)
		End Sub
	End Class
End Namespace

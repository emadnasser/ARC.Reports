Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	''' <summary>
	''' Summary description for HeadersAreaInfo.
	''' </summary>
	Partial Public Class HeadersAreaInfo
		Inherits DevExpress.XtraEditors.XtraUserControl
		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()
			' TODO: Add any initialization after the InitForm call
		End Sub

		Public Sub Init(ByVal info As PivotGridHitInfo)
			If info Is Nothing OrElse info.HeadersAreaInfo Is Nothing Then
				Me.Visible = False
				Return
			End If
			Me.Visible = True
			textEdit1.Text = String.Format("{0}", info.HeadersAreaInfo.Area)
			textEdit2.Text = String.Format("{0}", info.HeadersAreaInfo.Field)
		End Sub
	End Class
End Namespace

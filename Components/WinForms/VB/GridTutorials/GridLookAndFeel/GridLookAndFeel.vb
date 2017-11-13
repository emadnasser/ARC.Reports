Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridLookAndFeel.
	''' </summary>
	Public Partial Class GridLookAndFeel
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

		Private Sub GridLookAndFeel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitHelper.InitAdvBandedView(gridControl1)
			InitLookAndFeelRadioGroup()
		End Sub

		Private Sub InitLookAndFeelRadioGroup()
			Dim useXP As Boolean = DevExpress.Utils.WXPaint.Painter.ThemesEnabled
			If (Not useXP) Then
				For i As Integer = 0 To 1
					radioGroup1.Properties.Items.RemoveAt(radioGroup1.Properties.Items.Count - 1)
				Next i
			End If
			radioGroup1.SelectedIndex = 3
		End Sub

	  '<radioGroup1>
		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroup1.SelectedIndexChanged
            Dim radioGroup As DevExpress.XtraEditors.RadioGroup = TryCast(sender, DevExpress.XtraEditors.RadioGroup)
            Dim lookAndFeel As String = radioGroup.EditValue.ToString()
			gridControl1.SwitchPaintStyle(lookAndFeel)
		End Sub
	  '</radioGroup1>

		Public Overrides ReadOnly Property ShowLookAndFeel() As Boolean
			Get
				Return False
			End Get
		End Property
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for RowCustomization.
	''' </summary>
	Public Partial Class RowCustomization
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

		Private Sub RowCustomization_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
			InitCustomize()
			Dim timer As Timer = New Timer()
			AddHandler timer.Tick, AddressOf OnTick
			timer.Interval = 200
			timer.Start()
		End Sub

		Private Sub OnTick(ByVal sender As Object, ByVal e As EventArgs)
			Dim timer As Timer = TryCast(sender, Timer)
			timer.Stop()
			DoCustomize(True)
		End Sub

		Private Sub InitCustomize()
			For i As Integer = 0 To 1
				vGridControl1.Rows(i).ChildRows(4).Visible = False
			Next i
		End Sub

		Private Sub vGridControl1_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles vGridControl1.HideCustomizationForm
			DoCustomize(False)
		End Sub


		'<sbCustomize>
		Private showCustomization As Boolean = False
		Private Sub sbCustomize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCustomize.Click
			DoCustomize((Not showCustomization))
		End Sub

		Private Sub DoCustomize(ByVal show As Boolean)
			showCustomization = show
			If showCustomization Then
				vGridControl1.RowsCustomization(sbCustomize.PointToScreen(New Point(0, sbCustomize.Bottom - sbCustomize.Top)))
				sbCustomize.Text = "Hide" & Constants.vbCrLf & "Customization" & Constants.vbCrLf & "Form"
			Else
				vGridControl1.DestroyCustomization()
				sbCustomize.Text = "Customize..."
			End If
		End Sub
		'</sbCustomize>
	End Class
End Namespace

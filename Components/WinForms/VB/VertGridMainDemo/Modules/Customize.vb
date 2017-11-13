Imports System.Collections
Imports System.ComponentModel



Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class Customize
		Inherits DevExpress.XtraVerticalGrid.Demos.PropertiesBase

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\VertGridMainDemo\Modules\Customize.vb"
            TutorialInfo.WhatsThisXMLFile = "Customize.xml"
			HideRows()
			timer = New Timer()
			timer.Interval = 200
			AddHandler timer.Tick, AddressOf Timer_Tick
			' TODO: Add any initialization after the InitializeComponent call
		End Sub

		Private timer As Timer = Nothing
		Private fShowCustomization As Boolean = False

		Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			timer.Stop()
			ShowCustomization = True
		End Sub
		'<chCustomize>
		Private Sub ShowCustomizationForm()
			CurrentGrid.RowsCustomization(chCustomize.PointToScreen(New Point(-chCustomize.Left, chCustomize.Bottom - chCustomize.Top)))
		End Sub

		Private Sub chCustomize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chCustomize.Click
			ShowCustomization = Not fShowCustomization
		End Sub

		Protected Overrides Property ShowCustomization() As Boolean
			Get
				Return fShowCustomization
			End Get
			Set(ByVal value As Boolean)
				fShowCustomization = value
				If fShowCustomization Then
					ShowCustomizationForm()
					chCustomize.Text = "Hide" & vbCrLf & "Customization" & vbCrLf & "Form"
				Else
					CurrentGrid.DestroyCustomization()
					chCustomize.Text = "Show" & vbCrLf & "Customization" & vbCrLf & "Form"
				End If
			End Set
		End Property
		'</chCustomize>
		Protected Overrides Sub AdjustmentGrid()
			MyBase.AdjustmentGrid()
			timer.Start()
		End Sub
	End Class
End Namespace


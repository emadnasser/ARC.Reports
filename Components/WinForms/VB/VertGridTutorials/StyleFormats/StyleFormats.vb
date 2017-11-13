Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for StyleFormats.
	''' </summary>
	Public Partial Class StyleFormats
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

		Private Sub StyleFormats_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
			InitStyles()
		End Sub

		'<lsStyles>
		Private xs As DevExpress.XtraVerticalGrid.Design.XAppearances = New DevExpress.XtraVerticalGrid.Design.XAppearances(System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) & "\DevExpress.XtraVerticalGrid.Appearances.xml")
		'</lsStyles>

		Private Sub InitStyles()
			lsStyles.Items.AddRange(xs.FormatNames)
			lsStyles.SelectedItem = "Blue Office"
		End Sub

		'<lsStyles>
		Private Sub lsStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsStyles.SelectedIndexChanged
			If Not lsStyles.SelectedItem Is Nothing Then
				xs.LoadScheme(lsStyles.SelectedItem.ToString(), vGridControl1)
			End If
		End Sub
		'</lsStyles>
	End Class
End Namespace

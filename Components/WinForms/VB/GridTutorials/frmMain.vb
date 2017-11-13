Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Tutorials

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for frmMain.
	''' </summary>
	Public Partial Class frmMain
		Inherits DevExpress.Tutorials.FrmMain
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            Me.MinimumSize = New Size(800, 600)
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
        Protected Overrides Function CreateMenu(ByVal manager As DevExpress.XtraBars.BarManager, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel) As DXperience.Demos.LookAndFeelMenu
            Return New GridTutorialMenu(manager, lookAndFeel, "Tutorial examples for the " & AssemblyInfo.SRAssemblyGrid)
        End Function

		Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			RegisterTutorials.Register()
			TutorialsInfo.FillListBox(Me.listBoxControl1, New String() {RegisterTutorials.NewFeaturesString})
			listBoxControl1.SortOrder = SortOrder.Ascending
			listBoxControl1.SelectedIndex = -1
			ShowModule(RegisterTutorials.NewFeaturesString)
		End Sub

		Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listBoxControl1.SelectedIndexChanged
			If Not listBoxControl1.SelectedItem Is Nothing Then
				ShowModule(listBoxControl1.SelectedItem.ToString())
			End If
		End Sub

		Private Sub ShowModule(ByVal name As String)
			pcMain.SuspendLayout()
			Try
				Dim [module] As DevExpress.Tutorials.ModuleBase = TutorialsInfo.ShowModule(name, gcContainer, Me.MainMenu, defaultLookAndFeel)
				SelectModule([module], True)
			Finally
				pcMain.ResumeLayout()
			End Try
		End Sub
    End Class
End Namespace

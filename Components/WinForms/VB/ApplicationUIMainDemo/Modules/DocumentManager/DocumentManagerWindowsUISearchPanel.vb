Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class DocumentManagerWindowsUISearchPanel
		Inherits TutorialControl
		Public Sub New()
            InitializeComponent()
            Dim ucDocumentManagerWindowsUI As ucDocumentManagerWindowsUISearchPanel
            ucDocumentManagerWindowsUI = New ucDocumentManagerWindowsUISearchPanel()
            ucDocumentManagerWindowsUI.Dock = DockStyle.Fill
            panelControl1.Controls.Add(ucDocumentManagerWindowsUI)
		End Sub
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.DashboardCommon
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon

Namespace DashboardMainDemo
	Partial Public Class DashboardDesignerForm
		Inherits RibbonForm
		Private saveDashboard_Renamed As Boolean

		Public ReadOnly Property Dashboard() As Dashboard
			Get
				Return dashboardDesigner.Dashboard
			End Get
		End Property
		Public ReadOnly Property SaveDashboard() As Boolean
			Get
				Return saveDashboard_Renamed
			End Get
		End Property

		Public Sub New(ByVal dashboard As Dashboard)
			InitializeComponent()
			Icon = ResourceImageHelper.CreateIconFromResourcesEx("DashboardMainDemo.AppIcon.ico", GetType(frmMain).Assembly)
			dashboardDesigner.Dashboard = dashboard
		End Sub

		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			MyBase.OnClosing(e)
			If dashboardDesigner.IsDashboardModified Then
				Dim result As DialogResult = XtraMessageBox.Show(LookAndFeel, Me, "Do you want to save changes ?", "Dashboard Designer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
				If result = System.Windows.Forms.DialogResult.Cancel Then
					e.Cancel = True
				Else
					saveDashboard_Renamed = result = System.Windows.Forms.DialogResult.Yes
				End If
			End If
		End Sub

		Private Sub DashboardDesignerForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			'Comment out the following lines to enable the New, Open, Save and Save As buttons in the Ribbon, 
			'as well as the Backstage View that allows you to quickly reopen recent dashboards.
			fileRibbonPageGroup1.Enabled = False
			fileNewBarItem1.Enabled = False
			fileOpenBarItem1.Enabled = False
			ribbonControl1.Toolbar.ItemLinks.Remove(fileSaveBarItem1)
			dashboardBackstageViewControl1.Enabled = False
		End Sub
	End Class
End Namespace

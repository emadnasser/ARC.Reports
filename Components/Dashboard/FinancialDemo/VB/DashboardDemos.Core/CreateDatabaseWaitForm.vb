Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraWaitForm

Namespace DashboardDemos.Core
	Partial Public Class CreateDatabaseWaitForm
		Inherits WaitForm
		Public Sub New()
			InitializeComponent()
			progressBar.Properties.Maximum = DashboardDemosUtils.DatabaseCreationMaxStep
		End Sub
		Public Overrides Sub SetCaption(ByVal caption As String)
			MyBase.SetCaption(caption)
			labelCaption.Text = caption
		End Sub
		Private Sub timerProgress_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timerProgress.Tick
			progressBar.EditValue = DashboardDemosUtils.DatabaseCreationCurrentStep
		End Sub
		Private Sub CreateDatabaseWaitForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			timerProgress.Start()
		End Sub

	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class AppearanceModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
		End Sub
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property
		Protected ReadOnly Property IsSchedulerAppearances() As Boolean
			Get
				Return rgrpEdit.SelectedIndex = 0
			End Get
		End Property
		Protected ReadOnly Property IsViewAppearances() As Boolean
			Get
				Return rgrpEdit.SelectedIndex = 1
			End Get
		End Property
		Protected ReadOnly Property IsResourceColorSchemas() As Boolean
			Get
				Return rgrpEdit.SelectedIndex = 2
			End Get
		End Property

		Private Sub DayViewModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			CarsDataHelper.FillData(schedulerControl, schedulerStorage)
		End Sub
		Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
			If IsResourceColorSchemas Then
				EditColorSchemas(schedulerControl.ResourceColorSchemas)
			Else
				Dim app As BaseViewAppearance = If(IsSchedulerAppearances, schedulerControl.Appearance, schedulerControl.ActiveView.Appearance)
				EditAppearances(app)
			End If
		End Sub
		Private Sub EditAppearances(ByVal appearances As BaseAppearanceCollection)
			Dim frm As New AppearancesEditForm(appearances, Me.FindForm())
			frm.ShowDialog()
		End Sub
		Private Sub EditColorSchemas(ByVal colorSchemas As SchedulerColorSchemaCollection)
			Dim frm As New ColorSchemasEditForm(colorSchemas, Me.FindForm())
			frm.ShowDialog()
		End Sub
	End Class
End Namespace

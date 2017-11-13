Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos
	Partial Public Class ChartDemoBase
		Inherits TutorialControl
		Protected panel As PanelControl
		Protected WithEvents checkEditShowLabels As CheckEdit

		Protected Property CheckEditShowLabelsVisible() As Boolean
			Get
				Return checkEditShowLabels.Visible
			End Get
			Set(ByVal value As Boolean)
				checkEditShowLabels.Visible = value
			End Set
		End Property
		Protected Property ShowLabels() As Boolean
			Get
				Return checkEditShowLabels.Checked
			End Get
			Set(ByVal value As Boolean)
				checkEditShowLabels.Checked = value
			End Set
		End Property
		Protected Overridable ReadOnly Property CrosshairEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.Default
			End Get
		End Property
		Protected Overridable ReadOnly Property ToolTipEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.Default
			End Get
		End Property

		Public Overridable ReadOnly Property AnimateChartControlOnDemoAppear() As Boolean
			Get
				Return True
			End Get
		End Property
		Public Property AppearanceName() As String
			Get
				Return If(ChartControl Is Nothing, String.Empty, ChartControl.AppearanceName)
			End Get
			Set(ByVal value As String)
				SetAppearanceName(value)
			End Set
		End Property
		Public Property PaletteName() As String
			Get
				Return If(ChartControl Is Nothing, String.Empty, ChartControl.PaletteName)
			End Get
			Set(ByVal value As String)
				SetPaletteName(value)
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overridable Sub ChartDemoBase_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			If ChartControl IsNot Nothing AndAlso (Not DesignMode) Then
				InitControls()
				UpdateControls()
			End If
		End Sub
		Protected Overridable Sub SetAppearanceName(ByVal appearanceName As String)
			If ChartControl IsNot Nothing Then
				ChartControl.AppearanceName = appearanceName
			End If
		End Sub
		Protected Overridable Sub SetPaletteName(ByVal paletteName As String)
			If ChartControl IsNot Nothing Then
				ChartControl.PaletteName = paletteName
			End If
		End Sub
		Protected Overridable Sub checkEditShowLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditShowLabels.CheckedChanged
			For Each series As Series In ChartControl.Series
				If series.Label IsNot Nothing Then
					series.LabelsVisibility = If(checkEditShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
				End If
			Next series
			If (Not String.IsNullOrWhiteSpace(ChartControl.SeriesDataMember)) AndAlso ChartControl.DataSource IsNot Nothing Then
				ChartControl.SeriesTemplate.LabelsVisibility = If(checkEditShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
			End If
			ChartControl.CrosshairEnabled = If(checkEditShowLabels.Checked, DefaultBoolean.False, CrosshairEnabled)
			ChartControl.ToolTipEnabled = If(checkEditShowLabels.Checked, DefaultBoolean.False, ToolTipEnabled)
			UpdateControls()
		End Sub
		Protected Overridable Sub InitControls()
		End Sub
		Public Overridable Sub UpdateControls()
		End Sub
	End Class
End Namespace

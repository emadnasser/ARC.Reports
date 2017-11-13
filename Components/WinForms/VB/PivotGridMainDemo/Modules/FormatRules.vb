Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.PivotGrid

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class FormatRules
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\FormatRules.vb"
            TutorialInfo.WhatsThisXMLFile = "FormatRules.xml"
			' TODO: Add any initialization after the InitializeComponent call
		End Sub
		Public Overrides ReadOnly Property ViewOptionsControl() As PivotGridControl
			Get
				Return pivotGridControl1
			End Get
		End Property
		Public Overrides ReadOnly Property ExportControl() As PivotGridControl
			Get
				Return pivotGridControl1
			End Get
		End Property

		Private Sub StyleConditions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.BeginUpdate()
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			fieldYear.FilterValues.FilterType = PivotFilterType.Included
            fieldYear.FilterValues.Add(2015)
			pivotGridControl1.OptionsCustomization.AllowFilterBySummary = False
			pivotGridControl1.EndUpdate()
		End Sub

		Private Sub pivotGridControl1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pivotGridControl1.Click

		End Sub
	End Class
End Namespace


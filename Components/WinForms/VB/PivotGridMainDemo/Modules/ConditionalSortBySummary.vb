Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class ConditionalSortBySummary
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\ConditionalSortBySummary.vb"
            TutorialInfo.WhatsThisXMLFile = "ConditionalSortBySummary.xml"
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
		'<pivotGridControl1>
		Private Sub ConditionalSortBySummary_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pivotGridControl1.BeginUpdate()
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			fieldYear.FilterValues.ValuesIncluded = New Object() { 1994 }
			fieldSalesPerson.SortBySummaryInfo.Field = fieldDiscount
			fieldSalesPerson.SortBySummaryInfo.Conditions.Add(New PivotGridFieldSortCondition(fieldYear, 1994))
			fieldSalesPerson.SortBySummaryInfo.Conditions.Add(New PivotGridFieldSortCondition(fieldMonth, 8))
			pivotGridControl1.EndUpdate()
		End Sub
		'</pivotGridControl1>
	End Class
End Namespace

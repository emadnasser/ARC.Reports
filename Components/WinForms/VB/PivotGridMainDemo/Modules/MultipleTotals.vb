Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Utils

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class MultipleTotals
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\MultipleTotals.vb"
            TutorialInfo.WhatsThisXMLFile = "MultipleTotals.xml"

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
		'<pivotGridControl1>
		Private Sub MultipleTotals_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			fieldYear.Group.FilterValues.FilterType = PivotFilterType.Included
			fieldYear.Group.FilterValues.Values.Add(1995)
			pivotGridControl1.ValueImages = CategoryImageList
			InitCustomTotals()
		End Sub

		Private Sub InitCustomTotals()
			fieldCategoryName.TotalsVisibility = PivotTotalsVisibility.CustomTotals
			fieldCategoryName.CustomTotals.Add(PivotSummaryType.Average)
			fieldCategoryName.CustomTotals.Add(PivotSummaryType.Sum)
			fieldCategoryName.CustomTotals.Add(PivotSummaryType.Max)
			fieldCategoryName.CustomTotals.Add(PivotSummaryType.Min)
			fieldCategoryName.CustomTotals.Add(PivotSummaryType.Count)
		End Sub

		Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs) Handles pivotGridControl1.FieldValueImageIndex
			If e.Field Is fieldCategoryName AndAlso Comparer.Equals(e.ValueType, PivotGridValueType.Value) Then
				e.ImageIndex = GetCategoryIndexByName(e.Value)
			End If
			If e.ValueType = PivotGridValueType.CustomTotal Then
				If e.CustomTotal.SummaryType = PivotSummaryType.Sum AndAlso e.Field.Area <> PivotArea.DataArea Then
					e.ImageIndex = 8
				End If
			End If
		End Sub
		'</pivotGridControl1>
	End Class
End Namespace


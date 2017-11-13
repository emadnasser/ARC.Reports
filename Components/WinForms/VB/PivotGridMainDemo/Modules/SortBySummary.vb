Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.PivotGrid

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class SortBySummary
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\SortBySummary.vb"
            TutorialInfo.WhatsThisXMLFile = "SortBySummary.xml"

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
		'<icbField>
		Private Sub SortBySummary_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			fieldYear.FilterValues.FilterType = PivotFilterType.Included
            fieldYear.FilterValues.Add(2015)
			InitComboBoxes()
			pivotGridControl1.HeaderImages = HeadersImageList
			fieldSalesPerson.ImageIndex = 0
		End Sub

		Private Sub InitComboBoxes()
			For Each field As PivotGridField In pivotGridControl1.Fields
				If field.Area = PivotArea.DataArea Then
					icbField.Properties.Items.Add(New ImageComboBoxItem(field.Caption.ToString(), field, -1))
				End If
			Next field
			icbField.EditValue = fieldSalesPerson.SortBySummaryInfo.Field
		End Sub

		Private Sub icbField_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbField.SelectedIndexChanged
			fieldSalesPerson.SortBySummaryInfo.Field = CType(icbField.EditValue, PivotGridField)
		End Sub
		'</icbField>
		Private Sub pivotGridControl1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs) Handles pivotGridControl1.CustomDrawCell
			If Comparer.ReferenceEquals(e.DataField, CType(icbField.EditValue, PivotGridField)) Then
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
			End If
		End Sub
	End Class
End Namespace


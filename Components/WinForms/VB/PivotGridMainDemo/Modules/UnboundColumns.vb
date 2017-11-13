Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class UnboundColumns
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\UnboundColumns.vb"
            TutorialInfo.WhatsThisXMLFile = "UnboundColumns.xml"

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

		Private Sub UnboundColumns_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			pivotGridControl1.HeaderImages = HeadersImageList
			fieldSalesPerson.ImageIndex = 0
			fieldOrderAmount.ImageIndex = 3
			fieldBonusAmount.ImageIndex = 4
		End Sub
		'<icbOrderAmount>
		'<icbSalesPerson>
		Private Sub pivotGridControl1_CustomUnboundFieldData(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomFieldDataEventArgs) Handles pivotGridControl1.CustomUnboundFieldData
			Dim row As DataRowView = GetDataRowByIndex(e.ListSourceRowIndex)
			If row Is Nothing Then
				Return
			End If
			If e.Field Is fieldSalesPerson Then
				e.Value = String.Format(icbSalesPerson.EditValue.ToString(), row("FirstName"), row("LastName"))
			End If
			If e.Field Is fieldOrderAmount Then
				Dim discount As Double = If(icbOrderAmount.EditValue.Equals(0), Convert.ToDouble(row("Discount")), 0)
				e.Value = Convert.ToDouble(row("UnitPrice")) * Convert.ToDouble(row("Quantity")) * (1 - discount)
			End If
		End Sub
		'</icbSalesPerson>        
		'<skip>
		Private Sub icb_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbOrderAmount.SelectedIndexChanged, icbSalesPerson.SelectedIndexChanged
			pivotGridControl1.RefreshData()
		End Sub

		Private Sub pivotGridControl1_FieldAreaChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldEventArgs) Handles pivotGridControl1.FieldAreaChanged
			If e.Field Is fieldOrderAmount Then
				fieldBonusAmount.Visible = e.Field.Area = PivotArea.DataArea
				fieldBonusAmount.Visible = e.Field.Area = PivotArea.DataArea
			End If
		End Sub
		'</skip>
		Private Sub pivotGridControl1_CustomCellDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs) Handles pivotGridControl1.CustomCellDisplayText
			If Comparer.ReferenceEquals(e.DataField, fieldPercent) Then
				Dim orderAmount As Object = e.GetCellValue(fieldOrderAmount)
				If orderAmount Is Nothing Then
					Return
				End If
				Dim grandTotalOrderAmount As Decimal = CDec(e.GetRowGrandTotal(fieldOrderAmount))
				Dim perc As Decimal = If(grandTotalOrderAmount <> 0, CDec(orderAmount) / grandTotalOrderAmount, 0)
				e.DisplayText = String.Format("{0:p}", perc)
			End If
			'The Bonus Amount field displays 15% if the order amount is greater than $50,000, or 10% of the amount is less.
			If Comparer.ReferenceEquals(e.DataField, fieldBonusAmount) Then
				Dim orderAmount As Object = e.GetCellValue(fieldOrderAmount)
				If orderAmount Is Nothing Then
					Return
				End If
				Dim perc As Double = If(CDec(orderAmount) > 50000, 0.15, 0.1)
				e.DisplayText = If(Comparer.Equals(e.RowValueType, PivotGridValueType.Value), String.Format("{0:p}", perc), "")
			End If
		End Sub
		'</icbOrderAmount>
	End Class
End Namespace


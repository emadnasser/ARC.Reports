Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class CustomCellValue
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\CustomCellValue.vb"
            TutorialInfo.WhatsThisXMLFile = "CustomCellValue.xml"
		End Sub

		Private Sub CustomCellValue_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("CustomerReports")


		End Sub
		'<pivotGridControl1>
		Private Sub pivotGridControl1_CustomCellValue(ByVal sender As Object, ByVal e As PivotCellValueEventArgs) Handles pivotGridControl1.CustomCellValue
			If e.RowValueType = PivotGridValueType.Total Then
				e.Value = Nothing
				Dim index As Integer = e.RowIndex - 1
				Do While index >= 0 AndAlso e.Value Is Nothing
					If (Not Comparer.Equals(pivotGridControl1.GetFieldValueType(False, index), PivotGridValueType.Value)) Then
						Exit Do
					End If
					e.Value = e.GetCellValue(e.ColumnIndex, index)
					index -= 1
				Loop
			End If
		End Sub

		Private Sub pivotGridControl1_FieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs) Handles pivotGridControl1.FieldValueDisplayText
			If e.Field Is fieldOrderYear AndAlso e.ValueType = PivotGridValueType.Total Then
				e.DisplayText = "Last Quarter Amount"
			End If
		End Sub
		'</pivotGridControl1>
	End Class
End Namespace

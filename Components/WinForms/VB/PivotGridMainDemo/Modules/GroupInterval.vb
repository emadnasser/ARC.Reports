Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class GroupInterval
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\GroupInterval.vb"
            TutorialInfo.WhatsThisXMLFile = "GroupInterval.xml"

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

		Private Sub GroupInterval_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			InitComboBoxes()
			ceProductInterval.Checked = True
			pivotGridControl1.HeaderImages = HeadersImageList
			fieldExtendedPrice.ImageIndex = 3
		End Sub

		Private Sub InitComboBoxes()
			Dim arr As Array = System.Enum.GetValues(GetType(PivotGroupInterval))
			For Each interval As PivotGroupInterval In arr
				If interval.ToString().IndexOf("Date") = 0 Then
					icbGroupInterval.Properties.Items.Add(New ImageComboBoxItem(interval.ToString(), interval, -1))
				End If
			Next interval
			icbGroupInterval.SelectedIndex = icbGroupInterval.Properties.Items.Count - 1
		End Sub
		'<icbGroupInterval>
		Private Sub icbGroupInterval_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbGroupInterval.SelectedIndexChanged
			fieldOrderDate.FilterValues.Clear()
			fieldOrderDate.GroupInterval = CType(icbGroupInterval.EditValue, PivotGroupInterval)
			fieldOrderDate.Caption = String.Format("Order Date ({0})", fieldOrderDate.GroupInterval.ToString().Replace("Date", ""))
		End Sub
		'</icbGroupInterval>
		'<ceProductInterval>
		Private Sub ceProductInterval_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceProductInterval.CheckedChanged
			fieldProductAlphabetical.Visible = ceProductInterval.Checked
		End Sub
		'</ceProductInterval>

		Private Sub pivotGridControl1_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles pivotGridControl1.FieldValueDisplayText
			If e.Field Is fieldOrderDate AndAlso e.Field.GroupInterval = PivotGroupInterval.DateQuarter Then
				e.DisplayText = String.Format("Qtr {0}", e.Value)
				If e.ValueType = PivotGridValueType.Total Then
					e.DisplayText &= " Total"
				End If
			End If
		End Sub

	End Class
End Namespace


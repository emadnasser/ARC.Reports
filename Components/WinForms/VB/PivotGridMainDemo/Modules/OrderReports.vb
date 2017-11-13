Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	''' <summary>
	''' Summary description for OrderReports.
	''' </summary>
	Partial Public Class OrderReports
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\OrderReports.vb"
            TutorialInfo.WhatsThisXMLFile = "OrderReports.xml"
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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

		Private Sub OrderReports_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("OrderReports")
			InitComboBox()
			rgReport.SelectedIndex = 0
			pivotGridControl1.HeaderImages = HeadersImageList
			fieldOrderID.ImageIndex = 1
			fieldSum.ImageIndex = 3
		End Sub

		Private Sub InitComboBox()
			Dim values() As Object = fieldOrderID.GetUniqueValues()
			For Each obj As Object In values
				cbeOrder.Properties.Items.Add(obj)
			Next obj
			cbeOrder.SelectedIndex = 0
		End Sub

		Protected Overrides Sub DoShow()
			SetCaption()
			OnSetDescription(ReportsDescriptions.OrderReportsDescriptions(rgReport.SelectedIndex))
			MyBase.DoShow()
		End Sub
		'<rgReport>
		Private Sub SetReport()
			DoShow()
			pivotGridControl1.BeginUpdate()
			Try
				fieldOrderID.FilterValues.Clear()
				pcOrder.Visible = rgReport.SelectedIndex = 1
				pivotGridControl1.OptionsView.ShowRowGrandTotals = rgReport.SelectedIndex <> 1
				fieldOrderID.FilterValues.FilterType = If(rgReport.SelectedIndex = 1, PivotFilterType.Included, PivotFilterType.Excluded)
				Dim parameter As DefaultBoolean = If((rgReport.SelectedIndex = 1), DefaultBoolean.False, DefaultBoolean.Default)
				fieldOrderID.Options.AllowSort = parameter
				fieldOrderID.Options.AllowFilter = fieldOrderID.Options.AllowSort
				For Each field As PivotGridField In pivotGridControl1.Fields
					field.Area = PivotArea.FilterArea
				Next field
				Select Case rgReport.SelectedIndex
					Case 0, 1
						fieldOrderID.Area = PivotArea.RowArea
						fieldProduct.Area = PivotArea.RowArea
						fieldUnitPrice.Area = PivotArea.DataArea
						fieldQuantity.Area = PivotArea.DataArea
						fieldDiscount.Area = PivotArea.DataArea
						fieldSum.Area = PivotArea.DataArea
						If rgReport.SelectedIndex = 1 Then
							SetOrderFilter()
						End If
					Case 2
						fieldProduct.Area = PivotArea.RowArea
						fieldQuantity.Area = PivotArea.DataArea
					Case 3
						fieldProduct.Area = PivotArea.RowArea
						fieldUnitPrice.Area = PivotArea.DataArea
				End Select
			Finally
				pivotGridControl1.EndUpdate()
			End Try
		End Sub
		'</rgReport>
		'<cbeOrder>
		Private Sub SetOrderFilter()
			pivotGridControl1.BeginUpdate()
			Try
				fieldOrderID.FilterValues.Clear()
				fieldOrderID.FilterValues.Add(cbeOrder.SelectedItem)
			Finally
				pivotGridControl1.EndUpdate()
			End Try
		End Sub
		'</cbeOrder>

		Private Sub rgReport_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rgReport.SelectedIndexChanged
			SetReport()
		End Sub

		Private Sub cbeOrder_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbeOrder.SelectedIndexChanged
			SetOrderFilter()
		End Sub

		Private Sub SetCaption()
			If rgReport.SelectedIndex > -1 Then
				OnSetCaption(rgReport.Properties.Items(rgReport.SelectedIndex).Description)
			End If
		End Sub
		Protected Overrides Sub OnSetCaption(ByVal fCaption As String)
			Caption.Text = String.Format("{0}: {1}", TutorialName, fCaption)
		End Sub
	End Class
End Namespace

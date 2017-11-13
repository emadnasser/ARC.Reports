Imports Microsoft.VisualBasic
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms
Imports System.Collections

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	''' <summary>
	''' Summary description for ProductReports.
	''' </summary>
	Partial Public Class ProductReports
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\ProductReports.vb"
            TutorialInfo.WhatsThisXMLFile = "ProductReports.xml"
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

		Private Sub ProductReports_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("ProductReports")
			cbeDate.SelectedIndex = 1
			rgReport.SelectedIndex = 0
			pivotGridControl1.ValueImages = CategoryImageList
			pivotGridControl1.HeaderImages = HeadersImageList
			fieldProductSales.ImageIndex = 3
		End Sub

		Private Sub pivotGridControl1_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles pivotGridControl1.FieldValueDisplayText
			If e.Field Is fieldShippedMonth AndAlso e.Value IsNot Nothing Then
				e.DisplayText = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Convert.ToInt32(e.Value) - 1)
				If e.ValueType = PivotGridValueType.Total Then
					e.DisplayText &= " Total"
				End If
			End If
		End Sub

		Protected Overrides Sub DoShow()
			SetCaption()
			OnSetDescription(ReportsDescriptions.ProductReportsDescriptions(rgReport.SelectedIndex))
			MyBase.DoShow()
		End Sub

		'<rgReport>
		Private Sub SetReport()
			DoShow()
			pivotGridControl1.BeginUpdate()
			Try
				pcCategories.Visible = rgReport.SelectedIndex = 1
				pcDate.Visible = rgReport.SelectedIndex = 2
				fieldShippedMonth.Visible = rgReport.SelectedIndex = 2
				For Each field As PivotGridField In pivotGridControl1.Fields
					field.Area = PivotArea.FilterArea
				Next field
				fieldProductSales.Area = PivotArea.DataArea
				fieldCategoryName.CustomTotals.Clear()
				fieldCategoryName.TotalsVisibility = PivotTotalsVisibility.AutomaticTotals
				fieldCategoryName.Area = 0
				fieldProductName.SortBySummaryInfo.Field = Nothing
				fieldProductName.SortOrder = PivotSortOrder.Ascending
				fieldProductName.TopValueCount = 0
				fieldMinimumSale.Visible = False
				fieldAverageSale.Visible = fieldMinimumSale.Visible
				pivotGridControl1.Groups(0).Clear()
				Select Case rgReport.SelectedIndex
					Case 0
						fieldCategoryName.Area = PivotArea.RowArea
					Case 1
						fieldProductName.Area = PivotArea.RowArea
						If ceCategories.Checked Then
							fieldCategoryName.Area = PivotArea.RowArea
							fieldCategoryName.AreaIndex = 0
						Else
							fieldCategoryName.Area = PivotArea.FilterArea
						End If
					Case 2
						fieldCategoryName.Area = PivotArea.RowArea
						fieldProductName.Area = PivotArea.RowArea
						SetDateInterval()
					Case 3
						fieldCategoryName.TotalsVisibility = PivotTotalsVisibility.CustomTotals
						fieldCategoryName.Area = PivotArea.RowArea
						fieldProductName.Area = PivotArea.RowArea
						SetDateInterval(True)
						fieldCategoryName.CustomTotals.Add(PivotSummaryType.Average)
						fieldCategoryName.CustomTotals.Add(PivotSummaryType.Sum)
						fieldCategoryName.CustomTotals.Add(PivotSummaryType.Max)
						fieldCategoryName.CustomTotals.Add(PivotSummaryType.Min)
					Case 4
						fieldShippedQuarter.SetAreaPosition(PivotArea.RowArea, 0)
						fieldCategoryName.Area = PivotArea.RowArea
						fieldAverageSale.SetAreaPosition(PivotArea.DataArea, 1)
						fieldMinimumSale.SetAreaPosition(PivotArea.DataArea, 2)
						fieldMinimumSale.Visible = True
						fieldAverageSale.Visible = fieldMinimumSale.Visible
					Case 5
						fieldProductName.Area = PivotArea.RowArea
						fieldCategoryName.Area = PivotArea.RowArea
						fieldProductName.SortBySummaryInfo.Field = fieldProductSales
						fieldProductName.SortOrder = PivotSortOrder.Descending
						fieldProductName.TopValueCount = 3
				End Select
			Finally
				pivotGridControl1.EndUpdate()
			End Try
		End Sub
		'</rgReport>
		'<cbeDate>
		Private Sub SetDateInterval()
			SetDateInterval(False)
		End Sub
		Private Sub SetDateInterval(ByVal showYearAndQuarter As Boolean)
			If cbeDate.SelectedIndex = 3 AndAlso (Not showYearAndQuarter) Then
				pivotGridControl1.Groups(0).AddRange(New PivotGridFieldBase() { fieldShippedYear, fieldShippedQuarter, fieldShippedMonth })
			Else
				pivotGridControl1.Groups(0).Clear()
			End If
			fieldShippedYear.Area = If((cbeDate.SelectedIndex = 0 OrElse cbeDate.SelectedIndex = 3 OrElse showYearAndQuarter), PivotArea.ColumnArea, PivotArea.FilterArea)
			fieldShippedQuarter.Area = If((cbeDate.SelectedIndex = 1 OrElse cbeDate.SelectedIndex = 3 OrElse showYearAndQuarter), PivotArea.ColumnArea, PivotArea.FilterArea)
			fieldShippedMonth.Area = If((cbeDate.SelectedIndex = 2 OrElse cbeDate.SelectedIndex = 3), PivotArea.ColumnArea, PivotArea.FilterArea)
			If showYearAndQuarter Then
				fieldShippedMonth.Area = PivotArea.FilterArea
			End If
			fieldShippedYear.AreaIndex = 0
			fieldShippedQuarter.AreaIndex = 1
			fieldShippedMonth.AreaIndex = 2
		End Sub
		'</cbeDate>

		Private Sub rgReport_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rgReport.SelectedIndexChanged
			SetReport()
		End Sub

		Private Sub ceCategories_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCategories.CheckedChanged
			SetReport()
		End Sub

		Private Sub cbeDate_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbeDate.SelectedIndexChanged
			pivotGridControl1.BeginUpdate()
			Try
				SetDateInterval()
			Finally
				pivotGridControl1.EndUpdate()
			End Try
		End Sub

		Private Sub SetCaption()
			If rgReport.SelectedIndex > -1 Then
				OnSetCaption(rgReport.Properties.Items(rgReport.SelectedIndex).Description)
			End If
		End Sub
		'<ceDrillDown>
		Private Sub pivotGridControl1_CellDoubleClick(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles pivotGridControl1.CellDoubleClick
			If (Not ceDrillDown.Checked) Then
				Return
			End If
			Dim form As New XtraForm()
			form.Text = "Drill Down Form"
			form.StartPosition = FormStartPosition.CenterParent
			Dim grid As New DataGridView()
			grid.Parent = form
			grid.Dock = DockStyle.Fill
			grid.DataSource = e.CreateDrillDownDataSource()
            form.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", GetType(ProductReports).Assembly)
			form.Width = 520
			form.Height = 300
			form.ShowDialog()
			form.Dispose()
		End Sub
		'</ceDrillDown>
		Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs) Handles pivotGridControl1.FieldValueImageIndex
			If e.Field Is fieldCategoryName AndAlso Comparer.Equals(e.ValueType, PivotGridValueType.Value) Then
				e.ImageIndex = GetCategoryIndexByName(e.Value)
			End If
		End Sub

		Protected Overrides Sub OnSetCaption(ByVal fCaption As String)
			Caption.Text = String.Format("{0}: {1}", TutorialName, fCaption)
		End Sub

		Private Sub ceDrillDown_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
	End Class
End Namespace

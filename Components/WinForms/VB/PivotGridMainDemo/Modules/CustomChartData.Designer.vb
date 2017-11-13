Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class CustomChartData
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.comboChartType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.checkShowPointLabels = New DevExpress.XtraEditors.CheckEdit()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.seCellZeroValueThreshold = New DevExpress.XtraEditors.SpinEdit()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.cbRowFieldValuesExportRule = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType(Me.comboChartType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkShowPointLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.seCellZeroValueThreshold.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbRowFieldValuesExportRule.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'fieldYear
            '
            Me.fieldYear.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            Me.fieldYear.FieldName = "OrderDate"
            Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.Name = "fieldYear"
            Me.fieldYear.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldYear.Options.ShowCustomTotals = False
            Me.fieldYear.Options.ShowGrandTotal = False
            Me.fieldYear.Options.ShowTotals = False
            Me.fieldYear.UnboundFieldName = "fieldYear"
            '
            'fieldQuarter
            '
            Me.fieldQuarter.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea
            Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldQuarter.AreaIndex = 1
            Me.fieldQuarter.Caption = "Quarter"
            Me.fieldQuarter.FieldName = "OrderDate"
            Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldQuarter.Name = "fieldQuarter"
            Me.fieldQuarter.Options.ShowCustomTotals = False
            Me.fieldQuarter.Options.ShowGrandTotal = False
            Me.fieldQuarter.Options.ShowTotals = False
            Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
            Me.fieldQuarter.ValueFormat.FormatString = "Qtr {0}"
            Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            '
            'fieldMonth
            '
            Me.fieldMonth.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea
            Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldMonth.AreaIndex = 2
            Me.fieldMonth.Caption = "Month"
            Me.fieldMonth.FieldName = "OrderDate"
            Me.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldMonth.Name = "fieldMonth"
            Me.fieldMonth.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldMonth.Options.ShowCustomTotals = False
            Me.fieldMonth.Options.ShowGrandTotal = False
            Me.fieldMonth.Options.ShowTotals = False
            Me.fieldMonth.UnboundFieldName = "fieldMonth"
            '
            'groupControl2
            '
            Me.groupControl2.Controls.Add(Me.labelControl2)
            Me.groupControl2.Controls.Add(Me.comboChartType)
            Me.groupControl2.Controls.Add(Me.checkShowPointLabels)
            Me.groupControl2.Location = New System.Drawing.Point(353, 0)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(246, 85)
            Me.groupControl2.TabIndex = 1
            Me.groupControl2.Text = "Chart Settings"
            '
            'labelControl2
            '
            Me.labelControl2.Location = New System.Drawing.Point(16, 34)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(58, 13)
            Me.labelControl2.TabIndex = 20
            Me.labelControl2.Text = "Chart Type:"
            '
            'comboChartType
            '
            Me.comboChartType.EditValue = "Line"
            Me.comboChartType.Location = New System.Drawing.Point(80, 31)
            Me.comboChartType.Name = "comboChartType"
            Me.comboChartType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboChartType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboChartType.Size = New System.Drawing.Size(154, 20)
            Me.comboChartType.TabIndex = 21
            '
            'checkShowPointLabels
            '
            Me.checkShowPointLabels.Location = New System.Drawing.Point(14, 56)
            Me.checkShowPointLabels.Name = "checkShowPointLabels"
            Me.checkShowPointLabels.Properties.Caption = "Show Point Labels"
            Me.checkShowPointLabels.Size = New System.Drawing.Size(109, 19)
            Me.checkShowPointLabels.TabIndex = 22
            '
            'groupControl1
            '
            Me.groupControl1.Controls.Add(Me.labelControl5)
            Me.groupControl1.Controls.Add(Me.seCellZeroValueThreshold)
            Me.groupControl1.Controls.Add(Me.labelControl4)
            Me.groupControl1.Controls.Add(Me.labelControl1)
            Me.groupControl1.Controls.Add(Me.cbRowFieldValuesExportRule)
            Me.groupControl1.Location = New System.Drawing.Point(0, 0)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(347, 85)
            Me.groupControl1.TabIndex = 0
            Me.groupControl1.Text = "Pivot Grid Settings"
            '
            'labelControl5
            '
            Me.labelControl5.Location = New System.Drawing.Point(241, 59)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(70, 13)
            Me.labelControl5.TabIndex = 26
            Me.labelControl5.Text = "as Zero Values"
            '
            'seCellZeroValueThreshold
            '
            Me.seCellZeroValueThreshold.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seCellZeroValueThreshold.Location = New System.Drawing.Point(167, 56)
            Me.seCellZeroValueThreshold.Name = "seCellZeroValueThreshold"
            Me.seCellZeroValueThreshold.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seCellZeroValueThreshold.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.seCellZeroValueThreshold.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.seCellZeroValueThreshold.Properties.IsFloatValue = False
            Me.seCellZeroValueThreshold.Properties.Mask.EditMask = "N00"
            Me.seCellZeroValueThreshold.Size = New System.Drawing.Size(60, 20)
            Me.seCellZeroValueThreshold.TabIndex = 25
            '
            'labelControl4
            '
            Me.labelControl4.Location = New System.Drawing.Point(18, 59)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(139, 13)
            Me.labelControl4.TabIndex = 24
            Me.labelControl4.Text = "Export Cell Values Less than:"
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(18, 34)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(143, 13)
            Me.labelControl1.TabIndex = 23
            Me.labelControl1.Text = "Row Field Values Export Rule:"
            '
            'cbRowFieldValuesExportRule
            '
            Me.cbRowFieldValuesExportRule.EditValue = ""
            Me.cbRowFieldValuesExportRule.Location = New System.Drawing.Point(167, 31)
            Me.cbRowFieldValuesExportRule.Name = "cbRowFieldValuesExportRule"
            Me.cbRowFieldValuesExportRule.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbRowFieldValuesExportRule.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbRowFieldValuesExportRule.Size = New System.Drawing.Size(157, 20)
            Me.cbRowFieldValuesExportRule.TabIndex = 22
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.groupControl2)
            Me.panelControl1.Controls.Add(Me.groupControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(707, 92)
            Me.panelControl1.TabIndex = 3
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 92)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.pivotGridControl)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.chartControl)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(707, 378)
            Me.splitContainerControl1.SplitterPosition = 164
            Me.splitContainerControl1.TabIndex = 5
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'pivotGridControl
            '
            Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName, Me.fieldExtendedPrice, Me.fieldMonth, Me.fieldYear, Me.fieldProductName, Me.fieldQuarter})
            PivotGridGroup1.Caption = "DateTimeFields"
            PivotGridGroup1.Fields.Add(Me.fieldYear)
            PivotGridGroup1.Fields.Add(Me.fieldQuarter)
            PivotGridGroup1.Fields.Add(Me.fieldMonth)
            PivotGridGroup1.Hierarchy = Nothing
            PivotGridGroup1.ShowNewValues = True
            Me.pivotGridControl.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings
            Me.pivotGridControl.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value
            Me.pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = False
            Me.pivotGridControl.OptionsView.ShowColumnGrandTotals = False
            Me.pivotGridControl.OptionsView.ShowColumnTotals = False
            Me.pivotGridControl.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl.OptionsView.ShowRowGrandTotals = False
            Me.pivotGridControl.OptionsView.ShowRowTotals = False
            Me.pivotGridControl.Size = New System.Drawing.Size(707, 209)
            Me.pivotGridControl.TabIndex = 20
            '
            'fieldCategoryName
            '
            Me.fieldCategoryName.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category"
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldCategoryName.Options.ShowCustomTotals = False
            Me.fieldCategoryName.Options.ShowGrandTotal = False
            Me.fieldCategoryName.Options.ShowTotals = False
            Me.fieldCategoryName.Width = 155
            '
            'fieldExtendedPrice
            '
            Me.fieldExtendedPrice.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.CellFormat.FormatString = "c"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.fieldExtendedPrice.FieldName = "Extended Price"
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            Me.fieldExtendedPrice.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            '
            'fieldProductName
            '
            Me.fieldProductName.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "ProductName"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            '
            'chartControl
            '
            Me.chartControl.Cursor = System.Windows.Forms.Cursors.Default
            XyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
            XyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
            XyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl.Diagram = XyDiagram1
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.MaxHorizontalPercentage = 30.0R
            Me.chartControl.Location = New System.Drawing.Point(0, 0)
            Me.chartControl.Name = "chartControl"
            Me.chartControl.SeriesDataMember = "Series"
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartControl.SeriesTemplate.ArgumentDataMember = "Arguments"
            Me.chartControl.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            Me.chartControl.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:c}"
            PointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl.SeriesTemplate.Label = PointSeriesLabel1
            Me.chartControl.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.chartControl.SeriesTemplate.View = LineSeriesView1
            Me.chartControl.Size = New System.Drawing.Size(707, 164)
            Me.chartControl.TabIndex = 30
            '
            'CustomChartData
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "CustomChartData"
            Me.Size = New System.Drawing.Size(707, 470)
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            Me.groupControl2.PerformLayout()
            CType(Me.comboChartType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkShowPointLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType(Me.seCellZeroValueThreshold.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbRowFieldValuesExportRule.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents pivotGridControl As PivotGridControl
		Private fieldCategoryName As PivotGridField
		Private fieldExtendedPrice As PivotGridField
		Private fieldMonth As PivotGridField
		Private chartControl As DevExpress.XtraCharts.ChartControl
		Private fieldYear As PivotGridField
		Private fieldProductName As PivotGridField
		Private fieldQuarter As PivotGridField
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents checkShowPointLabels As DevExpress.XtraEditors.CheckEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboChartType As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbRowFieldValuesExportRule As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents seCellZeroValueThreshold As DevExpress.XtraEditors.SpinEdit
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace

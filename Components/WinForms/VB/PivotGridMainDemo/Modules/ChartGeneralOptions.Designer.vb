Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class ChartGeneralOptions
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
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.seUpdateDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.lblUpdateDelay = New DevExpress.XtraEditors.LabelControl()
            Me.ceShowRowGrandTotals = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowColumnGrandTotals = New DevExpress.XtraEditors.CheckEdit()
            Me.ceSelectionOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.ceChartDataVertical = New DevExpress.XtraEditors.CheckEdit()
            Me.checkShowPointLabels = New DevExpress.XtraEditors.CheckEdit()
            Me.comboChartType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.seUpdateDelay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowRowGrandTotals.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowColumnGrandTotals.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceSelectionOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceChartDataVertical.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkShowPointLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboChartType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.seUpdateDelay)
            Me.panelControl1.Controls.Add(Me.lblUpdateDelay)
            Me.panelControl1.Controls.Add(Me.ceShowRowGrandTotals)
            Me.panelControl1.Controls.Add(Me.ceShowColumnGrandTotals)
            Me.panelControl1.Controls.Add(Me.ceSelectionOnly)
            Me.panelControl1.Controls.Add(Me.ceChartDataVertical)
            Me.panelControl1.Controls.Add(Me.checkShowPointLabels)
            Me.panelControl1.Controls.Add(Me.comboChartType)
            Me.panelControl1.Controls.Add(Me.labelControl2)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Padding = New System.Windows.Forms.Padding(5)
            Me.panelControl1.Size = New System.Drawing.Size(690, 67)
            Me.panelControl1.TabIndex = 0
            '
            'seUpdateDelay
            '
            Me.seUpdateDelay.EditValue = New Decimal(New Integer() {500, 0, 0, 0})
            Me.seUpdateDelay.Location = New System.Drawing.Point(184, 37)
            Me.seUpdateDelay.Name = "seUpdateDelay"
            Me.seUpdateDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seUpdateDelay.Properties.Increment = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seUpdateDelay.Properties.IsFloatValue = False
            Me.seUpdateDelay.Properties.Mask.EditMask = "N00"
            Me.seUpdateDelay.Properties.MaxValue = New Decimal(New Integer() {5000, 0, 0, 0})
            Me.seUpdateDelay.Size = New System.Drawing.Size(48, 20)
            Me.seUpdateDelay.TabIndex = 10
            Me.seUpdateDelay.ToolTip = "Sets the Chart update delay when PivotGrid selection changes."
            '
            'lblUpdateDelay
            '
            Me.lblUpdateDelay.Location = New System.Drawing.Point(107, 40)
            Me.lblUpdateDelay.Name = "lblUpdateDelay"
            Me.lblUpdateDelay.Size = New System.Drawing.Size(69, 13)
            Me.lblUpdateDelay.TabIndex = 13
            Me.lblUpdateDelay.Text = "Update Delay:"
            '
            'ceShowRowGrandTotals
            '
            Me.ceShowRowGrandTotals.EditValue = True
            Me.ceShowRowGrandTotals.Location = New System.Drawing.Point(412, 10)
            Me.ceShowRowGrandTotals.Name = "ceShowRowGrandTotals"
            Me.ceShowRowGrandTotals.Properties.AutoWidth = True
            Me.ceShowRowGrandTotals.Properties.Caption = "Show Row Grand Totals"
            Me.ceShowRowGrandTotals.Size = New System.Drawing.Size(136, 19)
            Me.ceShowRowGrandTotals.TabIndex = 7
            Me.ceShowRowGrandTotals.ToolTip = "Toggles whether row grand total values are shown in the Chart control"
            '
            'ceShowColumnGrandTotals
            '
            Me.ceShowColumnGrandTotals.Location = New System.Drawing.Point(412, 37)
            Me.ceShowColumnGrandTotals.Name = "ceShowColumnGrandTotals"
            Me.ceShowColumnGrandTotals.Properties.AutoWidth = True
            Me.ceShowColumnGrandTotals.Properties.Caption = "Show Column Grand Totals"
            Me.ceShowColumnGrandTotals.Size = New System.Drawing.Size(150, 19)
            Me.ceShowColumnGrandTotals.TabIndex = 13
            Me.ceShowColumnGrandTotals.ToolTip = "Toggles whether column grand total values are shown in the Chart control"
            '
            'ceSelectionOnly
            '
            Me.ceSelectionOnly.EditValue = True
            Me.ceSelectionOnly.Location = New System.Drawing.Point(10, 37)
            Me.ceSelectionOnly.Name = "ceSelectionOnly"
            Me.ceSelectionOnly.Properties.AutoWidth = True
            Me.ceSelectionOnly.Properties.Caption = "Selection Only"
            Me.ceSelectionOnly.Size = New System.Drawing.Size(90, 19)
            Me.ceSelectionOnly.TabIndex = 9
            Me.ceSelectionOnly.ToolTip = "Toggles whether all PivotGrid cells or selected cells only should be represented " & _
        "in the Chart"
            '
            'ceChartDataVertical
            '
            Me.ceChartDataVertical.Location = New System.Drawing.Point(238, 37)
            Me.ceChartDataVertical.Name = "ceChartDataVertical"
            Me.ceChartDataVertical.Properties.AutoWidth = True
            Me.ceChartDataVertical.Properties.Caption = "Generate Series from Columns"
            Me.ceChartDataVertical.Size = New System.Drawing.Size(167, 19)
            Me.ceChartDataVertical.TabIndex = 12
            Me.ceChartDataVertical.ToolTip = "Toggles whether series in a chart control are created based on PivotGrid columns " & _
        "or rows"
            '
            'checkShowPointLabels
            '
            Me.checkShowPointLabels.Location = New System.Drawing.Point(238, 10)
            Me.checkShowPointLabels.Name = "checkShowPointLabels"
            Me.checkShowPointLabels.Properties.AutoWidth = True
            Me.checkShowPointLabels.Properties.Caption = "Show Point Labels"
            Me.checkShowPointLabels.Size = New System.Drawing.Size(108, 19)
            Me.checkShowPointLabels.TabIndex = 4
            Me.checkShowPointLabels.ToolTip = "Toggles whether value labels are shown in the Chart control"
            '
            'comboChartType
            '
            Me.comboChartType.EditValue = "Line"
            Me.comboChartType.Location = New System.Drawing.Point(78, 10)
            Me.comboChartType.Name = "comboChartType"
            Me.comboChartType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboChartType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboChartType.Size = New System.Drawing.Size(154, 20)
            Me.comboChartType.TabIndex = 3
            '
            'labelControl2
            '
            Me.labelControl2.Location = New System.Drawing.Point(14, 13)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(58, 13)
            Me.labelControl2.TabIndex = 2
            Me.labelControl2.Text = "Chart Type:"
            '
            'paddingPanel
            '
            Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.paddingPanel.Location = New System.Drawing.Point(0, 67)
            Me.paddingPanel.Name = "paddingPanel"
            Me.paddingPanel.Size = New System.Drawing.Size(690, 8)
            Me.paddingPanel.TabIndex = 4
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 75)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.pivotGridControl)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.chartControl)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(690, 395)
            Me.splitContainerControl1.SplitterPosition = 176
            Me.splitContainerControl1.TabIndex = 5
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'pivotGridControl
            '
            Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName, Me.fieldExtendedPrice, Me.fieldOrderDate, Me.fieldOrderYear})
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings
            Me.pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = False
            Me.pivotGridControl.OptionsChartDataSource.UpdateDelay = 500
            Me.pivotGridControl.Size = New System.Drawing.Size(690, 214)
            Me.pivotGridControl.TabIndex = 2
            '
            'fieldProductName
            '
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 0
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Width = 155
            '
            'fieldExtendedPrice
            '
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.FieldName = "Extended Price"
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            '
            'fieldOrderDate
            '
            Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate.AreaIndex = 0
            Me.fieldOrderDate.Caption = "Order Month"
            Me.fieldOrderDate.FieldName = "OrderDate"
            Me.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldOrderDate.Name = "fieldOrderDate"
            Me.fieldOrderDate.UnboundFieldName = "fieldOrderDate"
            '
            'fieldOrderYear
            '
            Me.fieldOrderYear.AreaIndex = 0
            Me.fieldOrderYear.Caption = "Order Year"
            Me.fieldOrderYear.FieldName = "OrderDate"
            Me.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderYear.Name = "fieldOrderYear"
            Me.fieldOrderYear.Options.IsFilterRadioMode = DevExpress.Utils.DefaultBoolean.[True]
            Me.fieldOrderYear.UnboundFieldName = "pivotGridField1"
            '
            'chartControl
            '
            Me.chartControl.Cursor = System.Windows.Forms.Cursors.Default
            XyDiagram1.AxisX.Label.Staggered = True
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
            Me.chartControl.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:c}"
            PointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl.SeriesTemplate.Label = PointSeriesLabel1
            Me.chartControl.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.chartControl.SeriesTemplate.View = LineSeriesView1
            Me.chartControl.Size = New System.Drawing.Size(690, 176)
            Me.chartControl.TabIndex = 3
            '
            'ChartGeneralOptions
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.paddingPanel)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "ChartGeneralOptions"
            Me.Size = New System.Drawing.Size(690, 470)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.seUpdateDelay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowRowGrandTotals.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowColumnGrandTotals.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceSelectionOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceChartDataVertical.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkShowPointLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboChartType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private WithEvents comboChartType As DevExpress.XtraEditors.ComboBoxEdit
        Private WithEvents checkShowPointLabels As DevExpress.XtraEditors.CheckEdit
        Private paddingPanel As DevExpress.XtraEditors.PanelControl
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private pivotGridControl As PivotGridControl
        Private fieldProductName As PivotGridField
        Private fieldExtendedPrice As PivotGridField
        Private fieldOrderMonth As PivotGridField
        Private chartControl As DevExpress.XtraCharts.ChartControl
        Private WithEvents ceSelectionOnly As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceChartDataVertical As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceShowRowGrandTotals As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceShowColumnGrandTotals As DevExpress.XtraEditors.CheckEdit
        Private lblUpdateDelay As DevExpress.XtraEditors.LabelControl
        Private WithEvents seUpdateDelay As DevExpress.XtraEditors.SpinEdit
        Private WithEvents fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
        Private WithEvents fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

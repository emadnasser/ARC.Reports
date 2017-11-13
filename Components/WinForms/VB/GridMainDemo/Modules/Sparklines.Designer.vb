Namespace DevExpress.XtraGrid.Demos
	Partial Public Class Sparklines
		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sparklines))
            Dim LineSparklineView1 As DevExpress.Sparkline.LineSparklineView = New DevExpress.Sparkline.LineSparklineView()
            Me.dsContacts1 = New dsContacts()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomerName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colYear = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRowSum = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRowAvr = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.Payments = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSparklineEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSparklineEdit()
            Me.xtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
            Me.ceColor = New DevExpress.XtraEditors.ColorPickEdit()
            Me.ceMax = New DevExpress.XtraEditors.ColorPickEdit()
            Me.ceEnd = New DevExpress.XtraEditors.ColorPickEdit()
            Me.ceMin = New DevExpress.XtraEditors.ColorPickEdit()
            Me.ceStart = New DevExpress.XtraEditors.ColorPickEdit()
            Me.cheHighlightEndPoint = New DevExpress.XtraEditors.CheckEdit()
            Me.cheHighlightStartPoint = New DevExpress.XtraEditors.CheckEdit()
            Me.cheHighlightMinPoint = New DevExpress.XtraEditors.CheckEdit()
            Me.cheHighlightMaxPoint = New DevExpress.XtraEditors.CheckEdit()
            Me.cbeView = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.lblView = New System.Windows.Forms.Label()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelView = New System.Windows.Forms.Label()
            Me.panel1 = New DevExpress.XtraEditors.PanelControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.dsContacts1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSparklineEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraScrollableControl1.SuspendLayout()
            CType(Me.ceColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cheHighlightEndPoint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cheHighlightStartPoint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cheHighlightMinPoint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cheHighlightMaxPoint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbeView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dsContacts1
            '
            Me.dsContacts1.DataSetName = "dsContacts"
            Me.dsContacts1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsContacts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'gridControl
            '
            Me.gridControl.DataSource = Me.dsContacts1.CustomersPayment
            resources.ApplyResources(Me.gridControl, "gridControl")
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSparklineEdit1})
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCustomerName, Me.colYear, Me.colRowSum, Me.colRowAvr, Me.Payments})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.GroupCount = 1
            Me.gridView.HorzScrollStep = 25
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView.OptionsPrint.AutoWidth = False
            Me.gridView.OptionsView.ColumnAutoWidth = False
            Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colYear, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'colID
            '
            resources.ApplyResources(Me.colID, "colID")
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.OptionsColumn.AllowEdit = False
            '
            'colCustomerName
            '
            resources.ApplyResources(Me.colCustomerName, "colCustomerName")
            Me.colCustomerName.FieldName = "Customer Name"
            Me.colCustomerName.Name = "colCustomerName"
            Me.colCustomerName.OptionsColumn.AllowEdit = False
            Me.colCustomerName.OptionsColumn.AllowFocus = False
            Me.colCustomerName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            Me.colCustomerName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("colCustomerName.Summary"), DevExpress.Data.SummaryItemType))})
            '
            'colYear
            '
            Me.colYear.AppearanceCell.BackColor = CType(resources.GetObject("colYear.AppearanceCell.BackColor"), System.Drawing.Color)
            Me.colYear.AppearanceCell.Font = CType(resources.GetObject("colYear.AppearanceCell.Font"), System.Drawing.Font)
            Me.colYear.AppearanceCell.ForeColor = CType(resources.GetObject("colYear.AppearanceCell.ForeColor"), System.Drawing.Color)
            Me.colYear.AppearanceCell.Options.UseBackColor = True
            Me.colYear.AppearanceCell.Options.UseFont = True
            Me.colYear.AppearanceCell.Options.UseForeColor = True
            resources.ApplyResources(Me.colYear, "colYear")
            Me.colYear.FieldName = "Year"
            Me.colYear.Name = "colYear"
            Me.colYear.OptionsColumn.AllowEdit = False
            Me.colYear.OptionsColumn.AllowFocus = False
            Me.colYear.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colYear.OptionsColumn.AllowMove = False
            Me.colYear.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            '
            'colRowSum
            '
            resources.ApplyResources(Me.colRowSum, "colRowSum")
            Me.colRowSum.DisplayFormat.FormatString = "c"
            Me.colRowSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRowSum.FieldName = "RowSum"
            Me.colRowSum.Name = "colRowSum"
            Me.colRowSum.OptionsColumn.AllowEdit = False
            Me.colRowSum.OptionsColumn.AllowFocus = False
            Me.colRowSum.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("colRowSum.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("colRowSum.Summary1"), resources.GetString("colRowSum.Summary2"))})
            '
            'colRowAvr
            '
            resources.ApplyResources(Me.colRowAvr, "colRowAvr")
            Me.colRowAvr.DisplayFormat.FormatString = "c"
            Me.colRowAvr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRowAvr.FieldName = "RowAvr"
            Me.colRowAvr.Name = "colRowAvr"
            Me.colRowAvr.OptionsColumn.AllowEdit = False
            Me.colRowAvr.OptionsColumn.AllowFocus = False
            Me.colRowAvr.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("colRowAvr.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("colRowAvr.Summary1"), resources.GetString("colRowAvr.Summary2"))})
            '
            'Payments
            '
            resources.ApplyResources(Me.Payments, "Payments")
            Me.Payments.ColumnEdit = Me.repositoryItemSparklineEdit1
            Me.Payments.FieldName = "colSparkline"
            Me.Payments.Image = CType(resources.GetObject("Payments.Image"), System.Drawing.Image)
            Me.Payments.MaxWidth = 300
            Me.Payments.MinWidth = 50
            Me.Payments.Name = "Payments"
            Me.Payments.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
            '
            'repositoryItemSparklineEdit1
            '
            Me.repositoryItemSparklineEdit1.Name = "repositoryItemSparklineEdit1"
            LineSparklineView1.HighlightMaxPoint = True
            LineSparklineView1.HighlightMinPoint = True
            Me.repositoryItemSparklineEdit1.View = LineSparklineView1
            '
            'xtraScrollableControl1
            '
            resources.ApplyResources(Me.xtraScrollableControl1, "xtraScrollableControl1")
            Me.xtraScrollableControl1.Controls.Add(Me.ceColor)
            Me.xtraScrollableControl1.Controls.Add(Me.ceMax)
            Me.xtraScrollableControl1.Controls.Add(Me.ceEnd)
            Me.xtraScrollableControl1.Controls.Add(Me.ceMin)
            Me.xtraScrollableControl1.Controls.Add(Me.ceStart)
            Me.xtraScrollableControl1.Controls.Add(Me.cheHighlightEndPoint)
            Me.xtraScrollableControl1.Controls.Add(Me.cheHighlightStartPoint)
            Me.xtraScrollableControl1.Controls.Add(Me.cheHighlightMinPoint)
            Me.xtraScrollableControl1.Controls.Add(Me.cheHighlightMaxPoint)
            Me.xtraScrollableControl1.Controls.Add(Me.cbeView)
            Me.xtraScrollableControl1.Controls.Add(Me.lblView)
            Me.xtraScrollableControl1.Name = "xtraScrollableControl1"
            '
            'ceColor
            '
            resources.ApplyResources(Me.ceColor, "ceColor")
            Me.ceColor.Name = "ceColor"
            Me.ceColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ceColor.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            '
            'ceMax
            '
            resources.ApplyResources(Me.ceMax, "ceMax")
            Me.ceMax.Name = "ceMax"
            Me.ceMax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ceMax.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            '
            'ceEnd
            '
            resources.ApplyResources(Me.ceEnd, "ceEnd")
            Me.ceEnd.Name = "ceEnd"
            Me.ceEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ceEnd.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            '
            'ceMin
            '
            resources.ApplyResources(Me.ceMin, "ceMin")
            Me.ceMin.Name = "ceMin"
            Me.ceMin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ceMin.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            '
            'ceStart
            '
            resources.ApplyResources(Me.ceStart, "ceStart")
            Me.ceStart.Name = "ceStart"
            Me.ceStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ceStart.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            '
            'cheHighlightEndPoint
            '
            resources.ApplyResources(Me.cheHighlightEndPoint, "cheHighlightEndPoint")
            Me.cheHighlightEndPoint.Name = "cheHighlightEndPoint"
            Me.cheHighlightEndPoint.Properties.AutoWidth = True
            Me.cheHighlightEndPoint.Properties.Caption = resources.GetString("cheHighlightEndPoint.Properties.Caption")
            '
            'cheHighlightStartPoint
            '
            resources.ApplyResources(Me.cheHighlightStartPoint, "cheHighlightStartPoint")
            Me.cheHighlightStartPoint.Name = "cheHighlightStartPoint"
            Me.cheHighlightStartPoint.Properties.AutoWidth = True
            Me.cheHighlightStartPoint.Properties.Caption = resources.GetString("cheHighlightStartPoint.Properties.Caption")
            '
            'cheHighlightMinPoint
            '
            resources.ApplyResources(Me.cheHighlightMinPoint, "cheHighlightMinPoint")
            Me.cheHighlightMinPoint.Name = "cheHighlightMinPoint"
            Me.cheHighlightMinPoint.Properties.AutoWidth = True
            Me.cheHighlightMinPoint.Properties.Caption = resources.GetString("cheHighlightMinPoint.Properties.Caption")
            '
            'cheHighlightMaxPoint
            '
            resources.ApplyResources(Me.cheHighlightMaxPoint, "cheHighlightMaxPoint")
            Me.cheHighlightMaxPoint.Name = "cheHighlightMaxPoint"
            Me.cheHighlightMaxPoint.Properties.AutoWidth = True
            Me.cheHighlightMaxPoint.Properties.Caption = resources.GetString("cheHighlightMaxPoint.Properties.Caption")
            '
            'cbeView
            '
            resources.ApplyResources(Me.cbeView, "cbeView")
            Me.cbeView.Name = "cbeView"
            Me.cbeView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cbeView.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.cbeView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'lblView
            '
            resources.ApplyResources(Me.lblView, "lblView")
            Me.lblView.Name = "lblView"
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            '
            'labelView
            '
            resources.ApplyResources(Me.labelView, "labelView")
            Me.labelView.Name = "labelView"
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.xtraScrollableControl1)
            resources.ApplyResources(Me.panel1, "panel1")
            Me.panel1.Name = "panel1"
            '
            'panelControl2
            '
            Me.panelControl2.Controls.Add(Me.gridControl)
            resources.ApplyResources(Me.panelControl2, "panelControl2")
            Me.panelControl2.Name = "panelControl2"
            '
            'Sparklines
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Sparklines"
            CType(Me.dsContacts1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSparklineEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraScrollableControl1.ResumeLayout(False)
            Me.xtraScrollableControl1.PerformLayout()
            CType(Me.ceColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cheHighlightEndPoint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cheHighlightStartPoint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cheHighlightMinPoint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cheHighlightMaxPoint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbeView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

        Private dsContacts1 As dsContacts
		Private gridControl As GridControl
		Private repositoryItemSparklineEdit1 As XtraEditors.Repository.RepositoryItemSparklineEdit
		Private WithEvents gridView As Views.Grid.GridView
		Private colID As Columns.GridColumn
		Private colCustomerName As Columns.GridColumn
		Private colYear As Columns.GridColumn
		Private Payments As Columns.GridColumn
		Private colRowSum As Columns.GridColumn
		Private colRowAvr As Columns.GridColumn
		Private xtraScrollableControl1 As XtraEditors.XtraScrollableControl
		Private lblView As System.Windows.Forms.Label
		Private panelControl1 As XtraEditors.PanelControl
		Private WithEvents cbeView As XtraEditors.ComboBoxEdit
		Private labelView As System.Windows.Forms.Label
		Private WithEvents cheHighlightEndPoint As XtraEditors.CheckEdit
		Private WithEvents cheHighlightStartPoint As XtraEditors.CheckEdit
		Private WithEvents cheHighlightMinPoint As XtraEditors.CheckEdit
		Private WithEvents cheHighlightMaxPoint As XtraEditors.CheckEdit
		Private panel1 As XtraEditors.PanelControl
		Private panelControl2 As XtraEditors.PanelControl
		Private WithEvents ceMax As XtraEditors.ColorPickEdit
		Private WithEvents ceEnd As XtraEditors.ColorPickEdit
		Private WithEvents ceMin As XtraEditors.ColorPickEdit
		Private WithEvents ceStart As XtraEditors.ColorPickEdit
		Private WithEvents ceColor As XtraEditors.ColorPickEdit
    End Class
End Namespace

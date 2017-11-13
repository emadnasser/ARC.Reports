Namespace DevExpress.XtraGrid.Demos
    Partial Public Class Grid100000Records
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Grid100000Records))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colclnId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colclnText = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colclnDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colclnCurrency = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colclnBool = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridControl1.DataSource = Me.bindingSource1
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataSource = GetType(DevExpress.XtraGrid.Demos.Grid100000Records.Record)
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colclnId, Me.colclnText, Me.colclnDate, Me.colclnCurrency, Me.colclnBool})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {
                New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView1.GroupSummary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView1.GroupSummary1"), (CType(resources.GetObject("gridView1.GroupSummary2"), DevExpress.XtraGrid.Columns.GridColumn)), resources.GetString("gridView1.GroupSummary3")),
                New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView1.GroupSummary4"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView1.GroupSummary5"), (CType(resources.GetObject("gridView1.GroupSummary6"), DevExpress.XtraGrid.Columns.GridColumn)), resources.GetString("gridView1.GroupSummary7"))
            })
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
            Me.gridView1.OptionsView.BestFitMaxRowCount = 20
            Me.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard
            Me.gridView1.OptionsView.ShowFooter = True
            ' 
            ' colclnId
            ' 
            resources.ApplyResources(Me.colclnId, "colclnId")
            Me.colclnId.FieldName = "Id"
            Me.colclnId.Name = "colclnId"
            Me.colclnId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            Me.colclnId.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem((CType(resources.GetObject("colclnId.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("colclnId.Summary1"), resources.GetString("colclnId.Summary2"))})
            ' 
            ' colclnText
            ' 
            resources.ApplyResources(Me.colclnText, "colclnText")
            Me.colclnText.FieldName = "Text"
            Me.colclnText.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
            Me.colclnText.Name = "colclnText"
            ' 
            ' colclnDate
            ' 
            resources.ApplyResources(Me.colclnDate, "colclnDate")
            Me.colclnDate.FieldName = "Date"
            Me.colclnDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
            Me.colclnDate.Name = "colclnDate"
            ' 
            ' colclnCurrency
            ' 
            resources.ApplyResources(Me.colclnCurrency, "colclnCurrency")
            Me.colclnCurrency.DisplayFormat.FormatString = "c"
            Me.colclnCurrency.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colclnCurrency.FieldName = "Currency"
            Me.colclnCurrency.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
            Me.colclnCurrency.Name = "colclnCurrency"
            Me.colclnCurrency.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            Me.colclnCurrency.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem((CType(resources.GetObject("colclnCurrency.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("colclnCurrency.Summary1"), resources.GetString("colclnCurrency.Summary2"))})
            ' 
            ' colclnBool
            ' 
            resources.ApplyResources(Me.colclnBool, "colclnBool")
            Me.colclnBool.FieldName = "Bool"
            Me.colclnBool.Name = "colclnBool"
            ' 
            ' Grid100000Records
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Grid100000Records"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colclnId As DevExpress.XtraGrid.Columns.GridColumn
        Private colclnText As DevExpress.XtraGrid.Columns.GridColumn
        Private colclnDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colclnCurrency As DevExpress.XtraGrid.Columns.GridColumn
        Private colclnBool As DevExpress.XtraGrid.Columns.GridColumn
        Private components As System.ComponentModel.IContainer = Nothing
        Private bindingSource1 As System.Windows.Forms.BindingSource
    End Class
End Namespace

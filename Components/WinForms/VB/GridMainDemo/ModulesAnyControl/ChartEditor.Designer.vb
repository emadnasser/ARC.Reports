Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ChartEditor
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

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim simpleDiagram1 As New DevExpress.XtraCharts.SimpleDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
            Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
            Dim pieSeriesView2 As New DevExpress.XtraCharts.PieSeriesView()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbChartType = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colChart = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colFirstName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colHireDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colBirthDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colHomePhone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.icbChartType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.icbChartType)
            Me.layoutControl1.Controls.Add(Me.chartControl1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(678, 403, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(938, 611)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' icbChartType
            ' 
            Me.icbChartType.Location = New System.Drawing.Point(70, 0)
            Me.icbChartType.Name = "icbChartType"
            Me.icbChartType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbChartType.Size = New System.Drawing.Size(103, 20)
            Me.icbChartType.StyleController = Me.layoutControl1
            Me.icbChartType.TabIndex = 6
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False
            simpleDiagram1.EqualPieSize = False
            Me.chartControl1.Diagram = simpleDiagram1
            Me.chartControl1.Location = New System.Drawing.Point(70, 498)
            Me.chartControl1.Name = "chartControl1"
            pieSeriesLabel1.TextPattern = "{VP:P2}"
            series1.Label = pieSeriesLabel1
            series1.LegendTextPattern = "{A}"
            series1.Name = "Quantity"
            pieSeriesView1.RuntimeExploding = False
            pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise
            series1.View = pieSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartControl1.SeriesTemplate.LegendTextPattern = "{A}"
            pieSeriesView2.RuntimeExploding = False
            pieSeriesView2.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise
            Me.chartControl1.SeriesTemplate.View = pieSeriesView2
            Me.chartControl1.Size = New System.Drawing.Size(318, 111)
            Me.chartControl1.TabIndex = 5
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridControl1.Location = New System.Drawing.Point(0, 32)
            Me.gridControl1.MainView = Me.advBandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1, Me.repositoryItemTextEdit2, Me.repositoryItemMemoEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(938, 464)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.advBandedGridView1})
            ' 
            ' advBandedGridView1
            ' 
            Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand2, Me.gridBand3, Me.gridBand1})
            Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colBirthDate, Me.colFirstName, Me.colHireDate, Me.colHomePhone, Me.colLastName, Me.colNotes, Me.colPhoto, Me.colTitle, Me.colTitleOfCourtesy, Me.colChart})
            Me.advBandedGridView1.GridControl = Me.gridControl1
            Me.advBandedGridView1.Name = "advBandedGridView1"
            Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
            Me.advBandedGridView1.OptionsView.ShowColumnHeaders = False
            Me.advBandedGridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' gridBand2
            ' 
            Me.gridBand2.Caption = "Salesperson"
            Me.gridBand2.Columns.Add(Me.colPhoto)
            Me.gridBand2.Name = "gridBand2"
            Me.gridBand2.VisibleIndex = 0
            Me.gridBand2.Width = 126
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.Caption = "Salesperson"
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsColumn.AllowFocus = False
            Me.colPhoto.OptionsColumn.FixedWidth = True
            Me.colPhoto.OptionsFilter.AllowFilter = False
            Me.colPhoto.RowCount = 8
            Me.colPhoto.Visible = True
            Me.colPhoto.Width = 126
            ' 
            ' gridBand3
            ' 
            Me.gridBand3.Caption = "Sales % by Product Category"
            Me.gridBand3.Columns.Add(Me.colChart)
            Me.gridBand3.Name = "gridBand3"
            Me.gridBand3.VisibleIndex = 1
            Me.gridBand3.Width = 403
            ' 
            ' colChart
            ' 
            Me.colChart.Caption = "Sales by Product Category"
            Me.colChart.FieldName = "colChart"
            Me.colChart.Name = "colChart"
            Me.colChart.OptionsColumn.AllowFocus = False
            Me.colChart.RowCount = 8
            Me.colChart.UnboundType = DevExpress.Data.UnboundColumnType.Object
            Me.colChart.Visible = True
            Me.colChart.Width = 403
            ' 
            ' gridBand1
            ' 
            Me.gridBand1.Caption = "Contact Information"
            Me.gridBand1.Columns.Add(Me.colFirstName)
            Me.gridBand1.Columns.Add(Me.colLastName)
            Me.gridBand1.Columns.Add(Me.colTitle)
            Me.gridBand1.Columns.Add(Me.colTitleOfCourtesy)
            Me.gridBand1.Columns.Add(Me.colHireDate)
            Me.gridBand1.Columns.Add(Me.colBirthDate)
            Me.gridBand1.Columns.Add(Me.colHomePhone)
            Me.gridBand1.Columns.Add(Me.colNotes)
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.VisibleIndex = 2
            Me.gridBand1.Width = 409
            ' 
            ' colFirstName
            ' 
            Me.colFirstName.Caption = "First Name"
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.OptionsColumn.AllowFocus = False
            Me.colFirstName.Visible = True
            Me.colFirstName.Width = 111
            ' 
            ' colLastName
            ' 
            Me.colLastName.Caption = "Last Name"
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            Me.colLastName.OptionsColumn.AllowFocus = False
            Me.colLastName.Visible = True
            Me.colLastName.Width = 118
            ' 
            ' colTitle
            ' 
            Me.colTitle.Caption = "Title"
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            Me.colTitle.OptionsColumn.AllowFocus = False
            Me.colTitle.Visible = True
            Me.colTitle.Width = 180
            ' 
            ' colTitleOfCourtesy
            ' 
            Me.colTitleOfCourtesy.Caption = "Title Of Courtesy"
            Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
            Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
            Me.colTitleOfCourtesy.OptionsColumn.AllowFocus = False
            Me.colTitleOfCourtesy.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            Me.colTitleOfCourtesy.Width = 154
            ' 
            ' colHireDate
            ' 
            Me.colHireDate.Caption = "Hire Date"
            Me.colHireDate.FieldName = "HireDate"
            Me.colHireDate.Name = "colHireDate"
            Me.colHireDate.OptionsColumn.AllowFocus = False
            Me.colHireDate.RowIndex = 1
            Me.colHireDate.Visible = True
            Me.colHireDate.Width = 409
            ' 
            ' colBirthDate
            ' 
            Me.colBirthDate.Caption = "Birth Date"
            Me.colBirthDate.FieldName = "BirthDate"
            Me.colBirthDate.Name = "colBirthDate"
            Me.colBirthDate.OptionsColumn.AllowFocus = False
            Me.colBirthDate.RowIndex = 1
            Me.colBirthDate.Width = 483
            ' 
            ' colHomePhone
            ' 
            Me.colHomePhone.Caption = "Home Phone"
            Me.colHomePhone.FieldName = "HomePhone"
            Me.colHomePhone.Name = "colHomePhone"
            Me.colHomePhone.OptionsColumn.AllowFocus = False
            Me.colHomePhone.RowIndex = 2
            Me.colHomePhone.Visible = True
            Me.colHomePhone.Width = 409
            ' 
            ' colNotes
            ' 
            Me.colNotes.AppearanceCell.Options.UseTextOptions = True
            Me.colNotes.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.colNotes.Caption = "Notes"
            Me.colNotes.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.OptionsColumn.AllowFocus = False
            Me.colNotes.OptionsFilter.AllowFilter = False
            Me.colNotes.RowCount = 5
            Me.colNotes.RowIndex = 3
            Me.colNotes.Visible = True
            Me.colNotes.Width = 409
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.DisplayFormat.FormatString = "{0:n} Sq Ft"
            Me.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.repositoryItemTextEdit1.Mask.EditMask = "n"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' repositoryItemTextEdit2
            ' 
            Me.repositoryItemTextEdit2.AutoHeight = False
            Me.repositoryItemTextEdit2.Mask.EditMask = "c"
            Me.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.emptySpaceItem1, Me.simpleSeparator1, Me.emptySpaceItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(938, 611)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 32)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(938, 464)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.chartControl1
            Me.layoutControlItem2.CustomizationFormText = "Chart Control"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 496)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(390, 115)
            Me.layoutControlItem2.Text = "Chart Control"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(65, 13)
            Me.layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.icbChartType
            Me.layoutControlItem3.CustomizationFormText = "Chart Type"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 10)
            Me.layoutControlItem3.Size = New System.Drawing.Size(175, 30)
            Me.layoutControlItem3.Text = "Chart Type"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(175, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(763, 30)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' simpleSeparator1
            ' 
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
            Me.simpleSeparator1.Location = New System.Drawing.Point(0, 30)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Size = New System.Drawing.Size(938, 2)
            Me.simpleSeparator1.Text = "simpleSeparator1"
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(390, 496)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(548, 115)
            Me.emptySpaceItem2.Text = "emptySpaceItem2"
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.emptySpaceItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' ChartEditor
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ChartEditor"
            Me.Size = New System.Drawing.Size(938, 611)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.icbChartType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private gridControl1 As GridControl
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private repositoryItemTextEdit1 As XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemTextEdit2 As XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemMemoEdit1 As XtraEditors.Repository.RepositoryItemMemoEdit
        Private chartControl1 As XtraCharts.ChartControl
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private WithEvents icbChartType As XtraEditors.ImageComboBoxEdit
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private simpleSeparator1 As XtraLayout.SimpleSeparator
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private WithEvents advBandedGridView1 As Views.BandedGrid.AdvBandedGridView
        Private gridBand1 As Views.BandedGrid.GridBand
        Private colFirstName As Views.BandedGrid.BandedGridColumn
        Private colLastName As Views.BandedGrid.BandedGridColumn
        Private colTitle As Views.BandedGrid.BandedGridColumn
        Private colTitleOfCourtesy As Views.BandedGrid.BandedGridColumn
        Private colHireDate As Views.BandedGrid.BandedGridColumn
        Private colBirthDate As Views.BandedGrid.BandedGridColumn
        Private colHomePhone As Views.BandedGrid.BandedGridColumn
        Private colNotes As Views.BandedGrid.BandedGridColumn
        Private gridBand2 As Views.BandedGrid.GridBand
        Private colPhoto As Views.BandedGrid.BandedGridColumn
        Private gridBand3 As Views.BandedGrid.GridBand
        Private colChart As Views.BandedGrid.BandedGridColumn
    End Class
End Namespace

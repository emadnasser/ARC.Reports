Namespace DevExpress.XtraGauges.Demos
    Partial Class Databinding

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.CircularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
            Me.ArcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.ArcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.ArcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.dsCategories = New dsCategories
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.DigitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
            Me.gaugeControl3 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.CircularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
            Me.ArcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.ArcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.ArcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            CType(Me.CircularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dsCategories, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CircularGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gaugeControl1
            '
            Me.gaugeControl1.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.CircularGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(359, 246)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.ShowToolTips = True
            Me.gaugeControl1.Size = New System.Drawing.Size(206, 185)
            Me.gaugeControl1.TabIndex = 1
            '
            'CircularGauge1
            '
            Me.CircularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent1})
            Me.CircularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 194, 173)
            Me.CircularGauge1.Name = "cGauge1"
            Me.CircularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent1})
            Me.CircularGauge1.OptionsToolTip.TooltipTitle = "UnitsOnOrder"
            Me.CircularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent1})
            '
            'ArcScaleBackgroundLayerComponent1
            '
            Me.ArcScaleBackgroundLayerComponent1.ArcScale = Me.ArcScaleComponent1
            Me.ArcScaleBackgroundLayerComponent1.Name = "bg"
            Me.ArcScaleBackgroundLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 0.619!)
            Me.ArcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style1
            Me.ArcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(250.0!, 202.0!)
            Me.ArcScaleBackgroundLayerComponent1.ZOrder = 1000
            '
            'ArcScaleComponent1
            '
            Me.ArcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 11.0!)
            Me.ArcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.ArcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 140.0!)
            Me.ArcScaleComponent1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.productsBindingSource, "UnitsOnOrder", True, System.Windows.Forms.DataSourceUpdateMode.Never))
            Me.ArcScaleComponent1.EndAngle = 30.0!
            Me.ArcScaleComponent1.MajorTickCount = 9
            Me.ArcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.ArcScaleComponent1.MajorTickmark.ShapeOffset = -3.5!
            Me.ArcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
            Me.ArcScaleComponent1.MajorTickmark.TextOffset = -15.0!
            Me.ArcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.ArcScaleComponent1.MaxValue = 160.0!
            Me.ArcScaleComponent1.MinorTickCount = 4
            Me.ArcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
            Me.ArcScaleComponent1.Name = "scale1"
            Me.ArcScaleComponent1.StartAngle = -210.0!
            Me.ArcScaleComponent1.Value = 80.0!
            '
            'ArcScaleNeedleComponent1
            '
            Me.ArcScaleNeedleComponent1.ArcScale = Me.ArcScaleComponent1
            Me.ArcScaleNeedleComponent1.Name = "needle"
            Me.ArcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
            Me.ArcScaleNeedleComponent1.StartOffset = -4.5!
            Me.ArcScaleNeedleComponent1.ZOrder = -50
            '
            'productsBindingSource
            '
            Me.productsBindingSource.DataMember = "Products"
            Me.productsBindingSource.DataSource = Me.dsCategories
            '
            'dsCategories
            '
            Me.dsCategories.DataSetName = "dsCategories"
            Me.dsCategories.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'gridControl1
            '
            Me.gridControl1.DataSource = Me.productsBindingSource
            Me.gridControl1.Location = New System.Drawing.Point(2, 2)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(355, 427)
            Me.gridControl1.TabIndex = 2
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colDiscontinued})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            '
            'colProductName
            '
            Me.colProductName.Caption = "ProductName"
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            Me.colProductName.Width = 66
            '
            'colUnitPrice
            '
            Me.colUnitPrice.Caption = "UnitPrice"
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 1
            Me.colUnitPrice.Width = 50
            '
            'colUnitsInStock
            '
            Me.colUnitsInStock.Caption = "UnitsInStock"
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            Me.colUnitsInStock.Visible = True
            Me.colUnitsInStock.VisibleIndex = 3
            Me.colUnitsInStock.Width = 67
            '
            'colUnitsOnOrder
            '
            Me.colUnitsOnOrder.Caption = "UnitsOnOrder"
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            Me.colUnitsOnOrder.Visible = True
            Me.colUnitsOnOrder.VisibleIndex = 4
            Me.colUnitsOnOrder.Width = 80
            '
            'colDiscontinued
            '
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            Me.colDiscontinued.Visible = True
            Me.colDiscontinued.VisibleIndex = 2
            Me.colDiscontinued.Width = 71
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.gaugeControl2)
            Me.layoutControl1.Controls.Add(Me.gaugeControl3)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(565, 431)
            Me.layoutControl1.TabIndex = 3
            Me.layoutControl1.Text = "layoutControl1"
            '
            'gaugeControl2
            '
            Me.gaugeControl2.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge1})
            Me.gaugeControl2.Location = New System.Drawing.Point(361, 2)
            Me.gaugeControl2.Name = "gaugeControl2"
            Me.gaugeControl2.ShowToolTips = True
            Me.gaugeControl2.Size = New System.Drawing.Size(202, 74)
            Me.gaugeControl2.TabIndex = 0
            '
            'DigitalGauge1
            '
            Me.DigitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C8C8C8")
            Me.DigitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.DigitalGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 190, 62)
            Me.DigitalGauge1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.productsBindingSource, "ProductName", True, System.Windows.Forms.DataSourceUpdateMode.Never))
            Me.DigitalGauge1.DigitCount = 0
            Me.DigitalGauge1.Name = ""
            Me.DigitalGauge1.OptionsToolTip.TooltipTitle = "ProductName"
            Me.DigitalGauge1.Text = "00,000"
            '
            'gaugeControl3
            '
            Me.gaugeControl3.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl3.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.CircularGauge2})
            Me.gaugeControl3.Location = New System.Drawing.Point(359, 78)
            Me.gaugeControl3.Name = "gaugeControl3"
            Me.gaugeControl3.ShowToolTips = True
            Me.gaugeControl3.Size = New System.Drawing.Size(206, 168)
            Me.gaugeControl3.TabIndex = 5
            '
            'CircularGauge2
            '
            Me.CircularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent2})
            Me.CircularGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 194, 156)
            Me.CircularGauge2.Name = "cGauge1"
            Me.CircularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent2})
            Me.CircularGauge2.OptionsToolTip.TooltipTitle = "UnitsInStock"
            Me.CircularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent2})
            '
            'ArcScaleBackgroundLayerComponent2
            '
            Me.ArcScaleBackgroundLayerComponent2.ArcScale = Me.ArcScaleComponent2
            Me.ArcScaleBackgroundLayerComponent2.Name = "bg"
            Me.ArcScaleBackgroundLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 0.619!)
            Me.ArcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style1
            Me.ArcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(250.0!, 202.0!)
            Me.ArcScaleBackgroundLayerComponent2.ZOrder = 1000
            '
            'ArcScaleComponent2
            '
            Me.ArcScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 11.0!)
            Me.ArcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.ArcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 140.0!)
            Me.ArcScaleComponent2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.productsBindingSource, "UnitsInStock", True, System.Windows.Forms.DataSourceUpdateMode.Never))
            Me.ArcScaleComponent2.EndAngle = 30.0!
            Me.ArcScaleComponent2.MajorTickCount = 9
            Me.ArcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
            Me.ArcScaleComponent2.MajorTickmark.ShapeOffset = -3.5!
            Me.ArcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
            Me.ArcScaleComponent2.MajorTickmark.TextOffset = -15.0!
            Me.ArcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.ArcScaleComponent2.MaxValue = 160.0!
            Me.ArcScaleComponent2.MinorTickCount = 4
            Me.ArcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
            Me.ArcScaleComponent2.Name = "scale1"
            Me.ArcScaleComponent2.StartAngle = -210.0!
            Me.ArcScaleComponent2.Value = 80.0!
            '
            'ArcScaleNeedleComponent2
            '
            Me.ArcScaleNeedleComponent2.ArcScale = Me.ArcScaleComponent2
            Me.ArcScaleNeedleComponent2.Name = "needle"
            Me.ArcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
            Me.ArcScaleNeedleComponent2.StartOffset = -4.5!
            Me.ArcScaleNeedleComponent2.ZOrder = -50
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem4, Me.layoutControlItem1, Me.layoutControlItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(565, 431)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.gridControl1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(359, 431)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControlItem4.Control = Me.gaugeControl3
            Me.layoutControlItem4.CustomizationFormText = "UnitsInOrder"
            Me.layoutControlItem4.Location = New System.Drawing.Point(359, 78)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem4.Size = New System.Drawing.Size(206, 168)
            Me.layoutControlItem4.Text = "UnitsInOrder"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Bottom
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextToControlDistance = 0
            Me.layoutControlItem4.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControlItem1.Control = Me.gaugeControl1
            Me.layoutControlItem1.CustomizationFormText = "UnitsInStock"
            Me.layoutControlItem1.Location = New System.Drawing.Point(359, 246)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(206, 185)
            Me.layoutControlItem1.Text = "UnitsInStock"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Bottom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControlItem3.Control = Me.gaugeControl2
            Me.layoutControlItem3.CustomizationFormText = "ProductName"
            Me.layoutControlItem3.Location = New System.Drawing.Point(359, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(206, 78)
            Me.layoutControlItem3.Text = "ProductName"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Bottom
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            '
            'Databinding
            '
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Databinding"
            Me.Size = New System.Drawing.Size(565, 431)
            CType(Me.CircularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dsCategories, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CircularGauge2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn
        Private productsBindingSource As System.Windows.Forms.BindingSource
        Private dsCategories As dsCategories
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private gaugeControl3 As DevExpress.XtraGauges.Win.GaugeControl
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents CircularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private WithEvents ArcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private WithEvents ArcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private WithEvents ArcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Friend WithEvents DigitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
        Friend WithEvents CircularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private WithEvents ArcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private WithEvents ArcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private WithEvents ArcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Friend WithEvents colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

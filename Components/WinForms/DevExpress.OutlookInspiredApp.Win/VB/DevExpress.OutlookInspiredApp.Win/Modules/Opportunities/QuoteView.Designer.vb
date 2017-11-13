Namespace DevExpress.DevAV.Modules
    Partial Public Class QuoteView
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
            Dim funnelSeriesLabel1 As New DevExpress.XtraCharts.FunnelSeriesLabel()
            Dim funnelSeriesView1 As New DevExpress.XtraCharts.FunnelSeriesView()
            Dim funnelSeriesView2 As New DevExpress.XtraCharts.FunnelSeriesView()
            Me.modueLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForFunnel = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.modueLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.modueLayout.SuspendLayout()
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(funnelSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(funnelSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(funnelSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForFunnel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.modueLayout.AllowCustomization = False
            Me.modueLayout.Controls.Add(Me.chartControl)
            Me.modueLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.modueLayout.Location = New System.Drawing.Point(0, 0)
            Me.modueLayout.Margin = New System.Windows.Forms.Padding(2)
            Me.modueLayout.Name = "modueLayout"
            Me.modueLayout.Root = Me.Root
            Me.modueLayout.Size = New System.Drawing.Size(458, 572)
            Me.modueLayout.TabIndex = 0
            Me.chartControl.AccessibleName = ""
            Me.chartControl.AllowDrop = True
            simpleDiagram1.EqualPieSize = False
            Me.chartControl.Diagram = simpleDiagram1
            Me.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartControl.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chartControl.Legend.EnableAntialiasing = Utils.DefaultBoolean.True
            Me.chartControl.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartControl.Legend.Font = New System.Drawing.Font("Segoe UI", 8F)
            Me.chartControl.Legend.Margins.Bottom = 0
            Me.chartControl.Legend.Margins.Left = 0
            Me.chartControl.Legend.Margins.Right = 0
            Me.chartControl.Legend.Margins.Top = 0
            Me.chartControl.Legend.MarkerSize = New System.Drawing.Size(20, 20)
            Me.chartControl.Legend.Padding.Bottom = 0
            Me.chartControl.Legend.Padding.Left = 0
            Me.chartControl.Legend.Padding.Right = 0
            Me.chartControl.Legend.Padding.Top = 40
            Me.chartControl.Location = New System.Drawing.Point(0, 0)
            Me.chartControl.Name = "chartControl"
            Me.chartControl.Padding.Bottom = 40
            Me.chartControl.Padding.Left = 40
            Me.chartControl.Padding.Right = 40
            Me.chartControl.Padding.Top = 40
            Me.chartControl.PaletteName = "Opportunities Palette"
            Me.chartControl.PaletteRepository.Add("Opportunities Palette", New DevExpress.XtraCharts.Palette("Opportunities Palette", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {
                New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt((CByte(198)))), (CInt((CByte(108)))), (CInt((CByte(41))))), System.Drawing.Color.FromArgb((CInt((CByte(198)))), (CInt((CByte(108)))), (CInt((CByte(41)))))),
                New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt((CByte(79)))), (CInt((CByte(135)))), (CInt((CByte(184))))), System.Drawing.Color.FromArgb((CInt((CByte(79)))), (CInt((CByte(135)))), (CInt((CByte(184)))))),
                New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt((CByte(227)))), (CInt((CByte(170)))), (CInt((CByte(0))))), System.Drawing.Color.FromArgb((CInt((CByte(227)))), (CInt((CByte(170)))), (CInt((CByte(0)))))),
                New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt((CByte(135)))), (CInt((CByte(135)))), (CInt((CByte(135))))), System.Drawing.Color.FromArgb((CInt((CByte(135)))), (CInt((CByte(135)))), (CInt((CByte(135))))))
            }))
            funnelSeriesLabel1.EnableAntialiasing = Utils.DefaultBoolean.True
            funnelSeriesLabel1.BackColor = System.Drawing.Color.Transparent
            funnelSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
            funnelSeriesLabel1.Font = New System.Drawing.Font("Segoe UI", 10F)
            funnelSeriesLabel1.Position = DevExpress.XtraCharts.FunnelSeriesLabelPosition.Center
            funnelSeriesLabel1.TextColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
            funnelSeriesLabel1.TextPattern = "{V:c}"
            series1.Label = funnelSeriesLabel1
            series1.LegendTextPattern = "{A}"
            series1.Name = "Series 1"
            funnelSeriesView1.AlignToCenter = True
            series1.View = funnelSeriesView1
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl.SeriesTemplate.View = funnelSeriesView2
            Me.chartControl.Size = New System.Drawing.Size(458, 572)
            Me.chartControl.TabIndex = 6
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForFunnel})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.OptionsItemText.TextToControlDistance = 6
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(458, 572)
            Me.Root.Text = "Root"
            Me.ItemForFunnel.Control = Me.chartControl
            Me.ItemForFunnel.CustomizationFormText = "ItemForFunnel"
            Me.ItemForFunnel.Location = New System.Drawing.Point(0, 0)
            Me.ItemForFunnel.Name = "ItemForFunnel"
            Me.ItemForFunnel.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForFunnel.Size = New System.Drawing.Size(458, 572)
            Me.ItemForFunnel.Text = "ItemForFunnel"
            Me.ItemForFunnel.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForFunnel.TextToControlDistance = 0
            Me.ItemForFunnel.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.modueLayout)
            Me.Name = "QuoteView"
            Me.Size = New System.Drawing.Size(458, 572)
            CType(Me.modueLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.modueLayout.ResumeLayout(False)
            CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(funnelSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(funnelSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(funnelSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForFunnel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private modueLayout As DevExpress.XtraDataLayout.DataLayoutControl
        Private Root As XtraLayout.LayoutControlGroup
        Private chartControl As XtraCharts.ChartControl
        Private ItemForFunnel As XtraLayout.LayoutControlItem
    End Class
End Namespace

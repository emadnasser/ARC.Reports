Namespace DevExpress.XtraTreeList.Demos
    Partial Class FormatRules
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim TreeListFormatRule1 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim FormatConditionRuleIconSet1 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim FormatConditionIconSet1 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim FormatConditionIconSetIcon1 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim FormatConditionIconSetIcon2 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim FormatConditionIconSetIcon3 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim FormatConditionIconSetIcon4 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim FormatConditionIconSetIcon5 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim TreeListFormatRule2 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim FormatConditionRuleTopBottom1 As DevExpress.XtraEditors.FormatConditionRuleTopBottom = New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
            Dim TreeListFormatRule3 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim FormatConditionRuleTopBottom2 As DevExpress.XtraEditors.FormatConditionRuleTopBottom = New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
            Dim TreeListFormatRule4 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim FormatConditionRuleDataBar1 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim TreeListFormatRule5 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim TreeListFormatRule6 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim TreeListFormatRule7 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim FormatConditionRuleIconSet2 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim FormatConditionIconSet2 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim FormatConditionIconSetIcon6 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim FormatConditionIconSetIcon7 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim FormatConditionIconSetIcon8 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim TreeListFormatRule8 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim TreeListFormatRule9 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim TreeListFormatRule10 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim FormatConditionRuleDataBar2 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim TreeListFormatRule11 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim FormatConditionRuleDataBar3 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim TreeListFormatRule12 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim FormatConditionRuleContains1 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.treeListBand1 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.colRegion = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colMarchSales = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colSeptSales = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListBand2 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.colMarchSalesPrev = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colSeptSalesPrev = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListBand3 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.colMarketShare = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'treeList1
            '
            Me.treeList1.Bands.AddRange(New DevExpress.XtraTreeList.Columns.TreeListBand() {Me.treeListBand1, Me.treeListBand2, Me.treeListBand3})
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colRegion, Me.colMarchSales, Me.colSeptSales, Me.colMarchSalesPrev, Me.colSeptSalesPrev, Me.colMarketShare})
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            TreeListFormatRule1.Column = Me.colMarketShare
            TreeListFormatRule1.Name = "Market Share Icon Set"
            FormatConditionIconSet1.CategoryName = "Directional"
            FormatConditionIconSetIcon1.PredefinedName = "Arrows5_1.png"
            FormatConditionIconSetIcon1.Value = New Decimal(New Integer() {80, 0, 0, 0})
            FormatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSetIcon2.PredefinedName = "Arrows5_2.png"
            FormatConditionIconSetIcon2.Value = New Decimal(New Integer() {60, 0, 0, 0})
            FormatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSetIcon3.PredefinedName = "Arrows5_3.png"
            FormatConditionIconSetIcon3.Value = New Decimal(New Integer() {40, 0, 0, 0})
            FormatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSetIcon4.PredefinedName = "Arrows5_4.png"
            FormatConditionIconSetIcon4.Value = New Decimal(New Integer() {20, 0, 0, 0})
            FormatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSetIcon5.PredefinedName = "Arrows5_5.png"
            FormatConditionIconSetIcon5.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon1)
            FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon2)
            FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon3)
            FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon4)
            FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon5)
            FormatConditionIconSet1.Name = "Arrows5Colored"
            FormatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            FormatConditionRuleIconSet1.IconSet = FormatConditionIconSet1
            TreeListFormatRule1.Rule = FormatConditionRuleIconSet1
            TreeListFormatRule2.Column = Me.colMarketShare
            TreeListFormatRule2.Name = "Market Share Top"
            FormatConditionRuleTopBottom1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
            FormatConditionRuleTopBottom1.Appearance.ForeColor = System.Drawing.Color.Green
            FormatConditionRuleTopBottom1.Appearance.Options.UseFont = True
            FormatConditionRuleTopBottom1.Appearance.Options.UseForeColor = True
            FormatConditionRuleTopBottom1.Rank = New Decimal(New Integer() {20, 0, 0, 0})
            FormatConditionRuleTopBottom1.RankType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            TreeListFormatRule2.Rule = FormatConditionRuleTopBottom1
            TreeListFormatRule3.Column = Me.colMarketShare
            TreeListFormatRule3.Name = "Market Share Bottom"
            FormatConditionRuleTopBottom2.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
            FormatConditionRuleTopBottom2.Appearance.ForeColor = System.Drawing.Color.Red
            FormatConditionRuleTopBottom2.Appearance.Options.UseFont = True
            FormatConditionRuleTopBottom2.Appearance.Options.UseForeColor = True
            FormatConditionRuleTopBottom2.Rank = New Decimal(New Integer() {20, 0, 0, 0})
            FormatConditionRuleTopBottom2.RankType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            FormatConditionRuleTopBottom2.TopBottom = DevExpress.XtraEditors.FormatConditionTopBottomType.Bottom
            TreeListFormatRule3.Rule = FormatConditionRuleTopBottom2
            TreeListFormatRule4.Column = Me.colSeptSalesPrev
            TreeListFormatRule4.Name = "Change Sept DataBar"
            FormatConditionRuleDataBar1.Appearance.BackColor = System.Drawing.Color.SpringGreen
            FormatConditionRuleDataBar1.Appearance.BackColor2 = System.Drawing.Color.White
            FormatConditionRuleDataBar1.Appearance.BorderColor = System.Drawing.Color.SeaGreen
            FormatConditionRuleDataBar1.Appearance.Options.UseBackColor = True
            FormatConditionRuleDataBar1.Appearance.Options.UseBorderColor = True
            FormatConditionRuleDataBar1.AppearanceNegative.BackColor = System.Drawing.Color.White
            FormatConditionRuleDataBar1.AppearanceNegative.BackColor2 = System.Drawing.Color.LightCoral
            FormatConditionRuleDataBar1.AppearanceNegative.BorderColor = System.Drawing.Color.RosyBrown
            FormatConditionRuleDataBar1.AppearanceNegative.Options.UseBackColor = True
            FormatConditionRuleDataBar1.AppearanceNegative.Options.UseBorderColor = True
            FormatConditionRuleDataBar1.PredefinedName = Nothing
            TreeListFormatRule4.Rule = FormatConditionRuleDataBar1
            TreeListFormatRule5.Column = Me.colSeptSalesPrev
            TreeListFormatRule5.Name = "Change Sept Positive"
            FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Green
            FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
            FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater
            FormatConditionRuleValue1.Value1 = "0"
            TreeListFormatRule5.Rule = FormatConditionRuleValue1
            TreeListFormatRule6.Column = Me.colSeptSalesPrev
            TreeListFormatRule6.Name = "Change Sept Negative"
            FormatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.Red
            FormatConditionRuleValue2.Appearance.Options.UseForeColor = True
            FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Less
            FormatConditionRuleValue2.Value1 = "0"
            TreeListFormatRule6.Rule = FormatConditionRuleValue2
            TreeListFormatRule7.Column = Me.colMarchSalesPrev
            TreeListFormatRule7.Name = "Change March IconSet"
            FormatConditionIconSet2.CategoryName = "PositiveNegative"
            FormatConditionIconSetIcon6.PredefinedName = "Triangles3_3.png"
            FormatConditionIconSetIcon6.Value = New Decimal(New Integer() {-1, -1, -1, -2147483648})
            FormatConditionIconSetIcon6.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSetIcon7.PredefinedName = "Triangles3_2.png"
            FormatConditionIconSetIcon7.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSetIcon8.PredefinedName = "Triangles3_1.png"
            FormatConditionIconSet2.Icons.Add(FormatConditionIconSetIcon6)
            FormatConditionIconSet2.Icons.Add(FormatConditionIconSetIcon7)
            FormatConditionIconSet2.Icons.Add(FormatConditionIconSetIcon8)
            FormatConditionIconSet2.Name = "PositiveNegativeTriangles"
            FormatConditionIconSet2.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number
            FormatConditionRuleIconSet2.IconSet = FormatConditionIconSet2
            TreeListFormatRule7.Rule = FormatConditionRuleIconSet2
            TreeListFormatRule8.Column = Me.colMarchSalesPrev
            TreeListFormatRule8.Name = "Change March Positive"
            FormatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.Green
            FormatConditionRuleValue3.Appearance.Options.UseForeColor = True
            FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Greater
            FormatConditionRuleValue3.Value1 = "0"
            TreeListFormatRule8.Rule = FormatConditionRuleValue3
            TreeListFormatRule9.Column = Me.colMarchSalesPrev
            TreeListFormatRule9.Name = "Change March Negative"
            FormatConditionRuleValue4.Appearance.ForeColor = System.Drawing.Color.Red
            FormatConditionRuleValue4.Appearance.Options.UseForeColor = True
            FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Less
            FormatConditionRuleValue4.Value1 = "0"
            TreeListFormatRule9.Rule = FormatConditionRuleValue4
            TreeListFormatRule10.Column = Me.colSeptSales
            TreeListFormatRule10.Name = "Sales Sept DataBar"
            FormatConditionRuleDataBar2.MinimumType = DevExpress.XtraEditors.FormatConditionValueType.Number
            FormatConditionRuleDataBar2.PredefinedName = "Mint Gradient"
            TreeListFormatRule10.Rule = FormatConditionRuleDataBar2
            TreeListFormatRule11.Column = Me.colMarchSales
            TreeListFormatRule11.Name = "Sales March DataBar"
            FormatConditionRuleDataBar3.MinimumType = DevExpress.XtraEditors.FormatConditionValueType.Number
            FormatConditionRuleDataBar3.PredefinedName = "Green Gradient"
            TreeListFormatRule11.Rule = FormatConditionRuleDataBar3
            TreeListFormatRule12.ApplyToRow = True
            TreeListFormatRule12.Column = Me.colRegion
            TreeListFormatRule12.Name = "Region Name"
            FormatConditionRuleContains1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
            FormatConditionRuleContains1.Appearance.Options.UseFont = True
            FormatConditionRuleContains1.Values = New Object() {CType("Western Europe", Object), CType("Eastern Europe", Object), CType("North America", Object), CType("South America", Object), CType("Asia", Object)}
            TreeListFormatRule12.Rule = FormatConditionRuleContains1
            Me.treeList1.FormatRules.Add(TreeListFormatRule1)
            Me.treeList1.FormatRules.Add(TreeListFormatRule2)
            Me.treeList1.FormatRules.Add(TreeListFormatRule3)
            Me.treeList1.FormatRules.Add(TreeListFormatRule4)
            Me.treeList1.FormatRules.Add(TreeListFormatRule5)
            Me.treeList1.FormatRules.Add(TreeListFormatRule6)
            Me.treeList1.FormatRules.Add(TreeListFormatRule7)
            Me.treeList1.FormatRules.Add(TreeListFormatRule8)
            Me.treeList1.FormatRules.Add(TreeListFormatRule9)
            Me.treeList1.FormatRules.Add(TreeListFormatRule10)
            Me.treeList1.FormatRules.Add(TreeListFormatRule11)
            Me.treeList1.FormatRules.Add(TreeListFormatRule12)
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.OptionsMenu.ShowConditionalFormattingItem = True
            Me.treeList1.OptionsView.AllowHtmlDrawHeaders = True
            Me.treeList1.OptionsView.ShowBandsMode = Utils.DefaultBoolean.True
            Me.treeList1.ParentFieldName = "RegionID"
            Me.treeList1.Size = New System.Drawing.Size(784, 432)
            Me.treeList1.TabIndex = 14
            '
            'treeListBand1
            '
            Me.treeListBand1.Caption = "<b>Sales</b>"
            Me.treeListBand1.Columns.Add(Me.colRegion)
            Me.treeListBand1.Columns.Add(Me.colMarchSales)
            Me.treeListBand1.Columns.Add(Me.colSeptSales)
            Me.treeListBand1.Name = "treeListBand1"
            Me.treeListBand1.Width = 301
            '
            'colRegion
            '
            Me.colRegion.Caption = " Region"
            Me.colRegion.FieldName = "Region"
            Me.colRegion.Name = "colRegion"
            Me.colRegion.Visible = True
            Me.colRegion.VisibleIndex = 0
            Me.colRegion.Width = 101
            '
            'colMarchSales
            '
            Me.colMarchSales.Caption = "March"
            Me.colMarchSales.FieldName = "MarchSales"
            Me.colMarchSales.Name = "colMarchSales"
            Me.colMarchSales.Visible = True
            Me.colMarchSales.VisibleIndex = 1
            Me.colMarchSales.Width = 100
            '
            'colSeptSales
            '
            Me.colSeptSales.Caption = "September"
            Me.colSeptSales.FieldName = "SeptemberSales"
            Me.colSeptSales.Name = "colSeptSales"
            Me.colSeptSales.Visible = True
            Me.colSeptSales.VisibleIndex = 2
            Me.colSeptSales.Width = 100
            '
            'treeListBand2
            '
            Me.treeListBand2.Caption = "<b>Change From Prior Year</b>"
            Me.treeListBand2.Columns.Add(Me.colMarchSalesPrev)
            Me.treeListBand2.Columns.Add(Me.colSeptSalesPrev)
            Me.treeListBand2.Name = "treeListBand2"
            Me.treeListBand2.Width = 310
            '
            'colMarchSalesPrev
            '
            Me.colMarchSalesPrev.Caption = "March"
            Me.colMarchSalesPrev.FieldName = "March From Prior Year"
            Me.colMarchSalesPrev.Format.FormatString = "p"
            Me.colMarchSalesPrev.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colMarchSalesPrev.Name = "colMarchSalesPrev"
            Me.colMarchSalesPrev.UnboundExpression = "([MarchSales] - [MarchSalesPrev]) / [MarchSales] "
            Me.colMarchSalesPrev.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.[Decimal]
            Me.colMarchSalesPrev.Visible = True
            Me.colMarchSalesPrev.VisibleIndex = 3
            Me.colMarchSalesPrev.Width = 155
            '
            'colSeptSalesPrev
            '
            Me.colSeptSalesPrev.Caption = "September"
            Me.colSeptSalesPrev.FieldName = "September From Prior Year"
            Me.colSeptSalesPrev.Format.FormatString = "p"
            Me.colSeptSalesPrev.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSeptSalesPrev.Name = "colSeptSalesPrev"
            Me.colSeptSalesPrev.UnboundExpression = "([SeptemberSales] - [SeptemberSalesPrev]) / [SeptemberSales] "
            Me.colSeptSalesPrev.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.[Decimal]
            Me.colSeptSalesPrev.Visible = True
            Me.colSeptSalesPrev.VisibleIndex = 4
            Me.colSeptSalesPrev.Width = 155
            '
            'treeListBand3
            '
            Me.treeListBand3.Caption = "<b>Current Market Share </b>"
            Me.treeListBand3.Columns.Add(Me.colMarketShare)
            Me.treeListBand3.Name = "treeListBand3"
            Me.treeListBand3.Width = 155
            '
            'colMarketShare
            '
            Me.colMarketShare.Caption = "Market Share"
            Me.colMarketShare.FieldName = "MarketShare"
            Me.colMarketShare.Format.FormatString = "p0"
            Me.colMarketShare.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colMarketShare.Name = "colMarketShare"
            Me.colMarketShare.Visible = True
            Me.colMarketShare.VisibleIndex = 5
            Me.colMarketShare.Width = 155
            '
            'FormatRules
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Name = "FormatRules"
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
        Private WithEvents treeListBand1 As DevExpress.XtraTreeList.Columns.TreeListBand
        Private WithEvents colRegion As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents colMarchSales As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents colSeptSales As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListBand2 As DevExpress.XtraTreeList.Columns.TreeListBand
        Private WithEvents colMarchSalesPrev As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents colSeptSalesPrev As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListBand3 As DevExpress.XtraTreeList.Columns.TreeListBand
        Private WithEvents colMarketShare As DevExpress.XtraTreeList.Columns.TreeListColumn

    End Class
End Namespace

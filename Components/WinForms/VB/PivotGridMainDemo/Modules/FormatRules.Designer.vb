Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class FormatRules
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
  Dim PivotGridFormatRule1 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
  Dim FormatConditionRuleDataBar1 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
  Dim FormatRuleFieldIntersectionSettings1 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
  Dim PivotGridFormatRule2 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
  Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
  Dim FormatRuleTotalTypeSettings1 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
  Dim PivotGridFormatRule3 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
  Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
  Dim FormatRuleFieldIntersectionSettings2 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
  Dim PivotGridFormatRule4 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
  Dim FormatConditionRuleIconSet1 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
  Dim FormatConditionIconSet1 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
  Dim FormatConditionIconSetIcon1 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
  Dim FormatConditionIconSetIcon2 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
  Dim FormatRuleFieldIntersectionSettings3 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
  Dim PivotGridFormatRule5 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
  Dim FormatConditionRuleIconSet2 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
  Dim FormatConditionIconSet2 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
  Dim FormatConditionIconSetIcon3 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
  Dim FormatConditionIconSetIcon4 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
  Dim FormatRuleFieldIntersectionSettings4 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
  Dim PivotGridFormatRule6 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
  Dim FormatConditionRule2ColorScale1 As DevExpress.XtraEditors.FormatConditionRule2ColorScale = New DevExpress.XtraEditors.FormatConditionRule2ColorScale()
  Dim FormatRuleFieldIntersectionSettings5 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
  Dim PivotGridFormatRule7 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
  Dim FormatConditionRuleTopBottom1 As DevExpress.XtraEditors.FormatConditionRuleTopBottom = New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
  Dim FormatRuleFieldIntersectionSettings6 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
  Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
  Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
  Me.fieldExtendedPrice2 = New DevExpress.XtraPivotGrid.PivotGridField()
  Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
  Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
  Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
  Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
  Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
  Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
  Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
  CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.SuspendLayout()
  '
  'fieldQuarter
  '
  Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
  Me.fieldQuarter.AreaIndex = 1
  Me.fieldQuarter.Caption = "Order Quarter"
  Me.fieldQuarter.FieldName = "OrderDate"
  Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
  Me.fieldQuarter.Name = "fieldQuarter"
  Me.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
  Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
  Me.fieldQuarter.ValueFormat.FormatString = "Qtr {0}"
  Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
  '
  'fieldCountry
  '
  Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
  Me.fieldCountry.AreaIndex = 1
  Me.fieldCountry.FieldName = "Country"
  Me.fieldCountry.Name = "fieldCountry"
  '
  'fieldExtendedPrice2
  '
  Me.fieldExtendedPrice2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
  Me.fieldExtendedPrice2.AreaIndex = 1
  Me.fieldExtendedPrice2.Caption = "Variation"
  Me.fieldExtendedPrice2.FieldName = "Extended Price"
  Me.fieldExtendedPrice2.Name = "fieldExtendedPrice2"
  Me.fieldExtendedPrice2.Options.HideEmptyVariationItems = True
  Me.fieldExtendedPrice2.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.AbsoluteVariation
  '
  'fieldCategoryName
  '
  Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
  Me.fieldCategoryName.AreaIndex = 0
  Me.fieldCategoryName.FieldName = "CategoryName"
  Me.fieldCategoryName.Name = "fieldCategoryName"
  '
  'fieldExtendedPrice
  '
  Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
  Me.fieldExtendedPrice.AreaIndex = 0
  Me.fieldExtendedPrice.Caption = "Order Amount"
  Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
  Me.fieldExtendedPrice.FieldName = "Extended Price"
  Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
  '
  'dsSalesPerson1
  '
  Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
  Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
  Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
  '
  'pivotGridControl1
  '
  Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow
  Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
  Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
  Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldQuarter, Me.fieldExtendedPrice, Me.fieldExtendedPrice2, Me.fieldYear, Me.fieldCategoryName, Me.fieldProductName, Me.fieldCountry, Me.fieldSalesPerson})
  PivotGridFormatRule1.Measure = Me.fieldExtendedPrice2
  PivotGridFormatRule1.Name = "AbsVarDataBar"
  FormatConditionRuleDataBar1.Appearance.BackColor = System.Drawing.Color.YellowGreen
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
  FormatConditionRuleDataBar1.ShowBarOnly = True
  PivotGridFormatRule1.Rule = FormatConditionRuleDataBar1
  FormatRuleFieldIntersectionSettings1.Column = Me.fieldQuarter
  FormatRuleFieldIntersectionSettings1.Row = Me.fieldCountry
  PivotGridFormatRule1.Settings = FormatRuleFieldIntersectionSettings1
  PivotGridFormatRule2.Measure = Me.fieldExtendedPrice2
  PivotGridFormatRule2.Name = "AbsVarGreater0"
  FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.YellowGreen
  FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
  FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater
  FormatConditionRuleValue1.Value1 = 0
  PivotGridFormatRule2.Rule = FormatConditionRuleValue1
  PivotGridFormatRule2.Settings = FormatRuleTotalTypeSettings1
  PivotGridFormatRule3.Measure = Me.fieldExtendedPrice2
  PivotGridFormatRule3.Name = "AbsVarLess0"
  FormatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.LightCoral
  FormatConditionRuleValue2.Appearance.Options.UseForeColor = True
  FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Less
  FormatConditionRuleValue2.Value1 = 0
  PivotGridFormatRule3.Rule = FormatConditionRuleValue2
  FormatRuleFieldIntersectionSettings2.Column = Me.fieldQuarter
  FormatRuleFieldIntersectionSettings2.Row = Me.fieldCategoryName
  PivotGridFormatRule3.Settings = FormatRuleFieldIntersectionSettings2
  PivotGridFormatRule4.Measure = Me.fieldExtendedPrice2
  PivotGridFormatRule4.Name = "Format4"
  FormatConditionIconSet1.CategoryName = "Directional"
  FormatConditionIconSetIcon1.PredefinedName = "Triangles3_1.png"
  FormatConditionIconSetIcon2.PredefinedName = "Triangles3_3.png"
  FormatConditionIconSetIcon2.Value = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
  FormatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
  FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon1)
  FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon2)
  FormatConditionIconSet1.Name = "Triangles3"
  FormatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number
  FormatConditionRuleIconSet1.IconSet = FormatConditionIconSet1
  PivotGridFormatRule4.Rule = FormatConditionRuleIconSet1
  FormatRuleFieldIntersectionSettings3.Column = Me.fieldQuarter
  FormatRuleFieldIntersectionSettings3.Row = Me.fieldCategoryName
  PivotGridFormatRule4.Settings = FormatRuleFieldIntersectionSettings3
  PivotGridFormatRule4.StopIfTrue = True
  PivotGridFormatRule5.Measure = Me.fieldExtendedPrice2
  PivotGridFormatRule5.Name = "Format1"
  FormatConditionIconSet2.CategoryName = "Directional"
  FormatConditionIconSetIcon3.PredefinedName = "Arrows4_1.png"
  FormatConditionIconSetIcon4.PredefinedName = "Arrows4_4.png"
  FormatConditionIconSetIcon4.Value = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
  FormatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
  FormatConditionIconSet2.Icons.Add(FormatConditionIconSetIcon3)
  FormatConditionIconSet2.Icons.Add(FormatConditionIconSetIcon4)
  FormatConditionIconSet2.Name = "Arrows4Colored"
  FormatConditionIconSet2.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number
  FormatConditionRuleIconSet2.IconSet = FormatConditionIconSet2
  PivotGridFormatRule5.Rule = FormatConditionRuleIconSet2
  FormatRuleFieldIntersectionSettings4.Column = Me.fieldQuarter
  PivotGridFormatRule5.Settings = FormatRuleFieldIntersectionSettings4
  PivotGridFormatRule6.Measure = Me.fieldExtendedPrice
  PivotGridFormatRule6.Name = "Format5"
  FormatConditionRule2ColorScale1.PredefinedName = "Yellow, Green"
  PivotGridFormatRule6.Rule = FormatConditionRule2ColorScale1
  FormatRuleFieldIntersectionSettings5.Column = Me.fieldQuarter
  FormatRuleFieldIntersectionSettings5.Row = Me.fieldCountry
  PivotGridFormatRule6.Settings = FormatRuleFieldIntersectionSettings5
  PivotGridFormatRule7.Measure = Me.fieldExtendedPrice
  PivotGridFormatRule7.Name = "Top 3 Sale"
  FormatConditionRuleTopBottom1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
  FormatConditionRuleTopBottom1.Appearance.Options.UseFont = True
  FormatConditionRuleTopBottom1.Rank = New Decimal(New Integer() {3, 0, 0, 0})
  FormatConditionRuleTopBottom1.RankType = DevExpress.XtraEditors.FormatConditionValueType.Number
  PivotGridFormatRule7.Rule = FormatConditionRuleTopBottom1
  FormatRuleFieldIntersectionSettings6.Column = Me.fieldQuarter
  FormatRuleFieldIntersectionSettings6.Row = Me.fieldCountry
  PivotGridFormatRule7.Settings = FormatRuleFieldIntersectionSettings6
  Me.pivotGridControl1.FormatRules.Add(PivotGridFormatRule1)
  Me.pivotGridControl1.FormatRules.Add(PivotGridFormatRule2)
  Me.pivotGridControl1.FormatRules.Add(PivotGridFormatRule3)
  Me.pivotGridControl1.FormatRules.Add(PivotGridFormatRule4)
  Me.pivotGridControl1.FormatRules.Add(PivotGridFormatRule5)
  Me.pivotGridControl1.FormatRules.Add(PivotGridFormatRule6)
  Me.pivotGridControl1.FormatRules.Add(PivotGridFormatRule7)
  Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
  Me.pivotGridControl1.Name = "pivotGridControl1"
  Me.pivotGridControl1.OptionsMenu.EnableFormatRulesMenu = True
  Me.pivotGridControl1.OptionsView.ShowColumnGrandTotals = False
  Me.pivotGridControl1.OptionsView.ShowColumnTotals = False
  Me.pivotGridControl1.Size = New System.Drawing.Size(704, 416)
  Me.pivotGridControl1.TabIndex = 12
  '
  'fieldYear
  '
  Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
  Me.fieldYear.AreaIndex = 0
  Me.fieldYear.Caption = "Order Year"
  Me.fieldYear.FieldName = "OrderDate"
  Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
  Me.fieldYear.Name = "fieldYear"
  Me.fieldYear.UnboundFieldName = "fieldYear"
  '
  'fieldProductName
  '
  Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
  Me.fieldProductName.AreaIndex = 2
  Me.fieldProductName.FieldName = "ProductName"
  Me.fieldProductName.Name = "fieldProductName"
  Me.fieldProductName.Visible = False
  '
  'fieldSalesPerson
  '
  Me.fieldSalesPerson.AreaIndex = 0
  Me.fieldSalesPerson.FieldName = "Sales Person"
  Me.fieldSalesPerson.Name = "fieldSalesPerson"
  '
  'FormatRules
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  Me.Controls.Add(Me.pivotGridControl1)
  Me.Name = "FormatRules"
  Me.Size = New System.Drawing.Size(704, 416)
  CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
  Me.ResumeLayout(False)

End Sub

		#End Region
		Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private fieldQuarter As PivotGridField
		Private fieldExtendedPrice As PivotGridField
		Private fieldYear As PivotGridField
		Private fieldExtendedPrice2 As PivotGridField
		Private fieldCategoryName As PivotGridField
		Private fieldProductName As PivotGridField
		Private fieldCountry As PivotGridField
		Private fieldSalesPerson As PivotGridField

	End Class
End Namespace

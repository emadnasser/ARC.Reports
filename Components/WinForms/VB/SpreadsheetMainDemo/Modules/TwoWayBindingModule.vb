Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils


Namespace DevExpress.XtraSpreadsheet.Demos
	Public Class TwoWayBindingModule
		Inherits SpreadSheetTutorialControlBase
		Private verticalSplitContainerControl1 As SplitContainerControl
		Private gridControl1 As XtraGrid.GridControl
		Private gridView1 As XtraGrid.Views.Grid.GridView
		Private gridColumn1 As XtraGrid.Columns.GridColumn
		Private gridColumn2 As XtraGrid.Columns.GridColumn
		Private gridColumn3 As XtraGrid.Columns.GridColumn
		Private gridColumn4 As XtraGrid.Columns.GridColumn
		Private gridColumn5 As XtraGrid.Columns.GridColumn
		Private gridColumn6 As XtraGrid.Columns.GridColumn
		Private WithEvents spreadsheet As SpreadsheetControl

		Public Sub New()
			InitializeComponent()
			Me.spreadsheet.LoadDocument(DemoUtils.GetRelativePath("Expenses_template.xlsx"), DocumentFormat.Xlsx)
		End Sub

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			Me.spreadsheet.Focus()
		End Sub

		Private Sub spreadsheet_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs) Handles spreadsheet.DocumentLoaded
			Dim workbook As IWorkbook = Me.spreadsheet.Document
			Dim sheet As Worksheet = workbook.Worksheets(0)
			Dim expenses As Table = sheet.Tables(0)
			Dim options As New RangeDataSourceOptions()
			options.PreserveFormulas = True
			options.SkipHiddenRows = True
			gridControl1.DataSource = expenses.DataRange.GetDataSource(options)
		End Sub

		#Region "InitializeComponent"
		Private Sub InitializeComponent()
			Me.verticalSplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.spreadsheet = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.verticalSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.verticalSplitContainerControl1.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' verticalSplitContainerControl1
			' 
			Me.verticalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.verticalSplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
			Me.verticalSplitContainerControl1.Horizontal = False
			Me.verticalSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.verticalSplitContainerControl1.Name = "verticalSplitContainerControl1"
			Me.verticalSplitContainerControl1.Panel1.Controls.Add(Me.spreadsheet)
			Me.verticalSplitContainerControl1.Panel1.Text = "Panel1"
			Me.verticalSplitContainerControl1.Panel2.Controls.Add(Me.gridControl1)
			Me.verticalSplitContainerControl1.Panel2.Text = "Panel2"
			Me.verticalSplitContainerControl1.Size = New System.Drawing.Size(1228, 694)
			Me.verticalSplitContainerControl1.SplitterPosition = 348
			Me.verticalSplitContainerControl1.TabIndex = 0
			Me.verticalSplitContainerControl1.Text = "verticalSplitContainerControl1"
			' 
			' spreadsheet
			' 
			Me.spreadsheet.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheet.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheet.Name = "spreadsheet"
			Me.spreadsheet.Options.CalculationEngineType = DevExpress.Spreadsheet.CalculationEngineType.Recursive
			Me.spreadsheet.Options.Export.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheet.Options.Export.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheet.Options.Import.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheet.Options.Import.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheet.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
			Me.spreadsheet.Options.View.ShowPrintArea = False
			Me.spreadsheet.Size = New System.Drawing.Size(1228, 348)
			Me.spreadsheet.TabIndex = 7
'			Me.spreadsheet.DocumentLoaded += New System.EventHandler(Me.spreadsheet_DocumentLoaded);
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(1228, 341)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.UseEmbeddedNavigator = True
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
			Me.gridView1.OptionsView.ColumnAutoWidth = False
			Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
			Me.gridView1.OptionsView.ShowGroupPanel = False
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Operation Expenses"
			Me.gridColumn1.FieldName = "Column 0"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.OptionsColumn.FixedWidth = True
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			Me.gridColumn1.Width = 215
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Q1"
			Me.gridColumn2.DisplayFormat.FormatString = "$ {0:n2}"
			Me.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.gridColumn2.FieldName = "Column 1"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.OptionsColumn.FixedWidth = True
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			Me.gridColumn2.Width = 117
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Q2"
			Me.gridColumn3.DisplayFormat.FormatString = "$ {0:n2}"
			Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.gridColumn3.FieldName = "Column 2"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.OptionsColumn.FixedWidth = True
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 2
			Me.gridColumn3.Width = 117
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Q3"
			Me.gridColumn4.DisplayFormat.FormatString = "$ {0:n2}"
			Me.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.gridColumn4.FieldName = "Column 3"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.OptionsColumn.FixedWidth = True
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 3
			Me.gridColumn4.Width = 117
			' 
			' gridColumn5
			' 
			Me.gridColumn5.Caption = "Q4"
			Me.gridColumn5.DisplayFormat.FormatString = "$ {0:n2}"
			Me.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.gridColumn5.FieldName = "Column 4"
			Me.gridColumn5.Name = "gridColumn5"
			Me.gridColumn5.OptionsColumn.FixedWidth = True
			Me.gridColumn5.Visible = True
			Me.gridColumn5.VisibleIndex = 4
			Me.gridColumn5.Width = 117
			' 
			' gridColumn6
			' 
			Me.gridColumn6.Caption = "Yearly Total"
			Me.gridColumn6.DisplayFormat.FormatString = "$ {0:n2}"
			Me.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.gridColumn6.FieldName = "Column 5"
			Me.gridColumn6.Name = "gridColumn6"
			Me.gridColumn6.OptionsColumn.AllowEdit = False
			Me.gridColumn6.OptionsColumn.FixedWidth = True
			Me.gridColumn6.Visible = True
			Me.gridColumn6.VisibleIndex = 5
			Me.gridColumn6.Width = 145
			' 
			' TwoWayBindingModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.verticalSplitContainerControl1)
			Me.Name = "TwoWayBindingModule"
			Me.Size = New System.Drawing.Size(1228, 694)
			CType(Me.verticalSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.verticalSplitContainerControl1.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace

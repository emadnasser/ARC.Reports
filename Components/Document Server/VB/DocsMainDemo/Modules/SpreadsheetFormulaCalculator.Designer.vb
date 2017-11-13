Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetFormulaCalculatorModule
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
		''' 
		Private Sub InitializeComponent()
			Me.saveButton = New DevExpress.XtraEditors.SimpleButton()
			Me.grid = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.repositoryItemTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.formulaEdit = New DevExpress.XtraEditors.TextEdit()
			Me.formulaLabel = New DevExpress.XtraEditors.LabelControl()
			CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.formulaEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' saveButton
			' 
			Me.saveButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.saveButton.Location = New System.Drawing.Point(320, 500)
			Me.saveButton.Name = "saveButton"
			Me.saveButton.Size = New System.Drawing.Size(75, 23)
			Me.saveButton.TabIndex = 4
			Me.saveButton.Text = "Save As..."
'			Me.saveButton.Click += New System.EventHandler(Me.saveButton_Click);
			' 
			' grid
			' 
			Me.grid.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.grid.Location = New System.Drawing.Point(0, 23)
			Me.grid.MainView = Me.gridView1
			Me.grid.Name = "grid"
			Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit})
			Me.grid.Size = New System.Drawing.Size(396, 470)
			Me.grid.TabIndex = 0
			Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.grid
			Me.gridView1.IndicatorWidth = 30
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsBehavior.AllowPartialRedrawOnScrolling = False
			Me.gridView1.OptionsBehavior.AutoPopulateColumns = False
			Me.gridView1.OptionsBehavior.AutoSelectAllInEditor = False
			Me.gridView1.OptionsBehavior.AutoUpdateTotalSummary = False
			'this.gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
			Me.gridView1.OptionsBehavior.FocusLeaveOnTab = True
			Me.gridView1.OptionsCustomization.AllowColumnMoving = False
			Me.gridView1.OptionsCustomization.AllowFilter = False
			Me.gridView1.OptionsCustomization.AllowGroup = False
			Me.gridView1.OptionsCustomization.AllowQuickHideColumns = False
			Me.gridView1.OptionsCustomization.AllowSort = False
			Me.gridView1.OptionsSelection.EnableAppearanceFocusedRow = False
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.OptionsView.ShowButtonMode = XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor
'			Me.gridView1.CustomDrawRowIndicator += New DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(Me.gridView1_CustomDrawRowIndicator);
'			Me.gridView1.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gridView1_CustomDrawCell);
'			Me.gridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gridView1_FocusedRowChanged);
'			Me.gridView1.FocusedColumnChanged += New DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(Me.gridView1_FocusedColumnChanged);
'			Me.gridView1.CellValueChanged += New DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(Me.gridView1_CellValueChanged);
'			Me.gridView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gridView1_CustomUnboundColumnData);
			' 
			' repositoryItemTextEdit
			' 
			Me.repositoryItemTextEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
			Me.repositoryItemTextEdit.AutoHeight = False
			Me.repositoryItemTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemTextEdit.Mask.EditMask = "N00"
			Me.repositoryItemTextEdit.Name = "repositoryItemTextEdit"
'			Me.repositoryItemTextEdit.Enter += New System.EventHandler(Me.repositoryItemTextEdit_Enter);
'			Me.repositoryItemTextEdit.Leave += New System.EventHandler(Me.repositoryItemTextEdit_Leave);
			' 
			' formulaEdit
			' 
			Me.formulaEdit.Location = New System.Drawing.Point(104, 0)
			Me.formulaEdit.Name = "formulaEdit"
			Me.formulaEdit.Size = New System.Drawing.Size(292, 20)
			Me.formulaEdit.TabIndex = 1
'			Me.formulaEdit.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.formulaEdit_KeyDown);
			' 
			' formulaLabel
			' 
			Me.formulaLabel.Location = New System.Drawing.Point(3, 3)
			Me.formulaLabel.Name = "formulaLabel"
			Me.formulaLabel.Size = New System.Drawing.Size(97, 13)
			Me.formulaLabel.TabIndex = 3
			Me.formulaLabel.Text = "Enter Formula Here:"
			' 
			' SpreadsheetFormulaCalculatorModule
			' 
			Me.Controls.Add(Me.grid)
			Me.Controls.Add(Me.formulaEdit)
			Me.Controls.Add(Me.formulaLabel)
			Me.Controls.Add(Me.saveButton)
			Me.Name = "SpreadsheetFormulaCalculatorModule"
			Me.Size = New System.Drawing.Size(398, 527)
			CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.formulaEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private WithEvents gridView1 As GridView
		Private WithEvents repositoryItemTextEdit As RepositoryItemTextEdit
		Private grid As GridControl
		Private WithEvents formulaEdit As TextEdit
		Private formulaLabel As LabelControl
		Private WithEvents saveButton As SimpleButton
	End Class
End Namespace

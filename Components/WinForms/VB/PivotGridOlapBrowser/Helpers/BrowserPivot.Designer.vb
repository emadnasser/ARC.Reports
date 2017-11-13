Imports Microsoft.VisualBasic
Imports System
Namespace PivotGridOlapBrowser
	Partial Public Class BrowserPivot
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
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.fieldListContainer = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGrid = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.lcgRoot = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lcgPivotGrid = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciPivotGrid = New DevExpress.XtraLayout.LayoutControlItem()
			Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
			Me.lciFieldListContainer = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.fieldListContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgRoot, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgPivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciFieldListContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.fieldListContainer)
			Me.layoutControl1.Controls.Add(Me.pivotGrid)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.lcgRoot
			Me.layoutControl1.Size = New System.Drawing.Size(743, 415)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' fieldListContainer
			' 
			Me.fieldListContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
			Me.fieldListContainer.Location = New System.Drawing.Point(479, 2)
			Me.fieldListContainer.Name = "fieldListContainer"
			Me.fieldListContainer.Size = New System.Drawing.Size(262, 411)
			Me.fieldListContainer.TabIndex = 12
			' 
			' pivotGrid
			' 
			Me.pivotGrid.Location = New System.Drawing.Point(2, 2)
			Me.pivotGrid.Name = "pivotGrid"
			Me.pivotGrid.OptionsCustomization.AllowFilterInCustomizationForm = True
			Me.pivotGrid.OptionsCustomization.AllowPrefilter = False
			Me.pivotGrid.OptionsCustomization.AllowSortInCustomizationForm = True
			Me.pivotGrid.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
			Me.pivotGrid.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
			Me.pivotGrid.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree
			Me.pivotGrid.OptionsView.ShowColumnHeaders = False
			Me.pivotGrid.OptionsView.ShowDataHeaders = False
			Me.pivotGrid.OptionsView.ShowFilterHeaders = False
			Me.pivotGrid.OptionsView.ShowRowHeaders = False
			Me.pivotGrid.OptionsView.ShowTotalsForSingleValues = True
			Me.pivotGrid.Size = New System.Drawing.Size(468, 411)
			Me.pivotGrid.TabIndex = 11
'			Me.pivotGrid.FieldValueNotExpanded += New DevExpress.XtraPivotGrid.PivotFieldValueEventHandler(Me.pivotGrid_FieldValueNotExpanded);
'			Me.pivotGrid.FieldValueCollapsed += New DevExpress.XtraPivotGrid.PivotFieldValueEventHandler(Me.pivotGrid_FieldValueCollapsed);
'			Me.pivotGrid.FieldValueExpanding += New DevExpress.XtraPivotGrid.PivotFieldValueCancelEventHandler(Me.pivotGrid_FieldValueExpanding);
'			Me.pivotGrid.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.pivotGrid_MouseMove);
'			Me.pivotGrid.FieldValueExpanded += New DevExpress.XtraPivotGrid.PivotFieldValueEventHandler(Me.pivotGrid_FieldValueExpanded);
'			Me.pivotGrid.FieldValueCollapsing += New DevExpress.XtraPivotGrid.PivotFieldValueCancelEventHandler(Me.pivotGrid_FieldValueCollapsing);
'			Me.pivotGrid.BeginRefresh += New System.EventHandler(Me.pivotGrid_BeginRefresh);
'			Me.pivotGrid.PopupMenuShowing += New DevExpress.XtraPivotGrid.PopupMenuShowingEventHandler(Me.pivotGrid_ShowMenu);
'			Me.pivotGrid.EndRefresh += New System.EventHandler(Me.pivotGrid_EndRefresh);
			' 
			' lcgRoot
			' 
			Me.lcgRoot.CustomizationFormText = "Root"
			Me.lcgRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgRoot.GroupBordersVisible = False
			Me.lcgRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lcgPivotGrid})
			Me.lcgRoot.Location = New System.Drawing.Point(0, 0)
			Me.lcgRoot.Name = "lcgRoot"
			Me.lcgRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgRoot.Size = New System.Drawing.Size(743, 415)
			Me.lcgRoot.Text = "lcgRoot"
			Me.lcgRoot.TextVisible = False
			' 
			' lcgPivotGrid
			' 
			Me.lcgPivotGrid.CustomizationFormText = "Pivot Grid"
			Me.lcgPivotGrid.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Horizontal
			Me.lcgPivotGrid.GroupBordersVisible = False
			Me.lcgPivotGrid.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciPivotGrid, Me.splitterItem1, Me.lciFieldListContainer})
			Me.lcgPivotGrid.Location = New System.Drawing.Point(0, 0)
			Me.lcgPivotGrid.Name = "lcgPivotGrid"
			Me.lcgPivotGrid.Size = New System.Drawing.Size(743, 415)
			Me.lcgPivotGrid.Text = "Pivot Grid"
			' 
			' lciPivotGrid
			' 
			Me.lciPivotGrid.Control = Me.pivotGrid
			Me.lciPivotGrid.CustomizationFormText = "lciPivotGrid"
			Me.lciPivotGrid.Location = New System.Drawing.Point(0, 0)
			Me.lciPivotGrid.Name = "lciPivotGrid"
			Me.lciPivotGrid.Size = New System.Drawing.Size(472, 415)
			Me.lciPivotGrid.Text = "lciPivotGrid"
			Me.lciPivotGrid.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPivotGrid.TextToControlDistance = 0
			Me.lciPivotGrid.TextVisible = False
			' 
			' splitterItem1
			' 
			Me.splitterItem1.AllowHotTrack = True
			Me.splitterItem1.CustomizationFormText = "splitterItem1"
			Me.splitterItem1.Location = New System.Drawing.Point(472, 0)
			Me.splitterItem1.Name = "splitterItem1"
			Me.splitterItem1.Size = New System.Drawing.Size(5, 415)
			' 
			' lciFieldListContainer
			' 
			Me.lciFieldListContainer.Control = Me.fieldListContainer
			Me.lciFieldListContainer.CustomizationFormText = "lciFieldListContainer"
			Me.lciFieldListContainer.Location = New System.Drawing.Point(477, 0)
			Me.lciFieldListContainer.Name = "lciFieldListContainer"
			Me.lciFieldListContainer.Size = New System.Drawing.Size(266, 415)
			Me.lciFieldListContainer.Text = "lciFieldListContainer"
			Me.lciFieldListContainer.TextSize = New System.Drawing.Size(0, 0)
			Me.lciFieldListContainer.TextToControlDistance = 0
			Me.lciFieldListContainer.TextVisible = False
			' 
			' BrowserPivot
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "BrowserPivot"
			Me.Size = New System.Drawing.Size(743, 415)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.fieldListContainer, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgRoot, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgPivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciFieldListContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private lcgRoot As DevExpress.XtraLayout.LayoutControlGroup
		Private WithEvents pivotGrid As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldListContainer As DevExpress.XtraEditors.PanelControl
		Private lcgPivotGrid As DevExpress.XtraLayout.LayoutControlGroup
		Private lciPivotGrid As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private lciFieldListContainer As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace

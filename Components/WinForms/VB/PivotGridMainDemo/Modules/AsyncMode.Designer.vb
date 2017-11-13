Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
    Partial Public Class AsynchronousMode
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
            Me.components = New System.ComponentModel.Container()
            Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.btnGenerateDataSource = New DevExpress.XtraEditors.SimpleButton()
            Me.rgDataSources = New DevExpress.XtraEditors.RadioGroup()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.panelError = New DevExpress.XtraEditors.PanelControl()
            Me.labelError = New DevExpress.XtraEditors.LabelControl()
            CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.paddingPanel.SuspendLayout()
            CType(Me.rgDataSources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelError, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelError.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' paddingPanel
            ' 
            Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.paddingPanel.Controls.Add(Me.labelControl1)
            Me.paddingPanel.Controls.Add(Me.btnGenerateDataSource)
            Me.paddingPanel.Controls.Add(Me.rgDataSources)
            Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.paddingPanel.Location = New System.Drawing.Point(0, 43)
            Me.paddingPanel.Name = "paddingPanel"
            Me.paddingPanel.Size = New System.Drawing.Size(739, 29)
            Me.paddingPanel.TabIndex = 12
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(6, 8)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(63, 13)
            Me.labelControl1.TabIndex = 3
            Me.labelControl1.Text = "Data Source:"
            ' 
            ' btnGenerateDataSource
            ' 
            Me.btnGenerateDataSource.Location = New System.Drawing.Point(377, 3)
            Me.btnGenerateDataSource.Name = "btnGenerateDataSource"
            Me.btnGenerateDataSource.Size = New System.Drawing.Size(105, 23)
            Me.btnGenerateDataSource.TabIndex = 0
            Me.btnGenerateDataSource.Text = "Generate Database"
            '			Me.btnGenerateDataSource.Click += New System.EventHandler(Me.btnGenerateDataSource_Click);
            ' 
            ' rgDataSources
            ' 
            Me.rgDataSources.Location = New System.Drawing.Point(72, 3)
            Me.rgDataSources.Name = "rgDataSources"
            Me.rgDataSources.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgDataSources.Properties.Appearance.Options.UseBackColor = True
            Me.rgDataSources.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgDataSources.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "OLAP Cube"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Table Data Source")})
            Me.rgDataSources.Size = New System.Drawing.Size(221, 23)
            Me.rgDataSources.TabIndex = 2
            '			Me.rgDataSources.SelectedIndexChanged += New System.EventHandler(Me.rgDataSources_SelectedIndexChanged);
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 72)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.pivotGridControl)
            Me.splitContainerControl1.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(739, 415)
            Me.splitContainerControl1.SplitterPosition = 240
            Me.splitContainerControl1.TabIndex = 15
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '			Me.splitContainerControl1.SplitterMoved += New System.EventHandler(Me.splitContainerControl1_SplitterMoved);
            ' 
            ' pivotGridControl
            ' 
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsBehavior.UseAsyncMode = True
            Me.pivotGridControl.OptionsCustomization.AllowCustomizationForm = False
            Me.pivotGridControl.OptionsCustomization.AllowFilterInCustomizationForm = True
            Me.pivotGridControl.OptionsCustomization.AllowSortInCustomizationForm = True
            Me.pivotGridControl.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
            Me.pivotGridControl.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near
            Me.pivotGridControl.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree
            Me.pivotGridControl.OptionsView.ShowColumnHeaders = False
            Me.pivotGridControl.OptionsView.ShowDataHeaders = False
            Me.pivotGridControl.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl.OptionsView.ShowRowHeaders = False
            Me.pivotGridControl.Size = New System.Drawing.Size(490, 415)
            Me.pivotGridControl.TabIndex = 16
'			Me.pivotGridControl.CellDoubleClick += New DevExpress.XtraPivotGrid.PivotCellEventHandler(Me.pivotGridControl1_CellDoubleClick)
'			Me.pivotGridControl.QueryException += New DevExpress.XtraPivotGrid.PivotQueryExceptionEventHandler(Me.pivotGridControl_QueryException)
'			Me.pivotGridControl.AsyncOperationStarting += New System.EventHandler(Me.pivotGridControl_AsyncOperationStarting)
'			Me.pivotGridControl.AsyncOperationCompleted += New System.EventHandler(Me.pivotGridControl_AsyncOperationCompleted)
            ' 
            ' panelError
            ' 
            Me.panelError.Controls.Add(Me.labelError)
            Me.panelError.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelError.Location = New System.Drawing.Point(0, 0)
            Me.panelError.Name = "panelError"
            Me.panelError.Size = New System.Drawing.Size(739, 43)
            Me.panelError.TabIndex = 18
            Me.panelError.Visible = False
            ' 
            ' labelError
            ' 
            Me.labelError.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.labelError.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.labelError.Appearance.ForeColor = System.Drawing.Color.Red
            Me.labelError.AutoEllipsis = True
            Me.labelError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelError.Location = New System.Drawing.Point(12, 6)
            Me.labelError.Name = "labelError"
            Me.labelError.Size = New System.Drawing.Size(712, 28)
            Me.labelError.TabIndex = 0
            ' 
            ' AsynchronousMode
            ' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.paddingPanel)
            Me.Controls.Add(Me.panelError)
            Me.Name = "AsynchronousMode"
            Me.Size = New System.Drawing.Size(739, 487)
            '			Me.Load += New System.EventHandler(Me.AsynchronousMode_Load);
            '			Me.Resize += New System.EventHandler(Me.AsynchronousMode_Resize);
            CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.paddingPanel.ResumeLayout(False)
            Me.paddingPanel.PerformLayout()
            CType(Me.rgDataSources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelError, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelError.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

        Private paddingPanel As DevExpress.XtraEditors.PanelControl
        Private WithEvents rgDataSources As DevExpress.XtraEditors.RadioGroup
        Private WithEvents btnGenerateDataSource As DevExpress.XtraEditors.SimpleButton
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private WithEvents pivotGridControl As PivotGridControl
        Private panelError As DevExpress.XtraEditors.PanelControl
        Private labelError As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace

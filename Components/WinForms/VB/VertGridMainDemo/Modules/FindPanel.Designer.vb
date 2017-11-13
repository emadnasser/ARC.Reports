Namespace DevExpress.XtraVerticalGrid.Demos
    Partial Public Class FindPanel
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
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.cheShowClearButton = New DevExpress.XtraEditors.CheckEdit()
            Me.cheShowCloseButton = New DevExpress.XtraEditors.CheckEdit()
            Me.cheShowFindButton = New DevExpress.XtraEditors.CheckEdit()
            Me.cheClearFindOnClose = New DevExpress.XtraEditors.CheckEdit()
            Me.cheHighlightFindResults = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.cbFindDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.cbVisibility = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.cbFindMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.cbFindFilterColumns = New DevExpress.XtraEditors.CheckedComboBoxEdit()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.cheShowClearButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cheShowCloseButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cheShowFindButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cheClearFindOnClose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cheHighlightFindResults.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbFindDelay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbFindMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbFindFilterColumns.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.cheShowClearButton)
            Me.panelControl1.Controls.Add(Me.cheShowCloseButton)
            Me.panelControl1.Controls.Add(Me.cheShowFindButton)
            Me.panelControl1.Controls.Add(Me.cheClearFindOnClose)
            Me.panelControl1.Controls.Add(Me.cheHighlightFindResults)
            Me.panelControl1.Controls.Add(Me.labelControl4)
            Me.panelControl1.Controls.Add(Me.labelControl3)
            Me.panelControl1.Controls.Add(Me.labelControl2)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.cbFindDelay)
            Me.panelControl1.Controls.Add(Me.cbVisibility)
            Me.panelControl1.Controls.Add(Me.cbFindMode)
            Me.panelControl1.Controls.Add(Me.cbFindFilterColumns)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(784, 96)
            Me.panelControl1.TabIndex = 9
            ' 
            ' cheShowClearButton
            ' 
            Me.cheShowClearButton.Location = New System.Drawing.Point(342, 39)
            Me.cheShowClearButton.Name = "cheShowClearButton"
            Me.cheShowClearButton.Properties.AutoWidth = True
            Me.cheShowClearButton.Properties.Caption = "Show Clear Button"
            Me.cheShowClearButton.Size = New System.Drawing.Size(111, 19)
            Me.cheShowClearButton.TabIndex = 16
            ' 
            ' cheShowCloseButton
            ' 
            Me.cheShowCloseButton.Location = New System.Drawing.Point(342, 13)
            Me.cheShowCloseButton.Name = "cheShowCloseButton"
            Me.cheShowCloseButton.Properties.AutoWidth = True
            Me.cheShowCloseButton.Properties.Caption = "Show Close Button"
            Me.cheShowCloseButton.Size = New System.Drawing.Size(112, 19)
            Me.cheShowCloseButton.TabIndex = 15
            ' 
            ' cheShowFindButton
            ' 
            Me.cheShowFindButton.Location = New System.Drawing.Point(342, 65)
            Me.cheShowFindButton.Name = "cheShowFindButton"
            Me.cheShowFindButton.Properties.AutoWidth = True
            Me.cheShowFindButton.Properties.Caption = "Show Find Button"
            Me.cheShowFindButton.Size = New System.Drawing.Size(106, 19)
            Me.cheShowFindButton.TabIndex = 14
            ' 
            ' cheClearFindOnClose
            ' 
            Me.cheClearFindOnClose.Location = New System.Drawing.Point(15, 65)
            Me.cheClearFindOnClose.Name = "cheClearFindOnClose"
            Me.cheClearFindOnClose.Properties.AutoWidth = True
            Me.cheClearFindOnClose.Properties.Caption = "Clear Find On Close"
            Me.cheClearFindOnClose.Size = New System.Drawing.Size(116, 19)
            Me.cheClearFindOnClose.TabIndex = 13
            ' 
            ' cheHighlightFindResults
            ' 
            Me.cheHighlightFindResults.Location = New System.Drawing.Point(15, 39)
            Me.cheHighlightFindResults.Name = "cheHighlightFindResults"
            Me.cheHighlightFindResults.Properties.AutoWidth = True
            Me.cheHighlightFindResults.Properties.Caption = "Highlight Find Results"
            Me.cheHighlightFindResults.Size = New System.Drawing.Size(124, 19)
            Me.cheHighlightFindResults.TabIndex = 12
            ' 
            ' labelControl4
            ' 
            Me.labelControl4.Location = New System.Drawing.Point(516, 42)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(94, 13)
            Me.labelControl4.TabIndex = 11
            Me.labelControl4.Text = "Find Filter Columns:"
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Location = New System.Drawing.Point(516, 68)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(53, 13)
            Me.labelControl3.TabIndex = 9
            Me.labelControl3.Text = "Find Mode:"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(516, 16)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(54, 13)
            Me.labelControl2.TabIndex = 7
            Me.labelControl2.Text = "Find Delay:"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(18, 16)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(93, 13)
            Me.labelControl1.TabIndex = 5
            Me.labelControl1.Text = "Find Panel Visibility:"
            ' 
            ' cbFindDelay
            ' 
            Me.cbFindDelay.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.cbFindDelay.Location = New System.Drawing.Point(617, 13)
            Me.cbFindDelay.Name = "cbFindDelay"
            Me.cbFindDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbFindDelay.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.cbFindDelay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.cbFindDelay.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.cbFindDelay.Properties.MinValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.cbFindDelay.Size = New System.Drawing.Size(149, 20)
            Me.cbFindDelay.TabIndex = 6
            ' 
            ' cbVisibility
            ' 
            Me.cbVisibility.Location = New System.Drawing.Point(148, 13)
            Me.cbVisibility.Name = "cbVisibility"
            Me.cbVisibility.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbVisibility.Size = New System.Drawing.Size(149, 20)
            Me.cbVisibility.TabIndex = 4
            ' 
            ' cbFindMode
            ' 
            Me.cbFindMode.Location = New System.Drawing.Point(617, 65)
            Me.cbFindMode.Name = "cbFindMode"
            Me.cbFindMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbFindMode.Size = New System.Drawing.Size(149, 20)
            Me.cbFindMode.TabIndex = 8
            ' 
            ' cbFindFilterColumns
            ' 
            Me.cbFindFilterColumns.Location = New System.Drawing.Point(617, 39)
            Me.cbFindFilterColumns.Name = "cbFindFilterColumns"
            Me.cbFindFilterColumns.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbFindFilterColumns.Size = New System.Drawing.Size(149, 20)
            Me.cbFindFilterColumns.TabIndex = 10
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 96)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(784, 8)
            Me.panelControl2.TabIndex = 10
            ' 
            ' vGridControl1
            ' 
            Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vGridControl1.FindPanelVisible = True
            Me.vGridControl1.Location = New System.Drawing.Point(0, 104)
            Me.vGridControl1.Name = "vGridControl1"
            Me.vGridControl1.OptionsMenu.EnableContextMenu = True
            Me.vGridControl1.OptionsView.MinRowAutoHeight = 20
            Me.vGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1})
            Me.vGridControl1.Size = New System.Drawing.Size(784, 328)
            Me.vGridControl1.TabIndex = 11
            ' 
            ' repositoryItemLookUpEdit1
            ' 
            Me.repositoryItemLookUpEdit1.AutoHeight = False
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")})
            Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
            Me.repositoryItemLookUpEdit1.DropDownRows = 10
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 220
            Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
            ' 
            ' FindPanel
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.vGridControl1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "FindPanel"
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.cheShowClearButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cheShowCloseButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cheShowFindButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cheClearFindOnClose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cheHighlightFindResults.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbFindDelay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbFindMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbFindFilterColumns.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private panelControl1 As XtraEditors.PanelControl
        Private panelControl2 As XtraEditors.PanelControl
        Private vGridControl1 As VGridControl
        Private repositoryItemLookUpEdit1 As XtraEditors.Repository.RepositoryItemLookUpEdit
        Private labelControl4 As XtraEditors.LabelControl
        Private labelControl3 As XtraEditors.LabelControl
        Private labelControl2 As XtraEditors.LabelControl
        Private labelControl1 As XtraEditors.LabelControl
        Private WithEvents cheShowClearButton As XtraEditors.CheckEdit
        Private WithEvents cheShowCloseButton As XtraEditors.CheckEdit
        Private WithEvents cheShowFindButton As XtraEditors.CheckEdit
        Private WithEvents cheClearFindOnClose As XtraEditors.CheckEdit
        Private WithEvents cheHighlightFindResults As XtraEditors.CheckEdit
        Private WithEvents cbFindDelay As XtraEditors.SpinEdit
        Private WithEvents cbVisibility As XtraEditors.ImageComboBoxEdit
        Private WithEvents cbFindMode As XtraEditors.ImageComboBoxEdit
        Private WithEvents cbFindFilterColumns As XtraEditors.CheckedComboBoxEdit
    End Class
End Namespace

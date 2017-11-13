Namespace DevExpress.XtraTreeList.Demos
    Partial Class Bands
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
            Me.ceAllowChangeColumnParent = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowBandResizing = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowBandInCustomizationForm = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowBandMoving = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowBandPanel = New DevExpress.XtraEditors.CheckEdit()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.ceAllowChangeBandParent = New DevExpress.XtraEditors.CheckEdit()
            Me.treeListColumn8 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListBand5 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.treeListColumn7 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListBand4 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.treeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn9 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListBand3 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.treeListBand2 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListBand1 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.treeList = New DevExpress.XtraTreeList.TreeList()
            CType(Me.ceAllowChangeColumnParent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAllowBandResizing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowBandInCustomizationForm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAllowBandMoving.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowBandPanel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.ceAllowChangeBandParent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeList, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ceAllowChangeColumnParent
            '
            Me.ceAllowChangeColumnParent.Location = New System.Drawing.Point(185, 32)
            Me.ceAllowChangeColumnParent.Name = "ceAllowChangeColumnParent"
            Me.ceAllowChangeColumnParent.Properties.Caption = "Allow Change Column Parent"
            Me.ceAllowChangeColumnParent.Size = New System.Drawing.Size(160, 19)
            Me.ceAllowChangeColumnParent.TabIndex = 5
            '
            'ceAllowBandResizing
            '
            Me.ceAllowBandResizing.Location = New System.Drawing.Point(384, 32)
            Me.ceAllowBandResizing.Name = "ceAllowBandResizing"
            Me.ceAllowBandResizing.Properties.Caption = "Allow Band Resizing"
            Me.ceAllowBandResizing.Size = New System.Drawing.Size(126, 19)
            Me.ceAllowBandResizing.TabIndex = 5
            '
            'ceShowBandInCustomizationForm
            '
            Me.ceShowBandInCustomizationForm.Location = New System.Drawing.Point(538, 10)
            Me.ceShowBandInCustomizationForm.Name = "ceShowBandInCustomizationForm"
            Me.ceShowBandInCustomizationForm.Properties.Caption = "Show Bands In Customization Form"
            Me.ceShowBandInCustomizationForm.Size = New System.Drawing.Size(192, 19)
            Me.ceShowBandInCustomizationForm.TabIndex = 5
            '
            'ceAllowBandMoving
            '
            Me.ceAllowBandMoving.Location = New System.Drawing.Point(384, 10)
            Me.ceAllowBandMoving.Name = "ceAllowBandMoving"
            Me.ceAllowBandMoving.Properties.Caption = "Allow Band Moving"
            Me.ceAllowBandMoving.Size = New System.Drawing.Size(126, 19)
            Me.ceAllowBandMoving.TabIndex = 5
            '
            'ceShowBandPanel
            '
            Me.ceShowBandPanel.Location = New System.Drawing.Point(15, 10)
            Me.ceShowBandPanel.Name = "ceShowBandPanel"
            Me.ceShowBandPanel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.ceShowBandPanel.Properties.Appearance.Options.UseFont = True
            Me.ceShowBandPanel.Properties.Caption = "Show Bands Panel"
            Me.ceShowBandPanel.Size = New System.Drawing.Size(137, 19)
            Me.ceShowBandPanel.TabIndex = 4
            '
            'panelControl2
            '
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 59)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(784, 8)
            Me.panelControl2.TabIndex = 18
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.ceAllowChangeColumnParent)
            Me.panelControl1.Controls.Add(Me.ceAllowBandResizing)
            Me.panelControl1.Controls.Add(Me.ceShowBandInCustomizationForm)
            Me.panelControl1.Controls.Add(Me.ceAllowBandMoving)
            Me.panelControl1.Controls.Add(Me.ceAllowChangeBandParent)
            Me.panelControl1.Controls.Add(Me.ceShowBandPanel)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(784, 59)
            Me.panelControl1.TabIndex = 17
            '
            'ceAllowChangeBandParent
            '
            Me.ceAllowChangeBandParent.Location = New System.Drawing.Point(185, 10)
            Me.ceAllowChangeBandParent.Name = "ceAllowChangeBandParent"
            Me.ceAllowChangeBandParent.Properties.Caption = "Allow Change Band Parent"
            Me.ceAllowChangeBandParent.Size = New System.Drawing.Size(160, 19)
            Me.ceAllowChangeBandParent.TabIndex = 5
            '
            'treeListColumn8
            '
            Me.treeListColumn8.Caption = "Icon"
            Me.treeListColumn8.FieldName = "ImageData"
            Me.treeListColumn8.Name = "treeListColumn8"
            Me.treeListColumn8.OptionsColumn.FixedWidth = True
            Me.treeListColumn8.Visible = True
            Me.treeListColumn8.VisibleIndex = 8
            Me.treeListColumn8.Width = 68
            '
            'treeListBand5
            '
            Me.treeListBand5.Caption = "<b>Picture</b>"
            Me.treeListBand5.Columns.Add(Me.treeListColumn8)
            Me.treeListBand5.MinWidth = 68
            Me.treeListBand5.Name = "treeListBand5"
            Me.treeListBand5.OptionsBand.FixedWidth = True
            Me.treeListBand5.Width = 68
            '
            'treeListColumn7
            '
            Me.treeListColumn7.Caption = "Mass"
            Me.treeListColumn7.FieldName = "MassByEarth"
            Me.treeListColumn7.Name = "treeListColumn7"
            Me.treeListColumn7.RowIndex = 1
            Me.treeListColumn7.Visible = True
            Me.treeListColumn7.VisibleIndex = 7
            Me.treeListColumn7.Width = 74
            '
            'treeListColumn6
            '
            Me.treeListColumn6.Caption = "Volume "
            Me.treeListColumn6.FieldName = "VolumeRByEarth"
            Me.treeListColumn6.Name = "treeListColumn6"
            Me.treeListColumn6.Visible = True
            Me.treeListColumn6.VisibleIndex = 6
            Me.treeListColumn6.Width = 104
            '
            'treeListBand4
            '
            Me.treeListBand4.Caption = "Related To Earth Values"
            Me.treeListBand4.Columns.Add(Me.treeListColumn5)
            Me.treeListBand4.Columns.Add(Me.treeListColumn6)
            Me.treeListBand4.Columns.Add(Me.treeListColumn7)
            Me.treeListBand4.Name = "treeListBand4"
            Me.treeListBand4.Width = 280
            '
            'treeListColumn5
            '
            Me.treeListColumn5.Caption = "Mean radius"
            Me.treeListColumn5.FieldName = "MeanRadiusByEarth"
            Me.treeListColumn5.Format.FormatString = "f"
            Me.treeListColumn5.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.treeListColumn5.Name = "treeListColumn5"
            Me.treeListColumn5.Visible = True
            Me.treeListColumn5.VisibleIndex = 5
            Me.treeListColumn5.Width = 102
            '
            'treeListColumn9
            '
            Me.treeListColumn9.Caption = "Mass"
            Me.treeListColumn9.FieldName = "Mass10pow21kg"
            Me.treeListColumn9.Name = "treeListColumn9"
            Me.treeListColumn9.RowIndex = 1
            Me.treeListColumn9.Visible = True
            Me.treeListColumn9.VisibleIndex = 4
            Me.treeListColumn9.Width = 61
            '
            'treeListColumn4
            '
            Me.treeListColumn4.Caption = "Volume "
            Me.treeListColumn4.FieldName = "Volume10pow9KM3"
            Me.treeListColumn4.Format.FormatString = "f"
            Me.treeListColumn4.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.treeListColumn4.Name = "treeListColumn4"
            Me.treeListColumn4.Visible = True
            Me.treeListColumn4.VisibleIndex = 3
            Me.treeListColumn4.Width = 88
            '
            'treeListColumn3
            '
            Me.treeListColumn3.Caption = "Mean radius"
            Me.treeListColumn3.FieldName = "MeanRadiusInKM"
            Me.treeListColumn3.Name = "treeListColumn3"
            Me.treeListColumn3.Visible = True
            Me.treeListColumn3.VisibleIndex = 2
            Me.treeListColumn3.Width = 107
            '
            'treeListBand3
            '
            Me.treeListBand3.Caption = "Absolute Values"
            Me.treeListBand3.Columns.Add(Me.treeListColumn3)
            Me.treeListBand3.Columns.Add(Me.treeListColumn4)
            Me.treeListBand3.Columns.Add(Me.treeListColumn9)
            Me.treeListBand3.Name = "treeListBand3"
            Me.treeListBand3.Width = 256
            '
            'treeListBand2
            '
            Me.treeListBand2.Bands.AddRange(New DevExpress.XtraTreeList.Columns.TreeListBand() {Me.treeListBand3, Me.treeListBand4})
            Me.treeListBand2.Caption = "<b>Details </b>"
            Me.treeListBand2.Name = "treeListBand2"
            Me.treeListBand2.Width = 536
            '
            'treeListColumn2
            '
            Me.treeListColumn2.Caption = "Type of object"
            Me.treeListColumn2.FieldName = "TypeOfObject"
            Me.treeListColumn2.Name = "treeListColumn2"
            Me.treeListColumn2.RowIndex = 1
            Me.treeListColumn2.Visible = True
            Me.treeListColumn2.VisibleIndex = 1
            Me.treeListColumn2.Width = 88
            '
            'treeListColumn1
            '
            Me.treeListColumn1.Caption = "Name"
            Me.treeListColumn1.FieldName = "Name"
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            Me.treeListColumn1.Width = 90
            '
            'treeListBand1
            '
            Me.treeListBand1.Caption = "<b>Main</b>"
            Me.treeListBand1.Columns.Add(Me.treeListColumn1)
            Me.treeListBand1.Columns.Add(Me.treeListColumn2)
            Me.treeListBand1.Name = "treeListBand1"
            Me.treeListBand1.Width = 178
            '
            'treeList
            '
            Me.treeList.Bands.AddRange(New DevExpress.XtraTreeList.Columns.TreeListBand() {Me.treeListBand1, Me.treeListBand2, Me.treeListBand5})
            Me.treeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4, Me.treeListColumn5, Me.treeListColumn9, Me.treeListColumn6, Me.treeListColumn7, Me.treeListColumn8})
            Me.treeList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList.Location = New System.Drawing.Point(0, 67)
            Me.treeList.Name = "treeList"
            Me.treeList.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList.OptionsBehavior.AutoNodeHeight = False
            Me.treeList.OptionsBehavior.Editable = False
            Me.treeList.OptionsCustomization.AllowChangeBandParent = True
            Me.treeList.OptionsCustomization.AllowChangeColumnParent = True
            Me.treeList.OptionsCustomization.CustomizationFormSearchBoxVisible = True
            Me.treeList.OptionsView.AllowBandColumnsMultiRow = True
            Me.treeList.OptionsView.AllowHtmlDrawHeaders = True
            Me.treeList.OptionsView.EnableAppearanceEvenRow = True
            Me.treeList.OptionsView.EnableAppearanceOddRow = True
            Me.treeList.OptionsView.ShowBandsMode = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList.Size = New System.Drawing.Size(784, 365)
            Me.treeList.TabIndex = 19
            '
            'Bands
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Bands"
            CType(Me.ceAllowChangeColumnParent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAllowBandResizing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowBandInCustomizationForm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAllowBandMoving.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowBandPanel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.ceAllowChangeBandParent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents ceAllowChangeColumnParent As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceAllowBandResizing As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceShowBandInCustomizationForm As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceAllowBandMoving As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceShowBandPanel As DevExpress.XtraEditors.CheckEdit
        Private WithEvents panelControl2 As DevExpress.XtraEditors.PanelControl
        Private WithEvents panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents ceAllowChangeBandParent As DevExpress.XtraEditors.CheckEdit
        Private WithEvents treeListColumn8 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListBand5 As DevExpress.XtraTreeList.Columns.TreeListBand
        Private WithEvents treeListColumn7 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListBand4 As DevExpress.XtraTreeList.Columns.TreeListBand
        Private WithEvents treeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListColumn9 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListBand3 As DevExpress.XtraTreeList.Columns.TreeListBand
        Private WithEvents treeListBand2 As DevExpress.XtraTreeList.Columns.TreeListBand
        Private WithEvents treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListBand1 As DevExpress.XtraTreeList.Columns.TreeListBand
        Private WithEvents treeList As DevExpress.XtraTreeList.TreeList

    End Class
End Namespace


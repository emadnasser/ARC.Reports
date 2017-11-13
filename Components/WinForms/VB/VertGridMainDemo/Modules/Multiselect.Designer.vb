Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class Multiselect
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
			Me.sbSelectSomeElements = New DevExpress.XtraEditors.SimpleButton()
			Me.cheMultiselect = New DevExpress.XtraEditors.CheckEdit()
			Me.lblMultiselectMode = New DevExpress.XtraEditors.LabelControl()
			Me.cbMultiselectMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.cheMultiselect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbMultiselectMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.sbSelectSomeElements)
			Me.panelControl1.Controls.Add(Me.cheMultiselect)
			Me.panelControl1.Controls.Add(Me.lblMultiselectMode)
			Me.panelControl1.Controls.Add(Me.cbMultiselectMode)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(784, 75)
			Me.panelControl1.TabIndex = 9
			' 
			' sbSelectSomeElements
			' 
			Me.sbSelectSomeElements.Location = New System.Drawing.Point(116, 12)
			Me.sbSelectSomeElements.Name = "sbSelectSomeElements"
			Me.sbSelectSomeElements.Size = New System.Drawing.Size(160, 23)
			Me.sbSelectSomeElements.TabIndex = 13
			Me.sbSelectSomeElements.Text = "Select"
'			Me.sbSelectSomeElements.Click += New System.EventHandler(Me.sbSelectSomeElementsClick)
			' 
			' cheMultiselect
			' 
			Me.cheMultiselect.Location = New System.Drawing.Point(19, 14)
			Me.cheMultiselect.Name = "cheMultiselect"
			Me.cheMultiselect.Properties.AutoWidth = True
            Me.cheMultiselect.Properties.Caption = "Multi-Select"
            Me.cheMultiselect.Size = New System.Drawing.Size(76, 19)
			Me.cheMultiselect.TabIndex = 12
'			Me.cheMultiselect.CheckedChanged += New System.EventHandler(Me.cheMultiselectCheckedChanged)
			' 
			' lblMultiselectMode
			' 
			Me.lblMultiselectMode.Location = New System.Drawing.Point(19, 47)
			Me.lblMultiselectMode.Name = "lblMultiselectMode"
			Me.lblMultiselectMode.Size = New System.Drawing.Size(87, 13)
			Me.lblMultiselectMode.TabIndex = 5
            Me.lblMultiselectMode.Text = "Multi-Select Mode:"
            ' 
            ' cbMultiselectMode
            ' 
            Me.cbMultiselectMode.Location = New System.Drawing.Point(116, 44)
			Me.cbMultiselectMode.Name = "cbMultiselectMode"
			Me.cbMultiselectMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbMultiselectMode.Size = New System.Drawing.Size(160, 20)
			Me.cbMultiselectMode.TabIndex = 4
'			Me.cbMultiselectMode.SelectedIndexChanged += New System.EventHandler(Me.cbMultiselectModeSelectedIndexChanged)
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 75)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(784, 8)
			Me.panelControl2.TabIndex = 10
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(0, 83)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.OptionsMenu.EnableContextMenu = True
			Me.vGridControl1.OptionsView.MinRowAutoHeight = 20
			Me.vGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1})
			Me.vGridControl1.Size = New System.Drawing.Size(784, 349)
			Me.vGridControl1.TabIndex = 11
			' 
			' repositoryItemLookUpEdit1
			' 
			Me.repositoryItemLookUpEdit1.AutoHeight = False
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")})
			Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
			Me.repositoryItemLookUpEdit1.DropDownRows = 10
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			Me.repositoryItemLookUpEdit1.PopupWidth = 220
			Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
			' 
			' Multiselect
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Multiselect"
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.cheMultiselect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbMultiselectMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private lblMultiselectMode As XtraEditors.LabelControl
		Private WithEvents cheMultiselect As XtraEditors.CheckEdit
		Private WithEvents cbMultiselectMode As XtraEditors.ImageComboBoxEdit
		Private WithEvents sbSelectSomeElements As XtraEditors.SimpleButton
	End Class
End Namespace

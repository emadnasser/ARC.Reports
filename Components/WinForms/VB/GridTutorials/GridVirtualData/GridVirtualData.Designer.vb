Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridVirtualData
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
            Me.panel1 = New DevExpress.XtraEditors.PanelControl
            Me.controlNavigator1 = New DevExpress.XtraEditors.ControlNavigator
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton
            Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit
            Me.label4 = New DevExpress.XtraEditors.LabelControl
            Me.label3 = New DevExpress.XtraEditors.LabelControl
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.controlNavigator1)
            Me.panel1.Controls.Add(Me.checkEdit1)
            Me.panel1.Controls.Add(Me.simpleButton1)
            Me.panel1.Controls.Add(Me.spinEdit2)
            Me.panel1.Controls.Add(Me.spinEdit1)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(640, 75)
            Me.panel1.TabIndex = 3
            '
            'controlNavigator1
            '
            Me.controlNavigator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.controlNavigator1.Buttons.Append.Visible = False
            Me.controlNavigator1.Buttons.CancelEdit.Visible = False
            Me.controlNavigator1.Buttons.Edit.Visible = False
            Me.controlNavigator1.Buttons.EndEdit.Visible = False
            Me.controlNavigator1.Buttons.Remove.Visible = False
            Me.controlNavigator1.Location = New System.Drawing.Point(382, 45)
            Me.controlNavigator1.Name = "controlNavigator1"
            Me.controlNavigator1.NavigatableControl = Me.gridControl1
            Me.controlNavigator1.ShowToolTips = True
            Me.controlNavigator1.Size = New System.Drawing.Size(240, 21)
            Me.controlNavigator1.TabIndex = 12
            Me.controlNavigator1.Text = "controlNavigator1"
            Me.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 83)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(640, 283)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsMenu.EnableColumnMenu = False
            Me.gridView1.OptionsMenu.EnableFooterMenu = False
            Me.gridView1.OptionsMenu.EnableGroupPanelMenu = False
            Me.gridView1.OptionsView.ColumnAutoWidth = False
            '
            'checkEdit1
            '
            Me.checkEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.checkEdit1.Location = New System.Drawing.Point(522, 14)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Use &DataStore"
            Me.checkEdit1.Size = New System.Drawing.Size(103, 18)
            Me.checkEdit1.TabIndex = 11
            '
            'simpleButton1
            '
            Me.simpleButton1.Location = New System.Drawing.Point(12, 42)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(280, 24)
            Me.simpleButton1.TabIndex = 10
            Me.simpleButton1.Text = "Set Row/Column count"
            '
            'spinEdit2
            '
            Me.spinEdit2.EditValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinEdit2.Location = New System.Drawing.Point(208, 13)
            Me.spinEdit2.Name = "spinEdit2"
            Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinEdit2.Properties.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEdit2.Properties.IsFloatValue = False
            Me.spinEdit2.Properties.Mask.EditMask = "N00"
            Me.spinEdit2.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.spinEdit2.Size = New System.Drawing.Size(84, 20)
            Me.spinEdit2.TabIndex = 9
            '
            'spinEdit1
            '
            Me.spinEdit1.EditValue = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.spinEdit1.Location = New System.Drawing.Point(48, 13)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinEdit1.Properties.Increment = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinEdit1.Properties.IsFloatValue = False
            Me.spinEdit1.Properties.Mask.EditMask = "N00"
            Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() {10000000, 0, 0, 0})
            Me.spinEdit1.Size = New System.Drawing.Size(84, 20)
            Me.spinEdit1.TabIndex = 8
            '
            'label4
            '
            Me.label4.Location = New System.Drawing.Point(158, 17)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(44, 13)
            Me.label4.TabIndex = 7
            Me.label4.Text = "Columns:"
            '
            'label3
            '
            Me.label3.Location = New System.Drawing.Point(12, 17)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(30, 13)
            Me.label3.TabIndex = 6
            Me.label3.Text = "Rows:"
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 75)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(640, 8)
            Me.panelControl1.TabIndex = 9
            '
            'GridVirtualData
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridVirtualData"
            Me.Size = New System.Drawing.Size(640, 366)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private label4 As DevExpress.XtraEditors.LabelControl
        Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private WithEvents spinEdit2 As DevExpress.XtraEditors.SpinEdit
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private controlNavigator1 As DevExpress.XtraEditors.ControlNavigator
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace

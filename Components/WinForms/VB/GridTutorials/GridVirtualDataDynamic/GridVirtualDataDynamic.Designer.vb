Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridVirtualDataDynamic
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
            Me.checkEditAddColumns = New DevExpress.XtraEditors.CheckEdit
            Me.checkEditAddRows = New DevExpress.XtraEditors.CheckEdit
            Me.lbListDimension = New DevExpress.XtraEditors.LabelControl
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.checkEditAddColumns.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEditAddRows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.checkEditAddColumns)
            Me.panel1.Controls.Add(Me.checkEditAddRows)
            Me.panel1.Controls.Add(Me.lbListDimension)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(590, 40)
            Me.panel1.TabIndex = 3
            '
            'checkEditAddColumns
            '
            Me.checkEditAddColumns.EditValue = True
            Me.checkEditAddColumns.Location = New System.Drawing.Point(174, 12)
            Me.checkEditAddColumns.Name = "checkEditAddColumns"
            Me.checkEditAddColumns.Properties.Caption = "Dynamic column adding"
            Me.checkEditAddColumns.Size = New System.Drawing.Size(156, 18)
            Me.checkEditAddColumns.TabIndex = 5
            '
            'checkEditAddRows
            '
            Me.checkEditAddRows.EditValue = True
            Me.checkEditAddRows.Location = New System.Drawing.Point(12, 12)
            Me.checkEditAddRows.Name = "checkEditAddRows"
            Me.checkEditAddRows.Properties.Caption = "Dynamic row adding"
            Me.checkEditAddRows.Size = New System.Drawing.Size(156, 18)
            Me.checkEditAddRows.TabIndex = 4
            '
            'lbListDimension
            '
            Me.lbListDimension.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbListDimension.Appearance.Options.UseTextOptions = True
            Me.lbListDimension.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbListDimension.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbListDimension.Location = New System.Drawing.Point(360, 10)
            Me.lbListDimension.Name = "lbListDimension"
            Me.lbListDimension.Size = New System.Drawing.Size(214, 20)
            Me.lbListDimension.TabIndex = 3
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 48)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(590, 318)
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
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 40)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(590, 8)
            Me.panelControl1.TabIndex = 9
            '
            'GridVirtualDataDynamic
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridVirtualDataDynamic"
            Me.Size = New System.Drawing.Size(590, 366)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.checkEditAddColumns.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEditAddRows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private lbListDimension As DevExpress.XtraEditors.LabelControl
		Private WithEvents checkEditAddRows As DevExpress.XtraEditors.CheckEdit
		Private checkEditAddColumns As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace

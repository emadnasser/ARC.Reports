Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridXMLReader
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.label3 = New DevExpress.XtraEditors.LabelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Name = ""
            Me.gridControl1.Location = New System.Drawing.Point(0, 47)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(593, 319)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsDetail.EnableDetailToolTip = True
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.comboBoxEdit1)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(593, 39)
            Me.panel1.TabIndex = 5
            ' 
            ' comboBoxEdit1
            ' 
            Me.comboBoxEdit1.EditValue = "comboBoxEdit1"
            Me.comboBoxEdit1.Location = New System.Drawing.Point(82, 9)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit1.Size = New System.Drawing.Size(156, 20)
            Me.comboBoxEdit1.TabIndex = 2
            '			Me.comboBoxEdit1.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEdit1_SelectedIndexChanged);
            ' 
            ' label3
            ' 
            Me.label3.Location = New System.Drawing.Point(12, 12)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(64, 16)
            Me.label3.TabIndex = 1
            Me.label3.Text = "Xml Tabels:"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 39)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(593, 8)
            Me.panelControl1.TabIndex = 9
            ' 
            ' GridXMLReader
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridXMLReader"
            Me.Size = New System.Drawing.Size(593, 366)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            '			Me.Load += New System.EventHandler(Me.GridXMLReader_Load);
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace

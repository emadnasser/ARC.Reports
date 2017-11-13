Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridDragDropExternal
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
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.panel1 = New DevExpress.XtraEditors.PanelControl
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl
            Me.label3 = New DevExpress.XtraEditors.LabelControl
            Me.splitter1 = New DevExpress.XtraEditors.SplitterControl
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(465, 366)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsView.ColumnAutoWidth = False
            '
            'panel1
            '
            Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panel1.Controls.Add(Me.listBoxControl1)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(471, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(224, 366)
            Me.panel1.TabIndex = 5
            '
            'listBoxControl1
            '
            Me.listBoxControl1.AllowDrop = True
            Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl1.ItemHeight = 15
            Me.listBoxControl1.Location = New System.Drawing.Point(0, 17)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(224, 349)
            Me.listBoxControl1.TabIndex = 3
            '
            'label3
            '
            Me.label3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
            Me.label3.Appearance.Options.UseFont = True
            Me.label3.Dock = System.Windows.Forms.DockStyle.Top
            Me.label3.Location = New System.Drawing.Point(0, 0)
            Me.label3.Name = "label3"
            Me.label3.Padding = New System.Windows.Forms.Padding(2)
            Me.label3.Size = New System.Drawing.Size(106, 17)
            Me.label3.TabIndex = 2
            Me.label3.Text = "Drag && Drop here:"
            '
            'splitter1
            '
            Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitter1.Location = New System.Drawing.Point(465, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(6, 366)
            Me.splitter1.TabIndex = 6
            Me.splitter1.TabStop = False
            '
            'GridDragDropExternal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridDragDropExternal"
            Me.Size = New System.Drawing.Size(695, 366)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private splitter1 As DevExpress.XtraEditors.SplitterControl
        Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private components As System.ComponentModel.Container = Nothing
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridDoubleClickRow
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
            Me.lbRow = New DevExpress.XtraEditors.LabelControl
            Me.label1 = New DevExpress.XtraEditors.LabelControl
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panel1.Controls.Add(Me.lbRow)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 430)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(693, 36)
            Me.panel1.TabIndex = 3
            '
            'lbRow
            '
            Me.lbRow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbRow.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbRow.Appearance.Options.UseBackColor = True
            Me.lbRow.Appearance.Options.UseTextOptions = True
            Me.lbRow.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.lbRow.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.lbRow.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbRow.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbRow.Location = New System.Drawing.Point(35, 11)
            Me.lbRow.Name = "lbRow"
            Me.lbRow.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.lbRow.Size = New System.Drawing.Size(658, 16)
            Me.lbRow.TabIndex = 6
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(4, 12)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(25, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Row:"
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.advBandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(693, 430)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.advBandedGridView1})
            '
            'advBandedGridView1
            '
            Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1})
            Me.advBandedGridView1.GridControl = Me.gridControl1
            Me.advBandedGridView1.Name = "advBandedGridView1"
            '
            'gridBand1
            '
            Me.gridBand1.Caption = "gridBand1"
            Me.gridBand1.Name = "gridBand1"
            '
            'GridDoubleClickRow
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridDoubleClickRow"
            Me.Size = New System.Drawing.Size(693, 466)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
        Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Private lbRow As DevExpress.XtraEditors.LabelControl
        Private label1 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace

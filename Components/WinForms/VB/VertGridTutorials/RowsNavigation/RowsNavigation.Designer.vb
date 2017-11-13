Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class RowsNavigation
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
			Me.panel2 = New DevExpress.XtraEditors.PanelControl()
			Me.button4 = New DevExpress.XtraEditors.SimpleButton()
			Me.button3 = New DevExpress.XtraEditors.SimpleButton()
			Me.button2 = New DevExpress.XtraEditors.SimpleButton()
			Me.button1 = New DevExpress.XtraEditors.SimpleButton()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.button4)
			Me.panel2.Controls.Add(Me.button3)
			Me.panel2.Controls.Add(Me.button2)
			Me.panel2.Controls.Add(Me.button1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(341, 41)
			Me.panel2.TabIndex = 10
			' 
			' button4
			' 
			Me.button4.Location = New System.Drawing.Point(254, 8)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(76, 24)
			Me.button4.TabIndex = 3
			Me.button4.Text = "Focus Last"
'			Me.button4.Click += New System.EventHandler(Me.button4_Click);
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(172, 8)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(76, 24)
			Me.button3.TabIndex = 2
			Me.button3.Text = "Focus Next"
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(90, 8)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(76, 24)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Focus Prev"
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(8, 8)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(76, 24)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Focus First"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
			Me.vGridControl1.Location = New System.Drawing.Point(0, 49)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.Size = New System.Drawing.Size(341, 449)
			Me.vGridControl1.TabIndex = 11
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 41)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(341, 8)
			Me.panelControl1.TabIndex = 14
			' 
			' RowsNavigation
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "RowsNavigation"
			Me.Size = New System.Drawing.Size(341, 498)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.RowsNavigation_Load);
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel2 As PanelControl
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private WithEvents button1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents button2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents button3 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents button4 As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As PanelControl

	End Class
End Namespace

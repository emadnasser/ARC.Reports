Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class SimpleAlphaBlending
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimpleAlphaBlending))
			Me.panel2 = New DevExpress.XtraEditors.PanelControl()
			Me.button1 = New DevExpress.XtraEditors.SimpleButton()
			Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.xtraVertGridBlending1 = New DevExpress.XtraVerticalGrid.Blending.XtraVertGridBlending()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.button1)
			Me.panel2.Controls.Add(Me.checkBox1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(407, 44)
			Me.panel2.TabIndex = 8
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(120, 10)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(112, 24)
			Me.button1.TabIndex = 3
			Me.button1.Text = "Adjustment..."
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' checkBox1
			' 
			Me.checkBox1.Location = New System.Drawing.Point(12, 12)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Properties.Caption = "Alpha Blending"
			Me.checkBox1.Size = New System.Drawing.Size(100, 18)
			Me.checkBox1.TabIndex = 2
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' vGridControl1
			' 
			Me.vGridControl1.BackgroundImage = (CType(resources.GetObject("vGridControl1.BackgroundImage"), System.Drawing.Image))
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(0, 52)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.Size = New System.Drawing.Size(407, 474)
			Me.vGridControl1.TabIndex = 9
			' 
			' xtraVertGridBlending1
			' 
			Me.xtraVertGridBlending1.Enabled = False
			Me.xtraVertGridBlending1.VertGridControl = Me.vGridControl1
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 44)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(407, 8)
			Me.panelControl1.TabIndex = 10
			' 
			' SimpleAlphaBlending
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "SimpleAlphaBlending"
			Me.Size = New System.Drawing.Size(407, 526)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.SimpleAlphaBlending_Load);
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel2 As PanelControl
		Private WithEvents button1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private xtraVertGridBlending1 As DevExpress.XtraVerticalGrid.Blending.XtraVertGridBlending
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As PanelControl

	End Class
End Namespace

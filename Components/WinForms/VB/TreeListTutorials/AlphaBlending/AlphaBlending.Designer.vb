Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class AlphaBlending
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlphaBlending))
			Me.panel2 = New DevExpress.XtraEditors.PanelControl()
			Me.button1 = New DevExpress.XtraEditors.SimpleButton()
			Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.xtraTreeListBlending1 = New DevExpress.XtraTreeList.Blending.XtraTreeListBlending()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.panel2.Size = New System.Drawing.Size(555, 44)
			Me.panel2.TabIndex = 6
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(118, 10)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(100, 24)
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
			' treeList1
			' 
			Me.treeList1.Appearance.OddRow.BackColor = System.Drawing.Color.MistyRose
			Me.treeList1.Appearance.OddRow.Options.UseBackColor = True
			Me.treeList1.BackgroundImage = (CType(resources.GetObject("treeList1.BackgroundImage"), System.Drawing.Image))
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 52)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsView.EnableAppearanceEvenRow = True
			Me.treeList1.OptionsView.EnableAppearanceOddRow = True
			Me.treeList1.Size = New System.Drawing.Size(555, 317)
			Me.treeList1.TabIndex = 7
			' 
			' xtraTreeListBlending1
			' 
			Me.xtraTreeListBlending1.TreeListControl = Me.treeList1
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 44)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(555, 8)
			Me.panelControl1.TabIndex = 8
			' 
			' AlphaBlending
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "AlphaBlending"
			Me.Size = New System.Drawing.Size(555, 369)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel2 As PanelControl
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private WithEvents button1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
		Private xtraTreeListBlending1 As DevExpress.XtraTreeList.Blending.XtraTreeListBlending
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As PanelControl

	End Class
End Namespace

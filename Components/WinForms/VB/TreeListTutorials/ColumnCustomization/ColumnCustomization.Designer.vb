Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class ColumnCustomization
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
			Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
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
			Me.panel2.Controls.Add(Me.checkBox1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(563, 41)
			Me.panel2.TabIndex = 6
			' 
			' checkBox1
			' 
			Me.checkBox1.Location = New System.Drawing.Point(12, 12)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Properties.Caption = "Runtime Column Customization"
			Me.checkBox1.Size = New System.Drawing.Size(204, 18)
			Me.checkBox1.TabIndex = 0
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 49)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(563, 251)
			Me.treeList1.TabIndex = 7
'			Me.treeList1.HideCustomizationForm += New System.EventHandler(Me.treeList1_HideCustomizationForm);
'			Me.treeList1.ShowCustomizationForm += New System.EventHandler(Me.treeList1_ShowCustomizationForm);
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 41)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(563, 8)
			Me.panelControl1.TabIndex = 9
			' 
			' ColumnCustomization
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "ColumnCustomization"
			Me.Size = New System.Drawing.Size(563, 300)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.ColumnCustomization_Load);
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel2 As PanelControl
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace

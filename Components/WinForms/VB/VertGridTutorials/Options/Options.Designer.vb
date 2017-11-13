Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class Options
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
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			Me.panel2 = New PanelControl()
			Me.checkedListBox2 = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.label4 = New System.Windows.Forms.Label()
			Me.checkedListBox1 = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.label3 = New System.Windows.Forms.Label()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.panel2.SuspendLayout()
			CType(Me.checkedListBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkedListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitter1
			' 
			Me.splitter1.Location = New System.Drawing.Point(164, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(6, 457)
			Me.splitter1.TabIndex = 11
			Me.splitter1.TabStop = False
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.checkedListBox2)
			Me.panel2.Controls.Add(Me.label4)
			Me.panel2.Controls.Add(Me.checkedListBox1)
			Me.panel2.Controls.Add(Me.label3)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Padding = New System.Windows.Forms.Padding(4)
			Me.panel2.Size = New System.Drawing.Size(164, 457)
			Me.panel2.TabIndex = 10
			' 
			' checkedListBox2
			' 
			Me.checkedListBox2.CheckOnClick = True
			Me.checkedListBox2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.checkedListBox2.ItemHeight = 16
			Me.checkedListBox2.Location = New System.Drawing.Point(4, 228)
			Me.checkedListBox2.Name = "checkedListBox2"
			Me.checkedListBox2.Size = New System.Drawing.Size(156, 225)
			Me.checkedListBox2.TabIndex = 2
'			Me.checkedListBox2.ItemCheck += New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(Me.checkedListBox2_ItemCheck);
			' 
			' label4
			' 
			Me.label4.Dock = System.Windows.Forms.DockStyle.Top
			Me.label4.Location = New System.Drawing.Point(4, 208)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(156, 20)
			Me.label4.TabIndex = 3
			Me.label4.Text = "Behavor Options:"
			Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' checkedListBox1
			' 
			Me.checkedListBox1.CheckOnClick = True
			Me.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Top
			Me.checkedListBox1.ItemHeight = 16
			Me.checkedListBox1.Location = New System.Drawing.Point(4, 24)
			Me.checkedListBox1.Name = "checkedListBox1"
			Me.checkedListBox1.Size = New System.Drawing.Size(156, 184)
			Me.checkedListBox1.TabIndex = 0
'			Me.checkedListBox1.ItemCheck += New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(Me.checkedListBox1_ItemCheck);
			' 
			' label3
			' 
			Me.label3.Dock = System.Windows.Forms.DockStyle.Top
			Me.label3.Location = New System.Drawing.Point(4, 4)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(156, 20)
			Me.label3.TabIndex = 1
			Me.label3.Text = "View Options:"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(170, 0)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.Size = New System.Drawing.Size(340, 457)
			Me.vGridControl1.TabIndex = 12
			' 
			' Options
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "Options"
			Me.Size = New System.Drawing.Size(510, 457)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.Options_Load);
			Me.panel2.ResumeLayout(False)
			CType(Me.checkedListBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkedListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private panel2 As PanelControl
		Private WithEvents checkedListBox2 As DevExpress.XtraEditors.CheckedListBoxControl
		Private label4 As System.Windows.Forms.Label
		Private WithEvents checkedListBox1 As DevExpress.XtraEditors.CheckedListBoxControl
		Private label3 As System.Windows.Forms.Label
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace

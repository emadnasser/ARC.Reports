Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class DragDrop
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
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.listBox1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.label3 = New System.Windows.Forms.Label()
			Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.panel2.SuspendLayout()
			CType(Me.listBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitter1
			' 
			Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
			Me.splitter1.Location = New System.Drawing.Point(289, 4)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(8, 474)
			Me.splitter1.TabIndex = 11
			Me.splitter1.TabStop = False
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.listBox1)
			Me.panel2.Controls.Add(Me.label3)
			Me.panel2.Controls.Add(Me.checkBox1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel2.Location = New System.Drawing.Point(297, 4)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(184, 474)
			Me.panel2.TabIndex = 10
			' 
			' listBox1
			' 
			Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBox1.ItemHeight = 16
			Me.listBox1.Location = New System.Drawing.Point(0, 42)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(184, 432)
			Me.listBox1.TabIndex = 2
			' 
			' label3
			' 
			Me.label3.Dock = System.Windows.Forms.DockStyle.Top
			Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.label3.Location = New System.Drawing.Point(0, 18)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(184, 24)
			Me.label3.TabIndex = 3
			Me.label3.Text = "Drag && Drop here"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' checkBox1
			' 
			Me.checkBox1.Dock = System.Windows.Forms.DockStyle.Top
			Me.checkBox1.Location = New System.Drawing.Point(0, 0)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Properties.Caption = "DragRowHeaders"
			Me.checkBox1.Size = New System.Drawing.Size(184, 18)
			Me.checkBox1.TabIndex = 0
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(4, 4)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.OptionsBehavior.DragRowHeaders = True
			Me.vGridControl1.OptionsBehavior.UseTabKey = False
			Me.vGridControl1.Size = New System.Drawing.Size(285, 474)
			Me.vGridControl1.TabIndex = 12
'			Me.vGridControl1.EndDragRow += New DevExpress.XtraVerticalGrid.Events.EndDragRowEventHandler(Me.vGridControl1_EndDragRow);
'			Me.vGridControl1.ProcessDragRow += New DevExpress.XtraVerticalGrid.Events.ProcessDragRowEventHandler(Me.vGridControl1_ProcessDragRow);
			' 
			' DragDrop
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "DragDrop"
			Me.Size = New System.Drawing.Size(485, 482)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.DragDrop_Load);
			Me.panel2.ResumeLayout(False)
			CType(Me.listBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private panel2 As System.Windows.Forms.Panel
		Private listBox1 As DevExpress.XtraEditors.ListBoxControl
		Private label3 As System.Windows.Forms.Label
		Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraLayout.Demos
	Public Partial Class frmPassword
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPassword))
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.sbCustomization = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.label1 = New DevExpress.Utils.Frames.ApplicationCaption8_1()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.sbCustomization)
			Me.layoutControl1.Controls.Add(Me.simpleButton2)
			Me.layoutControl1.Controls.Add(Me.simpleButton1)
			Me.layoutControl1.Controls.Add(Me.comboBoxEdit1)
			Me.layoutControl1.Controls.Add(Me.textEdit2)
			Me.layoutControl1.Controls.Add(Me.textEdit1)
			Me.layoutControl1.Controls.Add(Me.label1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsView.AllowItemSkinning = False
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(452, 218)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' sbCustomization
			' 
			Me.sbCustomization.Image = (CType(resources.GetObject("sbCustomization.Image"), System.Drawing.Image))
			Me.sbCustomization.Location = New System.Drawing.Point(6, 189)
			Me.sbCustomization.Name = "sbCustomization"
			Me.sbCustomization.Size = New System.Drawing.Size(28, 24)
			Me.sbCustomization.StyleController = Me.layoutControl1
			Me.sbCustomization.TabIndex = 9
			Me.sbCustomization.TabStop = False
			Me.sbCustomization.ToolTip = "Customization form"
			Me.sbCustomization.ToolTipTitle = "Show"
'			Me.sbCustomization.Click += New System.EventHandler(Me.sbCustomization_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.simpleButton2.Location = New System.Drawing.Point(359, 189)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(88, 22)
			Me.simpleButton2.StyleController = Me.layoutControl1
			Me.simpleButton2.TabIndex = 8
			Me.simpleButton2.TabStop = False
			Me.simpleButton2.Text = "&Cancel"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.simpleButton1.Location = New System.Drawing.Point(263, 189)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(85, 22)
			Me.simpleButton1.StyleController = Me.layoutControl1
			Me.simpleButton1.TabIndex = 7
			Me.simpleButton1.TabStop = False
			Me.simpleButton1.Text = "&OK"
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.EditValue = ""
			Me.comboBoxEdit1.Location = New System.Drawing.Point(146, 143)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Properties.Items.AddRange(New Object() { "Customers", "Employees", "MyDatabase1"})
			Me.comboBoxEdit1.Size = New System.Drawing.Size(224, 20)
			Me.comboBoxEdit1.StyleController = Me.layoutControl1
			Me.comboBoxEdit1.TabIndex = 6
			' 
			' textEdit2
			' 
			Me.textEdit2.EditValue = "12345"
			Me.textEdit2.Location = New System.Drawing.Point(146, 112)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Properties.PasswordChar = "*"c
			Me.textEdit2.Size = New System.Drawing.Size(224, 20)
			Me.textEdit2.StyleController = Me.layoutControl1
			Me.textEdit2.TabIndex = 5
			' 
			' textEdit1
			' 
			Me.textEdit1.EditValue = "user"
			Me.textEdit1.Location = New System.Drawing.Point(146, 81)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(224, 20)
			Me.textEdit1.StyleController = Me.layoutControl1
			Me.textEdit1.TabIndex = 4
			' 
			' label1
			' 
			Me.label1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(118))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(255))))))
			Me.label1.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(46))))), (CInt(Fix((CByte(156))))), (CInt(Fix((CByte(253))))))
			Me.label1.Font = New System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold)
			Me.label1.Location = New System.Drawing.Point(6, 6)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(441, 48)
			Me.label1.TabIndex = 3
			Me.label1.TabStop = False
			Me.label1.Text = "Enter your data"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.emptySpaceItem3, Me.layoutControlItem5, Me.layoutControlItem6, Me.emptySpaceItem4, Me.layoutControlItem7, Me.emptySpaceItem5})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(452, 218)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "MainGroup"
			Me.layoutControlGroup1.TextVisible = True
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.label1
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.MinSize = New System.Drawing.Size(1, 59)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem1.Size = New System.Drawing.Size(452, 59)
			Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutControlItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem1.Text = "Title"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.textEdit1
			Me.layoutControlItem2.Location = New System.Drawing.Point(70, 75)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem2.Size = New System.Drawing.Size(305, 31)
			Me.layoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem2.Text = "&User Name:   "
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(65, 20)
			Me.layoutControlItem2.TextVisible = True
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.textEdit2
			Me.layoutControlItem3.Location = New System.Drawing.Point(70, 106)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem3.Size = New System.Drawing.Size(305, 31)
			Me.layoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem3.Text = "&Password:"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(65, 20)
			Me.layoutControlItem3.TextVisible = True
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.comboBoxEdit1
			Me.layoutControlItem4.Location = New System.Drawing.Point(70, 137)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem4.Size = New System.Drawing.Size(305, 31)
			Me.layoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem4.Text = "&Database:"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(65, 20)
			Me.layoutControlItem4.TextVisible = True
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 75)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.emptySpaceItem1.Size = New System.Drawing.Size(70, 93)
			Me.emptySpaceItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.Location = New System.Drawing.Point(375, 75)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.emptySpaceItem2.Size = New System.Drawing.Size(77, 93)
			Me.emptySpaceItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.emptySpaceItem2.Text = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.Location = New System.Drawing.Point(39, 183)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.emptySpaceItem3.Size = New System.Drawing.Size(218, 35)
			Me.emptySpaceItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.emptySpaceItem3.Text = "emptySpaceItem3"
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.simpleButton1
			Me.layoutControlItem5.Location = New System.Drawing.Point(257, 183)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem5.Size = New System.Drawing.Size(96, 35)
			Me.layoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem5.Text = "OK"
			Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Right
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.simpleButton2
			Me.layoutControlItem6.Location = New System.Drawing.Point(353, 183)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem6.Size = New System.Drawing.Size(99, 35)
			Me.layoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem6.Text = "Cancel"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem6.TextToControlDistance = 0
			Me.layoutControlItem6.TextVisible = False
			' 
			' emptySpaceItem4
			' 
			Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 168)
			Me.emptySpaceItem4.Name = "emptySpaceItem4"
			Me.emptySpaceItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.emptySpaceItem4.Size = New System.Drawing.Size(452, 15)
			Me.emptySpaceItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.emptySpaceItem4.Text = "emptySpaceItem4"
			Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.sbCustomization
			Me.layoutControlItem7.Location = New System.Drawing.Point(0, 183)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem7.Size = New System.Drawing.Size(39, 35)
			Me.layoutControlItem7.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem7.Text = "Customization"
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem7.TextToControlDistance = 0
			Me.layoutControlItem7.TextVisible = False
			' 
			' emptySpaceItem5
			' 
			Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 59)
			Me.emptySpaceItem5.Name = "emptySpaceItem5"
			Me.emptySpaceItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.emptySpaceItem5.Size = New System.Drawing.Size(452, 16)
			Me.emptySpaceItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.emptySpaceItem5.Text = "emptySpaceItem5"
			Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
			' 
			' frmPassword
			' 
			Me.AcceptButton = Me.simpleButton1
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.simpleButton2
			Me.ClientSize = New System.Drawing.Size(452, 218)
			Me.Controls.Add(Me.layoutControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
			Me.Name = "frmPassword"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "Login"
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private label1 As DevExpress.Utils.Frames.ApplicationCaption8_1
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
		Private WithEvents sbCustomization As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraLayout.Demos
	Public Partial Class Browser
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit
            Me.urlEdit = New DevExpress.XtraEditors.ButtonEdit
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.urlEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.comboBoxEdit1)
            Me.layoutControl1.Controls.Add(Me.checkEdit2)
            Me.layoutControl1.Controls.Add(Me.checkEdit1)
            Me.layoutControl1.Controls.Add(Me.urlEdit)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(435, 264)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'comboBoxEdit1
            '
            Me.comboBoxEdit1.Location = New System.Drawing.Point(327, 34)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit1.Size = New System.Drawing.Size(94, 20)
            Me.comboBoxEdit1.StyleController = Me.layoutControl1
            Me.comboBoxEdit1.TabIndex = 9
            '
            'checkEdit2
            '
            Me.checkEdit2.AutoSizeInLayoutControl = True
            Me.checkEdit2.Location = New System.Drawing.Point(144, 34)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = "Vertical headers"
            Me.checkEdit2.Size = New System.Drawing.Size(100, 19)
            Me.checkEdit2.StyleController = Me.layoutControl1
            Me.checkEdit2.TabIndex = 8
            '
            'checkEdit1
            '
            Me.checkEdit1.AutoSizeInLayoutControl = True
            Me.checkEdit1.Location = New System.Drawing.Point(14, 34)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Multi-line tab headers"
            Me.checkEdit1.Size = New System.Drawing.Size(126, 19)
            Me.checkEdit1.StyleController = Me.layoutControl1
            Me.checkEdit1.TabIndex = 7
            '
            'urlEdit
            '
            Me.urlEdit.Location = New System.Drawing.Point(2, 70)
            Me.urlEdit.Name = "urlEdit"
            Me.urlEdit.Properties.NullText = "Type URL here"
            Me.urlEdit.Size = New System.Drawing.Size(431, 20)
            Me.urlEdit.StyleController = Me.layoutControl1
            Me.urlEdit.TabIndex = 6
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tabbedControlGroup1, Me.layoutControlItem3, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(435, 264)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            '
            'tabbedControlGroup1
            '
            Me.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1"
            Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 92)
            Me.tabbedControlGroup1.MultiLine = DevExpress.Utils.DefaultBoolean.[False]
            Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
            Me.tabbedControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.tabbedControlGroup1.SelectedTabPage = Me.layoutControlGroup3
            Me.tabbedControlGroup1.SelectedTabPageIndex = 0
            Me.tabbedControlGroup1.Size = New System.Drawing.Size(435, 172)
            Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3})
            Me.tabbedControlGroup1.Text = "tabbedControlGroup1"
            '
            'layoutControlGroup3
            '
            Me.layoutControlGroup3.CustomizationFormText = "..."
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(429, 146)
            Me.layoutControlGroup3.Text = "..."
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.urlEdit
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 68)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(435, 24)
            Me.layoutControlItem3.Text = "layoutControlItem3"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            '
            'layoutControlGroup2
            '
            Me.layoutControlGroup2.CustomizationFormText = "Options"
            Me.layoutControlGroup2.ExpandButtonVisible = True
            Me.layoutControlGroup2.ExpandOnDoubleClick = True
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem4})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.OptionsToolTip.ToolTip = "Double-click the group caption to expand/collapse the group."
            Me.layoutControlGroup2.OptionsToolTip.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
            Me.layoutControlGroup2.Size = New System.Drawing.Size(435, 68)
            Me.layoutControlGroup2.Text = "Options"
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.checkEdit1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(130, 24)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.checkEdit2
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(130, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(104, 24)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.comboBoxEdit1
            Me.layoutControlItem4.CustomizationFormText = "Header location"
            Me.layoutControlItem4.Location = New System.Drawing.Point(234, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(177, 24)
            Me.layoutControlItem4.Text = "Header location"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(75, 13)
            '
            'Browser
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Browser"
            Me.Size = New System.Drawing.Size(435, 264)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.urlEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		Private WithEvents layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private WithEvents tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
		Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
		Private WithEvents urlEdit As DevExpress.XtraEditors.ButtonEdit
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		#End Region
		Private WithEvents checkEdit2 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private layoutControlGroup2 As LayoutControlGroup
		Private layoutControlItem1 As LayoutControlItem
		Private layoutControlItem2 As LayoutControlItem
		Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private layoutControlItem4 As LayoutControlItem
	End Class
End Namespace

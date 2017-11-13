Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class AddGroups
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
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
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.button1 = New DevExpress.XtraEditors.SimpleButton()
			Me.button2 = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.contentPanel_Renamed.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' contentPanel
			' 
			Me.contentPanel_Renamed.Controls.Add(Me.panelControl1)
			Me.contentPanel_Renamed.Controls.Add(Me.navBarControl1)
			Me.contentPanel_Renamed.Padding = New Padding(3, 3, 3, 3)
			Me.contentPanel_Renamed.Size = New Size(346, 273)
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Nothing
			Me.navBarControl1.Appearance.ItemDisabled.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.navBarControl1.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.navBarControl1.Appearance.ItemHotTracked.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.navBarControl1.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.navBarControl1.Appearance.ItemPressed.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.navBarControl1.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.navBarControl1.Location = New Point(4, 5)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 172
			Me.navBarControl1.Size = New Size(172, 264)
			Me.navBarControl1.StoreDefaultPaintStyleName = True
			Me.navBarControl1.TabIndex = 0
			Me.navBarControl1.Text = "navBarControl1"
			' 
			' button1
			' 
			Me.button1.Location = New Point(49, 2)
			Me.button1.Name = "button1"
			Me.button1.Size = New Size(110, 24)
			Me.button1.TabIndex = 6
			Me.button1.Text = "Add New Group"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.Location = New Point(49, 32)
			Me.button2.Name = "button2"
			Me.button2.Size = New Size(110, 24)
			Me.button2.TabIndex = 7
			Me.button2.Text = "Delete Last Group"
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.button1)
			Me.panelControl1.Controls.Add(Me.button2)
			Me.panelControl1.Location = New Point(176, 5)
			Me.panelControl1.Margin = New Padding(2, 2, 2, 2)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New Size(166, 264)
			Me.panelControl1.TabIndex = 8
			' 
			' AddGroups
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Name = "AddGroups"
			Me.Size = New Size(346, 273)
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.contentPanel_Renamed.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private WithEvents button1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents button2 As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As XtraEditors.PanelControl

	End Class
End Namespace

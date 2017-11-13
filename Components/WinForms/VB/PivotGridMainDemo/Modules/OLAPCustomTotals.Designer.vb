Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class OlapCustomTotals
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.controlPanel = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.totalsListBox = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			Me.separator1 = New DevExpress.XtraEditors.PanelControl()
			Me.panelError = New DevExpress.XtraEditors.PanelControl()
			Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.controlPanel.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.totalsListBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mainPanel.SuspendLayout()
			CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.separator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelError, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelError.SuspendLayout()
			CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' controlPanel
			' 
			Me.controlPanel.AutoSize = True
			Me.controlPanel.Controls.Add(Me.panelControl1)
			Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.controlPanel.Location = New System.Drawing.Point(0, 53)
			Me.controlPanel.Name = "controlPanel"
			Me.controlPanel.Size = New System.Drawing.Size(700, 79)
			Me.controlPanel.TabIndex = 7
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Controls.Add(Me.totalsListBox)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(2, 2)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(696, 75)
			Me.panelControl1.TabIndex = 1
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(14, 13)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(65, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Select Totals:"
			' 
			' totalsListBox
			' 
			Me.totalsListBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.totalsListBox.CheckOnClick = True
			Me.totalsListBox.ColumnWidth = 100
			Me.totalsListBox.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
			Me.totalsListBox.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() { New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Average", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Count", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Max"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Min"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("StdDev"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("StdDevp"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Sum"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Var"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Varp")})
			Me.totalsListBox.Location = New System.Drawing.Point(91, 12)
			Me.totalsListBox.MultiColumn = True
			Me.totalsListBox.Name = "totalsListBox"
			Me.totalsListBox.Size = New System.Drawing.Size(307, 58)
			Me.totalsListBox.TabIndex = 0
'			Me.totalsListBox.ItemCheck += New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(Me.chListBox_ItemCheck);
			' 
			' mainPanel
			' 
			Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.mainPanel.Controls.Add(Me.pivotGridControl)
			Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mainPanel.Location = New System.Drawing.Point(0, 140)
			Me.mainPanel.Name = "mainPanel"
			Me.mainPanel.Size = New System.Drawing.Size(700, 260)
			Me.mainPanel.TabIndex = 9
			' 
			' pivotGridControl
			' 
			Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl.Name = "pivotGridControl"
			Me.pivotGridControl.Size = New System.Drawing.Size(700, 260)
			Me.pivotGridControl.TabIndex = 6
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 132)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(700, 8)
			Me.paddingPanel.TabIndex = 8
			' 
			' separator1
			' 
			Me.separator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.separator1.Dock = System.Windows.Forms.DockStyle.Top
			Me.separator1.Location = New System.Drawing.Point(0, 45)
			Me.separator1.Name = "separator1"
			Me.separator1.Size = New System.Drawing.Size(700, 8)
			Me.separator1.TabIndex = 10
			' 
			' panelError
			' 
			Me.panelError.Controls.Add(Me.hyperLinkEdit1)
			Me.panelError.Controls.Add(Me.labelControl2)
			Me.panelError.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelError.Location = New System.Drawing.Point(0, 0)
			Me.panelError.Name = "panelError"
			Me.panelError.Size = New System.Drawing.Size(700, 45)
			Me.panelError.TabIndex = 11
			' 
			' hyperLinkEdit1
			' 
			Me.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB"
			Me.hyperLinkEdit1.Location = New System.Drawing.Point(456, 20)
			Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
			Me.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = True
			Me.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.hyperLinkEdit1.Properties.Caption = "www.microsoft.com"
			Me.hyperLinkEdit1.Properties.UseParentBackground = True
			Me.hyperLinkEdit1.Size = New System.Drawing.Size(100, 18)
			Me.hyperLinkEdit1.TabIndex = 1
			' 
			' labelControl2
			' 
			Me.labelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red
			Me.labelControl2.Appearance.Options.UseFont = True
			Me.labelControl2.Appearance.Options.UseForeColor = True
			Me.labelControl2.AutoEllipsis = True
			Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl2.Location = New System.Drawing.Point(14, 8)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(673, 28)
			Me.labelControl2.TabIndex = 0
			Me.labelControl2.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services" & " OLE DB 8.0 (or later) " & Constants.vbCrLf & "installed on your system. You can get the latest version of this provider here:"
			' 
			' OlapCustomTotals
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.mainPanel)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.controlPanel)
			Me.Controls.Add(Me.separator1)
			Me.Controls.Add(Me.panelError)
			Me.Name = "OlapCustomTotals"
			Me.Size = New System.Drawing.Size(700, 400)
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.controlPanel.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.totalsListBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mainPanel.ResumeLayout(False)
			CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.separator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelError, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelError.ResumeLayout(False)
			CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private controlPanel As DevExpress.XtraEditors.PanelControl
		Private mainPanel As DevExpress.XtraEditors.PanelControl
		Private paddingPanel As DevExpress.XtraEditors.PanelControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents totalsListBox As DevExpress.XtraEditors.CheckedListBoxControl
		Private pivotGridControl As PivotGridControl
		Private separator1 As DevExpress.XtraEditors.PanelControl
		Private panelError As DevExpress.XtraEditors.PanelControl
		Private hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace

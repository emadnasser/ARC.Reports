Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class AppearancesEditForm
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
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.lbcAppearances = New DevExpress.XtraEditors.ListBoxControl()
			Me.propertyGrid1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.lbcAppearances, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(5, 5)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.lbcAppearances)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.propertyGrid1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(382, 314)
			Me.splitContainerControl1.SplitterPosition = 156
			Me.splitContainerControl1.TabIndex = 7
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' lbcAppearances
			' 
			Me.lbcAppearances.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lbcAppearances.ItemHeight = 16
			Me.lbcAppearances.Location = New System.Drawing.Point(0, 0)
			Me.lbcAppearances.Name = "lbcAppearances"
			Me.lbcAppearances.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
			Me.lbcAppearances.Size = New System.Drawing.Size(152, 310)
			Me.lbcAppearances.SortOrder = System.Windows.Forms.SortOrder.Ascending
			Me.lbcAppearances.TabIndex = 24
'			Me.lbcAppearances.SelectedIndexChanged += New System.EventHandler(Me.lbcAppearances_SelectedIndexChanged);
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGrid1.Location = New System.Drawing.Point(0, 0)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.ServiceProvider = Nothing
			Me.propertyGrid1.Size = New System.Drawing.Size(216, 310)
			Me.propertyGrid1.TabIndex = 1
			' 
			' Appearances
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.ClientSize = New System.Drawing.Size(392, 324)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Appearances"
			Me.Padding = New System.Windows.Forms.Padding(5)
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "Appearances"
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.lbcAppearances, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private components As System.ComponentModel.Container = Nothing
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents lbcAppearances As DevExpress.XtraEditors.ListBoxControl
		Private propertyGrid1 As PropertyGridControl
	End Class
End Namespace

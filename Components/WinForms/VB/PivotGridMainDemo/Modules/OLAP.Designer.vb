Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class OLAP
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
			Me.panelConnection = New DevExpress.XtraEditors.PanelControl()
			Me.buttonNewConnection = New DevExpress.XtraEditors.SimpleButton()
			Me.splitPivotContainer = New DevExpress.XtraEditors.SplitContainerControl()
			Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.controlPanel = New DevExpress.XtraEditors.PanelControl()
			Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
			Me.separator2 = New DevExpress.XtraEditors.PanelControl()
			Me.separator1 = New DevExpress.XtraEditors.PanelControl()
			Me.panelError = New DevExpress.XtraEditors.PanelControl()
			Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panelConnection, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelConnection.SuspendLayout()
			CType(Me.splitPivotContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPivotContainer.SuspendLayout()
			CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.controlPanel.SuspendLayout()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mainPanel.SuspendLayout()
			CType(Me.separator2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.separator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelError, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelError.SuspendLayout()
			CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelConnection
			' 
			Me.panelConnection.Controls.Add(Me.buttonNewConnection)
			Me.panelConnection.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelConnection.Location = New System.Drawing.Point(0, 0)
			Me.panelConnection.Margin = New System.Windows.Forms.Padding(0)
			Me.panelConnection.Name = "panelConnection"
			Me.panelConnection.Size = New System.Drawing.Size(690, 43)
			Me.panelConnection.TabIndex = 0
			' 
			' buttonNewConnection
			' 
			Me.buttonNewConnection.Location = New System.Drawing.Point(14, 10)
			Me.buttonNewConnection.Name = "buttonNewConnection"
			Me.buttonNewConnection.Size = New System.Drawing.Size(109, 23)
			Me.buttonNewConnection.TabIndex = 0
			Me.buttonNewConnection.Text = "New Connection"
'			Me.buttonNewConnection.Click += New System.EventHandler(Me.buttonNewConnection_Click);
			' 
			' splitPivotContainer
			' 
			Me.splitPivotContainer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitPivotContainer.Location = New System.Drawing.Point(0, 0)
			Me.splitPivotContainer.Name = "splitPivotContainer"
			Me.splitPivotContainer.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
			Me.splitPivotContainer.Panel1.Text = "Panel1"
			Me.splitPivotContainer.Panel2.Controls.Add(Me.pivotGridControl)
			Me.splitPivotContainer.Panel2.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
			Me.splitPivotContainer.Panel2.Text = "Panel2"
			Me.splitPivotContainer.Size = New System.Drawing.Size(690, 368)
			Me.splitPivotContainer.SplitterPosition = 240
			Me.splitPivotContainer.TabIndex = 3
			Me.splitPivotContainer.Text = "splitContainerControl1"
			' 
			' pivotGridControl
			' 
			Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl.Location = New System.Drawing.Point(4, 0)
			Me.pivotGridControl.Name = "pivotGridControl"
			Me.pivotGridControl.OptionsCustomization.AllowFilterInCustomizationForm = True
			Me.pivotGridControl.OptionsCustomization.AllowSortInCustomizationForm = True
			Me.pivotGridControl.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
			Me.pivotGridControl.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
			Me.pivotGridControl.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree
			Me.pivotGridControl.OptionsView.ShowColumnHeaders = False
			Me.pivotGridControl.OptionsView.ShowDataHeaders = False
			Me.pivotGridControl.OptionsView.ShowFilterHeaders = False
			Me.pivotGridControl.OptionsView.ShowRowHeaders = False
			Me.pivotGridControl.OptionsView.ShowTotalsForSingleValues = True
			Me.pivotGridControl.Size = New System.Drawing.Size(441, 368)
			Me.pivotGridControl.TabIndex = 2
'			Me.pivotGridControl.ShowingCustomizationForm += New DevExpress.XtraPivotGrid.CustomizationFormShowingEventHandler(Me.pivotGridControl_ShowingCustomizationForm)
'			Me.pivotGridControl.PopupMenuShowing += New DevExpress.XtraPivotGrid.PopupMenuShowingEventHandler(Me.pivotGridControl_PopupMenuShowing)
'			Me.pivotGridControl.FieldValueNotExpanded += New DevExpress.XtraPivotGrid.PivotFieldValueEventHandler(Me.pivotGridControl_FieldValueNotExpanded)
'			Me.pivotGridControl.QueryException += New DevExpress.XtraPivotGrid.PivotQueryExceptionEventHandler(Me.pivotGridControl_QueryException)
			' 
			' controlPanel
			' 
			Me.controlPanel.AutoSize = True
			Me.controlPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.controlPanel.Controls.Add(Me.panelConnection)
			Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.controlPanel.Location = New System.Drawing.Point(0, 51)
			Me.controlPanel.Name = "controlPanel"
			Me.controlPanel.Size = New System.Drawing.Size(690, 43)
			Me.controlPanel.TabIndex = 5
			' 
			' mainPanel
			' 
			Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.mainPanel.Controls.Add(Me.splitPivotContainer)
			Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mainPanel.Location = New System.Drawing.Point(0, 102)
			Me.mainPanel.Name = "mainPanel"
			Me.mainPanel.Size = New System.Drawing.Size(690, 368)
			Me.mainPanel.TabIndex = 7
			' 
			' separator2
			' 
			Me.separator2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.separator2.Dock = System.Windows.Forms.DockStyle.Top
			Me.separator2.Location = New System.Drawing.Point(0, 94)
			Me.separator2.Name = "separator2"
			Me.separator2.Size = New System.Drawing.Size(690, 8)
			Me.separator2.TabIndex = 13
			' 
			' separator1
			' 
			Me.separator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.separator1.Dock = System.Windows.Forms.DockStyle.Top
			Me.separator1.Location = New System.Drawing.Point(0, 43)
			Me.separator1.Name = "separator1"
			Me.separator1.Size = New System.Drawing.Size(690, 8)
			Me.separator1.TabIndex = 14
			' 
			' panelError
			' 
			Me.panelError.Controls.Add(Me.hyperLinkEdit1)
			Me.panelError.Controls.Add(Me.labelControl1)
			Me.panelError.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelError.Location = New System.Drawing.Point(0, 0)
			Me.panelError.Name = "panelError"
			Me.panelError.Size = New System.Drawing.Size(690, 43)
			Me.panelError.TabIndex = 15
			' 
			' hyperLinkEdit1
			' 
			Me.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB"
			Me.hyperLinkEdit1.Location = New System.Drawing.Point(456, 19)
			Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
			Me.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = True
			Me.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.hyperLinkEdit1.Properties.Caption = "www.microsoft.com"
			Me.hyperLinkEdit1.Properties.UseParentBackground = True
			Me.hyperLinkEdit1.Size = New System.Drawing.Size(100, 18)
			Me.hyperLinkEdit1.TabIndex = 1
			' 
			' labelControl1
			' 
			Me.labelControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red
			Me.labelControl1.AutoEllipsis = True
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl1.Location = New System.Drawing.Point(12, 7)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(663, 28)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services" & " OLE DB 8.0 (or later) " & Constants.vbCrLf & "installed on your system. You can get the latest version of this provider here:"
			' 
			' OLAP
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.mainPanel)
			Me.Controls.Add(Me.separator2)
			Me.Controls.Add(Me.controlPanel)
			Me.Controls.Add(Me.separator1)
			Me.Controls.Add(Me.panelError)
			Me.Name = "OLAP"
			Me.Size = New System.Drawing.Size(690, 470)
'			Me.Load += New System.EventHandler(Me.OLAP_Load);
			CType(Me.panelConnection, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelConnection.ResumeLayout(False)
			CType(Me.splitPivotContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPivotContainer.ResumeLayout(False)
			CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.controlPanel.ResumeLayout(False)
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mainPanel.ResumeLayout(False)
			CType(Me.separator2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.separator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelError, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelError.ResumeLayout(False)
			CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private panelConnection As DevExpress.XtraEditors.PanelControl
		Private WithEvents buttonNewConnection As DevExpress.XtraEditors.SimpleButton
		Private splitPivotContainer As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents pivotGridControl As PivotGridControl
		Private controlPanel As DevExpress.XtraEditors.PanelControl
		Private mainPanel As DevExpress.XtraEditors.PanelControl
		Private separator2 As DevExpress.XtraEditors.PanelControl
		Private separator1 As DevExpress.XtraEditors.PanelControl
		Private panelError As DevExpress.XtraEditors.PanelControl
		Private hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

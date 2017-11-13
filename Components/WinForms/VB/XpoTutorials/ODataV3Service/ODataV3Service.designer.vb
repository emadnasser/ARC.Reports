Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
	Partial Public Class ODataV3Service
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.gclODataV3ServiceMain = New DevExpress.XtraGrid.GridControl()
            Me.gvlODataV3Service = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.sbViewMetadata = New DevExpress.XtraEditors.SimpleButton()
            Me.sbStartService = New DevExpress.XtraEditors.SimpleButton()
            Me.sbEmployees = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.gclODataV3ServiceMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gvlODataV3Service, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gclODataV3ServiceMain
            '
            Me.gclODataV3ServiceMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclODataV3ServiceMain.Location = New System.Drawing.Point(0, 59)
            Me.gclODataV3ServiceMain.MainView = Me.gvlODataV3Service
            Me.gclODataV3ServiceMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.gclODataV3ServiceMain.Name = "gclODataV3ServiceMain"
            Me.gclODataV3ServiceMain.Size = New System.Drawing.Size(915, 586)
            Me.gclODataV3ServiceMain.TabIndex = 2
            Me.gclODataV3ServiceMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvlODataV3Service})
            '
            'gvlODataV3Service
            '
            Me.gvlODataV3Service.GridControl = Me.gclODataV3ServiceMain
            Me.gvlODataV3Service.Name = "gvlODataV3Service"
            Me.gvlODataV3Service.OptionsBehavior.Editable = False
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.sbViewMetadata)
            Me.panelControl1.Controls.Add(Me.sbStartService)
            Me.panelControl1.Controls.Add(Me.sbEmployees)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(915, 59)
            Me.panelControl1.TabIndex = 3
            '
            'sbViewMetadata
            '
            Me.sbViewMetadata.Enabled = False
            Me.sbViewMetadata.Location = New System.Drawing.Point(288, 15)
            Me.sbViewMetadata.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.sbViewMetadata.Name = "sbViewMetadata"
            Me.sbViewMetadata.Size = New System.Drawing.Size(257, 26)
            Me.sbViewMetadata.TabIndex = 8
            Me.sbViewMetadata.Text = "View the Service Metadata in browser"
            '
            'sbStartService
            '
            Me.sbStartService.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbStartService.Location = New System.Drawing.Point(681, 15)
            Me.sbStartService.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.sbStartService.Name = "sbStartService"
            Me.sbStartService.Size = New System.Drawing.Size(215, 26)
            Me.sbStartService.TabIndex = 7
            Me.sbStartService.Text = "Start the XPO OData V3 Service"
            '
            'sbEmployees
            '
            Me.sbEmployees.Enabled = False
            Me.sbEmployees.Location = New System.Drawing.Point(20, 15)
            Me.sbEmployees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.sbEmployees.Name = "sbEmployees"
            Me.sbEmployees.Size = New System.Drawing.Size(262, 26)
            Me.sbEmployees.TabIndex = 6
            Me.sbEmployees.Text = "Load Customers via the OData Service"
            '
            'ODataV3Service
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gclODataV3ServiceMain)
            Me.Controls.Add(Me.panelControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "ODataV3Service"
            Me.Size = New System.Drawing.Size(915, 645)
            CType(Me.gclODataV3ServiceMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gvlODataV3Service, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private gclODataV3ServiceMain As DevExpress.XtraGrid.GridControl
		Private gvlODataV3Service As DevExpress.XtraGrid.Views.Grid.GridView
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents sbEmployees As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbStartService As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbViewMetadata As XtraEditors.SimpleButton
	End Class
End Namespace

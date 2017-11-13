Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridAlphaBlending
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GridAlphaBlending))
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.xtraGridBlending1 = New DevExpress.XtraGrid.Blending.XtraGridBlending()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.simpleButton1)
			Me.panel1.Controls.Add(Me.checkEdit1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(684, 42)
			Me.panel1.TabIndex = 3
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(148, 8)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(112, 24)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "A&djust..."
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(12, 12)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Alpha &Blending"
			Me.checkEdit1.Size = New System.Drawing.Size(132, 19)
			Me.checkEdit1.TabIndex = 0
'			Me.checkEdit1.CheckedChanged += New System.EventHandler(Me.checkEdit1_CheckedChanged);
			' 
			' gridControl1
			' 
			Me.gridControl1.BackgroundImage = (CType(resources.GetObject("gridControl1.BackgroundImage"), System.Drawing.Image))
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 50)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(684, 410)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1})
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "gridBand1"
			Me.gridBand1.Name = "gridBand1"
			' 
			' xtraGridBlending1
			' 
			Me.xtraGridBlending1.AlphaStyles.AddReplace("HeaderPanelBackground", 100)
			Me.xtraGridBlending1.AlphaStyles.AddReplace("RowSeparator", 0)
			Me.xtraGridBlending1.AlphaStyles.AddReplace("Row", 20)
			Me.xtraGridBlending1.AlphaStyles.AddReplace("HeaderPanel", 150)
			Me.xtraGridBlending1.GridControl = Me.gridControl1
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 42)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(684, 8)
			Me.panelControl1.TabIndex = 7
			' 
			' GridAlphaBlending
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "GridAlphaBlending"
			Me.Size = New System.Drawing.Size(684, 460)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.GridAlphaBlending_Load);
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel1 As DevExpress.XtraEditors.PanelControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private xtraGridBlending1 As DevExpress.XtraGrid.Blending.XtraGridBlending
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace

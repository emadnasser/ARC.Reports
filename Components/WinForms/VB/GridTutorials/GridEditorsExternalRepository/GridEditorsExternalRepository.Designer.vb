Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridEditorsExternalRepository
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GridEditorsExternalRepository))
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.persistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository(Me.components)
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel1.Controls.Add(Me.xtraTabControl1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel1.Location = New System.Drawing.Point(4, 4)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(204, 408)
			Me.panel1.TabIndex = 3
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.Size = New System.Drawing.Size(204, 408)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.Text = "xtraTabControl1"
'			Me.xtraTabControl1.SelectedPageChanged += New DevExpress.XtraTab.TabPageChangedEventHandler(Me.xtraTabControl1_SelectedPageChanged);
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(214, 4)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(627, 408)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1})
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Name = "advBandedGridView1"
'			Me.advBandedGridView1.FocusedColumnChanged += New DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(Me.advBandedGridView1_FocusedColumnChanged);
'			Me.advBandedGridView1.InvalidValueException += New DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(Me.advBandedGridView1_InvalidValueException);
'			Me.advBandedGridView1.ValidatingEditor += New DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(Me.advBandedGridView1_ValidatingEditor);
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "gridBand1"
			Me.gridBand1.Name = "gridBand1"
			' 
			' splitter1
			' 
			Me.splitter1.Location = New System.Drawing.Point(208, 4)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(6, 408)
			Me.splitter1.TabIndex = 5
			Me.splitter1.TabStop = False
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			' 
			' GridEditorsExternalRepository
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "GridEditorsExternalRepository"
			Me.Size = New System.Drawing.Size(845, 416)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.GridEditorsExternalRepository_Load);
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel1 As DevExpress.XtraEditors.PanelControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private persistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private components As System.ComponentModel.IContainer
	End Class
End Namespace

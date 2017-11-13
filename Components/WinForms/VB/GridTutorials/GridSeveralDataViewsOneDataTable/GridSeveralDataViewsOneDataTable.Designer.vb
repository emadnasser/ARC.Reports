Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridSeveralDataViewsOneDataTable
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(4, 4)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(587, 236)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AllowFocused = False
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' repositoryItemTextEdit2
			' 
			Me.repositoryItemTextEdit2.AllowFocused = False
			Me.repositoryItemTextEdit2.AutoHeight = False
			Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
			' 
			' gridControl2
			' 
			Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.gridControl2.EmbeddedNavigator.Name = ""
			Me.gridControl2.Location = New System.Drawing.Point(4, 272)
			Me.gridControl2.MainView = Me.cardView1
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.Size = New System.Drawing.Size(587, 140)
			Me.gridControl2.TabIndex = 5
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.cardView1})
			' 
			' cardView1
			' 
			Me.cardView1.FocusedCardTopFieldIndex = 0
			Me.cardView1.GridControl = Me.gridControl2
			Me.cardView1.Name = "cardView1"
			' 
			' splitter1
			' 
			Me.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit
			Me.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.splitter1.Location = New System.Drawing.Point(4, 264)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(587, 8)
			Me.splitter1.TabIndex = 6
			Me.splitter1.TabStop = False
			' 
			' panel1
			' 
			Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel1.Controls.Add(Me.checkEdit1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel1.Location = New System.Drawing.Point(4, 240)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(587, 24)
			Me.panel1.TabIndex = 7
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(4, 4)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Synchronize FocusedRow "
			Me.checkEdit1.Size = New System.Drawing.Size(188, 18)
			Me.checkEdit1.TabIndex = 0
'			Me.checkEdit1.CheckedChanged += New System.EventHandler(Me.checkEdit1_CheckedChanged);
			' 
			' GridSeveralDataViewsOneDataTable
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.gridControl2)
			Me.Name = "GridSeveralDataViewsOneDataTable"
			Me.Size = New System.Drawing.Size(595, 416)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.GridSeveralDataViewsOneDataTable_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private panel1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
	End Class
End Namespace

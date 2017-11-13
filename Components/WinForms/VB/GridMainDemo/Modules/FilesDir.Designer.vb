Namespace DevExpress.XtraGrid.Demos
	Partial Public Class FilesDir
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
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Dim gridLevelNode2 As New DevExpress.XtraGrid.GridLevelNode()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			Me.gridView2.OptionsBehavior.AutoUpdateTotalSummary = False
			Me.gridView2.OptionsDetail.AutoZoomDetail = True
			Me.gridView2.OptionsDetail.EnableDetailToolTip = True
			Me.gridView2.OptionsNavigation.UseTabKey = False
			Me.gridView2.OptionsView.AutoCalcPreviewLineCount = True
			Me.gridView2.OptionsView.ShowPreview = True
			Me.gridView2.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
			Me.gridView2.PreviewFieldName = "FullName"
			Me.gridView2.SynchronizeClones = False
'			Me.gridView2.MasterRowGetLevelDefaultView += New DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventHandler(Me.gridView2_MasterRowGetLevelDefaultView)
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.LevelTemplate = Me.gridView2
			gridLevelNode1.RelationName = "Directories"
			gridLevelNode2.LevelTemplate = Me.cardView1
			gridLevelNode2.RelationName = "Files"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1, gridLevelNode2})
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(760, 437)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.UseEmbeddedNavigator = True
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.cardView1, Me.gridView1, Me.gridView2})
'			Me.gridControl1.ViewRegistered += New DevExpress.XtraGrid.ViewOperationEventHandler(Me.gridControl1_ViewRegistered)
'			Me.gridControl1.DefaultViewChanged += New System.EventHandler(Me.gridControl1_DefaultViewChanged)
			' 
			' cardView1
			' 
			Me.cardView1.CardCaptionFormat = "{1} "
			Me.cardView1.CardWidth = 300
			Me.cardView1.FocusedCardTopFieldIndex = 0
			Me.cardView1.GridControl = Me.gridControl1
			Me.cardView1.Name = "cardView1"
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.AutoUpdateTotalSummary = False
			Me.gridView1.OptionsDetail.AutoZoomDetail = True
			Me.gridView1.OptionsDetail.EnableDetailToolTip = True
			Me.gridView1.OptionsNavigation.UseTabKey = False
			Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.PreviewFieldName = "FullName"
			' 
			' FilesDir
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "FilesDir"
			Me.Size = New System.Drawing.Size(760, 437)
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
	End Class
End Namespace

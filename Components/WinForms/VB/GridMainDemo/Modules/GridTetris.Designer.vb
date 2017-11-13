Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos
	Partial Public Class GridTetris
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(GridTetris))
			Me.bandedGridView = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridControl = New DevExpress.XtraGrid.GridControl()
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.label3 = New System.Windows.Forms.Label()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.bandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.label1 = New System.Windows.Forms.Label()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.xtraGridBlending1 = New DevExpress.XtraGrid.Blending.XtraGridBlending()
			Me.timer2 = New System.Windows.Forms.Timer(Me.components)
			CType(Me.bandedGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' bandedGridView
			' 
			Me.bandedGridView.Appearance.Empty.BackColor = (CType(resources.GetObject("bandedGridView.Appearance.Empty.BackColor"), System.Drawing.Color))
			Me.bandedGridView.Appearance.Empty.Options.UseBackColor = True
			Me.bandedGridView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1})
			Me.bandedGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
			Me.bandedGridView.GridControl = Me.gridControl
			Me.bandedGridView.Name = "bandedGridView"
			Me.bandedGridView.OptionsBehavior.Editable = False
			Me.bandedGridView.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.bandedGridView.OptionsSelection.EnableAppearanceFocusedRow = False
			Me.bandedGridView.OptionsSelection.EnableAppearanceHideSelection = False
			Me.bandedGridView.OptionsView.ShowColumnHeaders = False
			Me.bandedGridView.OptionsView.ShowGroupPanel = False
			Me.bandedGridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False
			Me.bandedGridView.OptionsView.ShowIndicator = False
			Me.bandedGridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
'			Me.bandedGridView.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.bandedGridView_CustomDrawCell);
			' 
			' gridBand1
			' 
			resources.ApplyResources(Me.gridBand1, "gridBand1")
			Me.gridBand1.OptionsBand.AllowHotTrack = False
			Me.gridBand1.OptionsBand.AllowMove = False
			Me.gridBand1.OptionsBand.AllowPress = False
			Me.gridBand1.OptionsBand.AllowSize = False
			' 
			' gridControl
			' 
			resources.ApplyResources(Me.gridControl, "gridControl")
			Me.gridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
			Me.gridControl.LookAndFeel.UseDefaultLookAndFeel = False
			Me.gridControl.MainView = Me.bandedGridView
			Me.gridControl.Name = "gridControl"
			Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.bandedGridView})
'			Me.gridControl.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.Form1_KeyDown);
			' 
			' panel1
			' 
			Me.panel1.Appearance.BackColor = (CType(resources.GetObject("panel1.Appearance.BackColor"), System.Drawing.Color))
			Me.panel1.Appearance.Options.UseBackColor = True
			Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
			Me.panel1.Controls.Add(Me.label3)
			Me.panel1.Controls.Add(Me.gridControl2)
			Me.panel1.Controls.Add(Me.label4)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.simpleButton1)
			Me.panel1.Controls.Add(Me.label1)
			resources.ApplyResources(Me.panel1, "panel1")
			Me.panel1.Name = "panel1"
			' 
			' label3
			' 
			resources.ApplyResources(Me.label3, "label3")
			Me.label3.BackColor = System.Drawing.Color.Transparent
			Me.label3.Name = "label3"
			' 
			' gridControl2
			' 
			resources.ApplyResources(Me.gridControl2, "gridControl2")
			Me.gridControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
			Me.gridControl2.LookAndFeel.UseDefaultLookAndFeel = False
			Me.gridControl2.MainView = Me.bandedGridView2
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.TabStop = False
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.bandedGridView2})
			' 
			' bandedGridView2
			' 
			Me.bandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand2})
			Me.bandedGridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.bandedGridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
			Me.bandedGridView2.GridControl = Me.gridControl2
			Me.bandedGridView2.Name = "bandedGridView2"
			Me.bandedGridView2.OptionsBehavior.Editable = False
			Me.bandedGridView2.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.bandedGridView2.OptionsSelection.EnableAppearanceFocusedRow = False
			Me.bandedGridView2.OptionsView.ShowBands = False
			Me.bandedGridView2.OptionsView.ShowColumnHeaders = False
			Me.bandedGridView2.OptionsView.ShowGroupPanel = False
			Me.bandedGridView2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False
			Me.bandedGridView2.OptionsView.ShowIndicator = False
			Me.bandedGridView2.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
'			Me.bandedGridView2.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.bandedGridView_CustomDrawCell);
			' 
			' gridBand2
			' 
			resources.ApplyResources(Me.gridBand2, "gridBand2")
			' 
			' label4
			' 
			Me.label4.BackColor = System.Drawing.Color.Transparent
			resources.ApplyResources(Me.label4, "label4")
			Me.label4.Name = "label4"
			' 
			' label2
			' 
			Me.label2.BackColor = System.Drawing.Color.Transparent
			resources.ApplyResources(Me.label2, "label2")
			Me.label2.Name = "label2"
			' 
			' simpleButton1
			' 
			resources.ApplyResources(Me.simpleButton1, "simpleButton1")
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.TabStop = False
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' label1
			' 
			Me.label1.BackColor = System.Drawing.Color.Transparent
			resources.ApplyResources(Me.label1, "label1")
			Me.label1.Name = "label1"
			' 
			' timer1
			' 
			Me.timer1.Interval = 400
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' xtraGridBlending1
			' 
			Me.xtraGridBlending1.AlphaStyles.AddReplace("Row", 100)
			Me.xtraGridBlending1.GridControl = Me.gridControl
			' 
			' timer2
			' 
			Me.timer2.Interval = 10
'			Me.timer2.Tick += New System.EventHandler(Me.timer2_Tick);
			' 
			' GridTetris
			' 
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.gridControl)
			Me.Name = "GridTetris"
			resources.ApplyResources(Me, "$this")
'			Me.Load += New System.EventHandler(Me.GridTetris_Load);
'			Me.Resize += New System.EventHandler(Me.GridTetris_Resize);
'			Me.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.Form1_KeyDown);
			CType(Me.bandedGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents bandedGridView As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private panel1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private WithEvents bandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private label4 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private label1 As System.Windows.Forms.Label
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private xtraGridBlending1 As DevExpress.XtraGrid.Blending.XtraGridBlending
		Private WithEvents timer2 As System.Windows.Forms.Timer
		Private label3 As System.Windows.Forms.Label
		Private components As System.ComponentModel.IContainer = Nothing
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridRowFilterEvent
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
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.ceRegion = New DevExpress.XtraEditors.CheckEdit()
			Me.ceHideEvenRows = New DevExpress.XtraEditors.CheckEdit()
			Me.ceHideOddRows = New DevExpress.XtraEditors.CheckEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.ceRegion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceHideEvenRows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceHideOddRows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 92)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(683, 274)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ColumnAutoWidth = False
			Me.gridView1.OptionsView.ShowFooter = True
'			Me.gridView1.CustomRowFilter += New DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(Me.gridView1_CustomRowFilter);
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.ceRegion)
			Me.panel1.Controls.Add(Me.ceHideEvenRows)
			Me.panel1.Controls.Add(Me.ceHideOddRows)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(683, 84)
			Me.panel1.TabIndex = 5
			' 
			' ceRegion
			' 
			Me.ceRegion.Location = New System.Drawing.Point(12, 54)
			Me.ceRegion.Name = "ceRegion"
			Me.ceRegion.Properties.Caption = "Hide Rows if the Region Value is NULL"
			Me.ceRegion.Size = New System.Drawing.Size(456, 19)
			Me.ceRegion.TabIndex = 3
'			Me.ceRegion.CheckedChanged += New System.EventHandler(Me.ceEditors__CheckedChanged);
			' 
			' ceHideEvenRows
			' 
			Me.ceHideEvenRows.Location = New System.Drawing.Point(12, 34)
			Me.ceHideEvenRows.Name = "ceHideEvenRows"
			Me.ceHideEvenRows.Properties.Caption = "Hide Even Rows"
			Me.ceHideEvenRows.Size = New System.Drawing.Size(184, 19)
			Me.ceHideEvenRows.TabIndex = 2
'			Me.ceHideEvenRows.CheckedChanged += New System.EventHandler(Me.ceEditors__CheckedChanged);
			' 
			' ceHideOddRows
			' 
			Me.ceHideOddRows.EditValue = True
			Me.ceHideOddRows.Location = New System.Drawing.Point(12, 12)
			Me.ceHideOddRows.Name = "ceHideOddRows"
			Me.ceHideOddRows.Properties.Caption = "Hide Odd Rows"
			Me.ceHideOddRows.Size = New System.Drawing.Size(184, 19)
			Me.ceHideOddRows.TabIndex = 1
'			Me.ceHideOddRows.CheckedChanged += New System.EventHandler(Me.ceEditors__CheckedChanged);
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 84)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(683, 8)
			Me.panelControl1.TabIndex = 9
			' 
			' GridRowFilterEvent
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "GridRowFilterEvent"
			Me.Size = New System.Drawing.Size(683, 366)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.GridRowFilterEvent_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.ceRegion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceHideEvenRows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceHideOddRows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private panel1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents ceHideOddRows As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceHideEvenRows As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceRegion As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace

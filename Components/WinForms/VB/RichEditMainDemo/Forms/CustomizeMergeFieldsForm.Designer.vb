Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos.Forms
	Partial Public Class CustomizeMergeFieldsForm
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
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
			Me.pcMain = New DevExpress.XtraEditors.PanelControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.horzSplitter1 = New DevExpress.XtraEditors.PanelControl()
			Me.gcDescription = New DevExpress.XtraEditors.GroupControl()
			Me.pnlHint = New DevExpress.Utils.Frames.NotePanel8_1()
			Me.horzSplitter2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.pcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcMain.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.horzSplitter1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gcDescription, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gcDescription.SuspendLayout()
			CType(Me.horzSplitter2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.horzSplitter2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' btnOk
			' 
			Me.btnOk.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnOk.Location = New System.Drawing.Point(312, 6)
			Me.btnOk.Name = "btnOk"
			Me.btnOk.Size = New System.Drawing.Size(75, 23)
			Me.btnOk.TabIndex = 1
			Me.btnOk.Text = "OK"
'			Me.btnOk.Click += New System.EventHandler(Me.btnOk_Click);
			' 
			' pcMain
			' 
			Me.pcMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcMain.Controls.Add(Me.gridControl1)
			Me.pcMain.Controls.Add(Me.horzSplitter1)
			Me.pcMain.Controls.Add(Me.gcDescription)
			Me.pcMain.Controls.Add(Me.horzSplitter2)
			Me.pcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pcMain.Location = New System.Drawing.Point(0, 0)
			Me.pcMain.Name = "pcMain"
			Me.pcMain.Padding = New System.Windows.Forms.Padding(8)
			Me.pcMain.Size = New System.Drawing.Size(403, 376)
			Me.pcMain.TabIndex = 4
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.RelationName = "Level1"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(8, 8)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(387, 284)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsMenu.EnableColumnMenu = False
			Me.gridView1.OptionsMenu.EnableFooterMenu = False
			Me.gridView1.OptionsMenu.EnableGroupPanelMenu = False
			Me.gridView1.OptionsView.ShowDetailButtons = False
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.OptionsView.ShowIndicator = False
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Can show"
			Me.gridColumn1.FieldName = "CanShow"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.OptionsColumn.AllowMove = False
			Me.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn1.OptionsFilter.AllowAutoFilter = False
			Me.gridColumn1.OptionsFilter.AllowFilter = False
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 2
			Me.gridColumn1.Width = 65
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Data field name (readonly)"
			Me.gridColumn2.FieldName = "FieldName.Name"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.OptionsColumn.AllowEdit = False
			Me.gridColumn2.OptionsColumn.AllowMove = False
			Me.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn2.OptionsFilter.AllowAutoFilter = False
			Me.gridColumn2.OptionsFilter.AllowFilter = False
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 0
			Me.gridColumn2.Width = 154
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Display name"
			Me.gridColumn3.FieldName = "FieldName.DisplayName"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.OptionsColumn.AllowMove = False
			Me.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn3.OptionsFilter.AllowAutoFilter = False
			Me.gridColumn3.OptionsFilter.AllowFilter = False
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 1
			Me.gridColumn3.Width = 166
			' 
			' horzSplitter1
			' 
			Me.horzSplitter1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.horzSplitter1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.horzSplitter1.Location = New System.Drawing.Point(8, 292)
			Me.horzSplitter1.Name = "horzSplitter1"
			Me.horzSplitter1.Size = New System.Drawing.Size(387, 6)
			Me.horzSplitter1.TabIndex = 0
			' 
			' gcDescription
			' 
			Me.gcDescription.Controls.Add(Me.pnlHint)
			Me.gcDescription.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.gcDescription.Location = New System.Drawing.Point(8, 298)
			Me.gcDescription.Name = "gcDescription"
			Me.gcDescription.ShowCaption = False
			Me.gcDescription.Size = New System.Drawing.Size(387, 37)
			Me.gcDescription.TabIndex = 3
			Me.gcDescription.Text = "Description:"
			' 
			' pnlHint
			' 
			Me.pnlHint.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.pnlHint.Location = New System.Drawing.Point(2, 0)
			Me.pnlHint.MaxRows = 5
			Me.pnlHint.Name = "pnlHint"
			Me.pnlHint.ParentAutoHeight = True
			Me.pnlHint.Size = New System.Drawing.Size(383, 35)
			Me.pnlHint.TabIndex = 0
			Me.pnlHint.TabStop = False
			Me.pnlHint.Text = "Change display names to make them more descriptive." & Constants.vbLf & "Uncheck the boxes next to the" & " unneeded fields to hide them."
			' 
			' horzSplitter2
			' 
			Me.horzSplitter2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.horzSplitter2.Controls.Add(Me.btnOk)
			Me.horzSplitter2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.horzSplitter2.Location = New System.Drawing.Point(8, 335)
			Me.horzSplitter2.Name = "horzSplitter2"
			Me.horzSplitter2.Size = New System.Drawing.Size(387, 33)
			Me.horzSplitter2.TabIndex = 0
			' 
			' CustomizeMergeFieldsForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(403, 376)
			Me.Controls.Add(Me.pcMain)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.MinimumSize = New System.Drawing.Size(250, 250)
			Me.Name = "CustomizeMergeFieldsForm"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Customize merge fields"
			CType(Me.pcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcMain.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.horzSplitter1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gcDescription, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gcDescription.ResumeLayout(False)
			CType(Me.horzSplitter2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.horzSplitter2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
		Protected pcMain As DevExpress.XtraEditors.PanelControl
		Public gcDescription As DevExpress.XtraEditors.GroupControl
		Public pnlHint As DevExpress.Utils.Frames.NotePanel8_1
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Public horzSplitter1 As DevExpress.XtraEditors.PanelControl
		Public horzSplitter2 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace

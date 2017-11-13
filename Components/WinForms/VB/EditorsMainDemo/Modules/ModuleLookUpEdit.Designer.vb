Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleLookUpEdit
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
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.notePanel1 = New DevExpress.Utils.Frames.NotePanel()
			Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.lookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.lookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
			Me.notePanel2 = New DevExpress.Utils.Frames.NotePanel()
			Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.lookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit()
			Me.notePanel3 = New DevExpress.Utils.Frames.NotePanel()
			Me.xtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.lookUpEdit4 = New DevExpress.XtraEditors.LookUpEdit()
			Me.notePanel4 = New DevExpress.Utils.Frames.NotePanel()
			Me.xtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
			Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.lookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage3.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.lookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage4.SuspendLayout()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.lookUpEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(429, 571)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3, Me.xtraTabPage4})
'			Me.xtraTabControl1.SelectedPageChanged += New DevExpress.XtraTab.TabPageChangedEventHandler(Me.xtraTabControl1_SelectedPageChanged)
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.notePanel1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl3)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Controls.Add(Me.dataNavigator1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Padding = New System.Windows.Forms.Padding(20, 20, 20, 10)
			Me.xtraTabPage1.Size = New System.Drawing.Size(423, 543)
			Me.xtraTabPage1.Text = "Data Binding"
			' 
			' notePanel1
			' 
			Me.notePanel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.notePanel1.ForeColor = System.Drawing.Color.Black
			Me.notePanel1.Location = New System.Drawing.Point(20, 478)
			Me.notePanel1.MaxRows = 10
			Me.notePanel1.Name = "notePanel1"
			Me.notePanel1.Size = New System.Drawing.Size(383, 22)
			Me.notePanel1.TabIndex = 4
			Me.notePanel1.TabStop = False
			Me.notePanel1.Visible = False
			' 
			' panelControl3
			' 
			Me.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl3.Appearance.Options.UseBackColor = True
			Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl3.Location = New System.Drawing.Point(20, 500)
			Me.panelControl3.Name = "panelControl3"
			Me.panelControl3.Size = New System.Drawing.Size(383, 12)
			Me.panelControl3.TabIndex = 6
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.lookUpEdit1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(20, 20)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
			Me.panelControl1.Size = New System.Drawing.Size(383, 204)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' lookUpEdit1
			' 
			Me.lookUpEdit1.Dock = System.Windows.Forms.DockStyle.Top
			Me.lookUpEdit1.Location = New System.Drawing.Point(22, 81)
			Me.lookUpEdit1.Name = "lookUpEdit1"
			Me.lookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", 100, "Product Name"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuantityPerUnit", 50, "Quantity Per Unit"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitPrice", "Unit Price", 30, DevExpress.Utils.FormatType.Numeric, "c", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Discontinued", "Discontinued", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center)})
			Me.lookUpEdit1.Properties.DisplayMember = "ProductName"
			Me.lookUpEdit1.Properties.DropDownRows = 15
			Me.lookUpEdit1.Properties.PopupWidth = 500
			Me.lookUpEdit1.Properties.ValueMember = "ProductID"
			Me.lookUpEdit1.Size = New System.Drawing.Size(339, 20)
			Me.lookUpEdit1.TabIndex = 0
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.Buttons.CancelEdit.Visible = False
			Me.dataNavigator1.Buttons.EndEdit.Visible = False
			Me.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.dataNavigator1.Location = New System.Drawing.Point(20, 512)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(383, 21)
			Me.dataNavigator1.TabIndex = 5
			Me.dataNavigator1.Text = "dataNavigator1"
			Me.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.groupControl1)
			Me.xtraTabPage2.Controls.Add(Me.notePanel2)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Padding = New System.Windows.Forms.Padding(20, 20, 20, 10)
			Me.xtraTabPage2.Size = New System.Drawing.Size(423, 543)
			Me.xtraTabPage2.Text = "Simple Binding"
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.lookUpEdit2)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.groupControl1.Location = New System.Drawing.Point(20, 20)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
			Me.groupControl1.Size = New System.Drawing.Size(383, 204)
			Me.groupControl1.TabIndex = 6
			Me.groupControl1.Text = "Sample"
			' 
			' lookUpEdit2
			' 
			Me.lookUpEdit2.Dock = System.Windows.Forms.DockStyle.Top
			Me.lookUpEdit2.Location = New System.Drawing.Point(22, 81)
			Me.lookUpEdit2.Name = "lookUpEdit2"
			Me.lookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurchaseDate", "Purchase Date", 30, DevExpress.Utils.FormatType.DateTime, "D", True, DevExpress.Utils.HorzAlignment.Default), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentAmount", "Payment Amount", 20, DevExpress.Utils.FormatType.Numeric, "c", True, DevExpress.Utils.HorzAlignment.Default)})
			Me.lookUpEdit2.Properties.DisplayMember = "Name"
			Me.lookUpEdit2.Properties.DropDownRows = 5
			Me.lookUpEdit2.Properties.PopupWidth = 400
			Me.lookUpEdit2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
			Me.lookUpEdit2.Properties.ValueMember = "ID"
			Me.lookUpEdit2.Size = New System.Drawing.Size(339, 20)
			Me.lookUpEdit2.TabIndex = 0
			' 
			' notePanel2
			' 
			Me.notePanel2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.notePanel2.ForeColor = System.Drawing.Color.Black
			Me.notePanel2.Location = New System.Drawing.Point(20, 511)
			Me.notePanel2.MaxRows = 10
			Me.notePanel2.Name = "notePanel2"
			Me.notePanel2.Size = New System.Drawing.Size(383, 22)
			Me.notePanel2.TabIndex = 5
			Me.notePanel2.TabStop = False
			' 
			' xtraTabPage3
			' 
			Me.xtraTabPage3.Controls.Add(Me.groupControl2)
			Me.xtraTabPage3.Controls.Add(Me.notePanel3)
			Me.xtraTabPage3.Name = "xtraTabPage3"
			Me.xtraTabPage3.Padding = New System.Windows.Forms.Padding(20, 20, 20, 10)
			Me.xtraTabPage3.Size = New System.Drawing.Size(423, 543)
			Me.xtraTabPage3.Text = "Array Binding"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.lookUpEdit3)
			Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.groupControl2.Location = New System.Drawing.Point(20, 20)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
			Me.groupControl2.Size = New System.Drawing.Size(383, 204)
			Me.groupControl2.TabIndex = 6
			Me.groupControl2.Text = "Sample"
			' 
			' lookUpEdit3
			' 
			Me.lookUpEdit3.Dock = System.Windows.Forms.DockStyle.Top
			Me.lookUpEdit3.Location = New System.Drawing.Point(22, 81)
			Me.lookUpEdit3.Name = "lookUpEdit3"
			Me.lookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lookUpEdit3.Properties.DropDownRows = 20
			Me.lookUpEdit3.Properties.PopupWidth = 200
			Me.lookUpEdit3.Size = New System.Drawing.Size(339, 20)
			Me.lookUpEdit3.TabIndex = 0
			' 
			' notePanel3
			' 
			Me.notePanel3.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.notePanel3.ForeColor = System.Drawing.Color.Black
			Me.notePanel3.Location = New System.Drawing.Point(20, 511)
			Me.notePanel3.MaxRows = 10
			Me.notePanel3.Name = "notePanel3"
			Me.notePanel3.Size = New System.Drawing.Size(383, 22)
			Me.notePanel3.TabIndex = 5
			Me.notePanel3.TabStop = False
			' 
			' xtraTabPage4
			' 
			Me.xtraTabPage4.Controls.Add(Me.groupControl3)
			Me.xtraTabPage4.Controls.Add(Me.notePanel4)
			Me.xtraTabPage4.Name = "xtraTabPage4"
			Me.xtraTabPage4.Padding = New System.Windows.Forms.Padding(20, 20, 20, 10)
			Me.xtraTabPage4.Size = New System.Drawing.Size(423, 543)
			Me.xtraTabPage4.Text = "Not In List"
			' 
			' groupControl3
			' 
			Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl3.Appearance.Options.UseBackColor = True
			Me.groupControl3.Controls.Add(Me.lookUpEdit4)
			Me.groupControl3.Dock = System.Windows.Forms.DockStyle.Top
			Me.groupControl3.Location = New System.Drawing.Point(20, 20)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
			Me.groupControl3.Size = New System.Drawing.Size(383, 204)
			Me.groupControl3.TabIndex = 7
			Me.groupControl3.Text = "Sample"
			' 
			' lookUpEdit4
			' 
			Me.lookUpEdit4.Dock = System.Windows.Forms.DockStyle.Top
			Me.lookUpEdit4.Location = New System.Drawing.Point(22, 81)
			Me.lookUpEdit4.Name = "lookUpEdit4"
			Me.lookUpEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lookUpEdit4.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NotInList", "# (Not In List Column)", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country")})
			Me.lookUpEdit4.Properties.DisplayMember = "Country"
			Me.lookUpEdit4.Properties.DropDownRows = 20
			Me.lookUpEdit4.Properties.PopupWidth = 300
			Me.lookUpEdit4.Properties.ValueMember = "Country"
			Me.lookUpEdit4.Size = New System.Drawing.Size(339, 20)
			Me.lookUpEdit4.TabIndex = 0
			' 
			' notePanel4
			' 
			Me.notePanel4.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.notePanel4.ForeColor = System.Drawing.Color.Black
			Me.notePanel4.Location = New System.Drawing.Point(20, 511)
			Me.notePanel4.MaxRows = 10
			Me.notePanel4.Name = "notePanel4"
			Me.notePanel4.Size = New System.Drawing.Size(383, 22)
			Me.notePanel4.TabIndex = 5
			Me.notePanel4.TabStop = False
			' 
			' xtraTabControl2
			' 
			Me.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl2.Location = New System.Drawing.Point(439, 0)
			Me.xtraTabControl2.Name = "xtraTabControl2"
			Me.xtraTabControl2.SelectedTabPage = Me.xtraTabPage5
			Me.xtraTabControl2.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl2.Size = New System.Drawing.Size(377, 571)
			Me.xtraTabControl2.TabIndex = 2
			Me.xtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage5})
			Me.xtraTabControl2.TabStop = False
			' 
			' xtraTabPage5
			' 
			Me.xtraTabPage5.Name = "xtraTabPage5"
			Me.xtraTabPage5.Size = New System.Drawing.Size(371, 565)
			Me.xtraTabPage5.Text = "xtraTabPage5"
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Location = New System.Drawing.Point(434, 0)
			Me.splitterControl1.MinExtra = 300
			Me.splitterControl1.MinSize = 300
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(5, 571)
			Me.splitterControl1.TabIndex = 4
			Me.splitterControl1.TabStop = False
			' 
			' ModuleLookUpEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl2)
			Me.Controls.Add(Me.splitterControl1)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleLookUpEdit"
			Me.Size = New System.Drawing.Size(816, 576)
'			Me.Load += New System.EventHandler(Me.ModuleLookUpEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.lookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage3.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.lookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage4.ResumeLayout(False)
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			CType(Me.lookUpEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage4 As DevExpress.XtraTab.XtraTabPage
		Private notePanel1 As DevExpress.Utils.Frames.NotePanel
		Private lookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
		Private xtraTabControl2 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage5 As DevExpress.XtraTab.XtraTabPage
		Private notePanel2 As DevExpress.Utils.Frames.NotePanel
		Private notePanel3 As DevExpress.Utils.Frames.NotePanel
		Private notePanel4 As DevExpress.Utils.Frames.NotePanel
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private panelControl3 As DevExpress.XtraEditors.PanelControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private lookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private lookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private lookUpEdit4 As DevExpress.XtraEditors.LookUpEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private splitterControl1 As SplitterControl

	End Class
End Namespace

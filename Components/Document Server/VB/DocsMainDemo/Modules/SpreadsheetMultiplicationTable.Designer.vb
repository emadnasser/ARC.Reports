Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetMultiplicationTableModule
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

		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		''' 
		Private Sub InitializeComponent()
			Me.widthSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.heightSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.createInfoCellsCheckEdit = New DevExpress.XtraEditors.CheckEdit()
			Me.useSharedFormulaCheckEdit = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.widthSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.heightSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.createInfoCellsCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.useSharedFormulaCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' widthSpinEdit
			' 
			Me.widthSpinEdit.EditValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.widthSpinEdit.Location = New System.Drawing.Point(47, 15)
			Me.widthSpinEdit.Name = "widthSpinEdit"
			Me.widthSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.widthSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
			Me.widthSpinEdit.Properties.MaxValue = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.widthSpinEdit.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.widthSpinEdit.Size = New System.Drawing.Size(60, 20)
			Me.widthSpinEdit.TabIndex = 0
'			Me.widthSpinEdit.EditValueChanged += New System.EventHandler(Me.ParametersChanged);
			' 
			' heightSpinEdit
			' 
			Me.heightSpinEdit.EditValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.heightSpinEdit.Location = New System.Drawing.Point(162, 15)
			Me.heightSpinEdit.Name = "heightSpinEdit"
			Me.heightSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.heightSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
			Me.heightSpinEdit.Properties.MaxValue = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.heightSpinEdit.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.heightSpinEdit.Size = New System.Drawing.Size(60, 20)
			Me.heightSpinEdit.TabIndex = 1
'			Me.heightSpinEdit.EditValueChanged += New System.EventHandler(Me.ParametersChanged);
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(3, 19)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(32, 13)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Width:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(121, 19)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(35, 13)
			Me.label2.TabIndex = 3
			Me.label2.Text = "Height:"
			' 
			' createInfoCellsCheckEdit
			' 
			Me.createInfoCellsCheckEdit.EditValue = True
			Me.createInfoCellsCheckEdit.Location = New System.Drawing.Point(3, 65)
			Me.createInfoCellsCheckEdit.Name = "createInfoCellsCheckEdit"
			Me.createInfoCellsCheckEdit.Properties.Caption = "Create Info Cells"
			Me.createInfoCellsCheckEdit.Size = New System.Drawing.Size(107, 19)
			Me.createInfoCellsCheckEdit.TabIndex = 3
'			Me.createInfoCellsCheckEdit.CheckedChanged += New System.EventHandler(Me.ParametersChanged);
			' 
			' useSharedFormulaCheckEdit
			' 
			Me.useSharedFormulaCheckEdit.EditValue = True
			Me.useSharedFormulaCheckEdit.Location = New System.Drawing.Point(3, 41)
			Me.useSharedFormulaCheckEdit.Name = "useSharedFormulaCheckEdit"
			Me.useSharedFormulaCheckEdit.Properties.AutoWidth = True
			Me.useSharedFormulaCheckEdit.Properties.Caption = "Use Shared Formula"
			Me.useSharedFormulaCheckEdit.Size = New System.Drawing.Size(118, 19)
			Me.useSharedFormulaCheckEdit.TabIndex = 2
'			Me.useSharedFormulaCheckEdit.CheckedChanged += New System.EventHandler(Me.ParametersChanged);
			' 
			' SpreadsheetMultiplicationTableModule
			' 
			Me.Controls.Add(Me.useSharedFormulaCheckEdit)
			Me.Controls.Add(Me.createInfoCellsCheckEdit)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.heightSpinEdit)
			Me.Controls.Add(Me.widthSpinEdit)
			Me.Name = "SpreadsheetMultiplicationTableModule"
			Me.Controls.SetChildIndex(Me.widthSpinEdit, 0)
			Me.Controls.SetChildIndex(Me.heightSpinEdit, 0)
			Me.Controls.SetChildIndex(Me.label1, 0)
			Me.Controls.SetChildIndex(Me.label2, 0)
			Me.Controls.SetChildIndex(Me.createInfoCellsCheckEdit, 0)
			Me.Controls.SetChildIndex(Me.useSharedFormulaCheckEdit, 0)
			CType(Me.widthSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.heightSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.createInfoCellsCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.useSharedFormulaCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private WithEvents widthSpinEdit As SpinEdit
		Private WithEvents heightSpinEdit As SpinEdit
		Private label1 As LabelControl
		Private label2 As LabelControl
		Private WithEvents createInfoCellsCheckEdit As CheckEdit
		Private WithEvents useSharedFormulaCheckEdit As CheckEdit
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetSimplifiedMultiplicationTableModule
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
			Me.tableCountSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.columnsSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.tableCountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.columnsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' tableCountSpinEdit
			' 
			Me.tableCountSpinEdit.EditValue = New Decimal(New Integer() { 8, 0, 0, 0})
			Me.tableCountSpinEdit.Location = New System.Drawing.Point(90, 18)
			Me.tableCountSpinEdit.Name = "tableCountSpinEdit"
			Me.tableCountSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.tableCountSpinEdit.Properties.IsFloatValue = False
			Me.tableCountSpinEdit.Properties.Mask.EditMask = "N00"
			Me.tableCountSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
			Me.tableCountSpinEdit.Properties.MaxValue = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.tableCountSpinEdit.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.tableCountSpinEdit.Size = New System.Drawing.Size(60, 20)
			Me.tableCountSpinEdit.TabIndex = 0
'			Me.tableCountSpinEdit.EditValueChanged += New System.EventHandler(Me.spinEdit_EditValueChanged);
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(3, 21)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(62, 13)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Table Count:"
			' 
			' columnsSpinEdit
			' 
			Me.columnsSpinEdit.EditValue = New Decimal(New Integer() { 4, 0, 0, 0})
			Me.columnsSpinEdit.Location = New System.Drawing.Point(90, 48)
			Me.columnsSpinEdit.Name = "columnsSpinEdit"
			Me.columnsSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.columnsSpinEdit.Properties.IsFloatValue = False
			Me.columnsSpinEdit.Properties.Mask.EditMask = "N00"
			Me.columnsSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
			Me.columnsSpinEdit.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.columnsSpinEdit.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.columnsSpinEdit.Size = New System.Drawing.Size(60, 20)
			Me.columnsSpinEdit.TabIndex = 1
'			Me.columnsSpinEdit.EditValueChanged += New System.EventHandler(Me.spinEdit_EditValueChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(3, 51)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(71, 13)
			Me.labelControl1.TabIndex = 3
			Me.labelControl1.Text = "Column Count:"
			' 
			' SpreadsheetSimplifiedMultiplicationTableModule
			' 
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.columnsSpinEdit)
			Me.Controls.Add(Me.tableCountSpinEdit)
			Me.Name = "SpreadsheetSimplifiedMultiplicationTableModule"
			Me.Controls.SetChildIndex(Me.tableCountSpinEdit, 0)
			Me.Controls.SetChildIndex(Me.columnsSpinEdit, 0)
			Me.Controls.SetChildIndex(Me.label1, 0)
			Me.Controls.SetChildIndex(Me.labelControl1, 0)
			CType(Me.tableCountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.columnsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private WithEvents tableCountSpinEdit As SpinEdit
		Private label1 As LabelControl
		Private WithEvents columnsSpinEdit As SpinEdit
		Private labelControl1 As LabelControl
	End Class
End Namespace

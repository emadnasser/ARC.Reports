Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class NumberToWords
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
			Me.numberSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.resultTreeList = New DevExpress.XtraTreeList.TreeList()
			CType(Me.numberSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.resultTreeList, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' numberSpinEdit
			' 
			Me.numberSpinEdit.EditValue = New Decimal(New Integer() { 4321, 0, 0, 0})
			Me.numberSpinEdit.Location = New System.Drawing.Point(94, 18)
			Me.numberSpinEdit.Name = "numberSpinEdit"
			Me.numberSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.numberSpinEdit.Properties.IsFloatValue = False
			Me.numberSpinEdit.Properties.Mask.EditMask = "N00"
			Me.numberSpinEdit.Size = New System.Drawing.Size(100, 20)
			Me.numberSpinEdit.TabIndex = 0
'			Me.numberSpinEdit.ValueChanged += New System.EventHandler(Me.spinEdit1_ValueChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl1.Location = New System.Drawing.Point(17, 21)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(71, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Number:"
			' 
			' resultTreeList
			' 
			Me.resultTreeList.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.resultTreeList.Location = New System.Drawing.Point(17, 53)
			Me.resultTreeList.Name = "resultTreeList"
			Me.resultTreeList.OptionsBehavior.Editable = False
			Me.resultTreeList.OptionsView.ShowIndicator = False
			Me.resultTreeList.Size = New System.Drawing.Size(750, 360)
			Me.resultTreeList.TabIndex = 2
			' 
			' NumberToWords
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.resultTreeList)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.numberSpinEdit)
			Me.Name = "NumberToWords"
			CType(Me.numberSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.resultTreeList, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents numberSpinEdit As XtraEditors.SpinEdit
		Private labelControl1 As XtraEditors.LabelControl
		Private resultTreeList As XtraTreeList.TreeList
	End Class
End Namespace

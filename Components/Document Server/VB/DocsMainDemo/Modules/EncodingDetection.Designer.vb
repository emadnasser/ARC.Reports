Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class EncodingDetection
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
			Me.txtNoDetection = New DevExpress.XtraEditors.MemoEdit()
			Me.txtDetection = New DevExpress.XtraEditors.MemoEdit()
			Me.cbLanguage = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblAutoDetect = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.lblEncoding = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.txtNoDetection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtDetection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLanguage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' txtNoDetection
			' 
			Me.txtNoDetection.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.txtNoDetection.Location = New System.Drawing.Point(3, 65)
			Me.txtNoDetection.Name = "txtNoDetection"
			Me.txtNoDetection.Size = New System.Drawing.Size(689, 250)
			Me.txtNoDetection.TabIndex = 1
			' 
			' txtDetection
			' 
			Me.txtDetection.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.txtDetection.Location = New System.Drawing.Point(3, 351)
			Me.txtDetection.Name = "txtDetection"
			Me.txtDetection.Size = New System.Drawing.Size(689, 250)
			Me.txtDetection.TabIndex = 1
			' 
			' cbLanguage
			' 
			Me.cbLanguage.Location = New System.Drawing.Point(83, 9)
			Me.cbLanguage.Name = "cbLanguage"
			Me.cbLanguage.Properties.AutoHeight = False
			Me.cbLanguage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLanguage.Properties.DropDownRows = 8
			Me.cbLanguage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbLanguage.Size = New System.Drawing.Size(113, 20)
			Me.cbLanguage.TabIndex = 2
'			Me.cbLanguage.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEdit1_SelectedIndexChanged);
'			Me.cbLanguage.EditValueChanging += New DevExpress.XtraEditors.Controls.ChangingEventHandler(Me.cbLanguage_EditValueChanging);
			' 
			' lblAutoDetect
			' 
			Me.lblAutoDetect.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.lblAutoDetect.Location = New System.Drawing.Point(3, 332)
			Me.lblAutoDetect.Name = "lblAutoDetect"
			Me.lblAutoDetect.Size = New System.Drawing.Size(103, 13)
			Me.lblAutoDetect.TabIndex = 3
			Me.lblAutoDetect.Text = "Encoding Detector"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(3, 12)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(74, 13)
			Me.labelControl1.TabIndex = 4
			Me.labelControl1.Text = "Load text from "
			' 
			' lblEncoding
			' 
			Me.lblEncoding.Location = New System.Drawing.Point(224, 332)
			Me.lblEncoding.Name = "lblEncoding"
			Me.lblEncoding.Size = New System.Drawing.Size(0, 13)
			Me.lblEncoding.TabIndex = 8
			' 
			' labelControl2
			' 
			Me.labelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelControl2.Location = New System.Drawing.Point(165, 332)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(53, 13)
			Me.labelControl2.TabIndex = 10
			Me.labelControl2.Text = "Encoding:"
			' 
			' labelControl3
			' 
			Me.labelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelControl3.Location = New System.Drawing.Point(4, 45)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(125, 13)
			Me.labelControl3.TabIndex = 11
			Me.labelControl3.Text = "No Encoding Detection"
			' 
			' EncodingDetection
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.lblEncoding)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.lblAutoDetect)
			Me.Controls.Add(Me.cbLanguage)
			Me.Controls.Add(Me.txtDetection)
			Me.Controls.Add(Me.txtNoDetection)
			Me.Name = "EncodingDetection"
			Me.Size = New System.Drawing.Size(719, 624)
			CType(Me.txtNoDetection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtDetection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLanguage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private txtNoDetection As MemoEdit
		Private txtDetection As MemoEdit
		Private WithEvents cbLanguage As ComboBoxEdit
		Private lblAutoDetect As LabelControl
		Private labelControl1 As LabelControl
		Private lblEncoding As LabelControl
		Private labelControl2 As LabelControl
		Private labelControl3 As LabelControl


	End Class
End Namespace

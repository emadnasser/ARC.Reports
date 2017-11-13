Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ToDoList
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
		Private Sub InitializeComponent()
            Me.radioGroup1 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit3 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit4 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radioGroup1
            '
            Me.radioGroup1.EditValue = True
            Me.radioGroup1.Location = New System.Drawing.Point(13, 13)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioGroup1.Properties.Appearance.Options.UseFont = True
            Me.radioGroup1.Properties.AutoHeight = False
            Me.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
            Me.radioGroup1.Properties.Caption = "Install DevExpress Components"
            Me.radioGroup1.Size = New System.Drawing.Size(234, 20)
            Me.radioGroup1.TabIndex = 0
            '
            'checkEdit3
            '
            Me.checkEdit3.Location = New System.Drawing.Point(13, 65)
            Me.checkEdit3.Name = "checkEdit3"
            Me.checkEdit3.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkEdit3.Properties.Appearance.Options.UseFont = True
            Me.checkEdit3.Properties.AutoHeight = False
            Me.checkEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
            Me.checkEdit3.Properties.Caption = "View all new components"
            Me.checkEdit3.Size = New System.Drawing.Size(160, 20)
            Me.checkEdit3.TabIndex = 3
            '
            'checkEdit4
            '
            Me.checkEdit4.EditValue = True
            Me.checkEdit4.Location = New System.Drawing.Point(13, 39)
            Me.checkEdit4.Name = "checkEdit4"
            Me.checkEdit4.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkEdit4.Properties.Appearance.Options.UseFont = True
            Me.checkEdit4.Properties.AutoHeight = False
            Me.checkEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
            Me.checkEdit4.Properties.Caption = "Test WinForms Demos"
            Me.checkEdit4.Size = New System.Drawing.Size(160, 20)
            Me.checkEdit4.TabIndex = 4
            '
            'checkEdit1
            '
            Me.checkEdit1.Location = New System.Drawing.Point(13, 91)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkEdit1.Properties.Appearance.Options.UseFont = True
            Me.checkEdit1.Properties.AutoHeight = False
            Me.checkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
            Me.checkEdit1.Properties.Caption = "Create a simple application"
            Me.checkEdit1.Size = New System.Drawing.Size(160, 20)
            Me.checkEdit1.TabIndex = 5
            '
            'ToDoList
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.checkEdit1)
            Me.Controls.Add(Me.checkEdit4)
            Me.Controls.Add(Me.checkEdit3)
            Me.Controls.Add(Me.radioGroup1)
            Me.Name = "ToDoList"
            Me.Padding = New System.Windows.Forms.Padding(10)
            Me.Size = New System.Drawing.Size(361, 213)
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents radioGroup1 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit3 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit4 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit



	End Class
End Namespace

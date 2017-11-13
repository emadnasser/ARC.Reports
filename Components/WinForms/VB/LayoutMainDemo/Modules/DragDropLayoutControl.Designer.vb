Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraLayout.Demos.Modules
	Public Partial Class DragDropLayoutControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
            Me.dragDropLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            CType(Me.dragDropLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl2
            ' 
            Me.dragDropLayout.AllowDrop = True
            Me.dragDropLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dragDropLayout.Location = New System.Drawing.Point(0, 0)
            Me.dragDropLayout.Name = "layoutControl2"
            Me.dragDropLayout.Root = Me.layoutControlGroup2
            Me.dragDropLayout.Size = New System.Drawing.Size(362, 346)
            Me.dragDropLayout.TabIndex = 5
            Me.dragDropLayout.Text = "layoutControl2"
            '			Me.layoutControl2.DragEnter += New System.Windows.Forms.DragEventHandler(Me.layoutControl2_DragEnter);
            '			Me.layoutControl2.DragDrop += New System.Windows.Forms.DragEventHandler(Me.layoutControl2_DragDrop);
            '			Me.layoutControl2.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.layoutControl2_MouseDown);
            '			Me.layoutControl2.DragOver += New System.Windows.Forms.DragEventHandler(Me.layoutControl2_DragOver);
            '			Me.layoutControl2.DragLeave += New System.EventHandler(Me.layoutControl2_DragLeave);
            '			Me.layoutControl2.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.layoutControl2_MouseMove);
            '			Me.layoutControl2.GiveFeedback += New System.Windows.Forms.GiveFeedbackEventHandler(Me.layoutControl2_GiveFeedback);
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(362, 346)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "layoutControlGroup2"
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' DragDropLayoutControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dragDropLayout)
            Me.Name = "DragDropLayoutControl"
            Me.Size = New System.Drawing.Size(362, 346)
            CType(Me.dragDropLayout, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Protected Friend WithEvents dragDropLayout As LayoutControl
		Private layoutControlGroup2 As LayoutControlGroup
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Namespace DashboardDemos.Core
	Partial Public Class CreateDatabaseWaitForm
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
			Me.components = New System.ComponentModel.Container()
			Me.labelCaption = New DevExpress.XtraEditors.LabelControl()
			Me.progressBar = New DevExpress.XtraEditors.ProgressBarControl()
			Me.timerProgress = New System.Windows.Forms.Timer(Me.components)
			CType(Me.progressBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' labelCaption
			' 
			Me.labelCaption.Appearance.Font = New System.Drawing.Font("Tahoma", 10F)
			Me.labelCaption.Location = New System.Drawing.Point(32, 21)
			Me.labelCaption.Name = "labelCaption"
			Me.labelCaption.Size = New System.Drawing.Size(118, 16)
			Me.labelCaption.TabIndex = 0
			Me.labelCaption.Text = "Creating databases.."
			' 
			' progressBar
			' 
			Me.progressBar.Location = New System.Drawing.Point(28, 50)
			Me.progressBar.Name = "progressBar"
			Me.progressBar.Size = New System.Drawing.Size(238, 18)
			Me.progressBar.TabIndex = 1
			' 
			' timerProgress
			' 
			Me.timerProgress.Interval = 1000
'			Me.timerProgress.Tick += New System.EventHandler(Me.timerProgress_Tick);
			' 
			' CreateDatabaseWaitForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.ClientSize = New System.Drawing.Size(293, 92)
			Me.Controls.Add(Me.progressBar)
			Me.Controls.Add(Me.labelCaption)
			Me.DoubleBuffered = True
			Me.Name = "CreateDatabaseWaitForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.CreateDatabaseWaitForm_Load);
			CType(Me.progressBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private labelCaption As DevExpress.XtraEditors.LabelControl
		Private progressBar As DevExpress.XtraEditors.ProgressBarControl
		Private WithEvents timerProgress As System.Windows.Forms.Timer

	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos.Forms
	Public Partial Class SelectDateForm
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dateNavigator1
			' 
			Me.dateNavigator1.DateTime = New System.DateTime(2009, 10, 19, 18, 18, 6, 0)
			Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dateNavigator1.Location = New System.Drawing.Point(0, 0)
			Me.dateNavigator1.Name = "dateNavigator1"
			Me.dateNavigator1.ShowTodayButton = False
			Me.dateNavigator1.Size = New System.Drawing.Size(184, 148)
			Me.dateNavigator1.TabIndex = 0
'			Me.dateNavigator1.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.dateNavigator_MouseClick);
'			Me.dateNavigator1.EditDateModified += New System.EventHandler(Me.dateNavigator1_EditDateModified);
			' 
			' SelectDateForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(184, 148)
			Me.Controls.Add(Me.dateNavigator1)
			Me.Name = "SelectDateForm"
			Me.Text = "Select a date"
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents dateNavigator1 As DevExpress.XtraScheduler.DateNavigator



	End Class
End Namespace

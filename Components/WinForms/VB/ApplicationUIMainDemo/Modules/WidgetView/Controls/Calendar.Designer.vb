Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class Calendar
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
			Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dateNavigator1
			' 
            Me.dateNavigator1.CalendarAppearance.DayCell.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.dateNavigator1.CalendarAppearance.DayCell.Options.UseFont = True
            Me.dateNavigator1.CalendarAppearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.dateNavigator1.CalendarAppearance.Header.Options.UseFont = True
            Me.dateNavigator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.dateNavigator1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.dateNavigator1.DateTime = New System.DateTime(2013, 11, 22, 0, 0, 0, 0)
            Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dateNavigator1.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.dateNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.dateNavigator1.SelectionMode = XtraEditors.Repository.CalendarSelectionMode.Single
            Me.dateNavigator1.Name = "dateNavigator1"
            Me.dateNavigator1.ShowTodayButton = False
            Me.dateNavigator1.ShowWeekNumbers = False
            Me.dateNavigator1.Size = New System.Drawing.Size(241, 190)
            Me.dateNavigator1.TabIndex = 0
            ' 
            ' Calendar
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dateNavigator1)
            Me.Name = "Calendar"
            Me.Size = New System.Drawing.Size(241, 190)
            CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator

	End Class
End Namespace

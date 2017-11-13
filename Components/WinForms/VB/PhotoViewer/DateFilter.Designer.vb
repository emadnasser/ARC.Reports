Imports Microsoft.VisualBasic
Imports System
Namespace PhotoViewer
	Partial Public Class DateFilter
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
            Dim DateRange1 As DevExpress.XtraEditors.Controls.DateRange = New DevExpress.XtraEditors.Controls.DateRange()
            Me.separator = New DevExpress.XtraEditors.LabelControl()
            Me._startDate = New DevExpress.XtraEditors.VistaCalendarControl()
            Me.allowFilterCheck = New DevExpress.XtraEditors.CheckEdit()
            Me.panel1 = New System.Windows.Forms.Panel()
            CType(Me._startDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.allowFilterCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'separator
            '
            Me.separator.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.separator.Dock = System.Windows.Forms.DockStyle.Top
            Me.separator.LineVisible = True
            Me.separator.Location = New System.Drawing.Point(0, 0)
            Me.separator.Name = "separator"
            Me.separator.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
            Me.separator.Size = New System.Drawing.Size(445, 13)
            Me.separator.TabIndex = 5
            '
            '_startDate
            '
            Me._startDate.AutoSize = False
            Me._startDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me._startDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me._startDate.DateTime = New Date(2010, 7, 23, 0, 0, 0, 0)
            Me._startDate.Dock = System.Windows.Forms.DockStyle.Fill
            Me._startDate.EditValue = New Date(2010, 7, 23, 0, 0, 0, 0)
            Me._startDate.Location = New System.Drawing.Point(0, 0)
            Me._startDate.Name = "_startDate"
            DateRange1.EndDate = New Date(2010, 7, 24, 0, 0, 0, 0)
            DateRange1.StartDate = New Date(2010, 7, 23, 0, 0, 0, 0)
            Me._startDate.SelectedRanges.Add(DateRange1)
            Me._startDate.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Multiple
            Me._startDate.Size = New System.Drawing.Size(445, 262)
            Me._startDate.TabIndex = 3
            '
            'allowFilterCheck
            '
            Me.allowFilterCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.allowFilterCheck.Location = New System.Drawing.Point(11, 17)
            Me.allowFilterCheck.Name = "allowFilterCheck"
            Me.allowFilterCheck.Properties.Caption = "Apply Filter"
            Me.allowFilterCheck.Size = New System.Drawing.Size(75, 19)
            Me.allowFilterCheck.TabIndex = 6
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.allowFilterCheck)
            Me.panel1.Controls.Add(Me.separator)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 262)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(445, 46)
            Me.panel1.TabIndex = 7
            '
            'DateFilter
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me._startDate)
            Me.Controls.Add(Me.panel1)
            Me.Name = "DateFilter"
            Me.Size = New System.Drawing.Size(445, 308)
            CType(Me._startDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.allowFilterCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private separator As DevExpress.XtraEditors.LabelControl
        Private WithEvents _startDate As DevExpress.XtraEditors.VistaCalendarControl
		Private WithEvents allowFilterCheck As DevExpress.XtraEditors.CheckEdit
		Private panel1 As System.Windows.Forms.Panel
	End Class
End Namespace
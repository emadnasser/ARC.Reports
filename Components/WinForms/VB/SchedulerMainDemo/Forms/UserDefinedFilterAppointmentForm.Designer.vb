Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos.Forms
	Partial Public Class UserDefinedFilterAppointmentForm
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
			Me.lblPrice = New System.Windows.Forms.Label()
			Me.edtPrice = New DevExpress.XtraEditors.CalcEdit()
			CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.progressPanel.SuspendLayout()
			CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lblLabel
			' 
			Me.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent
			' 
			' chkAllDay
			' 
			' 
			' edtStartDate
			' 
			Me.edtStartDate.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			' 
			' edtEndDate
			' 
			Me.edtEndDate.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			' 
			' edtStartTime
			' 
			Me.edtStartTime.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			' 
			' edtEndTime
			' 
			Me.edtEndTime.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			' 
			' edtLabel
			' 
			' 
			' edtShowTimeAs
			' 
			' 
			' tbSubject
			' 
			' 
			' edtResource
			' 
			' 
			' edtResources
			' 
			' 
			' 
			' 
			Me.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = True
			Me.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.edtResources.ResourcesCheckedListBoxControl.Location = New System.Drawing.Point(0, 0)
			Me.edtResources.ResourcesCheckedListBoxControl.Name = ""
			Me.edtResources.ResourcesCheckedListBoxControl.Size = New System.Drawing.Size(200, 100)
			Me.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0
			' 
			' chkReminder
			' 
			' 
			' tbDescription
			' 
			Me.tbDescription.Location = New System.Drawing.Point(16, 222)
			Me.tbDescription.Size = New System.Drawing.Size(496, 120)
			Me.tbDescription.TabIndex = 15
			' 
			' cbReminder
			' 
			' 
			' tbLocation
			' 
			' 
			' progressPanel
			' 
			Me.progressPanel.Location = New System.Drawing.Point(16, 187)
			' 
			' tbProgress
			' 
			Me.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			' 
			' lblPercentComplete
			' 
			Me.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent
			' 
			' lblPercentCompleteValue
			' 
			Me.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent
			' 
			' lblPrice
			' 
			Me.lblPrice.AutoSize = True
			Me.lblPrice.Location = New System.Drawing.Point(16, 168)
			Me.lblPrice.Name = "lblPrice"
			Me.lblPrice.Size = New System.Drawing.Size(34, 13)
			Me.lblPrice.TabIndex = 37
			Me.lblPrice.Text = "&Price:"
			' 
			' edtPrice
			' 
			Me.edtPrice.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.edtPrice.Location = New System.Drawing.Point(96, 165)
			Me.edtPrice.Name = "edtPrice"
			Me.edtPrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.edtPrice.Size = New System.Drawing.Size(216, 20)
			Me.edtPrice.TabIndex = 14
			' 
			' UserDefinedFilterAppointmentForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(528, 382)
			Me.Controls.Add(Me.edtPrice)
			Me.Controls.Add(Me.lblPrice)
			Me.Name = "UserDefinedFilterAppointmentForm"
			Me.Controls.SetChildIndex(Me.panel1, 0)
			Me.Controls.SetChildIndex(Me.progressPanel, 0)
			Me.Controls.SetChildIndex(Me.tbDescription, 0)
			Me.Controls.SetChildIndex(Me.lblPrice, 0)
			Me.Controls.SetChildIndex(Me.edtPrice, 0)
			Me.Controls.SetChildIndex(Me.edtShowTimeAs, 0)
			Me.Controls.SetChildIndex(Me.edtEndTime, 0)
			Me.Controls.SetChildIndex(Me.edtEndDate, 0)
			Me.Controls.SetChildIndex(Me.btnRecurrence, 0)
			Me.Controls.SetChildIndex(Me.btnDelete, 0)
			Me.Controls.SetChildIndex(Me.btnCancel, 0)
			Me.Controls.SetChildIndex(Me.lblShowTimeAs, 0)
			Me.Controls.SetChildIndex(Me.lblEndTime, 0)
			Me.Controls.SetChildIndex(Me.tbLocation, 0)
			Me.Controls.SetChildIndex(Me.lblSubject, 0)
			Me.Controls.SetChildIndex(Me.lblLocation, 0)
			Me.Controls.SetChildIndex(Me.tbSubject, 0)
			Me.Controls.SetChildIndex(Me.lblStartTime, 0)
			Me.Controls.SetChildIndex(Me.btnOk, 0)
			Me.Controls.SetChildIndex(Me.edtStartDate, 0)
			Me.Controls.SetChildIndex(Me.edtStartTime, 0)
			CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.progressPanel.ResumeLayout(False)
			Me.progressPanel.PerformLayout()
			CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lblPrice As System.Windows.Forms.Label
		Private edtPrice As DevExpress.XtraEditors.CalcEdit
	End Class
End Namespace

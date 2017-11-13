Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class WeatherInCaliforniaModule
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
			Me.panel = New DevExpress.XtraEditors.PanelControl()
			Me.chkHumidity = New DevExpress.XtraEditors.CheckEdit()
			Me.chkPressure = New DevExpress.XtraEditors.CheckEdit()
			Me.chkTemperature = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.chkHumidity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkPressure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkTemperature.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 60)
			Me.ribbonControl1.Size = New System.Drawing.Size(697, 142)
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 202)
			Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
			Me.spreadsheetControl1.Size = New System.Drawing.Size(697, 208)
			' 
			' panel
			' 
			Me.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel.Controls.Add(Me.chkHumidity)
			Me.panel.Controls.Add(Me.chkPressure)
			Me.panel.Controls.Add(Me.chkTemperature)
			Me.panel.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel.Location = New System.Drawing.Point(0, 0)
			Me.panel.Name = "panel"
			Me.panel.Size = New System.Drawing.Size(697, 35)
			Me.panel.TabIndex = 55
			' 
			' chkHumidity
			' 
			Me.chkHumidity.EditValue = True
			Me.chkHumidity.Location = New System.Drawing.Point(98, 8)
			Me.chkHumidity.Name = "chkHumidity"
			Me.chkHumidity.Properties.AutoWidth = True
			Me.chkHumidity.Properties.Caption = "Humidity"
			Me.chkHumidity.Size = New System.Drawing.Size(63, 19)
			Me.chkHumidity.TabIndex = 1
'			Me.chkHumidity.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged);
			' 
			' chkPressure
			' 
			Me.chkPressure.EditValue = True
			Me.chkPressure.Location = New System.Drawing.Point(198, 8)
			Me.chkPressure.Name = "chkPressure"
			Me.chkPressure.Properties.AutoWidth = True
			Me.chkPressure.Properties.Caption = "Pressure"
			Me.chkPressure.Size = New System.Drawing.Size(64, 19)
			Me.chkPressure.TabIndex = 2
'			Me.chkPressure.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged);
			' 
			' chkTemperature
			' 
			Me.chkTemperature.EditValue = True
			Me.chkTemperature.Location = New System.Drawing.Point(0, 8)
			Me.chkTemperature.Name = "chkTemperature"
			Me.chkTemperature.Properties.AutoWidth = True
			Me.chkTemperature.Properties.Caption = "Temperature"
			Me.chkTemperature.Size = New System.Drawing.Size(84, 19)
			Me.chkTemperature.TabIndex = 0
'			Me.chkTemperature.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged);
			' 
			' WeatherInCaliforniaModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panel)
			Me.Name = "WeatherInCaliforniaModule"
			Me.Size = New System.Drawing.Size(697, 410)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.chkHumidity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkPressure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkTemperature.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private panel As XtraEditors.PanelControl
		Protected WithEvents chkTemperature As XtraEditors.CheckEdit
		Protected WithEvents chkPressure As XtraEditors.CheckEdit
		Protected WithEvents chkHumidity As XtraEditors.CheckEdit
	End Class
End Namespace

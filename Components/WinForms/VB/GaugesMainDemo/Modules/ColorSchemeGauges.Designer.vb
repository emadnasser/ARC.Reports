Namespace DevExpress.XtraGauges.Demos
    Partial Public Class ColorSchemeGauges
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
            Me.colorPickControl = New DevExpress.XtraGauges.Demos.ColorPickerControl()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.gaugesDashboard1 = New DevExpress.XtraGauges.Demos.GaugesDashboard()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'colorPickControl
            '
            Me.colorPickControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.colorPickControl.Location = New System.Drawing.Point(0, 10)
            Me.colorPickControl.Margin = New System.Windows.Forms.Padding(10)
            Me.colorPickControl.Name = "colorPickControl"
            Me.colorPickControl.Size = New System.Drawing.Size(271, 600)
            Me.colorPickControl.TabIndex = 1
            Me.colorPickControl.TabStop = False
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.colorPickControl)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(481, 0)
            Me.panel1.Margin = New System.Windows.Forms.Padding(10)
            Me.panel1.Name = "panel1"
            Me.panel1.Padding = New System.Windows.Forms.Padding(0, 10, 10, 10)
            Me.panel1.Size = New System.Drawing.Size(281, 620)
            Me.panel1.TabIndex = 2
            '
            'gaugesDashboard1
            '
            Me.gaugesDashboard1.ColorPicker = Nothing
            Me.gaugesDashboard1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugesDashboard1.Location = New System.Drawing.Point(0, 0)
            Me.gaugesDashboard1.Name = "gaugesDashboard1"
            Me.gaugesDashboard1.Size = New System.Drawing.Size(481, 620)
            Me.gaugesDashboard1.TabIndex = 3
            '
            'ColorSchemeGauges
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gaugesDashboard1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "ColorSchemeGauges"
            Me.Size = New System.Drawing.Size(762, 620)
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

        Private WithEvents colorPickControl As ColorPickerControl
        Private panel1 As System.Windows.Forms.Panel
        Private gaugesDashboard1 As GaugesDashboard
    End Class
End Namespace

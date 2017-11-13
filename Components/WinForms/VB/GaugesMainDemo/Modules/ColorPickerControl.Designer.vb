Namespace DevExpress.XtraGauges.Demos
    Partial Public Class ColorPickerControl
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
            Me.xtraTabControl1 = New DevExpress.XtraGauges.Demos.NonFocusableTabControl()
            Me.tabCustom = New DevExpress.XtraTab.XtraTabPage()
            Me.colorPickControl = New DevExpress.XtraEditors.InnerColorPickControl()
            Me.tabWeb = New DevExpress.XtraTab.XtraTabPage()
            Me.webColorListControl = New DevExpress.XtraEditors.InnerColorListControl()
            Me.tabSystem = New DevExpress.XtraTab.XtraTabPage()
            Me.systemColorListControl = New DevExpress.XtraEditors.InnerColorListControl()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.tabCustom.SuspendLayout()
            Me.tabWeb.SuspendLayout()
            Me.tabSystem.SuspendLayout()
            Me.SuspendLayout()
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.tabCustom
            Me.xtraTabControl1.Size = New System.Drawing.Size(295, 471)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabCustom, Me.tabWeb, Me.tabSystem})
            Me.xtraTabControl1.TabStop = False
            '
            'tabCustom
            '
            Me.tabCustom.Controls.Add(Me.colorPickControl)
            Me.tabCustom.Name = "tabCustom"
            Me.tabCustom.Size = New System.Drawing.Size(289, 443)
            Me.tabCustom.Text = "Custom"
            '
            'colorPickControl
            '
            Me.colorPickControl.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.colorPickControl.Appearance.Options.UseBackColor = True
            Me.colorPickControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.colorPickControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.colorPickControl.Location = New System.Drawing.Point(0, 0)
            Me.colorPickControl.Name = "colorPickControl"
            Me.colorPickControl.Selectable = True
            Me.colorPickControl.Size = New System.Drawing.Size(289, 443)
            Me.colorPickControl.TabIndex = 2
            Me.colorPickControl.UserMouse = True
            '
            'tabWeb
            '
            Me.tabWeb.Controls.Add(Me.webColorListControl)
            Me.tabWeb.Name = "tabWeb"
            Me.tabWeb.Size = New System.Drawing.Size(289, 443)
            Me.tabWeb.Text = "Web"
            '
            'webColorListControl
            '
            Me.webColorListControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.webColorListControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.webColorListControl.Location = New System.Drawing.Point(0, 0)
            Me.webColorListControl.Name = "webColorListControl"
            Me.webColorListControl.Selectable = True
            Me.webColorListControl.Size = New System.Drawing.Size(289, 443)
            Me.webColorListControl.TabIndex = 1
            Me.webColorListControl.UserMouse = True
            '
            'tabSystem
            '
            Me.tabSystem.Controls.Add(Me.systemColorListControl)
            Me.tabSystem.Name = "tabSystem"
            Me.tabSystem.Size = New System.Drawing.Size(289, 443)
            Me.tabSystem.Text = "System"
            '
            'systemColorListControl
            '
            Me.systemColorListControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.systemColorListControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.systemColorListControl.Location = New System.Drawing.Point(0, 0)
            Me.systemColorListControl.Name = "systemColorListControl"
            Me.systemColorListControl.Selectable = True
            Me.systemColorListControl.Size = New System.Drawing.Size(289, 443)
            Me.systemColorListControl.TabIndex = 1
            Me.systemColorListControl.UserMouse = True
            '
            'ColorPickerControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ColorPickerControl"
            Me.Size = New System.Drawing.Size(295, 471)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.tabCustom.ResumeLayout(False)
            Me.tabWeb.ResumeLayout(False)
            Me.tabSystem.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private xtraTabControl1 As DevExpress.XtraGauges.Demos.NonFocusableTabControl
        Private tabCustom As XtraTab.XtraTabPage
        Private tabWeb As XtraTab.XtraTabPage
        Private tabSystem As XtraTab.XtraTabPage
        Private WithEvents colorPickControl As XtraEditors.InnerColorPickControl
        Private WithEvents webColorListControl As XtraEditors.InnerColorListControl
        Private WithEvents systemColorListControl As XtraEditors.InnerColorListControl
    End Class
End Namespace

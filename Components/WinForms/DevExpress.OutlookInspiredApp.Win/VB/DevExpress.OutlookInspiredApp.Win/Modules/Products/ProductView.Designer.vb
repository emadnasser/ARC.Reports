Namespace DevExpress.DevAV.Modules
    Partial Public Class ProductView
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
            Me.components = New System.ComponentModel.Container()
            Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
            Me.panel = New DevExpress.XtraEditors.PanelControl()
            CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel.SuspendLayout()
            Me.SuspendLayout()
            Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfViewer.Location = New System.Drawing.Point(2, 2)
            Me.pdfViewer.Name = "pdfViewer"
            Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
            Me.pdfViewer.Size = New System.Drawing.Size(446, 596)
            Me.pdfViewer.TabIndex = 0
            Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
            Me.panel.Controls.Add(Me.pdfViewer)
            Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel.Location = New System.Drawing.Point(0, 0)
            Me.panel.Name = "panel"
            Me.panel.Size = New System.Drawing.Size(450, 600)
            Me.panel.TabIndex = 0
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panel)
            Me.Name = "ProductView"
            Me.Size = New System.Drawing.Size(450, 600)
            CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private pdfViewer As DevExpress.XtraPdfViewer.PdfViewer
        Private panel As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace

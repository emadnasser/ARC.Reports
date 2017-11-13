Imports System

Namespace DevExpress.XtraLayout.Demos
    Partial Public Class LayoutInteractivePrinting
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnPrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintPreview.Click
            layoutWaybill1.pedLogo.Properties.SizeMode = XtraEditors.Controls.PictureSizeMode.Squeeze
            layoutWaybill1.layoutControl1.ShowPrintPreview()
            layoutWaybill1.pedLogo.Properties.SizeMode = XtraEditors.Controls.PictureSizeMode.Zoom
        End Sub
    End Class
End Namespace

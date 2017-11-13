Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting

Namespace XtraPrintingDemos.Tutorial1
    Public Class LessonPreviewControl2
        Inherits LessonPreviewControl1

        Public Sub New()
        End Sub

        Protected Overrides Sub CreateReportHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
            Const CaptionHeight As Single = 66F
            e.Graph.Font = New Font("Tahoma", 18F)
            e.Graph.BorderWidth = 0F
            e.Graph.StringFormat = e.Graph.StringFormat.ChangeLineAlignment(StringAlignment.Center).ChangeAlignment(StringAlignment.Center)
            e.Graph.DrawString(DocumentCaption, New RectangleF(PointF.Empty, New SizeF(e.Graph.ClientPageSize.Width, CaptionHeight)))
        End Sub
    End Class
End Namespace

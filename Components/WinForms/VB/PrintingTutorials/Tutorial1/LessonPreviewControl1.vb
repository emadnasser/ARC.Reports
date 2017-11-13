Imports System
Imports DevExpress.XtraPrinting
Imports System.Drawing
Imports System.ComponentModel

Namespace XtraPrintingDemos.Tutorial1
    Public Class LessonPreviewControl1
        Inherits XtraPrintingDemos.PreviewControl

        Protected Const DocumentCaption As String = "Product List"
        Protected ReadOnly link As New Link()

        Private components As Container

        Public Sub New()
            InitializeComponent()
            AddHandler Me.link.CreateReportHeaderArea, AddressOf CreateReportHeaderArea
        End Sub

        Protected Overridable Sub CreateReportHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
            e.Graph.BorderWidth = 0F
            Dim size As SizeF = e.Graph.MeasureString(DocumentCaption)
            e.Graph.DrawString(DocumentCaption, New RectangleF(PointF.Empty, size))
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            components = New System.ComponentModel.Container()
        End Sub
        #End Region
        Public Overrides Sub Activate()
            If link IsNot Nothing Then
                link.CreateDocument(printingSystem)
            End If
        End Sub
    End Class
End Namespace

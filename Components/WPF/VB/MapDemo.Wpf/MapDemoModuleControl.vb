Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Map

Namespace MapDemo
    Public Class MapDemoModule
        Inherits DemoModule

        Public Sub New()
        End Sub

        Public Overrides Sub Leave()
            For Each map As MapControl In DemoUtils.FindMap(Me)
                map.HideToolTip()
            Next map
            MyBase.Leave()
        End Sub

        Public Overrides ReadOnly Property AllowRtl() As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace

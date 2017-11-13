Imports DevExpress.Xpf.DemoBase

Namespace DevExpress.Xpf.LayoutControlDemo
    Public Class LayoutControlDemoModule
        Inherits DemoModule

        Public Const UriPrefix As String = "/LayoutControlDemo;component"

        Protected Overrides ReadOnly Property XamlSuffix() As String
            Get
                Return ".xaml"
            End Get
        End Property
    End Class
End Namespace

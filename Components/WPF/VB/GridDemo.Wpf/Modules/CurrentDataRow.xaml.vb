Imports System
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    <CodeFile("ModuleResources/CurrentDataRowTemplates(.SL).xaml")>
    Partial Public Class CurrentDataRow
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides ReadOnly Property IsGridBorderVisible() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

Imports System
Imports DevExpress.Xpf.DemoBase.DemoTesting

Namespace DevExpress.Xpf.LayoutControlDemo.Tests
    Public Class LayoutControlCheckAllDemosFixture
        Inherits CheckAllDemosFixture

        Protected Overrides Function CheckMemoryLeaks(ByVal moduleType As Type) As Boolean
            Return True
        End Function
    End Class
End Namespace

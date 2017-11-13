Imports DevExpress.Xpf.DemoBase.DemoTesting
Imports System
Imports DevExpress.Xpf.Bars
Imports System.Reflection
Imports DevExpress.Xpf.Core.Native
Imports System.Windows
Imports System.Windows.Controls
Imports System.Linq

Namespace RibbonDemo.Tests
    Public Class RibbonCheckAllDemosFixture
        Inherits CheckAllDemosFixture

    End Class
    Public Class RibbonDemoModulesAccessor
        Inherits DemoModulesAccessor(Of RibbonDemoModule)

        Public Sub New(ByVal fixture As BaseDemoTestingFixture)
            MyBase.New(fixture)
        End Sub
        Public ReadOnly Property Manager() As BarManager
            Get
                Return DemoModule.Manager
            End Get
        End Property
    End Class

    Public MustInherit Class BaseRibbonDemoTestingFixture
        Inherits BaseDemoTestingFixture

        Private ReadOnly modulesAccessor As RibbonDemoModulesAccessor
        Public Sub New()
            modulesAccessor = New RibbonDemoModulesAccessor(Me)
        End Sub
        Public ReadOnly Property Manager() As BarManager
            Get
                Return modulesAccessor.Manager
            End Get
        End Property
    End Class

    Public Class CheckDemoOptionsFixture
        Inherits BaseRibbonDemoTestingFixture

    End Class
End Namespace

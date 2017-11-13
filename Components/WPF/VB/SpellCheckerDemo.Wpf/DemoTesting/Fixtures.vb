Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.DemoBase.DemoTesting
Imports DevExpress.Xpf.SpellChecker

Namespace SpellCheckerDemo.Tests
    Public Class SpellCheckerDemoModuleAccessor
        Inherits DemoModulesAccessor(Of SpellCheckerDemoModule)

        Public Sub New(ByVal fixture As BaseDemoTestingFixture)
            MyBase.New(fixture)
        End Sub
        Public ReadOnly Property SpellChecker() As SpellChecker
            Get
                Return DemoModule.SpellChecker
            End Get
        End Property
    End Class
    Public MustInherit Class BaseSpellCheckerTestingFixture
        Inherits BaseDemoTestingFixture

        Private ReadOnly modulesAccessor As SpellCheckerDemoModuleAccessor
        Public Sub New()
            Me.modulesAccessor = New SpellCheckerDemoModuleAccessor(Me)
        End Sub
        Public ReadOnly Property SpellChecker() As SpellChecker
            Get
                Return Me.modulesAccessor.SpellChecker
            End Get
        End Property
    End Class
    Public Class SpellCheckerCheckAllDemosFixture
        Inherits CheckAllDemosFixture

    End Class
End Namespace

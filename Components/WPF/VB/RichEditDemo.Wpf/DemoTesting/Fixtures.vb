Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.DemoBase.DemoTesting
Imports DevExpress.XtraRichEdit
Imports DevExpress.Xpf.RichEdit

Namespace RichEditDemo.Tests
    Public Class RichEditDemoModuleAccessor
        Inherits DemoModulesAccessor(Of RichEditDemoModule)

        Public Sub New(ByVal fixture As BaseDemoTestingFixture)
            MyBase.New(fixture)
        End Sub
        Public ReadOnly Property RichEditControl() As RichEditControl
            Get
                Return DemoModule.RichEditControl
            End Get
        End Property
    End Class
    Public MustInherit Class BaseRichEditTestingFixture
        Inherits BaseDemoTestingFixture

        Private ReadOnly modulesAccessor As RichEditDemoModuleAccessor
        Public Sub New()
            Me.modulesAccessor = New RichEditDemoModuleAccessor(Me)
        End Sub
        Public ReadOnly Property RichEditControl() As RichEditControl
            Get
                Return Me.modulesAccessor.RichEditControl
            End Get
        End Property
    End Class
    Public Class FakeModuleFixture
        Inherits BaseRichEditTestingFixture

        Protected Overrides Sub CreateActions()
            AddLoadModuleActions(GetType(CharacterFormatting))
            Dim dayViewModule As CharacterFormatting = CType(DemoBaseTesting.CurrentDemoModule, CharacterFormatting)
            Dim viewType As RichEditViewType = DispatchExpr(Function() dayViewModule.richEdit.ActiveViewType)
            Assert.AreEqual(RichEditViewType.PrintLayout, viewType)
        End Sub
    End Class
    Public Class RichEditCheckAllDemosFixture
        Inherits CheckAllDemosFixture

        Protected Overrides Function CanRunModule(ByVal moduleType As Type) As Boolean
            Return moduleType IsNot GetType(MasterDetailMailMerge)
        End Function
    End Class
End Namespace

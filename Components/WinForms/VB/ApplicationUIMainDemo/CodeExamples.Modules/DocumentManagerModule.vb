Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.ApplicationUI.Demos
    Public Class DocumentManagerModule
        Inherits CodeTutorialControlBase

        Public Sub New()
            MyBase.New()
        End Sub
        Protected Overrides ReadOnly Property FileNamesForModule() As String()
            Get
                Return New String() {"CommonConcepts.vb", "TabbedView.vb", "WindowsUIView.vb", "WidgetView.vb"}
            End Get
        End Property
        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return ExampleLanguage.VB
            End Get
        End Property
    End Class
End Namespace

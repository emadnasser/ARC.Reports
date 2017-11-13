Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.MVVM.Demos.CodeExamples
    Public Class MessengerModule
        Inherits CodeTutorialControlBase

        Public Sub New()
            MyBase.New()
        End Sub
        Protected Overrides ReadOnly Property UseSameTutorialControlNameForGenerateExample() As Boolean
            Get
                Return True
            End Get
        End Property
        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return ExampleLanguage.VB
            End Get
        End Property
    End Class
End Namespace

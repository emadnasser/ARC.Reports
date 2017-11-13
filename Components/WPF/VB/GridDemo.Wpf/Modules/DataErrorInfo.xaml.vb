Imports System.Collections.Generic
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    <CodeFile("ModuleResources/DataErrorInfoClasses.(cs)")>
    Partial Public Class DataErrorInfo
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            Dim persons As New List(Of Person)()
            persons.Add(New Person("John", "", "123 Home Lane, Homesville", "(555)956-15-47", "none"))
            persons.Add(New Person("Henry", "McAllister", "436 1st Ave, Cleveland", "(555)941-24-32", "@hotbox.com"))
            persons.Add(New Person("Frank", "Frankson", "349 Graphic Design L, Newman", "(555)155-05-02", "none"))
            persons.Add(New Person("Freddy", "Krueger", "Elm Street", "", "none"))
            persons.Add(New Person("Leticia", "Ford", "93900 Carter Lane, Cartersville", "(555)776-15-66", "none"))
            persons.Add(New Person("Karen", "Holmes", "", "(555)342-25-74", "none"))
            persons.Add(New Person("Roger", "Michelson", "3920 Michelson Dr., Bridgeford", "(555)954-51-88", "none"))
            grid.ItemsSource = persons
        End Sub
    End Class
End Namespace

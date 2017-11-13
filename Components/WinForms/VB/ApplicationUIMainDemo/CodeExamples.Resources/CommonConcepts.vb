Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors

Namespace Examples
    <CodeExampleClass("Common Concepts", "CommonConcepts.vb"), CodeExampleHighlightTokens("UserControl")>
    Public NotInheritable Class DocumentLayout

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim documentManager As New DocumentManager()
            Dim documentManagerHost As New XtraUserControl()
            documentManagerHost.Parent = sampleHost
            documentManagerHost.Dock = DockStyle.Fill
            Dim view As New TabbedView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = documentManagerHost
            Return New Object() {documentManager}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim documentManager As DocumentManager = documentManager.FromControl(sampleHost)
            If documentManager IsNot Nothing Then
                documentManager.Dispose()
            End If
        End Sub
        <CodeExampleCase("Add Document via new Control")>
        Public Shared Sub AddDocumentViaControl(ByVal documentManager As DocumentManager)
            Dim control = New UserControl()
            control.Text = "Document1"
            documentManager.View.AddDocument(control)
        End Sub
        <CodeExampleCase("Add Document via QueryControl event"), CodeExampleUnderlineTokens("QueryControl")>
        Public Shared Sub AddDocumentViaQueryControl(ByVal documentManager As DocumentManager)
            AddHandler documentManager.View.QueryControl, Sub(sender, e)
                                                              If e.Document.ControlName = "UserControl1" Then
                                                                  e.Control = New UserControl()
                                                              End If
                                                          End Sub
            documentManager.View.AddDocument("Document1", "UserControl1")
        End Sub
        <CodeExampleCase("Add Document via ControlName")>
        Public Shared Sub AddDocumentViaControlName(ByVal documentManager As DocumentManager)
            documentManager.View.AddDocument("Document1", "UserControl1")
            Dim control = New UserControl()
            control.Name = "UserControl1"
            documentManager.View.AddDocument(control)
        End Sub
    End Class
End Namespace

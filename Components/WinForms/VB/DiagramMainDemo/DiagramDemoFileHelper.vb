Imports DevExpress.Utils
Imports DevExpress.XtraDiagram.Demos
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Linq
Namespace DevExpress.Diagram.Demos
    Public NotInheritable Class DiagramDemoFileHelper

        Private Sub New()
        End Sub

        Public Shared Function GetDataStream(ByVal fileName As String) As Stream
            Return File.OpenRead(DiagramTutorialControl.GetDataFileName(fileName))
        End Function
        Public Shared Function GetImageResource(ByVal path As String) As Image
            Dim assembly = GetType(DiagramDemoFileHelper).Assembly
            Dim stream = AssemblyHelper.GetResourceStream(assembly, path, True)
            Return New Bitmap(stream)
        End Function
    End Class
End Namespace

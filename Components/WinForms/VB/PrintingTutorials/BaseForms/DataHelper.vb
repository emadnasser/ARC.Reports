Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraPrinting.Control
Imports System.Data
Imports System.Collections.Generic

Namespace XtraPrintingDemos
    Public NotInheritable Class Helper

        Private Sub New()
        End Sub
        Public Shared demoPath As String = Directory.GetCurrentDirectory()

        Private Shared Function GetRelativePathCore(ByVal name As String) As String
            Return DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\" & name)
        End Function
        Public Shared Function GetRelativePath(ByVal path As String) As String
            If System.Reflection.Assembly.GetEntryAssembly() <> System.Reflection.Assembly.GetExecutingAssembly() Then
                Return System.IO.Path.Combine(demoPath, path)
            End If
            Dim index As Integer = path.LastIndexOf("\") + 1
            Return GetRelativePathCore(path.Substring(index))
        End Function
    End Class
End Namespace

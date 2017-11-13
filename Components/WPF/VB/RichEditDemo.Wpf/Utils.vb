Imports System
Imports System.IO
Imports System.Text
Imports System.Windows
Imports System.Reflection
Imports DevExpress.DemoData.Helpers
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditDemo
    Public Class DemoUtils
        Public Shared Function GetRelativePath(ByVal name As String) As String
            name = "Data\" & name
            Dim path As String = DataFilesHelper.DataDirectory
            Dim s As String = "\"
            For i As Integer = 0 To 10
                If System.IO.File.Exists(path & s & name) Then
                    Return System.IO.Path.GetFullPath(path & s & name)
                Else
                    s &= "..\"
                End If
            Next i
            Return ""
        End Function
        Public Shared Function GetDataStream(ByVal fileName As String) As Stream
            Dim path As String = DemoUtils.GetRelativePath(fileName)
            If Not String.IsNullOrEmpty(path) Then
                Dim fileAccess As FileAccess = If((File.GetAttributes(path) And FileAttributes.ReadOnly) <> 0, System.IO.FileAccess.Read, System.IO.FileAccess.ReadWrite)
                Return New FileStream(path, FileMode.Open, fileAccess)
            End If
            Return Nothing
        End Function
    End Class
    Public Class RtfLoadHelper
        Public Shared Sub Load(ByVal fileName As String, ByVal richEditControl As RichEditControl)
            Dim path As String = DemoUtils.GetRelativePath(fileName)
            If Not String.IsNullOrEmpty(path) Then
                richEditControl.LoadDocument(path, DocumentFormat.Rtf)
            End If
        End Sub
    End Class
    Public Class DocLoadHelper
        Public Shared Sub Load(ByVal fileName As String, ByVal richEditControl As RichEditControl)
            Dim path As String = DemoUtils.GetRelativePath(fileName)
            If Not String.IsNullOrEmpty(path) Then
                richEditControl.LoadDocument(path, DocumentFormat.Doc)
            End If
        End Sub
    End Class
    Public Class HtmlLoadHelper
        Public Shared Sub Load(ByVal fileName As String, ByVal richEditControl As RichEditControl)
            Dim path As String = DemoUtils.GetRelativePath(fileName)
            If Not String.IsNullOrEmpty(path) Then
                richEditControl.LoadDocument(path, DocumentFormat.Html)
            End If
        End Sub
    End Class
    Public Class OpenXmlLoadHelper
        Public Shared Sub Load(ByVal fileName As String, ByVal richEditControl As RichEditControl)
            Dim path As String = DemoUtils.GetRelativePath(fileName)
            If Not String.IsNullOrEmpty(path) Then
                richEditControl.LoadDocument(path, DocumentFormat.OpenXml)
            End If
        End Sub
    End Class
    Public Class PlainTextLoadHelper
        Public Shared Sub Load(ByVal fileName As String, ByVal richEditControl As RichEditControl)
            Dim path As String = DemoUtils.GetRelativePath(fileName)
            If Not String.IsNullOrEmpty(path) Then
                richEditControl.LoadDocument(path, DocumentFormat.PlainText)
            End If
        End Sub
    End Class
    Public Class CodeFileLoadHelper
        Public Shared Sub Load(ByVal moduleName As String, ByVal richEditControl As RichEditControl)
            Dim stream As Stream = DemoHelper.GetCodeTextStream(GetType(CodeFileLoadHelper).Assembly, GetCodeFileName(moduleName))
            If stream IsNot Nothing Then
                richEditControl.LoadDocument(stream, DocumentFormat.PlainText)
            End If
        End Sub
        Public Shared Function GetCodeFileName(ByVal moduleName As String) As String
            Return String.Format("{0}.xaml{1}", moduleName, DemoHelper.GetCodeSuffix(GetType(CodeFileLoadHelper).Assembly))
        End Function
    End Class
    Public Class RichEditDemoExceptionsHandler
        Private ReadOnly control As RichEditControl
        Public Sub New(ByVal control As RichEditControl)
            Me.control = control
        End Sub
        Public Sub Install()
            If control IsNot Nothing Then
                AddHandler control.UnhandledException, AddressOf OnRichEditControlUnhandledException
            End If
        End Sub

        Private Sub OnRichEditControlUnhandledException(ByVal sender As Object, ByVal e As RichEditUnhandledExceptionEventArgs)
            Try
                If e.Exception IsNot Nothing Then
                    Throw e.Exception
                End If
            Catch ex As RichEditUnsupportedFormatException
                ShowMessage(ex.Message)
                e.Handled = True
            Catch ex As System.Runtime.InteropServices.ExternalException
                ShowMessage(ex.Message)
                e.Handled = True
            Catch ex As System.IO.IOException
                ShowMessage(ex.Message)
                e.Handled = True
            Catch ex As System.InvalidOperationException
                If ex.Message = DevExpress.XtraRichEdit.Localization.XtraRichEditLocalizer.GetString(DevExpress.XtraRichEdit.Localization.XtraRichEditStringId.Msg_MagicNumberNotFound) OrElse ex.Message = DevExpress.XtraRichEdit.Localization.XtraRichEditLocalizer.GetString(DevExpress.XtraRichEdit.Localization.XtraRichEditStringId.Msg_UnsupportedDocVersion) Then
                    ShowMessage(ex.Message)
                    e.Handled = True
                Else
                    Throw ex
                End If
            Catch ex As SystemException
                ShowMessage(ex.Message)
                e.Handled = True
            End Try
        End Sub
        Private Sub ShowMessage(ByVal message As String)
            DXMessageBox.Show(message, System.Windows.Forms.Application.ProductName, MessageBoxButton.OK, MessageBoxImage.Error)
        End Sub
    End Class
    Public MustInherit Class BufferedDocumentVisitor
        Inherits DocumentVisitorBase


        Private ReadOnly buffer_Renamed As StringBuilder
        Protected Sub New()
            Me.buffer_Renamed = New StringBuilder()
        End Sub
        Protected ReadOnly Property Buffer() As StringBuilder
            Get
                Return buffer_Renamed
            End Get
        End Property
    End Class
End Namespace

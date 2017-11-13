Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Data
Imports System.IO
Imports System.Windows.Forms
Imports System.Globalization
Imports DevExpress.XtraRichEdit.Internal
Imports DevExpress.XtraSpellChecker
Imports DevExpress.XtraRichEdit.API.Native

Namespace DevExpress.XtraRichEdit.Demos
	''' <summary>
	''' Summary description for DemoUtils.
	''' </summary>
	Public Class DemoUtils
		Public Shared Function GetRelativePath(ByVal name As String) As String
			name = "Data\" & name
			Dim path As String = System.Windows.Forms.Application.StartupPath
			Dim s As String = "\"
			For i As Integer = 0 To 10
				If System.IO.File.Exists(path & s & name) Then
					Return (path & s & name)
				Else
					s &= "..\"
				End If
			Next i
			Return ""
        End Function
        Public Shared Sub SetConnectionString(ByVal oleDbConnection As System.Data.OleDb.OleDbConnection, ByVal path As String)
            oleDbConnection.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path)
        End Sub
    End Class
	Public Class RtfLoadHelper
		Public Shared Sub Load(ByVal fileName As String, ByVal richEditControl As RichEditControl)
			Dim path As String = DemoUtils.GetRelativePath(fileName)
			If (Not String.IsNullOrEmpty(path)) Then
				richEditControl.LoadDocument(path, DocumentFormat.Rtf)
			End If
		End Sub
    End Class
    Public Class DocLoadHelper
        Public Shared Sub Load(ByVal fileName As String, ByVal richEditControl As RichEditControl)
            Dim path As String = DemoUtils.GetRelativePath(fileName)
            If (Not String.IsNullOrEmpty(path)) Then
                richEditControl.LoadDocument(path, DocumentFormat.Doc)
            End If
        End Sub
    End Class
    Public Class HtmlLoadHelper
        Public Shared Sub Load(ByVal fileName As String, ByVal richEditControl As RichEditControl)
            Dim path As String = DemoUtils.GetRelativePath(fileName)
            If (Not String.IsNullOrEmpty(path)) Then
                richEditControl.LoadDocument(path, DocumentFormat.Html)
            End If
        End Sub
    End Class
    Public Class OpenXmlLoadHelper
        Public Shared Sub Load(ByVal fileName As String, ByVal richEditControl As RichEditControl)
            Dim path As String = DemoUtils.GetRelativePath(fileName)
            If (Not String.IsNullOrEmpty(path)) Then
                richEditControl.LoadDocument(path, DocumentFormat.OpenXml)
            End If
        End Sub
    End Class
    Public Class PlainTextLoadHelper
        Public Shared Sub Load(ByVal fileName As String, ByVal richEditControl As RichEditControl)
            Dim path As String = DemoUtils.GetRelativePath(fileName)
            If (Not String.IsNullOrEmpty(path)) Then
                richEditControl.LoadDocument(path, DocumentFormat.PlainText)
            End If
        End Sub
    End Class
    Public Class SpellCheckerHelper
        Public Shared Sub AddDictionaries(ByVal storage As SharedDictionaryStorage)
            Dim engCulture As CultureInfo = New CultureInfo("en-us")
            If storage.Dictionaries.Count = 0 Then
                Dim dictionary As SpellCheckerISpellDictionary = New SpellCheckerISpellDictionary(DemoUtils.GetRelativePath("american.xlg"), DemoUtils.GetRelativePath("english.aff"), engCulture)
                dictionary.AlphabetPath = DemoUtils.GetRelativePath("EnglishAlphabet.txt")
                storage.Dictionaries.Add(dictionary)
                Dim customDictionary As SpellCheckerCustomDictionary = New SpellCheckerCustomDictionary(DemoUtils.GetRelativePath("CustomEnglish.dic"), engCulture)
                storage.Dictionaries.Add(customDictionary)
            End If
        End Sub
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
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            Catch ex As System.IO.IOException
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End Try
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

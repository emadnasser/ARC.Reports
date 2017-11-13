Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports System.Globalization
Imports DevExpress.XtraSpellChecker

Namespace DevExpress.XtraSpellChecker.Demos
    ''' <summary>
    ''' Summary description for Employees.
    ''' </summary>
    Partial Public Class CustomDictionary
        Inherits BaseTutorialControl
        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()

            ' TODO: Add any initialization after the InitForm call
        End Sub

        Protected ReadOnly Property Dictionary() As SpellCheckerCustomDictionary
            Get
                Return CType(spellChecker1.Dictionaries(0), SpellCheckerCustomDictionary)
            End Get
        End Property

        Private Sub FormDictionary_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitSpellChecker()
        End Sub
        Protected Sub OnEditControlKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mmDictionary.KeyDown, memText.KeyDown
            OnEditorKeyDown(sender, e)
        End Sub
        Protected Overridable Sub InitSpellChecker()
            spellChecker1.Dictionaries.Add(New SpellCheckerCustomDictionary(String.Empty, New CultureInfo("En-us")))
        End Sub
        Protected Overrides Function GetActiveControl() As Control
            Return memText
        End Function
        Private Sub spellChecker1_AfterCheck(ByVal sender As Object, ByVal e As System.EventArgs) Handles spellChecker1.AfterCheck
            Dim words As New ArrayList()
            Dim wordCount As Integer = Dictionary.WordCount
            For i As Integer = 0 To wordCount - 1
                words.Add(Dictionary(i))
            Next i
            mmDictionary.Lines = CType(words.ToArray(GetType(String)), String())
        End Sub
        Private Sub spellChecker1_BeforeCheck(ByVal sender As Object, ByVal e As System.EventArgs) Handles spellChecker1.BeforeCheck
            Dictionary.Clear()
            Dictionary.AddWords(mmDictionary.Lines)
        End Sub
    End Class
End Namespace

Imports System
Imports System.Globalization
Imports System.IO
Imports System.Windows
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.SpellChecker
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraSpellChecker
Imports DevExpress.XtraSpellChecker.Native
Imports DevExpress.XtraRichEdit.SpellChecker

Namespace RichEditDemo
    Partial Public Class SpellChecking
        Inherits RichEditDemoModule

        Private spellChecker As SpellChecker

        Public Sub New()
            InitializeComponent()
            Me.spellChecker = InitializeSpellChecker()
            RtfLoadHelper.Load("SpellChecker.rtf", richEdit)
        End Sub
        Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.SpellChecker = spellChecker
            ApplySpellCheckMode()
        End Sub
        Private Sub btnCheckSpelling_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            spellChecker.Check(richEdit)
        End Sub
        Private Sub edtCheckAsYouType_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            ApplySpellCheckMode()
        End Sub
        Private Sub ApplySpellCheckMode()
            If edtCheckAsYouType.IsChecked = True Then
                spellChecker.SpellCheckMode = SpellCheckMode.AsYouType
            Else
                spellChecker.SpellCheckMode = SpellCheckMode.OnDemand
            End If
        End Sub

        #Region "SpellChecker initialization"
        Public Shared Function InitializeSpellChecker() As SpellChecker
            Dim spellChecker As New SpellChecker()
            spellChecker.Culture = New CultureInfo("en-US")
            spellChecker.SpellingFormType = SpellingFormType.Word
            RegisterDictionary(spellChecker, GetDefaultDictionary())
            RegisterDictionary(spellChecker, GetCustomDictionary(spellChecker))

            SpellCheckTextControllersManager.Default.RegisterClass(GetType(RichEditControl), GetType(RichEditSpellCheckController))
            Dim repository As New UndoControllerRepository()
            repository.Register(GetType(RichEditControl), GetType(RichEditUndoController))
            Return spellChecker
        End Function
        Private Shared Function GetDefaultDictionary() As SpellCheckerDictionaryBase
            Dim dic As New SpellCheckerISpellDictionary()
            dic.LoadFromStream(DemoUtils.GetDataStream("american.xlg"), DemoUtils.GetDataStream("english.aff"), DemoUtils.GetDataStream("EnglishAlphabet.txt"))
            Return dic
        End Function
        Private Shared Sub RegisterDictionary(ByVal spellChecker As SpellChecker, ByVal dic As SpellCheckerDictionaryBase)
            dic.Culture = spellChecker.Culture
            spellChecker.Dictionaries.Add(dic)
        End Sub
        Private Shared Function GetCustomDictionary(ByVal spellChecker As SpellChecker) As SpellCheckerDictionaryBase
            Return New SpellCheckerCustomDictionary("CustomEnglish.dic", spellChecker.Culture)
        End Function
        #End Region
    End Class
End Namespace

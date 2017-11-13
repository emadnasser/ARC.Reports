Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraSpellChecker
Imports System.Globalization
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Zip
Imports System.IO

Namespace DevExpress.XtraSpellChecker.Demos
	Partial Public Class BaseTutorialControl
		Inherits DevExpress.XtraSpellChecker.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overridable Sub OnTutorialControlLoaded(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			If DesignMode Then
				Return
			End If
			Dim dictionaries As DictionaryCollection = If(spellChecker1.UseSharedDictionaries, sharedDictionaryStorage1.Dictionaries, spellChecker1.Dictionaries)
			If dictionaries.Count = 0 Then
				PopulateDictionaries(dictionaries)
			End If
			spellChecker1.Culture = If(dictionaries.Count > 0, dictionaries(0).Culture, CultureInfo.CurrentCulture)
		End Sub
		Protected Overridable Sub PopulateDictionaries(ByVal dictionaries As DictionaryCollection)
			dictionaries.Add(GetDefaultDictionary())
			Dim customDictionary As New SpellCheckerCustomDictionary(DemoUtils.GetRelativePath("Dictionaries\CustomEnglish.dic"), New CultureInfo("en-US"))
			dictionaries.Add(customDictionary)
		End Sub
		Private Function GetDefaultDictionary() As ISpellCheckerDictionary
			Dim dic As New SpellCheckerISpellDictionary()
			Dim zipFileStream As Stream = GetFileStream("Dictionaries\default.zip")
			Dim files As InternalZipFileCollection = InternalZipArchive.Open(zipFileStream)
			Dim alphabetStream As Stream = GetFileStream("Dictionaries\EnglishAlphabet.txt")
			Dim dictionaryStream As Stream = GetFileStream(files, "american.xlg")
			Dim grammarStream As Stream = GetFileStream(files, "english.aff")
			Try
				dic.LoadFromStream(dictionaryStream, grammarStream, alphabetStream)
			Catch
			Finally
				dictionaryStream.Dispose()
				grammarStream.Dispose()
				zipFileStream.Dispose()
				alphabetStream.Dispose()
				DisposeZipFileStreams(files)
			End Try
			dic.Culture = New CultureInfo("en-US")
			Return dic
		End Function
		Protected Function GetFileStream(ByVal relativeUri As String) As Stream
			Return New FileStream(DemoUtils.GetRelativePath(relativeUri), FileMode.Open, FileAccess.Read, FileShare.Read)
		End Function
		Protected Function GetFileStream(ByVal files As InternalZipFileCollection, ByVal name As String) As Stream
			Dim stream As Stream = files.Find(Function(file As InternalZipFile) file.FileName.IndexOf(name) >= 0).FileDataStream
			Try
				Return CreateMemoryStream(stream)
			Finally
				stream.Close()
			End Try
		End Function
		Protected Function CreateMemoryStream(ByVal stream As Stream) As Stream
			Dim result As New MemoryStream()
			Do
				Dim readedByte As Integer = stream.ReadByte()
				If readedByte < 0 Then
					Exit Do
				End If
				result.WriteByte(CByte(readedByte))
			Loop
			result.Flush()
			result.Seek(0, SeekOrigin.Begin)
			Return result
		End Function
		Protected Sub DisposeZipFileStreams(ByVal files As InternalZipFileCollection)
			For Each file As InternalZipFile In files
				file.FileDataStream.Dispose()
			Next file
		End Sub
		Protected Overridable Function GetActiveControl() As Control
			Dim result As Control = ActiveControl
			If TypeOf result Is DevExpress.XtraEditors.TextBoxMaskBox Then
				result = result.Parent
			End If
			Return result
		End Function
		Protected Overridable Sub OnEditorKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
			If e.KeyCode = Keys.F7 AndAlso e.Modifiers = Keys.None Then
				DoCheck()
			End If
		End Sub
		Private Sub btnCheckSpelling_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckSpelling.Click
			DoCheck()
		End Sub
		Protected Overridable Sub DoCheck()
			spellChecker1.Check(GetActiveControl())
		End Sub

		Protected Overridable Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
			spellChecker1.SpellCheckMode = If((TryCast(sender, CheckEdit)).Checked, SpellCheckMode.AsYouType, SpellCheckMode.OnDemand)
			If spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType Then
				DoCheck()
			End If
		End Sub
	End Class
End Namespace


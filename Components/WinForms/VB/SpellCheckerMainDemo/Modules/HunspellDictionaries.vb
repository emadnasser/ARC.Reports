Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSpellChecker.Rules
Imports System.Collections.Generic
Imports DevExpress.XtraBars
Imports System.Globalization
Imports System.IO
Imports DevExpress.Utils.Zip

Namespace DevExpress.XtraSpellChecker.Demos
	''' <summary>
	''' Summary description for Employees.
	''' </summary>
	Partial Public Class HunspellDictionaries
		Inherits BaseTutorialControl
		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			spellChecker1.UseSharedDictionaries = False
			LoadDocument()
		End Sub

		Private Sub LoadDocument()
			Dim path As String = DemoUtils.GetRelativePath("HunspellDictionaries.docx")
			If (Not String.IsNullOrEmpty(path)) Then
				richEditControl1.LoadDocument(path, DevExpress.XtraRichEdit.DocumentFormat.OpenXml)
			End If
		End Sub
		Protected Overrides Sub OnTutorialControlLoaded(ByVal sender As Object, ByVal e As EventArgs)
			MyBase.OnTutorialControlLoaded(sender, e)
			spellChecker1.Culture = CultureInfo.InvariantCulture
		End Sub
		Protected Overrides Function GetActiveControl() As Control
			Return richEditControl1
		End Function
		Protected Sub OnEditControlKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles richEditControl1.KeyDown
			OnEditorKeyDown(sender, e)
		End Sub
		Protected Overrides Sub PopulateDictionaries(ByVal dictionaries As DictionaryCollection)
			dictionaries.Add(CreateHunspellDictionaries(New CultureInfo("en-US")))
			dictionaries.Add(CreateHunspellDictionaries(New CultureInfo("de-DE")))
			dictionaries.Add(CreateHunspellDictionaries(New CultureInfo("ru-RU")))
		End Sub
		Private Function CreateHunspellDictionaries(ByVal culture As CultureInfo) As HunspellDictionary
			Dim parts() As String = culture.Name.Split("-"c)
			Dim result As New HunspellDictionary()
			Dim zipFileStream As Stream = GetFileStream(String.Format("Dictionaries\{0}_{1}.zip", parts(0), parts(1)))
			Dim files As InternalZipFileCollection = InternalZipArchive.Open(zipFileStream)
			Dim dictionaryStream As Stream = GetFileStream(files, ".dic")
			Dim grammarStream As Stream = GetFileStream(files, ".aff")
			Try
				result.LoadFromStream(dictionaryStream, grammarStream)
			Catch
			Finally
				dictionaryStream.Dispose()
				grammarStream.Dispose()
				zipFileStream.Dispose()
				DisposeZipFileStreams(files)
			End Try
			result.Culture = culture
			Return result
		End Function
		Protected Overrides Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.spellChecker1.SpellCheckMode = If((TryCast(sender, CheckEdit)).Checked, SpellCheckMode.AsYouType, SpellCheckMode.OnDemand)
		End Sub
	End Class
End Namespace

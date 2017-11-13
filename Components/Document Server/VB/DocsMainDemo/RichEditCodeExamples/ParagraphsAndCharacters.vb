Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditExamples
	Public NotInheritable Class ParagraphsAndCharactersActions
		Private Sub New()
		End Sub
		Private Shared Sub ChangeSelection(ByVal document As Document)
'			#Region "#Selections"
			document.AppendText("Some text.")
			Dim textRange As DocumentRange = document.CreateRange(2, 5)
			Dim cp As CharacterProperties = document.BeginUpdateCharacters(textRange)
			cp.BackColor = System.Drawing.Color.FromArgb(180, 201, 233)
			document.EndUpdateCharacters(cp)
'			#End Region ' #Selections
		End Sub
		Private Shared Sub ChangeCharacterStyle(ByVal document As Document)
'			#Region "#CharacterStyle"
			Dim textRange As DocumentRange = document.AppendText("Some text.")
			Dim cp As CharacterProperties = document.BeginUpdateCharacters(textRange)
			cp.Bold = True
			cp.FontSize = 16
			cp.FontName = "Arial"
			cp.ForeColor = DXColor.Red
			cp.BackColor = DXColor.LightGreen
			document.EndUpdateCharacters(cp)
'			#End Region ' #CharacterStyle
		End Sub
		Private Shared Sub CreateParagraph(ByVal document As Document)
'			#Region "#Paragraphs"
			document.AppendText("First paragraph.")
			document.Paragraphs.Append()
			document.AppendText("Second paragraph.")
'			#End Region ' #Paragraphs
		End Sub
		Private Shared Sub ChangeParagraphStyle(ByVal document As Document)
'			#Region "#ParagraphStyle"
			document.AppendText("Title")
			document.Paragraphs.Append()
			document.Paragraphs(0).BackColor = DXColor.Yellow
			document.Paragraphs(0).Alignment = ParagraphAlignment.Center
			document.AppendText("Some text.")
			document.Paragraphs(1).BackColor = DXColor.YellowGreen
'			#End Region ' #ParagraphStyle
		End Sub
		Private Shared Sub CreateNumberingList(ByVal document As Document)
'			#Region "#Numbering List"
			document.BeginUpdate()
			'Describe the pattern used for bulleted list.
			'Specify parameters used to represent each list level, up to the eighth level.
			document.AbstractNumberingLists.Add()

			' Create a numbering list. It is based on a previously defined abstract list with ID = 0.
			document.NumberingLists.Add(0)

			'The main purpose of the Guard class is to validate parameters passed into a method. 
			'Methods exposed by the Guard class are designed to throw exceptions if a parameter being checked does not pass validation.
			Guard.Equals(document.NumberingLists(document.NumberingLists.Count - 1).Index, document.NumberingLists.Count - 1)

			' Append list items
			document.AppendText("One")
			document.Paragraphs.Append()
			Dim paragraph As Paragraph = document.Paragraphs(0)
			paragraph.ListIndex = 0

			document.AppendText("Two")
			document.Paragraphs.Append()
			paragraph = document.Paragraphs(1)
			paragraph.ListIndex = 0

			document.AppendText("Three")
			document.Paragraphs.Append()
			paragraph = document.Paragraphs(2)
			paragraph.ListIndex = 0

			document.EndUpdate()
'			#End Region ' #Numbering List
		End Sub
		Private Shared Sub ChangeNumberingListStyle(ByVal document As Document)
'			#Region "#Numbering List Style"
			document.BeginUpdate()
			'Describe the pattern used for bulleted list.
			'Specify parameters used to represent each list level, up to the eighth level.
			Dim list As AbstractNumberingList = document.AbstractNumberingLists.Add()
			document.AbstractNumberingLists.Add()
			list.NumberingType = NumberingType.Bullet

			Dim level As ListLevel = list.Levels(0)
			level.ParagraphProperties.LeftIndent = 150
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 75
			level.CharacterProperties.FontName = "Symbol"
			level.DisplayFormatString = New String(ChrW(&H00B7), 1)

			' Create a numbering list. It is based on a previously defined abstract list with ID = 0.
			document.NumberingLists.Add(0)

			'The main purpose of the Guard class is to validate parameters passed into a method. 
			'Methods exposed by the Guard class are designed to throw exceptions if a parameter being checked does not pass validation.
			Guard.Equals(document.NumberingLists(document.NumberingLists.Count - 1).Index, document.NumberingLists.Count - 1)

			' Append list items
			document.AppendText("One")
			document.Paragraphs.Append()
			Dim paragraph As Paragraph = document.Paragraphs(0)
			paragraph.ListIndex = 0
			paragraph.ListLevel = 0

			document.AppendText("OneOne")
			document.Paragraphs.Append()
			paragraph = document.Paragraphs(1)
			paragraph.ListIndex = 0
			paragraph.ListLevel = 1

			document.AppendText("Two")
			document.Paragraphs.Append()
			paragraph = document.Paragraphs(2)
			paragraph.ListIndex = 0
			paragraph.ListLevel = 0

			document.EndUpdate()
'			#End Region ' #Numbering List Style
		End Sub
	End Class
End Namespace

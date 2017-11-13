Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Demos.Forms

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class DocumentIteratorModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Private contentChanged_Renamed As Boolean
		Private includeTextboxes As Boolean

		Public Sub New()
			InitializeComponent()
			exportTimer.Start()
			AddHandler richEditControl.ContentChanged, AddressOf RichEditContentChanged
			OpenXmlLoadHelper.Load("Markdown.docx", richEditControl)
			CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
		End Sub

		Private Property ContentChanged() As Boolean
			Get
				SyncLock Me
					Return contentChanged_Renamed
				End SyncLock
			End Get
			Set(ByVal value As Boolean)
				SyncLock Me
					Me.contentChanged_Renamed = value
				End SyncLock
			End Set
		End Property

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			richEditControl.Focus()
		End Sub

		Private Sub RichEditContentChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.ContentChanged
			StartTimer()
		End Sub
		Private Sub StartTimer()
			ContentChanged = True
			exportTimer.Start()
		End Sub
		Private Sub ExportTimerElapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles exportTimer.Elapsed
			If (Not ContentChanged) Then
				Return
			End If
			ContentChanged = False
			exportTimer.Stop()
			BeginInvoke(New Action(Function() AnonymousMethod1()))
		End Sub
		
		Private Function AnonymousMethod1() As Boolean
			ExportToMarkdown()
			Return True
		End Function
		Private Sub ExportToMarkdown()
			Dim visitor As New MarkdownVisitor()
			Iterate(visitor)
			memoEditMarkdown.Text = visitor.Text
		End Sub
		Private Sub DocumentStatisticsBarButtonItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles documentStatisticsBarButtonItem.ItemClick
			ShowDocumentStatisticsForm()
		End Sub
		Private Sub ShowDocumentStatisticsForm()
			Using form As New DocumentStatisticsForm(richEditControl.Document, Me.includeTextboxes)
				form.LookAndFeel.ParentLookAndFeel = LookAndFeel
				form.ShowDialog()
				Me.includeTextboxes = form.IncludeTextboxes
			End Using
		End Sub
		Private Sub Iterate(ByVal visitor As IDocumentVisitor)
			Dim iterator As New DocumentIterator(richEditControl.Document, True)
			Do While iterator.MoveNext()
				iterator.Current.Accept(visitor)
			Loop
		End Sub
	End Class
	Public Class MarkdownVisitor
		Inherits BufferedDocumentVisitor
		Private Const lastLowSpecial As Char = ChrW(&H1f)
		Private Const firstHighSpecial As Char = ChrW(&Hffff)
		Public ReadOnly Property Text() As String
			Get
				Return Buffer.ToString()
			End Get
		End Property

		Public Overrides Sub Visit(ByVal text As DocumentText)
			Dim prefix As String = GetPrefix(text.TextProperties)
			Buffer.Append(prefix)

			Dim count As Integer = text.Length
			For i As Integer = 0 To count - 1
				Dim ch As Char = text.Text(i)
				If ch > lastLowSpecial AndAlso ch < firstHighSpecial Then
					Buffer.Append(ch)
				ElseIf ch = ChrW(&H9) OrElse ch = ChrW(&HA) OrElse ch = ChrW(&HD) Then
					Buffer.Append(ch)
				End If
			Next i

			Buffer.Append(prefix)
		End Sub
		Public Overrides Sub Visit(ByVal paragraphStart As DocumentParagraphStart)
			If paragraphStart.ParagraphProperties.ParagraphStyle.Name = "heading 1" Then
				Buffer.Append("#")
			End If
		End Sub
		Public Overrides Sub Visit(ByVal inlinePicture As DocumentInlinePicture)
			InsertImageUri(inlinePicture.Uri)
		End Sub
		Public Overrides Sub Visit(ByVal picture As DocumentPicture)
			InsertImageUri(picture.Uri)
		End Sub
		Public Overrides Sub Visit(ByVal paragraphEnd As DocumentParagraphEnd)
			AppendLineOnNonEmptyContent()
		End Sub
		Public Overrides Sub Visit(ByVal sectionEnd As DocumentSectionEnd)
			AppendLineOnNonEmptyContent()
		End Sub
		Public Overrides Sub Visit(ByVal hyperlinkStart As DocumentHyperlinkStart)
			If (Not String.IsNullOrEmpty(hyperlinkStart.NavigateUri)) Then
				Buffer.Append("[")
			End If
		End Sub
		Public Overrides Sub Visit(ByVal hyperlinkEnd As DocumentHyperlinkEnd)
			If (Not String.IsNullOrEmpty(hyperlinkEnd.NavigateUri)) Then
				Buffer.Append(String.Format("]({0})", hyperlinkEnd.NavigateUri))
			End If
		End Sub
		Private Sub InsertImageUri(ByVal uri As String)
			If (Not String.IsNullOrEmpty(uri)) Then
				Buffer.Append(String.Format("![]({0})", uri))
			Else
				Buffer.Append("[[img src=attached-image.jpg alt=foobar]]")
			End If
		End Sub
		Private Function GetPrefix(ByVal properties As ReadOnlyTextProperties) As String
			Dim prefix As String = String.Empty
			If properties.FontBold Then
				prefix = "**"
			End If
			If properties.FontItalic Then
				prefix &= "*"
			End If
			If properties.StrikeoutType = StrikeoutType.Single Then
				prefix &= "~~"
			End If
			Return prefix
		End Function
		Private Sub AppendLineOnNonEmptyContent()
			If Buffer.Length > 0 Then
				Buffer.AppendLine()
			End If
		End Sub
	End Class
End Namespace

Imports System
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports System.Collections.Generic
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Layout
Imports System.Drawing
Imports Color = System.Windows.Media.Color

Namespace RichEditDemo
    Partial Public Class CustomDraw
        Inherits RichEditDemoModule

        Private searchTimer As System.Timers.Timer
        Private searchResultsList As List(Of DocumentRange)

        Private selectedIndex_Renamed As Integer = -1
        Private searchOptions As SearchOptions
        Private Const paragraphMark As String = ControlChars.CrLf
        Private Const spaceMark As Char = " "c
        Public Sub New()
            InitializeComponent()
            Me.searchTimer = New System.Timers.Timer()
            OpenXmlLoadHelper.Load("CustomDraw.docx", richEdit)

        End Sub
        Private Property SelectedIndex() As Integer
            Get
                Return selectedIndex_Renamed
            End Get
            Set(ByVal value As Integer)
                selectedIndex_Renamed = value
                OnSelectedIndexChanged()
            End Set
        End Property
        Private ReadOnly Property IsSelectionInMainDocument() As Boolean
            Get
                Return (Not richEdit.IsSelectionInTextBox) AndAlso (Not richEdit.IsSelectionInHeaderOrFooter) AndAlso Not richEdit.IsSelectionInComment
            End Get
        End Property

        Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            AddHandler richEdit.BeforePagePaint, AddressOf richEditControl_OnBeforePagePaint
            AddHandler richEdit.ContentChanged, AddressOf richEditControl_ContentChanged
            AddHandler Me.searchTimer.Elapsed, AddressOf searchTimer_Elapsed
            searchResultsList = New List(Of DocumentRange)()
            ConfigureSearchPanelControls()
            richEdit.ReplaceService(Of IRichEditCommandFactoryService)(New CustomsRichEditCommandFactoryService(richEdit, richEdit.GetService(Of IRichEditCommandFactoryService)(), AddressOf Activate))
            For Each section As Section In richEdit.Document.Sections
                section.LineNumbering.CountBy = 1
                section.LineNumbering.Start = 0
                section.LineNumbering.RestartType = LineNumberingRestart.Continuous
            Next section
        End Sub
        Public Sub Activate()
            searchTextBox.Focus()
            Dim searchText As String = String.Empty
            Dim doc As SubDocument = richEdit.Document.Selection.BeginUpdateDocument()
            searchText = doc.GetText(richEdit.Document.Selection)
            richEdit.Document.Selection.EndUpdateDocument(doc)
            If String.IsNullOrEmpty(searchText) Then
                searchText = searchTextBox.Text
            Else
                searchText = searchText.Trim()
                searchText = searchText.Replace(paragraphMark, spaceMark.ToString())
                Dim maxLength As Integer = Math.Min(searchTextBox.MaxLength, searchText.Length)
                searchText = searchText.Substring(0, maxLength)
            End If
            searchTextBox.Text = searchText
            StartSearch()
        End Sub
        Private Sub richEditControl_OnBeforePagePaint(ByVal sender As Object, ByVal e As BeforePagePaintEventArgs)
            If e.CanvasOwnerType = CanvasOwnerType.Printer Then
                Return
            End If
            Dim customPagePainter As New CustomDrawPagePainter(richEdit, searchResultsList, selectedIndex_Renamed)
            customPagePainter.HighlightRow = edtHighlightRow.IsChecked.Value
            customPagePainter.HighlightLineNumbering = edtHighlightNumberingList.IsChecked.Value
            customPagePainter.TextHighlightColor = colorEdit.Color
            customPagePainter.RowHighlightColor = colorEditLine.Color
            customPagePainter.NumberingHighlightColor = colorEditHighlightNumbering.Color
            e.Painter = customPagePainter
        End Sub
        Private Sub richEditControl_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
            searchResultsList.Clear()
            ConfigureSearchPanelControls()
            richEdit.Refresh()
        End Sub
        Private Function CheckSelectedIndex() As Boolean
            Return SelectedIndex > -1 AndAlso SelectedIndex < searchResultsList.Count
        End Function
        Private Sub OnSelectedIndexChanged()
            If CheckSelectedIndex() Then
                Dim documentRange As DocumentRange = searchResultsList(SelectedIndex)
                richEdit.Document.ChangeActiveDocument(richEdit.Document)
                richEdit.Document.Selection = documentRange
                richEdit.ScrollToCaret()
            End If
            ConfigureSearchPanelControls()
            richEdit.Refresh()
        End Sub
        Private Sub ButtonInfo_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            searchTextBox.Text = String.Empty
            StartSearch()
        End Sub
        Private Sub ButtonDownInfo_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            SelectedIndex = GetNextIndex(False)
        End Sub
        Private Sub ButtonUpInfo_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            SelectedIndex = GetNextIndex(True)
        End Sub
        Private Function GetNextIndex(ByVal isUp As Boolean) As Integer
            Dim resultIndex As Integer = -1
            If isUp Then
                resultIndex = GetPreviousIndex(richEdit.Document.CaretPosition)
                If resultIndex < 0 Then
                    resultIndex = searchResultsList.Count - 1
                End If
            Else
                resultIndex = GetNextIndex(richEdit.Document.CaretPosition)
                If resultIndex < 0 Then
                    resultIndex = 0
                End If
            End If
            Return resultIndex
        End Function
        Private Function GetNextIndex(ByVal position As DocumentPosition) As Integer
            Dim caretPosition As Integer = richEdit.Document.CaretPosition.ToInt()
            Return searchResultsList.FindIndex(Function(x) x.Start.ToInt() >= position.ToInt())
        End Function
        Private Function GetPreviousIndex(ByVal position As DocumentPosition) As Integer
            Dim caretPosition As Integer = richEdit.Document.CaretPosition.ToInt()
            Return searchResultsList.FindLastIndex(Function(x) x.End.ToInt() < position.ToInt())
        End Function
        Private Sub searchTextBox_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            searchTimer.Stop()
            searchTimer.Start()
        End Sub
        Private Sub searchTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Input.KeyEventArgs)
            If e.Key = System.Windows.Input.Key.Enter Then
                StartSearch()
            ElseIf e.Key = System.Windows.Input.Key.Escape Then
                searchTextBox.Text = String.Empty
                StartSearch()
                richEdit.Focus()
            End If
        End Sub
        Private Sub SetSearchTextBoxButtonsVisibility()
            For Each button As ButtonInfo In searchTextBox.Buttons
                button.Visibility = If((Not String.IsNullOrEmpty(searchTextBox.Text)), System.Windows.Visibility.Visible, System.Windows.Visibility.Hidden)
            Next button
        End Sub
        Private Sub SetResultLabelText()
            Dim str As String = String.Empty
            If String.IsNullOrEmpty(searchTextBox.Text) Then
                str = String.Empty
            ElseIf searchResultsList.Count = 0 Then
                str = "No matches"
            Else
                str = searchResultsList.Count & " matches"
            End If
            If searchResultsList.Count > 0 AndAlso selectedIndex_Renamed > -1 Then
                str = (selectedIndex_Renamed + 1) & " of " & str
            End If
            labelResultCount.Text = str
        End Sub
        Private Sub ConfigureSearchPanelControls()
            SetResultLabelText()
            SetSearchTextBoxButtonsVisibility()
            ChangeNavigationButtonEditVisibility()
        End Sub
        Private Sub StartSearch()
            searchTimer.Stop()
            searchResultsList.Clear()
            FillSearchResultsList()
            SelectedIndex = -1
            ConfigureSearchPanelControls()
            If IsSelectionInMainDocument Then
                SelectedIndex = GetSearchResultIndex(searchResultsList.FindIndex(Function(x) richEdit.Document.Selection.Contains(x.Start) AndAlso richEdit.Document.Selection.Contains(richEdit.Document.CreatePosition(x.End.ToInt() - 1))))
            End If
        End Sub
        Private Function GetSearchResultIndex(ByVal findIndex As Integer) As Integer
            If findIndex >= 0 OrElse searchResultsList.Count <= 0 Then
                Return findIndex
            End If
            Dim visibleRange As DocumentRange = richEdit.ActiveView.GetVisiblePagesRange()
            findIndex = searchResultsList.FindIndex(Function(x) visibleRange.Contains(x.Start) OrElse visibleRange.Contains(x.End))
            If findIndex >= 0 Then
                Return findIndex
            End If
            If GetNextIndex(visibleRange.Start) < 0 Then
                Return GetPreviousIndex(visibleRange.Start)
            End If
            Return GetNextIndex(visibleRange.Start)
        End Function
        Private Sub searchTimer_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
            Dispatcher.BeginInvoke(New Action(Sub() StartSearch()))
        End Sub
        Private Sub ChangeNavigationButtonEditVisibility()
            navigationButtonEdit.Visibility = If((Not String.IsNullOrEmpty(searchTextBox.Text)) AndAlso searchResultsList.Count > 0, System.Windows.Visibility.Visible, System.Windows.Visibility.Hidden)
        End Sub
        Private Sub FillSearchResultsList()
            If String.IsNullOrEmpty(searchTextBox.Text) Then
                Return
            End If
            Dim result() As DocumentRange = richEdit.Document.FindAll(searchTextBox.Text, searchOptions)
            searchResultsList = New List(Of DocumentRange)(result)
        End Sub
        Private Sub matchCase_ValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            If edtMatchCase.IsChecked.Value Then
                searchOptions = searchOptions Or SearchOptions.CaseSensitive
            Else
                searchOptions = searchOptions Xor SearchOptions.CaseSensitive
            End If
            StartSearch()
        End Sub
        Private Sub findWholeWordsOnly_ValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            If edtFindWholeWordsOnly.IsChecked.Value Then
                searchOptions = searchOptions Or SearchOptions.WholeWord
            Else
                searchOptions = searchOptions Xor SearchOptions.WholeWord
            End If
            StartSearch()
        End Sub
        Private Sub colorEdit_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            richEdit.Refresh()
        End Sub
        Private Sub edtHighlightRow_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            richEdit.Refresh()
        End Sub
        Private Sub colorEditLine_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            richEdit.Refresh()
        End Sub
        Private Sub edtHighlightNumberingList_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            richEdit.Refresh()
        End Sub
        Private Sub colorEditHighlightNumbering_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            richEdit.Refresh()
        End Sub
    End Class
    #Region "CustomDrawPagePainter"
    Public Class CustomDrawPagePainter
        Inherits PagePainter

        Private searchResulstList As List(Of FixedRange)
        Private visibleSearchResultsList As List(Of FixedRange)
        Private richEditControl As RichEditControl
        Private shouldHighlight As Boolean = True
        Private selectedRange As FixedRange
        Private Const borderWidth As Integer = 2
        Private currentResultIndex As Integer
        Private previousColumnIndex As Integer = -1
        Private lineNumberFont As Font

        Public Sub New(ByVal richEdit As RichEditControl, ByVal resultList As List(Of DocumentRange), ByVal selectedResultIndex As Integer)
            MyBase.New()
            richEditControl = richEdit
            searchResulstList = resultList.ConvertAll(Function(x) New FixedRange(x.Start.ToInt(), x.Length))
            If selectedResultIndex >= 0 AndAlso selectedResultIndex < resultList.Count Then
                selectedRange = searchResulstList(selectedResultIndex)
                Dim documentRange As DocumentRange = richEditControl.Document.Paragraphs.Get(resultList(selectedResultIndex).Start).Range
            End If
        End Sub

        Public Property HighlightRow() As Boolean
        Public Property HighlightLineNumbering() As Boolean
        Public Property RowHighlightColor() As System.Windows.Media.Color
        Public Property TextHighlightColor() As System.Windows.Media.Color
        Public Property NumberingHighlightColor() As System.Windows.Media.Color

        Public Overrides Sub DrawPage(ByVal page As LayoutPage)
            visibleSearchResultsList = searchResulstList.FindAll(Function(x) page.MainContentRange.Intersect(x))
            lineNumberFont = New Font("Times New Roman", 11F, FontStyle.Regular)
            MyBase.DrawPage(page)
            lineNumberFont.Dispose()
        End Sub
        Public Overrides Sub DrawComment(ByVal comment As LayoutComment)
            shouldHighlight = False
            MyBase.DrawComment(comment)
            shouldHighlight = True
        End Sub
        Public Overrides Sub DrawTextBox(ByVal textBox As LayoutTextBox)
            shouldHighlight = False
            MyBase.DrawTextBox(textBox)
            shouldHighlight = True
        End Sub
        Public Overrides Sub DrawHeader(ByVal header As LayoutHeader)
            shouldHighlight = False
            MyBase.DrawHeader(header)
            shouldHighlight = True
        End Sub
        Public Overrides Sub DrawFooter(ByVal footer As LayoutFooter)
            shouldHighlight = False
            MyBase.DrawFooter(footer)
            shouldHighlight = True
        End Sub
        Public Overrides Sub DrawRow(ByVal row As LayoutRow)
            If shouldHighlight Then
                DrawHighlightRow(row)
            End If
            MyBase.DrawRow(row)
        End Sub
        Public Overrides Sub DrawPageArea(ByVal pageArea As LayoutPageArea)
            MyBase.DrawPageArea(pageArea)
            previousColumnIndex = -1
        End Sub
        Public Overrides Sub DrawColumn(ByVal column As LayoutColumn)
            Dim pageArea As LayoutPageArea = column.GetParentByType(Of LayoutPageArea)()
            If pageArea IsNot Nothing Then
                Dim leftBoundary As Integer = 0
                If previousColumnIndex >= 0 Then
                    leftBoundary = pageArea.Columns(previousColumnIndex).Bounds.Right
                End If
                If column.LineNumbers.Count > 0 Then
                    HighlightLineNumberingArea(column, leftBoundary)
                End If
                previousColumnIndex += 1
            End If
            MyBase.DrawColumn(column)
        End Sub
        Public Overrides Sub DrawTable(ByVal table As LayoutTable)
            currentResultIndex = 0
            MyBase.DrawTable(table)
        End Sub
        Public Overrides Sub DrawLineNumberBox(ByVal lineNumberBox As LineNumberBox)
            Dim foreColor As Color = System.Windows.Media.Colors.Black
            If HighlightRow AndAlso selectedRange IsNot Nothing AndAlso lineNumberBox.Row.Range.Intersect(selectedRange) Then
                foreColor = RowHighlightColor
            End If
            Canvas.DrawString(lineNumberBox.Text, lineNumberFont, New RichEditBrush(foreColor), lineNumberBox.Bounds, Me.richEditControl.LayoutUnit)
        End Sub
        Public Overrides Sub DrawTabSpaceBox(ByVal tabSpaceBox As PlainTextBox)
            HighlightElement(tabSpaceBox)
            MyBase.DrawTabSpaceBox(tabSpaceBox)
        End Sub
        Public Overrides Sub DrawPlainTextBox(ByVal plainTextBox As PlainTextBox)
            HighlightElement(plainTextBox)
            MyBase.DrawPlainTextBox(plainTextBox)
        End Sub
        Public Overrides Sub DrawColumnBreakBox(ByVal columnBreakBox As PlainTextBox)
            HighlightElement(columnBreakBox)
            MyBase.DrawColumnBreakBox(columnBreakBox)
        End Sub
        Public Overrides Sub DrawHyphenBox(ByVal hyphen As PlainTextBox)
            HighlightElement(hyphen)
            MyBase.DrawHyphenBox(hyphen)
        End Sub
        Public Overrides Sub DrawLineBreakBox(ByVal lineBreakBox As PlainTextBox)
            HighlightElement(lineBreakBox)
            MyBase.DrawLineBreakBox(lineBreakBox)
        End Sub
        Public Overrides Sub DrawPageBreakBox(ByVal pageBreakBox As PlainTextBox)
            HighlightElement(pageBreakBox)
            MyBase.DrawPageBreakBox(pageBreakBox)
        End Sub
        Public Overrides Sub DrawPageNumberBox(ByVal pageNumberBox As PlainTextBox)
            HighlightElement(pageNumberBox)
            MyBase.DrawPageNumberBox(pageNumberBox)
        End Sub
        Public Overrides Sub DrawParagraphMarkBox(ByVal paragraphMarkBox As PlainTextBox)
            HighlightElement(paragraphMarkBox)
            MyBase.DrawParagraphMarkBox(paragraphMarkBox)
        End Sub
        Public Overrides Sub DrawSectionBreakBox(ByVal sectionBreakBox As PlainTextBox)
            HighlightElement(sectionBreakBox)
            MyBase.DrawSectionBreakBox(sectionBreakBox)
        End Sub
        Public Overrides Sub DrawSpaceBox(ByVal spaceBox As PlainTextBox)
            HighlightElement(spaceBox)
            MyBase.DrawSpaceBox(spaceBox)
        End Sub
        Public Overrides Sub DrawSpecialTextBox(ByVal specialTextBox As PlainTextBox)
            HighlightElement(specialTextBox)
            MyBase.DrawSpecialTextBox(specialTextBox)
        End Sub
        Private Sub HighlightElement(ByVal element As PlainTextBox)
            If (Not shouldHighlight) OrElse visibleSearchResultsList Is Nothing OrElse visibleSearchResultsList.Count <= 0 Then
                Return
            End If
            currentResultIndex = GetNearestSearchReusltIndex(element)
            Do While currentResultIndex < visibleSearchResultsList.Count AndAlso element.Range.Intersect(visibleSearchResultsList(currentResultIndex))
                If element.Type <> LayoutType.PlainTextBox Then
                    HighlightElement(element.Bounds)
                    Exit Do
                End If
                Dim searchResult As FixedRange = visibleSearchResultsList(currentResultIndex)
                Dim firstCharacter As Integer = System.Math.Max(element.Range.Start, searchResult.Start)
                Dim lastCharacter As Integer = System.Math.Min(GetLastCharacterIndex(element.Range.Start + element.Range.Length), GetLastCharacterIndex(searchResult.Start + searchResult.Length))
                Dim boxes As CharacterBoxCollection = richEditControl.DocumentLayout.Split(element)
                Dim bounds As Rectangle = boxes(GetCharacterIndex(firstCharacter, element.Range)).Bounds
                If lastCharacter > firstCharacter Then
                    Dim lastCharacterBounds As Rectangle = boxes(GetCharacterIndex(lastCharacter, element.Range)).Bounds
                    bounds = Rectangle.Union(bounds, lastCharacterBounds)
                End If
                HighlightElement(bounds)
                If lastCharacter >= GetLastCharacterIndex(searchResult.Start + searchResult.Length) Then
                    currentResultIndex += 1
                Else
                    Exit Do
                End If
            Loop
        End Sub
        Private Function GetNearestSearchReusltIndex(ByVal element As PlainTextBox) As Integer
            Dim result As Integer = currentResultIndex
            Do While result < visibleSearchResultsList.Count AndAlso visibleSearchResultsList(result).Start + visibleSearchResultsList(result).Length < element.Range.Start
                result += 1
            Loop
            Return result
        End Function
        Private Sub DrawHighlightRow(ByVal row As LayoutRow)
            If HighlightRow AndAlso selectedRange IsNot Nothing AndAlso row.Range.Intersect(selectedRange) Then
                Canvas.DrawRectangle(New RichEditPen(RowHighlightColor, Canvas.ConvertToDrawingLayoutUnits(borderWidth, Me.richEditControl.LayoutUnit)), GetRowBounds(row))
            End If
        End Sub
        Private Sub HighlightLineNumberingArea(ByVal column As LayoutColumn, ByVal leftBoundary As Integer)
            If HighlightLineNumbering Then
                Dim page As LayoutPage = column.GetParentByType(Of LayoutPage)()
                Dim marginBounds As New Rectangle(New Point(leftBoundary, 0), New Size(column.Bounds.X - leftBoundary, page.Bounds.Height))
                Canvas.FillRectangle(New RichEditBrush(NumberingHighlightColor), marginBounds)
            End If
        End Sub
        Private Function GetRowBounds(ByVal row As LayoutRow) As Rectangle
            Dim column As LayoutColumn = row.GetParentByType(Of LayoutColumn)()
            If column IsNot Nothing Then
                Return New Rectangle(New Point(column.Bounds.X, row.Bounds.Y), New Size(column.Bounds.Width, row.Bounds.Height))
            End If
            Return row.Bounds
        End Function
        Private Function GetCharacterIndex(ByVal position As Integer, ByVal range As FixedRange) As Integer
            Return position - range.Start
        End Function
        Private Sub HighlightElement(ByVal bounds As Rectangle)
            Canvas.FillRectangle(New RichEditBrush(TextHighlightColor), bounds)
        End Sub
        Private Function GetLastCharacterIndex(ByVal [end] As Integer) As Integer
            Return [end] - 1
        End Function
    End Class
    #End Region
    #Region "CustomsRichEditCommandFactoryService"
    Public Class CustomsRichEditCommandFactoryService
        Implements IRichEditCommandFactoryService

        Private ReadOnly service As IRichEditCommandFactoryService
        Private ReadOnly control As RichEditControl
        Private ReadOnly showFormCallback As Action

        Public Sub New(ByVal richEditControl As RichEditControl, ByVal richEditCommandFactoryService As IRichEditCommandFactoryService, ByVal actionShowFormCallback As Action)
            DevExpress.Utils.Guard.ArgumentNotNull(richEditControl, "control")
            DevExpress.Utils.Guard.ArgumentNotNull(richEditCommandFactoryService, "service")
            DevExpress.Utils.Guard.ArgumentNotNull(actionShowFormCallback, "actionShowFormCallback")
            control = richEditControl
            service = richEditCommandFactoryService
            showFormCallback = actionShowFormCallback
        End Sub
        Private Function IRichEditCommandFactoryService_CreateCommand(ByVal id As RichEditCommandId) As RichEditCommand Implements IRichEditCommandFactoryService.CreateCommand
            If id.Equals(RichEditCommandId.Find) Then
                Return New CustomFindDocumentCommand(control, showFormCallback)
            End If
            Return service.CreateCommand(id)
        End Function
        Public Class CustomFindDocumentCommand
            Inherits FindCommand

            Private showFormCallback As Action

            Public Sub New(ByVal richEdit As IRichEditControl, ByVal actionShowFormCallback As Action)
                MyBase.New(richEdit)
                showFormCallback = actionShowFormCallback
            End Sub
            Protected Overrides Sub ShowForm(ByVal searchString As String)
                showFormCallback()
            End Sub
        End Class
    End Class
    #End Region
End Namespace

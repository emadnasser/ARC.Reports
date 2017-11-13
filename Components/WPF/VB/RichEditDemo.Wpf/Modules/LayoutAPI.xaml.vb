Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports System.Windows.Media
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.XtraRichEdit.API.Native
Imports Rectangle = System.Drawing.Rectangle

Namespace RichEditDemo
    Partial Public Class LayoutAPI
        Inherits RichEditDemoModule

        Public Shared ReadOnly CurrentTreeItemProperty As DependencyProperty = DependencyProperty.Register("CurrentTreeItem", GetType(RichEditTreeViewItem), GetType(LayoutAPI))
        Private Shared ReadOnly PageCountProperty As DependencyProperty = DependencyProperty.Register("PageCount", GetType(Integer), GetType(LayoutAPI), New PropertyMetadata(1))
        Private Shared ReadOnly ActivePageNumberProperty As DependencyProperty = DependencyProperty.Register("ActivePageNumber", GetType(Integer), GetType(LayoutAPI), New PropertyMetadata(1))

        Private layoutInfoItems_Renamed As ObservableCollection(Of LayoutInfoItem)

        Public Sub New()
            DataContext = Me
            Me.layoutInfoItems_Renamed = GetLayoutInfoItems()
            InitializeComponent()
            OpenXmlLoadHelper.Load("FloatingObjects.docx", richEdit)
            AddHandler richEdit.DocumentLayout.DocumentFormatted, AddressOf DocumentLayout_DocumentFormatted
        End Sub

        Public Property CurrentTreeItem() As RichEditTreeViewItem
            Get
                Return CType(GetValue(CurrentTreeItemProperty), RichEditTreeViewItem)
            End Get
            Set(ByVal value As RichEditTreeViewItem)
                SetValue(CurrentTreeItemProperty, value)
            End Set
        End Property
        Public Property PageCount() As Integer
            Get
                Return CInt((GetValue(PageCountProperty)))
            End Get
            Private Set(ByVal value As Integer)
                SetValue(PageCountProperty, value)
            End Set
        End Property
        Public Property ActivePageNumber() As Integer
            Get
                Return CInt((GetValue(ActivePageNumberProperty)))
            End Get
            Private Set(ByVal value As Integer)
                SetValue(ActivePageNumberProperty, value)
            End Set
        End Property
        Public ReadOnly Property LayoutInfoItems() As ObservableCollection(Of LayoutInfoItem)
            Get
                Return layoutInfoItems_Renamed
            End Get
        End Property

        Private Function GetLayoutInfoItems() As ObservableCollection(Of LayoutInfoItem)
            Dim result As New ObservableCollection(Of LayoutInfoItem)()
            Dim types() As LayoutType = CType(System.Enum.GetValues(GetType(LayoutType)), LayoutType())
            Dim rand As New Random()
            Dim colorBytes(2) As Byte
            For Each type As LayoutType In types
                If IsDrawingSupported(type) Then
                    rand.NextBytes(colorBytes)
                    result.Add(New LayoutInfoItem(type.ToString(), Color.FromRgb(colorBytes(0), colorBytes(1), colorBytes(2))))
                End If
            Next type
            Return result
        End Function
        Private Function IsDrawingSupported(ByVal type As LayoutType) As Boolean
            Select Case type
                Case LayoutType.BookmarkEndBox
                    Return False
                Case LayoutType.BookmarkStartBox
                    Return False
                Case LayoutType.CommentEndBox
                    Return False
                Case LayoutType.CommentStartBox
                    Return False
                Case LayoutType.CustomRunBox
                    Return False
                Case LayoutType.DataContainerRunBox
                    Return False
                Case LayoutType.RangePermissionEndBox
                    Return False
                Case LayoutType.RangePermissionStartBox
                    Return False
                Case LayoutType.HiddenTextUnderlineBox
                    Return False
                Case LayoutType.CharacterBox
                    Return False
                Case LayoutType.FloatingObjectAnchorBox
                    Return False
                Case Else
                    Return True
            End Select
        End Function
        Private Sub DocumentLayout_DocumentFormatted(ByVal sender As Object, ByVal e As System.EventArgs)
            richEdit.Dispatcher.BeginInvoke(New Action(Sub()
                layoutTreeView.Items.Clear()

                Dim pageCount_Renamed As Integer = richEdit.DocumentLayout.GetFormattedPageCount()
                For i As Integer = 0 To pageCount_Renamed - 1
                    AddTreeViewItem(layoutTreeView.Items, New TreeViewItemInfo(richEdit.DocumentLayout.GetPage(i), ContentDisplayAction.Select, True))
                Next i
                PageCount = richEdit.DocumentLayout.GetPageCount()
            End Sub))
        End Sub
        Private Sub AddTreeViewItem(ByVal collection As ItemCollection, ByVal info As TreeViewItemInfo)
            Dim item As New RichEditTreeViewItem(info)
            item.Header = GetTreeViewItemHeader(info.Element, collection.Count + 1)
            AddHandler item.Expanded, AddressOf OnTreeViewItemExpanded
            AddHandler item.Selected, AddressOf OnTreeViewItemSelected
            collection.Add(item)
        End Sub
        Private Function GetTreeViewItemHeader(ByVal element As LayoutElement, ByVal index As Integer) As String
            Dim typeName As String = element.Type.ToString()
            Select Case element.Type
                Case LayoutType.Column
                    Return String.Format("{0} #{1}", typeName, index)
                Case LayoutType.Page
                    Return String.Format("{0} #{1}", typeName, index)
                Case LayoutType.Row
                    Return String.Format("{0} #{1}", typeName, index)
                Case LayoutType.TableRow
                    Return String.Format("{0} #{1}", typeName, index)
            End Select
            Return typeName
        End Function
        Private Sub OnTreeViewItemSelected(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim item As RichEditTreeViewItem = DirectCast(sender, RichEditTreeViewItem)
            If Not item.IsSelected Then
                Return
            End If
            CurrentTreeItem = item
            richEdit.Document.ChangeActiveDocument(richEdit.Document)

            Dim element As LayoutElement = CurrentTreeItem.Info.Element
            If CurrentTreeItem.Info.DisplayAction = ContentDisplayAction.ScrollTo Then
                TryScrollToHeader(element)
                TryScrollToFooter(element)
                TryScrollToFloatingObject(element)
                TryScrollToComment(element)
                TryScrollToFrame(element)
            Else
                Dim rangedElement As RangedLayoutElement = TryCast(element, RangedLayoutElement)
                If rangedElement Is Nothing Then
                    Return
                End If
                ScrollToPosition(rangedElement.Range.Start)
                richEdit.Document.Selection = richEdit.Document.CreateRange(rangedElement.Range.Start, rangedElement.Range.Length)
            End If
        End Sub
        Private Sub TryScrollToFrame(ByVal element As LayoutElement)
            Dim frame As LayoutFrame = TryCast(element, LayoutFrame)
            If frame Is Nothing Then
                frame = element.GetParentByType(Of LayoutFrame)()
            End If
            If frame Is Nothing Then
                Return
            End If
            ScrollToPosition(frame.Range.Start)
        End Sub
        Private Sub TryScrollToHeader(ByVal element As LayoutElement)
            Dim header As LayoutHeader = TryCast(element, LayoutHeader)
            If header Is Nothing Then
                header = element.GetParentByType(Of LayoutHeader)()
            End If
            If header Is Nothing Then
                Return
            End If
            Dim nearestPageArea As LayoutPageArea = CType(header.Parent, LayoutPage).PageAreas.First
            ScrollToPosition(nearestPageArea.Range.Start)
        End Sub
        Private Sub TryScrollToFooter(ByVal element As LayoutElement)
            Dim footer As LayoutFooter = TryCast(element, LayoutFooter)
            If footer Is Nothing Then
                footer = element.GetParentByType(Of LayoutFooter)()
            End If
            If footer Is Nothing Then
                Return
            End If
            Dim nearestPageArea As LayoutPageArea = CType(footer.Parent, LayoutPage).PageAreas.Last
            ScrollToPosition(nearestPageArea.Range.Start + nearestPageArea.Range.Length - 1)
        End Sub
        Private Sub TryScrollToComment(ByVal element As LayoutElement)
            Dim layoutComment As LayoutComment = TryCast(element, LayoutComment)
            If layoutComment Is Nothing Then
                layoutComment = element.GetParentByType(Of LayoutComment)()
            End If
            If layoutComment IsNot Nothing Then
                Dim comment As Comment = layoutComment.GetDocumentComment()
                ScrollToPosition(comment.Range.Start)
            End If
        End Sub
        Private Sub TryScrollToFloatingObject(ByVal element As LayoutElement)
            Dim layoutFloatingObject As LayoutFloatingObject = TryCast(element, LayoutFloatingObject)
            If layoutFloatingObject Is Nothing Then
                layoutFloatingObject = element.GetParentByType(Of LayoutTextBox)()
            End If
            If layoutFloatingObject IsNot Nothing Then
                Dim anchor As FloatingObjectAnchorBox = layoutFloatingObject.AnchorBox
                ScrollToPosition(anchor.Range.Start)
                richEdit.Document.Selection = richEdit.Document.CreateRange(anchor.Range.Start, anchor.Range.Length)
            End If
        End Sub
        Private Sub ScrollToPosition(ByVal position As Integer)
            richEdit.Document.CaretPosition = richEdit.Document.CreatePosition(position)
            richEdit.ScrollToCaret(0.5F)
        End Sub
        Private Sub ScrollToPosition(ByVal position As DocumentPosition)
            richEdit.Document.CaretPosition = position
            richEdit.ScrollToCaret(0.5F)
        End Sub
        Private Sub OnTreeViewItemExpanded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim item As RichEditTreeViewItem = DirectCast(sender, RichEditTreeViewItem)
            If item.HasItems Then
                Return
            End If
            Dim collector As New ChildElementsCollector(item.Info)
            Dim itemsCount As Integer = collector.Collection.Count
            For i As Integer = 0 To itemsCount - 1
                AddTreeViewItem(item.Items, collector.Collection(i))
            Next i
        End Sub
        Private Sub richEdit_BeforePagePaint(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.BeforePagePaintEventArgs)
            e.Painter = New CustomPagePainter(LayoutInfoItems)
        End Sub
        Private Sub IsCheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Refresh()
        End Sub
        Private Sub PopupColorEdit_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            richEdit.Refresh()
        End Sub
        Private Sub richEdit_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim element As RangedLayoutElement = richEdit.DocumentLayout.GetElement(Of RangedLayoutElement)(richEdit.Document.CaretPosition)
            If element IsNot Nothing Then
                ActivePageNumber = richEdit.DocumentLayout.GetPageIndex(element) + 1
            End If
        End Sub
        Private Sub richEdit_VisiblePagesChanged(ByVal sender As Object, ByVal e As EventArgs)
            ActivePageNumber = richEdit.ActiveView.GetVisiblePageLayoutInfos()(0).PageIndex + 1
        End Sub
    End Class
    #Region "CustomPagePainter"
    Public Class CustomPagePainter
        Inherits PagePainter


        Private layoutInfoItems_Renamed As ObservableCollection(Of LayoutInfoItem)

        Public Sub New(ByVal layoutInfoItems As ObservableCollection(Of LayoutInfoItem))
            Me.layoutInfoItems_Renamed = layoutInfoItems
        End Sub

        Private ReadOnly Property LayoutInfoItems() As ObservableCollection(Of LayoutInfoItem)
            Get
                Return layoutInfoItems_Renamed
            End Get
        End Property

        Public Overrides Sub DrawCommentsArea(ByVal commentsArea As LayoutCommentsArea)
            MyBase.DrawCommentsArea(commentsArea)
            HighlightElement(commentsArea)
        End Sub
        Public Overrides Sub DrawRow(ByVal row As LayoutRow)
            MyBase.DrawRow(row)
            HighlightElement(row)
        End Sub
        Public Overrides Sub DrawPlainTextBox(ByVal plainTextBox As PlainTextBox)
            MyBase.DrawPlainTextBox(plainTextBox)
            HighlightElement(plainTextBox)
        End Sub
        Public Overrides Sub DrawPage(ByVal page As LayoutPage)
            MyBase.DrawPage(page)
            HighlightElement(page)
        End Sub
        Public Overrides Sub DrawColumn(ByVal column As LayoutColumn)
            MyBase.DrawColumn(column)
            HighlightElement(column)
        End Sub
        Public Overrides Sub DrawFrame(ByVal frame As LayoutFrame)
            MyBase.DrawFrame(frame)
            HighlightElement(frame)
        End Sub
        Public Overrides Sub DrawParagraphFrame(ByVal paragraphFrame As ParagraphFrameBox)
            MyBase.DrawParagraphFrame(paragraphFrame)
            HighlightElement(paragraphFrame)
        End Sub
        Public Overrides Sub DrawColumnBreakBox(ByVal columnBreakBox As PlainTextBox)
            MyBase.DrawColumnBreakBox(columnBreakBox)
            HighlightElement(columnBreakBox)
        End Sub
        Public Overrides Sub DrawComment(ByVal comment As LayoutComment)
            MyBase.DrawComment(comment)
            HighlightElement(comment)
        End Sub
        Public Overrides Sub DrawCommentHighlightAreaBox(ByVal commentHighlightAreaBox As CommentHighlightAreaBox)
            MyBase.DrawCommentHighlightAreaBox(commentHighlightAreaBox)
            HighlightElement(commentHighlightAreaBox)
        End Sub
        Public Overrides Sub DrawFieldHighlightAreaBox(ByVal fieldHighlightAreaBox As FieldHighlightAreaBox)
            MyBase.DrawFieldHighlightAreaBox(fieldHighlightAreaBox)
            HighlightElement(fieldHighlightAreaBox)
        End Sub
        Public Overrides Sub DrawFloatingPicture(ByVal floatingPicture As LayoutFloatingPicture)
            MyBase.DrawFloatingPicture(floatingPicture)
            HighlightElement(floatingPicture)
        End Sub
        Public Overrides Sub DrawFooter(ByVal footer As LayoutFooter)
            MyBase.DrawFooter(footer)
            HighlightElement(footer)
        End Sub
        Public Overrides Sub DrawHeader(ByVal header As LayoutHeader)
            MyBase.DrawHeader(header)
            HighlightElement(header)
        End Sub
        Public Overrides Sub DrawHighlightAreaBox(ByVal highlightAreaBox As HighlightAreaBox)
            MyBase.DrawHighlightAreaBox(highlightAreaBox)
            HighlightElement(highlightAreaBox)
        End Sub
        Public Overrides Sub DrawHyphenBox(ByVal hyphen As PlainTextBox)
            MyBase.DrawHyphenBox(hyphen)
            HighlightElement(hyphen)
        End Sub
        Public Overrides Sub DrawInlinePictureBox(ByVal inlinePictureBox As InlinePictureBox)
            MyBase.DrawInlinePictureBox(inlinePictureBox)
            HighlightElement(inlinePictureBox)
        End Sub
        Public Overrides Sub DrawLineBreakBox(ByVal lineBreakBox As PlainTextBox)
            MyBase.DrawLineBreakBox(lineBreakBox)
            HighlightElement(lineBreakBox)
        End Sub
        Public Overrides Sub DrawLineNumberBox(ByVal lineNumberBox As LineNumberBox)
            MyBase.DrawLineNumberBox(lineNumberBox)
            HighlightElement(lineNumberBox)
        End Sub
        Public Overrides Sub DrawNumberingListMarkBox(ByVal numberingListMarkBox As NumberingListMarkBox)
            MyBase.DrawNumberingListMarkBox(numberingListMarkBox)
            HighlightElement(numberingListMarkBox)
        End Sub
        Public Overrides Sub DrawNumberingListWithSeparatorBox(ByVal numberingListWithSeparatorBox As NumberingListWithSeparatorBox)
            MyBase.DrawNumberingListWithSeparatorBox(numberingListWithSeparatorBox)
            HighlightElement(numberingListWithSeparatorBox)
        End Sub
        Public Overrides Sub DrawPageArea(ByVal pageArea As LayoutPageArea)
            MyBase.DrawPageArea(pageArea)
            HighlightElement(pageArea)
        End Sub
        Public Overrides Sub DrawPageBreakBox(ByVal pageBreakBox As PlainTextBox)
            MyBase.DrawPageBreakBox(pageBreakBox)
            HighlightElement(pageBreakBox)
        End Sub
        Public Overrides Sub DrawPageNumberBox(ByVal pageNumberBox As PlainTextBox)
            MyBase.DrawPageNumberBox(pageNumberBox)
            HighlightElement(pageNumberBox)
        End Sub
        Public Overrides Sub DrawParagraphMarkBox(ByVal paragraphMarkBox As PlainTextBox)
            MyBase.DrawParagraphMarkBox(paragraphMarkBox)
            HighlightElement(paragraphMarkBox)
        End Sub
        Public Overrides Sub DrawRangePermissionHighlightAreaBox(ByVal rangePermissionHighlightAreaBox As RangePermissionHighlightAreaBox)
            MyBase.DrawRangePermissionHighlightAreaBox(rangePermissionHighlightAreaBox)
            HighlightElement(rangePermissionHighlightAreaBox)
        End Sub
        Public Overrides Sub DrawSectionBreakBox(ByVal sectionBreakBox As PlainTextBox)
            MyBase.DrawSectionBreakBox(sectionBreakBox)
            HighlightElement(sectionBreakBox)
        End Sub
        Public Overrides Sub DrawSpaceBox(ByVal spaceBox As PlainTextBox)
            MyBase.DrawSpaceBox(spaceBox)
            HighlightElement(spaceBox)
        End Sub
        Public Overrides Sub DrawSpecialTextBox(ByVal specialTextBox As PlainTextBox)
            MyBase.DrawSpecialTextBox(specialTextBox)
            HighlightElement(specialTextBox)
        End Sub
        Public Overrides Sub DrawStrikeoutBox(ByVal strikeoutBox As StrikeoutBox)
            MyBase.DrawStrikeoutBox(strikeoutBox)
            HighlightElement(strikeoutBox)
        End Sub
        Public Overrides Sub DrawTable(ByVal table As LayoutTable)
            MyBase.DrawTable(table)
            HighlightElement(table)
        End Sub
        Public Overrides Sub DrawTableCell(ByVal tableCell As LayoutTableCell)
            MyBase.DrawTableCell(tableCell)
            HighlightElement(tableCell)
        End Sub
        Public Overrides Sub DrawTableRow(ByVal tableRow As LayoutTableRow)
            MyBase.DrawTableRow(tableRow)
            HighlightElement(tableRow)
        End Sub
        Public Overrides Sub DrawTabSpaceBox(ByVal tabSpaceBox As PlainTextBox)
            MyBase.DrawTabSpaceBox(tabSpaceBox)
            HighlightElement(tabSpaceBox)
        End Sub
        Public Overrides Sub DrawTextBox(ByVal textBox As LayoutTextBox)
            MyBase.DrawTextBox(textBox)
            HighlightElement(textBox)
        End Sub
        Public Overrides Sub DrawUnderlineBox(ByVal underlineBox As UnderlineBox)
            MyBase.DrawUnderlineBox(underlineBox)
            HighlightElement(underlineBox)
        End Sub
        Private Sub HighlightElement(ByVal element As LayoutElement)
            HighlightElement(element, element.Bounds)
        End Sub
        Private Sub HighlightElement(ByVal element As LayoutElement, ByVal bounds As Rectangle)
            Dim item As LayoutInfoItem = GetItem(element.Type)
            If item IsNot Nothing AndAlso item.IsChecked Then
                Canvas.DrawRectangle(New RichEditPen(item.Color), bounds)
            End If
        End Sub
        Private Function GetItem(ByVal type As LayoutType) As LayoutInfoItem
            Dim count As Integer = LayoutInfoItems.Count
            For i As Integer = 0 To count - 1
                If LayoutInfoItems(i).Name.Equals(type.ToString()) Then
                    Return LayoutInfoItems(i)
                End If
            Next i
            Return Nothing
        End Function
    End Class
    #End Region
    Public Enum ContentDisplayAction
        [Select]
        ScrollTo
    End Enum
    Public Structure TreeViewItemInfo

        Private element_Renamed As LayoutElement

        Private displayAction_Renamed As ContentDisplayAction

        Private hasChildNodes_Renamed As Boolean

        Public Sub New(ByVal element As LayoutElement, ByVal displayAction As ContentDisplayAction, ByVal hasChildNodes As Boolean)
            Me.element_Renamed = element
            Me.displayAction_Renamed = displayAction
            Me.hasChildNodes_Renamed = hasChildNodes
        End Sub

        Public ReadOnly Property Element() As LayoutElement
            Get
                Return element_Renamed
            End Get
        End Property
        Public ReadOnly Property DisplayAction() As ContentDisplayAction
            Get
                Return displayAction_Renamed
            End Get
        End Property
        Public ReadOnly Property HasChildNodes() As Boolean
            Get
                Return hasChildNodes_Renamed
            End Get
        End Property
    End Structure
    #Region "ChildElementsCollector"
    Friend Class ChildElementsCollector
        Inherits LayoutVisitor


        Private collection_Renamed As List(Of TreeViewItemInfo)

        Private parentElement_Renamed As TreeViewItemInfo

        Public Sub New(ByVal parentElement As TreeViewItemInfo)
            Me.collection_Renamed = New List(Of TreeViewItemInfo)()
            Me.parentElement_Renamed = parentElement
            Visit(Me.ParentElement.Element)
        End Sub

        Public ReadOnly Property Collection() As List(Of TreeViewItemInfo)
            Get
                Return collection_Renamed
            End Get
        End Property
        Public ReadOnly Property ParentElement() As TreeViewItemInfo
            Get
                Return parentElement_Renamed
            End Get
        End Property

        Protected Overrides Sub VisitPage(ByVal page As LayoutPage)
            TryAddElementToCollection(page, ContentDisplayAction.Select, True)
            MyBase.VisitPage(page)
        End Sub
        Protected Overrides Sub VisitHeader(ByVal header As LayoutHeader)
            TryAddElementToCollection(header, ContentDisplayAction.ScrollTo, True)
            MyBase.VisitHeader(header)
        End Sub
        Protected Overrides Sub VisitFooter(ByVal footer As LayoutFooter)
            TryAddElementToCollection(footer, ContentDisplayAction.ScrollTo, True)
            MyBase.VisitFooter(footer)
        End Sub
        Protected Overrides Sub VisitFrame(ByVal frame As LayoutFrame)
            TryAddElementToCollection(frame, ContentDisplayAction.ScrollTo, True)
            MyBase.VisitFrame(frame)
        End Sub
        Protected Overrides Sub VisitParagraphFrameBox(ByVal paragraphFrameBox As ParagraphFrameBox)
            TryAddElementToCollection(paragraphFrameBox, ContentDisplayAction.ScrollTo, False)
            MyBase.VisitParagraphFrameBox(paragraphFrameBox)
        End Sub
        Protected Overrides Sub VisitCommentsArea(ByVal commentsArea As LayoutCommentsArea)
            TryAddElementToCollection(commentsArea, ContentDisplayAction.ScrollTo, True)
            MyBase.VisitCommentsArea(commentsArea)
        End Sub
        Protected Overrides Sub VisitPageArea(ByVal pageArea As LayoutPageArea)
            TryAddElementToCollection(pageArea, ContentDisplayAction.Select, True)
            MyBase.VisitPageArea(pageArea)
        End Sub
        Protected Overrides Sub VisitBookmarkEndBox(ByVal bookmarkEndBox As BookmarkBox)
            TryAddElementToCollection(bookmarkEndBox, ContentDisplayAction.Select, False)
            MyBase.VisitBookmarkEndBox(bookmarkEndBox)
        End Sub
        Protected Overrides Sub VisitBookmarkStartBox(ByVal bookmarkStartBox As BookmarkBox)
            TryAddElementToCollection(bookmarkStartBox, ContentDisplayAction.Select, False)
            MyBase.VisitBookmarkStartBox(bookmarkStartBox)
        End Sub
        Protected Overrides Sub VisitColumn(ByVal column As LayoutColumn)
            TryAddElementToCollection(column, ContentDisplayAction.Select, True)
            MyBase.VisitColumn(column)
        End Sub
        Protected Overrides Sub VisitColumnBreakBox(ByVal columnBreakBox As PlainTextBox)
            TryAddElementToCollection(columnBreakBox, ContentDisplayAction.Select, False)
            MyBase.VisitColumnBreakBox(columnBreakBox)
        End Sub
        Protected Overrides Sub VisitComment(ByVal comment As LayoutComment)
            TryAddElementToCollection(comment, ContentDisplayAction.ScrollTo, True)
            MyBase.VisitComment(comment)
        End Sub
        Protected Overrides Sub VisitCommentEndBox(ByVal commentEndBox As CommentBox)
            TryAddElementToCollection(commentEndBox, ContentDisplayAction.Select, False)
            MyBase.VisitCommentEndBox(commentEndBox)
        End Sub
        Protected Overrides Sub VisitCommentHighlightAreaBox(ByVal commentHighlightAreaBox As CommentHighlightAreaBox)
            TryAddElementToCollection(commentHighlightAreaBox, ContentDisplayAction.Select, False)
            MyBase.VisitCommentHighlightAreaBox(commentHighlightAreaBox)
        End Sub
        Protected Overrides Sub VisitCommentStartBox(ByVal commentStartBox As CommentBox)
            TryAddElementToCollection(commentStartBox, ContentDisplayAction.Select, False)
            MyBase.VisitCommentStartBox(commentStartBox)
        End Sub
        Protected Overrides Sub VisitFieldHighlightAreaBox(ByVal fieldHighlightAreaBox As FieldHighlightAreaBox)
            TryAddElementToCollection(fieldHighlightAreaBox, ContentDisplayAction.Select, False)
            MyBase.VisitFieldHighlightAreaBox(fieldHighlightAreaBox)
        End Sub
        Protected Overrides Sub VisitFloatingObjectAnchorBox(ByVal floatingObjectAnchorBox As FloatingObjectAnchorBox)
            TryAddElementToCollection(floatingObjectAnchorBox, ContentDisplayAction.Select, False)
            MyBase.VisitFloatingObjectAnchorBox(floatingObjectAnchorBox)
        End Sub
        Protected Overrides Sub VisitFloatingPicture(ByVal floatingPicture As LayoutFloatingPicture)
            TryAddElementToCollection(floatingPicture, ContentDisplayAction.ScrollTo, False)
            MyBase.VisitFloatingPicture(floatingPicture)
        End Sub
        Protected Overrides Sub VisitHiddenTextUnderlineBox(ByVal hiddenTextUnderlineBox As HiddenTextUnderlineBox)
            TryAddElementToCollection(hiddenTextUnderlineBox, ContentDisplayAction.Select, False)
            MyBase.VisitHiddenTextUnderlineBox(hiddenTextUnderlineBox)
        End Sub
        Protected Overrides Sub VisitHighlightAreaBox(ByVal highlightAreaBox As HighlightAreaBox)
            TryAddElementToCollection(highlightAreaBox, ContentDisplayAction.Select, False)
            MyBase.VisitHighlightAreaBox(highlightAreaBox)
        End Sub
        Protected Overrides Sub VisitHyphenBox(ByVal hyphen As PlainTextBox)
            TryAddElementToCollection(hyphen, ContentDisplayAction.Select, False)
            MyBase.VisitHyphenBox(hyphen)
        End Sub
        Protected Overrides Sub VisitInlinePictureBox(ByVal inlinePictureBox As InlinePictureBox)
            TryAddElementToCollection(inlinePictureBox, ContentDisplayAction.Select, False)
            MyBase.VisitInlinePictureBox(inlinePictureBox)
        End Sub
        Protected Overrides Sub VisitLineBreakBox(ByVal lineBreakBox As PlainTextBox)
            TryAddElementToCollection(lineBreakBox, ContentDisplayAction.Select, False)
            MyBase.VisitLineBreakBox(lineBreakBox)
        End Sub
        Protected Overrides Sub VisitLineNumberBox(ByVal lineNumberBox As LineNumberBox)
            TryAddElementToCollection(lineNumberBox, ContentDisplayAction.Select, False)
            MyBase.VisitLineNumberBox(lineNumberBox)
        End Sub
        Protected Overrides Sub VisitNumberingListMarkBox(ByVal numberingListMarkBox As NumberingListMarkBox)
            TryAddElementToCollection(numberingListMarkBox, ContentDisplayAction.Select, False)
            MyBase.VisitNumberingListMarkBox(numberingListMarkBox)
        End Sub
        Protected Overrides Sub VisitNumberingListWithSeparatorBox(ByVal numberingListWithSeparatorBox As NumberingListWithSeparatorBox)
            TryAddElementToCollection(numberingListWithSeparatorBox, ContentDisplayAction.Select, True)
            MyBase.VisitNumberingListWithSeparatorBox(numberingListWithSeparatorBox)
        End Sub
        Protected Overrides Sub VisitPageBreakBox(ByVal pageBreakBox As PlainTextBox)
            TryAddElementToCollection(pageBreakBox, ContentDisplayAction.Select, False)
            MyBase.VisitPageBreakBox(pageBreakBox)
        End Sub
        Protected Overrides Sub VisitPageNumberBox(ByVal pageNumberBox As PlainTextBox)
            TryAddElementToCollection(pageNumberBox, ContentDisplayAction.Select, False)
            MyBase.VisitPageNumberBox(pageNumberBox)
        End Sub
        Protected Overrides Sub VisitParagraphMarkBox(ByVal paragraphMarkBox As PlainTextBox)
            TryAddElementToCollection(paragraphMarkBox, ContentDisplayAction.Select, False)
            MyBase.VisitParagraphMarkBox(paragraphMarkBox)
        End Sub
        Protected Overrides Sub VisitPlainTextBox(ByVal plainTextBox As PlainTextBox)
            TryAddElementToCollection(plainTextBox, ContentDisplayAction.Select, False)
            MyBase.VisitPlainTextBox(plainTextBox)
        End Sub
        Protected Overrides Sub VisitRangePermissionEndBox(ByVal rangePermissionEndBox As RangePermissionBox)
            TryAddElementToCollection(rangePermissionEndBox, ContentDisplayAction.Select, False)
            MyBase.VisitRangePermissionEndBox(rangePermissionEndBox)
        End Sub
        Protected Overrides Sub VisitRangePermissionHighlightAreaBox(ByVal rangePermissionHighlightAreaBox As RangePermissionHighlightAreaBox)
            TryAddElementToCollection(rangePermissionHighlightAreaBox, ContentDisplayAction.Select, False)
            MyBase.VisitRangePermissionHighlightAreaBox(rangePermissionHighlightAreaBox)
        End Sub
        Protected Overrides Sub VisitRangePermissionStartBox(ByVal rangePermissionStartBox As RangePermissionBox)
            TryAddElementToCollection(rangePermissionStartBox, ContentDisplayAction.Select, False)
            MyBase.VisitRangePermissionStartBox(rangePermissionStartBox)
        End Sub
        Protected Overrides Sub VisitRow(ByVal row As LayoutRow)
            TryAddElementToCollection(row, ContentDisplayAction.Select, True)
            MyBase.VisitRow(row)
        End Sub
        Protected Overrides Sub VisitSectionBreakBox(ByVal sectionBreakBox As PlainTextBox)
            TryAddElementToCollection(sectionBreakBox, ContentDisplayAction.Select, False)
            MyBase.VisitSectionBreakBox(sectionBreakBox)
        End Sub
        Protected Overrides Sub VisitSpaceBox(ByVal spaceBox As PlainTextBox)
            TryAddElementToCollection(spaceBox, ContentDisplayAction.Select, False)
            MyBase.VisitSpaceBox(spaceBox)
        End Sub
        Protected Overrides Sub VisitSpecialTextBox(ByVal specialTextBox As PlainTextBox)
            TryAddElementToCollection(specialTextBox, ContentDisplayAction.Select, False)
            MyBase.VisitSpecialTextBox(specialTextBox)
        End Sub
        Protected Overrides Sub VisitStrikeoutBox(ByVal strikeoutBox As StrikeoutBox)
            TryAddElementToCollection(strikeoutBox, ContentDisplayAction.Select, False)
            MyBase.VisitStrikeoutBox(strikeoutBox)
        End Sub
        Protected Overrides Sub VisitTable(ByVal table As LayoutTable)
            TryAddElementToCollection(table, ContentDisplayAction.Select, True)
            MyBase.VisitTable(table)
        End Sub
        Protected Overrides Sub VisitTableCell(ByVal tableCell As LayoutTableCell)
            TryAddElementToCollection(tableCell, ContentDisplayAction.Select, True)
            MyBase.VisitTableCell(tableCell)
        End Sub
        Protected Overrides Sub VisitTableRow(ByVal tableRow As LayoutTableRow)
            TryAddElementToCollection(tableRow, ContentDisplayAction.Select, True)
            MyBase.VisitTableRow(tableRow)
        End Sub
        Protected Overrides Sub VisitTabSpaceBox(ByVal tabSpaceBox As PlainTextBox)
            TryAddElementToCollection(tabSpaceBox, ContentDisplayAction.Select, False)
            MyBase.VisitTabSpaceBox(tabSpaceBox)
        End Sub
        Protected Overrides Sub VisitTextBox(ByVal textBox As LayoutTextBox)
            TryAddElementToCollection(textBox, ContentDisplayAction.ScrollTo, True)
            MyBase.VisitTextBox(textBox)
        End Sub
        Protected Overrides Sub VisitUnderlineBox(ByVal underlineBox As UnderlineBox)
            TryAddElementToCollection(underlineBox, ContentDisplayAction.Select, False)
            MyBase.VisitUnderlineBox(underlineBox)
        End Sub
        Private Sub TryAddElementToCollection(ByVal element As LayoutElement, ByVal showingType As ContentDisplayAction, ByVal hasChildNodes As Boolean)
            If Object.ReferenceEquals(element.Parent, ParentElement.Element) Then
                Dim type As ContentDisplayAction = If(ParentElement.DisplayAction = ContentDisplayAction.ScrollTo, ParentElement.DisplayAction, showingType)
                Collection.Add(New TreeViewItemInfo(element, type, hasChildNodes))
            End If
        End Sub
    End Class
    #End Region
    Public Class RichEditTreeViewItem
        Inherits TreeViewItem


        Private info_Renamed As TreeViewItemInfo
        Private firstTimeExpanding As Boolean = True

        Public Sub New(ByVal info As TreeViewItemInfo)
            Me.info_Renamed = info
            If info.HasChildNodes Then
                Items.Add(New TreeViewItem() With {.Header = "Loading..."})
            End If
        End Sub

        Protected Overrides Sub OnExpanded(ByVal e As RoutedEventArgs)
            If firstTimeExpanding AndAlso Info.HasChildNodes Then
                Items.RemoveAt(0)
            End If
            firstTimeExpanding = False
            MyBase.OnExpanded(e)
        End Sub

        Public ReadOnly Property Info() As TreeViewItemInfo
            Get
                Return info_Renamed
            End Get
        End Property
    End Class
    Public Class LayoutInfoItem
        Inherits DependencyObject


        Private name_Renamed As String
        Private Shared ReadOnly IsCheckedProperty As DependencyProperty = DependencyProperty.Register("IsChecked", GetType(Boolean), GetType(LayoutInfoItem), New PropertyMetadata(False))
        Private Shared ReadOnly ColorProperty As DependencyProperty = DependencyProperty.Register("Color", GetType(Color), GetType(LayoutInfoItem))

        Public Sub New(ByVal name As String, ByVal color As Color)
            Me.name_Renamed = name
            Me.Color = color
        End Sub

        Public Property Name() As String
            Get
                Return name_Renamed
            End Get
            Set(ByVal value As String)
                name_Renamed = value
            End Set
        End Property
        Public Property Color() As Color
            Get
                Return DirectCast(GetValue(ColorProperty), Color)
            End Get
            Set(ByVal value As Color)
                SetValue(ColorProperty, value)
            End Set
        End Property
        Public Property IsChecked() As Boolean
            Get
                Return DirectCast(GetValue(IsCheckedProperty), Boolean)
            End Get
            Set(ByVal value As Boolean)
                SetValue(IsCheckedProperty, value)
            End Set
        End Property
    End Class
    Public Class PageInfoConverter
        Implements System.Windows.Data.IMultiValueConverter

        Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IMultiValueConverter.Convert
            Return String.Format("Page: {0} of {1}", values(0), values(1))
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements System.Windows.Data.IMultiValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.XtraRichEdit.API.Native

Namespace DevExpress.XtraRichEdit.Demos
    Partial Public Class LayoutAPI
        Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
        Private layoutInfos_Renamed As New List(Of LayoutInfoItem)()
        Private gridViewActiveEditor As DevExpress.XtraEditors.BaseEdit
        Private pageCount_Renamed As Integer = 1
        Private activePageNumber_Renamed As Integer = 1

        Public Sub New()
            InitializeComponent()
            Dim handle As IntPtr = Me.Handle 'force to initialize handle
            AddHandler richEditControl.DocumentLayout.DocumentFormatted, AddressOf OnDocumentFormatted
            OpenXmlLoadHelper.Load("FloatingObjects.docx", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
            InitializeLayoutInfos()
            Me.gridControl1.DataSource = LayoutInfos
            AddHandler gridView1.ShownEditor, AddressOf gridView_ShownEditor
            AddHandler gridView1.HiddenEditor, AddressOf gridView_HiddenEditor
        End Sub

        Public ReadOnly Property LayoutInfos() As List(Of LayoutInfoItem)
            Get
                Return layoutInfos_Renamed
            End Get
        End Property
        Private Property PageCount() As Integer
            Get
                Return pageCount_Renamed
            End Get
            Set(ByVal value As Integer)
                If pageCount_Renamed = value Then
                    Return
                End If
                pageCount_Renamed = value
                OnPagesInfoChanged()
            End Set
        End Property
        Private Property ActivePageNumber() As Integer
            Get
                Return activePageNumber_Renamed
            End Get
            Set(ByVal value As Integer)
                If activePageNumber_Renamed = value Then
                    Return
                End If
                activePageNumber_Renamed = value
                OnPagesInfoChanged()
            End Set
        End Property

        Private Sub OnPagesInfoChanged()
            barStatusInfo.Caption = String.Format("Page: {0} of {1}", ActivePageNumber, PageCount)
        End Sub
        Private Sub gridView_ShownEditor(ByVal sender As Object, ByVal e As EventArgs)
            gridViewActiveEditor = gridView1.ActiveEditor
            AddHandler gridViewActiveEditor.EditValueChanged, AddressOf ActiveEditor_EditValueChanged
        End Sub
        Private Sub gridView_HiddenEditor(ByVal sender As Object, ByVal e As EventArgs)
            RemoveHandler gridViewActiveEditor.EditValueChanged, AddressOf ActiveEditor_EditValueChanged
        End Sub
        Private Sub ActiveEditor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.PostEditor()
            richEditControl.Refresh()
        End Sub
        Private Sub OnCustomRowCellEdit(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gridView1.CustomRowCellEdit
            If e.Column.AbsoluteIndex = 0 Then
                e.RepositoryItem = New RepositoryItemCheckEdit() With {.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near, .Caption = LayoutInfos(e.RowHandle).Name}
            End If
        End Sub
        Private Sub InitializeLayoutInfos()
            Dim types() As LayoutType = CType(System.Enum.GetValues(GetType(LayoutType)), LayoutType())
            Dim rand As New Random()
            Dim colorBytes(2) As Byte
            For Each type As LayoutType In types
                If IsDrawingSupported(type) Then
                    rand.NextBytes(colorBytes)
                    LayoutInfos.Add(New LayoutInfoItem(type.ToString(), Color.FromArgb(colorBytes(0), colorBytes(1), colorBytes(2))))
                End If
            Next type
        End Sub
        Private Sub OnAfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles treeView1.AfterSelect
            Dim node As RichEditTreeNode = CType(e.Node, RichEditTreeNode)
            Dim bounds As Rectangle = node.Info.Element.Bounds
            labelControl1.Text = String.Format("{0}, {1}, {2}, {3}", bounds.X, bounds.Y, bounds.Width, bounds.Height)
            Dim rangedElement As RangedLayoutElement = TryCast(node.Info.Element, RangedLayoutElement)
            labelControl4.Text = If(rangedElement IsNot Nothing, rangedElement.Range.ToString(), String.Empty)

            richEditControl.Document.ChangeActiveDocument(richEditControl.Document)
            If node.Info.DisplayAction = ContentDisplayAction.ScrollTo Then
                TryScrollToHeader(node.Info.Element)
                TryScrollToFooter(node.Info.Element)
                TryScrollToFloatingObject(node.Info.Element)
                TryScrollToComment(node.Info.Element)
            Else
                If rangedElement Is Nothing Then
                    Return
                End If
                ScrollToPosition(rangedElement.Range.Start)
                richEditControl.Document.Selection = richEditControl.Document.CreateRange(rangedElement.Range.Start, rangedElement.Range.Length)
            End If
        End Sub
        Private Sub TryScrollToHeader(ByVal element As LayoutElement)
            Dim header As LayoutHeader = TryCast(element, LayoutHeader)
            If header Is Nothing Then
                header = element.GetParentByType(Of LayoutHeader)()
            End If
            If header Is Nothing Then
                Return
            End If
            Dim nearestPageArea As LayoutPageArea = (CType(header.Parent, LayoutPage)).PageAreas.First
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
            Dim nearestPageArea As LayoutPageArea = (CType(footer.Parent, LayoutPage)).PageAreas.Last
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
                richEditControl.Document.Selection = richEditControl.Document.CreateRange(anchor.Range.Start, anchor.Range.Length)
            End If
        End Sub
        Private Sub ScrollToPosition(ByVal position As Integer)
            richEditControl.Document.CaretPosition = richEditControl.Document.CreatePosition(position)
            richEditControl.ScrollToCaret(0.5F)
        End Sub
        Private Sub ScrollToPosition(ByVal position As DocumentPosition)
            richEditControl.Document.CaretPosition = position
            richEditControl.ScrollToCaret(0.5F)
        End Sub
        Private Sub OnBeforeExpand(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs) Handles treeView1.BeforeExpand
            Dim node As RichEditTreeNode = CType(e.Node, RichEditTreeNode)
            If node.Info.HasChildNodes AndAlso node.Nodes.Count > 0 Then
                Dim loadingNode As TreeNode = node.Nodes("Loading")
                If loadingNode IsNot Nothing Then
                    node.Nodes.Remove(loadingNode)
                End If
            End If
            If node.Nodes.Count > 0 Then
                Return
            End If
            Dim collector As New ChildElementsCollector(node.Info)
            Dim childCount As Integer = collector.Collection.Count
            For i As Integer = 0 To childCount - 1
                AddTreeViewItem(node.Nodes, collector.Collection(i))
            Next i
        End Sub
        Private Sub OnDocumentFormatted(ByVal sender As Object, ByVal e As EventArgs)
            BeginInvoke(New Action(Function() AnonymousMethod1()))
        End Sub

        Private Function AnonymousMethod1() As Boolean
            treeView1.Nodes.Clear()
            Dim pageCount As Integer = richEditControl.DocumentLayout.GetFormattedPageCount()
            For i As Integer = 0 To pageCount - 1
                AddTreeViewItem(treeView1.Nodes, New TreeViewItemInfo(richEditControl.DocumentLayout.GetPage(i), ContentDisplayAction.Select, True))
            Next i
            Me.PageCount = richEditControl.DocumentLayout.GetPageCount()
            Return True
        End Function
        Private Sub AddTreeViewItem(ByVal collection As TreeNodeCollection, ByVal info As TreeViewItemInfo)
            Dim node As New RichEditTreeNode(info)
            node.Text = GetTreeViewItemHeader(info.Element, collection.Count + 1)
            collection.Add(node)
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
        Private Sub OnBeforePagePaint(ByVal sender As Object, ByVal e As BeforePagePaintEventArgs) Handles richEditControl.BeforePagePaint
            e.Painter = New CustomPagePainter(LayoutInfos)
        End Sub
        Private Sub richEditControl_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.SelectionChanged
            Dim element As RangedLayoutElement = richEditControl.DocumentLayout.GetElement(Of RangedLayoutElement)(richEditControl.Document.CaretPosition)
            If element IsNot Nothing Then
                ActivePageNumber = richEditControl.DocumentLayout.GetPageIndex(element) + 1
            End If
        End Sub
        Private Sub richEditControl_VisiblePagesChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.VisiblePagesChanged
            ActivePageNumber = richEditControl.ActiveView.GetVisiblePageLayoutInfos()(0).PageIndex + 1
        End Sub
    End Class

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
    Public Class RichEditTreeNode
        Inherits TreeNode
        Private info_Renamed As TreeViewItemInfo

        Public Sub New(ByVal info As TreeViewItemInfo)
            Me.info_Renamed = info
            If info.HasChildNodes Then
                Nodes.Add("Loading", "Loading...")
            End If
        End Sub

        Public ReadOnly Property Info() As TreeViewItemInfo
            Get
                Return info_Renamed
            End Get
        End Property
    End Class
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
        Protected Overrides Sub VisitFrame(frame As LayoutFrame)
            TryAddElementToCollection(frame, ContentDisplayAction.Select, True)
            MyBase.VisitFrame(frame)
        End Sub
        Protected Overrides Sub VisitParagraphFrameBox(paragraphFrameBox As ParagraphFrameBox)
            TryAddElementToCollection(paragraphFrameBox, ContentDisplayAction.Select, False)
            MyBase.VisitParagraphFrameBox(paragraphFrameBox)
        End Sub
        Protected Overrides Sub VisitCommentsArea(commentsArea As LayoutCommentsArea)
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
    Public Class LayoutInfoItem
        Private name_Renamed As String
        Private isChecked_Renamed As Boolean
        Private color_Renamed As Color

        Public Sub New(ByVal name As String, ByVal color As Color)
            Me.name_Renamed = name
            Me.color_Renamed = color
            Me.isChecked_Renamed = False
        End Sub

        Public ReadOnly Property Name() As String
            Get
                Return name_Renamed
            End Get
        End Property
        Public Property IsChecked() As Boolean
            Get
                Return isChecked_Renamed
            End Get
            Set(ByVal value As Boolean)
                isChecked_Renamed = value
            End Set
        End Property
        Public Property Color() As Color
            Get
                Return color_Renamed
            End Get
            Set(ByVal value As Color)
                color_Renamed = value
            End Set
        End Property
    End Class
#Region "CustomPagePainter"
    Public Class CustomPagePainter
        Inherits PagePainter
        Private layoutInfos_Renamed As List(Of LayoutInfoItem)

        Public Sub New(ByVal layoutInfos As List(Of LayoutInfoItem))
            Me.layoutInfos_Renamed = layoutInfos
        End Sub

        Private ReadOnly Property LayoutInfos() As List(Of LayoutInfoItem)
            Get
                Return layoutInfos_Renamed
            End Get
        End Property

        Public Overrides Sub DrawCommentsArea(commentsArea As LayoutCommentsArea)
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
        Public Overrides Sub DrawFrame(frame As LayoutFrame)
            MyBase.DrawFrame(frame)
            HighlightElement(frame)
        End Sub
        Public Overrides Sub DrawParagraphFrame(paragraphFrame As ParagraphFrameBox)
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
            Dim count As Integer = LayoutInfos.Count
            For i As Integer = 0 To count - 1
                If LayoutInfos(i).Name.Equals(type.ToString()) Then
                    Return LayoutInfos(i)
                End If
            Next i
            Return Nothing
        End Function
    End Class
#End Region
End Namespace

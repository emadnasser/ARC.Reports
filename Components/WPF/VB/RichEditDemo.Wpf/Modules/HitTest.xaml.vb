Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Xpf.Editors
Imports DevExpress.XtraRichEdit
Imports System.Globalization
Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.Xpf.RichEdit
Imports System.Drawing
Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Namespace RichEditDemo
    Public Enum ScopeType
        <Description("Page")>
        Page
        <Description("Main Page Area")>
        MainPageArea
        <Description("Header Page Area")>
        HeaderPageArea
        <Description("Footer Page Area")>
        FooterPageArea
    End Enum
    Partial Public Class HitTest
        Inherits RichEditDemoModule

        #Region "Fields"

        Private hitTest_Renamed As HitTestManager
        Private result As RichEditHitTestResult
        Private pageIndex As Integer
        Private oldMousePosition As System.Windows.Point
        Private dicHighlightLayoutElement As Dictionary(Of LayoutType, RichEditPen)
        #End Region
        Public Sub New()
            InitializeComponent()
            OpenXmlLoadHelper.Load("HitTest.docx", richEdit)
            richEdit.Options.DocumentCapabilities.Comments = DocumentCapability.Disabled
            richEdit.Options.Comments.Visibility = RichEditCommentVisibility.Hidden
            richEdit.LayoutUnit = DocumentLayoutUnit.Pixel
            SpecifyHighlightOptions()
            SubscribeToHighlightEvents()
        End Sub
        Private Sub SubscribeToHighlightEvents()
            AddHandler highlightPage.EditValueChanged, AddressOf HighlightPotionsChanged
            AddHandler pageHigtlightColor.ColorChanged, AddressOf HighlightPotionsChanged
            AddHandler highlightPageArea.EditValueChanged, AddressOf HighlightPotionsChanged
            AddHandler pageAreaHigtlightColor.ColorChanged, AddressOf HighlightPotionsChanged
            AddHandler highlightColumn.EditValueChanged, AddressOf HighlightPotionsChanged
            AddHandler columnHigtlightColor.ColorChanged, AddressOf HighlightPotionsChanged
            AddHandler highlightRow.EditValueChanged, AddressOf HighlightPotionsChanged
            AddHandler rowHigtlightColor.ColorChanged, AddressOf HighlightPotionsChanged
            AddHandler highlightBox.EditValueChanged, AddressOf HighlightPotionsChanged
            AddHandler boxHigtlightColor.ColorChanged, AddressOf HighlightPotionsChanged
            AddHandler highlightCharacterBox.EditValueChanged, AddressOf HighlightPotionsChanged
            AddHandler characterBoxHigtlightColor.ColorChanged, AddressOf HighlightPotionsChanged
        End Sub
        Private Sub HighlightPotionsChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SpecifyHighlightOptions()
        End Sub
        Private Sub SpecifyHighlightOptions()
            dicHighlightLayoutElement = New Dictionary(Of LayoutType, RichEditPen)()
            dicHighlightLayoutElement.Add(LayoutType.Page,If(highlightPage.IsChecked = True, New RichEditPen(pageHigtlightColor.Color, 3), Nothing))
            dicHighlightLayoutElement.Add(LayoutType.PageArea,If(highlightPageArea.IsChecked = True, New RichEditPen(pageAreaHigtlightColor.Color, 3), Nothing))
            dicHighlightLayoutElement.Add(LayoutType.Column,If(highlightColumn.IsChecked = True, New RichEditPen(columnHigtlightColor.Color, 3), Nothing))
            dicHighlightLayoutElement.Add(LayoutType.Row,If(highlightRow.IsChecked = True, New RichEditPen(rowHigtlightColor.Color, 3), Nothing))
            dicHighlightLayoutElement.Add(LayoutType.PlainTextBox,If(highlightBox.IsChecked = True, New RichEditPen(boxHigtlightColor.Color, 3), Nothing))
            dicHighlightLayoutElement.Add(LayoutType.CharacterBox,If(highlightCharacterBox.IsChecked = True, New RichEditPen(characterBoxHigtlightColor.Color, 3), Nothing))
        End Sub
        Private Sub RichEditControl_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Input.MouseEventArgs)
            Dim currentMousePosition As System.Windows.Point = e.GetPosition(richEdit)
            If oldMousePosition <> currentMousePosition Then
                CalculateResult(e)
                richEdit.Refresh()
                oldMousePosition = currentMousePosition
            End If
        End Sub
        Private Sub RichEditControl_MouseEnter(ByVal sender As Object, ByVal e As System.Windows.Input.MouseEventArgs)
            AddHandler richEdit.PreviewMouseMove, AddressOf RichEditControl_MouseMove
            AddHandler richEdit.BeforePagePaint, AddressOf RichEditControl_BeforePagePaint
            AddHandler richEdit.PreviewMouseLeftButtonDown, AddressOf RichEditControl_MouseClick
        End Sub
        Private Sub RichEditControl_MouseLeave(ByVal sender As Object, ByVal e As System.Windows.Input.MouseEventArgs)
            RemoveHandler richEdit.PreviewMouseMove, AddressOf RichEditControl_MouseMove
            RemoveHandler richEdit.BeforePagePaint, AddressOf RichEditControl_BeforePagePaint
            RemoveHandler richEdit.PreviewMouseLeftButtonDown, AddressOf RichEditControl_MouseClick
            richEdit.Refresh()
            result = Nothing
        End Sub
        Private Sub RichEditControl_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Input.MouseEventArgs)
            lbResult.Items.Clear()
            CalculateResult(e)
            Dim leftSpace As String = ""
            Dim specialChar As String = "  "
            Dim reverseResult As RichEditHitTestResult = RichEditHitTestResult.Reverse(result)
            Do While reverseResult IsNot Nothing
                If leftSpace.Length = 2 Then
                    specialChar = "- "
                End If
                lbResult.Items.Add(leftSpace & specialChar & reverseResult.LayoutElement.Type.ToString())
                leftSpace &= "  "
                reverseResult = reverseResult.Next
            Loop
        End Sub
        Private Sub CalculateResult(ByVal e As System.Windows.Input.MouseEventArgs)
            Dim winPoint As System.Windows.Point = e.GetPosition(richEdit)
            Dim point As New System.Drawing.Point(CInt((winPoint.X)), CInt((winPoint.Y)))
            Dim searchOption As HitTestSearchOption = HitTestSearchOption.Exact
            If nearestHit.IsChecked = True Then
                searchOption = HitTestSearchOption.Nearest
            End If
            Dim pageLayoutPosition As DevExpress.XtraRichEdit.PageLayoutPosition = richEdit.ActiveView.GetDocumentLayoutPosition(point)
            If pageLayoutPosition Is Nothing Then
                result = Nothing
                Return
            End If
            pageIndex = pageLayoutPosition.PageIndex
            point = pageLayoutPosition.Position
            hitTest_Renamed = New HitTestManager(richEdit.DocumentLayout)
            Dim layoutPage As LayoutPage = richEdit.DocumentLayout.GetPage(pageIndex)
            ExecuteHitTest(layoutPage, point, searchOption)
        End Sub
        Private Sub ExecuteHitTest(ByVal layoutPage As LayoutPage, ByVal point As System.Drawing.Point, ByVal searchOption As HitTestSearchOption)
            Select Case CType(cbScope.EditValue, ScopeType)
                Case ScopeType.Page
                    result = hitTest_Renamed.HitTest(layoutPage, point, searchOption)
                Case ScopeType.MainPageArea
                    result = hitTest_Renamed.HitTest(layoutPage.PageAreas(0), point, searchOption)
                Case ScopeType.HeaderPageArea
                    If layoutPage.Header IsNot Nothing Then
                        result = hitTest_Renamed.HitTest(layoutPage.Header, point, searchOption)
                    End If
                Case ScopeType.FooterPageArea
                    If layoutPage.Footer IsNot Nothing Then
                        result = hitTest_Renamed.HitTest(layoutPage.Footer, point, searchOption)
                    End If
            End Select
        End Sub
        Private Sub RichEditControl_BeforePagePaint(ByVal sender As Object, ByVal e As BeforePagePaintEventArgs)
            If e.Page.Index = pageIndex Then
                e.Painter = New HitTestPagePainter(RichEditHitTestResult.Reverse(result), dicHighlightLayoutElement,If(highlightOther.IsChecked = True, New RichEditPen(otherHigtlightColor.Color, 3), Nothing))
            End If
        End Sub
    End Class
    Public Class HitTestPagePainter
        Inherits PagePainter

        Private result As RichEditHitTestResult
        Private dicHighlightLayoutType As Dictionary(Of LayoutType, RichEditPen)
        Private defaultHighlightPen As RichEditPen
        Public Sub New(ByVal result As RichEditHitTestResult)
            Me.New(result, New Dictionary(Of LayoutType, RichEditPen)())
        End Sub
        Public Sub New(ByVal result As RichEditHitTestResult, ByVal dicHighlightLayoutType As Dictionary(Of LayoutType, RichEditPen))
            Me.New(result, dicHighlightLayoutType, New RichEditPen(System.Windows.Media.Colors.Green, 3))
        End Sub
        Public Sub New(ByVal result As RichEditHitTestResult, ByVal dicHighlightLayoutType As Dictionary(Of LayoutType, RichEditPen), ByVal defaultHighlightPen As RichEditPen)
            Me.result = result
            Me.dicHighlightLayoutType = dicHighlightLayoutType
            Me.defaultHighlightPen = defaultHighlightPen
        End Sub
        Public Overrides Sub DrawPage(ByVal page As LayoutPage)
            MyBase.DrawPage(page)
            Dim currentHighLightPen As RichEditPen = Nothing
            Dim layoutElement As LayoutElement
            Do While result IsNot Nothing
                layoutElement = result.LayoutElement
                If Not dicHighlightLayoutType.TryGetValue(layoutElement.Type, currentHighLightPen) Then
                    currentHighLightPen = defaultHighlightPen
                End If
                If currentHighLightPen IsNot Nothing Then
                    If layoutElement.Type = LayoutType.FloatingPicture OrElse layoutElement.Type = LayoutType.TextBox Then
                        Dim pointToDraw() As System.Drawing.Point = CType(layoutElement, LayoutFloatingObject).GetCoordinates()
                        Me.Canvas.DrawLines(currentHighLightPen, pointToDraw)
                        Me.Canvas.DrawLine(currentHighLightPen, pointToDraw(3), pointToDraw(0))
                    Else
                        Dim parentTextBox As LayoutTextBox = layoutElement.GetParentByType(Of LayoutTextBox)()
                        If parentTextBox IsNot Nothing Then
                            Dim matrix As Matrix = parentTextBox.GetRotationMatrix()
                            Dim bounds As Rectangle = layoutElement.Bounds
                            Dim points() As System.Drawing.Point = {
                                New System.Drawing.Point(bounds.X, bounds.Y),
                                New System.Drawing.Point(bounds.X + bounds.Width, bounds.Y),
                                New System.Drawing.Point(bounds.X + bounds.Width, bounds.Y + bounds.Height),
                                New System.Drawing.Point(bounds.X, bounds.Y+bounds.Height),
                                New System.Drawing.Point(bounds.X, bounds.Y)
                            }
                            matrix.TransformPoints(points)
                            Me.Canvas.DrawLines(currentHighLightPen, points)
                            matrix.Dispose()
                        Else
                            Me.Canvas.DrawRectangle(currentHighLightPen, layoutElement.Bounds)
                        End If
                    End If
                End If
                result = result.Next
            Loop
        End Sub
    End Class
End Namespace

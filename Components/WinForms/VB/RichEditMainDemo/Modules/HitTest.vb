Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.XtraRichEdit.Utils
Imports System.Drawing.Drawing2D

Namespace DevExpress.XtraRichEdit.Demos
    Partial Public Class HitTest
        Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
#Region "Fields"
        Private hitTest_Renamed As HitTestManager
        Private result As RichEditHitTestResult
        Private pageIndex As Integer
        Private oldMousePosition As Point
        Private dicHighlightLayoutElement As Dictionary(Of LayoutType, RichEditPen)
#End Region

        Public Sub New()
            InitializeComponent()
            OpenXmlLoadHelper.Load("HitTest.docx", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
            richEditControl.Options.Comments.Visibility = RichEditCommentVisibility.Visible
            AddTargetElements()
            SpecifyHighlightOptions()
            SubscribeToHighlightEvents()
        End Sub
        Private Sub AddTargetElements()
            cbScope.Properties.Items.Clear()
            cbScope.Properties.Items.AddEnum(Of ScopeType)()
            cbScope.SelectedIndex = 0
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
        Private Sub HighlightPotionsChanged(ByVal sender As Object, ByVal e As EventArgs)
            SpecifyHighlightOptions()
        End Sub
        Private Sub SpecifyHighlightOptions()
            dicHighlightLayoutElement = New Dictionary(Of LayoutType, RichEditPen)()
            dicHighlightLayoutElement.Add(LayoutType.Page, If((highlightPage.Checked = True), New RichEditPen(pageHigtlightColor.Color, 3), Nothing))
            dicHighlightLayoutElement.Add(LayoutType.PageArea, If((highlightPageArea.Checked = True), New RichEditPen(pageAreaHigtlightColor.Color, 3), Nothing))
            dicHighlightLayoutElement.Add(LayoutType.Column, If((highlightColumn.Checked = True), New RichEditPen(columnHigtlightColor.Color, 3), Nothing))
            dicHighlightLayoutElement.Add(LayoutType.Row, If((highlightRow.Checked = True), New RichEditPen(rowHigtlightColor.Color, 3), Nothing))
            dicHighlightLayoutElement.Add(LayoutType.PlainTextBox, If((highlightBox.Checked = True), New RichEditPen(boxHigtlightColor.Color, 3), Nothing))
            dicHighlightLayoutElement.Add(LayoutType.CharacterBox, If((highlightCharacterBox.Checked = True), New RichEditPen(characterBoxHigtlightColor.Color, 3), Nothing))
        End Sub
        Private Sub RichEditControl_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles richEditControl.MouseMove
            Dim currentMousePosition As Point = e.Location
            If oldMousePosition <> currentMousePosition Then
                CalculateResult(e)
                richEditControl.Invalidate()
                oldMousePosition = currentMousePosition
            End If
        End Sub
        Private Sub RichEditControl_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.MouseEnter
            AddHandler richEditControl.MouseMove, AddressOf RichEditControl_MouseMove
            AddHandler richEditControl.BeforePagePaint, AddressOf RichEditControl_BeforePagePaint
            AddHandler richEditControl.MouseClick, AddressOf RichEditControl_MouseClick
        End Sub
        Private Sub RichEditControl_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.MouseLeave
            RemoveHandler richEditControl.MouseMove, AddressOf RichEditControl_MouseMove
            RemoveHandler richEditControl.BeforePagePaint, AddressOf RichEditControl_BeforePagePaint
            RemoveHandler richEditControl.MouseClick, AddressOf RichEditControl_MouseClick
            richEditControl.Invalidate()
        End Sub
        Private Sub RichEditControl_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles richEditControl.MouseClick
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
        Private Sub CalculateResult(ByVal e As MouseEventArgs)
            Dim point As Point = e.Location
            Dim searchOption As HitTestSearchOption = HitTestSearchOption.Exact
            If rgSearchOptions.SelectedIndex = 1 Then
                searchOption = HitTestSearchOption.Nearest
            End If
            Dim pageLayoutPosition As DevExpress.XtraRichEdit.PageLayoutPosition = richEditControl.ActiveView.GetDocumentLayoutPosition(point)
            If pageLayoutPosition Is Nothing Then
                result = Nothing
                Return
            End If
            pageIndex = pageLayoutPosition.PageIndex
            point = pageLayoutPosition.Position
            hitTest_Renamed = New HitTestManager(richEditControl.DocumentLayout)
            Dim layoutPage As LayoutPage = richEditControl.DocumentLayout.GetPage(pageIndex)
            ExecuteHitTest(layoutPage, point, searchOption)
        End Sub
        Private Sub ExecuteHitTest(ByVal layoutPage As LayoutPage, ByVal point As Point, ByVal searchOption As HitTestSearchOption)
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
        Private Sub RichEditControl_BeforePagePaint(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.BeforePagePaintEventArgs)
            If e.Page.Index = pageIndex Then
                e.Painter = New HitTestPagePainter(RichEditHitTestResult.Reverse(result), dicHighlightLayoutElement, If((highlightOther.Checked = True), New RichEditPen(otherHigtlightColor.Color, 3), Nothing))
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
            Me.New(result, dicHighlightLayoutType, New RichEditPen(Color.Green, 3))
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
                If (Not dicHighlightLayoutType.TryGetValue(layoutElement.Type, currentHighLightPen)) Then
                    currentHighLightPen = defaultHighlightPen
                End If
                If currentHighLightPen IsNot Nothing Then
                    If layoutElement.Type = LayoutType.FloatingPicture OrElse layoutElement.Type = LayoutType.TextBox Then
                        Dim pointToDraw() As Point = (CType(layoutElement, LayoutFloatingObject)).GetCoordinates()
                        Me.Canvas.DrawLines(currentHighLightPen, pointToDraw)
                        Me.Canvas.DrawLine(currentHighLightPen, pointToDraw(3), pointToDraw(0))
                    Else
                        Dim parentTextBox As LayoutTextBox = layoutElement.GetParentByType(Of LayoutTextBox)()
                        If parentTextBox IsNot Nothing Then
                            Dim matrix As Matrix = parentTextBox.GetRotationMatrix()
                            Dim bounds As Rectangle = layoutElement.Bounds
                            Dim points() As Point = {New Point(bounds.X, bounds.Y), New Point(bounds.X + bounds.Width, bounds.Y), New Point(bounds.X + bounds.Width, bounds.Y + bounds.Height), New Point(bounds.X, bounds.Y + bounds.Height), New Point(bounds.X, bounds.Y)}
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
End Namespace

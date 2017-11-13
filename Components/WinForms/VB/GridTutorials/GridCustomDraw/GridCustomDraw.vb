Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Data
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridCustomDraw.
    ''' </summary>
    Partial Public Class GridCustomDraw
        Inherits TutorialControl
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Private Sub GridCustomDraw_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
        End Sub

        Private Sub InitData()
            Dim XV As DevExpress.XtraGrid.Design.XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
            InitView()
        End Sub

        Private Sub InitView()
            gridView1.GroupSummary.Add(SummaryItemType.Count, "Product Name", gridView1.Columns("Product Name"))
            gridView1.GroupSummary.Add(SummaryItemType.Average, "Unit Price", gridView1.Columns("Unit Price"))
            CType(gridView1.GroupSummary(gridView1.GroupSummary.Count - 1), GridSummaryItem).DisplayFormat = "AVG={0:c}"
            gridView1.Columns("Discontinued").GroupIndex = 0
            gridView1.ExpandAllGroups()
        End Sub

#Region "CustomDraw"
        '<gridControl1>
        Private Sub gridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles gridView1.CustomDrawColumnHeader
            If e.Column Is Nothing Then
                Return
            End If
            Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.AliceBlue, Color.DodgerBlue, 90)
            Dim brushPressed As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.WhiteSmoke, Color.Gray, 90)

            Dim r As Rectangle = e.Bounds
            If e.Info.State = DevExpress.Utils.Drawing.ObjectState.Pressed Then
                ControlPaint.DrawBorder3D(e.Graphics, r, (Border3DStyle.SunkenOuter))
            Else
                ControlPaint.DrawBorder3D(e.Graphics, r, (Border3DStyle.RaisedInner))
            End If
            r.Inflate(-1, -1)
            If e.Info.State = DevExpress.Utils.Drawing.ObjectState.Pressed Then
                e.Graphics.FillRectangle((brushPressed), r)
            Else
                e.Graphics.FillRectangle((brush), r)
            End If

            If e.Column.AbsoluteIndex = gridView1.FocusedColumn.AbsoluteIndex Then
                e.Appearance.Font = New Font(AppearanceObject.DefaultFont, FontStyle.Bold)
                e.Appearance.ForeColor = Color.Navy
            Else
                e.Appearance.Font = AppearanceObject.DefaultFont
                e.Appearance.ForeColor = SystemColors.WindowText
            End If
            e.Appearance.DrawString(e.Cache, e.Column.GetTextCaption(), e.Info.CaptionRect)

            e.Info.InnerElements.DrawObjects(e.Info, e.Info.Cache, Point.Empty)
            e.Handled = True
        End Sub
        '</gridControl1>

        Private Sub gridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridView1.CustomDrawRowIndicator
            Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.AliceBlue, Color.DodgerBlue, 90)
            Dim r As Rectangle = e.Bounds
            r.Inflate(-1, -1)
            e.Graphics.FillRectangle(brush, r)
            If e.Info.ImageIndex > -1 Then
                Dim x As Integer = r.X + (r.Width - e.Info.Images.ImageSize.Width) \ 2
                Dim y As Integer = r.Y + (r.Height - e.Info.Images.ImageSize.Height) \ 2
                e.Graphics.DrawImageUnscaled(e.Info.Images.Images(e.Info.ImageIndex), x, y)
            End If
            ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
            e.Handled = True
        End Sub

        Private Sub gridView1_CustomDrawGroupPanel(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs) Handles gridView1.CustomDrawGroupPanel
            Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Gray, Color.WhiteSmoke, 0)
            e.Graphics.FillRectangle(brush, e.Bounds)
            e.Handled = True
        End Sub

        Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawGroupRow
            Dim groupInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo = TryCast(e.Info, DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo)
            Dim button As Rectangle = groupInfo.ButtonBounds, text As Rectangle = groupInfo.Bounds

            Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(text, Color.AliceBlue, Color.DodgerBlue, 0)
            Dim brushText As Brush = Brushes.Black
            If e.RowHandle = gridView1.FocusedRowHandle Then
                brush = SystemBrushes.Highlight
                brushText = SystemBrushes.HighlightText
            End If
            e.Graphics.FillRectangle(brush, text)
            If (Not button.IsEmpty) Then
                text.Width = text.Right - (button.Right + 4)
                text.X = button.Right + 4
                Dim x As Integer = button.X
                Dim y As Integer = text.Y + (text.Height - imageList1.ImageSize.Height) \ 2
                If gridView1.GetRowExpanded(e.RowHandle) Then
                    e.Graphics.DrawImageUnscaled(imageList1.Images((1)), x, y)
                Else
                    e.Graphics.DrawImageUnscaled(imageList1.Images((0)), x, y)
                End If
            End If
            Dim s As String = gridView1.GetGroupRowDisplayText(e.RowHandle)
            e.Graphics.DrawString(s, e.Appearance.Font, brushText, text, e.Appearance.GetStringFormat())
            e.Handled = True
        End Sub

        Private Sub gridView1_CustomDrawRowFooter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawRowFooter
            Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.AliceBlue, Color.DodgerBlue, 90)
            e.Graphics.FillRectangle(brush, e.Bounds)
            e.Handled = True
        End Sub

        Private Sub gridView1_CustomDrawRowFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles gridView1.CustomDrawRowFooterCell
            Dim brush As Brush = Brushes.AliceBlue

            Dim r As Rectangle = e.Bounds
            ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.SunkenOuter)

            r.Inflate(-1, -1)
            e.Graphics.FillRectangle(brush, r)

            r.Inflate(-2, 0)
            e.Appearance.DrawString(e.Cache, e.Info.DisplayText, r)

            If e.Column.AbsoluteIndex = 0 Then
                Dim x As Integer = r.X + 2
                Dim y As Integer = r.Y + (r.Height - imageList1.ImageSize.Height) \ 2
                e.Graphics.DrawImageUnscaled(imageList1.Images(2), x, y)
            End If
            e.Handled = True
        End Sub

        Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gridView1.RowCellStyle
            If e.RowHandle <> gridView1.FocusedRowHandle OrElse e.Column.AbsoluteIndex = gridView1.FocusedColumn.AbsoluteIndex Then
                If e.Column.FieldName = "Category" AndAlso gridView1.GetRowCellValue(e.RowHandle, e.Column).Equals(6) Then
                    e.Appearance.Font = New Font(AppearanceObject.DefaultFont, FontStyle.Bold)
                    e.Appearance.ForeColor = Color.Navy
                End If
                If e.Column.FieldName = "Unit Price" AndAlso TypeOf gridView1.GetRowCellValue(e.RowHandle, e.Column) Is System.Decimal Then
                    If CType(gridView1.GetRowCellValue(e.RowHandle, e.Column), Decimal) > 30 Then
                        e.Appearance.BackColor = Color.FromArgb(192, 192, 255)
                    End If
                End If
            End If
        End Sub

        Private Sub gridView1_GroupLevelStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs) Handles gridView1.GroupLevelStyle
            e.LevelAppearance.BackColor = System.Drawing.Color.AliceBlue
        End Sub
#End Region

        Private Sub gridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles gridView1.FocusedColumnChanged
            gridView1.InvalidateColumnHeader(Nothing)
            gridView1.InvalidateGroupPanel()
        End Sub

        Public Overrides ReadOnly Property ShowLookAndFeel() As Boolean
            Get
                Return False
            End Get
        End Property
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraReports.UI
Imports System.Drawing
Imports DevExpress.XtraPrinting.Export.Web
Imports DevExpress.XtraPrinting
Imports System.Data
Imports DevExpress.DemoData.Models

Namespace XtraReportsDemos.CustomDraw
    Public Class CustomControl
        Inherits XRControl

        Private controlData(,) As Object = {
            { "", 1.0 }
        }
        Public Sub UpdateData(ByVal regions As IList(Of AboutRegion))
            controlData = New Object(Math.Min(regions.Count, 10) - 1, 1){}
            For i As Integer = 0 To controlData.GetLength(0) - 1
                Dim population As Double = regions(i).PopulationPortion
                Dim country As String = String.Format("{0}, {1}", regions(i).Country, population.ToString("p"))
                controlData.SetValue(country, i, 0)
                controlData.SetValue(population, i, 1)
            Next i

        End Sub
        Protected Overrides Function CreateBrick(ByVal childrenBricks() As VisualBrick) As VisualBrick
            Return New PanelBrick(Me)
        End Function
        Protected Overrides Sub PutStateToBrick(ByVal brick As VisualBrick, ByVal ps As PrintingSystemBase)
            MyBase.PutStateToBrick(brick, ps)
            Dim itemHeight As Single = GetItemHeight(brick.Rect)
            Dim r As RectangleF = GetGraphicsRect(brick.Rect, itemHeight)
            Dim scale As Double = GetScale()
            For i As Integer = 0 To controlData.GetUpperBound(0)
                DrawPopulationInfo(CType(brick, PanelBrick), r, DirectCast(controlData(i, 0), String), DirectCast(controlData(i, 1), Double), scale)
                r.Offset(0, itemHeight)
            Next i
        End Sub
        Private Function GetItemHeight(ByVal bounds As RectangleF) As Single
            Return bounds.Height / (controlData.GetUpperBound(0) + 1)
        End Function
        Private Function GetScale() As Double
            Return 1 / DirectCast(controlData(0, 1), Double)
        End Function
        Private Shared Function GetGraphicsRect(ByVal bounds As RectangleF, ByVal itemHeight As Single) As RectangleF
            Const indent As Integer = 10
            Dim r As New RectangleF(0, 0, bounds.Width, itemHeight)
            r.Inflate(-2 * indent, -indent)
            Return r
        End Function
        Private Shared Sub DrawPopulationInfo(ByVal panel As PanelBrick, ByVal r As RectangleF, ByVal text As String, ByVal portion As Double, ByVal scale As Double)
            Dim barRect As RectangleF = GetBarRect(r, portion, scale)
            r.Height = barRect.Top - r.Top

            Dim textBrick As New TextBrick()
            textBrick.Sides = BorderSide.None
            textBrick.BackColor = panel.BackColor
            textBrick.Rect = r
            textBrick.ForeColor = panel.Style.ForeColor
            textBrick.Text = text
            textBrick.Font = panel.Style.Font
            textBrick.Padding = New PaddingInfo(1, 0, 0, 0)
            textBrick.StringFormat = panel.Style.StringFormat
            panel.Bricks.Add(textBrick)

            Dim barBrick As New VisualBrick()
            barBrick.Sides = BorderSide.All
            barBrick.BackColor = Color.FromArgb(232, 216, 195)
            barBrick.Rect = barRect
            barBrick.BorderColor = Color.FromArgb(173, 148, 116)
            barBrick.BorderStyle = BrickBorderStyle.Inset
            panel.Bricks.Add(barBrick)
        End Sub
        Private Shared Function GetBarRect(ByVal r As RectangleF, ByVal portion As Double, ByVal scale As Double) As RectangleF
            Dim barWidth As Single = CSng(r.Width * portion * scale)
            Dim barHeight As Single = CSng(CDbl(r.Height) / 3.0)
            Return New RectangleF(r.Left, r.Bottom - barHeight, barWidth, barHeight)
        End Function
    End Class
End Namespace

Imports System
Imports DevExpress.XtraReports.UI
Imports System.Drawing
Imports DevExpress.XtraPrinting

Namespace XtraReportsDemos.CrossBandControls
    Partial Public Class Report
        Inherits XtraReport

        Private drawZBelowTheTable As Boolean

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.CrossBands
            DisplayName = ReportNames.CrossBands
            AddHandler BeforePrint, AddressOf Report_BeforePrint
        End Sub

        Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            drawZBelowTheTable = CBool(Parameters("DrawZBelowTheTableParameter").Value)
            SetFillEmptySpace()
        End Sub

        Public Sub SetFillEmptySpace()
            If drawZBelowTheTable Then
                GroupFooter1.PrintAtBottom = False
                AddHandler FillEmptySpace, AddressOf report_FillEmptySpace
            Else
                GroupFooter1.PrintAtBottom = True
                RemoveHandler FillEmptySpace, AddressOf report_FillEmptySpace
            End If
        End Sub

        Private Sub report_FillEmptySpace(ByVal sender As Object, ByVal e As BandEventArgs)
            If Not drawZBelowTheTable Then
                RemoveHandler FillEmptySpace, AddressOf report_FillEmptySpace
                Return
            End If
            Dim bandHeight As Integer = GraphicsUnitConverter.Convert(e.Band.Height, ReportUnit.ToDpi(), ReportUnit.HundredthsOfAnInch.ToDpi())
            If bandHeight <= 30 Then
                Return
            End If
            Dim size As New Size(612, bandHeight - 30)
            Dim sizeInPixels As Size = XRConvert.Convert(size, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)
            Dim zBitmap As New Bitmap(sizeInPixels.Width, sizeInPixels.Height)
            Dim gr As Graphics = Graphics.FromImage(zBitmap)
            Using pen As New Pen(Color.FromArgb(205, 205, 205), 4)
                Dim points() As Point = {
                    New Point(0, 4),
                    New Point(sizeInPixels.Width, 4),
                    New Point(0, sizeInPixels.Height - 4),
                    New Point(sizeInPixels.Width, sizeInPixels.Height - 4)
                }
                gr.DrawLines(pen, points)
            End Using
            Dim pictureBox As New XRPictureBox()
            pictureBox.BackColor = Color.Transparent
            pictureBox.Size = size
            pictureBox.Location = New Point(19, 15)
            pictureBox.Image = zBitmap
            e.Band.Controls.Add(pictureBox)
        End Sub
    End Class
End Namespace

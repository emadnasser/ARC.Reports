Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraTab
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Control
Imports DevExpress.XtraEditors
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.DXperience.Demos
Imports DevExpress.Tutorials.Controls

Namespace XtraPrintingDemos.HierarchicalReport
    Public Class PreviewControl
        Inherits TutorialControlBase
        Implements IPreviewControl

        Private ReadOnly wCustomers() As Integer = { 90, 150, 100, 70, 83, 100 }
        Private ReadOnly wOrders() As Integer = { 90, 90, 90 }

        Private ReadOnly sCustomers() As String = { "ContactName", "CompanyName", "ContactTitle", "Country", "City", "Address" }
        Private ReadOnly sOrders() As String = { "OrderID", "OrderDate", "Freight" }

        Private WithEvents PSTab As XtraTabControl
        Private imageList1 As System.Windows.Forms.ImageList
        Private imageList2 As System.Windows.Forms.ImageList
        Private components As System.ComponentModel.IContainer

        Private controller As DocumentViewerRibbonController

        Private ReadOnly Property IPreviewControl_Viewer() As DocumentViewer Implements IPreviewControl.Viewer
            Get
                Return Viewer
            End Get
        End Property
        Private ReadOnly Property Viewer() As DocumentViewer
            Get
                Dim tp As XtraTabPage = PSTab.TabPages(PSTab.SelectedTabPageIndex)
                Return If(tp.Controls.Count > 0, TryCast(tp.Controls(0), DocumentViewer), Nothing)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

            Dim ps As New PrintingSystem()
            ps.PageSettings.Assign(New Margins(90, 90, 110, 100), PaperKind.Letter, False)

            AddTabControl("Main Report", Nothing, ps)

            Using dataView As DataView = CreateDataView("Customers", "")
                CType(New ReportCreator(dataView, sCustomers, wCustomers), ReportCreator).CreateReport(ps, imageList1, "Customers", imageList2.Images(0))
            End Using

            SetVisibilityToExportCommands(ps)
        End Sub
        Private Sub SetVisibilityToExportCommands(ByVal ps As PrintingSystem)
            ps.SetCommandVisibility(New PrintingSystemCommand() { PrintingSystemCommand.ExportTxt, PrintingSystemCommand.ExportXls, PrintingSystemCommand.ExportXlsx, PrintingSystemCommand.ExportCsv, PrintingSystemCommand.ExportHtm, PrintingSystemCommand.ExportMht, PrintingSystemCommand.ExportRtf, PrintingSystemCommand.SendMht, PrintingSystemCommand.SendRtf }, CommandVisibility.All)
        End Sub
        Private Sub AddTabControl(ByVal text As String, ByVal tag As Object, ByVal ps As PrintingSystem)
            Dim tp As New XtraTabPage() With {.Text = text, .Tag = tag}
            Dim pc As New DocumentViewer() With {.RequestDocumentCreation = False, .PrintingSystem = ps, .Dock = DockStyle.Fill}
            AddHandler pc.BrickClick, AddressOf OnBrickClick
            tp.Controls.Add(pc)
            PSTab.TabPages.Add(tp)
            PSTab.SelectedTabPageIndex = PSTab.TabPages.Count - 1
        End Sub
        Private Sub OnBrickClick(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.Control.BrickEventArgs)
            If e.Brick IsNot Nothing AndAlso (Not String.IsNullOrEmpty(e.Brick.ID)) Then
                ChangeClickBrick(e.Brick)
            End If
        End Sub
        Private Sub IPreviewControl_Activate(ByVal controller As DocumentViewerRibbonController) Implements IPreviewControl.Activate
            Me.controller = controller
            If controller IsNot Nothing Then
                controller.DocumentViewer = Viewer
            End If
        End Sub

        #Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(PreviewControl))
            Me.PSTab = New DevExpress.XtraTab.XtraTabControl()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            CType(Me.PSTab, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' PSTab
            ' 
            Me.PSTab.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PSTab.Location = New System.Drawing.Point(0, 0)
            Me.PSTab.Name = "PSTab"
            Me.PSTab.Size = New System.Drawing.Size(784, 432)
            Me.PSTab.TabIndex = 3
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList1.Images.SetKeyName(0, "Book_Closed_16x16.png")
            Me.imageList1.Images.SetKeyName(1, "Book_Opened_16x16.png")
            ' 
            ' imageList2
            ' 
            Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList2.Images.SetKeyName(0, "Customers_icon.png")
            Me.imageList2.Images.SetKeyName(1, "Order_Icon_64x64.png")
            ' 
            ' PreviewControl
            ' 
            Me.Controls.Add(Me.PSTab)
            Me.Name = "PreviewControl"
            CType(Me.PSTab, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        #End Region
        Private Function CreateDataView(ByVal tbl As String, ByVal s As String) As DataView
            Dim dataSet1 As New DataSet()
            Dim query As String = "SELECT * FROM " & tbl & s
            Dim work1 As New System.Data.OleDb.OleDbDataAdapter(query, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\nwind.mdb")
            work1.Fill(dataSet1, tbl)
            Dim dvManager1 As New DataViewManager(dataSet1)
            Return dvManager1.CreateDataView(dataSet1.Tables(tbl))
        End Function
        Private Sub ChangeClickBrick(ByVal brick As Brick)
            If brick.Value.Equals("Main") Then
                PSTab.SelectedTabPageIndex = 0
                Return
            End If
            Dim values As Tuple(Of String, String) = TryCast(brick.Value, Tuple(Of String, String))
            If values Is Nothing Then
                Return
            End If

            If Viewer IsNot Nothing Then
                Viewer.InvalidateBrick(brick)
            End If
            Dim tpName As String = String.Format("{0} Orders", values.Item2)

            If Equals("0", brick.ID) Then
                brick.ID = "1"
                CType(brick, ImageBrick).Image = imageList1.Images(1)

                Dim ps As New PrintingSystem()
                ps.PageSettings.Assign(New Margins(110, 110, 110, 100), PaperKind.Letter, False)
                AddTabControl(tpName, values.Item1, ps)

                Using dataView As DataView = CreateDataView("Orders", String.Format(" WHERE [CustomerID] ='{0}'", values.Item1))
                    CType(New DetailReportCreator(dataView, sOrders, wOrders), DetailReportCreator).CreateReport(ps, tpName, imageList2.Images(1))
                End Using
            Else
                brick.ID = "0"
                CType(brick, ImageBrick).Image = imageList1.Images(0)
                PSTab.TabPages.RemoveAt(FindTabPageIndex(tpName, PSTab))
                PSTab.SelectedTabPageIndex = 0
            End If
        End Sub

        Private Function FindTabPageIndex(ByVal s As String, ByVal tbc As XtraTabControl) As Integer
            For i As Integer = 0 To tbc.TabPages.Count - 1
                If tbc.TabPages(i).Text = s Then
                    Return i
                End If
            Next i
            Return -1
        End Function
        Private Sub PSTab_SelectedIndexChanged(ByVal sender As Object, ByVal e As TabPageChangedEventArgs) Handles PSTab.SelectedPageChanged
            If controller IsNot Nothing Then
                controller.DocumentViewer = Viewer
            End If
        End Sub
    End Class
    Friend Class ReportCreatorBase
        Protected ReadOnly numericTypes() As Type = { GetType(Byte), GetType(Decimal), GetType(Double), GetType(Short), GetType(Integer), GetType(Long), GetType(SByte), GetType(Single), GetType(UShort), GetType(UInteger), GetType(ULong) }
        Protected ReadOnly textPadding As New PaddingInfo(5, 5, 2, 2)

        Protected columnsNames() As String
        Protected dv As DataView
        Protected widths() As Integer
        Protected Sub New(ByVal dv As DataView, ByVal columnsNames() As String, ByVal widths() As Integer)
            Me.columnsNames = columnsNames
            Me.widths = widths
            Me.dv = dv
        End Sub
        Protected Sub CreatePageHeader(ByVal gr As BrickGraphics, ByVal reportName As String, ByVal imgTitle As Image, ByVal foreColor As Color)
            gr.BackColor = Color.Transparent
            gr.Modifier = BrickModifier.MarginalHeader

            gr.Font = New Font("Tahoma", 20F, FontStyle.Bold)


            Dim ptBrick As New PageTableBrick()
            Dim row As New TableRow()
            Dim piBrick As New PageImageBrick()
            piBrick.Image = imgTitle
            piBrick.SizeMode = ImageSizeMode.CenterImage
            piBrick.Rect = New RectangleF(0, 0, 95, 75)
            piBrick.Sides = BorderSide.None
            piBrick.BackColor = Color.Transparent
            row.Bricks.Add(piBrick)
            Dim pinfBrick As New PageInfoBrick()
            pinfBrick.Format = reportName
            pinfBrick.ForeColor = foreColor
            Dim infoRect As New RectangleF(piBrick.Rect.Right + 10, 0, 100, gr.Font.Height)
            pinfBrick.Rect = New RectangleF(New PointF(piBrick.Rect.X + piBrick.Rect.Right, piBrick.Rect.Y), piBrick.Rect.Size)
            pinfBrick.AutoWidth = True
            pinfBrick.Sides = BorderSide.None
            pinfBrick.StringFormat = pinfBrick.StringFormat.ChangeLineAlignment(StringAlignment.Center)
            row.Bricks.Add(pinfBrick)
            ptBrick.Rows.Add(row)
            gr.DrawBrick(ptBrick)
            ptBrick.Alignment = BrickAlignment.Near
            ptBrick.LineAlignment = BrickAlignment.Center
            ptBrick.UpdateSize()
        End Sub
        Protected Function CalcRowHeight(ByVal gr As BrickGraphics, ByVal text As String, ByVal width As Integer, ByVal height As Integer) As Integer
            Return Math.Max(CInt(gr.MeasureString(text, width).Height), height)
        End Function
        Protected Sub CreatePageFooter(ByVal gr As BrickGraphics)
            gr.Font = New Font("Tahoma", 8F, FontStyle.Regular)
            gr.BackColor = Color.Transparent
            gr.Modifier = BrickModifier.MarginalFooter

            Dim r As New RectangleF(0, 0, 0, gr.Font.Height)
            Dim format As String = "Page: {0} / {1}"
            Dim brick As PageInfoBrick = gr.DrawPageInfo(PageInfo.NumberOfTotal, format, Color.Black, r, BorderSide.None)
            brick.Padding = New PaddingInfo(0, 10, 0, 0, GraphicsDpi.Pixel)
            brick.Alignment = BrickAlignment.Far
            brick.AutoWidth = True
        End Sub
        Protected Sub CreateColumn(ByVal gr As BrickGraphics, ByVal row As DataRowView, ByVal j As Integer, ByVal leftCell As Integer, ByVal hGeneral As Integer, ByVal hRow As Integer)
            Dim columnType As Type = dv.Table.Columns(columnsNames(j)).DataType
            If Array.IndexOf(numericTypes, columnType) > 0 Then
                gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Far)
            Else
                gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Near)
            End If

            If j = 0 Then
                gr.BackColor = Color.FromArgb(255, 241, 219)
            Else
                gr.BackColor = SystemColors.Window
            End If

            Dim borderSides As BorderSide = BorderSide.Bottom Or BorderSide.Right
            If j = 0 Then
                borderSides = borderSides Or BorderSide.Left
            End If
            Dim columnValue As Object = row(columnsNames(j))
            Dim textBrick As TextBrick = gr.DrawString(If(TypeOf columnValue Is Date, DirectCast(columnValue, Date).ToString("d"), columnValue.ToString()), SystemColors.WindowText, New RectangleF(leftCell, hGeneral, widths(j), hRow), borderSides)
            textBrick.BorderStyle = BrickBorderStyle.Inset
            textBrick.Padding = textPadding
        End Sub
        Protected Function GetRowHeight(ByVal row As DataRowView, ByVal gr As BrickGraphics, ByVal textHeight As Integer) As Integer
            Dim hRow As Integer = 0
            For j As Integer = 0 To columnsNames.Length - 1
                hRow = Math.Max(hRow, CalcRowHeight(gr, row(columnsNames(j)).ToString(), widths(j) - textPadding.Left - textPadding.Right, textHeight))
            Next j
            Return hRow
        End Function
    End Class
    Friend Class ReportCreator
        Inherits ReportCreatorBase

        Public Sub New(ByVal dv As DataView, ByVal columnsNames() As String, ByVal widths() As Integer)
            MyBase.New(dv, columnsNames, widths)
        End Sub
        Public Sub CreateReport(ByVal ps As PrintingSystem, ByVal iList As ImageList, ByVal reportName As String, ByVal imgTitle As Image)
            Dim brick As Brick
            Dim gr As BrickGraphics = ps.Graph
            ps.Begin()

            'gr.
            gr.StringFormat = gr.StringFormat.ChangeLineAlignment(StringAlignment.Center)
            gr.Font = New Font("Tahoma", 8F, FontStyle.Bold)

            Dim imgW As Integer = iList.ImageSize.Width
            Dim imgH As Integer = iList.ImageSize.Height

            Dim textHeight As Integer = gr.Font.Height + 2

            'header
            Dim leftCell As Integer = 0
            Dim headerwidth As Integer
            Const BookImageWidth As Integer = 20
            gr.Modifier = BrickModifier.DetailHeader
            gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Center)
            gr.BackColor = Color.FromArgb(71, 143, 212)
            gr.BorderColor = Color.FromArgb(27, 91, 182)
            Dim headerPadding As New PaddingInfo(0, 0, 2, 2)
            For j As Integer = 0 To columnsNames.Length - 1
                headerwidth = widths(j)
                Dim borders As BorderSide = BorderSide.Top Or BorderSide.Bottom Or BorderSide.Right
                If j = 0 Then
                    headerwidth += BookImageWidth
                End If
                If j = 0 Then
                    borders = borders Or BorderSide.Left
                End If
                Dim textBrick As TextBrick = gr.DrawString(dv.Table.Columns(columnsNames(j)).Caption, SystemColors.HighlightText, New RectangleF(leftCell, 0, headerwidth, textHeight + headerPadding.Top + headerPadding.Bottom), borders)
                textBrick.BorderStyle = BrickBorderStyle.Inset
                textBrick.Padding = headerPadding
                leftCell += headerwidth
            Next j

            'strings
            gr.Modifier = BrickModifier.Detail
            gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Near)
            gr.Font = New Font("Tahoma", 8F)

            Dim hGeneral As Integer = 0
            For Each row As DataRowView In dv
                leftCell = imgW + imgW \ 4
                Dim hRow As Integer = GetRowHeight(row, gr, textHeight) + textPadding.Top + textPadding.Bottom

                gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Center)
                Dim imgBrick As ImageBrick = gr.DrawImage(iList.Images(0), New RectangleF(0, hGeneral, BookImageWidth, hRow), BorderSide.None, Color.Transparent)
                imgBrick.SizeMode = ImageSizeMode.CenterImage
                imgBrick.Url = "empty"
                imgBrick.ID = "0"
                imgBrick.Value = New Tuple(Of String, String)(DirectCast(row("CustomerID"), String), DirectCast(row("ContactName"), String))
                brick = imgBrick

                gr.BorderColor = Color.Gray
                For j As Integer = 0 To columnsNames.Length - 1
                    CreateColumn(gr, row, j, leftCell, hGeneral, hRow)
                    leftCell += widths(j)
                Next j
                hGeneral += hRow
            Next row

            CreatePageHeader(gr, reportName, imgTitle, Color.FromArgb(41, 113, 182))
            CreatePageFooter(gr)

            ps.End()
        End Sub
    End Class
    Friend Class DetailReportCreator
        Inherits ReportCreatorBase

        Public Sub New(ByVal dv As DataView, ByVal columnsNames() As String, ByVal widths() As Integer)
            MyBase.New(dv, columnsNames, widths)
        End Sub
        Public Sub CreateReport(ByVal ps As PrintingSystem, ByVal reportName As String, ByVal imgTitle As Image)
            Dim brick As Brick
            Dim gr As BrickGraphics = ps.Graph
            ps.Begin()

            'gr.
            gr.StringFormat = gr.StringFormat.ChangeLineAlignment(StringAlignment.Center)
            gr.Font = New Font("Tahoma", 8F, FontStyle.Bold)

            Dim textHeight As Integer = gr.Font.Height + 2

            'header
            Dim leftCell As Integer = 0
            Dim headerwidth As Integer

            gr.Modifier = BrickModifier.DetailHeader
            gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Center)
            gr.BackColor = Color.FromArgb(71, 143, 212)
            gr.BorderColor = Color.FromArgb(27, 91, 182)

            Dim headerPadding As New PaddingInfo(0, 0, 2, 2)
            For j As Integer = 0 To columnsNames.Length - 1
                headerwidth = widths(j)
                Dim borders As BorderSide = BorderSide.Top Or BorderSide.Bottom Or BorderSide.Right
                If j = 0 Then
                    borders = borders Or BorderSide.Left
                End If
                Dim textBrick As TextBrick = gr.DrawString(dv.Table.Columns(columnsNames(j)).Caption, SystemColors.HighlightText, New RectangleF(leftCell, 0, headerwidth, textHeight + headerPadding.Top + headerPadding.Bottom), borders)
                textBrick.BorderStyle = BrickBorderStyle.Inset
                textBrick.Padding = headerPadding
                leftCell += headerwidth
            Next j

            'strings
            gr.Modifier = BrickModifier.Detail
            gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Near)
            gr.Font = New Font("Tahoma", 8F)

            Dim hGeneral As Integer = 0
            For Each row As DataRowView In dv
                leftCell = 0
                Dim hRow As Integer = GetRowHeight(row, gr, textHeight) + textPadding.Top + textPadding.Bottom

                gr.BorderColor = Color.Gray
                For j As Integer = 0 To columnsNames.Length - 1
                    CreateColumn(gr, row, j, leftCell, hGeneral, hRow)
                    leftCell += widths(j)
                Next j
                hGeneral += hRow
            Next row

            'hyperlink
            gr.Font = New Font("Arial", 8, FontStyle.Underline)
            gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Near)
            gr.BackColor = Color.Transparent
            Dim hLink As String = "Show Main Report..."
            brick = gr.DrawString(hLink, Color.Blue, New RectangleF(0, hGeneral + textHeight, gr.MeasureString(hLink).Width + 5, textHeight), BorderSide.None)
            brick.ID = "Main"
            brick.Value = brick.ID
            brick.Url = "empty"
            brick.CanPublish = False

            CreatePageHeader(gr, reportName, imgTitle, Color.FromArgb(41, 113, 182))
            CreatePageFooter(gr)

            ps.End()
        End Sub
    End Class
End Namespace

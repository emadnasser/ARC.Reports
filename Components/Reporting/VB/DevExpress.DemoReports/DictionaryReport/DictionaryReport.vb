Imports System
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports System.Collections.Generic
Imports DevExpress.XtraPrinting

Namespace XtraReportsDemos.DictionaryReport
    Public Class Report
        Inherits XtraReport

        #Region "Designer generated code"

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private labelWord As DevExpress.XtraReports.UI.XRLabel
        Private labelFirstLetter As DevExpress.XtraReports.UI.XRLabel
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private WithEvents labelRangeTopMargin As DevExpress.XtraReports.UI.XRLabel
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private labelRangeBottomMargin As DevExpress.XtraReports.UI.XRLabel

        #End Region

        Private ReadOnly dictionaryFileName As String

        Public Sub New(ByVal dictionaryFileName As String)
            Me.New()
            Me.dictionaryFileName = dictionaryFileName
            Name = Path.GetFileNameWithoutExtension(dictionaryFileName)
        End Sub

        Public Sub New()
            InitializeComponent()
            labelWord.DataBindings.Add("Text", Nothing, "Word")

            labelRangeTopMargin.DataBindings.Add("Text", Nothing, "Word")
            labelRangeBottomMargin.DataBindings.Add("Text", Nothing, "Word")

            labelFirstLetter.DataBindings.Add("Text", Nothing, "FirstLetter")
            labelFirstLetter.DataBindings.Add("Bookmark", Nothing, "FirstLetter")

            GroupHeader1.GroupFields.Add(New GroupField("FirstLetter", XRColumnSortOrder.Ascending))
            Detail.SortFields.Add(New GroupField("Word", XRColumnSortOrder.Ascending))
        End Sub

        Private Sub DictionaryReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            If String.IsNullOrEmpty(dictionaryFileName) Then
                Return
            End If
            Using dictionaryFile As FileStream = File.OpenRead(dictionaryFileName)
                Dim words As New List(Of WordInfo)(180000)
                Using reader As New StreamReader(dictionaryFile)
                    Do While Not reader.EndOfStream
                        Dim word As String = reader.ReadLine()
                        If Not String.IsNullOrEmpty(word) Then
                            words.Add(New WordInfo(word))
                        End If
                    Loop
                End Using
                DataSource = words
            End Using
        End Sub

        Private Sub InitializeComponent()
'            #Region "Designer generated code"

            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.labelWord = New DevExpress.XtraReports.UI.XRLabel()
            Me.labelFirstLetter = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.labelRangeTopMargin = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.labelRangeBottomMargin = New DevExpress.XtraReports.UI.XRLabel()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.labelWord})
            Me.Detail.Height = 31
            Me.Detail.MultiColumn.ColumnCount = 3
            Me.Detail.MultiColumn.Layout = ColumnLayout.AcrossThenDown
            Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' labelWord
            ' 
            Me.labelWord.BackColor = System.Drawing.Color.Transparent
            Me.labelWord.BookmarkParent = Me.labelFirstLetter
            Me.labelWord.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(240)))), (CInt((CByte(240)))))
            Me.labelWord.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.labelWord.CanGrow = False
            Me.labelWord.Font = New System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.labelWord.Location = New System.Drawing.Point(0, 0)
            Me.labelWord.Name = "labelWord"
            Me.labelWord.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F)
            Me.labelWord.Size = New System.Drawing.Size(208, 25)
            Me.labelWord.Text = "cat"
            Me.labelWord.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' labelFirstLetter
            ' 
            Me.labelFirstLetter.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(58)))), (CInt((CByte(118)))), (CInt((CByte(148)))))
            Me.labelFirstLetter.CanGrow = False
            Me.labelFirstLetter.Font = New System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.labelFirstLetter.ForeColor = System.Drawing.Color.White
            Me.labelFirstLetter.Location = New System.Drawing.Point(0, 0)
            Me.labelFirstLetter.Name = "labelFirstLetter"
            Me.labelFirstLetter.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.labelFirstLetter.Size = New System.Drawing.Size(30, 30)
            Me.labelFirstLetter.Text = "A"
            Me.labelFirstLetter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.labelFirstLetter})
            Me.GroupHeader1.Height = 36
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.labelRangeTopMargin})
            Me.TopMargin.Height = 31
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' labelRangeTopMargin
            ' 
            Me.labelRangeTopMargin.Font = New System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.labelRangeTopMargin.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(58)))), (CInt((CByte(118)))), (CInt((CByte(148)))))
            Me.labelRangeTopMargin.Location = New System.Drawing.Point(0, 0)
            Me.labelRangeTopMargin.Name = "labelRangeTopMargin"
            Me.labelRangeTopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.labelRangeTopMargin.Size = New System.Drawing.Size(650, 25)
            Me.labelRangeTopMargin.Text = "cat - dog"
            Me.labelRangeTopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.labelRangeBottomMargin})
            Me.BottomMargin.Height = 2
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' labelRangeBottomMargin
            ' 
            Me.labelRangeBottomMargin.Font = New System.Drawing.Font("Tahoma", 9.75F)
            Me.labelRangeBottomMargin.Location = New System.Drawing.Point(0, 0)
            Me.labelRangeBottomMargin.Name = "labelRangeBottomMargin"
            Me.labelRangeBottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.labelRangeBottomMargin.Size = New System.Drawing.Size(650, 2)
            Me.labelRangeBottomMargin.Text = "cat - dog"
            Me.labelRangeBottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' DictionaryReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.GroupHeader1, Me.TopMargin, Me.BottomMargin})
            Me.Margins = New System.Drawing.Printing.Margins(100, 100, 31, 2)
            Me.Version = "8.1"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

'            #End Region
        End Sub

        Private Sub labelRangeTopMargin_PrintOnPage(ByVal sender As Object, ByVal e As PrintOnPageEventArgs) Handles labelRangeTopMargin.PrintOnPage
            If String.IsNullOrEmpty(dictionaryFileName) Then
                Return
            End If
            Dim page As Page = Pages(e.PageIndex)
            For Each brick As VisualBrick In page
                If Object.ReferenceEquals(brick.BrickOwner, labelRangeBottomMargin) Then
                    labelRangeTopMargin.Text &= " - " & brick.Text
                    brick.Text = String.Empty
                    Return
                End If
            Next brick
        End Sub

        Protected Overrides Sub OnAfterPrint(ByVal e As EventArgs)
            If String.IsNullOrEmpty(dictionaryFileName) Then
                Return
            End If
            MyBase.OnAfterPrint(e)
            Dim band As Band = Bands(BandKind.BottomMargin)
            band.Controls.Clear()
            band = Bands(BandKind.TopMargin)
            band.Controls.Clear()
        End Sub
    End Class
End Namespace

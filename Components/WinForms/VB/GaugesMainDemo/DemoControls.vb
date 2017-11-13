Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraGauges.Core.Printing
Imports DevExpress.XtraGauges.Win
Imports DevExpress.Tutorials

Namespace DevExpress.XtraGauges.Demos
    Public Class TutorialControl
        Inherits TutorialControlBase
        Public Overridable ReadOnly Property ShowExportMenu() As Boolean
            Get
                Return False
            End Get
        End Property
        Public Overridable ReadOnly Property ExportControl() As GaugeControl
            Get
                Return Nothing
            End Get
        End Property
#Region "Print and Export"
        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.Image Or ExportFormats.XLS, True)
        End Sub
        Public Overrides ReadOnly Property AllowPrintOptions() As Boolean
            Get
                Return ExportControl IsNot Nothing
            End Get
        End Property
        Protected Overrides Sub ExportToImage()
            If ExportControl Is Nothing Then
                Return
            End If
            Dim fileName As String = MainFormHelper.GetFileName("", "BMP Image (*.bmp)|*.bmp|GIF Image (*.gif)|*.gif|PNG Image (*.png)|*.png|JPEG Image (*.jpeg)|*.jpeg")
            If (Not String.IsNullOrEmpty(fileName)) Then
                Dim extansion() As String = fileName.Split("."c)
                Select Case extansion(extansion.Length - 1)
                    Case "bmp"
                        ExportControl.ExportToImage(fileName, System.Drawing.Imaging.ImageFormat.Bmp)
                    Case "gif"
                        ExportControl.ExportToImage(fileName, System.Drawing.Imaging.ImageFormat.Gif)
                    Case "png"
                        ExportControl.ExportToImage(fileName, System.Drawing.Imaging.ImageFormat.Png)
                    Case "jpeg"
                        ExportControl.ExportToImage(fileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Case Else
                        ExportControl.ExportToImage(fileName, System.Drawing.Imaging.ImageFormat.Png)
                End Select
            End If
        End Sub
        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            If ExportControl Is Nothing Then
                Return
            End If
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            If ext = "pdf" Then
                ExportControl.ExportToPdf(filename)
            End If
            If ext = "mht" Then
                ExportControl.ExportToMht(filename)
            End If
            If ext = "html" Then
                ExportControl.ExportToHtml(filename)
            End If
            If ext = "xls" Then
                ExportControl.ExportToXls(filename)
            End If
            Cursor.Current = currentCursor
        End Sub
        Protected Overrides Sub ExportToPDF()
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf")
        End Sub
        Protected Overrides Sub ExportToHTML()
            ExportTo("html", "HTML document (*.html)|*.html")
        End Sub
        Protected Overrides Sub ExportToMHT()
            ExportTo("mht", "MHT document (*.mht)|*.mht")
        End Sub
        Protected Overrides Sub ExportToXLS()
            ExportTo("xls", "XLS document (*.xls)|*.xls")
        End Sub
        Protected Overrides Sub PrintPreview()
            If ExportControl IsNot Nothing Then
                If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
                    Me.ExportControl.ShowRibbonPrintPreview(PrintSizeMode.None)
                Else
                    ExportControl.ShowPrintPreview(PrintSizeMode.None)
                End If
            End If
        End Sub
#End Region
    End Class
    Public Class GaugesRibbonMenuManager
        Inherits RibbonMenuManager
        Public Sub New(ByVal parentForm As RibbonMainForm)
            MyBase.New(parentForm)
        End Sub
    End Class
End Namespace

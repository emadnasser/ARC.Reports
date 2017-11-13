Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraEditors.Repository
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.Extensions
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.Design
Imports DevExpress.Utils

Namespace XtraReportsDemos
    ''' <summary>
    ''' Summary description for ModuleControl.
    ''' </summary>
    Public Class PreviewControl
        Inherits ModuleControl

        Protected Class DemoReportExtension
            Inherits ReportDesignExtension

            Protected Function CreateRepositoryItemImageComboBox(ByVal names() As String, ByVal valuesShift As Integer) As RepositoryItem
                Dim item As New RepositoryItemImageComboBox()
                Dim values() As Object = CreateValues(valuesShift, names.Length)
                Dim i As Integer = 0
                Do While i < values.Length AndAlso i < names.Length
                    item.Items.Add(New ImageComboBoxItem(names(i), values(i)))
                    i += 1
                Loop
                Return item
            End Function

            Private Function CreateValues(ByVal valuesShift As Integer, ByVal count As Integer) As Object()
                Dim values As New List(Of Object)()
                For i As Integer = valuesShift To (valuesShift + count) - 1
                    values.Add(i)
                Next i
                Return values.ToArray()
            End Function
        End Class

        Protected Class CustomDocumentViewer
            Inherits DocumentViewer

            Protected Overrides Sub OnViewKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
                If e.KeyCode = Keys.H AndAlso e.Modifiers.HasFlag(Keys.Control) AndAlso e.Modifiers.HasFlag(Keys.Shift) Then
                    If PrintingSystem IsNot Nothing Then
                        PrintingSystem.HighlightIntersectedBricks(Color.Red)
                        Invalidate(True)
                    End If
                Else
                    MyBase.OnViewKeyDown(sender, e)
                End If
            End Sub
        End Class

        Protected panelControl1 As DevExpress.XtraEditors.PanelControl
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private printPreviewBarItem1 As PrintPreviewBarItem
        Private documentViewerRibbonController1 As DocumentViewerRibbonController
        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Private printPreviewStaticItem1 As PrintPreviewStaticItem
        Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
        Private progressBarEditItem1 As ProgressBarEditItem
        Private repositoryItemProgressBar1 As RepositoryItemProgressBar
        Private printPreviewBarItem48 As PrintPreviewBarItem
        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private printPreviewStaticItem2 As PrintPreviewStaticItem
        Private zoomTrackBarEditItem1 As ZoomTrackBarEditItem
        Private repositoryItemZoomTrackBar1 As RepositoryItemZoomTrackBar
        Private printPreviewBarItem2 As PrintPreviewBarItem
        Private printPreviewBarItem4 As PrintPreviewBarItem
        Private printPreviewBarItem3 As PrintPreviewBarItem
        Private printPreviewBarItem5 As PrintPreviewBarItem
        Private printPreviewBarItem6 As PrintPreviewBarItem
        Private printPreviewBarItem7 As PrintPreviewBarItem
        Private printPreviewBarItem9 As PrintPreviewBarItem
        Private printPreviewBarItem10 As PrintPreviewBarItem
        Private printPreviewBarItem11 As PrintPreviewBarItem
        Private printPreviewBarItem12 As PrintPreviewBarItem
        Private printPreviewBarItem13 As PrintPreviewBarItem
        Private printPreviewBarItem14 As PrintPreviewBarItem
        Private printPreviewBarItem15 As PrintPreviewBarItem
        Private printPreviewBarItem16 As PrintPreviewBarItem
        Private printPreviewBarItem17 As PrintPreviewBarItem
        Private printPreviewBarItem18 As PrintPreviewBarItem
        Private printPreviewBarItem19 As PrintPreviewBarItem
        Private printPreviewBarItem20 As PrintPreviewBarItem
        Private printPreviewBarItem21 As PrintPreviewBarItem
        Private printPreviewBarItem22 As PrintPreviewBarItem
        Private printPreviewBarItem23 As PrintPreviewBarItem
        Private printPreviewBarItem24 As PrintPreviewBarItem
        Private printPreviewBarItem25 As PrintPreviewBarItem
        Private printPreviewBarItem26 As PrintPreviewBarItem
        Private printPreviewBarItem27 As PrintPreviewBarItem
        Private printPreviewBarItem28 As PrintPreviewBarItem
        Private printPreviewBarItem29 As PrintPreviewBarItem
        Private printPreviewBarItem30 As PrintPreviewBarItem
        Private printPreviewBarItem31 As PrintPreviewBarItem
        Private printPreviewBarItem32 As PrintPreviewBarItem
        Private printPreviewBarItem33 As PrintPreviewBarItem
        Private printPreviewBarItem34 As PrintPreviewBarItem
        Private printPreviewBarItem35 As PrintPreviewBarItem
        Private printPreviewBarItem36 As PrintPreviewBarItem
        Private printPreviewBarItem37 As PrintPreviewBarItem
        Private printPreviewBarItem38 As PrintPreviewBarItem
        Private printPreviewBarItem39 As PrintPreviewBarItem
        Private printPreviewBarItem40 As PrintPreviewBarItem
        Private printPreviewBarItem41 As PrintPreviewBarItem
        Private printPreviewBarItem42 As PrintPreviewBarItem
        Private printPreviewBarItem43 As PrintPreviewBarItem
        Private printPreviewBarItem44 As PrintPreviewBarItem
        Private printPreviewBarItem45 As PrintPreviewBarItem
        Private printPreviewBarItem46 As PrintPreviewBarItem
        Private printPreviewBarItem47 As PrintPreviewBarItem
        Private ribbonPage1 As PrintPreviewRibbonPage
        Private printPreviewRibbonPageGroup1 As PrintPreviewRibbonPageGroup
        Private printPreviewRibbonPageGroup2 As PrintPreviewRibbonPageGroup
        Private printPreviewRibbonPageGroup3 As PrintPreviewRibbonPageGroup
        Private printPreviewRibbonPageGroup4 As PrintPreviewRibbonPageGroup
        Private printPreviewRibbonPageGroup5 As PrintPreviewRibbonPageGroup
        Private printPreviewRibbonPageGroup6 As PrintPreviewRibbonPageGroup
        Private printPreviewRibbonPageGroup7 As PrintPreviewRibbonPageGroup
        Private printPreviewRibbonPageGroup8 As PrintPreviewRibbonPageGroup
        Protected printControl As CustomDocumentViewer
        Protected WithEvents barButtonItem2 As DevExpress.XtraBars.BarButtonItem
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private components As System.ComponentModel.IContainer
        Private fReport As XtraReport
        Private printPreviewBarItem8 As PrintPreviewBarItem
        Private fileName As String = String.Empty

        Public Sub New()
            InitializeComponent()
            If Not documentViewerRibbonController1.AllowDefaultSvgImages.ToBoolean(WindowsFormsSettings.GetAllowDefaultSvgImages()) Then
                Me.barButtonItem2.ImageUri.Uri = String.Empty
            End If
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If fReport IsNot Nothing Then
                    fReport.Dispose()
                    fReport = Nothing
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        Public Overrides Sub Activate()
            If Report IsNot Nothing OrElse DesignMode Then
                Return
            End If

            Dim navigationDockPanel As DevExpress.XtraBars.Docking.DockPanel = printControl.DockManager.Panels(New System.Guid("6b2e64eb-afd0-4676-bc3d-eca7e99946aa"))
            If navigationDockPanel IsNot Nothing Then
                navigationDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
            End If

            System.ComponentModel.DXDisplayNameAttribute.UseResourceManager = True
            Report = CreateReport()

            Report.ReportPrintOptions.DetailCountAtDesignTime = 0
            For Each item As XtraReportBase In Report.AllControls(Of XtraReportBase)()
                item.ReportPrintOptions.DetailCountAtDesignTime = 0
            Next item

            Report.CreateDocument(True)
            Try
                File.Delete(fileName)
            Catch e1 As UnauthorizedAccessException
            End Try
        End Sub
        Protected Overridable Function CreateReport() As XtraReport
            Throw New InvalidOperationException()
        End Function
        Protected Property Report() As XtraReport
            Get
                Return fReport
            End Get
            Set(ByVal value As XtraReport)
                If fReport IsNot value Then
                    If fReport IsNot Nothing Then
                        fReport.Dispose()
                    End If
                    fReport = value
                    If fReport Is Nothing Then
                        Return
                    End If
                    Invalidate()
                    Update()
                    fileName = GetReportPath(fReport, "repx")
                    Me.printControl.PrintingSystem = fReport.PrintingSystem
                    fReport.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, DevExpress.XtraPrinting.CommandVisibility.None)
                End If
            End Set
        End Property
        #Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        ''' 
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim superToolTip1 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem1 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem1 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip2 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem2 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem2 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip3 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem3 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem3 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip4 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem4 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem4 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip5 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem5 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem5 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip6 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem6 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem6 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip7 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem7 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem7 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip8 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem8 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem8 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip9 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem9 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem9 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip10 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem10 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem10 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip11 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem11 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem11 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip12 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem12 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem12 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip13 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem13 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem13 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip14 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem14 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem14 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip15 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem15 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem15 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip16 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem16 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem16 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip17 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem17 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem17 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip18 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem18 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem18 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip19 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem19 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem19 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip20 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem20 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem20 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip21 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem21 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem21 As New DevExpress.Utils.ToolTipItem()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(PreviewControl))
            Dim superToolTip22 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem22 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem22 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip23 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem23 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem23 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip24 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem24 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem24 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip25 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem25 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem25 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip26 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem26 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem26 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip27 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem27 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem27 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip28 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem28 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem28 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip29 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem29 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem29 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip30 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem30 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem30 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip31 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem31 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem31 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip32 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem32 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem32 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip33 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem33 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem33 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip34 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem34 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem34 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip35 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem35 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem35 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip36 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem36 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem36 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip37 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem37 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem37 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip38 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem38 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem38 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip39 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem39 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem39 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip40 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem40 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem40 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip41 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem41 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem41 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip42 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem42 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem42 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip43 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem43 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem43 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip44 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem44 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem44 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip45 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem45 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem45 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip46 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem46 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem46 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip47 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem47 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem47 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip48 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem48 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem48 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip49 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem49 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem49 As New DevExpress.Utils.ToolTipItem()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.printPreviewBarItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.documentViewerRibbonController1 = New DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController(Me.components)
            Me.printControl = New XtraReportsDemos.PreviewControl.CustomDocumentViewer()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.printPreviewStaticItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
            Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
            Me.progressBarEditItem1 = New DevExpress.XtraPrinting.Preview.ProgressBarEditItem()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.printPreviewBarItem48 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.printPreviewStaticItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
            Me.zoomTrackBarEditItem1 = New DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem()
            Me.repositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
            Me.printPreviewBarItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem3 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem4 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem5 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem6 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem7 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem9 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem10 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem11 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem12 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem13 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem14 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem15 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem16 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem17 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem18 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem19 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem20 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem21 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem22 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem23 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem24 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem25 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem26 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem27 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem28 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem29 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem30 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem31 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem32 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem33 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem34 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem35 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem36 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem37 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem38 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem39 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem40 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem41 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem42 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem43 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem44 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem45 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem46 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem47 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.printPreviewBarItem8 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.ribbonPage1 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.printPreviewRibbonPageGroup1 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup2 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup3 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup4 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup5 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup6 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup7 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup8 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentViewerRibbonController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.printPreviewBarItem1, Me.printPreviewBarItem2, Me.printPreviewBarItem3, Me.printPreviewBarItem4, Me.printPreviewBarItem5, Me.printPreviewBarItem6, Me.printPreviewBarItem7, Me.printPreviewBarItem9, Me.printPreviewBarItem10, Me.printPreviewBarItem11, Me.printPreviewBarItem12, Me.printPreviewBarItem13, Me.printPreviewBarItem14, Me.printPreviewBarItem15, Me.printPreviewBarItem16, Me.printPreviewBarItem17, Me.printPreviewBarItem18, Me.printPreviewBarItem19, Me.printPreviewBarItem20, Me.printPreviewBarItem21, Me.printPreviewBarItem22, Me.printPreviewBarItem23, Me.printPreviewBarItem24, Me.printPreviewBarItem25, Me.printPreviewBarItem26, Me.printPreviewBarItem27, Me.printPreviewBarItem28, Me.printPreviewBarItem29, Me.printPreviewBarItem30, Me.printPreviewBarItem31, Me.printPreviewBarItem32, Me.printPreviewBarItem33, Me.printPreviewBarItem34, Me.printPreviewBarItem35, Me.printPreviewBarItem36, Me.printPreviewBarItem37, Me.printPreviewBarItem38, Me.printPreviewBarItem39, Me.printPreviewBarItem40, Me.printPreviewBarItem41, Me.printPreviewBarItem42, Me.printPreviewBarItem43, Me.printPreviewBarItem44, Me.printPreviewBarItem45, Me.printPreviewBarItem46, Me.printPreviewBarItem47, Me.printPreviewStaticItem1, Me.barStaticItem1, Me.progressBarEditItem1, Me.printPreviewBarItem48, Me.barButtonItem1, Me.printPreviewStaticItem2, Me.zoomTrackBarEditItem1, Me.barButtonItem2, Me.printPreviewBarItem8})
            Me.ribbonControl1.Location = New System.Drawing.Point(2, 2)
            Me.ribbonControl1.MaxItemId = 60
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemProgressBar1, Me.repositoryItemZoomTrackBar1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1112, 116)
            Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
            Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            Me.ribbonControl1.TransparentEditors = True
            ' 
            ' printPreviewBarItem1
            ' 
            Me.printPreviewBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem1.Caption = "Bookmarks"
            Me.printPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap
            Me.printPreviewBarItem1.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem1.Enabled = False
            Me.printPreviewBarItem1.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_DocumentMap
            Me.printPreviewBarItem1.Id = 1
            Me.printPreviewBarItem1.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_DocumentMapLarge
            Me.printPreviewBarItem1.Name = "printPreviewBarItem1"
            superToolTip1.FixedTooltipWidth = True
            toolTipTitleItem1.Text = "Document Map"
            toolTipItem1.LeftIndent = 6
            toolTipItem1.Text = "Open the Document Map, which allows you to navigate through a structural view of " & "the document."
            superToolTip1.Items.Add(toolTipTitleItem1)
            superToolTip1.Items.Add(toolTipItem1)
            superToolTip1.MaxWidth = 210
            Me.printPreviewBarItem1.SuperTip = superToolTip1
            ' 
            ' documentViewerRibbonController1
            ' 
            Me.documentViewerRibbonController1.DocumentViewer = Me.printControl
            Me.documentViewerRibbonController1.RibbonControl = Me.ribbonControl1
            Me.documentViewerRibbonController1.RibbonStatusBar = Me.ribbonStatusBar1
            ' 
            ' printControl
            ' 
            Me.printControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.printControl.IsMetric = False
            Me.printControl.Location = New System.Drawing.Point(2, 118)
            Me.printControl.Name = "printControl"
            Me.printControl.Size = New System.Drawing.Size(1112, 327)
            Me.printControl.TabIndex = 1
            Me.printControl.TabStop = False
            ' 
            ' ribbonStatusBar1
            ' 
            Me.ribbonStatusBar1.ItemLinks.Add(Me.printPreviewStaticItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.barStaticItem1, True)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.progressBarEditItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.printPreviewBarItem48)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.barButtonItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.printPreviewStaticItem2)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.zoomTrackBarEditItem1)
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(2, 445)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1112, 27)
            ' 
            ' printPreviewStaticItem1
            ' 
            Me.printPreviewStaticItem1.Caption = "Nothing"
            Me.printPreviewStaticItem1.Id = 48
            Me.printPreviewStaticItem1.LeftIndent = 1
            Me.printPreviewStaticItem1.Name = "printPreviewStaticItem1"
            Me.printPreviewStaticItem1.RightIndent = 1
            Me.printPreviewStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
            Me.printPreviewStaticItem1.Type = "PageOfPages"
            ' 
            ' barStaticItem1
            ' 
            Me.barStaticItem1.Id = 49
            Me.barStaticItem1.Name = "barStaticItem1"
            Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
            Me.barStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
            ' 
            ' progressBarEditItem1
            ' 
            Me.progressBarEditItem1.ContextSpecifier = Me.documentViewerRibbonController1
            Me.progressBarEditItem1.Edit = Me.repositoryItemProgressBar1
            Me.progressBarEditItem1.EditHeight = 12
            Me.progressBarEditItem1.EditWidth = 150
            Me.progressBarEditItem1.Id = 50
            Me.progressBarEditItem1.Name = "progressBarEditItem1"
            Me.progressBarEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' repositoryItemProgressBar1
            ' 
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            ' 
            ' printPreviewBarItem48
            ' 
            Me.printPreviewBarItem48.Caption = "Stop"
            Me.printPreviewBarItem48.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding
            Me.printPreviewBarItem48.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem48.Enabled = False
            Me.printPreviewBarItem48.Hint = "Stop"
            Me.printPreviewBarItem48.Id = 51
            Me.printPreviewBarItem48.Name = "printPreviewBarItem48"
            Me.printPreviewBarItem48.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.barButtonItem1.Enabled = False
            Me.barButtonItem1.Id = 52
            Me.barButtonItem1.Name = "barButtonItem1"
            Me.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
            ' 
            ' printPreviewStaticItem2
            ' 
            Me.printPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.printPreviewStaticItem2.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
            Me.printPreviewStaticItem2.Caption = "100%"
            Me.printPreviewStaticItem2.Id = 53
            Me.printPreviewStaticItem2.Name = "printPreviewStaticItem2"
            Me.printPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
            Me.printPreviewStaticItem2.Type = "ZoomFactorText"
            ' 
            ' zoomTrackBarEditItem1
            ' 
            Me.zoomTrackBarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.zoomTrackBarEditItem1.ContextSpecifier = Me.documentViewerRibbonController1
            Me.zoomTrackBarEditItem1.Edit = Me.repositoryItemZoomTrackBar1
            Me.zoomTrackBarEditItem1.EditValue = 90
            Me.zoomTrackBarEditItem1.EditWidth = 140
            Me.zoomTrackBarEditItem1.Enabled = False
            Me.zoomTrackBarEditItem1.Id = 54
            Me.zoomTrackBarEditItem1.Name = "zoomTrackBarEditItem1"
            Me.zoomTrackBarEditItem1.Range = New Integer() { 10, 500}
            ' 
            ' repositoryItemZoomTrackBar1
            ' 
            Me.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center
            Me.repositoryItemZoomTrackBar1.AllowFocused = False
            Me.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemZoomTrackBar1.Maximum = 180
            Me.repositoryItemZoomTrackBar1.Middle = 90
            Me.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1"
            Me.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            ' 
            ' printPreviewBarItem2
            ' 
            Me.printPreviewBarItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem2.Caption = "Parameters"
            Me.printPreviewBarItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters
            Me.printPreviewBarItem2.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem2.Enabled = False
            Me.printPreviewBarItem2.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Parameters
            Me.printPreviewBarItem2.Id = 2
            Me.printPreviewBarItem2.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ParametersLarge
            Me.printPreviewBarItem2.Name = "printPreviewBarItem2"
            superToolTip2.FixedTooltipWidth = True
            toolTipTitleItem2.Text = "Parameters"
            toolTipItem2.LeftIndent = 6
            toolTipItem2.Text = "Open the Parameters pane, which allows you to enter values for report parameters." & ""
            superToolTip2.Items.Add(toolTipTitleItem2)
            superToolTip2.Items.Add(toolTipItem2)
            superToolTip2.MaxWidth = 210
            Me.printPreviewBarItem2.SuperTip = superToolTip2
            ' 
            ' printPreviewBarItem3
            ' 
            Me.printPreviewBarItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem3.Caption = "Find"
            Me.printPreviewBarItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find
            Me.printPreviewBarItem3.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem3.Enabled = False
            Me.printPreviewBarItem3.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Find
            Me.printPreviewBarItem3.Id = 3
            Me.printPreviewBarItem3.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_FindLarge
            Me.printPreviewBarItem3.Name = "printPreviewBarItem3"
            superToolTip3.FixedTooltipWidth = True
            toolTipTitleItem3.Text = "Find"
            toolTipItem3.LeftIndent = 6
            toolTipItem3.Text = "Show the Find dialog to find text in the document."
            superToolTip3.Items.Add(toolTipTitleItem3)
            superToolTip3.Items.Add(toolTipItem3)
            superToolTip3.MaxWidth = 210
            Me.printPreviewBarItem3.SuperTip = superToolTip3
            ' 
            ' printPreviewBarItem4
            ' 
            Me.printPreviewBarItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem4.Caption = "Thumbnails"
            Me.printPreviewBarItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Thumbnails
            Me.printPreviewBarItem4.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem4.Enabled = False
            Me.printPreviewBarItem4.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Thumbnails
            Me.printPreviewBarItem4.Id = 4
            Me.printPreviewBarItem4.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ThumbnailsLarge
            Me.printPreviewBarItem4.Name = "printPreviewBarItem4"
            superToolTip4.FixedTooltipWidth = True
            toolTipTitleItem4.Text = "Thumbnails"
            toolTipItem4.LeftIndent = 6
            toolTipItem4.Text = "Open the Thumbnails, which allows you to navigate through the document."
            superToolTip4.Items.Add(toolTipTitleItem4)
            superToolTip4.Items.Add(toolTipItem4)
            superToolTip4.MaxWidth = 210
            Me.printPreviewBarItem4.SuperTip = superToolTip4
            ' 
            ' printPreviewBarItem5
            ' 
            Me.printPreviewBarItem5.Caption = "Print"
            Me.printPreviewBarItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print
            Me.printPreviewBarItem5.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem5.Enabled = False
            Me.printPreviewBarItem5.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Print
            Me.printPreviewBarItem5.Id = 5
            Me.printPreviewBarItem5.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_PrintLarge
            Me.printPreviewBarItem5.Name = "printPreviewBarItem5"
            superToolTip5.FixedTooltipWidth = True
            toolTipTitleItem5.Text = "Print (Ctrl+P)"
            toolTipItem5.LeftIndent = 6
            toolTipItem5.Text = "Select a printer, number of copies and other printing options before printing."
            superToolTip5.Items.Add(toolTipTitleItem5)
            superToolTip5.Items.Add(toolTipItem5)
            superToolTip5.MaxWidth = 210
            Me.printPreviewBarItem5.SuperTip = superToolTip5
            ' 
            ' printPreviewBarItem6
            ' 
            Me.printPreviewBarItem6.Caption = "Quick Print"
            Me.printPreviewBarItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect
            Me.printPreviewBarItem6.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem6.Enabled = False
            Me.printPreviewBarItem6.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_PrintDirect
            Me.printPreviewBarItem6.Id = 6
            Me.printPreviewBarItem6.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_PrintDirectLarge
            Me.printPreviewBarItem6.Name = "printPreviewBarItem6"
            superToolTip6.FixedTooltipWidth = True
            toolTipTitleItem6.Text = "Quick Print"
            toolTipItem6.LeftIndent = 6
            toolTipItem6.Text = "Send the document directly to the default printer without making changes."
            superToolTip6.Items.Add(toolTipTitleItem6)
            superToolTip6.Items.Add(toolTipItem6)
            superToolTip6.MaxWidth = 210
            Me.printPreviewBarItem6.SuperTip = superToolTip6
            ' 
            ' printPreviewBarItem7
            ' 
            Me.printPreviewBarItem7.Caption = "Custom Margins..."
            Me.printPreviewBarItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup
            Me.printPreviewBarItem7.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem7.Enabled = False
            Me.printPreviewBarItem7.Id = 7
            Me.printPreviewBarItem7.Name = "printPreviewBarItem7"
            superToolTip7.FixedTooltipWidth = True
            toolTipTitleItem7.Text = "Page Setup"
            toolTipItem7.LeftIndent = 6
            toolTipItem7.Text = "Show the Page Setup dialog."
            superToolTip7.Items.Add(toolTipTitleItem7)
            superToolTip7.Items.Add(toolTipItem7)
            superToolTip7.MaxWidth = 210
            Me.printPreviewBarItem7.SuperTip = superToolTip7
            ' 
            ' printPreviewBarItem9
            ' 
            Me.printPreviewBarItem9.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem9.Caption = "Scale"
            Me.printPreviewBarItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale
            Me.printPreviewBarItem9.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem9.Enabled = False
            Me.printPreviewBarItem9.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Scale
            Me.printPreviewBarItem9.Id = 9
            Me.printPreviewBarItem9.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ScaleLarge
            Me.printPreviewBarItem9.Name = "printPreviewBarItem9"
            superToolTip8.FixedTooltipWidth = True
            toolTipTitleItem8.Text = "Scale"
            toolTipItem8.LeftIndent = 6
            toolTipItem8.Text = "Stretch or shrink the printed output to a percentage of its actual size."
            superToolTip8.Items.Add(toolTipTitleItem8)
            superToolTip8.Items.Add(toolTipItem8)
            superToolTip8.MaxWidth = 210
            Me.printPreviewBarItem9.SuperTip = superToolTip8
            ' 
            ' printPreviewBarItem10
            ' 
            Me.printPreviewBarItem10.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem10.Caption = "Pointer"
            Me.printPreviewBarItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Pointer
            Me.printPreviewBarItem10.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem10.Down = True
            Me.printPreviewBarItem10.Enabled = False
            Me.printPreviewBarItem10.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Pointer
            Me.printPreviewBarItem10.GroupIndex = 1
            Me.printPreviewBarItem10.Id = 10
            Me.printPreviewBarItem10.Name = "printPreviewBarItem10"
            Me.printPreviewBarItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            superToolTip9.FixedTooltipWidth = True
            toolTipTitleItem9.Text = "Mouse Pointer"
            toolTipItem9.LeftIndent = 6
            toolTipItem9.Text = "Show the mouse pointer."
            superToolTip9.Items.Add(toolTipTitleItem9)
            superToolTip9.Items.Add(toolTipItem9)
            superToolTip9.MaxWidth = 210
            Me.printPreviewBarItem10.SuperTip = superToolTip9
            ' 
            ' printPreviewBarItem11
            ' 
            Me.printPreviewBarItem11.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem11.Caption = "Hand Tool"
            Me.printPreviewBarItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool
            Me.printPreviewBarItem11.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem11.Enabled = False
            Me.printPreviewBarItem11.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_HandTool
            Me.printPreviewBarItem11.GroupIndex = 1
            Me.printPreviewBarItem11.Id = 11
            Me.printPreviewBarItem11.Name = "printPreviewBarItem11"
            Me.printPreviewBarItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            superToolTip10.FixedTooltipWidth = True
            toolTipTitleItem10.Text = "Hand Tool"
            toolTipItem10.LeftIndent = 6
            toolTipItem10.Text = "Invoke the Hand tool to manually scroll through pages."
            superToolTip10.Items.Add(toolTipTitleItem10)
            superToolTip10.Items.Add(toolTipItem10)
            superToolTip10.MaxWidth = 210
            Me.printPreviewBarItem11.SuperTip = superToolTip10
            ' 
            ' printPreviewBarItem12
            ' 
            Me.printPreviewBarItem12.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem12.Caption = "Magnifier"
            Me.printPreviewBarItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier
            Me.printPreviewBarItem12.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem12.Enabled = False
            Me.printPreviewBarItem12.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Magnifier
            Me.printPreviewBarItem12.GroupIndex = 1
            Me.printPreviewBarItem12.Id = 12
            Me.printPreviewBarItem12.Name = "printPreviewBarItem12"
            Me.printPreviewBarItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            superToolTip11.FixedTooltipWidth = True
            toolTipTitleItem11.Text = "Magnifier"
            toolTipItem11.LeftIndent = 6
            toolTipItem11.Text = "Invoke the Magnifier tool." & ControlChars.CrLf & ControlChars.CrLf & "Clicking once on a document zooms it so that a sing" & "le page becomes entirely visible, while clicking another time zooms it to 100% o" & "f the normal size."
            superToolTip11.Items.Add(toolTipTitleItem11)
            superToolTip11.Items.Add(toolTipItem11)
            superToolTip11.MaxWidth = 210
            Me.printPreviewBarItem12.SuperTip = superToolTip11
            ' 
            ' printPreviewBarItem13
            ' 
            Me.printPreviewBarItem13.Caption = "Zoom Out"
            Me.printPreviewBarItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut
            Me.printPreviewBarItem13.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem13.Enabled = False
            Me.printPreviewBarItem13.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ZoomOut
            Me.printPreviewBarItem13.Id = 13
            Me.printPreviewBarItem13.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ZoomOutLarge
            Me.printPreviewBarItem13.Name = "printPreviewBarItem13"
            superToolTip12.FixedTooltipWidth = True
            toolTipTitleItem12.Text = "Zoom Out"
            toolTipItem12.LeftIndent = 6
            toolTipItem12.Text = "Zoom out to see more of the page at a reduced size."
            superToolTip12.Items.Add(toolTipTitleItem12)
            superToolTip12.Items.Add(toolTipItem12)
            superToolTip12.MaxWidth = 210
            Me.printPreviewBarItem13.SuperTip = superToolTip12
            ' 
            ' printPreviewBarItem14
            ' 
            Me.printPreviewBarItem14.Caption = "Zoom In"
            Me.printPreviewBarItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn
            Me.printPreviewBarItem14.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem14.Enabled = False
            Me.printPreviewBarItem14.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ZoomIn
            Me.printPreviewBarItem14.Id = 14
            Me.printPreviewBarItem14.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ZoomInLarge
            Me.printPreviewBarItem14.Name = "printPreviewBarItem14"
            superToolTip13.FixedTooltipWidth = True
            toolTipTitleItem13.Text = "Zoom In"
            toolTipItem13.LeftIndent = 6
            toolTipItem13.Text = "Zoom in to get a close-up view of the document."
            superToolTip13.Items.Add(toolTipTitleItem13)
            superToolTip13.Items.Add(toolTipItem13)
            superToolTip13.MaxWidth = 210
            Me.printPreviewBarItem14.SuperTip = superToolTip13
            ' 
            ' printPreviewBarItem15
            ' 
            Me.printPreviewBarItem15.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem15.Caption = "Zoom"
            Me.printPreviewBarItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Zoom
            Me.printPreviewBarItem15.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem15.Enabled = False
            Me.printPreviewBarItem15.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Zoom
            Me.printPreviewBarItem15.Id = 15
            Me.printPreviewBarItem15.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ZoomLarge
            Me.printPreviewBarItem15.Name = "printPreviewBarItem15"
            superToolTip14.FixedTooltipWidth = True
            toolTipTitleItem14.Text = "Zoom"
            toolTipItem14.LeftIndent = 6
            toolTipItem14.Text = "Change the zoom level of the document preview."
            superToolTip14.Items.Add(toolTipTitleItem14)
            superToolTip14.Items.Add(toolTipItem14)
            superToolTip14.MaxWidth = 210
            Me.printPreviewBarItem15.SuperTip = superToolTip14
            ' 
            ' printPreviewBarItem16
            ' 
            Me.printPreviewBarItem16.Caption = "First Page"
            Me.printPreviewBarItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage
            Me.printPreviewBarItem16.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem16.Enabled = False
            Me.printPreviewBarItem16.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ShowFirstPage
            Me.printPreviewBarItem16.Id = 16
            Me.printPreviewBarItem16.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ShowFirstPageLarge
            Me.printPreviewBarItem16.Name = "printPreviewBarItem16"
            superToolTip15.FixedTooltipWidth = True
            toolTipTitleItem15.Text = "First Page (Ctrl+Home)"
            toolTipItem15.LeftIndent = 6
            toolTipItem15.Text = "Navigate to the first page of the document."
            superToolTip15.Items.Add(toolTipTitleItem15)
            superToolTip15.Items.Add(toolTipItem15)
            superToolTip15.MaxWidth = 210
            Me.printPreviewBarItem16.SuperTip = superToolTip15
            ' 
            ' printPreviewBarItem17
            ' 
            Me.printPreviewBarItem17.Caption = "Previous Page"
            Me.printPreviewBarItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage
            Me.printPreviewBarItem17.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem17.Enabled = False
            Me.printPreviewBarItem17.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ShowPrevPage
            Me.printPreviewBarItem17.Id = 17
            Me.printPreviewBarItem17.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ShowPrevPageLarge
            Me.printPreviewBarItem17.Name = "printPreviewBarItem17"
            superToolTip16.FixedTooltipWidth = True
            toolTipTitleItem16.Text = "Previous Page (PageUp)"
            toolTipItem16.LeftIndent = 6
            toolTipItem16.Text = "Navigate to the previous page of the document."
            superToolTip16.Items.Add(toolTipTitleItem16)
            superToolTip16.Items.Add(toolTipItem16)
            superToolTip16.MaxWidth = 210
            Me.printPreviewBarItem17.SuperTip = superToolTip16
            ' 
            ' printPreviewBarItem18
            ' 
            Me.printPreviewBarItem18.Caption = "Next  Page "
            Me.printPreviewBarItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage
            Me.printPreviewBarItem18.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem18.Enabled = False
            Me.printPreviewBarItem18.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ShowNextPage
            Me.printPreviewBarItem18.Id = 18
            Me.printPreviewBarItem18.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ShowNextPageLarge
            Me.printPreviewBarItem18.Name = "printPreviewBarItem18"
            superToolTip17.FixedTooltipWidth = True
            toolTipTitleItem17.Text = "Next Page (PageDown)"
            toolTipItem17.LeftIndent = 6
            toolTipItem17.Text = "Navigate to the next page of the document."
            superToolTip17.Items.Add(toolTipTitleItem17)
            superToolTip17.Items.Add(toolTipItem17)
            superToolTip17.MaxWidth = 210
            Me.printPreviewBarItem18.SuperTip = superToolTip17
            ' 
            ' printPreviewBarItem19
            ' 
            Me.printPreviewBarItem19.Caption = "Last  Page "
            Me.printPreviewBarItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage
            Me.printPreviewBarItem19.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem19.Enabled = False
            Me.printPreviewBarItem19.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ShowLastPage
            Me.printPreviewBarItem19.Id = 19
            Me.printPreviewBarItem19.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ShowLastPageLarge
            Me.printPreviewBarItem19.Name = "printPreviewBarItem19"
            superToolTip18.FixedTooltipWidth = True
            toolTipTitleItem18.Text = "Last Page (Ctrl+End)"
            toolTipItem18.LeftIndent = 6
            toolTipItem18.Text = "Navigate to the last page of the document."
            superToolTip18.Items.Add(toolTipTitleItem18)
            superToolTip18.Items.Add(toolTipItem18)
            superToolTip18.MaxWidth = 210
            Me.printPreviewBarItem19.SuperTip = superToolTip18
            ' 
            ' printPreviewBarItem20
            ' 
            Me.printPreviewBarItem20.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem20.Caption = "Many Pages"
            Me.printPreviewBarItem20.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages
            Me.printPreviewBarItem20.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem20.Enabled = False
            Me.printPreviewBarItem20.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_MultiplePages
            Me.printPreviewBarItem20.Id = 20
            Me.printPreviewBarItem20.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_MultiplePagesLarge
            Me.printPreviewBarItem20.Name = "printPreviewBarItem20"
            superToolTip19.FixedTooltipWidth = True
            toolTipTitleItem19.Text = "View Many Pages"
            toolTipItem19.LeftIndent = 6
            toolTipItem19.Text = "Choose the page layout to arrange the document pages in preview."
            superToolTip19.Items.Add(toolTipTitleItem19)
            superToolTip19.Items.Add(toolTipItem19)
            superToolTip19.MaxWidth = 210
            Me.printPreviewBarItem20.SuperTip = superToolTip19
            ' 
            ' printPreviewBarItem21
            ' 
            Me.printPreviewBarItem21.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem21.Caption = "Page Color"
            Me.printPreviewBarItem21.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground
            Me.printPreviewBarItem21.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem21.Enabled = False
            Me.printPreviewBarItem21.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_FillBackground
            Me.printPreviewBarItem21.Id = 21
            Me.printPreviewBarItem21.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_FillBackgroundLarge
            Me.printPreviewBarItem21.Name = "printPreviewBarItem21"
            superToolTip20.FixedTooltipWidth = True
            toolTipTitleItem20.Text = "Background Color"
            toolTipItem20.LeftIndent = 6
            toolTipItem20.Text = "Choose a color for the background of the document pages."
            superToolTip20.Items.Add(toolTipTitleItem20)
            superToolTip20.Items.Add(toolTipItem20)
            superToolTip20.MaxWidth = 210
            Me.printPreviewBarItem21.SuperTip = superToolTip20
            ' 
            ' printPreviewBarItem22
            ' 
            Me.printPreviewBarItem22.Caption = "Watermark"
            Me.printPreviewBarItem22.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark
            Me.printPreviewBarItem22.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem22.Enabled = False
            Me.printPreviewBarItem22.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Watermark
            Me.printPreviewBarItem22.Id = 22
            Me.printPreviewBarItem22.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_WatermarkLarge
            Me.printPreviewBarItem22.Name = "printPreviewBarItem22"
            superToolTip21.FixedTooltipWidth = True
            toolTipTitleItem21.Text = "Watermark"
            toolTipItem21.LeftIndent = 6
            toolTipItem21.Text = "Insert ghosted text or image behind the content of a page." & ControlChars.CrLf & ControlChars.CrLf & "This is often used " & "to indicate that a document is to be treated specially."
            superToolTip21.Items.Add(toolTipTitleItem21)
            superToolTip21.Items.Add(toolTipItem21)
            superToolTip21.MaxWidth = 210
            Me.printPreviewBarItem22.SuperTip = superToolTip21
            ' 
            ' printPreviewBarItem23
            ' 
            Me.printPreviewBarItem23.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem23.Caption = "Export To"
            Me.printPreviewBarItem23.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile
            Me.printPreviewBarItem23.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem23.Enabled = False
            Me.printPreviewBarItem23.Glyph = (CType(resources.GetObject("printPreviewBarItem23.Glyph"), System.Drawing.Image))
            Me.printPreviewBarItem23.Id = 23
            Me.printPreviewBarItem23.LargeGlyph = (CType(resources.GetObject("printPreviewBarItem23.LargeGlyph"), System.Drawing.Image))
            Me.printPreviewBarItem23.Name = "printPreviewBarItem23"
            superToolTip22.FixedTooltipWidth = True
            toolTipTitleItem22.Text = "Export To..."
            toolTipItem22.LeftIndent = 6
            toolTipItem22.Text = "Export the current document in one of the available formats, and save it to the f" & "ile on a disk."
            superToolTip22.Items.Add(toolTipTitleItem22)
            superToolTip22.Items.Add(toolTipItem22)
            superToolTip22.MaxWidth = 210
            Me.printPreviewBarItem23.SuperTip = superToolTip22
            ' 
            ' printPreviewBarItem24
            ' 
            Me.printPreviewBarItem24.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem24.Caption = "E-Mail As"
            Me.printPreviewBarItem24.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile
            Me.printPreviewBarItem24.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem24.Enabled = False
            Me.printPreviewBarItem24.Glyph = (CType(resources.GetObject("printPreviewBarItem24.Glyph"), System.Drawing.Image))
            Me.printPreviewBarItem24.Id = 24
            Me.printPreviewBarItem24.LargeGlyph = (CType(resources.GetObject("printPreviewBarItem24.LargeGlyph"), System.Drawing.Image))
            Me.printPreviewBarItem24.Name = "printPreviewBarItem24"
            superToolTip23.FixedTooltipWidth = True
            toolTipTitleItem23.Text = "E-Mail As..."
            toolTipItem23.LeftIndent = 6
            toolTipItem23.Text = "Export the current document in one of the available formats, and attach it to the" & " e-mail."
            superToolTip23.Items.Add(toolTipTitleItem23)
            superToolTip23.Items.Add(toolTipItem23)
            superToolTip23.MaxWidth = 210
            Me.printPreviewBarItem24.SuperTip = superToolTip23
            ' 
            ' printPreviewBarItem25
            ' 
            Me.printPreviewBarItem25.Caption = "Close"
            Me.printPreviewBarItem25.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview
            Me.printPreviewBarItem25.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem25.Enabled = False
            Me.printPreviewBarItem25.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ClosePreview
            Me.printPreviewBarItem25.Id = 25
            Me.printPreviewBarItem25.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ClosePreviewLarge
            Me.printPreviewBarItem25.Name = "printPreviewBarItem25"
            superToolTip24.FixedTooltipWidth = True
            toolTipTitleItem24.Text = "Close Print Preview"
            toolTipItem24.LeftIndent = 6
            toolTipItem24.Text = "Close Print Preview of the document."
            superToolTip24.Items.Add(toolTipTitleItem24)
            superToolTip24.Items.Add(toolTipItem24)
            superToolTip24.MaxWidth = 210
            Me.printPreviewBarItem25.SuperTip = superToolTip24
            ' 
            ' printPreviewBarItem26
            ' 
            Me.printPreviewBarItem26.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem26.Caption = "Orientation"
            Me.printPreviewBarItem26.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageOrientation
            Me.printPreviewBarItem26.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem26.Enabled = False
            Me.printPreviewBarItem26.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_PageOrientation
            Me.printPreviewBarItem26.Id = 26
            Me.printPreviewBarItem26.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_PageOrientationLarge
            Me.printPreviewBarItem26.Name = "printPreviewBarItem26"
            superToolTip25.FixedTooltipWidth = True
            toolTipTitleItem25.Text = "Page Orientation"
            toolTipItem25.LeftIndent = 6
            toolTipItem25.Text = "Switch the pages between portrait and landscape layouts."
            superToolTip25.Items.Add(toolTipTitleItem25)
            superToolTip25.Items.Add(toolTipItem25)
            superToolTip25.MaxWidth = 210
            Me.printPreviewBarItem26.SuperTip = superToolTip25
            ' 
            ' printPreviewBarItem27
            ' 
            Me.printPreviewBarItem27.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem27.Caption = "Size"
            Me.printPreviewBarItem27.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PaperSize
            Me.printPreviewBarItem27.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem27.Enabled = False
            Me.printPreviewBarItem27.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_PaperSize
            Me.printPreviewBarItem27.Id = 27
            Me.printPreviewBarItem27.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_PaperSizeLarge
            Me.printPreviewBarItem27.Name = "printPreviewBarItem27"
            superToolTip26.FixedTooltipWidth = True
            toolTipTitleItem26.Text = "Page Size"
            toolTipItem26.LeftIndent = 6
            toolTipItem26.Text = "Choose the paper size of the document."
            superToolTip26.Items.Add(toolTipTitleItem26)
            superToolTip26.Items.Add(toolTipItem26)
            superToolTip26.MaxWidth = 210
            Me.printPreviewBarItem27.SuperTip = superToolTip26
            ' 
            ' printPreviewBarItem28
            ' 
            Me.printPreviewBarItem28.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem28.Caption = "Margins"
            Me.printPreviewBarItem28.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageMargins
            Me.printPreviewBarItem28.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem28.Enabled = False
            Me.printPreviewBarItem28.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_PageMargins
            Me.printPreviewBarItem28.Id = 28
            Me.printPreviewBarItem28.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_PageMarginsLarge
            Me.printPreviewBarItem28.Name = "printPreviewBarItem28"
            superToolTip27.FixedTooltipWidth = True
            toolTipTitleItem27.Text = "Page Margins"
            toolTipItem27.LeftIndent = 6
            toolTipItem27.Text = "Select the margin sizes for the entire document." & ControlChars.CrLf & ControlChars.CrLf & "To apply specific margin size" & "s to the document, click Custom Margins."
            superToolTip27.Items.Add(toolTipTitleItem27)
            superToolTip27.Items.Add(toolTipItem27)
            superToolTip27.MaxWidth = 210
            Me.printPreviewBarItem28.SuperTip = superToolTip27
            ' 
            ' printPreviewBarItem29
            ' 
            Me.printPreviewBarItem29.Caption = "PDF File"
            Me.printPreviewBarItem29.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf
            Me.printPreviewBarItem29.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem29.Description = "Adobe Portable Document Format"
            Me.printPreviewBarItem29.Enabled = False
            Me.printPreviewBarItem29.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendPdf
            Me.printPreviewBarItem29.Id = 29
            Me.printPreviewBarItem29.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendPdfLarge
            Me.printPreviewBarItem29.Name = "printPreviewBarItem29"
            superToolTip28.FixedTooltipWidth = True
            toolTipTitleItem28.Text = "E-Mail As PDF"
            toolTipItem28.LeftIndent = 6
            toolTipItem28.Text = "Export the document to PDF and attach it to the e-mail."
            superToolTip28.Items.Add(toolTipTitleItem28)
            superToolTip28.Items.Add(toolTipItem28)
            superToolTip28.MaxWidth = 210
            Me.printPreviewBarItem29.SuperTip = superToolTip28
            ' 
            ' printPreviewBarItem30
            ' 
            Me.printPreviewBarItem30.Caption = "Text File"
            Me.printPreviewBarItem30.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt
            Me.printPreviewBarItem30.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem30.Description = "Plain Text"
            Me.printPreviewBarItem30.Enabled = False
            Me.printPreviewBarItem30.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendTxt
            Me.printPreviewBarItem30.Id = 30
            Me.printPreviewBarItem30.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendTxtLarge
            Me.printPreviewBarItem30.Name = "printPreviewBarItem30"
            superToolTip29.FixedTooltipWidth = True
            toolTipTitleItem29.Text = "E-Mail As Text"
            toolTipItem29.LeftIndent = 6
            toolTipItem29.Text = "Export the document to Text and attach it to the e-mail."
            superToolTip29.Items.Add(toolTipTitleItem29)
            superToolTip29.Items.Add(toolTipItem29)
            superToolTip29.MaxWidth = 210
            Me.printPreviewBarItem30.SuperTip = superToolTip29
            ' 
            ' printPreviewBarItem31
            ' 
            Me.printPreviewBarItem31.Caption = "CSV File"
            Me.printPreviewBarItem31.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv
            Me.printPreviewBarItem31.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem31.Description = "Comma-Separated Values Text"
            Me.printPreviewBarItem31.Enabled = False
            Me.printPreviewBarItem31.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendCsv
            Me.printPreviewBarItem31.Id = 31
            Me.printPreviewBarItem31.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendCsvLarge
            Me.printPreviewBarItem31.Name = "printPreviewBarItem31"
            superToolTip30.FixedTooltipWidth = True
            toolTipTitleItem30.Text = "E-Mail As CSV"
            toolTipItem30.LeftIndent = 6
            toolTipItem30.Text = "Export the document to CSV and attach it to the e-mail."
            superToolTip30.Items.Add(toolTipTitleItem30)
            superToolTip30.Items.Add(toolTipItem30)
            superToolTip30.MaxWidth = 210
            Me.printPreviewBarItem31.SuperTip = superToolTip30
            ' 
            ' printPreviewBarItem32
            ' 
            Me.printPreviewBarItem32.Caption = "MHT File"
            Me.printPreviewBarItem32.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht
            Me.printPreviewBarItem32.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem32.Description = "Single File Web Page"
            Me.printPreviewBarItem32.Enabled = False
            Me.printPreviewBarItem32.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendMht
            Me.printPreviewBarItem32.Id = 32
            Me.printPreviewBarItem32.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendMhtLarge
            Me.printPreviewBarItem32.Name = "printPreviewBarItem32"
            superToolTip31.FixedTooltipWidth = True
            toolTipTitleItem31.Text = "E-Mail As MHT"
            toolTipItem31.LeftIndent = 6
            toolTipItem31.Text = "Export the document to MHT and attach it to the e-mail."
            superToolTip31.Items.Add(toolTipTitleItem31)
            superToolTip31.Items.Add(toolTipItem31)
            superToolTip31.MaxWidth = 210
            Me.printPreviewBarItem32.SuperTip = superToolTip31
            ' 
            ' printPreviewBarItem33
            ' 
            Me.printPreviewBarItem33.Caption = "XLS File"
            Me.printPreviewBarItem33.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls
            Me.printPreviewBarItem33.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem33.Description = "Microsoft Excel 2000-2003 Workbook"
            Me.printPreviewBarItem33.Enabled = False
            Me.printPreviewBarItem33.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendXls
            Me.printPreviewBarItem33.Id = 33
            Me.printPreviewBarItem33.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendXlsLarge
            Me.printPreviewBarItem33.Name = "printPreviewBarItem33"
            superToolTip32.FixedTooltipWidth = True
            toolTipTitleItem32.Text = "E-Mail As XLS"
            toolTipItem32.LeftIndent = 6
            toolTipItem32.Text = "Export the document to XLS and attach it to the e-mail."
            superToolTip32.Items.Add(toolTipTitleItem32)
            superToolTip32.Items.Add(toolTipItem32)
            superToolTip32.MaxWidth = 210
            Me.printPreviewBarItem33.SuperTip = superToolTip32
            ' 
            ' printPreviewBarItem34
            ' 
            Me.printPreviewBarItem34.Caption = "XLSX File"
            Me.printPreviewBarItem34.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx
            Me.printPreviewBarItem34.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem34.Description = "Microsoft Excel 2007 Workbook"
            Me.printPreviewBarItem34.Enabled = False
            Me.printPreviewBarItem34.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendXlsx
            Me.printPreviewBarItem34.Id = 34
            Me.printPreviewBarItem34.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendXlsxLarge
            Me.printPreviewBarItem34.Name = "printPreviewBarItem34"
            superToolTip33.FixedTooltipWidth = True
            toolTipTitleItem33.Text = "E-Mail As XLSX"
            toolTipItem33.LeftIndent = 6
            toolTipItem33.Text = "Export the document to XLSX and attach it to the e-mail."
            superToolTip33.Items.Add(toolTipTitleItem33)
            superToolTip33.Items.Add(toolTipItem33)
            superToolTip33.MaxWidth = 210
            Me.printPreviewBarItem34.SuperTip = superToolTip33
            ' 
            ' printPreviewBarItem35
            ' 
            Me.printPreviewBarItem35.Caption = "RTF File"
            Me.printPreviewBarItem35.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf
            Me.printPreviewBarItem35.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem35.Description = "Rich Text Format"
            Me.printPreviewBarItem35.Enabled = False
            Me.printPreviewBarItem35.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendRtf
            Me.printPreviewBarItem35.Id = 35
            Me.printPreviewBarItem35.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendRtfLarge
            Me.printPreviewBarItem35.Name = "printPreviewBarItem35"
            superToolTip34.FixedTooltipWidth = True
            toolTipTitleItem34.Text = "E-Mail As RTF"
            toolTipItem34.LeftIndent = 6
            toolTipItem34.Text = "Export the document to RTF and attach it to the e-mail."
            superToolTip34.Items.Add(toolTipTitleItem34)
            superToolTip34.Items.Add(toolTipItem34)
            superToolTip34.MaxWidth = 210
            Me.printPreviewBarItem35.SuperTip = superToolTip34
            ' 
            ' printPreviewBarItem36
            ' 
            Me.printPreviewBarItem36.Caption = "Image File"
            Me.printPreviewBarItem36.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic
            Me.printPreviewBarItem36.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem36.Description = "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF"
            Me.printPreviewBarItem36.Enabled = False
            Me.printPreviewBarItem36.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendGraphic
            Me.printPreviewBarItem36.Id = 36
            Me.printPreviewBarItem36.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SendGraphicLarge
            Me.printPreviewBarItem36.Name = "printPreviewBarItem36"
            superToolTip35.FixedTooltipWidth = True
            toolTipTitleItem35.Text = "E-Mail As Image"
            toolTipItem35.LeftIndent = 6
            toolTipItem35.Text = "Export the document to Image and attach it to the e-mail."
            superToolTip35.Items.Add(toolTipTitleItem35)
            superToolTip35.Items.Add(toolTipItem35)
            superToolTip35.MaxWidth = 210
            Me.printPreviewBarItem36.SuperTip = superToolTip35
            ' 
            ' printPreviewBarItem37
            ' 
            Me.printPreviewBarItem37.Caption = "PDF File"
            Me.printPreviewBarItem37.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf
            Me.printPreviewBarItem37.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem37.Description = "Adobe Portable Document Format"
            Me.printPreviewBarItem37.Enabled = False
            Me.printPreviewBarItem37.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportPdf
            Me.printPreviewBarItem37.Id = 37
            Me.printPreviewBarItem37.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportPdfLarge
            Me.printPreviewBarItem37.Name = "printPreviewBarItem37"
            superToolTip36.FixedTooltipWidth = True
            toolTipTitleItem36.Text = "Export to PDF"
            toolTipItem36.LeftIndent = 6
            toolTipItem36.Text = "Export the document to PDF and save it to the file on a disk."
            superToolTip36.Items.Add(toolTipTitleItem36)
            superToolTip36.Items.Add(toolTipItem36)
            superToolTip36.MaxWidth = 210
            Me.printPreviewBarItem37.SuperTip = superToolTip36
            ' 
            ' printPreviewBarItem38
            ' 
            Me.printPreviewBarItem38.Caption = "HTML File"
            Me.printPreviewBarItem38.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm
            Me.printPreviewBarItem38.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem38.Description = "Web Page"
            Me.printPreviewBarItem38.Enabled = False
            Me.printPreviewBarItem38.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportHtm
            Me.printPreviewBarItem38.Id = 38
            Me.printPreviewBarItem38.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportHtmLarge
            Me.printPreviewBarItem38.Name = "printPreviewBarItem38"
            superToolTip37.FixedTooltipWidth = True
            toolTipTitleItem37.Text = "Export to HTML"
            toolTipItem37.LeftIndent = 6
            toolTipItem37.Text = "Export the document to HTML and save it to the file on a disk."
            superToolTip37.Items.Add(toolTipTitleItem37)
            superToolTip37.Items.Add(toolTipItem37)
            superToolTip37.MaxWidth = 210
            Me.printPreviewBarItem38.SuperTip = superToolTip37
            ' 
            ' printPreviewBarItem39
            ' 
            Me.printPreviewBarItem39.Caption = "Text File"
            Me.printPreviewBarItem39.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt
            Me.printPreviewBarItem39.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem39.Description = "Plain Text"
            Me.printPreviewBarItem39.Enabled = False
            Me.printPreviewBarItem39.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportTxt
            Me.printPreviewBarItem39.Id = 39
            Me.printPreviewBarItem39.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportTxtLarge
            Me.printPreviewBarItem39.Name = "printPreviewBarItem39"
            superToolTip38.FixedTooltipWidth = True
            toolTipTitleItem38.Text = "Export to Text"
            toolTipItem38.LeftIndent = 6
            toolTipItem38.Text = "Export the document to Text and save it to the file on a disk."
            superToolTip38.Items.Add(toolTipTitleItem38)
            superToolTip38.Items.Add(toolTipItem38)
            superToolTip38.MaxWidth = 210
            Me.printPreviewBarItem39.SuperTip = superToolTip38
            ' 
            ' printPreviewBarItem40
            ' 
            Me.printPreviewBarItem40.Caption = "CSV File"
            Me.printPreviewBarItem40.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv
            Me.printPreviewBarItem40.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem40.Description = "Comma-Separated Values Text"
            Me.printPreviewBarItem40.Enabled = False
            Me.printPreviewBarItem40.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportCsv
            Me.printPreviewBarItem40.Id = 40
            Me.printPreviewBarItem40.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportCsvLarge
            Me.printPreviewBarItem40.Name = "printPreviewBarItem40"
            superToolTip39.FixedTooltipWidth = True
            toolTipTitleItem39.Text = "Export to CSV"
            toolTipItem39.LeftIndent = 6
            toolTipItem39.Text = "Export the document to CSV and save it to the file on a disk."
            superToolTip39.Items.Add(toolTipTitleItem39)
            superToolTip39.Items.Add(toolTipItem39)
            superToolTip39.MaxWidth = 210
            Me.printPreviewBarItem40.SuperTip = superToolTip39
            ' 
            ' printPreviewBarItem41
            ' 
            Me.printPreviewBarItem41.Caption = "MHT File"
            Me.printPreviewBarItem41.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht
            Me.printPreviewBarItem41.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem41.Description = "Single File Web Page"
            Me.printPreviewBarItem41.Enabled = False
            Me.printPreviewBarItem41.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportMht
            Me.printPreviewBarItem41.Id = 41
            Me.printPreviewBarItem41.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportMhtLarge
            Me.printPreviewBarItem41.Name = "printPreviewBarItem41"
            superToolTip40.FixedTooltipWidth = True
            toolTipTitleItem40.Text = "Export to MHT"
            toolTipItem40.LeftIndent = 6
            toolTipItem40.Text = "Export the document to MHT and save it to the file on a disk."
            superToolTip40.Items.Add(toolTipTitleItem40)
            superToolTip40.Items.Add(toolTipItem40)
            superToolTip40.MaxWidth = 210
            Me.printPreviewBarItem41.SuperTip = superToolTip40
            ' 
            ' printPreviewBarItem42
            ' 
            Me.printPreviewBarItem42.Caption = "XLS File"
            Me.printPreviewBarItem42.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls
            Me.printPreviewBarItem42.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem42.Description = "Microsoft Excel 2000-2003 Workbook"
            Me.printPreviewBarItem42.Enabled = False
            Me.printPreviewBarItem42.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportXls
            Me.printPreviewBarItem42.Id = 42
            Me.printPreviewBarItem42.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportXlsLarge
            Me.printPreviewBarItem42.Name = "printPreviewBarItem42"
            superToolTip41.FixedTooltipWidth = True
            toolTipTitleItem41.Text = "Export to XLS"
            toolTipItem41.LeftIndent = 6
            toolTipItem41.Text = "Export the document to XLS and save it to the file on a disk."
            superToolTip41.Items.Add(toolTipTitleItem41)
            superToolTip41.Items.Add(toolTipItem41)
            superToolTip41.MaxWidth = 210
            Me.printPreviewBarItem42.SuperTip = superToolTip41
            ' 
            ' printPreviewBarItem43
            ' 
            Me.printPreviewBarItem43.Caption = "XLSX File"
            Me.printPreviewBarItem43.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx
            Me.printPreviewBarItem43.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem43.Description = "Microsoft Excel 2007 Workbook"
            Me.printPreviewBarItem43.Enabled = False
            Me.printPreviewBarItem43.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportXlsx
            Me.printPreviewBarItem43.Id = 43
            Me.printPreviewBarItem43.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportXlsxLarge
            Me.printPreviewBarItem43.Name = "printPreviewBarItem43"
            superToolTip42.FixedTooltipWidth = True
            toolTipTitleItem42.Text = "Export to XLSX"
            toolTipItem42.LeftIndent = 6
            toolTipItem42.Text = "Export the document to XLSX and save it to the file on a disk."
            superToolTip42.Items.Add(toolTipTitleItem42)
            superToolTip42.Items.Add(toolTipItem42)
            superToolTip42.MaxWidth = 210
            Me.printPreviewBarItem43.SuperTip = superToolTip42
            ' 
            ' printPreviewBarItem44
            ' 
            Me.printPreviewBarItem44.Caption = "RTF File"
            Me.printPreviewBarItem44.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf
            Me.printPreviewBarItem44.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem44.Description = "Rich Text Format"
            Me.printPreviewBarItem44.Enabled = False
            Me.printPreviewBarItem44.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportRtf
            Me.printPreviewBarItem44.Id = 44
            Me.printPreviewBarItem44.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportRtfLarge
            Me.printPreviewBarItem44.Name = "printPreviewBarItem44"
            superToolTip43.FixedTooltipWidth = True
            toolTipTitleItem43.Text = "Export to RTF"
            toolTipItem43.LeftIndent = 6
            toolTipItem43.Text = "Export the document to RTF and save it to the file on a disk."
            superToolTip43.Items.Add(toolTipTitleItem43)
            superToolTip43.Items.Add(toolTipItem43)
            superToolTip43.MaxWidth = 210
            Me.printPreviewBarItem44.SuperTip = superToolTip43
            ' 
            ' printPreviewBarItem45
            ' 
            Me.printPreviewBarItem45.Caption = "Image File"
            Me.printPreviewBarItem45.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic
            Me.printPreviewBarItem45.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem45.Description = "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF"
            Me.printPreviewBarItem45.Enabled = False
            Me.printPreviewBarItem45.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportGraphic
            Me.printPreviewBarItem45.Id = 45
            Me.printPreviewBarItem45.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportGraphicLarge
            Me.printPreviewBarItem45.Name = "printPreviewBarItem45"
            superToolTip44.FixedTooltipWidth = True
            toolTipTitleItem44.Text = "Export to Image"
            toolTipItem44.LeftIndent = 6
            toolTipItem44.Text = "Export the document to Image and save it to the file on a disk."
            superToolTip44.Items.Add(toolTipTitleItem44)
            superToolTip44.Items.Add(toolTipItem44)
            superToolTip44.MaxWidth = 210
            Me.printPreviewBarItem45.SuperTip = superToolTip44
            ' 
            ' printPreviewBarItem46
            ' 
            Me.printPreviewBarItem46.Caption = "Open"
            Me.printPreviewBarItem46.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open
            Me.printPreviewBarItem46.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem46.Enabled = False
            Me.printPreviewBarItem46.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Open
            Me.printPreviewBarItem46.Id = 46
            Me.printPreviewBarItem46.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_OpenLarge
            Me.printPreviewBarItem46.Name = "printPreviewBarItem46"
            superToolTip45.FixedTooltipWidth = True
            toolTipTitleItem45.Text = "Open (Ctrl + O)"
            toolTipItem45.LeftIndent = 6
            toolTipItem45.Text = "Open a document."
            superToolTip45.Items.Add(toolTipTitleItem45)
            superToolTip45.Items.Add(toolTipItem45)
            superToolTip45.MaxWidth = 210
            Me.printPreviewBarItem46.SuperTip = superToolTip45
            ' 
            ' printPreviewBarItem47
            ' 
            Me.printPreviewBarItem47.Caption = "Save"
            Me.printPreviewBarItem47.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save
            Me.printPreviewBarItem47.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem47.Enabled = False
            Me.printPreviewBarItem47.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Save
            Me.printPreviewBarItem47.Id = 47
            Me.printPreviewBarItem47.LargeGlyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_SaveLarge
            Me.printPreviewBarItem47.Name = "printPreviewBarItem47"
            superToolTip46.FixedTooltipWidth = True
            toolTipTitleItem46.Text = "Save (Ctrl + S)"
            toolTipItem46.LeftIndent = 6
            toolTipItem46.Text = "Save the document."
            superToolTip46.Items.Add(toolTipTitleItem46)
            superToolTip46.Items.Add(toolTipItem46)
            superToolTip46.MaxWidth = 210
            Me.printPreviewBarItem47.SuperTip = superToolTip46
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Designer"
            Me.barButtonItem2.Glyph = (CType(resources.GetObject("barButtonItem2.Glyph"), System.Drawing.Image))
            Me.barButtonItem2.Id = 57
            Me.barButtonItem2.LargeGlyph = (CType(resources.GetObject("barButtonItem2.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem2.ImageUri.ResourceType = GetType(XtraReportsDemos.PreviewControl)
            Me.barButtonItem2.ImageUri.Uri = "resource://XtraReportsDemos.Resources.Designer.svg"
            Me.barButtonItem2.Name = "barButtonItem2"
            toolTipTitleItem47.Text = "Designer"
            toolTipItem47.LeftIndent = 6
            toolTipItem47.Text = "Run Ribbon Report Designer"
            superToolTip47.Items.Add(toolTipTitleItem47)
            superToolTip47.Items.Add(toolTipItem47)
            Me.barButtonItem2.SuperTip = superToolTip47
            ' 
            ' printPreviewBarItem8
            ' 
            Me.printPreviewBarItem8.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem8.Caption = "Editing Fields"
            Me.printPreviewBarItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields
            Me.printPreviewBarItem8.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem8.Enabled = False
            Me.printPreviewBarItem8.Id = 59
            Me.printPreviewBarItem8.Name = "printPreviewBarItem8"
            superToolTip48.FixedTooltipWidth = True
            toolTipTitleItem48.Text = "Highlight Editing Fields"
            toolTipItem48.LeftIndent = 6
            toolTipItem48.Text = "Highlight all editing fields to quickly discover which of the document elements a" & "re editable."
            superToolTip48.Items.Add(toolTipTitleItem48)
            superToolTip48.Items.Add(toolTipItem48)
            superToolTip48.MaxWidth = 210
            Me.printPreviewBarItem8.SuperTip = superToolTip48
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.ContextSpecifier = Me.documentViewerRibbonController1
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.printPreviewRibbonPageGroup1, Me.printPreviewRibbonPageGroup2, Me.printPreviewRibbonPageGroup3, Me.printPreviewRibbonPageGroup4, Me.printPreviewRibbonPageGroup5, Me.printPreviewRibbonPageGroup6, Me.printPreviewRibbonPageGroup7, Me.printPreviewRibbonPageGroup8})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Print Preview"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem2)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "Actions"
            ' 
            ' printPreviewRibbonPageGroup1
            ' 
            Me.printPreviewRibbonPageGroup1.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup1.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup1.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Document
            Me.printPreviewRibbonPageGroup1.ItemLinks.Add(Me.printPreviewBarItem46)
            Me.printPreviewRibbonPageGroup1.ItemLinks.Add(Me.printPreviewBarItem47)
            Me.printPreviewRibbonPageGroup1.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Document
            Me.printPreviewRibbonPageGroup1.Name = "printPreviewRibbonPageGroup1"
            Me.printPreviewRibbonPageGroup1.ShowCaptionButton = False
            Me.printPreviewRibbonPageGroup1.Text = "Document"
            ' 
            ' printPreviewRibbonPageGroup2
            ' 
            Me.printPreviewRibbonPageGroup2.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup2.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup2.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_PrintDirect
            Me.printPreviewRibbonPageGroup2.ItemLinks.Add(Me.printPreviewBarItem5)
            Me.printPreviewRibbonPageGroup2.ItemLinks.Add(Me.printPreviewBarItem6)
            Me.printPreviewRibbonPageGroup2.ItemLinks.Add(Me.printPreviewBarItem2)
            Me.printPreviewRibbonPageGroup2.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Print
            Me.printPreviewRibbonPageGroup2.Name = "printPreviewRibbonPageGroup2"
            Me.printPreviewRibbonPageGroup2.ShowCaptionButton = False
            Me.printPreviewRibbonPageGroup2.Text = "Print"
            ' 
            ' printPreviewRibbonPageGroup3
            ' 
            Me.printPreviewRibbonPageGroup3.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup3.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup3.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_PageMargins
            Me.printPreviewRibbonPageGroup3.ItemLinks.Add(Me.printPreviewBarItem9)
            Me.printPreviewRibbonPageGroup3.ItemLinks.Add(Me.printPreviewBarItem28)
            Me.printPreviewRibbonPageGroup3.ItemLinks.Add(Me.printPreviewBarItem26)
            Me.printPreviewRibbonPageGroup3.ItemLinks.Add(Me.printPreviewBarItem27)
            Me.printPreviewRibbonPageGroup3.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.PageSetup
            Me.printPreviewRibbonPageGroup3.Name = "printPreviewRibbonPageGroup3"
            superToolTip49.FixedTooltipWidth = True
            toolTipTitleItem49.Text = "Page Setup"
            toolTipItem49.LeftIndent = 6
            toolTipItem49.Text = "Show the Page Setup dialog."
            superToolTip49.Items.Add(toolTipTitleItem49)
            superToolTip49.Items.Add(toolTipItem49)
            superToolTip49.MaxWidth = 210
            Me.printPreviewRibbonPageGroup3.SuperTip = superToolTip49
            Me.printPreviewRibbonPageGroup3.Text = "Page Setup"
            ' 
            ' printPreviewRibbonPageGroup4
            ' 
            Me.printPreviewRibbonPageGroup4.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup4.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup4.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Find
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem3)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem4)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem1)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem8)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem16, True)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem17)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem18)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem19)
            Me.printPreviewRibbonPageGroup4.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Navigation
            Me.printPreviewRibbonPageGroup4.Name = "printPreviewRibbonPageGroup4"
            Me.printPreviewRibbonPageGroup4.ShowCaptionButton = False
            Me.printPreviewRibbonPageGroup4.Text = "Navigation"
            ' 
            ' printPreviewRibbonPageGroup5
            ' 
            Me.printPreviewRibbonPageGroup5.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup5.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup5.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Zoom
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem10)
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem11)
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem12)
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem20)
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem13)
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem15)
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem14)
            Me.printPreviewRibbonPageGroup5.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Zoom
            Me.printPreviewRibbonPageGroup5.Name = "printPreviewRibbonPageGroup5"
            Me.printPreviewRibbonPageGroup5.ShowCaptionButton = False
            Me.printPreviewRibbonPageGroup5.Text = "Zoom"
            ' 
            ' printPreviewRibbonPageGroup6
            ' 
            Me.printPreviewRibbonPageGroup6.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup6.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup6.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_Watermark
            Me.printPreviewRibbonPageGroup6.ItemLinks.Add(Me.printPreviewBarItem21)
            Me.printPreviewRibbonPageGroup6.ItemLinks.Add(Me.printPreviewBarItem22)
            Me.printPreviewRibbonPageGroup6.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Background
            Me.printPreviewRibbonPageGroup6.Name = "printPreviewRibbonPageGroup6"
            Me.printPreviewRibbonPageGroup6.ShowCaptionButton = False
            Me.printPreviewRibbonPageGroup6.Text = "Page Background"
            ' 
            ' printPreviewRibbonPageGroup7
            ' 
            Me.printPreviewRibbonPageGroup7.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup7.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup7.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ExportFile
            Me.printPreviewRibbonPageGroup7.ItemLinks.Add(Me.printPreviewBarItem23)
            Me.printPreviewRibbonPageGroup7.ItemLinks.Add(Me.printPreviewBarItem24)
            Me.printPreviewRibbonPageGroup7.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Export
            Me.printPreviewRibbonPageGroup7.Name = "printPreviewRibbonPageGroup7"
            Me.printPreviewRibbonPageGroup7.ShowCaptionButton = False
            Me.printPreviewRibbonPageGroup7.Text = "Export"
            ' 
            ' printPreviewRibbonPageGroup8
            ' 
            Me.printPreviewRibbonPageGroup8.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup8.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup8.Glyph = Global.RibbonReportDesigner.PrintRibbonControllerResources.RibbonPrintPreview_ClosePreview
            Me.printPreviewRibbonPageGroup8.ItemLinks.Add(Me.printPreviewBarItem25)
            Me.printPreviewRibbonPageGroup8.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Close
            Me.printPreviewRibbonPageGroup8.Name = "printPreviewRibbonPageGroup8"
            Me.printPreviewRibbonPageGroup8.ShowCaptionButton = False
            Me.printPreviewRibbonPageGroup8.Text = "Close"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.panelControl1.Controls.Add(Me.printControl)
            Me.panelControl1.Controls.Add(Me.ribbonStatusBar1)
            Me.panelControl1.Controls.Add(Me.ribbonControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(1116, 474)
            Me.panelControl1.TabIndex = 4
            ' 
            ' PreviewControl
            ' 
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "PreviewControl"
            Me.Size = New System.Drawing.Size(1116, 474)
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentViewerRibbonController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        #End Region

        'protected PrintBarManager CreatePrintBarManager(PrintControl pc) {
        '    PrintBarManager printBarManager = new PrintBarManager();
        '    printBarManager.Form = printControl;
        '    printBarManager.Initialize(pc);
        '    printBarManager.MainMenu.Visible = false;
        '    printBarManager.AllowCustomization = false;
        '    return printBarManager;
        '}
        Public Overrides Property AutoMergeRibbon() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
            End Set
        End Property
        Protected Overrides Sub DoHide()
        End Sub
        Private Sub ShowDesignerForm(ByVal designForm As Form, ByVal parentForm As Form)
            If designForm Is Nothing OrElse parentForm Is Nothing Then
                Return
            End If

            designForm.MinimumSize = parentForm.MinimumSize
            If parentForm.WindowState = FormWindowState.Normal Then
                designForm.StartPosition = FormStartPosition.Manual
                designForm.Bounds = parentForm.Bounds
            End If
            designForm.WindowState = parentForm.WindowState
            parentForm.Visible = False
            designForm.ShowDialog(parentForm)
            parentForm.Visible = True
        End Sub
        Protected Overridable Sub InitializeControls()
        End Sub
        Private Sub EditReport(ByVal createForm As Func(Of IDesignForm))
            If fReport Is Nothing Then
                Throw New InvalidOperationException("report is null")
            End If
            Dim saveFileName As String = GetReportPath(fReport, "sav")
            fReport.PrintingSystem.ExecCommand(PrintingSystemCommand.StopPageBuilding)
            fReport.SaveLayout(saveFileName)
            Using newReport As XtraReport = XtraReport.FromFile(saveFileName, True)
                Dim designForm As IDesignForm = createForm()
                designForm.OpenReport(newReport)

                Dim panel As XRDesignPanel = designForm.ActiveXRDesignPanel
                If panel IsNot Nothing Then
                    panel.FileName = fileName
                End If

                ShowDesignerForm(designForm.Form, Me.FindForm())

                If panel IsNot Nothing AndAlso (Not panel.IsDisposed) AndAlso panel.FileName <> fileName AndAlso File.Exists(panel.FileName) Then
                    File.Copy(panel.FileName, fileName, True)
                End If

                If designForm.Form IsNot Nothing Then
                    designForm.Form.Dispose()
                End If
            End Using
            If File.Exists(fileName) Then
                fReport.LoadLayout(fileName)
                Try
                    fReport.CreateDocument(True)
                Catch ex As Exception
                    Dim form As Form = FindForm()
                    If form IsNot Nothing Then
                        XtraMessageBox.Show(Me.LookAndFeel.ParentLookAndFeel, form, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    If fReport IsNot Nothing Then
                        fReport.LoadLayout(saveFileName)
                        fReport.CreateDocument(True)
                    End If
                Finally
                    File.Delete(fileName)
                End Try
            End If
            File.Delete(saveFileName)
            InitializeControls()
        End Sub
        Private Shared Function GetReportPath(ByVal fReport As DevExpress.XtraReports.UI.XtraReport, ByVal ext As String) As String
            Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim repName As String = fReport.Name
            If repName.Length = 0 Then
                repName = fReport.GetType().Name
            End If
            Dim dirName As String = Path.GetDirectoryName(asm.Location)
            Return GetNewFilePath(Path.Combine(dirName, repName), ext)
        End Function

        Private Shared Function GetNewFilePath(ByVal repFullName As String, ByVal ext As String) As String
            Dim i As Integer = 0
            Dim path As String = repFullName & "." & ext
            Do While i < 10
                Try
                    Dim fs As Stream = File.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None)
                    fs.Close()
                    Return path
                Catch
                End Try
                i += 1
                path = repFullName & i.ToString() & "." & ext
            Loop
            Return Nothing
        End Function
        Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem2.ItemClick
            If Control.ModifierKeys = Keys.Control Then
                EditReport(Function() New StandardFormWrapper())
            Else
                EditReport(Function() New RibbonFormWrapper())
            End If
        End Sub
    End Class
    Friend Interface IDesignForm
        ReadOnly Property Form() As Form
        ReadOnly Property ActiveXRDesignPanel() As XRDesignPanel
        Sub OpenReport(ByVal newReport As DevExpress.XtraReports.UI.XtraReport)
    End Interface
    Friend Class StandardFormWrapper
        Implements IDesignForm

        Private wrappedForm As ReportDesigner.MainForm

        Public ReadOnly Property Form() As Form Implements IDesignForm.Form
            Get
                Return wrappedForm
            End Get
        End Property
        Public ReadOnly Property ActiveXRDesignPanel() As XRDesignPanel Implements IDesignForm.ActiveXRDesignPanel
            Get
                Return wrappedForm.ActiveXRDesignPanel
            End Get
        End Property
        Public Sub New()
            wrappedForm = New ReportDesigner.MainForm()
        End Sub
        Public Sub OpenReport(ByVal newReport As XtraReport) Implements IDesignForm.OpenReport
            wrappedForm.OpenReport(newReport)
        End Sub
    End Class
    Friend Class RibbonFormWrapper
        Implements IDesignForm

        Private wrappedForm As RibbonReportDesigner.MainForm

        Public ReadOnly Property Form() As Form Implements IDesignForm.Form
            Get
                Return wrappedForm
            End Get
        End Property
        Public ReadOnly Property ActiveXRDesignPanel() As XRDesignPanel Implements IDesignForm.ActiveXRDesignPanel
            Get
                Return wrappedForm.ActiveXRDesignPanel
            End Get
        End Property
        Public Sub New()
            wrappedForm = New RibbonReportDesigner.MainForm()
        End Sub
        Public Sub OpenReport(ByVal newReport As XtraReport) Implements IDesignForm.OpenReport
            wrappedForm.OpenReport(newReport)
        End Sub
    End Class
End Namespace

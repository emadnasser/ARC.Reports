Imports System
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI
Imports System.IO

Namespace XtraReportsDemos.AnchorVertical
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.Anchor
            DisplayName = ReportNames.Anchor
            AddHandler BeforePrint, AddressOf AnchorReport_BeforePrint
            AddHandler PrintingSystem.AfterMarginsChange, AddressOf PrintingSystem_AfterMarginsChange
            AddHandler PrintingSystem.PageSettingsChanged, AddressOf PrintingSystem_PageSettingsChanged
        End Sub

        Private Sub PrintingSystem_PageSettingsChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim ps As DevExpress.XtraPrinting.PrintingSystemBase = TryCast(sender, DevExpress.XtraPrinting.PrintingSystemBase)
            Dim pageSettings As DevExpress.XtraPrinting.XtraPageSettingsBase = ps.PageSettings

            Me.PaperKind = pageSettings.PaperKind
            Me.Landscape = pageSettings.Landscape
            Parameters("LandscapeParameter").Value = pageSettings.Landscape

            CreateDocument()
        End Sub
        Private Sub PrintingSystem_AfterMarginsChange(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.MarginsChangeEventArgs)
            Select Case e.Side
                Case DevExpress.XtraPrinting.MarginSide.Left
                    Me.Margins = New System.Drawing.Printing.Margins(CInt((e.Value)), Margins.Right, Margins.Top, Margins.Bottom)
                    CreateDocument()
                Case DevExpress.XtraPrinting.MarginSide.Right
                    Me.Margins = New System.Drawing.Printing.Margins(Margins.Left, CInt((e.Value)), Margins.Top, Margins.Bottom)
                    CreateDocument()
                Case DevExpress.XtraPrinting.MarginSide.All
                    Me.Margins = (TryCast(sender, DevExpress.XtraPrinting.PrintingSystemBase)).PageSettings.Margins
                    CreateDocument()
                Case Else
            End Select
        End Sub
        Private Sub AnchorReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            SetLandscape(CBool(Parameters("LandscapeParameter").Value))
        End Sub
        Public Sub SetLandscape(ByVal landscape As Boolean)
            Me.Landscape = landscape
        End Sub
    End Class
End Namespace

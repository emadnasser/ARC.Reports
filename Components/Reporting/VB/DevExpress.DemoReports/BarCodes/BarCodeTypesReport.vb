Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.BarCodes
    Partial Public Class BarCodeTypesReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.BarCodes_BarcodeTypes
            DisplayName = ReportNames.BarCodes_BarcodeTypes
            AddHandler BeforePrint, AddressOf BarCodeTypesReport_BeforePrint
        End Sub

        Private Sub BarCodeTypesReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            SetAutoModule(CBool(Parameters("AutoModuleParameter").Value))
        End Sub
        Public Sub SetAutoModule(ByVal autoModule As Boolean)
            For Each barCode As XRBarCode In AllControls(Of XRBarCode)()
                barCode.AutoModule = autoModule
            Next barCode
        End Sub
    End Class
End Namespace

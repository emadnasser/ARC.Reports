Imports System.Linq
Imports System.Data.Linq
Imports System.Data.Entity
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI
Imports System.Data
Imports System.Drawing
Imports DevExpress.DemoData.Models
Imports System.Configuration

Namespace XtraReportsDemos.CustomDraw
    ''' <summary>
    ''' Summary description for XtraReport1.
    ''' </summary>
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.CustomDraw
            DisplayName = ReportNames.CustomDraw
            UpdateControls()
        End Sub
        Public ReadOnly Property RegionID() As Integer
            Get
                Return CInt((Parameters("RegionIdParameter").Value))
            End Get
        End Property

        Protected Overrides Sub OnBeforePrint(ByVal e As System.Drawing.Printing.PrintEventArgs)
            UpdateControls()
            MyBase.OnBeforePrint(e)
        End Sub
        Private Sub UpdateControls()
            Using entities = New CountriesEntities()
                Dim regions = (
                    From region In entities.AboutRegions
                    Where region.Id = RegionID
                    Select region).ToList()
                xrLabel1.Text = regions.FirstOrDefault().Region
                customControl1.UpdateData(regions)
            End Using
        End Sub
    End Class
End Namespace

Imports System
Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.DemoBase
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraSpreadsheet.API.Native.Implementation

Namespace SpreadsheetDemo
    Public Class SpreadsheetDemoModule
        Inherits DemoModule


        Private defaultCulture_Renamed As New CultureInfo("en-US")

        Public ReadOnly Property DefaultCulture() As CultureInfo
            Get
                Return defaultCulture_Renamed
            End Get
        End Property
    End Class
End Namespace

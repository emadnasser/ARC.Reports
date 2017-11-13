Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.HugeAmountRecords
    Public Class ReportWeb
        Inherits Report

        Public Sub New()
            Parameters("RowCountParameter").Value = 10000UI
        End Sub
        Protected Overrides ReadOnly Property ReportName() As String
            Get
                Return ReportNames.HugeAmountRecordsWeb
            End Get
        End Property
    End Class
End Namespace

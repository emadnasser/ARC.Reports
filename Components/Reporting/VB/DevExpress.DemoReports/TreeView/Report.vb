Imports System
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing

Namespace XtraReportsDemos.TreeView
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property WinControlContainer() As DevExpress.XtraReports.UI.PrintableComponentContainer
            Get
                Return Me.winControlContainer1
            End Get
        End Property
        Public Sub New()
            InitializeComponent()

            Name = ReportNames.TreeView
            DisplayName = ReportNames.TreeView
        End Sub
    End Class
End Namespace

Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace ReportWpfDemo
    Partial Public Class CharacterComb
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class CharacterCombViewModel
        Inherits ReportModuleViewModelBase

        Shared Sub New()
            EditingFieldExtensions.Instance.RegisterEditorInfo("Name", "Custom", "Name")
            EditingFieldExtensions.Instance.RegisterEditorInfo("NumbersAndUppercaseLetters", "Custom", "Numbers and Uppercase letters")
            EditingFieldExtensions.Instance.RegisterEditorInfo("UppercaseText", "Custom", "Uppercase Text")

        End Sub
        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.CharacterComb.Report()
        End Function
    End Class
End Namespace

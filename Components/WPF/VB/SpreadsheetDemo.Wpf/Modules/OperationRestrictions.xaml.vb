Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.PropertyGrid
Imports System
Imports System.Windows
Imports System.Windows.Threading

Namespace SpreadsheetDemo
    Partial Public Class OperationRestrictions
        Inherits SpreadsheetDemoModule

        Private optionsGroupCounter As Integer = 11

        Public Sub New()
            InitializeComponent()

            Me.spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("OperationRestrictions_template.xlsx"), DocumentFormat.Xlsx)

            propertyGridControl1.SelectedObject = New BehaviorOptionsProvider(spreadsheetControl1.Options.Behavior)
            SubscribeEvents()

            ribbonControl1.SelectedPage = pageHome
        End Sub

        Private Sub SubscribeEvents()
            AddHandler propertyGridControl1.CustomExpand, AddressOf OnCustomExpand
        End Sub
        Private Sub UnsubscribeEvents()
            RemoveHandler propertyGridControl1.CustomExpand, AddressOf OnCustomExpand
        End Sub

        Private Sub OnCustomExpand(ByVal sender As Object, ByVal args As CustomExpandEventArgs)
            args.IsExpanded = True
            args.Handled = True

            optionsGroupCounter -= 1
            If optionsGroupCounter = 0 Then
                UnsubscribeEvents()
            End If
        End Sub
    End Class
End Namespace

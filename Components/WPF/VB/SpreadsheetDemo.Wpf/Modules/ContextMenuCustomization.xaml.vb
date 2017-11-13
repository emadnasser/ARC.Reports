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
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Spreadsheet

Namespace SpreadsheetDemo
    Partial Public Class ContextMenuCustomization
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            Me.spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.Document.LoadDocument(DemoUtils.GetRelativePath("EmployeeInformation.xlsx"))
        End Sub

        Private Sub SpreadsheetControlPopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.Xpf.Spreadsheet.Menu.PopupMenuShowingEventArgs)
            If e.MenuType.Equals(DevExpress.Xpf.Spreadsheet.SpreadsheetMenuType.Cell) Then
                If ceInsertPicture.IsChecked = True Then
                    e.Customizations.Add(New BarButtonItem() With {.Command = SpreadsheetUICommand.InsertPicture, .Content = "Insert picture", .CommandParameter = spreadsheetControl1})
                End If
                If ceZoomIn.IsChecked.Value = True Then
                    e.Customizations.Add(New BarButtonItem() With {.Command = SpreadsheetUICommand.ViewZoomIn, .Content = "Zoom In", .CommandParameter = spreadsheetControl1})
                End If
                If ceZoomOut.IsChecked.Value = True Then
                    e.Customizations.Add(New BarButtonItem() With {.Command = SpreadsheetUICommand.ViewZoomOut, .Content = "Zoom Out", .CommandParameter = spreadsheetControl1})
                End If
            End If
        End Sub
    End Class
End Namespace

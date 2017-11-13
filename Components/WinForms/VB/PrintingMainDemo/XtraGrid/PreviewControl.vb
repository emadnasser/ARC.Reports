Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.Data

Namespace XtraPrintingDemos.XtraGrid
    Partial Public Class PreviewControl
        Inherits XtraPrintingDemos.PreviewControl

        Public Sub New()
            InitializeComponent()
            categoriesTableAdapter.Fill(nwindDataSet.Categories)
            productsTableAdapter.Fill(nwindDataSet.Products)
            gridView1.Columns(nwindDataSet.Categories.CategoryNameColumn.ColumnName).SortOrder = ColumnSortOrder.Ascending
            AddHandler gridView1.EndSorting, AddressOf gridView_EndSorting
        End Sub
        Protected Overrides Sub CreateDocumentCore()
            printingSystem.Graph.PageUnit = GraphicsUnit.Pixel
            gridLink.CreateDocument()
            Viewer.ExecCommand(PrintingSystemCommand.ZoomToWholePage)
        End Sub
        Private Sub gridView_EndSorting(ByVal sender As Object, ByVal e As EventArgs)
            CreateDocument()
        End Sub
    End Class
End Namespace

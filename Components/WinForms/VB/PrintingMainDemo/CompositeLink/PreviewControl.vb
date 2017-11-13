Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview

Namespace XtraPrintingDemos.CompositeLink
    Partial Public Class PreviewControl
        Inherits XtraPrintingDemos.PreviewControl

        Public Sub New()
            InitializeComponent()
            Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
            Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
        End Sub
        Protected Overrides Sub CreateDocumentCore()
            printingSystem.Graph.PageUnit = GraphicsUnit.Pixel
            compositeLink.CreateDocument()
            Viewer.ExecCommand(PrintingSystemCommand.ZoomToWholePage)
        End Sub
        Private Sub gridView1_MasterRowExpandedCollapsed(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles gridView1.MasterRowExpanded, gridView1.MasterRowCollapsed
            CreateDocument()
        End Sub
    End Class
End Namespace

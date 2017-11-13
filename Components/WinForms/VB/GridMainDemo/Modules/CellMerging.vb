Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for CellMerging.
    ''' </summary>
    Partial Public Class CellMerging
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\CellMerging.vb"
            TutorialInfo.WhatsThisXMLFile = "CellMerging.xml"
            ' TODO: Add any initialization after the InitForm call
        End Sub
        Private Sub CellMerging_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitIssueListData(dsIssueList1)
            ceMerging.Checked = gridView1.OptionsView.AllowCellMerge
        End Sub
        Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
            Get
                Return gridView1
            End Get
        End Property
        Protected Overrides Sub InitXMLData(ByVal ds As DataSet)
            Me.gridControl1.DataSource = ds.Tables("Items")
            Me.repositoryItemLookUpEdit1.DataSource = ds.Tables("Projects")
            Me.repositoryItemLookUpEdit2.DataSource = ds.Tables("Users")
        End Sub
        '<ceMerging>
        Private Sub ceMerging_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceMerging.CheckedChanged
            gridView1.OptionsView.AllowCellMerge = ceMerging.Checked
        End Sub
        '</ceMerging>
        '<simpleButton1>
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            gridControl1.ShowRibbonPrintPreview()
            Cursor.Current = currentCursor
        End Sub
        '</simpleButton1>
    End Class
End Namespace

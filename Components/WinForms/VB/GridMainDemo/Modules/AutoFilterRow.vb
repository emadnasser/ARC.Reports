Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for AutoFilterRow.
    ''' </summary>
    Partial Public Class AutoFilterRow
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\AutoFilterRow.vb"
            TutorialInfo.WhatsThisXMLFile = "AutoFilterRow.xml"
            ' TODO: Add any initialization after the InitForm call

        End Sub

        Private Sub AutoFilterRow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitIssueListData(dsIssueList1)
            InitCheckEditors()
            gridView1.FocusedRowHandle = GridControl.AutoFilterRowHandle
        End Sub

        Private initEditors As Boolean = False
        Private Sub InitCheckEditors()
            initEditors = True
            ceAutoFilterRow.Checked = gridView1.OptionsView.ShowAutoFilterRow
            ceAutoFilterRowMenuItem.Checked = gridView1.OptionsMenu.ShowAutoFilterRowItem
            initEditors = False
        End Sub

        Protected Overrides Sub InitXMLData(ByVal ds As DataSet)
            Me.gridControl1.DataSource = ds.Tables("Items")
            Me.repositoryItemLookUpEdit1.DataSource = ds.Tables("Projects")
            Me.repositoryItemLookUpEdit2.DataSource = ds.Tables("Users")
        End Sub
        '<ceAutoFilterRow>
        Private Sub ceAutoFilterRow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceAutoFilterRow.CheckedChanged
            If initEditors Then
                Return
            End If
            gridView1.OptionsView.ShowAutoFilterRow = ceAutoFilterRow.Checked
        End Sub
        '</ceAutoFilterRow>

        '<ceAutoFilterRowMenuItem>
        Private Sub ceAutoFilterRowMenuItem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAutoFilterRowMenuItem.CheckedChanged
            If initEditors Then
                Return
            End If
            gridView1.OptionsMenu.ShowAutoFilterRowItem = ceAutoFilterRowMenuItem.Checked
        End Sub
        '</ceAutoFilterRowMenuItem>
        Private Sub gridView1_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles gridView1.GridMenuItemClick
            BeginInvoke(New MethodInvoker(AddressOf InitCheckEditors))
        End Sub
    End Class
End Namespace

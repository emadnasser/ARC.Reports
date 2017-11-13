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
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class MasterDetailSimple
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\MasterDetailSimple.vb"
            TutorialInfo.WhatsThisXMLFile = "MasterDetailSimple.xml"
            MainView.RowHeight = 60
            InitNWindData()
            InitRowHeightOptions()
            InitDetailOptions()
        End Sub

        Public Overrides ReadOnly Property ExportView() As Views.Base.BaseView
            Get
                Return MainView
            End Get
        End Property
        Private ReadOnly Property MainView() As GridView
            Get
                Return gridView1
            End Get
        End Property
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            CType(New OleDbDataAdapter("SELECT * FROM Categories", connectionString), OleDbDataAdapter).Fill(dsNWindCategories1.Categories)
            CType(New OleDbDataAdapter("SELECT * FROM Products", connectionString), OleDbDataAdapter).Fill(dsNWindCategories1.Products)
        End Sub
        Private Sub gridView1_MasterRowExpanded(ByVal sender As Object, ByVal e As CustomMasterRowEventArgs) Handles gridView1.MasterRowExpanded
            Dim view As GridView = TryCast(sender, GridView)
            If view IsNot Nothing Then
                Dim detailView As GridView = TryCast(view.GetDetailView(e.RowHandle, e.RelationIndex), GridView)
                If detailView IsNot Nothing Then
                    detailView.ExpandGroupRow(-1)
                End If
            End If
        End Sub

        Private Sub gridView2_CustomRowCellEditForEditing(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs) Handles gridView2.CustomRowCellEditForEditing
            If e.Column.FieldName = colReorderLevel.FieldName Then
                e.RepositoryItem = repositoryItemSpinEdit2
            End If
        End Sub

        Private Sub InitRowHeightOptions()
            ceRowAutoHeight.Checked = MainView.OptionsView.RowAutoHeight
            seRowHeight.Value = MainView.RowHeight
            seRowHeight.Enabled = Not MainView.OptionsView.RowAutoHeight
            sbBestFit.Enabled = MainView.OptionsView.RowAutoHeight
        End Sub

        '<seRowHeight>
        Private Sub seRowHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seRowHeight.EditValueChanged
            MainView.RowHeight = Convert.ToInt32(seRowHeight.Value)
            InitRowHeightOptions()
        End Sub
        '</seRowHeight>
        Private rowHeightValue As Integer = -1

        '<ceRowAutoHeight>
        Private Sub ceRowAutoHeight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceRowAutoHeight.CheckedChanged
            MainView.OptionsView.RowAutoHeight = ceRowAutoHeight.Checked
            If MainView.OptionsView.RowAutoHeight Then
                InitRowHeightOptions()
                rowHeightValue = Convert.ToInt32(seRowHeight.Value)
                MainView.RowHeight = -1
            Else
                MainView.RowHeight = rowHeightValue
                InitRowHeightOptions()
            End If
        End Sub
        '</ceRowAutoHeight>

        '<sbBestFit>
        Private Sub sbBestFit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbBestFit.Click
            MainView.BestFitColumns()
        End Sub
        '</sbBestFit>
        Private Sub InitDetailOptions()
            ceEnabledMasterViewMode.Checked = MainView.OptionsDetail.EnableMasterViewMode
            icbDetailMode.Properties.Items.Add(DetailMode.Classic.ToString(), DetailMode.Classic, -1)
            icbDetailMode.Properties.Items.Add(DetailMode.Embedded.ToString(), DetailMode.Embedded, -1)
            icbDetailMode.EditValue = MainView.OptionsDetail.DetailMode
            ceShowEmbeddedDetailIndent.Checked = MainView.OptionsDetail.ShowEmbeddedDetailIndent <> Utils.DefaultBoolean.False
            EnabledDetailOptions()
        End Sub

        '<ceEnabledMasterViewMode>
        Private Sub ceEnabledMasterViewMode_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceEnabledMasterViewMode.CheckedChanged
            sbExpandDetails.Enabled = ceEnabledMasterViewMode.Checked
            MainView.OptionsDetail.EnableMasterViewMode = sbExpandDetails.Enabled
            ExpandDemoGroup()
            EnabledDetailOptions()
            MainView.TopRowIndex = 0
        End Sub
        Private Sub ExpandDemoGroup()
            If MainView.OptionsDetail.EnableMasterViewMode Then
                MainView.SetMasterRowExpanded(1, True)
            End If
        End Sub
        Private Sub EnabledDetailOptions()
            ceShowEmbeddedDetailIndent.Enabled = MainView.OptionsDetail.DetailMode = DetailMode.Embedded AndAlso MainView.OptionsDetail.EnableMasterViewMode
            icbDetailMode.Enabled = MainView.OptionsDetail.EnableMasterViewMode
        End Sub
        '</ceEnabledMasterViewMode>
        '<sbExpandDetails>
        Private Sub sbExpandDetails_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbExpandDetails.Click
            If MainView.GroupCount > 0 Then
                MainView.ExpandAllGroups()
            End If
            MainView.BeginUpdate()
            Try
                For i As Integer = 0 To MainView.RowCount - 1
                    MainView.SetMasterRowExpanded(i, True)
                Next i
            Finally
                MainView.EndUpdate()
            End Try
        End Sub
        '</sbExpandDetails>
        Private Sub icbDetailMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbDetailMode.SelectedIndexChanged
            MainView.OptionsDetail.DetailMode = CType(icbDetailMode.EditValue, DetailMode)
            EnabledDetailOptions()
            ExpandDemoGroup()
            MainView.TopRowIndex = 0
        End Sub

        Private Sub ceShowEmbeddedDetailIndent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowEmbeddedDetailIndent.CheckedChanged
            MainView.OptionsDetail.ShowEmbeddedDetailIndent = If(ceShowEmbeddedDetailIndent.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub


    End Class
End Namespace

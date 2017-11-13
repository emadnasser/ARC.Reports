Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for Filtering.
    ''' </summary>
    Partial Public Class Filtering
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\Filtering.vb"
            TutorialInfo.WhatsThisXMLFile = "Filtering.xml"
            ' TODO: Add any initialization after the InitForm call
        End Sub

        Private Sub Filtering_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitIssueListData(dsIssueList1)
            InitFilter()
            InitEditors()
        End Sub

        Protected Overrides Sub InitXMLData(ByVal ds As DataSet)
            Me.gridControl1.DataSource = ds.Tables("Items")
            Me.repositoryItemLookUpEdit1.DataSource = ds.Tables("Projects")
            Me.repositoryItemLookUpEdit2.DataSource = ds.Tables("Users")
        End Sub

        Private Sub InitFilter()
            gridControl1.ForceInitialize()
        End Sub

        '<ceAllowFilter>
        Private Sub InitDemoFilter()
            gridView1.Columns("FixedDate").FilterInfo = New Columns.ColumnFilterInfo(Columns.ColumnFilterType.Custom, Nothing, "[FixedDate] is not null")
            gridView1.Columns("Status").FilterInfo = New Columns.ColumnFilterInfo(Columns.ColumnFilterType.Custom, Nothing, "[Status] in (2, 3, 4)")
        End Sub
        '</ceAllowFilter>
        Private Sub InitEditors()
            ceAllowFilter.Checked = gridView1.OptionsCustomization.AllowFilter
            ceFilterEditor.Checked = gridView1.OptionsFilter.AllowFilterEditor
            ceAdvDialog.Checked = gridView1.OptionsFilter.UseNewCustomFilterDialog
            ceFilterList.Checked = gridView1.OptionsFilter.AllowMRUFilterList
            ceColumnFilterList.Checked = gridView1.OptionsFilter.AllowColumnMRUFilterList
            InitEnabled()
        End Sub

        Private Sub InitEnabled()
            ceColumnFilterList.Enabled = gridView1.OptionsCustomization.AllowFilter
            ceFilterList.Enabled = ceColumnFilterList.Enabled
            ceAdvDialog.Enabled = ceFilterList.Enabled
            ceFilterEditor.Enabled = ceAdvDialog.Enabled
        End Sub

        Private Sub gridView1_ColumnFilterChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView1.ColumnFilterChanged
            gridView1.ExpandAllGroups()
        End Sub

        Private Sub gridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gridView1.PopupMenuShowing
            If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
                For i As Integer = e.Menu.Items.Count - 1 To 0 Step -1
                    If e.Menu.Items(i) IsNot Nothing Then
                        If e.Menu.Items(i).Caption.IndexOf("Filter") = -1 Then
                            e.Menu.Items.RemoveAt(i)
                        Else
                            e.Menu.Items(i).BeginGroup = False
                        End If
                    End If
                Next i
            End If
        End Sub

        '<ceAllowFilter>
        Private Sub ceAllowFilter_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceAllowFilter.CheckedChanged
            gridView1.OptionsCustomization.AllowFilter = ceAllowFilter.Checked
            If Not ceAllowFilter.Checked Then
                gridView1.ClearColumnsFilter()
            Else
                InitDemoFilter()
            End If
            InitEnabled()
        End Sub
        '</ceAllowFilter>
        '<ceFilterEditor>
        Private Sub ceFilterEditor_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceFilterEditor.CheckedChanged
            gridView1.OptionsFilter.AllowFilterEditor = ceFilterEditor.Checked
        End Sub
        '</ceFilterEditor>
        '<ceAdvDialog>
        Private Sub ceAdvDialog_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceAdvDialog.CheckedChanged
            gridView1.OptionsFilter.UseNewCustomFilterDialog = ceAdvDialog.Checked
        End Sub
        '</ceAdvDialog>
        '<ceFilterList>
        Private Sub ceFilterList_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceFilterList.CheckedChanged
            gridView1.OptionsFilter.AllowMRUFilterList = ceFilterList.Checked
        End Sub
        '</ceFilterList>
        '<ceColumnFilterList>
        Private Sub ceColumnFilterList_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceColumnFilterList.CheckedChanged
            gridView1.OptionsFilter.AllowColumnMRUFilterList = ceColumnFilterList.Checked
        End Sub
        '</ceColumnFilterList>
        '<sbInfo>
        Private Sub sbInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbInfo.Click
            Dim args As New ToolTipControllerShowEventArgs()
            args.IconType = ToolTipIconType.Information
            args.IconSize = ToolTipIconSize.Large
            args.AutoHide = False
            args.ToolTip = String.Format("<u>{7}</u><br> {0}<br><br>{8} <b>{1}</b><br><br>{9} <b>{2}</b><br>{10} <b>{3}</b><br>{11} <b>{4}</b><br>{12} <b>{5}</b><br>{13} <b>{6}</b><br>", gridView1.FilterPanelText, gridView1.RowCount, gridView1.OptionsFilter.ColumnFilterPopupMaxRecordsCount, gridView1.OptionsFilter.ColumnFilterPopupRowCount, gridView1.OptionsFilter.MRUColumnFilterListCount, gridView1.OptionsFilter.MRUFilterListCount, gridView1.OptionsFilter.MRUFilterListPopupCount, My.Resources.RowFilter, My.Resources.RowCount, My.Resources.FilterPopupMaxRecord, My.Resources.FilterPopupRowCount, My.Resources.MRUColumnFilterListCount, My.Resources.MRUFilterListCount, My.Resources.MRUFilterListPopupCount)
            args.ShowBeak = True
            args.ToolTipLocation = ToolTipLocation.TopLeft
            toolTipController1.ShowHint(args, sbInfo.Parent.PointToScreen(New Point(sbInfo.Left + sbInfo.Width \ 2, sbInfo.Top)))

        End Sub
        '</sbInfo>
        Private Sub sbInfo_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles sbInfo.Leave, sbInfo.MouseLeave
            toolTipController1.HideHint()
        End Sub
    End Class
End Namespace

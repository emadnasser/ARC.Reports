Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.FilterEditor
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for FilterControl.
    ''' </summary>
    Partial Public Class FilterControl
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\FilterControl.vb"
            TutorialInfo.WhatsThisXMLFile = "FilterControl.xml"
            ' TODO: Add any initialization after the InitForm call

        End Sub
        Private initProperties As Boolean = False
        Private Sub FilterControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            filterControl1.MenuManager = gridControl1.MenuManager
            InitNWindData()
            gridColumnProduct.FilterInfo = New ColumnFilterInfo("[ProductID] between ('Alice Munton', 'Iqura')")
            gridColumnDiscount.FilterInfo = New ColumnFilterInfo("[Discount] >= 0.05")
            InitOptions()
            InitCustomFilterControl()
            gridColumnImplemented.FilterInfo = New ColumnFilterInfo("[Implemented] >= 50")
            gridColumnSuspended.FilterInfo = New ColumnFilterInfo("[Suspended] = False")
            ResetCustomFilter()
            '<filterControl1>
            '            
            '~Note: the following code is set at design-time and is listed here for educational purposes only.
            '~filterControl1.SourceControl = gridControl1
            '            
            '</filterControl1>
        End Sub


        Private Sub InitOptions()
            initProperties = True
            ceEmptyValue.Color = filterControl1.AppearanceEmptyValueColor
            ceFieldName.Color = filterControl1.AppearanceFieldNameColor
            ceGroupOperator.Color = filterControl1.AppearanceGroupOperatorColor
            ceOperator.Color = filterControl1.AppearanceOperatorColor
            ceValue.Color = filterControl1.AppearanceValueColor
            seLevelIndent.Value = filterControl1.LevelIndent
            seSeparatorHeight.Value = filterControl1.NodeSeparatorHeight
            ceGroupCommandsIcon.Checked = filterControl1.ShowGroupCommandsIcon
            ceOperandTypeIcon.Checked = filterControl1.ShowOperandTypeIcon
            ceToolTips.Checked = filterControl1.ShowToolTips
            initProperties = False
        End Sub
        Private tblGrid As String = "[Order Details]"
        Private tblLookUp As String = "Products"
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim ds As New DataSet()
            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, connectionString)
            oleDbDataAdapter.Fill(ds, tblGrid)
            oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblLookUp, connectionString)
            oleDbDataAdapter.Fill(ds, tblLookUp)

            Dim dvManager As New DataViewManager(ds)
            Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tblGrid))

            gridControl1.DataSource = dv
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
        End Sub
        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            Dim ds As New DataSet()
            ds.ReadXml(dataFileName)

            gridControl1.DataSource = ds.Tables(tblGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
        End Sub
        Protected Overrides Sub InitNWindData()
            MyBase.InitNWindData()
            gridControl2.DataSource = OutlookData.CreateIssueList()
        End Sub

        '<sbApply>
        Private Sub sbApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbApply.Click
            filterControl1.ApplyFilter()
        End Sub
        '</sbApply>

        '<ceEmptyValue>
        Private Sub ceEmptyValue_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceEmptyValue.EditValueChanged
            If initProperties Then
                Return
            End If
            filterControl1.AppearanceEmptyValueColor = ceEmptyValue.Color
        End Sub
        '</ceEmptyValue>
        '<ceFieldName>
        Private Sub ceFieldName_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceFieldName.EditValueChanged
            If initProperties Then
                Return
            End If
            filterControl1.AppearanceFieldNameColor = ceFieldName.Color
        End Sub
        '</ceFieldName>
        '<ceGroupOperator>
        Private Sub ceGroupOperator_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceGroupOperator.EditValueChanged
            If initProperties Then
                Return
            End If
            filterControl1.AppearanceGroupOperatorColor = ceGroupOperator.Color
        End Sub
        '</ceGroupOperator>
        '<ceOperator>
        Private Sub ceOperator_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceOperator.EditValueChanged
            If initProperties Then
                Return
            End If
            filterControl1.AppearanceOperatorColor = ceOperator.Color
        End Sub
        '</ceOperator>
        '<ceValue>
        Private Sub ceValue_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceValue.EditValueChanged
            If initProperties Then
                Return
            End If
            filterControl1.AppearanceValueColor = ceValue.Color
        End Sub
        '</ceValue>
        '<seLevelIndent>
        Private Sub seLevelIndent_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seLevelIndent.EditValueChanged
            If initProperties Then
                Return
            End If
            filterControl1.LevelIndent = Convert.ToInt32(seLevelIndent.Value)
        End Sub
        '</seLevelIndent>
        '<seSeparatorHeight>
        Private Sub seSeparatorHeight_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seSeparatorHeight.EditValueChanged
            If initProperties Then
                Return
            End If
            filterControl1.NodeSeparatorHeight = Convert.ToInt32(seSeparatorHeight.Value)
        End Sub
        '</seSeparatorHeight>
        '<ceGroupCommandsIcon>
        Private Sub ceGroupCommandsIcon_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceGroupCommandsIcon.CheckedChanged
            If initProperties Then
                Return
            End If
            filterControl1.ShowGroupCommandsIcon = ceGroupCommandsIcon.Checked
        End Sub
        '</ceGroupCommandsIcon>
        '<ceOperandTypeIcon>
        Private Sub ceOperandTypeIcon_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceOperandTypeIcon.CheckedChanged
            If initProperties Then
                Return
            End If
            filterControl1.ShowOperandTypeIcon = ceOperandTypeIcon.Checked
        End Sub
        '</ceOperandTypeIcon>
        '<ceToolTips>
        Private Sub ceToolTips_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceToolTips.CheckedChanged
            If initProperties Then
                Return
            End If
            filterControl1.ShowToolTips = ceToolTips.Checked
        End Sub
        '</ceToolTips>
        Private Sub InitCustomFilterControl()
            Dim columnCollection As New ViewFilterColumnCollection(gridView2)
            CustomizationFilterColumnCollection(columnCollection)
            filterControl2.SetFilterColumnsCollection(columnCollection, gridControl2.MenuManager)
            filterControl2.SetDefaultColumn(GridCriteriaHelper.GetFilterColumnByGridColumn(filterControl2.FilterColumns, gridColumnImplemented))
            filterControl2.FilterString = gridView2.ActiveFilterString
        End Sub
        '<sbApplyFilter2>
        Private Sub sbApplyFilter2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbApplyFilter2.Click
            gridView2.ActiveFilterString = filterControl2.FilterString
        End Sub
        '</sbApplyFilter2>
        '<sbReset>
        Private Sub sbReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbReset.Click
            ResetCustomFilter()
        End Sub

        Private Sub ResetCustomFilter()
            filterControl2.FilterString = gridView2.ActiveFilterString
        End Sub
        '</sbReset>
        Private Sub CustomizationFilterColumnCollection(ByVal columnCollection As ViewFilterColumnCollection)
            columnCollection.RemoveAt(0)
            Dim col As GridFilterColumn = TryCast(columnCollection("Implemented"), GridFilterColumn)
            Dim tbItem As New RepositoryItemTrackBar()
            tbItem.Maximum = 100
            tbItem.TickFrequency = 10
            col.SetRepositoryItem(tbItem)
            col = TryCast(columnCollection("Suspended"), GridFilterColumn)
            Dim icbItem As New RepositoryItemImageComboBox()
            icbItem.SmallImages = imageList1
            icbItem.Items.Add(New ImageComboBoxItem("Checked", True, 1))
            icbItem.Items.Add(New ImageComboBoxItem("Unchecked", False, 2))
            col.SetRepositoryItem(icbItem)
            col = TryCast(columnCollection("Subject"), GridFilterColumn)
            col.SetImage(imageList1.Images(3))
        End Sub
    End Class
End Namespace

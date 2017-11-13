Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class WebStyleColumnSelection
        Inherits TutorialControl

        Private initData_Renamed As Boolean = False
        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\WebStyleColumnSelection.vb"
            TutorialInfo.WhatsThisXMLFile = "WebStyleColumnSelection.xml"
            InitNWindData()
            InitEditors()
            InitData()
        End Sub
        Public Overrides ReadOnly Property ExportView() As BaseView
            Get
                Return gridView1
            End Get
        End Property
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim tblGrid As String = "[Order Details]", tblLookUp As String = "Products"
            Dim ds As New DataSet()
            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, connectionString)
            SetWaitDialogCaption(My.Resources.LoadingOrderDetails)
            oleDbDataAdapter.Fill(ds, tblGrid)
            oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblLookUp, connectionString)
            SetWaitDialogCaption(My.Resources.LoadingProducts)
            oleDbDataAdapter.Fill(ds, tblLookUp)

            gridControl1.DataSource = ds.Tables(tblGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
        End Sub
        Private Sub InitEditors()
            For Each val As DefaultBoolean In System.Enum.GetValues(GetType(DefaultBoolean))
                icbShowCheckBoxSelectorInGroupRow.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of DefaultBoolean).GetTitle(val), val, -1))
                icbShowCheckBoxSelectorInHeader.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of DefaultBoolean).GetTitle(val), val, -1))
                icbShowCheckBoxSelectorInPrintExport.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of DefaultBoolean).GetTitle(val), val, -1))
            Next val
        End Sub
        Private Sub InitData()
            initData_Renamed = True
            Try
                icbShowCheckBoxSelectorInGroupRow.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow
                icbShowCheckBoxSelectorInHeader.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader
                icbShowCheckBoxSelectorInPrintExport.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport
                cePrintSelectedRowsOnly.Checked = gridView1.OptionsPrint.PrintSelectedRowsOnly
            Finally
            End Try
            initData_Renamed = False
        End Sub

        '<icbShowCheckBoxSelectorInGroupRow>
        Private Sub icbShowCheckBoxSelectorInGroupRow_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbShowCheckBoxSelectorInGroupRow.SelectedIndexChanged
            If initData_Renamed Then
                Return
            End If
            gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = CType(icbShowCheckBoxSelectorInGroupRow.EditValue, DefaultBoolean)
        End Sub
        '</icbShowCheckBoxSelectorInGroupRow>

        '<icbShowCheckBoxSelectorInHeader>
        Private Sub icbShowCheckBoxSelectorInColumnHeader_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbShowCheckBoxSelectorInHeader.SelectedIndexChanged
            If initData_Renamed Then
                Return
            End If
            gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = CType(icbShowCheckBoxSelectorInHeader.EditValue, DefaultBoolean)
        End Sub
        '</icbShowCheckBoxSelectorInHeader>

        '<icbShowCheckBoxSelectorInPrintExport>
        Private Sub icbShowCheckBoxSelectorInPrintExport_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbShowCheckBoxSelectorInPrintExport.SelectedIndexChanged
            If initData_Renamed Then
                Return
            End If
            gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = CType(icbShowCheckBoxSelectorInPrintExport.EditValue, DefaultBoolean)
        End Sub
        '</icbShowCheckBoxSelectorInPrintExport>

        '<cePrintSelectedRowsOnly>
        Private Sub cePrintSelectedRowsOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cePrintSelectedRowsOnly.CheckedChanged
            If initData_Renamed Then
                Return
            End If
            gridView1.OptionsPrint.PrintSelectedRowsOnly = cePrintSelectedRowsOnly.Checked
        End Sub
        '</cePrintSelectedRowsOnly>

    End Class
End Namespace

Imports System.Collections
Imports System.ComponentModel
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.Data
Imports DevExpress.XtraGrid

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for CustomDataSummaries.
    ''' </summary>
    Partial Public Class CustomDataSummaries
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\CustomDataSummaries.vb"
            TutorialInfo.WhatsThisXMLFile = "CustomDataSummaries.xml"

            InitNWindData()

            gridControl2.RefreshDataSource()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '

            '<gridControl2>
            '~Note: the following code is generated at design time and listed here only for demonstration purposes.
            '~Create two group summaries (Custom and Count):
            '~gridView2.GroupSummary.AddRange(new GridSummaryItem() {
            '~    New GridGroupSummaryItem(SummaryItemType.Custom, "Freight", Nothing, "(Order Count [WHERE Freight >= 100 = {0}])"),
            '~    New GridGroupSummaryItem(SummaryItemType.Count, "OrderID", Nothing, "(Total Order Count = {0})")})
            '~
            '~Create a Custom total summary:
            '~colFreight.Summary.AddRange(new GridSummaryItem() {
            '~    New GridColumnSummaryItem(SummaryItemType.Custom, "Freight", "Custom SUM={0:c}")})
            '            
            '</gridControl2>
        End Sub
        Private totalCount As Integer
        Private totalSum As Decimal
        Private footerApp As New AppearanceDefault(Color.Red, Color.Empty, New Font(AppearanceObject.DefaultFont, FontStyle.Bold))

#Region "Init"
        Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
            Get
                Return gridView2
            End Get
        End Property
        Private ReadOnly Property CustomGridView() As GridView
            Get
                Return gridView2
            End Get
        End Property

        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim ds As New DataSet()
            Dim oleDBAdapter As New OleDbDataAdapter("SELECT * FROM Orders", connectionString)
            SetWaitDialogCaption(My.Resources.LoadingOrders)
            oleDBAdapter.Fill(ds, "Orders")
            gridControl2.DataSource = ds.Tables("Orders")

            oleDBAdapter = New OleDbDataAdapter("SELECT * FROM Customers", connectionString)
            SetWaitDialogCaption(My.Resources.LoadingCustomers)
            oleDBAdapter.Fill(ds, "Customers")
            repositoryItemLookUpEdit2.DataSource = ds.Tables("Customers")

            oleDBAdapter = New OleDbDataAdapter("SELECT Employees.*, [FirstName] & ' ' & [LastName] AS Name FROM Employees", connectionString)
            SetWaitDialogCaption(My.Resources.LoadingEmployees)
            oleDBAdapter.Fill(ds, "Employees")
            repositoryItemLookUpEdit3.DataSource = ds.Tables("Employees")
        End Sub
        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            Dim ds As New DataSet()
            SetWaitDialogCaption(My.Resources.LoadingTables)
            ds.ReadXml(dataFileName)
            gridControl2.DataSource = ds.Tables("Orders")
            repositoryItemLookUpEdit2.DataSource = ds.Tables("Customers")
            repositoryItemLookUpEdit3.DisplayMember = "LastName"
            repositoryItemLookUpEdit3.DataSource = ds.Tables("Employees")
        End Sub

        Private Sub CustomDataSummaries_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            UpdateCaptions(numCustom.Value)
        End Sub
#End Region
#Region "Custom summaries"
        '<gridControl2>
        Private Sub InitStartValue()
            totalCount = 0
            totalSum = 0
        End Sub
        Private Sub gridView2_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles gridView2.CustomSummaryCalculate
            If e.SummaryProcess = CustomSummaryProcess.Start Then
                InitStartValue()
            End If
            If e.SummaryProcess = CustomSummaryProcess.Calculate Then
                If e.FieldValue IsNot Nothing AndAlso e.FieldValue IsNot DBNull.Value Then
                    If CDec(e.FieldValue) >= numCustom.Value Then
                        If e.IsGroupSummary Then
                            totalCount += 1
                        End If
                        If e.IsTotalSummary Then
                            totalSum += CDec(e.FieldValue)
                        End If
                    End If
                End If
                If e.IsGroupSummary Then
                    e.TotalValue = totalCount
                End If
                If e.IsTotalSummary Then
                    e.TotalValue = totalSum
                End If
            End If
        End Sub
        '</gridControl2>

        '<numCustom>
        Private Sub numCustom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numCustom.EditValueChanged
            CustomGridView.UpdateSummary()
            '<skip>
            UpdateCaptions(numCustom.Value)
            '</skip>
        End Sub
        '</numCustom>

        Private Sub UpdateCaptions(ByVal d As Decimal)
            CustomGridView.GroupSummary(0).DisplayFormat = String.Format(My.Resources.CustomOrderCountCaption, d) & " = {0})"
            OnSetCaption("")
            gridView2.FormatConditions(0).Value1 = d
        End Sub
        Protected Overrides Sub OnSetCaption(ByVal fCaption As String)
            fCaption = String.Format(My.Resources.CustomSummaryCaption, numCustom.Value)
            If Caption IsNot Nothing Then
                Caption.Text = String.Format("{0} ({1})", TutorialName, fCaption)
            End If
        End Sub
#End Region
#Region "Custom summaries appearance"
        Private Sub gridView2_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gridView2.PopupMenuShowing
            Dim menu As DevExpress.XtraGrid.Menu.GridViewFooterMenu = TryCast(e.Menu, DevExpress.XtraGrid.Menu.GridViewFooterMenu)
            If menu IsNot Nothing AndAlso menu.Column IsNot Nothing Then
                If menu.Column.FieldName = "Freight" Then
                    For Each item As DevExpress.Utils.Menu.DXMenuItem In menu.Items
                        item.Enabled = False
                    Next item
                End If
            End If
        End Sub

        Private Sub gridView2_CustomDrawFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles gridView2.CustomDrawFooterCell
            If e.Column.FieldName = "Freight" Then
                AppearanceHelper.Apply(e.Appearance, footerApp)
            End If
        End Sub
#End Region
    End Class
End Namespace

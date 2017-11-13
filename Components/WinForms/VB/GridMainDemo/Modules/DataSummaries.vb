Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for DataSummaries.
    ''' </summary>
    Partial Public Class DataSummaries
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\DataSummaries.vb"
            TutorialInfo.WhatsThisXMLFile = "DataSummaries.xml"
            InitNWindData()
            InitSummaries()
            InitEditing()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
        '<gridControl1>
        Private gsiSummary, gsiMultiSummary, gsiMultiSummaryDetail, gsiDisplaySummary, gsiDisplaySummaryDetails As GridGroupSummaryItemCollection
        '</gridControl1>

        Private displaySummary As Boolean = False
        #Region "Init"
        Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
            Get
                Return advBandedGridView1
            End Get
        End Property


        Private ReadOnly Property CurrentGrid() As GridControl
            Get
                Return gridControl1
            End Get
        End Property
        Private ReadOnly Property CurrentView() As GridView
            Get
                Return advBandedGridView1
            End Get
        End Property
        Private ReadOnly Property CurrentDetailView() As GridView
            Get
                Return gridView1
            End Get
        End Property

        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim oleDBAdapter As New OleDbDataAdapter("SELECT * FROM Products", connectionString)
            SetWaitDialogCaption(My.Resources.LoadingProducts)
            oleDBAdapter.Fill(dsNWindProducts1.Products)

            oleDBAdapter = New OleDbDataAdapter("SELECT * FROM [Order Details]", connectionString)
            SetWaitDialogCaption(My.Resources.LoadingOrderDetails)
            oleDBAdapter.Fill(dsNWindProducts1.Order_Details)

            oleDBAdapter = New OleDbDataAdapter("SELECT * FROM Suppliers", connectionString)
            SetWaitDialogCaption(My.Resources.LoadingSuppliers)
            oleDBAdapter.Fill(dsNWindProducts1.Suppliers)

            DemoHelper.AddCategoryImagesToEdit(connectionString, repositoryItemImageComboBox1)
        End Sub
        Private Sub InitEditing()
            gridControl1.ForceInitialize()
            colSupplierID.GroupIndex = 0
            colPrice.GroupIndex = 0
            SetShowFooter(chShowFooter.Checked)
            chAlignSummary.Checked = True
            OnSummaryChecked(chDisplaySummary)
        End Sub
        Private Sub UpdateMasterDetailSettings()
            CurrentView.BeginUpdate()
            CurrentView.ExpandAllGroups()
            CurrentView.FocusedRowHandle = 0
            CurrentView.TopRowIndex = 0
            CurrentView.SetMasterRowExpanded(CurrentView.FocusedRowHandle, True)
            If ceMasterDetail.Checked Then
                If Not FirstDetailView Is Nothing Then
                    FirstDetailView.ExpandGroupRow(-1)
                End If
            Else
                CurrentDetailView.ExpandAllGroups()
            End If
            CurrentView.EndUpdate()
        End Sub
        ReadOnly Property FirstDetailView As GridView
            Get
                Return TryCast(CurrentView.GetDetailView(0, 0), GridView)
            End Get
        End Property
        '<gridControl1>
        Private Sub InitSummaries()
            ' ~row summary 
            gsiSummary = New GridGroupSummaryItemCollection(CurrentView)
            gsiSummary.Add(SummaryItemType.Count, "ProductID")

            ' ~multi row summary 
            gsiMultiSummary = New GridGroupSummaryItemCollection(CurrentView)
            gsiMultiSummary.Add(SummaryItemType.Count, "ProductID")
            gsiMultiSummary.Add(SummaryItemType.Average, "UnitPrice", Nothing, My.Resources.AvgByPriceFormatCurrency)

            ' ~multi row summary for detail 
            gsiMultiSummaryDetail = New GridGroupSummaryItemCollection(CurrentDetailView)
            gsiMultiSummaryDetail.Add(SummaryItemType.Count, "OrderID")
            gsiMultiSummaryDetail.Add(SummaryItemType.Sum, "SubTotal", Nothing, My.Resources.SubTotalFormatCurrency)

            ' ~row footer summary 
            gsiDisplaySummary = New GridGroupSummaryItemCollection(CurrentView)
            gsiDisplaySummary.Add(SummaryItemType.Max, "UnitsOnOrder", colUnitsOnOrder, My.Resources.MaxFormat)
            gsiDisplaySummary.Add(SummaryItemType.Sum, "UnitsInStock", colUnitsInStock, My.Resources.SumFormat)
            gsiDisplaySummary.Add(SummaryItemType.Average, "UnitPrice", colUnitPrice, My.Resources.AvgFormatCurrency)
            gsiDisplaySummary.Add(SummaryItemType.Count, "ProductName", colProductName)

            ' ~row footer summary for details 
            gsiDisplaySummaryDetails = New GridGroupSummaryItemCollection(CurrentDetailView)
            gsiDisplaySummaryDetails.Add(SummaryItemType.Sum, "SubTotal", colSubTotal, My.Resources.SumFormatCurrency)
            gsiDisplaySummaryDetails.Add(SummaryItemType.Min, "Quantity", colQuantity, My.Resources.MinFormat)
        End Sub
        '</gridControl1>

        Private Sub DataSummaries_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            UpdateMasterDetailSettings()
        End Sub
        #End Region
        #Region "Editing"
        '<chShowFooter>
        Private Sub SetShowFooter(ByVal show As Boolean)
            CurrentView.OptionsView.ShowFooter = show
            CurrentDetailView.OptionsView.ShowFooter = show
        End Sub
        Private Sub chShowFooter_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chShowFooter.CheckedChanged
            Dim chb As CheckEdit = TryCast(sender, CheckEdit)
            SetShowFooter(chb.Checked)

        End Sub
        '</chShowFooter>

        Private Sub SaveDisplaySummary()
            If displaySummary Then
                gsiDisplaySummary.Assign(CurrentView.GroupSummary)
                gsiDisplaySummaryDetails.Assign(CurrentDetailView.GroupSummary)
                CurrentView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleIfExpanded
                CurrentDetailView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleIfExpanded
            End If
            displaySummary = False
        End Sub
        #End Region
        Private Function GetSubTotalFromDataRow(ByVal row_Renamed As DataRow) As Decimal
            Dim q As Decimal = Convert.ToDecimal(row_Renamed("Quantity"))
            Dim p As Decimal = Convert.ToDecimal(row_Renamed("UnitPrice"))
            Dim d As Decimal = Convert.ToDecimal(row_Renamed("Discount"))
            Return q * p * (1 - d)
        End Function

        Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
            If e.IsSetData OrElse e.Column.FieldName <> "SubTotal" Then
                Return
            End If
            Dim view As GridView = TryCast(sender, GridView)
            e.Value = GetSubTotalFromDataRow(CType(e.Row, DataRowView).Row)
        End Sub

        Private updateInfo As Boolean = False
        Private Sub chSummary_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chDisplaySummary.CheckedChanged, chMultiSummary.CheckedChanged, chSummary.CheckedChanged
            If updateInfo Then
                Return
            End If
            OnSummaryChecked(TryCast(sender, CheckEdit))
        End Sub

        '<gridControl1>
        Private Sub OnSummaryChecked(ByVal edit As CheckEdit)
            If edit.Properties.Tag Is Nothing Then
                Return
            End If
            updateInfo = True
            Dim caption As String = edit.Properties.Tag.ToString()
            Select Case caption
                Case "Summary"
                    chSummary.Checked = True
                    chAlignSummary.Enabled = False
                    SaveDisplaySummary()
                    CurrentView.GroupSummary.Assign(gsiSummary)
                    CurrentDetailView.GroupSummary.Assign(gsiSummary)
                Case "Multi Summary"
                    chMultiSummary.Checked = True
                    chAlignSummary.Enabled = False
                    SaveDisplaySummary()
                    CurrentView.GroupSummary.Assign(gsiMultiSummary)
                    CurrentDetailView.GroupSummary.Assign(gsiMultiSummaryDetail)
                Case "Display Summary"
                    chDisplaySummary.Checked = True
                    chAlignSummary.Enabled = True
                    displaySummary = True
                    CurrentView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways
                    CurrentDetailView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways
                    CurrentView.GroupSummary.Assign(gsiDisplaySummary)
                    CurrentDetailView.GroupSummary.Assign(gsiDisplaySummaryDetails)
            End Select
            UpdateAlignSummary()
            UpdateMasterDetailSettings()
            updateInfo = False
        End Sub

        Private Sub UpdateAlignSummary()
            CurrentDetailView.OptionsBehavior.AlignGroupSummaryInGroupRow = If(chAlignSummary.Enabled AndAlso chAlignSummary.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub
        '</gridControl1>
        Private Sub chAlignSummary_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chAlignSummary.CheckedChanged
            UpdateAlignSummary()
        End Sub

        Private Sub ceMasterDetail_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceMasterDetail.CheckedChanged
            If ceMasterDetail.Checked Then
                colOrderID.GroupIndex = -1
                colPrice.GroupIndex = 0
                gridControl1.MainView = CurrentView
                gridControl1.DataSource = dsNWindProducts1.Products
                colProduct.Visible = False
            Else
                colPrice.GroupIndex = -1
                colOrderID.GroupIndex = 0
                gridControl1.MainView = CurrentDetailView
                gridControl1.DataSource = dsNWindProducts1.Order_Details
                colProduct.VisibleIndex = 0
            End If
            UpdateMasterDetailSettings()
        End Sub
    End Class
End Namespace

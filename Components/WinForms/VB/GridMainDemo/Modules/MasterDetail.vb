Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports DevExpress.XtraGrid
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for MasterDetail.
    ''' </summary>
    Partial Public Class MasterDetail
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\MasterDetail.vb"
            TutorialInfo.WhatsThisXMLFile = "MasterDetail.xml"

            gridControl1.ForceInitialize()

            InitNWindData()
            InitEditing()
            InitMasterDetailDemo()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
            Get
                Return advBandedGridView1
            End Get
        End Property
        Public Overrides ReadOnly Property HasActiveDemo() As Boolean
            Get
                Return True
            End Get
        End Property
        
        #Region "Init"
        Private ReadOnly Property CurrentGrid() As GridControl
            Get
                Return gridControl1
            End Get
        End Property
        Private ReadOnly Property MainView() As GridView
            Get
                Return advBandedGridView1
            End Get
        End Property
        Private ReadOnly Property ProductView() As GridView
            Get
                Return gridView1
            End Get
        End Property

        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim oleDBAdapter1 As New OleDbDataAdapter("SELECT * FROM Suppliers", connectionString)
            Dim oleDBAdapter2 As New OleDbDataAdapter("SELECT * FROM Products", connectionString)
            Dim oleDBAdapter3 As New OleDbDataAdapter("SELECT * FROM [Order Details]", connectionString)
            Dim oleDBAdapter4 As New OleDbDataAdapter("SELECT * FROM CategoryProducts", connectionString)

            SetWaitDialogCaption(My.Resources.LoadingSuppliers)
            oleDBAdapter1.Fill(dsNWindSupplier1.Suppliers)

            SetWaitDialogCaption(My.Resources.LoadingProducts)
            oleDBAdapter2.Fill(dsNWindSupplier1.Products)

            SetWaitDialogCaption(My.Resources.LoadingOrderDetails)
            oleDBAdapter3.Fill(dsNWindSupplier1.Order_Details)

            SetWaitDialogCaption(My.Resources.LoadingCategoryProducts)
            oleDBAdapter4.Fill(dsNWindSupplier1.CategoryProducts)
            DemoHelper.AddCategoryImagesToEdit(connectionString, repositoryItemImageComboBox1)
        End Sub
        Private Sub InitMasterDetailDemo()
            MainView.BeginUpdate()
            MainView.FocusedRowHandle = 0
            MainView.SetMasterRowExpanded(MainView.FocusedRowHandle, True)
            Dim gv As GridView = TryCast(MainView.GetVisibleDetailView(MainView.FocusedRowHandle), GridView)
            If gv IsNot Nothing Then
                gv.SetMasterRowExpanded(0, True)
            End If
            MainView.SetMasterRowExpandedEx(1, 1, True)
            seVertIndent.Value = 4
            MainView.EndUpdate()
        End Sub
        Private Sub InitEditing()
            InitCheckButtons()
            SetZoom(imageComboBoxEdit1.SelectedIndex)
        End Sub
        Private Sub InitCheckButtons()
            icbDetailMode.Properties.Items.Add(DetailMode.Classic.ToString(), DetailMode.Classic, -1)
            icbDetailMode.Properties.Items.Add(DetailMode.Embedded.ToString(), DetailMode.Embedded, -1)
            icbDetailMode.EditValue = MainView.OptionsDetail.DetailMode
            ceShowEmbeddedDetailIndent.Checked = MainView.OptionsDetail.ShowEmbeddedDetailIndent <> Utils.DefaultBoolean.False
            ceTabs.Checked = MainView.OptionsDetail.ShowDetailTabs
            ceToolTips.Checked = MainView.OptionsDetail.EnableDetailToolTip
            ceMain.Checked = MainView.OptionsDetail.EnableMasterViewMode
        End Sub
        #End Region
        #Region "Editing"
        '<imageComboBoxEdit1>
        Private Sub SetZoom(ByVal allow As Boolean, ByVal [auto] As Boolean)
            MainView.OptionsDetail.AllowZoomDetail = allow
            MainView.OptionsDetail.AutoZoomDetail = [auto]
            ProductView.OptionsDetail.AllowZoomDetail = allow
            ProductView.OptionsDetail.AutoZoomDetail = [auto]
        End Sub

        Private Sub SetZoom(ByVal index As Integer)
            Select Case index
                Case 0 '"Auto Zoom"
                    SetZoom(True, True)
                Case 1 '"Manual Zoom"
                    SetZoom(True, False)
                Case 2 '"No Zoom"
                    SetZoom(False, False)
            End Select
            MainView.CollapseAllDetails()
        End Sub

        Private Sub imageComboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles imageComboBoxEdit1.SelectedIndexChanged
            SetZoom(imageComboBoxEdit1.SelectedIndex)
        End Sub
        '</imageComboBoxEdit1>
        '<ceTabs>
        Private Sub ceTabs_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceTabs.CheckedChanged
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            MainView.OptionsDetail.ShowDetailTabs = ce.Checked
            MainView.CollapseAllDetails()
            ProductView.BorderStyle = If(MainView.OptionsDetail.ShowDetailTabs, BorderStyles.NoBorder, BorderStyles.Default)
        End Sub
        '</ceTabs>
        '<ceToolTips>
        Private Sub ceToolTips_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceToolTips.CheckedChanged
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            MainView.OptionsDetail.EnableDetailToolTip = ce.Checked
        End Sub
        '</ceToolTips>
        '<ceMain>
        Private Sub ceMain_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceMain.CheckedChanged
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            MainView.OptionsDetail.EnableMasterViewMode = ce.Checked
            MainView.OptionsView.ShowChildrenInGroupPanel = ce.Checked
            '<skip>
            UpdateEnabledOptions()
            InitMasterDetailDemo()
            '</skip>
        End Sub
        '</ceMain>
        Private Sub UpdateEnabledOptions()
            ceToolTips.Enabled = MainView.OptionsDetail.EnableMasterViewMode
            ceTabs.Enabled = ceToolTips.Enabled
            imageComboBoxEdit1.Enabled = ceTabs.Enabled
            icbDetailMode.Enabled = imageComboBoxEdit1.Enabled
            ceShowEmbeddedDetailIndent.Enabled = MainView.OptionsDetail.DetailMode = DetailMode.Embedded AndAlso MainView.OptionsDetail.EnableMasterViewMode
            seVertIndent.Enabled = ceMain.Checked
            lciZooming.Enabled = MainView.OptionsDetail.DetailMode <> DetailMode.Embedded
            lciDetailIndent.Enabled = lciZooming.Enabled
        End Sub
        '<seVertIndent>
        Private Sub seVertIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seVertIndent.EditValueChanged
            For Each view As DevExpress.XtraGrid.Views.Base.BaseView In gridControl1.Views
                Dim gView As GridView = TryCast(view, GridView)
                If gView IsNot Nothing Then
                    gView.DetailVerticalIndent = CInt((seVertIndent.Value))
                End If
            Next view
        End Sub
        '</seVertIndent>
        Private Sub icbDetailMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbDetailMode.SelectedIndexChanged
            MainView.OptionsDetail.DetailMode = CType(icbDetailMode.EditValue, DetailMode)
            UpdateEnabledOptions()
            InitMasterDetailDemo()
            MainView.TopRowIndex = 0
        End Sub


        Private Sub ceShowEmbeddedDetailIndent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowEmbeddedDetailIndent.CheckedChanged
            MainView.OptionsDetail.ShowEmbeddedDetailIndent = If(ceShowEmbeddedDetailIndent.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub
        #End Region
    End Class
End Namespace

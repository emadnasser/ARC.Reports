Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for ColumnCustomization.
    ''' </summary>
    Partial Public Class ColumnCustomization
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            AddHandler tmr.Tick, AddressOf tmr_Tick
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
        Private _show As Boolean = False
        Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
            Get
                Return advBandedGridView1
            End Get
        End Property
        Private Sub ColumnCustomization_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitNWindData()
            InitCustomization()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\ColumnCustomization.vb"
            TutorialInfo.WhatsThisXMLFile = "ColumnCustomization.xml"
        End Sub

        Private tmr As New Timer()
        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            _show = True
            tmr.Start()
        End Sub

        Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
            tmr.Stop()
            If Visible Then
                ShowColumnSelector()
            End If
        End Sub
        Private tblGrid As String = "Orders"
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim ds As New DataSet()
            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT [Order Details].*, Orders.*, Employees.*, Products.*, Customers.*, Categories.* FROM Categories INNER JOIN (Customers INNER JOIN (Products INNER JOIN (Employees INNER JOIN (Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Employees.EmployeeID = Orders.EmployeeID) ON Products.ProductID = [Order Details].ProductID) ON Customers.CustomerID = Orders.CustomerID) ON Categories.CategoryID = Products.CategoryID;", connectionString)
            SetWaitDialogCaption(My.Resources.LoadingOrderDetails)
            oleDbDataAdapter.Fill(ds, tblGrid)
            Dim dvManager As New DataViewManager(ds)
            Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tblGrid))

            gridControl1.DataSource = dv
        End Sub
        Private initData As Boolean = False
        Private Sub InitCustomization()
            initData = True
            Try
                ccbSnapMode.Properties.SetFlags(GetType(DevExpress.Utils.Controls.SnapMode))
                For i As Integer = ccbSnapMode.Properties.Items.Count - 1 To 0 Step -1
                    If CInt((ccbSnapMode.Properties.Items(i).Value)) < 0 OrElse CInt((ccbSnapMode.Properties.Items(i).Value)) > 8 Then
                        ccbSnapMode.Properties.Items.RemoveAt(i)
                    End If
                Next i

                checkEdit1.Checked = advBandedGridView1.OptionsCustomization.AllowChangeColumnParent
                checkEdit2.Checked = advBandedGridView1.OptionsCustomization.AllowChangeBandParent
                checkEdit3.Checked = advBandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm
                checkEdit4.Checked = advBandedGridView1.OptionsCustomization.CustomizationFormSearchBoxVisible
                ccbSnapMode.EditValue = advBandedGridView1.OptionsCustomization.CustomizationFormSnapMode
            Finally
                initData = False
            End Try
        End Sub
        '<simpleButton1>
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
            _show = Not _show
            ShowColumnSelector()
        End Sub

        Private Sub ShowColumnSelector()
            ShowColumnSelector(True)
        End Sub
        Private Sub ShowColumnSelector(ByVal showForm As Boolean)
            If _show Then
                simpleButton1.Text = My.Resources.HideColumnsSelector
                If showForm Then
                    advBandedGridView1.ColumnsCustomization()
                End If
            Else
                simpleButton1.Text = My.Resources.ShowColumnsSelector
                If showForm Then
                    advBandedGridView1.DestroyCustomization()
                End If
            End If
        End Sub
        '</simpleButton1>
        Private Sub advBandedGridView1_ShowCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles advBandedGridView1.ShowCustomizationForm
            _show = True
            ShowColumnSelector(False)
        End Sub

        Private Sub advBandedGridView1_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles advBandedGridView1.HideCustomizationForm
            _show = False
            ShowColumnSelector(False)
        End Sub
        '<checkEdit1>
        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
            Dim edit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
            advBandedGridView1.OptionsCustomization.AllowChangeColumnParent = edit.Checked
        End Sub
        '</checkEdit1>
        '<checkEdit2>
        Private Sub checkEdit2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit2.CheckedChanged
            Dim edit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
            advBandedGridView1.OptionsCustomization.AllowChangeBandParent = edit.Checked
        End Sub
        '</checkEdit2>
        '<checkEdit3>
        Private Sub checkEdit3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit3.CheckedChanged
            Dim edit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
            advBandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm = edit.Checked
        End Sub
        '</checkEdit3>
        Private Sub checkEdit4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit4.CheckedChanged
            Dim edit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
            advBandedGridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = edit.Checked
        End Sub
        #Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport() As Boolean
            Get
                Return False
            End Get
        End Property
        #End Region

        Private Sub ccbSnapMode_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ccbSnapMode.EditValueChanged
            If initData Then
                Return
            End If
            Dim edit As DevExpress.XtraEditors.CheckedComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.CheckedComboBoxEdit)
            If Not String.IsNullOrEmpty(edit.Text) Then
                advBandedGridView1.OptionsCustomization.CustomizationFormSnapMode = CType(edit.EditValue, DevExpress.Utils.Controls.SnapMode)
            End If
        End Sub
    End Class
End Namespace

Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.OleDb

Namespace DevExpress.XtraLayout.Demos
    ''' <summary>
    ''' Summary description for Employees.
    ''' </summary>
    Partial Public Class MasterDetail
        Inherits BaseTutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            layoutControl1.SetDefaultLayout()
            InitPanels()
            InitData()
            pictureEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories1, "Categories.Picture"))

            ' TODO: Add any initialization after the InitForm call

        End Sub

        Public Overrides ReadOnly Property BaseLayout() As LayoutControl
            Get
                Return layoutControl1
            End Get
        End Property
        Protected Overrides ReadOnly Property FileMask() As String
            Get
                Return "md_"
            End Get
        End Property

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim oleDBAdapter1 As New OleDbDataAdapter("SELECT * FROM Categories", con)
                Dim oleDBAdapter2 As New OleDbDataAdapter("SELECT * FROM Products", con)
                Dim oleDBAdapter3 As New OleDbDataAdapter("SELECT * FROM [Order Details]", con)
                Dim oleDBAdapter4 As New OleDbDataAdapter("SELECT * FROM Suppliers", con)

                SetWaitDialogCaption("Loading Categories...")
                oleDBAdapter1.Fill(dsCategories1.Categories)

                SetWaitDialogCaption("Loading Products...")
                oleDBAdapter2.Fill(dsCategories1.Products)

                SetWaitDialogCaption("Loading Order Details...")
                oleDBAdapter3.Fill(dsCategories1.Order_Details)

                SetWaitDialogCaption("Loading Suppliers...")
                oleDBAdapter4.Fill(dsCategories1.Suppliers)

            End If
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
            layoutControl1.BeginUpdate()
            spinEdit3.Enabled = Not checkEdit1.Checked
            spinEdit2.Enabled = spinEdit3.Enabled
            spinEdit1.Enabled = spinEdit2.Enabled
            calcEdit1.Enabled = spinEdit1.Enabled
            lookUpEdit1.Enabled = calcEdit1.Enabled
            textEdit4.Enabled = lookUpEdit1.Enabled
            textEdit2.Enabled = textEdit4.Enabled
            layoutControl1.EndUpdate()
        End Sub

        Private Sub Detail_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEdit5.Validated, calcEdit2.Validated, spinEdit4.Validated
            CType(Me.BindingContext(Me.dataNavigator3.DataSource, Me.dataNavigator3.DataMember), CurrencyManager).EndCurrentEdit()
        End Sub
    End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class Databinding
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitData()
        End Sub
        Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            FindForm().Text = ArcScaleComponent1.Value.ToString()
            gaugeControl1.Invalidate()
            gaugeControl1.Refresh()
        End Sub
        Sub Databinding_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        End Sub
        Protected Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim oleDBAdapter1 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM Categories", con)
                Dim oleDBAdapter2 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM Products", con)
                Dim oleDBAdapter3 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM [Order Details]", con)
                Dim oleDBAdapter4 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM Suppliers", con)


                SetWaitDialogCaption("Loading Products...")
                oleDBAdapter2.Fill(dsCategories.Products)


                SetWaitDialogCaption("Loading Suppliers...")
                oleDBAdapter4.Fill(dsCategories.Suppliers)

            End If
        End Sub
    End Class
End Namespace

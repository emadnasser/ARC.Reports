Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridUnboundModeViaDataTable.
    ''' </summary>
    Partial Public Class GridUnboundModeViaDataTable
        Inherits TutorialControl
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Private Sub GridUnboundModeViaDataTable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            FillData()
            InitGridColumns()
        End Sub

        '<gridControl1>
        Private data As DataTable
        Private Sub InitData()
            data = New DataTable("ColumnsTable")
            data.BeginInit()
            AddColumn(data, "ID", System.Type.GetType("System.Int32"), True)
            AddColumn(data, "First Name", System.Type.GetType("System.String"))
            AddColumn(data, "Last Name", System.Type.GetType("System.String"))
            AddColumn(data, "Payment Type", System.Type.GetType("System.String"))
            AddColumn(data, "Customer", System.Type.GetType("System.Boolean"))
            AddColumn(data, "Payment Amount", System.Type.GetType("System.Single"))
            data.EndInit()
        End Sub
        '</gridControl1>

        Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type)
            AddColumn(data, name, type, False)
        End Sub
        Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
            Dim col As DataColumn
            col = New DataColumn(name, type)
            col.Caption = name
            col.ReadOnly = ro
            data.Columns.Add(col)
        End Sub

        Private Sub FillData()
            Dim sNames As String(,) = New String(,) {{"Elizabeth", "Lincoln"}, {"Yang", "Wang"}, {"Patricio", "Simpson"}, {"Francisco", "Chang"}, {"Ann", "Devon"}, {"Roland", "Mendel"}, {"Paolo", "Accorti"}, {"Diego", "Roel"}}
            Dim sType As String() = New String() {"Visa", "Master", "Cash"}
            data.Clear()
            Dim rnd As Random = New Random()
            Dim i As Integer = 0
            Do While i <= sNames.GetUpperBound(0)
                data.Rows.Add(New Object() {i + 1, sNames(i, 0), sNames(i, 1), sType(i Mod 3), rnd.Next(-1, 1), rnd.Next(10000) * 0.01})
                i += 1
            Loop
        End Sub

        '<gridControl1>
        Private Sub InitGridColumns()
            gridControl1.DataSource = data
            'The line below creates columns on the fly.
            gridControl1.DefaultView.PopulateColumns()
            gridView1.Columns("Payment Amount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            gridView1.Columns("Payment Amount").DisplayFormat.FormatString = "c"
            gridView1.BestFitColumns()
        End Sub
        '</gridControl1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

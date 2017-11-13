Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridStyleCondition.
    ''' </summary>
    Partial Public Class GridStyleCondition
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

        Private Sub GridStyleCondition_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            ConditionsAdjustment()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet()
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim tbl As String = "Products"
                Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tbl, con)
                oleDbDataAdapter.Fill(ds, tbl)

                Dim dvManager As DataViewManager = New DataViewManager(ds)
                Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tbl))

                gridControl1.DataSource = dv
            End If
        End Sub

        '<gridControl1>
        Private Sub ConditionsAdjustment()
            Dim cn As StyleFormatCondition
            cn = New StyleFormatCondition(FormatConditionEnum.LessOrEqual, gridView1.Columns("UnitPrice"), Nothing, 18)
            cn.Appearance.BackColor = Color.Yellow
            gridView1.FormatConditions.Add(cn)
            cn = New StyleFormatCondition(FormatConditionEnum.GreaterOrEqual, gridView1.Columns("UnitPrice"), Nothing, 40)
            cn.Appearance.BackColor = Color.Red
            cn.Appearance.ForeColor = Color.White
            gridView1.FormatConditions.Add(cn)
            '</gridControl1>
            cn = New StyleFormatCondition(FormatConditionEnum.Equal, gridView1.Columns("Discontinued"), Nothing, False)
            cn.ApplyToRow = True
            cn.Appearance.Font = New Font(AppearanceObject.DefaultFont, FontStyle.Bold)
            gridView1.FormatConditions.Add(cn)
            cn = New StyleFormatCondition(FormatConditionEnum.Equal, gridView1.Columns("Discontinued"), Nothing, True)
            cn.ApplyToRow = True
            cn.Appearance.Font = New Font(AppearanceObject.DefaultFont, FontStyle.Strikeout)
            cn.Appearance.ForeColor = SystemColors.ControlDark
            gridView1.FormatConditions.Add(cn)
            '<gridControl1>
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

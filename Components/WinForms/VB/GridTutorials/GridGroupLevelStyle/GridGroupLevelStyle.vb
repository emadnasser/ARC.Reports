Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridGroupLevelStyle.
    ''' </summary>
    Partial Public Class GridGroupLevelStyle
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

        Private Sub GridGroupLevelStyle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            InitGrid()
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

        Private Sub InitGrid()
            gridView1.ExpandAllGroups()
            spinEdit1.Value = gridView1.LevelIndent
        End Sub

        Private Function ColorFromID(ByVal index As Integer) As Color
            Select Case index
                Case 0
                    Return Color.LightSkyBlue
                Case 1
                    Return Color.LightCoral
                Case 2
                    Return Color.LightGreen
                Case 3
                    Return Color.Yellow
                Case 4
                    Return Color.LightYellow
                Case Else
                    Return Color.LightGray
            End Select
        End Function

        '<gridControl1>
        Private Sub gridView1_GroupLevelStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs) Handles gridView1.GroupLevelStyle
            e.LevelAppearance.BackColor = ColorFromID(e.Level)
            If e.Level = 1 Then
                e.LevelAppearance.ForeColor = Color.White
            End If
        End Sub
        '</gridControl1>

        Private Sub gridView1_EndGrouping(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView1.EndGrouping
            gridView1.ExpandAllGroups()
        End Sub

        Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEdit1.EditValueChanged
            Dim spinEdit As DevExpress.XtraEditors.SpinEdit = TryCast(sender, DevExpress.XtraEditors.SpinEdit)
            gridView1.LevelIndent = Convert.ToInt32(spinEdit1.Value)
        End Sub

        Public Overrides ReadOnly Property ShowLookAndFeel() As Boolean
            Get
                Return False
            End Get
        End Property
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

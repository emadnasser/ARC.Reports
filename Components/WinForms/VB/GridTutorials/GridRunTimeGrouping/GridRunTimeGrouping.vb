Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridRunTimeGrouping.
    ''' </summary>
    Partial Public Class GridRunTimeGrouping
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

        Private Sub GridRunTimeGrouping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            gridControl1.ForceInitialize()
            InitData()
            InitGroupedColumns()
            gridView1.ExpandAllGroups()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\cars.xml")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet()
                ds.ReadXml(DBFileName)
                gridControl1.DataSource = ds.Tables(0)
            End If
        End Sub

        Private Sub InitGroupedColumns()
            For i As Integer = gridView1.Columns.Count - 1 To 0 Step -1
                Dim checkEdit As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit()
                checkEdit.Text = gridView1.Columns(i).GetTextCaption()
                checkEdit.Checked = gridView1.Columns(i).GroupIndex <> -1
                checkEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
                checkEdit.Dock = System.Windows.Forms.DockStyle.Top
                checkEdit.Properties.FullFocusRect = True
                checkEdit.TabIndex = gridView1.Columns(i).AbsoluteIndex
                AddHandler checkEdit.CheckedChanged, AddressOf checkEditCheckedChanged
                panel1.Controls.Add(checkEdit)
            Next i
        End Sub

        '<panel1>
        Private Sub checkEditCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checkEdit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
            Dim checkEditIndex As Integer = checkEdit.TabIndex

            gridView1.BeginSort()

            If checkEdit.Checked Then
                gridView1.Columns(checkEditIndex).GroupIndex = gridView1.SortInfo.GroupCount
            Else
                gridView1.Columns(checkEditIndex).GroupIndex = -1
                gridView1.Columns(checkEditIndex).VisibleIndex = checkEditIndex
            End If

            gridView1.EndSort()
            gridView1.ExpandAllGroups()
            '</panel1>

            For Each ctrl As Control In panel1.Controls
                checkEdit = TryCast(ctrl, DevExpress.XtraEditors.CheckEdit)

                If gridView1.SortInfo.GroupCount >= panel1.Controls.Count - 1 Then
                    If (Not checkEdit.Checked) Then
                        checkEdit.Enabled = False
                    End If
                Else
                    If (Not checkEdit.Enabled) Then
                        checkEdit.Enabled = True
                    End If
                End If
            Next ctrl
            '<panel1>
        End Sub
        '</panel1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

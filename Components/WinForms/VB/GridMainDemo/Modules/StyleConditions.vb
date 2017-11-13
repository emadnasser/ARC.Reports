Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Localization

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for StyleConditions.
    ''' </summary>
    Partial Public Class StyleConditions
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\StyleConditions.vb;VB\GridMainDemo\Modules\ExpressionConditionsEditor.vb;VB\GridMainDemo\Modules\ConditionsEditor.vb;VB\GridMainDemo\Modules\ConditionsItem.vb"
            TutorialInfo.WhatsThisXMLFile = "StyleConditions.xml"
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
        Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
            Get
                If xtraTabControl1.SelectedTabPage Is xtraTabPage1 Then
                    Return gridView1
                End If
                Return gridView2
            End Get
        End Property
        Private Sub StyleConditions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitNWindData()
            gridView1.SetIcons()
            CreateTimer()
            ceTranslucentColors.Checked = True
            expressionConditionsEditor1.Init(gridView2)
        End Sub

        Protected Overrides Sub OnTick()
            gridView1.SetIcons()
        End Sub

        Private tblName As String = "Products"
        Private tblName2 As String = "[Order Details]"
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim ds As New DataSet()

            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblName, connectionString)
            oleDbDataAdapter.Fill(ds, tblName)
            oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblName2, connectionString)
            oleDbDataAdapter.Fill(ds, tblName2)

            Dim dvManager As New DataViewManager(ds)
            Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tblName))

            gridControl1.DataSource = dv
            gridControl2.DataSource = ds.Tables(tblName2)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblName)
        End Sub

        Private Sub gridView1_ShowFilterPopupListBox(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FilterPopupListBoxEventArgs) Handles gridView1.ShowFilterPopupListBox
            For i As Integer = 0 To e.ComboBox.Items.Count - 1
                If TypeOf e.ComboBox.Items(i) Is FilterItem Then
                    If CType(e.ComboBox.Items(i), FilterItem).Text = GridLocalizer.Active.GetLocalizedString(GridStringId.PopupFilterCustom) Then
                        e.ComboBox.Items.Insert(i, New FilterItem(My.Resources.ConditionsName, 4))
                        Exit For
                    End If
                End If
            Next i
        End Sub

        Private Sub gridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles gridView1.CustomDrawColumnHeader
            If MyGridView.IsCondition(e.Column) Then
                Dim headerFont As Font = gridView1.PaintAppearance.HeaderPanel.Font
                e.Appearance.Font = New Font(headerFont,If(headerFont.Bold, FontStyle.Underline Or FontStyle.Bold, FontStyle.Underline))
            End If
        End Sub

        Private Sub ceTranslucentColors_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceTranslucentColors.CheckedChanged
            If ceTranslucentColors.Checked Then
                gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(60, 0, 0, 240)
            Else
                gridView1.Appearance.FocusedRow.Reset()
            End If
        End Sub

        '<simpleBUtton1>
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            Dim editor As New ConditionsEditor(gridView1.FocusedColumn, Me.FindForm())
            Me.FindForm().Refresh()
            editor.ShowDialog()
        End Sub
        '</simpleButton1>
    End Class
End Namespace

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for Preview.
    ''' </summary>
    Partial Public Class Preview
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\Preview.vb"
            TutorialInfo.WhatsThisXMLFile = "Preview.xml"
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
            Get
                Return gridView1
            End Get
        End Property
        Private Sub Preview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitNWindData()
            InitGrid()
        End Sub

        Private tblName As String = "Employees"
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim ds As New DataSet()

            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblName, connectionString)
            oleDbDataAdapter.Fill(ds, tblName)

            gridControl1.DataSource = ds.Tables(tblName)
        End Sub
        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            Dim ds As New DataSet()
            ds.ReadXml(dataFileName)
            gridControl1.DataSource = ds.Tables(tblName)
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then

            End If
        End Sub

        Private Sub InitGrid()
            ceAuto.Checked = True
            ceCustom.Checked = True
            Dim separator As String = "------------------------"
            For Each column As DevExpress.XtraGrid.Columns.GridColumn In gridView1.Columns
                If Not column.FieldName.Equals("Photo") Then
                    cbName.Properties.Items.Add(New ImageComboBoxItem(column.GetCaption(), column.FieldName, -1))
                End If
            Next column
            cbName.Properties.Items.Add(New ImageComboBoxItem(separator, separator))
            cbName.Properties.Items.Add(New ImageComboBoxItem(My.Resources.CustomTextName, My.Resources.CustomTextName, -1))
            cbName.EditValue = "Notes"
        End Sub

        '<ceAuto>
        Private Sub ceAuto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceAuto.CheckedChanged
            Dim checkEdit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
            gridView1.OptionsView.AutoCalcPreviewLineCount = checkEdit.Checked
        End Sub
        '</ceAuto>

        '<ceCustom>
        Private Sub ceCustom_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCustom.CheckedChanged
            gridView1.Invalidate()
        End Sub

        Private Sub gridView1_CustomDrawRowPreview(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawRowPreview
            If ceCustom.Checked Then
                Dim dx As Integer = 5
                Dim r As Rectangle = e.Bounds
                r.X += e.Bounds.Height + dx * 2
                r.Width -= (e.Bounds.Height + dx * 3)
                e.Graphics.DrawImage(DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(CType(gridView1.GetDataRow(e.RowHandle)("Photo"), Byte())), e.Bounds.X + dx, e.Bounds.Y, CInt((e.Bounds.Height / 1.2)), e.Bounds.Height)
                e.Appearance.DrawString(e.Cache, gridView1.GetRowPreviewDisplayText(e.RowHandle), r)
                e.Handled = True
            End If
        End Sub
        '</ceCustom>

        '<cbName>
        Private Sub cbName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbName.SelectedIndexChanged
            Dim comboBox As DevExpress.XtraEditors.ImageComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ImageComboBoxEdit)
            If comboBox.EditValue.ToString().IndexOf("----") >= 0 Then
                comboBox.SelectedIndex = comboBox.Properties.Items.Count - 1
            Else
                gridView1.PreviewFieldName = comboBox.EditValue.ToString()
            End If
        End Sub

        Private Sub gridView1_CalcPreviewText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs) Handles gridView1.CalcPreviewText
            If cbName.SelectedIndex >= cbName.Properties.Items.Count - 1 Then
                Dim row_Renamed As DataRow = gridView1.GetDataRow(e.RowHandle)
                e.PreviewText = String.Format("{0} {1}" & ControlChars.CrLf & "{2}", row_Renamed("FirstName"), row_Renamed("LastName"), row_Renamed("Title"))
            End If
        End Sub
        '</cbName>


        '<ceUseMeasurePreviewHeight>
        Private Sub ceUseMeasurePreviewHeight_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceUseMeasurePreviewHeight.CheckedChanged
            gridView1.LayoutChanged()
            ceAuto.Enabled = Not ceUseMeasurePreviewHeight.Checked
        End Sub

        Private Sub gridView1_MeasurePreviewHeight(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles gridView1.MeasurePreviewHeight
            If ceUseMeasurePreviewHeight.Checked Then
                e.RowHeight = 80
            End If
        End Sub
        '</ceUseMeasurePreviewHeight>
    End Class
End Namespace

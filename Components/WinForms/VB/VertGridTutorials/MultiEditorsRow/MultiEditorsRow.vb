Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for MultiEditorsRow.
	''' </summary>
	Public Partial Class MultiEditorsRow
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

        Private lockUpdate As Boolean = False
        Private Sub MultiEditorsRow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            vGridControl1.FocusedRow = vGridControl1.Rows(0).ChildRows(0)
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Cars.xml")
            If DBFileName <> "" Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                vGridControl1.DataSource = dataSet.Tables(0).DefaultView
            End If
        End Sub


        '<checkBox1>
        Private customColors As Color() = New Color() {Color.Wheat, Color.PapayaWhip, Color.FloralWhite}
        Private Sub vGridControl1_CustomDrawRowHeaderCell(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs) Handles vGridControl1.CustomDrawRowHeaderCell
            If checkBox1.Checked Then
                If TypeOf e.Row Is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow AndAlso (Not e.Focused) Then
                    e.Appearance.BackColor = customColors(e.CellIndex)
                    e.Appearance.ForeColor = SystemColors.WindowText
                End If
            End If
        End Sub

        Private Sub vGridControl1_CustomDrawSeparator(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawSeparatorEventArgs) Handles vGridControl1.CustomDrawSeparator
            If checkBox1.Checked Then
                e.Appearance.BackColor = Color.Wheat
                e.Appearance.BackColor2 = Color.PapayaWhip
                e.Appearance.ForeColor = SystemColors.WindowText
            End If
        End Sub

        Private Sub vGridControl1_CustomDrawRowHeaderIndent(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderIndentEventArgs) Handles vGridControl1.CustomDrawRowHeaderIndent
            If checkBox1.Checked Then
                If TypeOf e.Row Is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow Then
                    e.Appearance.BackColor = Color.Wheat
                    e.Appearance.ForeColor = SystemColors.WindowText
                End If
            End If
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            vGridControl1.LayoutChanged()
        End Sub
        '</checkBox1>

        Private Sub vGridControl1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs) Handles vGridControl1.FocusedRowChanged
            SetSeparatorStyle()
        End Sub


        Private Sub SetSeparatorStyle()
            lockUpdate = True
            If TypeOf vGridControl1.FocusedRow Is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow Then
                Dim row As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow = TryCast(vGridControl1.FocusedRow, DevExpress.XtraVerticalGrid.Rows.MultiEditorRow)
                If row.SeparatorKind = DevExpress.XtraVerticalGrid.Rows.SeparatorKind.VertLine Then
                    comboBox1.SelectedIndex = 0
                Else
                    comboBox1.SelectedIndex = 1
                End If
                textBox1.Text = row.SeparatorString
                textBox1.Enabled = True
                comboBox1.Enabled = textBox1.Enabled
            Else
                textBox1.Enabled = False
                comboBox1.Enabled = textBox1.Enabled
            End If
            lockUpdate = False
        End Sub

        '<comboBox1>
        '<textBox1>
        Private Sub Separator_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged, comboBox1.SelectedIndexChanged
            If (Not lockUpdate) Then
                Dim row As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow = TryCast(vGridControl1.FocusedRow, DevExpress.XtraVerticalGrid.Rows.MultiEditorRow)
                If Not row Is Nothing Then
                    If comboBox1.SelectedIndex = 0 Then
                        row.SeparatorKind = DevExpress.XtraVerticalGrid.Rows.SeparatorKind.VertLine
                    Else
                        row.SeparatorKind = DevExpress.XtraVerticalGrid.Rows.SeparatorKind.String
                    End If
                    row.SeparatorString = textBox1.Text
                End If
            End If
        End Sub
		'</textBox1>
		'</comboBox1>
	End Class
End Namespace

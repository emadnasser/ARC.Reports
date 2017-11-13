Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridColumnCustomization.
	''' </summary>
	Public Partial Class GridColumnCustomization
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
        Private ColumnCustomizationVisible As Boolean = False

        Private Sub GridColumnCustomization_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            InitCustomization()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Contacts.xml")
            If DBFileName <> "" Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                gridControl1.DataSource = dataSet.Tables(0).DefaultView
            End If
        End Sub

        Private Sub InitCustomization()
            checkEdit1.Checked = advBandedGridView1.OptionsCustomization.AllowChangeColumnParent
            checkEdit2.Checked = advBandedGridView1.OptionsCustomization.AllowChangeBandParent
            checkEdit3.Checked = advBandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm
            ColumnCustomizationVisible = True
            ShowColumnSelector()
        End Sub

        '<simpleButton1>
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
            ColumnCustomizationVisible = Not ColumnCustomizationVisible
            ShowColumnSelector()
        End Sub


        Private Sub ShowColumnSelector()
            ShowColumnSelector(True)
        End Sub
        Private Sub ShowColumnSelector(ByVal showForm As Boolean)
            If ColumnCustomizationVisible Then
                simpleButton1.Text = "Hide Columns &Selector"
                If showForm Then
                    advBandedGridView1.ColumnsCustomization()
                End If
            Else
                simpleButton1.Text = "Show Columns &Selector"
                If showForm Then
                    advBandedGridView1.DestroyCustomization()
                End If
            End If
        End Sub

        Private Sub advBandedGridView1_ShowCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles advBandedGridView1.ShowCustomizationForm
            ColumnCustomizationVisible = True
            ShowColumnSelector(False)
        End Sub

        Private Sub advBandedGridView1_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles advBandedGridView1.HideCustomizationForm
            ColumnCustomizationVisible = False
            ShowColumnSelector(False)
        End Sub
        '</simpleButton1>

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

        Public Overrides Sub StartWhatsThis()
            ColumnCustomizationVisible = False
            ShowColumnSelector()
        End Sub
	End Class
End Namespace

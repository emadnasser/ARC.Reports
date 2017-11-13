Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridMasterDetail.
	''' </summary>
	Public Partial Class GridMasterDetail
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
		Private updateValues As Boolean = False
		Private Sub GridMasterDetail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			InitEditors()
			gridView1.SetMasterRowExpandedEx(0, 0, True)
			gridView1.SetMasterRowExpanded(1, True)
			gridView1.SetMasterRowExpanded(3, True)
		End Sub

		Private Sub InitData()
            Dim stream As System.IO.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Parents.xml")
			dsParents1.ReadXml(stream, XmlReadMode.IgnoreSchema)
		End Sub


		Private Sub InitEditors()
            imageComboBoxEdit1.Properties.Items.AddEnum(GetType(DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode))
            updateValues = True
			imageComboBoxEdit1.EditValue = gridView1.OptionsDetail.SmartDetailExpandButtonMode
			checkEdit1.EditValue = gridView1.OptionsDetail.EnableDetailToolTip
			checkEdit2.EditValue = gridView1.OptionsDetail.ShowDetailTabs
			updateValues = False
		End Sub

		'<imageComboBoxEdit1>
		Private Sub imageComboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles imageComboBoxEdit1.SelectedIndexChanged
			If updateValues Then
			Return
			End If
			Dim edit As DevExpress.XtraEditors.ImageComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ImageComboBoxEdit)
			gridView1.OptionsDetail.SmartDetailExpandButtonMode = CType(edit.EditValue, DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode)
		End Sub
		'</imageComboBoxEdit1>

		'<checkEdit1>
		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
			If updateValues Then
			Return
			End If
			Dim checkEdit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			gridView1.OptionsDetail.EnableDetailToolTip = checkEdit.Checked
		End Sub
		'</checkEdit1>

		'<checkEdit2>
		Private Sub checkEdit2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit2.CheckedChanged
			If updateValues Then
			Return
			End If
			Dim checkEdit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			gridView1.OptionsDetail.ShowDetailTabs = checkEdit.Checked
		End Sub
		'</checkEdit2>
	End Class
End Namespace

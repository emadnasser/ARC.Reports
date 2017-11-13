Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
'<comboBoxEdit1>
Imports DevExpress.Skins
'</comboBoxEdit1>
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridSkins.
	''' </summary>
	Public Partial Class GridSkins
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

		Private Sub GridSkins_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim xv As DevExpress.XtraGrid.Design.XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1, True)
			gridView1.ExpandAllGroups()
			InitSkinNames(comboBoxEdit1, gridControl1.LookAndFeel)
		End Sub
		'<comboBoxEdit1>
		Private Sub InitSkinNames(ByVal comboBox As ComboBoxEdit, ByVal lookAndFeel As UserLookAndFeel)
			For Each cnt As SkinContainer In SkinManager.Default.Skins
				comboBox.Properties.Items.Add(cnt.SkinName)
			Next cnt
			comboBox.EditValue = lookAndFeel.SkinName
		End Sub

		Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxEdit1.SelectedIndexChanged
			Dim cb As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
			gridControl1.LookAndFeel.SkinName = cb.EditValue.ToString()
		End Sub
		'</comboBoxEdit1>

		Public Overrides ReadOnly Property ShowLookAndFeel() As Boolean
			Get
				Return False
			End Get
		End Property
	End Class
End Namespace

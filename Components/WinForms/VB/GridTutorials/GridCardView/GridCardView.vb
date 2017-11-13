Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridCardView.
	''' </summary>
	Public Partial Class GridCardView
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

		#Region "Init"
		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\Cars.xml")
			If DBFileName <> "" Then
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXml(DBFileName)
				gridControl1.DataSource = dataSet.Tables(0).DefaultView
			End If
		End Sub

		Private Sub InitViewLayout()
			Dim LayoutFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\Layouts\cars_CardView.xml")
			If LayoutFileName <> "" Then
				InitEditors()
				cardView1.RestoreLayoutFromXml(LayoutFileName, Nothing)
			End If
		End Sub

		Private Sub InitEditors()
			Dim itemPictureEdit As RepositoryItemPictureEdit = New RepositoryItemPictureEdit()
			Dim itemSpinEdit As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
			Dim itemMemoExEdit As RepositoryItemMemoExEdit = New RepositoryItemMemoExEdit()
			Dim itemImageComboBox As RepositoryItemImageComboBox = New RepositoryItemImageComboBox()
			itemPictureEdit.Name = "repositoryItemPictureEdit1"
			itemSpinEdit.Name = "repositoryItemSpinEdit1"
			itemMemoExEdit.Name = "repositoryItemMemoExEdit1"
			itemImageComboBox.Name = "repositoryItemImageComboBox1"
			itemImageComboBox.Items.AddRange(New Object() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sports", "SPORTS", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Saloon", "SALOON", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "TRUCK", -1)})
            itemMemoExEdit.PopupFormSize = New Size(300, 150)
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { itemPictureEdit, itemSpinEdit, itemMemoExEdit, itemImageComboBox})
		End Sub
		#End Region
		Private Sub GridCardView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			InitViewLayout()
		End Sub
	End Class
End Namespace

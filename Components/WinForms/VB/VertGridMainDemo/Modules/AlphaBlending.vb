Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraVerticalGrid

Namespace DevExpress.XtraVerticalGrid.Demos
	''' <summary>
	''' Summary description for AlphaBlending.
	''' </summary>
	Partial Public Class AlphaBlending
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
		End Sub
		Public Overrides ReadOnly Property ExportControl() As VGridControlBase
			Get
				Return vGridControl1
			End Get
		End Property
		Public Overrides ReadOnly Property ViewOptionsControl() As VGridControlBase
			Get
				Return vGridControl1
			End Get
		End Property
		Private xs As New DevExpress.XtraVerticalGrid.Design.XAppearances(System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) & "\DevExpress.XtraVerticalGrid.Appearances.xml")
		#Region "Init"
		Private Sub AlphaBlending_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			InitStyles()
		End Sub
		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\Cars.xml")
			If DBFileName <> "" Then
				Dim dataSet As New DataSet()
				dataSet.ReadXml(DBFileName)
				vGridControl1.DataSource = dataSet.Tables(0).DefaultView
			End If
		End Sub


		Private Sub InitStyles()
			lsStyles.Items.AddRange(xs.FormatNames)
			lsStyles.SelectedIndex = If(lsStyles.Items.Count > 3, 4, 0)
			lsImages.SelectedIndex = 1
		End Sub
		#End Region
		#Region "Editing"
		Private Sub lsStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsStyles.SelectedIndexChanged
			If lsStyles.SelectedItem IsNot Nothing Then
				xs.LoadScheme(lsStyles.SelectedItem.ToString(), vGridControl1)
			End If
			RefreshAlphaBlending()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			xtraVertGridBlending1.ShowDialog()
		End Sub

		Private Function GetImage(ByVal s As String) As Image
            Dim str As System.IO.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(s & ".jpg")
			If str IsNot Nothing Then
				Return Bitmap.FromStream(str)
			End If
			Return Nothing
		End Function

		Private Sub lsImages_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsImages.SelectedIndexChanged
			If lsImages.SelectedItem IsNot Nothing Then
				xtraVertGridBlending1.VertGridControl.BackgroundImage = GetImage(lsImages.SelectedItem.ToString())
			End If
		End Sub

		Private Sub RefreshAlphaBlending()
			xtraVertGridBlending1.RefreshStyles()
		End Sub

		Private Sub chAlphaBlending_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chAlphaBlending.CheckedChanged
			xtraVertGridBlending1.Enabled = chAlphaBlending.Checked
			button1.Enabled = chAlphaBlending.Checked
		End Sub
		#End Region
	End Class
End Namespace

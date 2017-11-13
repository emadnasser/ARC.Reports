Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos
	''' <summary>
	''' Summary description for AlphaBlending.
	''' </summary>
	Partial Public Class AlphaBlending
		Inherits TutorialControl

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			CreateWaitDialog()
			InitializeComponent()
			InitNWindData()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
		Protected Overrides ReadOnly Property AllowAppearanceGroup() As Boolean
			Get
				Return False
			End Get
		End Property
		#Region "Init"
		Private Sub AlphaBlending_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			gridControl1.ForceInitialize()
			InitStyles()
		End Sub
		Private ReadOnly Property CurrentGrid() As GridControl
			Get
				Return gridControl1
			End Get
		End Property
		Protected Overrides Sub InitMDBData(ByVal connectionString As String)
			Dim ds As New DataSet()
			Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Employees", connectionString)

			SetWaitDialogCaption(My.Resources.LoadingEmployees)
			oleDbDataAdapter.Fill(ds, "Employees")

			CurrentGrid.DataSource = ds.Tables("Employees")
		End Sub
		Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
			Dim ds As New DataSet()
			SetWaitDialogCaption(My.Resources.LoadingTables)
			ds.ReadXml(dataFileName)

			CurrentGrid.DataSource = ds.Tables("Employees")
		End Sub
		Private Sub InitStyles()
			cbeStyles.Properties.Items.AddRange(GridRibbonMenuManager.XAppearances.FormatNames)
			cbeStyles.EditValue = "Vagabond"
			cbeImages.SelectedIndex = 1
		End Sub
		#End Region
		#Region "Grid events"
		Private Sub advBandedGridView1_EndGrouping(ByVal sender As Object, ByVal e As System.EventArgs) Handles advBandedGridView1.EndGrouping
			advBandedGridView1.ExpandAllGroups()
		End Sub
		#End Region
		#Region "Editing"
		Private Sub cbeStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbeStyles.SelectedIndexChanged
			If cbeStyles.EditValue IsNot Nothing Then
				GridRibbonMenuManager.XAppearances.LoadScheme(cbeStyles.EditValue.ToString(), CurrentGrid.MainView)
			End If
			RefreshAlphaBlending()
		End Sub

		Private Sub btnEditAlphaBlending_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditAlphaBlending.Click
			xtraGridBlending1.ShowDialog()
		End Sub

		Private Function GetImage(ByVal s As String) As Image
            Dim str As System.IO.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(s & ".jpg")
			If str IsNot Nothing Then
				Return Bitmap.FromStream(str)
			End If
			Return Nothing
		End Function

		Private Sub cbeImages_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbeImages.SelectedIndexChanged
			If cbeImages.EditValue IsNot Nothing Then
				xtraGridBlending1.GridControl.BackgroundImage = GetImage(cbeImages.EditValue.ToString())
			End If
		End Sub

		Private Sub RefreshAlphaBlending()
			If xtraGridBlending1.Enabled Then
				xtraGridBlending1.RefreshStyles()
			End If
		End Sub

		Private Sub chAlphaBlending_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chAlphaBlending.CheckedChanged
			Dim chb As CheckEdit = TryCast(sender, CheckEdit)
			xtraGridBlending1.Enabled = chb.Checked
			btnEditAlphaBlending.Enabled = chb.Checked
		End Sub
		#End Region
	End Class
End Namespace

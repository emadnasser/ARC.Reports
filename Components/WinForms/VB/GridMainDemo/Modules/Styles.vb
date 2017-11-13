Imports System.Collections
Imports System.ComponentModel
Imports System.Data.OleDb
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.XtraGrid.Demos
	''' <summary>
	''' Summary description for Styles.
	''' </summary>
	Partial Public Class Styles
		Inherits TutorialControl

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			CreateWaitDialog()
			InitializeComponent()

			InitNWindData()
			InitAppearance()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
		Private xapp As DevExpress.XtraGrid.Design.XAppearances
		Private styleUpdate As Boolean = False

		Protected Overrides ReadOnly Property AllowAppearanceGroup() As Boolean
			Get
				Return False
			End Get
		End Property
		Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
			Get
				Return CurrentGrid.MainView
			End Get
		End Property
		#Region "Init"

		Private Sub Styles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			xapp = New DevExpress.XtraGrid.Design.XAppearances(System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) & "\DevExpress.XtraGrid.Appearances.xml ")
			InitStyles()
		End Sub
		Private ReadOnly Property CurrentGrid() As GridControl
			Get
				Select Case xtcViews.SelectedTabPageIndex
					Case 1
						Return gridControl2
					Case 2
						Return gridControl3
				End Select
				Return gridControl1
			End Get
		End Property
		Private ReadOnly Property CurrentBlending() As DevExpress.XtraGrid.Blending.XtraGridBlending
			Get
				Select Case xtcViews.SelectedTabPageIndex
					Case 1
						Return xtraGridBlending2
					Case 2
						Return xtraGridBlending3
				End Select
				Return xtraGridBlending1
			End Get
		End Property
		Private Sub InitMenu()
			GridRibbonMenuManager.InitBlendingMenu(CurrentBlending)
		End Sub
		Protected Overrides Sub InitMDBData(ByVal connectionString As String)
			Dim dataSet As New DataSet()
			Dim oleDBAdapter As New OleDbDataAdapter("SELECT * FROM Customers", connectionString)

			SetWaitDialogCaption(My.Resources.LoadingCustomers)
			oleDBAdapter.Fill(dataSet, "Customers")
			gridControl2.DataSource = dataSet.Tables("Customers")
		End Sub
		Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
			Dim dataSet As New DataSet()
			SetWaitDialogCaption(My.Resources.LoadingTables)
			dataSet.ReadXml(dataFileName)

			gridControl2.DataSource = dataSet.Tables("Customers")

		End Sub
		Protected Overrides Sub InitNWindData()
			MyBase.InitNWindData()
			InitData()
		End Sub
		Private Sub InitData()
			Dim dataSet As DataSet
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Cars.xml")
			If DBFileName <> "" Then
				dataSet = New DataSet()
				SetWaitDialogCaption(My.Resources.LoadingCars)
				dataSet.ReadXml(DBFileName)
				gridControl1.DataSource = dataSet.Tables(0).DefaultView
			End If
			DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\DXProducts.xml")
			If DBFileName <> "" Then
				dataSet = New DataSet()
				SetWaitDialogCaption(My.Resources.LoadingDXProducts)
				dataSet.ReadXml(DBFileName)
				gridControl3.DataSource = dataSet.Tables(0).DefaultView
			End If
		End Sub

		Private Sub InitStyles()
			Try
				cbeStyles.Properties.Items.Clear()
				cbeStyles.Properties.Items.AddRange(xapp.FormatNames)
				gridControl1.Tag = 1
				gridControl2.Tag = 4
				gridControl3.Tag = 5
				cbeStyles.SelectedIndex = Convert.ToInt32(CurrentGrid.Tag)
				xapp.LoadScheme(cbeStyles.Properties.Items(Convert.ToInt32(gridControl1.Tag)).ToString(), gridControl1.MainView)
				xapp.LoadScheme(cbeStyles.Properties.Items(Convert.ToInt32(gridControl2.Tag)).ToString(), gridControl2.MainView)
				xapp.LoadScheme(cbeStyles.Properties.Items(Convert.ToInt32(gridControl3.Tag)).ToString(), gridControl3.MainView)
			Catch
			End Try
		End Sub
		Private Sub InitAppearance()
			gridControl2.ForceInitialize()
			gridControl3.ForceInitialize()
			gridView1.ExpandAllGroups()
			Dim s1() As String = {"", "AK", "BC", "CA", "Co. Cork", "DF", "ID", "Isle of Wight", "Lara", "MT", "NM", "Nueva Esparta", "OR", "Quebec", "RJ", "SP", "Tachira", "WA", "WY"}
			Dim s2() As String = {"Argentina", "Austria", "Belgium", "Brazil", "Canada", "Denmark", "F inland", "France", "Germany", "Ireland", "Italy", "Mexico", "Norway", "Poland", "Portugal", "Spain", "Sweden", "Switzerland", "UK", "USA", "Venezuela"}
			For Each s As String In s1
				repositoryItemComboBox1.Items.Add(s)
			Next s
			For Each s As String In s2
				repositoryItemComboBox2.Items.Add(s)
			Next s
			cardView1.FocusedRowHandle = 13
		End Sub
		#End Region
		#Region "Editing"
		Private Sub cbeStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbeStyles.SelectedIndexChanged
			If styleUpdate Then
				Return
			End If
			If cbeStyles.EditValue IsNot Nothing Then
				xapp.LoadScheme(cbeStyles.EditValue.ToString(), CurrentGrid.MainView)
				If CurrentBlending IsNot Nothing AndAlso CurrentBlending.Enabled Then
					CurrentBlending.RefreshStyles()
				End If
				CurrentGrid.Tag = cbeStyles.SelectedIndex
			End If
		End Sub


		Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtcViews.SelectedPageChanged
			InitMenu()
			styleUpdate = True
			cbeStyles.SelectedIndex = Convert.ToInt32(CurrentGrid.Tag)
			styleUpdate = False
			RibbonMenuManager.AllowExport(CurrentGrid.MainView)
		End Sub

		Private Sub ceNewStyles_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceNewStyles.CheckedChanged
			If xapp IsNot Nothing Then
				xapp.ShowNewStylesOnly = ceNewStyles.Checked
			End If
			cbeStyles.Properties.Items.Clear()
			cbeStyles.Properties.Items.AddRange(xapp.FormatNames)
			cbeStyles.SelectedIndex = Convert.ToInt32(CurrentGrid.Tag)
		End Sub
		Protected Overrides Sub OnSetCaption(ByVal caption As String)
			MyBase.OnSetCaption(caption)
			InitMenu()
		End Sub

		Private Sub btnEditAppearances_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditAppearances.Click
			Dim frm As New Appearances(CurrentGrid.MainView, Me.FindForm())
			frm.ShowDialog()
		End Sub
		#End Region
		#Region "Grid events"
		Private Sub gridView1_CalcPreviewText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs) Handles gridView1.CalcPreviewText
			If gridView1.GetDataRow(e.RowHandle) IsNot Nothing Then
				e.PreviewText = My.Resources.DescriptionFor & " " & gridView1.GetDataRow(e.RowHandle)("ContactName").ToString()
			End If
		End Sub
		#End Region
	End Class
End Namespace

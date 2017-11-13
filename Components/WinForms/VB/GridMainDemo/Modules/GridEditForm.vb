Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class GridEditForm
		Inherits TutorialControl

		Private pgOptions As New RibbonPageGroup("Edit Form Options")
		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\GridEditForm.vb"
            TutorialInfo.WhatsThisXMLFile = "GridEditForm.xml"
			'<gridControl2>
			advBandedGridView1.OptionsEditForm.CustomEditFormLayout = New AdvancedEditForm()
			'</gridControl2>
			InitVehiclesData()
			CreateTimer()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			CreateRibbonItems()
		End Sub
		Protected Overrides Sub SetVisibleCore(ByVal value As Boolean)
			MyBase.SetVisibleCore(value)
			pgOptions.Visible = value
		End Sub
		Private Sub CreateRibbonItems()
			pgOptions.ShowCaptionButton = False
			pgOptions.AllowTextClipping = False
			ParentFormMain.MainPage.Groups.Insert(3, pgOptions)
            Dim bItem As New BarButtonItem(ParentFormMain.Ribbon.Manager, "Options")
			bItem.Hint = pgOptions.Text
			bItem.LargeGlyph = My.Resources.properties_32x32
			AddHandler bItem.ItemClick, AddressOf OptionsItemClick
			pgOptions.ItemLinks.Add(bItem)
		End Sub

		Private ReadOnly Property CurrentGridView() As GridView
			Get
				If gridControl1.Visible Then
					Return gridView1
				End If
				Return advBandedGridView1
			End Get
		End Property
		Private Sub OptionsItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Using frm As New EditFormOptions(CurrentGridView, GridRibbonMenuManager.Manager)
				CurrentGridView.CloseEditForm()
				Dim res As DialogResult = frm.ShowDialog(Me.FindForm())
				If (CurrentGridView.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplace OrElse CurrentGridView.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplaceHideCurrentRow) AndAlso res = DialogResult.OK Then
					CurrentGridView.ShowEditForm()
				End If
			End Using
		End Sub
		Protected Overrides Sub OnTick()
			If DemosInfo.CurrentModule Is Me Then
				'<gridControl1>
'                
'                 ~Show the EditForm at startup:
'                 
				gridView1.ShowEditForm()
				'</gridControl1>

				gridControl2.ForceInitialize()
				advBandedGridView1.FocusedRowHandle = 0
			End If
		End Sub
		Protected Overrides Sub InitMDBData(ByVal connectionString As String)
			Dim tblModel As String = "Model", tblCategory As String = "Category", tblTrademark As String = "Trademark", tblModelFilter As String = "ModelFilter", tblBodyStyle As String = "BodyStyle", tblTransmissionType As String = "TransmissionType"
			Dim ds As New DataSet()

			FillTable(tblModel, Nothing, connectionString, ds)
			FillTable(tblModelFilter, String.Format("SELECT * FROM {0} WHERE [Photo] Is Not Null", tblModel), connectionString, ds)
			FillTable(tblCategory, Nothing, connectionString, ds)
			FillTable(tblTrademark, Nothing, connectionString, ds)
			FillTable(tblBodyStyle, Nothing, connectionString, ds)
			FillTable(tblTransmissionType, Nothing, connectionString, ds)

			SetGridDataSource(tblModel, ds, gridControl1)
			SetGridDataSource(tblModelFilter, ds, gridControl2)

			repositoryItemLookUpEdit1.DataSource = ds.Tables(tblCategory)
			repositoryItemLookUpEdit1.DropDownRows = ds.Tables(tblCategory).Rows.Count
			repositoryItemLookUpEdit2.DataSource = ds.Tables(tblBodyStyle)
			repositoryItemLookUpEdit2.DropDownRows = ds.Tables(tblBodyStyle).Rows.Count
			repositoryItemGridLookUpEdit1.DataSource = ds.Tables(tblTrademark)
			AddHandler repositoryItemGridLookUpEdit1.GetImageByValue, AddressOf repositoryItemGridLookUpEdit1_GetImageByValue

			CType(advBandedGridView1.OptionsEditForm.CustomEditFormLayout, AdvancedEditForm).InitData(ds)
		End Sub

		Private Sub FillTable(ByVal table As String, ByVal query As String, ByVal connectionString As String, ByVal ds As DataSet)
			If query Is Nothing Then
				query = String.Format("SELECT * FROM {0}", table)
			End If
			Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter(query, connectionString)
			SetWaitDialogCaption(String.Format("Loading {0}...", table))
			oleDbDataAdapter.Fill(ds, table)
		End Sub

		Private Sub SetGridDataSource(ByVal table As String, ByVal ds As DataSet, ByVal grid As GridControl)
			Dim dvManager As New DataViewManager(ds)
			Dim dv As DataView = dvManager.CreateDataView(ds.Tables(table))
			grid.DataMember = Nothing
			grid.DataSource = dv
		End Sub

		Private Sub repositoryItemGridLookUpEdit1_GetImageByValue(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
			DataHelper.LogoGridLookupGetImageByValue(sender, e)
		End Sub

		'<gridControl1>
'        
'         ~Use the MemoEdit in-place editor for the Description column in the EditForm instead of the MemoExEdit dropdown editor:
'         
		Private Sub gridView1_CustomRowCellEditForEditing(ByVal sender As Object, ByVal e As Views.Grid.CustomRowCellEditEventArgs) Handles gridView1.CustomRowCellEditForEditing
			If e.Column Is colDescription Then
				e.RepositoryItem = repositoryItemMemoEdit1
			End If
		End Sub
		'</gridControl1>

	End Class
End Namespace

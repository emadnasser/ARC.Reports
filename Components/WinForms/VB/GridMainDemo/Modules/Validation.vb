Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos
	''' <summary>
	''' Summary description for Validation.
	''' </summary>
	Partial Public Class Validation
		Inherits TutorialControl

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\Validation.vb"
            TutorialInfo.WhatsThisXMLFile = "Validation.xml"
			gridControl1.ForceInitialize()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private appError As New AppearanceDefault(Color.White, Color.LightCoral, Color.Empty, Color.Red, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal)
		Protected Overrides ReadOnly Property PaintViews() As PaintView()
			Get
				Return New PaintView() { New PaintView(gridView1, "Winter") }
			End Get
		End Property
		#Region "Init"
		Private Sub Validation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitNWindData()
			InitValidateControls()
		End Sub

		Private tblGrid As String = "[Order Details]"
		Private tblLookUp As String = "Products"
		Protected Overrides Sub InitMDBData(ByVal connectionString As String)
			Dim ds As New DataSet()
			Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, connectionString)
			oleDbDataAdapter.Fill(dsNWindOrders1.Order_Details)
			oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblLookUp, connectionString)
			oleDbDataAdapter.Fill(ds, tblLookUp)

			repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
		End Sub
		Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
			Dim ds As New DataSet()
			ds.ReadXml(dataFileName)
			gridControl1.DataSource = ds.Tables("[Order Details]")
			repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
			Me.gridColumn6.VisibleIndex = -1
			Me.gridColumn6.OptionsColumn.ShowInCustomizationForm = False
		End Sub

		Private Sub InitValidateControls()
			validationControl1.spinEdit1.EditValue = 10
			validationControl2.imageComboBoxEdit1.SelectedIndex = 4
			validationControl2.spinEdit1.EditValue = 40
			validationControl3.imageComboBoxEdit1.SelectedIndex = 1
			validationControl3.imageComboBoxEdit2.SelectedIndex = 2
			validationControl3.spinEdit2.EditValue = 1
		End Sub
		#End Region
		#Region "Validation rule"
		'<gridControl1>
		Private Sub gridView1_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gridView1.ValidatingEditor
			Dim reply() As Object = Nothing
			If gridView1.FocusedColumn.FieldName = "UnitPrice" Then
				reply = validationControl1.IsTrueCondition(e.Value)
			End If
			If gridView1.FocusedColumn.FieldName = "Quantity" Then
				reply = validationControl2.IsTrueCondition(e.Value)
			End If
			If gridView1.FocusedColumn.FieldName = "Discount" Then
				reply = validationControl3.IsTrueCondition(e.Value)
			End If
			If reply IsNot Nothing AndAlso (Not CBool(reply(0))) Then
				e.ErrorText = reply(1).ToString()
				e.Valid = False
			End If
		End Sub

		' ~Customize the appearance of invalid cells 
		Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gridView1.RowCellStyle
			Dim val As Object = gridView1.GetRowCellValue(e.RowHandle, e.Column)
			If (e.Column.FieldName = "UnitPrice" AndAlso (Not CBool(validationControl1.IsTrueCondition(val)(0)))) OrElse (e.Column.FieldName = "Quantity" AndAlso (Not CBool(validationControl2.IsTrueCondition(val)(0)))) OrElse (e.Column.FieldName = "Discount" AndAlso (Not CBool(validationControl3.IsTrueCondition(val)(0)))) Then
					AppearanceHelper.Apply(e.Appearance, appError)
			End If
		End Sub

		Private Sub validationControl_ValidateCondition(ByVal sender As Object, ByVal e As System.EventArgs) Handles validationControl1.ValidateCondition, validationControl3.ValidateCondition, validationControl2.ValidateCondition
			gridView1.LayoutChanged()
		End Sub

		Private Sub gridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gridView1.ValidateRow
			Dim val As Single = Convert.ToSingle(gridView1.GetRowCellValue(e.RowHandle, gridColumn3)) * Convert.ToInt16(gridView1.GetRowCellValue(e.RowHandle, gridColumn4)) * (1 - Convert.ToSingle(gridView1.GetRowCellValue(e.RowHandle, gridColumn5))) 'Total Sum
			If val < 0 Then
				e.ErrorText = String.Format("{0}" & vbCrLf, My.Resources.SubTotalGreaterEqual)
				e.Valid = False
			End If
		End Sub
		'</gridControl1>
		#End Region
		#Region "Edit errorValue style"
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			Using frm As New DevExpress.XtraEditors.XtraForm()
				frm.FormBorderStyle = FormBorderStyle.SizableToolWindow
				frm.StartPosition = FormStartPosition.Manual
				frm.Text = My.Resources.EditStyle
				frm.Location = Me.PointToScreen(New Point(simpleButton1.Left + simpleButton1.Width \ 2, panel2.Top + simpleButton1.Top + simpleButton1.Height \ 2))
				Dim grid As New DevExpress.DXperience.Demos.XtraPropertyGrid()
				grid.ShowDescription = False
				grid.ShowCategories = False
				grid.PropertyGrid.SelectedObject = appError
				AddHandler grid.PropertyGrid.CellValueChanged, AddressOf propertyValueChanged
				grid.Dock = DockStyle.Fill
				frm.Controls.Add(grid)
				frm.ShowDialog()
			End Using
		End Sub

		Private Sub propertyValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs)
			gridView1.LayoutChanged()
		End Sub
		#End Region
		Protected Overrides Sub OnVisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Not Me.Visible Then
				gridView1.HideEditor()
				gridView1.CancelUpdateCurrentRow()
			End If
			MyBase.OnVisibleChanged(sender, e)
		End Sub
	End Class
End Namespace

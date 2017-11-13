Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Card

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridSimpleMode.
	''' </summary>
	Public Partial Class GridSimpleMode
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
		Private cList As ContactList
		Private Sub GridSimpleMode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			radioGroup1.SelectedIndex = 1
		End Sub

		Private ReadOnly Property ColumnView() As DevExpress.XtraGrid.Views.Base.ColumnView
			Get
				Return TryCast(gridControl1.MainView, DevExpress.XtraGrid.Views.Base.ColumnView)
			End Get
		End Property

		Private ReadOnly Property RepositoryItemMemoEdit() As DevExpress.XtraEditors.Repository.RepositoryItem
			Get
				If TypeOf ColumnView Is DevExpress.XtraGrid.Views.Card.CardView Then
					Return repositoryItemMemoEdit1
				Else
					Return repositoryItemMemoExEdit1
				End If
			End Get
		End Property

		'<radioGroup1>
		Private Sub AddGridColumns()
			ColumnView.Columns.Clear()
			AddGridColumn(ColumnView, "FirstName", "First Name")
			AddGridColumn(ColumnView, "LastName", "Last Name")
			AddGridColumn(ColumnView, "Company", "Company")
			'</radioGroup1>
			AddGridColumn(ColumnView, "Address", "Address", RepositoryItemMemoEdit)
			AddGridColumn(ColumnView, "PurchaseDate", "Purchase Date")
			AddGridColumn(ColumnView, "PaymentType", "Payment Type", repositoryItemImageComboBox1)
			AddGridColumn(ColumnView, "PaymentAmount", "Payment Amount", repositoryItemSpinEdit1, "c", DevExpress.Utils.FormatType.Numeric)
			AddGridColumn(ColumnView, "Customer", "Customer")
			'<radioGroup1>
			If TypeOf ColumnView Is DevExpress.XtraGrid.Views.Grid.GridView Then
				CType(ColumnView, DevExpress.XtraGrid.Views.Grid.GridView).BestFitColumns()
			End If
			'Uncomment this line to create the column by default. In this case, you have to comment the lines above.
			'gridControl1.MainView.PopulateColumns();
		End Sub
		'</radioGroup1>

		Private Sub AddGridColumn(ByVal view As DevExpress.XtraGrid.Views.Base.ColumnView, ByVal fieldName As String, ByVal caption As String)
			AddGridColumn(view, fieldName, caption, Nothing)
		End Sub
		Private Sub AddGridColumn(ByVal view As DevExpress.XtraGrid.Views.Base.ColumnView, ByVal fieldName As String, ByVal caption As String, ByVal item As DevExpress.XtraEditors.Repository.RepositoryItem)
			AddGridColumn(view, fieldName, caption, item, "", DevExpress.Utils.FormatType.None)
		End Sub
		Private Sub AddGridColumn(ByVal view As DevExpress.XtraGrid.Views.Base.ColumnView, ByVal fieldName As String, ByVal caption As String, ByVal item As DevExpress.XtraEditors.Repository.RepositoryItem, ByVal format As String, ByVal type As DevExpress.Utils.FormatType)
			Dim column As DevExpress.XtraGrid.Columns.GridColumn = view.Columns.AddField(fieldName)
			column.Caption = caption
			column.ColumnEdit = item
			column.DisplayFormat.FormatType = type
			column.DisplayFormat.FormatString = format
			column.VisibleIndex = view.VisibleColumns.Count
		End Sub


		Private Sub InitData()
			cList = ContactList.GetContacts()
			gridControl1.DataSource = cList
			AddGridColumns()
		End Sub

		'<radioGroup1>
		Private Sub DoUpdateViewStyle(ByVal viewName As String)
			Dim oldView As DevExpress.XtraGrid.Views.Base.BaseView = gridControl1.MainView
			gridControl1.MainView = gridControl1.CreateView(viewName)
			If Not oldView Is Nothing Then
			oldView.Dispose()
			End If
			AddGridColumns()
			If viewName.IndexOf("Card") <> -1 Then
				CType(gridControl1.MainView, CardView).OptionsBehavior.FieldAutoHeight = True
			End If
		End Sub

		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroup1.SelectedIndexChanged
			DoUpdateViewStyle(radioGroup1.EditValue.ToString())
		End Sub
		'</radioGroup1>
	End Class
End Namespace

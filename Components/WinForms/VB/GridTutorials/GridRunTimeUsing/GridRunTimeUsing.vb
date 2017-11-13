Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridRunTimeUsing.
	''' </summary>
	Public Partial Class GridRunTimeUsing
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
		Private ds As DataSet = New DataSet()
		Private Sub GridRunTimeUsing_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			GridAdjustment()
			GridEditorsAdjustment()
			GridAppearance()
		End Sub


		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\nwind.mdb")
			If DBFileName <> "" Then
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
				Dim oleDBAdapter1 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM Customers", con)
				Dim oleDBAdapter2 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM Orders", con)
				Dim oleDBAdapter3 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM [Order Details]", con)
				Dim oleDBAdapter4 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM Employees", con)
				Dim oleDBAdapter5 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM Products", con)

				oleDBAdapter1.Fill(ds, "Customers")
				oleDBAdapter2.Fill(ds, "Orders")
				oleDBAdapter3.Fill(ds, "Order Details")
				oleDBAdapter4.Fill(ds, "Employees")
				oleDBAdapter5.Fill(ds, "Products")

				ds.Relations.Add("Orders", ds.Tables("Customers").Columns("CustomerID"), ds.Tables("Orders").Columns("CustomerID"))

				ds.Relations.Add("OrderDetails", ds.Tables("Orders").Columns("OrderID"), ds.Tables("Order Details").Columns("OrderID"))

				ds.Relations.Add("Employees", ds.Tables("Orders").Columns("EmployeeID"), ds.Tables("Employees").Columns("EmployeeID"), False)

				Dim dvManager As DataViewManager = New DataViewManager(ds)
				Dim dv As DataView = dvManager.CreateDataView(ds.Tables("Customers"))

				gridControl1.DataSource = dv
				gridControl1.MainView.PopulateColumns()
			End If
		End Sub

		Private Sub GridAdjustment()
		 AddHandler gridControl1.MainView.KeyDown, AddressOf gridView_KeyDown
			Dim gvs As GridView() = New GridView(3){}
			Dim colorMakers As ColorMaker() = New ColorMaker(3){}
			Dim options As String() = New String() { "EvenRow", "OddRow", "FocusedRow", "FocusedCell", "GroupRow", "HeaderPanel", "GroupPanel", "HorzLine", "VertLine"}
			gvs(0) = gridView1

			colorMakers(0) = New ColorMaker(Color.DimGray, Color.WhiteSmoke)
			colorMakers(1) = New ColorMaker(Color.DarkCyan, Color.LightCyan)
			colorMakers(2) = New ColorMaker(Color.DarkGoldenrod, Color.LightGoldenrodYellow)
			colorMakers(3) = New ColorMaker(Color.Navy, Color.Lavender)

			For i As Integer = 0 To 3
				Dim prefix As String = ""
				Dim basefontsize As Integer = 8, backColor As Integer = 100, foreColor As Integer = 0, font As Integer = 0
				Dim fstyle As FontStyle = FontStyle.Regular

				If i = 0 Then
				basefontsize = 9
				End If

				If i > 0 Then
					gvs(i) = New GridView(gridControl1)
			   AddHandler gvs(i).KeyDown, AddressOf gridView_KeyDown
					gvs(i).OptionsDetail.ShowDetailTabs = True
					gvs(i).OptionsDetail.EnableDetailToolTip = True
					prefix = ds.Relations(i - 1).RelationName
				End If

				If i < 2 Then
					gvs(i).OptionsView.ColumnAutoWidth = False
				End If

				For Each [option] As String In options
					Select Case [option]
						Case "EvenRow"
							backColor = 100
							foreColor = 0
						Case "OddRow"
							backColor = 90
							foreColor = 0
						Case "FocusedRow"
							backColor = 10
							foreColor = 90
							fstyle = FontStyle.Bold
						Case "FocusedCell"
							backColor = 200
							foreColor = 0
						Case "GroupRow"
							backColor = 60
							foreColor = 100
							fstyle = FontStyle.Italic
						Case "HeaderPanel"
							backColor = 30
							foreColor = 100
							font = 1
							fstyle = FontStyle.Bold
						Case "GroupPanel"
							backColor = 0
							foreColor = 100
							font = 2
							fstyle = FontStyle.Bold
						Case "HorzLine", "VertLine"
							backColor = 0
							foreColor = 0
							font = 0
					End Select
					gvs(i).Appearance.GetAppearance([option]).BackColor = colorMakers(i).ProduceColor(backColor)
					gvs(i).Appearance.GetAppearance([option]).BorderColor = colorMakers(i).ProduceColor(backColor)
					gvs(i).Appearance.GetAppearance([option]).ForeColor = colorMakers(i).ProduceColor(foreColor)
					gvs(i).Appearance.GetAppearance([option]).Font = New Font(DevExpress.Utils.AppearanceObject.DefaultFont.FontFamily, basefontsize + font, fstyle)
				Next [option]

				If gvs(i).OptionsView.ShowGroupPanel Then
					gvs(i).OptionsView.ShowGroupPanel = False
				End If

				gvs(i).DetailHeight = 500
				gvs(i).PaintStyleName = "MixedXP"

				If prefix = "Orders" Then
					gridControl1.LevelTree.Nodes.Add(prefix, gvs(i))
				ElseIf prefix <> "" Then
					gridControl1.LevelTree.Nodes("Orders").Nodes.Add(prefix, gvs(i))
				End If
			Next i
		End Sub

		Private Sub GridEditorsAdjustment()
			gridControl1.BeginUpdate()
			Try
				Dim col As GridColumn
				Dim gv As GridView
				Dim i As Integer = 0
				'values
				Dim s1 As String() = New String() {"", "AK", "BC", "CA", "Co. Cork", "DF", "ID", "Isle of Wight", "Lara", "MT", "NM", "Nueva Esparta", "OR", "Quebec", "RJ", "SP", "Tachira", "WA", "WY"}
				Dim s2 As String() = New String() {"Argentina", "Austria", "Belgium", "Brazil", "Canada", "Denmark", "Finland", "France", "Germany", "Ireland", "Italy", "Mexico", "Norway", "Poland", "Portugal", "Spain", "Sweden", "Switzerland", "UK", "USA", "Venezuela"}
				Dim s3 As String() = New String() {"Speedy Express", "United Package", "Federal Shipping"}
				Dim s4 As String() = New String() {"Dr.","Mr.","Miss","Mrs.","Ms."}
				'editors
				Dim cb1 As RepositoryItemComboBox = New RepositoryItemComboBox()
				gridControl1.RepositoryItems.Add(cb1)
				Dim cb2 As RepositoryItemComboBox = New RepositoryItemComboBox()
				gridControl1.RepositoryItems.Add(cb2)
				Dim se1 As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
				gridControl1.RepositoryItems.Add(se1)
				Dim se2 As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
				gridControl1.RepositoryItems.Add(se2)
				Dim pi1 As RepositoryItemImageComboBox = New RepositoryItemImageComboBox()
				gridControl1.RepositoryItems.Add(pi1)
				Dim pi2 As RepositoryItemImageComboBox = New RepositoryItemImageComboBox()
				gridControl1.RepositoryItems.Add(pi2)
				Dim [me] As RepositoryItemMemoExEdit = New RepositoryItemMemoExEdit()
				gridControl1.RepositoryItems.Add([me])
				Dim le As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit()
				gridControl1.RepositoryItems.Add(le)
				se2.IsFloatValue = False
				For Each s As String In s1
				cb1.Items.Add(s)
				Next s
				For Each s As String In s2
				cb2.Items.Add(s)
				Next s
				For Each s As String In s3
					pi1.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem(s, i + 1, i))
					i += 1
				Next s
				pi1.SmallImages = imageList1
				i = 0
				For Each s As String In s4
					pi2.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem(s, s, i))
					i += 1
				Next s
				pi2.SmallImages = imageList2
				le.ValueMember = "ProductID"
				le.DisplayMember = "ProductName"
				le.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Name", 100))
				le.PopupWidth = 200
				le.DataSource = ds.Tables("Products")
				'main gridview
				gv = gridView1
				For Each c As GridColumn In gv.Columns
					c.Caption = CaptionByFieldName(c.FieldName)
					If c.FieldName.IndexOf("ID") > 0 Then
						c.VisibleIndex = -1
					End If
				Next c
				gv.Columns("Region").ColumnEdit = cb1
				gv.Columns("Country").ColumnEdit = cb2
				'"Orders" gridview 
				gv = TryCast(gridControl1.LevelTree.Nodes("Orders").LevelTemplate, GridView)
				For Each c As DataColumn In ds.Tables("Orders").Columns
					col = gv.Columns.Add()
					col.FieldName = c.ColumnName
					col.Caption = CaptionByFieldName(col.FieldName)
					If col.FieldName.IndexOf("ID") > 6 Then
						col.VisibleIndex = -1
					Else
						col.VisibleIndex = c.Ordinal
					End If
				Next c
				CreateEditorFormat(gv.Columns("Freight"), DevExpress.Utils.FormatType.Numeric, "c")
				gv.Columns("Freight").ColumnEdit = se1
				gv.Columns("ShipVia").ColumnEdit = pi1
				gv.Columns("ShipCountry").ColumnEdit = cb2
				'"OrederDetails" gridview 
				gv = TryCast(gridControl1.LevelTree.Nodes("Orders").Nodes("OrderDetails").LevelTemplate, GridView)
				For Each c As DataColumn In ds.Tables("Order Details").Columns
					col = gv.Columns.Add()
					col.FieldName = c.ColumnName
					col.Caption = CaptionByFieldName(col.FieldName)
                    If col.GetTextCaption().IndexOf("ID") > 0 Then
                        col.VisibleIndex = -1
                    Else
                        col.VisibleIndex = c.Ordinal
                    End If
					If c.Ordinal = 2 Then
					col.ColumnEdit = se1
					End If
					If c.Ordinal = 3 Then
					col.ColumnEdit = se2
					End If
				Next c
				gv.Columns("ProductID").ColumnEdit = le
				CreateEditorFormat(gv.Columns("UnitPrice"), DevExpress.Utils.FormatType.Numeric, "c")
				CreateEditorFormat(gv.Columns("Discount"), DevExpress.Utils.FormatType.Numeric, "p")
				'"Employees" gridview
				gv = TryCast(gridControl1.LevelTree.Nodes("Orders").Nodes("Employees").LevelTemplate, GridView)
				Dim columns As String() = New String() {"LastName", "FirstName", "Title", "TitleOfCourtesy", "BirthDate", "Notes"}
				Dim j As Integer = 0
				Do While j < columns.Length
					col = gv.Columns.Add()
					col.FieldName = columns(j)
					col.Caption = CaptionByFieldName(col.FieldName)
					col.VisibleIndex = j
					col.OptionsFilter.AllowFilter = False
					j += 1
				Loop
				gv.Columns("TitleOfCourtesy").ColumnEdit = pi2
				gv.Columns("Notes").ColumnEdit = [me]
			Finally
				gridControl1.EndUpdate()
			End Try
		End Sub

		Private Sub CreateEditorFormat(ByVal c As GridColumn, ByVal formatType As DevExpress.Utils.FormatType, ByVal formatString As String)
			c.DisplayFormat.FormatType = formatType
			c.DisplayFormat.FormatString = formatString
		End Sub

		Private Sub GridAppearance()
			gridView1.BestFitColumns()
			gridView1.SetMasterRowExpanded(0, True)
			Dim gv As GridView = TryCast(gridControl1.Views(1), GridView)
			If Not gv Is Nothing Then
				gv.SetMasterRowExpanded(0, True)
				gv.SetMasterRowExpandedEx(1, 1, True)
			End If
		End Sub

		Private Sub gridControl1_ViewRegistered(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.ViewOperationEventArgs) Handles gridControl1.ViewRegistered
			If TypeOf e.View Is GridView Then
				CType(e.View, GridView).BestFitColumns()
			End If
		End Sub

		Private Function CaptionByFieldName(ByVal s As String) As String
			If s = "OrderID" Then
			Return "Order ID"
			End If
			If s = "ProductID" Then
			Return "Product"
			End If
			Dim ret As String = s.Chars(0).ToString()
			Dim i As Integer = 1
			Do While i < s.Length
				Dim c As Char = s.Chars(i)
				If c < "a"c Then
				ret &= " "
				End If
				ret &= c
				i += 1
			Loop
			Return ret
		End Function

	  Public Overrides ReadOnly Property ShowLookAndFeel() As Boolean
		  Get
			  Return False
		  End Get
	  End Property

	  Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
		 Dim view As ColumnView = TryCast(sender, ColumnView)
		 If e.KeyCode = Keys.Delete AndAlso e.Control Then
			view.DeleteRow(view.FocusedRowHandle)
		 End If
	  End Sub
	End Class
End Namespace

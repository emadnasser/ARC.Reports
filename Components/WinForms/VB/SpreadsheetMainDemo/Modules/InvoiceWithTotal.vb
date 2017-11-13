Imports Microsoft.VisualBasic
Imports System
Imports System.Data

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class InvoiceWithTotalModule
		Inherits SpreadSheetTutorialControlBase
		Private generator As InvoiceDocumentGenerator

		Public Sub New()
			InitializeComponent()
			spreadsheetControl1.Options.Culture = DefaultCulture
			generator = New InvoiceDocumentGenerator(spreadsheetControl1.Document)
			Me.productsTableAdapter.Fill(nwindDataSet.Products)
			generator.ClearGoods()
			For Each row As DataRow In nwindDataSet.Products.Rows
				Dim item As New InvoiceInMemoryData(0)
				item.ProductName = row.Field(Of String)("ProductName")
				item.Price = CDbl(row.Field(Of Decimal)("UnitPrice"))
				generator.AddGoods(item)
			Next row
			generator.SelectRandomGoods()
			Process()
		End Sub

		Private Sub TransferInvoiceParameters(ByVal generator As InvoiceDocumentGenerator)
			generator.ApplyParameter(InvoiceDocumentGenerator.FromAddressId, fromAddressEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.FromCityId, fromCityEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.FromCompanyId, fromCompanyEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.FromCompanySloganId, fromCompanySloganEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.FromContactNameId, fromContactNameEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.FromEMailId, fromEMailEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.FromFaxId, fromFaxEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.FromPhoneId, fromPhoneEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.FromStateId, fromStateEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.FromZipId, fromZipEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.ToCityId, toCityEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.ToCompanyId, toCompanyNameEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.ToNameId, toNameEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.ToPhoneId, toPhoneEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.ToStateId, toStateEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.ToStreetId, toStreetEdit.Text)
			generator.ApplyParameter(InvoiceDocumentGenerator.ToZipId, toZipEdit.Text)
		End Sub

		Private Sub Process()
			TransferInvoiceParameters(generator)
			generator.Generate()
		End Sub

		Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As XtraTab.TabPageChangedEventArgs) Handles mainTabControl.SelectedPageChanged
			If e.Page.Name = "invoiceTabPage" Then
				Process()
			End If
		End Sub

		#Region "Calculated grid columns"
		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			If e.IsGetData Then
				e.Value = generator.GetGoodsAttribute(e.Column.FieldName, e.ListSourceRowIndex)
			Else
				If generator.SetGoodsAttribute(e.Column.FieldName, e.ListSourceRowIndex, e.Value) Then
					Dim rowIndex As Integer = gridView1.GetRowHandle(e.ListSourceRowIndex)
					gridView1.RefreshRow(rowIndex)
				End If
			End If
		End Sub
		#End Region

		Private Sub includeItemCheckEdit_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles includeItemCheckEdit.CheckStateChanged
			gridView1.PostEditor()
		End Sub

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			spreadsheetControl1.Focus()
		End Sub

		Private Sub On_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			ribbonControl1.SelectedPage = homeRibbonPage1
		End Sub
	End Class
End Namespace

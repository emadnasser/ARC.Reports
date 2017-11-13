Imports System
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Demos

Namespace SpreadsheetDemo
    Partial Public Class Invoice
        Inherits SpreadsheetDemoModule

        Private generator As InvoiceDocumentGenerator

        Public Sub New()
            InitializeComponent()
            Me.spreadsheetControl1.Options.Culture = DefaultCulture
            generator = New InvoiceDocumentGenerator(spreadsheetControl1.Document)
            PrepareGoods()
            gridGoods.DataContext = generator.InvoiceGoods
            Process()
            ribbonControl1.SelectedPage = pageHome
        End Sub

        #Region "PrepareGoods - populate goods table with names and prices"
        Private Sub PrepareGoods()
            generator.ClearGoods()
            generator.AddGoods(New InvoiceInMemoryData("Chai", 18))
            generator.AddGoods(New InvoiceInMemoryData("Chang", 19))
            generator.AddGoods(New InvoiceInMemoryData("Aniseed Syrup", 10))
            generator.AddGoods(New InvoiceInMemoryData("Chef Anton's Cajun Seasoning", 22))
            generator.AddGoods(New InvoiceInMemoryData("Chef Anton's Gumbo Mix", 21.35))
            generator.AddGoods(New InvoiceInMemoryData("Grandma's Boysenberry Spread", 25))
            generator.AddGoods(New InvoiceInMemoryData("Uncle Bob's Organic Dried Pears", 30))
            generator.AddGoods(New InvoiceInMemoryData("Northwoods Cranberry Sauce", 40))
            generator.AddGoods(New InvoiceInMemoryData("Mishi Kobe Niku", 97))
            generator.AddGoods(New InvoiceInMemoryData("Ikura", 31))
            generator.AddGoods(New InvoiceInMemoryData("Queso Cabrales", 21))
            generator.AddGoods(New InvoiceInMemoryData("Queso Manchego La Pastora", 38))
            generator.AddGoods(New InvoiceInMemoryData("Konbu", 6))
            generator.AddGoods(New InvoiceInMemoryData("Tofu", 23.25))
            generator.AddGoods(New InvoiceInMemoryData("Genen Shouyu", 15.5))
            generator.AddGoods(New InvoiceInMemoryData("Pavlova", 17.45))
            generator.AddGoods(New InvoiceInMemoryData("Alice Mutton", 39))
            generator.AddGoods(New InvoiceInMemoryData("Carnarvon Tigers", 62.5))
            generator.AddGoods(New InvoiceInMemoryData("Teatime Chocolate Biscuits", 9.2))
            generator.AddGoods(New InvoiceInMemoryData("Sir Rodney's Marmalade", 81))
            generator.AddGoods(New InvoiceInMemoryData("Sir Rodney's Scones", 10))
            generator.AddGoods(New InvoiceInMemoryData("Gustaf's Knäckebröd", 21))
            generator.AddGoods(New InvoiceInMemoryData("Tunnbröd", 9))
            generator.AddGoods(New InvoiceInMemoryData("Guaraná Fantástica", 4.5))
            generator.AddGoods(New InvoiceInMemoryData("NuNuCa Nuß-Nougat-Creme", 14))
            generator.AddGoods(New InvoiceInMemoryData("Gumbär Gummibärchen", 31.23))
            generator.AddGoods(New InvoiceInMemoryData("Schoggi Schokolade", 43.9))
            generator.AddGoods(New InvoiceInMemoryData("Rössle Sauerkraut", 45.6))
            generator.AddGoods(New InvoiceInMemoryData("Thüringer Rostbratwurst", 123.79))
            generator.AddGoods(New InvoiceInMemoryData("Nord-Ost Matjeshering", 25.89))
            generator.AddGoods(New InvoiceInMemoryData("Gorgonzola Telino", 12.5))
            generator.SelectRandomGoods()
        End Sub
        #End Region

        Private Sub Process()
            TransferInvoiceParameters(generator)
            generator.Generate()
        End Sub

        Private Sub TransferInvoiceParameters(ByVal generator As InvoiceDocumentGenerator)
            generator.ApplyParameter(InvoiceDocumentGenerator.FromAddressId, editFromCompanyStreet.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.FromCityId, editFromCompanyCity.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.FromCompanyId, editFromCompany.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.FromCompanySloganId, editFromCompanySlogan.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.FromContactNameId, editFromCompanyContactName.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.FromEMailId, editFromCompanyEmail.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.FromFaxId, editFromCompanyFax.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.FromPhoneId, editFromCompanyPhone.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.FromStateId, editFromCompanyState.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.FromZipId, editFromCompanyZip.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.ToCityId, editToCity.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.ToCompanyId, editToCompany.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.ToNameId, editToName.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.ToPhoneId, editToPhone.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.ToStateId, editToState.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.ToStreetId, editToStreet.Text)
            generator.ApplyParameter(InvoiceDocumentGenerator.ToZipId, editToZip.Text)
        End Sub

        Private Sub gridGoods_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.GridColumnDataEventArgs)
            If e.IsGetData Then
                e.Value = generator.GetGoodsAttribute(e.Column.FieldName, e.ListSourceRowIndex)
            End If
            If e.IsSetData Then
                If generator.SetGoodsAttribute(e.Column.FieldName, e.ListSourceRowIndex, e.Value) Then
                    Dim rowIndex As Integer = gridGoods.GetRowHandleByListIndex(e.ListSourceRowIndex)
                    gridGoods.RefreshRow(rowIndex)
                End If
            End If
        End Sub

        Private Sub PART_Editor_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            gridGoods.View.PostEditor()
        End Sub

        Private Sub tabControl1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Core.TabControlSelectionChangedEventArgs)
            If IsInitialized AndAlso (e.NewSelectedIndex = 1) Then
                Process()
            End If
        End Sub
    End Class
End Namespace

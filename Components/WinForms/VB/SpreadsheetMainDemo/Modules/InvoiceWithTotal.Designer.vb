Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class InvoiceWithTotalModule
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing
		Private fromCompanyLabel As LabelControl
		Private fromCompanyEdit As TextEdit
		Private fromCityEdit As TextEdit
		Private fromCityLabel As LabelControl
		Private fromAddressEdit As TextEdit
		Private fromAddressLabel As LabelControl
		Private fromCompanySloganEdit As TextEdit
		Private fromCompanySloganLabel As LabelControl
		Private fromFaxEdit As TextEdit
		Private fromFaxLabel As LabelControl
		Private fromPhoneEdit As TextEdit
		Private fromPhoneLabel As LabelControl
		Private fromZipEdit As TextEdit
		Private fromZipLabel As LabelControl
		Private fromStateEdit As TextEdit
		Private fromStateLabel As LabelControl
		Private toCompanyNameEdit As TextEdit
		Private toCompanylabel As LabelControl
		Private toPhoneEdit As TextEdit
		Private toPhoneLabel As LabelControl
		Private toZipEdit As TextEdit
		Private toZipLabel As LabelControl
		Private toStateEdit As TextEdit
		Private toStateLabel As LabelControl
		Private toCityEdit As TextEdit
		Private toCityLabel As LabelControl
		Private toStreetEdit As TextEdit
		Private toStreetLabel As LabelControl
		Private toNameEdit As TextEdit
		Private toNameLabel As LabelControl
		Private spreadsheetControl1 As SpreadsheetControl
		Private WithEvents mainTabControl As XtraTab.XtraTabControl
		Private dataTabPage As XtraTab.XtraTabPage
		Private invoiceTabPage As XtraTab.XtraTabPage
		Private panelControl1 As PanelControl
		Private gridControl1 As XtraGrid.GridControl
		Private productsBindingSource As BindingSource
		Private nwindDataSet As nwindDataSet
		Private WithEvents gridView1 As XtraGrid.Views.Grid.GridView
		Private colProductName As XtraGrid.Columns.GridColumn
		Private colUnitPrice As XtraGrid.Columns.GridColumn
		Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
		Private gridColumn1 As XtraGrid.Columns.GridColumn

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim spreadsheetCommandGalleryItemGroup1 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem1 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem2 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem3 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem4 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem5 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem6 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup2 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem7 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem8 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem9 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem10 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem11 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem12 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem3 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem4 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem5 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem6 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem7 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem8 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem9 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem10 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem11 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem12 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem13 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem14 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim spreadsheetCommandGalleryItemGroup43 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem199 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem200 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem201 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem202 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem203 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem204 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem205 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem206 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem207 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem208 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem209 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem210 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup44 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem211 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem212 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem213 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem214 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem215 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem216 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem217 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup45 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem218 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem219 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem220 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem221 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem222 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup46 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem223 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem224 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem225 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup47 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem226 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem227 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem228 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem229 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem230 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup48 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem231 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem232 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem233 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup49 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem234 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem235 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem236 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem237 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup50 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem238 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem239 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem240 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem241 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup51 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem242 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem243 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem244 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem245 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup52 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem246 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem247 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem248 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem249 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup53 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem250 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem251 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem252 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem253 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem254 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem255 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup54 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem256 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup55 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem257 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem258 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup56 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem259 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem260 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup57 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem261 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem262 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup58 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem263 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem264 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem265 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup59 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem266 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem267 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem268 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup60 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem269 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem270 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem271 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup61 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem272 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem273 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem274 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup62 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem275 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem276 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem277 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup63 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem278 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem279 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem280 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup64 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem281 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem282 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem283 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup65 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem284 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem285 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem286 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem287 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem288 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup66 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem289 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem290 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup67 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem291 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem292 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem293 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem294 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup68 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem295 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem296 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem297 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup69 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem298 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem299 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem300 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup70 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem301 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem302 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup71 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem303 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem304 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem305 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem306 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup72 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem307 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem308 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem309 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem310 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem311 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem312 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem313 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup73 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem314 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem315 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem316 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem317 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem318 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem319 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem320 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem321 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem322 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem323 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem324 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup74 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem325 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem326 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem327 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem328 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem329 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem330 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem331 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem332 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem333 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup75 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem334 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem335 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem336 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem337 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem338 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem339 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem340 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem341 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem342 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup76 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem343 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem344 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem345 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem346 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup77 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem347 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem348 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem349 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem350 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup78 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem351 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem352 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem353 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem354 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem355 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup79 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem356 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem357 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup80 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem358 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem359 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem360 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem361 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup81 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem362 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem363 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem364 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem365 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem366 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem367 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup82 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem368 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem369 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem370 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem371 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem372 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem373 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim galleryItemGroup3 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItem15 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem16 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem17 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem18 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem19 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem20 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem21 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem22 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem23 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem24 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem25 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem26 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem27 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem28 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim spreadsheetCommandGalleryItemGroup83 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem374 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem375 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem376 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem377 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem378 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem379 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem380 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem381 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem382 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem383 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem384 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem385 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup84 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem386 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem387 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem388 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem389 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem390 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem391 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem392 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup85 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem393 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem394 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem395 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem396 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem397 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup86 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem398 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem399 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem400 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup87 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem401 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem402 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem403 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem404 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem405 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup88 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem406 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem407 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem408 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup89 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem409 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem410 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem411 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem412 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup90 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem413 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem414 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem415 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem416 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup91 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem417 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem418 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem419 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem420 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup92 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem421 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem422 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem423 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem424 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup93 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem425 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem426 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem427 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem428 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem429 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem430 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup94 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem431 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup95 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem432 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem433 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup96 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem434 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem435 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup97 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem436 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem437 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup98 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem438 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem439 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem440 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup99 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem441 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem442 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem443 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup100 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem444 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem445 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem446 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup101 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem447 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem448 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem449 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup102 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem450 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem451 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem452 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup103 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem453 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem454 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem455 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup104 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem456 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem457 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem458 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup105 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem459 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem460 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem461 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem462 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem463 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup106 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem464 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem465 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup107 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem466 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem467 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup108 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem468 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem469 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem470 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup109 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem471 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem472 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem473 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup110 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem474 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem475 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup111 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem476 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem477 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem478 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem479 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup112 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem480 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem481 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem482 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem483 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem484 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem485 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem486 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup113 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem487 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem488 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem489 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem490 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem491 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem492 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem493 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem494 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem495 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem496 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem497 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup114 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem498 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem499 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem500 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem501 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem502 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem503 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem504 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem505 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem506 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup115 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem507 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem508 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem509 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem510 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem511 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem512 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem513 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem514 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem515 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup116 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem516 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem517 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem518 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem519 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup117 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem520 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem521 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem522 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem523 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup118 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem524 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem525 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem526 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem527 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem528 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup119 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem529 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem530 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup120 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem531 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem532 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem533 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem534 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim reduceOperation1 As New DevExpress.XtraBars.Ribbon.ReduceOperation()
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim spreadsheetCommandGalleryItem13 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem14 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem15 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem16 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem17 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem18 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem19 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem20 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem21 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem22 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem23 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup3 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem24 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem25 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem26 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem27 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem28 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem29 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup4 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem30 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem31 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem32 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem33 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem34 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem35 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup5 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem36 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem37 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem38 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem39 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem40 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem41 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem42 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem43 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem44 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem45 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem46 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem47 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup6 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem48 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem49 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem50 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem51 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem52 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem53 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem54 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup7 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem55 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem56 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem57 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem58 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem59 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup8 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem60 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem61 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem62 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup9 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem63 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem64 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem65 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem66 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem67 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup10 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem68 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem69 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem70 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup11 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem71 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem72 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem73 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem74 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup12 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem75 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem76 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem77 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem78 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup13 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem79 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem80 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem81 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem82 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup14 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem83 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem84 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem85 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem86 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup15 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem87 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem88 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem89 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem90 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem91 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem92 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup16 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem93 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup17 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem94 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem95 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup18 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem96 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem97 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup19 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem98 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem99 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup20 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem100 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem101 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem102 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup21 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem103 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem104 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem105 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup22 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem106 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem107 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem108 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup23 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem109 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem110 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem111 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup24 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem112 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem113 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem114 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup25 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem115 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem116 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem117 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup26 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem118 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem119 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem120 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup27 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem121 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem122 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem123 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem124 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem125 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup28 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem126 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem127 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup29 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem128 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem129 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem130 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem131 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup30 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem132 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem133 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem134 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup31 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem135 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem136 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem137 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem138 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem139 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem140 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem141 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem142 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem143 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup32 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem144 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem145 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem146 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem147 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem148 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem149 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem150 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem151 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem152 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup33 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem153 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem154 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem155 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem156 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup34 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem157 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem158 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem159 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem160 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup35 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem161 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem162 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem163 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup36 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem164 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem165 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup37 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem166 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem167 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem168 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem169 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup38 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem170 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem171 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem172 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem173 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem174 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem175 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem176 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup39 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem177 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem178 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem179 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem180 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem181 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem182 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem183 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem184 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem185 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem186 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem187 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup40 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem188 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem189 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem190 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem191 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem192 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup41 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem193 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem194 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup42 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem195 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem196 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem197 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem198 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Me.commandBarGalleryDropDown26 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.commandBarGalleryDropDown25 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown27 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown28 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown29 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown30 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown31 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown32 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown33 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown34 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown35 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown36 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown37 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown38 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown39 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown40 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown41 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown42 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown43 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown44 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown45 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown46 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown47 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown48 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown8 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown9 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown10 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown11 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown12 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown13 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown14 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown15 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown16 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown17 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown18 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown19 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown20 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown21 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown22 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown23 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown24 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.fromFaxEdit = New DevExpress.XtraEditors.TextEdit()
			Me.fromFaxLabel = New DevExpress.XtraEditors.LabelControl()
			Me.fromPhoneEdit = New DevExpress.XtraEditors.TextEdit()
			Me.fromPhoneLabel = New DevExpress.XtraEditors.LabelControl()
			Me.fromZipEdit = New DevExpress.XtraEditors.TextEdit()
			Me.fromZipLabel = New DevExpress.XtraEditors.LabelControl()
			Me.fromStateEdit = New DevExpress.XtraEditors.TextEdit()
			Me.fromStateLabel = New DevExpress.XtraEditors.LabelControl()
			Me.fromCityEdit = New DevExpress.XtraEditors.TextEdit()
			Me.fromCityLabel = New DevExpress.XtraEditors.LabelControl()
			Me.fromAddressEdit = New DevExpress.XtraEditors.TextEdit()
			Me.fromAddressLabel = New DevExpress.XtraEditors.LabelControl()
			Me.fromCompanySloganEdit = New DevExpress.XtraEditors.TextEdit()
			Me.fromCompanySloganLabel = New DevExpress.XtraEditors.LabelControl()
			Me.fromCompanyEdit = New DevExpress.XtraEditors.TextEdit()
			Me.fromCompanyLabel = New DevExpress.XtraEditors.LabelControl()
			Me.toCompanyNameEdit = New DevExpress.XtraEditors.TextEdit()
			Me.toCompanylabel = New DevExpress.XtraEditors.LabelControl()
			Me.toPhoneEdit = New DevExpress.XtraEditors.TextEdit()
			Me.toPhoneLabel = New DevExpress.XtraEditors.LabelControl()
			Me.toZipEdit = New DevExpress.XtraEditors.TextEdit()
			Me.toZipLabel = New DevExpress.XtraEditors.LabelControl()
			Me.toStateEdit = New DevExpress.XtraEditors.TextEdit()
			Me.toStateLabel = New DevExpress.XtraEditors.LabelControl()
			Me.toCityEdit = New DevExpress.XtraEditors.TextEdit()
			Me.toCityLabel = New DevExpress.XtraEditors.LabelControl()
			Me.toStreetEdit = New DevExpress.XtraEditors.TextEdit()
			Me.toStreetLabel = New DevExpress.XtraEditors.LabelControl()
			Me.toNameEdit = New DevExpress.XtraEditors.TextEdit()
			Me.toNameLabel = New DevExpress.XtraEditors.LabelControl()
			Me.mainTabControl = New DevExpress.XtraTab.XtraTabControl()
			Me.invoiceTabPage = New DevExpress.XtraTab.XtraTabPage()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.spreadsheetNameBoxControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl()
			Me.spreadsheetFormulaBarControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl()
			Me.dataTabPage = New DevExpress.XtraTab.XtraTabPage()
			Me.toGroupControl = New DevExpress.XtraEditors.GroupControl()
			Me.fromGroupControl = New DevExpress.XtraEditors.GroupControl()
			Me.fromContactNameLabel = New DevExpress.XtraEditors.LabelControl()
			Me.fromContactNameEdit = New DevExpress.XtraEditors.TextEdit()
			Me.fromEMailLabel = New DevExpress.XtraEditors.LabelControl()
			Me.fromEMailEdit = New DevExpress.XtraEditors.TextEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New DevExpress.XtraSpreadsheet.Demos.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.includeItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.productsTableAdapter = New DevExpress.XtraSpreadsheet.Demos.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.spreadsheetBarController1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController()
			Me.spreadsheetCommandBarButtonItem107 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem108 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem109 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem110 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem111 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem119 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem120 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem121 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem122 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem123 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.commonRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup()
			Me.fileRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FileRibbonPage()
			Me.spreadsheetCommandBarButtonItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.infoRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup()
			Me.spreadsheetCommandBarButtonItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.clipboardRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup()
			Me.homeRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.HomeRibbonPage()
			Me.spreadsheetCommandBarButtonItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.fontRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup()
			Me.changeFontNameItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeFontNameItem()
			Me.changeFontSizeItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeFontSizeItem()
			Me.spreadsheetCommandBarButtonItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarCheckItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarSubItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem23 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem24 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem25 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem26 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem27 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem28 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem29 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem30 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.changeBorderLineColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeBorderLineColorItem()
			Me.changeBorderLineStyleItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeBorderLineStyleItem()
			Me.commandBarGalleryDropDown49 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.changeCellFillColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeCellFillColorItem()
			Me.changeFontColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeFontColorItem()
			Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
			Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
			Me.repositoryItemSpreadsheetFontSizeEdit1 = New DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit()
			Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
			Me.alignmentRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.AlignmentRibbonPageGroup()
			Me.spreadsheetCommandBarCheckItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarButtonItem31 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem32 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarCheckItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarSubItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarCheckItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarButtonItem33 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem34 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem35 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
			Me.numberRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.NumberRibbonPageGroup()
			Me.changeNumberFormatItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeNumberFormatItem()
			Me.spreadsheetCommandBarSubItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem36 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem37 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem38 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem39 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem40 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem41 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem42 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem43 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem44 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.barButtonGroup8 = New DevExpress.XtraBars.BarButtonGroup()
			Me.repositoryItemPopupGalleryEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit()
			Me.barButtonGroup9 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup10 = New DevExpress.XtraBars.BarButtonGroup()
			Me.stylesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.StylesRibbonPageGroup()
			Me.spreadsheetCommandBarSubItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarSubItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem45 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem46 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem47 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem48 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem49 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem50 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem51 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem52 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem53 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem54 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem55 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem56 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem57 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown50 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown51 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown52 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonItem58 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem59 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem60 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.galleryFormatAsTableItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryFormatAsTableItem()
			Me.commandBarGalleryDropDown53 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.galleryChangeStyleItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryChangeStyleItem()
			Me.cellsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CellsRibbonPageGroup()
			Me.spreadsheetCommandBarSubItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem61 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem62 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem63 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem64 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem65 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem66 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem67 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem68 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem69 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem70 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem71 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem72 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem73 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem74 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem75 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem76 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem77 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem78 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem79 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.changeSheetTabColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeSheetTabColorItem()
			Me.spreadsheetCommandBarButtonItem80 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarCheckItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarButtonItem81 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.editingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup()
			Me.spreadsheetCommandBarSubItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem82 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem83 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem84 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem85 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem86 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem87 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem88 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem89 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem90 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem91 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem92 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem93 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem94 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem95 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem96 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem97 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem98 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarCheckItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarButtonItem99 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem100 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem101 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem102 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem103 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem104 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem105 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem106 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem112 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.tablesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TablesRibbonPageGroup()
			Me.insertRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.InsertRibbonPage()
			Me.spreadsheetCommandBarButtonItem113 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem114 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.IllustrationsRibbonPageGroup()
			Me.spreadsheetCommandBarButtonItem115 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.chartsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsRibbonPageGroup()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown54 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown55 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown56 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown57 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown58 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown59 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown60 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.linksRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.LinksRibbonPageGroup()
			Me.spreadsheetCommandBarButtonItem116 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.symbolsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.SymbolsRibbonPageGroup()
			Me.spreadsheetCommandBarButtonItem117 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.pageSetupRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PageSetupRibbonPageGroup()
			Me.pageLayoutRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.PageLayoutRibbonPage()
			Me.spreadsheetCommandBarSubItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarCheckItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarButtonItem118 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarCheckItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.pageSetupPaperKindItem1 = New DevExpress.XtraSpreadsheet.UI.PageSetupPaperKindItem()
			Me.spreadsheetCommandBarSubItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem124 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem125 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem126 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem127 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.pageSetupShowRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PageSetupShowRibbonPageGroup()
			Me.spreadsheetCommandBarCheckItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.pageSetupPrintRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PageSetupPrintRibbonPageGroup()
			Me.spreadsheetCommandBarCheckItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem23 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.arrangeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ArrangeRibbonPageGroup()
			Me.spreadsheetCommandBarSubItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem128 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem129 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem130 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem131 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.functionLibraryRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FunctionLibraryRibbonPageGroup()
			Me.formulasRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FormulasRibbonPage()
			Me.spreadsheetCommandBarSubItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem132 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem133 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem134 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem135 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem136 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.functionsFinancialItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsFinancialItem()
			Me.functionsLogicalItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsLogicalItem()
			Me.functionsTextItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsTextItem()
			Me.functionsDateAndTimeItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsDateAndTimeItem()
			Me.functionsLookupAndReferenceItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsLookupAndReferenceItem()
			Me.functionsMathAndTrigonometryItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsMathAndTrigonometryItem()
			Me.spreadsheetCommandBarSubItem23 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.functionsStatisticalItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsStatisticalItem()
			Me.functionsEngineeringItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsEngineeringItem()
			Me.functionsInformationItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsInformationItem()
			Me.functionsCompatibilityItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsCompatibilityItem()
			Me.functionsWebItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsWebItem()
			Me.formulaDefinedNamesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FormulaDefinedNamesRibbonPageGroup()
			Me.spreadsheetCommandBarButtonItem137 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem138 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.definedNameListItem1 = New DevExpress.XtraSpreadsheet.UI.DefinedNameListItem()
			Me.spreadsheetCommandBarButtonItem139 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.formulaAuditingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FormulaAuditingRibbonPageGroup()
			Me.spreadsheetCommandBarCheckItem24 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.formulaCalculationRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FormulaCalculationRibbonPageGroup()
			Me.spreadsheetCommandBarSubItem24 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarCheckItem25 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem26 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarButtonItem140 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem141 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.sortAndFilterRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.SortAndFilterRibbonPageGroup()
			Me.dataRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.DataRibbonPage()
			Me.dataToolsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.DataToolsRibbonPageGroup()
			Me.spreadsheetCommandBarSubItem25 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem142 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem143 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem144 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.outlineRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.OutlineRibbonPageGroup()
			Me.spreadsheetCommandBarSubItem26 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem145 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem146 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem27 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem147 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem148 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem149 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem150 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem151 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.commentsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommentsRibbonPageGroup()
			Me.reviewRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ReviewRibbonPage()
			Me.spreadsheetCommandBarButtonItem152 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem153 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem154 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem155 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.changesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChangesRibbonPageGroup()
			Me.spreadsheetCommandBarButtonItem156 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem157 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem158 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem159 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.showRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ShowRibbonPageGroup()
			Me.viewRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ViewRibbonPage()
			Me.zoomRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ZoomRibbonPageGroup()
			Me.spreadsheetCommandBarButtonItem160 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem161 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem162 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem163 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.windowRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.WindowRibbonPageGroup()
			Me.spreadsheetCommandBarSubItem28 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem164 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem165 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem166 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem167 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.chartsDesignTypeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignTypeRibbonPageGroup()
			Me.chartsDesignRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignRibbonPage()
			Me.chartToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.ChartToolsRibbonPageCategory()
			Me.spreadsheetCommandBarButtonItem168 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.chartsDesignDataRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignDataRibbonPageGroup()
			Me.spreadsheetCommandBarButtonItem169 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem170 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.chartsDesignLayoutsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignLayoutsRibbonPageGroup()
			Me.galleryChartLayoutItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryChartLayoutItem()
			Me.chartsDesignStylesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignStylesRibbonPageGroup()
			Me.galleryChartStyleItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryChartStyleItem()
			Me.chartsLayoutAxesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsLayoutAxesRibbonPageGroup()
			Me.chartsLayoutRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ChartsLayoutRibbonPage()
			Me.spreadsheetCommandBarSubItem29 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown61 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown62 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarSubItem30 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown63 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown64 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.chartsLayoutLabelsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsLayoutLabelsRibbonPageGroup()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown65 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarSubItem31 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown66 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown67 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown68 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown69 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.chartsLayoutAnalysisRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsLayoutAnalysisRibbonPageGroup()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown70 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown71 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown72 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.chartsFormatArrangeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsFormatArrangeRibbonPageGroup()
			Me.chartsFormatRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ChartsFormatRibbonPage()
			Me.tablePropertiesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TablePropertiesRibbonPageGroup()
			Me.tableToolsDesignRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.TableToolsDesignRibbonPage()
			Me.tableToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageCategory()
			Me.renameTableItemCaption1 = New DevExpress.XtraSpreadsheet.UI.RenameTableItemCaption()
			Me.renameTableItem1 = New DevExpress.XtraSpreadsheet.UI.RenameTableItem()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.tableToolsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageGroup()
			Me.spreadsheetCommandBarCheckItem27 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.tableStyleOptionsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TableStyleOptionsRibbonPageGroup()
			Me.spreadsheetCommandBarCheckItem28 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem29 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem30 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem31 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem32 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem33 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.tableStylesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TableStylesRibbonPageGroup()
			Me.galleryTableStylesItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryTableStylesItem()
			Me.drawingFormatArrangeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.DrawingFormatArrangeRibbonPageGroup()
			Me.drawingFormatRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.DrawingFormatRibbonPage()
			Me.drawingToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.DrawingToolsRibbonPageCategory()
			Me.pictureFormatArrangeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PictureFormatArrangeRibbonPageGroup()
			Me.pictureFormatRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.PictureFormatRibbonPage()
			Me.pictureToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.PictureToolsRibbonPageCategory()
			Me.pivotTableAnalyzePivotTableRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzePivotTableRibbonPageGroup()
			Me.pivotTableAnalyzeRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeRibbonPage()
			Me.pivotTableToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.PivotTableToolsRibbonPageCategory()
			Me.spreadsheetCommandBarButtonItem171 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeActiveFieldRibbonPageGroup()
			Me.spreadsheetCommandBarButtonItem172 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem173 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem174 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.pivotTableAnalyzeGroupRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeGroupRibbonPageGroup()
			Me.spreadsheetCommandBarButtonItem175 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem176 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem177 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.pivotTableAnalyzeDataRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeDataRibbonPageGroup()
			Me.spreadsheetCommandBarSubItem32 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem178 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem179 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem180 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.pivotTableAnalyzeActionsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeActionsRibbonPageGroup()
			Me.spreadsheetCommandBarSubItem33 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem181 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem182 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem34 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem183 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem184 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem185 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem186 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.pivotTableAnalyzeCalculationsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeCalculationsRibbonPageGroup()
			Me.spreadsheetCommandBarSubItem35 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem187 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem188 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem189 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem190 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.pivotTableAnalyzeShowRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeShowRibbonPageGroup()
			Me.spreadsheetCommandBarCheckItem34 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem35 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem36 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.pivotTableDesignLayoutRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableDesignLayoutRibbonPageGroup()
			Me.pivotTableDesignRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.PivotTableDesignRibbonPage()
			Me.spreadsheetCommandBarSubItem36 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem191 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem192 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem193 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem37 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem194 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem195 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem196 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem197 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem38 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem198 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem199 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem200 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem201 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem202 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem39 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem203 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem204 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableDesignPivotTableStyleOptionsRibbonPageGroup()
			Me.spreadsheetCommandBarCheckItem37 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem38 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem39 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem40 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.pivotTableDesignPivotTableStylesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableDesignPivotTableStylesRibbonPageGroup()
			Me.galleryPivotStylesItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryPivotStylesItem()
			CType(Me.commandBarGalleryDropDown26, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown25, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown27, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown28, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown29, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown30, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown31, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown32, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown33, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown34, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown35, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown36, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown37, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown38, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown39, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown40, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown41, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown42, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown43, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown44, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown45, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown46, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown47, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown48, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown14, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown15, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown16, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown17, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown18, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown19, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown20, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown21, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown22, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown23, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown24, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fromFaxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fromPhoneEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fromZipEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fromStateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fromCityEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fromAddressEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fromCompanySloganEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fromCompanyEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toCompanyNameEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toPhoneEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toZipEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toStateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toCityEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toStreetEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toNameEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mainTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mainTabControl.SuspendLayout()
			Me.invoiceTabPage.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dataTabPage.SuspendLayout()
			CType(Me.toGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toGroupControl.SuspendLayout()
			CType(Me.fromGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.fromGroupControl.SuspendLayout()
			CType(Me.fromContactNameEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fromEMailEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.includeItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown49, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpreadsheetFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPopupGalleryEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown50, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown51, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown52, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown53, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown54, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown55, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown56, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown57, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown58, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown59, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown60, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown61, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown62, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown63, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown64, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown65, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown66, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown67, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown68, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown69, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown70, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown71, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown72, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' commandBarGalleryDropDown26
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown26.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup1.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup"
			spreadsheetCommandGalleryItem1.CommandName = "ConditionalFormattingDataBarGradientBlue"
			spreadsheetCommandGalleryItem2.CommandName = "ConditionalFormattingDataBarGradientGreen"
			spreadsheetCommandGalleryItem3.CommandName = "ConditionalFormattingDataBarGradientRed"
			spreadsheetCommandGalleryItem4.CommandName = "ConditionalFormattingDataBarGradientOrange"
			spreadsheetCommandGalleryItem5.CommandName = "ConditionalFormattingDataBarGradientLightBlue"
			spreadsheetCommandGalleryItem6.CommandName = "ConditionalFormattingDataBarGradientPurple"
			spreadsheetCommandGalleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem1, spreadsheetCommandGalleryItem2, spreadsheetCommandGalleryItem3, spreadsheetCommandGalleryItem4, spreadsheetCommandGalleryItem5, spreadsheetCommandGalleryItem6})
			spreadsheetCommandGalleryItemGroup2.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup"
			spreadsheetCommandGalleryItem7.CommandName = "ConditionalFormattingDataBarSolidBlue"
			spreadsheetCommandGalleryItem8.CommandName = "ConditionalFormattingDataBarSolidGreen"
			spreadsheetCommandGalleryItem9.CommandName = "ConditionalFormattingDataBarSolidRed"
			spreadsheetCommandGalleryItem10.CommandName = "ConditionalFormattingDataBarSolidOrange"
			spreadsheetCommandGalleryItem11.CommandName = "ConditionalFormattingDataBarSolidLightBlue"
			spreadsheetCommandGalleryItem12.CommandName = "ConditionalFormattingDataBarSolidPurple"
			spreadsheetCommandGalleryItemGroup2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem7, spreadsheetCommandGalleryItem8, spreadsheetCommandGalleryItem9, spreadsheetCommandGalleryItem10, spreadsheetCommandGalleryItem11, spreadsheetCommandGalleryItem12})
			Me.commandBarGalleryDropDown26.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup1, spreadsheetCommandGalleryItemGroup2})
			Me.commandBarGalleryDropDown26.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown26.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown26.Manager = Nothing
			Me.commandBarGalleryDropDown26.Name = "commandBarGalleryDropDown26"
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetControl1.Location = New System.Drawing.Point(2, 27)
			Me.spreadsheetControl1.MenuManager = Me.ribbonControl1
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spreadsheetControl1.Size = New System.Drawing.Size(686, 305)
			Me.spreadsheetControl1.TabIndex = 50
			Me.spreadsheetControl1.Text = "spreadsheetControl1"
			' 
			' commandBarGalleryDropDown25
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown25.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown25.Gallery.ColumnCount = 1
			Me.commandBarGalleryDropDown25.Gallery.DrawImageBackground = False
			galleryItem1.Tag = DevExpress.Export.Xl.XlBorderLineStyle.None
			galleryItem2.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thin
			galleryItem3.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Hair
			galleryItem4.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dotted
			galleryItem5.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dashed
			galleryItem6.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDot
			galleryItem7.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDotDot
			galleryItem8.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Double
			galleryItem9.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Medium
			galleryItem10.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashed
			galleryItem11.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDot
			galleryItem12.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDotDot
			galleryItem13.Tag = DevExpress.Export.Xl.XlBorderLineStyle.SlantDashDot
			galleryItem14.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thick
			galleryItemGroup2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5, galleryItem6, galleryItem7, galleryItem8, galleryItem9, galleryItem10, galleryItem11, galleryItem12, galleryItem13, galleryItem14})
			Me.commandBarGalleryDropDown25.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup2})
			Me.commandBarGalleryDropDown25.Gallery.ImageSize = New System.Drawing.Size(65, 46)
			Me.commandBarGalleryDropDown25.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
			Me.commandBarGalleryDropDown25.Gallery.ItemSize = New System.Drawing.Size(136, 26)
			Me.commandBarGalleryDropDown25.Gallery.RowCount = 14
			Me.commandBarGalleryDropDown25.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown25.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown25.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown25.Manager = Nothing
			Me.commandBarGalleryDropDown25.Name = "commandBarGalleryDropDown25"
			' 
			' commandBarGalleryDropDown27
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown27.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup43.CommandName = "ConditionalFormattingColorScalesCommandGroup"
			spreadsheetCommandGalleryItem199.CommandName = "ConditionalFormattingColorScaleGreenYellowRed"
			spreadsheetCommandGalleryItem200.CommandName = "ConditionalFormattingColorScaleRedYellowGreen"
			spreadsheetCommandGalleryItem201.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed"
			spreadsheetCommandGalleryItem202.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen"
			spreadsheetCommandGalleryItem203.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed"
			spreadsheetCommandGalleryItem204.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue"
			spreadsheetCommandGalleryItem205.CommandName = "ConditionalFormattingColorScaleWhiteRed"
			spreadsheetCommandGalleryItem206.CommandName = "ConditionalFormattingColorScaleRedWhite"
			spreadsheetCommandGalleryItem207.CommandName = "ConditionalFormattingColorScaleGreenWhite"
			spreadsheetCommandGalleryItem208.CommandName = "ConditionalFormattingColorScaleWhiteGreen"
			spreadsheetCommandGalleryItem209.CommandName = "ConditionalFormattingColorScaleGreenYellow"
			spreadsheetCommandGalleryItem210.CommandName = "ConditionalFormattingColorScaleYellowGreen"
			spreadsheetCommandGalleryItemGroup43.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem199, spreadsheetCommandGalleryItem200, spreadsheetCommandGalleryItem201, spreadsheetCommandGalleryItem202, spreadsheetCommandGalleryItem203, spreadsheetCommandGalleryItem204, spreadsheetCommandGalleryItem205, spreadsheetCommandGalleryItem206, spreadsheetCommandGalleryItem207, spreadsheetCommandGalleryItem208, spreadsheetCommandGalleryItem209, spreadsheetCommandGalleryItem210})
			Me.commandBarGalleryDropDown27.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup43})
			Me.commandBarGalleryDropDown27.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown27.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown27.Manager = Nothing
			Me.commandBarGalleryDropDown27.Name = "commandBarGalleryDropDown27"
			' 
			' commandBarGalleryDropDown28
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown28.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup44.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup"
			spreadsheetCommandGalleryItem211.CommandName = "ConditionalFormattingIconSetArrows3Colored"
			spreadsheetCommandGalleryItem212.CommandName = "ConditionalFormattingIconSetArrows3Grayed"
			spreadsheetCommandGalleryItem213.CommandName = "ConditionalFormattingIconSetArrows4Colored"
			spreadsheetCommandGalleryItem214.CommandName = "ConditionalFormattingIconSetArrows4Grayed"
			spreadsheetCommandGalleryItem215.CommandName = "ConditionalFormattingIconSetArrows5Colored"
			spreadsheetCommandGalleryItem216.CommandName = "ConditionalFormattingIconSetArrows5Grayed"
			spreadsheetCommandGalleryItem217.CommandName = "ConditionalFormattingIconSetTriangles3"
			spreadsheetCommandGalleryItemGroup44.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem211, spreadsheetCommandGalleryItem212, spreadsheetCommandGalleryItem213, spreadsheetCommandGalleryItem214, spreadsheetCommandGalleryItem215, spreadsheetCommandGalleryItem216, spreadsheetCommandGalleryItem217})
			spreadsheetCommandGalleryItemGroup45.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup"
			spreadsheetCommandGalleryItem218.CommandName = "ConditionalFormattingIconSetTrafficLights3"
			spreadsheetCommandGalleryItem219.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed"
			spreadsheetCommandGalleryItem220.CommandName = "ConditionalFormattingIconSetTrafficLights4"
			spreadsheetCommandGalleryItem221.CommandName = "ConditionalFormattingIconSetSigns3"
			spreadsheetCommandGalleryItem222.CommandName = "ConditionalFormattingIconSetRedToBlack"
			spreadsheetCommandGalleryItemGroup45.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem218, spreadsheetCommandGalleryItem219, spreadsheetCommandGalleryItem220, spreadsheetCommandGalleryItem221, spreadsheetCommandGalleryItem222})
			spreadsheetCommandGalleryItemGroup46.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup"
			spreadsheetCommandGalleryItem223.CommandName = "ConditionalFormattingIconSetSymbols3Circled"
			spreadsheetCommandGalleryItem224.CommandName = "ConditionalFormattingIconSetSymbols3"
			spreadsheetCommandGalleryItem225.CommandName = "ConditionalFormattingIconSetFlags3"
			spreadsheetCommandGalleryItemGroup46.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem223, spreadsheetCommandGalleryItem224, spreadsheetCommandGalleryItem225})
			spreadsheetCommandGalleryItemGroup47.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup"
			spreadsheetCommandGalleryItem226.CommandName = "ConditionalFormattingIconSetStars3"
			spreadsheetCommandGalleryItem227.CommandName = "ConditionalFormattingIconSetRatings4"
			spreadsheetCommandGalleryItem228.CommandName = "ConditionalFormattingIconSetRatings5"
			spreadsheetCommandGalleryItem229.CommandName = "ConditionalFormattingIconSetQuarters5"
			spreadsheetCommandGalleryItem230.CommandName = "ConditionalFormattingIconSetBoxes5"
			spreadsheetCommandGalleryItemGroup47.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem226, spreadsheetCommandGalleryItem227, spreadsheetCommandGalleryItem228, spreadsheetCommandGalleryItem229, spreadsheetCommandGalleryItem230})
			Me.commandBarGalleryDropDown28.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup44, spreadsheetCommandGalleryItemGroup45, spreadsheetCommandGalleryItemGroup46, spreadsheetCommandGalleryItemGroup47})
			Me.commandBarGalleryDropDown28.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown28.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown28.Manager = Nothing
			Me.commandBarGalleryDropDown28.Name = "commandBarGalleryDropDown28"
			' 
			' commandBarGalleryDropDown29
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown29.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown29.Gallery.ColumnCount = 7
			Me.commandBarGalleryDropDown29.Gallery.DrawImageBackground = False
			Me.commandBarGalleryDropDown29.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
			Me.commandBarGalleryDropDown29.Gallery.ItemSize = New System.Drawing.Size(73, 58)
			Me.commandBarGalleryDropDown29.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown29.Manager = Nothing
			Me.commandBarGalleryDropDown29.Name = "commandBarGalleryDropDown29"
			' 
			' commandBarGalleryDropDown30
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown30.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup48.CommandName = "InsertChartColumn2DCommandGroup"
			spreadsheetCommandGalleryItem231.CommandName = "InsertChartColumnClustered2D"
			spreadsheetCommandGalleryItem232.CommandName = "InsertChartColumnStacked2D"
			spreadsheetCommandGalleryItem233.CommandName = "InsertChartColumnPercentStacked2D"
			spreadsheetCommandGalleryItemGroup48.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem231, spreadsheetCommandGalleryItem232, spreadsheetCommandGalleryItem233})
			spreadsheetCommandGalleryItemGroup49.CommandName = "InsertChartColumn3DCommandGroup"
			spreadsheetCommandGalleryItem234.CommandName = "InsertChartColumnClustered3D"
			spreadsheetCommandGalleryItem235.CommandName = "InsertChartColumnStacked3D"
			spreadsheetCommandGalleryItem236.CommandName = "InsertChartColumnPercentStacked3D"
			spreadsheetCommandGalleryItem237.CommandName = "InsertChartColumn3D"
			spreadsheetCommandGalleryItemGroup49.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem234, spreadsheetCommandGalleryItem235, spreadsheetCommandGalleryItem236, spreadsheetCommandGalleryItem237})
			spreadsheetCommandGalleryItemGroup50.CommandName = "InsertChartCylinderCommandGroup"
			spreadsheetCommandGalleryItem238.CommandName = "InsertChartCylinderClustered"
			spreadsheetCommandGalleryItem239.CommandName = "InsertChartCylinderStacked"
			spreadsheetCommandGalleryItem240.CommandName = "InsertChartCylinderPercentStacked"
			spreadsheetCommandGalleryItem241.CommandName = "InsertChartCylinder"
			spreadsheetCommandGalleryItemGroup50.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem238, spreadsheetCommandGalleryItem239, spreadsheetCommandGalleryItem240, spreadsheetCommandGalleryItem241})
			spreadsheetCommandGalleryItemGroup51.CommandName = "InsertChartConeCommandGroup"
			spreadsheetCommandGalleryItem242.CommandName = "InsertChartConeClustered"
			spreadsheetCommandGalleryItem243.CommandName = "InsertChartConeStacked"
			spreadsheetCommandGalleryItem244.CommandName = "InsertChartConePercentStacked"
			spreadsheetCommandGalleryItem245.CommandName = "InsertChartCone"
			spreadsheetCommandGalleryItemGroup51.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem242, spreadsheetCommandGalleryItem243, spreadsheetCommandGalleryItem244, spreadsheetCommandGalleryItem245})
			spreadsheetCommandGalleryItemGroup52.CommandName = "InsertChartPyramidCommandGroup"
			spreadsheetCommandGalleryItem246.CommandName = "InsertChartPyramidClustered"
			spreadsheetCommandGalleryItem247.CommandName = "InsertChartPyramidStacked"
			spreadsheetCommandGalleryItem248.CommandName = "InsertChartPyramidPercentStacked"
			spreadsheetCommandGalleryItem249.CommandName = "InsertChartPyramid"
			spreadsheetCommandGalleryItemGroup52.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem246, spreadsheetCommandGalleryItem247, spreadsheetCommandGalleryItem248, spreadsheetCommandGalleryItem249})
			Me.commandBarGalleryDropDown30.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup48, spreadsheetCommandGalleryItemGroup49, spreadsheetCommandGalleryItemGroup50, spreadsheetCommandGalleryItemGroup51, spreadsheetCommandGalleryItemGroup52})
			Me.commandBarGalleryDropDown30.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown30.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown30.Manager = Nothing
			Me.commandBarGalleryDropDown30.Name = "commandBarGalleryDropDown30"
			' 
			' commandBarGalleryDropDown31
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown31.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup53.CommandName = "InsertChartLine2DCommandGroup"
			spreadsheetCommandGalleryItem250.CommandName = "InsertChartLine"
			spreadsheetCommandGalleryItem251.CommandName = "InsertChartStackedLine"
			spreadsheetCommandGalleryItem252.CommandName = "InsertChartPercentStackedLine"
			spreadsheetCommandGalleryItem253.CommandName = "InsertChartLineWithMarkers"
			spreadsheetCommandGalleryItem254.CommandName = "InsertChartStackedLineWithMarkers"
			spreadsheetCommandGalleryItem255.CommandName = "InsertChartPercentStackedLineWithMarkers"
			spreadsheetCommandGalleryItemGroup53.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem250, spreadsheetCommandGalleryItem251, spreadsheetCommandGalleryItem252, spreadsheetCommandGalleryItem253, spreadsheetCommandGalleryItem254, spreadsheetCommandGalleryItem255})
			spreadsheetCommandGalleryItemGroup54.CommandName = "InsertChartLine3DCommandGroup"
			spreadsheetCommandGalleryItem256.CommandName = "InsertChartLine3D"
			spreadsheetCommandGalleryItemGroup54.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem256})
			Me.commandBarGalleryDropDown31.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup53, spreadsheetCommandGalleryItemGroup54})
			Me.commandBarGalleryDropDown31.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown31.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown31.Manager = Nothing
			Me.commandBarGalleryDropDown31.Name = "commandBarGalleryDropDown31"
			' 
			' commandBarGalleryDropDown32
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown32.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup55.CommandName = "InsertChartPie2DCommandGroup"
			spreadsheetCommandGalleryItem257.CommandName = "InsertChartPie2D"
			spreadsheetCommandGalleryItem258.CommandName = "InsertChartPieExploded2D"
			spreadsheetCommandGalleryItemGroup55.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem257, spreadsheetCommandGalleryItem258})
			spreadsheetCommandGalleryItemGroup56.CommandName = "InsertChartPie3DCommandGroup"
			spreadsheetCommandGalleryItem259.CommandName = "InsertChartPie3D"
			spreadsheetCommandGalleryItem260.CommandName = "InsertChartPieExploded3D"
			spreadsheetCommandGalleryItemGroup56.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem259, spreadsheetCommandGalleryItem260})
			spreadsheetCommandGalleryItemGroup57.CommandName = "InsertChartDoughnut2DCommandGroup"
			spreadsheetCommandGalleryItem261.CommandName = "InsertChartDoughnut2D"
			spreadsheetCommandGalleryItem262.CommandName = "InsertChartDoughnutExploded2D"
			spreadsheetCommandGalleryItemGroup57.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem261, spreadsheetCommandGalleryItem262})
			Me.commandBarGalleryDropDown32.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup55, spreadsheetCommandGalleryItemGroup56, spreadsheetCommandGalleryItemGroup57})
			Me.commandBarGalleryDropDown32.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown32.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown32.Manager = Nothing
			Me.commandBarGalleryDropDown32.Name = "commandBarGalleryDropDown32"
			' 
			' commandBarGalleryDropDown33
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown33.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup58.CommandName = "InsertChartBar2DCommandGroup"
			spreadsheetCommandGalleryItem263.CommandName = "InsertChartBarClustered2D"
			spreadsheetCommandGalleryItem264.CommandName = "InsertChartBarStacked2D"
			spreadsheetCommandGalleryItem265.CommandName = "InsertChartBarPercentStacked2D"
			spreadsheetCommandGalleryItemGroup58.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem263, spreadsheetCommandGalleryItem264, spreadsheetCommandGalleryItem265})
			spreadsheetCommandGalleryItemGroup59.CommandName = "InsertChartBar3DCommandGroup"
			spreadsheetCommandGalleryItem266.CommandName = "InsertChartBarClustered3D"
			spreadsheetCommandGalleryItem267.CommandName = "InsertChartBarStacked3D"
			spreadsheetCommandGalleryItem268.CommandName = "InsertChartBarPercentStacked3D"
			spreadsheetCommandGalleryItemGroup59.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem266, spreadsheetCommandGalleryItem267, spreadsheetCommandGalleryItem268})
			spreadsheetCommandGalleryItemGroup60.CommandName = "InsertChartHorizontalCylinderCommandGroup"
			spreadsheetCommandGalleryItem269.CommandName = "InsertChartHorizontalCylinderClustered"
			spreadsheetCommandGalleryItem270.CommandName = "InsertChartHorizontalCylinderStacked"
			spreadsheetCommandGalleryItem271.CommandName = "InsertChartHorizontalCylinderPercentStacked"
			spreadsheetCommandGalleryItemGroup60.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem269, spreadsheetCommandGalleryItem270, spreadsheetCommandGalleryItem271})
			spreadsheetCommandGalleryItemGroup61.CommandName = "InsertChartHorizontalConeCommandGroup"
			spreadsheetCommandGalleryItem272.CommandName = "InsertChartHorizontalConeClustered"
			spreadsheetCommandGalleryItem273.CommandName = "InsertChartHorizontalConeStacked"
			spreadsheetCommandGalleryItem274.CommandName = "InsertChartHorizontalConePercentStacked"
			spreadsheetCommandGalleryItemGroup61.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem272, spreadsheetCommandGalleryItem273, spreadsheetCommandGalleryItem274})
			spreadsheetCommandGalleryItemGroup62.CommandName = "InsertChartHorizontalPyramidCommandGroup"
			spreadsheetCommandGalleryItem275.CommandName = "InsertChartHorizontalPyramidClustered"
			spreadsheetCommandGalleryItem276.CommandName = "InsertChartHorizontalPyramidStacked"
			spreadsheetCommandGalleryItem277.CommandName = "InsertChartHorizontalPyramidPercentStacked"
			spreadsheetCommandGalleryItemGroup62.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem275, spreadsheetCommandGalleryItem276, spreadsheetCommandGalleryItem277})
			Me.commandBarGalleryDropDown33.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup58, spreadsheetCommandGalleryItemGroup59, spreadsheetCommandGalleryItemGroup60, spreadsheetCommandGalleryItemGroup61, spreadsheetCommandGalleryItemGroup62})
			Me.commandBarGalleryDropDown33.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown33.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown33.Manager = Nothing
			Me.commandBarGalleryDropDown33.Name = "commandBarGalleryDropDown33"
			' 
			' commandBarGalleryDropDown34
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown34.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup63.CommandName = "InsertChartArea2DCommandGroup"
			spreadsheetCommandGalleryItem278.CommandName = "InsertChartArea"
			spreadsheetCommandGalleryItem279.CommandName = "InsertChartStackedArea"
			spreadsheetCommandGalleryItem280.CommandName = "InsertChartPercentStackedArea"
			spreadsheetCommandGalleryItemGroup63.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem278, spreadsheetCommandGalleryItem279, spreadsheetCommandGalleryItem280})
			spreadsheetCommandGalleryItemGroup64.CommandName = "InsertChartArea3DCommandGroup"
			spreadsheetCommandGalleryItem281.CommandName = "InsertChartArea3D"
			spreadsheetCommandGalleryItem282.CommandName = "InsertChartStackedArea3D"
			spreadsheetCommandGalleryItem283.CommandName = "InsertChartPercentStackedArea3D"
			spreadsheetCommandGalleryItemGroup64.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem281, spreadsheetCommandGalleryItem282, spreadsheetCommandGalleryItem283})
			Me.commandBarGalleryDropDown34.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup63, spreadsheetCommandGalleryItemGroup64})
			Me.commandBarGalleryDropDown34.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown34.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown34.Manager = Nothing
			Me.commandBarGalleryDropDown34.Name = "commandBarGalleryDropDown34"
			' 
			' commandBarGalleryDropDown35
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown35.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup65.CommandName = "InsertChartScatterCommandGroup"
			spreadsheetCommandGalleryItem284.CommandName = "InsertChartScatterMarkers"
			spreadsheetCommandGalleryItem285.CommandName = "InsertChartScatterSmoothLinesAndMarkers"
			spreadsheetCommandGalleryItem286.CommandName = "InsertChartScatterSmoothLines"
			spreadsheetCommandGalleryItem287.CommandName = "InsertChartScatterLinesAndMarkers"
			spreadsheetCommandGalleryItem288.CommandName = "InsertChartScatterLines"
			spreadsheetCommandGalleryItemGroup65.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem284, spreadsheetCommandGalleryItem285, spreadsheetCommandGalleryItem286, spreadsheetCommandGalleryItem287, spreadsheetCommandGalleryItem288})
			spreadsheetCommandGalleryItemGroup66.CommandName = "InsertChartBubbleCommandGroup"
			spreadsheetCommandGalleryItem289.CommandName = "InsertChartBubble"
			spreadsheetCommandGalleryItem290.CommandName = "InsertChartBubble3D"
			spreadsheetCommandGalleryItemGroup66.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem289, spreadsheetCommandGalleryItem290})
			Me.commandBarGalleryDropDown35.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup65, spreadsheetCommandGalleryItemGroup66})
			Me.commandBarGalleryDropDown35.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown35.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown35.Manager = Nothing
			Me.commandBarGalleryDropDown35.Name = "commandBarGalleryDropDown35"
			' 
			' commandBarGalleryDropDown36
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown36.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup67.CommandName = "InsertChartStockCommandGroup"
			spreadsheetCommandGalleryItem291.CommandName = "InsertChartStockHighLowClose"
			spreadsheetCommandGalleryItem292.CommandName = "InsertChartStockOpenHighLowClose"
			spreadsheetCommandGalleryItem293.CommandName = "InsertChartStockVolumeHighLowClose"
			spreadsheetCommandGalleryItem294.CommandName = "InsertChartStockVolumeOpenHighLowClose"
			spreadsheetCommandGalleryItemGroup67.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem291, spreadsheetCommandGalleryItem292, spreadsheetCommandGalleryItem293, spreadsheetCommandGalleryItem294})
			spreadsheetCommandGalleryItemGroup68.CommandName = "InsertChartRadarCommandGroup"
			spreadsheetCommandGalleryItem295.CommandName = "InsertChartRadar"
			spreadsheetCommandGalleryItem296.CommandName = "InsertChartRadarWithMarkers"
			spreadsheetCommandGalleryItem297.CommandName = "InsertChartRadarFilled"
			spreadsheetCommandGalleryItemGroup68.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem295, spreadsheetCommandGalleryItem296, spreadsheetCommandGalleryItem297})
			Me.commandBarGalleryDropDown36.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup67, spreadsheetCommandGalleryItemGroup68})
			Me.commandBarGalleryDropDown36.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown36.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown36.Manager = Nothing
			Me.commandBarGalleryDropDown36.Name = "commandBarGalleryDropDown36"
			' 
			' commandBarGalleryDropDown37
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown37.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown37.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup69.CommandName = "ChartTitleCommandGroup"
			spreadsheetCommandGalleryItem298.CommandName = "ChartTitleNone"
			spreadsheetCommandGalleryItem299.CommandName = "ChartTitleCenteredOverlay"
			spreadsheetCommandGalleryItem300.CommandName = "ChartTitleAbove"
			spreadsheetCommandGalleryItemGroup69.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem298, spreadsheetCommandGalleryItem299, spreadsheetCommandGalleryItem300})
			Me.commandBarGalleryDropDown37.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup69})
			Me.commandBarGalleryDropDown37.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown37.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown37.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown37.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown37.Manager = Nothing
			Me.commandBarGalleryDropDown37.Name = "commandBarGalleryDropDown37"
			' 
			' commandBarGalleryDropDown38
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown38.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown38.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup70.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup"
			spreadsheetCommandGalleryItem301.CommandName = "ChartPrimaryHorizontalAxisTitleNone"
			spreadsheetCommandGalleryItem302.CommandName = "ChartPrimaryHorizontalAxisTitleBelow"
			spreadsheetCommandGalleryItemGroup70.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem301, spreadsheetCommandGalleryItem302})
			Me.commandBarGalleryDropDown38.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup70})
			Me.commandBarGalleryDropDown38.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown38.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown38.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown38.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown38.Manager = Nothing
			Me.commandBarGalleryDropDown38.Name = "commandBarGalleryDropDown38"
			' 
			' commandBarGalleryDropDown39
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown39.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown39.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup71.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup"
			spreadsheetCommandGalleryItem303.CommandName = "ChartPrimaryVerticalAxisTitleNone"
			spreadsheetCommandGalleryItem304.CommandName = "ChartPrimaryVerticalAxisTitleRotated"
			spreadsheetCommandGalleryItem305.CommandName = "ChartPrimaryVerticalAxisTitleVertical"
			spreadsheetCommandGalleryItem306.CommandName = "ChartPrimaryVerticalAxisTitleHorizontal"
			spreadsheetCommandGalleryItemGroup71.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem303, spreadsheetCommandGalleryItem304, spreadsheetCommandGalleryItem305, spreadsheetCommandGalleryItem306})
			Me.commandBarGalleryDropDown39.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup71})
			Me.commandBarGalleryDropDown39.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown39.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown39.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown39.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown39.Manager = Nothing
			Me.commandBarGalleryDropDown39.Name = "commandBarGalleryDropDown39"
			' 
			' commandBarGalleryDropDown40
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown40.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown40.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup72.CommandName = "ChartLegendCommandGroup"
			spreadsheetCommandGalleryItem307.CommandName = "ChartLegendNone"
			spreadsheetCommandGalleryItem308.CommandName = "ChartLegendAtRight"
			spreadsheetCommandGalleryItem309.CommandName = "ChartLegendAtTop"
			spreadsheetCommandGalleryItem310.CommandName = "ChartLegendAtLeft"
			spreadsheetCommandGalleryItem311.CommandName = "ChartLegendAtBottom"
			spreadsheetCommandGalleryItem312.CommandName = "ChartLegendOverlayAtRight"
			spreadsheetCommandGalleryItem313.CommandName = "ChartLegendOverlayAtLeft"
			spreadsheetCommandGalleryItemGroup72.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem307, spreadsheetCommandGalleryItem308, spreadsheetCommandGalleryItem309, spreadsheetCommandGalleryItem310, spreadsheetCommandGalleryItem311, spreadsheetCommandGalleryItem312, spreadsheetCommandGalleryItem313})
			Me.commandBarGalleryDropDown40.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup72})
			Me.commandBarGalleryDropDown40.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown40.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown40.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown40.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown40.Manager = Nothing
			Me.commandBarGalleryDropDown40.Name = "commandBarGalleryDropDown40"
			' 
			' commandBarGalleryDropDown41
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown41.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown41.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup73.CommandName = "ChartDataLabelsCommandGroup"
			spreadsheetCommandGalleryItem314.CommandName = "ChartDataLabelsNone"
			spreadsheetCommandGalleryItem315.CommandName = "ChartDataLabelsDefault"
			spreadsheetCommandGalleryItem316.CommandName = "ChartDataLabelsCenter"
			spreadsheetCommandGalleryItem317.CommandName = "ChartDataLabelsInsideEnd"
			spreadsheetCommandGalleryItem318.CommandName = "ChartDataLabelsInsideBase"
			spreadsheetCommandGalleryItem319.CommandName = "ChartDataLabelsOutsideEnd"
			spreadsheetCommandGalleryItem320.CommandName = "ChartDataLabelsBestFit"
			spreadsheetCommandGalleryItem321.CommandName = "ChartDataLabelsLeft"
			spreadsheetCommandGalleryItem322.CommandName = "ChartDataLabelsRight"
			spreadsheetCommandGalleryItem323.CommandName = "ChartDataLabelsAbove"
			spreadsheetCommandGalleryItem324.CommandName = "ChartDataLabelsBelow"
			spreadsheetCommandGalleryItemGroup73.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem314, spreadsheetCommandGalleryItem315, spreadsheetCommandGalleryItem316, spreadsheetCommandGalleryItem317, spreadsheetCommandGalleryItem318, spreadsheetCommandGalleryItem319, spreadsheetCommandGalleryItem320, spreadsheetCommandGalleryItem321, spreadsheetCommandGalleryItem322, spreadsheetCommandGalleryItem323, spreadsheetCommandGalleryItem324})
			Me.commandBarGalleryDropDown41.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup73})
			Me.commandBarGalleryDropDown41.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown41.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown41.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown41.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown41.Manager = Nothing
			Me.commandBarGalleryDropDown41.Name = "commandBarGalleryDropDown41"
			' 
			' commandBarGalleryDropDown42
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown42.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown42.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup74.CommandName = "ChartPrimaryHorizontalAxisCommandGroup"
			spreadsheetCommandGalleryItem325.CommandName = "ChartHidePrimaryHorizontalAxis"
			spreadsheetCommandGalleryItem326.CommandName = "ChartPrimaryHorizontalAxisLeftToRight"
			spreadsheetCommandGalleryItem327.CommandName = "ChartPrimaryHorizontalAxisHideLabels"
			spreadsheetCommandGalleryItem328.CommandName = "ChartPrimaryHorizontalAxisRightToLeft"
			spreadsheetCommandGalleryItem329.CommandName = "ChartPrimaryHorizontalAxisDefault"
			spreadsheetCommandGalleryItem330.CommandName = "ChartPrimaryHorizontalAxisScaleThousands"
			spreadsheetCommandGalleryItem331.CommandName = "ChartPrimaryHorizontalAxisScaleMillions"
			spreadsheetCommandGalleryItem332.CommandName = "ChartPrimaryHorizontalAxisScaleBillions"
			spreadsheetCommandGalleryItem333.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm"
			spreadsheetCommandGalleryItemGroup74.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem325, spreadsheetCommandGalleryItem326, spreadsheetCommandGalleryItem327, spreadsheetCommandGalleryItem328, spreadsheetCommandGalleryItem329, spreadsheetCommandGalleryItem330, spreadsheetCommandGalleryItem331, spreadsheetCommandGalleryItem332, spreadsheetCommandGalleryItem333})
			Me.commandBarGalleryDropDown42.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup74})
			Me.commandBarGalleryDropDown42.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown42.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown42.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown42.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown42.Manager = Nothing
			Me.commandBarGalleryDropDown42.Name = "commandBarGalleryDropDown42"
			' 
			' commandBarGalleryDropDown43
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown43.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown43.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup75.CommandName = "ChartPrimaryVerticalAxisCommandGroup"
			spreadsheetCommandGalleryItem334.CommandName = "ChartHidePrimaryVerticalAxis"
			spreadsheetCommandGalleryItem335.CommandName = "ChartPrimaryVerticalAxisLeftToRight"
			spreadsheetCommandGalleryItem336.CommandName = "ChartPrimaryVerticalAxisHideLabels"
			spreadsheetCommandGalleryItem337.CommandName = "ChartPrimaryVerticalAxisRightToLeft"
			spreadsheetCommandGalleryItem338.CommandName = "ChartPrimaryVerticalAxisDefault"
			spreadsheetCommandGalleryItem339.CommandName = "ChartPrimaryVerticalAxisScaleThousands"
			spreadsheetCommandGalleryItem340.CommandName = "ChartPrimaryVerticalAxisScaleMillions"
			spreadsheetCommandGalleryItem341.CommandName = "ChartPrimaryVerticalAxisScaleBillions"
			spreadsheetCommandGalleryItem342.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm"
			spreadsheetCommandGalleryItemGroup75.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem334, spreadsheetCommandGalleryItem335, spreadsheetCommandGalleryItem336, spreadsheetCommandGalleryItem337, spreadsheetCommandGalleryItem338, spreadsheetCommandGalleryItem339, spreadsheetCommandGalleryItem340, spreadsheetCommandGalleryItem341, spreadsheetCommandGalleryItem342})
			Me.commandBarGalleryDropDown43.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup75})
			Me.commandBarGalleryDropDown43.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown43.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown43.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown43.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown43.Manager = Nothing
			Me.commandBarGalleryDropDown43.Name = "commandBarGalleryDropDown43"
			' 
			' commandBarGalleryDropDown44
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown44.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown44.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup76.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup"
			spreadsheetCommandGalleryItem343.CommandName = "ChartPrimaryHorizontalGridlinesNone"
			spreadsheetCommandGalleryItem344.CommandName = "ChartPrimaryHorizontalGridlinesMajor"
			spreadsheetCommandGalleryItem345.CommandName = "ChartPrimaryHorizontalGridlinesMinor"
			spreadsheetCommandGalleryItem346.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor"
			spreadsheetCommandGalleryItemGroup76.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem343, spreadsheetCommandGalleryItem344, spreadsheetCommandGalleryItem345, spreadsheetCommandGalleryItem346})
			Me.commandBarGalleryDropDown44.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup76})
			Me.commandBarGalleryDropDown44.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown44.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown44.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown44.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown44.Manager = Nothing
			Me.commandBarGalleryDropDown44.Name = "commandBarGalleryDropDown44"
			' 
			' commandBarGalleryDropDown45
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown45.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown45.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup77.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup"
			spreadsheetCommandGalleryItem347.CommandName = "ChartPrimaryVerticalGridlinesNone"
			spreadsheetCommandGalleryItem348.CommandName = "ChartPrimaryVerticalGridlinesMajor"
			spreadsheetCommandGalleryItem349.CommandName = "ChartPrimaryVerticalGridlinesMinor"
			spreadsheetCommandGalleryItem350.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor"
			spreadsheetCommandGalleryItemGroup77.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem347, spreadsheetCommandGalleryItem348, spreadsheetCommandGalleryItem349, spreadsheetCommandGalleryItem350})
			Me.commandBarGalleryDropDown45.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup77})
			Me.commandBarGalleryDropDown45.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown45.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown45.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown45.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown45.Manager = Nothing
			Me.commandBarGalleryDropDown45.Name = "commandBarGalleryDropDown45"
			' 
			' commandBarGalleryDropDown46
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown46.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown46.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup78.CommandName = "ChartLinesCommandGroup"
			spreadsheetCommandGalleryItem351.CommandName = "ChartLinesNone"
			spreadsheetCommandGalleryItem352.CommandName = "ChartShowDropLines"
			spreadsheetCommandGalleryItem353.CommandName = "ChartShowHighLowLines"
			spreadsheetCommandGalleryItem354.CommandName = "ChartShowDropLinesAndHighLowLines"
			spreadsheetCommandGalleryItem355.CommandName = "ChartShowSeriesLines"
			spreadsheetCommandGalleryItemGroup78.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem351, spreadsheetCommandGalleryItem352, spreadsheetCommandGalleryItem353, spreadsheetCommandGalleryItem354, spreadsheetCommandGalleryItem355})
			Me.commandBarGalleryDropDown46.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup78})
			Me.commandBarGalleryDropDown46.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown46.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown46.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown46.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown46.Manager = Nothing
			Me.commandBarGalleryDropDown46.Name = "commandBarGalleryDropDown46"
			' 
			' commandBarGalleryDropDown47
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown47.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown47.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup79.CommandName = "ChartUpDownBarsCommandGroup"
			spreadsheetCommandGalleryItem356.CommandName = "ChartHideUpDownBars"
			spreadsheetCommandGalleryItem357.CommandName = "ChartShowUpDownBars"
			spreadsheetCommandGalleryItemGroup79.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem356, spreadsheetCommandGalleryItem357})
			Me.commandBarGalleryDropDown47.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup79})
			Me.commandBarGalleryDropDown47.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown47.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown47.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown47.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown47.Manager = Nothing
			Me.commandBarGalleryDropDown47.Name = "commandBarGalleryDropDown47"
			' 
			' commandBarGalleryDropDown48
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown48.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown48.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup80.CommandName = "ChartErrorBarsCommandGroup"
			spreadsheetCommandGalleryItem358.CommandName = "ChartErrorBarsNone"
			spreadsheetCommandGalleryItem359.CommandName = "ChartErrorBarsStandardError"
			spreadsheetCommandGalleryItem360.CommandName = "ChartErrorBarsPercentage"
			spreadsheetCommandGalleryItem361.CommandName = "ChartErrorBarsStandardDeviation"
			spreadsheetCommandGalleryItemGroup80.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem358, spreadsheetCommandGalleryItem359, spreadsheetCommandGalleryItem360, spreadsheetCommandGalleryItem361})
			Me.commandBarGalleryDropDown48.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup80})
			Me.commandBarGalleryDropDown48.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown48.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown48.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown48.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown48.Manager = Nothing
			Me.commandBarGalleryDropDown48.Name = "commandBarGalleryDropDown48"
			' 
			' commandBarGalleryDropDown2
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown2.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup81.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup"
			spreadsheetCommandGalleryItem362.CommandName = "ConditionalFormattingDataBarGradientBlue"
			spreadsheetCommandGalleryItem363.CommandName = "ConditionalFormattingDataBarGradientGreen"
			spreadsheetCommandGalleryItem364.CommandName = "ConditionalFormattingDataBarGradientRed"
			spreadsheetCommandGalleryItem365.CommandName = "ConditionalFormattingDataBarGradientOrange"
			spreadsheetCommandGalleryItem366.CommandName = "ConditionalFormattingDataBarGradientLightBlue"
			spreadsheetCommandGalleryItem367.CommandName = "ConditionalFormattingDataBarGradientPurple"
			spreadsheetCommandGalleryItemGroup81.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem362, spreadsheetCommandGalleryItem363, spreadsheetCommandGalleryItem364, spreadsheetCommandGalleryItem365, spreadsheetCommandGalleryItem366, spreadsheetCommandGalleryItem367})
			spreadsheetCommandGalleryItemGroup82.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup"
			spreadsheetCommandGalleryItem368.CommandName = "ConditionalFormattingDataBarSolidBlue"
			spreadsheetCommandGalleryItem369.CommandName = "ConditionalFormattingDataBarSolidGreen"
			spreadsheetCommandGalleryItem370.CommandName = "ConditionalFormattingDataBarSolidRed"
			spreadsheetCommandGalleryItem371.CommandName = "ConditionalFormattingDataBarSolidOrange"
			spreadsheetCommandGalleryItem372.CommandName = "ConditionalFormattingDataBarSolidLightBlue"
			spreadsheetCommandGalleryItem373.CommandName = "ConditionalFormattingDataBarSolidPurple"
			spreadsheetCommandGalleryItemGroup82.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem368, spreadsheetCommandGalleryItem369, spreadsheetCommandGalleryItem370, spreadsheetCommandGalleryItem371, spreadsheetCommandGalleryItem372, spreadsheetCommandGalleryItem373})
			Me.commandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup81, spreadsheetCommandGalleryItemGroup82})
			Me.commandBarGalleryDropDown2.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown2.Manager = Nothing
			Me.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2"
			' 
			' commandBarGalleryDropDown1
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown1.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown1.Gallery.ColumnCount = 1
			Me.commandBarGalleryDropDown1.Gallery.DrawImageBackground = False
			galleryItem15.Tag = DevExpress.Export.Xl.XlBorderLineStyle.None
			galleryItem16.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thin
			galleryItem17.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Hair
			galleryItem18.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dotted
			galleryItem19.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dashed
			galleryItem20.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDot
			galleryItem21.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDotDot
			galleryItem22.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Double
			galleryItem23.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Medium
			galleryItem24.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashed
			galleryItem25.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDot
			galleryItem26.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDotDot
			galleryItem27.Tag = DevExpress.Export.Xl.XlBorderLineStyle.SlantDashDot
			galleryItem28.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thick
			galleryItemGroup3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem15, galleryItem16, galleryItem17, galleryItem18, galleryItem19, galleryItem20, galleryItem21, galleryItem22, galleryItem23, galleryItem24, galleryItem25, galleryItem26, galleryItem27, galleryItem28})
			Me.commandBarGalleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup3})
			Me.commandBarGalleryDropDown1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
			Me.commandBarGalleryDropDown1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
			Me.commandBarGalleryDropDown1.Gallery.ItemSize = New System.Drawing.Size(136, 26)
			Me.commandBarGalleryDropDown1.Gallery.RowCount = 14
			Me.commandBarGalleryDropDown1.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown1.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown1.Manager = Nothing
			Me.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1"
			' 
			' commandBarGalleryDropDown3
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown3.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup83.CommandName = "ConditionalFormattingColorScalesCommandGroup"
			spreadsheetCommandGalleryItem374.CommandName = "ConditionalFormattingColorScaleGreenYellowRed"
			spreadsheetCommandGalleryItem375.CommandName = "ConditionalFormattingColorScaleRedYellowGreen"
			spreadsheetCommandGalleryItem376.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed"
			spreadsheetCommandGalleryItem377.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen"
			spreadsheetCommandGalleryItem378.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed"
			spreadsheetCommandGalleryItem379.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue"
			spreadsheetCommandGalleryItem380.CommandName = "ConditionalFormattingColorScaleWhiteRed"
			spreadsheetCommandGalleryItem381.CommandName = "ConditionalFormattingColorScaleRedWhite"
			spreadsheetCommandGalleryItem382.CommandName = "ConditionalFormattingColorScaleGreenWhite"
			spreadsheetCommandGalleryItem383.CommandName = "ConditionalFormattingColorScaleWhiteGreen"
			spreadsheetCommandGalleryItem384.CommandName = "ConditionalFormattingColorScaleGreenYellow"
			spreadsheetCommandGalleryItem385.CommandName = "ConditionalFormattingColorScaleYellowGreen"
			spreadsheetCommandGalleryItemGroup83.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem374, spreadsheetCommandGalleryItem375, spreadsheetCommandGalleryItem376, spreadsheetCommandGalleryItem377, spreadsheetCommandGalleryItem378, spreadsheetCommandGalleryItem379, spreadsheetCommandGalleryItem380, spreadsheetCommandGalleryItem381, spreadsheetCommandGalleryItem382, spreadsheetCommandGalleryItem383, spreadsheetCommandGalleryItem384, spreadsheetCommandGalleryItem385})
			Me.commandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup83})
			Me.commandBarGalleryDropDown3.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown3.Manager = Nothing
			Me.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3"
			' 
			' commandBarGalleryDropDown4
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown4.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup84.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup"
			spreadsheetCommandGalleryItem386.CommandName = "ConditionalFormattingIconSetArrows3Colored"
			spreadsheetCommandGalleryItem387.CommandName = "ConditionalFormattingIconSetArrows3Grayed"
			spreadsheetCommandGalleryItem388.CommandName = "ConditionalFormattingIconSetArrows4Colored"
			spreadsheetCommandGalleryItem389.CommandName = "ConditionalFormattingIconSetArrows4Grayed"
			spreadsheetCommandGalleryItem390.CommandName = "ConditionalFormattingIconSetArrows5Colored"
			spreadsheetCommandGalleryItem391.CommandName = "ConditionalFormattingIconSetArrows5Grayed"
			spreadsheetCommandGalleryItem392.CommandName = "ConditionalFormattingIconSetTriangles3"
			spreadsheetCommandGalleryItemGroup84.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem386, spreadsheetCommandGalleryItem387, spreadsheetCommandGalleryItem388, spreadsheetCommandGalleryItem389, spreadsheetCommandGalleryItem390, spreadsheetCommandGalleryItem391, spreadsheetCommandGalleryItem392})
			spreadsheetCommandGalleryItemGroup85.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup"
			spreadsheetCommandGalleryItem393.CommandName = "ConditionalFormattingIconSetTrafficLights3"
			spreadsheetCommandGalleryItem394.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed"
			spreadsheetCommandGalleryItem395.CommandName = "ConditionalFormattingIconSetTrafficLights4"
			spreadsheetCommandGalleryItem396.CommandName = "ConditionalFormattingIconSetSigns3"
			spreadsheetCommandGalleryItem397.CommandName = "ConditionalFormattingIconSetRedToBlack"
			spreadsheetCommandGalleryItemGroup85.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem393, spreadsheetCommandGalleryItem394, spreadsheetCommandGalleryItem395, spreadsheetCommandGalleryItem396, spreadsheetCommandGalleryItem397})
			spreadsheetCommandGalleryItemGroup86.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup"
			spreadsheetCommandGalleryItem398.CommandName = "ConditionalFormattingIconSetSymbols3Circled"
			spreadsheetCommandGalleryItem399.CommandName = "ConditionalFormattingIconSetSymbols3"
			spreadsheetCommandGalleryItem400.CommandName = "ConditionalFormattingIconSetFlags3"
			spreadsheetCommandGalleryItemGroup86.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem398, spreadsheetCommandGalleryItem399, spreadsheetCommandGalleryItem400})
			spreadsheetCommandGalleryItemGroup87.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup"
			spreadsheetCommandGalleryItem401.CommandName = "ConditionalFormattingIconSetStars3"
			spreadsheetCommandGalleryItem402.CommandName = "ConditionalFormattingIconSetRatings4"
			spreadsheetCommandGalleryItem403.CommandName = "ConditionalFormattingIconSetRatings5"
			spreadsheetCommandGalleryItem404.CommandName = "ConditionalFormattingIconSetQuarters5"
			spreadsheetCommandGalleryItem405.CommandName = "ConditionalFormattingIconSetBoxes5"
			spreadsheetCommandGalleryItemGroup87.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem401, spreadsheetCommandGalleryItem402, spreadsheetCommandGalleryItem403, spreadsheetCommandGalleryItem404, spreadsheetCommandGalleryItem405})
			Me.commandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup84, spreadsheetCommandGalleryItemGroup85, spreadsheetCommandGalleryItemGroup86, spreadsheetCommandGalleryItemGroup87})
			Me.commandBarGalleryDropDown4.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown4.Manager = Nothing
			Me.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4"
			' 
			' commandBarGalleryDropDown5
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown5.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown5.Gallery.ColumnCount = 7
			Me.commandBarGalleryDropDown5.Gallery.DrawImageBackground = False
			Me.commandBarGalleryDropDown5.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
			Me.commandBarGalleryDropDown5.Gallery.ItemSize = New System.Drawing.Size(73, 58)
			Me.commandBarGalleryDropDown5.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown5.Manager = Nothing
			Me.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5"
			' 
			' commandBarGalleryDropDown6
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown6.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup88.CommandName = "InsertChartColumn2DCommandGroup"
			spreadsheetCommandGalleryItem406.CommandName = "InsertChartColumnClustered2D"
			spreadsheetCommandGalleryItem407.CommandName = "InsertChartColumnStacked2D"
			spreadsheetCommandGalleryItem408.CommandName = "InsertChartColumnPercentStacked2D"
			spreadsheetCommandGalleryItemGroup88.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem406, spreadsheetCommandGalleryItem407, spreadsheetCommandGalleryItem408})
			spreadsheetCommandGalleryItemGroup89.CommandName = "InsertChartColumn3DCommandGroup"
			spreadsheetCommandGalleryItem409.CommandName = "InsertChartColumnClustered3D"
			spreadsheetCommandGalleryItem410.CommandName = "InsertChartColumnStacked3D"
			spreadsheetCommandGalleryItem411.CommandName = "InsertChartColumnPercentStacked3D"
			spreadsheetCommandGalleryItem412.CommandName = "InsertChartColumn3D"
			spreadsheetCommandGalleryItemGroup89.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem409, spreadsheetCommandGalleryItem410, spreadsheetCommandGalleryItem411, spreadsheetCommandGalleryItem412})
			spreadsheetCommandGalleryItemGroup90.CommandName = "InsertChartCylinderCommandGroup"
			spreadsheetCommandGalleryItem413.CommandName = "InsertChartCylinderClustered"
			spreadsheetCommandGalleryItem414.CommandName = "InsertChartCylinderStacked"
			spreadsheetCommandGalleryItem415.CommandName = "InsertChartCylinderPercentStacked"
			spreadsheetCommandGalleryItem416.CommandName = "InsertChartCylinder"
			spreadsheetCommandGalleryItemGroup90.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem413, spreadsheetCommandGalleryItem414, spreadsheetCommandGalleryItem415, spreadsheetCommandGalleryItem416})
			spreadsheetCommandGalleryItemGroup91.CommandName = "InsertChartConeCommandGroup"
			spreadsheetCommandGalleryItem417.CommandName = "InsertChartConeClustered"
			spreadsheetCommandGalleryItem418.CommandName = "InsertChartConeStacked"
			spreadsheetCommandGalleryItem419.CommandName = "InsertChartConePercentStacked"
			spreadsheetCommandGalleryItem420.CommandName = "InsertChartCone"
			spreadsheetCommandGalleryItemGroup91.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem417, spreadsheetCommandGalleryItem418, spreadsheetCommandGalleryItem419, spreadsheetCommandGalleryItem420})
			spreadsheetCommandGalleryItemGroup92.CommandName = "InsertChartPyramidCommandGroup"
			spreadsheetCommandGalleryItem421.CommandName = "InsertChartPyramidClustered"
			spreadsheetCommandGalleryItem422.CommandName = "InsertChartPyramidStacked"
			spreadsheetCommandGalleryItem423.CommandName = "InsertChartPyramidPercentStacked"
			spreadsheetCommandGalleryItem424.CommandName = "InsertChartPyramid"
			spreadsheetCommandGalleryItemGroup92.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem421, spreadsheetCommandGalleryItem422, spreadsheetCommandGalleryItem423, spreadsheetCommandGalleryItem424})
			Me.commandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup88, spreadsheetCommandGalleryItemGroup89, spreadsheetCommandGalleryItemGroup90, spreadsheetCommandGalleryItemGroup91, spreadsheetCommandGalleryItemGroup92})
			Me.commandBarGalleryDropDown6.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown6.Manager = Nothing
			Me.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6"
			' 
			' commandBarGalleryDropDown7
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown7.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup93.CommandName = "InsertChartLine2DCommandGroup"
			spreadsheetCommandGalleryItem425.CommandName = "InsertChartLine"
			spreadsheetCommandGalleryItem426.CommandName = "InsertChartStackedLine"
			spreadsheetCommandGalleryItem427.CommandName = "InsertChartPercentStackedLine"
			spreadsheetCommandGalleryItem428.CommandName = "InsertChartLineWithMarkers"
			spreadsheetCommandGalleryItem429.CommandName = "InsertChartStackedLineWithMarkers"
			spreadsheetCommandGalleryItem430.CommandName = "InsertChartPercentStackedLineWithMarkers"
			spreadsheetCommandGalleryItemGroup93.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem425, spreadsheetCommandGalleryItem426, spreadsheetCommandGalleryItem427, spreadsheetCommandGalleryItem428, spreadsheetCommandGalleryItem429, spreadsheetCommandGalleryItem430})
			spreadsheetCommandGalleryItemGroup94.CommandName = "InsertChartLine3DCommandGroup"
			spreadsheetCommandGalleryItem431.CommandName = "InsertChartLine3D"
			spreadsheetCommandGalleryItemGroup94.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem431})
			Me.commandBarGalleryDropDown7.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup93, spreadsheetCommandGalleryItemGroup94})
			Me.commandBarGalleryDropDown7.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown7.Manager = Nothing
			Me.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7"
			' 
			' commandBarGalleryDropDown8
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown8.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup95.CommandName = "InsertChartPie2DCommandGroup"
			spreadsheetCommandGalleryItem432.CommandName = "InsertChartPie2D"
			spreadsheetCommandGalleryItem433.CommandName = "InsertChartPieExploded2D"
			spreadsheetCommandGalleryItemGroup95.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem432, spreadsheetCommandGalleryItem433})
			spreadsheetCommandGalleryItemGroup96.CommandName = "InsertChartPie3DCommandGroup"
			spreadsheetCommandGalleryItem434.CommandName = "InsertChartPie3D"
			spreadsheetCommandGalleryItem435.CommandName = "InsertChartPieExploded3D"
			spreadsheetCommandGalleryItemGroup96.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem434, spreadsheetCommandGalleryItem435})
			spreadsheetCommandGalleryItemGroup97.CommandName = "InsertChartDoughnut2DCommandGroup"
			spreadsheetCommandGalleryItem436.CommandName = "InsertChartDoughnut2D"
			spreadsheetCommandGalleryItem437.CommandName = "InsertChartDoughnutExploded2D"
			spreadsheetCommandGalleryItemGroup97.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem436, spreadsheetCommandGalleryItem437})
			Me.commandBarGalleryDropDown8.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup95, spreadsheetCommandGalleryItemGroup96, spreadsheetCommandGalleryItemGroup97})
			Me.commandBarGalleryDropDown8.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown8.Manager = Nothing
			Me.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8"
			' 
			' commandBarGalleryDropDown9
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown9.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup98.CommandName = "InsertChartBar2DCommandGroup"
			spreadsheetCommandGalleryItem438.CommandName = "InsertChartBarClustered2D"
			spreadsheetCommandGalleryItem439.CommandName = "InsertChartBarStacked2D"
			spreadsheetCommandGalleryItem440.CommandName = "InsertChartBarPercentStacked2D"
			spreadsheetCommandGalleryItemGroup98.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem438, spreadsheetCommandGalleryItem439, spreadsheetCommandGalleryItem440})
			spreadsheetCommandGalleryItemGroup99.CommandName = "InsertChartBar3DCommandGroup"
			spreadsheetCommandGalleryItem441.CommandName = "InsertChartBarClustered3D"
			spreadsheetCommandGalleryItem442.CommandName = "InsertChartBarStacked3D"
			spreadsheetCommandGalleryItem443.CommandName = "InsertChartBarPercentStacked3D"
			spreadsheetCommandGalleryItemGroup99.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem441, spreadsheetCommandGalleryItem442, spreadsheetCommandGalleryItem443})
			spreadsheetCommandGalleryItemGroup100.CommandName = "InsertChartHorizontalCylinderCommandGroup"
			spreadsheetCommandGalleryItem444.CommandName = "InsertChartHorizontalCylinderClustered"
			spreadsheetCommandGalleryItem445.CommandName = "InsertChartHorizontalCylinderStacked"
			spreadsheetCommandGalleryItem446.CommandName = "InsertChartHorizontalCylinderPercentStacked"
			spreadsheetCommandGalleryItemGroup100.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem444, spreadsheetCommandGalleryItem445, spreadsheetCommandGalleryItem446})
			spreadsheetCommandGalleryItemGroup101.CommandName = "InsertChartHorizontalConeCommandGroup"
			spreadsheetCommandGalleryItem447.CommandName = "InsertChartHorizontalConeClustered"
			spreadsheetCommandGalleryItem448.CommandName = "InsertChartHorizontalConeStacked"
			spreadsheetCommandGalleryItem449.CommandName = "InsertChartHorizontalConePercentStacked"
			spreadsheetCommandGalleryItemGroup101.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem447, spreadsheetCommandGalleryItem448, spreadsheetCommandGalleryItem449})
			spreadsheetCommandGalleryItemGroup102.CommandName = "InsertChartHorizontalPyramidCommandGroup"
			spreadsheetCommandGalleryItem450.CommandName = "InsertChartHorizontalPyramidClustered"
			spreadsheetCommandGalleryItem451.CommandName = "InsertChartHorizontalPyramidStacked"
			spreadsheetCommandGalleryItem452.CommandName = "InsertChartHorizontalPyramidPercentStacked"
			spreadsheetCommandGalleryItemGroup102.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem450, spreadsheetCommandGalleryItem451, spreadsheetCommandGalleryItem452})
			Me.commandBarGalleryDropDown9.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup98, spreadsheetCommandGalleryItemGroup99, spreadsheetCommandGalleryItemGroup100, spreadsheetCommandGalleryItemGroup101, spreadsheetCommandGalleryItemGroup102})
			Me.commandBarGalleryDropDown9.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown9.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown9.Manager = Nothing
			Me.commandBarGalleryDropDown9.Name = "commandBarGalleryDropDown9"
			' 
			' commandBarGalleryDropDown10
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown10.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup103.CommandName = "InsertChartArea2DCommandGroup"
			spreadsheetCommandGalleryItem453.CommandName = "InsertChartArea"
			spreadsheetCommandGalleryItem454.CommandName = "InsertChartStackedArea"
			spreadsheetCommandGalleryItem455.CommandName = "InsertChartPercentStackedArea"
			spreadsheetCommandGalleryItemGroup103.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem453, spreadsheetCommandGalleryItem454, spreadsheetCommandGalleryItem455})
			spreadsheetCommandGalleryItemGroup104.CommandName = "InsertChartArea3DCommandGroup"
			spreadsheetCommandGalleryItem456.CommandName = "InsertChartArea3D"
			spreadsheetCommandGalleryItem457.CommandName = "InsertChartStackedArea3D"
			spreadsheetCommandGalleryItem458.CommandName = "InsertChartPercentStackedArea3D"
			spreadsheetCommandGalleryItemGroup104.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem456, spreadsheetCommandGalleryItem457, spreadsheetCommandGalleryItem458})
			Me.commandBarGalleryDropDown10.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup103, spreadsheetCommandGalleryItemGroup104})
			Me.commandBarGalleryDropDown10.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown10.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown10.Manager = Nothing
			Me.commandBarGalleryDropDown10.Name = "commandBarGalleryDropDown10"
			' 
			' commandBarGalleryDropDown11
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown11.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup105.CommandName = "InsertChartScatterCommandGroup"
			spreadsheetCommandGalleryItem459.CommandName = "InsertChartScatterMarkers"
			spreadsheetCommandGalleryItem460.CommandName = "InsertChartScatterSmoothLinesAndMarkers"
			spreadsheetCommandGalleryItem461.CommandName = "InsertChartScatterSmoothLines"
			spreadsheetCommandGalleryItem462.CommandName = "InsertChartScatterLinesAndMarkers"
			spreadsheetCommandGalleryItem463.CommandName = "InsertChartScatterLines"
			spreadsheetCommandGalleryItemGroup105.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem459, spreadsheetCommandGalleryItem460, spreadsheetCommandGalleryItem461, spreadsheetCommandGalleryItem462, spreadsheetCommandGalleryItem463})
			spreadsheetCommandGalleryItemGroup106.CommandName = "InsertChartBubbleCommandGroup"
			spreadsheetCommandGalleryItem464.CommandName = "InsertChartBubble"
			spreadsheetCommandGalleryItem465.CommandName = "InsertChartBubble3D"
			spreadsheetCommandGalleryItemGroup106.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem464, spreadsheetCommandGalleryItem465})
			Me.commandBarGalleryDropDown11.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup105, spreadsheetCommandGalleryItemGroup106})
			Me.commandBarGalleryDropDown11.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown11.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown11.Manager = Nothing
			Me.commandBarGalleryDropDown11.Name = "commandBarGalleryDropDown11"
			' 
			' commandBarGalleryDropDown12
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown12.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup107.CommandName = "InsertChartStockCommandGroup"
			spreadsheetCommandGalleryItem466.CommandName = "InsertChartStockHighLowClose"
			spreadsheetCommandGalleryItem467.CommandName = "InsertChartStockOpenHighLowClose"
			spreadsheetCommandGalleryItemGroup107.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem466, spreadsheetCommandGalleryItem467})
			spreadsheetCommandGalleryItemGroup108.CommandName = "InsertChartRadarCommandGroup"
			spreadsheetCommandGalleryItem468.CommandName = "InsertChartRadar"
			spreadsheetCommandGalleryItem469.CommandName = "InsertChartRadarWithMarkers"
			spreadsheetCommandGalleryItem470.CommandName = "InsertChartRadarFilled"
			spreadsheetCommandGalleryItemGroup108.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem468, spreadsheetCommandGalleryItem469, spreadsheetCommandGalleryItem470})
			Me.commandBarGalleryDropDown12.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup107, spreadsheetCommandGalleryItemGroup108})
			Me.commandBarGalleryDropDown12.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown12.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown12.Manager = Nothing
			Me.commandBarGalleryDropDown12.Name = "commandBarGalleryDropDown12"
			' 
			' commandBarGalleryDropDown13
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown13.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown13.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup109.CommandName = "ChartTitleCommandGroup"
			spreadsheetCommandGalleryItem471.CommandName = "ChartTitleNone"
			spreadsheetCommandGalleryItem472.CommandName = "ChartTitleCenteredOverlay"
			spreadsheetCommandGalleryItem473.CommandName = "ChartTitleAbove"
			spreadsheetCommandGalleryItemGroup109.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem471, spreadsheetCommandGalleryItem472, spreadsheetCommandGalleryItem473})
			Me.commandBarGalleryDropDown13.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup109})
			Me.commandBarGalleryDropDown13.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown13.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown13.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown13.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown13.Manager = Nothing
			Me.commandBarGalleryDropDown13.Name = "commandBarGalleryDropDown13"
			' 
			' commandBarGalleryDropDown14
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown14.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown14.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup110.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup"
			spreadsheetCommandGalleryItem474.CommandName = "ChartPrimaryHorizontalAxisTitleNone"
			spreadsheetCommandGalleryItem475.CommandName = "ChartPrimaryHorizontalAxisTitleBelow"
			spreadsheetCommandGalleryItemGroup110.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem474, spreadsheetCommandGalleryItem475})
			Me.commandBarGalleryDropDown14.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup110})
			Me.commandBarGalleryDropDown14.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown14.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown14.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown14.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown14.Manager = Nothing
			Me.commandBarGalleryDropDown14.Name = "commandBarGalleryDropDown14"
			' 
			' commandBarGalleryDropDown15
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown15.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown15.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup111.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup"
			spreadsheetCommandGalleryItem476.CommandName = "ChartPrimaryVerticalAxisTitleNone"
			spreadsheetCommandGalleryItem477.CommandName = "ChartPrimaryVerticalAxisTitleRotated"
			spreadsheetCommandGalleryItem478.CommandName = "ChartPrimaryVerticalAxisTitleVertical"
			spreadsheetCommandGalleryItem479.CommandName = "ChartPrimaryVerticalAxisTitleHorizontal"
			spreadsheetCommandGalleryItemGroup111.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem476, spreadsheetCommandGalleryItem477, spreadsheetCommandGalleryItem478, spreadsheetCommandGalleryItem479})
			Me.commandBarGalleryDropDown15.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup111})
			Me.commandBarGalleryDropDown15.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown15.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown15.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown15.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown15.Manager = Nothing
			Me.commandBarGalleryDropDown15.Name = "commandBarGalleryDropDown15"
			' 
			' commandBarGalleryDropDown16
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown16.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown16.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup112.CommandName = "ChartLegendCommandGroup"
			spreadsheetCommandGalleryItem480.CommandName = "ChartLegendNone"
			spreadsheetCommandGalleryItem481.CommandName = "ChartLegendAtRight"
			spreadsheetCommandGalleryItem482.CommandName = "ChartLegendAtTop"
			spreadsheetCommandGalleryItem483.CommandName = "ChartLegendAtLeft"
			spreadsheetCommandGalleryItem484.CommandName = "ChartLegendAtBottom"
			spreadsheetCommandGalleryItem485.CommandName = "ChartLegendOverlayAtRight"
			spreadsheetCommandGalleryItem486.CommandName = "ChartLegendOverlayAtLeft"
			spreadsheetCommandGalleryItemGroup112.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem480, spreadsheetCommandGalleryItem481, spreadsheetCommandGalleryItem482, spreadsheetCommandGalleryItem483, spreadsheetCommandGalleryItem484, spreadsheetCommandGalleryItem485, spreadsheetCommandGalleryItem486})
			Me.commandBarGalleryDropDown16.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup112})
			Me.commandBarGalleryDropDown16.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown16.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown16.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown16.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown16.Manager = Nothing
			Me.commandBarGalleryDropDown16.Name = "commandBarGalleryDropDown16"
			' 
			' commandBarGalleryDropDown17
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown17.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown17.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup113.CommandName = "ChartDataLabelsCommandGroup"
			spreadsheetCommandGalleryItem487.CommandName = "ChartDataLabelsNone"
			spreadsheetCommandGalleryItem488.CommandName = "ChartDataLabelsDefault"
			spreadsheetCommandGalleryItem489.CommandName = "ChartDataLabelsCenter"
			spreadsheetCommandGalleryItem490.CommandName = "ChartDataLabelsInsideEnd"
			spreadsheetCommandGalleryItem491.CommandName = "ChartDataLabelsInsideBase"
			spreadsheetCommandGalleryItem492.CommandName = "ChartDataLabelsOutsideEnd"
			spreadsheetCommandGalleryItem493.CommandName = "ChartDataLabelsBestFit"
			spreadsheetCommandGalleryItem494.CommandName = "ChartDataLabelsLeft"
			spreadsheetCommandGalleryItem495.CommandName = "ChartDataLabelsRight"
			spreadsheetCommandGalleryItem496.CommandName = "ChartDataLabelsAbove"
			spreadsheetCommandGalleryItem497.CommandName = "ChartDataLabelsBelow"
			spreadsheetCommandGalleryItemGroup113.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem487, spreadsheetCommandGalleryItem488, spreadsheetCommandGalleryItem489, spreadsheetCommandGalleryItem490, spreadsheetCommandGalleryItem491, spreadsheetCommandGalleryItem492, spreadsheetCommandGalleryItem493, spreadsheetCommandGalleryItem494, spreadsheetCommandGalleryItem495, spreadsheetCommandGalleryItem496, spreadsheetCommandGalleryItem497})
			Me.commandBarGalleryDropDown17.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup113})
			Me.commandBarGalleryDropDown17.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown17.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown17.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown17.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown17.Manager = Nothing
			Me.commandBarGalleryDropDown17.Name = "commandBarGalleryDropDown17"
			' 
			' commandBarGalleryDropDown18
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown18.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown18.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup114.CommandName = "ChartPrimaryHorizontalAxisCommandGroup"
			spreadsheetCommandGalleryItem498.CommandName = "ChartHidePrimaryHorizontalAxis"
			spreadsheetCommandGalleryItem499.CommandName = "ChartPrimaryHorizontalAxisLeftToRight"
			spreadsheetCommandGalleryItem500.CommandName = "ChartPrimaryHorizontalAxisHideLabels"
			spreadsheetCommandGalleryItem501.CommandName = "ChartPrimaryHorizontalAxisRightToLeft"
			spreadsheetCommandGalleryItem502.CommandName = "ChartPrimaryHorizontalAxisDefault"
			spreadsheetCommandGalleryItem503.CommandName = "ChartPrimaryHorizontalAxisScaleThousands"
			spreadsheetCommandGalleryItem504.CommandName = "ChartPrimaryHorizontalAxisScaleMillions"
			spreadsheetCommandGalleryItem505.CommandName = "ChartPrimaryHorizontalAxisScaleBillions"
			spreadsheetCommandGalleryItem506.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm"
			spreadsheetCommandGalleryItemGroup114.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem498, spreadsheetCommandGalleryItem499, spreadsheetCommandGalleryItem500, spreadsheetCommandGalleryItem501, spreadsheetCommandGalleryItem502, spreadsheetCommandGalleryItem503, spreadsheetCommandGalleryItem504, spreadsheetCommandGalleryItem505, spreadsheetCommandGalleryItem506})
			Me.commandBarGalleryDropDown18.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup114})
			Me.commandBarGalleryDropDown18.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown18.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown18.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown18.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown18.Manager = Nothing
			Me.commandBarGalleryDropDown18.Name = "commandBarGalleryDropDown18"
			' 
			' commandBarGalleryDropDown19
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown19.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown19.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup115.CommandName = "ChartPrimaryVerticalAxisCommandGroup"
			spreadsheetCommandGalleryItem507.CommandName = "ChartHidePrimaryVerticalAxis"
			spreadsheetCommandGalleryItem508.CommandName = "ChartPrimaryVerticalAxisLeftToRight"
			spreadsheetCommandGalleryItem509.CommandName = "ChartPrimaryVerticalAxisHideLabels"
			spreadsheetCommandGalleryItem510.CommandName = "ChartPrimaryVerticalAxisRightToLeft"
			spreadsheetCommandGalleryItem511.CommandName = "ChartPrimaryVerticalAxisDefault"
			spreadsheetCommandGalleryItem512.CommandName = "ChartPrimaryVerticalAxisScaleThousands"
			spreadsheetCommandGalleryItem513.CommandName = "ChartPrimaryVerticalAxisScaleMillions"
			spreadsheetCommandGalleryItem514.CommandName = "ChartPrimaryVerticalAxisScaleBillions"
			spreadsheetCommandGalleryItem515.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm"
			spreadsheetCommandGalleryItemGroup115.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem507, spreadsheetCommandGalleryItem508, spreadsheetCommandGalleryItem509, spreadsheetCommandGalleryItem510, spreadsheetCommandGalleryItem511, spreadsheetCommandGalleryItem512, spreadsheetCommandGalleryItem513, spreadsheetCommandGalleryItem514, spreadsheetCommandGalleryItem515})
			Me.commandBarGalleryDropDown19.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup115})
			Me.commandBarGalleryDropDown19.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown19.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown19.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown19.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown19.Manager = Nothing
			Me.commandBarGalleryDropDown19.Name = "commandBarGalleryDropDown19"
			' 
			' commandBarGalleryDropDown20
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown20.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown20.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup116.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup"
			spreadsheetCommandGalleryItem516.CommandName = "ChartPrimaryHorizontalGridlinesNone"
			spreadsheetCommandGalleryItem517.CommandName = "ChartPrimaryHorizontalGridlinesMajor"
			spreadsheetCommandGalleryItem518.CommandName = "ChartPrimaryHorizontalGridlinesMinor"
			spreadsheetCommandGalleryItem519.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor"
			spreadsheetCommandGalleryItemGroup116.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem516, spreadsheetCommandGalleryItem517, spreadsheetCommandGalleryItem518, spreadsheetCommandGalleryItem519})
			Me.commandBarGalleryDropDown20.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup116})
			Me.commandBarGalleryDropDown20.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown20.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown20.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown20.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown20.Manager = Nothing
			Me.commandBarGalleryDropDown20.Name = "commandBarGalleryDropDown20"
			' 
			' commandBarGalleryDropDown21
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown21.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown21.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup117.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup"
			spreadsheetCommandGalleryItem520.CommandName = "ChartPrimaryVerticalGridlinesNone"
			spreadsheetCommandGalleryItem521.CommandName = "ChartPrimaryVerticalGridlinesMajor"
			spreadsheetCommandGalleryItem522.CommandName = "ChartPrimaryVerticalGridlinesMinor"
			spreadsheetCommandGalleryItem523.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor"
			spreadsheetCommandGalleryItemGroup117.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem520, spreadsheetCommandGalleryItem521, spreadsheetCommandGalleryItem522, spreadsheetCommandGalleryItem523})
			Me.commandBarGalleryDropDown21.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup117})
			Me.commandBarGalleryDropDown21.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown21.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown21.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown21.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown21.Manager = Nothing
			Me.commandBarGalleryDropDown21.Name = "commandBarGalleryDropDown21"
			' 
			' commandBarGalleryDropDown22
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown22.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown22.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup118.CommandName = "ChartLinesCommandGroup"
			spreadsheetCommandGalleryItem524.CommandName = "ChartLinesNone"
			spreadsheetCommandGalleryItem525.CommandName = "ChartShowDropLines"
			spreadsheetCommandGalleryItem526.CommandName = "ChartShowHighLowLines"
			spreadsheetCommandGalleryItem527.CommandName = "ChartShowDropLinesAndHighLowLines"
			spreadsheetCommandGalleryItem528.CommandName = "ChartShowSeriesLines"
			spreadsheetCommandGalleryItemGroup118.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem524, spreadsheetCommandGalleryItem525, spreadsheetCommandGalleryItem526, spreadsheetCommandGalleryItem527, spreadsheetCommandGalleryItem528})
			Me.commandBarGalleryDropDown22.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup118})
			Me.commandBarGalleryDropDown22.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown22.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown22.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown22.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown22.Manager = Nothing
			Me.commandBarGalleryDropDown22.Name = "commandBarGalleryDropDown22"
			' 
			' commandBarGalleryDropDown23
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown23.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown23.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup119.CommandName = "ChartUpDownBarsCommandGroup"
			spreadsheetCommandGalleryItem529.CommandName = "ChartHideUpDownBars"
			spreadsheetCommandGalleryItem530.CommandName = "ChartShowUpDownBars"
			spreadsheetCommandGalleryItemGroup119.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem529, spreadsheetCommandGalleryItem530})
			Me.commandBarGalleryDropDown23.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup119})
			Me.commandBarGalleryDropDown23.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown23.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown23.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown23.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown23.Manager = Nothing
			Me.commandBarGalleryDropDown23.Name = "commandBarGalleryDropDown23"
			' 
			' commandBarGalleryDropDown24
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown24.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown24.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup120.CommandName = "ChartErrorBarsCommandGroup"
			spreadsheetCommandGalleryItem531.CommandName = "ChartErrorBarsNone"
			spreadsheetCommandGalleryItem532.CommandName = "ChartErrorBarsStandardError"
			spreadsheetCommandGalleryItem533.CommandName = "ChartErrorBarsPercentage"
			spreadsheetCommandGalleryItem534.CommandName = "ChartErrorBarsStandardDeviation"
			spreadsheetCommandGalleryItemGroup120.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem531, spreadsheetCommandGalleryItem532, spreadsheetCommandGalleryItem533, spreadsheetCommandGalleryItem534})
			Me.commandBarGalleryDropDown24.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup120})
			Me.commandBarGalleryDropDown24.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown24.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown24.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown24.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown24.Manager = Nothing
			Me.commandBarGalleryDropDown24.Name = "commandBarGalleryDropDown24"
			' 
			' fromFaxEdit
			' 
			Me.fromFaxEdit.EditValue = "(111)111-1112"
			Me.fromFaxEdit.Location = New System.Drawing.Point(286, 71)
			Me.fromFaxEdit.Name = "fromFaxEdit"
			Me.fromFaxEdit.Size = New System.Drawing.Size(134, 20)
			Me.fromFaxEdit.TabIndex = 28
			' 
			' fromFaxLabel
			' 
			Me.fromFaxLabel.Location = New System.Drawing.Point(236, 74)
			Me.fromFaxLabel.Name = "fromFaxLabel"
			Me.fromFaxLabel.Size = New System.Drawing.Size(22, 13)
			Me.fromFaxLabel.TabIndex = 27
			Me.fromFaxLabel.Text = "Fax:"
			' 
			' fromPhoneEdit
			' 
			Me.fromPhoneEdit.EditValue = "(111)111-1111"
			Me.fromPhoneEdit.Location = New System.Drawing.Point(105, 71)
			Me.fromPhoneEdit.Name = "fromPhoneEdit"
			Me.fromPhoneEdit.Size = New System.Drawing.Size(125, 20)
			Me.fromPhoneEdit.TabIndex = 26
			' 
			' fromPhoneLabel
			' 
			Me.fromPhoneLabel.Location = New System.Drawing.Point(12, 74)
			Me.fromPhoneLabel.Name = "fromPhoneLabel"
			Me.fromPhoneLabel.Size = New System.Drawing.Size(34, 13)
			Me.fromPhoneLabel.TabIndex = 25
			Me.fromPhoneLabel.Text = "Phone:"
			' 
			' fromZipEdit
			' 
			Me.fromZipEdit.EditValue = "55555"
			Me.fromZipEdit.Location = New System.Drawing.Point(602, 47)
			Me.fromZipEdit.Name = "fromZipEdit"
			Me.fromZipEdit.Size = New System.Drawing.Size(78, 20)
			Me.fromZipEdit.TabIndex = 24
			' 
			' fromZipLabel
			' 
			Me.fromZipLabel.Location = New System.Drawing.Point(556, 50)
			Me.fromZipLabel.Name = "fromZipLabel"
			Me.fromZipLabel.Size = New System.Drawing.Size(20, 13)
			Me.fromZipLabel.TabIndex = 23
			Me.fromZipLabel.Text = "ZIP:"
			' 
			' fromStateEdit
			' 
			Me.fromStateEdit.EditValue = "CA"
			Me.fromStateEdit.Location = New System.Drawing.Point(472, 47)
			Me.fromStateEdit.Name = "fromStateEdit"
			Me.fromStateEdit.Size = New System.Drawing.Size(78, 20)
			Me.fromStateEdit.TabIndex = 22
			' 
			' fromStateLabel
			' 
			Me.fromStateLabel.Location = New System.Drawing.Point(426, 50)
			Me.fromStateLabel.Name = "fromStateLabel"
			Me.fromStateLabel.Size = New System.Drawing.Size(30, 13)
			Me.fromStateLabel.TabIndex = 21
			Me.fromStateLabel.Text = "State:"
			' 
			' fromCityEdit
			' 
			Me.fromCityEdit.EditValue = "Homesville"
			Me.fromCityEdit.Location = New System.Drawing.Point(286, 47)
			Me.fromCityEdit.Name = "fromCityEdit"
			Me.fromCityEdit.Size = New System.Drawing.Size(134, 20)
			Me.fromCityEdit.TabIndex = 20
			' 
			' fromCityLabel
			' 
			Me.fromCityLabel.Location = New System.Drawing.Point(236, 50)
			Me.fromCityLabel.Name = "fromCityLabel"
			Me.fromCityLabel.Size = New System.Drawing.Size(23, 13)
			Me.fromCityLabel.TabIndex = 19
			Me.fromCityLabel.Text = "City:"
			' 
			' fromAddressEdit
			' 
			Me.fromAddressEdit.EditValue = "123 Home Lane"
			Me.fromAddressEdit.Location = New System.Drawing.Point(105, 47)
			Me.fromAddressEdit.Name = "fromAddressEdit"
			Me.fromAddressEdit.Size = New System.Drawing.Size(125, 20)
			Me.fromAddressEdit.TabIndex = 18
			' 
			' fromAddressLabel
			' 
			Me.fromAddressLabel.Location = New System.Drawing.Point(12, 50)
			Me.fromAddressLabel.Name = "fromAddressLabel"
			Me.fromAddressLabel.Size = New System.Drawing.Size(76, 13)
			Me.fromAddressLabel.TabIndex = 17
			Me.fromAddressLabel.Text = "Street Address:"
			' 
			' fromCompanySloganEdit
			' 
			Me.fromCompanySloganEdit.EditValue = "Do what must be done"
			Me.fromCompanySloganEdit.Location = New System.Drawing.Point(286, 23)
			Me.fromCompanySloganEdit.Name = "fromCompanySloganEdit"
			Me.fromCompanySloganEdit.Size = New System.Drawing.Size(394, 20)
			Me.fromCompanySloganEdit.TabIndex = 16
			' 
			' fromCompanySloganLabel
			' 
			Me.fromCompanySloganLabel.Location = New System.Drawing.Point(236, 26)
			Me.fromCompanySloganLabel.Name = "fromCompanySloganLabel"
			Me.fromCompanySloganLabel.Size = New System.Drawing.Size(36, 13)
			Me.fromCompanySloganLabel.TabIndex = 15
			Me.fromCompanySloganLabel.Text = "Slogan:"
			' 
			' fromCompanyEdit
			' 
			Me.fromCompanyEdit.EditValue = "Vader Enterprises"
			Me.fromCompanyEdit.Location = New System.Drawing.Point(105, 23)
			Me.fromCompanyEdit.Name = "fromCompanyEdit"
			Me.fromCompanyEdit.Size = New System.Drawing.Size(125, 20)
			Me.fromCompanyEdit.TabIndex = 14
			' 
			' fromCompanyLabel
			' 
			Me.fromCompanyLabel.Location = New System.Drawing.Point(12, 26)
			Me.fromCompanyLabel.Name = "fromCompanyLabel"
			Me.fromCompanyLabel.Size = New System.Drawing.Size(49, 13)
			Me.fromCompanyLabel.TabIndex = 13
			Me.fromCompanyLabel.Text = "Company:"
			' 
			' toCompanyNameEdit
			' 
			Me.toCompanyNameEdit.EditValue = "Mickeys World of Fun"
			Me.toCompanyNameEdit.Location = New System.Drawing.Point(286, 24)
			Me.toCompanyNameEdit.Name = "toCompanyNameEdit"
			Me.toCompanyNameEdit.Size = New System.Drawing.Size(134, 20)
			Me.toCompanyNameEdit.TabIndex = 32
			' 
			' toCompanylabel
			' 
			Me.toCompanylabel.Location = New System.Drawing.Point(236, 27)
			Me.toCompanylabel.Name = "toCompanylabel"
			Me.toCompanylabel.Size = New System.Drawing.Size(49, 13)
			Me.toCompanylabel.TabIndex = 39
			Me.toCompanylabel.Text = "Company:"
			' 
			' toPhoneEdit
			' 
			Me.toPhoneEdit.EditValue = "(203)290-8902"
			Me.toPhoneEdit.Location = New System.Drawing.Point(105, 72)
			Me.toPhoneEdit.Name = "toPhoneEdit"
			Me.toPhoneEdit.Size = New System.Drawing.Size(125, 20)
			Me.toPhoneEdit.TabIndex = 42
			' 
			' toPhoneLabel
			' 
			Me.toPhoneLabel.Location = New System.Drawing.Point(12, 75)
			Me.toPhoneLabel.Name = "toPhoneLabel"
			Me.toPhoneLabel.Size = New System.Drawing.Size(34, 13)
			Me.toPhoneLabel.TabIndex = 37
			Me.toPhoneLabel.Text = "Phone:"
			' 
			' toZipEdit
			' 
			Me.toZipEdit.EditValue = "37288"
			Me.toZipEdit.Location = New System.Drawing.Point(601, 48)
			Me.toZipEdit.Name = "toZipEdit"
			Me.toZipEdit.Size = New System.Drawing.Size(78, 20)
			Me.toZipEdit.TabIndex = 40
			' 
			' toZipLabel
			' 
			Me.toZipLabel.Location = New System.Drawing.Point(556, 51)
			Me.toZipLabel.Name = "toZipLabel"
			Me.toZipLabel.Size = New System.Drawing.Size(20, 13)
			Me.toZipLabel.TabIndex = 35
			Me.toZipLabel.Text = "ZIP:"
			' 
			' toStateEdit
			' 
			Me.toStateEdit.EditValue = "OH"
			Me.toStateEdit.Location = New System.Drawing.Point(472, 48)
			Me.toStateEdit.Name = "toStateEdit"
			Me.toStateEdit.Size = New System.Drawing.Size(78, 20)
			Me.toStateEdit.TabIndex = 38
			' 
			' toStateLabel
			' 
			Me.toStateLabel.Location = New System.Drawing.Point(426, 51)
			Me.toStateLabel.Name = "toStateLabel"
			Me.toStateLabel.Size = New System.Drawing.Size(30, 13)
			Me.toStateLabel.TabIndex = 33
			Me.toStateLabel.Text = "State:"
			' 
			' toCityEdit
			' 
			Me.toCityEdit.EditValue = "Cleveland"
			Me.toCityEdit.Location = New System.Drawing.Point(286, 48)
			Me.toCityEdit.Name = "toCityEdit"
			Me.toCityEdit.Size = New System.Drawing.Size(134, 20)
			Me.toCityEdit.TabIndex = 36
			' 
			' toCityLabel
			' 
			Me.toCityLabel.Location = New System.Drawing.Point(236, 51)
			Me.toCityLabel.Name = "toCityLabel"
			Me.toCityLabel.Size = New System.Drawing.Size(23, 13)
			Me.toCityLabel.TabIndex = 31
			Me.toCityLabel.Text = "City:"
			' 
			' toStreetEdit
			' 
			Me.toStreetEdit.EditValue = "436 1st Ave."
			Me.toStreetEdit.Location = New System.Drawing.Point(105, 48)
			Me.toStreetEdit.Name = "toStreetEdit"
			Me.toStreetEdit.Size = New System.Drawing.Size(125, 20)
			Me.toStreetEdit.TabIndex = 34
			' 
			' toStreetLabel
			' 
			Me.toStreetLabel.Location = New System.Drawing.Point(12, 51)
			Me.toStreetLabel.Name = "toStreetLabel"
			Me.toStreetLabel.Size = New System.Drawing.Size(76, 13)
			Me.toStreetLabel.TabIndex = 29
			Me.toStreetLabel.Text = "Street Address:"
			' 
			' toNameEdit
			' 
			Me.toNameEdit.EditValue = "Alcorn Mickey"
			Me.toNameEdit.Location = New System.Drawing.Point(105, 24)
			Me.toNameEdit.Name = "toNameEdit"
			Me.toNameEdit.Size = New System.Drawing.Size(125, 20)
			Me.toNameEdit.TabIndex = 30
			' 
			' toNameLabel
			' 
			Me.toNameLabel.Location = New System.Drawing.Point(12, 27)
			Me.toNameLabel.Name = "toNameLabel"
			Me.toNameLabel.Size = New System.Drawing.Size(31, 13)
			Me.toNameLabel.TabIndex = 27
			Me.toNameLabel.Text = "Name:"
			' 
			' mainTabControl
			' 
			Me.mainTabControl.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.mainTabControl.Appearance.Options.UseBackColor = True
			Me.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mainTabControl.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
			Me.mainTabControl.Location = New System.Drawing.Point(0, 116)
			Me.mainTabControl.Name = "mainTabControl"
			Me.mainTabControl.SelectedTabPage = Me.invoiceTabPage
			Me.mainTabControl.Size = New System.Drawing.Size(696, 362)
			Me.mainTabControl.TabIndex = 54
			Me.mainTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.dataTabPage, Me.invoiceTabPage})
'			Me.mainTabControl.SelectedPageChanged += New DevExpress.XtraTab.TabPageChangedEventHandler(Me.xtraTabControl1_SelectedPageChanged);
			' 
			' invoiceTabPage
			' 
			Me.invoiceTabPage.Controls.Add(Me.panelControl1)
			Me.invoiceTabPage.Name = "invoiceTabPage"
			Me.invoiceTabPage.Size = New System.Drawing.Size(690, 334)
			Me.invoiceTabPage.Text = "Invoice"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.spreadsheetControl1)
			Me.panelControl1.Controls.Add(Me.splitterControl1)
			Me.panelControl1.Controls.Add(Me.splitContainerControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(690, 334)
			Me.panelControl1.TabIndex = 0
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitterControl1.Location = New System.Drawing.Point(2, 22)
			Me.splitterControl1.MinSize = 20
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(686, 5)
			Me.splitterControl1.TabIndex = 51
			Me.splitterControl1.TabStop = False
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitContainerControl1.Location = New System.Drawing.Point(2, 2)
			Me.splitContainerControl1.MinimumSize = New System.Drawing.Size(0, 20)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.spreadsheetNameBoxControl1)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetFormulaBarControl1)
			Me.splitContainerControl1.Size = New System.Drawing.Size(686, 20)
			Me.splitContainerControl1.TabIndex = 52
			' 
			' spreadsheetNameBoxControl1
			' 
			Me.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetNameBoxControl1.EditValue = "A1"
			Me.spreadsheetNameBoxControl1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1"
			Me.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.spreadsheetNameBoxControl1.ReadOnly = DevExpress.Utils.DefaultBoolean.Default
			Me.spreadsheetNameBoxControl1.Size = New System.Drawing.Size(100, 20)
			Me.spreadsheetNameBoxControl1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetNameBoxControl1.TabIndex = 0
			' 
			' spreadsheetFormulaBarControl1
			' 
			Me.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetFormulaBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetFormulaBarControl1.MinimumSize = New System.Drawing.Size(0, 20)
			Me.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1"
			Me.spreadsheetFormulaBarControl1.Size = New System.Drawing.Size(581, 20)
			Me.spreadsheetFormulaBarControl1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetFormulaBarControl1.TabIndex = 0
			' 
			' dataTabPage
			' 
			Me.dataTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(239))))))
			Me.dataTabPage.Appearance.PageClient.Options.UseBackColor = True
			Me.dataTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.dataTabPage.Controls.Add(Me.toGroupControl)
			Me.dataTabPage.Controls.Add(Me.fromGroupControl)
			Me.dataTabPage.Controls.Add(Me.gridControl1)
			Me.dataTabPage.Name = "dataTabPage"
			Me.dataTabPage.Size = New System.Drawing.Size(690, 403)
			Me.dataTabPage.Text = "Data"
			' 
			' toGroupControl
			' 
			Me.toGroupControl.Controls.Add(Me.toCompanyNameEdit)
			Me.toGroupControl.Controls.Add(Me.toNameEdit)
			Me.toGroupControl.Controls.Add(Me.toCompanylabel)
			Me.toGroupControl.Controls.Add(Me.toNameLabel)
			Me.toGroupControl.Controls.Add(Me.toPhoneEdit)
			Me.toGroupControl.Controls.Add(Me.toStreetLabel)
			Me.toGroupControl.Controls.Add(Me.toPhoneLabel)
			Me.toGroupControl.Controls.Add(Me.toStreetEdit)
			Me.toGroupControl.Controls.Add(Me.toZipEdit)
			Me.toGroupControl.Controls.Add(Me.toCityLabel)
			Me.toGroupControl.Controls.Add(Me.toZipLabel)
			Me.toGroupControl.Controls.Add(Me.toCityEdit)
			Me.toGroupControl.Controls.Add(Me.toStateEdit)
			Me.toGroupControl.Controls.Add(Me.toStateLabel)
			Me.toGroupControl.Location = New System.Drawing.Point(3, 128)
			Me.toGroupControl.Name = "toGroupControl"
			Me.toGroupControl.Size = New System.Drawing.Size(684, 97)
			Me.toGroupControl.TabIndex = 56
			Me.toGroupControl.Text = "Bill to"
			' 
			' fromGroupControl
			' 
			Me.fromGroupControl.Controls.Add(Me.fromContactNameLabel)
			Me.fromGroupControl.Controls.Add(Me.fromContactNameEdit)
			Me.fromGroupControl.Controls.Add(Me.fromEMailLabel)
			Me.fromGroupControl.Controls.Add(Me.fromEMailEdit)
			Me.fromGroupControl.Controls.Add(Me.fromFaxEdit)
			Me.fromGroupControl.Controls.Add(Me.fromCompanyLabel)
			Me.fromGroupControl.Controls.Add(Me.fromFaxLabel)
			Me.fromGroupControl.Controls.Add(Me.fromCompanyEdit)
			Me.fromGroupControl.Controls.Add(Me.fromPhoneEdit)
			Me.fromGroupControl.Controls.Add(Me.fromPhoneLabel)
			Me.fromGroupControl.Controls.Add(Me.fromCompanySloganLabel)
			Me.fromGroupControl.Controls.Add(Me.fromCompanySloganEdit)
			Me.fromGroupControl.Controls.Add(Me.fromZipEdit)
			Me.fromGroupControl.Controls.Add(Me.fromAddressLabel)
			Me.fromGroupControl.Controls.Add(Me.fromZipLabel)
			Me.fromGroupControl.Controls.Add(Me.fromAddressEdit)
			Me.fromGroupControl.Controls.Add(Me.fromStateEdit)
			Me.fromGroupControl.Controls.Add(Me.fromCityLabel)
			Me.fromGroupControl.Controls.Add(Me.fromStateLabel)
			Me.fromGroupControl.Controls.Add(Me.fromCityEdit)
			Me.fromGroupControl.Location = New System.Drawing.Point(3, 4)
			Me.fromGroupControl.Name = "fromGroupControl"
			Me.fromGroupControl.Size = New System.Drawing.Size(684, 120)
			Me.fromGroupControl.TabIndex = 55
			Me.fromGroupControl.Text = "From"
			' 
			' fromContactNameLabel
			' 
			Me.fromContactNameLabel.Location = New System.Drawing.Point(12, 98)
			Me.fromContactNameLabel.Name = "fromContactNameLabel"
			Me.fromContactNameLabel.Size = New System.Drawing.Size(78, 13)
			Me.fromContactNameLabel.TabIndex = 29
			Me.fromContactNameLabel.Text = "Contact Person:"
			' 
			' fromContactNameEdit
			' 
			Me.fromContactNameEdit.EditValue = "Darth Vader"
			Me.fromContactNameEdit.Location = New System.Drawing.Point(105, 95)
			Me.fromContactNameEdit.Name = "fromContactNameEdit"
			Me.fromContactNameEdit.Size = New System.Drawing.Size(125, 20)
			Me.fromContactNameEdit.TabIndex = 30
			' 
			' fromEMailLabel
			' 
			Me.fromEMailLabel.Location = New System.Drawing.Point(236, 98)
			Me.fromEMailLabel.Name = "fromEMailLabel"
			Me.fromEMailLabel.Size = New System.Drawing.Size(28, 13)
			Me.fromEMailLabel.TabIndex = 31
			Me.fromEMailLabel.Text = "Email:"
			' 
			' fromEMailEdit
			' 
			Me.fromEMailEdit.EditValue = "darth@vader.com"
			Me.fromEMailEdit.Location = New System.Drawing.Point(286, 95)
			Me.fromEMailEdit.Name = "fromEMailEdit"
			Me.fromEMailEdit.Size = New System.Drawing.Size(134, 20)
			Me.fromEMailEdit.TabIndex = 32
			' 
			' gridControl1
			' 
			Me.gridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridControl1.DataSource = Me.productsBindingSource
			Me.gridControl1.Location = New System.Drawing.Point(3, 229)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.includeItemCheckEdit})
			Me.gridControl1.Size = New System.Drawing.Size(684, 290)
			Me.gridControl1.TabIndex = 54
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.colProductName, Me.colQuantity, Me.colDiscount, Me.colUnitPrice})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsCustomization.AllowColumnMoving = False
			Me.gridView1.OptionsMenu.EnableColumnMenu = False
			Me.gridView1.OptionsSelection.MultiSelect = True
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colUnitPrice, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gridView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gridView1_CustomUnboundColumnData);
			' 
			' gridColumn1
			' 
			Me.gridColumn1.AppearanceHeader.Options.UseTextOptions = True
			Me.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.gridColumn1.Caption = " "
			Me.gridColumn1.ColumnEdit = Me.includeItemCheckEdit
			Me.gridColumn1.FieldName = "AppendIntoInvoice"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
			Me.gridColumn1.ToolTip = "You can add up to 18 items to invoice"
			Me.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Boolean
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			Me.gridColumn1.Width = 23
			' 
			' includeItemCheckEdit
			' 
			Me.includeItemCheckEdit.AutoHeight = False
			Me.includeItemCheckEdit.Caption = "Check"
			Me.includeItemCheckEdit.Name = "includeItemCheckEdit"
'			Me.includeItemCheckEdit.CheckStateChanged += New System.EventHandler(Me.includeItemCheckEdit_CheckStateChanged);
			' 
			' colProductName
			' 
			Me.colProductName.AppearanceHeader.Options.UseTextOptions = True
			Me.colProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.colProductName.Caption = "Product Name"
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.OptionsColumn.ReadOnly = True
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 1
			Me.colProductName.Width = 510
			' 
			' colQuantity
			' 
			Me.colQuantity.AppearanceHeader.Options.UseTextOptions = True
			Me.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.colQuantity.Caption = "Quantity"
			Me.colQuantity.FieldName = "Quantity"
			Me.colQuantity.Name = "colQuantity"
			Me.colQuantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.colQuantity.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			Me.colQuantity.Visible = True
			Me.colQuantity.VisibleIndex = 2
			Me.colQuantity.Width = 58
			' 
			' colDiscount
			' 
			Me.colDiscount.AppearanceHeader.Options.UseTextOptions = True
			Me.colDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.colDiscount.Caption = "Discount, %"
			Me.colDiscount.FieldName = "Discount"
			Me.colDiscount.Name = "colDiscount"
			Me.colDiscount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.colDiscount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			Me.colDiscount.Visible = True
			Me.colDiscount.VisibleIndex = 3
			Me.colDiscount.Width = 81
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.AppearanceHeader.Options.UseTextOptions = True
			Me.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.colUnitPrice.Caption = "Unit Price"
			Me.colUnitPrice.DisplayFormat.FormatString = "0.00"
			Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True
			Me.colUnitPrice.OptionsColumn.ReadOnly = True
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 4
			Me.colUnitPrice.Width = 122
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' spreadsheetBarController1
			' 
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem107)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem108)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem109)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem110)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem111)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem119)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem120)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem121)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem122)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem123)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem2)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem3)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem4)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem5)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem6)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem7)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem8)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem9)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem10)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem11)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem12)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem13)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem14)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem15)
			Me.spreadsheetBarController1.BarItems.Add(Me.changeFontNameItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.changeFontSizeItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem16)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem17)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem2)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem3)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem4)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem18)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem19)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem20)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem21)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem22)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem23)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem24)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem25)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem26)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem27)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem28)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem29)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem30)
			Me.spreadsheetBarController1.BarItems.Add(Me.changeBorderLineColorItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.changeBorderLineStyleItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.changeCellFillColorItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.changeFontColorItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem5)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem6)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem7)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem8)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem9)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem10)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem31)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem32)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem11)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem2)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem12)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem33)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem34)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem35)
			Me.spreadsheetBarController1.BarItems.Add(Me.changeNumberFormatItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem3)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem36)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem37)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem38)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem39)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem40)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem41)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem42)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem43)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem44)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem4)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem5)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem45)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem46)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem47)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem48)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem49)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem50)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem51)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem6)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem52)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem53)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem54)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem55)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem56)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem57)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem2)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem3)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem58)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem7)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem59)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem60)
			Me.spreadsheetBarController1.BarItems.Add(Me.galleryFormatAsTableItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.galleryChangeStyleItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem8)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem61)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem62)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem63)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem9)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem64)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem65)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem66)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem10)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem67)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem68)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem69)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem70)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem71)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem11)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem72)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem73)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem74)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem75)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem76)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem77)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem78)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem79)
			Me.spreadsheetBarController1.BarItems.Add(Me.changeSheetTabColorItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem80)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem13)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem81)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem12)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem82)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem83)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem84)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem85)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem86)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem13)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem87)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem88)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem89)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem90)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem14)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem91)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem92)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem93)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem94)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem95)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem96)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem15)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem97)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem98)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem14)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem99)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem100)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem16)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem101)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem102)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem103)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem104)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem105)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem106)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem112)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem113)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem114)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem115)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem4)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem5)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem6)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem7)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem8)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem9)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem10)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem116)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem117)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem17)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem15)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem16)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem17)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem118)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem18)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem18)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem19)
			Me.spreadsheetBarController1.BarItems.Add(Me.pageSetupPaperKindItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem19)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem124)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem125)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem126)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem127)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem20)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem21)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem22)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem23)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem20)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem128)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem129)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem21)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem130)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem131)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem22)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem132)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem133)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem134)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem135)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem136)
			Me.spreadsheetBarController1.BarItems.Add(Me.functionsFinancialItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.functionsLogicalItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.functionsTextItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.functionsDateAndTimeItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.functionsLookupAndReferenceItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.functionsMathAndTrigonometryItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem23)
			Me.spreadsheetBarController1.BarItems.Add(Me.functionsStatisticalItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.functionsEngineeringItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.functionsInformationItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.functionsCompatibilityItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.functionsWebItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem137)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem138)
			Me.spreadsheetBarController1.BarItems.Add(Me.definedNameListItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem139)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem24)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem24)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem25)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem26)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem140)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem141)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem25)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem142)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem143)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem144)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem26)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem145)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem146)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem27)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem147)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem148)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem149)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem150)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem151)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem152)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem153)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem154)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem155)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem156)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem157)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem158)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem159)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem160)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem161)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem162)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem163)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem28)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem164)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem165)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem166)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem167)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem168)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem169)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem170)
			Me.spreadsheetBarController1.BarItems.Add(Me.galleryChartLayoutItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.galleryChartStyleItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem29)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem11)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem12)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem30)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem13)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem14)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem15)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem31)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem16)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem17)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem18)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem19)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem20)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem21)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem22)
			Me.spreadsheetBarController1.BarItems.Add(Me.renameTableItemCaption1)
			Me.spreadsheetBarController1.BarItems.Add(Me.renameTableItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem27)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem28)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem29)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem30)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem31)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem32)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem33)
			Me.spreadsheetBarController1.BarItems.Add(Me.galleryTableStylesItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem171)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem172)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem173)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem174)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem175)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem176)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem177)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem32)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem178)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem179)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem180)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem33)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem181)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem182)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem34)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem183)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem184)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem185)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem186)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem35)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem187)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem188)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem189)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem190)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem34)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem35)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem36)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem36)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem191)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem192)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem193)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem37)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem194)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem195)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem196)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem197)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem38)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem198)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem199)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem200)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem201)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem202)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem39)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem203)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem204)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem37)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem38)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem39)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem40)
			Me.spreadsheetBarController1.BarItems.Add(Me.galleryPivotStylesItem1)
			Me.spreadsheetBarController1.Control = Me.spreadsheetControl1
			' 
			' spreadsheetCommandBarButtonItem107
			' 
			Me.spreadsheetCommandBarButtonItem107.CommandName = "FunctionsInsertSum"
			Me.spreadsheetCommandBarButtonItem107.Id = -1
			Me.spreadsheetCommandBarButtonItem107.Name = "spreadsheetCommandBarButtonItem107"
			' 
			' spreadsheetCommandBarButtonItem108
			' 
			Me.spreadsheetCommandBarButtonItem108.CommandName = "FunctionsInsertAverage"
			Me.spreadsheetCommandBarButtonItem108.Id = -1
			Me.spreadsheetCommandBarButtonItem108.Name = "spreadsheetCommandBarButtonItem108"
			' 
			' spreadsheetCommandBarButtonItem109
			' 
			Me.spreadsheetCommandBarButtonItem109.CommandName = "FunctionsInsertCountNumbers"
			Me.spreadsheetCommandBarButtonItem109.Id = -1
			Me.spreadsheetCommandBarButtonItem109.Name = "spreadsheetCommandBarButtonItem109"
			' 
			' spreadsheetCommandBarButtonItem110
			' 
			Me.spreadsheetCommandBarButtonItem110.CommandName = "FunctionsInsertMax"
			Me.spreadsheetCommandBarButtonItem110.Id = -1
			Me.spreadsheetCommandBarButtonItem110.Name = "spreadsheetCommandBarButtonItem110"
			' 
			' spreadsheetCommandBarButtonItem111
			' 
			Me.spreadsheetCommandBarButtonItem111.CommandName = "FunctionsInsertMin"
			Me.spreadsheetCommandBarButtonItem111.Id = -1
			Me.spreadsheetCommandBarButtonItem111.Name = "spreadsheetCommandBarButtonItem111"
			' 
			' spreadsheetCommandBarButtonItem119
			' 
			Me.spreadsheetCommandBarButtonItem119.CommandName = "FunctionsInsertSum"
			Me.spreadsheetCommandBarButtonItem119.Id = -1
			Me.spreadsheetCommandBarButtonItem119.Name = "spreadsheetCommandBarButtonItem119"
			' 
			' spreadsheetCommandBarButtonItem120
			' 
			Me.spreadsheetCommandBarButtonItem120.CommandName = "FunctionsInsertAverage"
			Me.spreadsheetCommandBarButtonItem120.Id = -1
			Me.spreadsheetCommandBarButtonItem120.Name = "spreadsheetCommandBarButtonItem120"
			' 
			' spreadsheetCommandBarButtonItem121
			' 
			Me.spreadsheetCommandBarButtonItem121.CommandName = "FunctionsInsertCountNumbers"
			Me.spreadsheetCommandBarButtonItem121.Id = -1
			Me.spreadsheetCommandBarButtonItem121.Name = "spreadsheetCommandBarButtonItem121"
			' 
			' spreadsheetCommandBarButtonItem122
			' 
			Me.spreadsheetCommandBarButtonItem122.CommandName = "FunctionsInsertMax"
			Me.spreadsheetCommandBarButtonItem122.Id = -1
			Me.spreadsheetCommandBarButtonItem122.Name = "spreadsheetCommandBarButtonItem122"
			' 
			' spreadsheetCommandBarButtonItem123
			' 
			Me.spreadsheetCommandBarButtonItem123.CommandName = "FunctionsInsertMin"
			Me.spreadsheetCommandBarButtonItem123.Id = -1
			Me.spreadsheetCommandBarButtonItem123.Name = "spreadsheetCommandBarButtonItem123"
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.spreadsheetCommandBarButtonItem1, Me.spreadsheetCommandBarButtonItem2, Me.spreadsheetCommandBarButtonItem3, Me.spreadsheetCommandBarButtonItem4, Me.spreadsheetCommandBarButtonItem5, Me.spreadsheetCommandBarButtonItem6, Me.spreadsheetCommandBarButtonItem7, Me.spreadsheetCommandBarButtonItem8, Me.spreadsheetCommandBarButtonItem9, Me.spreadsheetCommandBarButtonItem10, Me.spreadsheetCommandBarButtonItem11, Me.spreadsheetCommandBarButtonItem12, Me.spreadsheetCommandBarButtonItem13, Me.spreadsheetCommandBarButtonItem14, Me.spreadsheetCommandBarButtonItem15, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.spreadsheetCommandBarButtonItem16, Me.spreadsheetCommandBarButtonItem17, Me.barButtonGroup2, Me.spreadsheetCommandBarCheckItem1, Me.spreadsheetCommandBarCheckItem2, Me.spreadsheetCommandBarCheckItem3, Me.spreadsheetCommandBarCheckItem4, Me.barButtonGroup3, Me.spreadsheetCommandBarSubItem1, Me.spreadsheetCommandBarButtonItem18, Me.spreadsheetCommandBarButtonItem19, Me.spreadsheetCommandBarButtonItem20, Me.spreadsheetCommandBarButtonItem21, Me.spreadsheetCommandBarButtonItem22, Me.spreadsheetCommandBarButtonItem23, Me.spreadsheetCommandBarButtonItem24, Me.spreadsheetCommandBarButtonItem25, Me.spreadsheetCommandBarButtonItem26, Me.spreadsheetCommandBarButtonItem27, Me.spreadsheetCommandBarButtonItem28, Me.spreadsheetCommandBarButtonItem29, Me.spreadsheetCommandBarButtonItem30, Me.changeBorderLineColorItem1, Me.changeBorderLineStyleItem1, Me.barButtonGroup4, Me.changeCellFillColorItem1, Me.changeFontColorItem1, Me.barButtonGroup5, Me.spreadsheetCommandBarCheckItem5, Me.spreadsheetCommandBarCheckItem6, Me.spreadsheetCommandBarCheckItem7, Me.barButtonGroup6, Me.spreadsheetCommandBarCheckItem8, Me.spreadsheetCommandBarCheckItem9, Me.spreadsheetCommandBarCheckItem10, Me.barButtonGroup7, Me.spreadsheetCommandBarButtonItem31, Me.spreadsheetCommandBarButtonItem32, Me.spreadsheetCommandBarCheckItem11, Me.spreadsheetCommandBarSubItem2, Me.spreadsheetCommandBarCheckItem12, Me.spreadsheetCommandBarButtonItem33, Me.spreadsheetCommandBarButtonItem34, Me.spreadsheetCommandBarButtonItem35, Me.barButtonGroup8, Me.changeNumberFormatItem1, Me.barButtonGroup9, Me.spreadsheetCommandBarSubItem3, Me.spreadsheetCommandBarButtonItem36, Me.spreadsheetCommandBarButtonItem37, Me.spreadsheetCommandBarButtonItem38, Me.spreadsheetCommandBarButtonItem39, Me.spreadsheetCommandBarButtonItem40, Me.spreadsheetCommandBarButtonItem41, Me.spreadsheetCommandBarButtonItem42, Me.barButtonGroup10, Me.spreadsheetCommandBarButtonItem43, Me.spreadsheetCommandBarButtonItem44, Me.spreadsheetCommandBarSubItem4, Me.spreadsheetCommandBarButtonItem45, Me.spreadsheetCommandBarButtonItem46, Me.spreadsheetCommandBarButtonItem47, Me.spreadsheetCommandBarButtonItem48, Me.spreadsheetCommandBarButtonItem49, Me.spreadsheetCommandBarButtonItem50, Me.spreadsheetCommandBarButtonItem51, Me.spreadsheetCommandBarSubItem5, Me.spreadsheetCommandBarButtonItem52, Me.spreadsheetCommandBarButtonItem53, Me.spreadsheetCommandBarButtonItem54, Me.spreadsheetCommandBarButtonItem55, Me.spreadsheetCommandBarButtonItem56, Me.spreadsheetCommandBarButtonItem57, Me.spreadsheetCommandBarSubItem6, Me.spreadsheetCommandBarButtonGalleryDropDownItem1, Me.spreadsheetCommandBarButtonGalleryDropDownItem2, Me.spreadsheetCommandBarButtonGalleryDropDownItem3, Me.spreadsheetCommandBarButtonItem58, Me.spreadsheetCommandBarButtonItem59, Me.spreadsheetCommandBarButtonItem60, Me.spreadsheetCommandBarSubItem7, Me.galleryFormatAsTableItem1, Me.galleryChangeStyleItem1, Me.spreadsheetCommandBarSubItem8, Me.spreadsheetCommandBarButtonItem61, Me.spreadsheetCommandBarButtonItem62, Me.spreadsheetCommandBarButtonItem63, Me.spreadsheetCommandBarSubItem9, Me.spreadsheetCommandBarButtonItem64, Me.spreadsheetCommandBarButtonItem65, Me.spreadsheetCommandBarButtonItem66, Me.spreadsheetCommandBarSubItem10, Me.spreadsheetCommandBarButtonItem67, Me.spreadsheetCommandBarButtonItem68, Me.spreadsheetCommandBarButtonItem69, Me.spreadsheetCommandBarButtonItem70, Me.spreadsheetCommandBarButtonItem71, Me.spreadsheetCommandBarButtonItem72, Me.spreadsheetCommandBarButtonItem73, Me.spreadsheetCommandBarButtonItem74, Me.spreadsheetCommandBarButtonItem75, Me.spreadsheetCommandBarButtonItem76, Me.spreadsheetCommandBarButtonItem77, Me.spreadsheetCommandBarSubItem11, Me.spreadsheetCommandBarButtonItem78, Me.spreadsheetCommandBarButtonItem79, Me.changeSheetTabColorItem1, Me.spreadsheetCommandBarButtonItem80, Me.spreadsheetCommandBarCheckItem13, Me.spreadsheetCommandBarButtonItem81, Me.spreadsheetCommandBarSubItem12, Me.spreadsheetCommandBarButtonItem82, Me.spreadsheetCommandBarButtonItem83, Me.spreadsheetCommandBarButtonItem84, Me.spreadsheetCommandBarButtonItem85, Me.spreadsheetCommandBarButtonItem86, Me.spreadsheetCommandBarSubItem13, Me.spreadsheetCommandBarButtonItem87, Me.spreadsheetCommandBarButtonItem88, Me.spreadsheetCommandBarButtonItem89, Me.spreadsheetCommandBarButtonItem90, Me.spreadsheetCommandBarSubItem14, Me.spreadsheetCommandBarButtonItem91, Me.spreadsheetCommandBarButtonItem92, Me.spreadsheetCommandBarButtonItem93, Me.spreadsheetCommandBarButtonItem94, Me.spreadsheetCommandBarButtonItem95, Me.spreadsheetCommandBarButtonItem96, Me.spreadsheetCommandBarSubItem15, Me.spreadsheetCommandBarButtonItem97, Me.spreadsheetCommandBarButtonItem98, Me.spreadsheetCommandBarCheckItem14, Me.spreadsheetCommandBarButtonItem99, Me.spreadsheetCommandBarButtonItem100, Me.spreadsheetCommandBarSubItem16, Me.spreadsheetCommandBarButtonItem101, Me.spreadsheetCommandBarButtonItem102, Me.spreadsheetCommandBarButtonItem103, Me.spreadsheetCommandBarButtonItem104, Me.spreadsheetCommandBarButtonItem105, Me.spreadsheetCommandBarButtonItem106, Me.spreadsheetCommandBarButtonItem112, Me.spreadsheetCommandBarButtonItem113, Me.spreadsheetCommandBarButtonItem114, Me.spreadsheetCommandBarButtonItem115, Me.spreadsheetCommandBarButtonGalleryDropDownItem4, Me.spreadsheetCommandBarButtonGalleryDropDownItem5, Me.spreadsheetCommandBarButtonGalleryDropDownItem6, Me.spreadsheetCommandBarButtonGalleryDropDownItem7, Me.spreadsheetCommandBarButtonGalleryDropDownItem8, Me.spreadsheetCommandBarButtonGalleryDropDownItem9, Me.spreadsheetCommandBarButtonGalleryDropDownItem10, Me.spreadsheetCommandBarButtonItem116, Me.spreadsheetCommandBarButtonItem117, Me.spreadsheetCommandBarSubItem17, Me.spreadsheetCommandBarCheckItem15, Me.spreadsheetCommandBarCheckItem16, Me.spreadsheetCommandBarCheckItem17, Me.spreadsheetCommandBarButtonItem118, Me.spreadsheetCommandBarSubItem18, Me.spreadsheetCommandBarCheckItem18, Me.spreadsheetCommandBarCheckItem19, Me.pageSetupPaperKindItem1, Me.spreadsheetCommandBarSubItem19, Me.spreadsheetCommandBarButtonItem124, Me.spreadsheetCommandBarButtonItem125, Me.spreadsheetCommandBarButtonItem126, Me.spreadsheetCommandBarButtonItem127, Me.spreadsheetCommandBarCheckItem20, Me.spreadsheetCommandBarCheckItem21, Me.spreadsheetCommandBarCheckItem22, Me.spreadsheetCommandBarCheckItem23, Me.spreadsheetCommandBarSubItem20, Me.spreadsheetCommandBarButtonItem128, Me.spreadsheetCommandBarButtonItem129, Me.spreadsheetCommandBarSubItem21, Me.spreadsheetCommandBarButtonItem130, Me.spreadsheetCommandBarButtonItem131, Me.spreadsheetCommandBarSubItem22, Me.functionsFinancialItem1, Me.functionsLogicalItem1, Me.functionsTextItem1, Me.functionsDateAndTimeItem1, Me.functionsLookupAndReferenceItem1, Me.functionsMathAndTrigonometryItem1, Me.spreadsheetCommandBarSubItem23, Me.functionsStatisticalItem1, Me.functionsEngineeringItem1, Me.functionsInformationItem1, Me.functionsCompatibilityItem1, Me.functionsWebItem1, Me.spreadsheetCommandBarButtonItem137, Me.spreadsheetCommandBarButtonItem138, Me.definedNameListItem1, Me.spreadsheetCommandBarButtonItem139, Me.spreadsheetCommandBarCheckItem24, Me.spreadsheetCommandBarSubItem24, Me.spreadsheetCommandBarCheckItem25, Me.spreadsheetCommandBarCheckItem26, Me.spreadsheetCommandBarButtonItem140, Me.spreadsheetCommandBarButtonItem141, Me.spreadsheetCommandBarSubItem25, Me.spreadsheetCommandBarButtonItem142, Me.spreadsheetCommandBarButtonItem143, Me.spreadsheetCommandBarButtonItem144, Me.spreadsheetCommandBarSubItem26, Me.spreadsheetCommandBarButtonItem145, Me.spreadsheetCommandBarButtonItem146, Me.spreadsheetCommandBarSubItem27, Me.spreadsheetCommandBarButtonItem147, Me.spreadsheetCommandBarButtonItem148, Me.spreadsheetCommandBarButtonItem149, Me.spreadsheetCommandBarButtonItem150, Me.spreadsheetCommandBarButtonItem151, Me.spreadsheetCommandBarButtonItem152, Me.spreadsheetCommandBarButtonItem153, Me.spreadsheetCommandBarButtonItem154, Me.spreadsheetCommandBarButtonItem155, Me.spreadsheetCommandBarButtonItem156, Me.spreadsheetCommandBarButtonItem157, Me.spreadsheetCommandBarButtonItem158, Me.spreadsheetCommandBarButtonItem159, Me.spreadsheetCommandBarButtonItem160, Me.spreadsheetCommandBarButtonItem161, Me.spreadsheetCommandBarButtonItem162, Me.spreadsheetCommandBarButtonItem163, Me.spreadsheetCommandBarSubItem28, Me.spreadsheetCommandBarButtonItem164, Me.spreadsheetCommandBarButtonItem165, Me.spreadsheetCommandBarButtonItem166, Me.spreadsheetCommandBarButtonItem167, Me.spreadsheetCommandBarButtonItem168, Me.spreadsheetCommandBarButtonItem169, Me.spreadsheetCommandBarButtonItem170, Me.galleryChartLayoutItem1, Me.galleryChartStyleItem1, Me.spreadsheetCommandBarSubItem29, Me.spreadsheetCommandBarButtonGalleryDropDownItem11, Me.spreadsheetCommandBarButtonGalleryDropDownItem12, Me.spreadsheetCommandBarSubItem30, Me.spreadsheetCommandBarButtonGalleryDropDownItem13, Me.spreadsheetCommandBarButtonGalleryDropDownItem14, Me.spreadsheetCommandBarButtonGalleryDropDownItem15, Me.spreadsheetCommandBarSubItem31, Me.spreadsheetCommandBarButtonGalleryDropDownItem16, Me.spreadsheetCommandBarButtonGalleryDropDownItem17, Me.spreadsheetCommandBarButtonGalleryDropDownItem18, Me.spreadsheetCommandBarButtonGalleryDropDownItem19, Me.spreadsheetCommandBarButtonGalleryDropDownItem20, Me.spreadsheetCommandBarButtonGalleryDropDownItem21, Me.spreadsheetCommandBarButtonGalleryDropDownItem22, Me.renameTableItemCaption1, Me.renameTableItem1, Me.spreadsheetCommandBarCheckItem27, Me.spreadsheetCommandBarCheckItem28, Me.spreadsheetCommandBarCheckItem29, Me.spreadsheetCommandBarCheckItem30, Me.spreadsheetCommandBarCheckItem31, Me.spreadsheetCommandBarCheckItem32, Me.spreadsheetCommandBarCheckItem33, Me.galleryTableStylesItem1, Me.spreadsheetCommandBarButtonItem171, Me.spreadsheetCommandBarButtonItem172, Me.spreadsheetCommandBarButtonItem173, Me.spreadsheetCommandBarButtonItem174, Me.spreadsheetCommandBarButtonItem175, Me.spreadsheetCommandBarButtonItem176, Me.spreadsheetCommandBarButtonItem177, Me.spreadsheetCommandBarSubItem32, Me.spreadsheetCommandBarButtonItem178, Me.spreadsheetCommandBarButtonItem179, Me.spreadsheetCommandBarButtonItem180, Me.spreadsheetCommandBarSubItem33, Me.spreadsheetCommandBarButtonItem181, Me.spreadsheetCommandBarButtonItem182, Me.spreadsheetCommandBarSubItem34, Me.spreadsheetCommandBarButtonItem183, Me.spreadsheetCommandBarButtonItem184, Me.spreadsheetCommandBarButtonItem185, Me.spreadsheetCommandBarButtonItem186, Me.spreadsheetCommandBarSubItem35, Me.spreadsheetCommandBarButtonItem187, Me.spreadsheetCommandBarButtonItem188, Me.spreadsheetCommandBarButtonItem189, Me.spreadsheetCommandBarButtonItem190, Me.spreadsheetCommandBarCheckItem34, Me.spreadsheetCommandBarCheckItem35, Me.spreadsheetCommandBarCheckItem36, Me.spreadsheetCommandBarSubItem36, Me.spreadsheetCommandBarButtonItem191, Me.spreadsheetCommandBarButtonItem192, Me.spreadsheetCommandBarButtonItem193, Me.spreadsheetCommandBarSubItem37, Me.spreadsheetCommandBarButtonItem194, Me.spreadsheetCommandBarButtonItem195, Me.spreadsheetCommandBarButtonItem196, Me.spreadsheetCommandBarButtonItem197, Me.spreadsheetCommandBarSubItem38, Me.spreadsheetCommandBarButtonItem198, Me.spreadsheetCommandBarButtonItem199, Me.spreadsheetCommandBarButtonItem200, Me.spreadsheetCommandBarButtonItem201, Me.spreadsheetCommandBarButtonItem202, Me.spreadsheetCommandBarSubItem39, Me.spreadsheetCommandBarButtonItem203, Me.spreadsheetCommandBarButtonItem204, Me.spreadsheetCommandBarCheckItem37, Me.spreadsheetCommandBarCheckItem38, Me.spreadsheetCommandBarCheckItem39, Me.spreadsheetCommandBarCheckItem40, Me.galleryPivotStylesItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 330
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.chartToolsRibbonPageCategory1, Me.tableToolsRibbonPageCategory1, Me.drawingToolsRibbonPageCategory1, Me.pictureToolsRibbonPageCategory1, Me.pivotTableToolsRibbonPageCategory1})
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.homeRibbonPage1, Me.insertRibbonPage1, Me.pageLayoutRibbonPage1, Me.formulasRibbonPage1, Me.dataRibbonPage1, Me.reviewRibbonPage1, Me.viewRibbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemSpreadsheetFontSizeEdit1, Me.repositoryItemPopupGalleryEdit1, Me.repositoryItemTextEdit1})
			Me.ribbonControl1.Size = New System.Drawing.Size(696, 116)
			Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
			' 
			' commonRibbonPageGroup1
			' 
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem2)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem3)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem4)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem5)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem6)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem7)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem8)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem9)
			Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
			' 
			' fileRibbonPage1
			' 
			Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.infoRibbonPageGroup1})
			Me.fileRibbonPage1.Name = "fileRibbonPage1"
			' 
			' spreadsheetCommandBarButtonItem1
			' 
			Me.spreadsheetCommandBarButtonItem1.CommandName = "FileNew"
			Me.spreadsheetCommandBarButtonItem1.Id = 1
			Me.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1"
			' 
			' spreadsheetCommandBarButtonItem2
			' 
			Me.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen"
			Me.spreadsheetCommandBarButtonItem2.Id = 2
			Me.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2"
			' 
			' spreadsheetCommandBarButtonItem3
			' 
			Me.spreadsheetCommandBarButtonItem3.CommandName = "FileSave"
			Me.spreadsheetCommandBarButtonItem3.Id = 3
			Me.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3"
			' 
			' spreadsheetCommandBarButtonItem4
			' 
			Me.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs"
			Me.spreadsheetCommandBarButtonItem4.Id = 4
			Me.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4"
			' 
			' spreadsheetCommandBarButtonItem5
			' 
			Me.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint"
			Me.spreadsheetCommandBarButtonItem5.Id = 5
			Me.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5"
			' 
			' spreadsheetCommandBarButtonItem6
			' 
			Me.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint"
			Me.spreadsheetCommandBarButtonItem6.Id = 6
			Me.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6"
			' 
			' spreadsheetCommandBarButtonItem7
			' 
			Me.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview"
			Me.spreadsheetCommandBarButtonItem7.Id = 7
			Me.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7"
			' 
			' spreadsheetCommandBarButtonItem8
			' 
			Me.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo"
			Me.spreadsheetCommandBarButtonItem8.Id = 8
			Me.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8"
			' 
			' spreadsheetCommandBarButtonItem9
			' 
			Me.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo"
			Me.spreadsheetCommandBarButtonItem9.Id = 9
			Me.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9"
			' 
			' infoRibbonPageGroup1
			' 
			Me.infoRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem10)
			Me.infoRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem11)
			Me.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonItem10
			' 
			Me.spreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt"
			Me.spreadsheetCommandBarButtonItem10.Id = 10
			Me.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10"
			' 
			' spreadsheetCommandBarButtonItem11
			' 
			Me.spreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties"
			Me.spreadsheetCommandBarButtonItem11.Id = 11
			Me.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11"
			' 
			' clipboardRibbonPageGroup1
			' 
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem12)
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem13)
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem14)
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem15)
			Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
			' 
			' homeRibbonPage1
			' 
			Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.clipboardRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.alignmentRibbonPageGroup1, Me.numberRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.cellsRibbonPageGroup1, Me.editingRibbonPageGroup1})
			Me.homeRibbonPage1.Name = "homeRibbonPage1"
			reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
			reduceOperation1.Group = Me.stylesRibbonPageGroup1
			reduceOperation1.ItemLinkIndex = 2
			reduceOperation1.ItemLinksCount = 0
			reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
			Me.homeRibbonPage1.ReduceOperations.Add(reduceOperation1)
			' 
			' spreadsheetCommandBarButtonItem12
			' 
			Me.spreadsheetCommandBarButtonItem12.CommandName = "PasteSelection"
			Me.spreadsheetCommandBarButtonItem12.Id = 22
			Me.spreadsheetCommandBarButtonItem12.Name = "spreadsheetCommandBarButtonItem12"
			Me.spreadsheetCommandBarButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem13
			' 
			Me.spreadsheetCommandBarButtonItem13.CommandName = "CutSelection"
			Me.spreadsheetCommandBarButtonItem13.Id = 23
			Me.spreadsheetCommandBarButtonItem13.Name = "spreadsheetCommandBarButtonItem13"
			Me.spreadsheetCommandBarButtonItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem14
			' 
			Me.spreadsheetCommandBarButtonItem14.CommandName = "CopySelection"
			Me.spreadsheetCommandBarButtonItem14.Id = 24
			Me.spreadsheetCommandBarButtonItem14.Name = "spreadsheetCommandBarButtonItem14"
			Me.spreadsheetCommandBarButtonItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem15
			' 
			Me.spreadsheetCommandBarButtonItem15.CommandName = "ShowPasteSpecialForm"
			Me.spreadsheetCommandBarButtonItem15.Id = 25
			Me.spreadsheetCommandBarButtonItem15.Name = "spreadsheetCommandBarButtonItem15"
			Me.spreadsheetCommandBarButtonItem15.RibbonStyle = (CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
			' 
			' fontRibbonPageGroup1
			' 
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup4)
			Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
			' 
			' changeFontNameItem1
			' 
			Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
			Me.changeFontNameItem1.Id = 26
			Me.changeFontNameItem1.Name = "changeFontNameItem1"
			' 
			' changeFontSizeItem1
			' 
			Me.changeFontSizeItem1.Edit = Me.repositoryItemSpreadsheetFontSizeEdit1
			Me.changeFontSizeItem1.Id = 27
			Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
			' 
			' spreadsheetCommandBarButtonItem16
			' 
			Me.spreadsheetCommandBarButtonItem16.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
			Me.spreadsheetCommandBarButtonItem16.CommandName = "FormatIncreaseFontSize"
			Me.spreadsheetCommandBarButtonItem16.Id = 28
			Me.spreadsheetCommandBarButtonItem16.Name = "spreadsheetCommandBarButtonItem16"
			Me.spreadsheetCommandBarButtonItem16.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem17
			' 
			Me.spreadsheetCommandBarButtonItem17.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
			Me.spreadsheetCommandBarButtonItem17.CommandName = "FormatDecreaseFontSize"
			Me.spreadsheetCommandBarButtonItem17.Id = 29
			Me.spreadsheetCommandBarButtonItem17.Name = "spreadsheetCommandBarButtonItem17"
			Me.spreadsheetCommandBarButtonItem17.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem1
			' 
			Me.spreadsheetCommandBarCheckItem1.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
			Me.spreadsheetCommandBarCheckItem1.CommandName = "FormatFontBold"
			Me.spreadsheetCommandBarCheckItem1.Id = 30
			Me.spreadsheetCommandBarCheckItem1.Name = "spreadsheetCommandBarCheckItem1"
			Me.spreadsheetCommandBarCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem2
			' 
			Me.spreadsheetCommandBarCheckItem2.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
			Me.spreadsheetCommandBarCheckItem2.CommandName = "FormatFontItalic"
			Me.spreadsheetCommandBarCheckItem2.Id = 31
			Me.spreadsheetCommandBarCheckItem2.Name = "spreadsheetCommandBarCheckItem2"
			Me.spreadsheetCommandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem3
			' 
			Me.spreadsheetCommandBarCheckItem3.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
			Me.spreadsheetCommandBarCheckItem3.CommandName = "FormatFontUnderline"
			Me.spreadsheetCommandBarCheckItem3.Id = 32
			Me.spreadsheetCommandBarCheckItem3.Name = "spreadsheetCommandBarCheckItem3"
			Me.spreadsheetCommandBarCheckItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem4
			' 
			Me.spreadsheetCommandBarCheckItem4.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
			Me.spreadsheetCommandBarCheckItem4.CommandName = "FormatFontStrikeout"
			Me.spreadsheetCommandBarCheckItem4.Id = 33
			Me.spreadsheetCommandBarCheckItem4.Name = "spreadsheetCommandBarCheckItem4"
			Me.spreadsheetCommandBarCheckItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarSubItem1
			' 
			Me.spreadsheetCommandBarSubItem1.ButtonGroupTag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}"
			Me.spreadsheetCommandBarSubItem1.CommandName = "FormatBordersCommandGroup"
			Me.spreadsheetCommandBarSubItem1.Id = 34
			Me.spreadsheetCommandBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem26), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem27), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem28), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem29), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem30), New DevExpress.XtraBars.LinkPersistInfo(Me.changeBorderLineColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeBorderLineStyleItem1)})
			Me.spreadsheetCommandBarSubItem1.Name = "spreadsheetCommandBarSubItem1"
			Me.spreadsheetCommandBarSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem18
			' 
			Me.spreadsheetCommandBarButtonItem18.CommandName = "FormatBottomBorder"
			Me.spreadsheetCommandBarButtonItem18.Id = 35
			Me.spreadsheetCommandBarButtonItem18.Name = "spreadsheetCommandBarButtonItem18"
			' 
			' spreadsheetCommandBarButtonItem19
			' 
			Me.spreadsheetCommandBarButtonItem19.CommandName = "FormatTopBorder"
			Me.spreadsheetCommandBarButtonItem19.Id = 36
			Me.spreadsheetCommandBarButtonItem19.Name = "spreadsheetCommandBarButtonItem19"
			' 
			' spreadsheetCommandBarButtonItem20
			' 
			Me.spreadsheetCommandBarButtonItem20.CommandName = "FormatLeftBorder"
			Me.spreadsheetCommandBarButtonItem20.Id = 37
			Me.spreadsheetCommandBarButtonItem20.Name = "spreadsheetCommandBarButtonItem20"
			' 
			' spreadsheetCommandBarButtonItem21
			' 
			Me.spreadsheetCommandBarButtonItem21.CommandName = "FormatRightBorder"
			Me.spreadsheetCommandBarButtonItem21.Id = 38
			Me.spreadsheetCommandBarButtonItem21.Name = "spreadsheetCommandBarButtonItem21"
			' 
			' spreadsheetCommandBarButtonItem22
			' 
			Me.spreadsheetCommandBarButtonItem22.CommandName = "FormatNoBorders"
			Me.spreadsheetCommandBarButtonItem22.Id = 39
			Me.spreadsheetCommandBarButtonItem22.Name = "spreadsheetCommandBarButtonItem22"
			' 
			' spreadsheetCommandBarButtonItem23
			' 
			Me.spreadsheetCommandBarButtonItem23.CommandName = "FormatAllBorders"
			Me.spreadsheetCommandBarButtonItem23.Id = 40
			Me.spreadsheetCommandBarButtonItem23.Name = "spreadsheetCommandBarButtonItem23"
			' 
			' spreadsheetCommandBarButtonItem24
			' 
			Me.spreadsheetCommandBarButtonItem24.CommandName = "FormatOutsideBorders"
			Me.spreadsheetCommandBarButtonItem24.Id = 41
			Me.spreadsheetCommandBarButtonItem24.Name = "spreadsheetCommandBarButtonItem24"
			' 
			' spreadsheetCommandBarButtonItem25
			' 
			Me.spreadsheetCommandBarButtonItem25.CommandName = "FormatThickBorder"
			Me.spreadsheetCommandBarButtonItem25.Id = 42
			Me.spreadsheetCommandBarButtonItem25.Name = "spreadsheetCommandBarButtonItem25"
			' 
			' spreadsheetCommandBarButtonItem26
			' 
			Me.spreadsheetCommandBarButtonItem26.CommandName = "FormatBottomDoubleBorder"
			Me.spreadsheetCommandBarButtonItem26.Id = 43
			Me.spreadsheetCommandBarButtonItem26.Name = "spreadsheetCommandBarButtonItem26"
			' 
			' spreadsheetCommandBarButtonItem27
			' 
			Me.spreadsheetCommandBarButtonItem27.CommandName = "FormatBottomThickBorder"
			Me.spreadsheetCommandBarButtonItem27.Id = 44
			Me.spreadsheetCommandBarButtonItem27.Name = "spreadsheetCommandBarButtonItem27"
			' 
			' spreadsheetCommandBarButtonItem28
			' 
			Me.spreadsheetCommandBarButtonItem28.CommandName = "FormatTopAndBottomBorder"
			Me.spreadsheetCommandBarButtonItem28.Id = 45
			Me.spreadsheetCommandBarButtonItem28.Name = "spreadsheetCommandBarButtonItem28"
			' 
			' spreadsheetCommandBarButtonItem29
			' 
			Me.spreadsheetCommandBarButtonItem29.CommandName = "FormatTopAndThickBottomBorder"
			Me.spreadsheetCommandBarButtonItem29.Id = 46
			Me.spreadsheetCommandBarButtonItem29.Name = "spreadsheetCommandBarButtonItem29"
			' 
			' spreadsheetCommandBarButtonItem30
			' 
			Me.spreadsheetCommandBarButtonItem30.CommandName = "FormatTopAndDoubleBottomBorder"
			Me.spreadsheetCommandBarButtonItem30.Id = 47
			Me.spreadsheetCommandBarButtonItem30.Name = "spreadsheetCommandBarButtonItem30"
			' 
			' changeBorderLineColorItem1
			' 
			Me.changeBorderLineColorItem1.ActAsDropDown = True
			Me.changeBorderLineColorItem1.Id = 48
			Me.changeBorderLineColorItem1.Name = "changeBorderLineColorItem1"
			' 
			' changeBorderLineStyleItem1
			' 
			Me.changeBorderLineStyleItem1.DropDownControl = Me.commandBarGalleryDropDown49
			Me.changeBorderLineStyleItem1.Id = 49
			Me.changeBorderLineStyleItem1.Name = "changeBorderLineStyleItem1"
			' 
			' commandBarGalleryDropDown49
			' 
			Me.commandBarGalleryDropDown49.Name = "commandBarGalleryDropDown49"
			Me.commandBarGalleryDropDown49.Ribbon = Me.ribbonControl1
			' 
			' changeCellFillColorItem1
			' 
			Me.changeCellFillColorItem1.Id = 50
			Me.changeCellFillColorItem1.Name = "changeCellFillColorItem1"
			' 
			' changeFontColorItem1
			' 
			Me.changeFontColorItem1.Id = 51
			Me.changeFontColorItem1.Name = "changeFontColorItem1"
			' 
			' barButtonGroup1
			' 
			Me.barButtonGroup1.Id = 12
			Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1)
			Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
			Me.barButtonGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem16)
			Me.barButtonGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem17)
			Me.barButtonGroup1.Name = "barButtonGroup1"
			Me.barButtonGroup1.Tag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
			' 
			' repositoryItemFontEdit1
			' 
			Me.repositoryItemFontEdit1.AutoHeight = False
			Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
			' 
			' repositoryItemSpreadsheetFontSizeEdit1
			' 
			Me.repositoryItemSpreadsheetFontSizeEdit1.AutoHeight = False
			Me.repositoryItemSpreadsheetFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemSpreadsheetFontSizeEdit1.Control = Me.spreadsheetControl1
			Me.repositoryItemSpreadsheetFontSizeEdit1.Name = "repositoryItemSpreadsheetFontSizeEdit1"
			' 
			' barButtonGroup2
			' 
			Me.barButtonGroup2.Id = 13
			Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem1)
			Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem2)
			Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem3)
			Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem4)
			Me.barButtonGroup2.Name = "barButtonGroup2"
			Me.barButtonGroup2.Tag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
			' 
			' barButtonGroup3
			' 
			Me.barButtonGroup3.Id = 14
			Me.barButtonGroup3.ItemLinks.Add(Me.spreadsheetCommandBarSubItem1)
			Me.barButtonGroup3.Name = "barButtonGroup3"
			Me.barButtonGroup3.Tag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}"
			' 
			' barButtonGroup4
			' 
			Me.barButtonGroup4.Id = 15
			Me.barButtonGroup4.ItemLinks.Add(Me.changeCellFillColorItem1)
			Me.barButtonGroup4.ItemLinks.Add(Me.changeFontColorItem1)
			Me.barButtonGroup4.Name = "barButtonGroup4"
			Me.barButtonGroup4.Tag = "{C2275623-04A3-41E8-8D6A-EB5C7F8541D1}"
			' 
			' alignmentRibbonPageGroup1
			' 
			Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup5)
			Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup6)
			Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup7)
			Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem11)
			Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem2)
			Me.alignmentRibbonPageGroup1.Name = "alignmentRibbonPageGroup1"
			' 
			' spreadsheetCommandBarCheckItem5
			' 
			Me.spreadsheetCommandBarCheckItem5.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
			Me.spreadsheetCommandBarCheckItem5.CommandName = "FormatAlignmentTop"
			Me.spreadsheetCommandBarCheckItem5.Id = 52
			Me.spreadsheetCommandBarCheckItem5.Name = "spreadsheetCommandBarCheckItem5"
			Me.spreadsheetCommandBarCheckItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem6
			' 
			Me.spreadsheetCommandBarCheckItem6.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
			Me.spreadsheetCommandBarCheckItem6.CommandName = "FormatAlignmentMiddle"
			Me.spreadsheetCommandBarCheckItem6.Id = 53
			Me.spreadsheetCommandBarCheckItem6.Name = "spreadsheetCommandBarCheckItem6"
			Me.spreadsheetCommandBarCheckItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem7
			' 
			Me.spreadsheetCommandBarCheckItem7.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
			Me.spreadsheetCommandBarCheckItem7.CommandName = "FormatAlignmentBottom"
			Me.spreadsheetCommandBarCheckItem7.Id = 54
			Me.spreadsheetCommandBarCheckItem7.Name = "spreadsheetCommandBarCheckItem7"
			Me.spreadsheetCommandBarCheckItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem8
			' 
			Me.spreadsheetCommandBarCheckItem8.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
			Me.spreadsheetCommandBarCheckItem8.CommandName = "FormatAlignmentLeft"
			Me.spreadsheetCommandBarCheckItem8.Id = 55
			Me.spreadsheetCommandBarCheckItem8.Name = "spreadsheetCommandBarCheckItem8"
			Me.spreadsheetCommandBarCheckItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem9
			' 
			Me.spreadsheetCommandBarCheckItem9.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
			Me.spreadsheetCommandBarCheckItem9.CommandName = "FormatAlignmentCenter"
			Me.spreadsheetCommandBarCheckItem9.Id = 56
			Me.spreadsheetCommandBarCheckItem9.Name = "spreadsheetCommandBarCheckItem9"
			Me.spreadsheetCommandBarCheckItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem10
			' 
			Me.spreadsheetCommandBarCheckItem10.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
			Me.spreadsheetCommandBarCheckItem10.CommandName = "FormatAlignmentRight"
			Me.spreadsheetCommandBarCheckItem10.Id = 57
			Me.spreadsheetCommandBarCheckItem10.Name = "spreadsheetCommandBarCheckItem10"
			Me.spreadsheetCommandBarCheckItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem31
			' 
			Me.spreadsheetCommandBarButtonItem31.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
			Me.spreadsheetCommandBarButtonItem31.CommandName = "FormatDecreaseIndent"
			Me.spreadsheetCommandBarButtonItem31.Id = 58
			Me.spreadsheetCommandBarButtonItem31.Name = "spreadsheetCommandBarButtonItem31"
			Me.spreadsheetCommandBarButtonItem31.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem32
			' 
			Me.spreadsheetCommandBarButtonItem32.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
			Me.spreadsheetCommandBarButtonItem32.CommandName = "FormatIncreaseIndent"
			Me.spreadsheetCommandBarButtonItem32.Id = 59
			Me.spreadsheetCommandBarButtonItem32.Name = "spreadsheetCommandBarButtonItem32"
			Me.spreadsheetCommandBarButtonItem32.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem11
			' 
			Me.spreadsheetCommandBarCheckItem11.CommandName = "FormatWrapText"
			Me.spreadsheetCommandBarCheckItem11.Id = 60
			Me.spreadsheetCommandBarCheckItem11.Name = "spreadsheetCommandBarCheckItem11"
			Me.spreadsheetCommandBarCheckItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarSubItem2
			' 
			Me.spreadsheetCommandBarSubItem2.CommandName = "EditingMergeCellsCommandGroup"
			Me.spreadsheetCommandBarSubItem2.Id = 61
			Me.spreadsheetCommandBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem33), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem34), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem35)})
			Me.spreadsheetCommandBarSubItem2.Name = "spreadsheetCommandBarSubItem2"
			Me.spreadsheetCommandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarCheckItem12
			' 
			Me.spreadsheetCommandBarCheckItem12.CommandName = "EditingMergeAndCenterCells"
			Me.spreadsheetCommandBarCheckItem12.Id = 62
			Me.spreadsheetCommandBarCheckItem12.Name = "spreadsheetCommandBarCheckItem12"
			' 
			' spreadsheetCommandBarButtonItem33
			' 
			Me.spreadsheetCommandBarButtonItem33.CommandName = "EditingMergeCellsAcross"
			Me.spreadsheetCommandBarButtonItem33.Id = 63
			Me.spreadsheetCommandBarButtonItem33.Name = "spreadsheetCommandBarButtonItem33"
			' 
			' spreadsheetCommandBarButtonItem34
			' 
			Me.spreadsheetCommandBarButtonItem34.CommandName = "EditingMergeCells"
			Me.spreadsheetCommandBarButtonItem34.Id = 64
			Me.spreadsheetCommandBarButtonItem34.Name = "spreadsheetCommandBarButtonItem34"
			' 
			' spreadsheetCommandBarButtonItem35
			' 
			Me.spreadsheetCommandBarButtonItem35.CommandName = "EditingUnmergeCells"
			Me.spreadsheetCommandBarButtonItem35.Id = 65
			Me.spreadsheetCommandBarButtonItem35.Name = "spreadsheetCommandBarButtonItem35"
			' 
			' barButtonGroup5
			' 
			Me.barButtonGroup5.Id = 16
			Me.barButtonGroup5.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem5)
			Me.barButtonGroup5.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem6)
			Me.barButtonGroup5.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem7)
			Me.barButtonGroup5.Name = "barButtonGroup5"
			Me.barButtonGroup5.Tag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
			' 
			' barButtonGroup6
			' 
			Me.barButtonGroup6.Id = 17
			Me.barButtonGroup6.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem8)
			Me.barButtonGroup6.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem9)
			Me.barButtonGroup6.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem10)
			Me.barButtonGroup6.Name = "barButtonGroup6"
			Me.barButtonGroup6.Tag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
			' 
			' barButtonGroup7
			' 
			Me.barButtonGroup7.Id = 18
			Me.barButtonGroup7.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem31)
			Me.barButtonGroup7.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem32)
			Me.barButtonGroup7.Name = "barButtonGroup7"
			Me.barButtonGroup7.Tag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
			' 
			' numberRibbonPageGroup1
			' 
			Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup8)
			Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup9)
			Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup10)
			Me.numberRibbonPageGroup1.Name = "numberRibbonPageGroup1"
			' 
			' changeNumberFormatItem1
			' 
			Me.changeNumberFormatItem1.Edit = Me.repositoryItemPopupGalleryEdit1
			Me.changeNumberFormatItem1.Id = 66
			Me.changeNumberFormatItem1.Name = "changeNumberFormatItem1"
			' 
			' spreadsheetCommandBarSubItem3
			' 
			Me.spreadsheetCommandBarSubItem3.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
			Me.spreadsheetCommandBarSubItem3.CommandName = "FormatNumberAccountingCommandGroup"
			Me.spreadsheetCommandBarSubItem3.Id = 67
			Me.spreadsheetCommandBarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem36), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem37), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem38), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem39), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem40)})
			Me.spreadsheetCommandBarSubItem3.Name = "spreadsheetCommandBarSubItem3"
			Me.spreadsheetCommandBarSubItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem36
			' 
			Me.spreadsheetCommandBarButtonItem36.CommandName = "FormatNumberAccountingUS"
			Me.spreadsheetCommandBarButtonItem36.Id = 68
			Me.spreadsheetCommandBarButtonItem36.Name = "spreadsheetCommandBarButtonItem36"
			' 
			' spreadsheetCommandBarButtonItem37
			' 
			Me.spreadsheetCommandBarButtonItem37.CommandName = "FormatNumberAccountingUK"
			Me.spreadsheetCommandBarButtonItem37.Id = 69
			Me.spreadsheetCommandBarButtonItem37.Name = "spreadsheetCommandBarButtonItem37"
			' 
			' spreadsheetCommandBarButtonItem38
			' 
			Me.spreadsheetCommandBarButtonItem38.CommandName = "FormatNumberAccountingEuro"
			Me.spreadsheetCommandBarButtonItem38.Id = 70
			Me.spreadsheetCommandBarButtonItem38.Name = "spreadsheetCommandBarButtonItem38"
			' 
			' spreadsheetCommandBarButtonItem39
			' 
			Me.spreadsheetCommandBarButtonItem39.CommandName = "FormatNumberAccountingPRC"
			Me.spreadsheetCommandBarButtonItem39.Id = 71
			Me.spreadsheetCommandBarButtonItem39.Name = "spreadsheetCommandBarButtonItem39"
			' 
			' spreadsheetCommandBarButtonItem40
			' 
			Me.spreadsheetCommandBarButtonItem40.CommandName = "FormatNumberAccountingSwiss"
			Me.spreadsheetCommandBarButtonItem40.Id = 72
			Me.spreadsheetCommandBarButtonItem40.Name = "spreadsheetCommandBarButtonItem40"
			' 
			' spreadsheetCommandBarButtonItem41
			' 
			Me.spreadsheetCommandBarButtonItem41.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
			Me.spreadsheetCommandBarButtonItem41.CommandName = "FormatNumberPercent"
			Me.spreadsheetCommandBarButtonItem41.Id = 73
			Me.spreadsheetCommandBarButtonItem41.Name = "spreadsheetCommandBarButtonItem41"
			Me.spreadsheetCommandBarButtonItem41.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem42
			' 
			Me.spreadsheetCommandBarButtonItem42.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
			Me.spreadsheetCommandBarButtonItem42.CommandName = "FormatNumberAccounting"
			Me.spreadsheetCommandBarButtonItem42.Id = 74
			Me.spreadsheetCommandBarButtonItem42.Name = "spreadsheetCommandBarButtonItem42"
			Me.spreadsheetCommandBarButtonItem42.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem43
			' 
			Me.spreadsheetCommandBarButtonItem43.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
			Me.spreadsheetCommandBarButtonItem43.CommandName = "FormatNumberIncreaseDecimal"
			Me.spreadsheetCommandBarButtonItem43.Id = 75
			Me.spreadsheetCommandBarButtonItem43.Name = "spreadsheetCommandBarButtonItem43"
			Me.spreadsheetCommandBarButtonItem43.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem44
			' 
			Me.spreadsheetCommandBarButtonItem44.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
			Me.spreadsheetCommandBarButtonItem44.CommandName = "FormatNumberDecreaseDecimal"
			Me.spreadsheetCommandBarButtonItem44.Id = 76
			Me.spreadsheetCommandBarButtonItem44.Name = "spreadsheetCommandBarButtonItem44"
			Me.spreadsheetCommandBarButtonItem44.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' barButtonGroup8
			' 
			Me.barButtonGroup8.Id = 19
			Me.barButtonGroup8.ItemLinks.Add(Me.changeNumberFormatItem1)
			Me.barButtonGroup8.Name = "barButtonGroup8"
			Me.barButtonGroup8.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
			' 
			' repositoryItemPopupGalleryEdit1
			' 
			Me.repositoryItemPopupGalleryEdit1.AutoHeight = False
			Me.repositoryItemPopupGalleryEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			' 
			' 
			' 
			Me.repositoryItemPopupGalleryEdit1.Gallery.AllowFilter = False
			Me.repositoryItemPopupGalleryEdit1.Gallery.AutoFitColumns = False
			Me.repositoryItemPopupGalleryEdit1.Gallery.ColumnCount = 1
			Me.repositoryItemPopupGalleryEdit1.Gallery.FixedImageSize = False
			spreadsheetCommandGalleryItem13.AlwaysUpdateDescription = True
			spreadsheetCommandGalleryItem13.CaptionAsValue = True
			spreadsheetCommandGalleryItem13.CommandName = "FormatNumberGeneral"
			spreadsheetCommandGalleryItem13.IsEmptyHint = True
			spreadsheetCommandGalleryItem14.AlwaysUpdateDescription = True
			spreadsheetCommandGalleryItem14.CaptionAsValue = True
			spreadsheetCommandGalleryItem14.CommandName = "FormatNumberDecimal"
			spreadsheetCommandGalleryItem14.IsEmptyHint = True
			spreadsheetCommandGalleryItem15.AlwaysUpdateDescription = True
			spreadsheetCommandGalleryItem15.CaptionAsValue = True
			spreadsheetCommandGalleryItem15.CommandName = "FormatNumberAccountingCurrency"
			spreadsheetCommandGalleryItem15.IsEmptyHint = True
			spreadsheetCommandGalleryItem16.AlwaysUpdateDescription = True
			spreadsheetCommandGalleryItem16.CaptionAsValue = True
			spreadsheetCommandGalleryItem16.CommandName = "FormatNumberAccountingRegular"
			spreadsheetCommandGalleryItem16.IsEmptyHint = True
			spreadsheetCommandGalleryItem17.AlwaysUpdateDescription = True
			spreadsheetCommandGalleryItem17.CaptionAsValue = True
			spreadsheetCommandGalleryItem17.CommandName = "FormatNumberShortDate"
			spreadsheetCommandGalleryItem17.IsEmptyHint = True
			spreadsheetCommandGalleryItem18.AlwaysUpdateDescription = True
			spreadsheetCommandGalleryItem18.CaptionAsValue = True
			spreadsheetCommandGalleryItem18.CommandName = "FormatNumberLongDate"
			spreadsheetCommandGalleryItem18.IsEmptyHint = True
			spreadsheetCommandGalleryItem19.AlwaysUpdateDescription = True
			spreadsheetCommandGalleryItem19.CaptionAsValue = True
			spreadsheetCommandGalleryItem19.CommandName = "FormatNumberTime"
			spreadsheetCommandGalleryItem19.IsEmptyHint = True
			spreadsheetCommandGalleryItem20.AlwaysUpdateDescription = True
			spreadsheetCommandGalleryItem20.CaptionAsValue = True
			spreadsheetCommandGalleryItem20.CommandName = "FormatNumberPercentage"
			spreadsheetCommandGalleryItem20.IsEmptyHint = True
			spreadsheetCommandGalleryItem21.AlwaysUpdateDescription = True
			spreadsheetCommandGalleryItem21.CaptionAsValue = True
			spreadsheetCommandGalleryItem21.CommandName = "FormatNumberFraction"
			spreadsheetCommandGalleryItem21.IsEmptyHint = True
			spreadsheetCommandGalleryItem22.AlwaysUpdateDescription = True
			spreadsheetCommandGalleryItem22.CaptionAsValue = True
			spreadsheetCommandGalleryItem22.CommandName = "FormatNumberScientific"
			spreadsheetCommandGalleryItem22.IsEmptyHint = True
			spreadsheetCommandGalleryItem23.AlwaysUpdateDescription = True
			spreadsheetCommandGalleryItem23.CaptionAsValue = True
			spreadsheetCommandGalleryItem23.CommandName = "FormatNumberText"
			spreadsheetCommandGalleryItem23.IsEmptyHint = True
			galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem13, spreadsheetCommandGalleryItem14, spreadsheetCommandGalleryItem15, spreadsheetCommandGalleryItem16, spreadsheetCommandGalleryItem17, spreadsheetCommandGalleryItem18, spreadsheetCommandGalleryItem19, spreadsheetCommandGalleryItem20, spreadsheetCommandGalleryItem21, spreadsheetCommandGalleryItem22, spreadsheetCommandGalleryItem23})
			Me.repositoryItemPopupGalleryEdit1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.repositoryItemPopupGalleryEdit1.Gallery.RowCount = 11
			Me.repositoryItemPopupGalleryEdit1.Gallery.ShowGroupCaption = False
			Me.repositoryItemPopupGalleryEdit1.Gallery.ShowItemText = True
			Me.repositoryItemPopupGalleryEdit1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
			Me.repositoryItemPopupGalleryEdit1.Gallery.StretchItems = True
			Me.repositoryItemPopupGalleryEdit1.Name = "repositoryItemPopupGalleryEdit1"
			Me.repositoryItemPopupGalleryEdit1.ShowButtons = False
			Me.repositoryItemPopupGalleryEdit1.ShowPopupCloseButton = False
			Me.repositoryItemPopupGalleryEdit1.ShowSizeGrip = False
			' 
			' barButtonGroup9
			' 
			Me.barButtonGroup9.Id = 20
			Me.barButtonGroup9.ItemLinks.Add(Me.spreadsheetCommandBarSubItem3)
			Me.barButtonGroup9.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem41)
			Me.barButtonGroup9.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem42)
			Me.barButtonGroup9.Name = "barButtonGroup9"
			Me.barButtonGroup9.Tag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
			' 
			' barButtonGroup10
			' 
			Me.barButtonGroup10.Id = 21
			Me.barButtonGroup10.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem43)
			Me.barButtonGroup10.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem44)
			Me.barButtonGroup10.Name = "barButtonGroup10"
			Me.barButtonGroup10.Tag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
			' 
			' stylesRibbonPageGroup1
			' 
			Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem4)
			Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryFormatAsTableItem1)
			Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeStyleItem1)
			Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
			' 
			' spreadsheetCommandBarSubItem4
			' 
			Me.spreadsheetCommandBarSubItem4.CommandName = "ConditionalFormattingCommandGroup"
			Me.spreadsheetCommandBarSubItem4.Id = 77
			Me.spreadsheetCommandBarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem58), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem7)})
			Me.spreadsheetCommandBarSubItem4.Name = "spreadsheetCommandBarSubItem4"
			' 
			' spreadsheetCommandBarSubItem5
			' 
			Me.spreadsheetCommandBarSubItem5.CommandName = "ConditionalFormattingHighlightCellsRuleCommandGroup"
			Me.spreadsheetCommandBarSubItem5.Id = 85
			Me.spreadsheetCommandBarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem45), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem46), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem47), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem48), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem49), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem50), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem51)})
			Me.spreadsheetCommandBarSubItem5.Name = "spreadsheetCommandBarSubItem5"
			' 
			' spreadsheetCommandBarButtonItem45
			' 
			Me.spreadsheetCommandBarButtonItem45.CommandName = "ConditionalFormattingGreaterThanRuleCommand"
			Me.spreadsheetCommandBarButtonItem45.Id = 78
			Me.spreadsheetCommandBarButtonItem45.Name = "spreadsheetCommandBarButtonItem45"
			Me.spreadsheetCommandBarButtonItem45.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem46
			' 
			Me.spreadsheetCommandBarButtonItem46.CommandName = "ConditionalFormattingLessThanRuleCommand"
			Me.spreadsheetCommandBarButtonItem46.Id = 79
			Me.spreadsheetCommandBarButtonItem46.Name = "spreadsheetCommandBarButtonItem46"
			Me.spreadsheetCommandBarButtonItem46.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem47
			' 
			Me.spreadsheetCommandBarButtonItem47.CommandName = "ConditionalFormattingBetweenRuleCommand"
			Me.spreadsheetCommandBarButtonItem47.Id = 80
			Me.spreadsheetCommandBarButtonItem47.Name = "spreadsheetCommandBarButtonItem47"
			Me.spreadsheetCommandBarButtonItem47.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem48
			' 
			Me.spreadsheetCommandBarButtonItem48.CommandName = "ConditionalFormattingEqualToRuleCommand"
			Me.spreadsheetCommandBarButtonItem48.Id = 81
			Me.spreadsheetCommandBarButtonItem48.Name = "spreadsheetCommandBarButtonItem48"
			Me.spreadsheetCommandBarButtonItem48.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem49
			' 
			Me.spreadsheetCommandBarButtonItem49.CommandName = "ConditionalFormattingTextContainsRuleCommand"
			Me.spreadsheetCommandBarButtonItem49.Id = 82
			Me.spreadsheetCommandBarButtonItem49.Name = "spreadsheetCommandBarButtonItem49"
			Me.spreadsheetCommandBarButtonItem49.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem50
			' 
			Me.spreadsheetCommandBarButtonItem50.CommandName = "ConditionalFormattingDateOccurringRuleCommand"
			Me.spreadsheetCommandBarButtonItem50.Id = 83
			Me.spreadsheetCommandBarButtonItem50.Name = "spreadsheetCommandBarButtonItem50"
			Me.spreadsheetCommandBarButtonItem50.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem51
			' 
			Me.spreadsheetCommandBarButtonItem51.CommandName = "ConditionalFormattingDuplicateValuesRuleCommand"
			Me.spreadsheetCommandBarButtonItem51.Id = 84
			Me.spreadsheetCommandBarButtonItem51.Name = "spreadsheetCommandBarButtonItem51"
			Me.spreadsheetCommandBarButtonItem51.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarSubItem6
			' 
			Me.spreadsheetCommandBarSubItem6.CommandName = "ConditionalFormattingTopBottomRuleCommandGroup"
			Me.spreadsheetCommandBarSubItem6.Id = 92
			Me.spreadsheetCommandBarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem52), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem53), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem54), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem55), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem56), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem57)})
			Me.spreadsheetCommandBarSubItem6.Name = "spreadsheetCommandBarSubItem6"
			' 
			' spreadsheetCommandBarButtonItem52
			' 
			Me.spreadsheetCommandBarButtonItem52.CommandName = "ConditionalFormattingTop10RuleCommand"
			Me.spreadsheetCommandBarButtonItem52.Id = 86
			Me.spreadsheetCommandBarButtonItem52.Name = "spreadsheetCommandBarButtonItem52"
			Me.spreadsheetCommandBarButtonItem52.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem53
			' 
			Me.spreadsheetCommandBarButtonItem53.CommandName = "ConditionalFormattingTop10PercentRuleCommand"
			Me.spreadsheetCommandBarButtonItem53.Id = 87
			Me.spreadsheetCommandBarButtonItem53.Name = "spreadsheetCommandBarButtonItem53"
			Me.spreadsheetCommandBarButtonItem53.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem54
			' 
			Me.spreadsheetCommandBarButtonItem54.CommandName = "ConditionalFormattingBottom10RuleCommand"
			Me.spreadsheetCommandBarButtonItem54.Id = 88
			Me.spreadsheetCommandBarButtonItem54.Name = "spreadsheetCommandBarButtonItem54"
			Me.spreadsheetCommandBarButtonItem54.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem55
			' 
			Me.spreadsheetCommandBarButtonItem55.CommandName = "ConditionalFormattingBottom10PercentRuleCommand"
			Me.spreadsheetCommandBarButtonItem55.Id = 89
			Me.spreadsheetCommandBarButtonItem55.Name = "spreadsheetCommandBarButtonItem55"
			Me.spreadsheetCommandBarButtonItem55.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem56
			' 
			Me.spreadsheetCommandBarButtonItem56.CommandName = "ConditionalFormattingAboveAverageRuleCommand"
			Me.spreadsheetCommandBarButtonItem56.Id = 90
			Me.spreadsheetCommandBarButtonItem56.Name = "spreadsheetCommandBarButtonItem56"
			Me.spreadsheetCommandBarButtonItem56.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem57
			' 
			Me.spreadsheetCommandBarButtonItem57.CommandName = "ConditionalFormattingBelowAverageRuleCommand"
			Me.spreadsheetCommandBarButtonItem57.Id = 91
			Me.spreadsheetCommandBarButtonItem57.Name = "spreadsheetCommandBarButtonItem57"
			Me.spreadsheetCommandBarButtonItem57.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem1
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem1.CommandName = "ConditionalFormattingDataBarsCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem1.DropDownControl = Me.commandBarGalleryDropDown50
			Me.spreadsheetCommandBarButtonGalleryDropDownItem1.Id = 93
			Me.spreadsheetCommandBarButtonGalleryDropDownItem1.Name = "spreadsheetCommandBarButtonGalleryDropDownItem1"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' commandBarGalleryDropDown50
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown50.Gallery.ColumnCount = 3
			spreadsheetCommandGalleryItemGroup3.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup"
			spreadsheetCommandGalleryItem24.CommandName = "ConditionalFormattingDataBarGradientBlue"
			spreadsheetCommandGalleryItem25.CommandName = "ConditionalFormattingDataBarGradientGreen"
			spreadsheetCommandGalleryItem26.CommandName = "ConditionalFormattingDataBarGradientRed"
			spreadsheetCommandGalleryItem27.CommandName = "ConditionalFormattingDataBarGradientOrange"
			spreadsheetCommandGalleryItem28.CommandName = "ConditionalFormattingDataBarGradientLightBlue"
			spreadsheetCommandGalleryItem29.CommandName = "ConditionalFormattingDataBarGradientPurple"
			spreadsheetCommandGalleryItemGroup3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem24, spreadsheetCommandGalleryItem25, spreadsheetCommandGalleryItem26, spreadsheetCommandGalleryItem27, spreadsheetCommandGalleryItem28, spreadsheetCommandGalleryItem29})
			spreadsheetCommandGalleryItemGroup4.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup"
			spreadsheetCommandGalleryItem30.CommandName = "ConditionalFormattingDataBarSolidBlue"
			spreadsheetCommandGalleryItem31.CommandName = "ConditionalFormattingDataBarSolidGreen"
			spreadsheetCommandGalleryItem32.CommandName = "ConditionalFormattingDataBarSolidRed"
			spreadsheetCommandGalleryItem33.CommandName = "ConditionalFormattingDataBarSolidOrange"
			spreadsheetCommandGalleryItem34.CommandName = "ConditionalFormattingDataBarSolidLightBlue"
			spreadsheetCommandGalleryItem35.CommandName = "ConditionalFormattingDataBarSolidPurple"
			spreadsheetCommandGalleryItemGroup4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem30, spreadsheetCommandGalleryItem31, spreadsheetCommandGalleryItem32, spreadsheetCommandGalleryItem33, spreadsheetCommandGalleryItem34, spreadsheetCommandGalleryItem35})
			Me.commandBarGalleryDropDown50.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup3, spreadsheetCommandGalleryItemGroup4})
			Me.commandBarGalleryDropDown50.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown50.Name = "commandBarGalleryDropDown50"
			Me.commandBarGalleryDropDown50.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem2
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem2.CommandName = "ConditionalFormattingColorScalesCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem2.DropDownControl = Me.commandBarGalleryDropDown51
			Me.spreadsheetCommandBarButtonGalleryDropDownItem2.Id = 94
			Me.spreadsheetCommandBarButtonGalleryDropDownItem2.Name = "spreadsheetCommandBarButtonGalleryDropDownItem2"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' commandBarGalleryDropDown51
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown51.Gallery.ColumnCount = 4
			spreadsheetCommandGalleryItemGroup5.CommandName = "ConditionalFormattingColorScalesCommandGroup"
			spreadsheetCommandGalleryItem36.CommandName = "ConditionalFormattingColorScaleGreenYellowRed"
			spreadsheetCommandGalleryItem37.CommandName = "ConditionalFormattingColorScaleRedYellowGreen"
			spreadsheetCommandGalleryItem38.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed"
			spreadsheetCommandGalleryItem39.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen"
			spreadsheetCommandGalleryItem40.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed"
			spreadsheetCommandGalleryItem41.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue"
			spreadsheetCommandGalleryItem42.CommandName = "ConditionalFormattingColorScaleWhiteRed"
			spreadsheetCommandGalleryItem43.CommandName = "ConditionalFormattingColorScaleRedWhite"
			spreadsheetCommandGalleryItem44.CommandName = "ConditionalFormattingColorScaleGreenWhite"
			spreadsheetCommandGalleryItem45.CommandName = "ConditionalFormattingColorScaleWhiteGreen"
			spreadsheetCommandGalleryItem46.CommandName = "ConditionalFormattingColorScaleGreenYellow"
			spreadsheetCommandGalleryItem47.CommandName = "ConditionalFormattingColorScaleYellowGreen"
			spreadsheetCommandGalleryItemGroup5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem36, spreadsheetCommandGalleryItem37, spreadsheetCommandGalleryItem38, spreadsheetCommandGalleryItem39, spreadsheetCommandGalleryItem40, spreadsheetCommandGalleryItem41, spreadsheetCommandGalleryItem42, spreadsheetCommandGalleryItem43, spreadsheetCommandGalleryItem44, spreadsheetCommandGalleryItem45, spreadsheetCommandGalleryItem46, spreadsheetCommandGalleryItem47})
			Me.commandBarGalleryDropDown51.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup5})
			Me.commandBarGalleryDropDown51.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown51.Name = "commandBarGalleryDropDown51"
			Me.commandBarGalleryDropDown51.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem3
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem3.CommandName = "ConditionalFormattingIconSetsCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem3.DropDownControl = Me.commandBarGalleryDropDown52
			Me.spreadsheetCommandBarButtonGalleryDropDownItem3.Id = 95
			Me.spreadsheetCommandBarButtonGalleryDropDownItem3.Name = "spreadsheetCommandBarButtonGalleryDropDownItem3"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' commandBarGalleryDropDown52
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown52.Gallery.ColumnCount = 4
			spreadsheetCommandGalleryItemGroup6.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup"
			spreadsheetCommandGalleryItem48.CommandName = "ConditionalFormattingIconSetArrows3Colored"
			spreadsheetCommandGalleryItem49.CommandName = "ConditionalFormattingIconSetArrows3Grayed"
			spreadsheetCommandGalleryItem50.CommandName = "ConditionalFormattingIconSetArrows4Colored"
			spreadsheetCommandGalleryItem51.CommandName = "ConditionalFormattingIconSetArrows4Grayed"
			spreadsheetCommandGalleryItem52.CommandName = "ConditionalFormattingIconSetArrows5Colored"
			spreadsheetCommandGalleryItem53.CommandName = "ConditionalFormattingIconSetArrows5Grayed"
			spreadsheetCommandGalleryItem54.CommandName = "ConditionalFormattingIconSetTriangles3"
			spreadsheetCommandGalleryItemGroup6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem48, spreadsheetCommandGalleryItem49, spreadsheetCommandGalleryItem50, spreadsheetCommandGalleryItem51, spreadsheetCommandGalleryItem52, spreadsheetCommandGalleryItem53, spreadsheetCommandGalleryItem54})
			spreadsheetCommandGalleryItemGroup7.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup"
			spreadsheetCommandGalleryItem55.CommandName = "ConditionalFormattingIconSetTrafficLights3"
			spreadsheetCommandGalleryItem56.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed"
			spreadsheetCommandGalleryItem57.CommandName = "ConditionalFormattingIconSetTrafficLights4"
			spreadsheetCommandGalleryItem58.CommandName = "ConditionalFormattingIconSetSigns3"
			spreadsheetCommandGalleryItem59.CommandName = "ConditionalFormattingIconSetRedToBlack"
			spreadsheetCommandGalleryItemGroup7.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem55, spreadsheetCommandGalleryItem56, spreadsheetCommandGalleryItem57, spreadsheetCommandGalleryItem58, spreadsheetCommandGalleryItem59})
			spreadsheetCommandGalleryItemGroup8.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup"
			spreadsheetCommandGalleryItem60.CommandName = "ConditionalFormattingIconSetSymbols3Circled"
			spreadsheetCommandGalleryItem61.CommandName = "ConditionalFormattingIconSetSymbols3"
			spreadsheetCommandGalleryItem62.CommandName = "ConditionalFormattingIconSetFlags3"
			spreadsheetCommandGalleryItemGroup8.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem60, spreadsheetCommandGalleryItem61, spreadsheetCommandGalleryItem62})
			spreadsheetCommandGalleryItemGroup9.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup"
			spreadsheetCommandGalleryItem63.CommandName = "ConditionalFormattingIconSetStars3"
			spreadsheetCommandGalleryItem64.CommandName = "ConditionalFormattingIconSetRatings4"
			spreadsheetCommandGalleryItem65.CommandName = "ConditionalFormattingIconSetRatings5"
			spreadsheetCommandGalleryItem66.CommandName = "ConditionalFormattingIconSetQuarters5"
			spreadsheetCommandGalleryItem67.CommandName = "ConditionalFormattingIconSetBoxes5"
			spreadsheetCommandGalleryItemGroup9.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem63, spreadsheetCommandGalleryItem64, spreadsheetCommandGalleryItem65, spreadsheetCommandGalleryItem66, spreadsheetCommandGalleryItem67})
			Me.commandBarGalleryDropDown52.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup6, spreadsheetCommandGalleryItemGroup7, spreadsheetCommandGalleryItemGroup8, spreadsheetCommandGalleryItemGroup9})
			Me.commandBarGalleryDropDown52.Gallery.RowCount = 7
			Me.commandBarGalleryDropDown52.Name = "commandBarGalleryDropDown52"
			Me.commandBarGalleryDropDown52.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonItem58
			' 
			Me.spreadsheetCommandBarButtonItem58.CommandName = "NewConditionalFormattingRule"
			Me.spreadsheetCommandBarButtonItem58.Id = 96
			Me.spreadsheetCommandBarButtonItem58.Name = "spreadsheetCommandBarButtonItem58"
			' 
			' spreadsheetCommandBarSubItem7
			' 
			Me.spreadsheetCommandBarSubItem7.CommandName = "ConditionalFormattingRemoveCommandGroup"
			Me.spreadsheetCommandBarSubItem7.Id = 99
			Me.spreadsheetCommandBarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem59), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem60)})
			Me.spreadsheetCommandBarSubItem7.Name = "spreadsheetCommandBarSubItem7"
			' 
			' spreadsheetCommandBarButtonItem59
			' 
			Me.spreadsheetCommandBarButtonItem59.CommandName = "ConditionalFormattingRemoveFromSheet"
			Me.spreadsheetCommandBarButtonItem59.Id = 97
			Me.spreadsheetCommandBarButtonItem59.Name = "spreadsheetCommandBarButtonItem59"
			' 
			' spreadsheetCommandBarButtonItem60
			' 
			Me.spreadsheetCommandBarButtonItem60.CommandName = "ConditionalFormattingRemove"
			Me.spreadsheetCommandBarButtonItem60.Id = 98
			Me.spreadsheetCommandBarButtonItem60.Name = "spreadsheetCommandBarButtonItem60"
			' 
			' galleryFormatAsTableItem1
			' 
			Me.galleryFormatAsTableItem1.DropDownControl = Me.commandBarGalleryDropDown53
			Me.galleryFormatAsTableItem1.Id = 100
			Me.galleryFormatAsTableItem1.Name = "galleryFormatAsTableItem1"
			' 
			' commandBarGalleryDropDown53
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown53.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown53.Gallery.ColumnCount = 7
			Me.commandBarGalleryDropDown53.Gallery.DrawImageBackground = False
			Me.commandBarGalleryDropDown53.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
			Me.commandBarGalleryDropDown53.Gallery.ItemSize = New System.Drawing.Size(73, 58)
			Me.commandBarGalleryDropDown53.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown53.Name = "commandBarGalleryDropDown53"
			Me.commandBarGalleryDropDown53.Ribbon = Me.ribbonControl1
			' 
			' galleryChangeStyleItem1
			' 
			' 
			' 
			' 
			Me.galleryChangeStyleItem1.Gallery.DrawImageBackground = False
			Me.galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
			Me.galleryChangeStyleItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
			Me.galleryChangeStyleItem1.Gallery.ItemSize = New System.Drawing.Size(106, 28)
			Me.galleryChangeStyleItem1.Gallery.RowCount = 9
			Me.galleryChangeStyleItem1.Gallery.ShowItemText = True
			Me.galleryChangeStyleItem1.Id = 101
			Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
			' 
			' cellsRibbonPageGroup1
			' 
			Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem8)
			Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem9)
			Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem10)
			Me.cellsRibbonPageGroup1.Name = "cellsRibbonPageGroup1"
			' 
			' spreadsheetCommandBarSubItem8
			' 
			Me.spreadsheetCommandBarSubItem8.CommandName = "InsertCellsCommandGroup"
			Me.spreadsheetCommandBarSubItem8.Id = 102
			Me.spreadsheetCommandBarSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem61), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem62), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem63)})
			Me.spreadsheetCommandBarSubItem8.Name = "spreadsheetCommandBarSubItem8"
			' 
			' spreadsheetCommandBarButtonItem61
			' 
			Me.spreadsheetCommandBarButtonItem61.CommandName = "InsertSheetRows"
			Me.spreadsheetCommandBarButtonItem61.Id = 103
			Me.spreadsheetCommandBarButtonItem61.Name = "spreadsheetCommandBarButtonItem61"
			' 
			' spreadsheetCommandBarButtonItem62
			' 
			Me.spreadsheetCommandBarButtonItem62.CommandName = "InsertSheetColumns"
			Me.spreadsheetCommandBarButtonItem62.Id = 104
			Me.spreadsheetCommandBarButtonItem62.Name = "spreadsheetCommandBarButtonItem62"
			' 
			' spreadsheetCommandBarButtonItem63
			' 
			Me.spreadsheetCommandBarButtonItem63.CommandName = "InsertSheet"
			Me.spreadsheetCommandBarButtonItem63.Id = 105
			Me.spreadsheetCommandBarButtonItem63.Name = "spreadsheetCommandBarButtonItem63"
			' 
			' spreadsheetCommandBarSubItem9
			' 
			Me.spreadsheetCommandBarSubItem9.CommandName = "RemoveCellsCommandGroup"
			Me.spreadsheetCommandBarSubItem9.Id = 106
			Me.spreadsheetCommandBarSubItem9.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem64), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem65), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem66)})
			Me.spreadsheetCommandBarSubItem9.Name = "spreadsheetCommandBarSubItem9"
			' 
			' spreadsheetCommandBarButtonItem64
			' 
			Me.spreadsheetCommandBarButtonItem64.CommandName = "RemoveSheetRows"
			Me.spreadsheetCommandBarButtonItem64.Id = 107
			Me.spreadsheetCommandBarButtonItem64.Name = "spreadsheetCommandBarButtonItem64"
			' 
			' spreadsheetCommandBarButtonItem65
			' 
			Me.spreadsheetCommandBarButtonItem65.CommandName = "RemoveSheetColumns"
			Me.spreadsheetCommandBarButtonItem65.Id = 108
			Me.spreadsheetCommandBarButtonItem65.Name = "spreadsheetCommandBarButtonItem65"
			' 
			' spreadsheetCommandBarButtonItem66
			' 
			Me.spreadsheetCommandBarButtonItem66.CommandName = "RemoveSheet"
			Me.spreadsheetCommandBarButtonItem66.Id = 109
			Me.spreadsheetCommandBarButtonItem66.Name = "spreadsheetCommandBarButtonItem66"
			' 
			' spreadsheetCommandBarSubItem10
			' 
			Me.spreadsheetCommandBarSubItem10.CommandName = "FormatCommandGroup"
			Me.spreadsheetCommandBarSubItem10.Id = 110
			Me.spreadsheetCommandBarSubItem10.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem67), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem68), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem69), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem70), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem71), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem78), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem79), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSheetTabColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem80), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem81)})
			Me.spreadsheetCommandBarSubItem10.Name = "spreadsheetCommandBarSubItem10"
			' 
			' spreadsheetCommandBarButtonItem67
			' 
			Me.spreadsheetCommandBarButtonItem67.CommandName = "FormatRowHeight"
			Me.spreadsheetCommandBarButtonItem67.Id = 111
			Me.spreadsheetCommandBarButtonItem67.Name = "spreadsheetCommandBarButtonItem67"
			' 
			' spreadsheetCommandBarButtonItem68
			' 
			Me.spreadsheetCommandBarButtonItem68.CommandName = "FormatAutoFitRowHeight"
			Me.spreadsheetCommandBarButtonItem68.Id = 112
			Me.spreadsheetCommandBarButtonItem68.Name = "spreadsheetCommandBarButtonItem68"
			' 
			' spreadsheetCommandBarButtonItem69
			' 
			Me.spreadsheetCommandBarButtonItem69.CommandName = "FormatColumnWidth"
			Me.spreadsheetCommandBarButtonItem69.Id = 113
			Me.spreadsheetCommandBarButtonItem69.Name = "spreadsheetCommandBarButtonItem69"
			' 
			' spreadsheetCommandBarButtonItem70
			' 
			Me.spreadsheetCommandBarButtonItem70.CommandName = "FormatAutoFitColumnWidth"
			Me.spreadsheetCommandBarButtonItem70.Id = 114
			Me.spreadsheetCommandBarButtonItem70.Name = "spreadsheetCommandBarButtonItem70"
			' 
			' spreadsheetCommandBarButtonItem71
			' 
			Me.spreadsheetCommandBarButtonItem71.CommandName = "FormatDefaultColumnWidth"
			Me.spreadsheetCommandBarButtonItem71.Id = 115
			Me.spreadsheetCommandBarButtonItem71.Name = "spreadsheetCommandBarButtonItem71"
			' 
			' spreadsheetCommandBarSubItem11
			' 
			Me.spreadsheetCommandBarSubItem11.CommandName = "HideAndUnhideCommandGroup"
			Me.spreadsheetCommandBarSubItem11.Id = 122
			Me.spreadsheetCommandBarSubItem11.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem72), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem73), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem74), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem75), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem76), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem77)})
			Me.spreadsheetCommandBarSubItem11.Name = "spreadsheetCommandBarSubItem11"
			' 
			' spreadsheetCommandBarButtonItem72
			' 
			Me.spreadsheetCommandBarButtonItem72.CommandName = "HideRows"
			Me.spreadsheetCommandBarButtonItem72.Id = 116
			Me.spreadsheetCommandBarButtonItem72.Name = "spreadsheetCommandBarButtonItem72"
			' 
			' spreadsheetCommandBarButtonItem73
			' 
			Me.spreadsheetCommandBarButtonItem73.CommandName = "HideColumns"
			Me.spreadsheetCommandBarButtonItem73.Id = 117
			Me.spreadsheetCommandBarButtonItem73.Name = "spreadsheetCommandBarButtonItem73"
			' 
			' spreadsheetCommandBarButtonItem74
			' 
			Me.spreadsheetCommandBarButtonItem74.CommandName = "HideSheet"
			Me.spreadsheetCommandBarButtonItem74.Id = 118
			Me.spreadsheetCommandBarButtonItem74.Name = "spreadsheetCommandBarButtonItem74"
			' 
			' spreadsheetCommandBarButtonItem75
			' 
			Me.spreadsheetCommandBarButtonItem75.CommandName = "UnhideRows"
			Me.spreadsheetCommandBarButtonItem75.Id = 119
			Me.spreadsheetCommandBarButtonItem75.Name = "spreadsheetCommandBarButtonItem75"
			' 
			' spreadsheetCommandBarButtonItem76
			' 
			Me.spreadsheetCommandBarButtonItem76.CommandName = "UnhideColumns"
			Me.spreadsheetCommandBarButtonItem76.Id = 120
			Me.spreadsheetCommandBarButtonItem76.Name = "spreadsheetCommandBarButtonItem76"
			' 
			' spreadsheetCommandBarButtonItem77
			' 
			Me.spreadsheetCommandBarButtonItem77.CommandName = "UnhideSheet"
			Me.spreadsheetCommandBarButtonItem77.Id = 121
			Me.spreadsheetCommandBarButtonItem77.Name = "spreadsheetCommandBarButtonItem77"
			' 
			' spreadsheetCommandBarButtonItem78
			' 
			Me.spreadsheetCommandBarButtonItem78.CommandName = "RenameSheet"
			Me.spreadsheetCommandBarButtonItem78.Id = 123
			Me.spreadsheetCommandBarButtonItem78.Name = "spreadsheetCommandBarButtonItem78"
			' 
			' spreadsheetCommandBarButtonItem79
			' 
			Me.spreadsheetCommandBarButtonItem79.CommandName = "MoveOrCopySheet"
			Me.spreadsheetCommandBarButtonItem79.Id = 124
			Me.spreadsheetCommandBarButtonItem79.Name = "spreadsheetCommandBarButtonItem79"
			' 
			' changeSheetTabColorItem1
			' 
			Me.changeSheetTabColorItem1.ActAsDropDown = True
			Me.changeSheetTabColorItem1.Id = 125
			Me.changeSheetTabColorItem1.Name = "changeSheetTabColorItem1"
			' 
			' spreadsheetCommandBarButtonItem80
			' 
			Me.spreadsheetCommandBarButtonItem80.CommandName = "ReviewProtectSheet"
			Me.spreadsheetCommandBarButtonItem80.Id = 126
			Me.spreadsheetCommandBarButtonItem80.Name = "spreadsheetCommandBarButtonItem80"
			' 
			' spreadsheetCommandBarCheckItem13
			' 
			Me.spreadsheetCommandBarCheckItem13.CommandName = "FormatCellLocked"
			Me.spreadsheetCommandBarCheckItem13.Id = 127
			Me.spreadsheetCommandBarCheckItem13.Name = "spreadsheetCommandBarCheckItem13"
			' 
			' spreadsheetCommandBarButtonItem81
			' 
			Me.spreadsheetCommandBarButtonItem81.CommandName = "FormatCellsContextMenuItem"
			Me.spreadsheetCommandBarButtonItem81.Id = 128
			Me.spreadsheetCommandBarButtonItem81.Name = "spreadsheetCommandBarButtonItem81"
			' 
			' editingRibbonPageGroup1
			' 
			Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem12)
			Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem13)
			Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem14)
			Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem15)
			Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem16)
			Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
			' 
			' spreadsheetCommandBarSubItem12
			' 
			Me.spreadsheetCommandBarSubItem12.CommandName = "EditingAutoSumCommandGroup"
			Me.spreadsheetCommandBarSubItem12.Id = 129
			Me.spreadsheetCommandBarSubItem12.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem82), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem83), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem84), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem85), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem86)})
			Me.spreadsheetCommandBarSubItem12.Name = "spreadsheetCommandBarSubItem12"
			Me.spreadsheetCommandBarSubItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem82
			' 
			Me.spreadsheetCommandBarButtonItem82.CommandName = "FunctionsInsertSum"
			Me.spreadsheetCommandBarButtonItem82.Id = 130
			Me.spreadsheetCommandBarButtonItem82.Name = "spreadsheetCommandBarButtonItem82"
			' 
			' spreadsheetCommandBarButtonItem83
			' 
			Me.spreadsheetCommandBarButtonItem83.CommandName = "FunctionsInsertAverage"
			Me.spreadsheetCommandBarButtonItem83.Id = 131
			Me.spreadsheetCommandBarButtonItem83.Name = "spreadsheetCommandBarButtonItem83"
			' 
			' spreadsheetCommandBarButtonItem84
			' 
			Me.spreadsheetCommandBarButtonItem84.CommandName = "FunctionsInsertCountNumbers"
			Me.spreadsheetCommandBarButtonItem84.Id = 132
			Me.spreadsheetCommandBarButtonItem84.Name = "spreadsheetCommandBarButtonItem84"
			' 
			' spreadsheetCommandBarButtonItem85
			' 
			Me.spreadsheetCommandBarButtonItem85.CommandName = "FunctionsInsertMax"
			Me.spreadsheetCommandBarButtonItem85.Id = 133
			Me.spreadsheetCommandBarButtonItem85.Name = "spreadsheetCommandBarButtonItem85"
			' 
			' spreadsheetCommandBarButtonItem86
			' 
			Me.spreadsheetCommandBarButtonItem86.CommandName = "FunctionsInsertMin"
			Me.spreadsheetCommandBarButtonItem86.Id = 134
			Me.spreadsheetCommandBarButtonItem86.Name = "spreadsheetCommandBarButtonItem86"
			' 
			' spreadsheetCommandBarSubItem13
			' 
			Me.spreadsheetCommandBarSubItem13.CommandName = "EditingFillCommandGroup"
			Me.spreadsheetCommandBarSubItem13.Id = 135
			Me.spreadsheetCommandBarSubItem13.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem87), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem88), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem89), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem90)})
			Me.spreadsheetCommandBarSubItem13.Name = "spreadsheetCommandBarSubItem13"
			Me.spreadsheetCommandBarSubItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem87
			' 
			Me.spreadsheetCommandBarButtonItem87.CommandName = "EditingFillDown"
			Me.spreadsheetCommandBarButtonItem87.Id = 136
			Me.spreadsheetCommandBarButtonItem87.Name = "spreadsheetCommandBarButtonItem87"
			' 
			' spreadsheetCommandBarButtonItem88
			' 
			Me.spreadsheetCommandBarButtonItem88.CommandName = "EditingFillRight"
			Me.spreadsheetCommandBarButtonItem88.Id = 137
			Me.spreadsheetCommandBarButtonItem88.Name = "spreadsheetCommandBarButtonItem88"
			' 
			' spreadsheetCommandBarButtonItem89
			' 
			Me.spreadsheetCommandBarButtonItem89.CommandName = "EditingFillUp"
			Me.spreadsheetCommandBarButtonItem89.Id = 138
			Me.spreadsheetCommandBarButtonItem89.Name = "spreadsheetCommandBarButtonItem89"
			' 
			' spreadsheetCommandBarButtonItem90
			' 
			Me.spreadsheetCommandBarButtonItem90.CommandName = "EditingFillLeft"
			Me.spreadsheetCommandBarButtonItem90.Id = 139
			Me.spreadsheetCommandBarButtonItem90.Name = "spreadsheetCommandBarButtonItem90"
			' 
			' spreadsheetCommandBarSubItem14
			' 
			Me.spreadsheetCommandBarSubItem14.CommandName = "FormatClearCommandGroup"
			Me.spreadsheetCommandBarSubItem14.Id = 140
			Me.spreadsheetCommandBarSubItem14.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem91), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem92), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem93), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem94), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem95), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem96)})
			Me.spreadsheetCommandBarSubItem14.Name = "spreadsheetCommandBarSubItem14"
			Me.spreadsheetCommandBarSubItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem91
			' 
			Me.spreadsheetCommandBarButtonItem91.CommandName = "FormatClearAll"
			Me.spreadsheetCommandBarButtonItem91.Id = 141
			Me.spreadsheetCommandBarButtonItem91.Name = "spreadsheetCommandBarButtonItem91"
			' 
			' spreadsheetCommandBarButtonItem92
			' 
			Me.spreadsheetCommandBarButtonItem92.CommandName = "FormatClearFormats"
			Me.spreadsheetCommandBarButtonItem92.Id = 142
			Me.spreadsheetCommandBarButtonItem92.Name = "spreadsheetCommandBarButtonItem92"
			' 
			' spreadsheetCommandBarButtonItem93
			' 
			Me.spreadsheetCommandBarButtonItem93.CommandName = "FormatClearContents"
			Me.spreadsheetCommandBarButtonItem93.Id = 143
			Me.spreadsheetCommandBarButtonItem93.Name = "spreadsheetCommandBarButtonItem93"
			' 
			' spreadsheetCommandBarButtonItem94
			' 
			Me.spreadsheetCommandBarButtonItem94.CommandName = "FormatClearComments"
			Me.spreadsheetCommandBarButtonItem94.Id = 144
			Me.spreadsheetCommandBarButtonItem94.Name = "spreadsheetCommandBarButtonItem94"
			' 
			' spreadsheetCommandBarButtonItem95
			' 
			Me.spreadsheetCommandBarButtonItem95.CommandName = "FormatClearHyperlinks"
			Me.spreadsheetCommandBarButtonItem95.Id = 145
			Me.spreadsheetCommandBarButtonItem95.Name = "spreadsheetCommandBarButtonItem95"
			' 
			' spreadsheetCommandBarButtonItem96
			' 
			Me.spreadsheetCommandBarButtonItem96.CommandName = "FormatRemoveHyperlinks"
			Me.spreadsheetCommandBarButtonItem96.Id = 146
			Me.spreadsheetCommandBarButtonItem96.Name = "spreadsheetCommandBarButtonItem96"
			' 
			' spreadsheetCommandBarSubItem15
			' 
			Me.spreadsheetCommandBarSubItem15.CommandName = "EditingSortAndFilterCommandGroup"
			Me.spreadsheetCommandBarSubItem15.Id = 147
			Me.spreadsheetCommandBarSubItem15.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem97), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem98), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem99), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem100)})
			Me.spreadsheetCommandBarSubItem15.Name = "spreadsheetCommandBarSubItem15"
			' 
			' spreadsheetCommandBarButtonItem97
			' 
			Me.spreadsheetCommandBarButtonItem97.CommandName = "DataSortAscending"
			Me.spreadsheetCommandBarButtonItem97.Id = 148
			Me.spreadsheetCommandBarButtonItem97.Name = "spreadsheetCommandBarButtonItem97"
			' 
			' spreadsheetCommandBarButtonItem98
			' 
			Me.spreadsheetCommandBarButtonItem98.CommandName = "DataSortDescending"
			Me.spreadsheetCommandBarButtonItem98.Id = 149
			Me.spreadsheetCommandBarButtonItem98.Name = "spreadsheetCommandBarButtonItem98"
			' 
			' spreadsheetCommandBarCheckItem14
			' 
			Me.spreadsheetCommandBarCheckItem14.CommandName = "DataFilterToggle"
			Me.spreadsheetCommandBarCheckItem14.Id = 150
			Me.spreadsheetCommandBarCheckItem14.Name = "spreadsheetCommandBarCheckItem14"
			' 
			' spreadsheetCommandBarButtonItem99
			' 
			Me.spreadsheetCommandBarButtonItem99.CommandName = "DataFilterClear"
			Me.spreadsheetCommandBarButtonItem99.Id = 151
			Me.spreadsheetCommandBarButtonItem99.Name = "spreadsheetCommandBarButtonItem99"
			' 
			' spreadsheetCommandBarButtonItem100
			' 
			Me.spreadsheetCommandBarButtonItem100.CommandName = "DataFilterReApply"
			Me.spreadsheetCommandBarButtonItem100.Id = 152
			Me.spreadsheetCommandBarButtonItem100.Name = "spreadsheetCommandBarButtonItem100"
			' 
			' spreadsheetCommandBarSubItem16
			' 
			Me.spreadsheetCommandBarSubItem16.CommandName = "EditingFindAndSelectCommandGroup"
			Me.spreadsheetCommandBarSubItem16.Id = 153
			Me.spreadsheetCommandBarSubItem16.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem101), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem102), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem103), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem104), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem105), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem106), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem112)})
			Me.spreadsheetCommandBarSubItem16.Name = "spreadsheetCommandBarSubItem16"
			' 
			' spreadsheetCommandBarButtonItem101
			' 
			Me.spreadsheetCommandBarButtonItem101.CommandName = "EditingFind"
			Me.spreadsheetCommandBarButtonItem101.Id = 154
			Me.spreadsheetCommandBarButtonItem101.Name = "spreadsheetCommandBarButtonItem101"
			' 
			' spreadsheetCommandBarButtonItem102
			' 
			Me.spreadsheetCommandBarButtonItem102.CommandName = "EditingReplace"
			Me.spreadsheetCommandBarButtonItem102.Id = 155
			Me.spreadsheetCommandBarButtonItem102.Name = "spreadsheetCommandBarButtonItem102"
			' 
			' spreadsheetCommandBarButtonItem103
			' 
			Me.spreadsheetCommandBarButtonItem103.CommandName = "EditingSelectFormulas"
			Me.spreadsheetCommandBarButtonItem103.Id = 156
			Me.spreadsheetCommandBarButtonItem103.Name = "spreadsheetCommandBarButtonItem103"
			' 
			' spreadsheetCommandBarButtonItem104
			' 
			Me.spreadsheetCommandBarButtonItem104.CommandName = "EditingSelectComments"
			Me.spreadsheetCommandBarButtonItem104.Id = 157
			Me.spreadsheetCommandBarButtonItem104.Name = "spreadsheetCommandBarButtonItem104"
			' 
			' spreadsheetCommandBarButtonItem105
			' 
			Me.spreadsheetCommandBarButtonItem105.CommandName = "EditingSelectConditionalFormatting"
			Me.spreadsheetCommandBarButtonItem105.Id = 158
			Me.spreadsheetCommandBarButtonItem105.Name = "spreadsheetCommandBarButtonItem105"
			' 
			' spreadsheetCommandBarButtonItem106
			' 
			Me.spreadsheetCommandBarButtonItem106.CommandName = "EditingSelectConstants"
			Me.spreadsheetCommandBarButtonItem106.Id = 159
			Me.spreadsheetCommandBarButtonItem106.Name = "spreadsheetCommandBarButtonItem106"
			' 
			' spreadsheetCommandBarButtonItem112
			' 
			Me.spreadsheetCommandBarButtonItem112.CommandName = "EditingSelectDataValidation"
			Me.spreadsheetCommandBarButtonItem112.Id = 160
			Me.spreadsheetCommandBarButtonItem112.Name = "spreadsheetCommandBarButtonItem112"
			' 
			' tablesRibbonPageGroup1
			' 
			Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem113)
			Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem114)
			Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
			' 
			' insertRibbonPage1
			' 
			Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.chartsRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.symbolsRibbonPageGroup1})
			Me.insertRibbonPage1.Name = "insertRibbonPage1"
			' 
			' spreadsheetCommandBarButtonItem113
			' 
			Me.spreadsheetCommandBarButtonItem113.CommandName = "InsertPivotTable"
			Me.spreadsheetCommandBarButtonItem113.Id = 161
			Me.spreadsheetCommandBarButtonItem113.Name = "spreadsheetCommandBarButtonItem113"
			' 
			' spreadsheetCommandBarButtonItem114
			' 
			Me.spreadsheetCommandBarButtonItem114.CommandName = "InsertTable"
			Me.spreadsheetCommandBarButtonItem114.Id = 162
			Me.spreadsheetCommandBarButtonItem114.Name = "spreadsheetCommandBarButtonItem114"
			' 
			' illustrationsRibbonPageGroup1
			' 
			Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem115)
			Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonItem115
			' 
			Me.spreadsheetCommandBarButtonItem115.CommandName = "InsertPicture"
			Me.spreadsheetCommandBarButtonItem115.Id = 163
			Me.spreadsheetCommandBarButtonItem115.Name = "spreadsheetCommandBarButtonItem115"
			' 
			' chartsRibbonPageGroup1
			' 
			Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem4)
			Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem5)
			Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem6)
			Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem7)
			Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem8)
			Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem9)
			Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem10)
			Me.chartsRibbonPageGroup1.Name = "chartsRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem4
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem4.CommandName = "InsertChartColumnCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem4.DropDownControl = Me.commandBarGalleryDropDown54
			Me.spreadsheetCommandBarButtonGalleryDropDownItem4.Id = 164
			Me.spreadsheetCommandBarButtonGalleryDropDownItem4.Name = "spreadsheetCommandBarButtonGalleryDropDownItem4"
			' 
			' commandBarGalleryDropDown54
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown54.Gallery.ColumnCount = 4
			spreadsheetCommandGalleryItemGroup10.CommandName = "InsertChartColumn2DCommandGroup"
			spreadsheetCommandGalleryItem68.CommandName = "InsertChartColumnClustered2D"
			spreadsheetCommandGalleryItem69.CommandName = "InsertChartColumnStacked2D"
			spreadsheetCommandGalleryItem70.CommandName = "InsertChartColumnPercentStacked2D"
			spreadsheetCommandGalleryItemGroup10.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem68, spreadsheetCommandGalleryItem69, spreadsheetCommandGalleryItem70})
			spreadsheetCommandGalleryItemGroup11.CommandName = "InsertChartColumn3DCommandGroup"
			spreadsheetCommandGalleryItem71.CommandName = "InsertChartColumnClustered3D"
			spreadsheetCommandGalleryItem72.CommandName = "InsertChartColumnStacked3D"
			spreadsheetCommandGalleryItem73.CommandName = "InsertChartColumnPercentStacked3D"
			spreadsheetCommandGalleryItem74.CommandName = "InsertChartColumn3D"
			spreadsheetCommandGalleryItemGroup11.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem71, spreadsheetCommandGalleryItem72, spreadsheetCommandGalleryItem73, spreadsheetCommandGalleryItem74})
			spreadsheetCommandGalleryItemGroup12.CommandName = "InsertChartCylinderCommandGroup"
			spreadsheetCommandGalleryItem75.CommandName = "InsertChartCylinderClustered"
			spreadsheetCommandGalleryItem76.CommandName = "InsertChartCylinderStacked"
			spreadsheetCommandGalleryItem77.CommandName = "InsertChartCylinderPercentStacked"
			spreadsheetCommandGalleryItem78.CommandName = "InsertChartCylinder"
			spreadsheetCommandGalleryItemGroup12.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem75, spreadsheetCommandGalleryItem76, spreadsheetCommandGalleryItem77, spreadsheetCommandGalleryItem78})
			spreadsheetCommandGalleryItemGroup13.CommandName = "InsertChartConeCommandGroup"
			spreadsheetCommandGalleryItem79.CommandName = "InsertChartConeClustered"
			spreadsheetCommandGalleryItem80.CommandName = "InsertChartConeStacked"
			spreadsheetCommandGalleryItem81.CommandName = "InsertChartConePercentStacked"
			spreadsheetCommandGalleryItem82.CommandName = "InsertChartCone"
			spreadsheetCommandGalleryItemGroup13.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem79, spreadsheetCommandGalleryItem80, spreadsheetCommandGalleryItem81, spreadsheetCommandGalleryItem82})
			spreadsheetCommandGalleryItemGroup14.CommandName = "InsertChartPyramidCommandGroup"
			spreadsheetCommandGalleryItem83.CommandName = "InsertChartPyramidClustered"
			spreadsheetCommandGalleryItem84.CommandName = "InsertChartPyramidStacked"
			spreadsheetCommandGalleryItem85.CommandName = "InsertChartPyramidPercentStacked"
			spreadsheetCommandGalleryItem86.CommandName = "InsertChartPyramid"
			spreadsheetCommandGalleryItemGroup14.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem83, spreadsheetCommandGalleryItem84, spreadsheetCommandGalleryItem85, spreadsheetCommandGalleryItem86})
			Me.commandBarGalleryDropDown54.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup10, spreadsheetCommandGalleryItemGroup11, spreadsheetCommandGalleryItemGroup12, spreadsheetCommandGalleryItemGroup13, spreadsheetCommandGalleryItemGroup14})
			Me.commandBarGalleryDropDown54.Gallery.RowCount = 5
			Me.commandBarGalleryDropDown54.Name = "commandBarGalleryDropDown54"
			Me.commandBarGalleryDropDown54.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem5
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem5.CommandName = "InsertChartLineCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem5.DropDownControl = Me.commandBarGalleryDropDown55
			Me.spreadsheetCommandBarButtonGalleryDropDownItem5.Id = 165
			Me.spreadsheetCommandBarButtonGalleryDropDownItem5.Name = "spreadsheetCommandBarButtonGalleryDropDownItem5"
			' 
			' commandBarGalleryDropDown55
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown55.Gallery.ColumnCount = 3
			spreadsheetCommandGalleryItemGroup15.CommandName = "InsertChartLine2DCommandGroup"
			spreadsheetCommandGalleryItem87.CommandName = "InsertChartLine"
			spreadsheetCommandGalleryItem88.CommandName = "InsertChartStackedLine"
			spreadsheetCommandGalleryItem89.CommandName = "InsertChartPercentStackedLine"
			spreadsheetCommandGalleryItem90.CommandName = "InsertChartLineWithMarkers"
			spreadsheetCommandGalleryItem91.CommandName = "InsertChartStackedLineWithMarkers"
			spreadsheetCommandGalleryItem92.CommandName = "InsertChartPercentStackedLineWithMarkers"
			spreadsheetCommandGalleryItemGroup15.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem87, spreadsheetCommandGalleryItem88, spreadsheetCommandGalleryItem89, spreadsheetCommandGalleryItem90, spreadsheetCommandGalleryItem91, spreadsheetCommandGalleryItem92})
			spreadsheetCommandGalleryItemGroup16.CommandName = "InsertChartLine3DCommandGroup"
			spreadsheetCommandGalleryItem93.CommandName = "InsertChartLine3D"
			spreadsheetCommandGalleryItemGroup16.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem93})
			Me.commandBarGalleryDropDown55.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup15, spreadsheetCommandGalleryItemGroup16})
			Me.commandBarGalleryDropDown55.Name = "commandBarGalleryDropDown55"
			Me.commandBarGalleryDropDown55.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem6
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem6.CommandName = "InsertChartPieCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem6.DropDownControl = Me.commandBarGalleryDropDown56
			Me.spreadsheetCommandBarButtonGalleryDropDownItem6.Id = 166
			Me.spreadsheetCommandBarButtonGalleryDropDownItem6.Name = "spreadsheetCommandBarButtonGalleryDropDownItem6"
			' 
			' commandBarGalleryDropDown56
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown56.Gallery.ColumnCount = 2
			spreadsheetCommandGalleryItemGroup17.CommandName = "InsertChartPie2DCommandGroup"
			spreadsheetCommandGalleryItem94.CommandName = "InsertChartPie2D"
			spreadsheetCommandGalleryItem95.CommandName = "InsertChartPieExploded2D"
			spreadsheetCommandGalleryItemGroup17.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem94, spreadsheetCommandGalleryItem95})
			spreadsheetCommandGalleryItemGroup18.CommandName = "InsertChartPie3DCommandGroup"
			spreadsheetCommandGalleryItem96.CommandName = "InsertChartPie3D"
			spreadsheetCommandGalleryItem97.CommandName = "InsertChartPieExploded3D"
			spreadsheetCommandGalleryItemGroup18.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem96, spreadsheetCommandGalleryItem97})
			spreadsheetCommandGalleryItemGroup19.CommandName = "InsertChartDoughnut2DCommandGroup"
			spreadsheetCommandGalleryItem98.CommandName = "InsertChartDoughnut2D"
			spreadsheetCommandGalleryItem99.CommandName = "InsertChartDoughnutExploded2D"
			spreadsheetCommandGalleryItemGroup19.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem98, spreadsheetCommandGalleryItem99})
			Me.commandBarGalleryDropDown56.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup17, spreadsheetCommandGalleryItemGroup18, spreadsheetCommandGalleryItemGroup19})
			Me.commandBarGalleryDropDown56.Name = "commandBarGalleryDropDown56"
			Me.commandBarGalleryDropDown56.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem7
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem7.CommandName = "InsertChartBarCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem7.DropDownControl = Me.commandBarGalleryDropDown57
			Me.spreadsheetCommandBarButtonGalleryDropDownItem7.Id = 167
			Me.spreadsheetCommandBarButtonGalleryDropDownItem7.Name = "spreadsheetCommandBarButtonGalleryDropDownItem7"
			' 
			' commandBarGalleryDropDown57
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown57.Gallery.ColumnCount = 3
			spreadsheetCommandGalleryItemGroup20.CommandName = "InsertChartBar2DCommandGroup"
			spreadsheetCommandGalleryItem100.CommandName = "InsertChartBarClustered2D"
			spreadsheetCommandGalleryItem101.CommandName = "InsertChartBarStacked2D"
			spreadsheetCommandGalleryItem102.CommandName = "InsertChartBarPercentStacked2D"
			spreadsheetCommandGalleryItemGroup20.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem100, spreadsheetCommandGalleryItem101, spreadsheetCommandGalleryItem102})
			spreadsheetCommandGalleryItemGroup21.CommandName = "InsertChartBar3DCommandGroup"
			spreadsheetCommandGalleryItem103.CommandName = "InsertChartBarClustered3D"
			spreadsheetCommandGalleryItem104.CommandName = "InsertChartBarStacked3D"
			spreadsheetCommandGalleryItem105.CommandName = "InsertChartBarPercentStacked3D"
			spreadsheetCommandGalleryItemGroup21.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem103, spreadsheetCommandGalleryItem104, spreadsheetCommandGalleryItem105})
			spreadsheetCommandGalleryItemGroup22.CommandName = "InsertChartHorizontalCylinderCommandGroup"
			spreadsheetCommandGalleryItem106.CommandName = "InsertChartHorizontalCylinderClustered"
			spreadsheetCommandGalleryItem107.CommandName = "InsertChartHorizontalCylinderStacked"
			spreadsheetCommandGalleryItem108.CommandName = "InsertChartHorizontalCylinderPercentStacked"
			spreadsheetCommandGalleryItemGroup22.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem106, spreadsheetCommandGalleryItem107, spreadsheetCommandGalleryItem108})
			spreadsheetCommandGalleryItemGroup23.CommandName = "InsertChartHorizontalConeCommandGroup"
			spreadsheetCommandGalleryItem109.CommandName = "InsertChartHorizontalConeClustered"
			spreadsheetCommandGalleryItem110.CommandName = "InsertChartHorizontalConeStacked"
			spreadsheetCommandGalleryItem111.CommandName = "InsertChartHorizontalConePercentStacked"
			spreadsheetCommandGalleryItemGroup23.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem109, spreadsheetCommandGalleryItem110, spreadsheetCommandGalleryItem111})
			spreadsheetCommandGalleryItemGroup24.CommandName = "InsertChartHorizontalPyramidCommandGroup"
			spreadsheetCommandGalleryItem112.CommandName = "InsertChartHorizontalPyramidClustered"
			spreadsheetCommandGalleryItem113.CommandName = "InsertChartHorizontalPyramidStacked"
			spreadsheetCommandGalleryItem114.CommandName = "InsertChartHorizontalPyramidPercentStacked"
			spreadsheetCommandGalleryItemGroup24.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem112, spreadsheetCommandGalleryItem113, spreadsheetCommandGalleryItem114})
			Me.commandBarGalleryDropDown57.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup20, spreadsheetCommandGalleryItemGroup21, spreadsheetCommandGalleryItemGroup22, spreadsheetCommandGalleryItemGroup23, spreadsheetCommandGalleryItemGroup24})
			Me.commandBarGalleryDropDown57.Gallery.RowCount = 5
			Me.commandBarGalleryDropDown57.Name = "commandBarGalleryDropDown57"
			Me.commandBarGalleryDropDown57.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem8
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem8.CommandName = "InsertChartAreaCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem8.DropDownControl = Me.commandBarGalleryDropDown58
			Me.spreadsheetCommandBarButtonGalleryDropDownItem8.Id = 168
			Me.spreadsheetCommandBarButtonGalleryDropDownItem8.Name = "spreadsheetCommandBarButtonGalleryDropDownItem8"
			' 
			' commandBarGalleryDropDown58
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown58.Gallery.ColumnCount = 3
			spreadsheetCommandGalleryItemGroup25.CommandName = "InsertChartArea2DCommandGroup"
			spreadsheetCommandGalleryItem115.CommandName = "InsertChartArea"
			spreadsheetCommandGalleryItem116.CommandName = "InsertChartStackedArea"
			spreadsheetCommandGalleryItem117.CommandName = "InsertChartPercentStackedArea"
			spreadsheetCommandGalleryItemGroup25.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem115, spreadsheetCommandGalleryItem116, spreadsheetCommandGalleryItem117})
			spreadsheetCommandGalleryItemGroup26.CommandName = "InsertChartArea3DCommandGroup"
			spreadsheetCommandGalleryItem118.CommandName = "InsertChartArea3D"
			spreadsheetCommandGalleryItem119.CommandName = "InsertChartStackedArea3D"
			spreadsheetCommandGalleryItem120.CommandName = "InsertChartPercentStackedArea3D"
			spreadsheetCommandGalleryItemGroup26.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem118, spreadsheetCommandGalleryItem119, spreadsheetCommandGalleryItem120})
			Me.commandBarGalleryDropDown58.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup25, spreadsheetCommandGalleryItemGroup26})
			Me.commandBarGalleryDropDown58.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown58.Name = "commandBarGalleryDropDown58"
			Me.commandBarGalleryDropDown58.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem9
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem9.CommandName = "InsertChartScatterCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem9.DropDownControl = Me.commandBarGalleryDropDown59
			Me.spreadsheetCommandBarButtonGalleryDropDownItem9.Id = 169
			Me.spreadsheetCommandBarButtonGalleryDropDownItem9.Name = "spreadsheetCommandBarButtonGalleryDropDownItem9"
			' 
			' commandBarGalleryDropDown59
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown59.Gallery.ColumnCount = 2
			spreadsheetCommandGalleryItemGroup27.CommandName = "InsertChartScatterCommandGroup"
			spreadsheetCommandGalleryItem121.CommandName = "InsertChartScatterMarkers"
			spreadsheetCommandGalleryItem122.CommandName = "InsertChartScatterSmoothLinesAndMarkers"
			spreadsheetCommandGalleryItem123.CommandName = "InsertChartScatterSmoothLines"
			spreadsheetCommandGalleryItem124.CommandName = "InsertChartScatterLinesAndMarkers"
			spreadsheetCommandGalleryItem125.CommandName = "InsertChartScatterLines"
			spreadsheetCommandGalleryItemGroup27.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem121, spreadsheetCommandGalleryItem122, spreadsheetCommandGalleryItem123, spreadsheetCommandGalleryItem124, spreadsheetCommandGalleryItem125})
			spreadsheetCommandGalleryItemGroup28.CommandName = "InsertChartBubbleCommandGroup"
			spreadsheetCommandGalleryItem126.CommandName = "InsertChartBubble"
			spreadsheetCommandGalleryItem127.CommandName = "InsertChartBubble3D"
			spreadsheetCommandGalleryItemGroup28.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem126, spreadsheetCommandGalleryItem127})
			Me.commandBarGalleryDropDown59.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup27, spreadsheetCommandGalleryItemGroup28})
			Me.commandBarGalleryDropDown59.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown59.Name = "commandBarGalleryDropDown59"
			Me.commandBarGalleryDropDown59.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem10
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem10.CommandName = "InsertChartOtherCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem10.DropDownControl = Me.commandBarGalleryDropDown60
			Me.spreadsheetCommandBarButtonGalleryDropDownItem10.Id = 170
			Me.spreadsheetCommandBarButtonGalleryDropDownItem10.Name = "spreadsheetCommandBarButtonGalleryDropDownItem10"
			' 
			' commandBarGalleryDropDown60
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown60.Gallery.ColumnCount = 4
			spreadsheetCommandGalleryItemGroup29.CommandName = "InsertChartStockCommandGroup"
			spreadsheetCommandGalleryItem128.CommandName = "InsertChartStockHighLowClose"
			spreadsheetCommandGalleryItem129.CommandName = "InsertChartStockOpenHighLowClose"
			spreadsheetCommandGalleryItem130.CommandName = "InsertChartStockVolumeHighLowClose"
			spreadsheetCommandGalleryItem131.CommandName = "InsertChartStockVolumeOpenHighLowClose"
			spreadsheetCommandGalleryItemGroup29.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem128, spreadsheetCommandGalleryItem129, spreadsheetCommandGalleryItem130, spreadsheetCommandGalleryItem131})
			spreadsheetCommandGalleryItemGroup30.CommandName = "InsertChartRadarCommandGroup"
			spreadsheetCommandGalleryItem132.CommandName = "InsertChartRadar"
			spreadsheetCommandGalleryItem133.CommandName = "InsertChartRadarWithMarkers"
			spreadsheetCommandGalleryItem134.CommandName = "InsertChartRadarFilled"
			spreadsheetCommandGalleryItemGroup30.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem132, spreadsheetCommandGalleryItem133, spreadsheetCommandGalleryItem134})
			Me.commandBarGalleryDropDown60.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup29, spreadsheetCommandGalleryItemGroup30})
			Me.commandBarGalleryDropDown60.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown60.Name = "commandBarGalleryDropDown60"
			Me.commandBarGalleryDropDown60.Ribbon = Me.ribbonControl1
			' 
			' linksRibbonPageGroup1
			' 
			Me.linksRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem116)
			Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonItem116
			' 
			Me.spreadsheetCommandBarButtonItem116.CommandName = "InsertHyperlink"
			Me.spreadsheetCommandBarButtonItem116.Id = 171
			Me.spreadsheetCommandBarButtonItem116.Name = "spreadsheetCommandBarButtonItem116"
			' 
			' symbolsRibbonPageGroup1
			' 
			Me.symbolsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem117)
			Me.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonItem117
			' 
			Me.spreadsheetCommandBarButtonItem117.CommandName = "InsertSymbol"
			Me.spreadsheetCommandBarButtonItem117.Id = 172
			Me.spreadsheetCommandBarButtonItem117.Name = "spreadsheetCommandBarButtonItem117"
			' 
			' pageSetupRibbonPageGroup1
			' 
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem17)
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem18)
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.pageSetupPaperKindItem1)
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem19)
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem127)
			Me.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1"
			' 
			' pageLayoutRibbonPage1
			' 
			Me.pageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pageSetupRibbonPageGroup1, Me.pageSetupShowRibbonPageGroup1, Me.pageSetupPrintRibbonPageGroup1, Me.arrangeRibbonPageGroup1})
			Me.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1"
			' 
			' spreadsheetCommandBarSubItem17
			' 
			Me.spreadsheetCommandBarSubItem17.CommandName = "PageSetupMarginsCommandGroup"
			Me.spreadsheetCommandBarSubItem17.Id = 173
			Me.spreadsheetCommandBarSubItem17.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem118)})
			Me.spreadsheetCommandBarSubItem17.Name = "spreadsheetCommandBarSubItem17"
			' 
			' spreadsheetCommandBarCheckItem15
			' 
			Me.spreadsheetCommandBarCheckItem15.CaptionDependOnUnits = True
			Me.spreadsheetCommandBarCheckItem15.CommandName = "PageSetupMarginsNormal"
			Me.spreadsheetCommandBarCheckItem15.Id = 174
			Me.spreadsheetCommandBarCheckItem15.Name = "spreadsheetCommandBarCheckItem15"
			' 
			' spreadsheetCommandBarCheckItem16
			' 
			Me.spreadsheetCommandBarCheckItem16.CaptionDependOnUnits = True
			Me.spreadsheetCommandBarCheckItem16.CommandName = "PageSetupMarginsWide"
			Me.spreadsheetCommandBarCheckItem16.Id = 175
			Me.spreadsheetCommandBarCheckItem16.Name = "spreadsheetCommandBarCheckItem16"
			' 
			' spreadsheetCommandBarCheckItem17
			' 
			Me.spreadsheetCommandBarCheckItem17.CaptionDependOnUnits = True
			Me.spreadsheetCommandBarCheckItem17.CommandName = "PageSetupMarginsNarrow"
			Me.spreadsheetCommandBarCheckItem17.Id = 176
			Me.spreadsheetCommandBarCheckItem17.Name = "spreadsheetCommandBarCheckItem17"
			' 
			' spreadsheetCommandBarButtonItem118
			' 
			Me.spreadsheetCommandBarButtonItem118.CommandName = "PageSetupCustomMargins"
			Me.spreadsheetCommandBarButtonItem118.Id = 177
			Me.spreadsheetCommandBarButtonItem118.Name = "spreadsheetCommandBarButtonItem118"
			' 
			' spreadsheetCommandBarSubItem18
			' 
			Me.spreadsheetCommandBarSubItem18.CommandName = "PageSetupOrientationCommandGroup"
			Me.spreadsheetCommandBarSubItem18.Id = 178
			Me.spreadsheetCommandBarSubItem18.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem19)})
			Me.spreadsheetCommandBarSubItem18.Name = "spreadsheetCommandBarSubItem18"
			' 
			' spreadsheetCommandBarCheckItem18
			' 
			Me.spreadsheetCommandBarCheckItem18.CommandName = "PageSetupOrientationPortrait"
			Me.spreadsheetCommandBarCheckItem18.Id = 179
			Me.spreadsheetCommandBarCheckItem18.Name = "spreadsheetCommandBarCheckItem18"
			' 
			' spreadsheetCommandBarCheckItem19
			' 
			Me.spreadsheetCommandBarCheckItem19.CommandName = "PageSetupOrientationLandscape"
			Me.spreadsheetCommandBarCheckItem19.Id = 180
			Me.spreadsheetCommandBarCheckItem19.Name = "spreadsheetCommandBarCheckItem19"
			' 
			' pageSetupPaperKindItem1
			' 
			Me.pageSetupPaperKindItem1.Id = 181
			Me.pageSetupPaperKindItem1.Name = "pageSetupPaperKindItem1"
			' 
			' spreadsheetCommandBarSubItem19
			' 
			Me.spreadsheetCommandBarSubItem19.CommandName = "PageSetupPrintAreaCommandGroup"
			Me.spreadsheetCommandBarSubItem19.Id = 182
			Me.spreadsheetCommandBarSubItem19.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem124), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem125), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem126)})
			Me.spreadsheetCommandBarSubItem19.Name = "spreadsheetCommandBarSubItem19"
			' 
			' spreadsheetCommandBarButtonItem124
			' 
			Me.spreadsheetCommandBarButtonItem124.CommandName = "PageSetupSetPrintArea"
			Me.spreadsheetCommandBarButtonItem124.Id = 183
			Me.spreadsheetCommandBarButtonItem124.Name = "spreadsheetCommandBarButtonItem124"
			' 
			' spreadsheetCommandBarButtonItem125
			' 
			Me.spreadsheetCommandBarButtonItem125.CommandName = "PageSetupClearPrintArea"
			Me.spreadsheetCommandBarButtonItem125.Id = 184
			Me.spreadsheetCommandBarButtonItem125.Name = "spreadsheetCommandBarButtonItem125"
			' 
			' spreadsheetCommandBarButtonItem126
			' 
			Me.spreadsheetCommandBarButtonItem126.CommandName = "PageSetupAddPrintArea"
			Me.spreadsheetCommandBarButtonItem126.Id = 185
			Me.spreadsheetCommandBarButtonItem126.Name = "spreadsheetCommandBarButtonItem126"
			' 
			' spreadsheetCommandBarButtonItem127
			' 
			Me.spreadsheetCommandBarButtonItem127.CommandName = "PageSetupPrintTitles"
			Me.spreadsheetCommandBarButtonItem127.Id = 186
			Me.spreadsheetCommandBarButtonItem127.Name = "spreadsheetCommandBarButtonItem127"
			' 
			' pageSetupShowRibbonPageGroup1
			' 
			Me.pageSetupShowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem20)
			Me.pageSetupShowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem21)
			Me.pageSetupShowRibbonPageGroup1.Name = "pageSetupShowRibbonPageGroup1"
			' 
			' spreadsheetCommandBarCheckItem20
			' 
			Me.spreadsheetCommandBarCheckItem20.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem20.CommandName = "ViewShowGridlines"
			Me.spreadsheetCommandBarCheckItem20.Id = 187
			Me.spreadsheetCommandBarCheckItem20.Name = "spreadsheetCommandBarCheckItem20"
			' 
			' spreadsheetCommandBarCheckItem21
			' 
			Me.spreadsheetCommandBarCheckItem21.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem21.CommandName = "ViewShowHeadings"
			Me.spreadsheetCommandBarCheckItem21.Id = 188
			Me.spreadsheetCommandBarCheckItem21.Name = "spreadsheetCommandBarCheckItem21"
			' 
			' pageSetupPrintRibbonPageGroup1
			' 
			Me.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem22)
			Me.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem23)
			Me.pageSetupPrintRibbonPageGroup1.Name = "pageSetupPrintRibbonPageGroup1"
			' 
			' spreadsheetCommandBarCheckItem22
			' 
			Me.spreadsheetCommandBarCheckItem22.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem22.CommandName = "PageSetupPrintGridlines"
			Me.spreadsheetCommandBarCheckItem22.Id = 189
			Me.spreadsheetCommandBarCheckItem22.Name = "spreadsheetCommandBarCheckItem22"
			' 
			' spreadsheetCommandBarCheckItem23
			' 
			Me.spreadsheetCommandBarCheckItem23.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem23.CommandName = "PageSetupPrintHeadings"
			Me.spreadsheetCommandBarCheckItem23.Id = 190
			Me.spreadsheetCommandBarCheckItem23.Name = "spreadsheetCommandBarCheckItem23"
			' 
			' arrangeRibbonPageGroup1
			' 
			Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem20)
			Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem21)
			Me.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1"
			' 
			' spreadsheetCommandBarSubItem20
			' 
			Me.spreadsheetCommandBarSubItem20.CommandName = "ArrangeBringForwardCommandGroup"
			Me.spreadsheetCommandBarSubItem20.Id = 191
			Me.spreadsheetCommandBarSubItem20.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem128), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem129)})
			Me.spreadsheetCommandBarSubItem20.Name = "spreadsheetCommandBarSubItem20"
			' 
			' spreadsheetCommandBarButtonItem128
			' 
			Me.spreadsheetCommandBarButtonItem128.CommandName = "ArrangeBringForward"
			Me.spreadsheetCommandBarButtonItem128.Id = 192
			Me.spreadsheetCommandBarButtonItem128.Name = "spreadsheetCommandBarButtonItem128"
			' 
			' spreadsheetCommandBarButtonItem129
			' 
			Me.spreadsheetCommandBarButtonItem129.CommandName = "ArrangeBringToFront"
			Me.spreadsheetCommandBarButtonItem129.Id = 193
			Me.spreadsheetCommandBarButtonItem129.Name = "spreadsheetCommandBarButtonItem129"
			' 
			' spreadsheetCommandBarSubItem21
			' 
			Me.spreadsheetCommandBarSubItem21.CommandName = "ArrangeSendBackwardCommandGroup"
			Me.spreadsheetCommandBarSubItem21.Id = 194
			Me.spreadsheetCommandBarSubItem21.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem130), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem131)})
			Me.spreadsheetCommandBarSubItem21.Name = "spreadsheetCommandBarSubItem21"
			' 
			' spreadsheetCommandBarButtonItem130
			' 
			Me.spreadsheetCommandBarButtonItem130.CommandName = "ArrangeSendBackward"
			Me.spreadsheetCommandBarButtonItem130.Id = 195
			Me.spreadsheetCommandBarButtonItem130.Name = "spreadsheetCommandBarButtonItem130"
			' 
			' spreadsheetCommandBarButtonItem131
			' 
			Me.spreadsheetCommandBarButtonItem131.CommandName = "ArrangeSendToBack"
			Me.spreadsheetCommandBarButtonItem131.Id = 196
			Me.spreadsheetCommandBarButtonItem131.Name = "spreadsheetCommandBarButtonItem131"
			' 
			' functionLibraryRibbonPageGroup1
			' 
			Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem22)
			Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsFinancialItem1)
			Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsLogicalItem1)
			Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsTextItem1)
			Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsDateAndTimeItem1)
			Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsLookupAndReferenceItem1)
			Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsMathAndTrigonometryItem1)
			Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem23)
			Me.functionLibraryRibbonPageGroup1.Name = "functionLibraryRibbonPageGroup1"
			' 
			' formulasRibbonPage1
			' 
			Me.formulasRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.functionLibraryRibbonPageGroup1, Me.formulaDefinedNamesRibbonPageGroup1, Me.formulaAuditingRibbonPageGroup1, Me.formulaCalculationRibbonPageGroup1})
			Me.formulasRibbonPage1.Name = "formulasRibbonPage1"
			' 
			' spreadsheetCommandBarSubItem22
			' 
			Me.spreadsheetCommandBarSubItem22.CommandName = "FunctionsAutoSumCommandGroup"
			Me.spreadsheetCommandBarSubItem22.Id = 197
			Me.spreadsheetCommandBarSubItem22.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem82), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem83), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem84), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem85), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem86)})
			Me.spreadsheetCommandBarSubItem22.Name = "spreadsheetCommandBarSubItem22"
			' 
			' spreadsheetCommandBarButtonItem132
			' 
			Me.spreadsheetCommandBarButtonItem132.CommandName = "FunctionsInsertSum"
			Me.spreadsheetCommandBarButtonItem132.Id = -1
			Me.spreadsheetCommandBarButtonItem132.Name = "spreadsheetCommandBarButtonItem132"
			' 
			' spreadsheetCommandBarButtonItem133
			' 
			Me.spreadsheetCommandBarButtonItem133.CommandName = "FunctionsInsertAverage"
			Me.spreadsheetCommandBarButtonItem133.Id = -1
			Me.spreadsheetCommandBarButtonItem133.Name = "spreadsheetCommandBarButtonItem133"
			' 
			' spreadsheetCommandBarButtonItem134
			' 
			Me.spreadsheetCommandBarButtonItem134.CommandName = "FunctionsInsertCountNumbers"
			Me.spreadsheetCommandBarButtonItem134.Id = -1
			Me.spreadsheetCommandBarButtonItem134.Name = "spreadsheetCommandBarButtonItem134"
			' 
			' spreadsheetCommandBarButtonItem135
			' 
			Me.spreadsheetCommandBarButtonItem135.CommandName = "FunctionsInsertMax"
			Me.spreadsheetCommandBarButtonItem135.Id = -1
			Me.spreadsheetCommandBarButtonItem135.Name = "spreadsheetCommandBarButtonItem135"
			' 
			' spreadsheetCommandBarButtonItem136
			' 
			Me.spreadsheetCommandBarButtonItem136.CommandName = "FunctionsInsertMin"
			Me.spreadsheetCommandBarButtonItem136.Id = -1
			Me.spreadsheetCommandBarButtonItem136.Name = "spreadsheetCommandBarButtonItem136"
			' 
			' functionsFinancialItem1
			' 
			Me.functionsFinancialItem1.Id = 198
			Me.functionsFinancialItem1.Name = "functionsFinancialItem1"
			' 
			' functionsLogicalItem1
			' 
			Me.functionsLogicalItem1.Id = 199
			Me.functionsLogicalItem1.Name = "functionsLogicalItem1"
			' 
			' functionsTextItem1
			' 
			Me.functionsTextItem1.Id = 200
			Me.functionsTextItem1.Name = "functionsTextItem1"
			' 
			' functionsDateAndTimeItem1
			' 
			Me.functionsDateAndTimeItem1.Id = 201
			Me.functionsDateAndTimeItem1.Name = "functionsDateAndTimeItem1"
			' 
			' functionsLookupAndReferenceItem1
			' 
			Me.functionsLookupAndReferenceItem1.Id = 202
			Me.functionsLookupAndReferenceItem1.Name = "functionsLookupAndReferenceItem1"
			' 
			' functionsMathAndTrigonometryItem1
			' 
			Me.functionsMathAndTrigonometryItem1.Id = 203
			Me.functionsMathAndTrigonometryItem1.Name = "functionsMathAndTrigonometryItem1"
			' 
			' spreadsheetCommandBarSubItem23
			' 
			Me.spreadsheetCommandBarSubItem23.CommandName = "FunctionsMoreCommandGroup"
			Me.spreadsheetCommandBarSubItem23.Id = 204
			Me.spreadsheetCommandBarSubItem23.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.functionsStatisticalItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.functionsEngineeringItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.functionsInformationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.functionsCompatibilityItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.functionsWebItem1)})
			Me.spreadsheetCommandBarSubItem23.Name = "spreadsheetCommandBarSubItem23"
			' 
			' functionsStatisticalItem1
			' 
			Me.functionsStatisticalItem1.Id = 205
			Me.functionsStatisticalItem1.Name = "functionsStatisticalItem1"
			' 
			' functionsEngineeringItem1
			' 
			Me.functionsEngineeringItem1.Id = 206
			Me.functionsEngineeringItem1.Name = "functionsEngineeringItem1"
			' 
			' functionsInformationItem1
			' 
			Me.functionsInformationItem1.Id = 207
			Me.functionsInformationItem1.Name = "functionsInformationItem1"
			' 
			' functionsCompatibilityItem1
			' 
			Me.functionsCompatibilityItem1.Id = 208
			Me.functionsCompatibilityItem1.Name = "functionsCompatibilityItem1"
			' 
			' functionsWebItem1
			' 
			Me.functionsWebItem1.Id = 209
			Me.functionsWebItem1.Name = "functionsWebItem1"
			' 
			' formulaDefinedNamesRibbonPageGroup1
			' 
			Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem137)
			Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem138)
			Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.definedNameListItem1)
			Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem139)
			Me.formulaDefinedNamesRibbonPageGroup1.Name = "formulaDefinedNamesRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonItem137
			' 
			Me.spreadsheetCommandBarButtonItem137.CommandName = "FormulasShowNameManager"
			Me.spreadsheetCommandBarButtonItem137.Id = 210
			Me.spreadsheetCommandBarButtonItem137.Name = "spreadsheetCommandBarButtonItem137"
			' 
			' spreadsheetCommandBarButtonItem138
			' 
			Me.spreadsheetCommandBarButtonItem138.CommandName = "FormulasDefineNameCommand"
			Me.spreadsheetCommandBarButtonItem138.Id = 211
			Me.spreadsheetCommandBarButtonItem138.Name = "spreadsheetCommandBarButtonItem138"
			Me.spreadsheetCommandBarButtonItem138.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' definedNameListItem1
			' 
			Me.definedNameListItem1.Id = 212
			Me.definedNameListItem1.Name = "definedNameListItem1"
			Me.definedNameListItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem139
			' 
			Me.spreadsheetCommandBarButtonItem139.CommandName = "FormulasCreateDefinedNamesFromSelection"
			Me.spreadsheetCommandBarButtonItem139.Id = 213
			Me.spreadsheetCommandBarButtonItem139.Name = "spreadsheetCommandBarButtonItem139"
			Me.spreadsheetCommandBarButtonItem139.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' formulaAuditingRibbonPageGroup1
			' 
			Me.formulaAuditingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem24)
			Me.formulaAuditingRibbonPageGroup1.Name = "formulaAuditingRibbonPageGroup1"
			' 
			' spreadsheetCommandBarCheckItem24
			' 
			Me.spreadsheetCommandBarCheckItem24.CommandName = "ViewShowFormulas"
			Me.spreadsheetCommandBarCheckItem24.Id = 214
			Me.spreadsheetCommandBarCheckItem24.Name = "spreadsheetCommandBarCheckItem24"
			' 
			' formulaCalculationRibbonPageGroup1
			' 
			Me.formulaCalculationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem24)
			Me.formulaCalculationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem140)
			Me.formulaCalculationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem141)
			Me.formulaCalculationRibbonPageGroup1.Name = "formulaCalculationRibbonPageGroup1"
			' 
			' spreadsheetCommandBarSubItem24
			' 
			Me.spreadsheetCommandBarSubItem24.CommandName = "FormulasCalculationOptionsCommandGroup"
			Me.spreadsheetCommandBarSubItem24.Id = 215
			Me.spreadsheetCommandBarSubItem24.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem26)})
			Me.spreadsheetCommandBarSubItem24.Name = "spreadsheetCommandBarSubItem24"
			' 
			' spreadsheetCommandBarCheckItem25
			' 
			Me.spreadsheetCommandBarCheckItem25.CommandName = "FormulasCalculationModeAutomatic"
			Me.spreadsheetCommandBarCheckItem25.Id = 216
			Me.spreadsheetCommandBarCheckItem25.Name = "spreadsheetCommandBarCheckItem25"
			' 
			' spreadsheetCommandBarCheckItem26
			' 
			Me.spreadsheetCommandBarCheckItem26.CommandName = "FormulasCalculationModeManual"
			Me.spreadsheetCommandBarCheckItem26.Id = 217
			Me.spreadsheetCommandBarCheckItem26.Name = "spreadsheetCommandBarCheckItem26"
			' 
			' spreadsheetCommandBarButtonItem140
			' 
			Me.spreadsheetCommandBarButtonItem140.CommandName = "FormulasCalculateNow"
			Me.spreadsheetCommandBarButtonItem140.Id = 218
			Me.spreadsheetCommandBarButtonItem140.Name = "spreadsheetCommandBarButtonItem140"
			Me.spreadsheetCommandBarButtonItem140.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem141
			' 
			Me.spreadsheetCommandBarButtonItem141.CommandName = "FormulasCalculateSheet"
			Me.spreadsheetCommandBarButtonItem141.Id = 219
			Me.spreadsheetCommandBarButtonItem141.Name = "spreadsheetCommandBarButtonItem141"
			Me.spreadsheetCommandBarButtonItem141.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' sortAndFilterRibbonPageGroup1
			' 
			Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem97)
			Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem98)
			Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem14)
			Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem99)
			Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem100)
			Me.sortAndFilterRibbonPageGroup1.Name = "sortAndFilterRibbonPageGroup1"
			' 
			' dataRibbonPage1
			' 
			Me.dataRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.sortAndFilterRibbonPageGroup1, Me.dataToolsRibbonPageGroup1, Me.outlineRibbonPageGroup1})
			Me.dataRibbonPage1.Name = "dataRibbonPage1"
			' 
			' dataToolsRibbonPageGroup1
			' 
			Me.dataToolsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem25)
			Me.dataToolsRibbonPageGroup1.Name = "dataToolsRibbonPageGroup1"
			' 
			' spreadsheetCommandBarSubItem25
			' 
			Me.spreadsheetCommandBarSubItem25.CommandName = "DataToolsDataValidationCommandGroup"
			Me.spreadsheetCommandBarSubItem25.Id = 220
			Me.spreadsheetCommandBarSubItem25.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem142), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem143), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem144)})
			Me.spreadsheetCommandBarSubItem25.Name = "spreadsheetCommandBarSubItem25"
			' 
			' spreadsheetCommandBarButtonItem142
			' 
			Me.spreadsheetCommandBarButtonItem142.CommandName = "DataToolsDataValidation"
			Me.spreadsheetCommandBarButtonItem142.Id = 221
			Me.spreadsheetCommandBarButtonItem142.Name = "spreadsheetCommandBarButtonItem142"
			' 
			' spreadsheetCommandBarButtonItem143
			' 
			Me.spreadsheetCommandBarButtonItem143.CommandName = "DataToolsCircleInvalidData"
			Me.spreadsheetCommandBarButtonItem143.Id = 222
			Me.spreadsheetCommandBarButtonItem143.Name = "spreadsheetCommandBarButtonItem143"
			' 
			' spreadsheetCommandBarButtonItem144
			' 
			Me.spreadsheetCommandBarButtonItem144.CommandName = "DataToolsClearValidationCircles"
			Me.spreadsheetCommandBarButtonItem144.Id = 223
			Me.spreadsheetCommandBarButtonItem144.Name = "spreadsheetCommandBarButtonItem144"
			' 
			' outlineRibbonPageGroup1
			' 
			Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem26)
			Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem27)
			Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem149)
			Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem150)
			Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem151)
			Me.outlineRibbonPageGroup1.Name = "outlineRibbonPageGroup1"
			' 
			' spreadsheetCommandBarSubItem26
			' 
			Me.spreadsheetCommandBarSubItem26.CommandName = "OutlineGroupCommandGroup"
			Me.spreadsheetCommandBarSubItem26.Id = 224
			Me.spreadsheetCommandBarSubItem26.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem145), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem146)})
			Me.spreadsheetCommandBarSubItem26.Name = "spreadsheetCommandBarSubItem26"
			Me.spreadsheetCommandBarSubItem26.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem145
			' 
			Me.spreadsheetCommandBarButtonItem145.CommandName = "GroupOutline"
			Me.spreadsheetCommandBarButtonItem145.Id = 225
			Me.spreadsheetCommandBarButtonItem145.Name = "spreadsheetCommandBarButtonItem145"
			' 
			' spreadsheetCommandBarButtonItem146
			' 
			Me.spreadsheetCommandBarButtonItem146.CommandName = "AutoOutline"
			Me.spreadsheetCommandBarButtonItem146.Id = 226
			Me.spreadsheetCommandBarButtonItem146.Name = "spreadsheetCommandBarButtonItem146"
			' 
			' spreadsheetCommandBarSubItem27
			' 
			Me.spreadsheetCommandBarSubItem27.CommandName = "OutlineUngroupCommandGroup"
			Me.spreadsheetCommandBarSubItem27.Id = 227
			Me.spreadsheetCommandBarSubItem27.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem147), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem148)})
			Me.spreadsheetCommandBarSubItem27.Name = "spreadsheetCommandBarSubItem27"
			Me.spreadsheetCommandBarSubItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem147
			' 
			Me.spreadsheetCommandBarButtonItem147.CommandName = "UngroupOutline"
			Me.spreadsheetCommandBarButtonItem147.Id = 228
			Me.spreadsheetCommandBarButtonItem147.Name = "spreadsheetCommandBarButtonItem147"
			' 
			' spreadsheetCommandBarButtonItem148
			' 
			Me.spreadsheetCommandBarButtonItem148.CommandName = "ClearOutline"
			Me.spreadsheetCommandBarButtonItem148.Id = 229
			Me.spreadsheetCommandBarButtonItem148.Name = "spreadsheetCommandBarButtonItem148"
			' 
			' spreadsheetCommandBarButtonItem149
			' 
			Me.spreadsheetCommandBarButtonItem149.CommandName = "Subtotal"
			Me.spreadsheetCommandBarButtonItem149.Id = 230
			Me.spreadsheetCommandBarButtonItem149.Name = "spreadsheetCommandBarButtonItem149"
			Me.spreadsheetCommandBarButtonItem149.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem150
			' 
			Me.spreadsheetCommandBarButtonItem150.CommandName = "ShowDetail"
			Me.spreadsheetCommandBarButtonItem150.Id = 231
			Me.spreadsheetCommandBarButtonItem150.Name = "spreadsheetCommandBarButtonItem150"
			Me.spreadsheetCommandBarButtonItem150.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem151
			' 
			Me.spreadsheetCommandBarButtonItem151.CommandName = "HideDetail"
			Me.spreadsheetCommandBarButtonItem151.Id = 232
			Me.spreadsheetCommandBarButtonItem151.Name = "spreadsheetCommandBarButtonItem151"
			Me.spreadsheetCommandBarButtonItem151.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' commentsRibbonPageGroup1
			' 
			Me.commentsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem152)
			Me.commentsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem153)
			Me.commentsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem154)
			Me.commentsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem155)
			Me.commentsRibbonPageGroup1.Name = "commentsRibbonPageGroup1"
			' 
			' reviewRibbonPage1
			' 
			Me.reviewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commentsRibbonPageGroup1, Me.changesRibbonPageGroup1})
			Me.reviewRibbonPage1.Name = "reviewRibbonPage1"
			' 
			' spreadsheetCommandBarButtonItem152
			' 
			Me.spreadsheetCommandBarButtonItem152.CommandName = "ReviewInsertComment"
			Me.spreadsheetCommandBarButtonItem152.Id = 233
			Me.spreadsheetCommandBarButtonItem152.Name = "spreadsheetCommandBarButtonItem152"
			' 
			' spreadsheetCommandBarButtonItem153
			' 
			Me.spreadsheetCommandBarButtonItem153.CommandName = "ReviewEditComment"
			Me.spreadsheetCommandBarButtonItem153.Id = 234
			Me.spreadsheetCommandBarButtonItem153.Name = "spreadsheetCommandBarButtonItem153"
			' 
			' spreadsheetCommandBarButtonItem154
			' 
			Me.spreadsheetCommandBarButtonItem154.CommandName = "ReviewDeleteComment"
			Me.spreadsheetCommandBarButtonItem154.Id = 235
			Me.spreadsheetCommandBarButtonItem154.Name = "spreadsheetCommandBarButtonItem154"
			' 
			' spreadsheetCommandBarButtonItem155
			' 
			Me.spreadsheetCommandBarButtonItem155.CommandName = "ReviewShowHideComment"
			Me.spreadsheetCommandBarButtonItem155.Id = 236
			Me.spreadsheetCommandBarButtonItem155.Name = "spreadsheetCommandBarButtonItem155"
			Me.spreadsheetCommandBarButtonItem155.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' changesRibbonPageGroup1
			' 
			Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem80)
			Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem156)
			Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem157)
			Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem158)
			Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem159)
			Me.changesRibbonPageGroup1.Name = "changesRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonItem156
			' 
			Me.spreadsheetCommandBarButtonItem156.CommandName = "ReviewUnprotectSheet"
			Me.spreadsheetCommandBarButtonItem156.Id = 237
			Me.spreadsheetCommandBarButtonItem156.Name = "spreadsheetCommandBarButtonItem156"
			' 
			' spreadsheetCommandBarButtonItem157
			' 
			Me.spreadsheetCommandBarButtonItem157.CommandName = "ReviewProtectWorkbook"
			Me.spreadsheetCommandBarButtonItem157.Id = 238
			Me.spreadsheetCommandBarButtonItem157.Name = "spreadsheetCommandBarButtonItem157"
			' 
			' spreadsheetCommandBarButtonItem158
			' 
			Me.spreadsheetCommandBarButtonItem158.CommandName = "ReviewUnprotectWorkbook"
			Me.spreadsheetCommandBarButtonItem158.Id = 239
			Me.spreadsheetCommandBarButtonItem158.Name = "spreadsheetCommandBarButtonItem158"
			' 
			' spreadsheetCommandBarButtonItem159
			' 
			Me.spreadsheetCommandBarButtonItem159.CommandName = "ReviewShowProtectedRangeManager"
			Me.spreadsheetCommandBarButtonItem159.Id = 240
			Me.spreadsheetCommandBarButtonItem159.Name = "spreadsheetCommandBarButtonItem159"
			' 
			' showRibbonPageGroup1
			' 
			Me.showRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem20)
			Me.showRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem21)
			Me.showRibbonPageGroup1.Name = "showRibbonPageGroup1"
			' 
			' viewRibbonPage1
			' 
			Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.showRibbonPageGroup1, Me.zoomRibbonPageGroup1, Me.windowRibbonPageGroup1})
			Me.viewRibbonPage1.Name = "viewRibbonPage1"
			' 
			' zoomRibbonPageGroup1
			' 
			Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem160)
			Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem161)
			Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem162)
			Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem163)
			Me.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonItem160
			' 
			Me.spreadsheetCommandBarButtonItem160.CommandName = "ViewZoom"
			Me.spreadsheetCommandBarButtonItem160.Id = 241
			Me.spreadsheetCommandBarButtonItem160.Name = "spreadsheetCommandBarButtonItem160"
			' 
			' spreadsheetCommandBarButtonItem161
			' 
			Me.spreadsheetCommandBarButtonItem161.CommandName = "ViewZoomOut"
			Me.spreadsheetCommandBarButtonItem161.Id = 242
			Me.spreadsheetCommandBarButtonItem161.Name = "spreadsheetCommandBarButtonItem161"
			' 
			' spreadsheetCommandBarButtonItem162
			' 
			Me.spreadsheetCommandBarButtonItem162.CommandName = "ViewZoomIn"
			Me.spreadsheetCommandBarButtonItem162.Id = 243
			Me.spreadsheetCommandBarButtonItem162.Name = "spreadsheetCommandBarButtonItem162"
			' 
			' spreadsheetCommandBarButtonItem163
			' 
			Me.spreadsheetCommandBarButtonItem163.CommandName = "ViewZoom100Percent"
			Me.spreadsheetCommandBarButtonItem163.Id = 244
			Me.spreadsheetCommandBarButtonItem163.Name = "spreadsheetCommandBarButtonItem163"
			' 
			' windowRibbonPageGroup1
			' 
			Me.windowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem28)
			Me.windowRibbonPageGroup1.Name = "windowRibbonPageGroup1"
			' 
			' spreadsheetCommandBarSubItem28
			' 
			Me.spreadsheetCommandBarSubItem28.CommandName = "ViewFreezePanesCommandGroup"
			Me.spreadsheetCommandBarSubItem28.Id = 245
			Me.spreadsheetCommandBarSubItem28.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem164), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem165), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem166), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem167)})
			Me.spreadsheetCommandBarSubItem28.Name = "spreadsheetCommandBarSubItem28"
			' 
			' spreadsheetCommandBarButtonItem164
			' 
			Me.spreadsheetCommandBarButtonItem164.CommandName = "ViewFreezePanes"
			Me.spreadsheetCommandBarButtonItem164.Id = 246
			Me.spreadsheetCommandBarButtonItem164.Name = "spreadsheetCommandBarButtonItem164"
			' 
			' spreadsheetCommandBarButtonItem165
			' 
			Me.spreadsheetCommandBarButtonItem165.CommandName = "ViewUnfreezePanes"
			Me.spreadsheetCommandBarButtonItem165.Id = 247
			Me.spreadsheetCommandBarButtonItem165.Name = "spreadsheetCommandBarButtonItem165"
			' 
			' spreadsheetCommandBarButtonItem166
			' 
			Me.spreadsheetCommandBarButtonItem166.CommandName = "ViewFreezeTopRow"
			Me.spreadsheetCommandBarButtonItem166.Id = 248
			Me.spreadsheetCommandBarButtonItem166.Name = "spreadsheetCommandBarButtonItem166"
			' 
			' spreadsheetCommandBarButtonItem167
			' 
			Me.spreadsheetCommandBarButtonItem167.CommandName = "ViewFreezeFirstColumn"
			Me.spreadsheetCommandBarButtonItem167.Id = 249
			Me.spreadsheetCommandBarButtonItem167.Name = "spreadsheetCommandBarButtonItem167"
			' 
			' chartsDesignTypeRibbonPageGroup1
			' 
			Me.chartsDesignTypeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem168)
			Me.chartsDesignTypeRibbonPageGroup1.Name = "chartsDesignTypeRibbonPageGroup1"
			' 
			' chartsDesignRibbonPage1
			' 
			Me.chartsDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.chartsDesignTypeRibbonPageGroup1, Me.chartsDesignDataRibbonPageGroup1, Me.chartsDesignLayoutsRibbonPageGroup1, Me.chartsDesignStylesRibbonPageGroup1})
			Me.chartsDesignRibbonPage1.Name = "chartsDesignRibbonPage1"
			Me.chartsDesignRibbonPage1.Visible = False
			' 
			' chartToolsRibbonPageCategory1
			' 
			Me.chartToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
			Me.chartToolsRibbonPageCategory1.Name = "chartToolsRibbonPageCategory1"
			Me.chartToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.chartsDesignRibbonPage1, Me.chartsLayoutRibbonPage1, Me.chartsFormatRibbonPage1})
			Me.chartToolsRibbonPageCategory1.Visible = False
			' 
			' spreadsheetCommandBarButtonItem168
			' 
			Me.spreadsheetCommandBarButtonItem168.CommandName = "ChartChangeType"
			Me.spreadsheetCommandBarButtonItem168.Id = 250
			Me.spreadsheetCommandBarButtonItem168.Name = "spreadsheetCommandBarButtonItem168"
			' 
			' chartsDesignDataRibbonPageGroup1
			' 
			Me.chartsDesignDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem169)
			Me.chartsDesignDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem170)
			Me.chartsDesignDataRibbonPageGroup1.Name = "chartsDesignDataRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonItem169
			' 
			Me.spreadsheetCommandBarButtonItem169.CommandName = "ChartSwitchRowColumn"
			Me.spreadsheetCommandBarButtonItem169.Id = 251
			Me.spreadsheetCommandBarButtonItem169.Name = "spreadsheetCommandBarButtonItem169"
			' 
			' spreadsheetCommandBarButtonItem170
			' 
			Me.spreadsheetCommandBarButtonItem170.CommandName = "ChartSelectData"
			Me.spreadsheetCommandBarButtonItem170.Id = 252
			Me.spreadsheetCommandBarButtonItem170.Name = "spreadsheetCommandBarButtonItem170"
			' 
			' chartsDesignLayoutsRibbonPageGroup1
			' 
			Me.chartsDesignLayoutsRibbonPageGroup1.ItemLinks.Add(Me.galleryChartLayoutItem1)
			Me.chartsDesignLayoutsRibbonPageGroup1.Name = "chartsDesignLayoutsRibbonPageGroup1"
			' 
			' galleryChartLayoutItem1
			' 
			' 
			' 
			' 
			Me.galleryChartLayoutItem1.Gallery.ColumnCount = 6
			Me.galleryChartLayoutItem1.Gallery.DrawImageBackground = False
			Me.galleryChartLayoutItem1.Gallery.ImageSize = New System.Drawing.Size(48, 48)
			Me.galleryChartLayoutItem1.Gallery.RowCount = 2
			Me.galleryChartLayoutItem1.Id = 253
			Me.galleryChartLayoutItem1.Name = "galleryChartLayoutItem1"
			' 
			' chartsDesignStylesRibbonPageGroup1
			' 
			Me.chartsDesignStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChartStyleItem1)
			Me.chartsDesignStylesRibbonPageGroup1.Name = "chartsDesignStylesRibbonPageGroup1"
			' 
			' galleryChartStyleItem1
			' 
			' 
			' 
			' 
			Me.galleryChartStyleItem1.Gallery.ColumnCount = 8
			Me.galleryChartStyleItem1.Gallery.DrawImageBackground = False
			Me.galleryChartStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
			Me.galleryChartStyleItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
			Me.galleryChartStyleItem1.Gallery.ItemSize = New System.Drawing.Size(93, 56)
			Me.galleryChartStyleItem1.Gallery.MinimumColumnCount = 4
			Me.galleryChartStyleItem1.Gallery.RowCount = 6
			Me.galleryChartStyleItem1.Id = 254
			Me.galleryChartStyleItem1.Name = "galleryChartStyleItem1"
			' 
			' chartsLayoutAxesRibbonPageGroup1
			' 
			Me.chartsLayoutAxesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem29)
			Me.chartsLayoutAxesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem30)
			Me.chartsLayoutAxesRibbonPageGroup1.Name = "chartsLayoutAxesRibbonPageGroup1"
			' 
			' chartsLayoutRibbonPage1
			' 
			Me.chartsLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.chartsLayoutAxesRibbonPageGroup1, Me.chartsLayoutLabelsRibbonPageGroup1, Me.chartsLayoutAnalysisRibbonPageGroup1})
			Me.chartsLayoutRibbonPage1.Name = "chartsLayoutRibbonPage1"
			Me.chartsLayoutRibbonPage1.Visible = False
			' 
			' spreadsheetCommandBarSubItem29
			' 
			Me.spreadsheetCommandBarSubItem29.CommandName = "ChartAxesCommandGroup"
			Me.spreadsheetCommandBarSubItem29.Id = 255
			Me.spreadsheetCommandBarSubItem29.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem12)})
			Me.spreadsheetCommandBarSubItem29.Name = "spreadsheetCommandBarSubItem29"
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem11
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem11.CommandName = "ChartPrimaryHorizontalAxisCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem11.DropDownControl = Me.commandBarGalleryDropDown61
			Me.spreadsheetCommandBarButtonGalleryDropDownItem11.Id = 256
			Me.spreadsheetCommandBarButtonGalleryDropDownItem11.Name = "spreadsheetCommandBarButtonGalleryDropDownItem11"
			' 
			' commandBarGalleryDropDown61
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown61.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.commandBarGalleryDropDown61.Gallery.ColumnCount = 1
			spreadsheetCommandGalleryItemGroup31.CommandName = "ChartPrimaryHorizontalAxisCommandGroup"
			spreadsheetCommandGalleryItem135.CommandName = "ChartHidePrimaryHorizontalAxis"
			spreadsheetCommandGalleryItem136.CommandName = "ChartPrimaryHorizontalAxisLeftToRight"
			spreadsheetCommandGalleryItem137.CommandName = "ChartPrimaryHorizontalAxisHideLabels"
			spreadsheetCommandGalleryItem138.CommandName = "ChartPrimaryHorizontalAxisRightToLeft"
			spreadsheetCommandGalleryItem139.CommandName = "ChartPrimaryHorizontalAxisDefault"
			spreadsheetCommandGalleryItem140.CommandName = "ChartPrimaryHorizontalAxisScaleThousands"
			spreadsheetCommandGalleryItem141.CommandName = "ChartPrimaryHorizontalAxisScaleMillions"
			spreadsheetCommandGalleryItem142.CommandName = "ChartPrimaryHorizontalAxisScaleBillions"
			spreadsheetCommandGalleryItem143.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm"
			spreadsheetCommandGalleryItemGroup31.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem135, spreadsheetCommandGalleryItem136, spreadsheetCommandGalleryItem137, spreadsheetCommandGalleryItem138, spreadsheetCommandGalleryItem139, spreadsheetCommandGalleryItem140, spreadsheetCommandGalleryItem141, spreadsheetCommandGalleryItem142, spreadsheetCommandGalleryItem143})
			Me.commandBarGalleryDropDown61.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup31})
			Me.commandBarGalleryDropDown61.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown61.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown61.Gallery.RowCount = 9
			Me.commandBarGalleryDropDown61.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown61.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown61.Name = "commandBarGalleryDropDown61"
			Me.commandBarGalleryDropDown61.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem12
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem12.CommandName = "ChartPrimaryVerticalAxisCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem12.DropDownControl = Me.commandBarGalleryDropDown62
			Me.spreadsheetCommandBarButtonGalleryDropDownItem12.Id = 257
			Me.spreadsheetCommandBarButtonGalleryDropDownItem12.Name = "spreadsheetCommandBarButtonGalleryDropDownItem12"
			' 
			' commandBarGalleryDropDown62
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown62.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.commandBarGalleryDropDown62.Gallery.ColumnCount = 1
			spreadsheetCommandGalleryItemGroup32.CommandName = "ChartPrimaryVerticalAxisCommandGroup"
			spreadsheetCommandGalleryItem144.CommandName = "ChartHidePrimaryVerticalAxis"
			spreadsheetCommandGalleryItem145.CommandName = "ChartPrimaryVerticalAxisLeftToRight"
			spreadsheetCommandGalleryItem146.CommandName = "ChartPrimaryVerticalAxisHideLabels"
			spreadsheetCommandGalleryItem147.CommandName = "ChartPrimaryVerticalAxisRightToLeft"
			spreadsheetCommandGalleryItem148.CommandName = "ChartPrimaryVerticalAxisDefault"
			spreadsheetCommandGalleryItem149.CommandName = "ChartPrimaryVerticalAxisScaleThousands"
			spreadsheetCommandGalleryItem150.CommandName = "ChartPrimaryVerticalAxisScaleMillions"
			spreadsheetCommandGalleryItem151.CommandName = "ChartPrimaryVerticalAxisScaleBillions"
			spreadsheetCommandGalleryItem152.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm"
			spreadsheetCommandGalleryItemGroup32.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem144, spreadsheetCommandGalleryItem145, spreadsheetCommandGalleryItem146, spreadsheetCommandGalleryItem147, spreadsheetCommandGalleryItem148, spreadsheetCommandGalleryItem149, spreadsheetCommandGalleryItem150, spreadsheetCommandGalleryItem151, spreadsheetCommandGalleryItem152})
			Me.commandBarGalleryDropDown62.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup32})
			Me.commandBarGalleryDropDown62.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown62.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown62.Gallery.RowCount = 9
			Me.commandBarGalleryDropDown62.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown62.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown62.Name = "commandBarGalleryDropDown62"
			Me.commandBarGalleryDropDown62.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarSubItem30
			' 
			Me.spreadsheetCommandBarSubItem30.CommandName = "ChartGridlinesCommandGroup"
			Me.spreadsheetCommandBarSubItem30.Id = 258
			Me.spreadsheetCommandBarSubItem30.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem14)})
			Me.spreadsheetCommandBarSubItem30.Name = "spreadsheetCommandBarSubItem30"
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem13
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem13.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem13.DropDownControl = Me.commandBarGalleryDropDown63
			Me.spreadsheetCommandBarButtonGalleryDropDownItem13.Id = 259
			Me.spreadsheetCommandBarButtonGalleryDropDownItem13.Name = "spreadsheetCommandBarButtonGalleryDropDownItem13"
			' 
			' commandBarGalleryDropDown63
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown63.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.commandBarGalleryDropDown63.Gallery.ColumnCount = 1
			spreadsheetCommandGalleryItemGroup33.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup"
			spreadsheetCommandGalleryItem153.CommandName = "ChartPrimaryHorizontalGridlinesNone"
			spreadsheetCommandGalleryItem154.CommandName = "ChartPrimaryHorizontalGridlinesMajor"
			spreadsheetCommandGalleryItem155.CommandName = "ChartPrimaryHorizontalGridlinesMinor"
			spreadsheetCommandGalleryItem156.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor"
			spreadsheetCommandGalleryItemGroup33.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem153, spreadsheetCommandGalleryItem154, spreadsheetCommandGalleryItem155, spreadsheetCommandGalleryItem156})
			Me.commandBarGalleryDropDown63.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup33})
			Me.commandBarGalleryDropDown63.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown63.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown63.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown63.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown63.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown63.Name = "commandBarGalleryDropDown63"
			Me.commandBarGalleryDropDown63.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem14
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem14.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem14.DropDownControl = Me.commandBarGalleryDropDown64
			Me.spreadsheetCommandBarButtonGalleryDropDownItem14.Id = 260
			Me.spreadsheetCommandBarButtonGalleryDropDownItem14.Name = "spreadsheetCommandBarButtonGalleryDropDownItem14"
			' 
			' commandBarGalleryDropDown64
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown64.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.commandBarGalleryDropDown64.Gallery.ColumnCount = 1
			spreadsheetCommandGalleryItemGroup34.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup"
			spreadsheetCommandGalleryItem157.CommandName = "ChartPrimaryVerticalGridlinesNone"
			spreadsheetCommandGalleryItem158.CommandName = "ChartPrimaryVerticalGridlinesMajor"
			spreadsheetCommandGalleryItem159.CommandName = "ChartPrimaryVerticalGridlinesMinor"
			spreadsheetCommandGalleryItem160.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor"
			spreadsheetCommandGalleryItemGroup34.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem157, spreadsheetCommandGalleryItem158, spreadsheetCommandGalleryItem159, spreadsheetCommandGalleryItem160})
			Me.commandBarGalleryDropDown64.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup34})
			Me.commandBarGalleryDropDown64.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown64.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown64.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown64.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown64.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown64.Name = "commandBarGalleryDropDown64"
			Me.commandBarGalleryDropDown64.Ribbon = Me.ribbonControl1
			' 
			' chartsLayoutLabelsRibbonPageGroup1
			' 
			Me.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem15)
			Me.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem31)
			Me.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem18)
			Me.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem19)
			Me.chartsLayoutLabelsRibbonPageGroup1.Name = "chartsLayoutLabelsRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem15
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem15.CommandName = "ChartTitleCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem15.DropDownControl = Me.commandBarGalleryDropDown65
			Me.spreadsheetCommandBarButtonGalleryDropDownItem15.Id = 261
			Me.spreadsheetCommandBarButtonGalleryDropDownItem15.Name = "spreadsheetCommandBarButtonGalleryDropDownItem15"
			' 
			' commandBarGalleryDropDown65
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown65.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.commandBarGalleryDropDown65.Gallery.ColumnCount = 1
			spreadsheetCommandGalleryItemGroup35.CommandName = "ChartTitleCommandGroup"
			spreadsheetCommandGalleryItem161.CommandName = "ChartTitleNone"
			spreadsheetCommandGalleryItem162.CommandName = "ChartTitleCenteredOverlay"
			spreadsheetCommandGalleryItem163.CommandName = "ChartTitleAbove"
			spreadsheetCommandGalleryItemGroup35.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem161, spreadsheetCommandGalleryItem162, spreadsheetCommandGalleryItem163})
			Me.commandBarGalleryDropDown65.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup35})
			Me.commandBarGalleryDropDown65.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown65.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown65.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown65.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown65.Name = "commandBarGalleryDropDown65"
			Me.commandBarGalleryDropDown65.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarSubItem31
			' 
			Me.spreadsheetCommandBarSubItem31.CommandName = "ChartAxisTitlesCommandGroup"
			Me.spreadsheetCommandBarSubItem31.Id = 262
			Me.spreadsheetCommandBarSubItem31.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem17)})
			Me.spreadsheetCommandBarSubItem31.Name = "spreadsheetCommandBarSubItem31"
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem16
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem16.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem16.DropDownControl = Me.commandBarGalleryDropDown66
			Me.spreadsheetCommandBarButtonGalleryDropDownItem16.Id = 263
			Me.spreadsheetCommandBarButtonGalleryDropDownItem16.Name = "spreadsheetCommandBarButtonGalleryDropDownItem16"
			' 
			' commandBarGalleryDropDown66
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown66.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.commandBarGalleryDropDown66.Gallery.ColumnCount = 1
			spreadsheetCommandGalleryItemGroup36.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup"
			spreadsheetCommandGalleryItem164.CommandName = "ChartPrimaryHorizontalAxisTitleNone"
			spreadsheetCommandGalleryItem165.CommandName = "ChartPrimaryHorizontalAxisTitleBelow"
			spreadsheetCommandGalleryItemGroup36.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem164, spreadsheetCommandGalleryItem165})
			Me.commandBarGalleryDropDown66.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup36})
			Me.commandBarGalleryDropDown66.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown66.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown66.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown66.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown66.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown66.Name = "commandBarGalleryDropDown66"
			Me.commandBarGalleryDropDown66.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem17
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem17.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem17.DropDownControl = Me.commandBarGalleryDropDown67
			Me.spreadsheetCommandBarButtonGalleryDropDownItem17.Id = 264
			Me.spreadsheetCommandBarButtonGalleryDropDownItem17.Name = "spreadsheetCommandBarButtonGalleryDropDownItem17"
			' 
			' commandBarGalleryDropDown67
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown67.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.commandBarGalleryDropDown67.Gallery.ColumnCount = 1
			spreadsheetCommandGalleryItemGroup37.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup"
			spreadsheetCommandGalleryItem166.CommandName = "ChartPrimaryVerticalAxisTitleNone"
			spreadsheetCommandGalleryItem167.CommandName = "ChartPrimaryVerticalAxisTitleRotated"
			spreadsheetCommandGalleryItem168.CommandName = "ChartPrimaryVerticalAxisTitleVertical"
			spreadsheetCommandGalleryItem169.CommandName = "ChartPrimaryVerticalAxisTitleHorizontal"
			spreadsheetCommandGalleryItemGroup37.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem166, spreadsheetCommandGalleryItem167, spreadsheetCommandGalleryItem168, spreadsheetCommandGalleryItem169})
			Me.commandBarGalleryDropDown67.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup37})
			Me.commandBarGalleryDropDown67.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown67.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown67.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown67.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown67.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown67.Name = "commandBarGalleryDropDown67"
			Me.commandBarGalleryDropDown67.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem18
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem18.CommandName = "ChartLegendCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem18.DropDownControl = Me.commandBarGalleryDropDown68
			Me.spreadsheetCommandBarButtonGalleryDropDownItem18.Id = 265
			Me.spreadsheetCommandBarButtonGalleryDropDownItem18.Name = "spreadsheetCommandBarButtonGalleryDropDownItem18"
			' 
			' commandBarGalleryDropDown68
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown68.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.commandBarGalleryDropDown68.Gallery.ColumnCount = 1
			spreadsheetCommandGalleryItemGroup38.CommandName = "ChartLegendCommandGroup"
			spreadsheetCommandGalleryItem170.CommandName = "ChartLegendNone"
			spreadsheetCommandGalleryItem171.CommandName = "ChartLegendAtRight"
			spreadsheetCommandGalleryItem172.CommandName = "ChartLegendAtTop"
			spreadsheetCommandGalleryItem173.CommandName = "ChartLegendAtLeft"
			spreadsheetCommandGalleryItem174.CommandName = "ChartLegendAtBottom"
			spreadsheetCommandGalleryItem175.CommandName = "ChartLegendOverlayAtRight"
			spreadsheetCommandGalleryItem176.CommandName = "ChartLegendOverlayAtLeft"
			spreadsheetCommandGalleryItemGroup38.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem170, spreadsheetCommandGalleryItem171, spreadsheetCommandGalleryItem172, spreadsheetCommandGalleryItem173, spreadsheetCommandGalleryItem174, spreadsheetCommandGalleryItem175, spreadsheetCommandGalleryItem176})
			Me.commandBarGalleryDropDown68.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup38})
			Me.commandBarGalleryDropDown68.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown68.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown68.Gallery.RowCount = 7
			Me.commandBarGalleryDropDown68.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown68.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown68.Name = "commandBarGalleryDropDown68"
			Me.commandBarGalleryDropDown68.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem19
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem19.CommandName = "ChartDataLabelsCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem19.DropDownControl = Me.commandBarGalleryDropDown69
			Me.spreadsheetCommandBarButtonGalleryDropDownItem19.Id = 266
			Me.spreadsheetCommandBarButtonGalleryDropDownItem19.Name = "spreadsheetCommandBarButtonGalleryDropDownItem19"
			' 
			' commandBarGalleryDropDown69
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown69.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.commandBarGalleryDropDown69.Gallery.ColumnCount = 1
			spreadsheetCommandGalleryItemGroup39.CommandName = "ChartDataLabelsCommandGroup"
			spreadsheetCommandGalleryItem177.CommandName = "ChartDataLabelsNone"
			spreadsheetCommandGalleryItem178.CommandName = "ChartDataLabelsDefault"
			spreadsheetCommandGalleryItem179.CommandName = "ChartDataLabelsCenter"
			spreadsheetCommandGalleryItem180.CommandName = "ChartDataLabelsInsideEnd"
			spreadsheetCommandGalleryItem181.CommandName = "ChartDataLabelsInsideBase"
			spreadsheetCommandGalleryItem182.CommandName = "ChartDataLabelsOutsideEnd"
			spreadsheetCommandGalleryItem183.CommandName = "ChartDataLabelsBestFit"
			spreadsheetCommandGalleryItem184.CommandName = "ChartDataLabelsLeft"
			spreadsheetCommandGalleryItem185.CommandName = "ChartDataLabelsRight"
			spreadsheetCommandGalleryItem186.CommandName = "ChartDataLabelsAbove"
			spreadsheetCommandGalleryItem187.CommandName = "ChartDataLabelsBelow"
			spreadsheetCommandGalleryItemGroup39.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem177, spreadsheetCommandGalleryItem178, spreadsheetCommandGalleryItem179, spreadsheetCommandGalleryItem180, spreadsheetCommandGalleryItem181, spreadsheetCommandGalleryItem182, spreadsheetCommandGalleryItem183, spreadsheetCommandGalleryItem184, spreadsheetCommandGalleryItem185, spreadsheetCommandGalleryItem186, spreadsheetCommandGalleryItem187})
			Me.commandBarGalleryDropDown69.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup39})
			Me.commandBarGalleryDropDown69.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown69.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown69.Gallery.RowCount = 11
			Me.commandBarGalleryDropDown69.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown69.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown69.Name = "commandBarGalleryDropDown69"
			Me.commandBarGalleryDropDown69.Ribbon = Me.ribbonControl1
			' 
			' chartsLayoutAnalysisRibbonPageGroup1
			' 
			Me.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem20)
			Me.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem21)
			Me.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem22)
			Me.chartsLayoutAnalysisRibbonPageGroup1.Name = "chartsLayoutAnalysisRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem20
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem20.CommandName = "ChartLinesCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem20.DropDownControl = Me.commandBarGalleryDropDown70
			Me.spreadsheetCommandBarButtonGalleryDropDownItem20.Id = 267
			Me.spreadsheetCommandBarButtonGalleryDropDownItem20.Name = "spreadsheetCommandBarButtonGalleryDropDownItem20"
			' 
			' commandBarGalleryDropDown70
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown70.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.commandBarGalleryDropDown70.Gallery.ColumnCount = 1
			spreadsheetCommandGalleryItemGroup40.CommandName = "ChartLinesCommandGroup"
			spreadsheetCommandGalleryItem188.CommandName = "ChartLinesNone"
			spreadsheetCommandGalleryItem189.CommandName = "ChartShowDropLines"
			spreadsheetCommandGalleryItem190.CommandName = "ChartShowHighLowLines"
			spreadsheetCommandGalleryItem191.CommandName = "ChartShowDropLinesAndHighLowLines"
			spreadsheetCommandGalleryItem192.CommandName = "ChartShowSeriesLines"
			spreadsheetCommandGalleryItemGroup40.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem188, spreadsheetCommandGalleryItem189, spreadsheetCommandGalleryItem190, spreadsheetCommandGalleryItem191, spreadsheetCommandGalleryItem192})
			Me.commandBarGalleryDropDown70.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup40})
			Me.commandBarGalleryDropDown70.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown70.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown70.Gallery.RowCount = 5
			Me.commandBarGalleryDropDown70.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown70.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown70.Name = "commandBarGalleryDropDown70"
			Me.commandBarGalleryDropDown70.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem21
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem21.CommandName = "ChartUpDownBarsCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem21.DropDownControl = Me.commandBarGalleryDropDown71
			Me.spreadsheetCommandBarButtonGalleryDropDownItem21.Id = 268
			Me.spreadsheetCommandBarButtonGalleryDropDownItem21.Name = "spreadsheetCommandBarButtonGalleryDropDownItem21"
			' 
			' commandBarGalleryDropDown71
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown71.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.commandBarGalleryDropDown71.Gallery.ColumnCount = 1
			spreadsheetCommandGalleryItemGroup41.CommandName = "ChartUpDownBarsCommandGroup"
			spreadsheetCommandGalleryItem193.CommandName = "ChartHideUpDownBars"
			spreadsheetCommandGalleryItem194.CommandName = "ChartShowUpDownBars"
			spreadsheetCommandGalleryItemGroup41.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem193, spreadsheetCommandGalleryItem194})
			Me.commandBarGalleryDropDown71.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup41})
			Me.commandBarGalleryDropDown71.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown71.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown71.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown71.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown71.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown71.Name = "commandBarGalleryDropDown71"
			Me.commandBarGalleryDropDown71.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem22
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem22.CommandName = "ChartErrorBarsCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem22.DropDownControl = Me.commandBarGalleryDropDown72
			Me.spreadsheetCommandBarButtonGalleryDropDownItem22.Id = 269
			Me.spreadsheetCommandBarButtonGalleryDropDownItem22.Name = "spreadsheetCommandBarButtonGalleryDropDownItem22"
			' 
			' commandBarGalleryDropDown72
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown72.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.commandBarGalleryDropDown72.Gallery.ColumnCount = 1
			spreadsheetCommandGalleryItemGroup42.CommandName = "ChartErrorBarsCommandGroup"
			spreadsheetCommandGalleryItem195.CommandName = "ChartErrorBarsNone"
			spreadsheetCommandGalleryItem196.CommandName = "ChartErrorBarsStandardError"
			spreadsheetCommandGalleryItem197.CommandName = "ChartErrorBarsPercentage"
			spreadsheetCommandGalleryItem198.CommandName = "ChartErrorBarsStandardDeviation"
			spreadsheetCommandGalleryItemGroup42.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem195, spreadsheetCommandGalleryItem196, spreadsheetCommandGalleryItem197, spreadsheetCommandGalleryItem198})
			Me.commandBarGalleryDropDown72.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup42})
			Me.commandBarGalleryDropDown72.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown72.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown72.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown72.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown72.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown72.Name = "commandBarGalleryDropDown72"
			Me.commandBarGalleryDropDown72.Ribbon = Me.ribbonControl1
			' 
			' chartsFormatArrangeRibbonPageGroup1
			' 
			Me.chartsFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem20)
			Me.chartsFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem21)
			Me.chartsFormatArrangeRibbonPageGroup1.Name = "chartsFormatArrangeRibbonPageGroup1"
			' 
			' chartsFormatRibbonPage1
			' 
			Me.chartsFormatRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.chartsFormatArrangeRibbonPageGroup1})
			Me.chartsFormatRibbonPage1.Name = "chartsFormatRibbonPage1"
			Me.chartsFormatRibbonPage1.Visible = False
			' 
			' tablePropertiesRibbonPageGroup1
			' 
			Me.tablePropertiesRibbonPageGroup1.ItemLinks.Add(Me.renameTableItemCaption1)
			Me.tablePropertiesRibbonPageGroup1.ItemLinks.Add(Me.renameTableItem1)
			Me.tablePropertiesRibbonPageGroup1.Name = "tablePropertiesRibbonPageGroup1"
			' 
			' tableToolsDesignRibbonPage1
			' 
			Me.tableToolsDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tablePropertiesRibbonPageGroup1, Me.tableToolsRibbonPageGroup1, Me.tableStyleOptionsRibbonPageGroup1, Me.tableStylesRibbonPageGroup1})
			Me.tableToolsDesignRibbonPage1.Name = "tableToolsDesignRibbonPage1"
			Me.tableToolsDesignRibbonPage1.Visible = False
			' 
			' tableToolsRibbonPageCategory1
			' 
			Me.tableToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
			Me.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1"
			Me.tableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.tableToolsDesignRibbonPage1})
			Me.tableToolsRibbonPageCategory1.Visible = False
			' 
			' renameTableItemCaption1
			' 
			Me.renameTableItemCaption1.Caption = "Table Name:"
			Me.renameTableItemCaption1.Id = 270
			Me.renameTableItemCaption1.Name = "renameTableItemCaption1"
			Me.renameTableItemCaption1.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' renameTableItem1
			' 
			Me.renameTableItem1.Edit = Me.repositoryItemTextEdit1
			Me.renameTableItem1.Id = 271
			Me.renameTableItem1.Name = "renameTableItem1"
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' tableToolsRibbonPageGroup1
			' 
			Me.tableToolsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem27)
			Me.tableToolsRibbonPageGroup1.Name = "tableToolsRibbonPageGroup1"
			' 
			' spreadsheetCommandBarCheckItem27
			' 
			Me.spreadsheetCommandBarCheckItem27.CommandName = "TableToolsConvertToRange"
			Me.spreadsheetCommandBarCheckItem27.Id = 272
			Me.spreadsheetCommandBarCheckItem27.Name = "spreadsheetCommandBarCheckItem27"
			Me.spreadsheetCommandBarCheckItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' tableStyleOptionsRibbonPageGroup1
			' 
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem28)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem29)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem30)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem31)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem32)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem33)
			Me.tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1"
			' 
			' spreadsheetCommandBarCheckItem28
			' 
			Me.spreadsheetCommandBarCheckItem28.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem28.CommandName = "TableToolsToggleHeaderRow"
			Me.spreadsheetCommandBarCheckItem28.Id = 273
			Me.spreadsheetCommandBarCheckItem28.Name = "spreadsheetCommandBarCheckItem28"
			' 
			' spreadsheetCommandBarCheckItem29
			' 
			Me.spreadsheetCommandBarCheckItem29.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem29.CommandName = "TableToolsToggleTotalRow"
			Me.spreadsheetCommandBarCheckItem29.Id = 274
			Me.spreadsheetCommandBarCheckItem29.Name = "spreadsheetCommandBarCheckItem29"
			' 
			' spreadsheetCommandBarCheckItem30
			' 
			Me.spreadsheetCommandBarCheckItem30.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem30.CommandName = "TableToolsToggleBandedColumns"
			Me.spreadsheetCommandBarCheckItem30.Id = 275
			Me.spreadsheetCommandBarCheckItem30.Name = "spreadsheetCommandBarCheckItem30"
			' 
			' spreadsheetCommandBarCheckItem31
			' 
			Me.spreadsheetCommandBarCheckItem31.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem31.CommandName = "TableToolsToggleFirstColumn"
			Me.spreadsheetCommandBarCheckItem31.Id = 276
			Me.spreadsheetCommandBarCheckItem31.Name = "spreadsheetCommandBarCheckItem31"
			' 
			' spreadsheetCommandBarCheckItem32
			' 
			Me.spreadsheetCommandBarCheckItem32.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem32.CommandName = "TableToolsToggleLastColumn"
			Me.spreadsheetCommandBarCheckItem32.Id = 277
			Me.spreadsheetCommandBarCheckItem32.Name = "spreadsheetCommandBarCheckItem32"
			' 
			' spreadsheetCommandBarCheckItem33
			' 
			Me.spreadsheetCommandBarCheckItem33.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem33.CommandName = "TableToolsToggleBandedRows"
			Me.spreadsheetCommandBarCheckItem33.Id = 278
			Me.spreadsheetCommandBarCheckItem33.Name = "spreadsheetCommandBarCheckItem33"
			' 
			' tableStylesRibbonPageGroup1
			' 
			Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryTableStylesItem1)
			Me.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1"
			' 
			' galleryTableStylesItem1
			' 
			' 
			' 
			' 
			Me.galleryTableStylesItem1.Gallery.ColumnCount = 7
			Me.galleryTableStylesItem1.Gallery.DrawImageBackground = False
			Me.galleryTableStylesItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
			Me.galleryTableStylesItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
			Me.galleryTableStylesItem1.Gallery.ItemSize = New System.Drawing.Size(73, 58)
			Me.galleryTableStylesItem1.Gallery.RowCount = 10
			Me.galleryTableStylesItem1.Id = 279
			Me.galleryTableStylesItem1.Name = "galleryTableStylesItem1"
			' 
			' drawingFormatArrangeRibbonPageGroup1
			' 
			Me.drawingFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem20)
			Me.drawingFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem21)
			Me.drawingFormatArrangeRibbonPageGroup1.Name = "drawingFormatArrangeRibbonPageGroup1"
			' 
			' drawingFormatRibbonPage1
			' 
			Me.drawingFormatRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.drawingFormatArrangeRibbonPageGroup1})
			Me.drawingFormatRibbonPage1.Name = "drawingFormatRibbonPage1"
			Me.drawingFormatRibbonPage1.Visible = False
			' 
			' drawingToolsRibbonPageCategory1
			' 
			Me.drawingToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
			Me.drawingToolsRibbonPageCategory1.Name = "drawingToolsRibbonPageCategory1"
			Me.drawingToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.drawingFormatRibbonPage1})
			Me.drawingToolsRibbonPageCategory1.Visible = False
			' 
			' pictureFormatArrangeRibbonPageGroup1
			' 
			Me.pictureFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem20)
			Me.pictureFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem21)
			Me.pictureFormatArrangeRibbonPageGroup1.Name = "pictureFormatArrangeRibbonPageGroup1"
			' 
			' pictureFormatRibbonPage1
			' 
			Me.pictureFormatRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pictureFormatArrangeRibbonPageGroup1})
			Me.pictureFormatRibbonPage1.Name = "pictureFormatRibbonPage1"
			Me.pictureFormatRibbonPage1.Visible = False
			' 
			' pictureToolsRibbonPageCategory1
			' 
			Me.pictureToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
			Me.pictureToolsRibbonPageCategory1.Name = "pictureToolsRibbonPageCategory1"
			Me.pictureToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.pictureFormatRibbonPage1})
			Me.pictureToolsRibbonPageCategory1.Visible = False
			' 
			' pivotTableAnalyzePivotTableRibbonPageGroup1
			' 
			Me.pivotTableAnalyzePivotTableRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem171)
			Me.pivotTableAnalyzePivotTableRibbonPageGroup1.Name = "pivotTableAnalyzePivotTableRibbonPageGroup1"
			' 
			' pivotTableAnalyzeRibbonPage1
			' 
			Me.pivotTableAnalyzeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pivotTableAnalyzePivotTableRibbonPageGroup1, Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1, Me.pivotTableAnalyzeGroupRibbonPageGroup1, Me.pivotTableAnalyzeDataRibbonPageGroup1, Me.pivotTableAnalyzeActionsRibbonPageGroup1, Me.pivotTableAnalyzeCalculationsRibbonPageGroup1, Me.pivotTableAnalyzeShowRibbonPageGroup1})
			Me.pivotTableAnalyzeRibbonPage1.Name = "pivotTableAnalyzeRibbonPage1"
			Me.pivotTableAnalyzeRibbonPage1.Visible = False
			' 
			' pivotTableToolsRibbonPageCategory1
			' 
			Me.pivotTableToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
			Me.pivotTableToolsRibbonPageCategory1.Name = "pivotTableToolsRibbonPageCategory1"
			Me.pivotTableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.pivotTableAnalyzeRibbonPage1, Me.pivotTableDesignRibbonPage1})
			Me.pivotTableToolsRibbonPageCategory1.Visible = False
			' 
			' spreadsheetCommandBarButtonItem171
			' 
			Me.spreadsheetCommandBarButtonItem171.CommandName = "OptionsPivotTable"
			Me.spreadsheetCommandBarButtonItem171.Id = 280
			Me.spreadsheetCommandBarButtonItem171.Name = "spreadsheetCommandBarButtonItem171"
			' 
			' pivotTableAnalyzeActiveFieldRibbonPageGroup1
			' 
			Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem172)
			Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem173)
			Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem174)
			Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1.Name = "pivotTableAnalyzeActiveFieldRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonItem172
			' 
			Me.spreadsheetCommandBarButtonItem172.CommandName = "SelectFieldTypePivotTable"
			Me.spreadsheetCommandBarButtonItem172.Id = 281
			Me.spreadsheetCommandBarButtonItem172.Name = "spreadsheetCommandBarButtonItem172"
			' 
			' spreadsheetCommandBarButtonItem173
			' 
			Me.spreadsheetCommandBarButtonItem173.CommandName = "PivotTableExpandField"
			Me.spreadsheetCommandBarButtonItem173.Id = 282
			Me.spreadsheetCommandBarButtonItem173.Name = "spreadsheetCommandBarButtonItem173"
			Me.spreadsheetCommandBarButtonItem173.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem174
			' 
			Me.spreadsheetCommandBarButtonItem174.CommandName = "PivotTableCollapseField"
			Me.spreadsheetCommandBarButtonItem174.Id = 283
			Me.spreadsheetCommandBarButtonItem174.Name = "spreadsheetCommandBarButtonItem174"
			Me.spreadsheetCommandBarButtonItem174.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' pivotTableAnalyzeGroupRibbonPageGroup1
			' 
			Me.pivotTableAnalyzeGroupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem175)
			Me.pivotTableAnalyzeGroupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem176)
			Me.pivotTableAnalyzeGroupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem177)
			Me.pivotTableAnalyzeGroupRibbonPageGroup1.Name = "pivotTableAnalyzeGroupRibbonPageGroup1"
			' 
			' spreadsheetCommandBarButtonItem175
			' 
			Me.spreadsheetCommandBarButtonItem175.CommandName = "PivotTableGroupSelection"
			Me.spreadsheetCommandBarButtonItem175.Id = 284
			Me.spreadsheetCommandBarButtonItem175.Name = "spreadsheetCommandBarButtonItem175"
			Me.spreadsheetCommandBarButtonItem175.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem176
			' 
			Me.spreadsheetCommandBarButtonItem176.CommandName = "PivotTableUngroup"
			Me.spreadsheetCommandBarButtonItem176.Id = 285
			Me.spreadsheetCommandBarButtonItem176.Name = "spreadsheetCommandBarButtonItem176"
			Me.spreadsheetCommandBarButtonItem176.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem177
			' 
			Me.spreadsheetCommandBarButtonItem177.CommandName = "PivotTableGroupField"
			Me.spreadsheetCommandBarButtonItem177.Id = 286
			Me.spreadsheetCommandBarButtonItem177.Name = "spreadsheetCommandBarButtonItem177"
			Me.spreadsheetCommandBarButtonItem177.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' pivotTableAnalyzeDataRibbonPageGroup1
			' 
			Me.pivotTableAnalyzeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem32)
			Me.pivotTableAnalyzeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem180)
			Me.pivotTableAnalyzeDataRibbonPageGroup1.Name = "pivotTableAnalyzeDataRibbonPageGroup1"
			' 
			' spreadsheetCommandBarSubItem32
			' 
			Me.spreadsheetCommandBarSubItem32.CommandName = "PivotTableDataRefreshGroup"
			Me.spreadsheetCommandBarSubItem32.Id = 287
			Me.spreadsheetCommandBarSubItem32.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem178), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem179)})
			Me.spreadsheetCommandBarSubItem32.Name = "spreadsheetCommandBarSubItem32"
			' 
			' spreadsheetCommandBarButtonItem178
			' 
			Me.spreadsheetCommandBarButtonItem178.CommandName = "RefreshPivotTable"
			Me.spreadsheetCommandBarButtonItem178.Id = 288
			Me.spreadsheetCommandBarButtonItem178.Name = "spreadsheetCommandBarButtonItem178"
			' 
			' spreadsheetCommandBarButtonItem179
			' 
			Me.spreadsheetCommandBarButtonItem179.CommandName = "RefreshAllPivotTable"
			Me.spreadsheetCommandBarButtonItem179.Id = 289
			Me.spreadsheetCommandBarButtonItem179.Name = "spreadsheetCommandBarButtonItem179"
			' 
			' spreadsheetCommandBarButtonItem180
			' 
			Me.spreadsheetCommandBarButtonItem180.CommandName = "ChangeDataSourcePivotTable"
			Me.spreadsheetCommandBarButtonItem180.Id = 290
			Me.spreadsheetCommandBarButtonItem180.Name = "spreadsheetCommandBarButtonItem180"
			' 
			' pivotTableAnalyzeActionsRibbonPageGroup1
			' 
			Me.pivotTableAnalyzeActionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem33)
			Me.pivotTableAnalyzeActionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem34)
			Me.pivotTableAnalyzeActionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem186)
			Me.pivotTableAnalyzeActionsRibbonPageGroup1.Name = "pivotTableAnalyzeActionsRibbonPageGroup1"
			' 
			' spreadsheetCommandBarSubItem33
			' 
			Me.spreadsheetCommandBarSubItem33.CommandName = "PivotTableActionsClearGroup"
			Me.spreadsheetCommandBarSubItem33.Id = 291
			Me.spreadsheetCommandBarSubItem33.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem181), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem182)})
			Me.spreadsheetCommandBarSubItem33.Name = "spreadsheetCommandBarSubItem33"
			' 
			' spreadsheetCommandBarButtonItem181
			' 
			Me.spreadsheetCommandBarButtonItem181.CommandName = "ClearAllPivotTable"
			Me.spreadsheetCommandBarButtonItem181.Id = 292
			Me.spreadsheetCommandBarButtonItem181.Name = "spreadsheetCommandBarButtonItem181"
			' 
			' spreadsheetCommandBarButtonItem182
			' 
			Me.spreadsheetCommandBarButtonItem182.CommandName = "ClearFiltersPivotTable"
			Me.spreadsheetCommandBarButtonItem182.Id = 293
			Me.spreadsheetCommandBarButtonItem182.Name = "spreadsheetCommandBarButtonItem182"
			' 
			' spreadsheetCommandBarSubItem34
			' 
			Me.spreadsheetCommandBarSubItem34.CommandName = "PivotTableActionsSelectGroup"
			Me.spreadsheetCommandBarSubItem34.Id = 294
			Me.spreadsheetCommandBarSubItem34.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem183), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem184), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem185)})
			Me.spreadsheetCommandBarSubItem34.Name = "spreadsheetCommandBarSubItem34"
			' 
			' spreadsheetCommandBarButtonItem183
			' 
			Me.spreadsheetCommandBarButtonItem183.CommandName = "SelectValuesPivotTable"
			Me.spreadsheetCommandBarButtonItem183.Id = 295
			Me.spreadsheetCommandBarButtonItem183.Name = "spreadsheetCommandBarButtonItem183"
			' 
			' spreadsheetCommandBarButtonItem184
			' 
			Me.spreadsheetCommandBarButtonItem184.CommandName = "SelectLabelsPivotTable"
			Me.spreadsheetCommandBarButtonItem184.Id = 296
			Me.spreadsheetCommandBarButtonItem184.Name = "spreadsheetCommandBarButtonItem184"
			' 
			' spreadsheetCommandBarButtonItem185
			' 
			Me.spreadsheetCommandBarButtonItem185.CommandName = "SelectEntirePivotTable"
			Me.spreadsheetCommandBarButtonItem185.Id = 297
			Me.spreadsheetCommandBarButtonItem185.Name = "spreadsheetCommandBarButtonItem185"
			' 
			' spreadsheetCommandBarButtonItem186
			' 
			Me.spreadsheetCommandBarButtonItem186.CommandName = "MovePivotTable"
			Me.spreadsheetCommandBarButtonItem186.Id = 298
			Me.spreadsheetCommandBarButtonItem186.Name = "spreadsheetCommandBarButtonItem186"
			' 
			' pivotTableAnalyzeCalculationsRibbonPageGroup1
			' 
			Me.pivotTableAnalyzeCalculationsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem35)
			Me.pivotTableAnalyzeCalculationsRibbonPageGroup1.Name = "pivotTableAnalyzeCalculationsRibbonPageGroup1"
			' 
			' spreadsheetCommandBarSubItem35
			' 
			Me.spreadsheetCommandBarSubItem35.CommandName = "PivotTableCalculationFieldsItemsSetsGroup"
			Me.spreadsheetCommandBarSubItem35.Id = 299
			Me.spreadsheetCommandBarSubItem35.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem187), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem188), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem189), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem190)})
			Me.spreadsheetCommandBarSubItem35.Name = "spreadsheetCommandBarSubItem35"
			' 
			' spreadsheetCommandBarButtonItem187
			' 
			Me.spreadsheetCommandBarButtonItem187.CommandName = "PivotTableCalculatedField"
			Me.spreadsheetCommandBarButtonItem187.Id = 300
			Me.spreadsheetCommandBarButtonItem187.Name = "spreadsheetCommandBarButtonItem187"
			' 
			' spreadsheetCommandBarButtonItem188
			' 
			Me.spreadsheetCommandBarButtonItem188.CommandName = "PivotTableCalculatedItem"
			Me.spreadsheetCommandBarButtonItem188.Id = 301
			Me.spreadsheetCommandBarButtonItem188.Name = "spreadsheetCommandBarButtonItem188"
			' 
			' spreadsheetCommandBarButtonItem189
			' 
			Me.spreadsheetCommandBarButtonItem189.CommandName = "PivotTableCalculatedItemSolveOrder"
			Me.spreadsheetCommandBarButtonItem189.Id = 302
			Me.spreadsheetCommandBarButtonItem189.Name = "spreadsheetCommandBarButtonItem189"
			' 
			' spreadsheetCommandBarButtonItem190
			' 
			Me.spreadsheetCommandBarButtonItem190.CommandName = "PivotTableListFormulas"
			Me.spreadsheetCommandBarButtonItem190.Id = 303
			Me.spreadsheetCommandBarButtonItem190.Name = "spreadsheetCommandBarButtonItem190"
			' 
			' pivotTableAnalyzeShowRibbonPageGroup1
			' 
			Me.pivotTableAnalyzeShowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem34)
			Me.pivotTableAnalyzeShowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem35)
			Me.pivotTableAnalyzeShowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem36)
			Me.pivotTableAnalyzeShowRibbonPageGroup1.Name = "pivotTableAnalyzeShowRibbonPageGroup1"
			' 
			' spreadsheetCommandBarCheckItem34
			' 
			Me.spreadsheetCommandBarCheckItem34.CommandName = "FieldListPanelPivotTable"
			Me.spreadsheetCommandBarCheckItem34.Id = 304
			Me.spreadsheetCommandBarCheckItem34.Name = "spreadsheetCommandBarCheckItem34"
			' 
			' spreadsheetCommandBarCheckItem35
			' 
			Me.spreadsheetCommandBarCheckItem35.CommandName = "ShowPivotTableExpandCollapseButtons"
			Me.spreadsheetCommandBarCheckItem35.Id = 305
			Me.spreadsheetCommandBarCheckItem35.Name = "spreadsheetCommandBarCheckItem35"
			' 
			' spreadsheetCommandBarCheckItem36
			' 
			Me.spreadsheetCommandBarCheckItem36.CommandName = "ShowPivotTableFieldHeaders"
			Me.spreadsheetCommandBarCheckItem36.Id = 306
			Me.spreadsheetCommandBarCheckItem36.Name = "spreadsheetCommandBarCheckItem36"
			' 
			' pivotTableDesignLayoutRibbonPageGroup1
			' 
			Me.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem36)
			Me.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem37)
			Me.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem38)
			Me.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem39)
			Me.pivotTableDesignLayoutRibbonPageGroup1.Name = "pivotTableDesignLayoutRibbonPageGroup1"
			' 
			' pivotTableDesignRibbonPage1
			' 
			Me.pivotTableDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pivotTableDesignLayoutRibbonPageGroup1, Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1, Me.pivotTableDesignPivotTableStylesRibbonPageGroup1})
			Me.pivotTableDesignRibbonPage1.Name = "pivotTableDesignRibbonPage1"
			Me.pivotTableDesignRibbonPage1.Visible = False
			' 
			' spreadsheetCommandBarSubItem36
			' 
			Me.spreadsheetCommandBarSubItem36.CommandName = "PivotTableLayoutSubtotalsGroup"
			Me.spreadsheetCommandBarSubItem36.Id = 307
			Me.spreadsheetCommandBarSubItem36.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem191), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem192), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem193)})
			Me.spreadsheetCommandBarSubItem36.Name = "spreadsheetCommandBarSubItem36"
			' 
			' spreadsheetCommandBarButtonItem191
			' 
			Me.spreadsheetCommandBarButtonItem191.CommandName = "PivotTableDoNotShowSubtotals"
			Me.spreadsheetCommandBarButtonItem191.Id = 308
			Me.spreadsheetCommandBarButtonItem191.Name = "spreadsheetCommandBarButtonItem191"
			Me.spreadsheetCommandBarButtonItem191.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem192
			' 
			Me.spreadsheetCommandBarButtonItem192.CommandName = "PivotTableShowAllSubtotalsAtBottom"
			Me.spreadsheetCommandBarButtonItem192.Id = 309
			Me.spreadsheetCommandBarButtonItem192.Name = "spreadsheetCommandBarButtonItem192"
			Me.spreadsheetCommandBarButtonItem192.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem193
			' 
			Me.spreadsheetCommandBarButtonItem193.CommandName = "PivotTableShowAllSubtotalsAtTop"
			Me.spreadsheetCommandBarButtonItem193.Id = 310
			Me.spreadsheetCommandBarButtonItem193.Name = "spreadsheetCommandBarButtonItem193"
			Me.spreadsheetCommandBarButtonItem193.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarSubItem37
			' 
			Me.spreadsheetCommandBarSubItem37.CommandName = "PivotTableLayoutGrandTotalsGroup"
			Me.spreadsheetCommandBarSubItem37.Id = 311
			Me.spreadsheetCommandBarSubItem37.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem194), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem195), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem196), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem197)})
			Me.spreadsheetCommandBarSubItem37.Name = "spreadsheetCommandBarSubItem37"
			' 
			' spreadsheetCommandBarButtonItem194
			' 
			Me.spreadsheetCommandBarButtonItem194.CommandName = "PivotTableGrandTotalsOffRowsColumns"
			Me.spreadsheetCommandBarButtonItem194.Id = 312
			Me.spreadsheetCommandBarButtonItem194.Name = "spreadsheetCommandBarButtonItem194"
			Me.spreadsheetCommandBarButtonItem194.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem195
			' 
			Me.spreadsheetCommandBarButtonItem195.CommandName = "PivotTableGrandTotalsOnRowsColumns"
			Me.spreadsheetCommandBarButtonItem195.Id = 313
			Me.spreadsheetCommandBarButtonItem195.Name = "spreadsheetCommandBarButtonItem195"
			Me.spreadsheetCommandBarButtonItem195.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem196
			' 
			Me.spreadsheetCommandBarButtonItem196.CommandName = "PivotTableGrandTotalsOnRowsOnly"
			Me.spreadsheetCommandBarButtonItem196.Id = 314
			Me.spreadsheetCommandBarButtonItem196.Name = "spreadsheetCommandBarButtonItem196"
			Me.spreadsheetCommandBarButtonItem196.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem197
			' 
			Me.spreadsheetCommandBarButtonItem197.CommandName = "PivotTableGrandTotalsOnColumnsOnly"
			Me.spreadsheetCommandBarButtonItem197.Id = 315
			Me.spreadsheetCommandBarButtonItem197.Name = "spreadsheetCommandBarButtonItem197"
			Me.spreadsheetCommandBarButtonItem197.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarSubItem38
			' 
			Me.spreadsheetCommandBarSubItem38.CommandName = "PivotTableLayoutReportLayoutGroup"
			Me.spreadsheetCommandBarSubItem38.Id = 316
			Me.spreadsheetCommandBarSubItem38.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem198), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem199), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem200), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem201), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem202)})
			Me.spreadsheetCommandBarSubItem38.Name = "spreadsheetCommandBarSubItem38"
			' 
			' spreadsheetCommandBarButtonItem198
			' 
			Me.spreadsheetCommandBarButtonItem198.CommandName = "PivotTableShowCompactForm"
			Me.spreadsheetCommandBarButtonItem198.Id = 317
			Me.spreadsheetCommandBarButtonItem198.Name = "spreadsheetCommandBarButtonItem198"
			Me.spreadsheetCommandBarButtonItem198.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem199
			' 
			Me.spreadsheetCommandBarButtonItem199.CommandName = "PivotTableShowOutlineForm"
			Me.spreadsheetCommandBarButtonItem199.Id = 318
			Me.spreadsheetCommandBarButtonItem199.Name = "spreadsheetCommandBarButtonItem199"
			Me.spreadsheetCommandBarButtonItem199.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem200
			' 
			Me.spreadsheetCommandBarButtonItem200.CommandName = "PivotTableShowTabularForm"
			Me.spreadsheetCommandBarButtonItem200.Id = 319
			Me.spreadsheetCommandBarButtonItem200.Name = "spreadsheetCommandBarButtonItem200"
			Me.spreadsheetCommandBarButtonItem200.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem201
			' 
			Me.spreadsheetCommandBarButtonItem201.CommandName = "PivotTableRepeatAllItemLabels"
			Me.spreadsheetCommandBarButtonItem201.Id = 320
			Me.spreadsheetCommandBarButtonItem201.Name = "spreadsheetCommandBarButtonItem201"
			Me.spreadsheetCommandBarButtonItem201.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem202
			' 
			Me.spreadsheetCommandBarButtonItem202.CommandName = "PivotTableDoNotRepeatItemLabels"
			Me.spreadsheetCommandBarButtonItem202.Id = 321
			Me.spreadsheetCommandBarButtonItem202.Name = "spreadsheetCommandBarButtonItem202"
			Me.spreadsheetCommandBarButtonItem202.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarSubItem39
			' 
			Me.spreadsheetCommandBarSubItem39.CommandName = "PivotTableLayoutBlankRowsGroup"
			Me.spreadsheetCommandBarSubItem39.Id = 322
			Me.spreadsheetCommandBarSubItem39.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem203), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem204)})
			Me.spreadsheetCommandBarSubItem39.Name = "spreadsheetCommandBarSubItem39"
			' 
			' spreadsheetCommandBarButtonItem203
			' 
			Me.spreadsheetCommandBarButtonItem203.CommandName = "PivotTableInsertBlankLineEachItem"
			Me.spreadsheetCommandBarButtonItem203.Id = 323
			Me.spreadsheetCommandBarButtonItem203.Name = "spreadsheetCommandBarButtonItem203"
			Me.spreadsheetCommandBarButtonItem203.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem204
			' 
			Me.spreadsheetCommandBarButtonItem204.CommandName = "PivotTableRemoveBlankLineEachItem"
			Me.spreadsheetCommandBarButtonItem204.Id = 324
			Me.spreadsheetCommandBarButtonItem204.Name = "spreadsheetCommandBarButtonItem204"
			Me.spreadsheetCommandBarButtonItem204.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1
			' 
			Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem37)
			Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem38)
			Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem39)
			Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem40)
			Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows
			Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.Name = "pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1"
			' 
			' spreadsheetCommandBarCheckItem37
			' 
			Me.spreadsheetCommandBarCheckItem37.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem37.CommandName = "PivotTableToggleRowHeaders"
			Me.spreadsheetCommandBarCheckItem37.Id = 325
			Me.spreadsheetCommandBarCheckItem37.Name = "spreadsheetCommandBarCheckItem37"
			' 
			' spreadsheetCommandBarCheckItem38
			' 
			Me.spreadsheetCommandBarCheckItem38.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem38.CommandName = "PivotTableToggleColumnHeaders"
			Me.spreadsheetCommandBarCheckItem38.Id = 326
			Me.spreadsheetCommandBarCheckItem38.Name = "spreadsheetCommandBarCheckItem38"
			' 
			' spreadsheetCommandBarCheckItem39
			' 
			Me.spreadsheetCommandBarCheckItem39.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem39.CommandName = "PivotTableToggleBandedRows"
			Me.spreadsheetCommandBarCheckItem39.Id = 327
			Me.spreadsheetCommandBarCheckItem39.Name = "spreadsheetCommandBarCheckItem39"
			' 
			' spreadsheetCommandBarCheckItem40
			' 
			Me.spreadsheetCommandBarCheckItem40.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem40.CommandName = "PivotTableToggleBandedColumns"
			Me.spreadsheetCommandBarCheckItem40.Id = 328
			Me.spreadsheetCommandBarCheckItem40.Name = "spreadsheetCommandBarCheckItem40"
			' 
			' pivotTableDesignPivotTableStylesRibbonPageGroup1
			' 
			Me.pivotTableDesignPivotTableStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryPivotStylesItem1)
			Me.pivotTableDesignPivotTableStylesRibbonPageGroup1.Name = "pivotTableDesignPivotTableStylesRibbonPageGroup1"
			' 
			' galleryPivotStylesItem1
			' 
			' 
			' 
			' 
			Me.galleryPivotStylesItem1.Gallery.ColumnCount = 7
			Me.galleryPivotStylesItem1.Gallery.DrawImageBackground = False
			Me.galleryPivotStylesItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
			Me.galleryPivotStylesItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
			Me.galleryPivotStylesItem1.Gallery.ItemSize = New System.Drawing.Size(73, 61)
			Me.galleryPivotStylesItem1.Gallery.RowCount = 10
			Me.galleryPivotStylesItem1.Id = 329
			Me.galleryPivotStylesItem1.Name = "galleryPivotStylesItem1"
			' 
			' InvoiceWithTotalModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.mainTabControl)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "InvoiceWithTotalModule"
			Me.Size = New System.Drawing.Size(696, 478)
'			Me.Load += New System.EventHandler(Me.On_Load);
			CType(Me.commandBarGalleryDropDown26, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown25, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown27, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown28, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown29, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown30, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown31, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown32, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown33, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown34, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown35, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown36, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown37, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown38, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown39, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown40, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown41, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown42, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown43, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown44, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown45, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown46, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown47, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown48, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown14, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown16, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown17, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown18, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown19, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown20, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown21, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown22, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown23, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown24, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fromFaxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fromPhoneEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fromZipEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fromStateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fromCityEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fromAddressEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fromCompanySloganEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fromCompanyEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toCompanyNameEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toPhoneEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toZipEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toStateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toCityEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toStreetEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toNameEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mainTabControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mainTabControl.ResumeLayout(False)
			Me.invoiceTabPage.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dataTabPage.ResumeLayout(False)
			CType(Me.toGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toGroupControl.ResumeLayout(False)
			Me.toGroupControl.PerformLayout()
			CType(Me.fromGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.fromGroupControl.ResumeLayout(False)
			Me.fromGroupControl.PerformLayout()
			CType(Me.fromContactNameEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fromEMailEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.includeItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown49, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpreadsheetFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPopupGalleryEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown50, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown51, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown52, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown53, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown54, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown55, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown56, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown57, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown58, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown59, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown60, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown61, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown62, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown63, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown64, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown65, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown66, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown67, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown68, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown69, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown70, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown71, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown72, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents includeItemCheckEdit As XtraEditors.Repository.RepositoryItemCheckEdit
		Private toGroupControl As GroupControl
		Private fromGroupControl As GroupControl
		Private colQuantity As XtraGrid.Columns.GridColumn
		Private colDiscount As XtraGrid.Columns.GridColumn
		Private fromContactNameLabel As LabelControl
		Private fromContactNameEdit As TextEdit
		Private fromEMailLabel As LabelControl
		Private fromEMailEdit As TextEdit
		Private splitterControl1 As SplitterControl
		Private splitContainerControl1 As SplitContainerControl
		Private spreadsheetNameBoxControl1 As SpreadsheetNameBoxControl
		Private spreadsheetFormulaBarControl1 As SpreadsheetFormulaBarControl
		Private spreadsheetBarController1 As UI.SpreadsheetBarController
		Private commandBarGalleryDropDown1 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown2 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown3 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown4 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown5 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown6 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown7 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown8 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown9 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown10 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown11 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown12 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown13 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown14 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown15 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown16 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown17 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown18 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown19 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown20 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown21 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown22 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown23 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown24 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonItem107 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem108 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem109 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem110 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem111 As UI.SpreadsheetCommandBarButtonItem
		Private commandBarGalleryDropDown25 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown26 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown27 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown28 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown29 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown30 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown31 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown32 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown33 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown34 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown35 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown36 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown37 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown38 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown39 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown40 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown41 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown42 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown43 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown44 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown45 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown46 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown47 As XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown48 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonItem119 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem120 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem121 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem122 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem123 As UI.SpreadsheetCommandBarButtonItem
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private spreadsheetCommandBarButtonItem1 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem2 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem3 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem4 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem5 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem6 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem7 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem8 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem9 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem10 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem11 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem12 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem13 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem14 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem15 As UI.SpreadsheetCommandBarButtonItem
		Private barButtonGroup1 As XtraBars.BarButtonGroup
		Private changeFontNameItem1 As UI.ChangeFontNameItem
		Private repositoryItemFontEdit1 As XtraEditors.Repository.RepositoryItemFontEdit
		Private changeFontSizeItem1 As UI.ChangeFontSizeItem
		Private repositoryItemSpreadsheetFontSizeEdit1 As Design.RepositoryItemSpreadsheetFontSizeEdit
		Private spreadsheetCommandBarButtonItem16 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem17 As UI.SpreadsheetCommandBarButtonItem
		Private barButtonGroup2 As XtraBars.BarButtonGroup
		Private spreadsheetCommandBarCheckItem1 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem2 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem3 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem4 As UI.SpreadsheetCommandBarCheckItem
		Private barButtonGroup3 As XtraBars.BarButtonGroup
		Private spreadsheetCommandBarSubItem1 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem18 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem19 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem20 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem21 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem22 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem23 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem24 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem25 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem26 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem27 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem28 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem29 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem30 As UI.SpreadsheetCommandBarButtonItem
		Private changeBorderLineColorItem1 As UI.ChangeBorderLineColorItem
		Private changeBorderLineStyleItem1 As UI.ChangeBorderLineStyleItem
		Private commandBarGalleryDropDown49 As XtraBars.Commands.CommandBarGalleryDropDown
		Private barButtonGroup4 As XtraBars.BarButtonGroup
		Private changeCellFillColorItem1 As UI.ChangeCellFillColorItem
		Private changeFontColorItem1 As UI.ChangeFontColorItem
		Private barButtonGroup5 As XtraBars.BarButtonGroup
		Private spreadsheetCommandBarCheckItem5 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem6 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem7 As UI.SpreadsheetCommandBarCheckItem
		Private barButtonGroup6 As XtraBars.BarButtonGroup
		Private spreadsheetCommandBarCheckItem8 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem9 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem10 As UI.SpreadsheetCommandBarCheckItem
		Private barButtonGroup7 As XtraBars.BarButtonGroup
		Private spreadsheetCommandBarButtonItem31 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem32 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarCheckItem11 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarSubItem2 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarCheckItem12 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarButtonItem33 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem34 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem35 As UI.SpreadsheetCommandBarButtonItem
		Private barButtonGroup8 As XtraBars.BarButtonGroup
		Private changeNumberFormatItem1 As UI.ChangeNumberFormatItem
		Private repositoryItemPopupGalleryEdit1 As XtraEditors.Repository.RepositoryItemPopupGalleryEdit
		Private barButtonGroup9 As XtraBars.BarButtonGroup
		Private spreadsheetCommandBarSubItem3 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem36 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem37 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem38 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem39 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem40 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem41 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem42 As UI.SpreadsheetCommandBarButtonItem
		Private barButtonGroup10 As XtraBars.BarButtonGroup
		Private spreadsheetCommandBarButtonItem43 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem44 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem4 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarSubItem5 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem45 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem46 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem47 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem48 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem49 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem50 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem51 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem6 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem52 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem53 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem54 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem55 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem56 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem57 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonGalleryDropDownItem1 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown50 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem2 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown51 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem3 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown52 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonItem58 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem7 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem59 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem60 As UI.SpreadsheetCommandBarButtonItem
		Private galleryFormatAsTableItem1 As UI.GalleryFormatAsTableItem
		Private commandBarGalleryDropDown53 As XtraBars.Commands.CommandBarGalleryDropDown
		Private galleryChangeStyleItem1 As UI.GalleryChangeStyleItem
		Private spreadsheetCommandBarSubItem8 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem61 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem62 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem63 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem9 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem64 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem65 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem66 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem10 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem67 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem68 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem69 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem70 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem71 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem11 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem72 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem73 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem74 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem75 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem76 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem77 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem78 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem79 As UI.SpreadsheetCommandBarButtonItem
		Private changeSheetTabColorItem1 As UI.ChangeSheetTabColorItem
		Private spreadsheetCommandBarButtonItem80 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarCheckItem13 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarButtonItem81 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem12 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem82 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem83 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem84 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem85 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem86 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem13 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem87 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem88 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem89 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem90 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem14 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem91 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem92 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem93 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem94 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem95 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem96 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem15 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem97 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem98 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarCheckItem14 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarButtonItem99 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem100 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem16 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem101 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem102 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem103 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem104 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem105 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem106 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem112 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem113 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem114 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem115 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonGalleryDropDownItem4 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown54 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem5 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown55 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem6 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown56 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem7 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown57 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem8 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown58 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem9 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown59 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem10 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown60 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonItem116 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem117 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem17 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarCheckItem15 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem16 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem17 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarButtonItem118 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem18 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarCheckItem18 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem19 As UI.SpreadsheetCommandBarCheckItem
		Private pageSetupPaperKindItem1 As UI.PageSetupPaperKindItem
		Private spreadsheetCommandBarSubItem19 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem124 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem125 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem126 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem127 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarCheckItem20 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem21 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem22 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem23 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarSubItem20 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem128 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem129 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem21 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem130 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem131 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem22 As UI.SpreadsheetCommandBarSubItem
		Private functionsFinancialItem1 As UI.FunctionsFinancialItem
		Private functionsLogicalItem1 As UI.FunctionsLogicalItem
		Private functionsTextItem1 As UI.FunctionsTextItem
		Private functionsDateAndTimeItem1 As UI.FunctionsDateAndTimeItem
		Private functionsLookupAndReferenceItem1 As UI.FunctionsLookupAndReferenceItem
		Private functionsMathAndTrigonometryItem1 As UI.FunctionsMathAndTrigonometryItem
		Private spreadsheetCommandBarSubItem23 As UI.SpreadsheetCommandBarSubItem
		Private functionsStatisticalItem1 As UI.FunctionsStatisticalItem
		Private functionsEngineeringItem1 As UI.FunctionsEngineeringItem
		Private functionsInformationItem1 As UI.FunctionsInformationItem
		Private functionsCompatibilityItem1 As UI.FunctionsCompatibilityItem
		Private functionsWebItem1 As UI.FunctionsWebItem
		Private spreadsheetCommandBarButtonItem137 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem138 As UI.SpreadsheetCommandBarButtonItem
		Private definedNameListItem1 As UI.DefinedNameListItem
		Private spreadsheetCommandBarButtonItem139 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarCheckItem24 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarSubItem24 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarCheckItem25 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem26 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarButtonItem140 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem141 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem25 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem142 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem143 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem144 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem26 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem145 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem146 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem27 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem147 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem148 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem149 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem150 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem151 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem152 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem153 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem154 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem155 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem156 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem157 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem158 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem159 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem160 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem161 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem162 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem163 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem28 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem164 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem165 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem166 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem167 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem168 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem169 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem170 As UI.SpreadsheetCommandBarButtonItem
		Private galleryChartLayoutItem1 As UI.GalleryChartLayoutItem
		Private galleryChartStyleItem1 As UI.GalleryChartStyleItem
		Private spreadsheetCommandBarSubItem29 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonGalleryDropDownItem11 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown61 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem12 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown62 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarSubItem30 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonGalleryDropDownItem13 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown63 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem14 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown64 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem15 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown65 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarSubItem31 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonGalleryDropDownItem16 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown66 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem17 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown67 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem18 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown68 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem19 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown69 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem20 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown70 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem21 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown71 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem22 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown72 As XtraBars.Commands.CommandBarGalleryDropDown
		Private renameTableItemCaption1 As UI.RenameTableItemCaption
		Private renameTableItem1 As UI.RenameTableItem
		Private repositoryItemTextEdit1 As XtraEditors.Repository.RepositoryItemTextEdit
		Private spreadsheetCommandBarCheckItem27 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem28 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem29 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem30 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem31 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem32 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem33 As UI.SpreadsheetCommandBarCheckItem
		Private galleryTableStylesItem1 As UI.GalleryTableStylesItem
		Private spreadsheetCommandBarButtonItem171 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem172 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem173 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem174 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem175 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem176 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem177 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem32 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem178 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem179 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem180 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem33 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem181 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem182 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem34 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem183 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem184 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem185 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem186 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem35 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem187 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem188 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem189 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem190 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarCheckItem34 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem35 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem36 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarSubItem36 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem191 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem192 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem193 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem37 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem194 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem195 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem196 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem197 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem38 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem198 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem199 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem200 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem201 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem202 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem39 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem203 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem204 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarCheckItem37 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem38 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem39 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem40 As UI.SpreadsheetCommandBarCheckItem
		Private galleryPivotStylesItem1 As UI.GalleryPivotStylesItem
		Private chartToolsRibbonPageCategory1 As UI.ChartToolsRibbonPageCategory
		Private chartsDesignRibbonPage1 As UI.ChartsDesignRibbonPage
		Private chartsDesignTypeRibbonPageGroup1 As UI.ChartsDesignTypeRibbonPageGroup
		Private chartsDesignDataRibbonPageGroup1 As UI.ChartsDesignDataRibbonPageGroup
		Private chartsDesignLayoutsRibbonPageGroup1 As UI.ChartsDesignLayoutsRibbonPageGroup
		Private chartsDesignStylesRibbonPageGroup1 As UI.ChartsDesignStylesRibbonPageGroup
		Private chartsLayoutRibbonPage1 As UI.ChartsLayoutRibbonPage
		Private chartsLayoutAxesRibbonPageGroup1 As UI.ChartsLayoutAxesRibbonPageGroup
		Private chartsLayoutLabelsRibbonPageGroup1 As UI.ChartsLayoutLabelsRibbonPageGroup
		Private chartsLayoutAnalysisRibbonPageGroup1 As UI.ChartsLayoutAnalysisRibbonPageGroup
		Private chartsFormatRibbonPage1 As UI.ChartsFormatRibbonPage
		Private chartsFormatArrangeRibbonPageGroup1 As UI.ChartsFormatArrangeRibbonPageGroup
		Private tableToolsRibbonPageCategory1 As UI.TableToolsRibbonPageCategory
		Private tableToolsDesignRibbonPage1 As UI.TableToolsDesignRibbonPage
		Private tablePropertiesRibbonPageGroup1 As UI.TablePropertiesRibbonPageGroup
		Private tableToolsRibbonPageGroup1 As UI.TableToolsRibbonPageGroup
		Private tableStyleOptionsRibbonPageGroup1 As UI.TableStyleOptionsRibbonPageGroup
		Private tableStylesRibbonPageGroup1 As UI.TableStylesRibbonPageGroup
		Private drawingToolsRibbonPageCategory1 As UI.DrawingToolsRibbonPageCategory
		Private drawingFormatRibbonPage1 As UI.DrawingFormatRibbonPage
		Private drawingFormatArrangeRibbonPageGroup1 As UI.DrawingFormatArrangeRibbonPageGroup
		Private pictureToolsRibbonPageCategory1 As UI.PictureToolsRibbonPageCategory
		Private pictureFormatRibbonPage1 As UI.PictureFormatRibbonPage
		Private pictureFormatArrangeRibbonPageGroup1 As UI.PictureFormatArrangeRibbonPageGroup
		Private pivotTableToolsRibbonPageCategory1 As UI.PivotTableToolsRibbonPageCategory
		Private pivotTableAnalyzeRibbonPage1 As UI.PivotTableAnalyzeRibbonPage
		Private pivotTableAnalyzePivotTableRibbonPageGroup1 As UI.PivotTableAnalyzePivotTableRibbonPageGroup
		Private pivotTableAnalyzeActiveFieldRibbonPageGroup1 As UI.PivotTableAnalyzeActiveFieldRibbonPageGroup
		Private pivotTableAnalyzeGroupRibbonPageGroup1 As UI.PivotTableAnalyzeGroupRibbonPageGroup
		Private pivotTableAnalyzeDataRibbonPageGroup1 As UI.PivotTableAnalyzeDataRibbonPageGroup
		Private pivotTableAnalyzeActionsRibbonPageGroup1 As UI.PivotTableAnalyzeActionsRibbonPageGroup
		Private pivotTableAnalyzeCalculationsRibbonPageGroup1 As UI.PivotTableAnalyzeCalculationsRibbonPageGroup
		Private pivotTableAnalyzeShowRibbonPageGroup1 As UI.PivotTableAnalyzeShowRibbonPageGroup
		Private pivotTableDesignRibbonPage1 As UI.PivotTableDesignRibbonPage
		Private pivotTableDesignLayoutRibbonPageGroup1 As UI.PivotTableDesignLayoutRibbonPageGroup
		Private pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1 As UI.PivotTableDesignPivotTableStyleOptionsRibbonPageGroup
		Private pivotTableDesignPivotTableStylesRibbonPageGroup1 As UI.PivotTableDesignPivotTableStylesRibbonPageGroup
		Private fileRibbonPage1 As UI.FileRibbonPage
		Private commonRibbonPageGroup1 As UI.CommonRibbonPageGroup
		Private infoRibbonPageGroup1 As UI.InfoRibbonPageGroup
		Private homeRibbonPage1 As UI.HomeRibbonPage
		Private clipboardRibbonPageGroup1 As UI.ClipboardRibbonPageGroup
		Private fontRibbonPageGroup1 As UI.FontRibbonPageGroup
		Private alignmentRibbonPageGroup1 As UI.AlignmentRibbonPageGroup
		Private numberRibbonPageGroup1 As UI.NumberRibbonPageGroup
		Private stylesRibbonPageGroup1 As UI.StylesRibbonPageGroup
		Private cellsRibbonPageGroup1 As UI.CellsRibbonPageGroup
		Private editingRibbonPageGroup1 As UI.EditingRibbonPageGroup
		Private insertRibbonPage1 As UI.InsertRibbonPage
		Private tablesRibbonPageGroup1 As UI.TablesRibbonPageGroup
		Private illustrationsRibbonPageGroup1 As UI.IllustrationsRibbonPageGroup
		Private chartsRibbonPageGroup1 As UI.ChartsRibbonPageGroup
		Private linksRibbonPageGroup1 As UI.LinksRibbonPageGroup
		Private symbolsRibbonPageGroup1 As UI.SymbolsRibbonPageGroup
		Private pageLayoutRibbonPage1 As UI.PageLayoutRibbonPage
		Private pageSetupRibbonPageGroup1 As UI.PageSetupRibbonPageGroup
		Private pageSetupShowRibbonPageGroup1 As UI.PageSetupShowRibbonPageGroup
		Private pageSetupPrintRibbonPageGroup1 As UI.PageSetupPrintRibbonPageGroup
		Private arrangeRibbonPageGroup1 As UI.ArrangeRibbonPageGroup
		Private formulasRibbonPage1 As UI.FormulasRibbonPage
		Private functionLibraryRibbonPageGroup1 As UI.FunctionLibraryRibbonPageGroup
		Private formulaDefinedNamesRibbonPageGroup1 As UI.FormulaDefinedNamesRibbonPageGroup
		Private formulaAuditingRibbonPageGroup1 As UI.FormulaAuditingRibbonPageGroup
		Private formulaCalculationRibbonPageGroup1 As UI.FormulaCalculationRibbonPageGroup
		Private dataRibbonPage1 As UI.DataRibbonPage
		Private sortAndFilterRibbonPageGroup1 As UI.SortAndFilterRibbonPageGroup
		Private dataToolsRibbonPageGroup1 As UI.DataToolsRibbonPageGroup
		Private outlineRibbonPageGroup1 As UI.OutlineRibbonPageGroup
		Private reviewRibbonPage1 As UI.ReviewRibbonPage
		Private commentsRibbonPageGroup1 As UI.CommentsRibbonPageGroup
		Private changesRibbonPageGroup1 As UI.ChangesRibbonPageGroup
		Private viewRibbonPage1 As UI.ViewRibbonPage
		Private showRibbonPageGroup1 As UI.ShowRibbonPageGroup
		Private zoomRibbonPageGroup1 As UI.ZoomRibbonPageGroup
		Private windowRibbonPageGroup1 As UI.WindowRibbonPageGroup
		Private spreadsheetCommandBarButtonItem132 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem133 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem134 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem135 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem136 As UI.SpreadsheetCommandBarButtonItem
	End Class
End Namespace

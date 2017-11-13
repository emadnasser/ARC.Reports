using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;

namespace DevExpress.XtraSpreadsheet.Demos {
    partial class InvoiceWithTotalModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        System.ComponentModel.IContainer components = null;
        LabelControl fromCompanyLabel;
        TextEdit fromCompanyEdit;
        TextEdit fromCityEdit;
        LabelControl fromCityLabel;
        TextEdit fromAddressEdit;
        LabelControl fromAddressLabel;
        TextEdit fromCompanySloganEdit;
        LabelControl fromCompanySloganLabel;
        TextEdit fromFaxEdit;
        LabelControl fromFaxLabel;
        TextEdit fromPhoneEdit;
        LabelControl fromPhoneLabel;
        TextEdit fromZipEdit;
        LabelControl fromZipLabel;
        TextEdit fromStateEdit;
        LabelControl fromStateLabel;
        TextEdit toCompanyNameEdit;
        LabelControl toCompanylabel;
        TextEdit toPhoneEdit;
        LabelControl toPhoneLabel;
        TextEdit toZipEdit;
        LabelControl toZipLabel;
        TextEdit toStateEdit;
        LabelControl toStateLabel;
        TextEdit toCityEdit;
        LabelControl toCityLabel;
        TextEdit toStreetEdit;
        LabelControl toStreetLabel;
        TextEdit toNameEdit;
        LabelControl toNameLabel;
        SpreadsheetControl spreadsheetControl1;
        XtraTab.XtraTabControl mainTabControl;
        XtraTab.XtraTabPage dataTabPage;
        XtraTab.XtraTabPage invoiceTabPage;
        PanelControl panelControl1;
        XtraGrid.GridControl gridControl1;
        BindingSource productsBindingSource;
        nwindDataSet nwindDataSet;
        XtraGrid.Views.Grid.GridView gridView1;
        XtraGrid.Columns.GridColumn colProductName;
        XtraGrid.Columns.GridColumn colUnitPrice;
        nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        XtraGrid.Columns.GridColumn gridColumn1;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem8 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem9 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem10 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem11 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem12 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem13 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem14 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup43 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem199 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem200 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem201 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem202 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem203 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem204 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem205 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem206 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem207 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem208 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem209 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem210 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup44 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem211 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem212 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem213 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem214 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem215 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem216 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem217 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup45 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem218 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem219 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem220 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem221 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem222 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup46 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem223 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem224 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem225 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup47 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem226 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem227 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem228 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem229 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem230 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup48 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem231 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem232 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem233 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup49 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem234 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem235 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem236 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem237 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup50 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem238 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem239 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem240 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem241 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup51 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem242 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem243 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem244 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem245 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup52 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem246 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem247 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem248 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem249 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup53 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem250 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem251 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem252 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem253 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem254 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem255 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup54 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem256 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup55 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem257 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem258 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup56 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem259 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem260 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup57 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem261 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem262 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup58 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem263 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem264 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem265 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup59 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem266 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem267 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem268 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup60 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem269 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem270 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem271 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup61 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem272 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem273 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem274 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup62 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem275 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem276 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem277 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup63 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem278 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem279 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem280 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup64 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem281 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem282 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem283 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup65 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem284 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem285 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem286 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem287 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem288 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup66 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem289 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem290 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup67 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem291 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem292 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem293 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem294 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup68 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem295 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem296 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem297 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup69 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem298 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem299 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem300 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup70 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem301 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem302 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup71 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem303 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem304 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem305 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem306 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup72 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem307 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem308 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem309 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem310 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem311 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem312 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem313 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup73 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem314 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem315 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem316 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem317 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem318 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem319 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem320 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem321 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem322 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem323 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem324 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup74 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem325 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem326 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem327 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem328 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem329 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem330 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem331 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem332 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem333 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup75 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem334 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem335 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem336 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem337 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem338 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem339 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem340 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem341 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem342 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup76 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem343 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem344 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem345 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem346 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup77 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem347 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem348 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem349 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem350 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup78 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem351 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem352 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem353 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem354 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem355 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup79 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem356 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem357 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup80 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem358 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem359 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem360 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem361 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup81 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem362 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem363 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem364 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem365 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem366 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem367 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup82 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem368 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem369 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem370 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem371 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem372 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem373 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem15 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem16 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem17 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem18 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem19 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem20 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem21 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem22 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem23 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem24 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem25 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem26 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem27 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem28 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup83 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem374 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem375 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem376 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem377 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem378 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem379 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem380 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem381 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem382 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem383 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem384 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem385 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup84 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem386 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem387 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem388 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem389 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem390 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem391 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem392 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup85 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem393 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem394 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem395 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem396 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem397 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup86 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem398 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem399 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem400 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup87 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem401 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem402 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem403 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem404 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem405 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup88 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem406 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem407 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem408 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup89 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem409 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem410 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem411 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem412 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup90 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem413 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem414 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem415 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem416 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup91 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem417 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem418 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem419 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem420 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup92 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem421 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem422 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem423 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem424 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup93 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem425 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem426 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem427 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem428 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem429 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem430 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup94 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem431 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup95 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem432 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem433 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup96 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem434 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem435 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup97 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem436 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem437 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup98 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem438 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem439 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem440 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup99 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem441 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem442 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem443 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup100 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem444 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem445 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem446 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup101 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem447 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem448 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem449 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup102 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem450 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem451 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem452 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup103 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem453 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem454 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem455 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup104 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem456 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem457 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem458 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup105 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem459 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem460 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem461 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem462 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem463 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup106 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem464 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem465 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup107 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem466 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem467 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup108 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem468 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem469 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem470 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup109 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem471 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem472 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem473 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup110 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem474 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem475 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup111 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem476 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem477 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem478 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem479 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup112 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem480 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem481 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem482 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem483 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem484 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem485 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem486 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup113 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem487 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem488 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem489 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem490 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem491 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem492 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem493 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem494 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem495 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem496 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem497 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup114 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem498 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem499 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem500 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem501 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem502 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem503 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem504 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem505 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem506 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup115 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem507 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem508 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem509 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem510 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem511 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem512 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem513 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem514 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem515 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup116 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem516 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem517 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem518 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem519 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup117 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem520 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem521 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem522 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem523 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup118 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem524 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem525 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem526 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem527 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem528 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup119 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem529 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem530 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup120 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem531 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem532 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem533 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem534 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem41 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem42 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem43 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem44 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem45 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem46 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem47 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem48 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem49 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem50 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem51 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem52 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem53 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem54 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem55 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem56 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem57 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem58 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem59 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem60 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem61 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem62 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem63 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem64 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem65 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem66 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem67 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem68 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem69 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem70 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem71 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem72 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem73 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem74 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem75 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem76 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem77 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem78 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem79 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem80 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem81 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem82 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem83 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem84 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem85 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem86 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem87 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem88 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem89 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem90 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem91 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem92 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem93 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem94 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem95 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem96 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem97 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem98 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem99 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem100 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem101 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem102 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem103 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem104 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem105 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem106 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem107 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem108 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem109 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem110 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem111 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem112 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem113 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem114 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem115 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem116 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem117 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem118 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem119 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem120 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem121 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem122 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem123 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem124 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem125 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem126 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem127 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem128 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem129 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem130 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem131 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem132 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem133 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem134 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem135 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem136 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem137 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem138 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem139 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem140 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem141 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem142 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem143 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem144 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem145 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem146 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem147 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem148 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem149 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem150 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem151 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem152 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem153 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem154 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem155 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem156 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem157 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem158 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem159 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem160 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem161 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem162 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem163 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem164 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem165 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem166 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem167 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem168 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem169 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem170 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem171 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem172 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem173 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem174 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem175 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem176 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem177 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem178 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem179 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem180 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem181 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem182 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem183 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem184 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem185 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem186 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem187 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem188 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem189 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem190 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem191 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem192 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup41 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem193 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem194 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup42 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem195 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem196 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem197 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem198 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            this.commandBarGalleryDropDown26 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.commandBarGalleryDropDown25 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown27 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown28 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown29 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown30 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown31 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown32 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown33 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown34 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown35 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown36 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown37 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown38 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown39 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown40 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown41 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown42 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown43 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown44 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown45 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown46 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown47 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown48 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown2 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown1 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown3 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown4 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown5 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown6 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown7 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown8 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown9 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown10 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown11 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown12 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown13 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown14 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown15 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown16 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown17 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown18 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown19 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown20 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown21 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown22 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown23 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown24 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.fromFaxEdit = new DevExpress.XtraEditors.TextEdit();
            this.fromFaxLabel = new DevExpress.XtraEditors.LabelControl();
            this.fromPhoneEdit = new DevExpress.XtraEditors.TextEdit();
            this.fromPhoneLabel = new DevExpress.XtraEditors.LabelControl();
            this.fromZipEdit = new DevExpress.XtraEditors.TextEdit();
            this.fromZipLabel = new DevExpress.XtraEditors.LabelControl();
            this.fromStateEdit = new DevExpress.XtraEditors.TextEdit();
            this.fromStateLabel = new DevExpress.XtraEditors.LabelControl();
            this.fromCityEdit = new DevExpress.XtraEditors.TextEdit();
            this.fromCityLabel = new DevExpress.XtraEditors.LabelControl();
            this.fromAddressEdit = new DevExpress.XtraEditors.TextEdit();
            this.fromAddressLabel = new DevExpress.XtraEditors.LabelControl();
            this.fromCompanySloganEdit = new DevExpress.XtraEditors.TextEdit();
            this.fromCompanySloganLabel = new DevExpress.XtraEditors.LabelControl();
            this.fromCompanyEdit = new DevExpress.XtraEditors.TextEdit();
            this.fromCompanyLabel = new DevExpress.XtraEditors.LabelControl();
            this.toCompanyNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.toCompanylabel = new DevExpress.XtraEditors.LabelControl();
            this.toPhoneEdit = new DevExpress.XtraEditors.TextEdit();
            this.toPhoneLabel = new DevExpress.XtraEditors.LabelControl();
            this.toZipEdit = new DevExpress.XtraEditors.TextEdit();
            this.toZipLabel = new DevExpress.XtraEditors.LabelControl();
            this.toStateEdit = new DevExpress.XtraEditors.TextEdit();
            this.toStateLabel = new DevExpress.XtraEditors.LabelControl();
            this.toCityEdit = new DevExpress.XtraEditors.TextEdit();
            this.toCityLabel = new DevExpress.XtraEditors.LabelControl();
            this.toStreetEdit = new DevExpress.XtraEditors.TextEdit();
            this.toStreetLabel = new DevExpress.XtraEditors.LabelControl();
            this.toNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.toNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.mainTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.invoiceTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.spreadsheetNameBoxControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl();
            this.spreadsheetFormulaBarControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl();
            this.dataTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.toGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.fromGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.fromContactNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.fromContactNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.fromEMailLabel = new DevExpress.XtraEditors.LabelControl();
            this.fromEMailEdit = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new DevExpress.XtraSpreadsheet.Demos.nwindDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.includeItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productsTableAdapter = new DevExpress.XtraSpreadsheet.Demos.nwindDataSetTableAdapters.ProductsTableAdapter();
            this.spreadsheetBarController1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController();
            this.spreadsheetCommandBarButtonItem107 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem108 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem109 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem110 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem111 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem119 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem120 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem121 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem122 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem123 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.commonRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup();
            this.fileRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.FileRibbonPage();
            this.spreadsheetCommandBarButtonItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.infoRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup();
            this.spreadsheetCommandBarButtonItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.clipboardRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup();
            this.homeRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.HomeRibbonPage();
            this.spreadsheetCommandBarButtonItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.fontRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup();
            this.changeFontNameItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeFontNameItem();
            this.changeFontSizeItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeFontSizeItem();
            this.spreadsheetCommandBarButtonItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarSubItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.changeBorderLineColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeBorderLineColorItem();
            this.changeBorderLineStyleItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeBorderLineStyleItem();
            this.commandBarGalleryDropDown49 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.changeCellFillColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeCellFillColorItem();
            this.changeFontColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeFontColorItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.repositoryItemSpreadsheetFontSizeEdit1 = new DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
            this.alignmentRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.AlignmentRibbonPageGroup();
            this.spreadsheetCommandBarCheckItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarSubItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barButtonGroup5 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup6 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup7 = new DevExpress.XtraBars.BarButtonGroup();
            this.numberRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.NumberRibbonPageGroup();
            this.changeNumberFormatItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeNumberFormatItem();
            this.spreadsheetCommandBarSubItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem41 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem42 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem43 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem44 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barButtonGroup8 = new DevExpress.XtraBars.BarButtonGroup();
            this.repositoryItemPopupGalleryEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit();
            this.barButtonGroup9 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup10 = new DevExpress.XtraBars.BarButtonGroup();
            this.stylesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.StylesRibbonPageGroup();
            this.spreadsheetCommandBarSubItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarSubItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem45 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem46 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem47 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem48 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem49 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem50 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem51 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem52 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem53 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem54 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem55 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem56 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem57 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown50 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown51 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown52 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonItem58 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem59 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem60 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.galleryFormatAsTableItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryFormatAsTableItem();
            this.commandBarGalleryDropDown53 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.galleryChangeStyleItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryChangeStyleItem();
            this.cellsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.CellsRibbonPageGroup();
            this.spreadsheetCommandBarSubItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem61 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem62 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem63 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem64 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem65 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem66 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem67 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem68 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem69 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem70 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem71 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem72 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem73 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem74 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem75 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem76 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem77 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem78 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem79 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.changeSheetTabColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeSheetTabColorItem();
            this.spreadsheetCommandBarButtonItem80 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem81 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.editingRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup();
            this.spreadsheetCommandBarSubItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem82 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem83 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem84 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem85 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem86 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem87 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem88 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem89 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem90 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem91 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem92 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem93 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem94 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem95 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem96 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem97 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem98 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem99 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem100 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem101 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem102 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem103 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem104 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem105 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem106 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem112 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.tablesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TablesRibbonPageGroup();
            this.insertRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.InsertRibbonPage();
            this.spreadsheetCommandBarButtonItem113 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem114 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.illustrationsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.IllustrationsRibbonPageGroup();
            this.spreadsheetCommandBarButtonItem115 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.chartsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsRibbonPageGroup();
            this.spreadsheetCommandBarButtonGalleryDropDownItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown54 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown55 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown56 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown57 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown58 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown59 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown60 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.linksRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.LinksRibbonPageGroup();
            this.spreadsheetCommandBarButtonItem116 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.symbolsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.SymbolsRibbonPageGroup();
            this.spreadsheetCommandBarButtonItem117 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.pageSetupRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PageSetupRibbonPageGroup();
            this.pageLayoutRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.PageLayoutRibbonPage();
            this.spreadsheetCommandBarSubItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem118 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.pageSetupPaperKindItem1 = new DevExpress.XtraSpreadsheet.UI.PageSetupPaperKindItem();
            this.spreadsheetCommandBarSubItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem124 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem125 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem126 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem127 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.pageSetupShowRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PageSetupShowRibbonPageGroup();
            this.spreadsheetCommandBarCheckItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.pageSetupPrintRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PageSetupPrintRibbonPageGroup();
            this.spreadsheetCommandBarCheckItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.arrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ArrangeRibbonPageGroup();
            this.spreadsheetCommandBarSubItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem128 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem129 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem130 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem131 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.functionLibraryRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FunctionLibraryRibbonPageGroup();
            this.formulasRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.FormulasRibbonPage();
            this.spreadsheetCommandBarSubItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem132 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem133 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem134 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem135 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem136 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.functionsFinancialItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsFinancialItem();
            this.functionsLogicalItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsLogicalItem();
            this.functionsTextItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsTextItem();
            this.functionsDateAndTimeItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsDateAndTimeItem();
            this.functionsLookupAndReferenceItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsLookupAndReferenceItem();
            this.functionsMathAndTrigonometryItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsMathAndTrigonometryItem();
            this.spreadsheetCommandBarSubItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.functionsStatisticalItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsStatisticalItem();
            this.functionsEngineeringItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsEngineeringItem();
            this.functionsInformationItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsInformationItem();
            this.functionsCompatibilityItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsCompatibilityItem();
            this.functionsWebItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsWebItem();
            this.formulaDefinedNamesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FormulaDefinedNamesRibbonPageGroup();
            this.spreadsheetCommandBarButtonItem137 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem138 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.definedNameListItem1 = new DevExpress.XtraSpreadsheet.UI.DefinedNameListItem();
            this.spreadsheetCommandBarButtonItem139 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.formulaAuditingRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FormulaAuditingRibbonPageGroup();
            this.spreadsheetCommandBarCheckItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.formulaCalculationRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FormulaCalculationRibbonPageGroup();
            this.spreadsheetCommandBarSubItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem140 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem141 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.sortAndFilterRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.SortAndFilterRibbonPageGroup();
            this.dataRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.DataRibbonPage();
            this.dataToolsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.DataToolsRibbonPageGroup();
            this.spreadsheetCommandBarSubItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem142 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem143 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem144 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.outlineRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.OutlineRibbonPageGroup();
            this.spreadsheetCommandBarSubItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem145 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem146 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem147 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem148 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem149 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem150 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem151 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.commentsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.CommentsRibbonPageGroup();
            this.reviewRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ReviewRibbonPage();
            this.spreadsheetCommandBarButtonItem152 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem153 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem154 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem155 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.changesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChangesRibbonPageGroup();
            this.spreadsheetCommandBarButtonItem156 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem157 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem158 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem159 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.showRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ShowRibbonPageGroup();
            this.viewRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ViewRibbonPage();
            this.zoomRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ZoomRibbonPageGroup();
            this.spreadsheetCommandBarButtonItem160 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem161 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem162 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem163 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.windowRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.WindowRibbonPageGroup();
            this.spreadsheetCommandBarSubItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem164 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem165 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem166 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem167 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.chartsDesignTypeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignTypeRibbonPageGroup();
            this.chartsDesignRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignRibbonPage();
            this.chartToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.ChartToolsRibbonPageCategory();
            this.spreadsheetCommandBarButtonItem168 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.chartsDesignDataRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignDataRibbonPageGroup();
            this.spreadsheetCommandBarButtonItem169 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem170 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.chartsDesignLayoutsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignLayoutsRibbonPageGroup();
            this.galleryChartLayoutItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryChartLayoutItem();
            this.chartsDesignStylesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignStylesRibbonPageGroup();
            this.galleryChartStyleItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryChartStyleItem();
            this.chartsLayoutAxesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsLayoutAxesRibbonPageGroup();
            this.chartsLayoutRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ChartsLayoutRibbonPage();
            this.spreadsheetCommandBarSubItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown61 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown62 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarSubItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown63 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown64 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.chartsLayoutLabelsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsLayoutLabelsRibbonPageGroup();
            this.spreadsheetCommandBarButtonGalleryDropDownItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown65 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarSubItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown66 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown67 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown68 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown69 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.chartsLayoutAnalysisRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsLayoutAnalysisRibbonPageGroup();
            this.spreadsheetCommandBarButtonGalleryDropDownItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown70 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown71 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown72 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.chartsFormatArrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsFormatArrangeRibbonPageGroup();
            this.chartsFormatRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ChartsFormatRibbonPage();
            this.tablePropertiesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TablePropertiesRibbonPageGroup();
            this.tableToolsDesignRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.TableToolsDesignRibbonPage();
            this.tableToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageCategory();
            this.renameTableItemCaption1 = new DevExpress.XtraSpreadsheet.UI.RenameTableItemCaption();
            this.renameTableItem1 = new DevExpress.XtraSpreadsheet.UI.RenameTableItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tableToolsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageGroup();
            this.spreadsheetCommandBarCheckItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.tableStyleOptionsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TableStyleOptionsRibbonPageGroup();
            this.spreadsheetCommandBarCheckItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.tableStylesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TableStylesRibbonPageGroup();
            this.galleryTableStylesItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryTableStylesItem();
            this.drawingFormatArrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.DrawingFormatArrangeRibbonPageGroup();
            this.drawingFormatRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.DrawingFormatRibbonPage();
            this.drawingToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.DrawingToolsRibbonPageCategory();
            this.pictureFormatArrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PictureFormatArrangeRibbonPageGroup();
            this.pictureFormatRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.PictureFormatRibbonPage();
            this.pictureToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.PictureToolsRibbonPageCategory();
            this.pivotTableAnalyzePivotTableRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzePivotTableRibbonPageGroup();
            this.pivotTableAnalyzeRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeRibbonPage();
            this.pivotTableToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.PivotTableToolsRibbonPageCategory();
            this.spreadsheetCommandBarButtonItem171 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeActiveFieldRibbonPageGroup();
            this.spreadsheetCommandBarButtonItem172 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem173 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem174 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.pivotTableAnalyzeGroupRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeGroupRibbonPageGroup();
            this.spreadsheetCommandBarButtonItem175 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem176 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem177 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.pivotTableAnalyzeDataRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeDataRibbonPageGroup();
            this.spreadsheetCommandBarSubItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem178 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem179 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem180 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.pivotTableAnalyzeActionsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeActionsRibbonPageGroup();
            this.spreadsheetCommandBarSubItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem181 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem182 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem183 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem184 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem185 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem186 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.pivotTableAnalyzeCalculationsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeCalculationsRibbonPageGroup();
            this.spreadsheetCommandBarSubItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem187 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem188 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem189 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem190 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.pivotTableAnalyzeShowRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeShowRibbonPageGroup();
            this.spreadsheetCommandBarCheckItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.pivotTableDesignLayoutRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableDesignLayoutRibbonPageGroup();
            this.pivotTableDesignRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.PivotTableDesignRibbonPage();
            this.spreadsheetCommandBarSubItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem191 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem192 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem193 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem194 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem195 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem196 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem197 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem198 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem199 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem200 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem201 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem202 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem203 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem204 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableDesignPivotTableStyleOptionsRibbonPageGroup();
            this.spreadsheetCommandBarCheckItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.pivotTableDesignPivotTableStylesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableDesignPivotTableStylesRibbonPageGroup();
            this.galleryPivotStylesItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryPivotStylesItem();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromFaxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromPhoneEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromZipEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromStateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromCityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromAddressEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromCompanySloganEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromCompanyEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toCompanyNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toPhoneEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toZipEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toStateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toCityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toStreetEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTabControl)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.invoiceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetNameBoxControl1.Properties)).BeginInit();
            this.dataTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toGroupControl)).BeginInit();
            this.toGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromGroupControl)).BeginInit();
            this.fromGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromContactNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromEMailEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.includeItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpreadsheetFontSizeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // commandBarGalleryDropDown26
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown26.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup1.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup";
            spreadsheetCommandGalleryItem1.CommandName = "ConditionalFormattingDataBarGradientBlue";
            spreadsheetCommandGalleryItem2.CommandName = "ConditionalFormattingDataBarGradientGreen";
            spreadsheetCommandGalleryItem3.CommandName = "ConditionalFormattingDataBarGradientRed";
            spreadsheetCommandGalleryItem4.CommandName = "ConditionalFormattingDataBarGradientOrange";
            spreadsheetCommandGalleryItem5.CommandName = "ConditionalFormattingDataBarGradientLightBlue";
            spreadsheetCommandGalleryItem6.CommandName = "ConditionalFormattingDataBarGradientPurple";
            spreadsheetCommandGalleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem1,
            spreadsheetCommandGalleryItem2,
            spreadsheetCommandGalleryItem3,
            spreadsheetCommandGalleryItem4,
            spreadsheetCommandGalleryItem5,
            spreadsheetCommandGalleryItem6});
            spreadsheetCommandGalleryItemGroup2.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup";
            spreadsheetCommandGalleryItem7.CommandName = "ConditionalFormattingDataBarSolidBlue";
            spreadsheetCommandGalleryItem8.CommandName = "ConditionalFormattingDataBarSolidGreen";
            spreadsheetCommandGalleryItem9.CommandName = "ConditionalFormattingDataBarSolidRed";
            spreadsheetCommandGalleryItem10.CommandName = "ConditionalFormattingDataBarSolidOrange";
            spreadsheetCommandGalleryItem11.CommandName = "ConditionalFormattingDataBarSolidLightBlue";
            spreadsheetCommandGalleryItem12.CommandName = "ConditionalFormattingDataBarSolidPurple";
            spreadsheetCommandGalleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem7,
            spreadsheetCommandGalleryItem8,
            spreadsheetCommandGalleryItem9,
            spreadsheetCommandGalleryItem10,
            spreadsheetCommandGalleryItem11,
            spreadsheetCommandGalleryItem12});
            this.commandBarGalleryDropDown26.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup1,
            spreadsheetCommandGalleryItemGroup2});
            this.commandBarGalleryDropDown26.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown26.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown26.Manager = null;
            this.commandBarGalleryDropDown26.Name = "commandBarGalleryDropDown26";
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(2, 27);
            this.spreadsheetControl1.MenuManager = this.ribbonControl1;
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Size = new System.Drawing.Size(686, 305);
            this.spreadsheetControl1.TabIndex = 50;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // commandBarGalleryDropDown25
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown25.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown25.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown25.Gallery.DrawImageBackground = false;
            galleryItem1.Tag = DevExpress.Export.Xl.XlBorderLineStyle.None;
            galleryItem2.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thin;
            galleryItem3.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Hair;
            galleryItem4.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dotted;
            galleryItem5.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dashed;
            galleryItem6.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDot;
            galleryItem7.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDotDot;
            galleryItem8.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Double;
            galleryItem9.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Medium;
            galleryItem10.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashed;
            galleryItem11.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDot;
            galleryItem12.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDotDot;
            galleryItem13.Tag = DevExpress.Export.Xl.XlBorderLineStyle.SlantDashDot;
            galleryItem14.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thick;
            galleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6,
            galleryItem7,
            galleryItem8,
            galleryItem9,
            galleryItem10,
            galleryItem11,
            galleryItem12,
            galleryItem13,
            galleryItem14});
            this.commandBarGalleryDropDown25.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
            this.commandBarGalleryDropDown25.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.commandBarGalleryDropDown25.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown25.Gallery.ItemSize = new System.Drawing.Size(136, 26);
            this.commandBarGalleryDropDown25.Gallery.RowCount = 14;
            this.commandBarGalleryDropDown25.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown25.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown25.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown25.Manager = null;
            this.commandBarGalleryDropDown25.Name = "commandBarGalleryDropDown25";
            // 
            // commandBarGalleryDropDown27
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown27.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup43.CommandName = "ConditionalFormattingColorScalesCommandGroup";
            spreadsheetCommandGalleryItem199.CommandName = "ConditionalFormattingColorScaleGreenYellowRed";
            spreadsheetCommandGalleryItem200.CommandName = "ConditionalFormattingColorScaleRedYellowGreen";
            spreadsheetCommandGalleryItem201.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed";
            spreadsheetCommandGalleryItem202.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen";
            spreadsheetCommandGalleryItem203.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed";
            spreadsheetCommandGalleryItem204.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue";
            spreadsheetCommandGalleryItem205.CommandName = "ConditionalFormattingColorScaleWhiteRed";
            spreadsheetCommandGalleryItem206.CommandName = "ConditionalFormattingColorScaleRedWhite";
            spreadsheetCommandGalleryItem207.CommandName = "ConditionalFormattingColorScaleGreenWhite";
            spreadsheetCommandGalleryItem208.CommandName = "ConditionalFormattingColorScaleWhiteGreen";
            spreadsheetCommandGalleryItem209.CommandName = "ConditionalFormattingColorScaleGreenYellow";
            spreadsheetCommandGalleryItem210.CommandName = "ConditionalFormattingColorScaleYellowGreen";
            spreadsheetCommandGalleryItemGroup43.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem199,
            spreadsheetCommandGalleryItem200,
            spreadsheetCommandGalleryItem201,
            spreadsheetCommandGalleryItem202,
            spreadsheetCommandGalleryItem203,
            spreadsheetCommandGalleryItem204,
            spreadsheetCommandGalleryItem205,
            spreadsheetCommandGalleryItem206,
            spreadsheetCommandGalleryItem207,
            spreadsheetCommandGalleryItem208,
            spreadsheetCommandGalleryItem209,
            spreadsheetCommandGalleryItem210});
            this.commandBarGalleryDropDown27.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup43});
            this.commandBarGalleryDropDown27.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown27.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown27.Manager = null;
            this.commandBarGalleryDropDown27.Name = "commandBarGalleryDropDown27";
            // 
            // commandBarGalleryDropDown28
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown28.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup44.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup";
            spreadsheetCommandGalleryItem211.CommandName = "ConditionalFormattingIconSetArrows3Colored";
            spreadsheetCommandGalleryItem212.CommandName = "ConditionalFormattingIconSetArrows3Grayed";
            spreadsheetCommandGalleryItem213.CommandName = "ConditionalFormattingIconSetArrows4Colored";
            spreadsheetCommandGalleryItem214.CommandName = "ConditionalFormattingIconSetArrows4Grayed";
            spreadsheetCommandGalleryItem215.CommandName = "ConditionalFormattingIconSetArrows5Colored";
            spreadsheetCommandGalleryItem216.CommandName = "ConditionalFormattingIconSetArrows5Grayed";
            spreadsheetCommandGalleryItem217.CommandName = "ConditionalFormattingIconSetTriangles3";
            spreadsheetCommandGalleryItemGroup44.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem211,
            spreadsheetCommandGalleryItem212,
            spreadsheetCommandGalleryItem213,
            spreadsheetCommandGalleryItem214,
            spreadsheetCommandGalleryItem215,
            spreadsheetCommandGalleryItem216,
            spreadsheetCommandGalleryItem217});
            spreadsheetCommandGalleryItemGroup45.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup";
            spreadsheetCommandGalleryItem218.CommandName = "ConditionalFormattingIconSetTrafficLights3";
            spreadsheetCommandGalleryItem219.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed";
            spreadsheetCommandGalleryItem220.CommandName = "ConditionalFormattingIconSetTrafficLights4";
            spreadsheetCommandGalleryItem221.CommandName = "ConditionalFormattingIconSetSigns3";
            spreadsheetCommandGalleryItem222.CommandName = "ConditionalFormattingIconSetRedToBlack";
            spreadsheetCommandGalleryItemGroup45.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem218,
            spreadsheetCommandGalleryItem219,
            spreadsheetCommandGalleryItem220,
            spreadsheetCommandGalleryItem221,
            spreadsheetCommandGalleryItem222});
            spreadsheetCommandGalleryItemGroup46.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup";
            spreadsheetCommandGalleryItem223.CommandName = "ConditionalFormattingIconSetSymbols3Circled";
            spreadsheetCommandGalleryItem224.CommandName = "ConditionalFormattingIconSetSymbols3";
            spreadsheetCommandGalleryItem225.CommandName = "ConditionalFormattingIconSetFlags3";
            spreadsheetCommandGalleryItemGroup46.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem223,
            spreadsheetCommandGalleryItem224,
            spreadsheetCommandGalleryItem225});
            spreadsheetCommandGalleryItemGroup47.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup";
            spreadsheetCommandGalleryItem226.CommandName = "ConditionalFormattingIconSetStars3";
            spreadsheetCommandGalleryItem227.CommandName = "ConditionalFormattingIconSetRatings4";
            spreadsheetCommandGalleryItem228.CommandName = "ConditionalFormattingIconSetRatings5";
            spreadsheetCommandGalleryItem229.CommandName = "ConditionalFormattingIconSetQuarters5";
            spreadsheetCommandGalleryItem230.CommandName = "ConditionalFormattingIconSetBoxes5";
            spreadsheetCommandGalleryItemGroup47.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem226,
            spreadsheetCommandGalleryItem227,
            spreadsheetCommandGalleryItem228,
            spreadsheetCommandGalleryItem229,
            spreadsheetCommandGalleryItem230});
            this.commandBarGalleryDropDown28.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup44,
            spreadsheetCommandGalleryItemGroup45,
            spreadsheetCommandGalleryItemGroup46,
            spreadsheetCommandGalleryItemGroup47});
            this.commandBarGalleryDropDown28.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown28.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown28.Manager = null;
            this.commandBarGalleryDropDown28.Name = "commandBarGalleryDropDown28";
            // 
            // commandBarGalleryDropDown29
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown29.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown29.Gallery.ColumnCount = 7;
            this.commandBarGalleryDropDown29.Gallery.DrawImageBackground = false;
            this.commandBarGalleryDropDown29.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown29.Gallery.ItemSize = new System.Drawing.Size(73, 58);
            this.commandBarGalleryDropDown29.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown29.Manager = null;
            this.commandBarGalleryDropDown29.Name = "commandBarGalleryDropDown29";
            // 
            // commandBarGalleryDropDown30
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown30.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup48.CommandName = "InsertChartColumn2DCommandGroup";
            spreadsheetCommandGalleryItem231.CommandName = "InsertChartColumnClustered2D";
            spreadsheetCommandGalleryItem232.CommandName = "InsertChartColumnStacked2D";
            spreadsheetCommandGalleryItem233.CommandName = "InsertChartColumnPercentStacked2D";
            spreadsheetCommandGalleryItemGroup48.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem231,
            spreadsheetCommandGalleryItem232,
            spreadsheetCommandGalleryItem233});
            spreadsheetCommandGalleryItemGroup49.CommandName = "InsertChartColumn3DCommandGroup";
            spreadsheetCommandGalleryItem234.CommandName = "InsertChartColumnClustered3D";
            spreadsheetCommandGalleryItem235.CommandName = "InsertChartColumnStacked3D";
            spreadsheetCommandGalleryItem236.CommandName = "InsertChartColumnPercentStacked3D";
            spreadsheetCommandGalleryItem237.CommandName = "InsertChartColumn3D";
            spreadsheetCommandGalleryItemGroup49.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem234,
            spreadsheetCommandGalleryItem235,
            spreadsheetCommandGalleryItem236,
            spreadsheetCommandGalleryItem237});
            spreadsheetCommandGalleryItemGroup50.CommandName = "InsertChartCylinderCommandGroup";
            spreadsheetCommandGalleryItem238.CommandName = "InsertChartCylinderClustered";
            spreadsheetCommandGalleryItem239.CommandName = "InsertChartCylinderStacked";
            spreadsheetCommandGalleryItem240.CommandName = "InsertChartCylinderPercentStacked";
            spreadsheetCommandGalleryItem241.CommandName = "InsertChartCylinder";
            spreadsheetCommandGalleryItemGroup50.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem238,
            spreadsheetCommandGalleryItem239,
            spreadsheetCommandGalleryItem240,
            spreadsheetCommandGalleryItem241});
            spreadsheetCommandGalleryItemGroup51.CommandName = "InsertChartConeCommandGroup";
            spreadsheetCommandGalleryItem242.CommandName = "InsertChartConeClustered";
            spreadsheetCommandGalleryItem243.CommandName = "InsertChartConeStacked";
            spreadsheetCommandGalleryItem244.CommandName = "InsertChartConePercentStacked";
            spreadsheetCommandGalleryItem245.CommandName = "InsertChartCone";
            spreadsheetCommandGalleryItemGroup51.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem242,
            spreadsheetCommandGalleryItem243,
            spreadsheetCommandGalleryItem244,
            spreadsheetCommandGalleryItem245});
            spreadsheetCommandGalleryItemGroup52.CommandName = "InsertChartPyramidCommandGroup";
            spreadsheetCommandGalleryItem246.CommandName = "InsertChartPyramidClustered";
            spreadsheetCommandGalleryItem247.CommandName = "InsertChartPyramidStacked";
            spreadsheetCommandGalleryItem248.CommandName = "InsertChartPyramidPercentStacked";
            spreadsheetCommandGalleryItem249.CommandName = "InsertChartPyramid";
            spreadsheetCommandGalleryItemGroup52.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem246,
            spreadsheetCommandGalleryItem247,
            spreadsheetCommandGalleryItem248,
            spreadsheetCommandGalleryItem249});
            this.commandBarGalleryDropDown30.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup48,
            spreadsheetCommandGalleryItemGroup49,
            spreadsheetCommandGalleryItemGroup50,
            spreadsheetCommandGalleryItemGroup51,
            spreadsheetCommandGalleryItemGroup52});
            this.commandBarGalleryDropDown30.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown30.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown30.Manager = null;
            this.commandBarGalleryDropDown30.Name = "commandBarGalleryDropDown30";
            // 
            // commandBarGalleryDropDown31
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown31.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup53.CommandName = "InsertChartLine2DCommandGroup";
            spreadsheetCommandGalleryItem250.CommandName = "InsertChartLine";
            spreadsheetCommandGalleryItem251.CommandName = "InsertChartStackedLine";
            spreadsheetCommandGalleryItem252.CommandName = "InsertChartPercentStackedLine";
            spreadsheetCommandGalleryItem253.CommandName = "InsertChartLineWithMarkers";
            spreadsheetCommandGalleryItem254.CommandName = "InsertChartStackedLineWithMarkers";
            spreadsheetCommandGalleryItem255.CommandName = "InsertChartPercentStackedLineWithMarkers";
            spreadsheetCommandGalleryItemGroup53.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem250,
            spreadsheetCommandGalleryItem251,
            spreadsheetCommandGalleryItem252,
            spreadsheetCommandGalleryItem253,
            spreadsheetCommandGalleryItem254,
            spreadsheetCommandGalleryItem255});
            spreadsheetCommandGalleryItemGroup54.CommandName = "InsertChartLine3DCommandGroup";
            spreadsheetCommandGalleryItem256.CommandName = "InsertChartLine3D";
            spreadsheetCommandGalleryItemGroup54.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem256});
            this.commandBarGalleryDropDown31.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup53,
            spreadsheetCommandGalleryItemGroup54});
            this.commandBarGalleryDropDown31.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown31.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown31.Manager = null;
            this.commandBarGalleryDropDown31.Name = "commandBarGalleryDropDown31";
            // 
            // commandBarGalleryDropDown32
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown32.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup55.CommandName = "InsertChartPie2DCommandGroup";
            spreadsheetCommandGalleryItem257.CommandName = "InsertChartPie2D";
            spreadsheetCommandGalleryItem258.CommandName = "InsertChartPieExploded2D";
            spreadsheetCommandGalleryItemGroup55.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem257,
            spreadsheetCommandGalleryItem258});
            spreadsheetCommandGalleryItemGroup56.CommandName = "InsertChartPie3DCommandGroup";
            spreadsheetCommandGalleryItem259.CommandName = "InsertChartPie3D";
            spreadsheetCommandGalleryItem260.CommandName = "InsertChartPieExploded3D";
            spreadsheetCommandGalleryItemGroup56.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem259,
            spreadsheetCommandGalleryItem260});
            spreadsheetCommandGalleryItemGroup57.CommandName = "InsertChartDoughnut2DCommandGroup";
            spreadsheetCommandGalleryItem261.CommandName = "InsertChartDoughnut2D";
            spreadsheetCommandGalleryItem262.CommandName = "InsertChartDoughnutExploded2D";
            spreadsheetCommandGalleryItemGroup57.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem261,
            spreadsheetCommandGalleryItem262});
            this.commandBarGalleryDropDown32.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup55,
            spreadsheetCommandGalleryItemGroup56,
            spreadsheetCommandGalleryItemGroup57});
            this.commandBarGalleryDropDown32.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown32.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown32.Manager = null;
            this.commandBarGalleryDropDown32.Name = "commandBarGalleryDropDown32";
            // 
            // commandBarGalleryDropDown33
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown33.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup58.CommandName = "InsertChartBar2DCommandGroup";
            spreadsheetCommandGalleryItem263.CommandName = "InsertChartBarClustered2D";
            spreadsheetCommandGalleryItem264.CommandName = "InsertChartBarStacked2D";
            spreadsheetCommandGalleryItem265.CommandName = "InsertChartBarPercentStacked2D";
            spreadsheetCommandGalleryItemGroup58.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem263,
            spreadsheetCommandGalleryItem264,
            spreadsheetCommandGalleryItem265});
            spreadsheetCommandGalleryItemGroup59.CommandName = "InsertChartBar3DCommandGroup";
            spreadsheetCommandGalleryItem266.CommandName = "InsertChartBarClustered3D";
            spreadsheetCommandGalleryItem267.CommandName = "InsertChartBarStacked3D";
            spreadsheetCommandGalleryItem268.CommandName = "InsertChartBarPercentStacked3D";
            spreadsheetCommandGalleryItemGroup59.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem266,
            spreadsheetCommandGalleryItem267,
            spreadsheetCommandGalleryItem268});
            spreadsheetCommandGalleryItemGroup60.CommandName = "InsertChartHorizontalCylinderCommandGroup";
            spreadsheetCommandGalleryItem269.CommandName = "InsertChartHorizontalCylinderClustered";
            spreadsheetCommandGalleryItem270.CommandName = "InsertChartHorizontalCylinderStacked";
            spreadsheetCommandGalleryItem271.CommandName = "InsertChartHorizontalCylinderPercentStacked";
            spreadsheetCommandGalleryItemGroup60.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem269,
            spreadsheetCommandGalleryItem270,
            spreadsheetCommandGalleryItem271});
            spreadsheetCommandGalleryItemGroup61.CommandName = "InsertChartHorizontalConeCommandGroup";
            spreadsheetCommandGalleryItem272.CommandName = "InsertChartHorizontalConeClustered";
            spreadsheetCommandGalleryItem273.CommandName = "InsertChartHorizontalConeStacked";
            spreadsheetCommandGalleryItem274.CommandName = "InsertChartHorizontalConePercentStacked";
            spreadsheetCommandGalleryItemGroup61.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem272,
            spreadsheetCommandGalleryItem273,
            spreadsheetCommandGalleryItem274});
            spreadsheetCommandGalleryItemGroup62.CommandName = "InsertChartHorizontalPyramidCommandGroup";
            spreadsheetCommandGalleryItem275.CommandName = "InsertChartHorizontalPyramidClustered";
            spreadsheetCommandGalleryItem276.CommandName = "InsertChartHorizontalPyramidStacked";
            spreadsheetCommandGalleryItem277.CommandName = "InsertChartHorizontalPyramidPercentStacked";
            spreadsheetCommandGalleryItemGroup62.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem275,
            spreadsheetCommandGalleryItem276,
            spreadsheetCommandGalleryItem277});
            this.commandBarGalleryDropDown33.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup58,
            spreadsheetCommandGalleryItemGroup59,
            spreadsheetCommandGalleryItemGroup60,
            spreadsheetCommandGalleryItemGroup61,
            spreadsheetCommandGalleryItemGroup62});
            this.commandBarGalleryDropDown33.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown33.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown33.Manager = null;
            this.commandBarGalleryDropDown33.Name = "commandBarGalleryDropDown33";
            // 
            // commandBarGalleryDropDown34
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown34.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup63.CommandName = "InsertChartArea2DCommandGroup";
            spreadsheetCommandGalleryItem278.CommandName = "InsertChartArea";
            spreadsheetCommandGalleryItem279.CommandName = "InsertChartStackedArea";
            spreadsheetCommandGalleryItem280.CommandName = "InsertChartPercentStackedArea";
            spreadsheetCommandGalleryItemGroup63.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem278,
            spreadsheetCommandGalleryItem279,
            spreadsheetCommandGalleryItem280});
            spreadsheetCommandGalleryItemGroup64.CommandName = "InsertChartArea3DCommandGroup";
            spreadsheetCommandGalleryItem281.CommandName = "InsertChartArea3D";
            spreadsheetCommandGalleryItem282.CommandName = "InsertChartStackedArea3D";
            spreadsheetCommandGalleryItem283.CommandName = "InsertChartPercentStackedArea3D";
            spreadsheetCommandGalleryItemGroup64.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem281,
            spreadsheetCommandGalleryItem282,
            spreadsheetCommandGalleryItem283});
            this.commandBarGalleryDropDown34.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup63,
            spreadsheetCommandGalleryItemGroup64});
            this.commandBarGalleryDropDown34.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown34.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown34.Manager = null;
            this.commandBarGalleryDropDown34.Name = "commandBarGalleryDropDown34";
            // 
            // commandBarGalleryDropDown35
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown35.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup65.CommandName = "InsertChartScatterCommandGroup";
            spreadsheetCommandGalleryItem284.CommandName = "InsertChartScatterMarkers";
            spreadsheetCommandGalleryItem285.CommandName = "InsertChartScatterSmoothLinesAndMarkers";
            spreadsheetCommandGalleryItem286.CommandName = "InsertChartScatterSmoothLines";
            spreadsheetCommandGalleryItem287.CommandName = "InsertChartScatterLinesAndMarkers";
            spreadsheetCommandGalleryItem288.CommandName = "InsertChartScatterLines";
            spreadsheetCommandGalleryItemGroup65.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem284,
            spreadsheetCommandGalleryItem285,
            spreadsheetCommandGalleryItem286,
            spreadsheetCommandGalleryItem287,
            spreadsheetCommandGalleryItem288});
            spreadsheetCommandGalleryItemGroup66.CommandName = "InsertChartBubbleCommandGroup";
            spreadsheetCommandGalleryItem289.CommandName = "InsertChartBubble";
            spreadsheetCommandGalleryItem290.CommandName = "InsertChartBubble3D";
            spreadsheetCommandGalleryItemGroup66.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem289,
            spreadsheetCommandGalleryItem290});
            this.commandBarGalleryDropDown35.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup65,
            spreadsheetCommandGalleryItemGroup66});
            this.commandBarGalleryDropDown35.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown35.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown35.Manager = null;
            this.commandBarGalleryDropDown35.Name = "commandBarGalleryDropDown35";
            // 
            // commandBarGalleryDropDown36
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown36.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup67.CommandName = "InsertChartStockCommandGroup";
            spreadsheetCommandGalleryItem291.CommandName = "InsertChartStockHighLowClose";
            spreadsheetCommandGalleryItem292.CommandName = "InsertChartStockOpenHighLowClose";
            spreadsheetCommandGalleryItem293.CommandName = "InsertChartStockVolumeHighLowClose";
            spreadsheetCommandGalleryItem294.CommandName = "InsertChartStockVolumeOpenHighLowClose";
            spreadsheetCommandGalleryItemGroup67.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem291,
            spreadsheetCommandGalleryItem292,
            spreadsheetCommandGalleryItem293,
            spreadsheetCommandGalleryItem294});
            spreadsheetCommandGalleryItemGroup68.CommandName = "InsertChartRadarCommandGroup";
            spreadsheetCommandGalleryItem295.CommandName = "InsertChartRadar";
            spreadsheetCommandGalleryItem296.CommandName = "InsertChartRadarWithMarkers";
            spreadsheetCommandGalleryItem297.CommandName = "InsertChartRadarFilled";
            spreadsheetCommandGalleryItemGroup68.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem295,
            spreadsheetCommandGalleryItem296,
            spreadsheetCommandGalleryItem297});
            this.commandBarGalleryDropDown36.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup67,
            spreadsheetCommandGalleryItemGroup68});
            this.commandBarGalleryDropDown36.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown36.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown36.Manager = null;
            this.commandBarGalleryDropDown36.Name = "commandBarGalleryDropDown36";
            // 
            // commandBarGalleryDropDown37
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown37.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown37.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup69.CommandName = "ChartTitleCommandGroup";
            spreadsheetCommandGalleryItem298.CommandName = "ChartTitleNone";
            spreadsheetCommandGalleryItem299.CommandName = "ChartTitleCenteredOverlay";
            spreadsheetCommandGalleryItem300.CommandName = "ChartTitleAbove";
            spreadsheetCommandGalleryItemGroup69.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem298,
            spreadsheetCommandGalleryItem299,
            spreadsheetCommandGalleryItem300});
            this.commandBarGalleryDropDown37.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup69});
            this.commandBarGalleryDropDown37.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown37.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown37.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown37.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown37.Manager = null;
            this.commandBarGalleryDropDown37.Name = "commandBarGalleryDropDown37";
            // 
            // commandBarGalleryDropDown38
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown38.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown38.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup70.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem301.CommandName = "ChartPrimaryHorizontalAxisTitleNone";
            spreadsheetCommandGalleryItem302.CommandName = "ChartPrimaryHorizontalAxisTitleBelow";
            spreadsheetCommandGalleryItemGroup70.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem301,
            spreadsheetCommandGalleryItem302});
            this.commandBarGalleryDropDown38.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup70});
            this.commandBarGalleryDropDown38.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown38.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown38.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown38.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown38.Manager = null;
            this.commandBarGalleryDropDown38.Name = "commandBarGalleryDropDown38";
            // 
            // commandBarGalleryDropDown39
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown39.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown39.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup71.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem303.CommandName = "ChartPrimaryVerticalAxisTitleNone";
            spreadsheetCommandGalleryItem304.CommandName = "ChartPrimaryVerticalAxisTitleRotated";
            spreadsheetCommandGalleryItem305.CommandName = "ChartPrimaryVerticalAxisTitleVertical";
            spreadsheetCommandGalleryItem306.CommandName = "ChartPrimaryVerticalAxisTitleHorizontal";
            spreadsheetCommandGalleryItemGroup71.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem303,
            spreadsheetCommandGalleryItem304,
            spreadsheetCommandGalleryItem305,
            spreadsheetCommandGalleryItem306});
            this.commandBarGalleryDropDown39.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup71});
            this.commandBarGalleryDropDown39.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown39.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown39.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown39.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown39.Manager = null;
            this.commandBarGalleryDropDown39.Name = "commandBarGalleryDropDown39";
            // 
            // commandBarGalleryDropDown40
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown40.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown40.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup72.CommandName = "ChartLegendCommandGroup";
            spreadsheetCommandGalleryItem307.CommandName = "ChartLegendNone";
            spreadsheetCommandGalleryItem308.CommandName = "ChartLegendAtRight";
            spreadsheetCommandGalleryItem309.CommandName = "ChartLegendAtTop";
            spreadsheetCommandGalleryItem310.CommandName = "ChartLegendAtLeft";
            spreadsheetCommandGalleryItem311.CommandName = "ChartLegendAtBottom";
            spreadsheetCommandGalleryItem312.CommandName = "ChartLegendOverlayAtRight";
            spreadsheetCommandGalleryItem313.CommandName = "ChartLegendOverlayAtLeft";
            spreadsheetCommandGalleryItemGroup72.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem307,
            spreadsheetCommandGalleryItem308,
            spreadsheetCommandGalleryItem309,
            spreadsheetCommandGalleryItem310,
            spreadsheetCommandGalleryItem311,
            spreadsheetCommandGalleryItem312,
            spreadsheetCommandGalleryItem313});
            this.commandBarGalleryDropDown40.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup72});
            this.commandBarGalleryDropDown40.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown40.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown40.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown40.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown40.Manager = null;
            this.commandBarGalleryDropDown40.Name = "commandBarGalleryDropDown40";
            // 
            // commandBarGalleryDropDown41
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown41.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown41.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup73.CommandName = "ChartDataLabelsCommandGroup";
            spreadsheetCommandGalleryItem314.CommandName = "ChartDataLabelsNone";
            spreadsheetCommandGalleryItem315.CommandName = "ChartDataLabelsDefault";
            spreadsheetCommandGalleryItem316.CommandName = "ChartDataLabelsCenter";
            spreadsheetCommandGalleryItem317.CommandName = "ChartDataLabelsInsideEnd";
            spreadsheetCommandGalleryItem318.CommandName = "ChartDataLabelsInsideBase";
            spreadsheetCommandGalleryItem319.CommandName = "ChartDataLabelsOutsideEnd";
            spreadsheetCommandGalleryItem320.CommandName = "ChartDataLabelsBestFit";
            spreadsheetCommandGalleryItem321.CommandName = "ChartDataLabelsLeft";
            spreadsheetCommandGalleryItem322.CommandName = "ChartDataLabelsRight";
            spreadsheetCommandGalleryItem323.CommandName = "ChartDataLabelsAbove";
            spreadsheetCommandGalleryItem324.CommandName = "ChartDataLabelsBelow";
            spreadsheetCommandGalleryItemGroup73.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem314,
            spreadsheetCommandGalleryItem315,
            spreadsheetCommandGalleryItem316,
            spreadsheetCommandGalleryItem317,
            spreadsheetCommandGalleryItem318,
            spreadsheetCommandGalleryItem319,
            spreadsheetCommandGalleryItem320,
            spreadsheetCommandGalleryItem321,
            spreadsheetCommandGalleryItem322,
            spreadsheetCommandGalleryItem323,
            spreadsheetCommandGalleryItem324});
            this.commandBarGalleryDropDown41.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup73});
            this.commandBarGalleryDropDown41.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown41.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown41.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown41.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown41.Manager = null;
            this.commandBarGalleryDropDown41.Name = "commandBarGalleryDropDown41";
            // 
            // commandBarGalleryDropDown42
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown42.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown42.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup74.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
            spreadsheetCommandGalleryItem325.CommandName = "ChartHidePrimaryHorizontalAxis";
            spreadsheetCommandGalleryItem326.CommandName = "ChartPrimaryHorizontalAxisLeftToRight";
            spreadsheetCommandGalleryItem327.CommandName = "ChartPrimaryHorizontalAxisHideLabels";
            spreadsheetCommandGalleryItem328.CommandName = "ChartPrimaryHorizontalAxisRightToLeft";
            spreadsheetCommandGalleryItem329.CommandName = "ChartPrimaryHorizontalAxisDefault";
            spreadsheetCommandGalleryItem330.CommandName = "ChartPrimaryHorizontalAxisScaleThousands";
            spreadsheetCommandGalleryItem331.CommandName = "ChartPrimaryHorizontalAxisScaleMillions";
            spreadsheetCommandGalleryItem332.CommandName = "ChartPrimaryHorizontalAxisScaleBillions";
            spreadsheetCommandGalleryItem333.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm";
            spreadsheetCommandGalleryItemGroup74.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem325,
            spreadsheetCommandGalleryItem326,
            spreadsheetCommandGalleryItem327,
            spreadsheetCommandGalleryItem328,
            spreadsheetCommandGalleryItem329,
            spreadsheetCommandGalleryItem330,
            spreadsheetCommandGalleryItem331,
            spreadsheetCommandGalleryItem332,
            spreadsheetCommandGalleryItem333});
            this.commandBarGalleryDropDown42.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup74});
            this.commandBarGalleryDropDown42.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown42.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown42.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown42.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown42.Manager = null;
            this.commandBarGalleryDropDown42.Name = "commandBarGalleryDropDown42";
            // 
            // commandBarGalleryDropDown43
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown43.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown43.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup75.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
            spreadsheetCommandGalleryItem334.CommandName = "ChartHidePrimaryVerticalAxis";
            spreadsheetCommandGalleryItem335.CommandName = "ChartPrimaryVerticalAxisLeftToRight";
            spreadsheetCommandGalleryItem336.CommandName = "ChartPrimaryVerticalAxisHideLabels";
            spreadsheetCommandGalleryItem337.CommandName = "ChartPrimaryVerticalAxisRightToLeft";
            spreadsheetCommandGalleryItem338.CommandName = "ChartPrimaryVerticalAxisDefault";
            spreadsheetCommandGalleryItem339.CommandName = "ChartPrimaryVerticalAxisScaleThousands";
            spreadsheetCommandGalleryItem340.CommandName = "ChartPrimaryVerticalAxisScaleMillions";
            spreadsheetCommandGalleryItem341.CommandName = "ChartPrimaryVerticalAxisScaleBillions";
            spreadsheetCommandGalleryItem342.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm";
            spreadsheetCommandGalleryItemGroup75.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem334,
            spreadsheetCommandGalleryItem335,
            spreadsheetCommandGalleryItem336,
            spreadsheetCommandGalleryItem337,
            spreadsheetCommandGalleryItem338,
            spreadsheetCommandGalleryItem339,
            spreadsheetCommandGalleryItem340,
            spreadsheetCommandGalleryItem341,
            spreadsheetCommandGalleryItem342});
            this.commandBarGalleryDropDown43.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup75});
            this.commandBarGalleryDropDown43.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown43.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown43.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown43.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown43.Manager = null;
            this.commandBarGalleryDropDown43.Name = "commandBarGalleryDropDown43";
            // 
            // commandBarGalleryDropDown44
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown44.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown44.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup76.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem343.CommandName = "ChartPrimaryHorizontalGridlinesNone";
            spreadsheetCommandGalleryItem344.CommandName = "ChartPrimaryHorizontalGridlinesMajor";
            spreadsheetCommandGalleryItem345.CommandName = "ChartPrimaryHorizontalGridlinesMinor";
            spreadsheetCommandGalleryItem346.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItemGroup76.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem343,
            spreadsheetCommandGalleryItem344,
            spreadsheetCommandGalleryItem345,
            spreadsheetCommandGalleryItem346});
            this.commandBarGalleryDropDown44.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup76});
            this.commandBarGalleryDropDown44.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown44.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown44.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown44.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown44.Manager = null;
            this.commandBarGalleryDropDown44.Name = "commandBarGalleryDropDown44";
            // 
            // commandBarGalleryDropDown45
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown45.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown45.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup77.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem347.CommandName = "ChartPrimaryVerticalGridlinesNone";
            spreadsheetCommandGalleryItem348.CommandName = "ChartPrimaryVerticalGridlinesMajor";
            spreadsheetCommandGalleryItem349.CommandName = "ChartPrimaryVerticalGridlinesMinor";
            spreadsheetCommandGalleryItem350.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItemGroup77.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem347,
            spreadsheetCommandGalleryItem348,
            spreadsheetCommandGalleryItem349,
            spreadsheetCommandGalleryItem350});
            this.commandBarGalleryDropDown45.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup77});
            this.commandBarGalleryDropDown45.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown45.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown45.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown45.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown45.Manager = null;
            this.commandBarGalleryDropDown45.Name = "commandBarGalleryDropDown45";
            // 
            // commandBarGalleryDropDown46
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown46.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown46.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup78.CommandName = "ChartLinesCommandGroup";
            spreadsheetCommandGalleryItem351.CommandName = "ChartLinesNone";
            spreadsheetCommandGalleryItem352.CommandName = "ChartShowDropLines";
            spreadsheetCommandGalleryItem353.CommandName = "ChartShowHighLowLines";
            spreadsheetCommandGalleryItem354.CommandName = "ChartShowDropLinesAndHighLowLines";
            spreadsheetCommandGalleryItem355.CommandName = "ChartShowSeriesLines";
            spreadsheetCommandGalleryItemGroup78.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem351,
            spreadsheetCommandGalleryItem352,
            spreadsheetCommandGalleryItem353,
            spreadsheetCommandGalleryItem354,
            spreadsheetCommandGalleryItem355});
            this.commandBarGalleryDropDown46.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup78});
            this.commandBarGalleryDropDown46.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown46.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown46.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown46.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown46.Manager = null;
            this.commandBarGalleryDropDown46.Name = "commandBarGalleryDropDown46";
            // 
            // commandBarGalleryDropDown47
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown47.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown47.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup79.CommandName = "ChartUpDownBarsCommandGroup";
            spreadsheetCommandGalleryItem356.CommandName = "ChartHideUpDownBars";
            spreadsheetCommandGalleryItem357.CommandName = "ChartShowUpDownBars";
            spreadsheetCommandGalleryItemGroup79.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem356,
            spreadsheetCommandGalleryItem357});
            this.commandBarGalleryDropDown47.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup79});
            this.commandBarGalleryDropDown47.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown47.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown47.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown47.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown47.Manager = null;
            this.commandBarGalleryDropDown47.Name = "commandBarGalleryDropDown47";
            // 
            // commandBarGalleryDropDown48
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown48.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown48.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup80.CommandName = "ChartErrorBarsCommandGroup";
            spreadsheetCommandGalleryItem358.CommandName = "ChartErrorBarsNone";
            spreadsheetCommandGalleryItem359.CommandName = "ChartErrorBarsStandardError";
            spreadsheetCommandGalleryItem360.CommandName = "ChartErrorBarsPercentage";
            spreadsheetCommandGalleryItem361.CommandName = "ChartErrorBarsStandardDeviation";
            spreadsheetCommandGalleryItemGroup80.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem358,
            spreadsheetCommandGalleryItem359,
            spreadsheetCommandGalleryItem360,
            spreadsheetCommandGalleryItem361});
            this.commandBarGalleryDropDown48.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup80});
            this.commandBarGalleryDropDown48.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown48.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown48.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown48.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown48.Manager = null;
            this.commandBarGalleryDropDown48.Name = "commandBarGalleryDropDown48";
            // 
            // commandBarGalleryDropDown2
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown2.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup81.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup";
            spreadsheetCommandGalleryItem362.CommandName = "ConditionalFormattingDataBarGradientBlue";
            spreadsheetCommandGalleryItem363.CommandName = "ConditionalFormattingDataBarGradientGreen";
            spreadsheetCommandGalleryItem364.CommandName = "ConditionalFormattingDataBarGradientRed";
            spreadsheetCommandGalleryItem365.CommandName = "ConditionalFormattingDataBarGradientOrange";
            spreadsheetCommandGalleryItem366.CommandName = "ConditionalFormattingDataBarGradientLightBlue";
            spreadsheetCommandGalleryItem367.CommandName = "ConditionalFormattingDataBarGradientPurple";
            spreadsheetCommandGalleryItemGroup81.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem362,
            spreadsheetCommandGalleryItem363,
            spreadsheetCommandGalleryItem364,
            spreadsheetCommandGalleryItem365,
            spreadsheetCommandGalleryItem366,
            spreadsheetCommandGalleryItem367});
            spreadsheetCommandGalleryItemGroup82.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup";
            spreadsheetCommandGalleryItem368.CommandName = "ConditionalFormattingDataBarSolidBlue";
            spreadsheetCommandGalleryItem369.CommandName = "ConditionalFormattingDataBarSolidGreen";
            spreadsheetCommandGalleryItem370.CommandName = "ConditionalFormattingDataBarSolidRed";
            spreadsheetCommandGalleryItem371.CommandName = "ConditionalFormattingDataBarSolidOrange";
            spreadsheetCommandGalleryItem372.CommandName = "ConditionalFormattingDataBarSolidLightBlue";
            spreadsheetCommandGalleryItem373.CommandName = "ConditionalFormattingDataBarSolidPurple";
            spreadsheetCommandGalleryItemGroup82.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem368,
            spreadsheetCommandGalleryItem369,
            spreadsheetCommandGalleryItem370,
            spreadsheetCommandGalleryItem371,
            spreadsheetCommandGalleryItem372,
            spreadsheetCommandGalleryItem373});
            this.commandBarGalleryDropDown2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup81,
            spreadsheetCommandGalleryItemGroup82});
            this.commandBarGalleryDropDown2.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown2.Manager = null;
            this.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2";
            // 
            // commandBarGalleryDropDown1
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown1.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown1.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown1.Gallery.DrawImageBackground = false;
            galleryItem15.Tag = DevExpress.Export.Xl.XlBorderLineStyle.None;
            galleryItem16.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thin;
            galleryItem17.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Hair;
            galleryItem18.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dotted;
            galleryItem19.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dashed;
            galleryItem20.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDot;
            galleryItem21.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDotDot;
            galleryItem22.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Double;
            galleryItem23.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Medium;
            galleryItem24.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashed;
            galleryItem25.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDot;
            galleryItem26.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDotDot;
            galleryItem27.Tag = DevExpress.Export.Xl.XlBorderLineStyle.SlantDashDot;
            galleryItem28.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thick;
            galleryItemGroup3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem15,
            galleryItem16,
            galleryItem17,
            galleryItem18,
            galleryItem19,
            galleryItem20,
            galleryItem21,
            galleryItem22,
            galleryItem23,
            galleryItem24,
            galleryItem25,
            galleryItem26,
            galleryItem27,
            galleryItem28});
            this.commandBarGalleryDropDown1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup3});
            this.commandBarGalleryDropDown1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.commandBarGalleryDropDown1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown1.Gallery.ItemSize = new System.Drawing.Size(136, 26);
            this.commandBarGalleryDropDown1.Gallery.RowCount = 14;
            this.commandBarGalleryDropDown1.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown1.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown1.Manager = null;
            this.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1";
            // 
            // commandBarGalleryDropDown3
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown3.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup83.CommandName = "ConditionalFormattingColorScalesCommandGroup";
            spreadsheetCommandGalleryItem374.CommandName = "ConditionalFormattingColorScaleGreenYellowRed";
            spreadsheetCommandGalleryItem375.CommandName = "ConditionalFormattingColorScaleRedYellowGreen";
            spreadsheetCommandGalleryItem376.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed";
            spreadsheetCommandGalleryItem377.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen";
            spreadsheetCommandGalleryItem378.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed";
            spreadsheetCommandGalleryItem379.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue";
            spreadsheetCommandGalleryItem380.CommandName = "ConditionalFormattingColorScaleWhiteRed";
            spreadsheetCommandGalleryItem381.CommandName = "ConditionalFormattingColorScaleRedWhite";
            spreadsheetCommandGalleryItem382.CommandName = "ConditionalFormattingColorScaleGreenWhite";
            spreadsheetCommandGalleryItem383.CommandName = "ConditionalFormattingColorScaleWhiteGreen";
            spreadsheetCommandGalleryItem384.CommandName = "ConditionalFormattingColorScaleGreenYellow";
            spreadsheetCommandGalleryItem385.CommandName = "ConditionalFormattingColorScaleYellowGreen";
            spreadsheetCommandGalleryItemGroup83.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem374,
            spreadsheetCommandGalleryItem375,
            spreadsheetCommandGalleryItem376,
            spreadsheetCommandGalleryItem377,
            spreadsheetCommandGalleryItem378,
            spreadsheetCommandGalleryItem379,
            spreadsheetCommandGalleryItem380,
            spreadsheetCommandGalleryItem381,
            spreadsheetCommandGalleryItem382,
            spreadsheetCommandGalleryItem383,
            spreadsheetCommandGalleryItem384,
            spreadsheetCommandGalleryItem385});
            this.commandBarGalleryDropDown3.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup83});
            this.commandBarGalleryDropDown3.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown3.Manager = null;
            this.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3";
            // 
            // commandBarGalleryDropDown4
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown4.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup84.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup";
            spreadsheetCommandGalleryItem386.CommandName = "ConditionalFormattingIconSetArrows3Colored";
            spreadsheetCommandGalleryItem387.CommandName = "ConditionalFormattingIconSetArrows3Grayed";
            spreadsheetCommandGalleryItem388.CommandName = "ConditionalFormattingIconSetArrows4Colored";
            spreadsheetCommandGalleryItem389.CommandName = "ConditionalFormattingIconSetArrows4Grayed";
            spreadsheetCommandGalleryItem390.CommandName = "ConditionalFormattingIconSetArrows5Colored";
            spreadsheetCommandGalleryItem391.CommandName = "ConditionalFormattingIconSetArrows5Grayed";
            spreadsheetCommandGalleryItem392.CommandName = "ConditionalFormattingIconSetTriangles3";
            spreadsheetCommandGalleryItemGroup84.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem386,
            spreadsheetCommandGalleryItem387,
            spreadsheetCommandGalleryItem388,
            spreadsheetCommandGalleryItem389,
            spreadsheetCommandGalleryItem390,
            spreadsheetCommandGalleryItem391,
            spreadsheetCommandGalleryItem392});
            spreadsheetCommandGalleryItemGroup85.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup";
            spreadsheetCommandGalleryItem393.CommandName = "ConditionalFormattingIconSetTrafficLights3";
            spreadsheetCommandGalleryItem394.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed";
            spreadsheetCommandGalleryItem395.CommandName = "ConditionalFormattingIconSetTrafficLights4";
            spreadsheetCommandGalleryItem396.CommandName = "ConditionalFormattingIconSetSigns3";
            spreadsheetCommandGalleryItem397.CommandName = "ConditionalFormattingIconSetRedToBlack";
            spreadsheetCommandGalleryItemGroup85.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem393,
            spreadsheetCommandGalleryItem394,
            spreadsheetCommandGalleryItem395,
            spreadsheetCommandGalleryItem396,
            spreadsheetCommandGalleryItem397});
            spreadsheetCommandGalleryItemGroup86.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup";
            spreadsheetCommandGalleryItem398.CommandName = "ConditionalFormattingIconSetSymbols3Circled";
            spreadsheetCommandGalleryItem399.CommandName = "ConditionalFormattingIconSetSymbols3";
            spreadsheetCommandGalleryItem400.CommandName = "ConditionalFormattingIconSetFlags3";
            spreadsheetCommandGalleryItemGroup86.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem398,
            spreadsheetCommandGalleryItem399,
            spreadsheetCommandGalleryItem400});
            spreadsheetCommandGalleryItemGroup87.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup";
            spreadsheetCommandGalleryItem401.CommandName = "ConditionalFormattingIconSetStars3";
            spreadsheetCommandGalleryItem402.CommandName = "ConditionalFormattingIconSetRatings4";
            spreadsheetCommandGalleryItem403.CommandName = "ConditionalFormattingIconSetRatings5";
            spreadsheetCommandGalleryItem404.CommandName = "ConditionalFormattingIconSetQuarters5";
            spreadsheetCommandGalleryItem405.CommandName = "ConditionalFormattingIconSetBoxes5";
            spreadsheetCommandGalleryItemGroup87.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem401,
            spreadsheetCommandGalleryItem402,
            spreadsheetCommandGalleryItem403,
            spreadsheetCommandGalleryItem404,
            spreadsheetCommandGalleryItem405});
            this.commandBarGalleryDropDown4.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup84,
            spreadsheetCommandGalleryItemGroup85,
            spreadsheetCommandGalleryItemGroup86,
            spreadsheetCommandGalleryItemGroup87});
            this.commandBarGalleryDropDown4.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown4.Manager = null;
            this.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4";
            // 
            // commandBarGalleryDropDown5
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown5.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown5.Gallery.ColumnCount = 7;
            this.commandBarGalleryDropDown5.Gallery.DrawImageBackground = false;
            this.commandBarGalleryDropDown5.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown5.Gallery.ItemSize = new System.Drawing.Size(73, 58);
            this.commandBarGalleryDropDown5.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown5.Manager = null;
            this.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5";
            // 
            // commandBarGalleryDropDown6
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown6.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup88.CommandName = "InsertChartColumn2DCommandGroup";
            spreadsheetCommandGalleryItem406.CommandName = "InsertChartColumnClustered2D";
            spreadsheetCommandGalleryItem407.CommandName = "InsertChartColumnStacked2D";
            spreadsheetCommandGalleryItem408.CommandName = "InsertChartColumnPercentStacked2D";
            spreadsheetCommandGalleryItemGroup88.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem406,
            spreadsheetCommandGalleryItem407,
            spreadsheetCommandGalleryItem408});
            spreadsheetCommandGalleryItemGroup89.CommandName = "InsertChartColumn3DCommandGroup";
            spreadsheetCommandGalleryItem409.CommandName = "InsertChartColumnClustered3D";
            spreadsheetCommandGalleryItem410.CommandName = "InsertChartColumnStacked3D";
            spreadsheetCommandGalleryItem411.CommandName = "InsertChartColumnPercentStacked3D";
            spreadsheetCommandGalleryItem412.CommandName = "InsertChartColumn3D";
            spreadsheetCommandGalleryItemGroup89.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem409,
            spreadsheetCommandGalleryItem410,
            spreadsheetCommandGalleryItem411,
            spreadsheetCommandGalleryItem412});
            spreadsheetCommandGalleryItemGroup90.CommandName = "InsertChartCylinderCommandGroup";
            spreadsheetCommandGalleryItem413.CommandName = "InsertChartCylinderClustered";
            spreadsheetCommandGalleryItem414.CommandName = "InsertChartCylinderStacked";
            spreadsheetCommandGalleryItem415.CommandName = "InsertChartCylinderPercentStacked";
            spreadsheetCommandGalleryItem416.CommandName = "InsertChartCylinder";
            spreadsheetCommandGalleryItemGroup90.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem413,
            spreadsheetCommandGalleryItem414,
            spreadsheetCommandGalleryItem415,
            spreadsheetCommandGalleryItem416});
            spreadsheetCommandGalleryItemGroup91.CommandName = "InsertChartConeCommandGroup";
            spreadsheetCommandGalleryItem417.CommandName = "InsertChartConeClustered";
            spreadsheetCommandGalleryItem418.CommandName = "InsertChartConeStacked";
            spreadsheetCommandGalleryItem419.CommandName = "InsertChartConePercentStacked";
            spreadsheetCommandGalleryItem420.CommandName = "InsertChartCone";
            spreadsheetCommandGalleryItemGroup91.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem417,
            spreadsheetCommandGalleryItem418,
            spreadsheetCommandGalleryItem419,
            spreadsheetCommandGalleryItem420});
            spreadsheetCommandGalleryItemGroup92.CommandName = "InsertChartPyramidCommandGroup";
            spreadsheetCommandGalleryItem421.CommandName = "InsertChartPyramidClustered";
            spreadsheetCommandGalleryItem422.CommandName = "InsertChartPyramidStacked";
            spreadsheetCommandGalleryItem423.CommandName = "InsertChartPyramidPercentStacked";
            spreadsheetCommandGalleryItem424.CommandName = "InsertChartPyramid";
            spreadsheetCommandGalleryItemGroup92.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem421,
            spreadsheetCommandGalleryItem422,
            spreadsheetCommandGalleryItem423,
            spreadsheetCommandGalleryItem424});
            this.commandBarGalleryDropDown6.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup88,
            spreadsheetCommandGalleryItemGroup89,
            spreadsheetCommandGalleryItemGroup90,
            spreadsheetCommandGalleryItemGroup91,
            spreadsheetCommandGalleryItemGroup92});
            this.commandBarGalleryDropDown6.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown6.Manager = null;
            this.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6";
            // 
            // commandBarGalleryDropDown7
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown7.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup93.CommandName = "InsertChartLine2DCommandGroup";
            spreadsheetCommandGalleryItem425.CommandName = "InsertChartLine";
            spreadsheetCommandGalleryItem426.CommandName = "InsertChartStackedLine";
            spreadsheetCommandGalleryItem427.CommandName = "InsertChartPercentStackedLine";
            spreadsheetCommandGalleryItem428.CommandName = "InsertChartLineWithMarkers";
            spreadsheetCommandGalleryItem429.CommandName = "InsertChartStackedLineWithMarkers";
            spreadsheetCommandGalleryItem430.CommandName = "InsertChartPercentStackedLineWithMarkers";
            spreadsheetCommandGalleryItemGroup93.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem425,
            spreadsheetCommandGalleryItem426,
            spreadsheetCommandGalleryItem427,
            spreadsheetCommandGalleryItem428,
            spreadsheetCommandGalleryItem429,
            spreadsheetCommandGalleryItem430});
            spreadsheetCommandGalleryItemGroup94.CommandName = "InsertChartLine3DCommandGroup";
            spreadsheetCommandGalleryItem431.CommandName = "InsertChartLine3D";
            spreadsheetCommandGalleryItemGroup94.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem431});
            this.commandBarGalleryDropDown7.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup93,
            spreadsheetCommandGalleryItemGroup94});
            this.commandBarGalleryDropDown7.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown7.Manager = null;
            this.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7";
            // 
            // commandBarGalleryDropDown8
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown8.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup95.CommandName = "InsertChartPie2DCommandGroup";
            spreadsheetCommandGalleryItem432.CommandName = "InsertChartPie2D";
            spreadsheetCommandGalleryItem433.CommandName = "InsertChartPieExploded2D";
            spreadsheetCommandGalleryItemGroup95.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem432,
            spreadsheetCommandGalleryItem433});
            spreadsheetCommandGalleryItemGroup96.CommandName = "InsertChartPie3DCommandGroup";
            spreadsheetCommandGalleryItem434.CommandName = "InsertChartPie3D";
            spreadsheetCommandGalleryItem435.CommandName = "InsertChartPieExploded3D";
            spreadsheetCommandGalleryItemGroup96.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem434,
            spreadsheetCommandGalleryItem435});
            spreadsheetCommandGalleryItemGroup97.CommandName = "InsertChartDoughnut2DCommandGroup";
            spreadsheetCommandGalleryItem436.CommandName = "InsertChartDoughnut2D";
            spreadsheetCommandGalleryItem437.CommandName = "InsertChartDoughnutExploded2D";
            spreadsheetCommandGalleryItemGroup97.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem436,
            spreadsheetCommandGalleryItem437});
            this.commandBarGalleryDropDown8.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup95,
            spreadsheetCommandGalleryItemGroup96,
            spreadsheetCommandGalleryItemGroup97});
            this.commandBarGalleryDropDown8.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown8.Manager = null;
            this.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8";
            // 
            // commandBarGalleryDropDown9
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown9.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup98.CommandName = "InsertChartBar2DCommandGroup";
            spreadsheetCommandGalleryItem438.CommandName = "InsertChartBarClustered2D";
            spreadsheetCommandGalleryItem439.CommandName = "InsertChartBarStacked2D";
            spreadsheetCommandGalleryItem440.CommandName = "InsertChartBarPercentStacked2D";
            spreadsheetCommandGalleryItemGroup98.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem438,
            spreadsheetCommandGalleryItem439,
            spreadsheetCommandGalleryItem440});
            spreadsheetCommandGalleryItemGroup99.CommandName = "InsertChartBar3DCommandGroup";
            spreadsheetCommandGalleryItem441.CommandName = "InsertChartBarClustered3D";
            spreadsheetCommandGalleryItem442.CommandName = "InsertChartBarStacked3D";
            spreadsheetCommandGalleryItem443.CommandName = "InsertChartBarPercentStacked3D";
            spreadsheetCommandGalleryItemGroup99.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem441,
            spreadsheetCommandGalleryItem442,
            spreadsheetCommandGalleryItem443});
            spreadsheetCommandGalleryItemGroup100.CommandName = "InsertChartHorizontalCylinderCommandGroup";
            spreadsheetCommandGalleryItem444.CommandName = "InsertChartHorizontalCylinderClustered";
            spreadsheetCommandGalleryItem445.CommandName = "InsertChartHorizontalCylinderStacked";
            spreadsheetCommandGalleryItem446.CommandName = "InsertChartHorizontalCylinderPercentStacked";
            spreadsheetCommandGalleryItemGroup100.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem444,
            spreadsheetCommandGalleryItem445,
            spreadsheetCommandGalleryItem446});
            spreadsheetCommandGalleryItemGroup101.CommandName = "InsertChartHorizontalConeCommandGroup";
            spreadsheetCommandGalleryItem447.CommandName = "InsertChartHorizontalConeClustered";
            spreadsheetCommandGalleryItem448.CommandName = "InsertChartHorizontalConeStacked";
            spreadsheetCommandGalleryItem449.CommandName = "InsertChartHorizontalConePercentStacked";
            spreadsheetCommandGalleryItemGroup101.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem447,
            spreadsheetCommandGalleryItem448,
            spreadsheetCommandGalleryItem449});
            spreadsheetCommandGalleryItemGroup102.CommandName = "InsertChartHorizontalPyramidCommandGroup";
            spreadsheetCommandGalleryItem450.CommandName = "InsertChartHorizontalPyramidClustered";
            spreadsheetCommandGalleryItem451.CommandName = "InsertChartHorizontalPyramidStacked";
            spreadsheetCommandGalleryItem452.CommandName = "InsertChartHorizontalPyramidPercentStacked";
            spreadsheetCommandGalleryItemGroup102.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem450,
            spreadsheetCommandGalleryItem451,
            spreadsheetCommandGalleryItem452});
            this.commandBarGalleryDropDown9.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup98,
            spreadsheetCommandGalleryItemGroup99,
            spreadsheetCommandGalleryItemGroup100,
            spreadsheetCommandGalleryItemGroup101,
            spreadsheetCommandGalleryItemGroup102});
            this.commandBarGalleryDropDown9.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown9.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown9.Manager = null;
            this.commandBarGalleryDropDown9.Name = "commandBarGalleryDropDown9";
            // 
            // commandBarGalleryDropDown10
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown10.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup103.CommandName = "InsertChartArea2DCommandGroup";
            spreadsheetCommandGalleryItem453.CommandName = "InsertChartArea";
            spreadsheetCommandGalleryItem454.CommandName = "InsertChartStackedArea";
            spreadsheetCommandGalleryItem455.CommandName = "InsertChartPercentStackedArea";
            spreadsheetCommandGalleryItemGroup103.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem453,
            spreadsheetCommandGalleryItem454,
            spreadsheetCommandGalleryItem455});
            spreadsheetCommandGalleryItemGroup104.CommandName = "InsertChartArea3DCommandGroup";
            spreadsheetCommandGalleryItem456.CommandName = "InsertChartArea3D";
            spreadsheetCommandGalleryItem457.CommandName = "InsertChartStackedArea3D";
            spreadsheetCommandGalleryItem458.CommandName = "InsertChartPercentStackedArea3D";
            spreadsheetCommandGalleryItemGroup104.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem456,
            spreadsheetCommandGalleryItem457,
            spreadsheetCommandGalleryItem458});
            this.commandBarGalleryDropDown10.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup103,
            spreadsheetCommandGalleryItemGroup104});
            this.commandBarGalleryDropDown10.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown10.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown10.Manager = null;
            this.commandBarGalleryDropDown10.Name = "commandBarGalleryDropDown10";
            // 
            // commandBarGalleryDropDown11
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown11.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup105.CommandName = "InsertChartScatterCommandGroup";
            spreadsheetCommandGalleryItem459.CommandName = "InsertChartScatterMarkers";
            spreadsheetCommandGalleryItem460.CommandName = "InsertChartScatterSmoothLinesAndMarkers";
            spreadsheetCommandGalleryItem461.CommandName = "InsertChartScatterSmoothLines";
            spreadsheetCommandGalleryItem462.CommandName = "InsertChartScatterLinesAndMarkers";
            spreadsheetCommandGalleryItem463.CommandName = "InsertChartScatterLines";
            spreadsheetCommandGalleryItemGroup105.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem459,
            spreadsheetCommandGalleryItem460,
            spreadsheetCommandGalleryItem461,
            spreadsheetCommandGalleryItem462,
            spreadsheetCommandGalleryItem463});
            spreadsheetCommandGalleryItemGroup106.CommandName = "InsertChartBubbleCommandGroup";
            spreadsheetCommandGalleryItem464.CommandName = "InsertChartBubble";
            spreadsheetCommandGalleryItem465.CommandName = "InsertChartBubble3D";
            spreadsheetCommandGalleryItemGroup106.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem464,
            spreadsheetCommandGalleryItem465});
            this.commandBarGalleryDropDown11.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup105,
            spreadsheetCommandGalleryItemGroup106});
            this.commandBarGalleryDropDown11.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown11.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown11.Manager = null;
            this.commandBarGalleryDropDown11.Name = "commandBarGalleryDropDown11";
            // 
            // commandBarGalleryDropDown12
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown12.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup107.CommandName = "InsertChartStockCommandGroup";
            spreadsheetCommandGalleryItem466.CommandName = "InsertChartStockHighLowClose";
            spreadsheetCommandGalleryItem467.CommandName = "InsertChartStockOpenHighLowClose";
            spreadsheetCommandGalleryItemGroup107.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem466,
            spreadsheetCommandGalleryItem467});
            spreadsheetCommandGalleryItemGroup108.CommandName = "InsertChartRadarCommandGroup";
            spreadsheetCommandGalleryItem468.CommandName = "InsertChartRadar";
            spreadsheetCommandGalleryItem469.CommandName = "InsertChartRadarWithMarkers";
            spreadsheetCommandGalleryItem470.CommandName = "InsertChartRadarFilled";
            spreadsheetCommandGalleryItemGroup108.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem468,
            spreadsheetCommandGalleryItem469,
            spreadsheetCommandGalleryItem470});
            this.commandBarGalleryDropDown12.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup107,
            spreadsheetCommandGalleryItemGroup108});
            this.commandBarGalleryDropDown12.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown12.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown12.Manager = null;
            this.commandBarGalleryDropDown12.Name = "commandBarGalleryDropDown12";
            // 
            // commandBarGalleryDropDown13
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown13.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown13.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup109.CommandName = "ChartTitleCommandGroup";
            spreadsheetCommandGalleryItem471.CommandName = "ChartTitleNone";
            spreadsheetCommandGalleryItem472.CommandName = "ChartTitleCenteredOverlay";
            spreadsheetCommandGalleryItem473.CommandName = "ChartTitleAbove";
            spreadsheetCommandGalleryItemGroup109.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem471,
            spreadsheetCommandGalleryItem472,
            spreadsheetCommandGalleryItem473});
            this.commandBarGalleryDropDown13.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup109});
            this.commandBarGalleryDropDown13.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown13.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown13.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown13.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown13.Manager = null;
            this.commandBarGalleryDropDown13.Name = "commandBarGalleryDropDown13";
            // 
            // commandBarGalleryDropDown14
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown14.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown14.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup110.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem474.CommandName = "ChartPrimaryHorizontalAxisTitleNone";
            spreadsheetCommandGalleryItem475.CommandName = "ChartPrimaryHorizontalAxisTitleBelow";
            spreadsheetCommandGalleryItemGroup110.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem474,
            spreadsheetCommandGalleryItem475});
            this.commandBarGalleryDropDown14.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup110});
            this.commandBarGalleryDropDown14.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown14.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown14.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown14.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown14.Manager = null;
            this.commandBarGalleryDropDown14.Name = "commandBarGalleryDropDown14";
            // 
            // commandBarGalleryDropDown15
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown15.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown15.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup111.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem476.CommandName = "ChartPrimaryVerticalAxisTitleNone";
            spreadsheetCommandGalleryItem477.CommandName = "ChartPrimaryVerticalAxisTitleRotated";
            spreadsheetCommandGalleryItem478.CommandName = "ChartPrimaryVerticalAxisTitleVertical";
            spreadsheetCommandGalleryItem479.CommandName = "ChartPrimaryVerticalAxisTitleHorizontal";
            spreadsheetCommandGalleryItemGroup111.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem476,
            spreadsheetCommandGalleryItem477,
            spreadsheetCommandGalleryItem478,
            spreadsheetCommandGalleryItem479});
            this.commandBarGalleryDropDown15.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup111});
            this.commandBarGalleryDropDown15.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown15.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown15.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown15.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown15.Manager = null;
            this.commandBarGalleryDropDown15.Name = "commandBarGalleryDropDown15";
            // 
            // commandBarGalleryDropDown16
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown16.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown16.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup112.CommandName = "ChartLegendCommandGroup";
            spreadsheetCommandGalleryItem480.CommandName = "ChartLegendNone";
            spreadsheetCommandGalleryItem481.CommandName = "ChartLegendAtRight";
            spreadsheetCommandGalleryItem482.CommandName = "ChartLegendAtTop";
            spreadsheetCommandGalleryItem483.CommandName = "ChartLegendAtLeft";
            spreadsheetCommandGalleryItem484.CommandName = "ChartLegendAtBottom";
            spreadsheetCommandGalleryItem485.CommandName = "ChartLegendOverlayAtRight";
            spreadsheetCommandGalleryItem486.CommandName = "ChartLegendOverlayAtLeft";
            spreadsheetCommandGalleryItemGroup112.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem480,
            spreadsheetCommandGalleryItem481,
            spreadsheetCommandGalleryItem482,
            spreadsheetCommandGalleryItem483,
            spreadsheetCommandGalleryItem484,
            spreadsheetCommandGalleryItem485,
            spreadsheetCommandGalleryItem486});
            this.commandBarGalleryDropDown16.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup112});
            this.commandBarGalleryDropDown16.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown16.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown16.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown16.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown16.Manager = null;
            this.commandBarGalleryDropDown16.Name = "commandBarGalleryDropDown16";
            // 
            // commandBarGalleryDropDown17
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown17.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown17.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup113.CommandName = "ChartDataLabelsCommandGroup";
            spreadsheetCommandGalleryItem487.CommandName = "ChartDataLabelsNone";
            spreadsheetCommandGalleryItem488.CommandName = "ChartDataLabelsDefault";
            spreadsheetCommandGalleryItem489.CommandName = "ChartDataLabelsCenter";
            spreadsheetCommandGalleryItem490.CommandName = "ChartDataLabelsInsideEnd";
            spreadsheetCommandGalleryItem491.CommandName = "ChartDataLabelsInsideBase";
            spreadsheetCommandGalleryItem492.CommandName = "ChartDataLabelsOutsideEnd";
            spreadsheetCommandGalleryItem493.CommandName = "ChartDataLabelsBestFit";
            spreadsheetCommandGalleryItem494.CommandName = "ChartDataLabelsLeft";
            spreadsheetCommandGalleryItem495.CommandName = "ChartDataLabelsRight";
            spreadsheetCommandGalleryItem496.CommandName = "ChartDataLabelsAbove";
            spreadsheetCommandGalleryItem497.CommandName = "ChartDataLabelsBelow";
            spreadsheetCommandGalleryItemGroup113.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem487,
            spreadsheetCommandGalleryItem488,
            spreadsheetCommandGalleryItem489,
            spreadsheetCommandGalleryItem490,
            spreadsheetCommandGalleryItem491,
            spreadsheetCommandGalleryItem492,
            spreadsheetCommandGalleryItem493,
            spreadsheetCommandGalleryItem494,
            spreadsheetCommandGalleryItem495,
            spreadsheetCommandGalleryItem496,
            spreadsheetCommandGalleryItem497});
            this.commandBarGalleryDropDown17.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup113});
            this.commandBarGalleryDropDown17.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown17.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown17.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown17.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown17.Manager = null;
            this.commandBarGalleryDropDown17.Name = "commandBarGalleryDropDown17";
            // 
            // commandBarGalleryDropDown18
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown18.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown18.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup114.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
            spreadsheetCommandGalleryItem498.CommandName = "ChartHidePrimaryHorizontalAxis";
            spreadsheetCommandGalleryItem499.CommandName = "ChartPrimaryHorizontalAxisLeftToRight";
            spreadsheetCommandGalleryItem500.CommandName = "ChartPrimaryHorizontalAxisHideLabels";
            spreadsheetCommandGalleryItem501.CommandName = "ChartPrimaryHorizontalAxisRightToLeft";
            spreadsheetCommandGalleryItem502.CommandName = "ChartPrimaryHorizontalAxisDefault";
            spreadsheetCommandGalleryItem503.CommandName = "ChartPrimaryHorizontalAxisScaleThousands";
            spreadsheetCommandGalleryItem504.CommandName = "ChartPrimaryHorizontalAxisScaleMillions";
            spreadsheetCommandGalleryItem505.CommandName = "ChartPrimaryHorizontalAxisScaleBillions";
            spreadsheetCommandGalleryItem506.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm";
            spreadsheetCommandGalleryItemGroup114.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem498,
            spreadsheetCommandGalleryItem499,
            spreadsheetCommandGalleryItem500,
            spreadsheetCommandGalleryItem501,
            spreadsheetCommandGalleryItem502,
            spreadsheetCommandGalleryItem503,
            spreadsheetCommandGalleryItem504,
            spreadsheetCommandGalleryItem505,
            spreadsheetCommandGalleryItem506});
            this.commandBarGalleryDropDown18.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup114});
            this.commandBarGalleryDropDown18.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown18.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown18.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown18.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown18.Manager = null;
            this.commandBarGalleryDropDown18.Name = "commandBarGalleryDropDown18";
            // 
            // commandBarGalleryDropDown19
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown19.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown19.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup115.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
            spreadsheetCommandGalleryItem507.CommandName = "ChartHidePrimaryVerticalAxis";
            spreadsheetCommandGalleryItem508.CommandName = "ChartPrimaryVerticalAxisLeftToRight";
            spreadsheetCommandGalleryItem509.CommandName = "ChartPrimaryVerticalAxisHideLabels";
            spreadsheetCommandGalleryItem510.CommandName = "ChartPrimaryVerticalAxisRightToLeft";
            spreadsheetCommandGalleryItem511.CommandName = "ChartPrimaryVerticalAxisDefault";
            spreadsheetCommandGalleryItem512.CommandName = "ChartPrimaryVerticalAxisScaleThousands";
            spreadsheetCommandGalleryItem513.CommandName = "ChartPrimaryVerticalAxisScaleMillions";
            spreadsheetCommandGalleryItem514.CommandName = "ChartPrimaryVerticalAxisScaleBillions";
            spreadsheetCommandGalleryItem515.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm";
            spreadsheetCommandGalleryItemGroup115.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem507,
            spreadsheetCommandGalleryItem508,
            spreadsheetCommandGalleryItem509,
            spreadsheetCommandGalleryItem510,
            spreadsheetCommandGalleryItem511,
            spreadsheetCommandGalleryItem512,
            spreadsheetCommandGalleryItem513,
            spreadsheetCommandGalleryItem514,
            spreadsheetCommandGalleryItem515});
            this.commandBarGalleryDropDown19.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup115});
            this.commandBarGalleryDropDown19.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown19.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown19.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown19.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown19.Manager = null;
            this.commandBarGalleryDropDown19.Name = "commandBarGalleryDropDown19";
            // 
            // commandBarGalleryDropDown20
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown20.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown20.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup116.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem516.CommandName = "ChartPrimaryHorizontalGridlinesNone";
            spreadsheetCommandGalleryItem517.CommandName = "ChartPrimaryHorizontalGridlinesMajor";
            spreadsheetCommandGalleryItem518.CommandName = "ChartPrimaryHorizontalGridlinesMinor";
            spreadsheetCommandGalleryItem519.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItemGroup116.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem516,
            spreadsheetCommandGalleryItem517,
            spreadsheetCommandGalleryItem518,
            spreadsheetCommandGalleryItem519});
            this.commandBarGalleryDropDown20.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup116});
            this.commandBarGalleryDropDown20.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown20.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown20.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown20.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown20.Manager = null;
            this.commandBarGalleryDropDown20.Name = "commandBarGalleryDropDown20";
            // 
            // commandBarGalleryDropDown21
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown21.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown21.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup117.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem520.CommandName = "ChartPrimaryVerticalGridlinesNone";
            spreadsheetCommandGalleryItem521.CommandName = "ChartPrimaryVerticalGridlinesMajor";
            spreadsheetCommandGalleryItem522.CommandName = "ChartPrimaryVerticalGridlinesMinor";
            spreadsheetCommandGalleryItem523.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItemGroup117.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem520,
            spreadsheetCommandGalleryItem521,
            spreadsheetCommandGalleryItem522,
            spreadsheetCommandGalleryItem523});
            this.commandBarGalleryDropDown21.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup117});
            this.commandBarGalleryDropDown21.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown21.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown21.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown21.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown21.Manager = null;
            this.commandBarGalleryDropDown21.Name = "commandBarGalleryDropDown21";
            // 
            // commandBarGalleryDropDown22
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown22.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown22.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup118.CommandName = "ChartLinesCommandGroup";
            spreadsheetCommandGalleryItem524.CommandName = "ChartLinesNone";
            spreadsheetCommandGalleryItem525.CommandName = "ChartShowDropLines";
            spreadsheetCommandGalleryItem526.CommandName = "ChartShowHighLowLines";
            spreadsheetCommandGalleryItem527.CommandName = "ChartShowDropLinesAndHighLowLines";
            spreadsheetCommandGalleryItem528.CommandName = "ChartShowSeriesLines";
            spreadsheetCommandGalleryItemGroup118.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem524,
            spreadsheetCommandGalleryItem525,
            spreadsheetCommandGalleryItem526,
            spreadsheetCommandGalleryItem527,
            spreadsheetCommandGalleryItem528});
            this.commandBarGalleryDropDown22.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup118});
            this.commandBarGalleryDropDown22.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown22.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown22.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown22.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown22.Manager = null;
            this.commandBarGalleryDropDown22.Name = "commandBarGalleryDropDown22";
            // 
            // commandBarGalleryDropDown23
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown23.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown23.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup119.CommandName = "ChartUpDownBarsCommandGroup";
            spreadsheetCommandGalleryItem529.CommandName = "ChartHideUpDownBars";
            spreadsheetCommandGalleryItem530.CommandName = "ChartShowUpDownBars";
            spreadsheetCommandGalleryItemGroup119.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem529,
            spreadsheetCommandGalleryItem530});
            this.commandBarGalleryDropDown23.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup119});
            this.commandBarGalleryDropDown23.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown23.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown23.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown23.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown23.Manager = null;
            this.commandBarGalleryDropDown23.Name = "commandBarGalleryDropDown23";
            // 
            // commandBarGalleryDropDown24
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown24.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown24.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup120.CommandName = "ChartErrorBarsCommandGroup";
            spreadsheetCommandGalleryItem531.CommandName = "ChartErrorBarsNone";
            spreadsheetCommandGalleryItem532.CommandName = "ChartErrorBarsStandardError";
            spreadsheetCommandGalleryItem533.CommandName = "ChartErrorBarsPercentage";
            spreadsheetCommandGalleryItem534.CommandName = "ChartErrorBarsStandardDeviation";
            spreadsheetCommandGalleryItemGroup120.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem531,
            spreadsheetCommandGalleryItem532,
            spreadsheetCommandGalleryItem533,
            spreadsheetCommandGalleryItem534});
            this.commandBarGalleryDropDown24.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup120});
            this.commandBarGalleryDropDown24.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown24.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown24.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown24.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown24.Manager = null;
            this.commandBarGalleryDropDown24.Name = "commandBarGalleryDropDown24";
            // 
            // fromFaxEdit
            // 
            this.fromFaxEdit.EditValue = "(111)111-1112";
            this.fromFaxEdit.Location = new System.Drawing.Point(286, 71);
            this.fromFaxEdit.Name = "fromFaxEdit";
            this.fromFaxEdit.Size = new System.Drawing.Size(134, 20);
            this.fromFaxEdit.TabIndex = 28;
            // 
            // fromFaxLabel
            // 
            this.fromFaxLabel.Location = new System.Drawing.Point(236, 74);
            this.fromFaxLabel.Name = "fromFaxLabel";
            this.fromFaxLabel.Size = new System.Drawing.Size(22, 13);
            this.fromFaxLabel.TabIndex = 27;
            this.fromFaxLabel.Text = "Fax:";
            // 
            // fromPhoneEdit
            // 
            this.fromPhoneEdit.EditValue = "(111)111-1111";
            this.fromPhoneEdit.Location = new System.Drawing.Point(105, 71);
            this.fromPhoneEdit.Name = "fromPhoneEdit";
            this.fromPhoneEdit.Size = new System.Drawing.Size(125, 20);
            this.fromPhoneEdit.TabIndex = 26;
            // 
            // fromPhoneLabel
            // 
            this.fromPhoneLabel.Location = new System.Drawing.Point(12, 74);
            this.fromPhoneLabel.Name = "fromPhoneLabel";
            this.fromPhoneLabel.Size = new System.Drawing.Size(34, 13);
            this.fromPhoneLabel.TabIndex = 25;
            this.fromPhoneLabel.Text = "Phone:";
            // 
            // fromZipEdit
            // 
            this.fromZipEdit.EditValue = "55555";
            this.fromZipEdit.Location = new System.Drawing.Point(602, 47);
            this.fromZipEdit.Name = "fromZipEdit";
            this.fromZipEdit.Size = new System.Drawing.Size(78, 20);
            this.fromZipEdit.TabIndex = 24;
            // 
            // fromZipLabel
            // 
            this.fromZipLabel.Location = new System.Drawing.Point(556, 50);
            this.fromZipLabel.Name = "fromZipLabel";
            this.fromZipLabel.Size = new System.Drawing.Size(20, 13);
            this.fromZipLabel.TabIndex = 23;
            this.fromZipLabel.Text = "ZIP:";
            // 
            // fromStateEdit
            // 
            this.fromStateEdit.EditValue = "CA";
            this.fromStateEdit.Location = new System.Drawing.Point(472, 47);
            this.fromStateEdit.Name = "fromStateEdit";
            this.fromStateEdit.Size = new System.Drawing.Size(78, 20);
            this.fromStateEdit.TabIndex = 22;
            // 
            // fromStateLabel
            // 
            this.fromStateLabel.Location = new System.Drawing.Point(426, 50);
            this.fromStateLabel.Name = "fromStateLabel";
            this.fromStateLabel.Size = new System.Drawing.Size(30, 13);
            this.fromStateLabel.TabIndex = 21;
            this.fromStateLabel.Text = "State:";
            // 
            // fromCityEdit
            // 
            this.fromCityEdit.EditValue = "Homesville";
            this.fromCityEdit.Location = new System.Drawing.Point(286, 47);
            this.fromCityEdit.Name = "fromCityEdit";
            this.fromCityEdit.Size = new System.Drawing.Size(134, 20);
            this.fromCityEdit.TabIndex = 20;
            // 
            // fromCityLabel
            // 
            this.fromCityLabel.Location = new System.Drawing.Point(236, 50);
            this.fromCityLabel.Name = "fromCityLabel";
            this.fromCityLabel.Size = new System.Drawing.Size(23, 13);
            this.fromCityLabel.TabIndex = 19;
            this.fromCityLabel.Text = "City:";
            // 
            // fromAddressEdit
            // 
            this.fromAddressEdit.EditValue = "123 Home Lane";
            this.fromAddressEdit.Location = new System.Drawing.Point(105, 47);
            this.fromAddressEdit.Name = "fromAddressEdit";
            this.fromAddressEdit.Size = new System.Drawing.Size(125, 20);
            this.fromAddressEdit.TabIndex = 18;
            // 
            // fromAddressLabel
            // 
            this.fromAddressLabel.Location = new System.Drawing.Point(12, 50);
            this.fromAddressLabel.Name = "fromAddressLabel";
            this.fromAddressLabel.Size = new System.Drawing.Size(76, 13);
            this.fromAddressLabel.TabIndex = 17;
            this.fromAddressLabel.Text = "Street Address:";
            // 
            // fromCompanySloganEdit
            // 
            this.fromCompanySloganEdit.EditValue = "Do what must be done";
            this.fromCompanySloganEdit.Location = new System.Drawing.Point(286, 23);
            this.fromCompanySloganEdit.Name = "fromCompanySloganEdit";
            this.fromCompanySloganEdit.Size = new System.Drawing.Size(394, 20);
            this.fromCompanySloganEdit.TabIndex = 16;
            // 
            // fromCompanySloganLabel
            // 
            this.fromCompanySloganLabel.Location = new System.Drawing.Point(236, 26);
            this.fromCompanySloganLabel.Name = "fromCompanySloganLabel";
            this.fromCompanySloganLabel.Size = new System.Drawing.Size(36, 13);
            this.fromCompanySloganLabel.TabIndex = 15;
            this.fromCompanySloganLabel.Text = "Slogan:";
            // 
            // fromCompanyEdit
            // 
            this.fromCompanyEdit.EditValue = "Vader Enterprises";
            this.fromCompanyEdit.Location = new System.Drawing.Point(105, 23);
            this.fromCompanyEdit.Name = "fromCompanyEdit";
            this.fromCompanyEdit.Size = new System.Drawing.Size(125, 20);
            this.fromCompanyEdit.TabIndex = 14;
            // 
            // fromCompanyLabel
            // 
            this.fromCompanyLabel.Location = new System.Drawing.Point(12, 26);
            this.fromCompanyLabel.Name = "fromCompanyLabel";
            this.fromCompanyLabel.Size = new System.Drawing.Size(49, 13);
            this.fromCompanyLabel.TabIndex = 13;
            this.fromCompanyLabel.Text = "Company:";
            // 
            // toCompanyNameEdit
            // 
            this.toCompanyNameEdit.EditValue = "Mickeys World of Fun";
            this.toCompanyNameEdit.Location = new System.Drawing.Point(286, 24);
            this.toCompanyNameEdit.Name = "toCompanyNameEdit";
            this.toCompanyNameEdit.Size = new System.Drawing.Size(134, 20);
            this.toCompanyNameEdit.TabIndex = 32;
            // 
            // toCompanylabel
            // 
            this.toCompanylabel.Location = new System.Drawing.Point(236, 27);
            this.toCompanylabel.Name = "toCompanylabel";
            this.toCompanylabel.Size = new System.Drawing.Size(49, 13);
            this.toCompanylabel.TabIndex = 39;
            this.toCompanylabel.Text = "Company:";
            // 
            // toPhoneEdit
            // 
            this.toPhoneEdit.EditValue = "(203)290-8902";
            this.toPhoneEdit.Location = new System.Drawing.Point(105, 72);
            this.toPhoneEdit.Name = "toPhoneEdit";
            this.toPhoneEdit.Size = new System.Drawing.Size(125, 20);
            this.toPhoneEdit.TabIndex = 42;
            // 
            // toPhoneLabel
            // 
            this.toPhoneLabel.Location = new System.Drawing.Point(12, 75);
            this.toPhoneLabel.Name = "toPhoneLabel";
            this.toPhoneLabel.Size = new System.Drawing.Size(34, 13);
            this.toPhoneLabel.TabIndex = 37;
            this.toPhoneLabel.Text = "Phone:";
            // 
            // toZipEdit
            // 
            this.toZipEdit.EditValue = "37288";
            this.toZipEdit.Location = new System.Drawing.Point(601, 48);
            this.toZipEdit.Name = "toZipEdit";
            this.toZipEdit.Size = new System.Drawing.Size(78, 20);
            this.toZipEdit.TabIndex = 40;
            // 
            // toZipLabel
            // 
            this.toZipLabel.Location = new System.Drawing.Point(556, 51);
            this.toZipLabel.Name = "toZipLabel";
            this.toZipLabel.Size = new System.Drawing.Size(20, 13);
            this.toZipLabel.TabIndex = 35;
            this.toZipLabel.Text = "ZIP:";
            // 
            // toStateEdit
            // 
            this.toStateEdit.EditValue = "OH";
            this.toStateEdit.Location = new System.Drawing.Point(472, 48);
            this.toStateEdit.Name = "toStateEdit";
            this.toStateEdit.Size = new System.Drawing.Size(78, 20);
            this.toStateEdit.TabIndex = 38;
            // 
            // toStateLabel
            // 
            this.toStateLabel.Location = new System.Drawing.Point(426, 51);
            this.toStateLabel.Name = "toStateLabel";
            this.toStateLabel.Size = new System.Drawing.Size(30, 13);
            this.toStateLabel.TabIndex = 33;
            this.toStateLabel.Text = "State:";
            // 
            // toCityEdit
            // 
            this.toCityEdit.EditValue = "Cleveland";
            this.toCityEdit.Location = new System.Drawing.Point(286, 48);
            this.toCityEdit.Name = "toCityEdit";
            this.toCityEdit.Size = new System.Drawing.Size(134, 20);
            this.toCityEdit.TabIndex = 36;
            // 
            // toCityLabel
            // 
            this.toCityLabel.Location = new System.Drawing.Point(236, 51);
            this.toCityLabel.Name = "toCityLabel";
            this.toCityLabel.Size = new System.Drawing.Size(23, 13);
            this.toCityLabel.TabIndex = 31;
            this.toCityLabel.Text = "City:";
            // 
            // toStreetEdit
            // 
            this.toStreetEdit.EditValue = "436 1st Ave.";
            this.toStreetEdit.Location = new System.Drawing.Point(105, 48);
            this.toStreetEdit.Name = "toStreetEdit";
            this.toStreetEdit.Size = new System.Drawing.Size(125, 20);
            this.toStreetEdit.TabIndex = 34;
            // 
            // toStreetLabel
            // 
            this.toStreetLabel.Location = new System.Drawing.Point(12, 51);
            this.toStreetLabel.Name = "toStreetLabel";
            this.toStreetLabel.Size = new System.Drawing.Size(76, 13);
            this.toStreetLabel.TabIndex = 29;
            this.toStreetLabel.Text = "Street Address:";
            // 
            // toNameEdit
            // 
            this.toNameEdit.EditValue = "Alcorn Mickey";
            this.toNameEdit.Location = new System.Drawing.Point(105, 24);
            this.toNameEdit.Name = "toNameEdit";
            this.toNameEdit.Size = new System.Drawing.Size(125, 20);
            this.toNameEdit.TabIndex = 30;
            // 
            // toNameLabel
            // 
            this.toNameLabel.Location = new System.Drawing.Point(12, 27);
            this.toNameLabel.Name = "toNameLabel";
            this.toNameLabel.Size = new System.Drawing.Size(31, 13);
            this.toNameLabel.TabIndex = 27;
            this.toNameLabel.Text = "Name:";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.mainTabControl.Appearance.Options.UseBackColor = true;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.mainTabControl.Location = new System.Drawing.Point(0, 116);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedTabPage = this.invoiceTabPage;
            this.mainTabControl.Size = new System.Drawing.Size(696, 362);
            this.mainTabControl.TabIndex = 54;
            this.mainTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.dataTabPage,
            this.invoiceTabPage});
            this.mainTabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // invoiceTabPage
            // 
            this.invoiceTabPage.Controls.Add(this.panelControl1);
            this.invoiceTabPage.Name = "invoiceTabPage";
            this.invoiceTabPage.Size = new System.Drawing.Size(690, 334);
            this.invoiceTabPage.Text = "Invoice";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.spreadsheetControl1);
            this.panelControl1.Controls.Add(this.splitterControl1);
            this.panelControl1.Controls.Add(this.splitContainerControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(690, 334);
            this.panelControl1.TabIndex = 0;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(2, 22);
            this.splitterControl1.MinSize = 20;
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(686, 5);
            this.splitterControl1.TabIndex = 51;
            this.splitterControl1.TabStop = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.MinimumSize = new System.Drawing.Size(0, 20);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.spreadsheetNameBoxControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.spreadsheetFormulaBarControl1);
            this.splitContainerControl1.Size = new System.Drawing.Size(686, 20);
            this.splitContainerControl1.TabIndex = 52;
            // 
            // spreadsheetNameBoxControl1
            // 
            this.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetNameBoxControl1.EditValue = "A1";
            this.spreadsheetNameBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1";
            this.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spreadsheetNameBoxControl1.ReadOnly = DevExpress.Utils.DefaultBoolean.Default;
            this.spreadsheetNameBoxControl1.Size = new System.Drawing.Size(100, 20);
            this.spreadsheetNameBoxControl1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetNameBoxControl1.TabIndex = 0;
            // 
            // spreadsheetFormulaBarControl1
            // 
            this.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetFormulaBarControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetFormulaBarControl1.MinimumSize = new System.Drawing.Size(0, 20);
            this.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1";
            this.spreadsheetFormulaBarControl1.Size = new System.Drawing.Size(581, 20);
            this.spreadsheetFormulaBarControl1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetFormulaBarControl1.TabIndex = 0;
            // 
            // dataTabPage
            // 
            this.dataTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dataTabPage.Appearance.PageClient.Options.UseBackColor = true;
            this.dataTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dataTabPage.Controls.Add(this.toGroupControl);
            this.dataTabPage.Controls.Add(this.fromGroupControl);
            this.dataTabPage.Controls.Add(this.gridControl1);
            this.dataTabPage.Name = "dataTabPage";
            this.dataTabPage.Size = new System.Drawing.Size(690, 403);
            this.dataTabPage.Text = "Data";
            // 
            // toGroupControl
            // 
            this.toGroupControl.Controls.Add(this.toCompanyNameEdit);
            this.toGroupControl.Controls.Add(this.toNameEdit);
            this.toGroupControl.Controls.Add(this.toCompanylabel);
            this.toGroupControl.Controls.Add(this.toNameLabel);
            this.toGroupControl.Controls.Add(this.toPhoneEdit);
            this.toGroupControl.Controls.Add(this.toStreetLabel);
            this.toGroupControl.Controls.Add(this.toPhoneLabel);
            this.toGroupControl.Controls.Add(this.toStreetEdit);
            this.toGroupControl.Controls.Add(this.toZipEdit);
            this.toGroupControl.Controls.Add(this.toCityLabel);
            this.toGroupControl.Controls.Add(this.toZipLabel);
            this.toGroupControl.Controls.Add(this.toCityEdit);
            this.toGroupControl.Controls.Add(this.toStateEdit);
            this.toGroupControl.Controls.Add(this.toStateLabel);
            this.toGroupControl.Location = new System.Drawing.Point(3, 128);
            this.toGroupControl.Name = "toGroupControl";
            this.toGroupControl.Size = new System.Drawing.Size(684, 97);
            this.toGroupControl.TabIndex = 56;
            this.toGroupControl.Text = "Bill to";
            // 
            // fromGroupControl
            // 
            this.fromGroupControl.Controls.Add(this.fromContactNameLabel);
            this.fromGroupControl.Controls.Add(this.fromContactNameEdit);
            this.fromGroupControl.Controls.Add(this.fromEMailLabel);
            this.fromGroupControl.Controls.Add(this.fromEMailEdit);
            this.fromGroupControl.Controls.Add(this.fromFaxEdit);
            this.fromGroupControl.Controls.Add(this.fromCompanyLabel);
            this.fromGroupControl.Controls.Add(this.fromFaxLabel);
            this.fromGroupControl.Controls.Add(this.fromCompanyEdit);
            this.fromGroupControl.Controls.Add(this.fromPhoneEdit);
            this.fromGroupControl.Controls.Add(this.fromPhoneLabel);
            this.fromGroupControl.Controls.Add(this.fromCompanySloganLabel);
            this.fromGroupControl.Controls.Add(this.fromCompanySloganEdit);
            this.fromGroupControl.Controls.Add(this.fromZipEdit);
            this.fromGroupControl.Controls.Add(this.fromAddressLabel);
            this.fromGroupControl.Controls.Add(this.fromZipLabel);
            this.fromGroupControl.Controls.Add(this.fromAddressEdit);
            this.fromGroupControl.Controls.Add(this.fromStateEdit);
            this.fromGroupControl.Controls.Add(this.fromCityLabel);
            this.fromGroupControl.Controls.Add(this.fromStateLabel);
            this.fromGroupControl.Controls.Add(this.fromCityEdit);
            this.fromGroupControl.Location = new System.Drawing.Point(3, 4);
            this.fromGroupControl.Name = "fromGroupControl";
            this.fromGroupControl.Size = new System.Drawing.Size(684, 120);
            this.fromGroupControl.TabIndex = 55;
            this.fromGroupControl.Text = "From";
            // 
            // fromContactNameLabel
            // 
            this.fromContactNameLabel.Location = new System.Drawing.Point(12, 98);
            this.fromContactNameLabel.Name = "fromContactNameLabel";
            this.fromContactNameLabel.Size = new System.Drawing.Size(78, 13);
            this.fromContactNameLabel.TabIndex = 29;
            this.fromContactNameLabel.Text = "Contact Person:";
            // 
            // fromContactNameEdit
            // 
            this.fromContactNameEdit.EditValue = "Darth Vader";
            this.fromContactNameEdit.Location = new System.Drawing.Point(105, 95);
            this.fromContactNameEdit.Name = "fromContactNameEdit";
            this.fromContactNameEdit.Size = new System.Drawing.Size(125, 20);
            this.fromContactNameEdit.TabIndex = 30;
            // 
            // fromEMailLabel
            // 
            this.fromEMailLabel.Location = new System.Drawing.Point(236, 98);
            this.fromEMailLabel.Name = "fromEMailLabel";
            this.fromEMailLabel.Size = new System.Drawing.Size(28, 13);
            this.fromEMailLabel.TabIndex = 31;
            this.fromEMailLabel.Text = "Email:";
            // 
            // fromEMailEdit
            // 
            this.fromEMailEdit.EditValue = "darth@vader.com";
            this.fromEMailEdit.Location = new System.Drawing.Point(286, 95);
            this.fromEMailEdit.Name = "fromEMailEdit";
            this.fromEMailEdit.Size = new System.Drawing.Size(134, 20);
            this.fromEMailEdit.TabIndex = 32;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.productsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 229);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.includeItemCheckEdit});
            this.gridControl1.Size = new System.Drawing.Size(684, 290);
            this.gridControl1.TabIndex = 54;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colProductName,
            this.colQuantity,
            this.colDiscount,
            this.colUnitPrice});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUnitPrice, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = " ";
            this.gridColumn1.ColumnEdit = this.includeItemCheckEdit;
            this.gridColumn1.FieldName = "AppendIntoInvoice";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridColumn1.ToolTip = "You can add up to 18 items to invoice";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 23;
            // 
            // includeItemCheckEdit
            // 
            this.includeItemCheckEdit.AutoHeight = false;
            this.includeItemCheckEdit.Caption = "Check";
            this.includeItemCheckEdit.Name = "includeItemCheckEdit";
            this.includeItemCheckEdit.CheckStateChanged += new System.EventHandler(this.includeItemCheckEdit_CheckStateChanged);
            // 
            // colProductName
            // 
            this.colProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductName.Caption = "Product Name";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.ReadOnly = true;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 510;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQuantity.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 58;
            // 
            // colDiscount
            // 
            this.colDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiscount.Caption = "Discount, %";
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDiscount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 3;
            this.colDiscount.Width = 81;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitPrice.Caption = "Unit Price";
            this.colUnitPrice.DisplayFormat.FormatString = "0.00";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colUnitPrice.OptionsColumn.ReadOnly = true;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 4;
            this.colUnitPrice.Width = 122;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // spreadsheetBarController1
            // 
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem107);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem108);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem109);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem110);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem111);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem119);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem120);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem121);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem122);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem123);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem7);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem10);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem11);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem12);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem13);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem14);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem15);
            this.spreadsheetBarController1.BarItems.Add(this.changeFontNameItem1);
            this.spreadsheetBarController1.BarItems.Add(this.changeFontSizeItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem16);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem17);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem18);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem19);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem20);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem21);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem22);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem23);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem24);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem25);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem26);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem27);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem28);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem29);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem30);
            this.spreadsheetBarController1.BarItems.Add(this.changeBorderLineColorItem1);
            this.spreadsheetBarController1.BarItems.Add(this.changeBorderLineStyleItem1);
            this.spreadsheetBarController1.BarItems.Add(this.changeCellFillColorItem1);
            this.spreadsheetBarController1.BarItems.Add(this.changeFontColorItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem7);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem10);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem31);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem32);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem11);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem12);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem33);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem34);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem35);
            this.spreadsheetBarController1.BarItems.Add(this.changeNumberFormatItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem36);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem37);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem38);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem39);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem40);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem41);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem42);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem43);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem44);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem45);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem46);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem47);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem48);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem49);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem50);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem51);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem52);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem53);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem54);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem55);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem56);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem57);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem58);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem7);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem59);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem60);
            this.spreadsheetBarController1.BarItems.Add(this.galleryFormatAsTableItem1);
            this.spreadsheetBarController1.BarItems.Add(this.galleryChangeStyleItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem61);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem62);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem63);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem64);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem65);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem66);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem10);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem67);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem68);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem69);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem70);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem71);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem11);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem72);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem73);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem74);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem75);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem76);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem77);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem78);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem79);
            this.spreadsheetBarController1.BarItems.Add(this.changeSheetTabColorItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem80);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem13);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem81);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem12);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem82);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem83);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem84);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem85);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem86);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem13);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem87);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem88);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem89);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem90);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem14);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem91);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem92);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem93);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem94);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem95);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem96);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem15);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem97);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem98);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem14);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem99);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem100);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem16);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem101);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem102);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem103);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem104);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem105);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem106);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem112);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem113);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem114);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem115);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem7);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem10);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem116);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem117);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem17);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem15);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem16);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem17);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem118);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem18);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem18);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem19);
            this.spreadsheetBarController1.BarItems.Add(this.pageSetupPaperKindItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem19);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem124);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem125);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem126);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem127);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem20);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem21);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem22);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem23);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem20);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem128);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem129);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem21);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem130);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem131);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem22);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem132);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem133);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem134);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem135);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem136);
            this.spreadsheetBarController1.BarItems.Add(this.functionsFinancialItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsLogicalItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsTextItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsDateAndTimeItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsLookupAndReferenceItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsMathAndTrigonometryItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem23);
            this.spreadsheetBarController1.BarItems.Add(this.functionsStatisticalItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsEngineeringItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsInformationItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsCompatibilityItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsWebItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem137);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem138);
            this.spreadsheetBarController1.BarItems.Add(this.definedNameListItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem139);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem24);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem24);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem25);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem26);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem140);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem141);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem25);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem142);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem143);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem144);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem26);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem145);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem146);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem27);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem147);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem148);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem149);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem150);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem151);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem152);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem153);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem154);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem155);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem156);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem157);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem158);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem159);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem160);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem161);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem162);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem163);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem28);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem164);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem165);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem166);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem167);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem168);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem169);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem170);
            this.spreadsheetBarController1.BarItems.Add(this.galleryChartLayoutItem1);
            this.spreadsheetBarController1.BarItems.Add(this.galleryChartStyleItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem29);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem11);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem12);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem30);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem13);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem14);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem15);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem31);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem16);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem17);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem18);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem19);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem20);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem21);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem22);
            this.spreadsheetBarController1.BarItems.Add(this.renameTableItemCaption1);
            this.spreadsheetBarController1.BarItems.Add(this.renameTableItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem27);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem28);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem29);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem30);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem31);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem32);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem33);
            this.spreadsheetBarController1.BarItems.Add(this.galleryTableStylesItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem171);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem172);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem173);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem174);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem175);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem176);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem177);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem32);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem178);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem179);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem180);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem33);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem181);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem182);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem34);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem183);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem184);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem185);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem186);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem35);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem187);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem188);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem189);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem190);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem34);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem35);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem36);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem36);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem191);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem192);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem193);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem37);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem194);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem195);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem196);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem197);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem38);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem198);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem199);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem200);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem201);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem202);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem39);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem203);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem204);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem37);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem38);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem39);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem40);
            this.spreadsheetBarController1.BarItems.Add(this.galleryPivotStylesItem1);
            this.spreadsheetBarController1.Control = this.spreadsheetControl1;
            // 
            // spreadsheetCommandBarButtonItem107
            // 
            this.spreadsheetCommandBarButtonItem107.CommandName = "FunctionsInsertSum";
            this.spreadsheetCommandBarButtonItem107.Id = -1;
            this.spreadsheetCommandBarButtonItem107.Name = "spreadsheetCommandBarButtonItem107";
            // 
            // spreadsheetCommandBarButtonItem108
            // 
            this.spreadsheetCommandBarButtonItem108.CommandName = "FunctionsInsertAverage";
            this.spreadsheetCommandBarButtonItem108.Id = -1;
            this.spreadsheetCommandBarButtonItem108.Name = "spreadsheetCommandBarButtonItem108";
            // 
            // spreadsheetCommandBarButtonItem109
            // 
            this.spreadsheetCommandBarButtonItem109.CommandName = "FunctionsInsertCountNumbers";
            this.spreadsheetCommandBarButtonItem109.Id = -1;
            this.spreadsheetCommandBarButtonItem109.Name = "spreadsheetCommandBarButtonItem109";
            // 
            // spreadsheetCommandBarButtonItem110
            // 
            this.spreadsheetCommandBarButtonItem110.CommandName = "FunctionsInsertMax";
            this.spreadsheetCommandBarButtonItem110.Id = -1;
            this.spreadsheetCommandBarButtonItem110.Name = "spreadsheetCommandBarButtonItem110";
            // 
            // spreadsheetCommandBarButtonItem111
            // 
            this.spreadsheetCommandBarButtonItem111.CommandName = "FunctionsInsertMin";
            this.spreadsheetCommandBarButtonItem111.Id = -1;
            this.spreadsheetCommandBarButtonItem111.Name = "spreadsheetCommandBarButtonItem111";
            // 
            // spreadsheetCommandBarButtonItem119
            // 
            this.spreadsheetCommandBarButtonItem119.CommandName = "FunctionsInsertSum";
            this.spreadsheetCommandBarButtonItem119.Id = -1;
            this.spreadsheetCommandBarButtonItem119.Name = "spreadsheetCommandBarButtonItem119";
            // 
            // spreadsheetCommandBarButtonItem120
            // 
            this.spreadsheetCommandBarButtonItem120.CommandName = "FunctionsInsertAverage";
            this.spreadsheetCommandBarButtonItem120.Id = -1;
            this.spreadsheetCommandBarButtonItem120.Name = "spreadsheetCommandBarButtonItem120";
            // 
            // spreadsheetCommandBarButtonItem121
            // 
            this.spreadsheetCommandBarButtonItem121.CommandName = "FunctionsInsertCountNumbers";
            this.spreadsheetCommandBarButtonItem121.Id = -1;
            this.spreadsheetCommandBarButtonItem121.Name = "spreadsheetCommandBarButtonItem121";
            // 
            // spreadsheetCommandBarButtonItem122
            // 
            this.spreadsheetCommandBarButtonItem122.CommandName = "FunctionsInsertMax";
            this.spreadsheetCommandBarButtonItem122.Id = -1;
            this.spreadsheetCommandBarButtonItem122.Name = "spreadsheetCommandBarButtonItem122";
            // 
            // spreadsheetCommandBarButtonItem123
            // 
            this.spreadsheetCommandBarButtonItem123.CommandName = "FunctionsInsertMin";
            this.spreadsheetCommandBarButtonItem123.Id = -1;
            this.spreadsheetCommandBarButtonItem123.Name = "spreadsheetCommandBarButtonItem123";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.spreadsheetCommandBarButtonItem1,
            this.spreadsheetCommandBarButtonItem2,
            this.spreadsheetCommandBarButtonItem3,
            this.spreadsheetCommandBarButtonItem4,
            this.spreadsheetCommandBarButtonItem5,
            this.spreadsheetCommandBarButtonItem6,
            this.spreadsheetCommandBarButtonItem7,
            this.spreadsheetCommandBarButtonItem8,
            this.spreadsheetCommandBarButtonItem9,
            this.spreadsheetCommandBarButtonItem10,
            this.spreadsheetCommandBarButtonItem11,
            this.spreadsheetCommandBarButtonItem12,
            this.spreadsheetCommandBarButtonItem13,
            this.spreadsheetCommandBarButtonItem14,
            this.spreadsheetCommandBarButtonItem15,
            this.barButtonGroup1,
            this.changeFontNameItem1,
            this.changeFontSizeItem1,
            this.spreadsheetCommandBarButtonItem16,
            this.spreadsheetCommandBarButtonItem17,
            this.barButtonGroup2,
            this.spreadsheetCommandBarCheckItem1,
            this.spreadsheetCommandBarCheckItem2,
            this.spreadsheetCommandBarCheckItem3,
            this.spreadsheetCommandBarCheckItem4,
            this.barButtonGroup3,
            this.spreadsheetCommandBarSubItem1,
            this.spreadsheetCommandBarButtonItem18,
            this.spreadsheetCommandBarButtonItem19,
            this.spreadsheetCommandBarButtonItem20,
            this.spreadsheetCommandBarButtonItem21,
            this.spreadsheetCommandBarButtonItem22,
            this.spreadsheetCommandBarButtonItem23,
            this.spreadsheetCommandBarButtonItem24,
            this.spreadsheetCommandBarButtonItem25,
            this.spreadsheetCommandBarButtonItem26,
            this.spreadsheetCommandBarButtonItem27,
            this.spreadsheetCommandBarButtonItem28,
            this.spreadsheetCommandBarButtonItem29,
            this.spreadsheetCommandBarButtonItem30,
            this.changeBorderLineColorItem1,
            this.changeBorderLineStyleItem1,
            this.barButtonGroup4,
            this.changeCellFillColorItem1,
            this.changeFontColorItem1,
            this.barButtonGroup5,
            this.spreadsheetCommandBarCheckItem5,
            this.spreadsheetCommandBarCheckItem6,
            this.spreadsheetCommandBarCheckItem7,
            this.barButtonGroup6,
            this.spreadsheetCommandBarCheckItem8,
            this.spreadsheetCommandBarCheckItem9,
            this.spreadsheetCommandBarCheckItem10,
            this.barButtonGroup7,
            this.spreadsheetCommandBarButtonItem31,
            this.spreadsheetCommandBarButtonItem32,
            this.spreadsheetCommandBarCheckItem11,
            this.spreadsheetCommandBarSubItem2,
            this.spreadsheetCommandBarCheckItem12,
            this.spreadsheetCommandBarButtonItem33,
            this.spreadsheetCommandBarButtonItem34,
            this.spreadsheetCommandBarButtonItem35,
            this.barButtonGroup8,
            this.changeNumberFormatItem1,
            this.barButtonGroup9,
            this.spreadsheetCommandBarSubItem3,
            this.spreadsheetCommandBarButtonItem36,
            this.spreadsheetCommandBarButtonItem37,
            this.spreadsheetCommandBarButtonItem38,
            this.spreadsheetCommandBarButtonItem39,
            this.spreadsheetCommandBarButtonItem40,
            this.spreadsheetCommandBarButtonItem41,
            this.spreadsheetCommandBarButtonItem42,
            this.barButtonGroup10,
            this.spreadsheetCommandBarButtonItem43,
            this.spreadsheetCommandBarButtonItem44,
            this.spreadsheetCommandBarSubItem4,
            this.spreadsheetCommandBarButtonItem45,
            this.spreadsheetCommandBarButtonItem46,
            this.spreadsheetCommandBarButtonItem47,
            this.spreadsheetCommandBarButtonItem48,
            this.spreadsheetCommandBarButtonItem49,
            this.spreadsheetCommandBarButtonItem50,
            this.spreadsheetCommandBarButtonItem51,
            this.spreadsheetCommandBarSubItem5,
            this.spreadsheetCommandBarButtonItem52,
            this.spreadsheetCommandBarButtonItem53,
            this.spreadsheetCommandBarButtonItem54,
            this.spreadsheetCommandBarButtonItem55,
            this.spreadsheetCommandBarButtonItem56,
            this.spreadsheetCommandBarButtonItem57,
            this.spreadsheetCommandBarSubItem6,
            this.spreadsheetCommandBarButtonGalleryDropDownItem1,
            this.spreadsheetCommandBarButtonGalleryDropDownItem2,
            this.spreadsheetCommandBarButtonGalleryDropDownItem3,
            this.spreadsheetCommandBarButtonItem58,
            this.spreadsheetCommandBarButtonItem59,
            this.spreadsheetCommandBarButtonItem60,
            this.spreadsheetCommandBarSubItem7,
            this.galleryFormatAsTableItem1,
            this.galleryChangeStyleItem1,
            this.spreadsheetCommandBarSubItem8,
            this.spreadsheetCommandBarButtonItem61,
            this.spreadsheetCommandBarButtonItem62,
            this.spreadsheetCommandBarButtonItem63,
            this.spreadsheetCommandBarSubItem9,
            this.spreadsheetCommandBarButtonItem64,
            this.spreadsheetCommandBarButtonItem65,
            this.spreadsheetCommandBarButtonItem66,
            this.spreadsheetCommandBarSubItem10,
            this.spreadsheetCommandBarButtonItem67,
            this.spreadsheetCommandBarButtonItem68,
            this.spreadsheetCommandBarButtonItem69,
            this.spreadsheetCommandBarButtonItem70,
            this.spreadsheetCommandBarButtonItem71,
            this.spreadsheetCommandBarButtonItem72,
            this.spreadsheetCommandBarButtonItem73,
            this.spreadsheetCommandBarButtonItem74,
            this.spreadsheetCommandBarButtonItem75,
            this.spreadsheetCommandBarButtonItem76,
            this.spreadsheetCommandBarButtonItem77,
            this.spreadsheetCommandBarSubItem11,
            this.spreadsheetCommandBarButtonItem78,
            this.spreadsheetCommandBarButtonItem79,
            this.changeSheetTabColorItem1,
            this.spreadsheetCommandBarButtonItem80,
            this.spreadsheetCommandBarCheckItem13,
            this.spreadsheetCommandBarButtonItem81,
            this.spreadsheetCommandBarSubItem12,
            this.spreadsheetCommandBarButtonItem82,
            this.spreadsheetCommandBarButtonItem83,
            this.spreadsheetCommandBarButtonItem84,
            this.spreadsheetCommandBarButtonItem85,
            this.spreadsheetCommandBarButtonItem86,
            this.spreadsheetCommandBarSubItem13,
            this.spreadsheetCommandBarButtonItem87,
            this.spreadsheetCommandBarButtonItem88,
            this.spreadsheetCommandBarButtonItem89,
            this.spreadsheetCommandBarButtonItem90,
            this.spreadsheetCommandBarSubItem14,
            this.spreadsheetCommandBarButtonItem91,
            this.spreadsheetCommandBarButtonItem92,
            this.spreadsheetCommandBarButtonItem93,
            this.spreadsheetCommandBarButtonItem94,
            this.spreadsheetCommandBarButtonItem95,
            this.spreadsheetCommandBarButtonItem96,
            this.spreadsheetCommandBarSubItem15,
            this.spreadsheetCommandBarButtonItem97,
            this.spreadsheetCommandBarButtonItem98,
            this.spreadsheetCommandBarCheckItem14,
            this.spreadsheetCommandBarButtonItem99,
            this.spreadsheetCommandBarButtonItem100,
            this.spreadsheetCommandBarSubItem16,
            this.spreadsheetCommandBarButtonItem101,
            this.spreadsheetCommandBarButtonItem102,
            this.spreadsheetCommandBarButtonItem103,
            this.spreadsheetCommandBarButtonItem104,
            this.spreadsheetCommandBarButtonItem105,
            this.spreadsheetCommandBarButtonItem106,
            this.spreadsheetCommandBarButtonItem112,
            this.spreadsheetCommandBarButtonItem113,
            this.spreadsheetCommandBarButtonItem114,
            this.spreadsheetCommandBarButtonItem115,
            this.spreadsheetCommandBarButtonGalleryDropDownItem4,
            this.spreadsheetCommandBarButtonGalleryDropDownItem5,
            this.spreadsheetCommandBarButtonGalleryDropDownItem6,
            this.spreadsheetCommandBarButtonGalleryDropDownItem7,
            this.spreadsheetCommandBarButtonGalleryDropDownItem8,
            this.spreadsheetCommandBarButtonGalleryDropDownItem9,
            this.spreadsheetCommandBarButtonGalleryDropDownItem10,
            this.spreadsheetCommandBarButtonItem116,
            this.spreadsheetCommandBarButtonItem117,
            this.spreadsheetCommandBarSubItem17,
            this.spreadsheetCommandBarCheckItem15,
            this.spreadsheetCommandBarCheckItem16,
            this.spreadsheetCommandBarCheckItem17,
            this.spreadsheetCommandBarButtonItem118,
            this.spreadsheetCommandBarSubItem18,
            this.spreadsheetCommandBarCheckItem18,
            this.spreadsheetCommandBarCheckItem19,
            this.pageSetupPaperKindItem1,
            this.spreadsheetCommandBarSubItem19,
            this.spreadsheetCommandBarButtonItem124,
            this.spreadsheetCommandBarButtonItem125,
            this.spreadsheetCommandBarButtonItem126,
            this.spreadsheetCommandBarButtonItem127,
            this.spreadsheetCommandBarCheckItem20,
            this.spreadsheetCommandBarCheckItem21,
            this.spreadsheetCommandBarCheckItem22,
            this.spreadsheetCommandBarCheckItem23,
            this.spreadsheetCommandBarSubItem20,
            this.spreadsheetCommandBarButtonItem128,
            this.spreadsheetCommandBarButtonItem129,
            this.spreadsheetCommandBarSubItem21,
            this.spreadsheetCommandBarButtonItem130,
            this.spreadsheetCommandBarButtonItem131,
            this.spreadsheetCommandBarSubItem22,
            this.functionsFinancialItem1,
            this.functionsLogicalItem1,
            this.functionsTextItem1,
            this.functionsDateAndTimeItem1,
            this.functionsLookupAndReferenceItem1,
            this.functionsMathAndTrigonometryItem1,
            this.spreadsheetCommandBarSubItem23,
            this.functionsStatisticalItem1,
            this.functionsEngineeringItem1,
            this.functionsInformationItem1,
            this.functionsCompatibilityItem1,
            this.functionsWebItem1,
            this.spreadsheetCommandBarButtonItem137,
            this.spreadsheetCommandBarButtonItem138,
            this.definedNameListItem1,
            this.spreadsheetCommandBarButtonItem139,
            this.spreadsheetCommandBarCheckItem24,
            this.spreadsheetCommandBarSubItem24,
            this.spreadsheetCommandBarCheckItem25,
            this.spreadsheetCommandBarCheckItem26,
            this.spreadsheetCommandBarButtonItem140,
            this.spreadsheetCommandBarButtonItem141,
            this.spreadsheetCommandBarSubItem25,
            this.spreadsheetCommandBarButtonItem142,
            this.spreadsheetCommandBarButtonItem143,
            this.spreadsheetCommandBarButtonItem144,
            this.spreadsheetCommandBarSubItem26,
            this.spreadsheetCommandBarButtonItem145,
            this.spreadsheetCommandBarButtonItem146,
            this.spreadsheetCommandBarSubItem27,
            this.spreadsheetCommandBarButtonItem147,
            this.spreadsheetCommandBarButtonItem148,
            this.spreadsheetCommandBarButtonItem149,
            this.spreadsheetCommandBarButtonItem150,
            this.spreadsheetCommandBarButtonItem151,
            this.spreadsheetCommandBarButtonItem152,
            this.spreadsheetCommandBarButtonItem153,
            this.spreadsheetCommandBarButtonItem154,
            this.spreadsheetCommandBarButtonItem155,
            this.spreadsheetCommandBarButtonItem156,
            this.spreadsheetCommandBarButtonItem157,
            this.spreadsheetCommandBarButtonItem158,
            this.spreadsheetCommandBarButtonItem159,
            this.spreadsheetCommandBarButtonItem160,
            this.spreadsheetCommandBarButtonItem161,
            this.spreadsheetCommandBarButtonItem162,
            this.spreadsheetCommandBarButtonItem163,
            this.spreadsheetCommandBarSubItem28,
            this.spreadsheetCommandBarButtonItem164,
            this.spreadsheetCommandBarButtonItem165,
            this.spreadsheetCommandBarButtonItem166,
            this.spreadsheetCommandBarButtonItem167,
            this.spreadsheetCommandBarButtonItem168,
            this.spreadsheetCommandBarButtonItem169,
            this.spreadsheetCommandBarButtonItem170,
            this.galleryChartLayoutItem1,
            this.galleryChartStyleItem1,
            this.spreadsheetCommandBarSubItem29,
            this.spreadsheetCommandBarButtonGalleryDropDownItem11,
            this.spreadsheetCommandBarButtonGalleryDropDownItem12,
            this.spreadsheetCommandBarSubItem30,
            this.spreadsheetCommandBarButtonGalleryDropDownItem13,
            this.spreadsheetCommandBarButtonGalleryDropDownItem14,
            this.spreadsheetCommandBarButtonGalleryDropDownItem15,
            this.spreadsheetCommandBarSubItem31,
            this.spreadsheetCommandBarButtonGalleryDropDownItem16,
            this.spreadsheetCommandBarButtonGalleryDropDownItem17,
            this.spreadsheetCommandBarButtonGalleryDropDownItem18,
            this.spreadsheetCommandBarButtonGalleryDropDownItem19,
            this.spreadsheetCommandBarButtonGalleryDropDownItem20,
            this.spreadsheetCommandBarButtonGalleryDropDownItem21,
            this.spreadsheetCommandBarButtonGalleryDropDownItem22,
            this.renameTableItemCaption1,
            this.renameTableItem1,
            this.spreadsheetCommandBarCheckItem27,
            this.spreadsheetCommandBarCheckItem28,
            this.spreadsheetCommandBarCheckItem29,
            this.spreadsheetCommandBarCheckItem30,
            this.spreadsheetCommandBarCheckItem31,
            this.spreadsheetCommandBarCheckItem32,
            this.spreadsheetCommandBarCheckItem33,
            this.galleryTableStylesItem1,
            this.spreadsheetCommandBarButtonItem171,
            this.spreadsheetCommandBarButtonItem172,
            this.spreadsheetCommandBarButtonItem173,
            this.spreadsheetCommandBarButtonItem174,
            this.spreadsheetCommandBarButtonItem175,
            this.spreadsheetCommandBarButtonItem176,
            this.spreadsheetCommandBarButtonItem177,
            this.spreadsheetCommandBarSubItem32,
            this.spreadsheetCommandBarButtonItem178,
            this.spreadsheetCommandBarButtonItem179,
            this.spreadsheetCommandBarButtonItem180,
            this.spreadsheetCommandBarSubItem33,
            this.spreadsheetCommandBarButtonItem181,
            this.spreadsheetCommandBarButtonItem182,
            this.spreadsheetCommandBarSubItem34,
            this.spreadsheetCommandBarButtonItem183,
            this.spreadsheetCommandBarButtonItem184,
            this.spreadsheetCommandBarButtonItem185,
            this.spreadsheetCommandBarButtonItem186,
            this.spreadsheetCommandBarSubItem35,
            this.spreadsheetCommandBarButtonItem187,
            this.spreadsheetCommandBarButtonItem188,
            this.spreadsheetCommandBarButtonItem189,
            this.spreadsheetCommandBarButtonItem190,
            this.spreadsheetCommandBarCheckItem34,
            this.spreadsheetCommandBarCheckItem35,
            this.spreadsheetCommandBarCheckItem36,
            this.spreadsheetCommandBarSubItem36,
            this.spreadsheetCommandBarButtonItem191,
            this.spreadsheetCommandBarButtonItem192,
            this.spreadsheetCommandBarButtonItem193,
            this.spreadsheetCommandBarSubItem37,
            this.spreadsheetCommandBarButtonItem194,
            this.spreadsheetCommandBarButtonItem195,
            this.spreadsheetCommandBarButtonItem196,
            this.spreadsheetCommandBarButtonItem197,
            this.spreadsheetCommandBarSubItem38,
            this.spreadsheetCommandBarButtonItem198,
            this.spreadsheetCommandBarButtonItem199,
            this.spreadsheetCommandBarButtonItem200,
            this.spreadsheetCommandBarButtonItem201,
            this.spreadsheetCommandBarButtonItem202,
            this.spreadsheetCommandBarSubItem39,
            this.spreadsheetCommandBarButtonItem203,
            this.spreadsheetCommandBarButtonItem204,
            this.spreadsheetCommandBarCheckItem37,
            this.spreadsheetCommandBarCheckItem38,
            this.spreadsheetCommandBarCheckItem39,
            this.spreadsheetCommandBarCheckItem40,
            this.galleryPivotStylesItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 330;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.chartToolsRibbonPageCategory1,
            this.tableToolsRibbonPageCategory1,
            this.drawingToolsRibbonPageCategory1,
            this.pictureToolsRibbonPageCategory1,
            this.pivotTableToolsRibbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.homeRibbonPage1,
            this.insertRibbonPage1,
            this.pageLayoutRibbonPage1,
            this.formulasRibbonPage1,
            this.dataRibbonPage1,
            this.reviewRibbonPage1,
            this.viewRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1,
            this.repositoryItemSpreadsheetFontSizeEdit1,
            this.repositoryItemPopupGalleryEdit1,
            this.repositoryItemTextEdit1});
            this.ribbonControl1.Size = new System.Drawing.Size(696, 116);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // commonRibbonPageGroup1
            // 
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem2);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem3);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem4);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem5);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem6);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem7);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem8);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem9);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1,
            this.infoRibbonPageGroup1});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            // 
            // spreadsheetCommandBarButtonItem1
            // 
            this.spreadsheetCommandBarButtonItem1.CommandName = "FileNew";
            this.spreadsheetCommandBarButtonItem1.Id = 1;
            this.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1";
            // 
            // spreadsheetCommandBarButtonItem2
            // 
            this.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen";
            this.spreadsheetCommandBarButtonItem2.Id = 2;
            this.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2";
            // 
            // spreadsheetCommandBarButtonItem3
            // 
            this.spreadsheetCommandBarButtonItem3.CommandName = "FileSave";
            this.spreadsheetCommandBarButtonItem3.Id = 3;
            this.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3";
            // 
            // spreadsheetCommandBarButtonItem4
            // 
            this.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs";
            this.spreadsheetCommandBarButtonItem4.Id = 4;
            this.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4";
            // 
            // spreadsheetCommandBarButtonItem5
            // 
            this.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint";
            this.spreadsheetCommandBarButtonItem5.Id = 5;
            this.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5";
            // 
            // spreadsheetCommandBarButtonItem6
            // 
            this.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint";
            this.spreadsheetCommandBarButtonItem6.Id = 6;
            this.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6";
            // 
            // spreadsheetCommandBarButtonItem7
            // 
            this.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview";
            this.spreadsheetCommandBarButtonItem7.Id = 7;
            this.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7";
            // 
            // spreadsheetCommandBarButtonItem8
            // 
            this.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo";
            this.spreadsheetCommandBarButtonItem8.Id = 8;
            this.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8";
            // 
            // spreadsheetCommandBarButtonItem9
            // 
            this.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo";
            this.spreadsheetCommandBarButtonItem9.Id = 9;
            this.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9";
            // 
            // infoRibbonPageGroup1
            // 
            this.infoRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem10);
            this.infoRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem11);
            this.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonItem10
            // 
            this.spreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt";
            this.spreadsheetCommandBarButtonItem10.Id = 10;
            this.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10";
            // 
            // spreadsheetCommandBarButtonItem11
            // 
            this.spreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties";
            this.spreadsheetCommandBarButtonItem11.Id = 11;
            this.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11";
            // 
            // clipboardRibbonPageGroup1
            // 
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem12);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem13);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem14);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem15);
            this.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1";
            // 
            // homeRibbonPage1
            // 
            this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.clipboardRibbonPageGroup1,
            this.fontRibbonPageGroup1,
            this.alignmentRibbonPageGroup1,
            this.numberRibbonPageGroup1,
            this.stylesRibbonPageGroup1,
            this.cellsRibbonPageGroup1,
            this.editingRibbonPageGroup1});
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable;
            reduceOperation1.Group = this.stylesRibbonPageGroup1;
            reduceOperation1.ItemLinkIndex = 2;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery;
            this.homeRibbonPage1.ReduceOperations.Add(reduceOperation1);
            // 
            // spreadsheetCommandBarButtonItem12
            // 
            this.spreadsheetCommandBarButtonItem12.CommandName = "PasteSelection";
            this.spreadsheetCommandBarButtonItem12.Id = 22;
            this.spreadsheetCommandBarButtonItem12.Name = "spreadsheetCommandBarButtonItem12";
            this.spreadsheetCommandBarButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem13
            // 
            this.spreadsheetCommandBarButtonItem13.CommandName = "CutSelection";
            this.spreadsheetCommandBarButtonItem13.Id = 23;
            this.spreadsheetCommandBarButtonItem13.Name = "spreadsheetCommandBarButtonItem13";
            this.spreadsheetCommandBarButtonItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem14
            // 
            this.spreadsheetCommandBarButtonItem14.CommandName = "CopySelection";
            this.spreadsheetCommandBarButtonItem14.Id = 24;
            this.spreadsheetCommandBarButtonItem14.Name = "spreadsheetCommandBarButtonItem14";
            this.spreadsheetCommandBarButtonItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem15
            // 
            this.spreadsheetCommandBarButtonItem15.CommandName = "ShowPasteSpecialForm";
            this.spreadsheetCommandBarButtonItem15.Id = 25;
            this.spreadsheetCommandBarButtonItem15.Name = "spreadsheetCommandBarButtonItem15";
            this.spreadsheetCommandBarButtonItem15.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // fontRibbonPageGroup1
            // 
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup1);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup2);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup3);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup4);
            this.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1";
            // 
            // changeFontNameItem1
            // 
            this.changeFontNameItem1.Edit = this.repositoryItemFontEdit1;
            this.changeFontNameItem1.Id = 26;
            this.changeFontNameItem1.Name = "changeFontNameItem1";
            // 
            // changeFontSizeItem1
            // 
            this.changeFontSizeItem1.Edit = this.repositoryItemSpreadsheetFontSizeEdit1;
            this.changeFontSizeItem1.Id = 27;
            this.changeFontSizeItem1.Name = "changeFontSizeItem1";
            // 
            // spreadsheetCommandBarButtonItem16
            // 
            this.spreadsheetCommandBarButtonItem16.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
            this.spreadsheetCommandBarButtonItem16.CommandName = "FormatIncreaseFontSize";
            this.spreadsheetCommandBarButtonItem16.Id = 28;
            this.spreadsheetCommandBarButtonItem16.Name = "spreadsheetCommandBarButtonItem16";
            this.spreadsheetCommandBarButtonItem16.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem17
            // 
            this.spreadsheetCommandBarButtonItem17.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
            this.spreadsheetCommandBarButtonItem17.CommandName = "FormatDecreaseFontSize";
            this.spreadsheetCommandBarButtonItem17.Id = 29;
            this.spreadsheetCommandBarButtonItem17.Name = "spreadsheetCommandBarButtonItem17";
            this.spreadsheetCommandBarButtonItem17.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem1
            // 
            this.spreadsheetCommandBarCheckItem1.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            this.spreadsheetCommandBarCheckItem1.CommandName = "FormatFontBold";
            this.spreadsheetCommandBarCheckItem1.Id = 30;
            this.spreadsheetCommandBarCheckItem1.Name = "spreadsheetCommandBarCheckItem1";
            this.spreadsheetCommandBarCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem2
            // 
            this.spreadsheetCommandBarCheckItem2.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            this.spreadsheetCommandBarCheckItem2.CommandName = "FormatFontItalic";
            this.spreadsheetCommandBarCheckItem2.Id = 31;
            this.spreadsheetCommandBarCheckItem2.Name = "spreadsheetCommandBarCheckItem2";
            this.spreadsheetCommandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem3
            // 
            this.spreadsheetCommandBarCheckItem3.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            this.spreadsheetCommandBarCheckItem3.CommandName = "FormatFontUnderline";
            this.spreadsheetCommandBarCheckItem3.Id = 32;
            this.spreadsheetCommandBarCheckItem3.Name = "spreadsheetCommandBarCheckItem3";
            this.spreadsheetCommandBarCheckItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem4
            // 
            this.spreadsheetCommandBarCheckItem4.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            this.spreadsheetCommandBarCheckItem4.CommandName = "FormatFontStrikeout";
            this.spreadsheetCommandBarCheckItem4.Id = 33;
            this.spreadsheetCommandBarCheckItem4.Name = "spreadsheetCommandBarCheckItem4";
            this.spreadsheetCommandBarCheckItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarSubItem1
            // 
            this.spreadsheetCommandBarSubItem1.ButtonGroupTag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}";
            this.spreadsheetCommandBarSubItem1.CommandName = "FormatBordersCommandGroup";
            this.spreadsheetCommandBarSubItem1.Id = 34;
            this.spreadsheetCommandBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem18),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem19),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem20),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem21),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem22),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem23),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem24),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem25),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem26),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem27),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem28),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem29),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem30),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeBorderLineColorItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeBorderLineStyleItem1)});
            this.spreadsheetCommandBarSubItem1.Name = "spreadsheetCommandBarSubItem1";
            this.spreadsheetCommandBarSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem18
            // 
            this.spreadsheetCommandBarButtonItem18.CommandName = "FormatBottomBorder";
            this.spreadsheetCommandBarButtonItem18.Id = 35;
            this.spreadsheetCommandBarButtonItem18.Name = "spreadsheetCommandBarButtonItem18";
            // 
            // spreadsheetCommandBarButtonItem19
            // 
            this.spreadsheetCommandBarButtonItem19.CommandName = "FormatTopBorder";
            this.spreadsheetCommandBarButtonItem19.Id = 36;
            this.spreadsheetCommandBarButtonItem19.Name = "spreadsheetCommandBarButtonItem19";
            // 
            // spreadsheetCommandBarButtonItem20
            // 
            this.spreadsheetCommandBarButtonItem20.CommandName = "FormatLeftBorder";
            this.spreadsheetCommandBarButtonItem20.Id = 37;
            this.spreadsheetCommandBarButtonItem20.Name = "spreadsheetCommandBarButtonItem20";
            // 
            // spreadsheetCommandBarButtonItem21
            // 
            this.spreadsheetCommandBarButtonItem21.CommandName = "FormatRightBorder";
            this.spreadsheetCommandBarButtonItem21.Id = 38;
            this.spreadsheetCommandBarButtonItem21.Name = "spreadsheetCommandBarButtonItem21";
            // 
            // spreadsheetCommandBarButtonItem22
            // 
            this.spreadsheetCommandBarButtonItem22.CommandName = "FormatNoBorders";
            this.spreadsheetCommandBarButtonItem22.Id = 39;
            this.spreadsheetCommandBarButtonItem22.Name = "spreadsheetCommandBarButtonItem22";
            // 
            // spreadsheetCommandBarButtonItem23
            // 
            this.spreadsheetCommandBarButtonItem23.CommandName = "FormatAllBorders";
            this.spreadsheetCommandBarButtonItem23.Id = 40;
            this.spreadsheetCommandBarButtonItem23.Name = "spreadsheetCommandBarButtonItem23";
            // 
            // spreadsheetCommandBarButtonItem24
            // 
            this.spreadsheetCommandBarButtonItem24.CommandName = "FormatOutsideBorders";
            this.spreadsheetCommandBarButtonItem24.Id = 41;
            this.spreadsheetCommandBarButtonItem24.Name = "spreadsheetCommandBarButtonItem24";
            // 
            // spreadsheetCommandBarButtonItem25
            // 
            this.spreadsheetCommandBarButtonItem25.CommandName = "FormatThickBorder";
            this.spreadsheetCommandBarButtonItem25.Id = 42;
            this.spreadsheetCommandBarButtonItem25.Name = "spreadsheetCommandBarButtonItem25";
            // 
            // spreadsheetCommandBarButtonItem26
            // 
            this.spreadsheetCommandBarButtonItem26.CommandName = "FormatBottomDoubleBorder";
            this.spreadsheetCommandBarButtonItem26.Id = 43;
            this.spreadsheetCommandBarButtonItem26.Name = "spreadsheetCommandBarButtonItem26";
            // 
            // spreadsheetCommandBarButtonItem27
            // 
            this.spreadsheetCommandBarButtonItem27.CommandName = "FormatBottomThickBorder";
            this.spreadsheetCommandBarButtonItem27.Id = 44;
            this.spreadsheetCommandBarButtonItem27.Name = "spreadsheetCommandBarButtonItem27";
            // 
            // spreadsheetCommandBarButtonItem28
            // 
            this.spreadsheetCommandBarButtonItem28.CommandName = "FormatTopAndBottomBorder";
            this.spreadsheetCommandBarButtonItem28.Id = 45;
            this.spreadsheetCommandBarButtonItem28.Name = "spreadsheetCommandBarButtonItem28";
            // 
            // spreadsheetCommandBarButtonItem29
            // 
            this.spreadsheetCommandBarButtonItem29.CommandName = "FormatTopAndThickBottomBorder";
            this.spreadsheetCommandBarButtonItem29.Id = 46;
            this.spreadsheetCommandBarButtonItem29.Name = "spreadsheetCommandBarButtonItem29";
            // 
            // spreadsheetCommandBarButtonItem30
            // 
            this.spreadsheetCommandBarButtonItem30.CommandName = "FormatTopAndDoubleBottomBorder";
            this.spreadsheetCommandBarButtonItem30.Id = 47;
            this.spreadsheetCommandBarButtonItem30.Name = "spreadsheetCommandBarButtonItem30";
            // 
            // changeBorderLineColorItem1
            // 
            this.changeBorderLineColorItem1.ActAsDropDown = true;
            this.changeBorderLineColorItem1.Id = 48;
            this.changeBorderLineColorItem1.Name = "changeBorderLineColorItem1";
            // 
            // changeBorderLineStyleItem1
            // 
            this.changeBorderLineStyleItem1.DropDownControl = this.commandBarGalleryDropDown49;
            this.changeBorderLineStyleItem1.Id = 49;
            this.changeBorderLineStyleItem1.Name = "changeBorderLineStyleItem1";
            // 
            // commandBarGalleryDropDown49
            // 
            this.commandBarGalleryDropDown49.Name = "commandBarGalleryDropDown49";
            this.commandBarGalleryDropDown49.Ribbon = this.ribbonControl1;
            // 
            // changeCellFillColorItem1
            // 
            this.changeCellFillColorItem1.Id = 50;
            this.changeCellFillColorItem1.Name = "changeCellFillColorItem1";
            // 
            // changeFontColorItem1
            // 
            this.changeFontColorItem1.Id = 51;
            this.changeFontColorItem1.Name = "changeFontColorItem1";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Id = 12;
            this.barButtonGroup1.ItemLinks.Add(this.changeFontNameItem1);
            this.barButtonGroup1.ItemLinks.Add(this.changeFontSizeItem1);
            this.barButtonGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem16);
            this.barButtonGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem17);
            this.barButtonGroup1.Name = "barButtonGroup1";
            this.barButtonGroup1.Tag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // repositoryItemSpreadsheetFontSizeEdit1
            // 
            this.repositoryItemSpreadsheetFontSizeEdit1.AutoHeight = false;
            this.repositoryItemSpreadsheetFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpreadsheetFontSizeEdit1.Control = this.spreadsheetControl1;
            this.repositoryItemSpreadsheetFontSizeEdit1.Name = "repositoryItemSpreadsheetFontSizeEdit1";
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Id = 13;
            this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem1);
            this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem2);
            this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem3);
            this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem4);
            this.barButtonGroup2.Name = "barButtonGroup2";
            this.barButtonGroup2.Tag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            // 
            // barButtonGroup3
            // 
            this.barButtonGroup3.Id = 14;
            this.barButtonGroup3.ItemLinks.Add(this.spreadsheetCommandBarSubItem1);
            this.barButtonGroup3.Name = "barButtonGroup3";
            this.barButtonGroup3.Tag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}";
            // 
            // barButtonGroup4
            // 
            this.barButtonGroup4.Id = 15;
            this.barButtonGroup4.ItemLinks.Add(this.changeCellFillColorItem1);
            this.barButtonGroup4.ItemLinks.Add(this.changeFontColorItem1);
            this.barButtonGroup4.Name = "barButtonGroup4";
            this.barButtonGroup4.Tag = "{C2275623-04A3-41E8-8D6A-EB5C7F8541D1}";
            // 
            // alignmentRibbonPageGroup1
            // 
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup5);
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup6);
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup7);
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem11);
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem2);
            this.alignmentRibbonPageGroup1.Name = "alignmentRibbonPageGroup1";
            // 
            // spreadsheetCommandBarCheckItem5
            // 
            this.spreadsheetCommandBarCheckItem5.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            this.spreadsheetCommandBarCheckItem5.CommandName = "FormatAlignmentTop";
            this.spreadsheetCommandBarCheckItem5.Id = 52;
            this.spreadsheetCommandBarCheckItem5.Name = "spreadsheetCommandBarCheckItem5";
            this.spreadsheetCommandBarCheckItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem6
            // 
            this.spreadsheetCommandBarCheckItem6.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            this.spreadsheetCommandBarCheckItem6.CommandName = "FormatAlignmentMiddle";
            this.spreadsheetCommandBarCheckItem6.Id = 53;
            this.spreadsheetCommandBarCheckItem6.Name = "spreadsheetCommandBarCheckItem6";
            this.spreadsheetCommandBarCheckItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem7
            // 
            this.spreadsheetCommandBarCheckItem7.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            this.spreadsheetCommandBarCheckItem7.CommandName = "FormatAlignmentBottom";
            this.spreadsheetCommandBarCheckItem7.Id = 54;
            this.spreadsheetCommandBarCheckItem7.Name = "spreadsheetCommandBarCheckItem7";
            this.spreadsheetCommandBarCheckItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem8
            // 
            this.spreadsheetCommandBarCheckItem8.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            this.spreadsheetCommandBarCheckItem8.CommandName = "FormatAlignmentLeft";
            this.spreadsheetCommandBarCheckItem8.Id = 55;
            this.spreadsheetCommandBarCheckItem8.Name = "spreadsheetCommandBarCheckItem8";
            this.spreadsheetCommandBarCheckItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem9
            // 
            this.spreadsheetCommandBarCheckItem9.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            this.spreadsheetCommandBarCheckItem9.CommandName = "FormatAlignmentCenter";
            this.spreadsheetCommandBarCheckItem9.Id = 56;
            this.spreadsheetCommandBarCheckItem9.Name = "spreadsheetCommandBarCheckItem9";
            this.spreadsheetCommandBarCheckItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem10
            // 
            this.spreadsheetCommandBarCheckItem10.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            this.spreadsheetCommandBarCheckItem10.CommandName = "FormatAlignmentRight";
            this.spreadsheetCommandBarCheckItem10.Id = 57;
            this.spreadsheetCommandBarCheckItem10.Name = "spreadsheetCommandBarCheckItem10";
            this.spreadsheetCommandBarCheckItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem31
            // 
            this.spreadsheetCommandBarButtonItem31.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
            this.spreadsheetCommandBarButtonItem31.CommandName = "FormatDecreaseIndent";
            this.spreadsheetCommandBarButtonItem31.Id = 58;
            this.spreadsheetCommandBarButtonItem31.Name = "spreadsheetCommandBarButtonItem31";
            this.spreadsheetCommandBarButtonItem31.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem32
            // 
            this.spreadsheetCommandBarButtonItem32.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
            this.spreadsheetCommandBarButtonItem32.CommandName = "FormatIncreaseIndent";
            this.spreadsheetCommandBarButtonItem32.Id = 59;
            this.spreadsheetCommandBarButtonItem32.Name = "spreadsheetCommandBarButtonItem32";
            this.spreadsheetCommandBarButtonItem32.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem11
            // 
            this.spreadsheetCommandBarCheckItem11.CommandName = "FormatWrapText";
            this.spreadsheetCommandBarCheckItem11.Id = 60;
            this.spreadsheetCommandBarCheckItem11.Name = "spreadsheetCommandBarCheckItem11";
            this.spreadsheetCommandBarCheckItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarSubItem2
            // 
            this.spreadsheetCommandBarSubItem2.CommandName = "EditingMergeCellsCommandGroup";
            this.spreadsheetCommandBarSubItem2.Id = 61;
            this.spreadsheetCommandBarSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem12),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem33),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem34),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem35)});
            this.spreadsheetCommandBarSubItem2.Name = "spreadsheetCommandBarSubItem2";
            this.spreadsheetCommandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarCheckItem12
            // 
            this.spreadsheetCommandBarCheckItem12.CommandName = "EditingMergeAndCenterCells";
            this.spreadsheetCommandBarCheckItem12.Id = 62;
            this.spreadsheetCommandBarCheckItem12.Name = "spreadsheetCommandBarCheckItem12";
            // 
            // spreadsheetCommandBarButtonItem33
            // 
            this.spreadsheetCommandBarButtonItem33.CommandName = "EditingMergeCellsAcross";
            this.spreadsheetCommandBarButtonItem33.Id = 63;
            this.spreadsheetCommandBarButtonItem33.Name = "spreadsheetCommandBarButtonItem33";
            // 
            // spreadsheetCommandBarButtonItem34
            // 
            this.spreadsheetCommandBarButtonItem34.CommandName = "EditingMergeCells";
            this.spreadsheetCommandBarButtonItem34.Id = 64;
            this.spreadsheetCommandBarButtonItem34.Name = "spreadsheetCommandBarButtonItem34";
            // 
            // spreadsheetCommandBarButtonItem35
            // 
            this.spreadsheetCommandBarButtonItem35.CommandName = "EditingUnmergeCells";
            this.spreadsheetCommandBarButtonItem35.Id = 65;
            this.spreadsheetCommandBarButtonItem35.Name = "spreadsheetCommandBarButtonItem35";
            // 
            // barButtonGroup5
            // 
            this.barButtonGroup5.Id = 16;
            this.barButtonGroup5.ItemLinks.Add(this.spreadsheetCommandBarCheckItem5);
            this.barButtonGroup5.ItemLinks.Add(this.spreadsheetCommandBarCheckItem6);
            this.barButtonGroup5.ItemLinks.Add(this.spreadsheetCommandBarCheckItem7);
            this.barButtonGroup5.Name = "barButtonGroup5";
            this.barButtonGroup5.Tag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            // 
            // barButtonGroup6
            // 
            this.barButtonGroup6.Id = 17;
            this.barButtonGroup6.ItemLinks.Add(this.spreadsheetCommandBarCheckItem8);
            this.barButtonGroup6.ItemLinks.Add(this.spreadsheetCommandBarCheckItem9);
            this.barButtonGroup6.ItemLinks.Add(this.spreadsheetCommandBarCheckItem10);
            this.barButtonGroup6.Name = "barButtonGroup6";
            this.barButtonGroup6.Tag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            // 
            // barButtonGroup7
            // 
            this.barButtonGroup7.Id = 18;
            this.barButtonGroup7.ItemLinks.Add(this.spreadsheetCommandBarButtonItem31);
            this.barButtonGroup7.ItemLinks.Add(this.spreadsheetCommandBarButtonItem32);
            this.barButtonGroup7.Name = "barButtonGroup7";
            this.barButtonGroup7.Tag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
            // 
            // numberRibbonPageGroup1
            // 
            this.numberRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup8);
            this.numberRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup9);
            this.numberRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup10);
            this.numberRibbonPageGroup1.Name = "numberRibbonPageGroup1";
            // 
            // changeNumberFormatItem1
            // 
            this.changeNumberFormatItem1.Edit = this.repositoryItemPopupGalleryEdit1;
            this.changeNumberFormatItem1.Id = 66;
            this.changeNumberFormatItem1.Name = "changeNumberFormatItem1";
            // 
            // spreadsheetCommandBarSubItem3
            // 
            this.spreadsheetCommandBarSubItem3.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            this.spreadsheetCommandBarSubItem3.CommandName = "FormatNumberAccountingCommandGroup";
            this.spreadsheetCommandBarSubItem3.Id = 67;
            this.spreadsheetCommandBarSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem36),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem37),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem38),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem39),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem40)});
            this.spreadsheetCommandBarSubItem3.Name = "spreadsheetCommandBarSubItem3";
            this.spreadsheetCommandBarSubItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem36
            // 
            this.spreadsheetCommandBarButtonItem36.CommandName = "FormatNumberAccountingUS";
            this.spreadsheetCommandBarButtonItem36.Id = 68;
            this.spreadsheetCommandBarButtonItem36.Name = "spreadsheetCommandBarButtonItem36";
            // 
            // spreadsheetCommandBarButtonItem37
            // 
            this.spreadsheetCommandBarButtonItem37.CommandName = "FormatNumberAccountingUK";
            this.spreadsheetCommandBarButtonItem37.Id = 69;
            this.spreadsheetCommandBarButtonItem37.Name = "spreadsheetCommandBarButtonItem37";
            // 
            // spreadsheetCommandBarButtonItem38
            // 
            this.spreadsheetCommandBarButtonItem38.CommandName = "FormatNumberAccountingEuro";
            this.spreadsheetCommandBarButtonItem38.Id = 70;
            this.spreadsheetCommandBarButtonItem38.Name = "spreadsheetCommandBarButtonItem38";
            // 
            // spreadsheetCommandBarButtonItem39
            // 
            this.spreadsheetCommandBarButtonItem39.CommandName = "FormatNumberAccountingPRC";
            this.spreadsheetCommandBarButtonItem39.Id = 71;
            this.spreadsheetCommandBarButtonItem39.Name = "spreadsheetCommandBarButtonItem39";
            // 
            // spreadsheetCommandBarButtonItem40
            // 
            this.spreadsheetCommandBarButtonItem40.CommandName = "FormatNumberAccountingSwiss";
            this.spreadsheetCommandBarButtonItem40.Id = 72;
            this.spreadsheetCommandBarButtonItem40.Name = "spreadsheetCommandBarButtonItem40";
            // 
            // spreadsheetCommandBarButtonItem41
            // 
            this.spreadsheetCommandBarButtonItem41.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            this.spreadsheetCommandBarButtonItem41.CommandName = "FormatNumberPercent";
            this.spreadsheetCommandBarButtonItem41.Id = 73;
            this.spreadsheetCommandBarButtonItem41.Name = "spreadsheetCommandBarButtonItem41";
            this.spreadsheetCommandBarButtonItem41.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem42
            // 
            this.spreadsheetCommandBarButtonItem42.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            this.spreadsheetCommandBarButtonItem42.CommandName = "FormatNumberAccounting";
            this.spreadsheetCommandBarButtonItem42.Id = 74;
            this.spreadsheetCommandBarButtonItem42.Name = "spreadsheetCommandBarButtonItem42";
            this.spreadsheetCommandBarButtonItem42.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem43
            // 
            this.spreadsheetCommandBarButtonItem43.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
            this.spreadsheetCommandBarButtonItem43.CommandName = "FormatNumberIncreaseDecimal";
            this.spreadsheetCommandBarButtonItem43.Id = 75;
            this.spreadsheetCommandBarButtonItem43.Name = "spreadsheetCommandBarButtonItem43";
            this.spreadsheetCommandBarButtonItem43.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem44
            // 
            this.spreadsheetCommandBarButtonItem44.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
            this.spreadsheetCommandBarButtonItem44.CommandName = "FormatNumberDecreaseDecimal";
            this.spreadsheetCommandBarButtonItem44.Id = 76;
            this.spreadsheetCommandBarButtonItem44.Name = "spreadsheetCommandBarButtonItem44";
            this.spreadsheetCommandBarButtonItem44.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroup8
            // 
            this.barButtonGroup8.Id = 19;
            this.barButtonGroup8.ItemLinks.Add(this.changeNumberFormatItem1);
            this.barButtonGroup8.Name = "barButtonGroup8";
            this.barButtonGroup8.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}";
            // 
            // repositoryItemPopupGalleryEdit1
            // 
            this.repositoryItemPopupGalleryEdit1.AutoHeight = false;
            this.repositoryItemPopupGalleryEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.repositoryItemPopupGalleryEdit1.Gallery.AllowFilter = false;
            this.repositoryItemPopupGalleryEdit1.Gallery.AutoFitColumns = false;
            this.repositoryItemPopupGalleryEdit1.Gallery.ColumnCount = 1;
            this.repositoryItemPopupGalleryEdit1.Gallery.FixedImageSize = false;
            spreadsheetCommandGalleryItem13.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem13.CaptionAsValue = true;
            spreadsheetCommandGalleryItem13.CommandName = "FormatNumberGeneral";
            spreadsheetCommandGalleryItem13.IsEmptyHint = true;
            spreadsheetCommandGalleryItem14.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem14.CaptionAsValue = true;
            spreadsheetCommandGalleryItem14.CommandName = "FormatNumberDecimal";
            spreadsheetCommandGalleryItem14.IsEmptyHint = true;
            spreadsheetCommandGalleryItem15.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem15.CaptionAsValue = true;
            spreadsheetCommandGalleryItem15.CommandName = "FormatNumberAccountingCurrency";
            spreadsheetCommandGalleryItem15.IsEmptyHint = true;
            spreadsheetCommandGalleryItem16.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem16.CaptionAsValue = true;
            spreadsheetCommandGalleryItem16.CommandName = "FormatNumberAccountingRegular";
            spreadsheetCommandGalleryItem16.IsEmptyHint = true;
            spreadsheetCommandGalleryItem17.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem17.CaptionAsValue = true;
            spreadsheetCommandGalleryItem17.CommandName = "FormatNumberShortDate";
            spreadsheetCommandGalleryItem17.IsEmptyHint = true;
            spreadsheetCommandGalleryItem18.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem18.CaptionAsValue = true;
            spreadsheetCommandGalleryItem18.CommandName = "FormatNumberLongDate";
            spreadsheetCommandGalleryItem18.IsEmptyHint = true;
            spreadsheetCommandGalleryItem19.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem19.CaptionAsValue = true;
            spreadsheetCommandGalleryItem19.CommandName = "FormatNumberTime";
            spreadsheetCommandGalleryItem19.IsEmptyHint = true;
            spreadsheetCommandGalleryItem20.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem20.CaptionAsValue = true;
            spreadsheetCommandGalleryItem20.CommandName = "FormatNumberPercentage";
            spreadsheetCommandGalleryItem20.IsEmptyHint = true;
            spreadsheetCommandGalleryItem21.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem21.CaptionAsValue = true;
            spreadsheetCommandGalleryItem21.CommandName = "FormatNumberFraction";
            spreadsheetCommandGalleryItem21.IsEmptyHint = true;
            spreadsheetCommandGalleryItem22.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem22.CaptionAsValue = true;
            spreadsheetCommandGalleryItem22.CommandName = "FormatNumberScientific";
            spreadsheetCommandGalleryItem22.IsEmptyHint = true;
            spreadsheetCommandGalleryItem23.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem23.CaptionAsValue = true;
            spreadsheetCommandGalleryItem23.CommandName = "FormatNumberText";
            spreadsheetCommandGalleryItem23.IsEmptyHint = true;
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem13,
            spreadsheetCommandGalleryItem14,
            spreadsheetCommandGalleryItem15,
            spreadsheetCommandGalleryItem16,
            spreadsheetCommandGalleryItem17,
            spreadsheetCommandGalleryItem18,
            spreadsheetCommandGalleryItem19,
            spreadsheetCommandGalleryItem20,
            spreadsheetCommandGalleryItem21,
            spreadsheetCommandGalleryItem22,
            spreadsheetCommandGalleryItem23});
            this.repositoryItemPopupGalleryEdit1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.repositoryItemPopupGalleryEdit1.Gallery.RowCount = 11;
            this.repositoryItemPopupGalleryEdit1.Gallery.ShowGroupCaption = false;
            this.repositoryItemPopupGalleryEdit1.Gallery.ShowItemText = true;
            this.repositoryItemPopupGalleryEdit1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide;
            this.repositoryItemPopupGalleryEdit1.Gallery.StretchItems = true;
            this.repositoryItemPopupGalleryEdit1.Name = "repositoryItemPopupGalleryEdit1";
            this.repositoryItemPopupGalleryEdit1.ShowButtons = false;
            this.repositoryItemPopupGalleryEdit1.ShowPopupCloseButton = false;
            this.repositoryItemPopupGalleryEdit1.ShowSizeGrip = false;
            // 
            // barButtonGroup9
            // 
            this.barButtonGroup9.Id = 20;
            this.barButtonGroup9.ItemLinks.Add(this.spreadsheetCommandBarSubItem3);
            this.barButtonGroup9.ItemLinks.Add(this.spreadsheetCommandBarButtonItem41);
            this.barButtonGroup9.ItemLinks.Add(this.spreadsheetCommandBarButtonItem42);
            this.barButtonGroup9.Name = "barButtonGroup9";
            this.barButtonGroup9.Tag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            // 
            // barButtonGroup10
            // 
            this.barButtonGroup10.Id = 21;
            this.barButtonGroup10.ItemLinks.Add(this.spreadsheetCommandBarButtonItem43);
            this.barButtonGroup10.ItemLinks.Add(this.spreadsheetCommandBarButtonItem44);
            this.barButtonGroup10.Name = "barButtonGroup10";
            this.barButtonGroup10.Tag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
            // 
            // stylesRibbonPageGroup1
            // 
            this.stylesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem4);
            this.stylesRibbonPageGroup1.ItemLinks.Add(this.galleryFormatAsTableItem1);
            this.stylesRibbonPageGroup1.ItemLinks.Add(this.galleryChangeStyleItem1);
            this.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1";
            // 
            // spreadsheetCommandBarSubItem4
            // 
            this.spreadsheetCommandBarSubItem4.CommandName = "ConditionalFormattingCommandGroup";
            this.spreadsheetCommandBarSubItem4.Id = 77;
            this.spreadsheetCommandBarSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem58),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem7)});
            this.spreadsheetCommandBarSubItem4.Name = "spreadsheetCommandBarSubItem4";
            // 
            // spreadsheetCommandBarSubItem5
            // 
            this.spreadsheetCommandBarSubItem5.CommandName = "ConditionalFormattingHighlightCellsRuleCommandGroup";
            this.spreadsheetCommandBarSubItem5.Id = 85;
            this.spreadsheetCommandBarSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem45),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem46),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem47),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem48),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem49),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem50),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem51)});
            this.spreadsheetCommandBarSubItem5.Name = "spreadsheetCommandBarSubItem5";
            // 
            // spreadsheetCommandBarButtonItem45
            // 
            this.spreadsheetCommandBarButtonItem45.CommandName = "ConditionalFormattingGreaterThanRuleCommand";
            this.spreadsheetCommandBarButtonItem45.Id = 78;
            this.spreadsheetCommandBarButtonItem45.Name = "spreadsheetCommandBarButtonItem45";
            this.spreadsheetCommandBarButtonItem45.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem46
            // 
            this.spreadsheetCommandBarButtonItem46.CommandName = "ConditionalFormattingLessThanRuleCommand";
            this.spreadsheetCommandBarButtonItem46.Id = 79;
            this.spreadsheetCommandBarButtonItem46.Name = "spreadsheetCommandBarButtonItem46";
            this.spreadsheetCommandBarButtonItem46.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem47
            // 
            this.spreadsheetCommandBarButtonItem47.CommandName = "ConditionalFormattingBetweenRuleCommand";
            this.spreadsheetCommandBarButtonItem47.Id = 80;
            this.spreadsheetCommandBarButtonItem47.Name = "spreadsheetCommandBarButtonItem47";
            this.spreadsheetCommandBarButtonItem47.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem48
            // 
            this.spreadsheetCommandBarButtonItem48.CommandName = "ConditionalFormattingEqualToRuleCommand";
            this.spreadsheetCommandBarButtonItem48.Id = 81;
            this.spreadsheetCommandBarButtonItem48.Name = "spreadsheetCommandBarButtonItem48";
            this.spreadsheetCommandBarButtonItem48.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem49
            // 
            this.spreadsheetCommandBarButtonItem49.CommandName = "ConditionalFormattingTextContainsRuleCommand";
            this.spreadsheetCommandBarButtonItem49.Id = 82;
            this.spreadsheetCommandBarButtonItem49.Name = "spreadsheetCommandBarButtonItem49";
            this.spreadsheetCommandBarButtonItem49.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem50
            // 
            this.spreadsheetCommandBarButtonItem50.CommandName = "ConditionalFormattingDateOccurringRuleCommand";
            this.spreadsheetCommandBarButtonItem50.Id = 83;
            this.spreadsheetCommandBarButtonItem50.Name = "spreadsheetCommandBarButtonItem50";
            this.spreadsheetCommandBarButtonItem50.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem51
            // 
            this.spreadsheetCommandBarButtonItem51.CommandName = "ConditionalFormattingDuplicateValuesRuleCommand";
            this.spreadsheetCommandBarButtonItem51.Id = 84;
            this.spreadsheetCommandBarButtonItem51.Name = "spreadsheetCommandBarButtonItem51";
            this.spreadsheetCommandBarButtonItem51.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem6
            // 
            this.spreadsheetCommandBarSubItem6.CommandName = "ConditionalFormattingTopBottomRuleCommandGroup";
            this.spreadsheetCommandBarSubItem6.Id = 92;
            this.spreadsheetCommandBarSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem52),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem53),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem54),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem55),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem56),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem57)});
            this.spreadsheetCommandBarSubItem6.Name = "spreadsheetCommandBarSubItem6";
            // 
            // spreadsheetCommandBarButtonItem52
            // 
            this.spreadsheetCommandBarButtonItem52.CommandName = "ConditionalFormattingTop10RuleCommand";
            this.spreadsheetCommandBarButtonItem52.Id = 86;
            this.spreadsheetCommandBarButtonItem52.Name = "spreadsheetCommandBarButtonItem52";
            this.spreadsheetCommandBarButtonItem52.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem53
            // 
            this.spreadsheetCommandBarButtonItem53.CommandName = "ConditionalFormattingTop10PercentRuleCommand";
            this.spreadsheetCommandBarButtonItem53.Id = 87;
            this.spreadsheetCommandBarButtonItem53.Name = "spreadsheetCommandBarButtonItem53";
            this.spreadsheetCommandBarButtonItem53.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem54
            // 
            this.spreadsheetCommandBarButtonItem54.CommandName = "ConditionalFormattingBottom10RuleCommand";
            this.spreadsheetCommandBarButtonItem54.Id = 88;
            this.spreadsheetCommandBarButtonItem54.Name = "spreadsheetCommandBarButtonItem54";
            this.spreadsheetCommandBarButtonItem54.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem55
            // 
            this.spreadsheetCommandBarButtonItem55.CommandName = "ConditionalFormattingBottom10PercentRuleCommand";
            this.spreadsheetCommandBarButtonItem55.Id = 89;
            this.spreadsheetCommandBarButtonItem55.Name = "spreadsheetCommandBarButtonItem55";
            this.spreadsheetCommandBarButtonItem55.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem56
            // 
            this.spreadsheetCommandBarButtonItem56.CommandName = "ConditionalFormattingAboveAverageRuleCommand";
            this.spreadsheetCommandBarButtonItem56.Id = 90;
            this.spreadsheetCommandBarButtonItem56.Name = "spreadsheetCommandBarButtonItem56";
            this.spreadsheetCommandBarButtonItem56.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem57
            // 
            this.spreadsheetCommandBarButtonItem57.CommandName = "ConditionalFormattingBelowAverageRuleCommand";
            this.spreadsheetCommandBarButtonItem57.Id = 91;
            this.spreadsheetCommandBarButtonItem57.Name = "spreadsheetCommandBarButtonItem57";
            this.spreadsheetCommandBarButtonItem57.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem1
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.CommandName = "ConditionalFormattingDataBarsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.DropDownControl = this.commandBarGalleryDropDown50;
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.Id = 93;
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.Name = "spreadsheetCommandBarButtonGalleryDropDownItem1";
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // commandBarGalleryDropDown50
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown50.Gallery.ColumnCount = 3;
            spreadsheetCommandGalleryItemGroup3.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup";
            spreadsheetCommandGalleryItem24.CommandName = "ConditionalFormattingDataBarGradientBlue";
            spreadsheetCommandGalleryItem25.CommandName = "ConditionalFormattingDataBarGradientGreen";
            spreadsheetCommandGalleryItem26.CommandName = "ConditionalFormattingDataBarGradientRed";
            spreadsheetCommandGalleryItem27.CommandName = "ConditionalFormattingDataBarGradientOrange";
            spreadsheetCommandGalleryItem28.CommandName = "ConditionalFormattingDataBarGradientLightBlue";
            spreadsheetCommandGalleryItem29.CommandName = "ConditionalFormattingDataBarGradientPurple";
            spreadsheetCommandGalleryItemGroup3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem24,
            spreadsheetCommandGalleryItem25,
            spreadsheetCommandGalleryItem26,
            spreadsheetCommandGalleryItem27,
            spreadsheetCommandGalleryItem28,
            spreadsheetCommandGalleryItem29});
            spreadsheetCommandGalleryItemGroup4.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup";
            spreadsheetCommandGalleryItem30.CommandName = "ConditionalFormattingDataBarSolidBlue";
            spreadsheetCommandGalleryItem31.CommandName = "ConditionalFormattingDataBarSolidGreen";
            spreadsheetCommandGalleryItem32.CommandName = "ConditionalFormattingDataBarSolidRed";
            spreadsheetCommandGalleryItem33.CommandName = "ConditionalFormattingDataBarSolidOrange";
            spreadsheetCommandGalleryItem34.CommandName = "ConditionalFormattingDataBarSolidLightBlue";
            spreadsheetCommandGalleryItem35.CommandName = "ConditionalFormattingDataBarSolidPurple";
            spreadsheetCommandGalleryItemGroup4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem30,
            spreadsheetCommandGalleryItem31,
            spreadsheetCommandGalleryItem32,
            spreadsheetCommandGalleryItem33,
            spreadsheetCommandGalleryItem34,
            spreadsheetCommandGalleryItem35});
            this.commandBarGalleryDropDown50.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup3,
            spreadsheetCommandGalleryItemGroup4});
            this.commandBarGalleryDropDown50.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown50.Name = "commandBarGalleryDropDown50";
            this.commandBarGalleryDropDown50.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem2
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.CommandName = "ConditionalFormattingColorScalesCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.DropDownControl = this.commandBarGalleryDropDown51;
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.Id = 94;
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.Name = "spreadsheetCommandBarButtonGalleryDropDownItem2";
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // commandBarGalleryDropDown51
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown51.Gallery.ColumnCount = 4;
            spreadsheetCommandGalleryItemGroup5.CommandName = "ConditionalFormattingColorScalesCommandGroup";
            spreadsheetCommandGalleryItem36.CommandName = "ConditionalFormattingColorScaleGreenYellowRed";
            spreadsheetCommandGalleryItem37.CommandName = "ConditionalFormattingColorScaleRedYellowGreen";
            spreadsheetCommandGalleryItem38.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed";
            spreadsheetCommandGalleryItem39.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen";
            spreadsheetCommandGalleryItem40.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed";
            spreadsheetCommandGalleryItem41.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue";
            spreadsheetCommandGalleryItem42.CommandName = "ConditionalFormattingColorScaleWhiteRed";
            spreadsheetCommandGalleryItem43.CommandName = "ConditionalFormattingColorScaleRedWhite";
            spreadsheetCommandGalleryItem44.CommandName = "ConditionalFormattingColorScaleGreenWhite";
            spreadsheetCommandGalleryItem45.CommandName = "ConditionalFormattingColorScaleWhiteGreen";
            spreadsheetCommandGalleryItem46.CommandName = "ConditionalFormattingColorScaleGreenYellow";
            spreadsheetCommandGalleryItem47.CommandName = "ConditionalFormattingColorScaleYellowGreen";
            spreadsheetCommandGalleryItemGroup5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem36,
            spreadsheetCommandGalleryItem37,
            spreadsheetCommandGalleryItem38,
            spreadsheetCommandGalleryItem39,
            spreadsheetCommandGalleryItem40,
            spreadsheetCommandGalleryItem41,
            spreadsheetCommandGalleryItem42,
            spreadsheetCommandGalleryItem43,
            spreadsheetCommandGalleryItem44,
            spreadsheetCommandGalleryItem45,
            spreadsheetCommandGalleryItem46,
            spreadsheetCommandGalleryItem47});
            this.commandBarGalleryDropDown51.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup5});
            this.commandBarGalleryDropDown51.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown51.Name = "commandBarGalleryDropDown51";
            this.commandBarGalleryDropDown51.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem3
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.CommandName = "ConditionalFormattingIconSetsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.DropDownControl = this.commandBarGalleryDropDown52;
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.Id = 95;
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.Name = "spreadsheetCommandBarButtonGalleryDropDownItem3";
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // commandBarGalleryDropDown52
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown52.Gallery.ColumnCount = 4;
            spreadsheetCommandGalleryItemGroup6.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup";
            spreadsheetCommandGalleryItem48.CommandName = "ConditionalFormattingIconSetArrows3Colored";
            spreadsheetCommandGalleryItem49.CommandName = "ConditionalFormattingIconSetArrows3Grayed";
            spreadsheetCommandGalleryItem50.CommandName = "ConditionalFormattingIconSetArrows4Colored";
            spreadsheetCommandGalleryItem51.CommandName = "ConditionalFormattingIconSetArrows4Grayed";
            spreadsheetCommandGalleryItem52.CommandName = "ConditionalFormattingIconSetArrows5Colored";
            spreadsheetCommandGalleryItem53.CommandName = "ConditionalFormattingIconSetArrows5Grayed";
            spreadsheetCommandGalleryItem54.CommandName = "ConditionalFormattingIconSetTriangles3";
            spreadsheetCommandGalleryItemGroup6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem48,
            spreadsheetCommandGalleryItem49,
            spreadsheetCommandGalleryItem50,
            spreadsheetCommandGalleryItem51,
            spreadsheetCommandGalleryItem52,
            spreadsheetCommandGalleryItem53,
            spreadsheetCommandGalleryItem54});
            spreadsheetCommandGalleryItemGroup7.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup";
            spreadsheetCommandGalleryItem55.CommandName = "ConditionalFormattingIconSetTrafficLights3";
            spreadsheetCommandGalleryItem56.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed";
            spreadsheetCommandGalleryItem57.CommandName = "ConditionalFormattingIconSetTrafficLights4";
            spreadsheetCommandGalleryItem58.CommandName = "ConditionalFormattingIconSetSigns3";
            spreadsheetCommandGalleryItem59.CommandName = "ConditionalFormattingIconSetRedToBlack";
            spreadsheetCommandGalleryItemGroup7.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem55,
            spreadsheetCommandGalleryItem56,
            spreadsheetCommandGalleryItem57,
            spreadsheetCommandGalleryItem58,
            spreadsheetCommandGalleryItem59});
            spreadsheetCommandGalleryItemGroup8.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup";
            spreadsheetCommandGalleryItem60.CommandName = "ConditionalFormattingIconSetSymbols3Circled";
            spreadsheetCommandGalleryItem61.CommandName = "ConditionalFormattingIconSetSymbols3";
            spreadsheetCommandGalleryItem62.CommandName = "ConditionalFormattingIconSetFlags3";
            spreadsheetCommandGalleryItemGroup8.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem60,
            spreadsheetCommandGalleryItem61,
            spreadsheetCommandGalleryItem62});
            spreadsheetCommandGalleryItemGroup9.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup";
            spreadsheetCommandGalleryItem63.CommandName = "ConditionalFormattingIconSetStars3";
            spreadsheetCommandGalleryItem64.CommandName = "ConditionalFormattingIconSetRatings4";
            spreadsheetCommandGalleryItem65.CommandName = "ConditionalFormattingIconSetRatings5";
            spreadsheetCommandGalleryItem66.CommandName = "ConditionalFormattingIconSetQuarters5";
            spreadsheetCommandGalleryItem67.CommandName = "ConditionalFormattingIconSetBoxes5";
            spreadsheetCommandGalleryItemGroup9.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem63,
            spreadsheetCommandGalleryItem64,
            spreadsheetCommandGalleryItem65,
            spreadsheetCommandGalleryItem66,
            spreadsheetCommandGalleryItem67});
            this.commandBarGalleryDropDown52.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup6,
            spreadsheetCommandGalleryItemGroup7,
            spreadsheetCommandGalleryItemGroup8,
            spreadsheetCommandGalleryItemGroup9});
            this.commandBarGalleryDropDown52.Gallery.RowCount = 7;
            this.commandBarGalleryDropDown52.Name = "commandBarGalleryDropDown52";
            this.commandBarGalleryDropDown52.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonItem58
            // 
            this.spreadsheetCommandBarButtonItem58.CommandName = "NewConditionalFormattingRule";
            this.spreadsheetCommandBarButtonItem58.Id = 96;
            this.spreadsheetCommandBarButtonItem58.Name = "spreadsheetCommandBarButtonItem58";
            // 
            // spreadsheetCommandBarSubItem7
            // 
            this.spreadsheetCommandBarSubItem7.CommandName = "ConditionalFormattingRemoveCommandGroup";
            this.spreadsheetCommandBarSubItem7.Id = 99;
            this.spreadsheetCommandBarSubItem7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem59),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem60)});
            this.spreadsheetCommandBarSubItem7.Name = "spreadsheetCommandBarSubItem7";
            // 
            // spreadsheetCommandBarButtonItem59
            // 
            this.spreadsheetCommandBarButtonItem59.CommandName = "ConditionalFormattingRemoveFromSheet";
            this.spreadsheetCommandBarButtonItem59.Id = 97;
            this.spreadsheetCommandBarButtonItem59.Name = "spreadsheetCommandBarButtonItem59";
            // 
            // spreadsheetCommandBarButtonItem60
            // 
            this.spreadsheetCommandBarButtonItem60.CommandName = "ConditionalFormattingRemove";
            this.spreadsheetCommandBarButtonItem60.Id = 98;
            this.spreadsheetCommandBarButtonItem60.Name = "spreadsheetCommandBarButtonItem60";
            // 
            // galleryFormatAsTableItem1
            // 
            this.galleryFormatAsTableItem1.DropDownControl = this.commandBarGalleryDropDown53;
            this.galleryFormatAsTableItem1.Id = 100;
            this.galleryFormatAsTableItem1.Name = "galleryFormatAsTableItem1";
            // 
            // commandBarGalleryDropDown53
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown53.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown53.Gallery.ColumnCount = 7;
            this.commandBarGalleryDropDown53.Gallery.DrawImageBackground = false;
            this.commandBarGalleryDropDown53.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown53.Gallery.ItemSize = new System.Drawing.Size(73, 58);
            this.commandBarGalleryDropDown53.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown53.Name = "commandBarGalleryDropDown53";
            this.commandBarGalleryDropDown53.Ribbon = this.ribbonControl1;
            // 
            // galleryChangeStyleItem1
            // 
            // 
            // 
            // 
            this.galleryChangeStyleItem1.Gallery.DrawImageBackground = false;
            this.galleryChangeStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChangeStyleItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.galleryChangeStyleItem1.Gallery.ItemSize = new System.Drawing.Size(106, 28);
            this.galleryChangeStyleItem1.Gallery.RowCount = 9;
            this.galleryChangeStyleItem1.Gallery.ShowItemText = true;
            this.galleryChangeStyleItem1.Id = 101;
            this.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1";
            // 
            // cellsRibbonPageGroup1
            // 
            this.cellsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem8);
            this.cellsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem9);
            this.cellsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem10);
            this.cellsRibbonPageGroup1.Name = "cellsRibbonPageGroup1";
            // 
            // spreadsheetCommandBarSubItem8
            // 
            this.spreadsheetCommandBarSubItem8.CommandName = "InsertCellsCommandGroup";
            this.spreadsheetCommandBarSubItem8.Id = 102;
            this.spreadsheetCommandBarSubItem8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem61),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem62),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem63)});
            this.spreadsheetCommandBarSubItem8.Name = "spreadsheetCommandBarSubItem8";
            // 
            // spreadsheetCommandBarButtonItem61
            // 
            this.spreadsheetCommandBarButtonItem61.CommandName = "InsertSheetRows";
            this.spreadsheetCommandBarButtonItem61.Id = 103;
            this.spreadsheetCommandBarButtonItem61.Name = "spreadsheetCommandBarButtonItem61";
            // 
            // spreadsheetCommandBarButtonItem62
            // 
            this.spreadsheetCommandBarButtonItem62.CommandName = "InsertSheetColumns";
            this.spreadsheetCommandBarButtonItem62.Id = 104;
            this.spreadsheetCommandBarButtonItem62.Name = "spreadsheetCommandBarButtonItem62";
            // 
            // spreadsheetCommandBarButtonItem63
            // 
            this.spreadsheetCommandBarButtonItem63.CommandName = "InsertSheet";
            this.spreadsheetCommandBarButtonItem63.Id = 105;
            this.spreadsheetCommandBarButtonItem63.Name = "spreadsheetCommandBarButtonItem63";
            // 
            // spreadsheetCommandBarSubItem9
            // 
            this.spreadsheetCommandBarSubItem9.CommandName = "RemoveCellsCommandGroup";
            this.spreadsheetCommandBarSubItem9.Id = 106;
            this.spreadsheetCommandBarSubItem9.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem64),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem65),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem66)});
            this.spreadsheetCommandBarSubItem9.Name = "spreadsheetCommandBarSubItem9";
            // 
            // spreadsheetCommandBarButtonItem64
            // 
            this.spreadsheetCommandBarButtonItem64.CommandName = "RemoveSheetRows";
            this.spreadsheetCommandBarButtonItem64.Id = 107;
            this.spreadsheetCommandBarButtonItem64.Name = "spreadsheetCommandBarButtonItem64";
            // 
            // spreadsheetCommandBarButtonItem65
            // 
            this.spreadsheetCommandBarButtonItem65.CommandName = "RemoveSheetColumns";
            this.spreadsheetCommandBarButtonItem65.Id = 108;
            this.spreadsheetCommandBarButtonItem65.Name = "spreadsheetCommandBarButtonItem65";
            // 
            // spreadsheetCommandBarButtonItem66
            // 
            this.spreadsheetCommandBarButtonItem66.CommandName = "RemoveSheet";
            this.spreadsheetCommandBarButtonItem66.Id = 109;
            this.spreadsheetCommandBarButtonItem66.Name = "spreadsheetCommandBarButtonItem66";
            // 
            // spreadsheetCommandBarSubItem10
            // 
            this.spreadsheetCommandBarSubItem10.CommandName = "FormatCommandGroup";
            this.spreadsheetCommandBarSubItem10.Id = 110;
            this.spreadsheetCommandBarSubItem10.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem67),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem68),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem69),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem70),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem71),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem11),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem78),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem79),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeSheetTabColorItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem80),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem13),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem81)});
            this.spreadsheetCommandBarSubItem10.Name = "spreadsheetCommandBarSubItem10";
            // 
            // spreadsheetCommandBarButtonItem67
            // 
            this.spreadsheetCommandBarButtonItem67.CommandName = "FormatRowHeight";
            this.spreadsheetCommandBarButtonItem67.Id = 111;
            this.spreadsheetCommandBarButtonItem67.Name = "spreadsheetCommandBarButtonItem67";
            // 
            // spreadsheetCommandBarButtonItem68
            // 
            this.spreadsheetCommandBarButtonItem68.CommandName = "FormatAutoFitRowHeight";
            this.spreadsheetCommandBarButtonItem68.Id = 112;
            this.spreadsheetCommandBarButtonItem68.Name = "spreadsheetCommandBarButtonItem68";
            // 
            // spreadsheetCommandBarButtonItem69
            // 
            this.spreadsheetCommandBarButtonItem69.CommandName = "FormatColumnWidth";
            this.spreadsheetCommandBarButtonItem69.Id = 113;
            this.spreadsheetCommandBarButtonItem69.Name = "spreadsheetCommandBarButtonItem69";
            // 
            // spreadsheetCommandBarButtonItem70
            // 
            this.spreadsheetCommandBarButtonItem70.CommandName = "FormatAutoFitColumnWidth";
            this.spreadsheetCommandBarButtonItem70.Id = 114;
            this.spreadsheetCommandBarButtonItem70.Name = "spreadsheetCommandBarButtonItem70";
            // 
            // spreadsheetCommandBarButtonItem71
            // 
            this.spreadsheetCommandBarButtonItem71.CommandName = "FormatDefaultColumnWidth";
            this.spreadsheetCommandBarButtonItem71.Id = 115;
            this.spreadsheetCommandBarButtonItem71.Name = "spreadsheetCommandBarButtonItem71";
            // 
            // spreadsheetCommandBarSubItem11
            // 
            this.spreadsheetCommandBarSubItem11.CommandName = "HideAndUnhideCommandGroup";
            this.spreadsheetCommandBarSubItem11.Id = 122;
            this.spreadsheetCommandBarSubItem11.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem72),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem73),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem74),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem75),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem76),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem77)});
            this.spreadsheetCommandBarSubItem11.Name = "spreadsheetCommandBarSubItem11";
            // 
            // spreadsheetCommandBarButtonItem72
            // 
            this.spreadsheetCommandBarButtonItem72.CommandName = "HideRows";
            this.spreadsheetCommandBarButtonItem72.Id = 116;
            this.spreadsheetCommandBarButtonItem72.Name = "spreadsheetCommandBarButtonItem72";
            // 
            // spreadsheetCommandBarButtonItem73
            // 
            this.spreadsheetCommandBarButtonItem73.CommandName = "HideColumns";
            this.spreadsheetCommandBarButtonItem73.Id = 117;
            this.spreadsheetCommandBarButtonItem73.Name = "spreadsheetCommandBarButtonItem73";
            // 
            // spreadsheetCommandBarButtonItem74
            // 
            this.spreadsheetCommandBarButtonItem74.CommandName = "HideSheet";
            this.spreadsheetCommandBarButtonItem74.Id = 118;
            this.spreadsheetCommandBarButtonItem74.Name = "spreadsheetCommandBarButtonItem74";
            // 
            // spreadsheetCommandBarButtonItem75
            // 
            this.spreadsheetCommandBarButtonItem75.CommandName = "UnhideRows";
            this.spreadsheetCommandBarButtonItem75.Id = 119;
            this.spreadsheetCommandBarButtonItem75.Name = "spreadsheetCommandBarButtonItem75";
            // 
            // spreadsheetCommandBarButtonItem76
            // 
            this.spreadsheetCommandBarButtonItem76.CommandName = "UnhideColumns";
            this.spreadsheetCommandBarButtonItem76.Id = 120;
            this.spreadsheetCommandBarButtonItem76.Name = "spreadsheetCommandBarButtonItem76";
            // 
            // spreadsheetCommandBarButtonItem77
            // 
            this.spreadsheetCommandBarButtonItem77.CommandName = "UnhideSheet";
            this.spreadsheetCommandBarButtonItem77.Id = 121;
            this.spreadsheetCommandBarButtonItem77.Name = "spreadsheetCommandBarButtonItem77";
            // 
            // spreadsheetCommandBarButtonItem78
            // 
            this.spreadsheetCommandBarButtonItem78.CommandName = "RenameSheet";
            this.spreadsheetCommandBarButtonItem78.Id = 123;
            this.spreadsheetCommandBarButtonItem78.Name = "spreadsheetCommandBarButtonItem78";
            // 
            // spreadsheetCommandBarButtonItem79
            // 
            this.spreadsheetCommandBarButtonItem79.CommandName = "MoveOrCopySheet";
            this.spreadsheetCommandBarButtonItem79.Id = 124;
            this.spreadsheetCommandBarButtonItem79.Name = "spreadsheetCommandBarButtonItem79";
            // 
            // changeSheetTabColorItem1
            // 
            this.changeSheetTabColorItem1.ActAsDropDown = true;
            this.changeSheetTabColorItem1.Id = 125;
            this.changeSheetTabColorItem1.Name = "changeSheetTabColorItem1";
            // 
            // spreadsheetCommandBarButtonItem80
            // 
            this.spreadsheetCommandBarButtonItem80.CommandName = "ReviewProtectSheet";
            this.spreadsheetCommandBarButtonItem80.Id = 126;
            this.spreadsheetCommandBarButtonItem80.Name = "spreadsheetCommandBarButtonItem80";
            // 
            // spreadsheetCommandBarCheckItem13
            // 
            this.spreadsheetCommandBarCheckItem13.CommandName = "FormatCellLocked";
            this.spreadsheetCommandBarCheckItem13.Id = 127;
            this.spreadsheetCommandBarCheckItem13.Name = "spreadsheetCommandBarCheckItem13";
            // 
            // spreadsheetCommandBarButtonItem81
            // 
            this.spreadsheetCommandBarButtonItem81.CommandName = "FormatCellsContextMenuItem";
            this.spreadsheetCommandBarButtonItem81.Id = 128;
            this.spreadsheetCommandBarButtonItem81.Name = "spreadsheetCommandBarButtonItem81";
            // 
            // editingRibbonPageGroup1
            // 
            this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem12);
            this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem13);
            this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem14);
            this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem15);
            this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem16);
            this.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1";
            // 
            // spreadsheetCommandBarSubItem12
            // 
            this.spreadsheetCommandBarSubItem12.CommandName = "EditingAutoSumCommandGroup";
            this.spreadsheetCommandBarSubItem12.Id = 129;
            this.spreadsheetCommandBarSubItem12.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem82),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem83),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem84),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem85),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem86)});
            this.spreadsheetCommandBarSubItem12.Name = "spreadsheetCommandBarSubItem12";
            this.spreadsheetCommandBarSubItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem82
            // 
            this.spreadsheetCommandBarButtonItem82.CommandName = "FunctionsInsertSum";
            this.spreadsheetCommandBarButtonItem82.Id = 130;
            this.spreadsheetCommandBarButtonItem82.Name = "spreadsheetCommandBarButtonItem82";
            // 
            // spreadsheetCommandBarButtonItem83
            // 
            this.spreadsheetCommandBarButtonItem83.CommandName = "FunctionsInsertAverage";
            this.spreadsheetCommandBarButtonItem83.Id = 131;
            this.spreadsheetCommandBarButtonItem83.Name = "spreadsheetCommandBarButtonItem83";
            // 
            // spreadsheetCommandBarButtonItem84
            // 
            this.spreadsheetCommandBarButtonItem84.CommandName = "FunctionsInsertCountNumbers";
            this.spreadsheetCommandBarButtonItem84.Id = 132;
            this.spreadsheetCommandBarButtonItem84.Name = "spreadsheetCommandBarButtonItem84";
            // 
            // spreadsheetCommandBarButtonItem85
            // 
            this.spreadsheetCommandBarButtonItem85.CommandName = "FunctionsInsertMax";
            this.spreadsheetCommandBarButtonItem85.Id = 133;
            this.spreadsheetCommandBarButtonItem85.Name = "spreadsheetCommandBarButtonItem85";
            // 
            // spreadsheetCommandBarButtonItem86
            // 
            this.spreadsheetCommandBarButtonItem86.CommandName = "FunctionsInsertMin";
            this.spreadsheetCommandBarButtonItem86.Id = 134;
            this.spreadsheetCommandBarButtonItem86.Name = "spreadsheetCommandBarButtonItem86";
            // 
            // spreadsheetCommandBarSubItem13
            // 
            this.spreadsheetCommandBarSubItem13.CommandName = "EditingFillCommandGroup";
            this.spreadsheetCommandBarSubItem13.Id = 135;
            this.spreadsheetCommandBarSubItem13.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem87),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem88),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem89),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem90)});
            this.spreadsheetCommandBarSubItem13.Name = "spreadsheetCommandBarSubItem13";
            this.spreadsheetCommandBarSubItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem87
            // 
            this.spreadsheetCommandBarButtonItem87.CommandName = "EditingFillDown";
            this.spreadsheetCommandBarButtonItem87.Id = 136;
            this.spreadsheetCommandBarButtonItem87.Name = "spreadsheetCommandBarButtonItem87";
            // 
            // spreadsheetCommandBarButtonItem88
            // 
            this.spreadsheetCommandBarButtonItem88.CommandName = "EditingFillRight";
            this.spreadsheetCommandBarButtonItem88.Id = 137;
            this.spreadsheetCommandBarButtonItem88.Name = "spreadsheetCommandBarButtonItem88";
            // 
            // spreadsheetCommandBarButtonItem89
            // 
            this.spreadsheetCommandBarButtonItem89.CommandName = "EditingFillUp";
            this.spreadsheetCommandBarButtonItem89.Id = 138;
            this.spreadsheetCommandBarButtonItem89.Name = "spreadsheetCommandBarButtonItem89";
            // 
            // spreadsheetCommandBarButtonItem90
            // 
            this.spreadsheetCommandBarButtonItem90.CommandName = "EditingFillLeft";
            this.spreadsheetCommandBarButtonItem90.Id = 139;
            this.spreadsheetCommandBarButtonItem90.Name = "spreadsheetCommandBarButtonItem90";
            // 
            // spreadsheetCommandBarSubItem14
            // 
            this.spreadsheetCommandBarSubItem14.CommandName = "FormatClearCommandGroup";
            this.spreadsheetCommandBarSubItem14.Id = 140;
            this.spreadsheetCommandBarSubItem14.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem91),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem92),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem93),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem94),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem95),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem96)});
            this.spreadsheetCommandBarSubItem14.Name = "spreadsheetCommandBarSubItem14";
            this.spreadsheetCommandBarSubItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem91
            // 
            this.spreadsheetCommandBarButtonItem91.CommandName = "FormatClearAll";
            this.spreadsheetCommandBarButtonItem91.Id = 141;
            this.spreadsheetCommandBarButtonItem91.Name = "spreadsheetCommandBarButtonItem91";
            // 
            // spreadsheetCommandBarButtonItem92
            // 
            this.spreadsheetCommandBarButtonItem92.CommandName = "FormatClearFormats";
            this.spreadsheetCommandBarButtonItem92.Id = 142;
            this.spreadsheetCommandBarButtonItem92.Name = "spreadsheetCommandBarButtonItem92";
            // 
            // spreadsheetCommandBarButtonItem93
            // 
            this.spreadsheetCommandBarButtonItem93.CommandName = "FormatClearContents";
            this.spreadsheetCommandBarButtonItem93.Id = 143;
            this.spreadsheetCommandBarButtonItem93.Name = "spreadsheetCommandBarButtonItem93";
            // 
            // spreadsheetCommandBarButtonItem94
            // 
            this.spreadsheetCommandBarButtonItem94.CommandName = "FormatClearComments";
            this.spreadsheetCommandBarButtonItem94.Id = 144;
            this.spreadsheetCommandBarButtonItem94.Name = "spreadsheetCommandBarButtonItem94";
            // 
            // spreadsheetCommandBarButtonItem95
            // 
            this.spreadsheetCommandBarButtonItem95.CommandName = "FormatClearHyperlinks";
            this.spreadsheetCommandBarButtonItem95.Id = 145;
            this.spreadsheetCommandBarButtonItem95.Name = "spreadsheetCommandBarButtonItem95";
            // 
            // spreadsheetCommandBarButtonItem96
            // 
            this.spreadsheetCommandBarButtonItem96.CommandName = "FormatRemoveHyperlinks";
            this.spreadsheetCommandBarButtonItem96.Id = 146;
            this.spreadsheetCommandBarButtonItem96.Name = "spreadsheetCommandBarButtonItem96";
            // 
            // spreadsheetCommandBarSubItem15
            // 
            this.spreadsheetCommandBarSubItem15.CommandName = "EditingSortAndFilterCommandGroup";
            this.spreadsheetCommandBarSubItem15.Id = 147;
            this.spreadsheetCommandBarSubItem15.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem97),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem98),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem14),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem99),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem100)});
            this.spreadsheetCommandBarSubItem15.Name = "spreadsheetCommandBarSubItem15";
            // 
            // spreadsheetCommandBarButtonItem97
            // 
            this.spreadsheetCommandBarButtonItem97.CommandName = "DataSortAscending";
            this.spreadsheetCommandBarButtonItem97.Id = 148;
            this.spreadsheetCommandBarButtonItem97.Name = "spreadsheetCommandBarButtonItem97";
            // 
            // spreadsheetCommandBarButtonItem98
            // 
            this.spreadsheetCommandBarButtonItem98.CommandName = "DataSortDescending";
            this.spreadsheetCommandBarButtonItem98.Id = 149;
            this.spreadsheetCommandBarButtonItem98.Name = "spreadsheetCommandBarButtonItem98";
            // 
            // spreadsheetCommandBarCheckItem14
            // 
            this.spreadsheetCommandBarCheckItem14.CommandName = "DataFilterToggle";
            this.spreadsheetCommandBarCheckItem14.Id = 150;
            this.spreadsheetCommandBarCheckItem14.Name = "spreadsheetCommandBarCheckItem14";
            // 
            // spreadsheetCommandBarButtonItem99
            // 
            this.spreadsheetCommandBarButtonItem99.CommandName = "DataFilterClear";
            this.spreadsheetCommandBarButtonItem99.Id = 151;
            this.spreadsheetCommandBarButtonItem99.Name = "spreadsheetCommandBarButtonItem99";
            // 
            // spreadsheetCommandBarButtonItem100
            // 
            this.spreadsheetCommandBarButtonItem100.CommandName = "DataFilterReApply";
            this.spreadsheetCommandBarButtonItem100.Id = 152;
            this.spreadsheetCommandBarButtonItem100.Name = "spreadsheetCommandBarButtonItem100";
            // 
            // spreadsheetCommandBarSubItem16
            // 
            this.spreadsheetCommandBarSubItem16.CommandName = "EditingFindAndSelectCommandGroup";
            this.spreadsheetCommandBarSubItem16.Id = 153;
            this.spreadsheetCommandBarSubItem16.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem101),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem102),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem103),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem104),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem105),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem106),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem112)});
            this.spreadsheetCommandBarSubItem16.Name = "spreadsheetCommandBarSubItem16";
            // 
            // spreadsheetCommandBarButtonItem101
            // 
            this.spreadsheetCommandBarButtonItem101.CommandName = "EditingFind";
            this.spreadsheetCommandBarButtonItem101.Id = 154;
            this.spreadsheetCommandBarButtonItem101.Name = "spreadsheetCommandBarButtonItem101";
            // 
            // spreadsheetCommandBarButtonItem102
            // 
            this.spreadsheetCommandBarButtonItem102.CommandName = "EditingReplace";
            this.spreadsheetCommandBarButtonItem102.Id = 155;
            this.spreadsheetCommandBarButtonItem102.Name = "spreadsheetCommandBarButtonItem102";
            // 
            // spreadsheetCommandBarButtonItem103
            // 
            this.spreadsheetCommandBarButtonItem103.CommandName = "EditingSelectFormulas";
            this.spreadsheetCommandBarButtonItem103.Id = 156;
            this.spreadsheetCommandBarButtonItem103.Name = "spreadsheetCommandBarButtonItem103";
            // 
            // spreadsheetCommandBarButtonItem104
            // 
            this.spreadsheetCommandBarButtonItem104.CommandName = "EditingSelectComments";
            this.spreadsheetCommandBarButtonItem104.Id = 157;
            this.spreadsheetCommandBarButtonItem104.Name = "spreadsheetCommandBarButtonItem104";
            // 
            // spreadsheetCommandBarButtonItem105
            // 
            this.spreadsheetCommandBarButtonItem105.CommandName = "EditingSelectConditionalFormatting";
            this.spreadsheetCommandBarButtonItem105.Id = 158;
            this.spreadsheetCommandBarButtonItem105.Name = "spreadsheetCommandBarButtonItem105";
            // 
            // spreadsheetCommandBarButtonItem106
            // 
            this.spreadsheetCommandBarButtonItem106.CommandName = "EditingSelectConstants";
            this.spreadsheetCommandBarButtonItem106.Id = 159;
            this.spreadsheetCommandBarButtonItem106.Name = "spreadsheetCommandBarButtonItem106";
            // 
            // spreadsheetCommandBarButtonItem112
            // 
            this.spreadsheetCommandBarButtonItem112.CommandName = "EditingSelectDataValidation";
            this.spreadsheetCommandBarButtonItem112.Id = 160;
            this.spreadsheetCommandBarButtonItem112.Name = "spreadsheetCommandBarButtonItem112";
            // 
            // tablesRibbonPageGroup1
            // 
            this.tablesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem113);
            this.tablesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem114);
            this.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1";
            // 
            // insertRibbonPage1
            // 
            this.insertRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tablesRibbonPageGroup1,
            this.illustrationsRibbonPageGroup1,
            this.chartsRibbonPageGroup1,
            this.linksRibbonPageGroup1,
            this.symbolsRibbonPageGroup1});
            this.insertRibbonPage1.Name = "insertRibbonPage1";
            // 
            // spreadsheetCommandBarButtonItem113
            // 
            this.spreadsheetCommandBarButtonItem113.CommandName = "InsertPivotTable";
            this.spreadsheetCommandBarButtonItem113.Id = 161;
            this.spreadsheetCommandBarButtonItem113.Name = "spreadsheetCommandBarButtonItem113";
            // 
            // spreadsheetCommandBarButtonItem114
            // 
            this.spreadsheetCommandBarButtonItem114.CommandName = "InsertTable";
            this.spreadsheetCommandBarButtonItem114.Id = 162;
            this.spreadsheetCommandBarButtonItem114.Name = "spreadsheetCommandBarButtonItem114";
            // 
            // illustrationsRibbonPageGroup1
            // 
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem115);
            this.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonItem115
            // 
            this.spreadsheetCommandBarButtonItem115.CommandName = "InsertPicture";
            this.spreadsheetCommandBarButtonItem115.Id = 163;
            this.spreadsheetCommandBarButtonItem115.Name = "spreadsheetCommandBarButtonItem115";
            // 
            // chartsRibbonPageGroup1
            // 
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem4);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem5);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem6);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem7);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem8);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem9);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem10);
            this.chartsRibbonPageGroup1.Name = "chartsRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem4
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem4.CommandName = "InsertChartColumnCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem4.DropDownControl = this.commandBarGalleryDropDown54;
            this.spreadsheetCommandBarButtonGalleryDropDownItem4.Id = 164;
            this.spreadsheetCommandBarButtonGalleryDropDownItem4.Name = "spreadsheetCommandBarButtonGalleryDropDownItem4";
            // 
            // commandBarGalleryDropDown54
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown54.Gallery.ColumnCount = 4;
            spreadsheetCommandGalleryItemGroup10.CommandName = "InsertChartColumn2DCommandGroup";
            spreadsheetCommandGalleryItem68.CommandName = "InsertChartColumnClustered2D";
            spreadsheetCommandGalleryItem69.CommandName = "InsertChartColumnStacked2D";
            spreadsheetCommandGalleryItem70.CommandName = "InsertChartColumnPercentStacked2D";
            spreadsheetCommandGalleryItemGroup10.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem68,
            spreadsheetCommandGalleryItem69,
            spreadsheetCommandGalleryItem70});
            spreadsheetCommandGalleryItemGroup11.CommandName = "InsertChartColumn3DCommandGroup";
            spreadsheetCommandGalleryItem71.CommandName = "InsertChartColumnClustered3D";
            spreadsheetCommandGalleryItem72.CommandName = "InsertChartColumnStacked3D";
            spreadsheetCommandGalleryItem73.CommandName = "InsertChartColumnPercentStacked3D";
            spreadsheetCommandGalleryItem74.CommandName = "InsertChartColumn3D";
            spreadsheetCommandGalleryItemGroup11.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem71,
            spreadsheetCommandGalleryItem72,
            spreadsheetCommandGalleryItem73,
            spreadsheetCommandGalleryItem74});
            spreadsheetCommandGalleryItemGroup12.CommandName = "InsertChartCylinderCommandGroup";
            spreadsheetCommandGalleryItem75.CommandName = "InsertChartCylinderClustered";
            spreadsheetCommandGalleryItem76.CommandName = "InsertChartCylinderStacked";
            spreadsheetCommandGalleryItem77.CommandName = "InsertChartCylinderPercentStacked";
            spreadsheetCommandGalleryItem78.CommandName = "InsertChartCylinder";
            spreadsheetCommandGalleryItemGroup12.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem75,
            spreadsheetCommandGalleryItem76,
            spreadsheetCommandGalleryItem77,
            spreadsheetCommandGalleryItem78});
            spreadsheetCommandGalleryItemGroup13.CommandName = "InsertChartConeCommandGroup";
            spreadsheetCommandGalleryItem79.CommandName = "InsertChartConeClustered";
            spreadsheetCommandGalleryItem80.CommandName = "InsertChartConeStacked";
            spreadsheetCommandGalleryItem81.CommandName = "InsertChartConePercentStacked";
            spreadsheetCommandGalleryItem82.CommandName = "InsertChartCone";
            spreadsheetCommandGalleryItemGroup13.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem79,
            spreadsheetCommandGalleryItem80,
            spreadsheetCommandGalleryItem81,
            spreadsheetCommandGalleryItem82});
            spreadsheetCommandGalleryItemGroup14.CommandName = "InsertChartPyramidCommandGroup";
            spreadsheetCommandGalleryItem83.CommandName = "InsertChartPyramidClustered";
            spreadsheetCommandGalleryItem84.CommandName = "InsertChartPyramidStacked";
            spreadsheetCommandGalleryItem85.CommandName = "InsertChartPyramidPercentStacked";
            spreadsheetCommandGalleryItem86.CommandName = "InsertChartPyramid";
            spreadsheetCommandGalleryItemGroup14.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem83,
            spreadsheetCommandGalleryItem84,
            spreadsheetCommandGalleryItem85,
            spreadsheetCommandGalleryItem86});
            this.commandBarGalleryDropDown54.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup10,
            spreadsheetCommandGalleryItemGroup11,
            spreadsheetCommandGalleryItemGroup12,
            spreadsheetCommandGalleryItemGroup13,
            spreadsheetCommandGalleryItemGroup14});
            this.commandBarGalleryDropDown54.Gallery.RowCount = 5;
            this.commandBarGalleryDropDown54.Name = "commandBarGalleryDropDown54";
            this.commandBarGalleryDropDown54.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem5
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem5.CommandName = "InsertChartLineCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem5.DropDownControl = this.commandBarGalleryDropDown55;
            this.spreadsheetCommandBarButtonGalleryDropDownItem5.Id = 165;
            this.spreadsheetCommandBarButtonGalleryDropDownItem5.Name = "spreadsheetCommandBarButtonGalleryDropDownItem5";
            // 
            // commandBarGalleryDropDown55
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown55.Gallery.ColumnCount = 3;
            spreadsheetCommandGalleryItemGroup15.CommandName = "InsertChartLine2DCommandGroup";
            spreadsheetCommandGalleryItem87.CommandName = "InsertChartLine";
            spreadsheetCommandGalleryItem88.CommandName = "InsertChartStackedLine";
            spreadsheetCommandGalleryItem89.CommandName = "InsertChartPercentStackedLine";
            spreadsheetCommandGalleryItem90.CommandName = "InsertChartLineWithMarkers";
            spreadsheetCommandGalleryItem91.CommandName = "InsertChartStackedLineWithMarkers";
            spreadsheetCommandGalleryItem92.CommandName = "InsertChartPercentStackedLineWithMarkers";
            spreadsheetCommandGalleryItemGroup15.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem87,
            spreadsheetCommandGalleryItem88,
            spreadsheetCommandGalleryItem89,
            spreadsheetCommandGalleryItem90,
            spreadsheetCommandGalleryItem91,
            spreadsheetCommandGalleryItem92});
            spreadsheetCommandGalleryItemGroup16.CommandName = "InsertChartLine3DCommandGroup";
            spreadsheetCommandGalleryItem93.CommandName = "InsertChartLine3D";
            spreadsheetCommandGalleryItemGroup16.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem93});
            this.commandBarGalleryDropDown55.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup15,
            spreadsheetCommandGalleryItemGroup16});
            this.commandBarGalleryDropDown55.Name = "commandBarGalleryDropDown55";
            this.commandBarGalleryDropDown55.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem6
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem6.CommandName = "InsertChartPieCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem6.DropDownControl = this.commandBarGalleryDropDown56;
            this.spreadsheetCommandBarButtonGalleryDropDownItem6.Id = 166;
            this.spreadsheetCommandBarButtonGalleryDropDownItem6.Name = "spreadsheetCommandBarButtonGalleryDropDownItem6";
            // 
            // commandBarGalleryDropDown56
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown56.Gallery.ColumnCount = 2;
            spreadsheetCommandGalleryItemGroup17.CommandName = "InsertChartPie2DCommandGroup";
            spreadsheetCommandGalleryItem94.CommandName = "InsertChartPie2D";
            spreadsheetCommandGalleryItem95.CommandName = "InsertChartPieExploded2D";
            spreadsheetCommandGalleryItemGroup17.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem94,
            spreadsheetCommandGalleryItem95});
            spreadsheetCommandGalleryItemGroup18.CommandName = "InsertChartPie3DCommandGroup";
            spreadsheetCommandGalleryItem96.CommandName = "InsertChartPie3D";
            spreadsheetCommandGalleryItem97.CommandName = "InsertChartPieExploded3D";
            spreadsheetCommandGalleryItemGroup18.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem96,
            spreadsheetCommandGalleryItem97});
            spreadsheetCommandGalleryItemGroup19.CommandName = "InsertChartDoughnut2DCommandGroup";
            spreadsheetCommandGalleryItem98.CommandName = "InsertChartDoughnut2D";
            spreadsheetCommandGalleryItem99.CommandName = "InsertChartDoughnutExploded2D";
            spreadsheetCommandGalleryItemGroup19.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem98,
            spreadsheetCommandGalleryItem99});
            this.commandBarGalleryDropDown56.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup17,
            spreadsheetCommandGalleryItemGroup18,
            spreadsheetCommandGalleryItemGroup19});
            this.commandBarGalleryDropDown56.Name = "commandBarGalleryDropDown56";
            this.commandBarGalleryDropDown56.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem7
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem7.CommandName = "InsertChartBarCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem7.DropDownControl = this.commandBarGalleryDropDown57;
            this.spreadsheetCommandBarButtonGalleryDropDownItem7.Id = 167;
            this.spreadsheetCommandBarButtonGalleryDropDownItem7.Name = "spreadsheetCommandBarButtonGalleryDropDownItem7";
            // 
            // commandBarGalleryDropDown57
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown57.Gallery.ColumnCount = 3;
            spreadsheetCommandGalleryItemGroup20.CommandName = "InsertChartBar2DCommandGroup";
            spreadsheetCommandGalleryItem100.CommandName = "InsertChartBarClustered2D";
            spreadsheetCommandGalleryItem101.CommandName = "InsertChartBarStacked2D";
            spreadsheetCommandGalleryItem102.CommandName = "InsertChartBarPercentStacked2D";
            spreadsheetCommandGalleryItemGroup20.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem100,
            spreadsheetCommandGalleryItem101,
            spreadsheetCommandGalleryItem102});
            spreadsheetCommandGalleryItemGroup21.CommandName = "InsertChartBar3DCommandGroup";
            spreadsheetCommandGalleryItem103.CommandName = "InsertChartBarClustered3D";
            spreadsheetCommandGalleryItem104.CommandName = "InsertChartBarStacked3D";
            spreadsheetCommandGalleryItem105.CommandName = "InsertChartBarPercentStacked3D";
            spreadsheetCommandGalleryItemGroup21.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem103,
            spreadsheetCommandGalleryItem104,
            spreadsheetCommandGalleryItem105});
            spreadsheetCommandGalleryItemGroup22.CommandName = "InsertChartHorizontalCylinderCommandGroup";
            spreadsheetCommandGalleryItem106.CommandName = "InsertChartHorizontalCylinderClustered";
            spreadsheetCommandGalleryItem107.CommandName = "InsertChartHorizontalCylinderStacked";
            spreadsheetCommandGalleryItem108.CommandName = "InsertChartHorizontalCylinderPercentStacked";
            spreadsheetCommandGalleryItemGroup22.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem106,
            spreadsheetCommandGalleryItem107,
            spreadsheetCommandGalleryItem108});
            spreadsheetCommandGalleryItemGroup23.CommandName = "InsertChartHorizontalConeCommandGroup";
            spreadsheetCommandGalleryItem109.CommandName = "InsertChartHorizontalConeClustered";
            spreadsheetCommandGalleryItem110.CommandName = "InsertChartHorizontalConeStacked";
            spreadsheetCommandGalleryItem111.CommandName = "InsertChartHorizontalConePercentStacked";
            spreadsheetCommandGalleryItemGroup23.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem109,
            spreadsheetCommandGalleryItem110,
            spreadsheetCommandGalleryItem111});
            spreadsheetCommandGalleryItemGroup24.CommandName = "InsertChartHorizontalPyramidCommandGroup";
            spreadsheetCommandGalleryItem112.CommandName = "InsertChartHorizontalPyramidClustered";
            spreadsheetCommandGalleryItem113.CommandName = "InsertChartHorizontalPyramidStacked";
            spreadsheetCommandGalleryItem114.CommandName = "InsertChartHorizontalPyramidPercentStacked";
            spreadsheetCommandGalleryItemGroup24.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem112,
            spreadsheetCommandGalleryItem113,
            spreadsheetCommandGalleryItem114});
            this.commandBarGalleryDropDown57.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup20,
            spreadsheetCommandGalleryItemGroup21,
            spreadsheetCommandGalleryItemGroup22,
            spreadsheetCommandGalleryItemGroup23,
            spreadsheetCommandGalleryItemGroup24});
            this.commandBarGalleryDropDown57.Gallery.RowCount = 5;
            this.commandBarGalleryDropDown57.Name = "commandBarGalleryDropDown57";
            this.commandBarGalleryDropDown57.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem8
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem8.CommandName = "InsertChartAreaCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem8.DropDownControl = this.commandBarGalleryDropDown58;
            this.spreadsheetCommandBarButtonGalleryDropDownItem8.Id = 168;
            this.spreadsheetCommandBarButtonGalleryDropDownItem8.Name = "spreadsheetCommandBarButtonGalleryDropDownItem8";
            // 
            // commandBarGalleryDropDown58
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown58.Gallery.ColumnCount = 3;
            spreadsheetCommandGalleryItemGroup25.CommandName = "InsertChartArea2DCommandGroup";
            spreadsheetCommandGalleryItem115.CommandName = "InsertChartArea";
            spreadsheetCommandGalleryItem116.CommandName = "InsertChartStackedArea";
            spreadsheetCommandGalleryItem117.CommandName = "InsertChartPercentStackedArea";
            spreadsheetCommandGalleryItemGroup25.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem115,
            spreadsheetCommandGalleryItem116,
            spreadsheetCommandGalleryItem117});
            spreadsheetCommandGalleryItemGroup26.CommandName = "InsertChartArea3DCommandGroup";
            spreadsheetCommandGalleryItem118.CommandName = "InsertChartArea3D";
            spreadsheetCommandGalleryItem119.CommandName = "InsertChartStackedArea3D";
            spreadsheetCommandGalleryItem120.CommandName = "InsertChartPercentStackedArea3D";
            spreadsheetCommandGalleryItemGroup26.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem118,
            spreadsheetCommandGalleryItem119,
            spreadsheetCommandGalleryItem120});
            this.commandBarGalleryDropDown58.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup25,
            spreadsheetCommandGalleryItemGroup26});
            this.commandBarGalleryDropDown58.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown58.Name = "commandBarGalleryDropDown58";
            this.commandBarGalleryDropDown58.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem9
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem9.CommandName = "InsertChartScatterCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem9.DropDownControl = this.commandBarGalleryDropDown59;
            this.spreadsheetCommandBarButtonGalleryDropDownItem9.Id = 169;
            this.spreadsheetCommandBarButtonGalleryDropDownItem9.Name = "spreadsheetCommandBarButtonGalleryDropDownItem9";
            // 
            // commandBarGalleryDropDown59
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown59.Gallery.ColumnCount = 2;
            spreadsheetCommandGalleryItemGroup27.CommandName = "InsertChartScatterCommandGroup";
            spreadsheetCommandGalleryItem121.CommandName = "InsertChartScatterMarkers";
            spreadsheetCommandGalleryItem122.CommandName = "InsertChartScatterSmoothLinesAndMarkers";
            spreadsheetCommandGalleryItem123.CommandName = "InsertChartScatterSmoothLines";
            spreadsheetCommandGalleryItem124.CommandName = "InsertChartScatterLinesAndMarkers";
            spreadsheetCommandGalleryItem125.CommandName = "InsertChartScatterLines";
            spreadsheetCommandGalleryItemGroup27.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem121,
            spreadsheetCommandGalleryItem122,
            spreadsheetCommandGalleryItem123,
            spreadsheetCommandGalleryItem124,
            spreadsheetCommandGalleryItem125});
            spreadsheetCommandGalleryItemGroup28.CommandName = "InsertChartBubbleCommandGroup";
            spreadsheetCommandGalleryItem126.CommandName = "InsertChartBubble";
            spreadsheetCommandGalleryItem127.CommandName = "InsertChartBubble3D";
            spreadsheetCommandGalleryItemGroup28.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem126,
            spreadsheetCommandGalleryItem127});
            this.commandBarGalleryDropDown59.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup27,
            spreadsheetCommandGalleryItemGroup28});
            this.commandBarGalleryDropDown59.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown59.Name = "commandBarGalleryDropDown59";
            this.commandBarGalleryDropDown59.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem10
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem10.CommandName = "InsertChartOtherCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem10.DropDownControl = this.commandBarGalleryDropDown60;
            this.spreadsheetCommandBarButtonGalleryDropDownItem10.Id = 170;
            this.spreadsheetCommandBarButtonGalleryDropDownItem10.Name = "spreadsheetCommandBarButtonGalleryDropDownItem10";
            // 
            // commandBarGalleryDropDown60
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown60.Gallery.ColumnCount = 4;
            spreadsheetCommandGalleryItemGroup29.CommandName = "InsertChartStockCommandGroup";
            spreadsheetCommandGalleryItem128.CommandName = "InsertChartStockHighLowClose";
            spreadsheetCommandGalleryItem129.CommandName = "InsertChartStockOpenHighLowClose";
            spreadsheetCommandGalleryItem130.CommandName = "InsertChartStockVolumeHighLowClose";
            spreadsheetCommandGalleryItem131.CommandName = "InsertChartStockVolumeOpenHighLowClose";
            spreadsheetCommandGalleryItemGroup29.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem128,
            spreadsheetCommandGalleryItem129,
            spreadsheetCommandGalleryItem130,
            spreadsheetCommandGalleryItem131});
            spreadsheetCommandGalleryItemGroup30.CommandName = "InsertChartRadarCommandGroup";
            spreadsheetCommandGalleryItem132.CommandName = "InsertChartRadar";
            spreadsheetCommandGalleryItem133.CommandName = "InsertChartRadarWithMarkers";
            spreadsheetCommandGalleryItem134.CommandName = "InsertChartRadarFilled";
            spreadsheetCommandGalleryItemGroup30.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem132,
            spreadsheetCommandGalleryItem133,
            spreadsheetCommandGalleryItem134});
            this.commandBarGalleryDropDown60.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup29,
            spreadsheetCommandGalleryItemGroup30});
            this.commandBarGalleryDropDown60.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown60.Name = "commandBarGalleryDropDown60";
            this.commandBarGalleryDropDown60.Ribbon = this.ribbonControl1;
            // 
            // linksRibbonPageGroup1
            // 
            this.linksRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem116);
            this.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonItem116
            // 
            this.spreadsheetCommandBarButtonItem116.CommandName = "InsertHyperlink";
            this.spreadsheetCommandBarButtonItem116.Id = 171;
            this.spreadsheetCommandBarButtonItem116.Name = "spreadsheetCommandBarButtonItem116";
            // 
            // symbolsRibbonPageGroup1
            // 
            this.symbolsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem117);
            this.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonItem117
            // 
            this.spreadsheetCommandBarButtonItem117.CommandName = "InsertSymbol";
            this.spreadsheetCommandBarButtonItem117.Id = 172;
            this.spreadsheetCommandBarButtonItem117.Name = "spreadsheetCommandBarButtonItem117";
            // 
            // pageSetupRibbonPageGroup1
            // 
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem17);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem18);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.pageSetupPaperKindItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem19);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem127);
            this.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1";
            // 
            // pageLayoutRibbonPage1
            // 
            this.pageLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageSetupRibbonPageGroup1,
            this.pageSetupShowRibbonPageGroup1,
            this.pageSetupPrintRibbonPageGroup1,
            this.arrangeRibbonPageGroup1});
            this.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1";
            // 
            // spreadsheetCommandBarSubItem17
            // 
            this.spreadsheetCommandBarSubItem17.CommandName = "PageSetupMarginsCommandGroup";
            this.spreadsheetCommandBarSubItem17.Id = 173;
            this.spreadsheetCommandBarSubItem17.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem15),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem16),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem17),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem118)});
            this.spreadsheetCommandBarSubItem17.Name = "spreadsheetCommandBarSubItem17";
            // 
            // spreadsheetCommandBarCheckItem15
            // 
            this.spreadsheetCommandBarCheckItem15.CaptionDependOnUnits = true;
            this.spreadsheetCommandBarCheckItem15.CommandName = "PageSetupMarginsNormal";
            this.spreadsheetCommandBarCheckItem15.Id = 174;
            this.spreadsheetCommandBarCheckItem15.Name = "spreadsheetCommandBarCheckItem15";
            // 
            // spreadsheetCommandBarCheckItem16
            // 
            this.spreadsheetCommandBarCheckItem16.CaptionDependOnUnits = true;
            this.spreadsheetCommandBarCheckItem16.CommandName = "PageSetupMarginsWide";
            this.spreadsheetCommandBarCheckItem16.Id = 175;
            this.spreadsheetCommandBarCheckItem16.Name = "spreadsheetCommandBarCheckItem16";
            // 
            // spreadsheetCommandBarCheckItem17
            // 
            this.spreadsheetCommandBarCheckItem17.CaptionDependOnUnits = true;
            this.spreadsheetCommandBarCheckItem17.CommandName = "PageSetupMarginsNarrow";
            this.spreadsheetCommandBarCheckItem17.Id = 176;
            this.spreadsheetCommandBarCheckItem17.Name = "spreadsheetCommandBarCheckItem17";
            // 
            // spreadsheetCommandBarButtonItem118
            // 
            this.spreadsheetCommandBarButtonItem118.CommandName = "PageSetupCustomMargins";
            this.spreadsheetCommandBarButtonItem118.Id = 177;
            this.spreadsheetCommandBarButtonItem118.Name = "spreadsheetCommandBarButtonItem118";
            // 
            // spreadsheetCommandBarSubItem18
            // 
            this.spreadsheetCommandBarSubItem18.CommandName = "PageSetupOrientationCommandGroup";
            this.spreadsheetCommandBarSubItem18.Id = 178;
            this.spreadsheetCommandBarSubItem18.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem18),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem19)});
            this.spreadsheetCommandBarSubItem18.Name = "spreadsheetCommandBarSubItem18";
            // 
            // spreadsheetCommandBarCheckItem18
            // 
            this.spreadsheetCommandBarCheckItem18.CommandName = "PageSetupOrientationPortrait";
            this.spreadsheetCommandBarCheckItem18.Id = 179;
            this.spreadsheetCommandBarCheckItem18.Name = "spreadsheetCommandBarCheckItem18";
            // 
            // spreadsheetCommandBarCheckItem19
            // 
            this.spreadsheetCommandBarCheckItem19.CommandName = "PageSetupOrientationLandscape";
            this.spreadsheetCommandBarCheckItem19.Id = 180;
            this.spreadsheetCommandBarCheckItem19.Name = "spreadsheetCommandBarCheckItem19";
            // 
            // pageSetupPaperKindItem1
            // 
            this.pageSetupPaperKindItem1.Id = 181;
            this.pageSetupPaperKindItem1.Name = "pageSetupPaperKindItem1";
            // 
            // spreadsheetCommandBarSubItem19
            // 
            this.spreadsheetCommandBarSubItem19.CommandName = "PageSetupPrintAreaCommandGroup";
            this.spreadsheetCommandBarSubItem19.Id = 182;
            this.spreadsheetCommandBarSubItem19.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem124),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem125),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem126)});
            this.spreadsheetCommandBarSubItem19.Name = "spreadsheetCommandBarSubItem19";
            // 
            // spreadsheetCommandBarButtonItem124
            // 
            this.spreadsheetCommandBarButtonItem124.CommandName = "PageSetupSetPrintArea";
            this.spreadsheetCommandBarButtonItem124.Id = 183;
            this.spreadsheetCommandBarButtonItem124.Name = "spreadsheetCommandBarButtonItem124";
            // 
            // spreadsheetCommandBarButtonItem125
            // 
            this.spreadsheetCommandBarButtonItem125.CommandName = "PageSetupClearPrintArea";
            this.spreadsheetCommandBarButtonItem125.Id = 184;
            this.spreadsheetCommandBarButtonItem125.Name = "spreadsheetCommandBarButtonItem125";
            // 
            // spreadsheetCommandBarButtonItem126
            // 
            this.spreadsheetCommandBarButtonItem126.CommandName = "PageSetupAddPrintArea";
            this.spreadsheetCommandBarButtonItem126.Id = 185;
            this.spreadsheetCommandBarButtonItem126.Name = "spreadsheetCommandBarButtonItem126";
            // 
            // spreadsheetCommandBarButtonItem127
            // 
            this.spreadsheetCommandBarButtonItem127.CommandName = "PageSetupPrintTitles";
            this.spreadsheetCommandBarButtonItem127.Id = 186;
            this.spreadsheetCommandBarButtonItem127.Name = "spreadsheetCommandBarButtonItem127";
            // 
            // pageSetupShowRibbonPageGroup1
            // 
            this.pageSetupShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem20);
            this.pageSetupShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem21);
            this.pageSetupShowRibbonPageGroup1.Name = "pageSetupShowRibbonPageGroup1";
            // 
            // spreadsheetCommandBarCheckItem20
            // 
            this.spreadsheetCommandBarCheckItem20.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem20.CommandName = "ViewShowGridlines";
            this.spreadsheetCommandBarCheckItem20.Id = 187;
            this.spreadsheetCommandBarCheckItem20.Name = "spreadsheetCommandBarCheckItem20";
            // 
            // spreadsheetCommandBarCheckItem21
            // 
            this.spreadsheetCommandBarCheckItem21.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem21.CommandName = "ViewShowHeadings";
            this.spreadsheetCommandBarCheckItem21.Id = 188;
            this.spreadsheetCommandBarCheckItem21.Name = "spreadsheetCommandBarCheckItem21";
            // 
            // pageSetupPrintRibbonPageGroup1
            // 
            this.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem22);
            this.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem23);
            this.pageSetupPrintRibbonPageGroup1.Name = "pageSetupPrintRibbonPageGroup1";
            // 
            // spreadsheetCommandBarCheckItem22
            // 
            this.spreadsheetCommandBarCheckItem22.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem22.CommandName = "PageSetupPrintGridlines";
            this.spreadsheetCommandBarCheckItem22.Id = 189;
            this.spreadsheetCommandBarCheckItem22.Name = "spreadsheetCommandBarCheckItem22";
            // 
            // spreadsheetCommandBarCheckItem23
            // 
            this.spreadsheetCommandBarCheckItem23.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem23.CommandName = "PageSetupPrintHeadings";
            this.spreadsheetCommandBarCheckItem23.Id = 190;
            this.spreadsheetCommandBarCheckItem23.Name = "spreadsheetCommandBarCheckItem23";
            // 
            // arrangeRibbonPageGroup1
            // 
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
            this.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1";
            // 
            // spreadsheetCommandBarSubItem20
            // 
            this.spreadsheetCommandBarSubItem20.CommandName = "ArrangeBringForwardCommandGroup";
            this.spreadsheetCommandBarSubItem20.Id = 191;
            this.spreadsheetCommandBarSubItem20.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem128),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem129)});
            this.spreadsheetCommandBarSubItem20.Name = "spreadsheetCommandBarSubItem20";
            // 
            // spreadsheetCommandBarButtonItem128
            // 
            this.spreadsheetCommandBarButtonItem128.CommandName = "ArrangeBringForward";
            this.spreadsheetCommandBarButtonItem128.Id = 192;
            this.spreadsheetCommandBarButtonItem128.Name = "spreadsheetCommandBarButtonItem128";
            // 
            // spreadsheetCommandBarButtonItem129
            // 
            this.spreadsheetCommandBarButtonItem129.CommandName = "ArrangeBringToFront";
            this.spreadsheetCommandBarButtonItem129.Id = 193;
            this.spreadsheetCommandBarButtonItem129.Name = "spreadsheetCommandBarButtonItem129";
            // 
            // spreadsheetCommandBarSubItem21
            // 
            this.spreadsheetCommandBarSubItem21.CommandName = "ArrangeSendBackwardCommandGroup";
            this.spreadsheetCommandBarSubItem21.Id = 194;
            this.spreadsheetCommandBarSubItem21.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem130),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem131)});
            this.spreadsheetCommandBarSubItem21.Name = "spreadsheetCommandBarSubItem21";
            // 
            // spreadsheetCommandBarButtonItem130
            // 
            this.spreadsheetCommandBarButtonItem130.CommandName = "ArrangeSendBackward";
            this.spreadsheetCommandBarButtonItem130.Id = 195;
            this.spreadsheetCommandBarButtonItem130.Name = "spreadsheetCommandBarButtonItem130";
            // 
            // spreadsheetCommandBarButtonItem131
            // 
            this.spreadsheetCommandBarButtonItem131.CommandName = "ArrangeSendToBack";
            this.spreadsheetCommandBarButtonItem131.Id = 196;
            this.spreadsheetCommandBarButtonItem131.Name = "spreadsheetCommandBarButtonItem131";
            // 
            // functionLibraryRibbonPageGroup1
            // 
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem22);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsFinancialItem1);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsLogicalItem1);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsTextItem1);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsDateAndTimeItem1);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsLookupAndReferenceItem1);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsMathAndTrigonometryItem1);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem23);
            this.functionLibraryRibbonPageGroup1.Name = "functionLibraryRibbonPageGroup1";
            // 
            // formulasRibbonPage1
            // 
            this.formulasRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.functionLibraryRibbonPageGroup1,
            this.formulaDefinedNamesRibbonPageGroup1,
            this.formulaAuditingRibbonPageGroup1,
            this.formulaCalculationRibbonPageGroup1});
            this.formulasRibbonPage1.Name = "formulasRibbonPage1";
            // 
            // spreadsheetCommandBarSubItem22
            // 
            this.spreadsheetCommandBarSubItem22.CommandName = "FunctionsAutoSumCommandGroup";
            this.spreadsheetCommandBarSubItem22.Id = 197;
            this.spreadsheetCommandBarSubItem22.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem82),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem83),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem84),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem85),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem86)});
            this.spreadsheetCommandBarSubItem22.Name = "spreadsheetCommandBarSubItem22";
            // 
            // spreadsheetCommandBarButtonItem132
            // 
            this.spreadsheetCommandBarButtonItem132.CommandName = "FunctionsInsertSum";
            this.spreadsheetCommandBarButtonItem132.Id = -1;
            this.spreadsheetCommandBarButtonItem132.Name = "spreadsheetCommandBarButtonItem132";
            // 
            // spreadsheetCommandBarButtonItem133
            // 
            this.spreadsheetCommandBarButtonItem133.CommandName = "FunctionsInsertAverage";
            this.spreadsheetCommandBarButtonItem133.Id = -1;
            this.spreadsheetCommandBarButtonItem133.Name = "spreadsheetCommandBarButtonItem133";
            // 
            // spreadsheetCommandBarButtonItem134
            // 
            this.spreadsheetCommandBarButtonItem134.CommandName = "FunctionsInsertCountNumbers";
            this.spreadsheetCommandBarButtonItem134.Id = -1;
            this.spreadsheetCommandBarButtonItem134.Name = "spreadsheetCommandBarButtonItem134";
            // 
            // spreadsheetCommandBarButtonItem135
            // 
            this.spreadsheetCommandBarButtonItem135.CommandName = "FunctionsInsertMax";
            this.spreadsheetCommandBarButtonItem135.Id = -1;
            this.spreadsheetCommandBarButtonItem135.Name = "spreadsheetCommandBarButtonItem135";
            // 
            // spreadsheetCommandBarButtonItem136
            // 
            this.spreadsheetCommandBarButtonItem136.CommandName = "FunctionsInsertMin";
            this.spreadsheetCommandBarButtonItem136.Id = -1;
            this.spreadsheetCommandBarButtonItem136.Name = "spreadsheetCommandBarButtonItem136";
            // 
            // functionsFinancialItem1
            // 
            this.functionsFinancialItem1.Id = 198;
            this.functionsFinancialItem1.Name = "functionsFinancialItem1";
            // 
            // functionsLogicalItem1
            // 
            this.functionsLogicalItem1.Id = 199;
            this.functionsLogicalItem1.Name = "functionsLogicalItem1";
            // 
            // functionsTextItem1
            // 
            this.functionsTextItem1.Id = 200;
            this.functionsTextItem1.Name = "functionsTextItem1";
            // 
            // functionsDateAndTimeItem1
            // 
            this.functionsDateAndTimeItem1.Id = 201;
            this.functionsDateAndTimeItem1.Name = "functionsDateAndTimeItem1";
            // 
            // functionsLookupAndReferenceItem1
            // 
            this.functionsLookupAndReferenceItem1.Id = 202;
            this.functionsLookupAndReferenceItem1.Name = "functionsLookupAndReferenceItem1";
            // 
            // functionsMathAndTrigonometryItem1
            // 
            this.functionsMathAndTrigonometryItem1.Id = 203;
            this.functionsMathAndTrigonometryItem1.Name = "functionsMathAndTrigonometryItem1";
            // 
            // spreadsheetCommandBarSubItem23
            // 
            this.spreadsheetCommandBarSubItem23.CommandName = "FunctionsMoreCommandGroup";
            this.spreadsheetCommandBarSubItem23.Id = 204;
            this.spreadsheetCommandBarSubItem23.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.functionsStatisticalItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.functionsEngineeringItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.functionsInformationItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.functionsCompatibilityItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.functionsWebItem1)});
            this.spreadsheetCommandBarSubItem23.Name = "spreadsheetCommandBarSubItem23";
            // 
            // functionsStatisticalItem1
            // 
            this.functionsStatisticalItem1.Id = 205;
            this.functionsStatisticalItem1.Name = "functionsStatisticalItem1";
            // 
            // functionsEngineeringItem1
            // 
            this.functionsEngineeringItem1.Id = 206;
            this.functionsEngineeringItem1.Name = "functionsEngineeringItem1";
            // 
            // functionsInformationItem1
            // 
            this.functionsInformationItem1.Id = 207;
            this.functionsInformationItem1.Name = "functionsInformationItem1";
            // 
            // functionsCompatibilityItem1
            // 
            this.functionsCompatibilityItem1.Id = 208;
            this.functionsCompatibilityItem1.Name = "functionsCompatibilityItem1";
            // 
            // functionsWebItem1
            // 
            this.functionsWebItem1.Id = 209;
            this.functionsWebItem1.Name = "functionsWebItem1";
            // 
            // formulaDefinedNamesRibbonPageGroup1
            // 
            this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem137);
            this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem138);
            this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.definedNameListItem1);
            this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem139);
            this.formulaDefinedNamesRibbonPageGroup1.Name = "formulaDefinedNamesRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonItem137
            // 
            this.spreadsheetCommandBarButtonItem137.CommandName = "FormulasShowNameManager";
            this.spreadsheetCommandBarButtonItem137.Id = 210;
            this.spreadsheetCommandBarButtonItem137.Name = "spreadsheetCommandBarButtonItem137";
            // 
            // spreadsheetCommandBarButtonItem138
            // 
            this.spreadsheetCommandBarButtonItem138.CommandName = "FormulasDefineNameCommand";
            this.spreadsheetCommandBarButtonItem138.Id = 211;
            this.spreadsheetCommandBarButtonItem138.Name = "spreadsheetCommandBarButtonItem138";
            this.spreadsheetCommandBarButtonItem138.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // definedNameListItem1
            // 
            this.definedNameListItem1.Id = 212;
            this.definedNameListItem1.Name = "definedNameListItem1";
            this.definedNameListItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem139
            // 
            this.spreadsheetCommandBarButtonItem139.CommandName = "FormulasCreateDefinedNamesFromSelection";
            this.spreadsheetCommandBarButtonItem139.Id = 213;
            this.spreadsheetCommandBarButtonItem139.Name = "spreadsheetCommandBarButtonItem139";
            this.spreadsheetCommandBarButtonItem139.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // formulaAuditingRibbonPageGroup1
            // 
            this.formulaAuditingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem24);
            this.formulaAuditingRibbonPageGroup1.Name = "formulaAuditingRibbonPageGroup1";
            // 
            // spreadsheetCommandBarCheckItem24
            // 
            this.spreadsheetCommandBarCheckItem24.CommandName = "ViewShowFormulas";
            this.spreadsheetCommandBarCheckItem24.Id = 214;
            this.spreadsheetCommandBarCheckItem24.Name = "spreadsheetCommandBarCheckItem24";
            // 
            // formulaCalculationRibbonPageGroup1
            // 
            this.formulaCalculationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem24);
            this.formulaCalculationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem140);
            this.formulaCalculationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem141);
            this.formulaCalculationRibbonPageGroup1.Name = "formulaCalculationRibbonPageGroup1";
            // 
            // spreadsheetCommandBarSubItem24
            // 
            this.spreadsheetCommandBarSubItem24.CommandName = "FormulasCalculationOptionsCommandGroup";
            this.spreadsheetCommandBarSubItem24.Id = 215;
            this.spreadsheetCommandBarSubItem24.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem25),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem26)});
            this.spreadsheetCommandBarSubItem24.Name = "spreadsheetCommandBarSubItem24";
            // 
            // spreadsheetCommandBarCheckItem25
            // 
            this.spreadsheetCommandBarCheckItem25.CommandName = "FormulasCalculationModeAutomatic";
            this.spreadsheetCommandBarCheckItem25.Id = 216;
            this.spreadsheetCommandBarCheckItem25.Name = "spreadsheetCommandBarCheckItem25";
            // 
            // spreadsheetCommandBarCheckItem26
            // 
            this.spreadsheetCommandBarCheckItem26.CommandName = "FormulasCalculationModeManual";
            this.spreadsheetCommandBarCheckItem26.Id = 217;
            this.spreadsheetCommandBarCheckItem26.Name = "spreadsheetCommandBarCheckItem26";
            // 
            // spreadsheetCommandBarButtonItem140
            // 
            this.spreadsheetCommandBarButtonItem140.CommandName = "FormulasCalculateNow";
            this.spreadsheetCommandBarButtonItem140.Id = 218;
            this.spreadsheetCommandBarButtonItem140.Name = "spreadsheetCommandBarButtonItem140";
            this.spreadsheetCommandBarButtonItem140.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem141
            // 
            this.spreadsheetCommandBarButtonItem141.CommandName = "FormulasCalculateSheet";
            this.spreadsheetCommandBarButtonItem141.Id = 219;
            this.spreadsheetCommandBarButtonItem141.Name = "spreadsheetCommandBarButtonItem141";
            this.spreadsheetCommandBarButtonItem141.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // sortAndFilterRibbonPageGroup1
            // 
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem97);
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem98);
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem14);
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem99);
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem100);
            this.sortAndFilterRibbonPageGroup1.Name = "sortAndFilterRibbonPageGroup1";
            // 
            // dataRibbonPage1
            // 
            this.dataRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.sortAndFilterRibbonPageGroup1,
            this.dataToolsRibbonPageGroup1,
            this.outlineRibbonPageGroup1});
            this.dataRibbonPage1.Name = "dataRibbonPage1";
            // 
            // dataToolsRibbonPageGroup1
            // 
            this.dataToolsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem25);
            this.dataToolsRibbonPageGroup1.Name = "dataToolsRibbonPageGroup1";
            // 
            // spreadsheetCommandBarSubItem25
            // 
            this.spreadsheetCommandBarSubItem25.CommandName = "DataToolsDataValidationCommandGroup";
            this.spreadsheetCommandBarSubItem25.Id = 220;
            this.spreadsheetCommandBarSubItem25.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem142),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem143),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem144)});
            this.spreadsheetCommandBarSubItem25.Name = "spreadsheetCommandBarSubItem25";
            // 
            // spreadsheetCommandBarButtonItem142
            // 
            this.spreadsheetCommandBarButtonItem142.CommandName = "DataToolsDataValidation";
            this.spreadsheetCommandBarButtonItem142.Id = 221;
            this.spreadsheetCommandBarButtonItem142.Name = "spreadsheetCommandBarButtonItem142";
            // 
            // spreadsheetCommandBarButtonItem143
            // 
            this.spreadsheetCommandBarButtonItem143.CommandName = "DataToolsCircleInvalidData";
            this.spreadsheetCommandBarButtonItem143.Id = 222;
            this.spreadsheetCommandBarButtonItem143.Name = "spreadsheetCommandBarButtonItem143";
            // 
            // spreadsheetCommandBarButtonItem144
            // 
            this.spreadsheetCommandBarButtonItem144.CommandName = "DataToolsClearValidationCircles";
            this.spreadsheetCommandBarButtonItem144.Id = 223;
            this.spreadsheetCommandBarButtonItem144.Name = "spreadsheetCommandBarButtonItem144";
            // 
            // outlineRibbonPageGroup1
            // 
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem26);
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem27);
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem149);
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem150);
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem151);
            this.outlineRibbonPageGroup1.Name = "outlineRibbonPageGroup1";
            // 
            // spreadsheetCommandBarSubItem26
            // 
            this.spreadsheetCommandBarSubItem26.CommandName = "OutlineGroupCommandGroup";
            this.spreadsheetCommandBarSubItem26.Id = 224;
            this.spreadsheetCommandBarSubItem26.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem145),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem146)});
            this.spreadsheetCommandBarSubItem26.Name = "spreadsheetCommandBarSubItem26";
            this.spreadsheetCommandBarSubItem26.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem145
            // 
            this.spreadsheetCommandBarButtonItem145.CommandName = "GroupOutline";
            this.spreadsheetCommandBarButtonItem145.Id = 225;
            this.spreadsheetCommandBarButtonItem145.Name = "spreadsheetCommandBarButtonItem145";
            // 
            // spreadsheetCommandBarButtonItem146
            // 
            this.spreadsheetCommandBarButtonItem146.CommandName = "AutoOutline";
            this.spreadsheetCommandBarButtonItem146.Id = 226;
            this.spreadsheetCommandBarButtonItem146.Name = "spreadsheetCommandBarButtonItem146";
            // 
            // spreadsheetCommandBarSubItem27
            // 
            this.spreadsheetCommandBarSubItem27.CommandName = "OutlineUngroupCommandGroup";
            this.spreadsheetCommandBarSubItem27.Id = 227;
            this.spreadsheetCommandBarSubItem27.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem147),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem148)});
            this.spreadsheetCommandBarSubItem27.Name = "spreadsheetCommandBarSubItem27";
            this.spreadsheetCommandBarSubItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem147
            // 
            this.spreadsheetCommandBarButtonItem147.CommandName = "UngroupOutline";
            this.spreadsheetCommandBarButtonItem147.Id = 228;
            this.spreadsheetCommandBarButtonItem147.Name = "spreadsheetCommandBarButtonItem147";
            // 
            // spreadsheetCommandBarButtonItem148
            // 
            this.spreadsheetCommandBarButtonItem148.CommandName = "ClearOutline";
            this.spreadsheetCommandBarButtonItem148.Id = 229;
            this.spreadsheetCommandBarButtonItem148.Name = "spreadsheetCommandBarButtonItem148";
            // 
            // spreadsheetCommandBarButtonItem149
            // 
            this.spreadsheetCommandBarButtonItem149.CommandName = "Subtotal";
            this.spreadsheetCommandBarButtonItem149.Id = 230;
            this.spreadsheetCommandBarButtonItem149.Name = "spreadsheetCommandBarButtonItem149";
            this.spreadsheetCommandBarButtonItem149.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem150
            // 
            this.spreadsheetCommandBarButtonItem150.CommandName = "ShowDetail";
            this.spreadsheetCommandBarButtonItem150.Id = 231;
            this.spreadsheetCommandBarButtonItem150.Name = "spreadsheetCommandBarButtonItem150";
            this.spreadsheetCommandBarButtonItem150.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem151
            // 
            this.spreadsheetCommandBarButtonItem151.CommandName = "HideDetail";
            this.spreadsheetCommandBarButtonItem151.Id = 232;
            this.spreadsheetCommandBarButtonItem151.Name = "spreadsheetCommandBarButtonItem151";
            this.spreadsheetCommandBarButtonItem151.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // commentsRibbonPageGroup1
            // 
            this.commentsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem152);
            this.commentsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem153);
            this.commentsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem154);
            this.commentsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem155);
            this.commentsRibbonPageGroup1.Name = "commentsRibbonPageGroup1";
            // 
            // reviewRibbonPage1
            // 
            this.reviewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commentsRibbonPageGroup1,
            this.changesRibbonPageGroup1});
            this.reviewRibbonPage1.Name = "reviewRibbonPage1";
            // 
            // spreadsheetCommandBarButtonItem152
            // 
            this.spreadsheetCommandBarButtonItem152.CommandName = "ReviewInsertComment";
            this.spreadsheetCommandBarButtonItem152.Id = 233;
            this.spreadsheetCommandBarButtonItem152.Name = "spreadsheetCommandBarButtonItem152";
            // 
            // spreadsheetCommandBarButtonItem153
            // 
            this.spreadsheetCommandBarButtonItem153.CommandName = "ReviewEditComment";
            this.spreadsheetCommandBarButtonItem153.Id = 234;
            this.spreadsheetCommandBarButtonItem153.Name = "spreadsheetCommandBarButtonItem153";
            // 
            // spreadsheetCommandBarButtonItem154
            // 
            this.spreadsheetCommandBarButtonItem154.CommandName = "ReviewDeleteComment";
            this.spreadsheetCommandBarButtonItem154.Id = 235;
            this.spreadsheetCommandBarButtonItem154.Name = "spreadsheetCommandBarButtonItem154";
            // 
            // spreadsheetCommandBarButtonItem155
            // 
            this.spreadsheetCommandBarButtonItem155.CommandName = "ReviewShowHideComment";
            this.spreadsheetCommandBarButtonItem155.Id = 236;
            this.spreadsheetCommandBarButtonItem155.Name = "spreadsheetCommandBarButtonItem155";
            this.spreadsheetCommandBarButtonItem155.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // changesRibbonPageGroup1
            // 
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem80);
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem156);
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem157);
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem158);
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem159);
            this.changesRibbonPageGroup1.Name = "changesRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonItem156
            // 
            this.spreadsheetCommandBarButtonItem156.CommandName = "ReviewUnprotectSheet";
            this.spreadsheetCommandBarButtonItem156.Id = 237;
            this.spreadsheetCommandBarButtonItem156.Name = "spreadsheetCommandBarButtonItem156";
            // 
            // spreadsheetCommandBarButtonItem157
            // 
            this.spreadsheetCommandBarButtonItem157.CommandName = "ReviewProtectWorkbook";
            this.spreadsheetCommandBarButtonItem157.Id = 238;
            this.spreadsheetCommandBarButtonItem157.Name = "spreadsheetCommandBarButtonItem157";
            // 
            // spreadsheetCommandBarButtonItem158
            // 
            this.spreadsheetCommandBarButtonItem158.CommandName = "ReviewUnprotectWorkbook";
            this.spreadsheetCommandBarButtonItem158.Id = 239;
            this.spreadsheetCommandBarButtonItem158.Name = "spreadsheetCommandBarButtonItem158";
            // 
            // spreadsheetCommandBarButtonItem159
            // 
            this.spreadsheetCommandBarButtonItem159.CommandName = "ReviewShowProtectedRangeManager";
            this.spreadsheetCommandBarButtonItem159.Id = 240;
            this.spreadsheetCommandBarButtonItem159.Name = "spreadsheetCommandBarButtonItem159";
            // 
            // showRibbonPageGroup1
            // 
            this.showRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem20);
            this.showRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem21);
            this.showRibbonPageGroup1.Name = "showRibbonPageGroup1";
            // 
            // viewRibbonPage1
            // 
            this.viewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.showRibbonPageGroup1,
            this.zoomRibbonPageGroup1,
            this.windowRibbonPageGroup1});
            this.viewRibbonPage1.Name = "viewRibbonPage1";
            // 
            // zoomRibbonPageGroup1
            // 
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem160);
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem161);
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem162);
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem163);
            this.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonItem160
            // 
            this.spreadsheetCommandBarButtonItem160.CommandName = "ViewZoom";
            this.spreadsheetCommandBarButtonItem160.Id = 241;
            this.spreadsheetCommandBarButtonItem160.Name = "spreadsheetCommandBarButtonItem160";
            // 
            // spreadsheetCommandBarButtonItem161
            // 
            this.spreadsheetCommandBarButtonItem161.CommandName = "ViewZoomOut";
            this.spreadsheetCommandBarButtonItem161.Id = 242;
            this.spreadsheetCommandBarButtonItem161.Name = "spreadsheetCommandBarButtonItem161";
            // 
            // spreadsheetCommandBarButtonItem162
            // 
            this.spreadsheetCommandBarButtonItem162.CommandName = "ViewZoomIn";
            this.spreadsheetCommandBarButtonItem162.Id = 243;
            this.spreadsheetCommandBarButtonItem162.Name = "spreadsheetCommandBarButtonItem162";
            // 
            // spreadsheetCommandBarButtonItem163
            // 
            this.spreadsheetCommandBarButtonItem163.CommandName = "ViewZoom100Percent";
            this.spreadsheetCommandBarButtonItem163.Id = 244;
            this.spreadsheetCommandBarButtonItem163.Name = "spreadsheetCommandBarButtonItem163";
            // 
            // windowRibbonPageGroup1
            // 
            this.windowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem28);
            this.windowRibbonPageGroup1.Name = "windowRibbonPageGroup1";
            // 
            // spreadsheetCommandBarSubItem28
            // 
            this.spreadsheetCommandBarSubItem28.CommandName = "ViewFreezePanesCommandGroup";
            this.spreadsheetCommandBarSubItem28.Id = 245;
            this.spreadsheetCommandBarSubItem28.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem164),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem165),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem166),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem167)});
            this.spreadsheetCommandBarSubItem28.Name = "spreadsheetCommandBarSubItem28";
            // 
            // spreadsheetCommandBarButtonItem164
            // 
            this.spreadsheetCommandBarButtonItem164.CommandName = "ViewFreezePanes";
            this.spreadsheetCommandBarButtonItem164.Id = 246;
            this.spreadsheetCommandBarButtonItem164.Name = "spreadsheetCommandBarButtonItem164";
            // 
            // spreadsheetCommandBarButtonItem165
            // 
            this.spreadsheetCommandBarButtonItem165.CommandName = "ViewUnfreezePanes";
            this.spreadsheetCommandBarButtonItem165.Id = 247;
            this.spreadsheetCommandBarButtonItem165.Name = "spreadsheetCommandBarButtonItem165";
            // 
            // spreadsheetCommandBarButtonItem166
            // 
            this.spreadsheetCommandBarButtonItem166.CommandName = "ViewFreezeTopRow";
            this.spreadsheetCommandBarButtonItem166.Id = 248;
            this.spreadsheetCommandBarButtonItem166.Name = "spreadsheetCommandBarButtonItem166";
            // 
            // spreadsheetCommandBarButtonItem167
            // 
            this.spreadsheetCommandBarButtonItem167.CommandName = "ViewFreezeFirstColumn";
            this.spreadsheetCommandBarButtonItem167.Id = 249;
            this.spreadsheetCommandBarButtonItem167.Name = "spreadsheetCommandBarButtonItem167";
            // 
            // chartsDesignTypeRibbonPageGroup1
            // 
            this.chartsDesignTypeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem168);
            this.chartsDesignTypeRibbonPageGroup1.Name = "chartsDesignTypeRibbonPageGroup1";
            // 
            // chartsDesignRibbonPage1
            // 
            this.chartsDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.chartsDesignTypeRibbonPageGroup1,
            this.chartsDesignDataRibbonPageGroup1,
            this.chartsDesignLayoutsRibbonPageGroup1,
            this.chartsDesignStylesRibbonPageGroup1});
            this.chartsDesignRibbonPage1.Name = "chartsDesignRibbonPage1";
            this.chartsDesignRibbonPage1.Visible = false;
            // 
            // chartToolsRibbonPageCategory1
            // 
            this.chartToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.chartToolsRibbonPageCategory1.Name = "chartToolsRibbonPageCategory1";
            this.chartToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.chartsDesignRibbonPage1,
            this.chartsLayoutRibbonPage1,
            this.chartsFormatRibbonPage1});
            this.chartToolsRibbonPageCategory1.Visible = false;
            // 
            // spreadsheetCommandBarButtonItem168
            // 
            this.spreadsheetCommandBarButtonItem168.CommandName = "ChartChangeType";
            this.spreadsheetCommandBarButtonItem168.Id = 250;
            this.spreadsheetCommandBarButtonItem168.Name = "spreadsheetCommandBarButtonItem168";
            // 
            // chartsDesignDataRibbonPageGroup1
            // 
            this.chartsDesignDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem169);
            this.chartsDesignDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem170);
            this.chartsDesignDataRibbonPageGroup1.Name = "chartsDesignDataRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonItem169
            // 
            this.spreadsheetCommandBarButtonItem169.CommandName = "ChartSwitchRowColumn";
            this.spreadsheetCommandBarButtonItem169.Id = 251;
            this.spreadsheetCommandBarButtonItem169.Name = "spreadsheetCommandBarButtonItem169";
            // 
            // spreadsheetCommandBarButtonItem170
            // 
            this.spreadsheetCommandBarButtonItem170.CommandName = "ChartSelectData";
            this.spreadsheetCommandBarButtonItem170.Id = 252;
            this.spreadsheetCommandBarButtonItem170.Name = "spreadsheetCommandBarButtonItem170";
            // 
            // chartsDesignLayoutsRibbonPageGroup1
            // 
            this.chartsDesignLayoutsRibbonPageGroup1.ItemLinks.Add(this.galleryChartLayoutItem1);
            this.chartsDesignLayoutsRibbonPageGroup1.Name = "chartsDesignLayoutsRibbonPageGroup1";
            // 
            // galleryChartLayoutItem1
            // 
            // 
            // 
            // 
            this.galleryChartLayoutItem1.Gallery.ColumnCount = 6;
            this.galleryChartLayoutItem1.Gallery.DrawImageBackground = false;
            this.galleryChartLayoutItem1.Gallery.ImageSize = new System.Drawing.Size(48, 48);
            this.galleryChartLayoutItem1.Gallery.RowCount = 2;
            this.galleryChartLayoutItem1.Id = 253;
            this.galleryChartLayoutItem1.Name = "galleryChartLayoutItem1";
            // 
            // chartsDesignStylesRibbonPageGroup1
            // 
            this.chartsDesignStylesRibbonPageGroup1.ItemLinks.Add(this.galleryChartStyleItem1);
            this.chartsDesignStylesRibbonPageGroup1.Name = "chartsDesignStylesRibbonPageGroup1";
            // 
            // galleryChartStyleItem1
            // 
            // 
            // 
            // 
            this.galleryChartStyleItem1.Gallery.ColumnCount = 8;
            this.galleryChartStyleItem1.Gallery.DrawImageBackground = false;
            this.galleryChartStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChartStyleItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.galleryChartStyleItem1.Gallery.ItemSize = new System.Drawing.Size(93, 56);
            this.galleryChartStyleItem1.Gallery.MinimumColumnCount = 4;
            this.galleryChartStyleItem1.Gallery.RowCount = 6;
            this.galleryChartStyleItem1.Id = 254;
            this.galleryChartStyleItem1.Name = "galleryChartStyleItem1";
            // 
            // chartsLayoutAxesRibbonPageGroup1
            // 
            this.chartsLayoutAxesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem29);
            this.chartsLayoutAxesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem30);
            this.chartsLayoutAxesRibbonPageGroup1.Name = "chartsLayoutAxesRibbonPageGroup1";
            // 
            // chartsLayoutRibbonPage1
            // 
            this.chartsLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.chartsLayoutAxesRibbonPageGroup1,
            this.chartsLayoutLabelsRibbonPageGroup1,
            this.chartsLayoutAnalysisRibbonPageGroup1});
            this.chartsLayoutRibbonPage1.Name = "chartsLayoutRibbonPage1";
            this.chartsLayoutRibbonPage1.Visible = false;
            // 
            // spreadsheetCommandBarSubItem29
            // 
            this.spreadsheetCommandBarSubItem29.CommandName = "ChartAxesCommandGroup";
            this.spreadsheetCommandBarSubItem29.Id = 255;
            this.spreadsheetCommandBarSubItem29.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem11),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem12)});
            this.spreadsheetCommandBarSubItem29.Name = "spreadsheetCommandBarSubItem29";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem11
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem11.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem11.DropDownControl = this.commandBarGalleryDropDown61;
            this.spreadsheetCommandBarButtonGalleryDropDownItem11.Id = 256;
            this.spreadsheetCommandBarButtonGalleryDropDownItem11.Name = "spreadsheetCommandBarButtonGalleryDropDownItem11";
            // 
            // commandBarGalleryDropDown61
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown61.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.commandBarGalleryDropDown61.Gallery.ColumnCount = 1;
            spreadsheetCommandGalleryItemGroup31.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
            spreadsheetCommandGalleryItem135.CommandName = "ChartHidePrimaryHorizontalAxis";
            spreadsheetCommandGalleryItem136.CommandName = "ChartPrimaryHorizontalAxisLeftToRight";
            spreadsheetCommandGalleryItem137.CommandName = "ChartPrimaryHorizontalAxisHideLabels";
            spreadsheetCommandGalleryItem138.CommandName = "ChartPrimaryHorizontalAxisRightToLeft";
            spreadsheetCommandGalleryItem139.CommandName = "ChartPrimaryHorizontalAxisDefault";
            spreadsheetCommandGalleryItem140.CommandName = "ChartPrimaryHorizontalAxisScaleThousands";
            spreadsheetCommandGalleryItem141.CommandName = "ChartPrimaryHorizontalAxisScaleMillions";
            spreadsheetCommandGalleryItem142.CommandName = "ChartPrimaryHorizontalAxisScaleBillions";
            spreadsheetCommandGalleryItem143.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm";
            spreadsheetCommandGalleryItemGroup31.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem135,
            spreadsheetCommandGalleryItem136,
            spreadsheetCommandGalleryItem137,
            spreadsheetCommandGalleryItem138,
            spreadsheetCommandGalleryItem139,
            spreadsheetCommandGalleryItem140,
            spreadsheetCommandGalleryItem141,
            spreadsheetCommandGalleryItem142,
            spreadsheetCommandGalleryItem143});
            this.commandBarGalleryDropDown61.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup31});
            this.commandBarGalleryDropDown61.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown61.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown61.Gallery.RowCount = 9;
            this.commandBarGalleryDropDown61.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown61.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown61.Name = "commandBarGalleryDropDown61";
            this.commandBarGalleryDropDown61.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem12
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem12.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem12.DropDownControl = this.commandBarGalleryDropDown62;
            this.spreadsheetCommandBarButtonGalleryDropDownItem12.Id = 257;
            this.spreadsheetCommandBarButtonGalleryDropDownItem12.Name = "spreadsheetCommandBarButtonGalleryDropDownItem12";
            // 
            // commandBarGalleryDropDown62
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown62.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.commandBarGalleryDropDown62.Gallery.ColumnCount = 1;
            spreadsheetCommandGalleryItemGroup32.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
            spreadsheetCommandGalleryItem144.CommandName = "ChartHidePrimaryVerticalAxis";
            spreadsheetCommandGalleryItem145.CommandName = "ChartPrimaryVerticalAxisLeftToRight";
            spreadsheetCommandGalleryItem146.CommandName = "ChartPrimaryVerticalAxisHideLabels";
            spreadsheetCommandGalleryItem147.CommandName = "ChartPrimaryVerticalAxisRightToLeft";
            spreadsheetCommandGalleryItem148.CommandName = "ChartPrimaryVerticalAxisDefault";
            spreadsheetCommandGalleryItem149.CommandName = "ChartPrimaryVerticalAxisScaleThousands";
            spreadsheetCommandGalleryItem150.CommandName = "ChartPrimaryVerticalAxisScaleMillions";
            spreadsheetCommandGalleryItem151.CommandName = "ChartPrimaryVerticalAxisScaleBillions";
            spreadsheetCommandGalleryItem152.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm";
            spreadsheetCommandGalleryItemGroup32.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem144,
            spreadsheetCommandGalleryItem145,
            spreadsheetCommandGalleryItem146,
            spreadsheetCommandGalleryItem147,
            spreadsheetCommandGalleryItem148,
            spreadsheetCommandGalleryItem149,
            spreadsheetCommandGalleryItem150,
            spreadsheetCommandGalleryItem151,
            spreadsheetCommandGalleryItem152});
            this.commandBarGalleryDropDown62.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup32});
            this.commandBarGalleryDropDown62.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown62.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown62.Gallery.RowCount = 9;
            this.commandBarGalleryDropDown62.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown62.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown62.Name = "commandBarGalleryDropDown62";
            this.commandBarGalleryDropDown62.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarSubItem30
            // 
            this.spreadsheetCommandBarSubItem30.CommandName = "ChartGridlinesCommandGroup";
            this.spreadsheetCommandBarSubItem30.Id = 258;
            this.spreadsheetCommandBarSubItem30.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem13),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem14)});
            this.spreadsheetCommandBarSubItem30.Name = "spreadsheetCommandBarSubItem30";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem13
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem13.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem13.DropDownControl = this.commandBarGalleryDropDown63;
            this.spreadsheetCommandBarButtonGalleryDropDownItem13.Id = 259;
            this.spreadsheetCommandBarButtonGalleryDropDownItem13.Name = "spreadsheetCommandBarButtonGalleryDropDownItem13";
            // 
            // commandBarGalleryDropDown63
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown63.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.commandBarGalleryDropDown63.Gallery.ColumnCount = 1;
            spreadsheetCommandGalleryItemGroup33.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem153.CommandName = "ChartPrimaryHorizontalGridlinesNone";
            spreadsheetCommandGalleryItem154.CommandName = "ChartPrimaryHorizontalGridlinesMajor";
            spreadsheetCommandGalleryItem155.CommandName = "ChartPrimaryHorizontalGridlinesMinor";
            spreadsheetCommandGalleryItem156.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItemGroup33.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem153,
            spreadsheetCommandGalleryItem154,
            spreadsheetCommandGalleryItem155,
            spreadsheetCommandGalleryItem156});
            this.commandBarGalleryDropDown63.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup33});
            this.commandBarGalleryDropDown63.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown63.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown63.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown63.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown63.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown63.Name = "commandBarGalleryDropDown63";
            this.commandBarGalleryDropDown63.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem14
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem14.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem14.DropDownControl = this.commandBarGalleryDropDown64;
            this.spreadsheetCommandBarButtonGalleryDropDownItem14.Id = 260;
            this.spreadsheetCommandBarButtonGalleryDropDownItem14.Name = "spreadsheetCommandBarButtonGalleryDropDownItem14";
            // 
            // commandBarGalleryDropDown64
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown64.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.commandBarGalleryDropDown64.Gallery.ColumnCount = 1;
            spreadsheetCommandGalleryItemGroup34.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem157.CommandName = "ChartPrimaryVerticalGridlinesNone";
            spreadsheetCommandGalleryItem158.CommandName = "ChartPrimaryVerticalGridlinesMajor";
            spreadsheetCommandGalleryItem159.CommandName = "ChartPrimaryVerticalGridlinesMinor";
            spreadsheetCommandGalleryItem160.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItemGroup34.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem157,
            spreadsheetCommandGalleryItem158,
            spreadsheetCommandGalleryItem159,
            spreadsheetCommandGalleryItem160});
            this.commandBarGalleryDropDown64.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup34});
            this.commandBarGalleryDropDown64.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown64.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown64.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown64.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown64.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown64.Name = "commandBarGalleryDropDown64";
            this.commandBarGalleryDropDown64.Ribbon = this.ribbonControl1;
            // 
            // chartsLayoutLabelsRibbonPageGroup1
            // 
            this.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem15);
            this.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem31);
            this.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem18);
            this.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem19);
            this.chartsLayoutLabelsRibbonPageGroup1.Name = "chartsLayoutLabelsRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem15
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem15.CommandName = "ChartTitleCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem15.DropDownControl = this.commandBarGalleryDropDown65;
            this.spreadsheetCommandBarButtonGalleryDropDownItem15.Id = 261;
            this.spreadsheetCommandBarButtonGalleryDropDownItem15.Name = "spreadsheetCommandBarButtonGalleryDropDownItem15";
            // 
            // commandBarGalleryDropDown65
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown65.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.commandBarGalleryDropDown65.Gallery.ColumnCount = 1;
            spreadsheetCommandGalleryItemGroup35.CommandName = "ChartTitleCommandGroup";
            spreadsheetCommandGalleryItem161.CommandName = "ChartTitleNone";
            spreadsheetCommandGalleryItem162.CommandName = "ChartTitleCenteredOverlay";
            spreadsheetCommandGalleryItem163.CommandName = "ChartTitleAbove";
            spreadsheetCommandGalleryItemGroup35.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem161,
            spreadsheetCommandGalleryItem162,
            spreadsheetCommandGalleryItem163});
            this.commandBarGalleryDropDown65.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup35});
            this.commandBarGalleryDropDown65.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown65.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown65.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown65.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown65.Name = "commandBarGalleryDropDown65";
            this.commandBarGalleryDropDown65.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarSubItem31
            // 
            this.spreadsheetCommandBarSubItem31.CommandName = "ChartAxisTitlesCommandGroup";
            this.spreadsheetCommandBarSubItem31.Id = 262;
            this.spreadsheetCommandBarSubItem31.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem16),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem17)});
            this.spreadsheetCommandBarSubItem31.Name = "spreadsheetCommandBarSubItem31";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem16
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem16.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem16.DropDownControl = this.commandBarGalleryDropDown66;
            this.spreadsheetCommandBarButtonGalleryDropDownItem16.Id = 263;
            this.spreadsheetCommandBarButtonGalleryDropDownItem16.Name = "spreadsheetCommandBarButtonGalleryDropDownItem16";
            // 
            // commandBarGalleryDropDown66
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown66.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.commandBarGalleryDropDown66.Gallery.ColumnCount = 1;
            spreadsheetCommandGalleryItemGroup36.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem164.CommandName = "ChartPrimaryHorizontalAxisTitleNone";
            spreadsheetCommandGalleryItem165.CommandName = "ChartPrimaryHorizontalAxisTitleBelow";
            spreadsheetCommandGalleryItemGroup36.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem164,
            spreadsheetCommandGalleryItem165});
            this.commandBarGalleryDropDown66.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup36});
            this.commandBarGalleryDropDown66.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown66.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown66.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown66.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown66.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown66.Name = "commandBarGalleryDropDown66";
            this.commandBarGalleryDropDown66.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem17
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem17.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem17.DropDownControl = this.commandBarGalleryDropDown67;
            this.spreadsheetCommandBarButtonGalleryDropDownItem17.Id = 264;
            this.spreadsheetCommandBarButtonGalleryDropDownItem17.Name = "spreadsheetCommandBarButtonGalleryDropDownItem17";
            // 
            // commandBarGalleryDropDown67
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown67.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.commandBarGalleryDropDown67.Gallery.ColumnCount = 1;
            spreadsheetCommandGalleryItemGroup37.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem166.CommandName = "ChartPrimaryVerticalAxisTitleNone";
            spreadsheetCommandGalleryItem167.CommandName = "ChartPrimaryVerticalAxisTitleRotated";
            spreadsheetCommandGalleryItem168.CommandName = "ChartPrimaryVerticalAxisTitleVertical";
            spreadsheetCommandGalleryItem169.CommandName = "ChartPrimaryVerticalAxisTitleHorizontal";
            spreadsheetCommandGalleryItemGroup37.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem166,
            spreadsheetCommandGalleryItem167,
            spreadsheetCommandGalleryItem168,
            spreadsheetCommandGalleryItem169});
            this.commandBarGalleryDropDown67.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup37});
            this.commandBarGalleryDropDown67.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown67.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown67.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown67.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown67.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown67.Name = "commandBarGalleryDropDown67";
            this.commandBarGalleryDropDown67.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem18
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem18.CommandName = "ChartLegendCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem18.DropDownControl = this.commandBarGalleryDropDown68;
            this.spreadsheetCommandBarButtonGalleryDropDownItem18.Id = 265;
            this.spreadsheetCommandBarButtonGalleryDropDownItem18.Name = "spreadsheetCommandBarButtonGalleryDropDownItem18";
            // 
            // commandBarGalleryDropDown68
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown68.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.commandBarGalleryDropDown68.Gallery.ColumnCount = 1;
            spreadsheetCommandGalleryItemGroup38.CommandName = "ChartLegendCommandGroup";
            spreadsheetCommandGalleryItem170.CommandName = "ChartLegendNone";
            spreadsheetCommandGalleryItem171.CommandName = "ChartLegendAtRight";
            spreadsheetCommandGalleryItem172.CommandName = "ChartLegendAtTop";
            spreadsheetCommandGalleryItem173.CommandName = "ChartLegendAtLeft";
            spreadsheetCommandGalleryItem174.CommandName = "ChartLegendAtBottom";
            spreadsheetCommandGalleryItem175.CommandName = "ChartLegendOverlayAtRight";
            spreadsheetCommandGalleryItem176.CommandName = "ChartLegendOverlayAtLeft";
            spreadsheetCommandGalleryItemGroup38.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem170,
            spreadsheetCommandGalleryItem171,
            spreadsheetCommandGalleryItem172,
            spreadsheetCommandGalleryItem173,
            spreadsheetCommandGalleryItem174,
            spreadsheetCommandGalleryItem175,
            spreadsheetCommandGalleryItem176});
            this.commandBarGalleryDropDown68.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup38});
            this.commandBarGalleryDropDown68.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown68.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown68.Gallery.RowCount = 7;
            this.commandBarGalleryDropDown68.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown68.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown68.Name = "commandBarGalleryDropDown68";
            this.commandBarGalleryDropDown68.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem19
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem19.CommandName = "ChartDataLabelsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem19.DropDownControl = this.commandBarGalleryDropDown69;
            this.spreadsheetCommandBarButtonGalleryDropDownItem19.Id = 266;
            this.spreadsheetCommandBarButtonGalleryDropDownItem19.Name = "spreadsheetCommandBarButtonGalleryDropDownItem19";
            // 
            // commandBarGalleryDropDown69
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown69.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.commandBarGalleryDropDown69.Gallery.ColumnCount = 1;
            spreadsheetCommandGalleryItemGroup39.CommandName = "ChartDataLabelsCommandGroup";
            spreadsheetCommandGalleryItem177.CommandName = "ChartDataLabelsNone";
            spreadsheetCommandGalleryItem178.CommandName = "ChartDataLabelsDefault";
            spreadsheetCommandGalleryItem179.CommandName = "ChartDataLabelsCenter";
            spreadsheetCommandGalleryItem180.CommandName = "ChartDataLabelsInsideEnd";
            spreadsheetCommandGalleryItem181.CommandName = "ChartDataLabelsInsideBase";
            spreadsheetCommandGalleryItem182.CommandName = "ChartDataLabelsOutsideEnd";
            spreadsheetCommandGalleryItem183.CommandName = "ChartDataLabelsBestFit";
            spreadsheetCommandGalleryItem184.CommandName = "ChartDataLabelsLeft";
            spreadsheetCommandGalleryItem185.CommandName = "ChartDataLabelsRight";
            spreadsheetCommandGalleryItem186.CommandName = "ChartDataLabelsAbove";
            spreadsheetCommandGalleryItem187.CommandName = "ChartDataLabelsBelow";
            spreadsheetCommandGalleryItemGroup39.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem177,
            spreadsheetCommandGalleryItem178,
            spreadsheetCommandGalleryItem179,
            spreadsheetCommandGalleryItem180,
            spreadsheetCommandGalleryItem181,
            spreadsheetCommandGalleryItem182,
            spreadsheetCommandGalleryItem183,
            spreadsheetCommandGalleryItem184,
            spreadsheetCommandGalleryItem185,
            spreadsheetCommandGalleryItem186,
            spreadsheetCommandGalleryItem187});
            this.commandBarGalleryDropDown69.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup39});
            this.commandBarGalleryDropDown69.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown69.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown69.Gallery.RowCount = 11;
            this.commandBarGalleryDropDown69.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown69.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown69.Name = "commandBarGalleryDropDown69";
            this.commandBarGalleryDropDown69.Ribbon = this.ribbonControl1;
            // 
            // chartsLayoutAnalysisRibbonPageGroup1
            // 
            this.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem20);
            this.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem21);
            this.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem22);
            this.chartsLayoutAnalysisRibbonPageGroup1.Name = "chartsLayoutAnalysisRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem20
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem20.CommandName = "ChartLinesCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem20.DropDownControl = this.commandBarGalleryDropDown70;
            this.spreadsheetCommandBarButtonGalleryDropDownItem20.Id = 267;
            this.spreadsheetCommandBarButtonGalleryDropDownItem20.Name = "spreadsheetCommandBarButtonGalleryDropDownItem20";
            // 
            // commandBarGalleryDropDown70
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown70.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.commandBarGalleryDropDown70.Gallery.ColumnCount = 1;
            spreadsheetCommandGalleryItemGroup40.CommandName = "ChartLinesCommandGroup";
            spreadsheetCommandGalleryItem188.CommandName = "ChartLinesNone";
            spreadsheetCommandGalleryItem189.CommandName = "ChartShowDropLines";
            spreadsheetCommandGalleryItem190.CommandName = "ChartShowHighLowLines";
            spreadsheetCommandGalleryItem191.CommandName = "ChartShowDropLinesAndHighLowLines";
            spreadsheetCommandGalleryItem192.CommandName = "ChartShowSeriesLines";
            spreadsheetCommandGalleryItemGroup40.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem188,
            spreadsheetCommandGalleryItem189,
            spreadsheetCommandGalleryItem190,
            spreadsheetCommandGalleryItem191,
            spreadsheetCommandGalleryItem192});
            this.commandBarGalleryDropDown70.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup40});
            this.commandBarGalleryDropDown70.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown70.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown70.Gallery.RowCount = 5;
            this.commandBarGalleryDropDown70.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown70.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown70.Name = "commandBarGalleryDropDown70";
            this.commandBarGalleryDropDown70.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem21
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem21.CommandName = "ChartUpDownBarsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem21.DropDownControl = this.commandBarGalleryDropDown71;
            this.spreadsheetCommandBarButtonGalleryDropDownItem21.Id = 268;
            this.spreadsheetCommandBarButtonGalleryDropDownItem21.Name = "spreadsheetCommandBarButtonGalleryDropDownItem21";
            // 
            // commandBarGalleryDropDown71
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown71.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.commandBarGalleryDropDown71.Gallery.ColumnCount = 1;
            spreadsheetCommandGalleryItemGroup41.CommandName = "ChartUpDownBarsCommandGroup";
            spreadsheetCommandGalleryItem193.CommandName = "ChartHideUpDownBars";
            spreadsheetCommandGalleryItem194.CommandName = "ChartShowUpDownBars";
            spreadsheetCommandGalleryItemGroup41.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem193,
            spreadsheetCommandGalleryItem194});
            this.commandBarGalleryDropDown71.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup41});
            this.commandBarGalleryDropDown71.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown71.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown71.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown71.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown71.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown71.Name = "commandBarGalleryDropDown71";
            this.commandBarGalleryDropDown71.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem22
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem22.CommandName = "ChartErrorBarsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem22.DropDownControl = this.commandBarGalleryDropDown72;
            this.spreadsheetCommandBarButtonGalleryDropDownItem22.Id = 269;
            this.spreadsheetCommandBarButtonGalleryDropDownItem22.Name = "spreadsheetCommandBarButtonGalleryDropDownItem22";
            // 
            // commandBarGalleryDropDown72
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown72.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.commandBarGalleryDropDown72.Gallery.ColumnCount = 1;
            spreadsheetCommandGalleryItemGroup42.CommandName = "ChartErrorBarsCommandGroup";
            spreadsheetCommandGalleryItem195.CommandName = "ChartErrorBarsNone";
            spreadsheetCommandGalleryItem196.CommandName = "ChartErrorBarsStandardError";
            spreadsheetCommandGalleryItem197.CommandName = "ChartErrorBarsPercentage";
            spreadsheetCommandGalleryItem198.CommandName = "ChartErrorBarsStandardDeviation";
            spreadsheetCommandGalleryItemGroup42.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem195,
            spreadsheetCommandGalleryItem196,
            spreadsheetCommandGalleryItem197,
            spreadsheetCommandGalleryItem198});
            this.commandBarGalleryDropDown72.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup42});
            this.commandBarGalleryDropDown72.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown72.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown72.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown72.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown72.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown72.Name = "commandBarGalleryDropDown72";
            this.commandBarGalleryDropDown72.Ribbon = this.ribbonControl1;
            // 
            // chartsFormatArrangeRibbonPageGroup1
            // 
            this.chartsFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
            this.chartsFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
            this.chartsFormatArrangeRibbonPageGroup1.Name = "chartsFormatArrangeRibbonPageGroup1";
            // 
            // chartsFormatRibbonPage1
            // 
            this.chartsFormatRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.chartsFormatArrangeRibbonPageGroup1});
            this.chartsFormatRibbonPage1.Name = "chartsFormatRibbonPage1";
            this.chartsFormatRibbonPage1.Visible = false;
            // 
            // tablePropertiesRibbonPageGroup1
            // 
            this.tablePropertiesRibbonPageGroup1.ItemLinks.Add(this.renameTableItemCaption1);
            this.tablePropertiesRibbonPageGroup1.ItemLinks.Add(this.renameTableItem1);
            this.tablePropertiesRibbonPageGroup1.Name = "tablePropertiesRibbonPageGroup1";
            // 
            // tableToolsDesignRibbonPage1
            // 
            this.tableToolsDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tablePropertiesRibbonPageGroup1,
            this.tableToolsRibbonPageGroup1,
            this.tableStyleOptionsRibbonPageGroup1,
            this.tableStylesRibbonPageGroup1});
            this.tableToolsDesignRibbonPage1.Name = "tableToolsDesignRibbonPage1";
            this.tableToolsDesignRibbonPage1.Visible = false;
            // 
            // tableToolsRibbonPageCategory1
            // 
            this.tableToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1";
            this.tableToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tableToolsDesignRibbonPage1});
            this.tableToolsRibbonPageCategory1.Visible = false;
            // 
            // renameTableItemCaption1
            // 
            this.renameTableItemCaption1.Caption = "Table Name:";
            this.renameTableItemCaption1.Id = 270;
            this.renameTableItemCaption1.Name = "renameTableItemCaption1";
            this.renameTableItemCaption1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // renameTableItem1
            // 
            this.renameTableItem1.Edit = this.repositoryItemTextEdit1;
            this.renameTableItem1.Id = 271;
            this.renameTableItem1.Name = "renameTableItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // tableToolsRibbonPageGroup1
            // 
            this.tableToolsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem27);
            this.tableToolsRibbonPageGroup1.Name = "tableToolsRibbonPageGroup1";
            // 
            // spreadsheetCommandBarCheckItem27
            // 
            this.spreadsheetCommandBarCheckItem27.CommandName = "TableToolsConvertToRange";
            this.spreadsheetCommandBarCheckItem27.Id = 272;
            this.spreadsheetCommandBarCheckItem27.Name = "spreadsheetCommandBarCheckItem27";
            this.spreadsheetCommandBarCheckItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // tableStyleOptionsRibbonPageGroup1
            // 
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem28);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem29);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem30);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem31);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem32);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem33);
            this.tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1";
            // 
            // spreadsheetCommandBarCheckItem28
            // 
            this.spreadsheetCommandBarCheckItem28.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem28.CommandName = "TableToolsToggleHeaderRow";
            this.spreadsheetCommandBarCheckItem28.Id = 273;
            this.spreadsheetCommandBarCheckItem28.Name = "spreadsheetCommandBarCheckItem28";
            // 
            // spreadsheetCommandBarCheckItem29
            // 
            this.spreadsheetCommandBarCheckItem29.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem29.CommandName = "TableToolsToggleTotalRow";
            this.spreadsheetCommandBarCheckItem29.Id = 274;
            this.spreadsheetCommandBarCheckItem29.Name = "spreadsheetCommandBarCheckItem29";
            // 
            // spreadsheetCommandBarCheckItem30
            // 
            this.spreadsheetCommandBarCheckItem30.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem30.CommandName = "TableToolsToggleBandedColumns";
            this.spreadsheetCommandBarCheckItem30.Id = 275;
            this.spreadsheetCommandBarCheckItem30.Name = "spreadsheetCommandBarCheckItem30";
            // 
            // spreadsheetCommandBarCheckItem31
            // 
            this.spreadsheetCommandBarCheckItem31.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem31.CommandName = "TableToolsToggleFirstColumn";
            this.spreadsheetCommandBarCheckItem31.Id = 276;
            this.spreadsheetCommandBarCheckItem31.Name = "spreadsheetCommandBarCheckItem31";
            // 
            // spreadsheetCommandBarCheckItem32
            // 
            this.spreadsheetCommandBarCheckItem32.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem32.CommandName = "TableToolsToggleLastColumn";
            this.spreadsheetCommandBarCheckItem32.Id = 277;
            this.spreadsheetCommandBarCheckItem32.Name = "spreadsheetCommandBarCheckItem32";
            // 
            // spreadsheetCommandBarCheckItem33
            // 
            this.spreadsheetCommandBarCheckItem33.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem33.CommandName = "TableToolsToggleBandedRows";
            this.spreadsheetCommandBarCheckItem33.Id = 278;
            this.spreadsheetCommandBarCheckItem33.Name = "spreadsheetCommandBarCheckItem33";
            // 
            // tableStylesRibbonPageGroup1
            // 
            this.tableStylesRibbonPageGroup1.ItemLinks.Add(this.galleryTableStylesItem1);
            this.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1";
            // 
            // galleryTableStylesItem1
            // 
            // 
            // 
            // 
            this.galleryTableStylesItem1.Gallery.ColumnCount = 7;
            this.galleryTableStylesItem1.Gallery.DrawImageBackground = false;
            this.galleryTableStylesItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryTableStylesItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.galleryTableStylesItem1.Gallery.ItemSize = new System.Drawing.Size(73, 58);
            this.galleryTableStylesItem1.Gallery.RowCount = 10;
            this.galleryTableStylesItem1.Id = 279;
            this.galleryTableStylesItem1.Name = "galleryTableStylesItem1";
            // 
            // drawingFormatArrangeRibbonPageGroup1
            // 
            this.drawingFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
            this.drawingFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
            this.drawingFormatArrangeRibbonPageGroup1.Name = "drawingFormatArrangeRibbonPageGroup1";
            // 
            // drawingFormatRibbonPage1
            // 
            this.drawingFormatRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.drawingFormatArrangeRibbonPageGroup1});
            this.drawingFormatRibbonPage1.Name = "drawingFormatRibbonPage1";
            this.drawingFormatRibbonPage1.Visible = false;
            // 
            // drawingToolsRibbonPageCategory1
            // 
            this.drawingToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.drawingToolsRibbonPageCategory1.Name = "drawingToolsRibbonPageCategory1";
            this.drawingToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.drawingFormatRibbonPage1});
            this.drawingToolsRibbonPageCategory1.Visible = false;
            // 
            // pictureFormatArrangeRibbonPageGroup1
            // 
            this.pictureFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
            this.pictureFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
            this.pictureFormatArrangeRibbonPageGroup1.Name = "pictureFormatArrangeRibbonPageGroup1";
            // 
            // pictureFormatRibbonPage1
            // 
            this.pictureFormatRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pictureFormatArrangeRibbonPageGroup1});
            this.pictureFormatRibbonPage1.Name = "pictureFormatRibbonPage1";
            this.pictureFormatRibbonPage1.Visible = false;
            // 
            // pictureToolsRibbonPageCategory1
            // 
            this.pictureToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.pictureToolsRibbonPageCategory1.Name = "pictureToolsRibbonPageCategory1";
            this.pictureToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pictureFormatRibbonPage1});
            this.pictureToolsRibbonPageCategory1.Visible = false;
            // 
            // pivotTableAnalyzePivotTableRibbonPageGroup1
            // 
            this.pivotTableAnalyzePivotTableRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem171);
            this.pivotTableAnalyzePivotTableRibbonPageGroup1.Name = "pivotTableAnalyzePivotTableRibbonPageGroup1";
            // 
            // pivotTableAnalyzeRibbonPage1
            // 
            this.pivotTableAnalyzeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pivotTableAnalyzePivotTableRibbonPageGroup1,
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1,
            this.pivotTableAnalyzeGroupRibbonPageGroup1,
            this.pivotTableAnalyzeDataRibbonPageGroup1,
            this.pivotTableAnalyzeActionsRibbonPageGroup1,
            this.pivotTableAnalyzeCalculationsRibbonPageGroup1,
            this.pivotTableAnalyzeShowRibbonPageGroup1});
            this.pivotTableAnalyzeRibbonPage1.Name = "pivotTableAnalyzeRibbonPage1";
            this.pivotTableAnalyzeRibbonPage1.Visible = false;
            // 
            // pivotTableToolsRibbonPageCategory1
            // 
            this.pivotTableToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.pivotTableToolsRibbonPageCategory1.Name = "pivotTableToolsRibbonPageCategory1";
            this.pivotTableToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pivotTableAnalyzeRibbonPage1,
            this.pivotTableDesignRibbonPage1});
            this.pivotTableToolsRibbonPageCategory1.Visible = false;
            // 
            // spreadsheetCommandBarButtonItem171
            // 
            this.spreadsheetCommandBarButtonItem171.CommandName = "OptionsPivotTable";
            this.spreadsheetCommandBarButtonItem171.Id = 280;
            this.spreadsheetCommandBarButtonItem171.Name = "spreadsheetCommandBarButtonItem171";
            // 
            // pivotTableAnalyzeActiveFieldRibbonPageGroup1
            // 
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem172);
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem173);
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem174);
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1.Name = "pivotTableAnalyzeActiveFieldRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonItem172
            // 
            this.spreadsheetCommandBarButtonItem172.CommandName = "SelectFieldTypePivotTable";
            this.spreadsheetCommandBarButtonItem172.Id = 281;
            this.spreadsheetCommandBarButtonItem172.Name = "spreadsheetCommandBarButtonItem172";
            // 
            // spreadsheetCommandBarButtonItem173
            // 
            this.spreadsheetCommandBarButtonItem173.CommandName = "PivotTableExpandField";
            this.spreadsheetCommandBarButtonItem173.Id = 282;
            this.spreadsheetCommandBarButtonItem173.Name = "spreadsheetCommandBarButtonItem173";
            this.spreadsheetCommandBarButtonItem173.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem174
            // 
            this.spreadsheetCommandBarButtonItem174.CommandName = "PivotTableCollapseField";
            this.spreadsheetCommandBarButtonItem174.Id = 283;
            this.spreadsheetCommandBarButtonItem174.Name = "spreadsheetCommandBarButtonItem174";
            this.spreadsheetCommandBarButtonItem174.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // pivotTableAnalyzeGroupRibbonPageGroup1
            // 
            this.pivotTableAnalyzeGroupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem175);
            this.pivotTableAnalyzeGroupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem176);
            this.pivotTableAnalyzeGroupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem177);
            this.pivotTableAnalyzeGroupRibbonPageGroup1.Name = "pivotTableAnalyzeGroupRibbonPageGroup1";
            // 
            // spreadsheetCommandBarButtonItem175
            // 
            this.spreadsheetCommandBarButtonItem175.CommandName = "PivotTableGroupSelection";
            this.spreadsheetCommandBarButtonItem175.Id = 284;
            this.spreadsheetCommandBarButtonItem175.Name = "spreadsheetCommandBarButtonItem175";
            this.spreadsheetCommandBarButtonItem175.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem176
            // 
            this.spreadsheetCommandBarButtonItem176.CommandName = "PivotTableUngroup";
            this.spreadsheetCommandBarButtonItem176.Id = 285;
            this.spreadsheetCommandBarButtonItem176.Name = "spreadsheetCommandBarButtonItem176";
            this.spreadsheetCommandBarButtonItem176.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem177
            // 
            this.spreadsheetCommandBarButtonItem177.CommandName = "PivotTableGroupField";
            this.spreadsheetCommandBarButtonItem177.Id = 286;
            this.spreadsheetCommandBarButtonItem177.Name = "spreadsheetCommandBarButtonItem177";
            this.spreadsheetCommandBarButtonItem177.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // pivotTableAnalyzeDataRibbonPageGroup1
            // 
            this.pivotTableAnalyzeDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem32);
            this.pivotTableAnalyzeDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem180);
            this.pivotTableAnalyzeDataRibbonPageGroup1.Name = "pivotTableAnalyzeDataRibbonPageGroup1";
            // 
            // spreadsheetCommandBarSubItem32
            // 
            this.spreadsheetCommandBarSubItem32.CommandName = "PivotTableDataRefreshGroup";
            this.spreadsheetCommandBarSubItem32.Id = 287;
            this.spreadsheetCommandBarSubItem32.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem178),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem179)});
            this.spreadsheetCommandBarSubItem32.Name = "spreadsheetCommandBarSubItem32";
            // 
            // spreadsheetCommandBarButtonItem178
            // 
            this.spreadsheetCommandBarButtonItem178.CommandName = "RefreshPivotTable";
            this.spreadsheetCommandBarButtonItem178.Id = 288;
            this.spreadsheetCommandBarButtonItem178.Name = "spreadsheetCommandBarButtonItem178";
            // 
            // spreadsheetCommandBarButtonItem179
            // 
            this.spreadsheetCommandBarButtonItem179.CommandName = "RefreshAllPivotTable";
            this.spreadsheetCommandBarButtonItem179.Id = 289;
            this.spreadsheetCommandBarButtonItem179.Name = "spreadsheetCommandBarButtonItem179";
            // 
            // spreadsheetCommandBarButtonItem180
            // 
            this.spreadsheetCommandBarButtonItem180.CommandName = "ChangeDataSourcePivotTable";
            this.spreadsheetCommandBarButtonItem180.Id = 290;
            this.spreadsheetCommandBarButtonItem180.Name = "spreadsheetCommandBarButtonItem180";
            // 
            // pivotTableAnalyzeActionsRibbonPageGroup1
            // 
            this.pivotTableAnalyzeActionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem33);
            this.pivotTableAnalyzeActionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem34);
            this.pivotTableAnalyzeActionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem186);
            this.pivotTableAnalyzeActionsRibbonPageGroup1.Name = "pivotTableAnalyzeActionsRibbonPageGroup1";
            // 
            // spreadsheetCommandBarSubItem33
            // 
            this.spreadsheetCommandBarSubItem33.CommandName = "PivotTableActionsClearGroup";
            this.spreadsheetCommandBarSubItem33.Id = 291;
            this.spreadsheetCommandBarSubItem33.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem181),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem182)});
            this.spreadsheetCommandBarSubItem33.Name = "spreadsheetCommandBarSubItem33";
            // 
            // spreadsheetCommandBarButtonItem181
            // 
            this.spreadsheetCommandBarButtonItem181.CommandName = "ClearAllPivotTable";
            this.spreadsheetCommandBarButtonItem181.Id = 292;
            this.spreadsheetCommandBarButtonItem181.Name = "spreadsheetCommandBarButtonItem181";
            // 
            // spreadsheetCommandBarButtonItem182
            // 
            this.spreadsheetCommandBarButtonItem182.CommandName = "ClearFiltersPivotTable";
            this.spreadsheetCommandBarButtonItem182.Id = 293;
            this.spreadsheetCommandBarButtonItem182.Name = "spreadsheetCommandBarButtonItem182";
            // 
            // spreadsheetCommandBarSubItem34
            // 
            this.spreadsheetCommandBarSubItem34.CommandName = "PivotTableActionsSelectGroup";
            this.spreadsheetCommandBarSubItem34.Id = 294;
            this.spreadsheetCommandBarSubItem34.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem183),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem184),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem185)});
            this.spreadsheetCommandBarSubItem34.Name = "spreadsheetCommandBarSubItem34";
            // 
            // spreadsheetCommandBarButtonItem183
            // 
            this.spreadsheetCommandBarButtonItem183.CommandName = "SelectValuesPivotTable";
            this.spreadsheetCommandBarButtonItem183.Id = 295;
            this.spreadsheetCommandBarButtonItem183.Name = "spreadsheetCommandBarButtonItem183";
            // 
            // spreadsheetCommandBarButtonItem184
            // 
            this.spreadsheetCommandBarButtonItem184.CommandName = "SelectLabelsPivotTable";
            this.spreadsheetCommandBarButtonItem184.Id = 296;
            this.spreadsheetCommandBarButtonItem184.Name = "spreadsheetCommandBarButtonItem184";
            // 
            // spreadsheetCommandBarButtonItem185
            // 
            this.spreadsheetCommandBarButtonItem185.CommandName = "SelectEntirePivotTable";
            this.spreadsheetCommandBarButtonItem185.Id = 297;
            this.spreadsheetCommandBarButtonItem185.Name = "spreadsheetCommandBarButtonItem185";
            // 
            // spreadsheetCommandBarButtonItem186
            // 
            this.spreadsheetCommandBarButtonItem186.CommandName = "MovePivotTable";
            this.spreadsheetCommandBarButtonItem186.Id = 298;
            this.spreadsheetCommandBarButtonItem186.Name = "spreadsheetCommandBarButtonItem186";
            // 
            // pivotTableAnalyzeCalculationsRibbonPageGroup1
            // 
            this.pivotTableAnalyzeCalculationsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem35);
            this.pivotTableAnalyzeCalculationsRibbonPageGroup1.Name = "pivotTableAnalyzeCalculationsRibbonPageGroup1";
            // 
            // spreadsheetCommandBarSubItem35
            // 
            this.spreadsheetCommandBarSubItem35.CommandName = "PivotTableCalculationFieldsItemsSetsGroup";
            this.spreadsheetCommandBarSubItem35.Id = 299;
            this.spreadsheetCommandBarSubItem35.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem187),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem188),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem189),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem190)});
            this.spreadsheetCommandBarSubItem35.Name = "spreadsheetCommandBarSubItem35";
            // 
            // spreadsheetCommandBarButtonItem187
            // 
            this.spreadsheetCommandBarButtonItem187.CommandName = "PivotTableCalculatedField";
            this.spreadsheetCommandBarButtonItem187.Id = 300;
            this.spreadsheetCommandBarButtonItem187.Name = "spreadsheetCommandBarButtonItem187";
            // 
            // spreadsheetCommandBarButtonItem188
            // 
            this.spreadsheetCommandBarButtonItem188.CommandName = "PivotTableCalculatedItem";
            this.spreadsheetCommandBarButtonItem188.Id = 301;
            this.spreadsheetCommandBarButtonItem188.Name = "spreadsheetCommandBarButtonItem188";
            // 
            // spreadsheetCommandBarButtonItem189
            // 
            this.spreadsheetCommandBarButtonItem189.CommandName = "PivotTableCalculatedItemSolveOrder";
            this.spreadsheetCommandBarButtonItem189.Id = 302;
            this.spreadsheetCommandBarButtonItem189.Name = "spreadsheetCommandBarButtonItem189";
            // 
            // spreadsheetCommandBarButtonItem190
            // 
            this.spreadsheetCommandBarButtonItem190.CommandName = "PivotTableListFormulas";
            this.spreadsheetCommandBarButtonItem190.Id = 303;
            this.spreadsheetCommandBarButtonItem190.Name = "spreadsheetCommandBarButtonItem190";
            // 
            // pivotTableAnalyzeShowRibbonPageGroup1
            // 
            this.pivotTableAnalyzeShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem34);
            this.pivotTableAnalyzeShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem35);
            this.pivotTableAnalyzeShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem36);
            this.pivotTableAnalyzeShowRibbonPageGroup1.Name = "pivotTableAnalyzeShowRibbonPageGroup1";
            // 
            // spreadsheetCommandBarCheckItem34
            // 
            this.spreadsheetCommandBarCheckItem34.CommandName = "FieldListPanelPivotTable";
            this.spreadsheetCommandBarCheckItem34.Id = 304;
            this.spreadsheetCommandBarCheckItem34.Name = "spreadsheetCommandBarCheckItem34";
            // 
            // spreadsheetCommandBarCheckItem35
            // 
            this.spreadsheetCommandBarCheckItem35.CommandName = "ShowPivotTableExpandCollapseButtons";
            this.spreadsheetCommandBarCheckItem35.Id = 305;
            this.spreadsheetCommandBarCheckItem35.Name = "spreadsheetCommandBarCheckItem35";
            // 
            // spreadsheetCommandBarCheckItem36
            // 
            this.spreadsheetCommandBarCheckItem36.CommandName = "ShowPivotTableFieldHeaders";
            this.spreadsheetCommandBarCheckItem36.Id = 306;
            this.spreadsheetCommandBarCheckItem36.Name = "spreadsheetCommandBarCheckItem36";
            // 
            // pivotTableDesignLayoutRibbonPageGroup1
            // 
            this.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem36);
            this.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem37);
            this.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem38);
            this.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem39);
            this.pivotTableDesignLayoutRibbonPageGroup1.Name = "pivotTableDesignLayoutRibbonPageGroup1";
            // 
            // pivotTableDesignRibbonPage1
            // 
            this.pivotTableDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pivotTableDesignLayoutRibbonPageGroup1,
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1,
            this.pivotTableDesignPivotTableStylesRibbonPageGroup1});
            this.pivotTableDesignRibbonPage1.Name = "pivotTableDesignRibbonPage1";
            this.pivotTableDesignRibbonPage1.Visible = false;
            // 
            // spreadsheetCommandBarSubItem36
            // 
            this.spreadsheetCommandBarSubItem36.CommandName = "PivotTableLayoutSubtotalsGroup";
            this.spreadsheetCommandBarSubItem36.Id = 307;
            this.spreadsheetCommandBarSubItem36.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem191),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem192),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem193)});
            this.spreadsheetCommandBarSubItem36.Name = "spreadsheetCommandBarSubItem36";
            // 
            // spreadsheetCommandBarButtonItem191
            // 
            this.spreadsheetCommandBarButtonItem191.CommandName = "PivotTableDoNotShowSubtotals";
            this.spreadsheetCommandBarButtonItem191.Id = 308;
            this.spreadsheetCommandBarButtonItem191.Name = "spreadsheetCommandBarButtonItem191";
            this.spreadsheetCommandBarButtonItem191.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem192
            // 
            this.spreadsheetCommandBarButtonItem192.CommandName = "PivotTableShowAllSubtotalsAtBottom";
            this.spreadsheetCommandBarButtonItem192.Id = 309;
            this.spreadsheetCommandBarButtonItem192.Name = "spreadsheetCommandBarButtonItem192";
            this.spreadsheetCommandBarButtonItem192.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem193
            // 
            this.spreadsheetCommandBarButtonItem193.CommandName = "PivotTableShowAllSubtotalsAtTop";
            this.spreadsheetCommandBarButtonItem193.Id = 310;
            this.spreadsheetCommandBarButtonItem193.Name = "spreadsheetCommandBarButtonItem193";
            this.spreadsheetCommandBarButtonItem193.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem37
            // 
            this.spreadsheetCommandBarSubItem37.CommandName = "PivotTableLayoutGrandTotalsGroup";
            this.spreadsheetCommandBarSubItem37.Id = 311;
            this.spreadsheetCommandBarSubItem37.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem194),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem195),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem196),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem197)});
            this.spreadsheetCommandBarSubItem37.Name = "spreadsheetCommandBarSubItem37";
            // 
            // spreadsheetCommandBarButtonItem194
            // 
            this.spreadsheetCommandBarButtonItem194.CommandName = "PivotTableGrandTotalsOffRowsColumns";
            this.spreadsheetCommandBarButtonItem194.Id = 312;
            this.spreadsheetCommandBarButtonItem194.Name = "spreadsheetCommandBarButtonItem194";
            this.spreadsheetCommandBarButtonItem194.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem195
            // 
            this.spreadsheetCommandBarButtonItem195.CommandName = "PivotTableGrandTotalsOnRowsColumns";
            this.spreadsheetCommandBarButtonItem195.Id = 313;
            this.spreadsheetCommandBarButtonItem195.Name = "spreadsheetCommandBarButtonItem195";
            this.spreadsheetCommandBarButtonItem195.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem196
            // 
            this.spreadsheetCommandBarButtonItem196.CommandName = "PivotTableGrandTotalsOnRowsOnly";
            this.spreadsheetCommandBarButtonItem196.Id = 314;
            this.spreadsheetCommandBarButtonItem196.Name = "spreadsheetCommandBarButtonItem196";
            this.spreadsheetCommandBarButtonItem196.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem197
            // 
            this.spreadsheetCommandBarButtonItem197.CommandName = "PivotTableGrandTotalsOnColumnsOnly";
            this.spreadsheetCommandBarButtonItem197.Id = 315;
            this.spreadsheetCommandBarButtonItem197.Name = "spreadsheetCommandBarButtonItem197";
            this.spreadsheetCommandBarButtonItem197.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem38
            // 
            this.spreadsheetCommandBarSubItem38.CommandName = "PivotTableLayoutReportLayoutGroup";
            this.spreadsheetCommandBarSubItem38.Id = 316;
            this.spreadsheetCommandBarSubItem38.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem198),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem199),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem200),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem201),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem202)});
            this.spreadsheetCommandBarSubItem38.Name = "spreadsheetCommandBarSubItem38";
            // 
            // spreadsheetCommandBarButtonItem198
            // 
            this.spreadsheetCommandBarButtonItem198.CommandName = "PivotTableShowCompactForm";
            this.spreadsheetCommandBarButtonItem198.Id = 317;
            this.spreadsheetCommandBarButtonItem198.Name = "spreadsheetCommandBarButtonItem198";
            this.spreadsheetCommandBarButtonItem198.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem199
            // 
            this.spreadsheetCommandBarButtonItem199.CommandName = "PivotTableShowOutlineForm";
            this.spreadsheetCommandBarButtonItem199.Id = 318;
            this.spreadsheetCommandBarButtonItem199.Name = "spreadsheetCommandBarButtonItem199";
            this.spreadsheetCommandBarButtonItem199.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem200
            // 
            this.spreadsheetCommandBarButtonItem200.CommandName = "PivotTableShowTabularForm";
            this.spreadsheetCommandBarButtonItem200.Id = 319;
            this.spreadsheetCommandBarButtonItem200.Name = "spreadsheetCommandBarButtonItem200";
            this.spreadsheetCommandBarButtonItem200.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem201
            // 
            this.spreadsheetCommandBarButtonItem201.CommandName = "PivotTableRepeatAllItemLabels";
            this.spreadsheetCommandBarButtonItem201.Id = 320;
            this.spreadsheetCommandBarButtonItem201.Name = "spreadsheetCommandBarButtonItem201";
            this.spreadsheetCommandBarButtonItem201.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem202
            // 
            this.spreadsheetCommandBarButtonItem202.CommandName = "PivotTableDoNotRepeatItemLabels";
            this.spreadsheetCommandBarButtonItem202.Id = 321;
            this.spreadsheetCommandBarButtonItem202.Name = "spreadsheetCommandBarButtonItem202";
            this.spreadsheetCommandBarButtonItem202.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem39
            // 
            this.spreadsheetCommandBarSubItem39.CommandName = "PivotTableLayoutBlankRowsGroup";
            this.spreadsheetCommandBarSubItem39.Id = 322;
            this.spreadsheetCommandBarSubItem39.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem203),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem204)});
            this.spreadsheetCommandBarSubItem39.Name = "spreadsheetCommandBarSubItem39";
            // 
            // spreadsheetCommandBarButtonItem203
            // 
            this.spreadsheetCommandBarButtonItem203.CommandName = "PivotTableInsertBlankLineEachItem";
            this.spreadsheetCommandBarButtonItem203.Id = 323;
            this.spreadsheetCommandBarButtonItem203.Name = "spreadsheetCommandBarButtonItem203";
            this.spreadsheetCommandBarButtonItem203.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem204
            // 
            this.spreadsheetCommandBarButtonItem204.CommandName = "PivotTableRemoveBlankLineEachItem";
            this.spreadsheetCommandBarButtonItem204.Id = 324;
            this.spreadsheetCommandBarButtonItem204.Name = "spreadsheetCommandBarButtonItem204";
            this.spreadsheetCommandBarButtonItem204.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1
            // 
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem37);
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem38);
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem39);
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem40);
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.Name = "pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1";
            // 
            // spreadsheetCommandBarCheckItem37
            // 
            this.spreadsheetCommandBarCheckItem37.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem37.CommandName = "PivotTableToggleRowHeaders";
            this.spreadsheetCommandBarCheckItem37.Id = 325;
            this.spreadsheetCommandBarCheckItem37.Name = "spreadsheetCommandBarCheckItem37";
            // 
            // spreadsheetCommandBarCheckItem38
            // 
            this.spreadsheetCommandBarCheckItem38.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem38.CommandName = "PivotTableToggleColumnHeaders";
            this.spreadsheetCommandBarCheckItem38.Id = 326;
            this.spreadsheetCommandBarCheckItem38.Name = "spreadsheetCommandBarCheckItem38";
            // 
            // spreadsheetCommandBarCheckItem39
            // 
            this.spreadsheetCommandBarCheckItem39.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem39.CommandName = "PivotTableToggleBandedRows";
            this.spreadsheetCommandBarCheckItem39.Id = 327;
            this.spreadsheetCommandBarCheckItem39.Name = "spreadsheetCommandBarCheckItem39";
            // 
            // spreadsheetCommandBarCheckItem40
            // 
            this.spreadsheetCommandBarCheckItem40.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem40.CommandName = "PivotTableToggleBandedColumns";
            this.spreadsheetCommandBarCheckItem40.Id = 328;
            this.spreadsheetCommandBarCheckItem40.Name = "spreadsheetCommandBarCheckItem40";
            // 
            // pivotTableDesignPivotTableStylesRibbonPageGroup1
            // 
            this.pivotTableDesignPivotTableStylesRibbonPageGroup1.ItemLinks.Add(this.galleryPivotStylesItem1);
            this.pivotTableDesignPivotTableStylesRibbonPageGroup1.Name = "pivotTableDesignPivotTableStylesRibbonPageGroup1";
            // 
            // galleryPivotStylesItem1
            // 
            // 
            // 
            // 
            this.galleryPivotStylesItem1.Gallery.ColumnCount = 7;
            this.galleryPivotStylesItem1.Gallery.DrawImageBackground = false;
            this.galleryPivotStylesItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryPivotStylesItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.galleryPivotStylesItem1.Gallery.ItemSize = new System.Drawing.Size(73, 61);
            this.galleryPivotStylesItem1.Gallery.RowCount = 10;
            this.galleryPivotStylesItem1.Id = 329;
            this.galleryPivotStylesItem1.Name = "galleryPivotStylesItem1";
            // 
            // InvoiceWithTotalModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "InvoiceWithTotalModule";
            this.Size = new System.Drawing.Size(696, 478);
            this.Load += new System.EventHandler(this.On_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromFaxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromPhoneEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromZipEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromStateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromCityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromAddressEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromCompanySloganEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromCompanyEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toCompanyNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toPhoneEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toZipEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toStateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toCityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toStreetEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTabControl)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.invoiceTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetNameBoxControl1.Properties)).EndInit();
            this.dataTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toGroupControl)).EndInit();
            this.toGroupControl.ResumeLayout(false);
            this.toGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromGroupControl)).EndInit();
            this.fromGroupControl.ResumeLayout(false);
            this.fromGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromContactNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromEMailEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.includeItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpreadsheetFontSizeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraEditors.Repository.RepositoryItemCheckEdit includeItemCheckEdit;
        private GroupControl toGroupControl;
        private GroupControl fromGroupControl;
        private XtraGrid.Columns.GridColumn colQuantity;
        private XtraGrid.Columns.GridColumn colDiscount;
        private LabelControl fromContactNameLabel;
        private TextEdit fromContactNameEdit;
        private LabelControl fromEMailLabel;
        private TextEdit fromEMailEdit;
        private SplitterControl splitterControl1;
        private SplitContainerControl splitContainerControl1;
        private SpreadsheetNameBoxControl spreadsheetNameBoxControl1;
        private SpreadsheetFormulaBarControl spreadsheetFormulaBarControl1;
        private UI.SpreadsheetBarController spreadsheetBarController1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown2;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown3;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown4;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown5;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown6;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown7;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown8;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown9;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown10;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown11;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown12;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown13;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown14;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown15;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown16;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown17;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown18;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown19;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown20;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown21;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown22;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown23;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown24;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem107;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem108;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem109;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem110;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem111;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown25;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown26;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown27;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown28;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown29;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown30;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown31;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown32;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown33;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown34;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown35;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown36;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown37;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown38;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown39;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown40;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown41;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown42;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown43;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown44;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown45;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown46;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown47;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown48;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem119;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem120;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem121;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem122;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem123;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem2;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem3;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem4;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem5;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem6;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem7;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem8;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem9;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem10;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem11;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem12;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem13;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem14;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem15;
        private XtraBars.BarButtonGroup barButtonGroup1;
        private UI.ChangeFontNameItem changeFontNameItem1;
        private XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private UI.ChangeFontSizeItem changeFontSizeItem1;
        private Design.RepositoryItemSpreadsheetFontSizeEdit repositoryItemSpreadsheetFontSizeEdit1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem16;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem17;
        private XtraBars.BarButtonGroup barButtonGroup2;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem1;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem2;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem3;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem4;
        private XtraBars.BarButtonGroup barButtonGroup3;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem18;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem19;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem20;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem21;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem22;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem23;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem24;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem25;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem26;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem27;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem28;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem29;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem30;
        private UI.ChangeBorderLineColorItem changeBorderLineColorItem1;
        private UI.ChangeBorderLineStyleItem changeBorderLineStyleItem1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown49;
        private XtraBars.BarButtonGroup barButtonGroup4;
        private UI.ChangeCellFillColorItem changeCellFillColorItem1;
        private UI.ChangeFontColorItem changeFontColorItem1;
        private XtraBars.BarButtonGroup barButtonGroup5;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem5;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem6;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem7;
        private XtraBars.BarButtonGroup barButtonGroup6;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem8;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem9;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem10;
        private XtraBars.BarButtonGroup barButtonGroup7;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem31;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem32;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem11;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem2;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem12;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem33;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem34;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem35;
        private XtraBars.BarButtonGroup barButtonGroup8;
        private UI.ChangeNumberFormatItem changeNumberFormatItem1;
        private XtraEditors.Repository.RepositoryItemPopupGalleryEdit repositoryItemPopupGalleryEdit1;
        private XtraBars.BarButtonGroup barButtonGroup9;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem3;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem36;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem37;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem38;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem39;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem40;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem41;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem42;
        private XtraBars.BarButtonGroup barButtonGroup10;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem43;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem44;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem4;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem5;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem45;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem46;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem47;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem48;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem49;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem50;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem51;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem6;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem52;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem53;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem54;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem55;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem56;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem57;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown50;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem2;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown51;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem3;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown52;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem58;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem7;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem59;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem60;
        private UI.GalleryFormatAsTableItem galleryFormatAsTableItem1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown53;
        private UI.GalleryChangeStyleItem galleryChangeStyleItem1;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem8;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem61;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem62;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem63;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem9;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem64;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem65;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem66;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem10;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem67;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem68;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem69;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem70;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem71;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem11;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem72;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem73;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem74;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem75;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem76;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem77;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem78;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem79;
        private UI.ChangeSheetTabColorItem changeSheetTabColorItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem80;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem13;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem81;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem12;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem82;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem83;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem84;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem85;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem86;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem13;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem87;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem88;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem89;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem90;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem14;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem91;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem92;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem93;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem94;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem95;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem96;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem15;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem97;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem98;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem14;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem99;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem100;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem16;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem101;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem102;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem103;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem104;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem105;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem106;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem112;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem113;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem114;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem115;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem4;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown54;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem5;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown55;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem6;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown56;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem7;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown57;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem8;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown58;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem9;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown59;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem10;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown60;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem116;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem117;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem17;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem15;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem16;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem17;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem118;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem18;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem18;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem19;
        private UI.PageSetupPaperKindItem pageSetupPaperKindItem1;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem19;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem124;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem125;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem126;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem127;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem20;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem21;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem22;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem23;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem20;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem128;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem129;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem21;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem130;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem131;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem22;
        private UI.FunctionsFinancialItem functionsFinancialItem1;
        private UI.FunctionsLogicalItem functionsLogicalItem1;
        private UI.FunctionsTextItem functionsTextItem1;
        private UI.FunctionsDateAndTimeItem functionsDateAndTimeItem1;
        private UI.FunctionsLookupAndReferenceItem functionsLookupAndReferenceItem1;
        private UI.FunctionsMathAndTrigonometryItem functionsMathAndTrigonometryItem1;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem23;
        private UI.FunctionsStatisticalItem functionsStatisticalItem1;
        private UI.FunctionsEngineeringItem functionsEngineeringItem1;
        private UI.FunctionsInformationItem functionsInformationItem1;
        private UI.FunctionsCompatibilityItem functionsCompatibilityItem1;
        private UI.FunctionsWebItem functionsWebItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem137;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem138;
        private UI.DefinedNameListItem definedNameListItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem139;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem24;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem24;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem25;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem26;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem140;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem141;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem25;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem142;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem143;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem144;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem26;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem145;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem146;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem27;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem147;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem148;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem149;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem150;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem151;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem152;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem153;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem154;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem155;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem156;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem157;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem158;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem159;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem160;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem161;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem162;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem163;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem28;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem164;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem165;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem166;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem167;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem168;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem169;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem170;
        private UI.GalleryChartLayoutItem galleryChartLayoutItem1;
        private UI.GalleryChartStyleItem galleryChartStyleItem1;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem29;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem11;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown61;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem12;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown62;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem30;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem13;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown63;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem14;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown64;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem15;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown65;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem31;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem16;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown66;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem17;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown67;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem18;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown68;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem19;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown69;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem20;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown70;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem21;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown71;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem22;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown72;
        private UI.RenameTableItemCaption renameTableItemCaption1;
        private UI.RenameTableItem renameTableItem1;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem27;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem28;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem29;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem30;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem31;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem32;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem33;
        private UI.GalleryTableStylesItem galleryTableStylesItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem171;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem172;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem173;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem174;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem175;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem176;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem177;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem32;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem178;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem179;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem180;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem33;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem181;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem182;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem34;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem183;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem184;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem185;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem186;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem35;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem187;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem188;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem189;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem190;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem34;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem35;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem36;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem36;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem191;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem192;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem193;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem37;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem194;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem195;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem196;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem197;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem38;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem198;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem199;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem200;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem201;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem202;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem39;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem203;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem204;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem37;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem38;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem39;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem40;
        private UI.GalleryPivotStylesItem galleryPivotStylesItem1;
        private UI.ChartToolsRibbonPageCategory chartToolsRibbonPageCategory1;
        private UI.ChartsDesignRibbonPage chartsDesignRibbonPage1;
        private UI.ChartsDesignTypeRibbonPageGroup chartsDesignTypeRibbonPageGroup1;
        private UI.ChartsDesignDataRibbonPageGroup chartsDesignDataRibbonPageGroup1;
        private UI.ChartsDesignLayoutsRibbonPageGroup chartsDesignLayoutsRibbonPageGroup1;
        private UI.ChartsDesignStylesRibbonPageGroup chartsDesignStylesRibbonPageGroup1;
        private UI.ChartsLayoutRibbonPage chartsLayoutRibbonPage1;
        private UI.ChartsLayoutAxesRibbonPageGroup chartsLayoutAxesRibbonPageGroup1;
        private UI.ChartsLayoutLabelsRibbonPageGroup chartsLayoutLabelsRibbonPageGroup1;
        private UI.ChartsLayoutAnalysisRibbonPageGroup chartsLayoutAnalysisRibbonPageGroup1;
        private UI.ChartsFormatRibbonPage chartsFormatRibbonPage1;
        private UI.ChartsFormatArrangeRibbonPageGroup chartsFormatArrangeRibbonPageGroup1;
        private UI.TableToolsRibbonPageCategory tableToolsRibbonPageCategory1;
        private UI.TableToolsDesignRibbonPage tableToolsDesignRibbonPage1;
        private UI.TablePropertiesRibbonPageGroup tablePropertiesRibbonPageGroup1;
        private UI.TableToolsRibbonPageGroup tableToolsRibbonPageGroup1;
        private UI.TableStyleOptionsRibbonPageGroup tableStyleOptionsRibbonPageGroup1;
        private UI.TableStylesRibbonPageGroup tableStylesRibbonPageGroup1;
        private UI.DrawingToolsRibbonPageCategory drawingToolsRibbonPageCategory1;
        private UI.DrawingFormatRibbonPage drawingFormatRibbonPage1;
        private UI.DrawingFormatArrangeRibbonPageGroup drawingFormatArrangeRibbonPageGroup1;
        private UI.PictureToolsRibbonPageCategory pictureToolsRibbonPageCategory1;
        private UI.PictureFormatRibbonPage pictureFormatRibbonPage1;
        private UI.PictureFormatArrangeRibbonPageGroup pictureFormatArrangeRibbonPageGroup1;
        private UI.PivotTableToolsRibbonPageCategory pivotTableToolsRibbonPageCategory1;
        private UI.PivotTableAnalyzeRibbonPage pivotTableAnalyzeRibbonPage1;
        private UI.PivotTableAnalyzePivotTableRibbonPageGroup pivotTableAnalyzePivotTableRibbonPageGroup1;
        private UI.PivotTableAnalyzeActiveFieldRibbonPageGroup pivotTableAnalyzeActiveFieldRibbonPageGroup1;
        private UI.PivotTableAnalyzeGroupRibbonPageGroup pivotTableAnalyzeGroupRibbonPageGroup1;
        private UI.PivotTableAnalyzeDataRibbonPageGroup pivotTableAnalyzeDataRibbonPageGroup1;
        private UI.PivotTableAnalyzeActionsRibbonPageGroup pivotTableAnalyzeActionsRibbonPageGroup1;
        private UI.PivotTableAnalyzeCalculationsRibbonPageGroup pivotTableAnalyzeCalculationsRibbonPageGroup1;
        private UI.PivotTableAnalyzeShowRibbonPageGroup pivotTableAnalyzeShowRibbonPageGroup1;
        private UI.PivotTableDesignRibbonPage pivotTableDesignRibbonPage1;
        private UI.PivotTableDesignLayoutRibbonPageGroup pivotTableDesignLayoutRibbonPageGroup1;
        private UI.PivotTableDesignPivotTableStyleOptionsRibbonPageGroup pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1;
        private UI.PivotTableDesignPivotTableStylesRibbonPageGroup pivotTableDesignPivotTableStylesRibbonPageGroup1;
        private UI.FileRibbonPage fileRibbonPage1;
        private UI.CommonRibbonPageGroup commonRibbonPageGroup1;
        private UI.InfoRibbonPageGroup infoRibbonPageGroup1;
        private UI.HomeRibbonPage homeRibbonPage1;
        private UI.ClipboardRibbonPageGroup clipboardRibbonPageGroup1;
        private UI.FontRibbonPageGroup fontRibbonPageGroup1;
        private UI.AlignmentRibbonPageGroup alignmentRibbonPageGroup1;
        private UI.NumberRibbonPageGroup numberRibbonPageGroup1;
        private UI.StylesRibbonPageGroup stylesRibbonPageGroup1;
        private UI.CellsRibbonPageGroup cellsRibbonPageGroup1;
        private UI.EditingRibbonPageGroup editingRibbonPageGroup1;
        private UI.InsertRibbonPage insertRibbonPage1;
        private UI.TablesRibbonPageGroup tablesRibbonPageGroup1;
        private UI.IllustrationsRibbonPageGroup illustrationsRibbonPageGroup1;
        private UI.ChartsRibbonPageGroup chartsRibbonPageGroup1;
        private UI.LinksRibbonPageGroup linksRibbonPageGroup1;
        private UI.SymbolsRibbonPageGroup symbolsRibbonPageGroup1;
        private UI.PageLayoutRibbonPage pageLayoutRibbonPage1;
        private UI.PageSetupRibbonPageGroup pageSetupRibbonPageGroup1;
        private UI.PageSetupShowRibbonPageGroup pageSetupShowRibbonPageGroup1;
        private UI.PageSetupPrintRibbonPageGroup pageSetupPrintRibbonPageGroup1;
        private UI.ArrangeRibbonPageGroup arrangeRibbonPageGroup1;
        private UI.FormulasRibbonPage formulasRibbonPage1;
        private UI.FunctionLibraryRibbonPageGroup functionLibraryRibbonPageGroup1;
        private UI.FormulaDefinedNamesRibbonPageGroup formulaDefinedNamesRibbonPageGroup1;
        private UI.FormulaAuditingRibbonPageGroup formulaAuditingRibbonPageGroup1;
        private UI.FormulaCalculationRibbonPageGroup formulaCalculationRibbonPageGroup1;
        private UI.DataRibbonPage dataRibbonPage1;
        private UI.SortAndFilterRibbonPageGroup sortAndFilterRibbonPageGroup1;
        private UI.DataToolsRibbonPageGroup dataToolsRibbonPageGroup1;
        private UI.OutlineRibbonPageGroup outlineRibbonPageGroup1;
        private UI.ReviewRibbonPage reviewRibbonPage1;
        private UI.CommentsRibbonPageGroup commentsRibbonPageGroup1;
        private UI.ChangesRibbonPageGroup changesRibbonPageGroup1;
        private UI.ViewRibbonPage viewRibbonPage1;
        private UI.ShowRibbonPageGroup showRibbonPageGroup1;
        private UI.ZoomRibbonPageGroup zoomRibbonPageGroup1;
        private UI.WindowRibbonPageGroup windowRibbonPageGroup1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem132;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem133;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem134;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem135;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem136;
    }
}

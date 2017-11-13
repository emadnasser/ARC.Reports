using System.Globalization;
using System.IO;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraBars.Docking;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class MailMergeModuleBase : SpreadSheetTutorialControlBase {
        private void InitializeComponent() {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailMergeModuleBase));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
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
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem41 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem42 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem43 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem44 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem45 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem46 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem47 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem48 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem49 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem50 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem51 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem52 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem53 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem54 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem55 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem56 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem57 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem58 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem59 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem60 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem61 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem62 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem63 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem64 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem65 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem66 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem67 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem68 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem69 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem70 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem71 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem72 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem73 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem74 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem75 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem76 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem77 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem78 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem79 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem80 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem81 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem82 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem83 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem84 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem85 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem86 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem87 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem88 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem89 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem90 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem91 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem92 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem93 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem94 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem95 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem96 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem97 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem98 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem99 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem100 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem101 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem102 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem103 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem104 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem105 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem106 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem107 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem108 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem109 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem110 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem111 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem112 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem113 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem114 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem115 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem116 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem117 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem118 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem119 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem120 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem121 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem122 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem123 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem124 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem125 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem126 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem127 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem128 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem129 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem130 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem131 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem132 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem133 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem134 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem135 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem136 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem137 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem138 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem139 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem140 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem141 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem142 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem143 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem144 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem145 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem146 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem147 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem148 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem149 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem150 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem151 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem152 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem153 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem154 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem155 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem156 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem157 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem158 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem159 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem160 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem161 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem162 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem163 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem164 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem165 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem166 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem167 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem168 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem169 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem170 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem171 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem172 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem173 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem174 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem175 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem176 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem177 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem178 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem179 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem180 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem181 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem182 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem183 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem184 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            this.stylesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.StylesRibbonPageGroup();
            this.spreadsheetCommandBarSubItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarSubItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem43 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem44 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem45 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem46 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem47 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem48 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem49 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem50 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem51 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem52 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem53 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem54 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem55 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown2 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.hideCommentsCheckItem = new DevExpress.XtraBars.BarCheckItem();
            this.spreadsheetCommandBarButtonItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeFontNameItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeFontNameItem();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.changeFontSizeItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeFontSizeItem();
            this.repositoryItemSpreadsheetFontSizeEdit1 = new DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.spreadsheetCommandBarButtonItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarCheckItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarSubItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
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
            this.changeBorderLineColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeBorderLineColorItem();
            this.changeBorderLineStyleItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeBorderLineStyleItem();
            this.commandBarGalleryDropDown1 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeCellFillColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeCellFillColorItem();
            this.changeFontColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeFontColorItem();
            this.barButtonGroup5 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarCheckItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.barButtonGroup6 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarCheckItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.barButtonGroup7 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarButtonItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarSubItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barButtonGroup8 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeNumberFormatItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeNumberFormatItem();
            this.repositoryItemPopupGalleryEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit();
            this.barButtonGroup9 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarSubItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barButtonGroup10 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarButtonItem41 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem42 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown3 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown4 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonItem56 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem57 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.galleryFormatAsTableItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryFormatAsTableItem();
            this.commandBarGalleryDropDown5 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.galleryChangeStyleItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryChangeStyleItem();
            this.spreadsheetCommandBarSubItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem58 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem59 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem60 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem61 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem62 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem63 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem64 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem65 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem66 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem67 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem68 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem69 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem70 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem71 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem72 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem73 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem74 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem75 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.changeSheetTabColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeSheetTabColorItem();
            this.spreadsheetCommandBarButtonItem76 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem77 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem78 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem79 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem80 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem81 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem82 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem83 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem84 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem85 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem86 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem87 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem88 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem89 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem90 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem91 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem92 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem93 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem94 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem95 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem96 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem97 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem98 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown6 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown7 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown8 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown9 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown10 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown11 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown12 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonItem99 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem100 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarSubItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.pageSetupPaperKindItem1 = new DevExpress.XtraSpreadsheet.UI.PageSetupPaperKindItem();
            this.spreadsheetCommandBarSubItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem101 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem102 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarSubItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem103 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem104 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem105 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem106 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
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
            this.spreadsheetCommandBarButtonItem112 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem113 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.definedNameListItem1 = new DevExpress.XtraSpreadsheet.UI.DefinedNameListItem();
            this.spreadsheetCommandBarButtonItem114 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarSubItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem115 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem116 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem117 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem118 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem119 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem120 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem121 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem122 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem123 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem124 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem125 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem126 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem127 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem128 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem129 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem130 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.galleryChartLayoutItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryChartLayoutItem();
            this.galleryChartStyleItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryChartStyleItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown13 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarSubItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown14 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown15 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown16 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown17 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarSubItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown18 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown19 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarSubItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown20 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown21 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown22 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown23 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown24 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.renameTableItem1 = new DevExpress.XtraSpreadsheet.UI.RenameTableItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.spreadsheetCommandBarCheckItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.galleryTableStylesItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryTableStylesItem();
            this.spreadsheetCommandBarCheckItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarSubItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem131 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem132 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem133 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem134 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem135 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem136 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem137 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem138 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem139 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem140 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem141 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem142 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem143 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem144 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem145 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem146 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem147 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem148 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem149 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barButtonGroup11 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup12 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup13 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup14 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup15 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup16 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup17 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup18 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup19 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup20 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarCheckItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem150 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem151 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem152 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem153 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem154 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem155 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem156 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem157 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem158 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem159 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem160 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem161 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem162 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.chartToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.ChartToolsRibbonPageCategory();
            this.chartsDesignRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignRibbonPage();
            this.chartsDesignTypeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignTypeRibbonPageGroup();
            this.chartsDesignDataRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignDataRibbonPageGroup();
            this.chartsDesignLayoutsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignLayoutsRibbonPageGroup();
            this.chartsDesignStylesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignStylesRibbonPageGroup();
            this.chartsLayoutRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ChartsLayoutRibbonPage();
            this.chartsLayoutLabelsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsLayoutLabelsRibbonPageGroup();
            this.chartsLayoutAxesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsLayoutAxesRibbonPageGroup();
            this.chartsLayoutAnalysisRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsLayoutAnalysisRibbonPageGroup();
            this.chartsFormatRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ChartsFormatRibbonPage();
            this.chartsFormatArrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsFormatArrangeRibbonPageGroup();
            this.tableToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageCategory();
            this.tableToolsDesignRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.TableToolsDesignRibbonPage();
            this.tablePropertiesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TablePropertiesRibbonPageGroup();
            this.tableToolsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageGroup();
            this.tableStyleOptionsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TableStyleOptionsRibbonPageGroup();
            this.tableStylesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TableStylesRibbonPageGroup();
            this.pictureToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.PictureToolsRibbonPageCategory();
            this.pictureFormatRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.PictureFormatRibbonPage();
            this.pictureFormatArrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PictureFormatArrangeRibbonPageGroup();
            this.drawingToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.DrawingToolsRibbonPageCategory();
            this.drawingFormatRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.DrawingFormatRibbonPage();
            this.drawingFormatArrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.DrawingFormatArrangeRibbonPageGroup();
            this.fileRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.FileRibbonPage();
            this.commonRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup();
            this.infoRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup();
            this.homeRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.HomeRibbonPage();
            this.clipboardRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup();
            this.fontRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup();
            this.alignmentRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.AlignmentRibbonPageGroup();
            this.numberRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.NumberRibbonPageGroup();
            this.cellsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.CellsRibbonPageGroup();
            this.editingRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup();
            this.insertRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.InsertRibbonPage();
            this.tablesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TablesRibbonPageGroup();
            this.illustrationsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.IllustrationsRibbonPageGroup();
            this.chartsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsRibbonPageGroup();
            this.linksRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.LinksRibbonPageGroup();
            this.symbolsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.SymbolsRibbonPageGroup();
            this.pageLayoutRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.PageLayoutRibbonPage();
            this.pageSetupRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PageSetupRibbonPageGroup();
            this.pageSetupShowRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PageSetupShowRibbonPageGroup();
            this.pageSetupPrintRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PageSetupPrintRibbonPageGroup();
            this.arrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ArrangeRibbonPageGroup();
            this.formulasRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.FormulasRibbonPage();
            this.functionLibraryRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FunctionLibraryRibbonPageGroup();
            this.formulaDefinedNamesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FormulaDefinedNamesRibbonPageGroup();
            this.formulaAuditingRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FormulaAuditingRibbonPageGroup();
            this.formulaCalculationRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FormulaCalculationRibbonPageGroup();
            this.dataRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.DataRibbonPage();
            this.sortAndFilterRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.SortAndFilterRibbonPageGroup();
            this.outlineRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.OutlineRibbonPageGroup();
            this.mailMergeRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.MailMergeRibbonPage();
            this.mailMergeDataRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.MailMergeDataRibbonPageGroup();
            this.mailMergeModeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.MailMergeModeRibbonPageGroup();
            this.mailMergeExtendedRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.MailMergeExtendedRibbonPageGroup();
            this.mailMergeGroupingRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.MailMergeGroupingRibbonPageGroup();
            this.mailMergeFilteringRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.MailMergeFilteringRibbonPageGroup();
            this.mailMergeBindingRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.MailMergeBindingRibbonPageGroup();
            this.ribbonPageDemoGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.reviewRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ReviewRibbonPage();
            this.commentsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.CommentsRibbonPageGroup();
            this.changesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChangesRibbonPageGroup();
            this.viewRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ViewRibbonPage();
            this.showRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ShowRibbonPageGroup();
            this.zoomRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ZoomRibbonPageGroup();
            this.windowRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.WindowRibbonPageGroup();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.spreadsheetNameBoxControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl();
            this.spreadsheetFormulaBarControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl();
            this.spreadsheetBarController1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController();
            this.spreadsheetCommandBarButtonItem107 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem108 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem109 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem110 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem111 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetDockManager1 = new DevExpress.XtraSpreadsheet.SpreadsheetDockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.fieldListDockPanel1 = new DevExpress.XtraSpreadsheet.FieldListDockPanel();
            this.fieldListDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.mailMergeParametersDockPanel = new DevExpress.XtraSpreadsheet.MailMergeParametersDockPanel();
            this.mailMergeParametersDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.filteringDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.checkEdit0 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpreadsheetFontSizeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit1)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetNameBoxControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetDockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.fieldListDockPanel1.SuspendLayout();
            this.mailMergeParametersDockPanel.SuspendLayout();
            this.filteringDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit0.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.spreadsheetCommandBarSubItem4.Id = 367;
            this.spreadsheetCommandBarSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem7)});
            this.spreadsheetCommandBarSubItem4.Name = "spreadsheetCommandBarSubItem4";
            // 
            // spreadsheetCommandBarSubItem5
            // 
            this.spreadsheetCommandBarSubItem5.CommandName = "ConditionalFormattingHighlightCellsRuleCommandGroup";
            this.spreadsheetCommandBarSubItem5.Id = 375;
            this.spreadsheetCommandBarSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem43),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem44),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem45),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem46),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem47),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem48),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem49)});
            this.spreadsheetCommandBarSubItem5.Name = "spreadsheetCommandBarSubItem5";
            // 
            // spreadsheetCommandBarButtonItem43
            // 
            this.spreadsheetCommandBarButtonItem43.CommandName = "ConditionalFormattingGreaterThanRuleCommand";
            this.spreadsheetCommandBarButtonItem43.Id = 368;
            this.spreadsheetCommandBarButtonItem43.Name = "spreadsheetCommandBarButtonItem43";
            this.spreadsheetCommandBarButtonItem43.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem44
            // 
            this.spreadsheetCommandBarButtonItem44.CommandName = "ConditionalFormattingLessThanRuleCommand";
            this.spreadsheetCommandBarButtonItem44.Id = 369;
            this.spreadsheetCommandBarButtonItem44.Name = "spreadsheetCommandBarButtonItem44";
            this.spreadsheetCommandBarButtonItem44.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem45
            // 
            this.spreadsheetCommandBarButtonItem45.CommandName = "ConditionalFormattingBetweenRuleCommand";
            this.spreadsheetCommandBarButtonItem45.Id = 370;
            this.spreadsheetCommandBarButtonItem45.Name = "spreadsheetCommandBarButtonItem45";
            this.spreadsheetCommandBarButtonItem45.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem46
            // 
            this.spreadsheetCommandBarButtonItem46.CommandName = "ConditionalFormattingEqualToRuleCommand";
            this.spreadsheetCommandBarButtonItem46.Id = 371;
            this.spreadsheetCommandBarButtonItem46.Name = "spreadsheetCommandBarButtonItem46";
            this.spreadsheetCommandBarButtonItem46.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem47
            // 
            this.spreadsheetCommandBarButtonItem47.CommandName = "ConditionalFormattingTextContainsRuleCommand";
            this.spreadsheetCommandBarButtonItem47.Id = 372;
            this.spreadsheetCommandBarButtonItem47.Name = "spreadsheetCommandBarButtonItem47";
            this.spreadsheetCommandBarButtonItem47.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem48
            // 
            this.spreadsheetCommandBarButtonItem48.CommandName = "ConditionalFormattingDateOccurringRuleCommand";
            this.spreadsheetCommandBarButtonItem48.Id = 373;
            this.spreadsheetCommandBarButtonItem48.Name = "spreadsheetCommandBarButtonItem48";
            this.spreadsheetCommandBarButtonItem48.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem49
            // 
            this.spreadsheetCommandBarButtonItem49.CommandName = "ConditionalFormattingDuplicateValuesRuleCommand";
            this.spreadsheetCommandBarButtonItem49.Id = 374;
            this.spreadsheetCommandBarButtonItem49.Name = "spreadsheetCommandBarButtonItem49";
            this.spreadsheetCommandBarButtonItem49.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem6
            // 
            this.spreadsheetCommandBarSubItem6.CommandName = "ConditionalFormattingTopBottomRuleCommandGroup";
            this.spreadsheetCommandBarSubItem6.Id = 382;
            this.spreadsheetCommandBarSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem50),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem51),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem52),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem53),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem54),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem55)});
            this.spreadsheetCommandBarSubItem6.Name = "spreadsheetCommandBarSubItem6";
            // 
            // spreadsheetCommandBarButtonItem50
            // 
            this.spreadsheetCommandBarButtonItem50.CommandName = "ConditionalFormattingTop10RuleCommand";
            this.spreadsheetCommandBarButtonItem50.Id = 376;
            this.spreadsheetCommandBarButtonItem50.Name = "spreadsheetCommandBarButtonItem50";
            this.spreadsheetCommandBarButtonItem50.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem51
            // 
            this.spreadsheetCommandBarButtonItem51.CommandName = "ConditionalFormattingTop10PercentRuleCommand";
            this.spreadsheetCommandBarButtonItem51.Id = 377;
            this.spreadsheetCommandBarButtonItem51.Name = "spreadsheetCommandBarButtonItem51";
            this.spreadsheetCommandBarButtonItem51.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem52
            // 
            this.spreadsheetCommandBarButtonItem52.CommandName = "ConditionalFormattingBottom10RuleCommand";
            this.spreadsheetCommandBarButtonItem52.Id = 378;
            this.spreadsheetCommandBarButtonItem52.Name = "spreadsheetCommandBarButtonItem52";
            this.spreadsheetCommandBarButtonItem52.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem53
            // 
            this.spreadsheetCommandBarButtonItem53.CommandName = "ConditionalFormattingBottom10PercentRuleCommand";
            this.spreadsheetCommandBarButtonItem53.Id = 379;
            this.spreadsheetCommandBarButtonItem53.Name = "spreadsheetCommandBarButtonItem53";
            this.spreadsheetCommandBarButtonItem53.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem54
            // 
            this.spreadsheetCommandBarButtonItem54.CommandName = "ConditionalFormattingAboveAverageRuleCommand";
            this.spreadsheetCommandBarButtonItem54.Id = 380;
            this.spreadsheetCommandBarButtonItem54.Name = "spreadsheetCommandBarButtonItem54";
            this.spreadsheetCommandBarButtonItem54.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem55
            // 
            this.spreadsheetCommandBarButtonItem55.CommandName = "ConditionalFormattingBelowAverageRuleCommand";
            this.spreadsheetCommandBarButtonItem55.Id = 381;
            this.spreadsheetCommandBarButtonItem55.Name = "spreadsheetCommandBarButtonItem55";
            this.spreadsheetCommandBarButtonItem55.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem1
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.CommandName = "ConditionalFormattingDataBarsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.DropDownControl = this.commandBarGalleryDropDown2;
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.Id = 383;
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.Name = "spreadsheetCommandBarButtonGalleryDropDownItem1";
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // commandBarGalleryDropDown2
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown2.Gallery.AllowFilter = false;
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
            this.commandBarGalleryDropDown2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup1,
            spreadsheetCommandGalleryItemGroup2});
            this.commandBarGalleryDropDown2.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2";
            this.commandBarGalleryDropDown2.Ribbon = this.ribbonControl1;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.hideCommentsCheckItem,
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
            this.barButtonGroup1,
            this.changeFontNameItem1,
            this.changeFontSizeItem1,
            this.spreadsheetCommandBarButtonItem14,
            this.spreadsheetCommandBarButtonItem15,
            this.barButtonGroup2,
            this.spreadsheetCommandBarCheckItem1,
            this.spreadsheetCommandBarCheckItem2,
            this.spreadsheetCommandBarCheckItem3,
            this.spreadsheetCommandBarCheckItem4,
            this.barButtonGroup3,
            this.spreadsheetCommandBarSubItem1,
            this.spreadsheetCommandBarButtonItem16,
            this.spreadsheetCommandBarButtonItem17,
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
            this.spreadsheetCommandBarButtonItem29,
            this.spreadsheetCommandBarButtonItem30,
            this.spreadsheetCommandBarCheckItem11,
            this.spreadsheetCommandBarSubItem2,
            this.spreadsheetCommandBarCheckItem12,
            this.spreadsheetCommandBarButtonItem31,
            this.spreadsheetCommandBarButtonItem32,
            this.spreadsheetCommandBarButtonItem33,
            this.barButtonGroup8,
            this.changeNumberFormatItem1,
            this.barButtonGroup9,
            this.spreadsheetCommandBarSubItem3,
            this.spreadsheetCommandBarButtonItem34,
            this.spreadsheetCommandBarButtonItem35,
            this.spreadsheetCommandBarButtonItem36,
            this.spreadsheetCommandBarButtonItem37,
            this.spreadsheetCommandBarButtonItem38,
            this.spreadsheetCommandBarButtonItem39,
            this.spreadsheetCommandBarButtonItem40,
            this.barButtonGroup10,
            this.spreadsheetCommandBarButtonItem41,
            this.spreadsheetCommandBarButtonItem42,
            this.spreadsheetCommandBarSubItem4,
            this.spreadsheetCommandBarButtonItem43,
            this.spreadsheetCommandBarButtonItem44,
            this.spreadsheetCommandBarButtonItem45,
            this.spreadsheetCommandBarButtonItem46,
            this.spreadsheetCommandBarButtonItem47,
            this.spreadsheetCommandBarButtonItem48,
            this.spreadsheetCommandBarButtonItem49,
            this.spreadsheetCommandBarSubItem5,
            this.spreadsheetCommandBarButtonItem50,
            this.spreadsheetCommandBarButtonItem51,
            this.spreadsheetCommandBarButtonItem52,
            this.spreadsheetCommandBarButtonItem53,
            this.spreadsheetCommandBarButtonItem54,
            this.spreadsheetCommandBarButtonItem55,
            this.spreadsheetCommandBarSubItem6,
            this.spreadsheetCommandBarButtonGalleryDropDownItem1,
            this.spreadsheetCommandBarButtonGalleryDropDownItem2,
            this.spreadsheetCommandBarButtonGalleryDropDownItem3,
            this.spreadsheetCommandBarButtonItem56,
            this.spreadsheetCommandBarButtonItem57,
            this.spreadsheetCommandBarSubItem7,
            this.galleryFormatAsTableItem1,
            this.galleryChangeStyleItem1,
            this.spreadsheetCommandBarSubItem8,
            this.spreadsheetCommandBarButtonItem58,
            this.spreadsheetCommandBarButtonItem59,
            this.spreadsheetCommandBarButtonItem60,
            this.spreadsheetCommandBarSubItem9,
            this.spreadsheetCommandBarButtonItem61,
            this.spreadsheetCommandBarButtonItem62,
            this.spreadsheetCommandBarButtonItem63,
            this.spreadsheetCommandBarSubItem10,
            this.spreadsheetCommandBarButtonItem64,
            this.spreadsheetCommandBarButtonItem65,
            this.spreadsheetCommandBarButtonItem66,
            this.spreadsheetCommandBarButtonItem67,
            this.spreadsheetCommandBarButtonItem68,
            this.spreadsheetCommandBarButtonItem69,
            this.spreadsheetCommandBarButtonItem70,
            this.spreadsheetCommandBarButtonItem71,
            this.spreadsheetCommandBarButtonItem72,
            this.spreadsheetCommandBarButtonItem73,
            this.spreadsheetCommandBarButtonItem74,
            this.spreadsheetCommandBarSubItem11,
            this.spreadsheetCommandBarButtonItem75,
            this.changeSheetTabColorItem1,
            this.spreadsheetCommandBarButtonItem76,
            this.spreadsheetCommandBarCheckItem13,
            this.spreadsheetCommandBarButtonItem77,
            this.spreadsheetCommandBarSubItem12,
            this.spreadsheetCommandBarButtonItem78,
            this.spreadsheetCommandBarButtonItem79,
            this.spreadsheetCommandBarButtonItem80,
            this.spreadsheetCommandBarButtonItem81,
            this.spreadsheetCommandBarButtonItem82,
            this.spreadsheetCommandBarSubItem13,
            this.spreadsheetCommandBarButtonItem83,
            this.spreadsheetCommandBarButtonItem84,
            this.spreadsheetCommandBarButtonItem85,
            this.spreadsheetCommandBarButtonItem86,
            this.spreadsheetCommandBarSubItem14,
            this.spreadsheetCommandBarButtonItem87,
            this.spreadsheetCommandBarButtonItem88,
            this.spreadsheetCommandBarButtonItem89,
            this.spreadsheetCommandBarButtonItem90,
            this.spreadsheetCommandBarButtonItem91,
            this.spreadsheetCommandBarButtonItem92,
            this.spreadsheetCommandBarSubItem15,
            this.spreadsheetCommandBarButtonItem93,
            this.spreadsheetCommandBarButtonItem94,
            this.spreadsheetCommandBarSubItem16,
            this.spreadsheetCommandBarButtonItem95,
            this.spreadsheetCommandBarButtonItem96,
            this.spreadsheetCommandBarButtonItem97,
            this.spreadsheetCommandBarButtonItem98,
            this.spreadsheetCommandBarButtonGalleryDropDownItem4,
            this.spreadsheetCommandBarButtonGalleryDropDownItem5,
            this.spreadsheetCommandBarButtonGalleryDropDownItem6,
            this.spreadsheetCommandBarButtonGalleryDropDownItem7,
            this.spreadsheetCommandBarButtonGalleryDropDownItem8,
            this.spreadsheetCommandBarButtonGalleryDropDownItem9,
            this.spreadsheetCommandBarButtonGalleryDropDownItem10,
            this.spreadsheetCommandBarButtonItem99,
            this.spreadsheetCommandBarButtonItem100,
            this.spreadsheetCommandBarSubItem17,
            this.spreadsheetCommandBarCheckItem14,
            this.spreadsheetCommandBarCheckItem15,
            this.spreadsheetCommandBarCheckItem16,
            this.spreadsheetCommandBarSubItem18,
            this.spreadsheetCommandBarCheckItem17,
            this.spreadsheetCommandBarCheckItem18,
            this.pageSetupPaperKindItem1,
            this.spreadsheetCommandBarSubItem19,
            this.spreadsheetCommandBarButtonItem101,
            this.spreadsheetCommandBarButtonItem102,
            this.spreadsheetCommandBarCheckItem19,
            this.spreadsheetCommandBarCheckItem20,
            this.spreadsheetCommandBarCheckItem21,
            this.spreadsheetCommandBarCheckItem22,
            this.spreadsheetCommandBarSubItem20,
            this.spreadsheetCommandBarButtonItem103,
            this.spreadsheetCommandBarButtonItem104,
            this.spreadsheetCommandBarSubItem21,
            this.spreadsheetCommandBarButtonItem105,
            this.spreadsheetCommandBarButtonItem106,
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
            this.spreadsheetCommandBarButtonItem112,
            this.spreadsheetCommandBarButtonItem113,
            this.definedNameListItem1,
            this.spreadsheetCommandBarButtonItem114,
            this.spreadsheetCommandBarCheckItem23,
            this.spreadsheetCommandBarSubItem24,
            this.spreadsheetCommandBarCheckItem24,
            this.spreadsheetCommandBarCheckItem25,
            this.spreadsheetCommandBarButtonItem115,
            this.spreadsheetCommandBarButtonItem116,
            this.spreadsheetCommandBarButtonItem117,
            this.spreadsheetCommandBarButtonItem118,
            this.spreadsheetCommandBarButtonItem119,
            this.spreadsheetCommandBarButtonItem120,
            this.spreadsheetCommandBarButtonItem121,
            this.spreadsheetCommandBarButtonItem122,
            this.spreadsheetCommandBarButtonItem123,
            this.spreadsheetCommandBarSubItem25,
            this.spreadsheetCommandBarButtonItem124,
            this.spreadsheetCommandBarButtonItem125,
            this.spreadsheetCommandBarButtonItem126,
            this.spreadsheetCommandBarButtonItem127,
            this.spreadsheetCommandBarButtonItem128,
            this.spreadsheetCommandBarButtonItem129,
            this.spreadsheetCommandBarButtonItem130,
            this.galleryChartLayoutItem1,
            this.galleryChartStyleItem1,
            this.spreadsheetCommandBarButtonGalleryDropDownItem11,
            this.spreadsheetCommandBarSubItem26,
            this.spreadsheetCommandBarButtonGalleryDropDownItem12,
            this.spreadsheetCommandBarButtonGalleryDropDownItem13,
            this.spreadsheetCommandBarButtonGalleryDropDownItem14,
            this.spreadsheetCommandBarButtonGalleryDropDownItem15,
            this.spreadsheetCommandBarSubItem27,
            this.spreadsheetCommandBarButtonGalleryDropDownItem16,
            this.spreadsheetCommandBarButtonGalleryDropDownItem17,
            this.spreadsheetCommandBarSubItem28,
            this.spreadsheetCommandBarButtonGalleryDropDownItem18,
            this.spreadsheetCommandBarButtonGalleryDropDownItem19,
            this.spreadsheetCommandBarButtonGalleryDropDownItem20,
            this.spreadsheetCommandBarButtonGalleryDropDownItem21,
            this.spreadsheetCommandBarButtonGalleryDropDownItem22,
            this.barStaticItem1,
            this.renameTableItem1,
            this.spreadsheetCommandBarCheckItem26,
            this.spreadsheetCommandBarCheckItem27,
            this.spreadsheetCommandBarCheckItem28,
            this.spreadsheetCommandBarCheckItem29,
            this.spreadsheetCommandBarCheckItem30,
            this.spreadsheetCommandBarCheckItem31,
            this.spreadsheetCommandBarCheckItem32,
            this.galleryTableStylesItem1,
            this.spreadsheetCommandBarCheckItem33,
            this.spreadsheetCommandBarCheckItem34,
            this.spreadsheetCommandBarCheckItem35,
            this.spreadsheetCommandBarSubItem29,
            this.spreadsheetCommandBarCheckItem36,
            this.spreadsheetCommandBarCheckItem37,
            this.spreadsheetCommandBarButtonItem131,
            this.spreadsheetCommandBarButtonItem132,
            this.spreadsheetCommandBarButtonItem133,
            this.spreadsheetCommandBarSubItem30,
            this.spreadsheetCommandBarButtonItem134,
            this.spreadsheetCommandBarButtonItem135,
            this.spreadsheetCommandBarButtonItem136,
            this.spreadsheetCommandBarButtonItem137,
            this.spreadsheetCommandBarButtonItem138,
            this.spreadsheetCommandBarButtonItem139,
            this.spreadsheetCommandBarButtonItem140,
            this.spreadsheetCommandBarButtonItem141,
            this.spreadsheetCommandBarCheckItem38,
            this.spreadsheetCommandBarButtonItem142,
            this.spreadsheetCommandBarButtonItem143,
            this.spreadsheetCommandBarSubItem31,
            this.spreadsheetCommandBarButtonItem144,
            this.spreadsheetCommandBarButtonItem145,
            this.spreadsheetCommandBarSubItem32,
            this.spreadsheetCommandBarButtonItem146,
            this.spreadsheetCommandBarButtonItem147,
            this.spreadsheetCommandBarButtonItem148,
            this.spreadsheetCommandBarButtonItem149,
            this.barButtonGroup11,
            this.barButtonGroup12,
            this.barButtonGroup13,
            this.barButtonGroup14,
            this.barButtonGroup15,
            this.barButtonGroup16,
            this.barButtonGroup17,
            this.barButtonGroup18,
            this.barButtonGroup19,
            this.barButtonGroup20,
            this.spreadsheetCommandBarCheckItem39,
            this.spreadsheetCommandBarButtonItem150,
            this.spreadsheetCommandBarButtonItem151,
            this.spreadsheetCommandBarSubItem33,
            this.spreadsheetCommandBarButtonItem152,
            this.spreadsheetCommandBarButtonItem153,
            this.spreadsheetCommandBarSubItem34,
            this.spreadsheetCommandBarButtonItem154,
            this.spreadsheetCommandBarButtonItem155,
            this.spreadsheetCommandBarButtonItem156,
            this.spreadsheetCommandBarButtonItem157,
            this.spreadsheetCommandBarButtonItem158,
            this.spreadsheetCommandBarButtonItem159,
            this.spreadsheetCommandBarButtonItem160,
            this.spreadsheetCommandBarButtonItem161,
            this.spreadsheetCommandBarButtonItem162,
            this.barStaticItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 604;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.chartToolsRibbonPageCategory1,
            this.tableToolsRibbonPageCategory1,
            this.pictureToolsRibbonPageCategory1,
            this.drawingToolsRibbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.homeRibbonPage1,
            this.insertRibbonPage1,
            this.pageLayoutRibbonPage1,
            this.formulasRibbonPage1,
            this.dataRibbonPage1,
            this.mailMergeRibbonPage1,
            this.reviewRibbonPage1,
            this.viewRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1,
            this.repositoryItemSpreadsheetFontSizeEdit1,
            this.repositoryItemPopupGalleryEdit1,
            this.repositoryItemTextEdit1});
            this.ribbonControl1.Size = new System.Drawing.Size(1062, 142);
            // 
            // hideCommentsCheckItem
            // 
            this.hideCommentsCheckItem.Caption = "Hide Comments";
            this.hideCommentsCheckItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.hideCommentsCheckItem.Description = "Show or hide descriptive comments in the template.";
            this.hideCommentsCheckItem.Glyph = ((System.Drawing.Image)(resources.GetObject("hideCommentsCheckItem.Glyph")));
            this.hideCommentsCheckItem.Id = 230;
            this.hideCommentsCheckItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("hideCommentsCheckItem.LargeGlyph")));
            this.hideCommentsCheckItem.Name = "hideCommentsCheckItem";
            this.hideCommentsCheckItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem1.Text = "Hide Comments";
            toolTipItem1.Text = "Show or hide descriptive comments in the template.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.hideCommentsCheckItem.SuperTip = superToolTip1;
            this.hideCommentsCheckItem.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.hideCommentsCheckItem_ItemClick);
            // 
            // spreadsheetCommandBarButtonItem1
            // 
            this.spreadsheetCommandBarButtonItem1.CommandName = "FileNew";
            this.spreadsheetCommandBarButtonItem1.Id = 293;
            this.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1";
            // 
            // spreadsheetCommandBarButtonItem2
            // 
            this.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen";
            this.spreadsheetCommandBarButtonItem2.Id = 294;
            this.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2";
            // 
            // spreadsheetCommandBarButtonItem3
            // 
            this.spreadsheetCommandBarButtonItem3.CommandName = "FileSave";
            this.spreadsheetCommandBarButtonItem3.Id = 295;
            this.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3";
            // 
            // spreadsheetCommandBarButtonItem4
            // 
            this.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs";
            this.spreadsheetCommandBarButtonItem4.Id = 296;
            this.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4";
            // 
            // spreadsheetCommandBarButtonItem5
            // 
            this.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint";
            this.spreadsheetCommandBarButtonItem5.Id = 297;
            this.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5";
            // 
            // spreadsheetCommandBarButtonItem6
            // 
            this.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint";
            this.spreadsheetCommandBarButtonItem6.Id = 298;
            this.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6";
            // 
            // spreadsheetCommandBarButtonItem7
            // 
            this.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview";
            this.spreadsheetCommandBarButtonItem7.Id = 299;
            this.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7";
            // 
            // spreadsheetCommandBarButtonItem8
            // 
            this.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo";
            this.spreadsheetCommandBarButtonItem8.Id = 300;
            this.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8";
            // 
            // spreadsheetCommandBarButtonItem9
            // 
            this.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo";
            this.spreadsheetCommandBarButtonItem9.Id = 301;
            this.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9";
            // 
            // spreadsheetCommandBarButtonItem10
            // 
            this.spreadsheetCommandBarButtonItem10.CommandName = "PasteSelection";
            this.spreadsheetCommandBarButtonItem10.Id = 312;
            this.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10";
            this.spreadsheetCommandBarButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem11
            // 
            this.spreadsheetCommandBarButtonItem11.CommandName = "CutSelection";
            this.spreadsheetCommandBarButtonItem11.Id = 313;
            this.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11";
            this.spreadsheetCommandBarButtonItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem12
            // 
            this.spreadsheetCommandBarButtonItem12.CommandName = "CopySelection";
            this.spreadsheetCommandBarButtonItem12.Id = 314;
            this.spreadsheetCommandBarButtonItem12.Name = "spreadsheetCommandBarButtonItem12";
            this.spreadsheetCommandBarButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem13
            // 
            this.spreadsheetCommandBarButtonItem13.CommandName = "ShowPasteSpecialForm";
            this.spreadsheetCommandBarButtonItem13.Id = 315;
            this.spreadsheetCommandBarButtonItem13.Name = "spreadsheetCommandBarButtonItem13";
            this.spreadsheetCommandBarButtonItem13.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Id = 302;
            this.barButtonGroup1.ItemLinks.Add(this.changeFontNameItem1);
            this.barButtonGroup1.ItemLinks.Add(this.changeFontSizeItem1);
            this.barButtonGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem14);
            this.barButtonGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem15);
            this.barButtonGroup1.Name = "barButtonGroup1";
            this.barButtonGroup1.Tag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
            // 
            // changeFontNameItem1
            // 
            this.changeFontNameItem1.Edit = this.repositoryItemFontEdit1;
            this.changeFontNameItem1.Id = 316;
            this.changeFontNameItem1.Name = "changeFontNameItem1";
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // changeFontSizeItem1
            // 
            this.changeFontSizeItem1.Edit = this.repositoryItemSpreadsheetFontSizeEdit1;
            this.changeFontSizeItem1.Id = 317;
            this.changeFontSizeItem1.Name = "changeFontSizeItem1";
            // 
            // repositoryItemSpreadsheetFontSizeEdit1
            // 
            this.repositoryItemSpreadsheetFontSizeEdit1.AutoHeight = false;
            this.repositoryItemSpreadsheetFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpreadsheetFontSizeEdit1.Control = this.spreadsheetControl1;
            this.repositoryItemSpreadsheetFontSizeEdit1.Name = "repositoryItemSpreadsheetFontSizeEdit1";
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 162);
            this.spreadsheetControl1.MenuManager = this.ribbonControl1;
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.Export.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Export.Csv.Encoding")));
            this.spreadsheetControl1.Options.Export.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Export.Txt.Encoding")));
            this.spreadsheetControl1.Size = new System.Drawing.Size(862, 270);
            this.spreadsheetControl1.TabIndex = 0;
            // 
            // spreadsheetCommandBarButtonItem14
            // 
            this.spreadsheetCommandBarButtonItem14.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
            this.spreadsheetCommandBarButtonItem14.CommandName = "FormatIncreaseFontSize";
            this.spreadsheetCommandBarButtonItem14.Id = 318;
            this.spreadsheetCommandBarButtonItem14.Name = "spreadsheetCommandBarButtonItem14";
            this.spreadsheetCommandBarButtonItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem15
            // 
            this.spreadsheetCommandBarButtonItem15.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
            this.spreadsheetCommandBarButtonItem15.CommandName = "FormatDecreaseFontSize";
            this.spreadsheetCommandBarButtonItem15.Id = 319;
            this.spreadsheetCommandBarButtonItem15.Name = "spreadsheetCommandBarButtonItem15";
            this.spreadsheetCommandBarButtonItem15.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Id = 303;
            this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem1);
            this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem2);
            this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem3);
            this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem4);
            this.barButtonGroup2.Name = "barButtonGroup2";
            this.barButtonGroup2.Tag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            // 
            // spreadsheetCommandBarCheckItem1
            // 
            this.spreadsheetCommandBarCheckItem1.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            this.spreadsheetCommandBarCheckItem1.CommandName = "FormatFontBold";
            this.spreadsheetCommandBarCheckItem1.Id = 320;
            this.spreadsheetCommandBarCheckItem1.Name = "spreadsheetCommandBarCheckItem1";
            this.spreadsheetCommandBarCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem2
            // 
            this.spreadsheetCommandBarCheckItem2.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            this.spreadsheetCommandBarCheckItem2.CommandName = "FormatFontItalic";
            this.spreadsheetCommandBarCheckItem2.Id = 321;
            this.spreadsheetCommandBarCheckItem2.Name = "spreadsheetCommandBarCheckItem2";
            this.spreadsheetCommandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem3
            // 
            this.spreadsheetCommandBarCheckItem3.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            this.spreadsheetCommandBarCheckItem3.CommandName = "FormatFontUnderline";
            this.spreadsheetCommandBarCheckItem3.Id = 322;
            this.spreadsheetCommandBarCheckItem3.Name = "spreadsheetCommandBarCheckItem3";
            this.spreadsheetCommandBarCheckItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem4
            // 
            this.spreadsheetCommandBarCheckItem4.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            this.spreadsheetCommandBarCheckItem4.CommandName = "FormatFontStrikeout";
            this.spreadsheetCommandBarCheckItem4.Id = 323;
            this.spreadsheetCommandBarCheckItem4.Name = "spreadsheetCommandBarCheckItem4";
            this.spreadsheetCommandBarCheckItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroup3
            // 
            this.barButtonGroup3.Id = 304;
            this.barButtonGroup3.ItemLinks.Add(this.spreadsheetCommandBarSubItem1);
            this.barButtonGroup3.Name = "barButtonGroup3";
            this.barButtonGroup3.Tag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}";
            // 
            // spreadsheetCommandBarSubItem1
            // 
            this.spreadsheetCommandBarSubItem1.ButtonGroupTag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}";
            this.spreadsheetCommandBarSubItem1.CommandName = "FormatBordersCommandGroup";
            this.spreadsheetCommandBarSubItem1.Id = 324;
            this.spreadsheetCommandBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem16),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem17),
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
            new DevExpress.XtraBars.LinkPersistInfo(this.changeBorderLineColorItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeBorderLineStyleItem1)});
            this.spreadsheetCommandBarSubItem1.Name = "spreadsheetCommandBarSubItem1";
            this.spreadsheetCommandBarSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem16
            // 
            this.spreadsheetCommandBarButtonItem16.CommandName = "FormatBottomBorder";
            this.spreadsheetCommandBarButtonItem16.Id = 325;
            this.spreadsheetCommandBarButtonItem16.Name = "spreadsheetCommandBarButtonItem16";
            // 
            // spreadsheetCommandBarButtonItem17
            // 
            this.spreadsheetCommandBarButtonItem17.CommandName = "FormatTopBorder";
            this.spreadsheetCommandBarButtonItem17.Id = 326;
            this.spreadsheetCommandBarButtonItem17.Name = "spreadsheetCommandBarButtonItem17";
            // 
            // spreadsheetCommandBarButtonItem18
            // 
            this.spreadsheetCommandBarButtonItem18.CommandName = "FormatLeftBorder";
            this.spreadsheetCommandBarButtonItem18.Id = 327;
            this.spreadsheetCommandBarButtonItem18.Name = "spreadsheetCommandBarButtonItem18";
            // 
            // spreadsheetCommandBarButtonItem19
            // 
            this.spreadsheetCommandBarButtonItem19.CommandName = "FormatRightBorder";
            this.spreadsheetCommandBarButtonItem19.Id = 328;
            this.spreadsheetCommandBarButtonItem19.Name = "spreadsheetCommandBarButtonItem19";
            // 
            // spreadsheetCommandBarButtonItem20
            // 
            this.spreadsheetCommandBarButtonItem20.CommandName = "FormatNoBorders";
            this.spreadsheetCommandBarButtonItem20.Id = 329;
            this.spreadsheetCommandBarButtonItem20.Name = "spreadsheetCommandBarButtonItem20";
            // 
            // spreadsheetCommandBarButtonItem21
            // 
            this.spreadsheetCommandBarButtonItem21.CommandName = "FormatAllBorders";
            this.spreadsheetCommandBarButtonItem21.Id = 330;
            this.spreadsheetCommandBarButtonItem21.Name = "spreadsheetCommandBarButtonItem21";
            // 
            // spreadsheetCommandBarButtonItem22
            // 
            this.spreadsheetCommandBarButtonItem22.CommandName = "FormatOutsideBorders";
            this.spreadsheetCommandBarButtonItem22.Id = 331;
            this.spreadsheetCommandBarButtonItem22.Name = "spreadsheetCommandBarButtonItem22";
            // 
            // spreadsheetCommandBarButtonItem23
            // 
            this.spreadsheetCommandBarButtonItem23.CommandName = "FormatThickBorder";
            this.spreadsheetCommandBarButtonItem23.Id = 332;
            this.spreadsheetCommandBarButtonItem23.Name = "spreadsheetCommandBarButtonItem23";
            // 
            // spreadsheetCommandBarButtonItem24
            // 
            this.spreadsheetCommandBarButtonItem24.CommandName = "FormatBottomDoubleBorder";
            this.spreadsheetCommandBarButtonItem24.Id = 333;
            this.spreadsheetCommandBarButtonItem24.Name = "spreadsheetCommandBarButtonItem24";
            // 
            // spreadsheetCommandBarButtonItem25
            // 
            this.spreadsheetCommandBarButtonItem25.CommandName = "FormatBottomThickBorder";
            this.spreadsheetCommandBarButtonItem25.Id = 334;
            this.spreadsheetCommandBarButtonItem25.Name = "spreadsheetCommandBarButtonItem25";
            // 
            // spreadsheetCommandBarButtonItem26
            // 
            this.spreadsheetCommandBarButtonItem26.CommandName = "FormatTopAndBottomBorder";
            this.spreadsheetCommandBarButtonItem26.Id = 335;
            this.spreadsheetCommandBarButtonItem26.Name = "spreadsheetCommandBarButtonItem26";
            // 
            // spreadsheetCommandBarButtonItem27
            // 
            this.spreadsheetCommandBarButtonItem27.CommandName = "FormatTopAndThickBottomBorder";
            this.spreadsheetCommandBarButtonItem27.Id = 336;
            this.spreadsheetCommandBarButtonItem27.Name = "spreadsheetCommandBarButtonItem27";
            // 
            // spreadsheetCommandBarButtonItem28
            // 
            this.spreadsheetCommandBarButtonItem28.CommandName = "FormatTopAndDoubleBottomBorder";
            this.spreadsheetCommandBarButtonItem28.Id = 337;
            this.spreadsheetCommandBarButtonItem28.Name = "spreadsheetCommandBarButtonItem28";
            // 
            // changeBorderLineColorItem1
            // 
            this.changeBorderLineColorItem1.ActAsDropDown = true;
            this.changeBorderLineColorItem1.Id = 338;
            this.changeBorderLineColorItem1.Name = "changeBorderLineColorItem1";
            // 
            // changeBorderLineStyleItem1
            // 
            this.changeBorderLineStyleItem1.DropDownControl = this.commandBarGalleryDropDown1;
            this.changeBorderLineStyleItem1.Id = 339;
            this.changeBorderLineStyleItem1.Name = "changeBorderLineStyleItem1";
            // 
            // commandBarGalleryDropDown1
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown1.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown1.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown1.Gallery.DrawImageBackground = false;
            this.commandBarGalleryDropDown1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.commandBarGalleryDropDown1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown1.Gallery.ItemSize = new System.Drawing.Size(136, 26);
            this.commandBarGalleryDropDown1.Gallery.RowCount = 14;
            this.commandBarGalleryDropDown1.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown1.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1";
            this.commandBarGalleryDropDown1.Ribbon = this.ribbonControl1;
            // 
            // barButtonGroup4
            // 
            this.barButtonGroup4.Id = 305;
            this.barButtonGroup4.ItemLinks.Add(this.changeCellFillColorItem1);
            this.barButtonGroup4.ItemLinks.Add(this.changeFontColorItem1);
            this.barButtonGroup4.Name = "barButtonGroup4";
            this.barButtonGroup4.Tag = "{C2275623-04A3-41E8-8D6A-EB5C7F8541D1}";
            // 
            // changeCellFillColorItem1
            // 
            this.changeCellFillColorItem1.Id = 340;
            this.changeCellFillColorItem1.Name = "changeCellFillColorItem1";
            // 
            // changeFontColorItem1
            // 
            this.changeFontColorItem1.Id = 341;
            this.changeFontColorItem1.Name = "changeFontColorItem1";
            // 
            // barButtonGroup5
            // 
            this.barButtonGroup5.Id = 306;
            this.barButtonGroup5.ItemLinks.Add(this.spreadsheetCommandBarCheckItem5);
            this.barButtonGroup5.ItemLinks.Add(this.spreadsheetCommandBarCheckItem6);
            this.barButtonGroup5.ItemLinks.Add(this.spreadsheetCommandBarCheckItem7);
            this.barButtonGroup5.Name = "barButtonGroup5";
            this.barButtonGroup5.Tag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            // 
            // spreadsheetCommandBarCheckItem5
            // 
            this.spreadsheetCommandBarCheckItem5.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            this.spreadsheetCommandBarCheckItem5.CommandName = "FormatAlignmentTop";
            this.spreadsheetCommandBarCheckItem5.Id = 342;
            this.spreadsheetCommandBarCheckItem5.Name = "spreadsheetCommandBarCheckItem5";
            this.spreadsheetCommandBarCheckItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem6
            // 
            this.spreadsheetCommandBarCheckItem6.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            this.spreadsheetCommandBarCheckItem6.CommandName = "FormatAlignmentMiddle";
            this.spreadsheetCommandBarCheckItem6.Id = 343;
            this.spreadsheetCommandBarCheckItem6.Name = "spreadsheetCommandBarCheckItem6";
            this.spreadsheetCommandBarCheckItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem7
            // 
            this.spreadsheetCommandBarCheckItem7.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            this.spreadsheetCommandBarCheckItem7.CommandName = "FormatAlignmentBottom";
            this.spreadsheetCommandBarCheckItem7.Id = 344;
            this.spreadsheetCommandBarCheckItem7.Name = "spreadsheetCommandBarCheckItem7";
            this.spreadsheetCommandBarCheckItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroup6
            // 
            this.barButtonGroup6.Id = 307;
            this.barButtonGroup6.ItemLinks.Add(this.spreadsheetCommandBarCheckItem8);
            this.barButtonGroup6.ItemLinks.Add(this.spreadsheetCommandBarCheckItem9);
            this.barButtonGroup6.ItemLinks.Add(this.spreadsheetCommandBarCheckItem10);
            this.barButtonGroup6.Name = "barButtonGroup6";
            this.barButtonGroup6.Tag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            // 
            // spreadsheetCommandBarCheckItem8
            // 
            this.spreadsheetCommandBarCheckItem8.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            this.spreadsheetCommandBarCheckItem8.CommandName = "FormatAlignmentLeft";
            this.spreadsheetCommandBarCheckItem8.Id = 345;
            this.spreadsheetCommandBarCheckItem8.Name = "spreadsheetCommandBarCheckItem8";
            this.spreadsheetCommandBarCheckItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem9
            // 
            this.spreadsheetCommandBarCheckItem9.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            this.spreadsheetCommandBarCheckItem9.CommandName = "FormatAlignmentCenter";
            this.spreadsheetCommandBarCheckItem9.Id = 346;
            this.spreadsheetCommandBarCheckItem9.Name = "spreadsheetCommandBarCheckItem9";
            this.spreadsheetCommandBarCheckItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem10
            // 
            this.spreadsheetCommandBarCheckItem10.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            this.spreadsheetCommandBarCheckItem10.CommandName = "FormatAlignmentRight";
            this.spreadsheetCommandBarCheckItem10.Id = 347;
            this.spreadsheetCommandBarCheckItem10.Name = "spreadsheetCommandBarCheckItem10";
            this.spreadsheetCommandBarCheckItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroup7
            // 
            this.barButtonGroup7.Id = 308;
            this.barButtonGroup7.ItemLinks.Add(this.spreadsheetCommandBarButtonItem29);
            this.barButtonGroup7.ItemLinks.Add(this.spreadsheetCommandBarButtonItem30);
            this.barButtonGroup7.Name = "barButtonGroup7";
            this.barButtonGroup7.Tag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
            // 
            // spreadsheetCommandBarButtonItem29
            // 
            this.spreadsheetCommandBarButtonItem29.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
            this.spreadsheetCommandBarButtonItem29.CommandName = "FormatDecreaseIndent";
            this.spreadsheetCommandBarButtonItem29.Id = 348;
            this.spreadsheetCommandBarButtonItem29.Name = "spreadsheetCommandBarButtonItem29";
            this.spreadsheetCommandBarButtonItem29.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem30
            // 
            this.spreadsheetCommandBarButtonItem30.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
            this.spreadsheetCommandBarButtonItem30.CommandName = "FormatIncreaseIndent";
            this.spreadsheetCommandBarButtonItem30.Id = 349;
            this.spreadsheetCommandBarButtonItem30.Name = "spreadsheetCommandBarButtonItem30";
            this.spreadsheetCommandBarButtonItem30.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem11
            // 
            this.spreadsheetCommandBarCheckItem11.CommandName = "FormatWrapText";
            this.spreadsheetCommandBarCheckItem11.Id = 350;
            this.spreadsheetCommandBarCheckItem11.Name = "spreadsheetCommandBarCheckItem11";
            this.spreadsheetCommandBarCheckItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarSubItem2
            // 
            this.spreadsheetCommandBarSubItem2.CommandName = "EditingMergeCellsCommandGroup";
            this.spreadsheetCommandBarSubItem2.Id = 351;
            this.spreadsheetCommandBarSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem12),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem31),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem32),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem33)});
            this.spreadsheetCommandBarSubItem2.Name = "spreadsheetCommandBarSubItem2";
            this.spreadsheetCommandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarCheckItem12
            // 
            this.spreadsheetCommandBarCheckItem12.CommandName = "EditingMergeAndCenterCells";
            this.spreadsheetCommandBarCheckItem12.Id = 352;
            this.spreadsheetCommandBarCheckItem12.Name = "spreadsheetCommandBarCheckItem12";
            // 
            // spreadsheetCommandBarButtonItem31
            // 
            this.spreadsheetCommandBarButtonItem31.CommandName = "EditingMergeCellsAcross";
            this.spreadsheetCommandBarButtonItem31.Id = 353;
            this.spreadsheetCommandBarButtonItem31.Name = "spreadsheetCommandBarButtonItem31";
            // 
            // spreadsheetCommandBarButtonItem32
            // 
            this.spreadsheetCommandBarButtonItem32.CommandName = "EditingMergeCells";
            this.spreadsheetCommandBarButtonItem32.Id = 354;
            this.spreadsheetCommandBarButtonItem32.Name = "spreadsheetCommandBarButtonItem32";
            // 
            // spreadsheetCommandBarButtonItem33
            // 
            this.spreadsheetCommandBarButtonItem33.CommandName = "EditingUnmergeCells";
            this.spreadsheetCommandBarButtonItem33.Id = 355;
            this.spreadsheetCommandBarButtonItem33.Name = "spreadsheetCommandBarButtonItem33";
            // 
            // barButtonGroup8
            // 
            this.barButtonGroup8.Id = 309;
            this.barButtonGroup8.ItemLinks.Add(this.changeNumberFormatItem1);
            this.barButtonGroup8.Name = "barButtonGroup8";
            this.barButtonGroup8.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}";
            // 
            // changeNumberFormatItem1
            // 
            this.changeNumberFormatItem1.Edit = this.repositoryItemPopupGalleryEdit1;
            this.changeNumberFormatItem1.Id = 356;
            this.changeNumberFormatItem1.Name = "changeNumberFormatItem1";
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
            this.barButtonGroup9.Id = 310;
            this.barButtonGroup9.ItemLinks.Add(this.spreadsheetCommandBarSubItem3);
            this.barButtonGroup9.ItemLinks.Add(this.spreadsheetCommandBarButtonItem39);
            this.barButtonGroup9.ItemLinks.Add(this.spreadsheetCommandBarButtonItem40);
            this.barButtonGroup9.Name = "barButtonGroup9";
            this.barButtonGroup9.Tag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            // 
            // spreadsheetCommandBarSubItem3
            // 
            this.spreadsheetCommandBarSubItem3.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            this.spreadsheetCommandBarSubItem3.CommandName = "FormatNumberAccountingCommandGroup";
            this.spreadsheetCommandBarSubItem3.Id = 357;
            this.spreadsheetCommandBarSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem34),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem35),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem36),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem37),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem38)});
            this.spreadsheetCommandBarSubItem3.Name = "spreadsheetCommandBarSubItem3";
            this.spreadsheetCommandBarSubItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem34
            // 
            this.spreadsheetCommandBarButtonItem34.CommandName = "FormatNumberAccountingUS";
            this.spreadsheetCommandBarButtonItem34.Id = 358;
            this.spreadsheetCommandBarButtonItem34.Name = "spreadsheetCommandBarButtonItem34";
            // 
            // spreadsheetCommandBarButtonItem35
            // 
            this.spreadsheetCommandBarButtonItem35.CommandName = "FormatNumberAccountingUK";
            this.spreadsheetCommandBarButtonItem35.Id = 359;
            this.spreadsheetCommandBarButtonItem35.Name = "spreadsheetCommandBarButtonItem35";
            // 
            // spreadsheetCommandBarButtonItem36
            // 
            this.spreadsheetCommandBarButtonItem36.CommandName = "FormatNumberAccountingEuro";
            this.spreadsheetCommandBarButtonItem36.Id = 360;
            this.spreadsheetCommandBarButtonItem36.Name = "spreadsheetCommandBarButtonItem36";
            // 
            // spreadsheetCommandBarButtonItem37
            // 
            this.spreadsheetCommandBarButtonItem37.CommandName = "FormatNumberAccountingPRC";
            this.spreadsheetCommandBarButtonItem37.Id = 361;
            this.spreadsheetCommandBarButtonItem37.Name = "spreadsheetCommandBarButtonItem37";
            // 
            // spreadsheetCommandBarButtonItem38
            // 
            this.spreadsheetCommandBarButtonItem38.CommandName = "FormatNumberAccountingSwiss";
            this.spreadsheetCommandBarButtonItem38.Id = 362;
            this.spreadsheetCommandBarButtonItem38.Name = "spreadsheetCommandBarButtonItem38";
            // 
            // spreadsheetCommandBarButtonItem39
            // 
            this.spreadsheetCommandBarButtonItem39.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            this.spreadsheetCommandBarButtonItem39.CommandName = "FormatNumberPercent";
            this.spreadsheetCommandBarButtonItem39.Id = 363;
            this.spreadsheetCommandBarButtonItem39.Name = "spreadsheetCommandBarButtonItem39";
            this.spreadsheetCommandBarButtonItem39.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem40
            // 
            this.spreadsheetCommandBarButtonItem40.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            this.spreadsheetCommandBarButtonItem40.CommandName = "FormatNumberAccounting";
            this.spreadsheetCommandBarButtonItem40.Id = 364;
            this.spreadsheetCommandBarButtonItem40.Name = "spreadsheetCommandBarButtonItem40";
            this.spreadsheetCommandBarButtonItem40.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroup10
            // 
            this.barButtonGroup10.Id = 311;
            this.barButtonGroup10.ItemLinks.Add(this.spreadsheetCommandBarButtonItem41);
            this.barButtonGroup10.ItemLinks.Add(this.spreadsheetCommandBarButtonItem42);
            this.barButtonGroup10.Name = "barButtonGroup10";
            this.barButtonGroup10.Tag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
            // 
            // spreadsheetCommandBarButtonItem41
            // 
            this.spreadsheetCommandBarButtonItem41.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
            this.spreadsheetCommandBarButtonItem41.CommandName = "FormatNumberIncreaseDecimal";
            this.spreadsheetCommandBarButtonItem41.Id = 365;
            this.spreadsheetCommandBarButtonItem41.Name = "spreadsheetCommandBarButtonItem41";
            this.spreadsheetCommandBarButtonItem41.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem42
            // 
            this.spreadsheetCommandBarButtonItem42.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
            this.spreadsheetCommandBarButtonItem42.CommandName = "FormatNumberDecreaseDecimal";
            this.spreadsheetCommandBarButtonItem42.Id = 366;
            this.spreadsheetCommandBarButtonItem42.Name = "spreadsheetCommandBarButtonItem42";
            this.spreadsheetCommandBarButtonItem42.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem2
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.CommandName = "ConditionalFormattingColorScalesCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.DropDownControl = this.commandBarGalleryDropDown3;
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.Id = 384;
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.Name = "spreadsheetCommandBarButtonGalleryDropDownItem2";
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // commandBarGalleryDropDown3
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown3.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup3.CommandName = "ConditionalFormattingColorScalesCommandGroup";
            spreadsheetCommandGalleryItem24.CommandName = "ConditionalFormattingColorScaleGreenYellowRed";
            spreadsheetCommandGalleryItem25.CommandName = "ConditionalFormattingColorScaleRedYellowGreen";
            spreadsheetCommandGalleryItem26.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed";
            spreadsheetCommandGalleryItem27.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen";
            spreadsheetCommandGalleryItem28.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed";
            spreadsheetCommandGalleryItem29.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue";
            spreadsheetCommandGalleryItem30.CommandName = "ConditionalFormattingColorScaleWhiteRed";
            spreadsheetCommandGalleryItem31.CommandName = "ConditionalFormattingColorScaleRedWhite";
            spreadsheetCommandGalleryItem32.CommandName = "ConditionalFormattingColorScaleGreenWhite";
            spreadsheetCommandGalleryItem33.CommandName = "ConditionalFormattingColorScaleWhiteGreen";
            spreadsheetCommandGalleryItem34.CommandName = "ConditionalFormattingColorScaleGreenYellow";
            spreadsheetCommandGalleryItem35.CommandName = "ConditionalFormattingColorScaleYellowGreen";
            spreadsheetCommandGalleryItemGroup3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem24,
            spreadsheetCommandGalleryItem25,
            spreadsheetCommandGalleryItem26,
            spreadsheetCommandGalleryItem27,
            spreadsheetCommandGalleryItem28,
            spreadsheetCommandGalleryItem29,
            spreadsheetCommandGalleryItem30,
            spreadsheetCommandGalleryItem31,
            spreadsheetCommandGalleryItem32,
            spreadsheetCommandGalleryItem33,
            spreadsheetCommandGalleryItem34,
            spreadsheetCommandGalleryItem35});
            this.commandBarGalleryDropDown3.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup3});
            this.commandBarGalleryDropDown3.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3";
            this.commandBarGalleryDropDown3.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem3
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.CommandName = "ConditionalFormattingIconSetsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.DropDownControl = this.commandBarGalleryDropDown4;
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.Id = 385;
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.Name = "spreadsheetCommandBarButtonGalleryDropDownItem3";
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // commandBarGalleryDropDown4
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown4.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup4.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup";
            spreadsheetCommandGalleryItem36.CommandName = "ConditionalFormattingIconSetArrows3Colored";
            spreadsheetCommandGalleryItem37.CommandName = "ConditionalFormattingIconSetArrows3Grayed";
            spreadsheetCommandGalleryItem38.CommandName = "ConditionalFormattingIconSetArrows4Colored";
            spreadsheetCommandGalleryItem39.CommandName = "ConditionalFormattingIconSetArrows4Grayed";
            spreadsheetCommandGalleryItem40.CommandName = "ConditionalFormattingIconSetArrows5Colored";
            spreadsheetCommandGalleryItem41.CommandName = "ConditionalFormattingIconSetArrows5Grayed";
            spreadsheetCommandGalleryItem42.CommandName = "ConditionalFormattingIconSetTriangles3";
            spreadsheetCommandGalleryItemGroup4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem36,
            spreadsheetCommandGalleryItem37,
            spreadsheetCommandGalleryItem38,
            spreadsheetCommandGalleryItem39,
            spreadsheetCommandGalleryItem40,
            spreadsheetCommandGalleryItem41,
            spreadsheetCommandGalleryItem42});
            spreadsheetCommandGalleryItemGroup5.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup";
            spreadsheetCommandGalleryItem43.CommandName = "ConditionalFormattingIconSetTrafficLights3";
            spreadsheetCommandGalleryItem44.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed";
            spreadsheetCommandGalleryItem45.CommandName = "ConditionalFormattingIconSetTrafficLights4";
            spreadsheetCommandGalleryItem46.CommandName = "ConditionalFormattingIconSetSigns3";
            spreadsheetCommandGalleryItem47.CommandName = "ConditionalFormattingIconSetRedToBlack";
            spreadsheetCommandGalleryItemGroup5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem43,
            spreadsheetCommandGalleryItem44,
            spreadsheetCommandGalleryItem45,
            spreadsheetCommandGalleryItem46,
            spreadsheetCommandGalleryItem47});
            spreadsheetCommandGalleryItemGroup6.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup";
            spreadsheetCommandGalleryItem48.CommandName = "ConditionalFormattingIconSetSymbols3Circled";
            spreadsheetCommandGalleryItem49.CommandName = "ConditionalFormattingIconSetSymbols3";
            spreadsheetCommandGalleryItem50.CommandName = "ConditionalFormattingIconSetFlags3";
            spreadsheetCommandGalleryItemGroup6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem48,
            spreadsheetCommandGalleryItem49,
            spreadsheetCommandGalleryItem50});
            spreadsheetCommandGalleryItemGroup7.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup";
            spreadsheetCommandGalleryItem51.CommandName = "ConditionalFormattingIconSetStars3";
            spreadsheetCommandGalleryItem52.CommandName = "ConditionalFormattingIconSetRatings4";
            spreadsheetCommandGalleryItem53.CommandName = "ConditionalFormattingIconSetRatings5";
            spreadsheetCommandGalleryItem54.CommandName = "ConditionalFormattingIconSetQuarters5";
            spreadsheetCommandGalleryItem55.CommandName = "ConditionalFormattingIconSetBoxes5";
            spreadsheetCommandGalleryItemGroup7.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem51,
            spreadsheetCommandGalleryItem52,
            spreadsheetCommandGalleryItem53,
            spreadsheetCommandGalleryItem54,
            spreadsheetCommandGalleryItem55});
            this.commandBarGalleryDropDown4.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup4,
            spreadsheetCommandGalleryItemGroup5,
            spreadsheetCommandGalleryItemGroup6,
            spreadsheetCommandGalleryItemGroup7});
            this.commandBarGalleryDropDown4.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4";
            this.commandBarGalleryDropDown4.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonItem56
            // 
            this.spreadsheetCommandBarButtonItem56.CommandName = "ConditionalFormattingRemoveFromSheet";
            this.spreadsheetCommandBarButtonItem56.Id = 386;
            this.spreadsheetCommandBarButtonItem56.Name = "spreadsheetCommandBarButtonItem56";
            // 
            // spreadsheetCommandBarButtonItem57
            // 
            this.spreadsheetCommandBarButtonItem57.CommandName = "ConditionalFormattingRemove";
            this.spreadsheetCommandBarButtonItem57.Id = 387;
            this.spreadsheetCommandBarButtonItem57.Name = "spreadsheetCommandBarButtonItem57";
            // 
            // spreadsheetCommandBarSubItem7
            // 
            this.spreadsheetCommandBarSubItem7.CommandName = "ConditionalFormattingRemoveCommandGroup";
            this.spreadsheetCommandBarSubItem7.Id = 388;
            this.spreadsheetCommandBarSubItem7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem56),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem57)});
            this.spreadsheetCommandBarSubItem7.Name = "spreadsheetCommandBarSubItem7";
            // 
            // galleryFormatAsTableItem1
            // 
            this.galleryFormatAsTableItem1.DropDownControl = this.commandBarGalleryDropDown5;
            this.galleryFormatAsTableItem1.Id = 389;
            this.galleryFormatAsTableItem1.Name = "galleryFormatAsTableItem1";
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
            this.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5";
            this.commandBarGalleryDropDown5.Ribbon = this.ribbonControl1;
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
            this.galleryChangeStyleItem1.Id = 390;
            this.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1";
            // 
            // spreadsheetCommandBarSubItem8
            // 
            this.spreadsheetCommandBarSubItem8.CommandName = "InsertCellsCommandGroup";
            this.spreadsheetCommandBarSubItem8.Id = 391;
            this.spreadsheetCommandBarSubItem8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem58),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem59),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem60)});
            this.spreadsheetCommandBarSubItem8.Name = "spreadsheetCommandBarSubItem8";
            // 
            // spreadsheetCommandBarButtonItem58
            // 
            this.spreadsheetCommandBarButtonItem58.CommandName = "InsertSheetRows";
            this.spreadsheetCommandBarButtonItem58.Id = 392;
            this.spreadsheetCommandBarButtonItem58.Name = "spreadsheetCommandBarButtonItem58";
            // 
            // spreadsheetCommandBarButtonItem59
            // 
            this.spreadsheetCommandBarButtonItem59.CommandName = "InsertSheetColumns";
            this.spreadsheetCommandBarButtonItem59.Id = 393;
            this.spreadsheetCommandBarButtonItem59.Name = "spreadsheetCommandBarButtonItem59";
            // 
            // spreadsheetCommandBarButtonItem60
            // 
            this.spreadsheetCommandBarButtonItem60.CommandName = "InsertSheet";
            this.spreadsheetCommandBarButtonItem60.Id = 394;
            this.spreadsheetCommandBarButtonItem60.Name = "spreadsheetCommandBarButtonItem60";
            // 
            // spreadsheetCommandBarSubItem9
            // 
            this.spreadsheetCommandBarSubItem9.CommandName = "RemoveCellsCommandGroup";
            this.spreadsheetCommandBarSubItem9.Id = 395;
            this.spreadsheetCommandBarSubItem9.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem61),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem62),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem63)});
            this.spreadsheetCommandBarSubItem9.Name = "spreadsheetCommandBarSubItem9";
            // 
            // spreadsheetCommandBarButtonItem61
            // 
            this.spreadsheetCommandBarButtonItem61.CommandName = "RemoveSheetRows";
            this.spreadsheetCommandBarButtonItem61.Id = 396;
            this.spreadsheetCommandBarButtonItem61.Name = "spreadsheetCommandBarButtonItem61";
            // 
            // spreadsheetCommandBarButtonItem62
            // 
            this.spreadsheetCommandBarButtonItem62.CommandName = "RemoveSheetColumns";
            this.spreadsheetCommandBarButtonItem62.Id = 397;
            this.spreadsheetCommandBarButtonItem62.Name = "spreadsheetCommandBarButtonItem62";
            // 
            // spreadsheetCommandBarButtonItem63
            // 
            this.spreadsheetCommandBarButtonItem63.CommandName = "RemoveSheet";
            this.spreadsheetCommandBarButtonItem63.Id = 398;
            this.spreadsheetCommandBarButtonItem63.Name = "spreadsheetCommandBarButtonItem63";
            // 
            // spreadsheetCommandBarSubItem10
            // 
            this.spreadsheetCommandBarSubItem10.CommandName = "FormatCommandGroup";
            this.spreadsheetCommandBarSubItem10.Id = 399;
            this.spreadsheetCommandBarSubItem10.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem64),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem65),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem66),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem67),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem68),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem11),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem75),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeSheetTabColorItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem76),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem13),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem77)});
            this.spreadsheetCommandBarSubItem10.Name = "spreadsheetCommandBarSubItem10";
            // 
            // spreadsheetCommandBarButtonItem64
            // 
            this.spreadsheetCommandBarButtonItem64.CommandName = "FormatRowHeight";
            this.spreadsheetCommandBarButtonItem64.Id = 400;
            this.spreadsheetCommandBarButtonItem64.Name = "spreadsheetCommandBarButtonItem64";
            // 
            // spreadsheetCommandBarButtonItem65
            // 
            this.spreadsheetCommandBarButtonItem65.CommandName = "FormatAutoFitRowHeight";
            this.spreadsheetCommandBarButtonItem65.Id = 401;
            this.spreadsheetCommandBarButtonItem65.Name = "spreadsheetCommandBarButtonItem65";
            // 
            // spreadsheetCommandBarButtonItem66
            // 
            this.spreadsheetCommandBarButtonItem66.CommandName = "FormatColumnWidth";
            this.spreadsheetCommandBarButtonItem66.Id = 402;
            this.spreadsheetCommandBarButtonItem66.Name = "spreadsheetCommandBarButtonItem66";
            // 
            // spreadsheetCommandBarButtonItem67
            // 
            this.spreadsheetCommandBarButtonItem67.CommandName = "FormatAutoFitColumnWidth";
            this.spreadsheetCommandBarButtonItem67.Id = 403;
            this.spreadsheetCommandBarButtonItem67.Name = "spreadsheetCommandBarButtonItem67";
            // 
            // spreadsheetCommandBarButtonItem68
            // 
            this.spreadsheetCommandBarButtonItem68.CommandName = "FormatDefaultColumnWidth";
            this.spreadsheetCommandBarButtonItem68.Id = 404;
            this.spreadsheetCommandBarButtonItem68.Name = "spreadsheetCommandBarButtonItem68";
            // 
            // spreadsheetCommandBarSubItem11
            // 
            this.spreadsheetCommandBarSubItem11.CommandName = "HideAndUnhideCommandGroup";
            this.spreadsheetCommandBarSubItem11.Id = 411;
            this.spreadsheetCommandBarSubItem11.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem69),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem70),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem71),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem72),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem73),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem74)});
            this.spreadsheetCommandBarSubItem11.Name = "spreadsheetCommandBarSubItem11";
            // 
            // spreadsheetCommandBarButtonItem69
            // 
            this.spreadsheetCommandBarButtonItem69.CommandName = "HideRows";
            this.spreadsheetCommandBarButtonItem69.Id = 405;
            this.spreadsheetCommandBarButtonItem69.Name = "spreadsheetCommandBarButtonItem69";
            // 
            // spreadsheetCommandBarButtonItem70
            // 
            this.spreadsheetCommandBarButtonItem70.CommandName = "HideColumns";
            this.spreadsheetCommandBarButtonItem70.Id = 406;
            this.spreadsheetCommandBarButtonItem70.Name = "spreadsheetCommandBarButtonItem70";
            // 
            // spreadsheetCommandBarButtonItem71
            // 
            this.spreadsheetCommandBarButtonItem71.CommandName = "HideSheet";
            this.spreadsheetCommandBarButtonItem71.Id = 407;
            this.spreadsheetCommandBarButtonItem71.Name = "spreadsheetCommandBarButtonItem71";
            // 
            // spreadsheetCommandBarButtonItem72
            // 
            this.spreadsheetCommandBarButtonItem72.CommandName = "UnhideRows";
            this.spreadsheetCommandBarButtonItem72.Id = 408;
            this.spreadsheetCommandBarButtonItem72.Name = "spreadsheetCommandBarButtonItem72";
            // 
            // spreadsheetCommandBarButtonItem73
            // 
            this.spreadsheetCommandBarButtonItem73.CommandName = "UnhideColumns";
            this.spreadsheetCommandBarButtonItem73.Id = 409;
            this.spreadsheetCommandBarButtonItem73.Name = "spreadsheetCommandBarButtonItem73";
            // 
            // spreadsheetCommandBarButtonItem74
            // 
            this.spreadsheetCommandBarButtonItem74.CommandName = "UnhideSheet";
            this.spreadsheetCommandBarButtonItem74.Id = 410;
            this.spreadsheetCommandBarButtonItem74.Name = "spreadsheetCommandBarButtonItem74";
            // 
            // spreadsheetCommandBarButtonItem75
            // 
            this.spreadsheetCommandBarButtonItem75.CommandName = "RenameSheet";
            this.spreadsheetCommandBarButtonItem75.Id = 412;
            this.spreadsheetCommandBarButtonItem75.Name = "spreadsheetCommandBarButtonItem75";
            // 
            // changeSheetTabColorItem1
            // 
            this.changeSheetTabColorItem1.ActAsDropDown = true;
            this.changeSheetTabColorItem1.Id = 413;
            this.changeSheetTabColorItem1.Name = "changeSheetTabColorItem1";
            // 
            // spreadsheetCommandBarButtonItem76
            // 
            this.spreadsheetCommandBarButtonItem76.CommandName = "ReviewProtectSheet";
            this.spreadsheetCommandBarButtonItem76.Id = 414;
            this.spreadsheetCommandBarButtonItem76.Name = "spreadsheetCommandBarButtonItem76";
            // 
            // spreadsheetCommandBarCheckItem13
            // 
            this.spreadsheetCommandBarCheckItem13.CommandName = "FormatCellLocked";
            this.spreadsheetCommandBarCheckItem13.Id = 415;
            this.spreadsheetCommandBarCheckItem13.Name = "spreadsheetCommandBarCheckItem13";
            // 
            // spreadsheetCommandBarButtonItem77
            // 
            this.spreadsheetCommandBarButtonItem77.CommandName = "FormatCellsContextMenuItem";
            this.spreadsheetCommandBarButtonItem77.Id = 416;
            this.spreadsheetCommandBarButtonItem77.Name = "spreadsheetCommandBarButtonItem77";
            // 
            // spreadsheetCommandBarSubItem12
            // 
            this.spreadsheetCommandBarSubItem12.CommandName = "EditingAutoSumCommandGroup";
            this.spreadsheetCommandBarSubItem12.Id = 417;
            this.spreadsheetCommandBarSubItem12.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem78),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem79),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem80),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem81),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem82)});
            this.spreadsheetCommandBarSubItem12.Name = "spreadsheetCommandBarSubItem12";
            this.spreadsheetCommandBarSubItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem78
            // 
            this.spreadsheetCommandBarButtonItem78.CommandName = "FunctionsInsertSum";
            this.spreadsheetCommandBarButtonItem78.Id = 418;
            this.spreadsheetCommandBarButtonItem78.Name = "spreadsheetCommandBarButtonItem78";
            // 
            // spreadsheetCommandBarButtonItem79
            // 
            this.spreadsheetCommandBarButtonItem79.CommandName = "FunctionsInsertAverage";
            this.spreadsheetCommandBarButtonItem79.Id = 419;
            this.spreadsheetCommandBarButtonItem79.Name = "spreadsheetCommandBarButtonItem79";
            // 
            // spreadsheetCommandBarButtonItem80
            // 
            this.spreadsheetCommandBarButtonItem80.CommandName = "FunctionsInsertCountNumbers";
            this.spreadsheetCommandBarButtonItem80.Id = 420;
            this.spreadsheetCommandBarButtonItem80.Name = "spreadsheetCommandBarButtonItem80";
            // 
            // spreadsheetCommandBarButtonItem81
            // 
            this.spreadsheetCommandBarButtonItem81.CommandName = "FunctionsInsertMax";
            this.spreadsheetCommandBarButtonItem81.Id = 421;
            this.spreadsheetCommandBarButtonItem81.Name = "spreadsheetCommandBarButtonItem81";
            // 
            // spreadsheetCommandBarButtonItem82
            // 
            this.spreadsheetCommandBarButtonItem82.CommandName = "FunctionsInsertMin";
            this.spreadsheetCommandBarButtonItem82.Id = 422;
            this.spreadsheetCommandBarButtonItem82.Name = "spreadsheetCommandBarButtonItem82";
            // 
            // spreadsheetCommandBarSubItem13
            // 
            this.spreadsheetCommandBarSubItem13.CommandName = "EditingFillCommandGroup";
            this.spreadsheetCommandBarSubItem13.Id = 423;
            this.spreadsheetCommandBarSubItem13.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem83),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem84),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem85),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem86)});
            this.spreadsheetCommandBarSubItem13.Name = "spreadsheetCommandBarSubItem13";
            this.spreadsheetCommandBarSubItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem83
            // 
            this.spreadsheetCommandBarButtonItem83.CommandName = "EditingFillDown";
            this.spreadsheetCommandBarButtonItem83.Id = 424;
            this.spreadsheetCommandBarButtonItem83.Name = "spreadsheetCommandBarButtonItem83";
            // 
            // spreadsheetCommandBarButtonItem84
            // 
            this.spreadsheetCommandBarButtonItem84.CommandName = "EditingFillRight";
            this.spreadsheetCommandBarButtonItem84.Id = 425;
            this.spreadsheetCommandBarButtonItem84.Name = "spreadsheetCommandBarButtonItem84";
            // 
            // spreadsheetCommandBarButtonItem85
            // 
            this.spreadsheetCommandBarButtonItem85.CommandName = "EditingFillUp";
            this.spreadsheetCommandBarButtonItem85.Id = 426;
            this.spreadsheetCommandBarButtonItem85.Name = "spreadsheetCommandBarButtonItem85";
            // 
            // spreadsheetCommandBarButtonItem86
            // 
            this.spreadsheetCommandBarButtonItem86.CommandName = "EditingFillLeft";
            this.spreadsheetCommandBarButtonItem86.Id = 427;
            this.spreadsheetCommandBarButtonItem86.Name = "spreadsheetCommandBarButtonItem86";
            // 
            // spreadsheetCommandBarSubItem14
            // 
            this.spreadsheetCommandBarSubItem14.CommandName = "FormatClearCommandGroup";
            this.spreadsheetCommandBarSubItem14.Id = 428;
            this.spreadsheetCommandBarSubItem14.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem87),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem88),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem89),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem90),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem91),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem92)});
            this.spreadsheetCommandBarSubItem14.Name = "spreadsheetCommandBarSubItem14";
            this.spreadsheetCommandBarSubItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem87
            // 
            this.spreadsheetCommandBarButtonItem87.CommandName = "FormatClearAll";
            this.spreadsheetCommandBarButtonItem87.Id = 429;
            this.spreadsheetCommandBarButtonItem87.Name = "spreadsheetCommandBarButtonItem87";
            // 
            // spreadsheetCommandBarButtonItem88
            // 
            this.spreadsheetCommandBarButtonItem88.CommandName = "FormatClearFormats";
            this.spreadsheetCommandBarButtonItem88.Id = 430;
            this.spreadsheetCommandBarButtonItem88.Name = "spreadsheetCommandBarButtonItem88";
            // 
            // spreadsheetCommandBarButtonItem89
            // 
            this.spreadsheetCommandBarButtonItem89.CommandName = "FormatClearContents";
            this.spreadsheetCommandBarButtonItem89.Id = 431;
            this.spreadsheetCommandBarButtonItem89.Name = "spreadsheetCommandBarButtonItem89";
            // 
            // spreadsheetCommandBarButtonItem90
            // 
            this.spreadsheetCommandBarButtonItem90.CommandName = "FormatClearComments";
            this.spreadsheetCommandBarButtonItem90.Id = 432;
            this.spreadsheetCommandBarButtonItem90.Name = "spreadsheetCommandBarButtonItem90";
            // 
            // spreadsheetCommandBarButtonItem91
            // 
            this.spreadsheetCommandBarButtonItem91.CommandName = "FormatClearHyperlinks";
            this.spreadsheetCommandBarButtonItem91.Id = 433;
            this.spreadsheetCommandBarButtonItem91.Name = "spreadsheetCommandBarButtonItem91";
            // 
            // spreadsheetCommandBarButtonItem92
            // 
            this.spreadsheetCommandBarButtonItem92.CommandName = "FormatRemoveHyperlinks";
            this.spreadsheetCommandBarButtonItem92.Id = 434;
            this.spreadsheetCommandBarButtonItem92.Name = "spreadsheetCommandBarButtonItem92";
            // 
            // spreadsheetCommandBarSubItem15
            // 
            this.spreadsheetCommandBarSubItem15.CommandName = "EditingSortAndFilterCommandGroup";
            this.spreadsheetCommandBarSubItem15.Id = 435;
            this.spreadsheetCommandBarSubItem15.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem93),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem94)});
            this.spreadsheetCommandBarSubItem15.Name = "spreadsheetCommandBarSubItem15";
            // 
            // spreadsheetCommandBarButtonItem93
            // 
            this.spreadsheetCommandBarButtonItem93.CommandName = "DataSortAscending";
            this.spreadsheetCommandBarButtonItem93.Id = 436;
            this.spreadsheetCommandBarButtonItem93.Name = "spreadsheetCommandBarButtonItem93";
            // 
            // spreadsheetCommandBarButtonItem94
            // 
            this.spreadsheetCommandBarButtonItem94.CommandName = "DataSortDescending";
            this.spreadsheetCommandBarButtonItem94.Id = 437;
            this.spreadsheetCommandBarButtonItem94.Name = "spreadsheetCommandBarButtonItem94";
            // 
            // spreadsheetCommandBarSubItem16
            // 
            this.spreadsheetCommandBarSubItem16.CommandName = "EditingFindAndSelectCommandGroup";
            this.spreadsheetCommandBarSubItem16.Id = 438;
            this.spreadsheetCommandBarSubItem16.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem95),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem96)});
            this.spreadsheetCommandBarSubItem16.Name = "spreadsheetCommandBarSubItem16";
            // 
            // spreadsheetCommandBarButtonItem95
            // 
            this.spreadsheetCommandBarButtonItem95.CommandName = "EditingFind";
            this.spreadsheetCommandBarButtonItem95.Id = 439;
            this.spreadsheetCommandBarButtonItem95.Name = "spreadsheetCommandBarButtonItem95";
            // 
            // spreadsheetCommandBarButtonItem96
            // 
            this.spreadsheetCommandBarButtonItem96.CommandName = "EditingReplace";
            this.spreadsheetCommandBarButtonItem96.Id = 440;
            this.spreadsheetCommandBarButtonItem96.Name = "spreadsheetCommandBarButtonItem96";
            // 
            // spreadsheetCommandBarButtonItem97
            // 
            this.spreadsheetCommandBarButtonItem97.CommandName = "InsertTable";
            this.spreadsheetCommandBarButtonItem97.Id = 441;
            this.spreadsheetCommandBarButtonItem97.Name = "spreadsheetCommandBarButtonItem97";
            // 
            // spreadsheetCommandBarButtonItem98
            // 
            this.spreadsheetCommandBarButtonItem98.CommandName = "InsertPicture";
            this.spreadsheetCommandBarButtonItem98.Id = 442;
            this.spreadsheetCommandBarButtonItem98.Name = "spreadsheetCommandBarButtonItem98";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem4
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem4.CommandName = "InsertChartColumnCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem4.DropDownControl = this.commandBarGalleryDropDown6;
            this.spreadsheetCommandBarButtonGalleryDropDownItem4.Id = 443;
            this.spreadsheetCommandBarButtonGalleryDropDownItem4.Name = "spreadsheetCommandBarButtonGalleryDropDownItem4";
            // 
            // commandBarGalleryDropDown6
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown6.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup8.CommandName = "InsertChartColumn2DCommandGroup";
            spreadsheetCommandGalleryItem56.CommandName = "InsertChartColumnClustered2D";
            spreadsheetCommandGalleryItem57.CommandName = "InsertChartColumnStacked2D";
            spreadsheetCommandGalleryItem58.CommandName = "InsertChartColumnPercentStacked2D";
            spreadsheetCommandGalleryItemGroup8.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem56,
            spreadsheetCommandGalleryItem57,
            spreadsheetCommandGalleryItem58});
            spreadsheetCommandGalleryItemGroup9.CommandName = "InsertChartColumn3DCommandGroup";
            spreadsheetCommandGalleryItem59.CommandName = "InsertChartColumnClustered3D";
            spreadsheetCommandGalleryItem60.CommandName = "InsertChartColumnStacked3D";
            spreadsheetCommandGalleryItem61.CommandName = "InsertChartColumnPercentStacked3D";
            spreadsheetCommandGalleryItem62.CommandName = "InsertChartColumn3D";
            spreadsheetCommandGalleryItemGroup9.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem59,
            spreadsheetCommandGalleryItem60,
            spreadsheetCommandGalleryItem61,
            spreadsheetCommandGalleryItem62});
            spreadsheetCommandGalleryItemGroup10.CommandName = "InsertChartCylinderCommandGroup";
            spreadsheetCommandGalleryItem63.CommandName = "InsertChartCylinderClustered";
            spreadsheetCommandGalleryItem64.CommandName = "InsertChartCylinderStacked";
            spreadsheetCommandGalleryItem65.CommandName = "InsertChartCylinderPercentStacked";
            spreadsheetCommandGalleryItem66.CommandName = "InsertChartCylinder";
            spreadsheetCommandGalleryItemGroup10.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem63,
            spreadsheetCommandGalleryItem64,
            spreadsheetCommandGalleryItem65,
            spreadsheetCommandGalleryItem66});
            spreadsheetCommandGalleryItemGroup11.CommandName = "InsertChartConeCommandGroup";
            spreadsheetCommandGalleryItem67.CommandName = "InsertChartConeClustered";
            spreadsheetCommandGalleryItem68.CommandName = "InsertChartConeStacked";
            spreadsheetCommandGalleryItem69.CommandName = "InsertChartConePercentStacked";
            spreadsheetCommandGalleryItem70.CommandName = "InsertChartCone";
            spreadsheetCommandGalleryItemGroup11.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem67,
            spreadsheetCommandGalleryItem68,
            spreadsheetCommandGalleryItem69,
            spreadsheetCommandGalleryItem70});
            spreadsheetCommandGalleryItemGroup12.CommandName = "InsertChartPyramidCommandGroup";
            spreadsheetCommandGalleryItem71.CommandName = "InsertChartPyramidClustered";
            spreadsheetCommandGalleryItem72.CommandName = "InsertChartPyramidStacked";
            spreadsheetCommandGalleryItem73.CommandName = "InsertChartPyramidPercentStacked";
            spreadsheetCommandGalleryItem74.CommandName = "InsertChartPyramid";
            spreadsheetCommandGalleryItemGroup12.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem71,
            spreadsheetCommandGalleryItem72,
            spreadsheetCommandGalleryItem73,
            spreadsheetCommandGalleryItem74});
            this.commandBarGalleryDropDown6.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup8,
            spreadsheetCommandGalleryItemGroup9,
            spreadsheetCommandGalleryItemGroup10,
            spreadsheetCommandGalleryItemGroup11,
            spreadsheetCommandGalleryItemGroup12});
            this.commandBarGalleryDropDown6.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6";
            this.commandBarGalleryDropDown6.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem5
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem5.CommandName = "InsertChartLineCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem5.DropDownControl = this.commandBarGalleryDropDown7;
            this.spreadsheetCommandBarButtonGalleryDropDownItem5.Id = 444;
            this.spreadsheetCommandBarButtonGalleryDropDownItem5.Name = "spreadsheetCommandBarButtonGalleryDropDownItem5";
            // 
            // commandBarGalleryDropDown7
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown7.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup13.CommandName = "InsertChartLine2DCommandGroup";
            spreadsheetCommandGalleryItem75.CommandName = "InsertChartLine";
            spreadsheetCommandGalleryItem76.CommandName = "InsertChartStackedLine";
            spreadsheetCommandGalleryItem77.CommandName = "InsertChartPercentStackedLine";
            spreadsheetCommandGalleryItem78.CommandName = "InsertChartLineWithMarkers";
            spreadsheetCommandGalleryItem79.CommandName = "InsertChartStackedLineWithMarkers";
            spreadsheetCommandGalleryItem80.CommandName = "InsertChartPercentStackedLineWithMarkers";
            spreadsheetCommandGalleryItemGroup13.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem75,
            spreadsheetCommandGalleryItem76,
            spreadsheetCommandGalleryItem77,
            spreadsheetCommandGalleryItem78,
            spreadsheetCommandGalleryItem79,
            spreadsheetCommandGalleryItem80});
            spreadsheetCommandGalleryItemGroup14.CommandName = "InsertChartLine3DCommandGroup";
            spreadsheetCommandGalleryItem81.CommandName = "InsertChartLine3D";
            spreadsheetCommandGalleryItemGroup14.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem81});
            this.commandBarGalleryDropDown7.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup13,
            spreadsheetCommandGalleryItemGroup14});
            this.commandBarGalleryDropDown7.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7";
            this.commandBarGalleryDropDown7.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem6
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem6.CommandName = "InsertChartPieCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem6.DropDownControl = this.commandBarGalleryDropDown8;
            this.spreadsheetCommandBarButtonGalleryDropDownItem6.Id = 445;
            this.spreadsheetCommandBarButtonGalleryDropDownItem6.Name = "spreadsheetCommandBarButtonGalleryDropDownItem6";
            // 
            // commandBarGalleryDropDown8
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown8.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup15.CommandName = "InsertChartPie2DCommandGroup";
            spreadsheetCommandGalleryItem82.CommandName = "InsertChartPie2D";
            spreadsheetCommandGalleryItem83.CommandName = "InsertChartPieExploded2D";
            spreadsheetCommandGalleryItemGroup15.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem82,
            spreadsheetCommandGalleryItem83});
            spreadsheetCommandGalleryItemGroup16.CommandName = "InsertChartPie3DCommandGroup";
            spreadsheetCommandGalleryItem84.CommandName = "InsertChartPie3D";
            spreadsheetCommandGalleryItem85.CommandName = "InsertChartPieExploded3D";
            spreadsheetCommandGalleryItemGroup16.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem84,
            spreadsheetCommandGalleryItem85});
            spreadsheetCommandGalleryItemGroup17.CommandName = "InsertChartDoughnut2DCommandGroup";
            spreadsheetCommandGalleryItem86.CommandName = "InsertChartDoughnut2D";
            spreadsheetCommandGalleryItem87.CommandName = "InsertChartDoughnutExploded2D";
            spreadsheetCommandGalleryItemGroup17.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem86,
            spreadsheetCommandGalleryItem87});
            this.commandBarGalleryDropDown8.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup15,
            spreadsheetCommandGalleryItemGroup16,
            spreadsheetCommandGalleryItemGroup17});
            this.commandBarGalleryDropDown8.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8";
            this.commandBarGalleryDropDown8.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem7
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem7.CommandName = "InsertChartBarCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem7.DropDownControl = this.commandBarGalleryDropDown9;
            this.spreadsheetCommandBarButtonGalleryDropDownItem7.Id = 446;
            this.spreadsheetCommandBarButtonGalleryDropDownItem7.Name = "spreadsheetCommandBarButtonGalleryDropDownItem7";
            // 
            // commandBarGalleryDropDown9
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown9.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup18.CommandName = "InsertChartBar2DCommandGroup";
            spreadsheetCommandGalleryItem88.CommandName = "InsertChartBarClustered2D";
            spreadsheetCommandGalleryItem89.CommandName = "InsertChartBarStacked2D";
            spreadsheetCommandGalleryItem90.CommandName = "InsertChartBarPercentStacked2D";
            spreadsheetCommandGalleryItemGroup18.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem88,
            spreadsheetCommandGalleryItem89,
            spreadsheetCommandGalleryItem90});
            spreadsheetCommandGalleryItemGroup19.CommandName = "InsertChartBar3DCommandGroup";
            spreadsheetCommandGalleryItem91.CommandName = "InsertChartBarClustered3D";
            spreadsheetCommandGalleryItem92.CommandName = "InsertChartBarStacked3D";
            spreadsheetCommandGalleryItem93.CommandName = "InsertChartBarPercentStacked3D";
            spreadsheetCommandGalleryItemGroup19.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem91,
            spreadsheetCommandGalleryItem92,
            spreadsheetCommandGalleryItem93});
            spreadsheetCommandGalleryItemGroup20.CommandName = "InsertChartHorizontalCylinderCommandGroup";
            spreadsheetCommandGalleryItem94.CommandName = "InsertChartHorizontalCylinderClustered";
            spreadsheetCommandGalleryItem95.CommandName = "InsertChartHorizontalCylinderStacked";
            spreadsheetCommandGalleryItem96.CommandName = "InsertChartHorizontalCylinderPercentStacked";
            spreadsheetCommandGalleryItemGroup20.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem94,
            spreadsheetCommandGalleryItem95,
            spreadsheetCommandGalleryItem96});
            spreadsheetCommandGalleryItemGroup21.CommandName = "InsertChartHorizontalConeCommandGroup";
            spreadsheetCommandGalleryItem97.CommandName = "InsertChartHorizontalConeClustered";
            spreadsheetCommandGalleryItem98.CommandName = "InsertChartHorizontalConeStacked";
            spreadsheetCommandGalleryItem99.CommandName = "InsertChartHorizontalConePercentStacked";
            spreadsheetCommandGalleryItemGroup21.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem97,
            spreadsheetCommandGalleryItem98,
            spreadsheetCommandGalleryItem99});
            spreadsheetCommandGalleryItemGroup22.CommandName = "InsertChartHorizontalPyramidCommandGroup";
            spreadsheetCommandGalleryItem100.CommandName = "InsertChartHorizontalPyramidClustered";
            spreadsheetCommandGalleryItem101.CommandName = "InsertChartHorizontalPyramidStacked";
            spreadsheetCommandGalleryItem102.CommandName = "InsertChartHorizontalPyramidPercentStacked";
            spreadsheetCommandGalleryItemGroup22.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem100,
            spreadsheetCommandGalleryItem101,
            spreadsheetCommandGalleryItem102});
            this.commandBarGalleryDropDown9.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup18,
            spreadsheetCommandGalleryItemGroup19,
            spreadsheetCommandGalleryItemGroup20,
            spreadsheetCommandGalleryItemGroup21,
            spreadsheetCommandGalleryItemGroup22});
            this.commandBarGalleryDropDown9.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown9.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown9.Name = "commandBarGalleryDropDown9";
            this.commandBarGalleryDropDown9.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem8
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem8.CommandName = "InsertChartAreaCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem8.DropDownControl = this.commandBarGalleryDropDown10;
            this.spreadsheetCommandBarButtonGalleryDropDownItem8.Id = 447;
            this.spreadsheetCommandBarButtonGalleryDropDownItem8.Name = "spreadsheetCommandBarButtonGalleryDropDownItem8";
            // 
            // commandBarGalleryDropDown10
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown10.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup23.CommandName = "InsertChartArea2DCommandGroup";
            spreadsheetCommandGalleryItem103.CommandName = "InsertChartArea";
            spreadsheetCommandGalleryItem104.CommandName = "InsertChartStackedArea";
            spreadsheetCommandGalleryItem105.CommandName = "InsertChartPercentStackedArea";
            spreadsheetCommandGalleryItemGroup23.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem103,
            spreadsheetCommandGalleryItem104,
            spreadsheetCommandGalleryItem105});
            spreadsheetCommandGalleryItemGroup24.CommandName = "InsertChartArea3DCommandGroup";
            spreadsheetCommandGalleryItem106.CommandName = "InsertChartArea3D";
            spreadsheetCommandGalleryItem107.CommandName = "InsertChartStackedArea3D";
            spreadsheetCommandGalleryItem108.CommandName = "InsertChartPercentStackedArea3D";
            spreadsheetCommandGalleryItemGroup24.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem106,
            spreadsheetCommandGalleryItem107,
            spreadsheetCommandGalleryItem108});
            this.commandBarGalleryDropDown10.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup23,
            spreadsheetCommandGalleryItemGroup24});
            this.commandBarGalleryDropDown10.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown10.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown10.Name = "commandBarGalleryDropDown10";
            this.commandBarGalleryDropDown10.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem9
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem9.CommandName = "InsertChartScatterCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem9.DropDownControl = this.commandBarGalleryDropDown11;
            this.spreadsheetCommandBarButtonGalleryDropDownItem9.Id = 448;
            this.spreadsheetCommandBarButtonGalleryDropDownItem9.Name = "spreadsheetCommandBarButtonGalleryDropDownItem9";
            // 
            // commandBarGalleryDropDown11
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown11.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup25.CommandName = "InsertChartScatterCommandGroup";
            spreadsheetCommandGalleryItem109.CommandName = "InsertChartScatterMarkers";
            spreadsheetCommandGalleryItem110.CommandName = "InsertChartScatterSmoothLinesAndMarkers";
            spreadsheetCommandGalleryItem111.CommandName = "InsertChartScatterSmoothLines";
            spreadsheetCommandGalleryItem112.CommandName = "InsertChartScatterLinesAndMarkers";
            spreadsheetCommandGalleryItem113.CommandName = "InsertChartScatterLines";
            spreadsheetCommandGalleryItemGroup25.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem109,
            spreadsheetCommandGalleryItem110,
            spreadsheetCommandGalleryItem111,
            spreadsheetCommandGalleryItem112,
            spreadsheetCommandGalleryItem113});
            spreadsheetCommandGalleryItemGroup26.CommandName = "InsertChartBubbleCommandGroup";
            spreadsheetCommandGalleryItem114.CommandName = "InsertChartBubble";
            spreadsheetCommandGalleryItem115.CommandName = "InsertChartBubble3D";
            spreadsheetCommandGalleryItemGroup26.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem114,
            spreadsheetCommandGalleryItem115});
            this.commandBarGalleryDropDown11.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup25,
            spreadsheetCommandGalleryItemGroup26});
            this.commandBarGalleryDropDown11.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown11.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown11.Name = "commandBarGalleryDropDown11";
            this.commandBarGalleryDropDown11.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem10
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem10.CommandName = "InsertChartOtherCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem10.DropDownControl = this.commandBarGalleryDropDown12;
            this.spreadsheetCommandBarButtonGalleryDropDownItem10.Id = 449;
            this.spreadsheetCommandBarButtonGalleryDropDownItem10.Name = "spreadsheetCommandBarButtonGalleryDropDownItem10";
            // 
            // commandBarGalleryDropDown12
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown12.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup27.CommandName = "InsertChartStockCommandGroup";
            spreadsheetCommandGalleryItem116.CommandName = "InsertChartStockHighLowClose";
            spreadsheetCommandGalleryItem117.CommandName = "InsertChartStockOpenHighLowClose";
            spreadsheetCommandGalleryItemGroup27.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem116,
            spreadsheetCommandGalleryItem117});
            spreadsheetCommandGalleryItemGroup28.CommandName = "InsertChartRadarCommandGroup";
            spreadsheetCommandGalleryItem118.CommandName = "InsertChartRadar";
            spreadsheetCommandGalleryItem119.CommandName = "InsertChartRadarWithMarkers";
            spreadsheetCommandGalleryItem120.CommandName = "InsertChartRadarFilled";
            spreadsheetCommandGalleryItemGroup28.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem118,
            spreadsheetCommandGalleryItem119,
            spreadsheetCommandGalleryItem120});
            this.commandBarGalleryDropDown12.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup27,
            spreadsheetCommandGalleryItemGroup28});
            this.commandBarGalleryDropDown12.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown12.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown12.Name = "commandBarGalleryDropDown12";
            this.commandBarGalleryDropDown12.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonItem99
            // 
            this.spreadsheetCommandBarButtonItem99.CommandName = "InsertHyperlink";
            this.spreadsheetCommandBarButtonItem99.Id = 450;
            this.spreadsheetCommandBarButtonItem99.Name = "spreadsheetCommandBarButtonItem99";
            // 
            // spreadsheetCommandBarButtonItem100
            // 
            this.spreadsheetCommandBarButtonItem100.CommandName = "InsertSymbol";
            this.spreadsheetCommandBarButtonItem100.Id = 451;
            this.spreadsheetCommandBarButtonItem100.Name = "spreadsheetCommandBarButtonItem100";
            // 
            // spreadsheetCommandBarSubItem17
            // 
            this.spreadsheetCommandBarSubItem17.CommandName = "PageSetupMarginsCommandGroup";
            this.spreadsheetCommandBarSubItem17.Id = 452;
            this.spreadsheetCommandBarSubItem17.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem14),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem15),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem16)});
            this.spreadsheetCommandBarSubItem17.Name = "spreadsheetCommandBarSubItem17";
            // 
            // spreadsheetCommandBarCheckItem14
            // 
            this.spreadsheetCommandBarCheckItem14.CaptionDependOnUnits = true;
            this.spreadsheetCommandBarCheckItem14.CommandName = "PageSetupMarginsNormal";
            this.spreadsheetCommandBarCheckItem14.Id = 453;
            this.spreadsheetCommandBarCheckItem14.Name = "spreadsheetCommandBarCheckItem14";
            // 
            // spreadsheetCommandBarCheckItem15
            // 
            this.spreadsheetCommandBarCheckItem15.CaptionDependOnUnits = true;
            this.spreadsheetCommandBarCheckItem15.CommandName = "PageSetupMarginsWide";
            this.spreadsheetCommandBarCheckItem15.Id = 454;
            this.spreadsheetCommandBarCheckItem15.Name = "spreadsheetCommandBarCheckItem15";
            // 
            // spreadsheetCommandBarCheckItem16
            // 
            this.spreadsheetCommandBarCheckItem16.CaptionDependOnUnits = true;
            this.spreadsheetCommandBarCheckItem16.CommandName = "PageSetupMarginsNarrow";
            this.spreadsheetCommandBarCheckItem16.Id = 455;
            this.spreadsheetCommandBarCheckItem16.Name = "spreadsheetCommandBarCheckItem16";
            // 
            // spreadsheetCommandBarSubItem18
            // 
            this.spreadsheetCommandBarSubItem18.CommandName = "PageSetupOrientationCommandGroup";
            this.spreadsheetCommandBarSubItem18.Id = 456;
            this.spreadsheetCommandBarSubItem18.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem17),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem18)});
            this.spreadsheetCommandBarSubItem18.Name = "spreadsheetCommandBarSubItem18";
            // 
            // spreadsheetCommandBarCheckItem17
            // 
            this.spreadsheetCommandBarCheckItem17.CommandName = "PageSetupOrientationPortrait";
            this.spreadsheetCommandBarCheckItem17.Id = 457;
            this.spreadsheetCommandBarCheckItem17.Name = "spreadsheetCommandBarCheckItem17";
            // 
            // spreadsheetCommandBarCheckItem18
            // 
            this.spreadsheetCommandBarCheckItem18.CommandName = "PageSetupOrientationLandscape";
            this.spreadsheetCommandBarCheckItem18.Id = 458;
            this.spreadsheetCommandBarCheckItem18.Name = "spreadsheetCommandBarCheckItem18";
            // 
            // pageSetupPaperKindItem1
            // 
            this.pageSetupPaperKindItem1.Id = 459;
            this.pageSetupPaperKindItem1.Name = "pageSetupPaperKindItem1";
            // 
            // spreadsheetCommandBarSubItem19
            // 
            this.spreadsheetCommandBarSubItem19.CommandName = "PageSetupPrintAreaCommandGroup";
            this.spreadsheetCommandBarSubItem19.Id = 460;
            this.spreadsheetCommandBarSubItem19.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem101),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem102)});
            this.spreadsheetCommandBarSubItem19.Name = "spreadsheetCommandBarSubItem19";
            // 
            // spreadsheetCommandBarButtonItem101
            // 
            this.spreadsheetCommandBarButtonItem101.CommandName = "PageSetupSetPrintArea";
            this.spreadsheetCommandBarButtonItem101.Id = 461;
            this.spreadsheetCommandBarButtonItem101.Name = "spreadsheetCommandBarButtonItem101";
            // 
            // spreadsheetCommandBarButtonItem102
            // 
            this.spreadsheetCommandBarButtonItem102.CommandName = "PageSetupClearPrintArea";
            this.spreadsheetCommandBarButtonItem102.Id = 462;
            this.spreadsheetCommandBarButtonItem102.Name = "spreadsheetCommandBarButtonItem102";
            // 
            // spreadsheetCommandBarCheckItem19
            // 
            this.spreadsheetCommandBarCheckItem19.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem19.CommandName = "ViewShowGridlines";
            this.spreadsheetCommandBarCheckItem19.Id = 463;
            this.spreadsheetCommandBarCheckItem19.Name = "spreadsheetCommandBarCheckItem19";
            // 
            // spreadsheetCommandBarCheckItem20
            // 
            this.spreadsheetCommandBarCheckItem20.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem20.CommandName = "ViewShowHeadings";
            this.spreadsheetCommandBarCheckItem20.Id = 464;
            this.spreadsheetCommandBarCheckItem20.Name = "spreadsheetCommandBarCheckItem20";
            // 
            // spreadsheetCommandBarCheckItem21
            // 
            this.spreadsheetCommandBarCheckItem21.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem21.CommandName = "PageSetupPrintGridlines";
            this.spreadsheetCommandBarCheckItem21.Id = 465;
            this.spreadsheetCommandBarCheckItem21.Name = "spreadsheetCommandBarCheckItem21";
            // 
            // spreadsheetCommandBarCheckItem22
            // 
            this.spreadsheetCommandBarCheckItem22.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem22.CommandName = "PageSetupPrintHeadings";
            this.spreadsheetCommandBarCheckItem22.Id = 466;
            this.spreadsheetCommandBarCheckItem22.Name = "spreadsheetCommandBarCheckItem22";
            // 
            // spreadsheetCommandBarSubItem20
            // 
            this.spreadsheetCommandBarSubItem20.CommandName = "ArrangeBringForwardCommandGroup";
            this.spreadsheetCommandBarSubItem20.Id = 467;
            this.spreadsheetCommandBarSubItem20.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem103),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem104)});
            this.spreadsheetCommandBarSubItem20.Name = "spreadsheetCommandBarSubItem20";
            // 
            // spreadsheetCommandBarButtonItem103
            // 
            this.spreadsheetCommandBarButtonItem103.CommandName = "ArrangeBringForward";
            this.spreadsheetCommandBarButtonItem103.Id = 468;
            this.spreadsheetCommandBarButtonItem103.Name = "spreadsheetCommandBarButtonItem103";
            // 
            // spreadsheetCommandBarButtonItem104
            // 
            this.spreadsheetCommandBarButtonItem104.CommandName = "ArrangeBringToFront";
            this.spreadsheetCommandBarButtonItem104.Id = 469;
            this.spreadsheetCommandBarButtonItem104.Name = "spreadsheetCommandBarButtonItem104";
            // 
            // spreadsheetCommandBarSubItem21
            // 
            this.spreadsheetCommandBarSubItem21.CommandName = "ArrangeSendBackwardCommandGroup";
            this.spreadsheetCommandBarSubItem21.Id = 470;
            this.spreadsheetCommandBarSubItem21.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem105),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem106)});
            this.spreadsheetCommandBarSubItem21.Name = "spreadsheetCommandBarSubItem21";
            // 
            // spreadsheetCommandBarButtonItem105
            // 
            this.spreadsheetCommandBarButtonItem105.CommandName = "ArrangeSendBackward";
            this.spreadsheetCommandBarButtonItem105.Id = 471;
            this.spreadsheetCommandBarButtonItem105.Name = "spreadsheetCommandBarButtonItem105";
            // 
            // spreadsheetCommandBarButtonItem106
            // 
            this.spreadsheetCommandBarButtonItem106.CommandName = "ArrangeSendToBack";
            this.spreadsheetCommandBarButtonItem106.Id = 472;
            this.spreadsheetCommandBarButtonItem106.Name = "spreadsheetCommandBarButtonItem106";
            // 
            // spreadsheetCommandBarSubItem22
            // 
            this.spreadsheetCommandBarSubItem22.CommandName = "FunctionsAutoSumCommandGroup";
            this.spreadsheetCommandBarSubItem22.Id = 473;
            this.spreadsheetCommandBarSubItem22.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem78),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem79),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem80),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem81),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem82)});
            this.spreadsheetCommandBarSubItem22.Name = "spreadsheetCommandBarSubItem22";
            // 
            // functionsFinancialItem1
            // 
            this.functionsFinancialItem1.Id = 474;
            this.functionsFinancialItem1.Name = "functionsFinancialItem1";
            // 
            // functionsLogicalItem1
            // 
            this.functionsLogicalItem1.Id = 475;
            this.functionsLogicalItem1.Name = "functionsLogicalItem1";
            // 
            // functionsTextItem1
            // 
            this.functionsTextItem1.Id = 476;
            this.functionsTextItem1.Name = "functionsTextItem1";
            // 
            // functionsDateAndTimeItem1
            // 
            this.functionsDateAndTimeItem1.Id = 477;
            this.functionsDateAndTimeItem1.Name = "functionsDateAndTimeItem1";
            // 
            // functionsLookupAndReferenceItem1
            // 
            this.functionsLookupAndReferenceItem1.Id = 478;
            this.functionsLookupAndReferenceItem1.Name = "functionsLookupAndReferenceItem1";
            // 
            // functionsMathAndTrigonometryItem1
            // 
            this.functionsMathAndTrigonometryItem1.Id = 479;
            this.functionsMathAndTrigonometryItem1.Name = "functionsMathAndTrigonometryItem1";
            // 
            // spreadsheetCommandBarSubItem23
            // 
            this.spreadsheetCommandBarSubItem23.CommandName = "FunctionsMoreCommandGroup";
            this.spreadsheetCommandBarSubItem23.Id = 480;
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
            this.functionsStatisticalItem1.Id = 481;
            this.functionsStatisticalItem1.Name = "functionsStatisticalItem1";
            // 
            // functionsEngineeringItem1
            // 
            this.functionsEngineeringItem1.Id = 482;
            this.functionsEngineeringItem1.Name = "functionsEngineeringItem1";
            // 
            // functionsInformationItem1
            // 
            this.functionsInformationItem1.Id = 483;
            this.functionsInformationItem1.Name = "functionsInformationItem1";
            // 
            // functionsCompatibilityItem1
            // 
            this.functionsCompatibilityItem1.Id = 484;
            this.functionsCompatibilityItem1.Name = "functionsCompatibilityItem1";
            // 
            // functionsWebItem1
            // 
            this.functionsWebItem1.Id = 485;
            this.functionsWebItem1.Name = "functionsWebItem1";
            // 
            // spreadsheetCommandBarButtonItem112
            // 
            this.spreadsheetCommandBarButtonItem112.CommandName = "FormulasShowNameManager";
            this.spreadsheetCommandBarButtonItem112.Id = 486;
            this.spreadsheetCommandBarButtonItem112.Name = "spreadsheetCommandBarButtonItem112";
            // 
            // spreadsheetCommandBarButtonItem113
            // 
            this.spreadsheetCommandBarButtonItem113.CommandName = "FormulasDefineNameCommand";
            this.spreadsheetCommandBarButtonItem113.Id = 487;
            this.spreadsheetCommandBarButtonItem113.Name = "spreadsheetCommandBarButtonItem113";
            this.spreadsheetCommandBarButtonItem113.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // definedNameListItem1
            // 
            this.definedNameListItem1.Id = 488;
            this.definedNameListItem1.Name = "definedNameListItem1";
            this.definedNameListItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem114
            // 
            this.spreadsheetCommandBarButtonItem114.CommandName = "FormulasCreateDefinedNamesFromSelection";
            this.spreadsheetCommandBarButtonItem114.Id = 489;
            this.spreadsheetCommandBarButtonItem114.Name = "spreadsheetCommandBarButtonItem114";
            this.spreadsheetCommandBarButtonItem114.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarCheckItem23
            // 
            this.spreadsheetCommandBarCheckItem23.CommandName = "ViewShowFormulas";
            this.spreadsheetCommandBarCheckItem23.Id = 490;
            this.spreadsheetCommandBarCheckItem23.Name = "spreadsheetCommandBarCheckItem23";
            // 
            // spreadsheetCommandBarSubItem24
            // 
            this.spreadsheetCommandBarSubItem24.CommandName = "FormulasCalculationOptionsCommandGroup";
            this.spreadsheetCommandBarSubItem24.Id = 491;
            this.spreadsheetCommandBarSubItem24.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem24),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem25)});
            this.spreadsheetCommandBarSubItem24.Name = "spreadsheetCommandBarSubItem24";
            // 
            // spreadsheetCommandBarCheckItem24
            // 
            this.spreadsheetCommandBarCheckItem24.CommandName = "FormulasCalculationModeAutomatic";
            this.spreadsheetCommandBarCheckItem24.Id = 492;
            this.spreadsheetCommandBarCheckItem24.Name = "spreadsheetCommandBarCheckItem24";
            // 
            // spreadsheetCommandBarCheckItem25
            // 
            this.spreadsheetCommandBarCheckItem25.CommandName = "FormulasCalculationModeManual";
            this.spreadsheetCommandBarCheckItem25.Id = 493;
            this.spreadsheetCommandBarCheckItem25.Name = "spreadsheetCommandBarCheckItem25";
            // 
            // spreadsheetCommandBarButtonItem115
            // 
            this.spreadsheetCommandBarButtonItem115.CommandName = "FormulasCalculateNow";
            this.spreadsheetCommandBarButtonItem115.Id = 494;
            this.spreadsheetCommandBarButtonItem115.Name = "spreadsheetCommandBarButtonItem115";
            this.spreadsheetCommandBarButtonItem115.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem116
            // 
            this.spreadsheetCommandBarButtonItem116.CommandName = "FormulasCalculateSheet";
            this.spreadsheetCommandBarButtonItem116.Id = 495;
            this.spreadsheetCommandBarButtonItem116.Name = "spreadsheetCommandBarButtonItem116";
            this.spreadsheetCommandBarButtonItem116.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem117
            // 
            this.spreadsheetCommandBarButtonItem117.CommandName = "ReviewUnprotectSheet";
            this.spreadsheetCommandBarButtonItem117.Id = 496;
            this.spreadsheetCommandBarButtonItem117.Name = "spreadsheetCommandBarButtonItem117";
            // 
            // spreadsheetCommandBarButtonItem118
            // 
            this.spreadsheetCommandBarButtonItem118.CommandName = "ReviewProtectWorkbook";
            this.spreadsheetCommandBarButtonItem118.Id = 497;
            this.spreadsheetCommandBarButtonItem118.Name = "spreadsheetCommandBarButtonItem118";
            // 
            // spreadsheetCommandBarButtonItem119
            // 
            this.spreadsheetCommandBarButtonItem119.CommandName = "ReviewUnprotectWorkbook";
            this.spreadsheetCommandBarButtonItem119.Id = 498;
            this.spreadsheetCommandBarButtonItem119.Name = "spreadsheetCommandBarButtonItem119";
            // 
            // spreadsheetCommandBarButtonItem120
            // 
            this.spreadsheetCommandBarButtonItem120.CommandName = "ReviewShowProtectedRangeManager";
            this.spreadsheetCommandBarButtonItem120.Id = 499;
            this.spreadsheetCommandBarButtonItem120.Name = "spreadsheetCommandBarButtonItem120";
            // 
            // spreadsheetCommandBarButtonItem121
            // 
            this.spreadsheetCommandBarButtonItem121.CommandName = "ViewZoomOut";
            this.spreadsheetCommandBarButtonItem121.Id = 500;
            this.spreadsheetCommandBarButtonItem121.Name = "spreadsheetCommandBarButtonItem121";
            // 
            // spreadsheetCommandBarButtonItem122
            // 
            this.spreadsheetCommandBarButtonItem122.CommandName = "ViewZoomIn";
            this.spreadsheetCommandBarButtonItem122.Id = 501;
            this.spreadsheetCommandBarButtonItem122.Name = "spreadsheetCommandBarButtonItem122";
            // 
            // spreadsheetCommandBarButtonItem123
            // 
            this.spreadsheetCommandBarButtonItem123.CommandName = "ViewZoom100Percent";
            this.spreadsheetCommandBarButtonItem123.Id = 502;
            this.spreadsheetCommandBarButtonItem123.Name = "spreadsheetCommandBarButtonItem123";
            // 
            // spreadsheetCommandBarSubItem25
            // 
            this.spreadsheetCommandBarSubItem25.CommandName = "ViewFreezePanesCommandGroup";
            this.spreadsheetCommandBarSubItem25.Id = 503;
            this.spreadsheetCommandBarSubItem25.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem124),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem125),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem126),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem127)});
            this.spreadsheetCommandBarSubItem25.Name = "spreadsheetCommandBarSubItem25";
            // 
            // spreadsheetCommandBarButtonItem124
            // 
            this.spreadsheetCommandBarButtonItem124.CommandName = "ViewFreezePanes";
            this.spreadsheetCommandBarButtonItem124.Id = 504;
            this.spreadsheetCommandBarButtonItem124.Name = "spreadsheetCommandBarButtonItem124";
            // 
            // spreadsheetCommandBarButtonItem125
            // 
            this.spreadsheetCommandBarButtonItem125.CommandName = "ViewUnfreezePanes";
            this.spreadsheetCommandBarButtonItem125.Id = 505;
            this.spreadsheetCommandBarButtonItem125.Name = "spreadsheetCommandBarButtonItem125";
            // 
            // spreadsheetCommandBarButtonItem126
            // 
            this.spreadsheetCommandBarButtonItem126.CommandName = "ViewFreezeTopRow";
            this.spreadsheetCommandBarButtonItem126.Id = 506;
            this.spreadsheetCommandBarButtonItem126.Name = "spreadsheetCommandBarButtonItem126";
            // 
            // spreadsheetCommandBarButtonItem127
            // 
            this.spreadsheetCommandBarButtonItem127.CommandName = "ViewFreezeFirstColumn";
            this.spreadsheetCommandBarButtonItem127.Id = 507;
            this.spreadsheetCommandBarButtonItem127.Name = "spreadsheetCommandBarButtonItem127";
            // 
            // spreadsheetCommandBarButtonItem128
            // 
            this.spreadsheetCommandBarButtonItem128.CommandName = "ChartChangeType";
            this.spreadsheetCommandBarButtonItem128.Id = 508;
            this.spreadsheetCommandBarButtonItem128.Name = "spreadsheetCommandBarButtonItem128";
            // 
            // spreadsheetCommandBarButtonItem129
            // 
            this.spreadsheetCommandBarButtonItem129.CommandName = "ChartSwitchRowColumn";
            this.spreadsheetCommandBarButtonItem129.Id = 509;
            this.spreadsheetCommandBarButtonItem129.Name = "spreadsheetCommandBarButtonItem129";
            // 
            // spreadsheetCommandBarButtonItem130
            // 
            this.spreadsheetCommandBarButtonItem130.CommandName = "ChartSelectData";
            this.spreadsheetCommandBarButtonItem130.Id = 510;
            this.spreadsheetCommandBarButtonItem130.Name = "spreadsheetCommandBarButtonItem130";
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
            this.galleryChartLayoutItem1.Id = 511;
            this.galleryChartLayoutItem1.Name = "galleryChartLayoutItem1";
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
            this.galleryChartStyleItem1.Id = 512;
            this.galleryChartStyleItem1.Name = "galleryChartStyleItem1";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem11
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem11.CommandName = "ChartTitleCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem11.DropDownControl = this.commandBarGalleryDropDown13;
            this.spreadsheetCommandBarButtonGalleryDropDownItem11.Id = 513;
            this.spreadsheetCommandBarButtonGalleryDropDownItem11.Name = "spreadsheetCommandBarButtonGalleryDropDownItem11";
            // 
            // commandBarGalleryDropDown13
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown13.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown13.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup29.CommandName = "ChartTitleCommandGroup";
            spreadsheetCommandGalleryItem121.CommandName = "ChartTitleNone";
            spreadsheetCommandGalleryItem122.CommandName = "ChartTitleCenteredOverlay";
            spreadsheetCommandGalleryItem123.CommandName = "ChartTitleAbove";
            spreadsheetCommandGalleryItemGroup29.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem121,
            spreadsheetCommandGalleryItem122,
            spreadsheetCommandGalleryItem123});
            this.commandBarGalleryDropDown13.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup29});
            this.commandBarGalleryDropDown13.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown13.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown13.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown13.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown13.Name = "commandBarGalleryDropDown13";
            this.commandBarGalleryDropDown13.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarSubItem26
            // 
            this.spreadsheetCommandBarSubItem26.CommandName = "ChartAxisTitlesCommandGroup";
            this.spreadsheetCommandBarSubItem26.Id = 514;
            this.spreadsheetCommandBarSubItem26.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem12),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem13)});
            this.spreadsheetCommandBarSubItem26.Name = "spreadsheetCommandBarSubItem26";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem12
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem12.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem12.DropDownControl = this.commandBarGalleryDropDown14;
            this.spreadsheetCommandBarButtonGalleryDropDownItem12.Id = 515;
            this.spreadsheetCommandBarButtonGalleryDropDownItem12.Name = "spreadsheetCommandBarButtonGalleryDropDownItem12";
            // 
            // commandBarGalleryDropDown14
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown14.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown14.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup30.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem124.CommandName = "ChartPrimaryHorizontalAxisTitleNone";
            spreadsheetCommandGalleryItem125.CommandName = "ChartPrimaryHorizontalAxisTitleBelow";
            spreadsheetCommandGalleryItemGroup30.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem124,
            spreadsheetCommandGalleryItem125});
            this.commandBarGalleryDropDown14.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup30});
            this.commandBarGalleryDropDown14.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown14.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown14.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown14.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown14.Name = "commandBarGalleryDropDown14";
            this.commandBarGalleryDropDown14.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem13
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem13.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem13.DropDownControl = this.commandBarGalleryDropDown15;
            this.spreadsheetCommandBarButtonGalleryDropDownItem13.Id = 516;
            this.spreadsheetCommandBarButtonGalleryDropDownItem13.Name = "spreadsheetCommandBarButtonGalleryDropDownItem13";
            // 
            // commandBarGalleryDropDown15
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown15.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown15.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup31.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem126.CommandName = "ChartPrimaryVerticalAxisTitleNone";
            spreadsheetCommandGalleryItem127.CommandName = "ChartPrimaryVerticalAxisTitleRotated";
            spreadsheetCommandGalleryItem128.CommandName = "ChartPrimaryVerticalAxisTitleVertical";
            spreadsheetCommandGalleryItem129.CommandName = "ChartPrimaryVerticalAxisTitleHorizontal";
            spreadsheetCommandGalleryItemGroup31.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem126,
            spreadsheetCommandGalleryItem127,
            spreadsheetCommandGalleryItem128,
            spreadsheetCommandGalleryItem129});
            this.commandBarGalleryDropDown15.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup31});
            this.commandBarGalleryDropDown15.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown15.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown15.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown15.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown15.Name = "commandBarGalleryDropDown15";
            this.commandBarGalleryDropDown15.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem14
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem14.CommandName = "ChartLegendCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem14.DropDownControl = this.commandBarGalleryDropDown16;
            this.spreadsheetCommandBarButtonGalleryDropDownItem14.Id = 517;
            this.spreadsheetCommandBarButtonGalleryDropDownItem14.Name = "spreadsheetCommandBarButtonGalleryDropDownItem14";
            // 
            // commandBarGalleryDropDown16
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown16.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown16.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup32.CommandName = "ChartLegendCommandGroup";
            spreadsheetCommandGalleryItem130.CommandName = "ChartLegendNone";
            spreadsheetCommandGalleryItem131.CommandName = "ChartLegendAtRight";
            spreadsheetCommandGalleryItem132.CommandName = "ChartLegendAtTop";
            spreadsheetCommandGalleryItem133.CommandName = "ChartLegendAtLeft";
            spreadsheetCommandGalleryItem134.CommandName = "ChartLegendAtBottom";
            spreadsheetCommandGalleryItem135.CommandName = "ChartLegendOverlayAtRight";
            spreadsheetCommandGalleryItem136.CommandName = "ChartLegendOverlayAtLeft";
            spreadsheetCommandGalleryItemGroup32.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem130,
            spreadsheetCommandGalleryItem131,
            spreadsheetCommandGalleryItem132,
            spreadsheetCommandGalleryItem133,
            spreadsheetCommandGalleryItem134,
            spreadsheetCommandGalleryItem135,
            spreadsheetCommandGalleryItem136});
            this.commandBarGalleryDropDown16.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup32});
            this.commandBarGalleryDropDown16.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown16.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown16.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown16.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown16.Name = "commandBarGalleryDropDown16";
            this.commandBarGalleryDropDown16.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem15
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem15.CommandName = "ChartDataLabelsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem15.DropDownControl = this.commandBarGalleryDropDown17;
            this.spreadsheetCommandBarButtonGalleryDropDownItem15.Id = 518;
            this.spreadsheetCommandBarButtonGalleryDropDownItem15.Name = "spreadsheetCommandBarButtonGalleryDropDownItem15";
            // 
            // commandBarGalleryDropDown17
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown17.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown17.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup33.CommandName = "ChartDataLabelsCommandGroup";
            spreadsheetCommandGalleryItem137.CommandName = "ChartDataLabelsNone";
            spreadsheetCommandGalleryItem138.CommandName = "ChartDataLabelsDefault";
            spreadsheetCommandGalleryItem139.CommandName = "ChartDataLabelsCenter";
            spreadsheetCommandGalleryItem140.CommandName = "ChartDataLabelsInsideEnd";
            spreadsheetCommandGalleryItem141.CommandName = "ChartDataLabelsInsideBase";
            spreadsheetCommandGalleryItem142.CommandName = "ChartDataLabelsOutsideEnd";
            spreadsheetCommandGalleryItem143.CommandName = "ChartDataLabelsBestFit";
            spreadsheetCommandGalleryItem144.CommandName = "ChartDataLabelsLeft";
            spreadsheetCommandGalleryItem145.CommandName = "ChartDataLabelsRight";
            spreadsheetCommandGalleryItem146.CommandName = "ChartDataLabelsAbove";
            spreadsheetCommandGalleryItem147.CommandName = "ChartDataLabelsBelow";
            spreadsheetCommandGalleryItemGroup33.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem137,
            spreadsheetCommandGalleryItem138,
            spreadsheetCommandGalleryItem139,
            spreadsheetCommandGalleryItem140,
            spreadsheetCommandGalleryItem141,
            spreadsheetCommandGalleryItem142,
            spreadsheetCommandGalleryItem143,
            spreadsheetCommandGalleryItem144,
            spreadsheetCommandGalleryItem145,
            spreadsheetCommandGalleryItem146,
            spreadsheetCommandGalleryItem147});
            this.commandBarGalleryDropDown17.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup33});
            this.commandBarGalleryDropDown17.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown17.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown17.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown17.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown17.Name = "commandBarGalleryDropDown17";
            this.commandBarGalleryDropDown17.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarSubItem27
            // 
            this.spreadsheetCommandBarSubItem27.CommandName = "ChartAxesCommandGroup";
            this.spreadsheetCommandBarSubItem27.Id = 519;
            this.spreadsheetCommandBarSubItem27.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem16),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem17)});
            this.spreadsheetCommandBarSubItem27.Name = "spreadsheetCommandBarSubItem27";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem16
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem16.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem16.DropDownControl = this.commandBarGalleryDropDown18;
            this.spreadsheetCommandBarButtonGalleryDropDownItem16.Id = 520;
            this.spreadsheetCommandBarButtonGalleryDropDownItem16.Name = "spreadsheetCommandBarButtonGalleryDropDownItem16";
            // 
            // commandBarGalleryDropDown18
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown18.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown18.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup34.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
            spreadsheetCommandGalleryItem148.CommandName = "ChartHidePrimaryHorizontalAxis";
            spreadsheetCommandGalleryItem149.CommandName = "ChartPrimaryHorizontalAxisLeftToRight";
            spreadsheetCommandGalleryItem150.CommandName = "ChartPrimaryHorizontalAxisHideLabels";
            spreadsheetCommandGalleryItem151.CommandName = "ChartPrimaryHorizontalAxisRightToLeft";
            spreadsheetCommandGalleryItem152.CommandName = "ChartPrimaryHorizontalAxisDefault";
            spreadsheetCommandGalleryItem153.CommandName = "ChartPrimaryHorizontalAxisScaleThousands";
            spreadsheetCommandGalleryItem154.CommandName = "ChartPrimaryHorizontalAxisScaleMillions";
            spreadsheetCommandGalleryItem155.CommandName = "ChartPrimaryHorizontalAxisScaleBillions";
            spreadsheetCommandGalleryItem156.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm";
            spreadsheetCommandGalleryItemGroup34.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem148,
            spreadsheetCommandGalleryItem149,
            spreadsheetCommandGalleryItem150,
            spreadsheetCommandGalleryItem151,
            spreadsheetCommandGalleryItem152,
            spreadsheetCommandGalleryItem153,
            spreadsheetCommandGalleryItem154,
            spreadsheetCommandGalleryItem155,
            spreadsheetCommandGalleryItem156});
            this.commandBarGalleryDropDown18.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup34});
            this.commandBarGalleryDropDown18.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown18.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown18.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown18.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown18.Name = "commandBarGalleryDropDown18";
            this.commandBarGalleryDropDown18.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem17
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem17.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem17.DropDownControl = this.commandBarGalleryDropDown19;
            this.spreadsheetCommandBarButtonGalleryDropDownItem17.Id = 521;
            this.spreadsheetCommandBarButtonGalleryDropDownItem17.Name = "spreadsheetCommandBarButtonGalleryDropDownItem17";
            // 
            // commandBarGalleryDropDown19
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown19.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown19.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup35.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
            spreadsheetCommandGalleryItem157.CommandName = "ChartHidePrimaryVerticalAxis";
            spreadsheetCommandGalleryItem158.CommandName = "ChartPrimaryVerticalAxisLeftToRight";
            spreadsheetCommandGalleryItem159.CommandName = "ChartPrimaryVerticalAxisHideLabels";
            spreadsheetCommandGalleryItem160.CommandName = "ChartPrimaryVerticalAxisRightToLeft";
            spreadsheetCommandGalleryItem161.CommandName = "ChartPrimaryVerticalAxisDefault";
            spreadsheetCommandGalleryItem162.CommandName = "ChartPrimaryVerticalAxisScaleThousands";
            spreadsheetCommandGalleryItem163.CommandName = "ChartPrimaryVerticalAxisScaleMillions";
            spreadsheetCommandGalleryItem164.CommandName = "ChartPrimaryVerticalAxisScaleBillions";
            spreadsheetCommandGalleryItem165.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm";
            spreadsheetCommandGalleryItemGroup35.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem157,
            spreadsheetCommandGalleryItem158,
            spreadsheetCommandGalleryItem159,
            spreadsheetCommandGalleryItem160,
            spreadsheetCommandGalleryItem161,
            spreadsheetCommandGalleryItem162,
            spreadsheetCommandGalleryItem163,
            spreadsheetCommandGalleryItem164,
            spreadsheetCommandGalleryItem165});
            this.commandBarGalleryDropDown19.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup35});
            this.commandBarGalleryDropDown19.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown19.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown19.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown19.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown19.Name = "commandBarGalleryDropDown19";
            this.commandBarGalleryDropDown19.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarSubItem28
            // 
            this.spreadsheetCommandBarSubItem28.CommandName = "ChartGridlinesCommandGroup";
            this.spreadsheetCommandBarSubItem28.Id = 522;
            this.spreadsheetCommandBarSubItem28.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem18),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem19)});
            this.spreadsheetCommandBarSubItem28.Name = "spreadsheetCommandBarSubItem28";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem18
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem18.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem18.DropDownControl = this.commandBarGalleryDropDown20;
            this.spreadsheetCommandBarButtonGalleryDropDownItem18.Id = 523;
            this.spreadsheetCommandBarButtonGalleryDropDownItem18.Name = "spreadsheetCommandBarButtonGalleryDropDownItem18";
            // 
            // commandBarGalleryDropDown20
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown20.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown20.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup36.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem166.CommandName = "ChartPrimaryHorizontalGridlinesNone";
            spreadsheetCommandGalleryItem167.CommandName = "ChartPrimaryHorizontalGridlinesMajor";
            spreadsheetCommandGalleryItem168.CommandName = "ChartPrimaryHorizontalGridlinesMinor";
            spreadsheetCommandGalleryItem169.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItemGroup36.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem166,
            spreadsheetCommandGalleryItem167,
            spreadsheetCommandGalleryItem168,
            spreadsheetCommandGalleryItem169});
            this.commandBarGalleryDropDown20.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup36});
            this.commandBarGalleryDropDown20.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown20.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown20.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown20.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown20.Name = "commandBarGalleryDropDown20";
            this.commandBarGalleryDropDown20.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem19
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem19.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem19.DropDownControl = this.commandBarGalleryDropDown21;
            this.spreadsheetCommandBarButtonGalleryDropDownItem19.Id = 524;
            this.spreadsheetCommandBarButtonGalleryDropDownItem19.Name = "spreadsheetCommandBarButtonGalleryDropDownItem19";
            // 
            // commandBarGalleryDropDown21
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown21.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown21.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup37.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem170.CommandName = "ChartPrimaryVerticalGridlinesNone";
            spreadsheetCommandGalleryItem171.CommandName = "ChartPrimaryVerticalGridlinesMajor";
            spreadsheetCommandGalleryItem172.CommandName = "ChartPrimaryVerticalGridlinesMinor";
            spreadsheetCommandGalleryItem173.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItemGroup37.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem170,
            spreadsheetCommandGalleryItem171,
            spreadsheetCommandGalleryItem172,
            spreadsheetCommandGalleryItem173});
            this.commandBarGalleryDropDown21.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup37});
            this.commandBarGalleryDropDown21.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown21.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown21.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown21.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown21.Name = "commandBarGalleryDropDown21";
            this.commandBarGalleryDropDown21.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem20
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem20.CommandName = "ChartLinesCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem20.DropDownControl = this.commandBarGalleryDropDown22;
            this.spreadsheetCommandBarButtonGalleryDropDownItem20.Id = 525;
            this.spreadsheetCommandBarButtonGalleryDropDownItem20.Name = "spreadsheetCommandBarButtonGalleryDropDownItem20";
            // 
            // commandBarGalleryDropDown22
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown22.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown22.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup38.CommandName = "ChartLinesCommandGroup";
            spreadsheetCommandGalleryItem174.CommandName = "ChartLinesNone";
            spreadsheetCommandGalleryItem175.CommandName = "ChartShowDropLines";
            spreadsheetCommandGalleryItem176.CommandName = "ChartShowHighLowLines";
            spreadsheetCommandGalleryItem177.CommandName = "ChartShowDropLinesAndHighLowLines";
            spreadsheetCommandGalleryItem178.CommandName = "ChartShowSeriesLines";
            spreadsheetCommandGalleryItemGroup38.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem174,
            spreadsheetCommandGalleryItem175,
            spreadsheetCommandGalleryItem176,
            spreadsheetCommandGalleryItem177,
            spreadsheetCommandGalleryItem178});
            this.commandBarGalleryDropDown22.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup38});
            this.commandBarGalleryDropDown22.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown22.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown22.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown22.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown22.Name = "commandBarGalleryDropDown22";
            this.commandBarGalleryDropDown22.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem21
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem21.CommandName = "ChartUpDownBarsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem21.DropDownControl = this.commandBarGalleryDropDown23;
            this.spreadsheetCommandBarButtonGalleryDropDownItem21.Id = 526;
            this.spreadsheetCommandBarButtonGalleryDropDownItem21.Name = "spreadsheetCommandBarButtonGalleryDropDownItem21";
            // 
            // commandBarGalleryDropDown23
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown23.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown23.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup39.CommandName = "ChartUpDownBarsCommandGroup";
            spreadsheetCommandGalleryItem179.CommandName = "ChartHideUpDownBars";
            spreadsheetCommandGalleryItem180.CommandName = "ChartShowUpDownBars";
            spreadsheetCommandGalleryItemGroup39.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem179,
            spreadsheetCommandGalleryItem180});
            this.commandBarGalleryDropDown23.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup39});
            this.commandBarGalleryDropDown23.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown23.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown23.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown23.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown23.Name = "commandBarGalleryDropDown23";
            this.commandBarGalleryDropDown23.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem22
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem22.CommandName = "ChartErrorBarsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem22.DropDownControl = this.commandBarGalleryDropDown24;
            this.spreadsheetCommandBarButtonGalleryDropDownItem22.Id = 527;
            this.spreadsheetCommandBarButtonGalleryDropDownItem22.Name = "spreadsheetCommandBarButtonGalleryDropDownItem22";
            // 
            // commandBarGalleryDropDown24
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown24.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown24.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup40.CommandName = "ChartErrorBarsCommandGroup";
            spreadsheetCommandGalleryItem181.CommandName = "ChartErrorBarsNone";
            spreadsheetCommandGalleryItem182.CommandName = "ChartErrorBarsStandardError";
            spreadsheetCommandGalleryItem183.CommandName = "ChartErrorBarsPercentage";
            spreadsheetCommandGalleryItem184.CommandName = "ChartErrorBarsStandardDeviation";
            spreadsheetCommandGalleryItemGroup40.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem181,
            spreadsheetCommandGalleryItem182,
            spreadsheetCommandGalleryItem183,
            spreadsheetCommandGalleryItem184});
            this.commandBarGalleryDropDown24.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup40});
            this.commandBarGalleryDropDown24.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown24.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown24.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown24.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown24.Name = "commandBarGalleryDropDown24";
            this.commandBarGalleryDropDown24.Ribbon = this.ribbonControl1;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Table Name:";
            this.barStaticItem1.Id = 528;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // renameTableItem1
            // 
            this.renameTableItem1.Edit = this.repositoryItemTextEdit1;
            this.renameTableItem1.Id = 529;
            this.renameTableItem1.Name = "renameTableItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // spreadsheetCommandBarCheckItem26
            // 
            this.spreadsheetCommandBarCheckItem26.CommandName = "TableToolsConvertToRange";
            this.spreadsheetCommandBarCheckItem26.Id = 530;
            this.spreadsheetCommandBarCheckItem26.Name = "spreadsheetCommandBarCheckItem26";
            this.spreadsheetCommandBarCheckItem26.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarCheckItem27
            // 
            this.spreadsheetCommandBarCheckItem27.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem27.CommandName = "TableToolsToggleHeaderRow";
            this.spreadsheetCommandBarCheckItem27.Id = 531;
            this.spreadsheetCommandBarCheckItem27.Name = "spreadsheetCommandBarCheckItem27";
            // 
            // spreadsheetCommandBarCheckItem28
            // 
            this.spreadsheetCommandBarCheckItem28.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem28.CommandName = "TableToolsToggleTotalRow";
            this.spreadsheetCommandBarCheckItem28.Id = 532;
            this.spreadsheetCommandBarCheckItem28.Name = "spreadsheetCommandBarCheckItem28";
            // 
            // spreadsheetCommandBarCheckItem29
            // 
            this.spreadsheetCommandBarCheckItem29.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem29.CommandName = "TableToolsToggleBandedColumns";
            this.spreadsheetCommandBarCheckItem29.Id = 533;
            this.spreadsheetCommandBarCheckItem29.Name = "spreadsheetCommandBarCheckItem29";
            // 
            // spreadsheetCommandBarCheckItem30
            // 
            this.spreadsheetCommandBarCheckItem30.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem30.CommandName = "TableToolsToggleFirstColumn";
            this.spreadsheetCommandBarCheckItem30.Id = 534;
            this.spreadsheetCommandBarCheckItem30.Name = "spreadsheetCommandBarCheckItem30";
            // 
            // spreadsheetCommandBarCheckItem31
            // 
            this.spreadsheetCommandBarCheckItem31.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem31.CommandName = "TableToolsToggleLastColumn";
            this.spreadsheetCommandBarCheckItem31.Id = 535;
            this.spreadsheetCommandBarCheckItem31.Name = "spreadsheetCommandBarCheckItem31";
            // 
            // spreadsheetCommandBarCheckItem32
            // 
            this.spreadsheetCommandBarCheckItem32.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem32.CommandName = "TableToolsToggleBandedRows";
            this.spreadsheetCommandBarCheckItem32.Id = 536;
            this.spreadsheetCommandBarCheckItem32.Name = "spreadsheetCommandBarCheckItem32";
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
            this.galleryTableStylesItem1.Id = 537;
            this.galleryTableStylesItem1.Name = "galleryTableStylesItem1";
            // 
            // spreadsheetCommandBarCheckItem33
            // 
            this.spreadsheetCommandBarCheckItem33.CommandName = "MailMergeDocumentsMode";
            this.spreadsheetCommandBarCheckItem33.Id = 538;
            this.spreadsheetCommandBarCheckItem33.Name = "spreadsheetCommandBarCheckItem33";
            this.spreadsheetCommandBarCheckItem33.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarCheckItem34
            // 
            this.spreadsheetCommandBarCheckItem34.CommandName = "MailMergeOneDocumentMode";
            this.spreadsheetCommandBarCheckItem34.Id = 539;
            this.spreadsheetCommandBarCheckItem34.Name = "spreadsheetCommandBarCheckItem34";
            this.spreadsheetCommandBarCheckItem34.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarCheckItem35
            // 
            this.spreadsheetCommandBarCheckItem35.CommandName = "MailMergeOneSheetMode";
            this.spreadsheetCommandBarCheckItem35.Id = 540;
            this.spreadsheetCommandBarCheckItem35.Name = "spreadsheetCommandBarCheckItem35";
            this.spreadsheetCommandBarCheckItem35.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarSubItem29
            // 
            this.spreadsheetCommandBarSubItem29.CommandName = "MailMergeOrientationCommandGroup";
            this.spreadsheetCommandBarSubItem29.Id = 541;
            this.spreadsheetCommandBarSubItem29.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem36),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem37)});
            this.spreadsheetCommandBarSubItem29.Name = "spreadsheetCommandBarSubItem29";
            this.spreadsheetCommandBarSubItem29.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarCheckItem36
            // 
            this.spreadsheetCommandBarCheckItem36.CommandName = "MailMergeHorizontalMode";
            this.spreadsheetCommandBarCheckItem36.Id = 542;
            this.spreadsheetCommandBarCheckItem36.Name = "spreadsheetCommandBarCheckItem36";
            // 
            // spreadsheetCommandBarCheckItem37
            // 
            this.spreadsheetCommandBarCheckItem37.CommandName = "MailMergeVerticalMode";
            this.spreadsheetCommandBarCheckItem37.Id = 543;
            this.spreadsheetCommandBarCheckItem37.Name = "spreadsheetCommandBarCheckItem37";
            // 
            // spreadsheetCommandBarButtonItem131
            // 
            this.spreadsheetCommandBarButtonItem131.CommandName = "MailMergeSetHeaderRange";
            this.spreadsheetCommandBarButtonItem131.Id = 544;
            this.spreadsheetCommandBarButtonItem131.Name = "spreadsheetCommandBarButtonItem131";
            this.spreadsheetCommandBarButtonItem131.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem132
            // 
            this.spreadsheetCommandBarButtonItem132.CommandName = "MailMergeSetFooterRange";
            this.spreadsheetCommandBarButtonItem132.Id = 545;
            this.spreadsheetCommandBarButtonItem132.Name = "spreadsheetCommandBarButtonItem132";
            this.spreadsheetCommandBarButtonItem132.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem133
            // 
            this.spreadsheetCommandBarButtonItem133.CommandName = "MailMergeSetDetailRange";
            this.spreadsheetCommandBarButtonItem133.Id = 546;
            this.spreadsheetCommandBarButtonItem133.Name = "spreadsheetCommandBarButtonItem133";
            this.spreadsheetCommandBarButtonItem133.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem30
            // 
            this.spreadsheetCommandBarSubItem30.CommandName = "EditingMailMergeMasterDetailCommandGroup";
            this.spreadsheetCommandBarSubItem30.Id = 547;
            this.spreadsheetCommandBarSubItem30.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem134),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem135)});
            this.spreadsheetCommandBarSubItem30.Name = "spreadsheetCommandBarSubItem30";
            this.spreadsheetCommandBarSubItem30.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem134
            // 
            this.spreadsheetCommandBarButtonItem134.CommandName = "MailMergeSetDetailLevel";
            this.spreadsheetCommandBarButtonItem134.Id = 548;
            this.spreadsheetCommandBarButtonItem134.Name = "spreadsheetCommandBarButtonItem134";
            // 
            // spreadsheetCommandBarButtonItem135
            // 
            this.spreadsheetCommandBarButtonItem135.CommandName = "MailMergeSetDetailDataMember";
            this.spreadsheetCommandBarButtonItem135.Id = 549;
            this.spreadsheetCommandBarButtonItem135.Name = "spreadsheetCommandBarButtonItem135";
            // 
            // spreadsheetCommandBarButtonItem136
            // 
            this.spreadsheetCommandBarButtonItem136.CommandName = "MailMergeResetRange";
            this.spreadsheetCommandBarButtonItem136.Id = 550;
            this.spreadsheetCommandBarButtonItem136.Name = "spreadsheetCommandBarButtonItem136";
            this.spreadsheetCommandBarButtonItem136.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem137
            // 
            this.spreadsheetCommandBarButtonItem137.CommandName = "MailMergeSetGroup";
            this.spreadsheetCommandBarButtonItem137.Id = 551;
            this.spreadsheetCommandBarButtonItem137.Name = "spreadsheetCommandBarButtonItem137";
            this.spreadsheetCommandBarButtonItem137.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem138
            // 
            this.spreadsheetCommandBarButtonItem138.CommandName = "MailMergeSetGroupHeader";
            this.spreadsheetCommandBarButtonItem138.Id = 552;
            this.spreadsheetCommandBarButtonItem138.Name = "spreadsheetCommandBarButtonItem138";
            this.spreadsheetCommandBarButtonItem138.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem139
            // 
            this.spreadsheetCommandBarButtonItem139.CommandName = "MailMergeSetGroupFooter";
            this.spreadsheetCommandBarButtonItem139.Id = 553;
            this.spreadsheetCommandBarButtonItem139.Name = "spreadsheetCommandBarButtonItem139";
            this.spreadsheetCommandBarButtonItem139.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem140
            // 
            this.spreadsheetCommandBarButtonItem140.CommandName = "MailMergeSetFilter";
            this.spreadsheetCommandBarButtonItem140.Id = 554;
            this.spreadsheetCommandBarButtonItem140.Name = "spreadsheetCommandBarButtonItem140";
            this.spreadsheetCommandBarButtonItem140.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem141
            // 
            this.spreadsheetCommandBarButtonItem141.CommandName = "MailMergeResetFilter";
            this.spreadsheetCommandBarButtonItem141.Id = 555;
            this.spreadsheetCommandBarButtonItem141.Name = "spreadsheetCommandBarButtonItem141";
            this.spreadsheetCommandBarButtonItem141.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarCheckItem38
            // 
            this.spreadsheetCommandBarCheckItem38.CommandName = "MailMergeShowRanges";
            this.spreadsheetCommandBarCheckItem38.Id = 556;
            this.spreadsheetCommandBarCheckItem38.Name = "spreadsheetCommandBarCheckItem38";
            this.spreadsheetCommandBarCheckItem38.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem142
            // 
            this.spreadsheetCommandBarButtonItem142.CommandName = "MailMergePreview";
            this.spreadsheetCommandBarButtonItem142.Id = 557;
            this.spreadsheetCommandBarButtonItem142.Name = "spreadsheetCommandBarButtonItem142";
            this.spreadsheetCommandBarButtonItem142.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem143
            // 
            this.spreadsheetCommandBarButtonItem143.CommandName = "MailMergeAddDataSource";
            this.spreadsheetCommandBarButtonItem143.Id = 561;
            this.spreadsheetCommandBarButtonItem143.Name = "spreadsheetCommandBarButtonItem143";
            this.spreadsheetCommandBarButtonItem143.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem31
            // 
            this.spreadsheetCommandBarSubItem31.CommandName = "MailMergeManageRelationsCommandGroup";
            this.spreadsheetCommandBarSubItem31.Id = 562;
            this.spreadsheetCommandBarSubItem31.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem144),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem145)});
            this.spreadsheetCommandBarSubItem31.Name = "spreadsheetCommandBarSubItem31";
            this.spreadsheetCommandBarSubItem31.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem144
            // 
            this.spreadsheetCommandBarButtonItem144.CommandName = "MailMergeManageQueriesCommand";
            this.spreadsheetCommandBarButtonItem144.Id = 563;
            this.spreadsheetCommandBarButtonItem144.Name = "spreadsheetCommandBarButtonItem144";
            // 
            // spreadsheetCommandBarButtonItem145
            // 
            this.spreadsheetCommandBarButtonItem145.CommandName = "MailMergeManageRelationsCommand";
            this.spreadsheetCommandBarButtonItem145.Id = 564;
            this.spreadsheetCommandBarButtonItem145.Name = "spreadsheetCommandBarButtonItem145";
            // 
            // spreadsheetCommandBarSubItem32
            // 
            this.spreadsheetCommandBarSubItem32.CommandName = "MailMergeManageDataSourceCommandGroup";
            this.spreadsheetCommandBarSubItem32.Id = 565;
            this.spreadsheetCommandBarSubItem32.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem146),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem147),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem148)});
            this.spreadsheetCommandBarSubItem32.Name = "spreadsheetCommandBarSubItem32";
            this.spreadsheetCommandBarSubItem32.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem146
            // 
            this.spreadsheetCommandBarButtonItem146.CommandName = "MailMergeSelectDataSource";
            this.spreadsheetCommandBarButtonItem146.Id = 566;
            this.spreadsheetCommandBarButtonItem146.Name = "spreadsheetCommandBarButtonItem146";
            // 
            // spreadsheetCommandBarButtonItem147
            // 
            this.spreadsheetCommandBarButtonItem147.CommandName = "MailMergeSelectDataMember";
            this.spreadsheetCommandBarButtonItem147.Id = 567;
            this.spreadsheetCommandBarButtonItem147.Name = "spreadsheetCommandBarButtonItem147";
            // 
            // spreadsheetCommandBarButtonItem148
            // 
            this.spreadsheetCommandBarButtonItem148.CommandName = "MailMergeManageDataSourcesCommand";
            this.spreadsheetCommandBarButtonItem148.Id = 568;
            this.spreadsheetCommandBarButtonItem148.Name = "spreadsheetCommandBarButtonItem148";
            // 
            // spreadsheetCommandBarButtonItem149
            // 
            this.spreadsheetCommandBarButtonItem149.CommandName = "FileShowDocumentProperties";
            this.spreadsheetCommandBarButtonItem149.Id = 570;
            this.spreadsheetCommandBarButtonItem149.Name = "spreadsheetCommandBarButtonItem149";
            // 
            // barButtonGroup11
            // 
            this.barButtonGroup11.Id = 571;
            this.barButtonGroup11.ItemLinks.Add(this.changeFontNameItem1);
            this.barButtonGroup11.ItemLinks.Add(this.changeFontSizeItem1);
            this.barButtonGroup11.ItemLinks.Add(this.spreadsheetCommandBarButtonItem14);
            this.barButtonGroup11.ItemLinks.Add(this.spreadsheetCommandBarButtonItem15);
            this.barButtonGroup11.Name = "barButtonGroup11";
            this.barButtonGroup11.Tag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
            // 
            // barButtonGroup12
            // 
            this.barButtonGroup12.Id = 572;
            this.barButtonGroup12.ItemLinks.Add(this.spreadsheetCommandBarCheckItem1);
            this.barButtonGroup12.ItemLinks.Add(this.spreadsheetCommandBarCheckItem2);
            this.barButtonGroup12.ItemLinks.Add(this.spreadsheetCommandBarCheckItem3);
            this.barButtonGroup12.ItemLinks.Add(this.spreadsheetCommandBarCheckItem4);
            this.barButtonGroup12.Name = "barButtonGroup12";
            this.barButtonGroup12.Tag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            // 
            // barButtonGroup13
            // 
            this.barButtonGroup13.Id = 573;
            this.barButtonGroup13.ItemLinks.Add(this.spreadsheetCommandBarSubItem1);
            this.barButtonGroup13.Name = "barButtonGroup13";
            this.barButtonGroup13.Tag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}";
            // 
            // barButtonGroup14
            // 
            this.barButtonGroup14.Id = 574;
            this.barButtonGroup14.ItemLinks.Add(this.changeCellFillColorItem1);
            this.barButtonGroup14.ItemLinks.Add(this.changeFontColorItem1);
            this.barButtonGroup14.Name = "barButtonGroup14";
            this.barButtonGroup14.Tag = "{C2275623-04A3-41E8-8D6A-EB5C7F8541D1}";
            // 
            // barButtonGroup15
            // 
            this.barButtonGroup15.Id = 575;
            this.barButtonGroup15.ItemLinks.Add(this.spreadsheetCommandBarCheckItem5);
            this.barButtonGroup15.ItemLinks.Add(this.spreadsheetCommandBarCheckItem6);
            this.barButtonGroup15.ItemLinks.Add(this.spreadsheetCommandBarCheckItem7);
            this.barButtonGroup15.Name = "barButtonGroup15";
            this.barButtonGroup15.Tag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            // 
            // barButtonGroup16
            // 
            this.barButtonGroup16.Id = 576;
            this.barButtonGroup16.ItemLinks.Add(this.spreadsheetCommandBarCheckItem8);
            this.barButtonGroup16.ItemLinks.Add(this.spreadsheetCommandBarCheckItem9);
            this.barButtonGroup16.ItemLinks.Add(this.spreadsheetCommandBarCheckItem10);
            this.barButtonGroup16.Name = "barButtonGroup16";
            this.barButtonGroup16.Tag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            // 
            // barButtonGroup17
            // 
            this.barButtonGroup17.Id = 577;
            this.barButtonGroup17.ItemLinks.Add(this.spreadsheetCommandBarButtonItem29);
            this.barButtonGroup17.ItemLinks.Add(this.spreadsheetCommandBarButtonItem30);
            this.barButtonGroup17.Name = "barButtonGroup17";
            this.barButtonGroup17.Tag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
            // 
            // barButtonGroup18
            // 
            this.barButtonGroup18.Id = 578;
            this.barButtonGroup18.ItemLinks.Add(this.changeNumberFormatItem1);
            this.barButtonGroup18.Name = "barButtonGroup18";
            this.barButtonGroup18.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}";
            // 
            // barButtonGroup19
            // 
            this.barButtonGroup19.Id = 579;
            this.barButtonGroup19.ItemLinks.Add(this.spreadsheetCommandBarSubItem3);
            this.barButtonGroup19.ItemLinks.Add(this.spreadsheetCommandBarButtonItem39);
            this.barButtonGroup19.ItemLinks.Add(this.spreadsheetCommandBarButtonItem40);
            this.barButtonGroup19.Name = "barButtonGroup19";
            this.barButtonGroup19.Tag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            // 
            // barButtonGroup20
            // 
            this.barButtonGroup20.Id = 580;
            this.barButtonGroup20.ItemLinks.Add(this.spreadsheetCommandBarButtonItem41);
            this.barButtonGroup20.ItemLinks.Add(this.spreadsheetCommandBarButtonItem42);
            this.barButtonGroup20.Name = "barButtonGroup20";
            this.barButtonGroup20.Tag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
            // 
            // spreadsheetCommandBarCheckItem39
            // 
            this.spreadsheetCommandBarCheckItem39.CommandName = "DataFilterToggle";
            this.spreadsheetCommandBarCheckItem39.Id = 581;
            this.spreadsheetCommandBarCheckItem39.Name = "spreadsheetCommandBarCheckItem39";
            // 
            // spreadsheetCommandBarButtonItem150
            // 
            this.spreadsheetCommandBarButtonItem150.CommandName = "DataFilterClear";
            this.spreadsheetCommandBarButtonItem150.Id = 582;
            this.spreadsheetCommandBarButtonItem150.Name = "spreadsheetCommandBarButtonItem150";
            // 
            // spreadsheetCommandBarButtonItem151
            // 
            this.spreadsheetCommandBarButtonItem151.CommandName = "DataFilterReApply";
            this.spreadsheetCommandBarButtonItem151.Id = 583;
            this.spreadsheetCommandBarButtonItem151.Name = "spreadsheetCommandBarButtonItem151";
            // 
            // spreadsheetCommandBarSubItem33
            // 
            this.spreadsheetCommandBarSubItem33.CommandName = "OutlineGroupCommandGroup";
            this.spreadsheetCommandBarSubItem33.Id = 584;
            this.spreadsheetCommandBarSubItem33.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem152),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem153)});
            this.spreadsheetCommandBarSubItem33.Name = "spreadsheetCommandBarSubItem33";
            this.spreadsheetCommandBarSubItem33.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem152
            // 
            this.spreadsheetCommandBarButtonItem152.CommandName = "GroupOutline";
            this.spreadsheetCommandBarButtonItem152.Id = 585;
            this.spreadsheetCommandBarButtonItem152.Name = "spreadsheetCommandBarButtonItem152";
            // 
            // spreadsheetCommandBarButtonItem153
            // 
            this.spreadsheetCommandBarButtonItem153.CommandName = "AutoOutline";
            this.spreadsheetCommandBarButtonItem153.Id = 586;
            this.spreadsheetCommandBarButtonItem153.Name = "spreadsheetCommandBarButtonItem153";
            // 
            // spreadsheetCommandBarSubItem34
            // 
            this.spreadsheetCommandBarSubItem34.CommandName = "OutlineUngroupCommandGroup";
            this.spreadsheetCommandBarSubItem34.Id = 587;
            this.spreadsheetCommandBarSubItem34.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem154),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem155)});
            this.spreadsheetCommandBarSubItem34.Name = "spreadsheetCommandBarSubItem34";
            this.spreadsheetCommandBarSubItem34.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem154
            // 
            this.spreadsheetCommandBarButtonItem154.CommandName = "UngroupOutline";
            this.spreadsheetCommandBarButtonItem154.Id = 588;
            this.spreadsheetCommandBarButtonItem154.Name = "spreadsheetCommandBarButtonItem154";
            // 
            // spreadsheetCommandBarButtonItem155
            // 
            this.spreadsheetCommandBarButtonItem155.CommandName = "ClearOutline";
            this.spreadsheetCommandBarButtonItem155.Id = 589;
            this.spreadsheetCommandBarButtonItem155.Name = "spreadsheetCommandBarButtonItem155";
            // 
            // spreadsheetCommandBarButtonItem156
            // 
            this.spreadsheetCommandBarButtonItem156.CommandName = "Subtotal";
            this.spreadsheetCommandBarButtonItem156.Id = 590;
            this.spreadsheetCommandBarButtonItem156.Name = "spreadsheetCommandBarButtonItem156";
            this.spreadsheetCommandBarButtonItem156.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem157
            // 
            this.spreadsheetCommandBarButtonItem157.CommandName = "ShowDetail";
            this.spreadsheetCommandBarButtonItem157.Id = 591;
            this.spreadsheetCommandBarButtonItem157.Name = "spreadsheetCommandBarButtonItem157";
            this.spreadsheetCommandBarButtonItem157.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem158
            // 
            this.spreadsheetCommandBarButtonItem158.CommandName = "HideDetail";
            this.spreadsheetCommandBarButtonItem158.Id = 592;
            this.spreadsheetCommandBarButtonItem158.Name = "spreadsheetCommandBarButtonItem158";
            this.spreadsheetCommandBarButtonItem158.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem159
            // 
            this.spreadsheetCommandBarButtonItem159.CommandName = "ReviewInsertComment";
            this.spreadsheetCommandBarButtonItem159.Id = 593;
            this.spreadsheetCommandBarButtonItem159.Name = "spreadsheetCommandBarButtonItem159";
            // 
            // spreadsheetCommandBarButtonItem160
            // 
            this.spreadsheetCommandBarButtonItem160.CommandName = "ReviewEditComment";
            this.spreadsheetCommandBarButtonItem160.Id = 594;
            this.spreadsheetCommandBarButtonItem160.Name = "spreadsheetCommandBarButtonItem160";
            // 
            // spreadsheetCommandBarButtonItem161
            // 
            this.spreadsheetCommandBarButtonItem161.CommandName = "ReviewDeleteComment";
            this.spreadsheetCommandBarButtonItem161.Id = 595;
            this.spreadsheetCommandBarButtonItem161.Name = "spreadsheetCommandBarButtonItem161";
            // 
            // spreadsheetCommandBarButtonItem162
            // 
            this.spreadsheetCommandBarButtonItem162.CommandName = "ReviewShowHideComment";
            this.spreadsheetCommandBarButtonItem162.Id = 596;
            this.spreadsheetCommandBarButtonItem162.Name = "spreadsheetCommandBarButtonItem162";
            this.spreadsheetCommandBarButtonItem162.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Table Name:";
            this.barStaticItem2.Id = 597;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
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
            // chartsDesignTypeRibbonPageGroup1
            // 
            this.chartsDesignTypeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem128);
            this.chartsDesignTypeRibbonPageGroup1.Name = "chartsDesignTypeRibbonPageGroup1";
            // 
            // chartsDesignDataRibbonPageGroup1
            // 
            this.chartsDesignDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem129);
            this.chartsDesignDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem130);
            this.chartsDesignDataRibbonPageGroup1.Name = "chartsDesignDataRibbonPageGroup1";
            // 
            // chartsDesignLayoutsRibbonPageGroup1
            // 
            this.chartsDesignLayoutsRibbonPageGroup1.ItemLinks.Add(this.galleryChartLayoutItem1);
            this.chartsDesignLayoutsRibbonPageGroup1.Name = "chartsDesignLayoutsRibbonPageGroup1";
            // 
            // chartsDesignStylesRibbonPageGroup1
            // 
            this.chartsDesignStylesRibbonPageGroup1.ItemLinks.Add(this.galleryChartStyleItem1);
            this.chartsDesignStylesRibbonPageGroup1.Name = "chartsDesignStylesRibbonPageGroup1";
            // 
            // chartsLayoutRibbonPage1
            // 
            this.chartsLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.chartsLayoutLabelsRibbonPageGroup1,
            this.chartsLayoutAxesRibbonPageGroup1,
            this.chartsLayoutAnalysisRibbonPageGroup1});
            this.chartsLayoutRibbonPage1.Name = "chartsLayoutRibbonPage1";
            this.chartsLayoutRibbonPage1.Visible = false;
            // 
            // chartsLayoutLabelsRibbonPageGroup1
            // 
            this.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem11);
            this.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem26);
            this.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem14);
            this.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem15);
            this.chartsLayoutLabelsRibbonPageGroup1.Name = "chartsLayoutLabelsRibbonPageGroup1";
            // 
            // chartsLayoutAxesRibbonPageGroup1
            // 
            this.chartsLayoutAxesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem27);
            this.chartsLayoutAxesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem28);
            this.chartsLayoutAxesRibbonPageGroup1.Name = "chartsLayoutAxesRibbonPageGroup1";
            // 
            // chartsLayoutAnalysisRibbonPageGroup1
            // 
            this.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem20);
            this.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem21);
            this.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem22);
            this.chartsLayoutAnalysisRibbonPageGroup1.Name = "chartsLayoutAnalysisRibbonPageGroup1";
            // 
            // chartsFormatRibbonPage1
            // 
            this.chartsFormatRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.chartsFormatArrangeRibbonPageGroup1});
            this.chartsFormatRibbonPage1.Name = "chartsFormatRibbonPage1";
            this.chartsFormatRibbonPage1.Visible = false;
            // 
            // chartsFormatArrangeRibbonPageGroup1
            // 
            this.chartsFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
            this.chartsFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
            this.chartsFormatArrangeRibbonPageGroup1.Name = "chartsFormatArrangeRibbonPageGroup1";
            // 
            // tableToolsRibbonPageCategory1
            // 
            this.tableToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1";
            this.tableToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tableToolsDesignRibbonPage1});
            this.tableToolsRibbonPageCategory1.Visible = false;
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
            // tablePropertiesRibbonPageGroup1
            // 
            this.tablePropertiesRibbonPageGroup1.ItemLinks.Add(this.barStaticItem2);
            this.tablePropertiesRibbonPageGroup1.ItemLinks.Add(this.renameTableItem1);
            this.tablePropertiesRibbonPageGroup1.Name = "tablePropertiesRibbonPageGroup1";
            // 
            // tableToolsRibbonPageGroup1
            // 
            this.tableToolsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem26);
            this.tableToolsRibbonPageGroup1.Name = "tableToolsRibbonPageGroup1";
            // 
            // tableStyleOptionsRibbonPageGroup1
            // 
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem27);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem28);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem29);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem30);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem31);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem32);
            this.tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1";
            // 
            // tableStylesRibbonPageGroup1
            // 
            this.tableStylesRibbonPageGroup1.ItemLinks.Add(this.galleryTableStylesItem1);
            this.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1";
            // 
            // pictureToolsRibbonPageCategory1
            // 
            this.pictureToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.pictureToolsRibbonPageCategory1.Name = "pictureToolsRibbonPageCategory1";
            this.pictureToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pictureFormatRibbonPage1});
            this.pictureToolsRibbonPageCategory1.Visible = false;
            // 
            // pictureFormatRibbonPage1
            // 
            this.pictureFormatRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pictureFormatArrangeRibbonPageGroup1});
            this.pictureFormatRibbonPage1.Name = "pictureFormatRibbonPage1";
            this.pictureFormatRibbonPage1.Visible = false;
            // 
            // pictureFormatArrangeRibbonPageGroup1
            // 
            this.pictureFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
            this.pictureFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
            this.pictureFormatArrangeRibbonPageGroup1.Name = "pictureFormatArrangeRibbonPageGroup1";
            // 
            // drawingToolsRibbonPageCategory1
            // 
            this.drawingToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.drawingToolsRibbonPageCategory1.Name = "drawingToolsRibbonPageCategory1";
            this.drawingToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.drawingFormatRibbonPage1});
            this.drawingToolsRibbonPageCategory1.Visible = false;
            // 
            // drawingFormatRibbonPage1
            // 
            this.drawingFormatRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.drawingFormatArrangeRibbonPageGroup1});
            this.drawingFormatRibbonPage1.Name = "drawingFormatRibbonPage1";
            this.drawingFormatRibbonPage1.Visible = false;
            // 
            // drawingFormatArrangeRibbonPageGroup1
            // 
            this.drawingFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
            this.drawingFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
            this.drawingFormatArrangeRibbonPageGroup1.Name = "drawingFormatArrangeRibbonPageGroup1";
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1,
            this.infoRibbonPageGroup1});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
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
            // infoRibbonPageGroup1
            // 
            this.infoRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem149);
            this.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1";
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
            // clipboardRibbonPageGroup1
            // 
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem10);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem11);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem12);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem13);
            this.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1";
            // 
            // fontRibbonPageGroup1
            // 
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup11);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup12);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup13);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup14);
            this.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1";
            // 
            // alignmentRibbonPageGroup1
            // 
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup15);
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup16);
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup17);
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem11);
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem2);
            this.alignmentRibbonPageGroup1.Name = "alignmentRibbonPageGroup1";
            // 
            // numberRibbonPageGroup1
            // 
            this.numberRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup18);
            this.numberRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup19);
            this.numberRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup20);
            this.numberRibbonPageGroup1.Name = "numberRibbonPageGroup1";
            // 
            // cellsRibbonPageGroup1
            // 
            this.cellsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem8);
            this.cellsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem9);
            this.cellsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem10);
            this.cellsRibbonPageGroup1.Name = "cellsRibbonPageGroup1";
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
            // tablesRibbonPageGroup1
            // 
            this.tablesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem97);
            this.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1";
            // 
            // illustrationsRibbonPageGroup1
            // 
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem98);
            this.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1";
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
            // linksRibbonPageGroup1
            // 
            this.linksRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem99);
            this.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1";
            // 
            // symbolsRibbonPageGroup1
            // 
            this.symbolsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem100);
            this.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1";
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
            // pageSetupRibbonPageGroup1
            // 
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem17);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem18);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.pageSetupPaperKindItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem19);
            this.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1";
            // 
            // pageSetupShowRibbonPageGroup1
            // 
            this.pageSetupShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem19);
            this.pageSetupShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem20);
            this.pageSetupShowRibbonPageGroup1.Name = "pageSetupShowRibbonPageGroup1";
            // 
            // pageSetupPrintRibbonPageGroup1
            // 
            this.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem21);
            this.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem22);
            this.pageSetupPrintRibbonPageGroup1.Name = "pageSetupPrintRibbonPageGroup1";
            // 
            // arrangeRibbonPageGroup1
            // 
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
            this.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1";
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
            // formulaDefinedNamesRibbonPageGroup1
            // 
            this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem112);
            this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem113);
            this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.definedNameListItem1);
            this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem114);
            this.formulaDefinedNamesRibbonPageGroup1.Name = "formulaDefinedNamesRibbonPageGroup1";
            // 
            // formulaAuditingRibbonPageGroup1
            // 
            this.formulaAuditingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem23);
            this.formulaAuditingRibbonPageGroup1.Name = "formulaAuditingRibbonPageGroup1";
            // 
            // formulaCalculationRibbonPageGroup1
            // 
            this.formulaCalculationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem24);
            this.formulaCalculationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem115);
            this.formulaCalculationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem116);
            this.formulaCalculationRibbonPageGroup1.Name = "formulaCalculationRibbonPageGroup1";
            // 
            // dataRibbonPage1
            // 
            this.dataRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.sortAndFilterRibbonPageGroup1,
            this.outlineRibbonPageGroup1});
            this.dataRibbonPage1.Name = "dataRibbonPage1";
            // 
            // sortAndFilterRibbonPageGroup1
            // 
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem93);
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem94);
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem39);
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem150);
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem151);
            this.sortAndFilterRibbonPageGroup1.Name = "sortAndFilterRibbonPageGroup1";
            // 
            // outlineRibbonPageGroup1
            // 
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem33);
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem34);
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem156);
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem157);
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem158);
            this.outlineRibbonPageGroup1.Name = "outlineRibbonPageGroup1";
            // 
            // mailMergeRibbonPage1
            // 
            this.mailMergeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mailMergeDataRibbonPageGroup1,
            this.mailMergeModeRibbonPageGroup1,
            this.mailMergeExtendedRibbonPageGroup1,
            this.mailMergeGroupingRibbonPageGroup1,
            this.mailMergeFilteringRibbonPageGroup1,
            this.mailMergeBindingRibbonPageGroup1,
            this.ribbonPageDemoGroup});
            this.mailMergeRibbonPage1.Name = "mailMergeRibbonPage1";
            // 
            // mailMergeDataRibbonPageGroup1
            // 
            this.mailMergeDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem143);
            this.mailMergeDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem31);
            this.mailMergeDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem32);
            this.mailMergeDataRibbonPageGroup1.Name = "mailMergeDataRibbonPageGroup1";
            // 
            // mailMergeModeRibbonPageGroup1
            // 
            this.mailMergeModeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem33);
            this.mailMergeModeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem34);
            this.mailMergeModeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem35);
            this.mailMergeModeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem29);
            this.mailMergeModeRibbonPageGroup1.Name = "mailMergeModeRibbonPageGroup1";
            // 
            // mailMergeExtendedRibbonPageGroup1
            // 
            this.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem131);
            this.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem132);
            this.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem133);
            this.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem30);
            this.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem136);
            this.mailMergeExtendedRibbonPageGroup1.Name = "mailMergeExtendedRibbonPageGroup1";
            // 
            // mailMergeGroupingRibbonPageGroup1
            // 
            this.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem137);
            this.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem138);
            this.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem139);
            this.mailMergeGroupingRibbonPageGroup1.Name = "mailMergeGroupingRibbonPageGroup1";
            // 
            // mailMergeFilteringRibbonPageGroup1
            // 
            this.mailMergeFilteringRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem140);
            this.mailMergeFilteringRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem141);
            this.mailMergeFilteringRibbonPageGroup1.Name = "mailMergeFilteringRibbonPageGroup1";
            // 
            // mailMergeBindingRibbonPageGroup1
            // 
            this.mailMergeBindingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem38);
            this.mailMergeBindingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem142);
            this.mailMergeBindingRibbonPageGroup1.Name = "mailMergeBindingRibbonPageGroup1";
            // 
            // ribbonPageDemoGroup
            // 
            this.ribbonPageDemoGroup.ItemLinks.Add(this.hideCommentsCheckItem);
            this.ribbonPageDemoGroup.Name = "ribbonPageDemoGroup";
            this.ribbonPageDemoGroup.ShowCaptionButton = false;
            this.ribbonPageDemoGroup.Text = "Demo";
            // 
            // reviewRibbonPage1
            // 
            this.reviewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commentsRibbonPageGroup1,
            this.changesRibbonPageGroup1});
            this.reviewRibbonPage1.Name = "reviewRibbonPage1";
            // 
            // commentsRibbonPageGroup1
            // 
            this.commentsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem159);
            this.commentsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem160);
            this.commentsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem161);
            this.commentsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem162);
            this.commentsRibbonPageGroup1.Name = "commentsRibbonPageGroup1";
            // 
            // changesRibbonPageGroup1
            // 
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem76);
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem117);
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem118);
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem119);
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem120);
            this.changesRibbonPageGroup1.Name = "changesRibbonPageGroup1";
            // 
            // viewRibbonPage1
            // 
            this.viewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.showRibbonPageGroup1,
            this.zoomRibbonPageGroup1,
            this.windowRibbonPageGroup1});
            this.viewRibbonPage1.Name = "viewRibbonPage1";
            // 
            // showRibbonPageGroup1
            // 
            this.showRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem19);
            this.showRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem20);
            this.showRibbonPageGroup1.Name = "showRibbonPageGroup1";
            // 
            // zoomRibbonPageGroup1
            // 
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem121);
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem122);
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem123);
            this.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1";
            // 
            // windowRibbonPageGroup1
            // 
            this.windowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem25);
            this.windowRibbonPageGroup1.Name = "windowRibbonPageGroup1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 142);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.spreadsheetNameBoxControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.spreadsheetFormulaBarControl1);
            this.splitContainerControl1.Size = new System.Drawing.Size(862, 20);
            this.splitContainerControl1.TabIndex = 2;
            // 
            // spreadsheetNameBoxControl1
            // 
            this.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetNameBoxControl1.EditValue = "A1";
            this.spreadsheetNameBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1";
            this.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
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
            this.spreadsheetFormulaBarControl1.Size = new System.Drawing.Size(757, 20);
            this.spreadsheetFormulaBarControl1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetFormulaBarControl1.TabIndex = 0;
            // 
            // spreadsheetBarController1
            // 
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
            this.spreadsheetBarController1.BarItems.Add(this.changeFontNameItem1);
            this.spreadsheetBarController1.BarItems.Add(this.changeFontSizeItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem14);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem15);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem16);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem17);
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
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem29);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem30);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem11);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem12);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem31);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem32);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem33);
            this.spreadsheetBarController1.BarItems.Add(this.changeNumberFormatItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem34);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem35);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem36);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem37);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem38);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem39);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem40);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem41);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem42);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem43);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem44);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem45);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem46);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem47);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem48);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem49);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem50);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem51);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem52);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem53);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem54);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem55);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem7);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem56);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem57);
            this.spreadsheetBarController1.BarItems.Add(this.galleryFormatAsTableItem1);
            this.spreadsheetBarController1.BarItems.Add(this.galleryChangeStyleItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem58);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem59);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem60);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem61);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem62);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem63);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem10);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem64);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem65);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem66);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem67);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem68);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem11);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem69);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem70);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem71);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem72);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem73);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem74);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem75);
            this.spreadsheetBarController1.BarItems.Add(this.changeSheetTabColorItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem76);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem13);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem77);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem12);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem78);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem79);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem80);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem81);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem82);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem13);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem83);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem84);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem85);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem86);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem14);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem87);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem88);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem89);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem90);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem91);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem92);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem15);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem93);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem94);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem16);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem95);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem96);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem97);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem98);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem7);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem10);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem99);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem100);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem17);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem14);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem15);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem16);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem18);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem17);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem18);
            this.spreadsheetBarController1.BarItems.Add(this.pageSetupPaperKindItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem19);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem101);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem102);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem19);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem20);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem21);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem22);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem20);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem103);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem104);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem21);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem105);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem106);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem22);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem107);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem108);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem109);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem110);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem111);
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
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem112);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem113);
            this.spreadsheetBarController1.BarItems.Add(this.definedNameListItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem114);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem23);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem24);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem24);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem25);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem115);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem116);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem117);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem118);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem119);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem120);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem121);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem122);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem123);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem25);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem124);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem125);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem126);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem127);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem128);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem129);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem130);
            this.spreadsheetBarController1.BarItems.Add(this.galleryChartLayoutItem1);
            this.spreadsheetBarController1.BarItems.Add(this.galleryChartStyleItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem11);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem26);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem12);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem13);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem14);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem15);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem27);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem16);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem17);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem28);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem18);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem19);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem20);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem21);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem22);
            this.spreadsheetBarController1.BarItems.Add(this.barStaticItem1);
            this.spreadsheetBarController1.BarItems.Add(this.renameTableItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem26);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem27);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem28);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem29);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem30);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem31);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem32);
            this.spreadsheetBarController1.BarItems.Add(this.galleryTableStylesItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem33);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem34);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem35);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem29);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem36);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem37);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem131);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem132);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem133);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem30);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem134);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem135);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem136);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem137);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem138);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem139);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem140);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem141);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem38);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem142);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem143);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem31);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem144);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem145);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem32);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem146);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem147);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem148);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem149);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem39);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem150);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem151);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem33);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem152);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem153);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem34);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem154);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem155);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem156);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem157);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem158);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem159);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem160);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem161);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem162);
            this.spreadsheetBarController1.BarItems.Add(this.barStaticItem2);
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
            // spreadsheetDockManager1
            // 
            this.spreadsheetDockManager1.Form = this;
            this.spreadsheetDockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.spreadsheetDockManager1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.fieldListDockPanel1);
            this.panelContainer1.Controls.Add(this.mailMergeParametersDockPanel);
            this.panelContainer1.Controls.Add(this.filteringDockPanel);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer1.ID = new System.Guid("a9a40f94-dc0f-4f90-b029-4282846c5053");
            this.panelContainer1.Location = new System.Drawing.Point(862, 142);
            this.panelContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.Size = new System.Drawing.Size(200, 290);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // fieldListDockPanel1
            // 
            this.fieldListDockPanel1.Controls.Add(this.fieldListDockPanel1_Container);
            this.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.fieldListDockPanel1.ID = new System.Guid("6b098cf1-bd50-44c1-a93a-38b0a4bce017");
            this.fieldListDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.fieldListDockPanel1.Name = "fieldListDockPanel1";
            this.fieldListDockPanel1.OriginalSize = new System.Drawing.Size(200, 145);
            this.fieldListDockPanel1.Size = new System.Drawing.Size(200, 97);
            this.fieldListDockPanel1.SpreadsheetControl = this.spreadsheetControl1;
            this.fieldListDockPanel1.Text = "Field List";
            // 
            // fieldListDockPanel1_Container
            // 
            this.fieldListDockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container";
            this.fieldListDockPanel1_Container.Size = new System.Drawing.Size(192, 70);
            this.fieldListDockPanel1_Container.TabIndex = 0;
            // 
            // mailMergeParametersDockPanel
            // 
            this.mailMergeParametersDockPanel.Controls.Add(this.mailMergeParametersDockPanel1_Container);
            this.mailMergeParametersDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.mailMergeParametersDockPanel.ID = new System.Guid("09c84a14-2284-4751-b3f0-df4853bb164f");
            this.mailMergeParametersDockPanel.Location = new System.Drawing.Point(0, 97);
            this.mailMergeParametersDockPanel.Name = "mailMergeParametersDockPanel";
            this.mailMergeParametersDockPanel.OriginalSize = new System.Drawing.Size(200, 145);
            this.mailMergeParametersDockPanel.Size = new System.Drawing.Size(200, 97);
            this.mailMergeParametersDockPanel.SpreadsheetControl = this.spreadsheetControl1;
            this.mailMergeParametersDockPanel.Text = "Parameters";
            // 
            // mailMergeParametersDockPanel1_Container
            // 
            this.mailMergeParametersDockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.mailMergeParametersDockPanel1_Container.Name = "mailMergeParametersDockPanel1_Container";
            this.mailMergeParametersDockPanel1_Container.Size = new System.Drawing.Size(192, 70);
            this.mailMergeParametersDockPanel1_Container.TabIndex = 0;
            // 
            // filteringDockPanel
            // 
            this.filteringDockPanel.Controls.Add(this.dockPanel1_Container);
            this.filteringDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.filteringDockPanel.ID = new System.Guid("3fa0b467-3f8b-40ff-9387-ffbd4a309a03");
            this.filteringDockPanel.Location = new System.Drawing.Point(0, 194);
            this.filteringDockPanel.Name = "filteringDockPanel";
            this.filteringDockPanel.Options.ShowAutoHideButton = false;
            this.filteringDockPanel.Options.ShowCloseButton = false;
            this.filteringDockPanel.Options.ShowMaximizeButton = false;
            this.filteringDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.filteringDockPanel.Size = new System.Drawing.Size(200, 96);
            this.filteringDockPanel.Text = "Filter Templates";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.checkEdit0);
            this.dockPanel1_Container.Controls.Add(this.checkEdit1);
            this.dockPanel1_Container.Controls.Add(this.checkEdit2);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 69);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // checkEdit0
            // 
            this.checkEdit0.EditValue = true;
            this.checkEdit0.Location = new System.Drawing.Point(3, 3);
            this.checkEdit0.Name = "checkEdit0";
            this.checkEdit0.Properties.Caption = "Sales Manager";
            this.checkEdit0.Size = new System.Drawing.Size(174, 19);
            this.checkEdit0.TabIndex = 7;
            this.checkEdit0.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(3, 28);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Inside Sales Coordinator";
            this.checkEdit1.Size = new System.Drawing.Size(174, 19);
            this.checkEdit1.TabIndex = 8;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged);
            // 
            // checkEdit2
            // 
            this.checkEdit2.EditValue = true;
            this.checkEdit2.Location = new System.Drawing.Point(3, 53);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Sales Representative";
            this.checkEdit2.Size = new System.Drawing.Size(174, 19);
            this.checkEdit2.TabIndex = 9;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged);
            // 
            // MailMergeModuleBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MailMergeModuleBase";
            this.Size = new System.Drawing.Size(1062, 432);
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpreadsheetFontSizeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetNameBoxControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetDockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.fieldListDockPanel1.ResumeLayout(false);
            this.mailMergeParametersDockPanel.ResumeLayout(false);
            this.filteringDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit0.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private SplitContainerControl splitContainerControl1;
        private SpreadsheetNameBoxControl spreadsheetNameBoxControl1;
        private SpreadsheetFormulaBarControl spreadsheetFormulaBarControl1;
        private UI.SpreadsheetBarController spreadsheetBarController1;
        private XtraBars.BarCheckItem hideCommentsCheckItem;
        private System.ComponentModel.IContainer components;
        private SpreadsheetDockManager spreadsheetDockManager1;
        private FieldListDockPanel fieldListDockPanel1;
        private XtraBars.Docking.ControlContainer fieldListDockPanel1_Container;
        private DockPanel panelContainer1;
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
        private XtraBars.BarButtonGroup barButtonGroup1;
        private UI.ChangeFontNameItem changeFontNameItem1;
        private XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private UI.ChangeFontSizeItem changeFontSizeItem1;
        private Design.RepositoryItemSpreadsheetFontSizeEdit repositoryItemSpreadsheetFontSizeEdit1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem14;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem15;
        private XtraBars.BarButtonGroup barButtonGroup2;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem1;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem2;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem3;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem4;
        private XtraBars.BarButtonGroup barButtonGroup3;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem16;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem17;
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
        private UI.ChangeBorderLineColorItem changeBorderLineColorItem1;
        private UI.ChangeBorderLineStyleItem changeBorderLineStyleItem1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown1;
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
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem29;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem30;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem11;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem2;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem12;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem31;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem32;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem33;
        private XtraBars.BarButtonGroup barButtonGroup8;
        private UI.ChangeNumberFormatItem changeNumberFormatItem1;
        private XtraEditors.Repository.RepositoryItemPopupGalleryEdit repositoryItemPopupGalleryEdit1;
        private XtraBars.BarButtonGroup barButtonGroup9;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem3;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem34;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem35;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem36;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem37;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem38;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem39;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem40;
        private XtraBars.BarButtonGroup barButtonGroup10;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem41;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem42;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem4;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem5;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem43;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem44;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem45;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem46;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem47;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem48;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem49;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem6;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem50;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem51;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem52;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem53;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem54;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem55;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown2;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem2;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown3;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem3;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown4;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem7;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem56;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem57;
        private UI.GalleryFormatAsTableItem galleryFormatAsTableItem1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown5;
        private UI.GalleryChangeStyleItem galleryChangeStyleItem1;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem8;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem58;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem59;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem60;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem9;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem61;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem62;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem63;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem10;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem64;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem65;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem66;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem67;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem68;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem11;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem69;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem70;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem71;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem72;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem73;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem74;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem75;
        private UI.ChangeSheetTabColorItem changeSheetTabColorItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem76;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem13;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem77;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem12;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem78;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem79;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem80;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem81;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem82;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem13;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem83;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem84;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem85;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem86;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem14;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem87;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem88;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem89;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem90;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem91;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem92;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem15;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem93;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem94;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem16;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem95;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem96;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem97;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem98;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem4;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown6;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem5;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown7;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem6;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown8;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem7;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown9;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem8;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown10;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem9;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown11;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem10;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown12;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem99;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem100;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem17;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem14;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem15;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem16;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem18;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem17;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem18;
        private UI.PageSetupPaperKindItem pageSetupPaperKindItem1;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem19;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem101;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem102;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem19;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem20;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem21;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem22;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem20;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem103;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem104;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem21;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem105;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem106;
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
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem112;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem113;
        private UI.DefinedNameListItem definedNameListItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem114;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem23;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem24;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem24;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem25;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem115;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem116;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem117;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem118;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem119;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem120;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem121;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem122;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem123;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem25;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem124;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem125;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem126;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem127;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem128;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem129;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem130;
        private UI.GalleryChartLayoutItem galleryChartLayoutItem1;
        private UI.GalleryChartStyleItem galleryChartStyleItem1;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem11;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown13;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem26;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem12;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown14;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem13;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown15;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem14;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown16;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem15;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown17;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem27;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem16;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown18;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem17;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown19;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem28;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem18;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown20;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem19;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown21;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem20;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown22;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem21;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown23;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem22;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown24;
        private XtraBars.BarStaticItem barStaticItem1;
        private UI.RenameTableItem renameTableItem1;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem26;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem27;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem28;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem29;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem30;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem31;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem32;
        private UI.GalleryTableStylesItem galleryTableStylesItem1;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem33;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem34;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem35;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem29;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem36;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem37;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem131;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem132;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem133;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem30;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem134;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem135;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem136;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem137;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem138;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem139;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem140;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem141;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem38;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem142;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageDemoGroup;			
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem107;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem108;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem109;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem110;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem111;
        private MailMergeParametersDockPanel mailMergeParametersDockPanel;
        private ControlContainer mailMergeParametersDockPanel1_Container;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem143;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem31;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem144;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem145;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem32;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem146;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem147;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem148;
        private UI.MailMergeRibbonPage mailMergeRibbonPage1;
        private UI.MailMergeDataRibbonPageGroup mailMergeDataRibbonPageGroup1;
        private UI.MailMergeModeRibbonPageGroup mailMergeModeRibbonPageGroup1;
        private UI.MailMergeExtendedRibbonPageGroup mailMergeExtendedRibbonPageGroup1;
        private UI.MailMergeGroupingRibbonPageGroup mailMergeGroupingRibbonPageGroup1;
        private UI.MailMergeFilteringRibbonPageGroup mailMergeFilteringRibbonPageGroup1;
        private UI.MailMergeBindingRibbonPageGroup mailMergeBindingRibbonPageGroup1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem149;
        private XtraBars.BarButtonGroup barButtonGroup11;
        private XtraBars.BarButtonGroup barButtonGroup12;
        private XtraBars.BarButtonGroup barButtonGroup13;
        private XtraBars.BarButtonGroup barButtonGroup14;
        private XtraBars.BarButtonGroup barButtonGroup15;
        private XtraBars.BarButtonGroup barButtonGroup16;
        private XtraBars.BarButtonGroup barButtonGroup17;
        private XtraBars.BarButtonGroup barButtonGroup18;
        private XtraBars.BarButtonGroup barButtonGroup19;
        private XtraBars.BarButtonGroup barButtonGroup20;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem39;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem150;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem151;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem33;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem152;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem153;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem34;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem154;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem155;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem156;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem157;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem158;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem159;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem160;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem161;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem162;
        private XtraBars.BarStaticItem barStaticItem2;
        private UI.ChartToolsRibbonPageCategory chartToolsRibbonPageCategory1;
        private UI.ChartsDesignRibbonPage chartsDesignRibbonPage1;
        private UI.ChartsDesignTypeRibbonPageGroup chartsDesignTypeRibbonPageGroup1;
        private UI.ChartsDesignDataRibbonPageGroup chartsDesignDataRibbonPageGroup1;
        private UI.ChartsDesignLayoutsRibbonPageGroup chartsDesignLayoutsRibbonPageGroup1;
        private UI.ChartsDesignStylesRibbonPageGroup chartsDesignStylesRibbonPageGroup1;
        private UI.ChartsLayoutRibbonPage chartsLayoutRibbonPage1;
        private UI.ChartsLayoutLabelsRibbonPageGroup chartsLayoutLabelsRibbonPageGroup1;
        private UI.ChartsLayoutAxesRibbonPageGroup chartsLayoutAxesRibbonPageGroup1;
        private UI.ChartsLayoutAnalysisRibbonPageGroup chartsLayoutAnalysisRibbonPageGroup1;
        private UI.ChartsFormatRibbonPage chartsFormatRibbonPage1;
        private UI.ChartsFormatArrangeRibbonPageGroup chartsFormatArrangeRibbonPageGroup1;
        private UI.TableToolsRibbonPageCategory tableToolsRibbonPageCategory1;
        private UI.TableToolsDesignRibbonPage tableToolsDesignRibbonPage1;
        private UI.TablePropertiesRibbonPageGroup tablePropertiesRibbonPageGroup1;
        private UI.TableToolsRibbonPageGroup tableToolsRibbonPageGroup1;
        private UI.TableStyleOptionsRibbonPageGroup tableStyleOptionsRibbonPageGroup1;
        private UI.TableStylesRibbonPageGroup tableStylesRibbonPageGroup1;
        private UI.PictureToolsRibbonPageCategory pictureToolsRibbonPageCategory1;
        private UI.PictureFormatRibbonPage pictureFormatRibbonPage1;
        private UI.PictureFormatArrangeRibbonPageGroup pictureFormatArrangeRibbonPageGroup1;
        private UI.DrawingToolsRibbonPageCategory drawingToolsRibbonPageCategory1;
        private UI.DrawingFormatRibbonPage drawingFormatRibbonPage1;
        private UI.DrawingFormatArrangeRibbonPageGroup drawingFormatArrangeRibbonPageGroup1;
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
        private UI.OutlineRibbonPageGroup outlineRibbonPageGroup1;
        private UI.ReviewRibbonPage reviewRibbonPage1;
        private UI.CommentsRibbonPageGroup commentsRibbonPageGroup1;
        private UI.ChangesRibbonPageGroup changesRibbonPageGroup1;
        private UI.ViewRibbonPage viewRibbonPage1;
        private UI.ShowRibbonPageGroup showRibbonPageGroup1;
        private UI.ZoomRibbonPageGroup zoomRibbonPageGroup1;
        private UI.WindowRibbonPageGroup windowRibbonPageGroup1;
        private DockPanel filteringDockPanel;
        private ControlContainer dockPanel1_Container;
        private CheckEdit checkEdit0;
        private CheckEdit checkEdit1;
        private CheckEdit checkEdit2;
	}
}

Imports Microsoft.VisualBasic
Imports System.Globalization
Imports System.IO
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab
Imports DevExpress.XtraBars.Docking

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class MailMergeModuleBase
		Inherits SpreadSheetTutorialControlBase
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MailMergeModuleBase))
			Dim superToolTip1 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem1 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem1 As New DevExpress.Utils.ToolTipItem()
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
			Dim spreadsheetCommandGalleryItem30 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem31 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem32 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem33 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem34 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem35 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup4 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem36 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem37 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem38 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem39 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem40 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem41 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem42 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup5 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem43 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem44 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem45 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem46 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem47 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup6 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem48 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem49 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem50 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup7 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem51 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem52 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem53 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem54 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem55 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup8 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem56 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem57 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem58 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup9 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem59 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem60 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem61 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem62 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup10 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem63 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem64 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem65 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem66 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup11 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem67 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem68 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem69 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem70 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup12 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem71 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem72 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem73 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem74 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup13 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem75 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem76 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem77 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem78 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem79 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem80 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup14 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem81 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup15 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem82 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem83 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup16 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem84 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem85 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup17 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem86 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem87 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup18 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem88 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem89 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem90 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup19 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem91 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem92 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem93 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup20 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem94 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem95 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem96 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup21 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem97 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem98 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem99 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup22 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem100 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem101 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem102 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup23 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem103 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem104 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem105 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup24 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem106 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem107 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem108 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup25 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem109 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem110 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem111 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem112 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem113 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup26 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem114 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem115 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup27 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem116 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem117 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup28 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem118 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem119 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem120 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup29 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem121 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem122 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem123 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup30 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem124 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem125 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup31 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem126 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem127 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem128 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem129 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup32 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem130 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem131 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem132 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem133 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem134 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem135 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem136 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup33 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem137 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem138 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem139 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem140 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem141 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem142 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem143 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem144 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem145 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem146 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem147 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup34 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem148 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem149 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem150 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem151 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem152 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem153 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem154 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem155 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem156 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup35 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem157 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem158 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem159 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem160 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem161 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem162 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem163 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem164 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem165 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup36 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem166 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem167 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem168 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem169 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup37 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem170 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem171 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem172 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem173 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup38 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem174 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem175 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem176 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem177 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem178 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup39 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem179 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem180 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItemGroup40 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
			Dim spreadsheetCommandGalleryItem181 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem182 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem183 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim spreadsheetCommandGalleryItem184 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
			Dim reduceOperation1 As New DevExpress.XtraBars.Ribbon.ReduceOperation()
			Me.stylesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.StylesRibbonPageGroup()
			Me.spreadsheetCommandBarSubItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarSubItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem43 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem44 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem45 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem46 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem47 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem48 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem49 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem50 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem51 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem52 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem53 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem54 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem55 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.hideCommentsCheckItem = New DevExpress.XtraBars.BarCheckItem()
			Me.spreadsheetCommandBarButtonItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
			Me.changeFontNameItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeFontNameItem()
			Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
			Me.changeFontSizeItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeFontSizeItem()
			Me.repositoryItemSpreadsheetFontSizeEdit1 = New DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit()
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.spreadsheetCommandBarButtonItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
			Me.spreadsheetCommandBarCheckItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
			Me.spreadsheetCommandBarSubItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
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
			Me.changeBorderLineColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeBorderLineColorItem()
			Me.changeBorderLineStyleItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeBorderLineStyleItem()
			Me.commandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
			Me.changeCellFillColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeCellFillColorItem()
			Me.changeFontColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeFontColorItem()
			Me.barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
			Me.spreadsheetCommandBarCheckItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
			Me.spreadsheetCommandBarCheckItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
			Me.spreadsheetCommandBarButtonItem29 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem30 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarCheckItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarSubItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarCheckItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarButtonItem31 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem32 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem33 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.barButtonGroup8 = New DevExpress.XtraBars.BarButtonGroup()
			Me.changeNumberFormatItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeNumberFormatItem()
			Me.repositoryItemPopupGalleryEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit()
			Me.barButtonGroup9 = New DevExpress.XtraBars.BarButtonGroup()
			Me.spreadsheetCommandBarSubItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem34 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem35 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem36 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem37 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem38 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem39 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem40 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.barButtonGroup10 = New DevExpress.XtraBars.BarButtonGroup()
			Me.spreadsheetCommandBarButtonItem41 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem42 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonItem56 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem57 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.galleryFormatAsTableItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryFormatAsTableItem()
			Me.commandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.galleryChangeStyleItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryChangeStyleItem()
			Me.spreadsheetCommandBarSubItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem58 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem59 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem60 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem61 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem62 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem63 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem64 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem65 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem66 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem67 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem68 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem69 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem70 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem71 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem72 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem73 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem74 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem75 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.changeSheetTabColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeSheetTabColorItem()
			Me.spreadsheetCommandBarButtonItem76 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarCheckItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarButtonItem77 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem78 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem79 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem80 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem81 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem82 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem83 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem84 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem85 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem86 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem87 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem88 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem89 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem90 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem91 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem92 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem93 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem94 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem95 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem96 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem97 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem98 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown8 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown9 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown10 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown11 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown12 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonItem99 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem100 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarCheckItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarSubItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarCheckItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.pageSetupPaperKindItem1 = New DevExpress.XtraSpreadsheet.UI.PageSetupPaperKindItem()
			Me.spreadsheetCommandBarSubItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem101 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem102 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarCheckItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarSubItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem103 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem104 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem105 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem106 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
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
			Me.spreadsheetCommandBarButtonItem112 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem113 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.definedNameListItem1 = New DevExpress.XtraSpreadsheet.UI.DefinedNameListItem()
			Me.spreadsheetCommandBarButtonItem114 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarCheckItem23 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarSubItem24 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarCheckItem24 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem25 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarButtonItem115 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem116 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem117 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem118 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem119 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem120 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem121 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem122 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem123 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem25 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem124 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem125 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem126 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem127 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem128 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem129 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem130 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.galleryChartLayoutItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryChartLayoutItem()
			Me.galleryChartStyleItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryChartStyleItem()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown13 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarSubItem26 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown14 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown15 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown16 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown17 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarSubItem27 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown18 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown19 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarSubItem28 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonGalleryDropDownItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown20 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown21 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown22 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown23 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.spreadsheetCommandBarButtonGalleryDropDownItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
			Me.commandBarGalleryDropDown24 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.renameTableItem1 = New DevExpress.XtraSpreadsheet.UI.RenameTableItem()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.spreadsheetCommandBarCheckItem26 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem27 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem28 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem29 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem30 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem31 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem32 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.galleryTableStylesItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryTableStylesItem()
			Me.spreadsheetCommandBarCheckItem33 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem34 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem35 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarSubItem29 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarCheckItem36 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarCheckItem37 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarButtonItem131 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem132 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem133 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem30 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem134 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem135 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem136 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem137 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem138 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem139 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem140 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem141 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarCheckItem38 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarButtonItem142 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem143 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem31 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem144 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem145 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem32 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem146 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem147 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem148 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem149 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.barButtonGroup11 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup12 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup13 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup14 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup15 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup16 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup17 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup18 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup19 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonGroup20 = New DevExpress.XtraBars.BarButtonGroup()
			Me.spreadsheetCommandBarCheckItem39 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
			Me.spreadsheetCommandBarButtonItem150 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem151 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem33 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem152 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem153 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarSubItem34 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
			Me.spreadsheetCommandBarButtonItem154 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem155 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem156 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem157 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem158 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem159 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem160 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem161 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem162 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.barStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
			Me.chartToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.ChartToolsRibbonPageCategory()
			Me.chartsDesignRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignRibbonPage()
			Me.chartsDesignTypeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignTypeRibbonPageGroup()
			Me.chartsDesignDataRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignDataRibbonPageGroup()
			Me.chartsDesignLayoutsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignLayoutsRibbonPageGroup()
			Me.chartsDesignStylesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignStylesRibbonPageGroup()
			Me.chartsLayoutRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ChartsLayoutRibbonPage()
			Me.chartsLayoutLabelsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsLayoutLabelsRibbonPageGroup()
			Me.chartsLayoutAxesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsLayoutAxesRibbonPageGroup()
			Me.chartsLayoutAnalysisRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsLayoutAnalysisRibbonPageGroup()
			Me.chartsFormatRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ChartsFormatRibbonPage()
			Me.chartsFormatArrangeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsFormatArrangeRibbonPageGroup()
			Me.tableToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageCategory()
			Me.tableToolsDesignRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.TableToolsDesignRibbonPage()
			Me.tablePropertiesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TablePropertiesRibbonPageGroup()
			Me.tableToolsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageGroup()
			Me.tableStyleOptionsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TableStyleOptionsRibbonPageGroup()
			Me.tableStylesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TableStylesRibbonPageGroup()
			Me.pictureToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.PictureToolsRibbonPageCategory()
			Me.pictureFormatRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.PictureFormatRibbonPage()
			Me.pictureFormatArrangeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PictureFormatArrangeRibbonPageGroup()
			Me.drawingToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.DrawingToolsRibbonPageCategory()
			Me.drawingFormatRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.DrawingFormatRibbonPage()
			Me.drawingFormatArrangeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.DrawingFormatArrangeRibbonPageGroup()
			Me.fileRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FileRibbonPage()
			Me.commonRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup()
			Me.infoRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup()
			Me.homeRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.HomeRibbonPage()
			Me.clipboardRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup()
			Me.fontRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup()
			Me.alignmentRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.AlignmentRibbonPageGroup()
			Me.numberRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.NumberRibbonPageGroup()
			Me.cellsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CellsRibbonPageGroup()
			Me.editingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup()
			Me.insertRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.InsertRibbonPage()
			Me.tablesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TablesRibbonPageGroup()
			Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.IllustrationsRibbonPageGroup()
			Me.chartsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsRibbonPageGroup()
			Me.linksRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.LinksRibbonPageGroup()
			Me.symbolsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.SymbolsRibbonPageGroup()
			Me.pageLayoutRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.PageLayoutRibbonPage()
			Me.pageSetupRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PageSetupRibbonPageGroup()
			Me.pageSetupShowRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PageSetupShowRibbonPageGroup()
			Me.pageSetupPrintRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PageSetupPrintRibbonPageGroup()
			Me.arrangeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ArrangeRibbonPageGroup()
			Me.formulasRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FormulasRibbonPage()
			Me.functionLibraryRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FunctionLibraryRibbonPageGroup()
			Me.formulaDefinedNamesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FormulaDefinedNamesRibbonPageGroup()
			Me.formulaAuditingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FormulaAuditingRibbonPageGroup()
			Me.formulaCalculationRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FormulaCalculationRibbonPageGroup()
			Me.dataRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.DataRibbonPage()
			Me.sortAndFilterRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.SortAndFilterRibbonPageGroup()
			Me.outlineRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.OutlineRibbonPageGroup()
			Me.mailMergeRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.MailMergeRibbonPage()
			Me.mailMergeDataRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeDataRibbonPageGroup()
			Me.mailMergeModeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeModeRibbonPageGroup()
			Me.mailMergeExtendedRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeExtendedRibbonPageGroup()
			Me.mailMergeGroupingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeGroupingRibbonPageGroup()
			Me.mailMergeFilteringRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeFilteringRibbonPageGroup()
			Me.mailMergeBindingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeBindingRibbonPageGroup()
			Me.ribbonPageDemoGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.reviewRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ReviewRibbonPage()
			Me.commentsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommentsRibbonPageGroup()
			Me.changesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChangesRibbonPageGroup()
			Me.viewRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ViewRibbonPage()
			Me.showRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ShowRibbonPageGroup()
			Me.zoomRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ZoomRibbonPageGroup()
			Me.windowRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.WindowRibbonPageGroup()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.spreadsheetNameBoxControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl()
			Me.spreadsheetFormulaBarControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl()
			Me.spreadsheetBarController1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController()
			Me.spreadsheetCommandBarButtonItem107 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem108 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem109 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem110 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem111 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetDockManager1 = New DevExpress.XtraSpreadsheet.SpreadsheetDockManager(Me.components)
			Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.fieldListDockPanel1 = New DevExpress.XtraSpreadsheet.FieldListDockPanel()
			Me.fieldListDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.mailMergeParametersDockPanel = New DevExpress.XtraSpreadsheet.MailMergeParametersDockPanel()
			Me.mailMergeParametersDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.filteringDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.checkEdit0 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpreadsheetFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPopupGalleryEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spreadsheetDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelContainer1.SuspendLayout()
			Me.fieldListDockPanel1.SuspendLayout()
			Me.mailMergeParametersDockPanel.SuspendLayout()
			Me.filteringDockPanel.SuspendLayout()
			Me.dockPanel1_Container.SuspendLayout()
			CType(Me.checkEdit0.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
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
			Me.spreadsheetCommandBarSubItem4.Id = 367
			Me.spreadsheetCommandBarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem7)})
			Me.spreadsheetCommandBarSubItem4.Name = "spreadsheetCommandBarSubItem4"
			' 
			' spreadsheetCommandBarSubItem5
			' 
			Me.spreadsheetCommandBarSubItem5.CommandName = "ConditionalFormattingHighlightCellsRuleCommandGroup"
			Me.spreadsheetCommandBarSubItem5.Id = 375
			Me.spreadsheetCommandBarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem43), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem44), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem45), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem46), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem47), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem48), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem49)})
			Me.spreadsheetCommandBarSubItem5.Name = "spreadsheetCommandBarSubItem5"
			' 
			' spreadsheetCommandBarButtonItem43
			' 
			Me.spreadsheetCommandBarButtonItem43.CommandName = "ConditionalFormattingGreaterThanRuleCommand"
			Me.spreadsheetCommandBarButtonItem43.Id = 368
			Me.spreadsheetCommandBarButtonItem43.Name = "spreadsheetCommandBarButtonItem43"
			Me.spreadsheetCommandBarButtonItem43.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem44
			' 
			Me.spreadsheetCommandBarButtonItem44.CommandName = "ConditionalFormattingLessThanRuleCommand"
			Me.spreadsheetCommandBarButtonItem44.Id = 369
			Me.spreadsheetCommandBarButtonItem44.Name = "spreadsheetCommandBarButtonItem44"
			Me.spreadsheetCommandBarButtonItem44.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem45
			' 
			Me.spreadsheetCommandBarButtonItem45.CommandName = "ConditionalFormattingBetweenRuleCommand"
			Me.spreadsheetCommandBarButtonItem45.Id = 370
			Me.spreadsheetCommandBarButtonItem45.Name = "spreadsheetCommandBarButtonItem45"
			Me.spreadsheetCommandBarButtonItem45.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem46
			' 
			Me.spreadsheetCommandBarButtonItem46.CommandName = "ConditionalFormattingEqualToRuleCommand"
			Me.spreadsheetCommandBarButtonItem46.Id = 371
			Me.spreadsheetCommandBarButtonItem46.Name = "spreadsheetCommandBarButtonItem46"
			Me.spreadsheetCommandBarButtonItem46.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem47
			' 
			Me.spreadsheetCommandBarButtonItem47.CommandName = "ConditionalFormattingTextContainsRuleCommand"
			Me.spreadsheetCommandBarButtonItem47.Id = 372
			Me.spreadsheetCommandBarButtonItem47.Name = "spreadsheetCommandBarButtonItem47"
			Me.spreadsheetCommandBarButtonItem47.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem48
			' 
			Me.spreadsheetCommandBarButtonItem48.CommandName = "ConditionalFormattingDateOccurringRuleCommand"
			Me.spreadsheetCommandBarButtonItem48.Id = 373
			Me.spreadsheetCommandBarButtonItem48.Name = "spreadsheetCommandBarButtonItem48"
			Me.spreadsheetCommandBarButtonItem48.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem49
			' 
			Me.spreadsheetCommandBarButtonItem49.CommandName = "ConditionalFormattingDuplicateValuesRuleCommand"
			Me.spreadsheetCommandBarButtonItem49.Id = 374
			Me.spreadsheetCommandBarButtonItem49.Name = "spreadsheetCommandBarButtonItem49"
			Me.spreadsheetCommandBarButtonItem49.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarSubItem6
			' 
			Me.spreadsheetCommandBarSubItem6.CommandName = "ConditionalFormattingTopBottomRuleCommandGroup"
			Me.spreadsheetCommandBarSubItem6.Id = 382
			Me.spreadsheetCommandBarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem50), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem51), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem52), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem53), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem54), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem55)})
			Me.spreadsheetCommandBarSubItem6.Name = "spreadsheetCommandBarSubItem6"
			' 
			' spreadsheetCommandBarButtonItem50
			' 
			Me.spreadsheetCommandBarButtonItem50.CommandName = "ConditionalFormattingTop10RuleCommand"
			Me.spreadsheetCommandBarButtonItem50.Id = 376
			Me.spreadsheetCommandBarButtonItem50.Name = "spreadsheetCommandBarButtonItem50"
			Me.spreadsheetCommandBarButtonItem50.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem51
			' 
			Me.spreadsheetCommandBarButtonItem51.CommandName = "ConditionalFormattingTop10PercentRuleCommand"
			Me.spreadsheetCommandBarButtonItem51.Id = 377
			Me.spreadsheetCommandBarButtonItem51.Name = "spreadsheetCommandBarButtonItem51"
			Me.spreadsheetCommandBarButtonItem51.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem52
			' 
			Me.spreadsheetCommandBarButtonItem52.CommandName = "ConditionalFormattingBottom10RuleCommand"
			Me.spreadsheetCommandBarButtonItem52.Id = 378
			Me.spreadsheetCommandBarButtonItem52.Name = "spreadsheetCommandBarButtonItem52"
			Me.spreadsheetCommandBarButtonItem52.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem53
			' 
			Me.spreadsheetCommandBarButtonItem53.CommandName = "ConditionalFormattingBottom10PercentRuleCommand"
			Me.spreadsheetCommandBarButtonItem53.Id = 379
			Me.spreadsheetCommandBarButtonItem53.Name = "spreadsheetCommandBarButtonItem53"
			Me.spreadsheetCommandBarButtonItem53.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem54
			' 
			Me.spreadsheetCommandBarButtonItem54.CommandName = "ConditionalFormattingAboveAverageRuleCommand"
			Me.spreadsheetCommandBarButtonItem54.Id = 380
			Me.spreadsheetCommandBarButtonItem54.Name = "spreadsheetCommandBarButtonItem54"
			Me.spreadsheetCommandBarButtonItem54.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem55
			' 
			Me.spreadsheetCommandBarButtonItem55.CommandName = "ConditionalFormattingBelowAverageRuleCommand"
			Me.spreadsheetCommandBarButtonItem55.Id = 381
			Me.spreadsheetCommandBarButtonItem55.Name = "spreadsheetCommandBarButtonItem55"
			Me.spreadsheetCommandBarButtonItem55.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem1
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem1.CommandName = "ConditionalFormattingDataBarsCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem1.DropDownControl = Me.commandBarGalleryDropDown2
			Me.spreadsheetCommandBarButtonGalleryDropDownItem1.Id = 383
			Me.spreadsheetCommandBarButtonGalleryDropDownItem1.Name = "spreadsheetCommandBarButtonGalleryDropDownItem1"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' commandBarGalleryDropDown2
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown2.Gallery.AllowFilter = False
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
			Me.commandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup1, spreadsheetCommandGalleryItemGroup2})
			Me.commandBarGalleryDropDown2.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2"
			Me.commandBarGalleryDropDown2.Ribbon = Me.ribbonControl1
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.hideCommentsCheckItem, Me.spreadsheetCommandBarButtonItem1, Me.spreadsheetCommandBarButtonItem2, Me.spreadsheetCommandBarButtonItem3, Me.spreadsheetCommandBarButtonItem4, Me.spreadsheetCommandBarButtonItem5, Me.spreadsheetCommandBarButtonItem6, Me.spreadsheetCommandBarButtonItem7, Me.spreadsheetCommandBarButtonItem8, Me.spreadsheetCommandBarButtonItem9, Me.spreadsheetCommandBarButtonItem10, Me.spreadsheetCommandBarButtonItem11, Me.spreadsheetCommandBarButtonItem12, Me.spreadsheetCommandBarButtonItem13, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.spreadsheetCommandBarButtonItem14, Me.spreadsheetCommandBarButtonItem15, Me.barButtonGroup2, Me.spreadsheetCommandBarCheckItem1, Me.spreadsheetCommandBarCheckItem2, Me.spreadsheetCommandBarCheckItem3, Me.spreadsheetCommandBarCheckItem4, Me.barButtonGroup3, Me.spreadsheetCommandBarSubItem1, Me.spreadsheetCommandBarButtonItem16, Me.spreadsheetCommandBarButtonItem17, Me.spreadsheetCommandBarButtonItem18, Me.spreadsheetCommandBarButtonItem19, Me.spreadsheetCommandBarButtonItem20, Me.spreadsheetCommandBarButtonItem21, Me.spreadsheetCommandBarButtonItem22, Me.spreadsheetCommandBarButtonItem23, Me.spreadsheetCommandBarButtonItem24, Me.spreadsheetCommandBarButtonItem25, Me.spreadsheetCommandBarButtonItem26, Me.spreadsheetCommandBarButtonItem27, Me.spreadsheetCommandBarButtonItem28, Me.changeBorderLineColorItem1, Me.changeBorderLineStyleItem1, Me.barButtonGroup4, Me.changeCellFillColorItem1, Me.changeFontColorItem1, Me.barButtonGroup5, Me.spreadsheetCommandBarCheckItem5, Me.spreadsheetCommandBarCheckItem6, Me.spreadsheetCommandBarCheckItem7, Me.barButtonGroup6, Me.spreadsheetCommandBarCheckItem8, Me.spreadsheetCommandBarCheckItem9, Me.spreadsheetCommandBarCheckItem10, Me.barButtonGroup7, Me.spreadsheetCommandBarButtonItem29, Me.spreadsheetCommandBarButtonItem30, Me.spreadsheetCommandBarCheckItem11, Me.spreadsheetCommandBarSubItem2, Me.spreadsheetCommandBarCheckItem12, Me.spreadsheetCommandBarButtonItem31, Me.spreadsheetCommandBarButtonItem32, Me.spreadsheetCommandBarButtonItem33, Me.barButtonGroup8, Me.changeNumberFormatItem1, Me.barButtonGroup9, Me.spreadsheetCommandBarSubItem3, Me.spreadsheetCommandBarButtonItem34, Me.spreadsheetCommandBarButtonItem35, Me.spreadsheetCommandBarButtonItem36, Me.spreadsheetCommandBarButtonItem37, Me.spreadsheetCommandBarButtonItem38, Me.spreadsheetCommandBarButtonItem39, Me.spreadsheetCommandBarButtonItem40, Me.barButtonGroup10, Me.spreadsheetCommandBarButtonItem41, Me.spreadsheetCommandBarButtonItem42, Me.spreadsheetCommandBarSubItem4, Me.spreadsheetCommandBarButtonItem43, Me.spreadsheetCommandBarButtonItem44, Me.spreadsheetCommandBarButtonItem45, Me.spreadsheetCommandBarButtonItem46, Me.spreadsheetCommandBarButtonItem47, Me.spreadsheetCommandBarButtonItem48, Me.spreadsheetCommandBarButtonItem49, Me.spreadsheetCommandBarSubItem5, Me.spreadsheetCommandBarButtonItem50, Me.spreadsheetCommandBarButtonItem51, Me.spreadsheetCommandBarButtonItem52, Me.spreadsheetCommandBarButtonItem53, Me.spreadsheetCommandBarButtonItem54, Me.spreadsheetCommandBarButtonItem55, Me.spreadsheetCommandBarSubItem6, Me.spreadsheetCommandBarButtonGalleryDropDownItem1, Me.spreadsheetCommandBarButtonGalleryDropDownItem2, Me.spreadsheetCommandBarButtonGalleryDropDownItem3, Me.spreadsheetCommandBarButtonItem56, Me.spreadsheetCommandBarButtonItem57, Me.spreadsheetCommandBarSubItem7, Me.galleryFormatAsTableItem1, Me.galleryChangeStyleItem1, Me.spreadsheetCommandBarSubItem8, Me.spreadsheetCommandBarButtonItem58, Me.spreadsheetCommandBarButtonItem59, Me.spreadsheetCommandBarButtonItem60, Me.spreadsheetCommandBarSubItem9, Me.spreadsheetCommandBarButtonItem61, Me.spreadsheetCommandBarButtonItem62, Me.spreadsheetCommandBarButtonItem63, Me.spreadsheetCommandBarSubItem10, Me.spreadsheetCommandBarButtonItem64, Me.spreadsheetCommandBarButtonItem65, Me.spreadsheetCommandBarButtonItem66, Me.spreadsheetCommandBarButtonItem67, Me.spreadsheetCommandBarButtonItem68, Me.spreadsheetCommandBarButtonItem69, Me.spreadsheetCommandBarButtonItem70, Me.spreadsheetCommandBarButtonItem71, Me.spreadsheetCommandBarButtonItem72, Me.spreadsheetCommandBarButtonItem73, Me.spreadsheetCommandBarButtonItem74, Me.spreadsheetCommandBarSubItem11, Me.spreadsheetCommandBarButtonItem75, Me.changeSheetTabColorItem1, Me.spreadsheetCommandBarButtonItem76, Me.spreadsheetCommandBarCheckItem13, Me.spreadsheetCommandBarButtonItem77, Me.spreadsheetCommandBarSubItem12, Me.spreadsheetCommandBarButtonItem78, Me.spreadsheetCommandBarButtonItem79, Me.spreadsheetCommandBarButtonItem80, Me.spreadsheetCommandBarButtonItem81, Me.spreadsheetCommandBarButtonItem82, Me.spreadsheetCommandBarSubItem13, Me.spreadsheetCommandBarButtonItem83, Me.spreadsheetCommandBarButtonItem84, Me.spreadsheetCommandBarButtonItem85, Me.spreadsheetCommandBarButtonItem86, Me.spreadsheetCommandBarSubItem14, Me.spreadsheetCommandBarButtonItem87, Me.spreadsheetCommandBarButtonItem88, Me.spreadsheetCommandBarButtonItem89, Me.spreadsheetCommandBarButtonItem90, Me.spreadsheetCommandBarButtonItem91, Me.spreadsheetCommandBarButtonItem92, Me.spreadsheetCommandBarSubItem15, Me.spreadsheetCommandBarButtonItem93, Me.spreadsheetCommandBarButtonItem94, Me.spreadsheetCommandBarSubItem16, Me.spreadsheetCommandBarButtonItem95, Me.spreadsheetCommandBarButtonItem96, Me.spreadsheetCommandBarButtonItem97, Me.spreadsheetCommandBarButtonItem98, Me.spreadsheetCommandBarButtonGalleryDropDownItem4, Me.spreadsheetCommandBarButtonGalleryDropDownItem5, Me.spreadsheetCommandBarButtonGalleryDropDownItem6, Me.spreadsheetCommandBarButtonGalleryDropDownItem7, Me.spreadsheetCommandBarButtonGalleryDropDownItem8, Me.spreadsheetCommandBarButtonGalleryDropDownItem9, Me.spreadsheetCommandBarButtonGalleryDropDownItem10, Me.spreadsheetCommandBarButtonItem99, Me.spreadsheetCommandBarButtonItem100, Me.spreadsheetCommandBarSubItem17, Me.spreadsheetCommandBarCheckItem14, Me.spreadsheetCommandBarCheckItem15, Me.spreadsheetCommandBarCheckItem16, Me.spreadsheetCommandBarSubItem18, Me.spreadsheetCommandBarCheckItem17, Me.spreadsheetCommandBarCheckItem18, Me.pageSetupPaperKindItem1, Me.spreadsheetCommandBarSubItem19, Me.spreadsheetCommandBarButtonItem101, Me.spreadsheetCommandBarButtonItem102, Me.spreadsheetCommandBarCheckItem19, Me.spreadsheetCommandBarCheckItem20, Me.spreadsheetCommandBarCheckItem21, Me.spreadsheetCommandBarCheckItem22, Me.spreadsheetCommandBarSubItem20, Me.spreadsheetCommandBarButtonItem103, Me.spreadsheetCommandBarButtonItem104, Me.spreadsheetCommandBarSubItem21, Me.spreadsheetCommandBarButtonItem105, Me.spreadsheetCommandBarButtonItem106, Me.spreadsheetCommandBarSubItem22, Me.functionsFinancialItem1, Me.functionsLogicalItem1, Me.functionsTextItem1, Me.functionsDateAndTimeItem1, Me.functionsLookupAndReferenceItem1, Me.functionsMathAndTrigonometryItem1, Me.spreadsheetCommandBarSubItem23, Me.functionsStatisticalItem1, Me.functionsEngineeringItem1, Me.functionsInformationItem1, Me.functionsCompatibilityItem1, Me.functionsWebItem1, Me.spreadsheetCommandBarButtonItem112, Me.spreadsheetCommandBarButtonItem113, Me.definedNameListItem1, Me.spreadsheetCommandBarButtonItem114, Me.spreadsheetCommandBarCheckItem23, Me.spreadsheetCommandBarSubItem24, Me.spreadsheetCommandBarCheckItem24, Me.spreadsheetCommandBarCheckItem25, Me.spreadsheetCommandBarButtonItem115, Me.spreadsheetCommandBarButtonItem116, Me.spreadsheetCommandBarButtonItem117, Me.spreadsheetCommandBarButtonItem118, Me.spreadsheetCommandBarButtonItem119, Me.spreadsheetCommandBarButtonItem120, Me.spreadsheetCommandBarButtonItem121, Me.spreadsheetCommandBarButtonItem122, Me.spreadsheetCommandBarButtonItem123, Me.spreadsheetCommandBarSubItem25, Me.spreadsheetCommandBarButtonItem124, Me.spreadsheetCommandBarButtonItem125, Me.spreadsheetCommandBarButtonItem126, Me.spreadsheetCommandBarButtonItem127, Me.spreadsheetCommandBarButtonItem128, Me.spreadsheetCommandBarButtonItem129, Me.spreadsheetCommandBarButtonItem130, Me.galleryChartLayoutItem1, Me.galleryChartStyleItem1, Me.spreadsheetCommandBarButtonGalleryDropDownItem11, Me.spreadsheetCommandBarSubItem26, Me.spreadsheetCommandBarButtonGalleryDropDownItem12, Me.spreadsheetCommandBarButtonGalleryDropDownItem13, Me.spreadsheetCommandBarButtonGalleryDropDownItem14, Me.spreadsheetCommandBarButtonGalleryDropDownItem15, Me.spreadsheetCommandBarSubItem27, Me.spreadsheetCommandBarButtonGalleryDropDownItem16, Me.spreadsheetCommandBarButtonGalleryDropDownItem17, Me.spreadsheetCommandBarSubItem28, Me.spreadsheetCommandBarButtonGalleryDropDownItem18, Me.spreadsheetCommandBarButtonGalleryDropDownItem19, Me.spreadsheetCommandBarButtonGalleryDropDownItem20, Me.spreadsheetCommandBarButtonGalleryDropDownItem21, Me.spreadsheetCommandBarButtonGalleryDropDownItem22, Me.barStaticItem1, Me.renameTableItem1, Me.spreadsheetCommandBarCheckItem26, Me.spreadsheetCommandBarCheckItem27, Me.spreadsheetCommandBarCheckItem28, Me.spreadsheetCommandBarCheckItem29, Me.spreadsheetCommandBarCheckItem30, Me.spreadsheetCommandBarCheckItem31, Me.spreadsheetCommandBarCheckItem32, Me.galleryTableStylesItem1, Me.spreadsheetCommandBarCheckItem33, Me.spreadsheetCommandBarCheckItem34, Me.spreadsheetCommandBarCheckItem35, Me.spreadsheetCommandBarSubItem29, Me.spreadsheetCommandBarCheckItem36, Me.spreadsheetCommandBarCheckItem37, Me.spreadsheetCommandBarButtonItem131, Me.spreadsheetCommandBarButtonItem132, Me.spreadsheetCommandBarButtonItem133, Me.spreadsheetCommandBarSubItem30, Me.spreadsheetCommandBarButtonItem134, Me.spreadsheetCommandBarButtonItem135, Me.spreadsheetCommandBarButtonItem136, Me.spreadsheetCommandBarButtonItem137, Me.spreadsheetCommandBarButtonItem138, Me.spreadsheetCommandBarButtonItem139, Me.spreadsheetCommandBarButtonItem140, Me.spreadsheetCommandBarButtonItem141, Me.spreadsheetCommandBarCheckItem38, Me.spreadsheetCommandBarButtonItem142, Me.spreadsheetCommandBarButtonItem143, Me.spreadsheetCommandBarSubItem31, Me.spreadsheetCommandBarButtonItem144, Me.spreadsheetCommandBarButtonItem145, Me.spreadsheetCommandBarSubItem32, Me.spreadsheetCommandBarButtonItem146, Me.spreadsheetCommandBarButtonItem147, Me.spreadsheetCommandBarButtonItem148, Me.spreadsheetCommandBarButtonItem149, Me.barButtonGroup11, Me.barButtonGroup12, Me.barButtonGroup13, Me.barButtonGroup14, Me.barButtonGroup15, Me.barButtonGroup16, Me.barButtonGroup17, Me.barButtonGroup18, Me.barButtonGroup19, Me.barButtonGroup20, Me.spreadsheetCommandBarCheckItem39, Me.spreadsheetCommandBarButtonItem150, Me.spreadsheetCommandBarButtonItem151, Me.spreadsheetCommandBarSubItem33, Me.spreadsheetCommandBarButtonItem152, Me.spreadsheetCommandBarButtonItem153, Me.spreadsheetCommandBarSubItem34, Me.spreadsheetCommandBarButtonItem154, Me.spreadsheetCommandBarButtonItem155, Me.spreadsheetCommandBarButtonItem156, Me.spreadsheetCommandBarButtonItem157, Me.spreadsheetCommandBarButtonItem158, Me.spreadsheetCommandBarButtonItem159, Me.spreadsheetCommandBarButtonItem160, Me.spreadsheetCommandBarButtonItem161, Me.spreadsheetCommandBarButtonItem162, Me.barStaticItem2})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 604
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.chartToolsRibbonPageCategory1, Me.tableToolsRibbonPageCategory1, Me.pictureToolsRibbonPageCategory1, Me.drawingToolsRibbonPageCategory1})
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.homeRibbonPage1, Me.insertRibbonPage1, Me.pageLayoutRibbonPage1, Me.formulasRibbonPage1, Me.dataRibbonPage1, Me.mailMergeRibbonPage1, Me.reviewRibbonPage1, Me.viewRibbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemSpreadsheetFontSizeEdit1, Me.repositoryItemPopupGalleryEdit1, Me.repositoryItemTextEdit1})
			Me.ribbonControl1.Size = New System.Drawing.Size(1062, 142)
			' 
			' hideCommentsCheckItem
			' 
			Me.hideCommentsCheckItem.Caption = "Hide Comments"
			Me.hideCommentsCheckItem.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.hideCommentsCheckItem.Description = "Show or hide descriptive comments in the template."
			Me.hideCommentsCheckItem.Glyph = (CType(resources.GetObject("hideCommentsCheckItem.Glyph"), System.Drawing.Image))
			Me.hideCommentsCheckItem.Id = 230
			Me.hideCommentsCheckItem.LargeGlyph = (CType(resources.GetObject("hideCommentsCheckItem.LargeGlyph"), System.Drawing.Image))
			Me.hideCommentsCheckItem.Name = "hideCommentsCheckItem"
			Me.hideCommentsCheckItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			toolTipTitleItem1.Text = "Hide Comments"
			toolTipItem1.Text = "Show or hide descriptive comments in the template."
			superToolTip1.Items.Add(toolTipTitleItem1)
			superToolTip1.Items.Add(toolTipItem1)
			Me.hideCommentsCheckItem.SuperTip = superToolTip1
'			Me.hideCommentsCheckItem.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.hideCommentsCheckItem_ItemClick);
			' 
			' spreadsheetCommandBarButtonItem1
			' 
			Me.spreadsheetCommandBarButtonItem1.CommandName = "FileNew"
			Me.spreadsheetCommandBarButtonItem1.Id = 293
			Me.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1"
			' 
			' spreadsheetCommandBarButtonItem2
			' 
			Me.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen"
			Me.spreadsheetCommandBarButtonItem2.Id = 294
			Me.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2"
			' 
			' spreadsheetCommandBarButtonItem3
			' 
			Me.spreadsheetCommandBarButtonItem3.CommandName = "FileSave"
			Me.spreadsheetCommandBarButtonItem3.Id = 295
			Me.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3"
			' 
			' spreadsheetCommandBarButtonItem4
			' 
			Me.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs"
			Me.spreadsheetCommandBarButtonItem4.Id = 296
			Me.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4"
			' 
			' spreadsheetCommandBarButtonItem5
			' 
			Me.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint"
			Me.spreadsheetCommandBarButtonItem5.Id = 297
			Me.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5"
			' 
			' spreadsheetCommandBarButtonItem6
			' 
			Me.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint"
			Me.spreadsheetCommandBarButtonItem6.Id = 298
			Me.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6"
			' 
			' spreadsheetCommandBarButtonItem7
			' 
			Me.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview"
			Me.spreadsheetCommandBarButtonItem7.Id = 299
			Me.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7"
			' 
			' spreadsheetCommandBarButtonItem8
			' 
			Me.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo"
			Me.spreadsheetCommandBarButtonItem8.Id = 300
			Me.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8"
			' 
			' spreadsheetCommandBarButtonItem9
			' 
			Me.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo"
			Me.spreadsheetCommandBarButtonItem9.Id = 301
			Me.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9"
			' 
			' spreadsheetCommandBarButtonItem10
			' 
			Me.spreadsheetCommandBarButtonItem10.CommandName = "PasteSelection"
			Me.spreadsheetCommandBarButtonItem10.Id = 312
			Me.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10"
			Me.spreadsheetCommandBarButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem11
			' 
			Me.spreadsheetCommandBarButtonItem11.CommandName = "CutSelection"
			Me.spreadsheetCommandBarButtonItem11.Id = 313
			Me.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11"
			Me.spreadsheetCommandBarButtonItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem12
			' 
			Me.spreadsheetCommandBarButtonItem12.CommandName = "CopySelection"
			Me.spreadsheetCommandBarButtonItem12.Id = 314
			Me.spreadsheetCommandBarButtonItem12.Name = "spreadsheetCommandBarButtonItem12"
			Me.spreadsheetCommandBarButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem13
			' 
			Me.spreadsheetCommandBarButtonItem13.CommandName = "ShowPasteSpecialForm"
			Me.spreadsheetCommandBarButtonItem13.Id = 315
			Me.spreadsheetCommandBarButtonItem13.Name = "spreadsheetCommandBarButtonItem13"
			Me.spreadsheetCommandBarButtonItem13.RibbonStyle = (CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
			' 
			' barButtonGroup1
			' 
			Me.barButtonGroup1.Id = 302
			Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1)
			Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
			Me.barButtonGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem14)
			Me.barButtonGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem15)
			Me.barButtonGroup1.Name = "barButtonGroup1"
			Me.barButtonGroup1.Tag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
			' 
			' changeFontNameItem1
			' 
			Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
			Me.changeFontNameItem1.Id = 316
			Me.changeFontNameItem1.Name = "changeFontNameItem1"
			' 
			' repositoryItemFontEdit1
			' 
			Me.repositoryItemFontEdit1.AutoHeight = False
			Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
			' 
			' changeFontSizeItem1
			' 
			Me.changeFontSizeItem1.Edit = Me.repositoryItemSpreadsheetFontSizeEdit1
			Me.changeFontSizeItem1.Id = 317
			Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
			' 
			' repositoryItemSpreadsheetFontSizeEdit1
			' 
			Me.repositoryItemSpreadsheetFontSizeEdit1.AutoHeight = False
			Me.repositoryItemSpreadsheetFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemSpreadsheetFontSizeEdit1.Control = Me.spreadsheetControl1
			Me.repositoryItemSpreadsheetFontSizeEdit1.Name = "repositoryItemSpreadsheetFontSizeEdit1"
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 162)
			Me.spreadsheetControl1.MenuManager = Me.ribbonControl1
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spreadsheetControl1.Options.Export.Csv.Encoding = (CType(resources.GetObject("spreadsheetControl1.Options.Export.Csv.Encoding"), System.Text.Encoding))
			Me.spreadsheetControl1.Options.Export.Txt.Encoding = (CType(resources.GetObject("spreadsheetControl1.Options.Export.Txt.Encoding"), System.Text.Encoding))
			Me.spreadsheetControl1.Size = New System.Drawing.Size(862, 270)
			Me.spreadsheetControl1.TabIndex = 0
			' 
			' spreadsheetCommandBarButtonItem14
			' 
			Me.spreadsheetCommandBarButtonItem14.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
			Me.spreadsheetCommandBarButtonItem14.CommandName = "FormatIncreaseFontSize"
			Me.spreadsheetCommandBarButtonItem14.Id = 318
			Me.spreadsheetCommandBarButtonItem14.Name = "spreadsheetCommandBarButtonItem14"
			Me.spreadsheetCommandBarButtonItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem15
			' 
			Me.spreadsheetCommandBarButtonItem15.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
			Me.spreadsheetCommandBarButtonItem15.CommandName = "FormatDecreaseFontSize"
			Me.spreadsheetCommandBarButtonItem15.Id = 319
			Me.spreadsheetCommandBarButtonItem15.Name = "spreadsheetCommandBarButtonItem15"
			Me.spreadsheetCommandBarButtonItem15.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' barButtonGroup2
			' 
			Me.barButtonGroup2.Id = 303
			Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem1)
			Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem2)
			Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem3)
			Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem4)
			Me.barButtonGroup2.Name = "barButtonGroup2"
			Me.barButtonGroup2.Tag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
			' 
			' spreadsheetCommandBarCheckItem1
			' 
			Me.spreadsheetCommandBarCheckItem1.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
			Me.spreadsheetCommandBarCheckItem1.CommandName = "FormatFontBold"
			Me.spreadsheetCommandBarCheckItem1.Id = 320
			Me.spreadsheetCommandBarCheckItem1.Name = "spreadsheetCommandBarCheckItem1"
			Me.spreadsheetCommandBarCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem2
			' 
			Me.spreadsheetCommandBarCheckItem2.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
			Me.spreadsheetCommandBarCheckItem2.CommandName = "FormatFontItalic"
			Me.spreadsheetCommandBarCheckItem2.Id = 321
			Me.spreadsheetCommandBarCheckItem2.Name = "spreadsheetCommandBarCheckItem2"
			Me.spreadsheetCommandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem3
			' 
			Me.spreadsheetCommandBarCheckItem3.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
			Me.spreadsheetCommandBarCheckItem3.CommandName = "FormatFontUnderline"
			Me.spreadsheetCommandBarCheckItem3.Id = 322
			Me.spreadsheetCommandBarCheckItem3.Name = "spreadsheetCommandBarCheckItem3"
			Me.spreadsheetCommandBarCheckItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem4
			' 
			Me.spreadsheetCommandBarCheckItem4.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
			Me.spreadsheetCommandBarCheckItem4.CommandName = "FormatFontStrikeout"
			Me.spreadsheetCommandBarCheckItem4.Id = 323
			Me.spreadsheetCommandBarCheckItem4.Name = "spreadsheetCommandBarCheckItem4"
			Me.spreadsheetCommandBarCheckItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' barButtonGroup3
			' 
			Me.barButtonGroup3.Id = 304
			Me.barButtonGroup3.ItemLinks.Add(Me.spreadsheetCommandBarSubItem1)
			Me.barButtonGroup3.Name = "barButtonGroup3"
			Me.barButtonGroup3.Tag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}"
			' 
			' spreadsheetCommandBarSubItem1
			' 
			Me.spreadsheetCommandBarSubItem1.ButtonGroupTag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}"
			Me.spreadsheetCommandBarSubItem1.CommandName = "FormatBordersCommandGroup"
			Me.spreadsheetCommandBarSubItem1.Id = 324
			Me.spreadsheetCommandBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem26), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem27), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem28), New DevExpress.XtraBars.LinkPersistInfo(Me.changeBorderLineColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeBorderLineStyleItem1)})
			Me.spreadsheetCommandBarSubItem1.Name = "spreadsheetCommandBarSubItem1"
			Me.spreadsheetCommandBarSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem16
			' 
			Me.spreadsheetCommandBarButtonItem16.CommandName = "FormatBottomBorder"
			Me.spreadsheetCommandBarButtonItem16.Id = 325
			Me.spreadsheetCommandBarButtonItem16.Name = "spreadsheetCommandBarButtonItem16"
			' 
			' spreadsheetCommandBarButtonItem17
			' 
			Me.spreadsheetCommandBarButtonItem17.CommandName = "FormatTopBorder"
			Me.spreadsheetCommandBarButtonItem17.Id = 326
			Me.spreadsheetCommandBarButtonItem17.Name = "spreadsheetCommandBarButtonItem17"
			' 
			' spreadsheetCommandBarButtonItem18
			' 
			Me.spreadsheetCommandBarButtonItem18.CommandName = "FormatLeftBorder"
			Me.spreadsheetCommandBarButtonItem18.Id = 327
			Me.spreadsheetCommandBarButtonItem18.Name = "spreadsheetCommandBarButtonItem18"
			' 
			' spreadsheetCommandBarButtonItem19
			' 
			Me.spreadsheetCommandBarButtonItem19.CommandName = "FormatRightBorder"
			Me.spreadsheetCommandBarButtonItem19.Id = 328
			Me.spreadsheetCommandBarButtonItem19.Name = "spreadsheetCommandBarButtonItem19"
			' 
			' spreadsheetCommandBarButtonItem20
			' 
			Me.spreadsheetCommandBarButtonItem20.CommandName = "FormatNoBorders"
			Me.spreadsheetCommandBarButtonItem20.Id = 329
			Me.spreadsheetCommandBarButtonItem20.Name = "spreadsheetCommandBarButtonItem20"
			' 
			' spreadsheetCommandBarButtonItem21
			' 
			Me.spreadsheetCommandBarButtonItem21.CommandName = "FormatAllBorders"
			Me.spreadsheetCommandBarButtonItem21.Id = 330
			Me.spreadsheetCommandBarButtonItem21.Name = "spreadsheetCommandBarButtonItem21"
			' 
			' spreadsheetCommandBarButtonItem22
			' 
			Me.spreadsheetCommandBarButtonItem22.CommandName = "FormatOutsideBorders"
			Me.spreadsheetCommandBarButtonItem22.Id = 331
			Me.spreadsheetCommandBarButtonItem22.Name = "spreadsheetCommandBarButtonItem22"
			' 
			' spreadsheetCommandBarButtonItem23
			' 
			Me.spreadsheetCommandBarButtonItem23.CommandName = "FormatThickBorder"
			Me.spreadsheetCommandBarButtonItem23.Id = 332
			Me.spreadsheetCommandBarButtonItem23.Name = "spreadsheetCommandBarButtonItem23"
			' 
			' spreadsheetCommandBarButtonItem24
			' 
			Me.spreadsheetCommandBarButtonItem24.CommandName = "FormatBottomDoubleBorder"
			Me.spreadsheetCommandBarButtonItem24.Id = 333
			Me.spreadsheetCommandBarButtonItem24.Name = "spreadsheetCommandBarButtonItem24"
			' 
			' spreadsheetCommandBarButtonItem25
			' 
			Me.spreadsheetCommandBarButtonItem25.CommandName = "FormatBottomThickBorder"
			Me.spreadsheetCommandBarButtonItem25.Id = 334
			Me.spreadsheetCommandBarButtonItem25.Name = "spreadsheetCommandBarButtonItem25"
			' 
			' spreadsheetCommandBarButtonItem26
			' 
			Me.spreadsheetCommandBarButtonItem26.CommandName = "FormatTopAndBottomBorder"
			Me.spreadsheetCommandBarButtonItem26.Id = 335
			Me.spreadsheetCommandBarButtonItem26.Name = "spreadsheetCommandBarButtonItem26"
			' 
			' spreadsheetCommandBarButtonItem27
			' 
			Me.spreadsheetCommandBarButtonItem27.CommandName = "FormatTopAndThickBottomBorder"
			Me.spreadsheetCommandBarButtonItem27.Id = 336
			Me.spreadsheetCommandBarButtonItem27.Name = "spreadsheetCommandBarButtonItem27"
			' 
			' spreadsheetCommandBarButtonItem28
			' 
			Me.spreadsheetCommandBarButtonItem28.CommandName = "FormatTopAndDoubleBottomBorder"
			Me.spreadsheetCommandBarButtonItem28.Id = 337
			Me.spreadsheetCommandBarButtonItem28.Name = "spreadsheetCommandBarButtonItem28"
			' 
			' changeBorderLineColorItem1
			' 
			Me.changeBorderLineColorItem1.ActAsDropDown = True
			Me.changeBorderLineColorItem1.Id = 338
			Me.changeBorderLineColorItem1.Name = "changeBorderLineColorItem1"
			' 
			' changeBorderLineStyleItem1
			' 
			Me.changeBorderLineStyleItem1.DropDownControl = Me.commandBarGalleryDropDown1
			Me.changeBorderLineStyleItem1.Id = 339
			Me.changeBorderLineStyleItem1.Name = "changeBorderLineStyleItem1"
			' 
			' commandBarGalleryDropDown1
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown1.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown1.Gallery.ColumnCount = 1
			Me.commandBarGalleryDropDown1.Gallery.DrawImageBackground = False
			Me.commandBarGalleryDropDown1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
			Me.commandBarGalleryDropDown1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
			Me.commandBarGalleryDropDown1.Gallery.ItemSize = New System.Drawing.Size(136, 26)
			Me.commandBarGalleryDropDown1.Gallery.RowCount = 14
			Me.commandBarGalleryDropDown1.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown1.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1"
			Me.commandBarGalleryDropDown1.Ribbon = Me.ribbonControl1
			' 
			' barButtonGroup4
			' 
			Me.barButtonGroup4.Id = 305
			Me.barButtonGroup4.ItemLinks.Add(Me.changeCellFillColorItem1)
			Me.barButtonGroup4.ItemLinks.Add(Me.changeFontColorItem1)
			Me.barButtonGroup4.Name = "barButtonGroup4"
			Me.barButtonGroup4.Tag = "{C2275623-04A3-41E8-8D6A-EB5C7F8541D1}"
			' 
			' changeCellFillColorItem1
			' 
			Me.changeCellFillColorItem1.Id = 340
			Me.changeCellFillColorItem1.Name = "changeCellFillColorItem1"
			' 
			' changeFontColorItem1
			' 
			Me.changeFontColorItem1.Id = 341
			Me.changeFontColorItem1.Name = "changeFontColorItem1"
			' 
			' barButtonGroup5
			' 
			Me.barButtonGroup5.Id = 306
			Me.barButtonGroup5.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem5)
			Me.barButtonGroup5.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem6)
			Me.barButtonGroup5.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem7)
			Me.barButtonGroup5.Name = "barButtonGroup5"
			Me.barButtonGroup5.Tag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
			' 
			' spreadsheetCommandBarCheckItem5
			' 
			Me.spreadsheetCommandBarCheckItem5.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
			Me.spreadsheetCommandBarCheckItem5.CommandName = "FormatAlignmentTop"
			Me.spreadsheetCommandBarCheckItem5.Id = 342
			Me.spreadsheetCommandBarCheckItem5.Name = "spreadsheetCommandBarCheckItem5"
			Me.spreadsheetCommandBarCheckItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem6
			' 
			Me.spreadsheetCommandBarCheckItem6.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
			Me.spreadsheetCommandBarCheckItem6.CommandName = "FormatAlignmentMiddle"
			Me.spreadsheetCommandBarCheckItem6.Id = 343
			Me.spreadsheetCommandBarCheckItem6.Name = "spreadsheetCommandBarCheckItem6"
			Me.spreadsheetCommandBarCheckItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem7
			' 
			Me.spreadsheetCommandBarCheckItem7.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
			Me.spreadsheetCommandBarCheckItem7.CommandName = "FormatAlignmentBottom"
			Me.spreadsheetCommandBarCheckItem7.Id = 344
			Me.spreadsheetCommandBarCheckItem7.Name = "spreadsheetCommandBarCheckItem7"
			Me.spreadsheetCommandBarCheckItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' barButtonGroup6
			' 
			Me.barButtonGroup6.Id = 307
			Me.barButtonGroup6.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem8)
			Me.barButtonGroup6.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem9)
			Me.barButtonGroup6.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem10)
			Me.barButtonGroup6.Name = "barButtonGroup6"
			Me.barButtonGroup6.Tag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
			' 
			' spreadsheetCommandBarCheckItem8
			' 
			Me.spreadsheetCommandBarCheckItem8.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
			Me.spreadsheetCommandBarCheckItem8.CommandName = "FormatAlignmentLeft"
			Me.spreadsheetCommandBarCheckItem8.Id = 345
			Me.spreadsheetCommandBarCheckItem8.Name = "spreadsheetCommandBarCheckItem8"
			Me.spreadsheetCommandBarCheckItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem9
			' 
			Me.spreadsheetCommandBarCheckItem9.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
			Me.spreadsheetCommandBarCheckItem9.CommandName = "FormatAlignmentCenter"
			Me.spreadsheetCommandBarCheckItem9.Id = 346
			Me.spreadsheetCommandBarCheckItem9.Name = "spreadsheetCommandBarCheckItem9"
			Me.spreadsheetCommandBarCheckItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem10
			' 
			Me.spreadsheetCommandBarCheckItem10.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
			Me.spreadsheetCommandBarCheckItem10.CommandName = "FormatAlignmentRight"
			Me.spreadsheetCommandBarCheckItem10.Id = 347
			Me.spreadsheetCommandBarCheckItem10.Name = "spreadsheetCommandBarCheckItem10"
			Me.spreadsheetCommandBarCheckItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' barButtonGroup7
			' 
			Me.barButtonGroup7.Id = 308
			Me.barButtonGroup7.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem29)
			Me.barButtonGroup7.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem30)
			Me.barButtonGroup7.Name = "barButtonGroup7"
			Me.barButtonGroup7.Tag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
			' 
			' spreadsheetCommandBarButtonItem29
			' 
			Me.spreadsheetCommandBarButtonItem29.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
			Me.spreadsheetCommandBarButtonItem29.CommandName = "FormatDecreaseIndent"
			Me.spreadsheetCommandBarButtonItem29.Id = 348
			Me.spreadsheetCommandBarButtonItem29.Name = "spreadsheetCommandBarButtonItem29"
			Me.spreadsheetCommandBarButtonItem29.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem30
			' 
			Me.spreadsheetCommandBarButtonItem30.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
			Me.spreadsheetCommandBarButtonItem30.CommandName = "FormatIncreaseIndent"
			Me.spreadsheetCommandBarButtonItem30.Id = 349
			Me.spreadsheetCommandBarButtonItem30.Name = "spreadsheetCommandBarButtonItem30"
			Me.spreadsheetCommandBarButtonItem30.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarCheckItem11
			' 
			Me.spreadsheetCommandBarCheckItem11.CommandName = "FormatWrapText"
			Me.spreadsheetCommandBarCheckItem11.Id = 350
			Me.spreadsheetCommandBarCheckItem11.Name = "spreadsheetCommandBarCheckItem11"
			Me.spreadsheetCommandBarCheckItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarSubItem2
			' 
			Me.spreadsheetCommandBarSubItem2.CommandName = "EditingMergeCellsCommandGroup"
			Me.spreadsheetCommandBarSubItem2.Id = 351
			Me.spreadsheetCommandBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem31), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem32), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem33)})
			Me.spreadsheetCommandBarSubItem2.Name = "spreadsheetCommandBarSubItem2"
			Me.spreadsheetCommandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarCheckItem12
			' 
			Me.spreadsheetCommandBarCheckItem12.CommandName = "EditingMergeAndCenterCells"
			Me.spreadsheetCommandBarCheckItem12.Id = 352
			Me.spreadsheetCommandBarCheckItem12.Name = "spreadsheetCommandBarCheckItem12"
			' 
			' spreadsheetCommandBarButtonItem31
			' 
			Me.spreadsheetCommandBarButtonItem31.CommandName = "EditingMergeCellsAcross"
			Me.spreadsheetCommandBarButtonItem31.Id = 353
			Me.spreadsheetCommandBarButtonItem31.Name = "spreadsheetCommandBarButtonItem31"
			' 
			' spreadsheetCommandBarButtonItem32
			' 
			Me.spreadsheetCommandBarButtonItem32.CommandName = "EditingMergeCells"
			Me.spreadsheetCommandBarButtonItem32.Id = 354
			Me.spreadsheetCommandBarButtonItem32.Name = "spreadsheetCommandBarButtonItem32"
			' 
			' spreadsheetCommandBarButtonItem33
			' 
			Me.spreadsheetCommandBarButtonItem33.CommandName = "EditingUnmergeCells"
			Me.spreadsheetCommandBarButtonItem33.Id = 355
			Me.spreadsheetCommandBarButtonItem33.Name = "spreadsheetCommandBarButtonItem33"
			' 
			' barButtonGroup8
			' 
			Me.barButtonGroup8.Id = 309
			Me.barButtonGroup8.ItemLinks.Add(Me.changeNumberFormatItem1)
			Me.barButtonGroup8.Name = "barButtonGroup8"
			Me.barButtonGroup8.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
			' 
			' changeNumberFormatItem1
			' 
			Me.changeNumberFormatItem1.Edit = Me.repositoryItemPopupGalleryEdit1
			Me.changeNumberFormatItem1.Id = 356
			Me.changeNumberFormatItem1.Name = "changeNumberFormatItem1"
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
			Me.barButtonGroup9.Id = 310
			Me.barButtonGroup9.ItemLinks.Add(Me.spreadsheetCommandBarSubItem3)
			Me.barButtonGroup9.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem39)
			Me.barButtonGroup9.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem40)
			Me.barButtonGroup9.Name = "barButtonGroup9"
			Me.barButtonGroup9.Tag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
			' 
			' spreadsheetCommandBarSubItem3
			' 
			Me.spreadsheetCommandBarSubItem3.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
			Me.spreadsheetCommandBarSubItem3.CommandName = "FormatNumberAccountingCommandGroup"
			Me.spreadsheetCommandBarSubItem3.Id = 357
			Me.spreadsheetCommandBarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem34), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem35), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem36), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem37), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem38)})
			Me.spreadsheetCommandBarSubItem3.Name = "spreadsheetCommandBarSubItem3"
			Me.spreadsheetCommandBarSubItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem34
			' 
			Me.spreadsheetCommandBarButtonItem34.CommandName = "FormatNumberAccountingUS"
			Me.spreadsheetCommandBarButtonItem34.Id = 358
			Me.spreadsheetCommandBarButtonItem34.Name = "spreadsheetCommandBarButtonItem34"
			' 
			' spreadsheetCommandBarButtonItem35
			' 
			Me.spreadsheetCommandBarButtonItem35.CommandName = "FormatNumberAccountingUK"
			Me.spreadsheetCommandBarButtonItem35.Id = 359
			Me.spreadsheetCommandBarButtonItem35.Name = "spreadsheetCommandBarButtonItem35"
			' 
			' spreadsheetCommandBarButtonItem36
			' 
			Me.spreadsheetCommandBarButtonItem36.CommandName = "FormatNumberAccountingEuro"
			Me.spreadsheetCommandBarButtonItem36.Id = 360
			Me.spreadsheetCommandBarButtonItem36.Name = "spreadsheetCommandBarButtonItem36"
			' 
			' spreadsheetCommandBarButtonItem37
			' 
			Me.spreadsheetCommandBarButtonItem37.CommandName = "FormatNumberAccountingPRC"
			Me.spreadsheetCommandBarButtonItem37.Id = 361
			Me.spreadsheetCommandBarButtonItem37.Name = "spreadsheetCommandBarButtonItem37"
			' 
			' spreadsheetCommandBarButtonItem38
			' 
			Me.spreadsheetCommandBarButtonItem38.CommandName = "FormatNumberAccountingSwiss"
			Me.spreadsheetCommandBarButtonItem38.Id = 362
			Me.spreadsheetCommandBarButtonItem38.Name = "spreadsheetCommandBarButtonItem38"
			' 
			' spreadsheetCommandBarButtonItem39
			' 
			Me.spreadsheetCommandBarButtonItem39.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
			Me.spreadsheetCommandBarButtonItem39.CommandName = "FormatNumberPercent"
			Me.spreadsheetCommandBarButtonItem39.Id = 363
			Me.spreadsheetCommandBarButtonItem39.Name = "spreadsheetCommandBarButtonItem39"
			Me.spreadsheetCommandBarButtonItem39.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem40
			' 
			Me.spreadsheetCommandBarButtonItem40.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
			Me.spreadsheetCommandBarButtonItem40.CommandName = "FormatNumberAccounting"
			Me.spreadsheetCommandBarButtonItem40.Id = 364
			Me.spreadsheetCommandBarButtonItem40.Name = "spreadsheetCommandBarButtonItem40"
			Me.spreadsheetCommandBarButtonItem40.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' barButtonGroup10
			' 
			Me.barButtonGroup10.Id = 311
			Me.barButtonGroup10.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem41)
			Me.barButtonGroup10.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem42)
			Me.barButtonGroup10.Name = "barButtonGroup10"
			Me.barButtonGroup10.Tag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
			' 
			' spreadsheetCommandBarButtonItem41
			' 
			Me.spreadsheetCommandBarButtonItem41.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
			Me.spreadsheetCommandBarButtonItem41.CommandName = "FormatNumberIncreaseDecimal"
			Me.spreadsheetCommandBarButtonItem41.Id = 365
			Me.spreadsheetCommandBarButtonItem41.Name = "spreadsheetCommandBarButtonItem41"
			Me.spreadsheetCommandBarButtonItem41.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonItem42
			' 
			Me.spreadsheetCommandBarButtonItem42.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
			Me.spreadsheetCommandBarButtonItem42.CommandName = "FormatNumberDecreaseDecimal"
			Me.spreadsheetCommandBarButtonItem42.Id = 366
			Me.spreadsheetCommandBarButtonItem42.Name = "spreadsheetCommandBarButtonItem42"
			Me.spreadsheetCommandBarButtonItem42.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem2
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem2.CommandName = "ConditionalFormattingColorScalesCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem2.DropDownControl = Me.commandBarGalleryDropDown3
			Me.spreadsheetCommandBarButtonGalleryDropDownItem2.Id = 384
			Me.spreadsheetCommandBarButtonGalleryDropDownItem2.Name = "spreadsheetCommandBarButtonGalleryDropDownItem2"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' commandBarGalleryDropDown3
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown3.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup3.CommandName = "ConditionalFormattingColorScalesCommandGroup"
			spreadsheetCommandGalleryItem24.CommandName = "ConditionalFormattingColorScaleGreenYellowRed"
			spreadsheetCommandGalleryItem25.CommandName = "ConditionalFormattingColorScaleRedYellowGreen"
			spreadsheetCommandGalleryItem26.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed"
			spreadsheetCommandGalleryItem27.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen"
			spreadsheetCommandGalleryItem28.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed"
			spreadsheetCommandGalleryItem29.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue"
			spreadsheetCommandGalleryItem30.CommandName = "ConditionalFormattingColorScaleWhiteRed"
			spreadsheetCommandGalleryItem31.CommandName = "ConditionalFormattingColorScaleRedWhite"
			spreadsheetCommandGalleryItem32.CommandName = "ConditionalFormattingColorScaleGreenWhite"
			spreadsheetCommandGalleryItem33.CommandName = "ConditionalFormattingColorScaleWhiteGreen"
			spreadsheetCommandGalleryItem34.CommandName = "ConditionalFormattingColorScaleGreenYellow"
			spreadsheetCommandGalleryItem35.CommandName = "ConditionalFormattingColorScaleYellowGreen"
			spreadsheetCommandGalleryItemGroup3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem24, spreadsheetCommandGalleryItem25, spreadsheetCommandGalleryItem26, spreadsheetCommandGalleryItem27, spreadsheetCommandGalleryItem28, spreadsheetCommandGalleryItem29, spreadsheetCommandGalleryItem30, spreadsheetCommandGalleryItem31, spreadsheetCommandGalleryItem32, spreadsheetCommandGalleryItem33, spreadsheetCommandGalleryItem34, spreadsheetCommandGalleryItem35})
			Me.commandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup3})
			Me.commandBarGalleryDropDown3.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3"
			Me.commandBarGalleryDropDown3.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem3
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem3.CommandName = "ConditionalFormattingIconSetsCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem3.DropDownControl = Me.commandBarGalleryDropDown4
			Me.spreadsheetCommandBarButtonGalleryDropDownItem3.Id = 385
			Me.spreadsheetCommandBarButtonGalleryDropDownItem3.Name = "spreadsheetCommandBarButtonGalleryDropDownItem3"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' commandBarGalleryDropDown4
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown4.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup4.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup"
			spreadsheetCommandGalleryItem36.CommandName = "ConditionalFormattingIconSetArrows3Colored"
			spreadsheetCommandGalleryItem37.CommandName = "ConditionalFormattingIconSetArrows3Grayed"
			spreadsheetCommandGalleryItem38.CommandName = "ConditionalFormattingIconSetArrows4Colored"
			spreadsheetCommandGalleryItem39.CommandName = "ConditionalFormattingIconSetArrows4Grayed"
			spreadsheetCommandGalleryItem40.CommandName = "ConditionalFormattingIconSetArrows5Colored"
			spreadsheetCommandGalleryItem41.CommandName = "ConditionalFormattingIconSetArrows5Grayed"
			spreadsheetCommandGalleryItem42.CommandName = "ConditionalFormattingIconSetTriangles3"
			spreadsheetCommandGalleryItemGroup4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem36, spreadsheetCommandGalleryItem37, spreadsheetCommandGalleryItem38, spreadsheetCommandGalleryItem39, spreadsheetCommandGalleryItem40, spreadsheetCommandGalleryItem41, spreadsheetCommandGalleryItem42})
			spreadsheetCommandGalleryItemGroup5.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup"
			spreadsheetCommandGalleryItem43.CommandName = "ConditionalFormattingIconSetTrafficLights3"
			spreadsheetCommandGalleryItem44.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed"
			spreadsheetCommandGalleryItem45.CommandName = "ConditionalFormattingIconSetTrafficLights4"
			spreadsheetCommandGalleryItem46.CommandName = "ConditionalFormattingIconSetSigns3"
			spreadsheetCommandGalleryItem47.CommandName = "ConditionalFormattingIconSetRedToBlack"
			spreadsheetCommandGalleryItemGroup5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem43, spreadsheetCommandGalleryItem44, spreadsheetCommandGalleryItem45, spreadsheetCommandGalleryItem46, spreadsheetCommandGalleryItem47})
			spreadsheetCommandGalleryItemGroup6.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup"
			spreadsheetCommandGalleryItem48.CommandName = "ConditionalFormattingIconSetSymbols3Circled"
			spreadsheetCommandGalleryItem49.CommandName = "ConditionalFormattingIconSetSymbols3"
			spreadsheetCommandGalleryItem50.CommandName = "ConditionalFormattingIconSetFlags3"
			spreadsheetCommandGalleryItemGroup6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem48, spreadsheetCommandGalleryItem49, spreadsheetCommandGalleryItem50})
			spreadsheetCommandGalleryItemGroup7.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup"
			spreadsheetCommandGalleryItem51.CommandName = "ConditionalFormattingIconSetStars3"
			spreadsheetCommandGalleryItem52.CommandName = "ConditionalFormattingIconSetRatings4"
			spreadsheetCommandGalleryItem53.CommandName = "ConditionalFormattingIconSetRatings5"
			spreadsheetCommandGalleryItem54.CommandName = "ConditionalFormattingIconSetQuarters5"
			spreadsheetCommandGalleryItem55.CommandName = "ConditionalFormattingIconSetBoxes5"
			spreadsheetCommandGalleryItemGroup7.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem51, spreadsheetCommandGalleryItem52, spreadsheetCommandGalleryItem53, spreadsheetCommandGalleryItem54, spreadsheetCommandGalleryItem55})
			Me.commandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup4, spreadsheetCommandGalleryItemGroup5, spreadsheetCommandGalleryItemGroup6, spreadsheetCommandGalleryItemGroup7})
			Me.commandBarGalleryDropDown4.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4"
			Me.commandBarGalleryDropDown4.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonItem56
			' 
			Me.spreadsheetCommandBarButtonItem56.CommandName = "ConditionalFormattingRemoveFromSheet"
			Me.spreadsheetCommandBarButtonItem56.Id = 386
			Me.spreadsheetCommandBarButtonItem56.Name = "spreadsheetCommandBarButtonItem56"
			' 
			' spreadsheetCommandBarButtonItem57
			' 
			Me.spreadsheetCommandBarButtonItem57.CommandName = "ConditionalFormattingRemove"
			Me.spreadsheetCommandBarButtonItem57.Id = 387
			Me.spreadsheetCommandBarButtonItem57.Name = "spreadsheetCommandBarButtonItem57"
			' 
			' spreadsheetCommandBarSubItem7
			' 
			Me.spreadsheetCommandBarSubItem7.CommandName = "ConditionalFormattingRemoveCommandGroup"
			Me.spreadsheetCommandBarSubItem7.Id = 388
			Me.spreadsheetCommandBarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem56), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem57)})
			Me.spreadsheetCommandBarSubItem7.Name = "spreadsheetCommandBarSubItem7"
			' 
			' galleryFormatAsTableItem1
			' 
			Me.galleryFormatAsTableItem1.DropDownControl = Me.commandBarGalleryDropDown5
			Me.galleryFormatAsTableItem1.Id = 389
			Me.galleryFormatAsTableItem1.Name = "galleryFormatAsTableItem1"
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
			Me.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5"
			Me.commandBarGalleryDropDown5.Ribbon = Me.ribbonControl1
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
			Me.galleryChangeStyleItem1.Id = 390
			Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
			' 
			' spreadsheetCommandBarSubItem8
			' 
			Me.spreadsheetCommandBarSubItem8.CommandName = "InsertCellsCommandGroup"
			Me.spreadsheetCommandBarSubItem8.Id = 391
			Me.spreadsheetCommandBarSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem58), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem59), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem60)})
			Me.spreadsheetCommandBarSubItem8.Name = "spreadsheetCommandBarSubItem8"
			' 
			' spreadsheetCommandBarButtonItem58
			' 
			Me.spreadsheetCommandBarButtonItem58.CommandName = "InsertSheetRows"
			Me.spreadsheetCommandBarButtonItem58.Id = 392
			Me.spreadsheetCommandBarButtonItem58.Name = "spreadsheetCommandBarButtonItem58"
			' 
			' spreadsheetCommandBarButtonItem59
			' 
			Me.spreadsheetCommandBarButtonItem59.CommandName = "InsertSheetColumns"
			Me.spreadsheetCommandBarButtonItem59.Id = 393
			Me.spreadsheetCommandBarButtonItem59.Name = "spreadsheetCommandBarButtonItem59"
			' 
			' spreadsheetCommandBarButtonItem60
			' 
			Me.spreadsheetCommandBarButtonItem60.CommandName = "InsertSheet"
			Me.spreadsheetCommandBarButtonItem60.Id = 394
			Me.spreadsheetCommandBarButtonItem60.Name = "spreadsheetCommandBarButtonItem60"
			' 
			' spreadsheetCommandBarSubItem9
			' 
			Me.spreadsheetCommandBarSubItem9.CommandName = "RemoveCellsCommandGroup"
			Me.spreadsheetCommandBarSubItem9.Id = 395
			Me.spreadsheetCommandBarSubItem9.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem61), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem62), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem63)})
			Me.spreadsheetCommandBarSubItem9.Name = "spreadsheetCommandBarSubItem9"
			' 
			' spreadsheetCommandBarButtonItem61
			' 
			Me.spreadsheetCommandBarButtonItem61.CommandName = "RemoveSheetRows"
			Me.spreadsheetCommandBarButtonItem61.Id = 396
			Me.spreadsheetCommandBarButtonItem61.Name = "spreadsheetCommandBarButtonItem61"
			' 
			' spreadsheetCommandBarButtonItem62
			' 
			Me.spreadsheetCommandBarButtonItem62.CommandName = "RemoveSheetColumns"
			Me.spreadsheetCommandBarButtonItem62.Id = 397
			Me.spreadsheetCommandBarButtonItem62.Name = "spreadsheetCommandBarButtonItem62"
			' 
			' spreadsheetCommandBarButtonItem63
			' 
			Me.spreadsheetCommandBarButtonItem63.CommandName = "RemoveSheet"
			Me.spreadsheetCommandBarButtonItem63.Id = 398
			Me.spreadsheetCommandBarButtonItem63.Name = "spreadsheetCommandBarButtonItem63"
			' 
			' spreadsheetCommandBarSubItem10
			' 
			Me.spreadsheetCommandBarSubItem10.CommandName = "FormatCommandGroup"
			Me.spreadsheetCommandBarSubItem10.Id = 399
			Me.spreadsheetCommandBarSubItem10.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem64), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem65), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem66), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem67), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem68), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem75), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSheetTabColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem76), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem77)})
			Me.spreadsheetCommandBarSubItem10.Name = "spreadsheetCommandBarSubItem10"
			' 
			' spreadsheetCommandBarButtonItem64
			' 
			Me.spreadsheetCommandBarButtonItem64.CommandName = "FormatRowHeight"
			Me.spreadsheetCommandBarButtonItem64.Id = 400
			Me.spreadsheetCommandBarButtonItem64.Name = "spreadsheetCommandBarButtonItem64"
			' 
			' spreadsheetCommandBarButtonItem65
			' 
			Me.spreadsheetCommandBarButtonItem65.CommandName = "FormatAutoFitRowHeight"
			Me.spreadsheetCommandBarButtonItem65.Id = 401
			Me.spreadsheetCommandBarButtonItem65.Name = "spreadsheetCommandBarButtonItem65"
			' 
			' spreadsheetCommandBarButtonItem66
			' 
			Me.spreadsheetCommandBarButtonItem66.CommandName = "FormatColumnWidth"
			Me.spreadsheetCommandBarButtonItem66.Id = 402
			Me.spreadsheetCommandBarButtonItem66.Name = "spreadsheetCommandBarButtonItem66"
			' 
			' spreadsheetCommandBarButtonItem67
			' 
			Me.spreadsheetCommandBarButtonItem67.CommandName = "FormatAutoFitColumnWidth"
			Me.spreadsheetCommandBarButtonItem67.Id = 403
			Me.spreadsheetCommandBarButtonItem67.Name = "spreadsheetCommandBarButtonItem67"
			' 
			' spreadsheetCommandBarButtonItem68
			' 
			Me.spreadsheetCommandBarButtonItem68.CommandName = "FormatDefaultColumnWidth"
			Me.spreadsheetCommandBarButtonItem68.Id = 404
			Me.spreadsheetCommandBarButtonItem68.Name = "spreadsheetCommandBarButtonItem68"
			' 
			' spreadsheetCommandBarSubItem11
			' 
			Me.spreadsheetCommandBarSubItem11.CommandName = "HideAndUnhideCommandGroup"
			Me.spreadsheetCommandBarSubItem11.Id = 411
			Me.spreadsheetCommandBarSubItem11.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem69), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem70), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem71), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem72), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem73), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem74)})
			Me.spreadsheetCommandBarSubItem11.Name = "spreadsheetCommandBarSubItem11"
			' 
			' spreadsheetCommandBarButtonItem69
			' 
			Me.spreadsheetCommandBarButtonItem69.CommandName = "HideRows"
			Me.spreadsheetCommandBarButtonItem69.Id = 405
			Me.spreadsheetCommandBarButtonItem69.Name = "spreadsheetCommandBarButtonItem69"
			' 
			' spreadsheetCommandBarButtonItem70
			' 
			Me.spreadsheetCommandBarButtonItem70.CommandName = "HideColumns"
			Me.spreadsheetCommandBarButtonItem70.Id = 406
			Me.spreadsheetCommandBarButtonItem70.Name = "spreadsheetCommandBarButtonItem70"
			' 
			' spreadsheetCommandBarButtonItem71
			' 
			Me.spreadsheetCommandBarButtonItem71.CommandName = "HideSheet"
			Me.spreadsheetCommandBarButtonItem71.Id = 407
			Me.spreadsheetCommandBarButtonItem71.Name = "spreadsheetCommandBarButtonItem71"
			' 
			' spreadsheetCommandBarButtonItem72
			' 
			Me.spreadsheetCommandBarButtonItem72.CommandName = "UnhideRows"
			Me.spreadsheetCommandBarButtonItem72.Id = 408
			Me.spreadsheetCommandBarButtonItem72.Name = "spreadsheetCommandBarButtonItem72"
			' 
			' spreadsheetCommandBarButtonItem73
			' 
			Me.spreadsheetCommandBarButtonItem73.CommandName = "UnhideColumns"
			Me.spreadsheetCommandBarButtonItem73.Id = 409
			Me.spreadsheetCommandBarButtonItem73.Name = "spreadsheetCommandBarButtonItem73"
			' 
			' spreadsheetCommandBarButtonItem74
			' 
			Me.spreadsheetCommandBarButtonItem74.CommandName = "UnhideSheet"
			Me.spreadsheetCommandBarButtonItem74.Id = 410
			Me.spreadsheetCommandBarButtonItem74.Name = "spreadsheetCommandBarButtonItem74"
			' 
			' spreadsheetCommandBarButtonItem75
			' 
			Me.spreadsheetCommandBarButtonItem75.CommandName = "RenameSheet"
			Me.spreadsheetCommandBarButtonItem75.Id = 412
			Me.spreadsheetCommandBarButtonItem75.Name = "spreadsheetCommandBarButtonItem75"
			' 
			' changeSheetTabColorItem1
			' 
			Me.changeSheetTabColorItem1.ActAsDropDown = True
			Me.changeSheetTabColorItem1.Id = 413
			Me.changeSheetTabColorItem1.Name = "changeSheetTabColorItem1"
			' 
			' spreadsheetCommandBarButtonItem76
			' 
			Me.spreadsheetCommandBarButtonItem76.CommandName = "ReviewProtectSheet"
			Me.spreadsheetCommandBarButtonItem76.Id = 414
			Me.spreadsheetCommandBarButtonItem76.Name = "spreadsheetCommandBarButtonItem76"
			' 
			' spreadsheetCommandBarCheckItem13
			' 
			Me.spreadsheetCommandBarCheckItem13.CommandName = "FormatCellLocked"
			Me.spreadsheetCommandBarCheckItem13.Id = 415
			Me.spreadsheetCommandBarCheckItem13.Name = "spreadsheetCommandBarCheckItem13"
			' 
			' spreadsheetCommandBarButtonItem77
			' 
			Me.spreadsheetCommandBarButtonItem77.CommandName = "FormatCellsContextMenuItem"
			Me.spreadsheetCommandBarButtonItem77.Id = 416
			Me.spreadsheetCommandBarButtonItem77.Name = "spreadsheetCommandBarButtonItem77"
			' 
			' spreadsheetCommandBarSubItem12
			' 
			Me.spreadsheetCommandBarSubItem12.CommandName = "EditingAutoSumCommandGroup"
			Me.spreadsheetCommandBarSubItem12.Id = 417
			Me.spreadsheetCommandBarSubItem12.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem78), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem79), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem80), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem81), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem82)})
			Me.spreadsheetCommandBarSubItem12.Name = "spreadsheetCommandBarSubItem12"
			Me.spreadsheetCommandBarSubItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem78
			' 
			Me.spreadsheetCommandBarButtonItem78.CommandName = "FunctionsInsertSum"
			Me.spreadsheetCommandBarButtonItem78.Id = 418
			Me.spreadsheetCommandBarButtonItem78.Name = "spreadsheetCommandBarButtonItem78"
			' 
			' spreadsheetCommandBarButtonItem79
			' 
			Me.spreadsheetCommandBarButtonItem79.CommandName = "FunctionsInsertAverage"
			Me.spreadsheetCommandBarButtonItem79.Id = 419
			Me.spreadsheetCommandBarButtonItem79.Name = "spreadsheetCommandBarButtonItem79"
			' 
			' spreadsheetCommandBarButtonItem80
			' 
			Me.spreadsheetCommandBarButtonItem80.CommandName = "FunctionsInsertCountNumbers"
			Me.spreadsheetCommandBarButtonItem80.Id = 420
			Me.spreadsheetCommandBarButtonItem80.Name = "spreadsheetCommandBarButtonItem80"
			' 
			' spreadsheetCommandBarButtonItem81
			' 
			Me.spreadsheetCommandBarButtonItem81.CommandName = "FunctionsInsertMax"
			Me.spreadsheetCommandBarButtonItem81.Id = 421
			Me.spreadsheetCommandBarButtonItem81.Name = "spreadsheetCommandBarButtonItem81"
			' 
			' spreadsheetCommandBarButtonItem82
			' 
			Me.spreadsheetCommandBarButtonItem82.CommandName = "FunctionsInsertMin"
			Me.spreadsheetCommandBarButtonItem82.Id = 422
			Me.spreadsheetCommandBarButtonItem82.Name = "spreadsheetCommandBarButtonItem82"
			' 
			' spreadsheetCommandBarSubItem13
			' 
			Me.spreadsheetCommandBarSubItem13.CommandName = "EditingFillCommandGroup"
			Me.spreadsheetCommandBarSubItem13.Id = 423
			Me.spreadsheetCommandBarSubItem13.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem83), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem84), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem85), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem86)})
			Me.spreadsheetCommandBarSubItem13.Name = "spreadsheetCommandBarSubItem13"
			Me.spreadsheetCommandBarSubItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem83
			' 
			Me.spreadsheetCommandBarButtonItem83.CommandName = "EditingFillDown"
			Me.spreadsheetCommandBarButtonItem83.Id = 424
			Me.spreadsheetCommandBarButtonItem83.Name = "spreadsheetCommandBarButtonItem83"
			' 
			' spreadsheetCommandBarButtonItem84
			' 
			Me.spreadsheetCommandBarButtonItem84.CommandName = "EditingFillRight"
			Me.spreadsheetCommandBarButtonItem84.Id = 425
			Me.spreadsheetCommandBarButtonItem84.Name = "spreadsheetCommandBarButtonItem84"
			' 
			' spreadsheetCommandBarButtonItem85
			' 
			Me.spreadsheetCommandBarButtonItem85.CommandName = "EditingFillUp"
			Me.spreadsheetCommandBarButtonItem85.Id = 426
			Me.spreadsheetCommandBarButtonItem85.Name = "spreadsheetCommandBarButtonItem85"
			' 
			' spreadsheetCommandBarButtonItem86
			' 
			Me.spreadsheetCommandBarButtonItem86.CommandName = "EditingFillLeft"
			Me.spreadsheetCommandBarButtonItem86.Id = 427
			Me.spreadsheetCommandBarButtonItem86.Name = "spreadsheetCommandBarButtonItem86"
			' 
			' spreadsheetCommandBarSubItem14
			' 
			Me.spreadsheetCommandBarSubItem14.CommandName = "FormatClearCommandGroup"
			Me.spreadsheetCommandBarSubItem14.Id = 428
			Me.spreadsheetCommandBarSubItem14.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem87), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem88), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem89), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem90), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem91), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem92)})
			Me.spreadsheetCommandBarSubItem14.Name = "spreadsheetCommandBarSubItem14"
			Me.spreadsheetCommandBarSubItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem87
			' 
			Me.spreadsheetCommandBarButtonItem87.CommandName = "FormatClearAll"
			Me.spreadsheetCommandBarButtonItem87.Id = 429
			Me.spreadsheetCommandBarButtonItem87.Name = "spreadsheetCommandBarButtonItem87"
			' 
			' spreadsheetCommandBarButtonItem88
			' 
			Me.spreadsheetCommandBarButtonItem88.CommandName = "FormatClearFormats"
			Me.spreadsheetCommandBarButtonItem88.Id = 430
			Me.spreadsheetCommandBarButtonItem88.Name = "spreadsheetCommandBarButtonItem88"
			' 
			' spreadsheetCommandBarButtonItem89
			' 
			Me.spreadsheetCommandBarButtonItem89.CommandName = "FormatClearContents"
			Me.spreadsheetCommandBarButtonItem89.Id = 431
			Me.spreadsheetCommandBarButtonItem89.Name = "spreadsheetCommandBarButtonItem89"
			' 
			' spreadsheetCommandBarButtonItem90
			' 
			Me.spreadsheetCommandBarButtonItem90.CommandName = "FormatClearComments"
			Me.spreadsheetCommandBarButtonItem90.Id = 432
			Me.spreadsheetCommandBarButtonItem90.Name = "spreadsheetCommandBarButtonItem90"
			' 
			' spreadsheetCommandBarButtonItem91
			' 
			Me.spreadsheetCommandBarButtonItem91.CommandName = "FormatClearHyperlinks"
			Me.spreadsheetCommandBarButtonItem91.Id = 433
			Me.spreadsheetCommandBarButtonItem91.Name = "spreadsheetCommandBarButtonItem91"
			' 
			' spreadsheetCommandBarButtonItem92
			' 
			Me.spreadsheetCommandBarButtonItem92.CommandName = "FormatRemoveHyperlinks"
			Me.spreadsheetCommandBarButtonItem92.Id = 434
			Me.spreadsheetCommandBarButtonItem92.Name = "spreadsheetCommandBarButtonItem92"
			' 
			' spreadsheetCommandBarSubItem15
			' 
			Me.spreadsheetCommandBarSubItem15.CommandName = "EditingSortAndFilterCommandGroup"
			Me.spreadsheetCommandBarSubItem15.Id = 435
			Me.spreadsheetCommandBarSubItem15.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem93), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem94)})
			Me.spreadsheetCommandBarSubItem15.Name = "spreadsheetCommandBarSubItem15"
			' 
			' spreadsheetCommandBarButtonItem93
			' 
			Me.spreadsheetCommandBarButtonItem93.CommandName = "DataSortAscending"
			Me.spreadsheetCommandBarButtonItem93.Id = 436
			Me.spreadsheetCommandBarButtonItem93.Name = "spreadsheetCommandBarButtonItem93"
			' 
			' spreadsheetCommandBarButtonItem94
			' 
			Me.spreadsheetCommandBarButtonItem94.CommandName = "DataSortDescending"
			Me.spreadsheetCommandBarButtonItem94.Id = 437
			Me.spreadsheetCommandBarButtonItem94.Name = "spreadsheetCommandBarButtonItem94"
			' 
			' spreadsheetCommandBarSubItem16
			' 
			Me.spreadsheetCommandBarSubItem16.CommandName = "EditingFindAndSelectCommandGroup"
			Me.spreadsheetCommandBarSubItem16.Id = 438
			Me.spreadsheetCommandBarSubItem16.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem95), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem96)})
			Me.spreadsheetCommandBarSubItem16.Name = "spreadsheetCommandBarSubItem16"
			' 
			' spreadsheetCommandBarButtonItem95
			' 
			Me.spreadsheetCommandBarButtonItem95.CommandName = "EditingFind"
			Me.spreadsheetCommandBarButtonItem95.Id = 439
			Me.spreadsheetCommandBarButtonItem95.Name = "spreadsheetCommandBarButtonItem95"
			' 
			' spreadsheetCommandBarButtonItem96
			' 
			Me.spreadsheetCommandBarButtonItem96.CommandName = "EditingReplace"
			Me.spreadsheetCommandBarButtonItem96.Id = 440
			Me.spreadsheetCommandBarButtonItem96.Name = "spreadsheetCommandBarButtonItem96"
			' 
			' spreadsheetCommandBarButtonItem97
			' 
			Me.spreadsheetCommandBarButtonItem97.CommandName = "InsertTable"
			Me.spreadsheetCommandBarButtonItem97.Id = 441
			Me.spreadsheetCommandBarButtonItem97.Name = "spreadsheetCommandBarButtonItem97"
			' 
			' spreadsheetCommandBarButtonItem98
			' 
			Me.spreadsheetCommandBarButtonItem98.CommandName = "InsertPicture"
			Me.spreadsheetCommandBarButtonItem98.Id = 442
			Me.spreadsheetCommandBarButtonItem98.Name = "spreadsheetCommandBarButtonItem98"
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem4
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem4.CommandName = "InsertChartColumnCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem4.DropDownControl = Me.commandBarGalleryDropDown6
			Me.spreadsheetCommandBarButtonGalleryDropDownItem4.Id = 443
			Me.spreadsheetCommandBarButtonGalleryDropDownItem4.Name = "spreadsheetCommandBarButtonGalleryDropDownItem4"
			' 
			' commandBarGalleryDropDown6
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown6.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup8.CommandName = "InsertChartColumn2DCommandGroup"
			spreadsheetCommandGalleryItem56.CommandName = "InsertChartColumnClustered2D"
			spreadsheetCommandGalleryItem57.CommandName = "InsertChartColumnStacked2D"
			spreadsheetCommandGalleryItem58.CommandName = "InsertChartColumnPercentStacked2D"
			spreadsheetCommandGalleryItemGroup8.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem56, spreadsheetCommandGalleryItem57, spreadsheetCommandGalleryItem58})
			spreadsheetCommandGalleryItemGroup9.CommandName = "InsertChartColumn3DCommandGroup"
			spreadsheetCommandGalleryItem59.CommandName = "InsertChartColumnClustered3D"
			spreadsheetCommandGalleryItem60.CommandName = "InsertChartColumnStacked3D"
			spreadsheetCommandGalleryItem61.CommandName = "InsertChartColumnPercentStacked3D"
			spreadsheetCommandGalleryItem62.CommandName = "InsertChartColumn3D"
			spreadsheetCommandGalleryItemGroup9.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem59, spreadsheetCommandGalleryItem60, spreadsheetCommandGalleryItem61, spreadsheetCommandGalleryItem62})
			spreadsheetCommandGalleryItemGroup10.CommandName = "InsertChartCylinderCommandGroup"
			spreadsheetCommandGalleryItem63.CommandName = "InsertChartCylinderClustered"
			spreadsheetCommandGalleryItem64.CommandName = "InsertChartCylinderStacked"
			spreadsheetCommandGalleryItem65.CommandName = "InsertChartCylinderPercentStacked"
			spreadsheetCommandGalleryItem66.CommandName = "InsertChartCylinder"
			spreadsheetCommandGalleryItemGroup10.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem63, spreadsheetCommandGalleryItem64, spreadsheetCommandGalleryItem65, spreadsheetCommandGalleryItem66})
			spreadsheetCommandGalleryItemGroup11.CommandName = "InsertChartConeCommandGroup"
			spreadsheetCommandGalleryItem67.CommandName = "InsertChartConeClustered"
			spreadsheetCommandGalleryItem68.CommandName = "InsertChartConeStacked"
			spreadsheetCommandGalleryItem69.CommandName = "InsertChartConePercentStacked"
			spreadsheetCommandGalleryItem70.CommandName = "InsertChartCone"
			spreadsheetCommandGalleryItemGroup11.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem67, spreadsheetCommandGalleryItem68, spreadsheetCommandGalleryItem69, spreadsheetCommandGalleryItem70})
			spreadsheetCommandGalleryItemGroup12.CommandName = "InsertChartPyramidCommandGroup"
			spreadsheetCommandGalleryItem71.CommandName = "InsertChartPyramidClustered"
			spreadsheetCommandGalleryItem72.CommandName = "InsertChartPyramidStacked"
			spreadsheetCommandGalleryItem73.CommandName = "InsertChartPyramidPercentStacked"
			spreadsheetCommandGalleryItem74.CommandName = "InsertChartPyramid"
			spreadsheetCommandGalleryItemGroup12.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem71, spreadsheetCommandGalleryItem72, spreadsheetCommandGalleryItem73, spreadsheetCommandGalleryItem74})
			Me.commandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup8, spreadsheetCommandGalleryItemGroup9, spreadsheetCommandGalleryItemGroup10, spreadsheetCommandGalleryItemGroup11, spreadsheetCommandGalleryItemGroup12})
			Me.commandBarGalleryDropDown6.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6"
			Me.commandBarGalleryDropDown6.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem5
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem5.CommandName = "InsertChartLineCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem5.DropDownControl = Me.commandBarGalleryDropDown7
			Me.spreadsheetCommandBarButtonGalleryDropDownItem5.Id = 444
			Me.spreadsheetCommandBarButtonGalleryDropDownItem5.Name = "spreadsheetCommandBarButtonGalleryDropDownItem5"
			' 
			' commandBarGalleryDropDown7
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown7.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup13.CommandName = "InsertChartLine2DCommandGroup"
			spreadsheetCommandGalleryItem75.CommandName = "InsertChartLine"
			spreadsheetCommandGalleryItem76.CommandName = "InsertChartStackedLine"
			spreadsheetCommandGalleryItem77.CommandName = "InsertChartPercentStackedLine"
			spreadsheetCommandGalleryItem78.CommandName = "InsertChartLineWithMarkers"
			spreadsheetCommandGalleryItem79.CommandName = "InsertChartStackedLineWithMarkers"
			spreadsheetCommandGalleryItem80.CommandName = "InsertChartPercentStackedLineWithMarkers"
			spreadsheetCommandGalleryItemGroup13.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem75, spreadsheetCommandGalleryItem76, spreadsheetCommandGalleryItem77, spreadsheetCommandGalleryItem78, spreadsheetCommandGalleryItem79, spreadsheetCommandGalleryItem80})
			spreadsheetCommandGalleryItemGroup14.CommandName = "InsertChartLine3DCommandGroup"
			spreadsheetCommandGalleryItem81.CommandName = "InsertChartLine3D"
			spreadsheetCommandGalleryItemGroup14.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem81})
			Me.commandBarGalleryDropDown7.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup13, spreadsheetCommandGalleryItemGroup14})
			Me.commandBarGalleryDropDown7.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7"
			Me.commandBarGalleryDropDown7.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem6
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem6.CommandName = "InsertChartPieCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem6.DropDownControl = Me.commandBarGalleryDropDown8
			Me.spreadsheetCommandBarButtonGalleryDropDownItem6.Id = 445
			Me.spreadsheetCommandBarButtonGalleryDropDownItem6.Name = "spreadsheetCommandBarButtonGalleryDropDownItem6"
			' 
			' commandBarGalleryDropDown8
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown8.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup15.CommandName = "InsertChartPie2DCommandGroup"
			spreadsheetCommandGalleryItem82.CommandName = "InsertChartPie2D"
			spreadsheetCommandGalleryItem83.CommandName = "InsertChartPieExploded2D"
			spreadsheetCommandGalleryItemGroup15.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem82, spreadsheetCommandGalleryItem83})
			spreadsheetCommandGalleryItemGroup16.CommandName = "InsertChartPie3DCommandGroup"
			spreadsheetCommandGalleryItem84.CommandName = "InsertChartPie3D"
			spreadsheetCommandGalleryItem85.CommandName = "InsertChartPieExploded3D"
			spreadsheetCommandGalleryItemGroup16.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem84, spreadsheetCommandGalleryItem85})
			spreadsheetCommandGalleryItemGroup17.CommandName = "InsertChartDoughnut2DCommandGroup"
			spreadsheetCommandGalleryItem86.CommandName = "InsertChartDoughnut2D"
			spreadsheetCommandGalleryItem87.CommandName = "InsertChartDoughnutExploded2D"
			spreadsheetCommandGalleryItemGroup17.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem86, spreadsheetCommandGalleryItem87})
			Me.commandBarGalleryDropDown8.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup15, spreadsheetCommandGalleryItemGroup16, spreadsheetCommandGalleryItemGroup17})
			Me.commandBarGalleryDropDown8.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8"
			Me.commandBarGalleryDropDown8.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem7
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem7.CommandName = "InsertChartBarCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem7.DropDownControl = Me.commandBarGalleryDropDown9
			Me.spreadsheetCommandBarButtonGalleryDropDownItem7.Id = 446
			Me.spreadsheetCommandBarButtonGalleryDropDownItem7.Name = "spreadsheetCommandBarButtonGalleryDropDownItem7"
			' 
			' commandBarGalleryDropDown9
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown9.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup18.CommandName = "InsertChartBar2DCommandGroup"
			spreadsheetCommandGalleryItem88.CommandName = "InsertChartBarClustered2D"
			spreadsheetCommandGalleryItem89.CommandName = "InsertChartBarStacked2D"
			spreadsheetCommandGalleryItem90.CommandName = "InsertChartBarPercentStacked2D"
			spreadsheetCommandGalleryItemGroup18.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem88, spreadsheetCommandGalleryItem89, spreadsheetCommandGalleryItem90})
			spreadsheetCommandGalleryItemGroup19.CommandName = "InsertChartBar3DCommandGroup"
			spreadsheetCommandGalleryItem91.CommandName = "InsertChartBarClustered3D"
			spreadsheetCommandGalleryItem92.CommandName = "InsertChartBarStacked3D"
			spreadsheetCommandGalleryItem93.CommandName = "InsertChartBarPercentStacked3D"
			spreadsheetCommandGalleryItemGroup19.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem91, spreadsheetCommandGalleryItem92, spreadsheetCommandGalleryItem93})
			spreadsheetCommandGalleryItemGroup20.CommandName = "InsertChartHorizontalCylinderCommandGroup"
			spreadsheetCommandGalleryItem94.CommandName = "InsertChartHorizontalCylinderClustered"
			spreadsheetCommandGalleryItem95.CommandName = "InsertChartHorizontalCylinderStacked"
			spreadsheetCommandGalleryItem96.CommandName = "InsertChartHorizontalCylinderPercentStacked"
			spreadsheetCommandGalleryItemGroup20.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem94, spreadsheetCommandGalleryItem95, spreadsheetCommandGalleryItem96})
			spreadsheetCommandGalleryItemGroup21.CommandName = "InsertChartHorizontalConeCommandGroup"
			spreadsheetCommandGalleryItem97.CommandName = "InsertChartHorizontalConeClustered"
			spreadsheetCommandGalleryItem98.CommandName = "InsertChartHorizontalConeStacked"
			spreadsheetCommandGalleryItem99.CommandName = "InsertChartHorizontalConePercentStacked"
			spreadsheetCommandGalleryItemGroup21.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem97, spreadsheetCommandGalleryItem98, spreadsheetCommandGalleryItem99})
			spreadsheetCommandGalleryItemGroup22.CommandName = "InsertChartHorizontalPyramidCommandGroup"
			spreadsheetCommandGalleryItem100.CommandName = "InsertChartHorizontalPyramidClustered"
			spreadsheetCommandGalleryItem101.CommandName = "InsertChartHorizontalPyramidStacked"
			spreadsheetCommandGalleryItem102.CommandName = "InsertChartHorizontalPyramidPercentStacked"
			spreadsheetCommandGalleryItemGroup22.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem100, spreadsheetCommandGalleryItem101, spreadsheetCommandGalleryItem102})
			Me.commandBarGalleryDropDown9.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup18, spreadsheetCommandGalleryItemGroup19, spreadsheetCommandGalleryItemGroup20, spreadsheetCommandGalleryItemGroup21, spreadsheetCommandGalleryItemGroup22})
			Me.commandBarGalleryDropDown9.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown9.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown9.Name = "commandBarGalleryDropDown9"
			Me.commandBarGalleryDropDown9.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem8
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem8.CommandName = "InsertChartAreaCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem8.DropDownControl = Me.commandBarGalleryDropDown10
			Me.spreadsheetCommandBarButtonGalleryDropDownItem8.Id = 447
			Me.spreadsheetCommandBarButtonGalleryDropDownItem8.Name = "spreadsheetCommandBarButtonGalleryDropDownItem8"
			' 
			' commandBarGalleryDropDown10
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown10.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup23.CommandName = "InsertChartArea2DCommandGroup"
			spreadsheetCommandGalleryItem103.CommandName = "InsertChartArea"
			spreadsheetCommandGalleryItem104.CommandName = "InsertChartStackedArea"
			spreadsheetCommandGalleryItem105.CommandName = "InsertChartPercentStackedArea"
			spreadsheetCommandGalleryItemGroup23.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem103, spreadsheetCommandGalleryItem104, spreadsheetCommandGalleryItem105})
			spreadsheetCommandGalleryItemGroup24.CommandName = "InsertChartArea3DCommandGroup"
			spreadsheetCommandGalleryItem106.CommandName = "InsertChartArea3D"
			spreadsheetCommandGalleryItem107.CommandName = "InsertChartStackedArea3D"
			spreadsheetCommandGalleryItem108.CommandName = "InsertChartPercentStackedArea3D"
			spreadsheetCommandGalleryItemGroup24.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem106, spreadsheetCommandGalleryItem107, spreadsheetCommandGalleryItem108})
			Me.commandBarGalleryDropDown10.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup23, spreadsheetCommandGalleryItemGroup24})
			Me.commandBarGalleryDropDown10.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown10.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown10.Name = "commandBarGalleryDropDown10"
			Me.commandBarGalleryDropDown10.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem9
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem9.CommandName = "InsertChartScatterCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem9.DropDownControl = Me.commandBarGalleryDropDown11
			Me.spreadsheetCommandBarButtonGalleryDropDownItem9.Id = 448
			Me.spreadsheetCommandBarButtonGalleryDropDownItem9.Name = "spreadsheetCommandBarButtonGalleryDropDownItem9"
			' 
			' commandBarGalleryDropDown11
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown11.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup25.CommandName = "InsertChartScatterCommandGroup"
			spreadsheetCommandGalleryItem109.CommandName = "InsertChartScatterMarkers"
			spreadsheetCommandGalleryItem110.CommandName = "InsertChartScatterSmoothLinesAndMarkers"
			spreadsheetCommandGalleryItem111.CommandName = "InsertChartScatterSmoothLines"
			spreadsheetCommandGalleryItem112.CommandName = "InsertChartScatterLinesAndMarkers"
			spreadsheetCommandGalleryItem113.CommandName = "InsertChartScatterLines"
			spreadsheetCommandGalleryItemGroup25.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem109, spreadsheetCommandGalleryItem110, spreadsheetCommandGalleryItem111, spreadsheetCommandGalleryItem112, spreadsheetCommandGalleryItem113})
			spreadsheetCommandGalleryItemGroup26.CommandName = "InsertChartBubbleCommandGroup"
			spreadsheetCommandGalleryItem114.CommandName = "InsertChartBubble"
			spreadsheetCommandGalleryItem115.CommandName = "InsertChartBubble3D"
			spreadsheetCommandGalleryItemGroup26.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem114, spreadsheetCommandGalleryItem115})
			Me.commandBarGalleryDropDown11.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup25, spreadsheetCommandGalleryItemGroup26})
			Me.commandBarGalleryDropDown11.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown11.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown11.Name = "commandBarGalleryDropDown11"
			Me.commandBarGalleryDropDown11.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem10
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem10.CommandName = "InsertChartOtherCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem10.DropDownControl = Me.commandBarGalleryDropDown12
			Me.spreadsheetCommandBarButtonGalleryDropDownItem10.Id = 449
			Me.spreadsheetCommandBarButtonGalleryDropDownItem10.Name = "spreadsheetCommandBarButtonGalleryDropDownItem10"
			' 
			' commandBarGalleryDropDown12
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown12.Gallery.AllowFilter = False
			spreadsheetCommandGalleryItemGroup27.CommandName = "InsertChartStockCommandGroup"
			spreadsheetCommandGalleryItem116.CommandName = "InsertChartStockHighLowClose"
			spreadsheetCommandGalleryItem117.CommandName = "InsertChartStockOpenHighLowClose"
			spreadsheetCommandGalleryItemGroup27.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem116, spreadsheetCommandGalleryItem117})
			spreadsheetCommandGalleryItemGroup28.CommandName = "InsertChartRadarCommandGroup"
			spreadsheetCommandGalleryItem118.CommandName = "InsertChartRadar"
			spreadsheetCommandGalleryItem119.CommandName = "InsertChartRadarWithMarkers"
			spreadsheetCommandGalleryItem120.CommandName = "InsertChartRadarFilled"
			spreadsheetCommandGalleryItemGroup28.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem118, spreadsheetCommandGalleryItem119, spreadsheetCommandGalleryItem120})
			Me.commandBarGalleryDropDown12.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup27, spreadsheetCommandGalleryItemGroup28})
			Me.commandBarGalleryDropDown12.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown12.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown12.Name = "commandBarGalleryDropDown12"
			Me.commandBarGalleryDropDown12.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonItem99
			' 
			Me.spreadsheetCommandBarButtonItem99.CommandName = "InsertHyperlink"
			Me.spreadsheetCommandBarButtonItem99.Id = 450
			Me.spreadsheetCommandBarButtonItem99.Name = "spreadsheetCommandBarButtonItem99"
			' 
			' spreadsheetCommandBarButtonItem100
			' 
			Me.spreadsheetCommandBarButtonItem100.CommandName = "InsertSymbol"
			Me.spreadsheetCommandBarButtonItem100.Id = 451
			Me.spreadsheetCommandBarButtonItem100.Name = "spreadsheetCommandBarButtonItem100"
			' 
			' spreadsheetCommandBarSubItem17
			' 
			Me.spreadsheetCommandBarSubItem17.CommandName = "PageSetupMarginsCommandGroup"
			Me.spreadsheetCommandBarSubItem17.Id = 452
			Me.spreadsheetCommandBarSubItem17.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem16)})
			Me.spreadsheetCommandBarSubItem17.Name = "spreadsheetCommandBarSubItem17"
			' 
			' spreadsheetCommandBarCheckItem14
			' 
			Me.spreadsheetCommandBarCheckItem14.CaptionDependOnUnits = True
			Me.spreadsheetCommandBarCheckItem14.CommandName = "PageSetupMarginsNormal"
			Me.spreadsheetCommandBarCheckItem14.Id = 453
			Me.spreadsheetCommandBarCheckItem14.Name = "spreadsheetCommandBarCheckItem14"
			' 
			' spreadsheetCommandBarCheckItem15
			' 
			Me.spreadsheetCommandBarCheckItem15.CaptionDependOnUnits = True
			Me.spreadsheetCommandBarCheckItem15.CommandName = "PageSetupMarginsWide"
			Me.spreadsheetCommandBarCheckItem15.Id = 454
			Me.spreadsheetCommandBarCheckItem15.Name = "spreadsheetCommandBarCheckItem15"
			' 
			' spreadsheetCommandBarCheckItem16
			' 
			Me.spreadsheetCommandBarCheckItem16.CaptionDependOnUnits = True
			Me.spreadsheetCommandBarCheckItem16.CommandName = "PageSetupMarginsNarrow"
			Me.spreadsheetCommandBarCheckItem16.Id = 455
			Me.spreadsheetCommandBarCheckItem16.Name = "spreadsheetCommandBarCheckItem16"
			' 
			' spreadsheetCommandBarSubItem18
			' 
			Me.spreadsheetCommandBarSubItem18.CommandName = "PageSetupOrientationCommandGroup"
			Me.spreadsheetCommandBarSubItem18.Id = 456
			Me.spreadsheetCommandBarSubItem18.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem18)})
			Me.spreadsheetCommandBarSubItem18.Name = "spreadsheetCommandBarSubItem18"
			' 
			' spreadsheetCommandBarCheckItem17
			' 
			Me.spreadsheetCommandBarCheckItem17.CommandName = "PageSetupOrientationPortrait"
			Me.spreadsheetCommandBarCheckItem17.Id = 457
			Me.spreadsheetCommandBarCheckItem17.Name = "spreadsheetCommandBarCheckItem17"
			' 
			' spreadsheetCommandBarCheckItem18
			' 
			Me.spreadsheetCommandBarCheckItem18.CommandName = "PageSetupOrientationLandscape"
			Me.spreadsheetCommandBarCheckItem18.Id = 458
			Me.spreadsheetCommandBarCheckItem18.Name = "spreadsheetCommandBarCheckItem18"
			' 
			' pageSetupPaperKindItem1
			' 
			Me.pageSetupPaperKindItem1.Id = 459
			Me.pageSetupPaperKindItem1.Name = "pageSetupPaperKindItem1"
			' 
			' spreadsheetCommandBarSubItem19
			' 
			Me.spreadsheetCommandBarSubItem19.CommandName = "PageSetupPrintAreaCommandGroup"
			Me.spreadsheetCommandBarSubItem19.Id = 460
			Me.spreadsheetCommandBarSubItem19.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem101), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem102)})
			Me.spreadsheetCommandBarSubItem19.Name = "spreadsheetCommandBarSubItem19"
			' 
			' spreadsheetCommandBarButtonItem101
			' 
			Me.spreadsheetCommandBarButtonItem101.CommandName = "PageSetupSetPrintArea"
			Me.spreadsheetCommandBarButtonItem101.Id = 461
			Me.spreadsheetCommandBarButtonItem101.Name = "spreadsheetCommandBarButtonItem101"
			' 
			' spreadsheetCommandBarButtonItem102
			' 
			Me.spreadsheetCommandBarButtonItem102.CommandName = "PageSetupClearPrintArea"
			Me.spreadsheetCommandBarButtonItem102.Id = 462
			Me.spreadsheetCommandBarButtonItem102.Name = "spreadsheetCommandBarButtonItem102"
			' 
			' spreadsheetCommandBarCheckItem19
			' 
			Me.spreadsheetCommandBarCheckItem19.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem19.CommandName = "ViewShowGridlines"
			Me.spreadsheetCommandBarCheckItem19.Id = 463
			Me.spreadsheetCommandBarCheckItem19.Name = "spreadsheetCommandBarCheckItem19"
			' 
			' spreadsheetCommandBarCheckItem20
			' 
			Me.spreadsheetCommandBarCheckItem20.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem20.CommandName = "ViewShowHeadings"
			Me.spreadsheetCommandBarCheckItem20.Id = 464
			Me.spreadsheetCommandBarCheckItem20.Name = "spreadsheetCommandBarCheckItem20"
			' 
			' spreadsheetCommandBarCheckItem21
			' 
			Me.spreadsheetCommandBarCheckItem21.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem21.CommandName = "PageSetupPrintGridlines"
			Me.spreadsheetCommandBarCheckItem21.Id = 465
			Me.spreadsheetCommandBarCheckItem21.Name = "spreadsheetCommandBarCheckItem21"
			' 
			' spreadsheetCommandBarCheckItem22
			' 
			Me.spreadsheetCommandBarCheckItem22.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem22.CommandName = "PageSetupPrintHeadings"
			Me.spreadsheetCommandBarCheckItem22.Id = 466
			Me.spreadsheetCommandBarCheckItem22.Name = "spreadsheetCommandBarCheckItem22"
			' 
			' spreadsheetCommandBarSubItem20
			' 
			Me.spreadsheetCommandBarSubItem20.CommandName = "ArrangeBringForwardCommandGroup"
			Me.spreadsheetCommandBarSubItem20.Id = 467
			Me.spreadsheetCommandBarSubItem20.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem103), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem104)})
			Me.spreadsheetCommandBarSubItem20.Name = "spreadsheetCommandBarSubItem20"
			' 
			' spreadsheetCommandBarButtonItem103
			' 
			Me.spreadsheetCommandBarButtonItem103.CommandName = "ArrangeBringForward"
			Me.spreadsheetCommandBarButtonItem103.Id = 468
			Me.spreadsheetCommandBarButtonItem103.Name = "spreadsheetCommandBarButtonItem103"
			' 
			' spreadsheetCommandBarButtonItem104
			' 
			Me.spreadsheetCommandBarButtonItem104.CommandName = "ArrangeBringToFront"
			Me.spreadsheetCommandBarButtonItem104.Id = 469
			Me.spreadsheetCommandBarButtonItem104.Name = "spreadsheetCommandBarButtonItem104"
			' 
			' spreadsheetCommandBarSubItem21
			' 
			Me.spreadsheetCommandBarSubItem21.CommandName = "ArrangeSendBackwardCommandGroup"
			Me.spreadsheetCommandBarSubItem21.Id = 470
			Me.spreadsheetCommandBarSubItem21.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem105), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem106)})
			Me.spreadsheetCommandBarSubItem21.Name = "spreadsheetCommandBarSubItem21"
			' 
			' spreadsheetCommandBarButtonItem105
			' 
			Me.spreadsheetCommandBarButtonItem105.CommandName = "ArrangeSendBackward"
			Me.spreadsheetCommandBarButtonItem105.Id = 471
			Me.spreadsheetCommandBarButtonItem105.Name = "spreadsheetCommandBarButtonItem105"
			' 
			' spreadsheetCommandBarButtonItem106
			' 
			Me.spreadsheetCommandBarButtonItem106.CommandName = "ArrangeSendToBack"
			Me.spreadsheetCommandBarButtonItem106.Id = 472
			Me.spreadsheetCommandBarButtonItem106.Name = "spreadsheetCommandBarButtonItem106"
			' 
			' spreadsheetCommandBarSubItem22
			' 
			Me.spreadsheetCommandBarSubItem22.CommandName = "FunctionsAutoSumCommandGroup"
			Me.spreadsheetCommandBarSubItem22.Id = 473
			Me.spreadsheetCommandBarSubItem22.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem78), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem79), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem80), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem81), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem82)})
			Me.spreadsheetCommandBarSubItem22.Name = "spreadsheetCommandBarSubItem22"
			' 
			' functionsFinancialItem1
			' 
			Me.functionsFinancialItem1.Id = 474
			Me.functionsFinancialItem1.Name = "functionsFinancialItem1"
			' 
			' functionsLogicalItem1
			' 
			Me.functionsLogicalItem1.Id = 475
			Me.functionsLogicalItem1.Name = "functionsLogicalItem1"
			' 
			' functionsTextItem1
			' 
			Me.functionsTextItem1.Id = 476
			Me.functionsTextItem1.Name = "functionsTextItem1"
			' 
			' functionsDateAndTimeItem1
			' 
			Me.functionsDateAndTimeItem1.Id = 477
			Me.functionsDateAndTimeItem1.Name = "functionsDateAndTimeItem1"
			' 
			' functionsLookupAndReferenceItem1
			' 
			Me.functionsLookupAndReferenceItem1.Id = 478
			Me.functionsLookupAndReferenceItem1.Name = "functionsLookupAndReferenceItem1"
			' 
			' functionsMathAndTrigonometryItem1
			' 
			Me.functionsMathAndTrigonometryItem1.Id = 479
			Me.functionsMathAndTrigonometryItem1.Name = "functionsMathAndTrigonometryItem1"
			' 
			' spreadsheetCommandBarSubItem23
			' 
			Me.spreadsheetCommandBarSubItem23.CommandName = "FunctionsMoreCommandGroup"
			Me.spreadsheetCommandBarSubItem23.Id = 480
			Me.spreadsheetCommandBarSubItem23.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.functionsStatisticalItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.functionsEngineeringItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.functionsInformationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.functionsCompatibilityItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.functionsWebItem1)})
			Me.spreadsheetCommandBarSubItem23.Name = "spreadsheetCommandBarSubItem23"
			' 
			' functionsStatisticalItem1
			' 
			Me.functionsStatisticalItem1.Id = 481
			Me.functionsStatisticalItem1.Name = "functionsStatisticalItem1"
			' 
			' functionsEngineeringItem1
			' 
			Me.functionsEngineeringItem1.Id = 482
			Me.functionsEngineeringItem1.Name = "functionsEngineeringItem1"
			' 
			' functionsInformationItem1
			' 
			Me.functionsInformationItem1.Id = 483
			Me.functionsInformationItem1.Name = "functionsInformationItem1"
			' 
			' functionsCompatibilityItem1
			' 
			Me.functionsCompatibilityItem1.Id = 484
			Me.functionsCompatibilityItem1.Name = "functionsCompatibilityItem1"
			' 
			' functionsWebItem1
			' 
			Me.functionsWebItem1.Id = 485
			Me.functionsWebItem1.Name = "functionsWebItem1"
			' 
			' spreadsheetCommandBarButtonItem112
			' 
			Me.spreadsheetCommandBarButtonItem112.CommandName = "FormulasShowNameManager"
			Me.spreadsheetCommandBarButtonItem112.Id = 486
			Me.spreadsheetCommandBarButtonItem112.Name = "spreadsheetCommandBarButtonItem112"
			' 
			' spreadsheetCommandBarButtonItem113
			' 
			Me.spreadsheetCommandBarButtonItem113.CommandName = "FormulasDefineNameCommand"
			Me.spreadsheetCommandBarButtonItem113.Id = 487
			Me.spreadsheetCommandBarButtonItem113.Name = "spreadsheetCommandBarButtonItem113"
			Me.spreadsheetCommandBarButtonItem113.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' definedNameListItem1
			' 
			Me.definedNameListItem1.Id = 488
			Me.definedNameListItem1.Name = "definedNameListItem1"
			Me.definedNameListItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem114
			' 
			Me.spreadsheetCommandBarButtonItem114.CommandName = "FormulasCreateDefinedNamesFromSelection"
			Me.spreadsheetCommandBarButtonItem114.Id = 489
			Me.spreadsheetCommandBarButtonItem114.Name = "spreadsheetCommandBarButtonItem114"
			Me.spreadsheetCommandBarButtonItem114.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarCheckItem23
			' 
			Me.spreadsheetCommandBarCheckItem23.CommandName = "ViewShowFormulas"
			Me.spreadsheetCommandBarCheckItem23.Id = 490
			Me.spreadsheetCommandBarCheckItem23.Name = "spreadsheetCommandBarCheckItem23"
			' 
			' spreadsheetCommandBarSubItem24
			' 
			Me.spreadsheetCommandBarSubItem24.CommandName = "FormulasCalculationOptionsCommandGroup"
			Me.spreadsheetCommandBarSubItem24.Id = 491
			Me.spreadsheetCommandBarSubItem24.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem25)})
			Me.spreadsheetCommandBarSubItem24.Name = "spreadsheetCommandBarSubItem24"
			' 
			' spreadsheetCommandBarCheckItem24
			' 
			Me.spreadsheetCommandBarCheckItem24.CommandName = "FormulasCalculationModeAutomatic"
			Me.spreadsheetCommandBarCheckItem24.Id = 492
			Me.spreadsheetCommandBarCheckItem24.Name = "spreadsheetCommandBarCheckItem24"
			' 
			' spreadsheetCommandBarCheckItem25
			' 
			Me.spreadsheetCommandBarCheckItem25.CommandName = "FormulasCalculationModeManual"
			Me.spreadsheetCommandBarCheckItem25.Id = 493
			Me.spreadsheetCommandBarCheckItem25.Name = "spreadsheetCommandBarCheckItem25"
			' 
			' spreadsheetCommandBarButtonItem115
			' 
			Me.spreadsheetCommandBarButtonItem115.CommandName = "FormulasCalculateNow"
			Me.spreadsheetCommandBarButtonItem115.Id = 494
			Me.spreadsheetCommandBarButtonItem115.Name = "spreadsheetCommandBarButtonItem115"
			Me.spreadsheetCommandBarButtonItem115.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem116
			' 
			Me.spreadsheetCommandBarButtonItem116.CommandName = "FormulasCalculateSheet"
			Me.spreadsheetCommandBarButtonItem116.Id = 495
			Me.spreadsheetCommandBarButtonItem116.Name = "spreadsheetCommandBarButtonItem116"
			Me.spreadsheetCommandBarButtonItem116.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem117
			' 
			Me.spreadsheetCommandBarButtonItem117.CommandName = "ReviewUnprotectSheet"
			Me.spreadsheetCommandBarButtonItem117.Id = 496
			Me.spreadsheetCommandBarButtonItem117.Name = "spreadsheetCommandBarButtonItem117"
			' 
			' spreadsheetCommandBarButtonItem118
			' 
			Me.spreadsheetCommandBarButtonItem118.CommandName = "ReviewProtectWorkbook"
			Me.spreadsheetCommandBarButtonItem118.Id = 497
			Me.spreadsheetCommandBarButtonItem118.Name = "spreadsheetCommandBarButtonItem118"
			' 
			' spreadsheetCommandBarButtonItem119
			' 
			Me.spreadsheetCommandBarButtonItem119.CommandName = "ReviewUnprotectWorkbook"
			Me.spreadsheetCommandBarButtonItem119.Id = 498
			Me.spreadsheetCommandBarButtonItem119.Name = "spreadsheetCommandBarButtonItem119"
			' 
			' spreadsheetCommandBarButtonItem120
			' 
			Me.spreadsheetCommandBarButtonItem120.CommandName = "ReviewShowProtectedRangeManager"
			Me.spreadsheetCommandBarButtonItem120.Id = 499
			Me.spreadsheetCommandBarButtonItem120.Name = "spreadsheetCommandBarButtonItem120"
			' 
			' spreadsheetCommandBarButtonItem121
			' 
			Me.spreadsheetCommandBarButtonItem121.CommandName = "ViewZoomOut"
			Me.spreadsheetCommandBarButtonItem121.Id = 500
			Me.spreadsheetCommandBarButtonItem121.Name = "spreadsheetCommandBarButtonItem121"
			' 
			' spreadsheetCommandBarButtonItem122
			' 
			Me.spreadsheetCommandBarButtonItem122.CommandName = "ViewZoomIn"
			Me.spreadsheetCommandBarButtonItem122.Id = 501
			Me.spreadsheetCommandBarButtonItem122.Name = "spreadsheetCommandBarButtonItem122"
			' 
			' spreadsheetCommandBarButtonItem123
			' 
			Me.spreadsheetCommandBarButtonItem123.CommandName = "ViewZoom100Percent"
			Me.spreadsheetCommandBarButtonItem123.Id = 502
			Me.spreadsheetCommandBarButtonItem123.Name = "spreadsheetCommandBarButtonItem123"
			' 
			' spreadsheetCommandBarSubItem25
			' 
			Me.spreadsheetCommandBarSubItem25.CommandName = "ViewFreezePanesCommandGroup"
			Me.spreadsheetCommandBarSubItem25.Id = 503
			Me.spreadsheetCommandBarSubItem25.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem124), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem125), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem126), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem127)})
			Me.spreadsheetCommandBarSubItem25.Name = "spreadsheetCommandBarSubItem25"
			' 
			' spreadsheetCommandBarButtonItem124
			' 
			Me.spreadsheetCommandBarButtonItem124.CommandName = "ViewFreezePanes"
			Me.spreadsheetCommandBarButtonItem124.Id = 504
			Me.spreadsheetCommandBarButtonItem124.Name = "spreadsheetCommandBarButtonItem124"
			' 
			' spreadsheetCommandBarButtonItem125
			' 
			Me.spreadsheetCommandBarButtonItem125.CommandName = "ViewUnfreezePanes"
			Me.spreadsheetCommandBarButtonItem125.Id = 505
			Me.spreadsheetCommandBarButtonItem125.Name = "spreadsheetCommandBarButtonItem125"
			' 
			' spreadsheetCommandBarButtonItem126
			' 
			Me.spreadsheetCommandBarButtonItem126.CommandName = "ViewFreezeTopRow"
			Me.spreadsheetCommandBarButtonItem126.Id = 506
			Me.spreadsheetCommandBarButtonItem126.Name = "spreadsheetCommandBarButtonItem126"
			' 
			' spreadsheetCommandBarButtonItem127
			' 
			Me.spreadsheetCommandBarButtonItem127.CommandName = "ViewFreezeFirstColumn"
			Me.spreadsheetCommandBarButtonItem127.Id = 507
			Me.spreadsheetCommandBarButtonItem127.Name = "spreadsheetCommandBarButtonItem127"
			' 
			' spreadsheetCommandBarButtonItem128
			' 
			Me.spreadsheetCommandBarButtonItem128.CommandName = "ChartChangeType"
			Me.spreadsheetCommandBarButtonItem128.Id = 508
			Me.spreadsheetCommandBarButtonItem128.Name = "spreadsheetCommandBarButtonItem128"
			' 
			' spreadsheetCommandBarButtonItem129
			' 
			Me.spreadsheetCommandBarButtonItem129.CommandName = "ChartSwitchRowColumn"
			Me.spreadsheetCommandBarButtonItem129.Id = 509
			Me.spreadsheetCommandBarButtonItem129.Name = "spreadsheetCommandBarButtonItem129"
			' 
			' spreadsheetCommandBarButtonItem130
			' 
			Me.spreadsheetCommandBarButtonItem130.CommandName = "ChartSelectData"
			Me.spreadsheetCommandBarButtonItem130.Id = 510
			Me.spreadsheetCommandBarButtonItem130.Name = "spreadsheetCommandBarButtonItem130"
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
			Me.galleryChartLayoutItem1.Id = 511
			Me.galleryChartLayoutItem1.Name = "galleryChartLayoutItem1"
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
			Me.galleryChartStyleItem1.Id = 512
			Me.galleryChartStyleItem1.Name = "galleryChartStyleItem1"
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem11
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem11.CommandName = "ChartTitleCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem11.DropDownControl = Me.commandBarGalleryDropDown13
			Me.spreadsheetCommandBarButtonGalleryDropDownItem11.Id = 513
			Me.spreadsheetCommandBarButtonGalleryDropDownItem11.Name = "spreadsheetCommandBarButtonGalleryDropDownItem11"
			' 
			' commandBarGalleryDropDown13
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown13.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown13.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup29.CommandName = "ChartTitleCommandGroup"
			spreadsheetCommandGalleryItem121.CommandName = "ChartTitleNone"
			spreadsheetCommandGalleryItem122.CommandName = "ChartTitleCenteredOverlay"
			spreadsheetCommandGalleryItem123.CommandName = "ChartTitleAbove"
			spreadsheetCommandGalleryItemGroup29.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem121, spreadsheetCommandGalleryItem122, spreadsheetCommandGalleryItem123})
			Me.commandBarGalleryDropDown13.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup29})
			Me.commandBarGalleryDropDown13.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown13.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown13.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown13.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown13.Name = "commandBarGalleryDropDown13"
			Me.commandBarGalleryDropDown13.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarSubItem26
			' 
			Me.spreadsheetCommandBarSubItem26.CommandName = "ChartAxisTitlesCommandGroup"
			Me.spreadsheetCommandBarSubItem26.Id = 514
			Me.spreadsheetCommandBarSubItem26.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem13)})
			Me.spreadsheetCommandBarSubItem26.Name = "spreadsheetCommandBarSubItem26"
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem12
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem12.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem12.DropDownControl = Me.commandBarGalleryDropDown14
			Me.spreadsheetCommandBarButtonGalleryDropDownItem12.Id = 515
			Me.spreadsheetCommandBarButtonGalleryDropDownItem12.Name = "spreadsheetCommandBarButtonGalleryDropDownItem12"
			' 
			' commandBarGalleryDropDown14
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown14.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown14.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup30.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup"
			spreadsheetCommandGalleryItem124.CommandName = "ChartPrimaryHorizontalAxisTitleNone"
			spreadsheetCommandGalleryItem125.CommandName = "ChartPrimaryHorizontalAxisTitleBelow"
			spreadsheetCommandGalleryItemGroup30.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem124, spreadsheetCommandGalleryItem125})
			Me.commandBarGalleryDropDown14.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup30})
			Me.commandBarGalleryDropDown14.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown14.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown14.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown14.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown14.Name = "commandBarGalleryDropDown14"
			Me.commandBarGalleryDropDown14.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem13
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem13.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem13.DropDownControl = Me.commandBarGalleryDropDown15
			Me.spreadsheetCommandBarButtonGalleryDropDownItem13.Id = 516
			Me.spreadsheetCommandBarButtonGalleryDropDownItem13.Name = "spreadsheetCommandBarButtonGalleryDropDownItem13"
			' 
			' commandBarGalleryDropDown15
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown15.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown15.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup31.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup"
			spreadsheetCommandGalleryItem126.CommandName = "ChartPrimaryVerticalAxisTitleNone"
			spreadsheetCommandGalleryItem127.CommandName = "ChartPrimaryVerticalAxisTitleRotated"
			spreadsheetCommandGalleryItem128.CommandName = "ChartPrimaryVerticalAxisTitleVertical"
			spreadsheetCommandGalleryItem129.CommandName = "ChartPrimaryVerticalAxisTitleHorizontal"
			spreadsheetCommandGalleryItemGroup31.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem126, spreadsheetCommandGalleryItem127, spreadsheetCommandGalleryItem128, spreadsheetCommandGalleryItem129})
			Me.commandBarGalleryDropDown15.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup31})
			Me.commandBarGalleryDropDown15.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown15.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown15.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown15.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown15.Name = "commandBarGalleryDropDown15"
			Me.commandBarGalleryDropDown15.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem14
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem14.CommandName = "ChartLegendCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem14.DropDownControl = Me.commandBarGalleryDropDown16
			Me.spreadsheetCommandBarButtonGalleryDropDownItem14.Id = 517
			Me.spreadsheetCommandBarButtonGalleryDropDownItem14.Name = "spreadsheetCommandBarButtonGalleryDropDownItem14"
			' 
			' commandBarGalleryDropDown16
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown16.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown16.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup32.CommandName = "ChartLegendCommandGroup"
			spreadsheetCommandGalleryItem130.CommandName = "ChartLegendNone"
			spreadsheetCommandGalleryItem131.CommandName = "ChartLegendAtRight"
			spreadsheetCommandGalleryItem132.CommandName = "ChartLegendAtTop"
			spreadsheetCommandGalleryItem133.CommandName = "ChartLegendAtLeft"
			spreadsheetCommandGalleryItem134.CommandName = "ChartLegendAtBottom"
			spreadsheetCommandGalleryItem135.CommandName = "ChartLegendOverlayAtRight"
			spreadsheetCommandGalleryItem136.CommandName = "ChartLegendOverlayAtLeft"
			spreadsheetCommandGalleryItemGroup32.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem130, spreadsheetCommandGalleryItem131, spreadsheetCommandGalleryItem132, spreadsheetCommandGalleryItem133, spreadsheetCommandGalleryItem134, spreadsheetCommandGalleryItem135, spreadsheetCommandGalleryItem136})
			Me.commandBarGalleryDropDown16.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup32})
			Me.commandBarGalleryDropDown16.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown16.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown16.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown16.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown16.Name = "commandBarGalleryDropDown16"
			Me.commandBarGalleryDropDown16.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem15
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem15.CommandName = "ChartDataLabelsCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem15.DropDownControl = Me.commandBarGalleryDropDown17
			Me.spreadsheetCommandBarButtonGalleryDropDownItem15.Id = 518
			Me.spreadsheetCommandBarButtonGalleryDropDownItem15.Name = "spreadsheetCommandBarButtonGalleryDropDownItem15"
			' 
			' commandBarGalleryDropDown17
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown17.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown17.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup33.CommandName = "ChartDataLabelsCommandGroup"
			spreadsheetCommandGalleryItem137.CommandName = "ChartDataLabelsNone"
			spreadsheetCommandGalleryItem138.CommandName = "ChartDataLabelsDefault"
			spreadsheetCommandGalleryItem139.CommandName = "ChartDataLabelsCenter"
			spreadsheetCommandGalleryItem140.CommandName = "ChartDataLabelsInsideEnd"
			spreadsheetCommandGalleryItem141.CommandName = "ChartDataLabelsInsideBase"
			spreadsheetCommandGalleryItem142.CommandName = "ChartDataLabelsOutsideEnd"
			spreadsheetCommandGalleryItem143.CommandName = "ChartDataLabelsBestFit"
			spreadsheetCommandGalleryItem144.CommandName = "ChartDataLabelsLeft"
			spreadsheetCommandGalleryItem145.CommandName = "ChartDataLabelsRight"
			spreadsheetCommandGalleryItem146.CommandName = "ChartDataLabelsAbove"
			spreadsheetCommandGalleryItem147.CommandName = "ChartDataLabelsBelow"
			spreadsheetCommandGalleryItemGroup33.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem137, spreadsheetCommandGalleryItem138, spreadsheetCommandGalleryItem139, spreadsheetCommandGalleryItem140, spreadsheetCommandGalleryItem141, spreadsheetCommandGalleryItem142, spreadsheetCommandGalleryItem143, spreadsheetCommandGalleryItem144, spreadsheetCommandGalleryItem145, spreadsheetCommandGalleryItem146, spreadsheetCommandGalleryItem147})
			Me.commandBarGalleryDropDown17.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup33})
			Me.commandBarGalleryDropDown17.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown17.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown17.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown17.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown17.Name = "commandBarGalleryDropDown17"
			Me.commandBarGalleryDropDown17.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarSubItem27
			' 
			Me.spreadsheetCommandBarSubItem27.CommandName = "ChartAxesCommandGroup"
			Me.spreadsheetCommandBarSubItem27.Id = 519
			Me.spreadsheetCommandBarSubItem27.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem17)})
			Me.spreadsheetCommandBarSubItem27.Name = "spreadsheetCommandBarSubItem27"
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem16
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem16.CommandName = "ChartPrimaryHorizontalAxisCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem16.DropDownControl = Me.commandBarGalleryDropDown18
			Me.spreadsheetCommandBarButtonGalleryDropDownItem16.Id = 520
			Me.spreadsheetCommandBarButtonGalleryDropDownItem16.Name = "spreadsheetCommandBarButtonGalleryDropDownItem16"
			' 
			' commandBarGalleryDropDown18
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown18.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown18.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup34.CommandName = "ChartPrimaryHorizontalAxisCommandGroup"
			spreadsheetCommandGalleryItem148.CommandName = "ChartHidePrimaryHorizontalAxis"
			spreadsheetCommandGalleryItem149.CommandName = "ChartPrimaryHorizontalAxisLeftToRight"
			spreadsheetCommandGalleryItem150.CommandName = "ChartPrimaryHorizontalAxisHideLabels"
			spreadsheetCommandGalleryItem151.CommandName = "ChartPrimaryHorizontalAxisRightToLeft"
			spreadsheetCommandGalleryItem152.CommandName = "ChartPrimaryHorizontalAxisDefault"
			spreadsheetCommandGalleryItem153.CommandName = "ChartPrimaryHorizontalAxisScaleThousands"
			spreadsheetCommandGalleryItem154.CommandName = "ChartPrimaryHorizontalAxisScaleMillions"
			spreadsheetCommandGalleryItem155.CommandName = "ChartPrimaryHorizontalAxisScaleBillions"
			spreadsheetCommandGalleryItem156.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm"
			spreadsheetCommandGalleryItemGroup34.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem148, spreadsheetCommandGalleryItem149, spreadsheetCommandGalleryItem150, spreadsheetCommandGalleryItem151, spreadsheetCommandGalleryItem152, spreadsheetCommandGalleryItem153, spreadsheetCommandGalleryItem154, spreadsheetCommandGalleryItem155, spreadsheetCommandGalleryItem156})
			Me.commandBarGalleryDropDown18.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup34})
			Me.commandBarGalleryDropDown18.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown18.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown18.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown18.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown18.Name = "commandBarGalleryDropDown18"
			Me.commandBarGalleryDropDown18.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem17
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem17.CommandName = "ChartPrimaryVerticalAxisCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem17.DropDownControl = Me.commandBarGalleryDropDown19
			Me.spreadsheetCommandBarButtonGalleryDropDownItem17.Id = 521
			Me.spreadsheetCommandBarButtonGalleryDropDownItem17.Name = "spreadsheetCommandBarButtonGalleryDropDownItem17"
			' 
			' commandBarGalleryDropDown19
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown19.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown19.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup35.CommandName = "ChartPrimaryVerticalAxisCommandGroup"
			spreadsheetCommandGalleryItem157.CommandName = "ChartHidePrimaryVerticalAxis"
			spreadsheetCommandGalleryItem158.CommandName = "ChartPrimaryVerticalAxisLeftToRight"
			spreadsheetCommandGalleryItem159.CommandName = "ChartPrimaryVerticalAxisHideLabels"
			spreadsheetCommandGalleryItem160.CommandName = "ChartPrimaryVerticalAxisRightToLeft"
			spreadsheetCommandGalleryItem161.CommandName = "ChartPrimaryVerticalAxisDefault"
			spreadsheetCommandGalleryItem162.CommandName = "ChartPrimaryVerticalAxisScaleThousands"
			spreadsheetCommandGalleryItem163.CommandName = "ChartPrimaryVerticalAxisScaleMillions"
			spreadsheetCommandGalleryItem164.CommandName = "ChartPrimaryVerticalAxisScaleBillions"
			spreadsheetCommandGalleryItem165.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm"
			spreadsheetCommandGalleryItemGroup35.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem157, spreadsheetCommandGalleryItem158, spreadsheetCommandGalleryItem159, spreadsheetCommandGalleryItem160, spreadsheetCommandGalleryItem161, spreadsheetCommandGalleryItem162, spreadsheetCommandGalleryItem163, spreadsheetCommandGalleryItem164, spreadsheetCommandGalleryItem165})
			Me.commandBarGalleryDropDown19.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup35})
			Me.commandBarGalleryDropDown19.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown19.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown19.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown19.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown19.Name = "commandBarGalleryDropDown19"
			Me.commandBarGalleryDropDown19.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarSubItem28
			' 
			Me.spreadsheetCommandBarSubItem28.CommandName = "ChartGridlinesCommandGroup"
			Me.spreadsheetCommandBarSubItem28.Id = 522
			Me.spreadsheetCommandBarSubItem28.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem19)})
			Me.spreadsheetCommandBarSubItem28.Name = "spreadsheetCommandBarSubItem28"
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem18
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem18.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem18.DropDownControl = Me.commandBarGalleryDropDown20
			Me.spreadsheetCommandBarButtonGalleryDropDownItem18.Id = 523
			Me.spreadsheetCommandBarButtonGalleryDropDownItem18.Name = "spreadsheetCommandBarButtonGalleryDropDownItem18"
			' 
			' commandBarGalleryDropDown20
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown20.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown20.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup36.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup"
			spreadsheetCommandGalleryItem166.CommandName = "ChartPrimaryHorizontalGridlinesNone"
			spreadsheetCommandGalleryItem167.CommandName = "ChartPrimaryHorizontalGridlinesMajor"
			spreadsheetCommandGalleryItem168.CommandName = "ChartPrimaryHorizontalGridlinesMinor"
			spreadsheetCommandGalleryItem169.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor"
			spreadsheetCommandGalleryItemGroup36.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem166, spreadsheetCommandGalleryItem167, spreadsheetCommandGalleryItem168, spreadsheetCommandGalleryItem169})
			Me.commandBarGalleryDropDown20.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup36})
			Me.commandBarGalleryDropDown20.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown20.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown20.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown20.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown20.Name = "commandBarGalleryDropDown20"
			Me.commandBarGalleryDropDown20.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem19
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem19.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem19.DropDownControl = Me.commandBarGalleryDropDown21
			Me.spreadsheetCommandBarButtonGalleryDropDownItem19.Id = 524
			Me.spreadsheetCommandBarButtonGalleryDropDownItem19.Name = "spreadsheetCommandBarButtonGalleryDropDownItem19"
			' 
			' commandBarGalleryDropDown21
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown21.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown21.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup37.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup"
			spreadsheetCommandGalleryItem170.CommandName = "ChartPrimaryVerticalGridlinesNone"
			spreadsheetCommandGalleryItem171.CommandName = "ChartPrimaryVerticalGridlinesMajor"
			spreadsheetCommandGalleryItem172.CommandName = "ChartPrimaryVerticalGridlinesMinor"
			spreadsheetCommandGalleryItem173.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor"
			spreadsheetCommandGalleryItemGroup37.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem170, spreadsheetCommandGalleryItem171, spreadsheetCommandGalleryItem172, spreadsheetCommandGalleryItem173})
			Me.commandBarGalleryDropDown21.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup37})
			Me.commandBarGalleryDropDown21.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown21.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown21.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown21.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown21.Name = "commandBarGalleryDropDown21"
			Me.commandBarGalleryDropDown21.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem20
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem20.CommandName = "ChartLinesCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem20.DropDownControl = Me.commandBarGalleryDropDown22
			Me.spreadsheetCommandBarButtonGalleryDropDownItem20.Id = 525
			Me.spreadsheetCommandBarButtonGalleryDropDownItem20.Name = "spreadsheetCommandBarButtonGalleryDropDownItem20"
			' 
			' commandBarGalleryDropDown22
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown22.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown22.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup38.CommandName = "ChartLinesCommandGroup"
			spreadsheetCommandGalleryItem174.CommandName = "ChartLinesNone"
			spreadsheetCommandGalleryItem175.CommandName = "ChartShowDropLines"
			spreadsheetCommandGalleryItem176.CommandName = "ChartShowHighLowLines"
			spreadsheetCommandGalleryItem177.CommandName = "ChartShowDropLinesAndHighLowLines"
			spreadsheetCommandGalleryItem178.CommandName = "ChartShowSeriesLines"
			spreadsheetCommandGalleryItemGroup38.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem174, spreadsheetCommandGalleryItem175, spreadsheetCommandGalleryItem176, spreadsheetCommandGalleryItem177, spreadsheetCommandGalleryItem178})
			Me.commandBarGalleryDropDown22.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup38})
			Me.commandBarGalleryDropDown22.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown22.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown22.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown22.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown22.Name = "commandBarGalleryDropDown22"
			Me.commandBarGalleryDropDown22.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem21
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem21.CommandName = "ChartUpDownBarsCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem21.DropDownControl = Me.commandBarGalleryDropDown23
			Me.spreadsheetCommandBarButtonGalleryDropDownItem21.Id = 526
			Me.spreadsheetCommandBarButtonGalleryDropDownItem21.Name = "spreadsheetCommandBarButtonGalleryDropDownItem21"
			' 
			' commandBarGalleryDropDown23
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown23.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown23.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup39.CommandName = "ChartUpDownBarsCommandGroup"
			spreadsheetCommandGalleryItem179.CommandName = "ChartHideUpDownBars"
			spreadsheetCommandGalleryItem180.CommandName = "ChartShowUpDownBars"
			spreadsheetCommandGalleryItemGroup39.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem179, spreadsheetCommandGalleryItem180})
			Me.commandBarGalleryDropDown23.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup39})
			Me.commandBarGalleryDropDown23.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown23.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown23.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown23.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown23.Name = "commandBarGalleryDropDown23"
			Me.commandBarGalleryDropDown23.Ribbon = Me.ribbonControl1
			' 
			' spreadsheetCommandBarButtonGalleryDropDownItem22
			' 
			Me.spreadsheetCommandBarButtonGalleryDropDownItem22.CommandName = "ChartErrorBarsCommandGroup"
			Me.spreadsheetCommandBarButtonGalleryDropDownItem22.DropDownControl = Me.commandBarGalleryDropDown24
			Me.spreadsheetCommandBarButtonGalleryDropDownItem22.Id = 527
			Me.spreadsheetCommandBarButtonGalleryDropDownItem22.Name = "spreadsheetCommandBarButtonGalleryDropDownItem22"
			' 
			' commandBarGalleryDropDown24
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown24.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown24.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			spreadsheetCommandGalleryItemGroup40.CommandName = "ChartErrorBarsCommandGroup"
			spreadsheetCommandGalleryItem181.CommandName = "ChartErrorBarsNone"
			spreadsheetCommandGalleryItem182.CommandName = "ChartErrorBarsStandardError"
			spreadsheetCommandGalleryItem183.CommandName = "ChartErrorBarsPercentage"
			spreadsheetCommandGalleryItem184.CommandName = "ChartErrorBarsStandardDeviation"
			spreadsheetCommandGalleryItemGroup40.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem181, spreadsheetCommandGalleryItem182, spreadsheetCommandGalleryItem183, spreadsheetCommandGalleryItem184})
			Me.commandBarGalleryDropDown24.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup40})
			Me.commandBarGalleryDropDown24.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown24.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown24.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.commandBarGalleryDropDown24.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown24.Name = "commandBarGalleryDropDown24"
			Me.commandBarGalleryDropDown24.Ribbon = Me.ribbonControl1
			' 
			' barStaticItem1
			' 
			Me.barStaticItem1.Caption = "Table Name:"
			Me.barStaticItem1.Id = 528
			Me.barStaticItem1.Name = "barStaticItem1"
			Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' renameTableItem1
			' 
			Me.renameTableItem1.Edit = Me.repositoryItemTextEdit1
			Me.renameTableItem1.Id = 529
			Me.renameTableItem1.Name = "renameTableItem1"
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' spreadsheetCommandBarCheckItem26
			' 
			Me.spreadsheetCommandBarCheckItem26.CommandName = "TableToolsConvertToRange"
			Me.spreadsheetCommandBarCheckItem26.Id = 530
			Me.spreadsheetCommandBarCheckItem26.Name = "spreadsheetCommandBarCheckItem26"
			Me.spreadsheetCommandBarCheckItem26.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarCheckItem27
			' 
			Me.spreadsheetCommandBarCheckItem27.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem27.CommandName = "TableToolsToggleHeaderRow"
			Me.spreadsheetCommandBarCheckItem27.Id = 531
			Me.spreadsheetCommandBarCheckItem27.Name = "spreadsheetCommandBarCheckItem27"
			' 
			' spreadsheetCommandBarCheckItem28
			' 
			Me.spreadsheetCommandBarCheckItem28.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem28.CommandName = "TableToolsToggleTotalRow"
			Me.spreadsheetCommandBarCheckItem28.Id = 532
			Me.spreadsheetCommandBarCheckItem28.Name = "spreadsheetCommandBarCheckItem28"
			' 
			' spreadsheetCommandBarCheckItem29
			' 
			Me.spreadsheetCommandBarCheckItem29.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem29.CommandName = "TableToolsToggleBandedColumns"
			Me.spreadsheetCommandBarCheckItem29.Id = 533
			Me.spreadsheetCommandBarCheckItem29.Name = "spreadsheetCommandBarCheckItem29"
			' 
			' spreadsheetCommandBarCheckItem30
			' 
			Me.spreadsheetCommandBarCheckItem30.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem30.CommandName = "TableToolsToggleFirstColumn"
			Me.spreadsheetCommandBarCheckItem30.Id = 534
			Me.spreadsheetCommandBarCheckItem30.Name = "spreadsheetCommandBarCheckItem30"
			' 
			' spreadsheetCommandBarCheckItem31
			' 
			Me.spreadsheetCommandBarCheckItem31.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem31.CommandName = "TableToolsToggleLastColumn"
			Me.spreadsheetCommandBarCheckItem31.Id = 535
			Me.spreadsheetCommandBarCheckItem31.Name = "spreadsheetCommandBarCheckItem31"
			' 
			' spreadsheetCommandBarCheckItem32
			' 
			Me.spreadsheetCommandBarCheckItem32.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.spreadsheetCommandBarCheckItem32.CommandName = "TableToolsToggleBandedRows"
			Me.spreadsheetCommandBarCheckItem32.Id = 536
			Me.spreadsheetCommandBarCheckItem32.Name = "spreadsheetCommandBarCheckItem32"
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
			Me.galleryTableStylesItem1.Id = 537
			Me.galleryTableStylesItem1.Name = "galleryTableStylesItem1"
			' 
			' spreadsheetCommandBarCheckItem33
			' 
			Me.spreadsheetCommandBarCheckItem33.CommandName = "MailMergeDocumentsMode"
			Me.spreadsheetCommandBarCheckItem33.Id = 538
			Me.spreadsheetCommandBarCheckItem33.Name = "spreadsheetCommandBarCheckItem33"
			Me.spreadsheetCommandBarCheckItem33.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarCheckItem34
			' 
			Me.spreadsheetCommandBarCheckItem34.CommandName = "MailMergeOneDocumentMode"
			Me.spreadsheetCommandBarCheckItem34.Id = 539
			Me.spreadsheetCommandBarCheckItem34.Name = "spreadsheetCommandBarCheckItem34"
			Me.spreadsheetCommandBarCheckItem34.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarCheckItem35
			' 
			Me.spreadsheetCommandBarCheckItem35.CommandName = "MailMergeOneSheetMode"
			Me.spreadsheetCommandBarCheckItem35.Id = 540
			Me.spreadsheetCommandBarCheckItem35.Name = "spreadsheetCommandBarCheckItem35"
			Me.spreadsheetCommandBarCheckItem35.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarSubItem29
			' 
			Me.spreadsheetCommandBarSubItem29.CommandName = "MailMergeOrientationCommandGroup"
			Me.spreadsheetCommandBarSubItem29.Id = 541
			Me.spreadsheetCommandBarSubItem29.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem36), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem37)})
			Me.spreadsheetCommandBarSubItem29.Name = "spreadsheetCommandBarSubItem29"
			Me.spreadsheetCommandBarSubItem29.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarCheckItem36
			' 
			Me.spreadsheetCommandBarCheckItem36.CommandName = "MailMergeHorizontalMode"
			Me.spreadsheetCommandBarCheckItem36.Id = 542
			Me.spreadsheetCommandBarCheckItem36.Name = "spreadsheetCommandBarCheckItem36"
			' 
			' spreadsheetCommandBarCheckItem37
			' 
			Me.spreadsheetCommandBarCheckItem37.CommandName = "MailMergeVerticalMode"
			Me.spreadsheetCommandBarCheckItem37.Id = 543
			Me.spreadsheetCommandBarCheckItem37.Name = "spreadsheetCommandBarCheckItem37"
			' 
			' spreadsheetCommandBarButtonItem131
			' 
			Me.spreadsheetCommandBarButtonItem131.CommandName = "MailMergeSetHeaderRange"
			Me.spreadsheetCommandBarButtonItem131.Id = 544
			Me.spreadsheetCommandBarButtonItem131.Name = "spreadsheetCommandBarButtonItem131"
			Me.spreadsheetCommandBarButtonItem131.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem132
			' 
			Me.spreadsheetCommandBarButtonItem132.CommandName = "MailMergeSetFooterRange"
			Me.spreadsheetCommandBarButtonItem132.Id = 545
			Me.spreadsheetCommandBarButtonItem132.Name = "spreadsheetCommandBarButtonItem132"
			Me.spreadsheetCommandBarButtonItem132.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem133
			' 
			Me.spreadsheetCommandBarButtonItem133.CommandName = "MailMergeSetDetailRange"
			Me.spreadsheetCommandBarButtonItem133.Id = 546
			Me.spreadsheetCommandBarButtonItem133.Name = "spreadsheetCommandBarButtonItem133"
			Me.spreadsheetCommandBarButtonItem133.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarSubItem30
			' 
			Me.spreadsheetCommandBarSubItem30.CommandName = "EditingMailMergeMasterDetailCommandGroup"
			Me.spreadsheetCommandBarSubItem30.Id = 547
			Me.spreadsheetCommandBarSubItem30.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem134), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem135)})
			Me.spreadsheetCommandBarSubItem30.Name = "spreadsheetCommandBarSubItem30"
			Me.spreadsheetCommandBarSubItem30.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem134
			' 
			Me.spreadsheetCommandBarButtonItem134.CommandName = "MailMergeSetDetailLevel"
			Me.spreadsheetCommandBarButtonItem134.Id = 548
			Me.spreadsheetCommandBarButtonItem134.Name = "spreadsheetCommandBarButtonItem134"
			' 
			' spreadsheetCommandBarButtonItem135
			' 
			Me.spreadsheetCommandBarButtonItem135.CommandName = "MailMergeSetDetailDataMember"
			Me.spreadsheetCommandBarButtonItem135.Id = 549
			Me.spreadsheetCommandBarButtonItem135.Name = "spreadsheetCommandBarButtonItem135"
			' 
			' spreadsheetCommandBarButtonItem136
			' 
			Me.spreadsheetCommandBarButtonItem136.CommandName = "MailMergeResetRange"
			Me.spreadsheetCommandBarButtonItem136.Id = 550
			Me.spreadsheetCommandBarButtonItem136.Name = "spreadsheetCommandBarButtonItem136"
			Me.spreadsheetCommandBarButtonItem136.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem137
			' 
			Me.spreadsheetCommandBarButtonItem137.CommandName = "MailMergeSetGroup"
			Me.spreadsheetCommandBarButtonItem137.Id = 551
			Me.spreadsheetCommandBarButtonItem137.Name = "spreadsheetCommandBarButtonItem137"
			Me.spreadsheetCommandBarButtonItem137.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem138
			' 
			Me.spreadsheetCommandBarButtonItem138.CommandName = "MailMergeSetGroupHeader"
			Me.spreadsheetCommandBarButtonItem138.Id = 552
			Me.spreadsheetCommandBarButtonItem138.Name = "spreadsheetCommandBarButtonItem138"
			Me.spreadsheetCommandBarButtonItem138.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem139
			' 
			Me.spreadsheetCommandBarButtonItem139.CommandName = "MailMergeSetGroupFooter"
			Me.spreadsheetCommandBarButtonItem139.Id = 553
			Me.spreadsheetCommandBarButtonItem139.Name = "spreadsheetCommandBarButtonItem139"
			Me.spreadsheetCommandBarButtonItem139.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem140
			' 
			Me.spreadsheetCommandBarButtonItem140.CommandName = "MailMergeSetFilter"
			Me.spreadsheetCommandBarButtonItem140.Id = 554
			Me.spreadsheetCommandBarButtonItem140.Name = "spreadsheetCommandBarButtonItem140"
			Me.spreadsheetCommandBarButtonItem140.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem141
			' 
			Me.spreadsheetCommandBarButtonItem141.CommandName = "MailMergeResetFilter"
			Me.spreadsheetCommandBarButtonItem141.Id = 555
			Me.spreadsheetCommandBarButtonItem141.Name = "spreadsheetCommandBarButtonItem141"
			Me.spreadsheetCommandBarButtonItem141.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarCheckItem38
			' 
			Me.spreadsheetCommandBarCheckItem38.CommandName = "MailMergeShowRanges"
			Me.spreadsheetCommandBarCheckItem38.Id = 556
			Me.spreadsheetCommandBarCheckItem38.Name = "spreadsheetCommandBarCheckItem38"
			Me.spreadsheetCommandBarCheckItem38.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem142
			' 
			Me.spreadsheetCommandBarButtonItem142.CommandName = "MailMergePreview"
			Me.spreadsheetCommandBarButtonItem142.Id = 557
			Me.spreadsheetCommandBarButtonItem142.Name = "spreadsheetCommandBarButtonItem142"
			Me.spreadsheetCommandBarButtonItem142.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem143
			' 
			Me.spreadsheetCommandBarButtonItem143.CommandName = "MailMergeAddDataSource"
			Me.spreadsheetCommandBarButtonItem143.Id = 561
			Me.spreadsheetCommandBarButtonItem143.Name = "spreadsheetCommandBarButtonItem143"
			Me.spreadsheetCommandBarButtonItem143.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarSubItem31
			' 
			Me.spreadsheetCommandBarSubItem31.CommandName = "MailMergeManageRelationsCommandGroup"
			Me.spreadsheetCommandBarSubItem31.Id = 562
			Me.spreadsheetCommandBarSubItem31.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem144), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem145)})
			Me.spreadsheetCommandBarSubItem31.Name = "spreadsheetCommandBarSubItem31"
			Me.spreadsheetCommandBarSubItem31.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem144
			' 
			Me.spreadsheetCommandBarButtonItem144.CommandName = "MailMergeManageQueriesCommand"
			Me.spreadsheetCommandBarButtonItem144.Id = 563
			Me.spreadsheetCommandBarButtonItem144.Name = "spreadsheetCommandBarButtonItem144"
			' 
			' spreadsheetCommandBarButtonItem145
			' 
			Me.spreadsheetCommandBarButtonItem145.CommandName = "MailMergeManageRelationsCommand"
			Me.spreadsheetCommandBarButtonItem145.Id = 564
			Me.spreadsheetCommandBarButtonItem145.Name = "spreadsheetCommandBarButtonItem145"
			' 
			' spreadsheetCommandBarSubItem32
			' 
			Me.spreadsheetCommandBarSubItem32.CommandName = "MailMergeManageDataSourceCommandGroup"
			Me.spreadsheetCommandBarSubItem32.Id = 565
			Me.spreadsheetCommandBarSubItem32.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem146), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem147), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem148)})
			Me.spreadsheetCommandBarSubItem32.Name = "spreadsheetCommandBarSubItem32"
			Me.spreadsheetCommandBarSubItem32.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem146
			' 
			Me.spreadsheetCommandBarButtonItem146.CommandName = "MailMergeSelectDataSource"
			Me.spreadsheetCommandBarButtonItem146.Id = 566
			Me.spreadsheetCommandBarButtonItem146.Name = "spreadsheetCommandBarButtonItem146"
			' 
			' spreadsheetCommandBarButtonItem147
			' 
			Me.spreadsheetCommandBarButtonItem147.CommandName = "MailMergeSelectDataMember"
			Me.spreadsheetCommandBarButtonItem147.Id = 567
			Me.spreadsheetCommandBarButtonItem147.Name = "spreadsheetCommandBarButtonItem147"
			' 
			' spreadsheetCommandBarButtonItem148
			' 
			Me.spreadsheetCommandBarButtonItem148.CommandName = "MailMergeManageDataSourcesCommand"
			Me.spreadsheetCommandBarButtonItem148.Id = 568
			Me.spreadsheetCommandBarButtonItem148.Name = "spreadsheetCommandBarButtonItem148"
			' 
			' spreadsheetCommandBarButtonItem149
			' 
			Me.spreadsheetCommandBarButtonItem149.CommandName = "FileShowDocumentProperties"
			Me.spreadsheetCommandBarButtonItem149.Id = 570
			Me.spreadsheetCommandBarButtonItem149.Name = "spreadsheetCommandBarButtonItem149"
			' 
			' barButtonGroup11
			' 
			Me.barButtonGroup11.Id = 571
			Me.barButtonGroup11.ItemLinks.Add(Me.changeFontNameItem1)
			Me.barButtonGroup11.ItemLinks.Add(Me.changeFontSizeItem1)
			Me.barButtonGroup11.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem14)
			Me.barButtonGroup11.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem15)
			Me.barButtonGroup11.Name = "barButtonGroup11"
			Me.barButtonGroup11.Tag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
			' 
			' barButtonGroup12
			' 
			Me.barButtonGroup12.Id = 572
			Me.barButtonGroup12.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem1)
			Me.barButtonGroup12.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem2)
			Me.barButtonGroup12.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem3)
			Me.barButtonGroup12.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem4)
			Me.barButtonGroup12.Name = "barButtonGroup12"
			Me.barButtonGroup12.Tag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
			' 
			' barButtonGroup13
			' 
			Me.barButtonGroup13.Id = 573
			Me.barButtonGroup13.ItemLinks.Add(Me.spreadsheetCommandBarSubItem1)
			Me.barButtonGroup13.Name = "barButtonGroup13"
			Me.barButtonGroup13.Tag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}"
			' 
			' barButtonGroup14
			' 
			Me.barButtonGroup14.Id = 574
			Me.barButtonGroup14.ItemLinks.Add(Me.changeCellFillColorItem1)
			Me.barButtonGroup14.ItemLinks.Add(Me.changeFontColorItem1)
			Me.barButtonGroup14.Name = "barButtonGroup14"
			Me.barButtonGroup14.Tag = "{C2275623-04A3-41E8-8D6A-EB5C7F8541D1}"
			' 
			' barButtonGroup15
			' 
			Me.barButtonGroup15.Id = 575
			Me.barButtonGroup15.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem5)
			Me.barButtonGroup15.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem6)
			Me.barButtonGroup15.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem7)
			Me.barButtonGroup15.Name = "barButtonGroup15"
			Me.barButtonGroup15.Tag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
			' 
			' barButtonGroup16
			' 
			Me.barButtonGroup16.Id = 576
			Me.barButtonGroup16.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem8)
			Me.barButtonGroup16.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem9)
			Me.barButtonGroup16.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem10)
			Me.barButtonGroup16.Name = "barButtonGroup16"
			Me.barButtonGroup16.Tag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
			' 
			' barButtonGroup17
			' 
			Me.barButtonGroup17.Id = 577
			Me.barButtonGroup17.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem29)
			Me.barButtonGroup17.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem30)
			Me.barButtonGroup17.Name = "barButtonGroup17"
			Me.barButtonGroup17.Tag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
			' 
			' barButtonGroup18
			' 
			Me.barButtonGroup18.Id = 578
			Me.barButtonGroup18.ItemLinks.Add(Me.changeNumberFormatItem1)
			Me.barButtonGroup18.Name = "barButtonGroup18"
			Me.barButtonGroup18.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
			' 
			' barButtonGroup19
			' 
			Me.barButtonGroup19.Id = 579
			Me.barButtonGroup19.ItemLinks.Add(Me.spreadsheetCommandBarSubItem3)
			Me.barButtonGroup19.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem39)
			Me.barButtonGroup19.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem40)
			Me.barButtonGroup19.Name = "barButtonGroup19"
			Me.barButtonGroup19.Tag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
			' 
			' barButtonGroup20
			' 
			Me.barButtonGroup20.Id = 580
			Me.barButtonGroup20.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem41)
			Me.barButtonGroup20.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem42)
			Me.barButtonGroup20.Name = "barButtonGroup20"
			Me.barButtonGroup20.Tag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
			' 
			' spreadsheetCommandBarCheckItem39
			' 
			Me.spreadsheetCommandBarCheckItem39.CommandName = "DataFilterToggle"
			Me.spreadsheetCommandBarCheckItem39.Id = 581
			Me.spreadsheetCommandBarCheckItem39.Name = "spreadsheetCommandBarCheckItem39"
			' 
			' spreadsheetCommandBarButtonItem150
			' 
			Me.spreadsheetCommandBarButtonItem150.CommandName = "DataFilterClear"
			Me.spreadsheetCommandBarButtonItem150.Id = 582
			Me.spreadsheetCommandBarButtonItem150.Name = "spreadsheetCommandBarButtonItem150"
			' 
			' spreadsheetCommandBarButtonItem151
			' 
			Me.spreadsheetCommandBarButtonItem151.CommandName = "DataFilterReApply"
			Me.spreadsheetCommandBarButtonItem151.Id = 583
			Me.spreadsheetCommandBarButtonItem151.Name = "spreadsheetCommandBarButtonItem151"
			' 
			' spreadsheetCommandBarSubItem33
			' 
			Me.spreadsheetCommandBarSubItem33.CommandName = "OutlineGroupCommandGroup"
			Me.spreadsheetCommandBarSubItem33.Id = 584
			Me.spreadsheetCommandBarSubItem33.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem152), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem153)})
			Me.spreadsheetCommandBarSubItem33.Name = "spreadsheetCommandBarSubItem33"
			Me.spreadsheetCommandBarSubItem33.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem152
			' 
			Me.spreadsheetCommandBarButtonItem152.CommandName = "GroupOutline"
			Me.spreadsheetCommandBarButtonItem152.Id = 585
			Me.spreadsheetCommandBarButtonItem152.Name = "spreadsheetCommandBarButtonItem152"
			' 
			' spreadsheetCommandBarButtonItem153
			' 
			Me.spreadsheetCommandBarButtonItem153.CommandName = "AutoOutline"
			Me.spreadsheetCommandBarButtonItem153.Id = 586
			Me.spreadsheetCommandBarButtonItem153.Name = "spreadsheetCommandBarButtonItem153"
			' 
			' spreadsheetCommandBarSubItem34
			' 
			Me.spreadsheetCommandBarSubItem34.CommandName = "OutlineUngroupCommandGroup"
			Me.spreadsheetCommandBarSubItem34.Id = 587
			Me.spreadsheetCommandBarSubItem34.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem154), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem155)})
			Me.spreadsheetCommandBarSubItem34.Name = "spreadsheetCommandBarSubItem34"
			Me.spreadsheetCommandBarSubItem34.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem154
			' 
			Me.spreadsheetCommandBarButtonItem154.CommandName = "UngroupOutline"
			Me.spreadsheetCommandBarButtonItem154.Id = 588
			Me.spreadsheetCommandBarButtonItem154.Name = "spreadsheetCommandBarButtonItem154"
			' 
			' spreadsheetCommandBarButtonItem155
			' 
			Me.spreadsheetCommandBarButtonItem155.CommandName = "ClearOutline"
			Me.spreadsheetCommandBarButtonItem155.Id = 589
			Me.spreadsheetCommandBarButtonItem155.Name = "spreadsheetCommandBarButtonItem155"
			' 
			' spreadsheetCommandBarButtonItem156
			' 
			Me.spreadsheetCommandBarButtonItem156.CommandName = "Subtotal"
			Me.spreadsheetCommandBarButtonItem156.Id = 590
			Me.spreadsheetCommandBarButtonItem156.Name = "spreadsheetCommandBarButtonItem156"
			Me.spreadsheetCommandBarButtonItem156.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' spreadsheetCommandBarButtonItem157
			' 
			Me.spreadsheetCommandBarButtonItem157.CommandName = "ShowDetail"
			Me.spreadsheetCommandBarButtonItem157.Id = 591
			Me.spreadsheetCommandBarButtonItem157.Name = "spreadsheetCommandBarButtonItem157"
			Me.spreadsheetCommandBarButtonItem157.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem158
			' 
			Me.spreadsheetCommandBarButtonItem158.CommandName = "HideDetail"
			Me.spreadsheetCommandBarButtonItem158.Id = 592
			Me.spreadsheetCommandBarButtonItem158.Name = "spreadsheetCommandBarButtonItem158"
			Me.spreadsheetCommandBarButtonItem158.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' spreadsheetCommandBarButtonItem159
			' 
			Me.spreadsheetCommandBarButtonItem159.CommandName = "ReviewInsertComment"
			Me.spreadsheetCommandBarButtonItem159.Id = 593
			Me.spreadsheetCommandBarButtonItem159.Name = "spreadsheetCommandBarButtonItem159"
			' 
			' spreadsheetCommandBarButtonItem160
			' 
			Me.spreadsheetCommandBarButtonItem160.CommandName = "ReviewEditComment"
			Me.spreadsheetCommandBarButtonItem160.Id = 594
			Me.spreadsheetCommandBarButtonItem160.Name = "spreadsheetCommandBarButtonItem160"
			' 
			' spreadsheetCommandBarButtonItem161
			' 
			Me.spreadsheetCommandBarButtonItem161.CommandName = "ReviewDeleteComment"
			Me.spreadsheetCommandBarButtonItem161.Id = 595
			Me.spreadsheetCommandBarButtonItem161.Name = "spreadsheetCommandBarButtonItem161"
			' 
			' spreadsheetCommandBarButtonItem162
			' 
			Me.spreadsheetCommandBarButtonItem162.CommandName = "ReviewShowHideComment"
			Me.spreadsheetCommandBarButtonItem162.Id = 596
			Me.spreadsheetCommandBarButtonItem162.Name = "spreadsheetCommandBarButtonItem162"
			Me.spreadsheetCommandBarButtonItem162.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' barStaticItem2
			' 
			Me.barStaticItem2.Caption = "Table Name:"
			Me.barStaticItem2.Id = 597
			Me.barStaticItem2.Name = "barStaticItem2"
			Me.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' chartToolsRibbonPageCategory1
			' 
			Me.chartToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
			Me.chartToolsRibbonPageCategory1.Name = "chartToolsRibbonPageCategory1"
			Me.chartToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.chartsDesignRibbonPage1, Me.chartsLayoutRibbonPage1, Me.chartsFormatRibbonPage1})
			Me.chartToolsRibbonPageCategory1.Visible = False
			' 
			' chartsDesignRibbonPage1
			' 
			Me.chartsDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.chartsDesignTypeRibbonPageGroup1, Me.chartsDesignDataRibbonPageGroup1, Me.chartsDesignLayoutsRibbonPageGroup1, Me.chartsDesignStylesRibbonPageGroup1})
			Me.chartsDesignRibbonPage1.Name = "chartsDesignRibbonPage1"
			Me.chartsDesignRibbonPage1.Visible = False
			' 
			' chartsDesignTypeRibbonPageGroup1
			' 
			Me.chartsDesignTypeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem128)
			Me.chartsDesignTypeRibbonPageGroup1.Name = "chartsDesignTypeRibbonPageGroup1"
			' 
			' chartsDesignDataRibbonPageGroup1
			' 
			Me.chartsDesignDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem129)
			Me.chartsDesignDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem130)
			Me.chartsDesignDataRibbonPageGroup1.Name = "chartsDesignDataRibbonPageGroup1"
			' 
			' chartsDesignLayoutsRibbonPageGroup1
			' 
			Me.chartsDesignLayoutsRibbonPageGroup1.ItemLinks.Add(Me.galleryChartLayoutItem1)
			Me.chartsDesignLayoutsRibbonPageGroup1.Name = "chartsDesignLayoutsRibbonPageGroup1"
			' 
			' chartsDesignStylesRibbonPageGroup1
			' 
			Me.chartsDesignStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChartStyleItem1)
			Me.chartsDesignStylesRibbonPageGroup1.Name = "chartsDesignStylesRibbonPageGroup1"
			' 
			' chartsLayoutRibbonPage1
			' 
			Me.chartsLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.chartsLayoutLabelsRibbonPageGroup1, Me.chartsLayoutAxesRibbonPageGroup1, Me.chartsLayoutAnalysisRibbonPageGroup1})
			Me.chartsLayoutRibbonPage1.Name = "chartsLayoutRibbonPage1"
			Me.chartsLayoutRibbonPage1.Visible = False
			' 
			' chartsLayoutLabelsRibbonPageGroup1
			' 
			Me.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem11)
			Me.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem26)
			Me.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem14)
			Me.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem15)
			Me.chartsLayoutLabelsRibbonPageGroup1.Name = "chartsLayoutLabelsRibbonPageGroup1"
			' 
			' chartsLayoutAxesRibbonPageGroup1
			' 
			Me.chartsLayoutAxesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem27)
			Me.chartsLayoutAxesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem28)
			Me.chartsLayoutAxesRibbonPageGroup1.Name = "chartsLayoutAxesRibbonPageGroup1"
			' 
			' chartsLayoutAnalysisRibbonPageGroup1
			' 
			Me.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem20)
			Me.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem21)
			Me.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem22)
			Me.chartsLayoutAnalysisRibbonPageGroup1.Name = "chartsLayoutAnalysisRibbonPageGroup1"
			' 
			' chartsFormatRibbonPage1
			' 
			Me.chartsFormatRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.chartsFormatArrangeRibbonPageGroup1})
			Me.chartsFormatRibbonPage1.Name = "chartsFormatRibbonPage1"
			Me.chartsFormatRibbonPage1.Visible = False
			' 
			' chartsFormatArrangeRibbonPageGroup1
			' 
			Me.chartsFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem20)
			Me.chartsFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem21)
			Me.chartsFormatArrangeRibbonPageGroup1.Name = "chartsFormatArrangeRibbonPageGroup1"
			' 
			' tableToolsRibbonPageCategory1
			' 
			Me.tableToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
			Me.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1"
			Me.tableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.tableToolsDesignRibbonPage1})
			Me.tableToolsRibbonPageCategory1.Visible = False
			' 
			' tableToolsDesignRibbonPage1
			' 
			Me.tableToolsDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tablePropertiesRibbonPageGroup1, Me.tableToolsRibbonPageGroup1, Me.tableStyleOptionsRibbonPageGroup1, Me.tableStylesRibbonPageGroup1})
			Me.tableToolsDesignRibbonPage1.Name = "tableToolsDesignRibbonPage1"
			Me.tableToolsDesignRibbonPage1.Visible = False
			' 
			' tablePropertiesRibbonPageGroup1
			' 
			Me.tablePropertiesRibbonPageGroup1.ItemLinks.Add(Me.barStaticItem2)
			Me.tablePropertiesRibbonPageGroup1.ItemLinks.Add(Me.renameTableItem1)
			Me.tablePropertiesRibbonPageGroup1.Name = "tablePropertiesRibbonPageGroup1"
			' 
			' tableToolsRibbonPageGroup1
			' 
			Me.tableToolsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem26)
			Me.tableToolsRibbonPageGroup1.Name = "tableToolsRibbonPageGroup1"
			' 
			' tableStyleOptionsRibbonPageGroup1
			' 
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem27)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem28)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem29)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem30)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem31)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem32)
			Me.tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1"
			' 
			' tableStylesRibbonPageGroup1
			' 
			Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryTableStylesItem1)
			Me.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1"
			' 
			' pictureToolsRibbonPageCategory1
			' 
			Me.pictureToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
			Me.pictureToolsRibbonPageCategory1.Name = "pictureToolsRibbonPageCategory1"
			Me.pictureToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.pictureFormatRibbonPage1})
			Me.pictureToolsRibbonPageCategory1.Visible = False
			' 
			' pictureFormatRibbonPage1
			' 
			Me.pictureFormatRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pictureFormatArrangeRibbonPageGroup1})
			Me.pictureFormatRibbonPage1.Name = "pictureFormatRibbonPage1"
			Me.pictureFormatRibbonPage1.Visible = False
			' 
			' pictureFormatArrangeRibbonPageGroup1
			' 
			Me.pictureFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem20)
			Me.pictureFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem21)
			Me.pictureFormatArrangeRibbonPageGroup1.Name = "pictureFormatArrangeRibbonPageGroup1"
			' 
			' drawingToolsRibbonPageCategory1
			' 
			Me.drawingToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
			Me.drawingToolsRibbonPageCategory1.Name = "drawingToolsRibbonPageCategory1"
			Me.drawingToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.drawingFormatRibbonPage1})
			Me.drawingToolsRibbonPageCategory1.Visible = False
			' 
			' drawingFormatRibbonPage1
			' 
			Me.drawingFormatRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.drawingFormatArrangeRibbonPageGroup1})
			Me.drawingFormatRibbonPage1.Name = "drawingFormatRibbonPage1"
			Me.drawingFormatRibbonPage1.Visible = False
			' 
			' drawingFormatArrangeRibbonPageGroup1
			' 
			Me.drawingFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem20)
			Me.drawingFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem21)
			Me.drawingFormatArrangeRibbonPageGroup1.Name = "drawingFormatArrangeRibbonPageGroup1"
			' 
			' fileRibbonPage1
			' 
			Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.infoRibbonPageGroup1})
			Me.fileRibbonPage1.Name = "fileRibbonPage1"
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
			' infoRibbonPageGroup1
			' 
			Me.infoRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem149)
			Me.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1"
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
			' clipboardRibbonPageGroup1
			' 
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem10)
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem11)
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem12)
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem13)
			Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
			' 
			' fontRibbonPageGroup1
			' 
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup11)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup12)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup13)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup14)
			Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
			' 
			' alignmentRibbonPageGroup1
			' 
			Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup15)
			Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup16)
			Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup17)
			Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem11)
			Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem2)
			Me.alignmentRibbonPageGroup1.Name = "alignmentRibbonPageGroup1"
			' 
			' numberRibbonPageGroup1
			' 
			Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup18)
			Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup19)
			Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup20)
			Me.numberRibbonPageGroup1.Name = "numberRibbonPageGroup1"
			' 
			' cellsRibbonPageGroup1
			' 
			Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem8)
			Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem9)
			Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem10)
			Me.cellsRibbonPageGroup1.Name = "cellsRibbonPageGroup1"
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
			' insertRibbonPage1
			' 
			Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.chartsRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.symbolsRibbonPageGroup1})
			Me.insertRibbonPage1.Name = "insertRibbonPage1"
			' 
			' tablesRibbonPageGroup1
			' 
			Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem97)
			Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
			' 
			' illustrationsRibbonPageGroup1
			' 
			Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem98)
			Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
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
			' linksRibbonPageGroup1
			' 
			Me.linksRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem99)
			Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
			' 
			' symbolsRibbonPageGroup1
			' 
			Me.symbolsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem100)
			Me.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
			' 
			' pageLayoutRibbonPage1
			' 
			Me.pageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pageSetupRibbonPageGroup1, Me.pageSetupShowRibbonPageGroup1, Me.pageSetupPrintRibbonPageGroup1, Me.arrangeRibbonPageGroup1})
			Me.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1"
			' 
			' pageSetupRibbonPageGroup1
			' 
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem17)
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem18)
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.pageSetupPaperKindItem1)
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem19)
			Me.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1"
			' 
			' pageSetupShowRibbonPageGroup1
			' 
			Me.pageSetupShowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem19)
			Me.pageSetupShowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem20)
			Me.pageSetupShowRibbonPageGroup1.Name = "pageSetupShowRibbonPageGroup1"
			' 
			' pageSetupPrintRibbonPageGroup1
			' 
			Me.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem21)
			Me.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem22)
			Me.pageSetupPrintRibbonPageGroup1.Name = "pageSetupPrintRibbonPageGroup1"
			' 
			' arrangeRibbonPageGroup1
			' 
			Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem20)
			Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem21)
			Me.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1"
			' 
			' formulasRibbonPage1
			' 
			Me.formulasRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.functionLibraryRibbonPageGroup1, Me.formulaDefinedNamesRibbonPageGroup1, Me.formulaAuditingRibbonPageGroup1, Me.formulaCalculationRibbonPageGroup1})
			Me.formulasRibbonPage1.Name = "formulasRibbonPage1"
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
			' formulaDefinedNamesRibbonPageGroup1
			' 
			Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem112)
			Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem113)
			Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.definedNameListItem1)
			Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem114)
			Me.formulaDefinedNamesRibbonPageGroup1.Name = "formulaDefinedNamesRibbonPageGroup1"
			' 
			' formulaAuditingRibbonPageGroup1
			' 
			Me.formulaAuditingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem23)
			Me.formulaAuditingRibbonPageGroup1.Name = "formulaAuditingRibbonPageGroup1"
			' 
			' formulaCalculationRibbonPageGroup1
			' 
			Me.formulaCalculationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem24)
			Me.formulaCalculationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem115)
			Me.formulaCalculationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem116)
			Me.formulaCalculationRibbonPageGroup1.Name = "formulaCalculationRibbonPageGroup1"
			' 
			' dataRibbonPage1
			' 
			Me.dataRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.sortAndFilterRibbonPageGroup1, Me.outlineRibbonPageGroup1})
			Me.dataRibbonPage1.Name = "dataRibbonPage1"
			' 
			' sortAndFilterRibbonPageGroup1
			' 
			Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem93)
			Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem94)
			Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem39)
			Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem150)
			Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem151)
			Me.sortAndFilterRibbonPageGroup1.Name = "sortAndFilterRibbonPageGroup1"
			' 
			' outlineRibbonPageGroup1
			' 
			Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem33)
			Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem34)
			Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem156)
			Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem157)
			Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem158)
			Me.outlineRibbonPageGroup1.Name = "outlineRibbonPageGroup1"
			' 
			' mailMergeRibbonPage1
			' 
			Me.mailMergeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.mailMergeDataRibbonPageGroup1, Me.mailMergeModeRibbonPageGroup1, Me.mailMergeExtendedRibbonPageGroup1, Me.mailMergeGroupingRibbonPageGroup1, Me.mailMergeFilteringRibbonPageGroup1, Me.mailMergeBindingRibbonPageGroup1, Me.ribbonPageDemoGroup})
			Me.mailMergeRibbonPage1.Name = "mailMergeRibbonPage1"
			' 
			' mailMergeDataRibbonPageGroup1
			' 
			Me.mailMergeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem143)
			Me.mailMergeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem31)
			Me.mailMergeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem32)
			Me.mailMergeDataRibbonPageGroup1.Name = "mailMergeDataRibbonPageGroup1"
			' 
			' mailMergeModeRibbonPageGroup1
			' 
			Me.mailMergeModeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem33)
			Me.mailMergeModeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem34)
			Me.mailMergeModeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem35)
			Me.mailMergeModeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem29)
			Me.mailMergeModeRibbonPageGroup1.Name = "mailMergeModeRibbonPageGroup1"
			' 
			' mailMergeExtendedRibbonPageGroup1
			' 
			Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem131)
			Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem132)
			Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem133)
			Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem30)
			Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem136)
			Me.mailMergeExtendedRibbonPageGroup1.Name = "mailMergeExtendedRibbonPageGroup1"
			' 
			' mailMergeGroupingRibbonPageGroup1
			' 
			Me.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem137)
			Me.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem138)
			Me.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem139)
			Me.mailMergeGroupingRibbonPageGroup1.Name = "mailMergeGroupingRibbonPageGroup1"
			' 
			' mailMergeFilteringRibbonPageGroup1
			' 
			Me.mailMergeFilteringRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem140)
			Me.mailMergeFilteringRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem141)
			Me.mailMergeFilteringRibbonPageGroup1.Name = "mailMergeFilteringRibbonPageGroup1"
			' 
			' mailMergeBindingRibbonPageGroup1
			' 
			Me.mailMergeBindingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem38)
			Me.mailMergeBindingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem142)
			Me.mailMergeBindingRibbonPageGroup1.Name = "mailMergeBindingRibbonPageGroup1"
			' 
			' ribbonPageDemoGroup
			' 
			Me.ribbonPageDemoGroup.ItemLinks.Add(Me.hideCommentsCheckItem)
			Me.ribbonPageDemoGroup.Name = "ribbonPageDemoGroup"
			Me.ribbonPageDemoGroup.ShowCaptionButton = False
			Me.ribbonPageDemoGroup.Text = "Demo"
			' 
			' reviewRibbonPage1
			' 
			Me.reviewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commentsRibbonPageGroup1, Me.changesRibbonPageGroup1})
			Me.reviewRibbonPage1.Name = "reviewRibbonPage1"
			' 
			' commentsRibbonPageGroup1
			' 
			Me.commentsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem159)
			Me.commentsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem160)
			Me.commentsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem161)
			Me.commentsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem162)
			Me.commentsRibbonPageGroup1.Name = "commentsRibbonPageGroup1"
			' 
			' changesRibbonPageGroup1
			' 
			Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem76)
			Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem117)
			Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem118)
			Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem119)
			Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem120)
			Me.changesRibbonPageGroup1.Name = "changesRibbonPageGroup1"
			' 
			' viewRibbonPage1
			' 
			Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.showRibbonPageGroup1, Me.zoomRibbonPageGroup1, Me.windowRibbonPageGroup1})
			Me.viewRibbonPage1.Name = "viewRibbonPage1"
			' 
			' showRibbonPageGroup1
			' 
			Me.showRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem19)
			Me.showRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem20)
			Me.showRibbonPageGroup1.Name = "showRibbonPageGroup1"
			' 
			' zoomRibbonPageGroup1
			' 
			Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem121)
			Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem122)
			Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem123)
			Me.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1"
			' 
			' windowRibbonPageGroup1
			' 
			Me.windowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem25)
			Me.windowRibbonPageGroup1.Name = "windowRibbonPageGroup1"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 142)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.spreadsheetNameBoxControl1)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetFormulaBarControl1)
			Me.splitContainerControl1.Size = New System.Drawing.Size(862, 20)
			Me.splitContainerControl1.TabIndex = 2
			' 
			' spreadsheetNameBoxControl1
			' 
			Me.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetNameBoxControl1.EditValue = "A1"
			Me.spreadsheetNameBoxControl1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1"
			Me.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
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
			Me.spreadsheetFormulaBarControl1.Size = New System.Drawing.Size(757, 20)
			Me.spreadsheetFormulaBarControl1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetFormulaBarControl1.TabIndex = 0
			' 
			' spreadsheetBarController1
			' 
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
			Me.spreadsheetBarController1.BarItems.Add(Me.changeFontNameItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.changeFontSizeItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem14)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem15)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem2)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem3)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem4)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem16)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem17)
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
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem29)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem30)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem11)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem2)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem12)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem31)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem32)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem33)
			Me.spreadsheetBarController1.BarItems.Add(Me.changeNumberFormatItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem3)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem34)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem35)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem36)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem37)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem38)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem39)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem40)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem41)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem42)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem4)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem5)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem43)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem44)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem45)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem46)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem47)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem48)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem49)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem6)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem50)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem51)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem52)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem53)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem54)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem55)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem2)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem3)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem7)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem56)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem57)
			Me.spreadsheetBarController1.BarItems.Add(Me.galleryFormatAsTableItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.galleryChangeStyleItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem8)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem58)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem59)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem60)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem9)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem61)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem62)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem63)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem10)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem64)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem65)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem66)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem67)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem68)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem11)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem69)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem70)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem71)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem72)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem73)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem74)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem75)
			Me.spreadsheetBarController1.BarItems.Add(Me.changeSheetTabColorItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem76)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem13)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem77)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem12)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem78)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem79)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem80)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem81)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem82)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem13)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem83)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem84)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem85)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem86)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem14)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem87)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem88)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem89)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem90)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem91)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem92)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem15)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem93)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem94)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem16)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem95)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem96)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem97)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem98)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem4)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem5)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem6)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem7)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem8)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem9)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem10)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem99)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem100)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem17)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem14)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem15)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem16)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem18)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem17)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem18)
			Me.spreadsheetBarController1.BarItems.Add(Me.pageSetupPaperKindItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem19)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem101)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem102)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem19)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem20)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem21)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem22)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem20)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem103)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem104)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem21)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem105)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem106)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem22)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem107)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem108)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem109)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem110)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem111)
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
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem112)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem113)
			Me.spreadsheetBarController1.BarItems.Add(Me.definedNameListItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem114)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem23)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem24)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem24)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem25)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem115)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem116)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem117)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem118)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem119)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem120)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem121)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem122)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem123)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem25)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem124)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem125)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem126)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem127)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem128)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem129)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem130)
			Me.spreadsheetBarController1.BarItems.Add(Me.galleryChartLayoutItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.galleryChartStyleItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem11)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem26)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem12)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem13)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem14)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem15)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem27)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem16)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem17)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem28)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem18)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem19)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem20)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem21)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem22)
			Me.spreadsheetBarController1.BarItems.Add(Me.barStaticItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.renameTableItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem26)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem27)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem28)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem29)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem30)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem31)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem32)
			Me.spreadsheetBarController1.BarItems.Add(Me.galleryTableStylesItem1)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem33)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem34)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem35)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem29)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem36)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem37)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem131)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem132)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem133)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem30)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem134)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem135)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem136)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem137)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem138)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem139)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem140)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem141)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem38)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem142)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem143)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem31)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem144)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem145)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem32)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem146)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem147)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem148)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem149)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem39)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem150)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem151)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem33)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem152)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem153)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem34)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem154)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem155)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem156)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem157)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem158)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem159)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem160)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem161)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem162)
			Me.spreadsheetBarController1.BarItems.Add(Me.barStaticItem2)
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
			' spreadsheetDockManager1
			' 
			Me.spreadsheetDockManager1.Form = Me
			Me.spreadsheetDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1})
			Me.spreadsheetDockManager1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' panelContainer1
			' 
			Me.panelContainer1.Controls.Add(Me.fieldListDockPanel1)
			Me.panelContainer1.Controls.Add(Me.mailMergeParametersDockPanel)
			Me.panelContainer1.Controls.Add(Me.filteringDockPanel)
			Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.panelContainer1.ID = New System.Guid("a9a40f94-dc0f-4f90-b029-4282846c5053")
			Me.panelContainer1.Location = New System.Drawing.Point(862, 142)
			Me.panelContainer1.Margin = New System.Windows.Forms.Padding(0)
			Me.panelContainer1.Name = "panelContainer1"
			Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
			Me.panelContainer1.Size = New System.Drawing.Size(200, 290)
			Me.panelContainer1.Text = "panelContainer1"
			' 
			' fieldListDockPanel1
			' 
			Me.fieldListDockPanel1.Controls.Add(Me.fieldListDockPanel1_Container)
			Me.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.fieldListDockPanel1.ID = New System.Guid("6b098cf1-bd50-44c1-a93a-38b0a4bce017")
			Me.fieldListDockPanel1.Location = New System.Drawing.Point(0, 0)
			Me.fieldListDockPanel1.Name = "fieldListDockPanel1"
			Me.fieldListDockPanel1.OriginalSize = New System.Drawing.Size(200, 145)
			Me.fieldListDockPanel1.Size = New System.Drawing.Size(200, 97)
			Me.fieldListDockPanel1.SpreadsheetControl = Me.spreadsheetControl1
			Me.fieldListDockPanel1.Text = "Field List"
			' 
			' fieldListDockPanel1_Container
			' 
			Me.fieldListDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
			Me.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container"
			Me.fieldListDockPanel1_Container.Size = New System.Drawing.Size(192, 70)
			Me.fieldListDockPanel1_Container.TabIndex = 0
			' 
			' mailMergeParametersDockPanel
			' 
			Me.mailMergeParametersDockPanel.Controls.Add(Me.mailMergeParametersDockPanel1_Container)
			Me.mailMergeParametersDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.mailMergeParametersDockPanel.ID = New System.Guid("09c84a14-2284-4751-b3f0-df4853bb164f")
			Me.mailMergeParametersDockPanel.Location = New System.Drawing.Point(0, 97)
			Me.mailMergeParametersDockPanel.Name = "mailMergeParametersDockPanel"
			Me.mailMergeParametersDockPanel.OriginalSize = New System.Drawing.Size(200, 145)
			Me.mailMergeParametersDockPanel.Size = New System.Drawing.Size(200, 97)
			Me.mailMergeParametersDockPanel.SpreadsheetControl = Me.spreadsheetControl1
			Me.mailMergeParametersDockPanel.Text = "Parameters"
			' 
			' mailMergeParametersDockPanel1_Container
			' 
			Me.mailMergeParametersDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
			Me.mailMergeParametersDockPanel1_Container.Name = "mailMergeParametersDockPanel1_Container"
			Me.mailMergeParametersDockPanel1_Container.Size = New System.Drawing.Size(192, 70)
			Me.mailMergeParametersDockPanel1_Container.TabIndex = 0
			' 
			' filteringDockPanel
			' 
			Me.filteringDockPanel.Controls.Add(Me.dockPanel1_Container)
			Me.filteringDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.filteringDockPanel.ID = New System.Guid("3fa0b467-3f8b-40ff-9387-ffbd4a309a03")
			Me.filteringDockPanel.Location = New System.Drawing.Point(0, 194)
			Me.filteringDockPanel.Name = "filteringDockPanel"
			Me.filteringDockPanel.Options.ShowAutoHideButton = False
			Me.filteringDockPanel.Options.ShowCloseButton = False
			Me.filteringDockPanel.Options.ShowMaximizeButton = False
			Me.filteringDockPanel.OriginalSize = New System.Drawing.Size(200, 200)
			Me.filteringDockPanel.Size = New System.Drawing.Size(200, 96)
			Me.filteringDockPanel.Text = "Filter Templates"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Controls.Add(Me.checkEdit0)
			Me.dockPanel1_Container.Controls.Add(Me.checkEdit1)
			Me.dockPanel1_Container.Controls.Add(Me.checkEdit2)
			Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 23)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(192, 69)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' checkEdit0
			' 
			Me.checkEdit0.EditValue = True
			Me.checkEdit0.Location = New System.Drawing.Point(3, 3)
			Me.checkEdit0.Name = "checkEdit0"
			Me.checkEdit0.Properties.Caption = "Sales Manager"
			Me.checkEdit0.Size = New System.Drawing.Size(174, 19)
			Me.checkEdit0.TabIndex = 7
'			Me.checkEdit0.CheckedChanged += New System.EventHandler(Me.checkEdit_CheckedChanged);
			' 
			' checkEdit1
			' 
			Me.checkEdit1.EditValue = True
			Me.checkEdit1.Location = New System.Drawing.Point(3, 28)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Inside Sales Coordinator"
			Me.checkEdit1.Size = New System.Drawing.Size(174, 19)
			Me.checkEdit1.TabIndex = 8
'			Me.checkEdit1.CheckedChanged += New System.EventHandler(Me.checkEdit_CheckedChanged);
			' 
			' checkEdit2
			' 
			Me.checkEdit2.EditValue = True
			Me.checkEdit2.Location = New System.Drawing.Point(3, 53)
			Me.checkEdit2.Name = "checkEdit2"
			Me.checkEdit2.Properties.Caption = "Sales Representative"
			Me.checkEdit2.Size = New System.Drawing.Size(174, 19)
			Me.checkEdit2.TabIndex = 9
'			Me.checkEdit2.CheckedChanged += New System.EventHandler(Me.checkEdit_CheckedChanged);
			' 
			' MailMergeModuleBase
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.spreadsheetControl1)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Controls.Add(Me.panelContainer1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "MailMergeModuleBase"
			Me.Size = New System.Drawing.Size(1062, 432)
			CType(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpreadsheetFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPopupGalleryEdit1, System.ComponentModel.ISupportInitialize).EndInit()
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
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spreadsheetDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelContainer1.ResumeLayout(False)
			Me.fieldListDockPanel1.ResumeLayout(False)
			Me.mailMergeParametersDockPanel.ResumeLayout(False)
			Me.filteringDockPanel.ResumeLayout(False)
			Me.dockPanel1_Container.ResumeLayout(False)
			CType(Me.checkEdit0.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private splitContainerControl1 As SplitContainerControl
		Private spreadsheetNameBoxControl1 As SpreadsheetNameBoxControl
		Private spreadsheetFormulaBarControl1 As SpreadsheetFormulaBarControl
		Private spreadsheetBarController1 As UI.SpreadsheetBarController
		Private WithEvents hideCommentsCheckItem As XtraBars.BarCheckItem
		Private components As System.ComponentModel.IContainer
		Private spreadsheetDockManager1 As SpreadsheetDockManager
		Private fieldListDockPanel1 As FieldListDockPanel
		Private fieldListDockPanel1_Container As XtraBars.Docking.ControlContainer
		Private panelContainer1 As DockPanel
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
		Private barButtonGroup1 As XtraBars.BarButtonGroup
		Private changeFontNameItem1 As UI.ChangeFontNameItem
		Private repositoryItemFontEdit1 As XtraEditors.Repository.RepositoryItemFontEdit
		Private changeFontSizeItem1 As UI.ChangeFontSizeItem
		Private repositoryItemSpreadsheetFontSizeEdit1 As Design.RepositoryItemSpreadsheetFontSizeEdit
		Private spreadsheetCommandBarButtonItem14 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem15 As UI.SpreadsheetCommandBarButtonItem
		Private barButtonGroup2 As XtraBars.BarButtonGroup
		Private spreadsheetCommandBarCheckItem1 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem2 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem3 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem4 As UI.SpreadsheetCommandBarCheckItem
		Private barButtonGroup3 As XtraBars.BarButtonGroup
		Private spreadsheetCommandBarSubItem1 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem16 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem17 As UI.SpreadsheetCommandBarButtonItem
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
		Private changeBorderLineColorItem1 As UI.ChangeBorderLineColorItem
		Private changeBorderLineStyleItem1 As UI.ChangeBorderLineStyleItem
		Private commandBarGalleryDropDown1 As XtraBars.Commands.CommandBarGalleryDropDown
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
		Private spreadsheetCommandBarButtonItem29 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem30 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarCheckItem11 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarSubItem2 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarCheckItem12 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarButtonItem31 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem32 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem33 As UI.SpreadsheetCommandBarButtonItem
		Private barButtonGroup8 As XtraBars.BarButtonGroup
		Private changeNumberFormatItem1 As UI.ChangeNumberFormatItem
		Private repositoryItemPopupGalleryEdit1 As XtraEditors.Repository.RepositoryItemPopupGalleryEdit
		Private barButtonGroup9 As XtraBars.BarButtonGroup
		Private spreadsheetCommandBarSubItem3 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem34 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem35 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem36 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem37 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem38 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem39 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem40 As UI.SpreadsheetCommandBarButtonItem
		Private barButtonGroup10 As XtraBars.BarButtonGroup
		Private spreadsheetCommandBarButtonItem41 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem42 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem4 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarSubItem5 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem43 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem44 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem45 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem46 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem47 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem48 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem49 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem6 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem50 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem51 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem52 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem53 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem54 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem55 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonGalleryDropDownItem1 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown2 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem2 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown3 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem3 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown4 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarSubItem7 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem56 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem57 As UI.SpreadsheetCommandBarButtonItem
		Private galleryFormatAsTableItem1 As UI.GalleryFormatAsTableItem
		Private commandBarGalleryDropDown5 As XtraBars.Commands.CommandBarGalleryDropDown
		Private galleryChangeStyleItem1 As UI.GalleryChangeStyleItem
		Private spreadsheetCommandBarSubItem8 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem58 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem59 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem60 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem9 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem61 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem62 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem63 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem10 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem64 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem65 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem66 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem67 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem68 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem11 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem69 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem70 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem71 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem72 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem73 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem74 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem75 As UI.SpreadsheetCommandBarButtonItem
		Private changeSheetTabColorItem1 As UI.ChangeSheetTabColorItem
		Private spreadsheetCommandBarButtonItem76 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarCheckItem13 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarButtonItem77 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem12 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem78 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem79 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem80 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem81 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem82 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem13 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem83 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem84 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem85 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem86 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem14 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem87 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem88 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem89 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem90 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem91 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem92 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem15 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem93 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem94 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem16 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem95 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem96 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem97 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem98 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonGalleryDropDownItem4 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown6 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem5 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown7 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem6 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown8 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem7 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown9 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem8 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown10 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem9 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown11 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem10 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown12 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonItem99 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem100 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem17 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarCheckItem14 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem15 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem16 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarSubItem18 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarCheckItem17 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem18 As UI.SpreadsheetCommandBarCheckItem
		Private pageSetupPaperKindItem1 As UI.PageSetupPaperKindItem
		Private spreadsheetCommandBarSubItem19 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem101 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem102 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarCheckItem19 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem20 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem21 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem22 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarSubItem20 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem103 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem104 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem21 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem105 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem106 As UI.SpreadsheetCommandBarButtonItem
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
		Private spreadsheetCommandBarButtonItem112 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem113 As UI.SpreadsheetCommandBarButtonItem
		Private definedNameListItem1 As UI.DefinedNameListItem
		Private spreadsheetCommandBarButtonItem114 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarCheckItem23 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarSubItem24 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarCheckItem24 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem25 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarButtonItem115 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem116 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem117 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem118 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem119 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem120 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem121 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem122 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem123 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem25 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem124 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem125 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem126 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem127 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem128 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem129 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem130 As UI.SpreadsheetCommandBarButtonItem
		Private galleryChartLayoutItem1 As UI.GalleryChartLayoutItem
		Private galleryChartStyleItem1 As UI.GalleryChartStyleItem
		Private spreadsheetCommandBarButtonGalleryDropDownItem11 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown13 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarSubItem26 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonGalleryDropDownItem12 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown14 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem13 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown15 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem14 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown16 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem15 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown17 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarSubItem27 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonGalleryDropDownItem16 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown18 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem17 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown19 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarSubItem28 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonGalleryDropDownItem18 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown20 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem19 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown21 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem20 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown22 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem21 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown23 As XtraBars.Commands.CommandBarGalleryDropDown
		Private spreadsheetCommandBarButtonGalleryDropDownItem22 As UI.SpreadsheetCommandBarButtonGalleryDropDownItem
		Private commandBarGalleryDropDown24 As XtraBars.Commands.CommandBarGalleryDropDown
		Private barStaticItem1 As XtraBars.BarStaticItem
		Private renameTableItem1 As UI.RenameTableItem
		Private repositoryItemTextEdit1 As XtraEditors.Repository.RepositoryItemTextEdit
		Private spreadsheetCommandBarCheckItem26 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem27 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem28 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem29 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem30 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem31 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem32 As UI.SpreadsheetCommandBarCheckItem
		Private galleryTableStylesItem1 As UI.GalleryTableStylesItem
		Private spreadsheetCommandBarCheckItem33 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem34 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem35 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarSubItem29 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarCheckItem36 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarCheckItem37 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarButtonItem131 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem132 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem133 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem30 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem134 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem135 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem136 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem137 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem138 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem139 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem140 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem141 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarCheckItem38 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarButtonItem142 As UI.SpreadsheetCommandBarButtonItem
		Private ribbonPageDemoGroup As XtraBars.Ribbon.RibbonPageGroup
		Private spreadsheetCommandBarButtonItem107 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem108 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem109 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem110 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem111 As UI.SpreadsheetCommandBarButtonItem
		Private mailMergeParametersDockPanel As MailMergeParametersDockPanel
		Private mailMergeParametersDockPanel1_Container As ControlContainer
		Private spreadsheetCommandBarButtonItem143 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem31 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem144 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem145 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem32 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem146 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem147 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem148 As UI.SpreadsheetCommandBarButtonItem
		Private mailMergeRibbonPage1 As UI.MailMergeRibbonPage
		Private mailMergeDataRibbonPageGroup1 As UI.MailMergeDataRibbonPageGroup
		Private mailMergeModeRibbonPageGroup1 As UI.MailMergeModeRibbonPageGroup
		Private mailMergeExtendedRibbonPageGroup1 As UI.MailMergeExtendedRibbonPageGroup
		Private mailMergeGroupingRibbonPageGroup1 As UI.MailMergeGroupingRibbonPageGroup
		Private mailMergeFilteringRibbonPageGroup1 As UI.MailMergeFilteringRibbonPageGroup
		Private mailMergeBindingRibbonPageGroup1 As UI.MailMergeBindingRibbonPageGroup
		Private spreadsheetCommandBarButtonItem149 As UI.SpreadsheetCommandBarButtonItem
		Private barButtonGroup11 As XtraBars.BarButtonGroup
		Private barButtonGroup12 As XtraBars.BarButtonGroup
		Private barButtonGroup13 As XtraBars.BarButtonGroup
		Private barButtonGroup14 As XtraBars.BarButtonGroup
		Private barButtonGroup15 As XtraBars.BarButtonGroup
		Private barButtonGroup16 As XtraBars.BarButtonGroup
		Private barButtonGroup17 As XtraBars.BarButtonGroup
		Private barButtonGroup18 As XtraBars.BarButtonGroup
		Private barButtonGroup19 As XtraBars.BarButtonGroup
		Private barButtonGroup20 As XtraBars.BarButtonGroup
		Private spreadsheetCommandBarCheckItem39 As UI.SpreadsheetCommandBarCheckItem
		Private spreadsheetCommandBarButtonItem150 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem151 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem33 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem152 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem153 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarSubItem34 As UI.SpreadsheetCommandBarSubItem
		Private spreadsheetCommandBarButtonItem154 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem155 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem156 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem157 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem158 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem159 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem160 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem161 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem162 As UI.SpreadsheetCommandBarButtonItem
		Private barStaticItem2 As XtraBars.BarStaticItem
		Private chartToolsRibbonPageCategory1 As UI.ChartToolsRibbonPageCategory
		Private chartsDesignRibbonPage1 As UI.ChartsDesignRibbonPage
		Private chartsDesignTypeRibbonPageGroup1 As UI.ChartsDesignTypeRibbonPageGroup
		Private chartsDesignDataRibbonPageGroup1 As UI.ChartsDesignDataRibbonPageGroup
		Private chartsDesignLayoutsRibbonPageGroup1 As UI.ChartsDesignLayoutsRibbonPageGroup
		Private chartsDesignStylesRibbonPageGroup1 As UI.ChartsDesignStylesRibbonPageGroup
		Private chartsLayoutRibbonPage1 As UI.ChartsLayoutRibbonPage
		Private chartsLayoutLabelsRibbonPageGroup1 As UI.ChartsLayoutLabelsRibbonPageGroup
		Private chartsLayoutAxesRibbonPageGroup1 As UI.ChartsLayoutAxesRibbonPageGroup
		Private chartsLayoutAnalysisRibbonPageGroup1 As UI.ChartsLayoutAnalysisRibbonPageGroup
		Private chartsFormatRibbonPage1 As UI.ChartsFormatRibbonPage
		Private chartsFormatArrangeRibbonPageGroup1 As UI.ChartsFormatArrangeRibbonPageGroup
		Private tableToolsRibbonPageCategory1 As UI.TableToolsRibbonPageCategory
		Private tableToolsDesignRibbonPage1 As UI.TableToolsDesignRibbonPage
		Private tablePropertiesRibbonPageGroup1 As UI.TablePropertiesRibbonPageGroup
		Private tableToolsRibbonPageGroup1 As UI.TableToolsRibbonPageGroup
		Private tableStyleOptionsRibbonPageGroup1 As UI.TableStyleOptionsRibbonPageGroup
		Private tableStylesRibbonPageGroup1 As UI.TableStylesRibbonPageGroup
		Private pictureToolsRibbonPageCategory1 As UI.PictureToolsRibbonPageCategory
		Private pictureFormatRibbonPage1 As UI.PictureFormatRibbonPage
		Private pictureFormatArrangeRibbonPageGroup1 As UI.PictureFormatArrangeRibbonPageGroup
		Private drawingToolsRibbonPageCategory1 As UI.DrawingToolsRibbonPageCategory
		Private drawingFormatRibbonPage1 As UI.DrawingFormatRibbonPage
		Private drawingFormatArrangeRibbonPageGroup1 As UI.DrawingFormatArrangeRibbonPageGroup
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
		Private outlineRibbonPageGroup1 As UI.OutlineRibbonPageGroup
		Private reviewRibbonPage1 As UI.ReviewRibbonPage
		Private commentsRibbonPageGroup1 As UI.CommentsRibbonPageGroup
		Private changesRibbonPageGroup1 As UI.ChangesRibbonPageGroup
		Private viewRibbonPage1 As UI.ViewRibbonPage
		Private showRibbonPageGroup1 As UI.ShowRibbonPageGroup
		Private zoomRibbonPageGroup1 As UI.ZoomRibbonPageGroup
		Private windowRibbonPageGroup1 As UI.WindowRibbonPageGroup
		Private filteringDockPanel As DockPanel
		Private dockPanel1_Container As ControlContainer
		Private WithEvents checkEdit0 As CheckEdit
		Private WithEvents checkEdit1 As CheckEdit
		Private WithEvents checkEdit2 As CheckEdit
	End Class
End Namespace

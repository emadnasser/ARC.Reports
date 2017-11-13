using System;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    public class TutorialsInfo : DevExpress.DXperience.Demos.ModulesInfo {
        const string languageDir = "CS\\";

        static BaseView GetBaseViewByControl(Control control) {
            if(control == null) return null;
            foreach(Control cntl in control.Controls)
                if(cntl is GridControl)
                    return ((GridControl)cntl).MainView;
            return null;
        }

        public static void CloseCustomizationForm(Control control) {
            BaseView view = GetBaseViewByControl(control);
            if(view is GridView)
                ((GridView)view).DestroyCustomization();
        }

        public static DevExpress.Tutorials.ModuleBase ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.DXperience.Demos.LookAndFeelMenu menu, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            ModuleInfo item = TutorialsInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            group.Parent.SuspendLayout();
            group.SuspendLayout();
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null)
                    oldTutorial = Instance.CurrentModuleBase.TModule;

                TutorialControl tutorial = item.TModule as TutorialControl;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;

                CloseCustomizationForm(oldTutorial);

                if(tutorial.ShowLookAndFeel)
                    menu.InitLookAndFeelMenu(lookAndFeel);
                else menu.InitLookAndFeelMenu(null);

                tutorial.AddMenuManager(menu.MainMenu.Manager);
                tutorial.Visible = true;
                if(oldTutorial != null) oldTutorial.Visible = false;
            }
            finally {
                group.ResumeLayout(true);
                group.Parent.ResumeLayout(true);
                Cursor.Current = currentCursor;
            }
            RaiseModuleChanged();
            DevExpress.Tutorials.ModuleBase module = Instance.CurrentModuleBase.TModule as DevExpress.Tutorials.ModuleBase;
            if(module != null) {
                module.TutorialInfo.Description = Instance.CurrentModuleBase.Description;
                module.TutorialInfo.TutorialName = Instance.CurrentModuleBase.Name;
                module.TutorialInfo.WhatsThisCodeFile = Instance.CurrentModuleBase.CodeFile;
                module.TutorialInfo.WhatsThisXMLFile = Instance.CurrentModuleBase.XMLFile;
                string xmlFile = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, module.TutorialInfo.WhatsThisXMLFile, false);
                string codeFile = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, module.TutorialInfo.WhatsThisCodeFile, false);
                if(xmlFile == "") module.TutorialInfo.WhatsThisXMLFile = DemoHelper.StringComposite(module.TutorialInfo.WhatsThisXMLFile, languageDir);
                if(codeFile == "") module.TutorialInfo.WhatsThisCodeFile = DemoHelper.StringComposite(module.TutorialInfo.WhatsThisCodeFile, languageDir);
            }
            return module;
        }
    }
    class RegisterTutorials {
        internal static string NewFeaturesString = "DevExpress XtraGrid " + AssemblyInfo.MarketingVersion;
        public static void Register() {
            TutorialsInfo.Add("Add New Row (Grouped Mode)", "DevExpress.XtraGrid.Demos.Tutorials.GridAddNewRowInGroupedMode",
                "This example demonstrates how to add a new row to a certain group when working with grouped data.", null,
                "GridTutorials\\GridAddNewRowInGroupedMode\\GridAddNewRowInGroupedMode.cs", "Data\\Tutorials\\XtraGrid\\GridAddNewRowInGroupedMode.xml");
            TutorialsInfo.Add("Alpha Blending", "DevExpress.XtraGrid.Demos.Tutorials.GridAlphaBlending",
                "This example demonstrates how to adjust the Alpha Blending feature of the XtraGrid using the XtraGridBlending component.", null,
                "GridTutorials\\GridAlphaBlending\\GridAlphaBlending.cs", "Data\\Tutorials\\XtraGrid\\GridAlphaBlending.xml");
            TutorialsInfo.Add("Control Navigator", "DevExpress.XtraGrid.Demos.Tutorials.GridAndControlNavigator",
                "This demo shows how to use the embedded and external control navigators. To hide the embedded navigator and show the external one, please uncheck the Use Embedded Navigator box.", null,
                "GridTutorials\\GridAndControlNavigator\\GridAndControlNavigator.cs", "Data\\Tutorials\\XtraGrid\\GridAndControlNavigator.xml");
            TutorialsInfo.Add("Banded View Navigation", "DevExpress.XtraGrid.Demos.Tutorials.GridBandedViewNavigation",
                "This demo illustrates different keyboard navigation types available in the banded view. Please play with the check edits and try to navigate the grid using the keyboard to see the difference.", null,
                "GridTutorials\\GridBandedViewNavigation\\GridBandedViewNavigation.cs", "Data\\Tutorials\\XtraGrid\\GridBandedViewNavigation.xml");
            TutorialsInfo.Add("Calc Row Height", "DevExpress.XtraGrid.Demos.Tutorials.GridCalcRowHeight",
                "This example demonstrates how to use the CalcRowHeight event and the OptionsView.RowAutoHeight option.", null,
                "GridTutorials\\GridCalcRowHeight\\GridCalcRowHeight.cs", "Data\\Tutorials\\XtraGrid\\GridCalcRowHeight.xml");
            TutorialsInfo.Add("Card View", "DevExpress.XtraGrid.Demos.Tutorials.GridCardView",
                "This example demonstrates the CardView feature (one of the GridViews).", null,
                "GridTutorials\\GridCardView\\GridCardView.cs", "Data\\Tutorials\\XtraGrid\\GridCardView.xml");
            TutorialsInfo.Add("Column Alignment", "DevExpress.XtraGrid.Demos.Tutorials.GridColumnAlignment",
                "This example demonstrates how to change column alignment.", null,
                "GridTutorials\\GridColumnAlignment\\GridColumnAlignment.cs", "Data\\Tutorials\\XtraGrid\\GridColumnAlignment.xml");
            TutorialsInfo.Add("Column Customization", "DevExpress.XtraGrid.Demos.Tutorials.GridColumnCustomization",
                "This example demonstrates the capabilities of using Column Customization Form.", null,
                "GridTutorials\\GridColumnCustomization\\GridColumnCustomization.cs", "Data\\Tutorials\\XtraGrid\\GridColumnCustomization.xml");
            TutorialsInfo.Add("Column Format", "DevExpress.XtraGrid.Demos.Tutorials.GridColumnFormat",
                "This example illustrates how to format data within a column.", null,
                "GridTutorials\\GridColumnFormat\\GridColumnFormat.cs", "Data\\Tutorials\\XtraGrid\\GridColumnFormat.xml");
            TutorialsInfo.Add("Custom Draw", "DevExpress.XtraGrid.Demos.Tutorials.GridCustomDraw",
                "This example demonstrates how to use CustomDraw Events for a View.", null,
                "GridTutorials\\GridCustomDraw\\GridCustomDraw.cs", "Data\\Tutorials\\XtraGrid\\GridCustomDraw.xml");
            TutorialsInfo.Add("Custom Filter Dialog", "DevExpress.XtraGrid.Demos.Tutorials.GridCustomFilterDialog",
                "This example demonstrates how to use the Custom Filter Dialog, allowing you to compare fields and to customize the list of these fields.", null,
                "GridTutorials\\GridCustomFilterDialog\\GridCustomFilterDialog.cs", "Data\\Tutorials\\XtraGrid\\GridCustomFilterDialog.xml");
            TutorialsInfo.Add("Custom Menu", "DevExpress.XtraGrid.Demos.Tutorials.GridCustomMenu",
                "This example demonstrates how to create custom context menus. To invoke this menu, you should right-click the column button (red square).", null,
                "GridTutorials\\GridCustomMenu\\GridCustomMenu.cs", "Data\\Tutorials\\XtraGrid\\GridCustomMenu.xml");
            TutorialsInfo.Add("Custom Tooltips", "DevExpress.XtraGrid.Demos.Tutorials.GridCustomTooltips",
                "This example demonstrates how to use the ToolTipController to display custom information in grid elements.", null,
                "GridTutorials\\GridCustomTooltips\\GridCustomTooltips.cs", "Data\\Tutorials\\XtraGrid\\GridCustomTooltips.xml");
            TutorialsInfo.Add("Double Click Row", "DevExpress.XtraGrid.Demos.Tutorials.GridDoubleClickRow",
                "This example illustrates how to use the DoubleClick event and get information on GridRow based on the coordinates of a specific point.", null,
                "GridTutorials\\GridDoubleClickRow\\GridDoubleClickRow.cs", "Data\\Tutorials\\XtraGrid\\GridDoubleClickRow.xml");
            TutorialsInfo.Add("Drag&Drop External", "DevExpress.XtraGrid.Demos.Tutorials.GridDragDropExternal",
                "This example demonstrates how to allow end users to drag cell values or data rows to other controls. Select a cell or a row (by clicking the indicator area) and drag it to any place.", null,
                "GridTutorials\\GridDragDropExternal\\GridDragDropExternal.cs", "Data\\Tutorials\\XtraGrid\\GridDragDropExternal.xml");
            TutorialsInfo.Add("Drag&Drop Internal", "DevExpress.XtraGrid.Demos.Tutorials.GridDragDropInternal",
                "This example illustrates how to implement Drag & Drop of rows within a grid. You can move a row by simple dragging or copy it by pressing the Control key when dragging.", null,
                "GridTutorials\\GridDragDropInternal\\GridDragDropInternal.cs", "Data\\Tutorials\\XtraGrid\\GridDragDropInternal.xml");
            TutorialsInfo.Add("Draw Column Objects", "DevExpress.XtraGrid.Demos.Tutorials.GridDrawColumnObjects",
                "This example demonstrates how to draw a customized column header's sorting glyphs and filter buttons.", null,
                "GridTutorials\\GridDrawColumnObjects\\GridDrawColumnObjects.cs", "Data\\Tutorials\\XtraGrid\\GridDrawColumnObjects.xml");
            TutorialsInfo.Add("Edit Data In Popup Form", "DevExpress.XtraGrid.Demos.Tutorials.GridEditDataInPopupForm",
                "This example demonstrates how to edit grid records in a separate popup window and how to use the ButtonClick EmbeddedNavigator event (press the Append or the Edit navigator button).", null,
                "GridTutorials\\GridEditDataInPopupForm\\GridEditDataInPopupForm.cs", "Data\\Tutorials\\XtraGrid\\GridEditDataInPopupForm.xml");
            TutorialsInfo.Add("Editors (External Repository)", "DevExpress.XtraGrid.Demos.Tutorials.GridEditorsExternalRepository",
                "This example demonstrates how to create editors within a grid and assign them to the selected columns. In this demo an External repository is used.", null,
                "GridTutorials\\GridEditorsExternalRepository\\GridEditorsExternalRepository.cs", "Data\\Tutorials\\XtraGrid\\GridEditorsExternalRepository.xml");
            TutorialsInfo.Add("Editors (Internal Repository)", "DevExpress.XtraGrid.Demos.Tutorials.GridEditorsInternalRepository",
                "This example demonstrates how to create editors within a grid and assign them to the selected columns. An Internal grid editor repository is used in this demo.", null,
                "GridTutorials\\GridEditorsInternalRepository\\GridEditorsInternalRepository.cs", "Data\\Tutorials\\XtraGrid\\GridEditorsInternalRepository.xml");
            TutorialsInfo.Add("Export (updated)", "DevExpress.XtraGrid.Demos.Tutorials.GridExport",
                "This example demonstrates how to export a view's data.", null,
                "GridTutorials\\GridExport\\GridExport.cs", "Data\\Tutorials\\XtraGrid\\GridExport.xml");
            TutorialsInfo.Add("Field Auto Height", "DevExpress.XtraGrid.Demos.Tutorials.GridFieldAutoHeight",
                "This example demonstrates how to use the FieldAutoHeight property for CardView(Memo And Picture Editors) displaying.", null,
                "GridTutorials\\GridFieldAutoHeight\\GridFieldAutoHeight.cs", "Data\\Tutorials\\XtraGrid\\GridFieldAutoHeight.xml");
            TutorialsInfo.Add("Filtered View", "DevExpress.XtraGrid.Demos.Tutorials.GridFilteredView",
                "This example illustrates how to retain a bound DataView's criteria and combine it with filter settings applied by the end-user at runtime from a grid control. The filter applied to the DataView is displayed at the bottom of the form. Practice setting the filter criteria using the grid control.", null,
                "GridTutorials\\GridFilteredView\\GridFilteredView.cs", "Data\\Tutorials\\XtraGrid\\GridFilteredView.xml");
            TutorialsInfo.Add("Focused Row", "DevExpress.XtraGrid.Demos.Tutorials.GridFocusedRow",
                "This example explains how to tune the look and feel of a Selected Cell (Row).", null,
                "GridTutorials\\GridFocusedRow\\GridFocusedRow.cs", "Data\\Tutorials\\XtraGrid\\GridFocusedRow.xml");
            TutorialsInfo.Add("Group Level Style", "DevExpress.XtraGrid.Demos.Tutorials.GridGroupLevelStyle",
                "This example demonstrates how to use the GroupLevelStyle event.", null,
                "GridTutorials\\GridGroupLevelStyle\\GridGroupLevelStyle.cs", "Data\\Tutorials\\XtraGrid\\GridGroupLevelStyle.xml");
            TutorialsInfo.Add("Hit Info", "DevExpress.XtraGrid.Demos.Tutorials.GridHitInfoForm",
                "This example demonstrates how to obtain information on grid elements (such as hittest, column, bands, row, cellvalue) based on the point coordinates.", null,
                "GridTutorials\\GridHitInfo\\GridHitInfo.cs", "Data\\Tutorials\\XtraGrid\\GridHitInfo.xml");
            TutorialsInfo.Add("IBindingList", "DevExpress.XtraGrid.Demos.Tutorials.GridIBindingList",
                "This demo illustrates how to connect a Grid to an IBindingList descendant. Note that a record object must be inherited from the IEditableObject class if you need the ability to cancel newly added records via the grid.", null,
                "GridTutorials\\GridIBindingList\\GridIBindingList.cs", "Data\\Tutorials\\XtraGrid\\GridIBindingList.xml");
            TutorialsInfo.Add("Incremental Search", "DevExpress.XtraGrid.Demos.Tutorials.GridIncrementalSearch",
                "This demo shows how to use the incremental search feature.", null,
                "GridTutorials\\GridIncrementalSearch\\GridIncrementalSearch.cs", "Data\\Tutorials\\XtraGrid\\GridIncrementalSearch.xml");
            TutorialsInfo.Add("Indicator", "DevExpress.XtraGrid.Demos.Tutorials.GridIndicator",
                "This example demonstrates how to adjust the Indicator based on your specific needs.", null,
                "GridTutorials\\GridIndicator\\GridIndicator.cs", "Data\\Tutorials\\XtraGrid\\GridIndicator.xml");
            TutorialsInfo.Add("Look And Feel", "DevExpress.XtraGrid.Demos.Tutorials.GridLookAndFeel",
                "This demo demonstrates how to use the SwitchPaintStyle method of the grid control.", null,
                "GridTutorials\\GridLookAndFeel\\GridLookAndFeel.cs", "Data\\Tutorials\\XtraGrid\\GridLookAndFeel.xml");
            TutorialsInfo.Add("Multi Editors", "DevExpress.XtraGrid.Demos.Tutorials.GridMultiEditors",
                "This demo illustrates how to dynamically assign editors to individual grid cells.", null,
                "GridTutorials\\GridMultiEditors\\GridMultiEditors.cs", "Data\\Tutorials\\XtraGrid\\GridMultiEditors.xml");
            TutorialsInfo.Add("Multi Select", "DevExpress.XtraGrid.Demos.Tutorials.GridMultiSelect",
                "This example illustrates how to work with the MultiSelect feature (press shift or ctrl).", null,
                "GridTutorials\\GridMultiSelect\\GridMultiSelect.cs", "Data\\Tutorials\\XtraGrid\\GridMultiSelect.xml");
            TutorialsInfo.Add("New Item Row", "DevExpress.XtraGrid.Demos.Tutorials.GridNewItemRow",
                "This example demonstrates how to use the NewItemRow feature.", null,
                "GridTutorials\\GridNewItemRow\\GridNewItemRow.cs", "Data\\Tutorials\\XtraGrid\\GridNewItemRow.xml");
            TutorialsInfo.Add("Options", "DevExpress.XtraGrid.Demos.Tutorials.GridOptions",
                "This example explains how to enable and disable the GridOptionsView and the GridOptionsBehaviour. Please notice that in this demo we are using static methods of the DevExpress.Utils.SetOptions class.", null,
                "GridTutorials\\GridOptions\\GridOptions.cs", "Data\\Tutorials\\XtraGrid\\GridOptions.xml");
            TutorialsInfo.Add("Population", "DevExpress.XtraGrid.Demos.Tutorials.GridPopulation",
                "This example demonstrates how to populate the XtraGrid with data from a System.Data.DataTable via a System.Data.DataView.", null,
                "GridTutorials\\GridPopulation\\GridPopulation.cs", "Data\\Tutorials\\XtraGrid\\GridPopulation.xml");
            TutorialsInfo.Add("Preview", "DevExpress.XtraGrid.Demos.Tutorials.GridPreview",
                "This example demonstrates how to use the Preview feature.", null,
                "GridTutorials\\GridPreview\\GridPreview.cs", "Data\\Tutorials\\XtraGrid\\GridPreview.xml");
            TutorialsInfo.Add("Relations", "DevExpress.XtraGrid.Demos.Tutorials.GridRelations",
                "This example demonstrates how to display related tables within a grid. Please examine the InitData() method to find out how to create a master-detail relationship between tables at runtime.", null,
                "GridTutorials\\GridRelations\\GridRelations.cs", "Data\\Tutorials\\XtraGrid\\GridRelations.xml");
            TutorialsInfo.Add("Row Cell Style", "DevExpress.XtraGrid.Demos.Tutorials.GridRowCellStyle",
                "This example demonstrates how to use the RowCellStyle event.", null,
                "GridTutorials\\GridRowCellStyle\\GridRowCellStyle.cs", "Data\\Tutorials\\XtraGrid\\GridRowCellStyle.xml");
            TutorialsInfo.Add("Runtime Grouping", "DevExpress.XtraGrid.Demos.Tutorials.GridRunTimeGrouping",
                "This example explains how to work with the Grouping feature at RunTime.", null,
                "GridTutorials\\GridRuntimeGrouping\\GridRuntimeGrouping.cs", "Data\\Tutorials\\XtraGrid\\GridRuntimeGrouping.xml");
            TutorialsInfo.Add("Runtime Using", "DevExpress.XtraGrid.Demos.Tutorials.GridRunTimeUsing",
                "This example shows how to create and customize detail views at runtime. It demonstrates grid view instances creation, column/editor customization, styles setting, adding grid view instances to LevelDefaults and grid event subscription.\r\nUse the CTRL+DEL key shortcut to delete rows.", null,
                "GridTutorials\\GridRuntimeUsing\\GridRuntimeUsing.cs", "Data\\Tutorials\\XtraGrid\\GridRuntimeUsing.xml");
            TutorialsInfo.Add("Several Data Views", "DevExpress.XtraGrid.Demos.Tutorials.GridSeveralDataViewsOneDataTable",
                "This example demonstrates how to bind two grid views to the same DataTable and set them up to be viewed separately (using separate DataView objects connected to the DataTable).", null,
                "GridTutorials\\GridSeveralDataViewsOneDataTable\\GridSeveralDataViewsOneDataTable.cs", "Data\\Tutorials\\XtraGrid\\GridSeveralDataViewsOneDataTable.xml");
            TutorialsInfo.Add("Simple Mode", "DevExpress.XtraGrid.Demos.Tutorials.GridSimpleMode",
                "This example demonstrates one of the UnboundMode variants which is based on using System.Collections.CollectionBase. It gives you the ability to create different Views for the XtraGrid at RunTime. Please review the AddGridColumns() method.", null,
                "GridTutorials\\GridSimpleMode\\GridSimpleMode.cs", "Data\\Tutorials\\XtraGrid\\GridSimpleMode.xml");
            TutorialsInfo.Add("Style Condition", "DevExpress.XtraGrid.Demos.Tutorials.GridStyleCondition",
                "This example demonstrates how to work with Styles Format Conditions at RunTime.", null,
                "GridTutorials\\GridStyleCondition\\GridStyleCondition.cs", "Data\\Tutorials\\XtraGrid\\GridStyleCondition.xml");
            TutorialsInfo.Add("Style Formats", "DevExpress.XtraGrid.Demos.Tutorials.GridStyleFormats",
                "This demo illustrates how to use the DevExpress.XtraGrid.Design.XAppearances class.", null,
                "GridTutorials\\GridStyleFormats\\GridStyleFormats.cs", "Data\\Tutorials\\XtraGrid\\GridStyleFormats.xml");
            TutorialsInfo.Add("Summaries", "DevExpress.XtraGrid.Demos.Tutorials.GridSummaries",
                "This example demonstrates how to work with summaries of 3 types (footer summary, row summary, row footer summary) in an XtraGrid (grid view).", null,
                "GridTutorials\\GridSummaries\\GridSummaries.cs", "Data\\Tutorials\\XtraGrid\\GridSummaries.xml");
            TutorialsInfo.Add("Unbound Master View", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboundMasterView",
                   "This example demonstrates how to use MasterDetail for UnboundMode. The grid control can be bound to the 'NestedRecords' or 'IRelationListRecords' object. The 'NestedRecords' object is derived from the ArrayList. The 'IRelationListRecords' additionally implements the DevExpress.Data.IRelationList interface (a master level field value is used to determine which data will be displayed in the corresponding detail view).", null,
                   "GridTutorials\\GridUnboundMasterView\\GridUnboundMasterView.cs;GridTutorials\\GridUnboundMasterView\\GridUnboundMasterViewClass.cs", "Data\\Tutorials\\XtraGrid\\GridUnboundMasterView.xml");
            TutorialsInfo.Add("Unbound Master View (dynamic)", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboundMasterViewDynamic",
                "This example illustrates how to implement MasterDetail for dynamically loading detail data via MasterRow~ events. This allows you to fully control which data and when should be loaded and how it should be represented.", null,
                "GridTutorials\\GridUnboundMasterViewDynamic\\GridUnboundMasterViewDynamic.cs", "Data\\Tutorials\\XtraGrid\\GridUnboundMasterViewDynamic.xml");
            TutorialsInfo.Add("Unbound Mode (collection)", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboundModeViaCollection",
                "This example demonstrates one of the UnboundMode variants which is based on using a Collection as a data source.", null,
                "GridTutorials\\GridUnboundModeViaCollection\\GridUnboundModeViaCollection.cs", "Data\\Tutorials\\XtraGrid\\GridUnboundModeViaCollection.xml");
            TutorialsInfo.Add("Unbound Mode (data table)", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboundModeViaDataTable",
                "This example demonstrates one of the UnboundMode variants which is based on using a DataTable. Please look at the InitGridColumns() method.", null,
                "GridTutorials\\GridUnboundModeViaDataTable\\GridUnboundModeViaDataTable.cs", "Data\\Tutorials\\XtraGrid\\GridUnboundModeViaDataTable.xml");
            TutorialsInfo.Add("Validating Control", "DevExpress.XtraGrid.Demos.Tutorials.GridValidatingControl",
                "This example demonstrates how to use the Validating and ValidateRow events for editing grid records (when editing a record where Discontinued = true, a warning is raised and the grid remains focused when shifting focus to another control).", null,
                "GridTutorials\\GridValidatingControl\\GridValidatingControl.cs", "Data\\Tutorials\\XtraGrid\\GridValidatingControl.xml");
            TutorialsInfo.Add("Vertical Headers", "DevExpress.XtraGrid.Demos.Tutorials.GridVerticalHeaders",
                "This example demonstrates how to draw vertical captions within the header panel.", null,
                "GridTutorials\\GridVerticalHeaders\\GridVerticalHeaders.cs", "Data\\Tutorials\\XtraGrid\\GridVerticalHeaders.xml");
            TutorialsInfo.Add("Virtual Data", "DevExpress.XtraGrid.Demos.Tutorials.GridVirtualData",
                "This example demonstrates how to implement virtual mode in an XtraGrid.", null,
                "GridTutorials\\GridVirtualData\\GridVirtualData.cs", "Data\\Tutorials\\XtraGrid\\GridVirtualData.xml");
            TutorialsInfo.Add("Virtual Data (dynamic)", "DevExpress.XtraGrid.Demos.Tutorials.GridVirtualDataDynamic",
                "This example demonstrates how to implement dynamic virtual mode in an XtraGrid. (Moving focus to the last row/column results in adding a new row/column).", null,
                "GridTutorials\\GridVirtualDataDynamic\\GridVirtualDataDynamic.cs", "Data\\Tutorials\\XtraGrid\\GridVirtualDataDynamic.xml");
            TutorialsInfo.Add("XML Reader", "DevExpress.XtraGrid.Demos.Tutorials.GridXMLReader",
                "This example illustrates how to obtain data from an XML table and display it within an XtraGrid (including a Master Detail variant).", null,
                "GridTutorials\\GridXMLReader\\GridXMLReader.cs", "Data\\Tutorials\\XtraGrid\\GridXMLReader.xml");

            TutorialsInfo.Add("Skins", "DevExpress.XtraGrid.Demos.Tutorials.GridSkins",
                "This demo demonstrates how to apply skins to the grid control.", null,
                "GridTutorials\\GridSkins\\GridSkins.cs", "Data\\Tutorials\\XtraGrid\\GridSkins.xml");
            TutorialsInfo.Add("Unbound Columns", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboundColumns",
                "This example demonstrates how to use the columns which are not bound to any field in the grid's data source.", null,
                "GridTutorials\\GridUnboundColumns\\GridUnboundColumns.cs", "Data\\Tutorials\\XtraGrid\\GridUnboundColumns.xml");
            TutorialsInfo.Add("Realtime Updating", "DevExpress.XtraGrid.Demos.Tutorials.GridRealTime",
                "This demo demonstrates the XtraGrid's ability to display information which is changed in realtime.", null,
                "GridTutorials\\GridRealTime\\GridRealTime.cs", "Data\\Tutorials\\XtraGrid\\GridRealTime.xml");

            TutorialsInfo.Add("Error Notification", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboundErrorNotification",
                "This demo shows how to implement error notifications for runtime created data. Error icons are displayed for cells and rows containing invalid dates. Data is checked when rows are validated.", null,
                "GridTutorials\\GridUnboundErrorNotification\\GridUnboundErrorNotification.cs", "Data\\Tutorials\\XtraGrid\\GridUnboundErrorNotification.xml");

            TutorialsInfo.Add("Error Notification Advanced", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboudErrorNotificationNew",
                "This demo shows how to implement support for extended error notification on the data source level. A business object in the example implements the IDXDataErrorInfo interface, which enables you to indicate errors to end-users using various error icons.", null,
                "GridTutorials\\GridUnboundErrorNotificationAdv\\GridUnboundErrorNotificationClassAdv.cs", "Data\\Tutorials\\XtraGrid\\GridUnboundErrorNotificationAdv.xml");
            
            TutorialsInfo.Add("Editor Show Mode", "DevExpress.XtraGrid.Demos.Tutorials.GridEditorShowMode",
                "This demo demonstrates how to specify the end-user action that invokes cell editors and which cells should display editor buttons.", null,
                "GridTutorials\\GridEditorShowMode\\GridEditorShowMode.cs", "Data\\Tutorials\\XtraGrid\\GridEditorShowMode.xml");
            TutorialsInfo.Add("Row Filter Event", "DevExpress.XtraGrid.Demos.Tutorials.GridRowFilterEvent",
                "This demo demonstrated how to manually filter rows within the view. For this purpose, the CustomRowFilter event is handled. The check boxes allow you to specify which rows should be filtered (hidden).", null,
                "GridTutorials\\GridRowFilterEvent\\GridRowFilterEvent.cs", "Data\\Tutorials\\XtraGrid\\GridRowFilterEvent.xml");
            TutorialsInfo.Add("Master-Detail", "DevExpress.XtraGrid.Demos.Tutorials.GridMasterDetail",
                "In this demo the grid control is customized at design time to present master-detail data. This demo also demonstrates controlling the visibility of detail buttons, tooltips and detail tabs.", null,
                "GridTutorials\\GridMasterDetail\\GridMasterDetail.cs", "Data\\Tutorials\\XtraGrid\\GridMasterDetail.xml");
            TutorialsInfo.Add("Filter Popup Date", "DevExpress.XtraGrid.Demos.Tutorials.GridFilterPopupDate",
                "This tutorial demonstrates the Filtering via Calendar feature, introduced in MS Vista, that allows quick and easy filtering against date-time columns.\r\nWith this feature enabled, the filter dropdown contains an embedded calendar and check boxes, that allow selecting commonly used date intervals: Today, Yesterday, Earlier this Week, etc. This provides an intuitive, on-the-fly way of picking up dates to create a filter.\r\nThere are three display modes that support the new filtering feature: DateSmart, DateAlt and Date. In all these modes, you can customize the filter dropdown via an event.", null,
                "GridTutorials\\GridFilterPopupDate\\GridFilterPopupDate.cs", "Data\\Tutorials\\XtraGrid\\GridFilterPopupDate.xml");
            TutorialsInfo.Add(RegisterTutorials.NewFeaturesString, "DevExpress.XtraGrid.Demos.Tutorials.About");
        }
    }
}

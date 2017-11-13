Imports Microsoft.VisualBasic
Imports System
Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Class TutorialsInfo
		Inherits DevExpress.DXperience.Demos.ModulesInfo
        Private Const languageDir As String = "VB\"

		Private Shared Function GetBaseViewByControl(ByVal control As Control) As BaseView
			If control Is Nothing Then
			Return Nothing
			End If
			For Each cntl As Control In control.Controls
				If TypeOf cntl Is GridControl Then
					Return (CType(cntl, GridControl)).MainView
				End If
			Next cntl
			Return Nothing
		End Function

		Public Shared Sub CloseCustomizationForm(ByVal control As Control)
			Dim view As BaseView = GetBaseViewByControl(control)
			If TypeOf view Is GridView Then
				CType(view, GridView).DestroyCustomization()
			End If
		End Sub

        Public Overloads Shared Function ShowModule(ByVal name As String, ByVal groupControl As DevExpress.XtraEditors.GroupControl, ByVal menu As DevExpress.DXperience.Demos.LookAndFeelMenu, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel) As DevExpress.Tutorials.ModuleBase
            Dim item As ModuleInfo = TutorialsInfo.GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            groupControl.Parent.SuspendLayout()
            groupControl.SuspendLayout()
            Try
                Dim oldTutorial As Control = Nothing
                If Not Instance.CurrentModuleBase Is Nothing Then
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If

                Dim tutorial As TutorialControl = TryCast(item.TModule, TutorialControl)
                tutorial.Bounds = groupControl.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                groupControl.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill

                CloseCustomizationForm(oldTutorial)

                If tutorial.ShowLookAndFeel Then
                    menu.InitLookAndFeelMenu(lookAndFeel)
                Else
                    menu.InitLookAndFeelMenu(Nothing)
                End If

                tutorial.AddMenuManager(menu.MainMenu.Manager)
                tutorial.Visible = True
                If Not oldTutorial Is Nothing Then
                    oldTutorial.Visible = False
                End If
            Finally
                groupControl.ResumeLayout(True)
                groupControl.Parent.ResumeLayout(True)
                Cursor.Current = currentCursor
            End Try
            RaiseModuleChanged()
            Dim [module] As DevExpress.Tutorials.ModuleBase = TryCast(Instance.CurrentModuleBase.TModule, DevExpress.Tutorials.ModuleBase)
            If Not [module] Is Nothing Then
                [module].TutorialInfo.Description = Instance.CurrentModuleBase.Description
                [module].TutorialInfo.TutorialName = Instance.CurrentModuleBase.Name
                [module].TutorialInfo.WhatsThisCodeFile = Instance.CurrentModuleBase.CodeFile
                [module].TutorialInfo.WhatsThisXMLFile = Instance.CurrentModuleBase.XMLFile
                Dim xmlFile As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, [module].TutorialInfo.WhatsThisXMLFile, False)
                Dim codeFile As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, [module].TutorialInfo.WhatsThisCodeFile, False)
                If xmlFile = "" Then
                    [module].TutorialInfo.WhatsThisXMLFile = DemoHelper.StringComposite([module].TutorialInfo.WhatsThisXMLFile, languageDir)
                End If
                If codeFile = "" Then
                    [module].TutorialInfo.WhatsThisCodeFile = DemoHelper.StringComposite([module].TutorialInfo.WhatsThisCodeFile, languageDir)
                End If
            End If
            Return [module]
        End Function
	End Class
	Friend Class RegisterTutorials
        Friend Shared NewFeaturesString As String = "DevExpress XtraGrid " & AssemblyInfo.MarketingVersion
		Public Shared Sub Register()
            TutorialsInfo.Add("Add New Row (Grouped Mode)", "DevExpress.XtraGrid.Demos.Tutorials.GridAddNewRowInGroupedMode", "This example demonstrates how to add a new row to a certain group when working with grouped data.", Nothing, "GridTutorials\GridAddNewRowInGroupedMode\GridAddNewRowInGroupedMode.vb", "Data\Tutorials\XtraGrid\GridAddNewRowInGroupedMode.xml")
            TutorialsInfo.Add("Alpha Blending", "DevExpress.XtraGrid.Demos.Tutorials.GridAlphaBlending", "This example demonstrates how to adjust the Alpha Blending feature of the XtraGrid using the XtraGridBlending component.", Nothing, "GridTutorials\GridAlphaBlending\GridAlphaBlending.vb", "Data\Tutorials\XtraGrid\GridAlphaBlending.xml")
            TutorialsInfo.Add("Control Navigator", "DevExpress.XtraGrid.Demos.Tutorials.GridAndControlNavigator", "This demo shows how to use the embedded and external control navigators. To hide the embedded navigator and show the external one, please uncheck the Use Embedded Navigator box.", Nothing, "GridTutorials\GridAndControlNavigator\GridAndControlNavigator.vb", "Data\Tutorials\XtraGrid\GridAndControlNavigator.xml")
            TutorialsInfo.Add("Banded View Navigation", "DevExpress.XtraGrid.Demos.Tutorials.GridBandedViewNavigation", "This demo illustrates different keyboard navigation types available in the banded view. Please play with the check edits and try to navigate the grid using the keyboard to see the difference.", Nothing, "GridTutorials\GridBandedViewNavigation\GridBandedViewNavigation.vb", "Data\Tutorials\XtraGrid\GridBandedViewNavigation.xml")
            TutorialsInfo.Add("Calc Row Height", "DevExpress.XtraGrid.Demos.Tutorials.GridCalcRowHeight", "This example demonstrates how to use the CalcRowHeight event and the OptionsView.RowAutoHeight option.", Nothing, "GridTutorials\GridCalcRowHeight\GridCalcRowHeight.vb", "Data\Tutorials\XtraGrid\GridCalcRowHeight.xml")
            TutorialsInfo.Add("Card View", "DevExpress.XtraGrid.Demos.Tutorials.GridCardView", "This example demonstrates the CardView feature (one of the GridViews).", Nothing, "GridTutorials\GridCardView\GridCardView.vb", "Data\Tutorials\XtraGrid\GridCardView.xml")
            TutorialsInfo.Add("Column Alignment", "DevExpress.XtraGrid.Demos.Tutorials.GridColumnAlignment", "This example demonstrates how to change column alignment.", Nothing, "GridTutorials\GridColumnAlignment\GridColumnAlignment.vb", "Data\Tutorials\XtraGrid\GridColumnAlignment.xml")
            TutorialsInfo.Add("Column Customization", "DevExpress.XtraGrid.Demos.Tutorials.GridColumnCustomization", "This example demonstrates the capabilities of using Column Customization Form.", Nothing, "GridTutorials\GridColumnCustomization\GridColumnCustomization.vb", "Data\Tutorials\XtraGrid\GridColumnCustomization.xml")
            TutorialsInfo.Add("Column Format", "DevExpress.XtraGrid.Demos.Tutorials.GridColumnFormat", "This example illustrates how to format data within a column.", Nothing, "GridTutorials\GridColumnFormat\GridColumnFormat.vb", "Data\Tutorials\XtraGrid\GridColumnFormat.xml")
            TutorialsInfo.Add("Custom Draw", "DevExpress.XtraGrid.Demos.Tutorials.GridCustomDraw", "This example demonstrates how to use CustomDraw Events for a View.", Nothing, "GridTutorials\GridCustomDraw\GridCustomDraw.vb", "Data\Tutorials\XtraGrid\GridCustomDraw.xml")
            TutorialsInfo.Add("Custom Filter Dialog", "DevExpress.XtraGrid.Demos.Tutorials.GridCustomFilterDialog", "This example demonstrates how to use the Custom Filter Dialog, allowing you to compare fields and to customize the list of these fields.", Nothing, "GridTutorials\GridCustomFilterDialog\GridCustomFilterDialog.vb", "Data\Tutorials\XtraGrid\GridCustomFilterDialog.xml")
            TutorialsInfo.Add("Custom Menu", "DevExpress.XtraGrid.Demos.Tutorials.GridCustomMenu", "This example demonstrates how to create custom context menus. To invoke this menu, you should right-click the column button (red square).", Nothing, "GridTutorials\GridCustomMenu\GridCustomMenu.vb", "Data\Tutorials\XtraGrid\GridCustomMenu.xml")
            TutorialsInfo.Add("Custom Tooltips", "DevExpress.XtraGrid.Demos.Tutorials.GridCustomTooltips", "This example demonstrates how to use the ToolTipController to display custom information in grid elements.", Nothing, "GridTutorials\GridCustomTooltips\GridCustomTooltips.vb", "Data\Tutorials\XtraGrid\GridCustomTooltips.xml")
            TutorialsInfo.Add("Double Click Row", "DevExpress.XtraGrid.Demos.Tutorials.GridDoubleClickRow", "This example illustrates how to use the DoubleClick event and get information on GridRow based on the coordinates of a specific point.", Nothing, "GridTutorials\GridDoubleClickRow\GridDoubleClickRow.vb", "Data\Tutorials\XtraGrid\GridDoubleClickRow.xml")
            TutorialsInfo.Add("Drag&Drop External", "DevExpress.XtraGrid.Demos.Tutorials.GridDragDropExternal", "This example demonstrates how to allow end users to drag cell values or data rows to other controls. Select a cell or a row (by clicking the indicator area) and drag it to any place.", Nothing, "GridTutorials\GridDragDropExternal\GridDragDropExternal.vb", "Data\Tutorials\XtraGrid\GridDragDropExternal.xml")
            TutorialsInfo.Add("Drag&Drop Internal", "DevExpress.XtraGrid.Demos.Tutorials.GridDragDropInternal", "This example illustrates how to implement Drag & Drop of rows within a grid. You can move a row by simple dragging or copy it by pressing the Control key when dragging.", Nothing, "GridTutorials\GridDragDropInternal\GridDragDropInternal.vb", "Data\Tutorials\XtraGrid\GridDragDropInternal.xml")
            TutorialsInfo.Add("Draw Column Objects", "DevExpress.XtraGrid.Demos.Tutorials.GridDrawColumnObjects", "This example demonstrates how to draw a customized column header's sorting glyphs and filter buttons.", Nothing, "GridTutorials\GridDrawColumnObjects\GridDrawColumnObjects.vb", "Data\Tutorials\XtraGrid\GridDrawColumnObjects.xml")
            TutorialsInfo.Add("Edit Data In Popup Form", "DevExpress.XtraGrid.Demos.Tutorials.GridEditDataInPopupForm", "This example demonstrates how to edit grid records in a separate popup window and how to use the ButtonClick EmbeddedNavigator event (press the Append or the Edit navigator button).", Nothing, "GridTutorials\GridEditDataInPopupForm\GridEditDataInPopupForm.vb", "Data\Tutorials\XtraGrid\GridEditDataInPopupForm.xml")
            TutorialsInfo.Add("Editors (External Repository)", "DevExpress.XtraGrid.Demos.Tutorials.GridEditorsExternalRepository", "This example demonstrates how to create editors within a grid and assign them to the selected columns. In this demo an External repository is used.", Nothing, "GridTutorials\GridEditorsExternalRepository\GridEditorsExternalRepository.vb", "Data\Tutorials\XtraGrid\GridEditorsExternalRepository.xml")
            TutorialsInfo.Add("Editors (Internal Repository)", "DevExpress.XtraGrid.Demos.Tutorials.GridEditorsInternalRepository", "This example demonstrates how to create editors within a grid and assign them to the selected columns. An Internal grid editor repository is used in this demo.", Nothing, "GridTutorials\GridEditorsInternalRepository\GridEditorsInternalRepository.vb", "Data\Tutorials\XtraGrid\GridEditorsInternalRepository.xml")
            TutorialsInfo.Add("Export (updated)", "DevExpress.XtraGrid.Demos.Tutorials.GridExport", "This example demonstrates how to export a view's data.", Nothing, "GridTutorials\GridExport\GridExport.vb", "Data\Tutorials\XtraGrid\GridExport.xml")
            TutorialsInfo.Add("Field Auto Height", "DevExpress.XtraGrid.Demos.Tutorials.GridFieldAutoHeight", "This example demonstrates how to use the FieldAutoHeight property for CardView(Memo And Picture Editors) displaying.", Nothing, "GridTutorials\GridFieldAutoHeight\GridFieldAutoHeight.vb", "Data\Tutorials\XtraGrid\GridFieldAutoHeight.xml")
            TutorialsInfo.Add("Filtered View", "DevExpress.XtraGrid.Demos.Tutorials.GridFilteredView", "This example illustrates how to retain a bound DataView's criteria and combine it with filter settings applied by the end-user at runtime from a grid control. The filter applied to the DataView is displayed at the bottom of the form. Practice setting the filter criteria using the grid control.", Nothing, "GridTutorials\GridFilteredView\GridFilteredView.vb", "Data\Tutorials\XtraGrid\GridFilteredView.xml")
            TutorialsInfo.Add("Focused Row", "DevExpress.XtraGrid.Demos.Tutorials.GridFocusedRow", "This example explains how to tune the look and feel of a Selected Cell (Row).", Nothing, "GridTutorials\GridFocusedRow\GridFocusedRow.vb", "Data\Tutorials\XtraGrid\GridFocusedRow.xml")
            TutorialsInfo.Add("Group Level Style", "DevExpress.XtraGrid.Demos.Tutorials.GridGroupLevelStyle", "This example demonstrates how to use the GroupLevelStyle event.", Nothing, "GridTutorials\GridGroupLevelStyle\GridGroupLevelStyle.vb", "Data\Tutorials\XtraGrid\GridGroupLevelStyle.xml")
            TutorialsInfo.Add("Hit Info", "DevExpress.XtraGrid.Demos.Tutorials.GridHitInfoForm", "This example demonstrates how to obtain information on grid elements (such as hittest, column, bands, row, cellvalue) based on the point coordinates.", Nothing, "GridTutorials\GridHitInfo\GridHitInfo.vb", "Data\Tutorials\XtraGrid\GridHitInfo.xml")
            TutorialsInfo.Add("IBindingList", "DevExpress.XtraGrid.Demos.Tutorials.GridIBindingList", "This demo illustrates how to connect a Grid to an IBindingList descendant. Note that a record object must be inherited from the IEditableObject class if you need the ability to cancel newly added records via the grid.", Nothing, "GridTutorials\GridIBindingList\GridIBindingList.vb", "Data\Tutorials\XtraGrid\GridIBindingList.xml")
            TutorialsInfo.Add("Incremental Search", "DevExpress.XtraGrid.Demos.Tutorials.GridIncrementalSearch", "This demo shows how to use the incremental search feature.", Nothing, "GridTutorials\GridIncrementalSearch\GridIncrementalSearch.vb", "Data\Tutorials\XtraGrid\GridIncrementalSearch.xml")
            TutorialsInfo.Add("Indicator", "DevExpress.XtraGrid.Demos.Tutorials.GridIndicator", "This example demonstrates how to adjust the Indicator based on your specific needs.", Nothing, "GridTutorials\GridIndicator\GridIndicator.vb", "Data\Tutorials\XtraGrid\GridIndicator.xml")
            TutorialsInfo.Add("Look And Feel", "DevExpress.XtraGrid.Demos.Tutorials.GridLookAndFeel", "This demo demonstrates how to use the SwitchPaintStyle method of the grid control.", Nothing, "GridTutorials\GridLookAndFeel\GridLookAndFeel.vb", "Data\Tutorials\XtraGrid\GridLookAndFeel.xml")
            TutorialsInfo.Add("Multi Editors", "DevExpress.XtraGrid.Demos.Tutorials.GridMultiEditors", "This demo illustrates how to dynamically assign editors to individual grid cells.", Nothing, "GridTutorials\GridMultiEditors\GridMultiEditors.vb", "Data\Tutorials\XtraGrid\GridMultiEditors.xml")
            TutorialsInfo.Add("Multi Select", "DevExpress.XtraGrid.Demos.Tutorials.GridMultiSelect", "This example illustrates how to work with the MultiSelect feature (press shift or ctrl).", Nothing, "GridTutorials\GridMultiSelect\GridMultiSelect.vb", "Data\Tutorials\XtraGrid\GridMultiSelect.xml")
            TutorialsInfo.Add("New Item Row", "DevExpress.XtraGrid.Demos.Tutorials.GridNewItemRow", "This example demonstrates how to use the NewItemRow feature.", Nothing, "GridTutorials\GridNewItemRow\GridNewItemRow.vb", "Data\Tutorials\XtraGrid\GridNewItemRow.xml")
            TutorialsInfo.Add("Options", "DevExpress.XtraGrid.Demos.Tutorials.GridOptions", "This example explains how to enable and disable the GridOptionsView and the GridOptionsBehaviour. Please notice that in this demo we are using static methods of the DevExpress.Utils.SetOptions class.", Nothing, "GridTutorials\GridOptions\GridOptions.vb", "Data\Tutorials\XtraGrid\GridOptions.xml")
            TutorialsInfo.Add("Population", "DevExpress.XtraGrid.Demos.Tutorials.GridPopulation", "This example demonstrates how to populate the XtraGrid with data from a System.Data.DataTable via a System.Data.DataView.", Nothing, "GridTutorials\GridPopulation\GridPopulation.vb", "Data\Tutorials\XtraGrid\GridPopulation.xml")
            TutorialsInfo.Add("Preview", "DevExpress.XtraGrid.Demos.Tutorials.GridPreview", "This example demonstrates how to use the Preview feature.", Nothing, "GridTutorials\GridPreview\GridPreview.vb", "Data\Tutorials\XtraGrid\GridPreview.xml")
            TutorialsInfo.Add("Relations", "DevExpress.XtraGrid.Demos.Tutorials.GridRelations", "This example demonstrates how to display related tables within a grid. Please examine the InitData() method to find out how to create a master-detail relationship between tables at runtime.", Nothing, "GridTutorials\GridRelations\GridRelations.vb", "Data\Tutorials\XtraGrid\GridRelations.xml")
            TutorialsInfo.Add("Row Cell Style", "DevExpress.XtraGrid.Demos.Tutorials.GridRowCellStyle", "This example demonstrates how to use the RowCellStyle event.", Nothing, "GridTutorials\GridRowCellStyle\GridRowCellStyle.vb", "Data\Tutorials\XtraGrid\GridRowCellStyle.xml")
            TutorialsInfo.Add("Runtime Grouping", "DevExpress.XtraGrid.Demos.Tutorials.GridRunTimeGrouping", "This example explains how to work with the Grouping feature at RunTime.", Nothing, "GridTutorials\GridRuntimeGrouping\GridRuntimeGrouping.vb", "Data\Tutorials\XtraGrid\GridRuntimeGrouping.xml")
            TutorialsInfo.Add("Runtime Using", "DevExpress.XtraGrid.Demos.Tutorials.GridRunTimeUsing", "This example shows how to create and customize detail views at runtime. It demonstrates grid view instances creation, column/editor customization, styles setting, adding grid view instances to LevelDefaults and grid event subscription." & Constants.vbCrLf & "Use the CTRL+DEL key shortcut to delete rows.", Nothing, "GridTutorials\GridRuntimeUsing\GridRuntimeUsing.vb", "Data\Tutorials\XtraGrid\GridRuntimeUsing.xml")
            TutorialsInfo.Add("Several Data Views", "DevExpress.XtraGrid.Demos.Tutorials.GridSeveralDataViewsOneDataTable", "This example demonstrates how to bind two grid views to the same DataTable and set them up to be viewed separately (using separate DataView objects connected to the DataTable).", Nothing, "GridTutorials\GridSeveralDataViewsOneDataTable\GridSeveralDataViewsOneDataTable.vb", "Data\Tutorials\XtraGrid\GridSeveralDataViewsOneDataTable.xml")
            TutorialsInfo.Add("Simple Mode", "DevExpress.XtraGrid.Demos.Tutorials.GridSimpleMode", "This example demonstrates one of the UnboundMode variants which is based on using System.Collections.CollectionBase. It gives you the ability to create different Views for the XtraGrid at RunTime. Please review the AddGridColumns() method.", Nothing, "GridTutorials\GridSimpleMode\GridSimpleMode.vb", "Data\Tutorials\XtraGrid\GridSimpleMode.xml")
            TutorialsInfo.Add("Style Condition", "DevExpress.XtraGrid.Demos.Tutorials.GridStyleCondition", "This example demonstrates how to work with Styles Format Conditions at RunTime.", Nothing, "GridTutorials\GridStyleCondition\GridStyleCondition.vb", "Data\Tutorials\XtraGrid\GridStyleCondition.xml")
            TutorialsInfo.Add("Style Formats", "DevExpress.XtraGrid.Demos.Tutorials.GridStyleFormats", "This demo illustrates how to use the DevExpress.XtraGrid.Design.XAppearances class.", Nothing, "GridTutorials\GridStyleFormats\GridStyleFormats.vb", "Data\Tutorials\XtraGrid\GridStyleFormats.xml")
            TutorialsInfo.Add("Summaries", "DevExpress.XtraGrid.Demos.Tutorials.GridSummaries", "This example demonstrates how to work with summaries of 3 types (footer summary, row summary, row footer summary) in an XtraGrid (grid view).", Nothing, "GridTutorials\GridSummaries\GridSummaries.vb", "Data\Tutorials\XtraGrid\GridSummaries.xml")
            TutorialsInfo.Add("Unbound Master View", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboundMasterView", "This example demonstrates how to use MasterDetail for UnboundMode. The grid control can be bound to the 'NestedRecords' or 'IRelationListRecords' object. The 'NestedRecords' object is derived from the ArrayList. The 'IRelationListRecords' additionally implements the DevExpress.Data.IRelationList interface (a master level field value is used to determine which data will be displayed in the corresponding detail view).", Nothing, "GridTutorials\GridUnboundMasterView\GridUnboundM.vberView.cs;GridTutorials\GridUnboundMasterView\GridUnboundMasterViewClass.vb", "Data\Tutorials\XtraGrid\GridUnboundMasterView.xml")
            TutorialsInfo.Add("Unbound Master View (dynamic)", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboundMasterViewDynamic", "This example illustrates how to implement MasterDetail for dynamically loading detail data via MasterRow~ events. This allows you to fully control which data and when should be loaded and how it should be represented.", Nothing, "GridTutorials\GridUnboundMasterViewDynamic\GridUnboundMasterViewDynamic.vb", "Data\Tutorials\XtraGrid\GridUnboundMasterViewDynamic.xml")
            TutorialsInfo.Add("Unbound Mode (collection)", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboundModeViaCollection", "This example demonstrates one of the UnboundMode variants which is based on using a Collection as a data source.", Nothing, "GridTutorials\GridUnboundModeViaCollection\GridUnboundModeViaCollection.vb", "Data\Tutorials\XtraGrid\GridUnboundModeViaCollection.xml")
            TutorialsInfo.Add("Unbound Mode (data table)", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboundModeViaDataTable", "This example demonstrates one of the UnboundMode variants which is based on using a DataTable. Please look at the InitGridColumns() method.", Nothing, "GridTutorials\GridUnboundModeViaDataTable\GridUnboundModeViaDataTable.vb", "Data\Tutorials\XtraGrid\GridUnboundModeViaDataTable.xml")
            TutorialsInfo.Add("Validating Control", "DevExpress.XtraGrid.Demos.Tutorials.GridValidatingControl", "This example demonstrates how to use the Validating and ValidateRow events for editing grid records (when editing a record where Discontinued = true, a warning is raised and the grid remains focused when shifting focus to another control).", Nothing, "GridTutorials\GridValidatingControl\GridValidatingControl.vb", "Data\Tutorials\XtraGrid\GridValidatingControl.xml")
            TutorialsInfo.Add("Vertical Headers", "DevExpress.XtraGrid.Demos.Tutorials.GridVerticalHeaders", "This example demonstrates how to draw vertical captions within the header panel.", Nothing, "GridTutorials\GridVerticalHeaders\GridVerticalHeaders.vb", "Data\Tutorials\XtraGrid\GridVerticalHeaders.xml")
            TutorialsInfo.Add("Virtual Data", "DevExpress.XtraGrid.Demos.Tutorials.GridVirtualData", "This example demonstrates how to implement virtual mode in an XtraGrid.", Nothing, "GridTutorials\GridVirtualData\GridVirtualData.vb", "Data\Tutorials\XtraGrid\GridVirtualData.xml")
            TutorialsInfo.Add("Virtual Data (dynamic)", "DevExpress.XtraGrid.Demos.Tutorials.GridVirtualDataDynamic", "This example demonstrates how to implement dynamic virtual mode in an XtraGrid. (Moving focus to the last row/column results in adding a new row/column).", Nothing, "GridTutorials\GridVirtualDataDynamic\GridVirtualDataDynamic.vb", "Data\Tutorials\XtraGrid\GridVirtualDataDynamic.xml")
            TutorialsInfo.Add("XML Reader", "DevExpress.XtraGrid.Demos.Tutorials.GridXMLReader", "This example illustrates how to obtain data from an XML table and display it within an XtraGrid (including a Master Detail variant).", Nothing, "GridTutorials\GridXMLReader\GridXMLReader.vb", "Data\Tutorials\XtraGrid\GridXMLReader.xml")

            TutorialsInfo.Add("Skins", "DevExpress.XtraGrid.Demos.Tutorials.GridSkins", "This demo demonstrates how to apply skins to the grid control.", Nothing, "GridTutorials\GridSkins\GridSkins.vb", "Data\Tutorials\XtraGrid\GridSkins.xml")
            TutorialsInfo.Add("Unbound Columns", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboundColumns", "This example demonstrates how to use the columns which are not bound to any field in the grid's data source.", Nothing, "GridTutorials\GridUnboundColumns\GridUnboundColumns.vb", "Data\Tutorials\XtraGrid\GridUnboundColumns.xml")
            TutorialsInfo.Add("Realtime Updating", "DevExpress.XtraGrid.Demos.Tutorials.GridRealTime", "This demo demonstrates the XtraGrid's ability to display information which is changed in realtime.", Nothing, "GridTutorials\GridRealTime\GridRealTime.vb", "Data\Tutorials\XtraGrid\GridRealTime.xml")

            TutorialsInfo.Add("Error Notification", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboundErrorNotification", "This demo shows how to implement error notifications for runtime created data. Error icons are displayed for cells and rows containing invalid dates. Data is checked when rows are validated.", Nothing, "GridTutorials\GridUnboundErrorNotification\GridUnboundErrorNotification.vb", "Data\Tutorials\XtraGrid\GridUnboundErrorNotification.xml")
            TutorialsInfo.Add("Error Notification Advanced", "DevExpress.XtraGrid.Demos.Tutorials.GridUnboudErrorNotificationNew", "This demo shows how to implement support for extended error notification on the data source level. A business object in the example implements the IDXDataErrorInfo interface, which enables you to indicate errors to end-users using various error icons.", Nothing, "GridTutorials\GridUnboundErrorNotificationAdv\GridUnboundErrorNotificationClassAdv.vb", "Data\Tutorials\XtraGrid\GridUnboundErrorNotificationAdv.xml")

            TutorialsInfo.Add("Editor Show Mode", "DevExpress.XtraGrid.Demos.Tutorials.GridEditorShowMode", "This demo demonstrates how to specify the end-user action that invokes cell editors and which cells should display editor buttons.", Nothing, "GridTutorials\GridEditorShowMode\GridEditorShowMode.vb", "Data\Tutorials\XtraGrid\GridEditorShowMode.xml")
            TutorialsInfo.Add("Row Filter Event", "DevExpress.XtraGrid.Demos.Tutorials.GridRowFilterEvent", "This demo demonstrated how to manually filter rows within the view. For this purpose, the CustomRowFilter event is handled. The check boxes allow you to specify which rows should be filtered (hidden).", Nothing, "GridTutorials\GridRowFilterEvent\GridRowFilterEvent.vb", "Data\Tutorials\XtraGrid\GridRowFilterEvent.xml")
            TutorialsInfo.Add("Master-Detail", "DevExpress.XtraGrid.Demos.Tutorials.GridMasterDetail", "In this demo the grid control is customized at design time to present master-detail data. This demo also demonstrates controlling the visibility of detail buttons, tooltips and detail tabs.", Nothing, "GridTutorials\GridMasterDetail\GridMasterDetail.vb", "Data\Tutorials\XtraGrid\GridMasterDetail.xml")
            TutorialsInfo.Add("Filter Popup Date", "DevExpress.XtraGrid.Demos.Tutorials.GridFilterPopupDate", "This tutorial demonstrates the Filtering via Calendar feature, introduced in MS Vista, that allows quick and easy filtering against date-time columns." & Constants.vbCrLf & "With this feature enabled, the filter dropdown contains an embedded calendar and check boxes, that allow selecting commonly used date intervals: Today, Yesterday, Earlier this Week, etc. This provides an intuitive, on-the-fly way of picking up dates to create a filter." & Constants.vbCrLf & "There are three display modes that support the new filtering feature: DateSmart, DateAlt and Date. In all these modes, you can customize the filter dropdown via an event.", Nothing, "GridTutorials\GridFilterPopupDate\GridFilterPopupDate.cs", "Data\Tutorials\XtraGrid\GridFilterPopupDate.xml")
            TutorialsInfo.Add(RegisterTutorials.NewFeaturesString, "DevExpress.XtraGrid.Demos.Tutorials.About")
		End Sub
	End Class
End Namespace

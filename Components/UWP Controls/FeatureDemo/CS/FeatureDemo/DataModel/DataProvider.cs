using System.Collections.Generic;
using DevExpress.Mvvm.Native;

namespace FeatureDemo.DataModel {
    public class DemoModule {
        public IEnumerable<string> Sources { get; set; }

        public string ViewTypeName { get; set; }
        public string Title { get; set; }
        public string About { get; set; }
        public string Description { get; set; }
        public bool IsHighlighted { get; set; }
        public bool IsNew { get; set; }
        public bool IsUpdated { get; set; }
        public string FullImagePath { get { return "ms-appx:///Images/Modules/" + ViewTypeName + ".png"; } }
        public DemoModule(string viewTypeName, string title, string about, string description = null) {
            ViewTypeName = viewTypeName;
            Title = title;
            About = about;
            Description = description ?? about;
        }
    }

    public class DemoModuleGroup {
        public string Name { get; private set; }
        public string Title { get; private set; }
        public string Icon { get; private set; }
        public List<DemoModule> DemoModules { get; private set; }
        public DemoModuleGroup(string name, string title, string icon, List<DemoModule> demoModules) {
            Name = name;
            Title = title;
            Icon = icon;
            DemoModules = demoModules;
        }
    }
    public class DataModel {
        private static DataModel current;
        public static DataModel Current { get { return current ?? (current = new DataModel()); } }
        private List<DemoModuleGroup> demoModuleGroups;
        public List<DemoModuleGroup> DemoModuleGroups { get { return demoModuleGroups ?? (demoModuleGroups = new List<DemoModuleGroup>()); } }
        public DataModel() {
            InitializeDataForDesktop();
        }
        private void InitializeDataForDesktop() {
            #region Ribbon
            DemoModuleGroups.Add(new DemoModuleGroup("Ribbon", "Ribbon", @"M195.6,377.5 L296,377.5 M195.6,377.5 L195.6,476 M296 405.2c-12.8 7.1-30.8 10.3-54.2-0.5c-20.1-9.3-35-10.5-45.8-8.4v46.4
                                                                          c10.8-2.1 25.8-0.8 45.8 8.4c23.4 10.8 41.3 7.6 54.2 0.5V405.2z", new List<DemoModule>() {
                new DemoModule("RibbonSimplePadModule", "Ribbon", "This module demonstrates the DevExpress UWP Ribbon Control which brings Microsoft Office inspired navigation and command UI to your applications.")
                    { IsHighlighted = true, Sources = new string[] { "RibbonSimplePadViewModel.cs", "RibbonDemoCommonStyles.xaml", "DemoRichEditor/DemoRichEditControl.cs", "DemoRichEditor/DemoRichEditInterfaces.cs", "DemoRichEditor/DemoRichEditorBehavior.cs", "DemoRichEditor/DemoRichEditPreviewControl.cs", "ViewModels/BackstageNewTabViewModel.cs", "ViewModels/BackstageOpenTabViewModel.cs", "ViewModels/FontStyleGroupViewModel.cs", "ViewModels/InsertGroupViewModel.cs", "ViewModels/ParagraphStyleGroupViewModel.cs", "Views/NewFileBackstageView.xaml", "Views/NewFileBackstageView.xaml.cs", "Views/OpenFileBackstageView.xaml", "Views/OpenFileBackstageView.xaml.cs" } },
                new DemoModule("RibbonToolbarModule",
                               "Ribbon Toolbar",
                               "This module demonstrates the DevExpress UWP RibbonToolbar Control. A lightweight version of the feature-rich Ribbon Control, the RibbonToolbarControl does not include caption, Backstage View, and is not integrated into the window's title bar, thus providing an elegant solution for creating compact menus for controls",
                               "This module demonstrates the DevExpress UWP RibbonToolbar Control.")
                    { IsHighlighted = true, Sources = new string[] { "RibbonSimplePadViewModel.cs", "RibbonDemoCommonStyles.xaml", "DemoRichEditor/DemoRichEditControl.cs", "DemoRichEditor/DemoRichEditInterfaces.cs", "DemoRichEditor/DemoRichEditorBehavior.cs",  "ViewModels/FontStyleGroupViewModel.cs", "ViewModels/InsertGroupViewModel.cs", "ViewModels/ParagraphStyleGroupViewModel.cs"} },
                new DemoModule("ToolbarModule",
                               "Toolbar Control",
                               "This module demonstrates the DexExpress UWP Toolbar Control - lightweight one-tab toolbar.",
                               "This module demonstrates the DevExpress UWP Toolbar Control.")
                    { IsHighlighted = true, IsNew = true, Sources = new string[] { "ToolbarModule.xaml", "ToolbarModule.xaml.cs" }
                }
            }));
            #endregion
            #region Layout
            DemoModuleGroups.Add(new DemoModuleGroup("Layout", "Layout", @" M57 80H17c-2.2 0-4 1.8-4 4v18c0 2.2 1.8 4 4 4h40c2.2 0 4-1.8 4-4V84C61 81.8 59.2 80 57 80z M57 20H21  c-4.4 0-8 3.6-8 8v40c0 2.2 1.8 4 4 4h40
                                                                                 c2.2 0 4-1.8 4-4V24C61 21.8 59.2 20 57 20z M183 145H73c-2.2 0-4 1.8-4 4v27  c0 2.2 1.8 4 4 4h106c4.4 0 8-3.6 8-8v-23C187 146.8 185.2 145 183 145z
                                                                                 M179 20H73c-2.2 0-4 1.8-4 4v28c0 2.2 1.8 4 4 4h110  c2.2 0 4-1.8 4-4V28C187 23.6 183.4 20 179 20z M57 114H17c-2.2 0-4 1.8-4 4v54c0 4.4 3.6 8 8 8h36
                                                                                 c2.2 0 4-1.8 4-4v-58  C61 115.8 59.2 114 57 114z M73 137h54c2.2 0 4-1.8 4-4V68c0-2.2-1.8-4-4-4H73c-2.2 0-4 1.8-4 4v65C69 135.2 70.8 137 73 137z
                                                                                 M183 64h-40c-2.2 0-4 1.8-4 4v65c0 2.2 1.8 4 4 4h40c2.2 0 4-1.8 4-4V68C187 65.8 185.2 64 183 64z", new List<DemoModule>() {
                new DemoModule("HamburgerMenuDemoModule", "Hamburger Menu", "This example demonstrates the features available to you when using the DevExpress Hamburger Menu control.\n\n    - Adaptive layout\n    - Item types: navigation buttons, radio groups, checkboxes, submenus and hyperlinks\n    - Window title customization\n    - Automatic synchronization with the currently selected page", "This example demonstrates the features available to you when using the DevExpress Hamburger Menu control.")
                    { IsHighlighted = true, Sources = new string[] { "HamburgerMenuDemo_ViewModel.cs", "HamburgerMenuDemoModule_Menu.xaml", "HamburgerMenuDemoModule_Menu.xaml.cs", "HamburgerMenuDemoModule.xaml", "HamburgerMenuDemoModule.xaml.cs", "HamburgerMenuDemo_SettingsPage.xaml", "HamburgerMenuDemo_SettingsPage.xaml.cs", "HamburgerMenuDemo_InboxPage.xaml", "HamburgerMenuDemo_InboxPage.xaml.cs" } },
                new DemoModule("MVVM_LayoutGroupDemoModule", "MVVM-Style Layout", "The LayoutControl allows you to use the MVVM design pattern in order to populate groups with items from View Models.\nIn this demo, the Phones and Emails groups are populated with items from bound collections.", "The LayoutControl allows you to use the MVVM design pattern in order to populate groups with items from View Models."),
                new DemoModule("DataLayoutControlModule", "Data Layout Control", "The DataLayoutControl automatically generates a data entry form based on the object assigned to its CurrentItem property.\n In this demo you can explore the features and options available in the control.", "The DataLayoutControl automatically generates a data entry form based on the object assigned to its CurrentItem property.")
                    { Sources = new string[] { "DataLayoutControlViewModel.cs"} },
                new DemoModule("ContentContainersModule", "Content Containers", "This module demonstrates content containers and their key settings."),
                new DemoModule("MortgageAppDemoModule", "LayoutControl: Mortgage Application", "This demo uses the LayoutControl to set up a an automatically arranged and customizable entry form. Take note of expandable groups and the automatic editor alignment."),
                new DemoModule("LayoutGroupOptionsDemoModule", "LayoutControl: LayoutGroup Options", "This example demonstrates key LayoutGroup options that will help you build your own data entry forms."),
                new DemoModule("LayoutItemOptionsDemoModule", "LayoutControl: LayoutItem Options", "This example demonstrates key LayoutItem options that will help you build your own data entry forms."),
                new DemoModule("DialogModule", "MVVM-Style Dialogs ", "This demo shows how to define custom dialogs in XAML and then invoke them via commands declared in a View Model (DialogModuleViewModel).\nThe View Model contains asynchronous methods that invoke dialogs and perform actions in response to various dialog results.", "This demo shows how to define custom dialogs in XAML and then invoke them via commands declared in a View Model (DialogModuleViewModel).")
                    { Sources = new string[] { "DialogModule/UseEditControl.xaml", "DialogModule/UseEditControl.xaml.cs" } },
                new DemoModule("MessageDialogModule", "MVVM-Style Message Dialog", "This demo shows how to define a Message Dialog in XAML and invoke it via a command declared in a View Model (MessageDialogModuleViewModel).\nThe View Model contains an asynchronous method that calls the Message Dialog and performs specific actions after it is closed.", "This demo shows how to define a Message Dialog in XAML and invoke it via a command declared in a View Model (MessageDialogModuleViewModel)."),
                new DemoModule("TilesModule", "Tiles", "This module demonstrates how to build a Windows Store UI experience for your apps."),
                new DemoModule("TileBarModule", "TileBar", "The TileBar control displays a set of tiles within its container and allows you to introduce a simple and straightforward navigation experience. In this demo, the TileBar is populated with items from a bound collection.")
                    { IsUpdated = true, IsHighlighted = true, Sources = new string[] { "TileBarModule/TileBarModuleDetailView.xaml", "TileBarModule/TileBarModuleDetailView.xaml.cs", "TileBarModule/TileBarService.cs" } }
            }));
            #endregion
            #region Controls
            DemoModuleGroups.Add(new DemoModuleGroup("Controls", "Controls", @"M184.7 39.3l-23.1 23c-3.1 3.1-8.2 3.1-11.3 0l-12.7-12.7c-3.1-3.1-3.1-8.2 0-11.3l23.1-23  c-5.2-2.1-10.8-3.3-16.7-3.3c-24.3 0-44 19.7-44 44
                                                                                    c0 5.9 1.2 11.6 3.3 16.7l-30.6 30.6c-5.2-2.1-10.8-3.3-16.7-3.3  c-24.3 0-44 19.7-44 44c0 5.9 1.2 11.6 3.3 16.7l23.1-23c3.1-3.1 8.2-3.1 11.3 0l12.7 12.7
                                                                                    c3.1 3.1 3.1 8.2 0 11.3l-23.1 23  c5.2 2.1 10.8 3.3 16.7 3.3c24.3 0 44-19.7 44-44c0-5.9-1.2-11.6-3.3-16.7l30.6-30.6c5.2 2.1 10.8 3.3 16.7 3.3  
                                                                                    c24.3 0 44-19.7 44-44C188 50.1 186.8 44.4 184.7 39.3z M129.2 78.8l-50.3 50.3c-1.6 1.6-4.1 1.6-5.7 0l-2.3-2.3  c-1.6-1.6-1.6-4.1 0-5.7l50.3-50.3
                                                                                    c1.6-1.6 4.1-1.6 5.7 0l2.3 2.3C130.7 74.7 130.7 77.3 129.2 78.8z", new List<DemoModule>() {
                new DemoModule("SimplePdfViewerModule", "PDF Viewer", "This module demonstrates the PDF Viewer control that allows you to print a PDF document via the standard Windows Print dialog.")
                    { IsHighlighted = true, Sources = new string[] { "PdfViewerDemo/SimplePdfViewerViewModel.cs" } },
                new DemoModule("SimplePadModule", "Radial Context Menu", "Inspired by Microsoft OneNote, the DevExpress UWP Radial Menu Control allows you to provide quick access to contextual commands in touch-centric interfaces."),
                new DemoModule("FlyoutFlowInfoModule", "Flyout", "This module demonstrates the features available in the DevExpress UWP Flyout control. It can be displayed as a hint or popup panel displayed to either side of the screen."),
                new DemoModule("BarCodeEmployees", "QR Code Business Card", "This example uses the BarCode Control to generate QR codes within business cards. Each QR code contains the corresponding contact's personal information.")
                    { Sources = new string[] { "ControlsDemo/Data/EmployeViewModel.cs" } },
                new DemoModule("BarCodeSample2D", "BarCode 2D", "This example demonstrates four types of two-dimensional barcodes created using the BarCode Control. You can set barcode values and customize related display options."),
                new DemoModule("BarCodeSample", "Linear BarCode", "This example demonstrates one-dimensional barcodes created using the BarCodeControl. You can switch between individual barcode types, set barcode values and change corresponding display options.", "This example demonstrates one-dimensional barcodes created using the BarCodeControl."),
                new DemoModule("SplashScreenModule", "Splash Screen", "This module demonstrates how to display a splash screen. Use the radio buttons to try the two predefined styles or a manually created template.")
                    { IsHighlighted = true, IsNew = true, Sources = new string[] { "SplashScreenDemo/SplashScreenViewModel.cs" } }
            }));
            #endregion
            #region Charts
            DemoModuleGroups.Add(new DemoModuleGroup("Charts", "Charts", "M24,109 L56,109 L56,181 L24,181z M64,77 L96,77 L96,181 L64,181z M104,45 L136,45 L136,181 L104,181z M144,13 L176,13 L176,181 L144,181z", new List<DemoModule>() {
                new DemoModule("DashboardDemoModule", "Dashboard", "This module uses the MVVM pattern to create a Population dashboard that includes chart and map controls.")
                    { IsHighlighted = true },
                new DemoModule("BigAmountOfDataModule", "Large Data Source", "This module shows the DevExpress Chart Control’s performance when bound to a large data source.")
                    { IsHighlighted = true },
                new DemoModule("RealTimeDataModule", "Real-Time Data", "This module shows the DevExpress Chart Control’s performance when bound to a frequently-updated data source."),
                new DemoModule("PieDonutSeriesViewModule", "Pie and Donut", "This module demonstrates Pie and Donut series view types."),
                new DemoModule("BarSeriesViewModule", "Bar and Column", "This module demonstrates the Bar series view type."),
                new DemoModule("AreaSeriesViewModule", "Area", "This module demonstrates the Area series view type."),
                new DemoModule("LineSeriesViewModule", "Line", "This module demonstrates the Line series view type."),
                new DemoModule("ScatterLineSeriesViewModule", "Scatter Line", "This module demonstrates the Scatter Line series view type."),
                new DemoModule("PointSeriesViewModule", "Point", "This module demonstrates the Point series view type."),
                new DemoModule("FunnelSeriesViewModule", "Funnel", "This module demonstrates the Funnel series view type.") }
            ));
            #endregion
            #region Gauges
            DemoModuleGroups.Add(new DemoModuleGroup("Gauges", "Gauges", @"M100 116c-8.8 0-16 7.2-16 16s7.2 16 16 16s16-7.2 16-16S108.8 116 100 116z
                                                                                M100 12c-48.6 0-88 39.4-88 88  c0 48.6 39.4 88 88 88s88-39.4 88-88C188 51.4 148.6 12 100 12z
                                                                                M129.2 150.8l-10.3 10.3c-1.6 1.6-4.1 1.6-5.7 0L107 155  c-2.2 0.7-4.5 1-7 1c-13.3 0-24-10.7-24-24c0-4.1 1-7.9 2.8-11.3
                                                                                L46.5 79.2c-1.3-1.7-1-2.1 0.7-0.7l41.6 32.3  c3.4-1.8 7.2-2.8 11.3-2.8c13.3 0 24 10.7 24 24c0 2.4-0.4 4.8-1 7l6.2 6.2C130.7 146.7 130.7 149.3 129.2 150.8z
                                                                                M100 36  c-35.3 0-64 28.7-64 64c0 17.7 7.2 33.7 18.7 45.3l-11.3 11.3C29 142.1 20 122.1 20 100c0-44.2 35.8-80 80-80  c20.1 0 38.4 7.4 52.4 19.6l-11.3 11.3
                                                                                C130 41.6 115.6 36 100 36z M156.6 156.6l-11.3-11.3c11.6-11.6 18.7-27.6 18.7-45.3  c0-15.6-5.6-30-14.9-41.1l11.3-11.3c12.2 14 19.6 32.4 19.6 52.4
                                                                                C180 122.1 171 142.1 156.6 156.6z", new List<DemoModule>() {
                new DemoModule("HouseClimateDashboardModule", "House Climate Dashboard", "In this demo, gauges are used to create a house climate dashboard that tracks house temperature which needs to stay at a specified level and also visualizes real-time energy consumption.")
                    { IsHighlighted = true },
                new DemoModule("CircularGaugeModule", "Circular Gauge", "In this module, Circular gauges show current time in different time zones."),
                new DemoModule("LinearGaugeModule", "Linear Gauge", "This module uses level bars and markers in a Linear Gauge to indicate web site visitor trends.")
            }));
            #endregion
            #region Maps
            DemoModuleGroups.Add(new DemoModuleGroup("Maps", "Maps", @"M170.9 112.7l25.1-12.6l-25.1-12.6c-1.1-6.3-3-12.2-5.6-17.8L155 89.2c0.7 3.5 1.1 7.2 1.1 11c0 30.9-25.1 56-56 56
                                                                       c-3.8 0-7.4-0.4-11-1.1l-19.4 10.4c5.6 2.6 11.6 4.5 17.8 5.6l12.6 25.1l12.6-25.1C142.3 165.8 165.7 142.4 170.9 112.7z
                                                                       M188 12.1l-84.3 48.2c-1.2-0.1-2.4-0.2-3.7-0.2c-22.1 0-40 17.9-40 40c0 1.2 0.1 2.5 0.2 3.7L12 188.1L96.3 140
                                                                       c1.2 0.1 2.4 0.2 3.7 0.2c22.1 0 40-17.9 40-40c0-1.2-0.1-2.5-0.2-3.7L188 12.1z M100 124.1c-13.3 0-24-10.7-24-24s10.7-24 24-24
                                                                       s24 10.7 24 24S113.3 124.1 100 124.1z M29.2 112.7c1.1 6.3 3 12.2 5.6 17.8l10.4-19.4c-0.7-3.5-1.1-7.2-1.1-11c0-30.9 25.1-56 56-56
                                                                       c3.8 0 7.4 0.4 11 1.1 l19.4-10.4c-5.6-2.6-11.6-4.5-17.8-5.6L100 4.1L87.5 29.3c-29.7 5.2-53.1 28.6-58.3 58.3L4 100.1L29.2 112.7z", new List<DemoModule>() {
                    new DemoModule("PhotoGallery", "Photo Gallery", "This module demonstrates how to integrate a Photo Gallery into the DevExpress UWP Map control."),
                    new DemoModule("ShapefileSupportModule", "Shapefile Support", "This module loads Shapefile vector elements into the DevExpress UWP Map Control."),
                    new DemoModule("DataProvidersModule", "Map Data Providers", "This module shows the use of both Bing Maps and OpenStreetMap data providers with the DevExpress UWP Map Control.")
            }));
            #endregion
            #region Grid
            DemoModuleGroups.Add(new DemoModuleGroup("Grid", "Grid", @"M179 20H21c-4.4 0-8 3.6-8 8v16c0 2.2 1.8 4 4 4h44v24H17c-2.2 0-4 1.8-4 4v8c0 2.2 1.8 4 4 4h44v24H17  c-2.2 0-4 1.8-4 4v8c0 2.2 1.8 4 4 4h44v24H17
                                                                            c-2.2 0-4 1.8-4 4v16.1c0 4.3 3.5 7.9 7.9 7.9h158.3c4.3 0 7.9-3.5 7.9-7.9V156  c0-2.2-1.8-4-4-4h-44v-24h44c2.2 0 4-1.8 4-4v-8c0-2.2-1.8-4-4-4h-44V88h44
                                                                            c2.2 0 4-1.8 4-4v-8c0-2.2-1.8-4-4-4h-44V48h44  c2.2 0 4-1.8 4-4V28C187 23.6 183.4 20 179 20z M123 152H77v-24h46V152z M123 112H77V88h46V112z M123 72H77V48h46V72z", new List<DemoModule>() {
                new DemoModule("InplaceEditing", "Cell Editors", "This module shows how to embed data editor controls (text box, date edit, track bar) into grid cells for in-place editing.")
                    { IsHighlighted = true },
                new DemoModule("CellTemplatesModule", "Custom Cell Templates", "This demo shows how to customize data cells using templates.")
                    { IsHighlighted = true },
                new DemoModule("FilteringModule", "Data Filtering", "This module allows you to explore the data filtering capabilities provided by the DevExpress UWP Grid Control."),
                new DemoModule("ConditionalFormattingModule", "Conditional Formatting", "This module shows how to use Conditional Formatting to enable alternate row appearance and highlight cells matching a specific condition."),
                new DemoModule("GridRealTimeDataModule", "Real-Time Data", "This module demonstrates the DevExpress Grid Control’s automatic refresh feature with a frequently-updated data source."),
                new DemoModule("GroupingModule", "Data Grouping and Summary Alignment", "This demo shows how to group data and align group summaries under the corresponding columns."),
                new DemoModule("MultiSelection", "Multi-Row Selection", "This module demonstrates multiple-row selection. The total summary uses only values from selected rows for calculation.")
                    { Sources = new string[] { "Data/MultiSelectionViewModel.cs" }},
                new DemoModule("CellSelection", "Multi-Cell Selection", "This module demonstrates multiple cell selection in the DevExpress UWP Grid Control."),
                new DemoModule("GridSearchPanelModule", "Grid Search Panel", "This module demonstrates the built-in Search Panel which provides end-users with an easy way to locate information within the grid.")
            }));
            #endregion
            #region RangeControl
            DemoModuleGroups.Add(new DemoModuleGroup("RangeControl", "RangeControl", @"M175.6,275.4 L400,275.4  M175.6,275.4 L175.6,498 M400 339l-48 48v-96H224v80.7c-4.7 1.6-8 6.1-8 11.3c0 1.2 0.2 2.4 0.5 3.5L176 427v16l48-48h0v88h128v-72.7
                                                                                      c4.7-1.6 8-6.1 8-11.3c0-1.2-0.2-2.4-0.5-3.5L400 355V339z M232 299h112v88l-32-32l-52 52l-20.5-20.5c0.3-1.1 0.5-2.3 0.5-3.5  c0-5.2-3.3-9.7-8-11.3V299z
                                                                                      M228 387c-2.2 0-4-1.8-4-4s1.8-4 4-4s4 1.8 4 4S230.2 387 228 387z M344 475H232v-80l28 28l52-52  l24.5 24.5c-0.3 1.1-0.5 2.3-0.5 3.5c0 5.2 3.3 9.7 8 11.3V475z
                                                                                      M348 403c-2.2 0-4-1.8-4-4s1.8-4 4-4s4 1.8 4 4S350.2 403 348 403z", new List<DemoModule>() {
                new DemoModule("RangeControlModule", "Range Control Clients", "This module demonstrates available controls that can be linked to the Range Control.")
                    { IsHighlighted = true },
                new DemoModule("AggregationModule", "Data Aggregation", "This demo shows how to use the Range Control’s Data Aggregation feature for statistical analysis.")
                    { IsHighlighted = true }
            }));
            #endregion
            #region Editors
            DemoModuleGroups.Add(new DemoModuleGroup("Editors", "Editors", @"M37.1 112.3c0 3.7 2.3 5.3 4.9 5.3c3.8 0 6.9-2.9 6.9-6.7v-5.5C43.4 105.4 37.1 106.4 37.1 112.3z M116 58H24  c-2.2 0-4 1.8-4 4
                                                                                  v72c0 2.2 1.8 4 4 4h92V58z M49.8 122l-0.5-3.8h-0.2c-1.9 2.6-5.1 4.5-9.2 4.5c-6.2 0-9.7-4.6-9.7-9.7  c0-8.2 7.1-12.3 18.5-12.3
                                                                                  c0-2.5 0-7.4-6.7-7.4c-2.9 0-5.9 0.9-8 2.3L32.5 91c2.3-1.5 6.2-2.8 10.7-2.8c9.7 0 12.4 6.4 12.4 13.4  v12.5c0 2.8 0.1 5.7 0.5 7.9H49.8z
                                                                                  M80.4 122.7c-4.3 0-7.6-1.7-9.8-5.6h-0.2l-0.4 5h-5.9c0.1-2.2 0.2-5.8 0.2-8.8V73.9h7v19.7h0.1  c2-3.4 5.4-5.3 10-5.3c7.6 0 12.8 6.7 12.8 16.7
                                                                                  C94.2 117 87.2 122.7 80.4 122.7z M78.9 93.8c-4.4 0-7.6 4.3-7.6 8.6v6.5  c0 4.2 3 8.2 7.6 8.2c5.3 0 8.3-4.7 8.3-11.8C87.2 99 84.5 93.8 78.9 93.8z
                                                                                  M164 40V28c0-1.1-0.9-2-2-2h-22v16h22  C163.1 42 164 41.1 164 40z M162 154h-22v16h22c1.1 0 2-0.9 2-2v-12C164 154.9 163.1 154 162 154z M100 156v12
                                                                                  c0 1.1 0.9 2 2 2h22  v-16h-22C100.9 154 100 154.9 100 156z M124 42v112h16V42H124z M102 26
                                                                                  c-1.1 0-2 0.9-2 2v12c0 1.1 0.9 2 2 2h22V26H102z M176 58h-28 v80h28c2.2 0 4-1.8 4-4V62C180 59.8 178.2 58 176 58z", new List<DemoModule>() {
                new DemoModule("RatingPhotoGallery", "Rating Photo Gallery", "This module demonstrates the rating editor.")
                    { IsHighlighted = true, IsNew = true, Sources = new string[] { "RatingPhotoGalleryViewModel.cs" } },
                new DemoModule("RatingEditModule", "Rating Editor Features", "This module demonstrates the features supported by a rating editor.")
                    { IsHighlighted = true, IsNew = true, Sources = new string[] { "RatingEditViewModel.cs" } },
                new DemoModule("GeneralTextEditorModule", "Text Editor", "This module demonstrates the features supported by a text editor.")
                    { IsHighlighted = true, Sources = new string[] { "TextEditModule.xaml", "TextEditModule.xaml.cs", "ButtonEditModule.xaml", "ButtonEditModule.xaml.cs", "ButtonOnlyModule.xaml", "ButtonOnlyModule.xaml.cs" } },
                new DemoModule("MasksModule", "Mask", "This module demonstrates the masked input features, including full Regular Expression support.")
                    { IsHighlighted = true, Sources = new string[] { "NumericMaskModule.xaml", "NumericMaskModule.xaml.cs", "DateTimeMaskModule.xaml", "DateTimeMaskModule.xaml.cs", "DateTimeAdvancingCaretMaskModule.xaml", "DateTimeAdvancingCaretMaskModule.xaml.cs", "RegExMaskModule.xaml", "RegExMaskModule.xaml.cs", "SimpleMaskModule.xaml", "SimpleMaskModule.xaml.cs", "RegularMaskModule.xaml", "RegularMaskModule.xaml.cs"} },
                new DemoModule("DateEditModule", "Date-Time Editor", "This modules demonstrates the features available in the DevExpress Date-Time Editor control."),
                new DemoModule("DateTimePickerModule", "Date-Time Picker", "This modules demonstrates the features available in the DevExpress Date-Time Picker control.")
                    { Sources = new string[] { "DatePickerModule.xaml", "DatePickerModule.xaml.cs", "TimePickerModule.xaml", "TimePickerModule.xaml.cs" } },
                new DemoModule("SpinEditModule", "Numeric Editor", "This demo shows the features available in the DevExpress SpinEdit control, including value increment/decrement and value range limitation."),
                new DemoModule("DateNavigatorModule", "DateNavigator", "This example demonstrates the features available in the DateNavigator control including range selection."),
                new DemoModule("DateNavigatorSpecialDatesModule", "DateNavigator: Cell Customization", "This demo shows how to use templates to customize date cell content and appearance.")
                    { Sources = new string[] { "EditorsDemo/Data/DateNavigatorSpecialDatesTemplateSelector.cs", "EditorsDemo/Data/DateNavigatorSpecialDatesViewModel.cs" } }
            }));
            #endregion
        }
    }
}

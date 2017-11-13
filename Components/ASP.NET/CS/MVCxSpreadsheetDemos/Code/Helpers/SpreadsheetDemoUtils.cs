using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using DevExpress.Web;
using DevExpress.Web.ASPxSpreadsheet;

namespace DevExpress.Web.Demos {
    public static class SpreadsheetDemoUtils {
        public static void HideFileTab(ASPxSpreadsheet.ASPxSpreadsheet spreadsheet) {
            spreadsheet.CreateDefaultRibbonTabs(true);
            RemoveRibbonTab(spreadsheet, typeof(SRFileTab));
        }

        public static void CreateOverviewRibbon(ASPxSpreadsheet.ASPxSpreadsheet spreadsheet) {
            spreadsheet.CreateDefaultRibbonTabs(true);
            RemoveRibbonTab(spreadsheet, typeof(SRFileTab));
            RemoveRibbonTab(spreadsheet, typeof(SRPageLayoutTab));
        }

        static void RemoveRibbonTab(ASPxSpreadsheet.ASPxSpreadsheet spreadsheet, Type tabTypeToRemove) {
            foreach(RibbonTab tab in spreadsheet.RibbonTabs) {                
                if(tab.GetType() == tabTypeToRemove) {
                    spreadsheet.RibbonTabs.Remove(tab);
                   break;
                }
            }
        }

        public static void HideAllTabsExceptFileAndPageLayout(ASPxSpreadsheet.ASPxSpreadsheet spreadsheet) {
            spreadsheet.CreateDefaultRibbonTabs(true);

            ShowRibbonItemsOnly(spreadsheet,  
                new Type[] { 
                    typeof(SRFilePrintCommand), 
                    typeof(SRPageSetupMarginsCommand), 
                    typeof(SRPageSetupOrientationCommand), 
                    typeof(SRPageSetupPaperKindCommand), 
                    typeof(SRPrintGridlinesCommand),
                    typeof(SRPrintHeadingsCommand)
                }
            );
        }

        public static void HideAllTabsExceptHomeAndView(ASPxSpreadsheet.ASPxSpreadsheet spreadsheet) {
            spreadsheet.CreateDefaultRibbonTabs(true);

            RemoveRibbonTab(spreadsheet, typeof(SRFileTab));
            RemoveRibbonTab(spreadsheet, typeof(SRInsertTab));
            RemoveRibbonTab(spreadsheet, typeof(SRPageLayoutTab));
            RemoveRibbonTab(spreadsheet, typeof(SRPageLayoutTab));
            RemoveRibbonTab(spreadsheet, typeof(SRFormulasTab));
            RemoveRibbonTab(spreadsheet, typeof(SRDataTab));
        }

        public static void HidePageLayoutTab(ASPxSpreadsheet.ASPxSpreadsheet spreadsheet) {
            RemoveRibbonTab(spreadsheet, typeof(SRPageLayoutTab));
        }

        public static void HideFormulasTab(ASPxSpreadsheet.ASPxSpreadsheet spreadsheet) {
            RemoveRibbonTab(spreadsheet, typeof(SRFormulasTab));
        }

        private static void HideRibbonItems(ASPxSpreadsheet.ASPxSpreadsheet spreadsheet, Type[] itemTypes) {
            ProcessRibbonItems(spreadsheet, itemTypes, false);
        }
        private static void ShowRibbonItemsOnly(ASPxSpreadsheet.ASPxSpreadsheet spreadsheet, Type[] itemTypes) {
            ProcessRibbonItems(spreadsheet, itemTypes, true);
        }
        private static void ProcessRibbonItems(ASPxSpreadsheet.ASPxSpreadsheet spreadsheet, Type[] targetTypes, bool removeNotInList) {
            var groups = new List<RibbonGroup>();
            var items = new List<RibbonItemBase>();
            
            List<RibbonTab> tabs = spreadsheet.RibbonTabs.ToList();
            foreach(RibbonTab tab in tabs) {                
                groups.AddRange(tab.Groups);
            }
            foreach(RibbonGroup group in groups) {
                items.AddRange(group.Items);
            }

            RemoveItemsByTypes(items, targetTypes, removeNotInList);
            RemoveEmptyGroups(groups);
            RemoveEmptyTabs(spreadsheet, tabs);
        }

        private static void RemoveItemsByTypes(List<RibbonItemBase> items, Type[] targetTypes, bool removeNotInList) {
            var targetItem = new List<RibbonItemBase>();
            var itemsNotInList = new List<RibbonItemBase>();
            GroupItemsByType(items, targetTypes, targetItem, itemsNotInList);

            if(removeNotInList)
                RemoveItems(itemsNotInList);
            else
                RemoveItems(targetItem);
                
        }

        private static void GroupItemsByType(List<RibbonItemBase> items, Type[] targetTypes, List<RibbonItemBase> targetItem, List<RibbonItemBase> itemsNotInList) {
            foreach(RibbonItemBase item in items) {
                if(targetTypes.Contains(item.GetType()))
                    targetItem.Add(item);
                else
                    itemsNotInList.Add(item);
            }
        }

        private static void RemoveItems(List<RibbonItemBase> items) {
            foreach(RibbonItemBase item in items)
                item.Group.Items.Remove(item);
        }
        private static void RemoveEmptyGroups(List<RibbonGroup> groups) {
            foreach(RibbonGroup group in groups) {
                if(group.Items.IsEmpty)
                    group.Tab.Groups.Remove(group);
            }
        }
        private static void RemoveEmptyTabs(ASPxSpreadsheet.ASPxSpreadsheet spreadsheet, List<RibbonTab> tabs) {
            foreach(RibbonTab tab in tabs) {
                if(tab.Groups.IsEmpty)
                    spreadsheet.RibbonTabs.Remove(tab); 
            }
        }
    }
}

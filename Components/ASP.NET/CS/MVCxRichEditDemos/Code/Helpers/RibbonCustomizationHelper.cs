using System.Web.UI.WebControls;
using DevExpress.Web.ASPxRichEdit;

namespace DevExpress.Web.Demos {
    public static class RibbonCustomizationDemoHelper {
        public static RibbonTab GetCustomRibbonTab(bool isExtenernalRibbon) {
            RibbonTab ribbonTab = new RibbonTab("Home");
            if (isExtenernalRibbon)
                ribbonTab.Groups.AddRange(new RibbonGroup[] { GetCommonGroup(), GetFontGroup(isExtenernalRibbon), GetViewGroup() });
            else
                ribbonTab.Groups.AddRange(new RibbonGroup[] { GetCommonGroup(), GetUndoGroup(), GetFontGroup(isExtenernalRibbon), GetPagesGroup(), GetViewGroup() });
            return ribbonTab;
        }

        static RERFileCommonGroup GetCommonGroup() {
            var commonGroup = new RERFileCommonGroup();
            commonGroup.Items.AddRange(new RibbonItemBase[] {
                new RERNewCommand(RibbonItemSize.Small) { Text = "New Document", ToolTip = "Ctrl + N" },
                new RERPrintCommand(RibbonItemSize.Small) { Text = "Print Document", ToolTip = "Ctrl + P" }
            });
            return commonGroup;
        }
        static RERUndoGroup GetUndoGroup() {
            var undoGroup = new RERUndoGroup();
            undoGroup.Items.AddRange(new RibbonItemBase[] {
                new RERUndoCommand(RibbonItemSize.Large) { Text = "Undo", ToolTip = "Ctrl + Z" },
                new RERRedoCommand(RibbonItemSize.Large) { Text = "Redo", ToolTip = "Ctrl + Y" }
            });
            return undoGroup;
        }
        static RERFontGroup GetFontGroup(bool isExtenernalRibbon) {
            var fontGroup = new RERFontGroup() { ShowDialogBoxLauncher = isExtenernalRibbon };
            fontGroup.Items.AddRange(new RibbonItemBase[] { 
                PrepareComboBoxCommand(new RERFontNameCommand()),
                PrepareComboBoxCommand(new RERFontSizeCommand()),    
                new RERFontBoldCommand(RibbonItemSize.Large) { Text = "Bold", ToolTip = "Ctrl + B" }, 
                new RERFontItalicCommand(RibbonItemSize.Large) { Text = "Italic", ToolTip = "Ctrl + I" } 
            });
            return fontGroup;
        }
        static RERComboBoxCommandBase PrepareComboBoxCommand(RERComboBoxCommandBase command) {
            command.FillItems();
            command.PropertiesComboBox.Width = Unit.Pixel(100);
            return command;
        }
        static RERPagesGroup GetPagesGroup() {
            var pagesGroup = new RERPagesGroup();
            pagesGroup.Items.Add(new RibbonItemBase[] { 
                new RERPageMarginsCommand(),
                new RERChangeSectionPageOrientationCommand(),
                new RERChangeSectionPaperKindCommand()
            });
            return pagesGroup;
        }
        static RERViewGroup GetViewGroup() {
            var viewGroup = new RERViewGroup();
            viewGroup.Items.AddRange(new RibbonItemBase[] {
                new RERToggleShowHorizontalRulerCommand(),
                new RERToggleFullScreenCommand() { ToolTip = "F11" } 
            });
            return viewGroup;
        }
    }
}

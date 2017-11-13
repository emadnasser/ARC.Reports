using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraSpreadsheet.Commands;
using DevExpress.XtraToolbox;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.Utils.About;

namespace ToolboxDemo {
    public partial class MainForm : RibbonForm {
        public MainForm() {
            InitializeComponent();
            InitializeToolbox();
            Toolbox.SelectedGroupIndex = 0;
            LoadDocument("Data\\ToolboxDemoData.xlsx");
        }
        protected void LoadDocument(string fileName) {
            string filePath = FilesHelper.FindingFileName(Application.StartupPath, fileName);
            Spreadsheet.Document.LoadDocument(filePath);
        }
        protected void InitializeToolbox() {
            Toolbox.Groups.Add(ToolboxGroupChartColumn);
            Toolbox.Groups.Add(ToolboxGroupChartBar);
            Toolbox.Groups.Add(ToolboxGroupChartArea);
        }
        public ToolboxControl Toolbox { get { return toolboxControl; } }
        public SpreadsheetControl Spreadsheet { get { return spreadsheetControl; } }
        ToolboxGroup toolboxGroupChartColumn;
        protected ToolboxGroup ToolboxGroupChartColumn {
            get { return toolboxGroupChartColumn ?? (toolboxGroupChartColumn = GetToolboxGroupFromData(ToolboxData.ChartColumn, "Column")); }
        }
        ToolboxGroup toolboxGroupChartBar;
        protected ToolboxGroup ToolboxGroupChartBar {
            get { return toolboxGroupChartBar ?? (toolboxGroupChartBar = GetToolboxGroupFromData(ToolboxData.ChartBar, "Bar")); }
        }
        ToolboxGroup toolboxGroupChartArea;
        protected ToolboxGroup ToolboxGroupChartArea {
            get { return toolboxGroupChartArea ?? (toolboxGroupChartArea = GetToolboxGroupFromData(ToolboxData.ChartArea, "Area")); }
        }
        protected ToolboxGroup GetToolboxGroupFromData(Dictionary<ToolboxDataKey, string> data, string name) {
            ToolboxGroup group = new ToolboxGroup(name);
            string lastCategoryName = string.Empty;
            foreach(ToolboxDataKey key in data.Keys) {
                ToolboxItem item = new ToolboxItem();
                SpreadsheetCommand command = Spreadsheet.CreateCommand(key.Id);
                item.Caption = command.MenuCaption;
                item.Image = command.LargeImage;
                item.Tag = key.ChartType;
                item.BeginGroup = lastCategoryName != data[key];
                lastCategoryName = data[key];
                item.BeginGroupCaption = item.BeginGroup ? lastCategoryName : string.Empty;
                group.Items.Add(item);
            }
            return group;
        }
        protected bool CanDropItem(Point loc) {
            return ClientBounds.Contains(loc) && Spreadsheet.GetCellFromPoint(loc) != null;
        }
        protected void OnToolboxDragItemDrop(object sender, ToolboxDragItemDropEventArgs e) {
            if(!CanDropItem(Spreadsheet.PointToClient(Cursor.Position))) return;
            Point pt = GetCenterPoint(Cursor.Position);
            Spreadsheet.BeginUpdate();
            try {
                Chart chart = Spreadsheet.ActiveWorksheet.Charts.Add((ChartType)e.Item.Tag, Spreadsheet.ActiveWorksheet["C4:D15"]);
                chart.TopLeftCell = Spreadsheet.GetCellFromPoint(new PointF(pt.X - HorizontalIndent, pt.Y - VerticalIndent));
                chart.BottomRightCell = Spreadsheet.GetCellFromPoint(new PointF(pt.X + HorizontalIndent, pt.Y + VerticalIndent));
            }
            catch {
                Spreadsheet.CancelUpdate();
            }
            finally {
                Spreadsheet.EndUpdate();
            }

        }
        protected Rectangle ClientBounds {
            get { return Spreadsheet.Bounds; }
        }
        protected int VerticalIndent { get { return 150; } }
        protected int HorizontalIndent { get { return 200; } }
        protected Point GetCenterPoint(Point point) {
            Point pt = Spreadsheet.PointToClient(Cursor.Position);
            if(pt.X + HorizontalIndent >= ClientBounds.Right) pt.X -= HorizontalIndent + 20;
            if(pt.X - HorizontalIndent <= ClientBounds.Left) pt.X += HorizontalIndent + 20;
            if(pt.Y + VerticalIndent >= ClientBounds.Bottom) pt.Y -= VerticalIndent + 20;
            if(pt.Y - VerticalIndent <= ClientBounds.Top) pt.Y += VerticalIndent + 20;
            return pt;
        }
        protected void OnToolboxDragItemMove(object sender, ToolboxDragItemMoveEventArgs e) {
            e.DragDropEffects = CanDropItem(Spreadsheet.PointToClient(Cursor.Position)) ? DragDropEffects.Move : DragDropEffects.None;
        }
        protected void OnToolboxDragItemStart(object sender, ToolboxDragItemStartEventArgs e) {
            ToolboxItem item = e.Item as ToolboxItem;
            if(item == null) return;
            e.Image = item.Image;
            e.Handled = true;
        }
        protected void OnToolboxStateChanged(object sender, ToolboxStateChangedEventArgs e) {
            Toolbox.OptionsView.ShowMenuButton = Toolbox.OptionsMinimizing.State == ToolboxState.Minimized;
        }
    }
}

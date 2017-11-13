using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using DevExpress.Snap.Core.API;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.Utils;
using DevExpress.Snap.Core.Fields;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraRichEdit.UI;
using DevExpress.Snap.Extensions.UI;
using RegexpMatch = System.Text.RegularExpressions.Match;

namespace SnapDemos.Modules {
    public partial class API : SnapTutorialControlBase {
        static readonly Regex formatFinder = new Regex(@"(?:^|[^\{])(\{0(?:(?:,\d+)?(?::([\d]*[\w]?))?)?\})");
        public API() {
            InitializeComponent();
            new SnapDemoExceptionsHandler(snapControl1).Install();
            using(WaitDialogForm dlg = new WaitDialogForm("Please wait", "Loading...")) {
                SetDataSource();
            }
        }

        protected override RibbonControl RibbonControl { get { return ribbonControl1; } }
        protected override GalleryChangeTableStyleItem GalleryChangeTableStyleItem { get { return galleryChangeTableStyleItem1; } }
        protected override GalleryChangeTableCellStyleItem GalleryChangeTableCellStyleItem { get { return galleryChangeTableCellStyleItem1; } }

        void SetDataSource() {
            object dataSource = new APIDataProvider().GetDataSource();
            gridControl1.DataSource = dataSource;
            snapControl1.DataSource = dataSource;
        }

        void AdjustSize(Table table) {
            table.SetPreferredWidth(50 * 100, WidthType.FiftiethsOfPercent);
            table.TableLayout = TableLayoutType.Fixed;
            table.ForEachCell(AssignPreferredWidth);
        }
        void AssignPreferredWidth(TableCell cell, int rowIndex, int cellIndex) {
            cell.PreferredWidthType = WidthType.FiftiethsOfPercent;
            cell.PreferredWidth = (float)(50.0 * 100.0 / cell.Row.Cells.Count);
        }
        void ApplyDataSource(SnapList list, GridLevelNode node) {
            if(!node.IsRootLevel) {
                list.DataMember = node.RelationName;
            }
        }

        void ApplyGroups(SnapList list, GridView grid) {
            foreach(GridColumn col in grid.GroupedColumns) {
                SnapListGroupInfo group = list.Groups.CreateSnapListGroupInfo(new SnapListGroupParam(col.FieldName, col.SortOrder));
                SnapDocument groupHeader = group.CreateHeader();
                Table box = groupHeader.Tables.Create(groupHeader.Range.End, 1, 1);
                AdjustSize(box);
                groupHeader.CreateSnText(box.Cell(0, 0).Range.Start, col.FieldName);
                groupHeader.InsertText(box.Cell(0, 0).Range.Start, String.Format("{0}: ", col.FieldName));
                ApplySummary(group, grid);
                list.Groups.Add(group);
            }
        }
        
        void BuildSummaryTemplate(SnapDocument template, TableCell box, GridSummaryItem source, SummaryRunning running) {
            MatchCollection formatFields = formatFinder.Matches(source.DisplayFormat);
            int k = 0;
            template.InsertText(box.ContentRange.End, " ");
            foreach(RegexpMatch match in formatFields) {
                template.InsertText(box.ContentRange.End, source.DisplayFormat.Substring(k, match.Groups[1].Index - k));
                k = match.Groups[1].Index + match.Groups[1].Length;
                SnapText snText = template.CreateSnText(box.ContentRange.End, source.FieldName);
                snText.BeginUpdate();
                snText.SummaryRunning = running;
                snText.SummaryFunc = source.SummaryType;
                string format = match.Groups[2].Value;
                if(!String.IsNullOrEmpty(format)) {
                    if(format.EndsWith("C", StringComparison.InvariantCultureIgnoreCase))
                        snText.FormatString = @"$0.00";
                }
                snText.EndUpdate();
            }
            template.InsertText(box.ContentRange.End, source.DisplayFormat.Substring(k));
        }

        void ApplySummary(SnapListGroupInfo group, GridView grid) {
            foreach(GridSummaryItem item in grid.GroupSummary) {
                GridGroupSummaryItem summary = item as GridGroupSummaryItem;
                if(summary != null) {
                    if(summary.ShowInGroupColumnFooter == null) {
                        BuildSummaryTemplate(group.Header, group.Header.Tables[0].Cell(0, 0), summary, SummaryRunning.Group);
                    }
                    else {
                        int col = grid.VisibleColumns.IndexOf(summary.ShowInGroupColumnFooter);
                        if(col < 0)
                            continue;
                        SnapDocument footer = group.Footer;
                        if(footer == null)
                            footer = group.CreateFooter();
                        if(footer.Tables.Count == 0 || footer.Tables[0].Rows.Count == 0 || footer.Tables[0].Rows[0].Cells.Count != grid.VisibleColumns.Count) {
                            Table table = footer.Tables.Create(footer.Range.Start, 1, grid.VisibleColumns.Count);
                            AdjustSize(table);
                        }
                        BuildSummaryTemplate(footer, footer.Tables[0].Cell(0, col), summary, SummaryRunning.Group);
                    }
                }
            }
        }
        
        void ApplySorting(SnapList list, GridView grid) {
            foreach(GridColumn col in grid.SortedColumns) {
                list.Sorting.Add(new SnapListGroupParam(col.FieldName, col.SortOrder));
            }
        }

        void ApplyFilter(SnapList list, GridView grid) {
            string filter = grid.ActiveFilterString;
            if(!String.IsNullOrEmpty(filter))
                list.Filters.Add(filter);
        }

        void MakeTemplate(SnapList list, GridView grid, out Table table, out SnapDocument template) {
            template = list.RowTemplate;
            SnapDocument header = list.ListHeader;

            table = template.Tables.Create(template.Range.End, 1, grid.VisibleColumns.Count);
            Table caption = header.Tables.Create(header.Range.End, 1, grid.VisibleColumns.Count);
            AdjustSize(table);
            AdjustSize(caption);

            foreach(GridColumn col in grid.VisibleColumns) {
                header.InsertText(caption.Cell(0, col.VisibleIndex).Range.Start, col.FieldName);
                TableCell cell = table.Cell(0, col.VisibleIndex);

                DocumentPosition pos = cell.Range.Start;
                Type colType = GetColType(col);
                if(colType == typeof(byte[]))
                    template.CreateSnImage(pos, col.FieldName);
                else if(colType == typeof(bool))
                    template.CreateSnCheckBox(pos, col.FieldName);
                else
                    template.CreateSnText(pos, col.FieldName);
            }
        }

        Type GetColType(GridColumn gridCol) {
            if(gridCol.View.DataSource != null)
                return gridCol.ColumnType;
            if(String.Equals(gridCol.View.Name, "detailView")) {
                nwindDataSet.ProductsDataTable products = nwindDataSet.Products;
                foreach(DataColumn dataCol in products.Columns) {
                    if(String.Equals(gridCol.FieldName, dataCol.ColumnName))
                        return dataCol.DataType;
                }
            }
            return typeof(System.Object);
        }

        void MakeReportFooter(SnapList list, GridView grid) {
            var tmp = new Dictionary<int, List<GridColumnSummaryItem>>();
            foreach(GridColumn column in grid.VisibleColumns) {
                int colNum = column.VisibleIndex;
                foreach(GridColumnSummaryItem item in column.Summary) {
                    if(!tmp.ContainsKey(colNum))
                        tmp[colNum] = new List<GridColumnSummaryItem>(1);
                    tmp[colNum].Add(item);
                }
            }
            if (tmp.Count == 0)
                return;
            SnapDocument footer = list.ListFooter;
            Table table = footer.Tables.Create(footer.Range.Start, tmp.Values.Max(o => o.Count), grid.VisibleColumns.Count);
            AdjustSize(table);
            foreach(KeyValuePair<int, List<GridColumnSummaryItem>> rec in tmp) {
                int colNum = rec.Key;
                int rowNum = 0;
                foreach(GridColumnSummaryItem summary in rec.Value) {
                    BuildSummaryTemplate(footer, table.Cell(rowNum++, colNum), summary, SummaryRunning.Report);
                }
            }
        }

        void ApplyDetails(GridLevelNode node, Table table, SnapDocument template, int level) {
            if(node.HasChildren)
                foreach(GridLevelNode child in node.Nodes) {
                    TableRow detail = table.Rows.Append();
                    table.MergeCells(detail.FirstCell, detail.LastCell);
                    Convert(child, template, detail.Range.Start, level + 1);
                }
        }

        void Convert(GridLevelNode node, SnapDocument document) {
            Convert(node, document, document.Range.End, 1);
        }
        void Convert(GridLevelNode node, SnapDocument document, DocumentPosition position, int level) {
            GridView grid = node.LevelTemplate as GridView;
            if(grid == null || grid.VisibleColumns.Count == 0)
                return;

            SnapList list = document.CreateSnList(position, grid.Name);
            list.BeginUpdate();

            ApplyDataSource(list, node);
            ApplyGroups(list, grid);
            ApplySorting(list, grid);
            ApplyFilter(list, grid);
            Table table = null;
            SnapDocument template = null;
            MakeTemplate(list, grid, out table, out template);
            MakeReportFooter(list, grid);
            ApplyDetails(node, table, template, level);

            list.ApplyTableStyles(level);
            list.EndUpdate();
        }

        void button1_Click(object sender, EventArgs e) {
            using(WaitDialogForm dlg = new WaitDialogForm("Please wait", "Document processing...")) {
                snapControl1.CreateNewDocument();
                SnapDocument document = snapControl1.Document;
                document.BeginUpdate();
                Convert(gridControl1.LevelTree, document);
                document.Fields.Update();
                document.EndUpdate();
            }
        }
    }
}

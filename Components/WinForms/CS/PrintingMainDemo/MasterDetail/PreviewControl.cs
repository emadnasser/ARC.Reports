using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using DevExpress.XtraTab;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraEditors;
using System.Drawing.Printing;
using DevExpress.XtraPrinting.Preview;
using DevExpress.DXperience.Demos;
using DevExpress.Tutorials.Controls;

namespace XtraPrintingDemos.HierarchicalReport {
    public class PreviewControl : TutorialControlBase, IPreviewControl {
        readonly int[] wCustomers = new int[] { 90, 150, 100, 70, 83, 100 };
        readonly int[] wOrders = new int[] { 90, 90, 90 };

        readonly string[] sCustomers = new string[] { "ContactName", "CompanyName", "ContactTitle", "Country", "City", "Address" };
        readonly string[] sOrders = new string[] { "OrderID", "OrderDate", "Freight" };

        XtraTabControl PSTab;
        System.Windows.Forms.ImageList imageList1;
        System.Windows.Forms.ImageList imageList2;
        System.ComponentModel.IContainer components;

        DocumentViewerRibbonController controller;

        DocumentViewer IPreviewControl.Viewer {
            get {
                return Viewer;
            }
        }
        DocumentViewer Viewer {
            get {
                XtraTabPage tp = PSTab.TabPages[PSTab.SelectedTabPageIndex];
                return tp.Controls.Count > 0 ? tp.Controls[0] as DocumentViewer : null;
            }
        }

        public PreviewControl() {
            InitializeComponent();

            PrintingSystem ps = new PrintingSystem();
            ps.PageSettings.Assign(new Margins(90, 90, 110, 100), PaperKind.Letter, false);

            AddTabControl("Main Report", null, ps);

            using(DataView dataView = CreateDataView("Customers", "")) {
                new ReportCreator(dataView, sCustomers, wCustomers).CreateReport(ps, imageList1, "Customers", imageList2.Images[0]);
            }

            SetVisibilityToExportCommands(ps);
        }
        void SetVisibilityToExportCommands(PrintingSystem ps) {
            ps.SetCommandVisibility(new PrintingSystemCommand[] { 
                PrintingSystemCommand.ExportTxt, PrintingSystemCommand.ExportXls, PrintingSystemCommand.ExportXlsx,
                PrintingSystemCommand.ExportCsv, PrintingSystemCommand.ExportHtm, PrintingSystemCommand.ExportMht,
                PrintingSystemCommand.ExportRtf, PrintingSystemCommand.SendMht, PrintingSystemCommand.SendRtf
                },
                CommandVisibility.All);
        }
        void AddTabControl(string text, object tag, PrintingSystem ps) {
            XtraTabPage tp = new XtraTabPage() { Text = text, Tag = tag };
            DocumentViewer pc = new DocumentViewer() { RequestDocumentCreation = false, PrintingSystem = ps, Dock = DockStyle.Fill };
            pc.BrickClick += OnBrickClick;
            tp.Controls.Add(pc);
            PSTab.TabPages.Add(tp);
            PSTab.SelectedTabPageIndex = PSTab.TabPages.Count - 1;
        }
        private void OnBrickClick(object sender, DevExpress.XtraPrinting.Control.BrickEventArgs e) {
            if(e.Brick != null && !string.IsNullOrEmpty(e.Brick.ID))
                ChangeClickBrick(e.Brick);
        }
        void IPreviewControl.Activate(DocumentViewerRibbonController controller) {
            this.controller = controller;
            if(controller != null)
                controller.DocumentViewer = Viewer;
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewControl));
            this.PSTab = new DevExpress.XtraTab.XtraTabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PSTab)).BeginInit();
            this.SuspendLayout();
            // 
            // PSTab
            // 
            this.PSTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PSTab.Location = new System.Drawing.Point(0, 0);
            this.PSTab.Name = "PSTab";
            this.PSTab.Size = new System.Drawing.Size(784, 432);
            this.PSTab.TabIndex = 3;
            this.PSTab.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.PSTab_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Book_Closed_16x16.png");
            this.imageList1.Images.SetKeyName(1, "Book_Opened_16x16.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "Customers_icon.png");
            this.imageList2.Images.SetKeyName(1, "Order_Icon_64x64.png");
            // 
            // PreviewControl
            // 
            this.Controls.Add(this.PSTab);
            this.Name = "PreviewControl";
            ((System.ComponentModel.ISupportInitialize)(this.PSTab)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private DataView CreateDataView(string tbl, string s) {
            DataSet dataSet1 = new DataSet();
            string query = "SELECT * FROM " + tbl + s;
            System.Data.OleDb.OleDbDataAdapter work1 = new System.Data.OleDb.OleDbDataAdapter(query, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\nwind.mdb");
            work1.Fill(dataSet1, tbl);
            DataViewManager dvManager1 = new DataViewManager(dataSet1);
            return dvManager1.CreateDataView(dataSet1.Tables[tbl]);
        }
        private void ChangeClickBrick(Brick brick) {
            if(brick.Value.Equals("Main")) {
                PSTab.SelectedTabPageIndex = 0;
                return;
            }
            Tuple<string, string> values = brick.Value as Tuple<string, string>;
            if(values == null) return;
            
            if(Viewer != null)
                Viewer.InvalidateBrick(brick);
            string tpName = string.Format("{0} Orders", values.Item2);

            if(Equals("0", brick.ID)) {
                brick.ID = "1";
                ((ImageBrick)brick).Image =  imageList1.Images[1];

                PrintingSystem ps = new PrintingSystem();
                ps.PageSettings.Assign(new Margins(110, 110, 110, 100), PaperKind.Letter, false);
                AddTabControl(tpName, values.Item1, ps);

                using(DataView dataView = CreateDataView("Orders", string.Format(" WHERE [CustomerID] ='{0}'", values.Item1))) {
                    new DetailReportCreator(dataView, sOrders, wOrders).CreateReport(ps, tpName, imageList2.Images[1]);
                }
            } else {
                brick.ID = "0";
                ((ImageBrick)brick).Image = imageList1.Images[0];
                PSTab.TabPages.RemoveAt(FindTabPageIndex(tpName, PSTab));
                PSTab.SelectedTabPageIndex = 0;
            }
        }

        private int FindTabPageIndex(string s, XtraTabControl tbc) {
            for(int i = 0; i < tbc.TabPages.Count; i++)
                if(tbc.TabPages[i].Text == s)
                    return i;
            return -1;
        }
        private void PSTab_SelectedIndexChanged(object sender, TabPageChangedEventArgs e) {
            if(controller != null)
                controller.DocumentViewer = Viewer;
        }
    }
    class ReportCreatorBase {
        protected readonly Type[] numericTypes = new Type[] {
            typeof(byte),
            typeof(decimal),
            typeof(double),
            typeof(short),
            typeof(int),
            typeof(long),
            typeof(sbyte),
            typeof(float),
            typeof(ushort),
            typeof(uint),
            typeof(ulong)
        };
        protected readonly PaddingInfo textPadding = new PaddingInfo(5, 5, 2, 2);

        protected string[] columnsNames;
        protected DataView dv;
        protected int[] widths;
        protected ReportCreatorBase(DataView dv, string[] columnsNames, int[] widths) {
            this.columnsNames = columnsNames;
            this.widths = widths;
            this.dv = dv;
        }
        protected void CreatePageHeader(BrickGraphics gr, string reportName, Image imgTitle, Color foreColor) {
            gr.BackColor = Color.Transparent;
            gr.Modifier = BrickModifier.MarginalHeader;

            gr.Font = new Font("Tahoma", 20f, FontStyle.Bold);


            PageTableBrick ptBrick = new PageTableBrick();
            TableRow row = new TableRow();
            PageImageBrick piBrick = new PageImageBrick();
            piBrick.Image = imgTitle;
            piBrick.SizeMode = ImageSizeMode.CenterImage;
            piBrick.Rect = new RectangleF(0, 0, 95, 75);
            piBrick.Sides = BorderSide.None;
            piBrick.BackColor = Color.Transparent;
            row.Bricks.Add(piBrick);
            PageInfoBrick pinfBrick = new PageInfoBrick();
            pinfBrick.Format = reportName;
            pinfBrick.ForeColor = foreColor;
            RectangleF infoRect = new RectangleF(piBrick.Rect.Right + 10, 0, 100, gr.Font.Height);
            pinfBrick.Rect = new RectangleF(new PointF(piBrick.Rect.X + piBrick.Rect.Right, piBrick.Rect.Y), piBrick.Rect.Size);
            pinfBrick.AutoWidth = true;
            pinfBrick.Sides = BorderSide.None;
            pinfBrick.StringFormat = pinfBrick.StringFormat.ChangeLineAlignment(StringAlignment.Center);
            row.Bricks.Add(pinfBrick);
            ptBrick.Rows.Add(row);
            gr.DrawBrick(ptBrick);
            ptBrick.Alignment = BrickAlignment.Near;
            ptBrick.LineAlignment = BrickAlignment.Center;
            ptBrick.UpdateSize();
        }
        protected int CalcRowHeight(BrickGraphics gr, string text, int width, int height) {
            return Math.Max((int)gr.MeasureString(text, width).Height, height);
        }
        protected void CreatePageFooter(BrickGraphics gr) {
            gr.Font = new Font("Tahoma", 8f, FontStyle.Regular);
            gr.BackColor = Color.Transparent;
            gr.Modifier = BrickModifier.MarginalFooter;

            RectangleF r = new RectangleF(0, 0, 0, gr.Font.Height);
            string format = "Page: {0} / {1}";
            PageInfoBrick brick = gr.DrawPageInfo(PageInfo.NumberOfTotal, format, Color.Black, r, BorderSide.None);
            brick.Padding = new PaddingInfo(0, 10, 0, 0, GraphicsDpi.Pixel);
            brick.Alignment = BrickAlignment.Far;
            brick.AutoWidth = true;
        }
        protected void CreateColumn(BrickGraphics gr, DataRowView row, int j, int leftCell, int hGeneral, int hRow) {
            Type columnType = dv.Table.Columns[columnsNames[j]].DataType;
            if(Array.IndexOf(numericTypes, columnType) > 0)
                gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Far);
            else
                gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Near);

            if(j == 0)
                gr.BackColor = Color.FromArgb(255, 241, 219);
            else
                gr.BackColor = SystemColors.Window;

            BorderSide borderSides = BorderSide.Bottom | BorderSide.Right;
            if(j == 0)
                borderSides |= BorderSide.Left;
            object columnValue = row[columnsNames[j]];
            TextBrick textBrick = gr.DrawString(
                (columnValue is DateTime) ? ((DateTime)columnValue).ToString("d") : columnValue.ToString(),
                SystemColors.WindowText,
                new RectangleF(leftCell, hGeneral, widths[j], hRow),
                borderSides);
            textBrick.BorderStyle = BrickBorderStyle.Inset;
            textBrick.Padding = textPadding;
        }
        protected int GetRowHeight(DataRowView row, BrickGraphics gr, int textHeight) {
            int hRow = 0;
            for(int j = 0; j < columnsNames.Length; j++)
                hRow = Math.Max(hRow, CalcRowHeight(gr, row[columnsNames[j]].ToString(), widths[j] - textPadding.Left - textPadding.Right, textHeight));
            return hRow;
        }
    }
    class ReportCreator : ReportCreatorBase {
        public ReportCreator(DataView dv, string[] columnsNames, int[] widths) : base(dv, columnsNames, widths) {
        }
        public void CreateReport(PrintingSystem ps, ImageList iList, string reportName, Image imgTitle) {
            Brick brick;
            BrickGraphics gr = ps.Graph;
            ps.Begin();

            //gr.
            gr.StringFormat = gr.StringFormat.ChangeLineAlignment(StringAlignment.Center);
            gr.Font = new Font("Tahoma", 8f, FontStyle.Bold);

            int imgW = iList.ImageSize.Width;
            int imgH = iList.ImageSize.Height;

            int textHeight = gr.Font.Height + 2;

            //header
            int leftCell = 0;
            int headerwidth;
            const int BookImageWidth = 20;
            gr.Modifier = BrickModifier.DetailHeader;
            gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Center);
            gr.BackColor = Color.FromArgb(71, 143, 212);
            gr.BorderColor = Color.FromArgb(27, 91, 182);
            PaddingInfo headerPadding = new PaddingInfo(0, 0, 2, 2);
            for(int j = 0; j < columnsNames.Length; j++) {
                headerwidth = widths[j];
                BorderSide borders = BorderSide.Top | BorderSide.Bottom | BorderSide.Right;
                if(j == 0)
                    headerwidth += BookImageWidth;
                if(j == 0)
                    borders |= BorderSide.Left;
                TextBrick textBrick = gr.DrawString(dv.Table.Columns[columnsNames[j]].Caption, SystemColors.HighlightText,
                    new RectangleF(leftCell, 0, headerwidth, textHeight + headerPadding.Top + headerPadding.Bottom), borders);
                textBrick.BorderStyle = BrickBorderStyle.Inset;
                textBrick.Padding = headerPadding;
                leftCell += headerwidth;
            }

            //strings
            gr.Modifier = BrickModifier.Detail;
            gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Near);
            gr.Font = new Font("Tahoma", 8f);

            int hGeneral = 0;
            foreach(DataRowView row in dv) {
                leftCell = imgW + imgW / 4;
                int hRow = GetRowHeight(row, gr, textHeight) + textPadding.Top + textPadding.Bottom;

                gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Center);
                ImageBrick imgBrick = gr.DrawImage(iList.Images[0], new RectangleF(0, hGeneral, BookImageWidth, hRow), BorderSide.None, Color.Transparent);
                imgBrick.SizeMode = ImageSizeMode.CenterImage;
                imgBrick.Url = "empty";
                imgBrick.ID = "0";
                imgBrick.Value = new Tuple<string, string>((string)row["CustomerID"], (string)row["ContactName"]);
                brick = imgBrick;

                gr.BorderColor = Color.Gray;
                for(int j = 0; j < columnsNames.Length; j++) {
                    CreateColumn(gr, row, j, leftCell, hGeneral, hRow);
                    leftCell += widths[j];
                }
                hGeneral += hRow;
            }

            CreatePageHeader(gr, reportName, imgTitle, Color.FromArgb(41, 113, 182));
            CreatePageFooter(gr);

            ps.End();
        }
    }
    class DetailReportCreator : ReportCreatorBase {
        public DetailReportCreator(DataView dv, string[] columnsNames, int[] widths) : base(dv, columnsNames, widths) {
        }
        public void CreateReport(PrintingSystem ps, string reportName, Image imgTitle) {
            Brick brick;
            BrickGraphics gr = ps.Graph;
            ps.Begin();

            //gr.
            gr.StringFormat = gr.StringFormat.ChangeLineAlignment(StringAlignment.Center);
            gr.Font = new Font("Tahoma", 8f, FontStyle.Bold);

            int textHeight = gr.Font.Height + 2;

            //header
            int leftCell = 0;
            int headerwidth;

            gr.Modifier = BrickModifier.DetailHeader;
            gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Center);
            gr.BackColor = Color.FromArgb(71, 143, 212);
            gr.BorderColor = Color.FromArgb(27, 91, 182);

            PaddingInfo headerPadding = new PaddingInfo(0, 0, 2, 2);
            for(int j = 0; j < columnsNames.Length; j++) {
                headerwidth = widths[j];
                BorderSide borders = BorderSide.Top | BorderSide.Bottom | BorderSide.Right;
                if(j == 0)
                    borders |= BorderSide.Left;
                TextBrick textBrick = gr.DrawString(dv.Table.Columns[columnsNames[j]].Caption, SystemColors.HighlightText,
                    new RectangleF(leftCell, 0, headerwidth, textHeight + headerPadding.Top + headerPadding.Bottom), borders);
                textBrick.BorderStyle = BrickBorderStyle.Inset;
                textBrick.Padding = headerPadding;
                leftCell += headerwidth;
            }

            //strings
            gr.Modifier = BrickModifier.Detail;
            gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Near);
            gr.Font = new Font("Tahoma", 8f);

            int hGeneral = 0;
            foreach(DataRowView row in dv) {
                leftCell = 0;
                int hRow = GetRowHeight(row, gr, textHeight) + textPadding.Top + textPadding.Bottom;

                gr.BorderColor = Color.Gray;
                for(int j = 0; j < columnsNames.Length; j++) {
                    CreateColumn(gr, row, j, leftCell, hGeneral, hRow);
                    leftCell += widths[j];
                }
                hGeneral += hRow;
            }

            //hyperlink
            gr.Font = new Font("Arial", 8, FontStyle.Underline);
            gr.StringFormat = gr.StringFormat.ChangeAlignment(StringAlignment.Near);
            gr.BackColor = Color.Transparent;
            string hLink = "Show Main Report...";
            brick = gr.DrawString(hLink, Color.Blue, new RectangleF(0, hGeneral + textHeight, gr.MeasureString(hLink).Width + 5, textHeight), BorderSide.None);
            brick.Value = brick.ID = "Main";
            brick.Url = "empty";
            brick.CanPublish = false;

            CreatePageHeader(gr, reportName, imgTitle, Color.FromArgb(41, 113, 182));
            CreatePageFooter(gr);

            ps.End();
        }
    }
}

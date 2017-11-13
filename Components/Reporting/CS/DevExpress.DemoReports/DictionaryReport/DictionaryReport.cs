using System;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections.Generic;
using DevExpress.XtraPrinting;

namespace XtraReportsDemos.DictionaryReport {
    public class Report : XtraReport {
        #region Designer generated code

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel labelWord;
        private DevExpress.XtraReports.UI.XRLabel labelFirstLetter;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.XRLabel labelRangeTopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel labelRangeBottomMargin;

        #endregion

        readonly string dictionaryFileName;

        public Report(string dictionaryFileName)
            : this() {
            this.dictionaryFileName = dictionaryFileName;
            Name = Path.GetFileNameWithoutExtension(dictionaryFileName);
        }

        public Report() {
            InitializeComponent();
            labelWord.DataBindings.Add("Text", null, "Word");

            labelRangeTopMargin.DataBindings.Add("Text", null, "Word");
            labelRangeBottomMargin.DataBindings.Add("Text", null, "Word");

            labelFirstLetter.DataBindings.Add("Text", null, "FirstLetter");
            labelFirstLetter.DataBindings.Add("Bookmark", null, "FirstLetter");

            GroupHeader1.GroupFields.Add(new GroupField("FirstLetter", XRColumnSortOrder.Ascending));
            Detail.SortFields.Add(new GroupField("Word", XRColumnSortOrder.Ascending));
        }

        private void DictionaryReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            if(string.IsNullOrEmpty(dictionaryFileName))
                return;
            using(FileStream dictionaryFile = File.OpenRead(dictionaryFileName)) {
                List<WordInfo> words = new List<WordInfo>(180000);
                using(StreamReader reader = new StreamReader(dictionaryFile)) {
                    while(!reader.EndOfStream) {
                        string word = reader.ReadLine();
                        if(!string.IsNullOrEmpty(word))
                            words.Add(new WordInfo(word));
                    }
                }
                DataSource = words;
            }
        }

        private void InitializeComponent() {
            #region Designer generated code

            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.labelWord = new DevExpress.XtraReports.UI.XRLabel();
            this.labelFirstLetter = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.labelRangeTopMargin = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.labelRangeBottomMargin = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.labelWord});
            this.Detail.Height = 31;
            this.Detail.MultiColumn.ColumnCount = 3;
            this.Detail.MultiColumn.Layout = ColumnLayout.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // labelWord
            // 
            this.labelWord.BackColor = System.Drawing.Color.Transparent;
            this.labelWord.BookmarkParent = this.labelFirstLetter;
            this.labelWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.labelWord.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.labelWord.CanGrow = false;
            this.labelWord.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelWord.Location = new System.Drawing.Point(0, 0);
            this.labelWord.Name = "labelWord";
            this.labelWord.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.labelWord.Size = new System.Drawing.Size(208, 25);
            this.labelWord.Text = "cat";
            this.labelWord.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // labelFirstLetter
            // 
            this.labelFirstLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(148)))));
            this.labelFirstLetter.CanGrow = false;
            this.labelFirstLetter.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFirstLetter.ForeColor = System.Drawing.Color.White;
            this.labelFirstLetter.Location = new System.Drawing.Point(0, 0);
            this.labelFirstLetter.Name = "labelFirstLetter";
            this.labelFirstLetter.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.labelFirstLetter.Size = new System.Drawing.Size(30, 30);
            this.labelFirstLetter.Text = "A";
            this.labelFirstLetter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.labelFirstLetter});
            this.GroupHeader1.Height = 36;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.labelRangeTopMargin});
            this.TopMargin.Height = 31;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // labelRangeTopMargin
            // 
            this.labelRangeTopMargin.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelRangeTopMargin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(148)))));
            this.labelRangeTopMargin.Location = new System.Drawing.Point(0, 0);
            this.labelRangeTopMargin.Name = "labelRangeTopMargin";
            this.labelRangeTopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.labelRangeTopMargin.Size = new System.Drawing.Size(650, 25);
            this.labelRangeTopMargin.Text = "cat - dog";
            this.labelRangeTopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.labelRangeTopMargin.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.labelRangeTopMargin_PrintOnPage);
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.labelRangeBottomMargin});
            this.BottomMargin.Height = 2;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // labelRangeBottomMargin
            // 
            this.labelRangeBottomMargin.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelRangeBottomMargin.Location = new System.Drawing.Point(0, 0);
            this.labelRangeBottomMargin.Name = "labelRangeBottomMargin";
            this.labelRangeBottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.labelRangeBottomMargin.Size = new System.Drawing.Size(650, 2);
            this.labelRangeBottomMargin.Text = "cat - dog";
            this.labelRangeBottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // DictionaryReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.GroupHeader1,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 31, 2);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.DictionaryReport_BeforePrint);
            this.Version = "8.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

            #endregion
        }

        private void labelRangeTopMargin_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            if(string.IsNullOrEmpty(dictionaryFileName))
                return;
            Page page = Pages[e.PageIndex];
            foreach(VisualBrick brick in page) {
                if(object.ReferenceEquals(brick.BrickOwner, labelRangeBottomMargin)) {
                    labelRangeTopMargin.Text += " - " + brick.Text;
                    brick.Text = string.Empty;
                    return;
                }
            }
        }

        protected override void OnAfterPrint(EventArgs e) {
            if(string.IsNullOrEmpty(dictionaryFileName))
                return;
            base.OnAfterPrint(e);
            Band band = Bands[BandKind.BottomMargin];
            band.Controls.Clear();
            band = Bands[BandKind.TopMargin];
            band.Controls.Clear();
        }
    }
}

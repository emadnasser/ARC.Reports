using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Calendar;
using DevExpress.Skins;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleCalendar : TutorialControl {
        public ModuleCalendar() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModuleCalendar.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.calendar.xml";
            InitComboBoxes();
            InitValues();
            InitCellDataProvider();
            if(xtraTabControl1 != null)
                xtraTabControl1.SelectedPageChanged += OnSelectedPageChanged;
        }

        void OnSelectedPageChanged(object sender, XtraTab.TabPageChangedEventArgs e) {
            CalcContentCore();
        }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            if(xtraTabControl1 != null)
                xtraTabControl1.SelectedPageChanged -= OnSelectedPageChanged;
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            if(layoutControl1 == null) return;
            layoutControl1.Size = GetLayoutControlSize();
            CalcModuleContent();
        }
        private void InitCellDataProvider() {
            this.calendarControl2.CellStyleProvider = new MyCellStyleProvider();
        }

        protected override bool AllowCenterControls {
            get { return false; }
        }

        void InitComboBoxes() {
            icbVistaDisplayMode.Properties.Items.AddEnum(typeof(CalendarView));
            icbShowVistaClock.Properties.Items.AddEnum(typeof(DefaultBoolean));
            icbWeekNumberRule.Properties.Items.AddEnum(typeof(WeekNumberRule));
            icbShowInactiveDays.Properties.Items.AddEnum(typeof(CalendarInactiveDaysVisibility));
            icbFirstDayOfWeek.Properties.Items.AddEnum(typeof(DayOfWeek));
            icbRowCount.Properties.Items.Add(new ImageComboBoxItem("Auto", 0));
            icbRowCount.Properties.Items.Add(new ImageComboBoxItem("1", 1));
            icbRowCount.Properties.Items.Add(new ImageComboBoxItem("2", 2));
            icbRowCount.Properties.Items.Add(new ImageComboBoxItem("3", 3));
            icbColumnCount.Properties.Items.Add(new ImageComboBoxItem("Auto", 0));
            icbColumnCount.Properties.Items.Add(new ImageComboBoxItem("1", 1));
            icbColumnCount.Properties.Items.Add(new ImageComboBoxItem("2", 2));
            icbColumnCount.Properties.Items.Add(new ImageComboBoxItem("3", 3));
        }

        bool updateValues;
        void InitValues() {
            updateValues = true;
            calendarControl1.DateTime = DateTime.Now;
            icbVistaDisplayMode.EditValue = calendarControl1.CalendarView;
            icbShowVistaClock.EditValue = calendarControl1.CalendarTimeEditing;
            icbWeekNumberRule.EditValue = calendarControl1.WeekNumberRule;
            icbShowInactiveDays.EditValue = calendarControl1.InactiveDaysVisibility;
            ceShowClear.Checked = calendarControl1.ShowClearButton;
            ceShowToday.Checked = calendarControl1.ShowTodayButton;
            ceShowWeekNumbers.Checked = calendarControl1.ShowWeekNumbers;
            ceShowHeader.Checked = calendarControl1.ShowHeader;
            ceShowFooter.Checked = calendarControl1.ShowFooter;
            ceShowWeekNumbers.Checked = calendarControl1.ShowWeekNumbers;

            icbFirstDayOfWeek.EditValue = calendarControl1.FirstDayOfWeek;
            icbRowCount.SelectedIndex = 1;
            icbColumnCount.SelectedIndex = 1;

            updateValues = false;
        }

        private void ceShowHeader_CheckedChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            this.calendarControl1.ShowHeader = ceShowHeader.Checked;
        }

        private void ceShowFooter_CheckedChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            this.calendarControl1.ShowFooter = ceShowFooter.Checked;
        }

        private void ceShowMonthName_CheckedChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            this.calendarControl1.ShowMonthHeaders = ceShowMonthName.Checked;
        }

        private void ceShowClear_CheckedChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            this.calendarControl1.ShowClearButton = ceShowClear.Checked;
        }

        private void ceShowToday_CheckedChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            this.calendarControl1.ShowTodayButton = ceShowToday.Checked;
        }

        private void ceShowWeekNumbers_CheckedChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            this.calendarControl1.ShowWeekNumbers = ceShowWeekNumbers.Checked;
        }

        private void icbVistaDisplayMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            CalendarView view = (CalendarView)((ImageComboBoxItem)icbVistaDisplayMode.SelectedItem).Value;
            this.calendarControl1.CalendarView = view;
            if(view == CalendarView.Classic)
                this.ceShowToday.Enabled = true;
            else
                this.ceShowToday.Enabled = false;
        }

        private void icbShowVistaClock_SelectedIndexChanged(object sender, EventArgs e) {
            DefaultBoolean value = (DefaultBoolean)((ImageComboBoxItem)icbShowVistaClock.SelectedItem).Value;
            this.calendarControl1.CalendarTimeEditing = value;
        }

        private void icbWeekNumberRule_SelectedIndexChanged(object sender, EventArgs e) {
            WeekNumberRule value = (WeekNumberRule)((ImageComboBoxItem)icbWeekNumberRule.SelectedItem).Value;
            this.calendarControl1.WeekNumberRule = value;
        }

        private void icbFirstDayOfWeek_SelectedIndexChanged(object sender, EventArgs e) {
            DayOfWeek value = (DayOfWeek)((ImageComboBoxItem)icbFirstDayOfWeek.SelectedItem).Value;
            this.calendarControl1.FirstDayOfWeek = value;
        }

        private void icbShowInactiveDays_SelectedIndexChanged(object sender, EventArgs e) {
            CalendarInactiveDaysVisibility value = (CalendarInactiveDaysVisibility)((ImageComboBoxItem)icbShowInactiveDays.SelectedItem).Value;
            this.calendarControl1.InactiveDaysVisibility = value;
        }

        private void icbRowCount_SelectedIndexChanged(object sender, EventArgs e) {
            int value = icbRowCount.SelectedIndex;
            this.calendarControl1.RowCount = value;
            UpdateCalendarControlSizingMode();
        }

        private void UpdateCalendarControlSizingMode() {
            if(this.calendarControl1.ColumnCount == 0 || this.calendarControl1.RowCount == 0)
                MakeCalendarControlSizeable();
            else
                MakeCalendarControlAutoSize();
        }

        protected Rectangle GetCalendarClientRect() {
            int padding = 32;
            return new Rectangle(this.xtraTabPage1.ClientRectangle.X + padding, this.xtraTabPage1.ClientRectangle.Y + padding,
                this.xtraTabPage1.Width - GetLayoutControlSize().Width - padding * 3, this.xtraTabPage1.Height - padding * 2);
        }

        private void MakeCalendarControlAutoSize() {
            this.calendarControl1.AutoSize = true;
            this.calendarControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Rectangle rect = GetCalendarClientRect();
            this.calendarControl1.Location = new Point(rect.X + (rect.Width - this.calendarControl1.Width) / 2, rect.Y + (rect.Height - this.calendarControl1.Height) / 2);
        }

        private void MakeCalendarControlSizeable() {
            this.calendarControl1.AutoSize = false;
            this.calendarControl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Rectangle rect = GetCalendarClientRect();
            this.calendarControl1.Bounds = rect;
        }

        private void icbColumnCount_SelectedIndexChanged(object sender, EventArgs e) {
            int value = icbColumnCount.SelectedIndex;
            this.calendarControl1.ColumnCount = value;
            UpdateCalendarControlSizingMode();
        }

        static readonly int Indent = 16;
        private void xtraTabPage1_Resize(object sender, EventArgs e) {
            CalcModuleContent();
        }

        protected void CalcModuleContent() {
            if(layoutControl1 == null) return;
            Size layoutControlBestSize = GetLayoutControlSize();
            this.layoutControl1.Location = new Point(this.xtraTabPage1.Width - layoutControlBestSize.Width - Indent, this.xtraTabPage1.ClientRectangle.Y + Math.Max(Indent, (this.xtraTabPage1.ClientRectangle.Height - layoutControlBestSize.Height) / 2));
            UpdateCalendarControlSizingMode();
        }
        protected Size GetLayoutControlSize() {
            Size size = layoutControl1.GetPreferredSize(Size.Empty);
            return new Size(Math.Min(size.Width, this.xtraTabPage1.ClientRectangle.Width - 2 * Indent), Math.Min(size.Height, this.xtraTabPage1.ClientRectangle.Height - 2 * Indent));
        }

        private void calendarControl1_Resize(object sender, EventArgs e) {
            UpdateCalendarControlSizingMode();
        }

        private void calendarControl2_ContextButtonCustomize(object sender, CalendarContextButtonCustomizeEventArgs e) {
            MyCellStyleProvider provider = (MyCellStyleProvider)this.calendarControl2.CellStyleProvider;
            MyCustomCellData data = provider.GetCell(e.Cell.Date);
            if(data == null || string.IsNullOrEmpty(data.InfoText)) {
                e.Item.Visibility = ContextItemVisibility.Hidden;
                return;
            }
            e.Item.AppearanceNormal.ForeColor = e.Item.AppearanceHover.ForeColor = e.Cell.Appearance.ForeColor;
            e.Item.AllowGlyphSkinning = DefaultBoolean.True;
            e.Item.Tag = data;
            e.Item.Glyph = data.InfoGlyph;
        }

        private void calendarControl2_ContextButtonClick(object sender, ContextItemClickEventArgs e) {
            MyCustomCellData data = (MyCustomCellData)e.Item.Tag;
            if(data == null)
                return;
            this.memoEdit1.Text = data.InfoText;
            this.flyoutPanel1.ShowBeakForm(new Point(e.ScreenBounds.X + e.ScreenBounds.Width / 2, e.ScreenBounds.Top - 5));
        }

        private void calendarControl1_SelectionChanged(object sender, EventArgs e) {
            this.listBoxControl1.BeginUpdate();
            try {
                this.listBoxControl1.Items.Clear();
                foreach(DateRange range in this.calendarControl1.SelectedRanges) { 
                    this.listBoxControl1.Items.Add(range.StartDate.ToShortDateString() + " - " + range.EndDate.ToShortDateString());
                }
            }
            finally {
                this.listBoxControl1.EndUpdate();
            }
        }
    }

    public enum CellDataType { Undefined, Work, Family, Event }

    public class MyCustomCellData {
        public DateTime Date { get; set; }
        public Color ForeColor { get; set; }
        public Image InfoGlyph { get; set; }
        public string InfoText { get; set; }
        public CellDataType CellType { get; set; }

        public string Description { get; set; }
        public bool SpecialDate { get; set; }
    }

    public class MyCellStyleProvider : ICalendarCellStyleProvider {

        List<MyCustomCellData> cells;
        protected List<MyCustomCellData> Cells {
            get {
                if(cells == null)
                    cells = CreateCells();
                return cells;
            }
        }

        protected virtual List<MyCustomCellData> CreateCells() {
            List <MyCustomCellData> res = new List<MyCustomCellData>();

            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 1), CellType = CellDataType.Work, InfoText = "Mexico City. Talks with Pure Products Inc.", InfoGlyph = DevExpress.XtraEditors.Demos.Properties.Resources.Flight });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 2), CellType = CellDataType.Work });

            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 4), SpecialDate = true, Description = "INDEPENDENCE DAY" });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 6), CellType = CellDataType.Family, InfoText = "New York Knicks vs Orlando Magic", InfoGlyph = DevExpress.XtraEditors.Demos.Properties.Resources.Game });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 13), CellType = CellDataType.Family });

            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 10), CellType = CellDataType.Work, InfoText = "Call Susanne Guper, New warehouse issues", InfoGlyph = DevExpress.XtraEditors.Demos.Properties.Resources.Meeting });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 16), Description = "JOHN\nBIRTHDAY", SpecialDate = true });

            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 21), CellType = CellDataType.Event  });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 22), Description = "MARY\nBIRTHDAY", SpecialDate = true });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 29), CellType = CellDataType.Event });

            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 17), CellType = CellDataType.Event, InfoText = "Flatiron Club", InfoGlyph = DevExpress.XtraEditors.Demos.Properties.Resources.Party });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 30), CellType = CellDataType.Family, InfoText = "Slow Food Farmers' Market", InfoGlyph = DevExpress.XtraEditors.Demos.Properties.Resources.Shopping });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 31), CellType = CellDataType.Family });

            return res;
        }

        public MyCustomCellData GetCell(DateTime date) {
            return Cells.FirstOrDefault((c) => c.Date.Date == date.Date);
        }
        void ICalendarCellStyleProvider.UpdateAppearance(CalendarCellStyle cell) {
            MyCustomCellData cellInfo = GetCell(cell.Date);
            if(cellInfo == null)
                return;

            cell.Description = cellInfo.Description;
            if(cell.Description != null) { 
                cell.DescriptionAppearance = (AppearanceObject)cell.Appearance.Clone();
                cell.DescriptionAppearance.Font = new Font(cell.Appearance.Font.FontFamily, 7.0f, FontStyle.Bold);
                cell.DescriptionAppearance.TextOptions.WordWrap = WordWrap.Wrap;
            }
            if(!cellInfo.ForeColor.IsEmpty)
                cell.Appearance.ForeColor = cellInfo.ForeColor;
            if(cell.State == Utils.Drawing.ObjectState.Normal) {
                cell.Appearance.BackColor = GetCellColor(cellInfo, cell); // cellInfo.BackColor;
            }
            if(cellInfo.SpecialDate)
                cell.Appearance.Font = new Font(cell.Appearance.Font.FontFamily, 20.0f, FontStyle.Bold);
        }

        protected virtual Color GetCellColor(MyCustomCellData cellData, CalendarCellStyle cellStyle) {
            switch(cellData.CellType) { 
                case CellDataType.Event:
                    return SchedulerSkins.GetSkin(cellStyle.PaintStyle.LookAndFeel).Colors.GetColor("ResourceColor02", Color.FromArgb(255, 209, 240, 253));
                case CellDataType.Family:
                    return SchedulerSkins.GetSkin(cellStyle.PaintStyle.LookAndFeel).Colors.GetColor("ResourceColor03", Color.FromArgb(255, 229, 253, 177));
                case CellDataType.Work:
                    return SchedulerSkins.GetSkin(cellStyle.PaintStyle.LookAndFeel).Colors.GetColor("ResourceColor04", Color.FromArgb(255, 255, 228, 239));
            }
            return Color.Empty;
        }
    } 
}

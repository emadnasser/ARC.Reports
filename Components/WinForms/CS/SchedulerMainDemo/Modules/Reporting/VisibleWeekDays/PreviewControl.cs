using System;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraScheduler.Services;
using DevExpress.XtraScheduler.Demos.Reporting.DateFormatting;

namespace DevExpress.XtraScheduler.Demos.Reporting.VisibleWeekDays {

    public class PreviewControl : ReportPreviewControlBase {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraScheduler.UI.WeekDaysCheckEdit weekDaysCheckEdit1;
        WeekDays visibleWeekDays = WeekDays.EveryDay;
        private MonthReport monthReport;
        private DevExpress.XtraEditors.RadioGroup rgrpView;
        private XtraBars.Navigation.NavigationPane navigationPaneSettings;
        private XtraBars.Navigation.NavigationPage navigationPageSettings;
        private XtraLayout.LayoutControl layoutControlSettings;
        private XtraLayout.LayoutControlGroup layoutControlGroupSettings;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DayReport dayReport;

		public PreviewControl()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			InitializeControlValues();            
		}
        SchedulerViewType ViewType { get { return (SchedulerViewType)rgrpView.EditValue; } }
        MonthReport MonthReport { get { return monthReport; } }
        DayReport DayReport { get { return dayReport; } }
        WeekDays VisibleWeekDays { get { return visibleWeekDays; } set { visibleWeekDays = value; } }
        
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
        protected override void CreateReports() {
            if (monthReport != null)
                monthReport.Dispose();
            this.monthReport = new MonthReport();
            if (dayReport != null)
                dayReport.Dispose();
            this.dayReport = new DayReport();
        }
        protected override XtraSchedulerReport GetActiveReport() {
            if (ViewType.Equals(SchedulerViewType.Month))
                return MonthReport;
            else
                return DayReport;
        }
        protected override void InitAdapterTimeInterval() {
            StoragePrintAdapter.TimeInterval = new TimeInterval(BaseDate, TimeSpan.FromDays(7 * 8));
        }
		void InitializeControlValues() {
            IVisibleWeekDaysReport report = (IVisibleWeekDaysReport)GetActiveReport();
            this.VisibleWeekDays = report.VisibleWeekDays;

		}
		protected override void UpdateReportProperties(XtraSchedulerReport otherReport) {
			base.UpdateReportProperties(otherReport);
            if (ViewType.Equals(SchedulerViewType.Month))
                ((MonthReport)otherReport).VisibleWeekDays = this.VisibleWeekDays;
            else {
                DayReport dayReport = (DayReport)otherReport;
                dayReport.VisibleWeekDays = this.VisibleWeekDays;
                dayReport.DayCount = CalculateDayCount();
            }
            UpdateFormatServices();
		}
        private int CalculateDayCount() {            
            int dayCount = DevExpress.XtraScheduler.Native.DateTimeHelper.ToDayOfWeeks(this.VisibleWeekDays).Length;
            return dayCount == 0 ? 7 : dayCount;
        }
		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlSettings = new DevExpress.XtraLayout.LayoutControl();
            this.weekDaysCheckEdit1 = new DevExpress.XtraScheduler.UI.WeekDaysCheckEdit();
            this.rgrpView = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroupSettings = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.navigationPaneSettings = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPageSettings = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.fSchedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStoragePrintAdapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSettings)).BeginInit();
            this.layoutControlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekDaysCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrpView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneSettings)).BeginInit();
            this.navigationPaneSettings.SuspendLayout();
            this.navigationPageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.Size = new System.Drawing.Size(495, 441);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(7, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(184, 22);
            this.btnEdit.StyleController = this.layoutControlSettings;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // layoutControlSettings
            // 
            this.layoutControlSettings.Controls.Add(this.weekDaysCheckEdit1);
            this.layoutControlSettings.Controls.Add(this.rgrpView);
            this.layoutControlSettings.Controls.Add(this.btnEdit);
            this.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlSettings.Location = new System.Drawing.Point(0, 0);
            this.layoutControlSettings.Name = "layoutControlSettings";
            this.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1051, 187, 650, 400);
            this.layoutControlSettings.Root = this.layoutControlGroupSettings;
            this.layoutControlSettings.Size = new System.Drawing.Size(198, 397);
            this.layoutControlSettings.TabIndex = 0;
            this.layoutControlSettings.Text = "layoutControl1";
            // 
            // weekDaysCheckEdit1
            // 
            this.weekDaysCheckEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weekDaysCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.weekDaysCheckEdit1.Appearance.Options.UseBackColor = true;
            this.weekDaysCheckEdit1.Location = new System.Drawing.Point(13, 161);
            this.weekDaysCheckEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.weekDaysCheckEdit1.MaximumSize = new System.Drawing.Size(0, 100);
            this.weekDaysCheckEdit1.MinimumSize = new System.Drawing.Size(0, 100);
            this.weekDaysCheckEdit1.Name = "weekDaysCheckEdit1";
            this.weekDaysCheckEdit1.Size = new System.Drawing.Size(172, 100);
            this.weekDaysCheckEdit1.TabIndex = 6;
            this.weekDaysCheckEdit1.WeekDaysChanged += new System.EventHandler(this.weekDaysCheckEdit1_WeekDaysChanged_1);
            // 
            // rgrpView
            // 
            this.rgrpView.EditValue = DevExpress.XtraScheduler.SchedulerViewType.Month;
            this.rgrpView.Location = new System.Drawing.Point(13, 67);
            this.rgrpView.MaximumSize = new System.Drawing.Size(0, 50);
            this.rgrpView.MinimumSize = new System.Drawing.Size(0, 50);
            this.rgrpView.Name = "rgrpView";
            this.rgrpView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgrpView.Properties.Appearance.Options.UseBackColor = true;
            this.rgrpView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgrpView.Properties.Columns = 1;
            this.rgrpView.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerViewType.Day, "Day"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerViewType.Month, "Month")});
            this.rgrpView.Size = new System.Drawing.Size(172, 50);
            this.rgrpView.StyleController = this.layoutControlSettings;
            this.rgrpView.TabIndex = 81;
            this.rgrpView.SelectedIndexChanged += new System.EventHandler(this.rgrpView_SelectedIndexChanged_1);
            // 
            // layoutControlGroupSettings
            // 
            this.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupSettings.GroupBordersVisible = false;
            this.layoutControlGroupSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.emptySpaceItem3,
            this.emptySpaceItem1});
            this.layoutControlGroupSettings.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupSettings.Name = "Root";
            this.layoutControlGroupSettings.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(198, 397);
            this.layoutControlGroupSettings.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(188, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 264);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(188, 123);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 36);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(188, 84);
            this.layoutControlGroup1.Text = "Report Type";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.rgrpView;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(176, 54);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 130);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup2.Size = new System.Drawing.Size(188, 134);
            this.layoutControlGroup2.Text = "Visible Weekdays";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.weekDaysCheckEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(176, 104);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(188, 10);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(188, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // navigationPaneSettings
            // 
            this.navigationPaneSettings.Controls.Add(this.navigationPageSettings);
            this.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationPaneSettings.Location = new System.Drawing.Point(495, 0);
            this.navigationPaneSettings.Name = "navigationPaneSettings";
            this.navigationPaneSettings.PageProperties.ShowExpandButton = false;
            this.navigationPaneSettings.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageSettings});
            this.navigationPaneSettings.RegularSize = new System.Drawing.Size(225, 441);
            this.navigationPaneSettings.SelectedPage = this.navigationPageSettings;
            this.navigationPaneSettings.Size = new System.Drawing.Size(225, 441);
            this.navigationPaneSettings.TabIndex = 11;
            this.navigationPaneSettings.Text = "navigationPane1";
            // 
            // navigationPageSettings
            // 
            this.navigationPageSettings.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.navigationPageSettings.Caption = "Options";
            this.navigationPageSettings.Controls.Add(this.layoutControlSettings);
            this.navigationPageSettings.Name = "navigationPageSettings";
            this.navigationPageSettings.Size = new System.Drawing.Size(198, 397);
            // 
            // PreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationPaneSettings);
            this.Name = "PreviewControl";
            this.Size = new System.Drawing.Size(720, 441);
            this.Controls.SetChildIndex(this.navigationPaneSettings, 0);
            this.Controls.SetChildIndex(this.printControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fSchedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStoragePrintAdapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSettings)).EndInit();
            this.layoutControlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weekDaysCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrpView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneSettings)).EndInit();
            this.navigationPaneSettings.ResumeLayout(false);
            this.navigationPageSettings.ResumeLayout(false);
            this.ResumeLayout(false);

		}
        #endregion
        void btnEdit_Click(object sender, EventArgs e) {
            CustomDesignForm designForm = new CustomDesignForm();
            XtraSchedulerReport report = GetActiveReport();
            if (report == null)
                return;

            designForm.OpenReport(report);
            PreventUpdate = true;
            try {
                ShowDesignerForm(designForm, this.FindForm());
            } finally {
                PreventUpdate = false;
            }
            designForm.Dispose();

            CreateReports();
            UpdateActiveReport();
        }
        private void weekDaysCheckEdit1_WeekDaysChanged_1(object sender, EventArgs e) {
            this.VisibleWeekDays = weekDaysCheckEdit1.WeekDays;
            UpdateActiveReport();
        }        

        private void rgrpView_SelectedIndexChanged_1(object sender, EventArgs e) {
            this.VisibleWeekDays = weekDaysCheckEdit1.WeekDays;
            UpdateActiveReport();
        }
        
        public void UpdateFormatServices() {
            StoragePrintAdapter.RemoveService(typeof(IHeaderCaptionService));
            IHeaderCaptionService customHeaderCaptionService = new CustomHeaderCaptionService("MM/dd, ddd");
            StoragePrintAdapter.AddService(typeof(IHeaderCaptionService), customHeaderCaptionService);                       
        }
	}
    public interface IVisibleWeekDaysReport {
        WeekDays VisibleWeekDays { get; set;}        
    }
}

﻿using System;
using System.Drawing;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraGauges.Core.Base;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Base;
using DevExpress.XtraGrid.Columns;

namespace DevExpress.XtraGrid.Demos {
    public partial class GaugeEditor : TutorialControl {
        TasksWithCategoriesDatasource gcDataSource;
        public GaugeEditor() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\ModulesAnyControl\\GaugeEditor.cs;";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.GaugeEditor.xml";
            InitDefaultColors();
            InitPanelProperties();
            gcDataSource = new TasksWithCategoriesDatasource(gridControl1);
            CreateGaugeEdit(gaugeColumn, gaugeControl1);
        }
        //<cpActive>
        Color InTimeColor { get; set; }
        //</cpActive>
        Color OutOfTimeColor { get; set; }
        Color LowPriorityColor { get; set; }
        Color MediumPriorityColor { get; set; }
        Color HighPriorityColor { get; set; }
        void InitPanelProperties() {
            cpHighPriority.Color = HighPriorityColor;
            cpMediumPriority.Color = MediumPriorityColor;
            cpLowPriority.Color = LowPriorityColor;
            cpOverDue.Color = OutOfTimeColor;
            cpActive.Color = InTimeColor;
            cpActive.ColorChanged += OnCPActiveChanged;
            cpActive.Closed += cpClosed;
            cpOverDue.ColorChanged += OnCPOverDueChanged;
            cpOverDue.Closed += cpClosed;
            cpLowPriority.ColorChanged += OnCPLowPriorityChanged;
            cpLowPriority.Closed += cpClosed;
            cpMediumPriority.ColorChanged += OnCPMediumPriorityChanged;
            cpMediumPriority.Closed += cpClosed;
            cpHighPriority.ColorChanged += OnCPHighPriorityChanged;
            cpHighPriority.Closed += cpClosed;
        }
        void OnCPHighPriorityChanged(object sender, EventArgs e) {
            HighPriorityColor = cpHighPriority.Color;
        }
        void OnCPMediumPriorityChanged(object sender, EventArgs e) {
            MediumPriorityColor = cpMediumPriority.Color;
        }
        void OnCPLowPriorityChanged(object sender, EventArgs e) {
            LowPriorityColor = cpLowPriority.Color;
        }
        void OnCPOverDueChanged(object sender, EventArgs e) {
            OutOfTimeColor = cpOverDue.Color;
        }
        //<cpActive>
        void OnCPActiveChanged(object sender, EventArgs e) {
            InTimeColor = cpActive.Color;
        }
        void cpClosed(object sender, XtraEditors.Controls.ClosedEventArgs e) {
            layoutViewCard1.Update();
        }
        //</cpActive>
        //</layoutControlGroup5>
        void InitDefaultColors() {
            OutOfTimeColor = Color.FromArgb(206, 5, 5);
            InTimeColor = Color.FromArgb(137, 137, 137);
            LowPriorityColor = Color.FromArgb(42, 174, 85);
            MediumPriorityColor = Color.FromArgb(253, 163, 6);
            HighPriorityColor = Color.FromArgb(206, 5, 5);
        }
        //<gridControl1>
        static void CreateGaugeEdit(GridColumn column, GaugeControl gaugeControl) {
            if(column.ColumnEdit != null) return;
            RepositoryItemAnyControl item = new RepositoryItemAnyControl();
            item.Control = gaugeControl;
            column.View.GridControl.RepositoryItems.Add(item);
            column.ColumnEdit = item;
        }
        void layoutView1_CustomUnboundColumnData(object sender, Views.Base.CustomColumnDataEventArgs e) {
            Task task = (e.Row as Task);
            ColorScheme colorScheme = new ColorScheme();
            if(e.IsGetData) {
                colorScheme.Color = GetColorByDay(task.DueDate);
                colorScheme.TargetElements = gaugeControl1.ColorScheme.TargetElements;
                e.Value = new ExtendedEditValue() { Value = task.PercentComplete, ColorScheme = colorScheme, ImageColor = GetColorByPriority(task.Priority) };
            }
        }
        //</gridControl1>
        Color GetColorByDay(DateTime dueDate) {
            if(dueDate < DateTime.Today)
                return OutOfTimeColor;
            return InTimeColor;
        }
        Color GetColorByPriority(Priority priority) {
            if(priority == Priority.Low)
                return LowPriorityColor;
            if(priority == Priority.Medium)
                return MediumPriorityColor;
            return HighPriorityColor;
        }
        //<gridControl1>
        class ExtendedEditValue : IValueProvider, IImageColorProvider, IColorSchemeProvider {
            public Color ImageColor { get; set; }
            public ColorScheme ColorScheme { get; set; }
            public object Value { get; set; }
        }
        //</gridControl1>
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Xml.Linq;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/DataAnalysis/BasicFinancialIndicatorsControl(.SL).xaml"),
     CodeFile("Modules/DataAnalysis/BasicFinancialIndicatorsControl.xaml.(cs)")]
    public partial class BasicFinancialIndicatorsControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public BasicFinancialIndicatorsControl() {
            InitializeComponent();
        }

        void ComboBoxEdit_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            switch (cbeIndicatorKind.SelectedIndex) {
                case 0:
                    ShowTrendLines();
                    break;
                case 1:
                    ShowRegressionLine();
                    break;
                case 2:
                    ShowFibonacciRetracement();
                    break;
                case 3:
                    ShowFibonacciFans();
                    break;
                case 4:
                    ShowFibonacciArcs();
                    break;
            }
        }
        void ShowFibonacciArcs() {
            HideAllIndicators();
            fibonacciArcs.Visible = true;
        }
        void ShowFibonacciFans() {
            HideAllIndicators();
            fibonacciFans.Visible = true;
        }
       void ShowFibonacciRetracement() {
            HideAllIndicators();
            fibonacciRetracement.Visible = true;
        }
        void ShowRegressionLine() {
            HideAllIndicators();
            regressionLine.Visible = true;
        }
        void ShowTrendLines() {
            HideAllIndicators();
            trendLine1.Visible = true;
            trendLine2.Visible = true;
        }
        void HideAllIndicators() {
            foreach (Indicator indicator in series.Indicators)
                indicator.Visible = false;
        }

        public override bool SupportSidebarContent() {
            return false;
        }
    }
}

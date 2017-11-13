using System;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.DataBinding {
    public partial class SummarizationDemo : ChartDemoBase2D {
        static SeriesPoint[] CalcStdDev(Series series, object argument, string[] functionArguments, DataSourceValues[] values, object[] colors) {
            double[] amount = new double[values.Length];
            double sum = 0.0;
            for (int i = 0; i < values.Length; i++) {
                amount[i] = Convert.ToDouble(values[i][functionArguments[0]]);
                sum += amount[i];
            }
            double averageAmount = sum / values.Length;
            double standardDeviationSquareSum = 0.0;
            for (int i = 0; i < values.Length; i++) {
                double deviation = amount[i] - averageAmount;
                standardDeviationSquareSum += deviation * deviation;
            }
            return new SeriesPoint[] { new SeriesPoint(argument, Math.Sqrt(standardDeviationSquareSum / values.Length)) };
        }

        ChartControl chart;

        public override ChartControl ChartControl { get { return chart; } }

        public SummarizationDemo() {
            InitializeComponent();
            ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries;
            SummaryFunctionArgumentDescription argumentDescription = new SummaryFunctionArgumentDescription("Argument", ScaleType.Numerical);
            chart.RegisterSummaryFunction("STDDEV", "STDDEV", 1, new SummaryFunctionArgumentDescription[] { argumentDescription }, CalcStdDev);
            chart.DataSource = dS41.Categories;
            string path = Utils.GetRelativePath("nwind.mdb");
            if (path.Length > 0)
                Utils.SetConnectionString(oleDbConnection1, path);
            else {
                XtraMessageBox.Show("The \"nwind.mdb\" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                oleDbDataAdapter1.Fill(dS41);
            }
            catch (OleDbException e) {
                XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            chart.DataAdapter = oleDbDataAdapter1;
            comboBoxFunction.SelectedIndex = 0;
        }

        void SetTitleText(string text) {
            if (chart.Titles.Count > 0)
                chart.Titles[0].Text = text;
        }
        void SetAxisYTitle(string text) {
            XYDiagram diagram = chart.Diagram as XYDiagram;
            if (diagram != null)
                diagram.AxisY.Title.Text = text;
        }
        void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e) {
            string functionName = (string)comboBoxFunction.EditValue;
            int suffixIndex = functionName.IndexOf(" (Custom)");
            if (suffixIndex >= 0)
                functionName = functionName.Substring(0, suffixIndex);
            switch (functionName) {
                case "SUM":
                    SetTitleText("Sales Volume");
                    SetAxisYTitle("Volume (USD)");
                    break;
                case "MIN":
                    SetTitleText("Minimal Order Amount");
                    SetAxisYTitle("Amount (USD)");
                    break;
                case "MAX":
                    SetTitleText("Maximal Order Amount");
                    SetAxisYTitle("Amount (USD)");
                    break;
                case "AVERAGE":
                    SetTitleText("Average Order Amount");
                    SetAxisYTitle("Amount (USD)");
                    break;
                case "COUNT":
                    SetTitleText("Overall Orders Count");
                    SetAxisYTitle("Count");
                    break;
                case "STDDEV":
                    SetTitleText("Standard Deviation from Average Order Amout");
                    SetAxisYTitle("Deviation (USD)");
                    break;
            }
            if (chart.Series.Count > 0)
                if (functionName == "COUNT")
                    chart.Series[0].SummaryFunction = functionName + "()";
                else
                    chart.Series[0].SummaryFunction = functionName + "([Sum])";
            ChartControl.Animate();
        }
    }
}

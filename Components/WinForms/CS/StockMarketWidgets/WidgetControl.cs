using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockMarketWidgets.StockDataServiceReference;

namespace StockMarketWidgets {
    public partial class WidgetControl : UserControl {
        Timer updateTimer = new Timer();
        List<CompanyData> dataCore;
        public WidgetControl() {
            InitializeComponent();
            updateTimer.Interval = 1000;
            updateTimer.Tick += OnTimerTick;
            emptyShader = this.stateIndicatorComponent1.Shader;
            coloredShader = this.stateIndicatorComponent1.Shader = new DevExpress.XtraGauges.Core.Drawing.ComplexShader("Opacity[1] Colors[Style1:#BE648C;Style2:#BE648C]");
        }
        public List<CompanyData> Data {
            get { return dataCore; }
            set {
                dataCore = value;
                OnTimerTick(this, EventArgs.Empty);
                updateTimer.Start();
            }
        }
        public string CompanyNameText {
            get { return labelControl1.Text; }
            set { labelControl1.Text = value; }
        }
        int index = 0;
        DevExpress.XtraGauges.Core.Drawing.BaseColorShader emptyShader;
        DevExpress.XtraGauges.Core.Drawing.BaseColorShader coloredShader;
        void OnTimerTick(object sender, EventArgs e) {
            if(IsDisposed) { updateTimer.Stop(); return; }
            labelControl2.Text = Data[index].HighPrice.ToString();
            labelControl3.Text = Data[index].LowPrice.ToString();
            labelControl4.Text = Data[index].Data.OpenP.ToString();
            labelControl5.Text = Data[index].Data.CloseP.ToString();
            labelControl11.Text = Data[index].Data.Volumne.ToString();
            if(index > 0) {
                stateIndicatorComponent1.StateIndex = Data[index - 1].Data.Price > Data[index].Data.Price ? 0 : 1;
                if(stateIndicatorComponent1.StateIndex != 0)
                    this.stateIndicatorComponent1.Shader = coloredShader;
                else
                    this.stateIndicatorComponent1.Shader = emptyShader;
            }
            index++;
            if(index == dataCore.Count)
                index = 0;
        }
    }
}

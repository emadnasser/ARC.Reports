using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Base;
using DevExpress.XtraGauges.Win.Gauges.Digital;
using DevExpress.XtraLayout;

namespace DevExpress.XtraGauges.Demos {
    public partial class AnimationScale : TutorialControl {
        Dictionary<string, IEasingFunction> functions = new Dictionary<string, IEasingFunction>();
        Dictionary<string, EasingMode> modes = new Dictionary<string, EasingMode>();
        public AnimationScale() {
            InitializeComponent();
            InitData();
            this.Load += new EventHandler(OnLoad);
        }

        private void InitData() {
            functions.Add("BackEase", new BackEase());
            functions.Add("ElasticEase", new ElasticEase());
            functions.Add("PowerEase", new PowerEase(1));
            functions.Add("QuadraticEase", new QuadraticEase());
            functions.Add("QuinticEase", new QuinticEase());
            functions.Add("SineEase", new SineEase());
            functions.Add("ExponentialEase", new ExponentialEase());
            functions.Add("CircleEase", new CircleEase());
            functions.Add("BounceEase", new BounceEase());
            functions.Add("CubicEase", new CubicEase());
            modes.Add("EaseIn", EasingMode.EaseIn);
            modes.Add("EaseOut", EasingMode.EaseOut);
            modes.Add("EaseInOut", EasingMode.EaseInOut);
            foreach(var item in modes) {
                EaseFuction.Properties.Items.Add(item.Key);
            }
            arcScaleComponent1.EnableAnimation = true;
            linearScaleComponent1.EnableAnimation = true;
            EaseFuction.SelectedIndex = 0;
        }
        private void ChangeEaseMode(object sender, EventArgs e) {
            arcScaleComponent1.EasingMode = modes[EaseFuction.SelectedItem.ToString()];
            linearScaleComponent1.EasingMode = modes[EaseFuction.SelectedItem.ToString()];
        }
        private void ChangeEaseFunction(object sender, EventArgs e) {
            RadioButton radioButton = sender as RadioButton;
            if(radioButton.Checked) {
                arcScaleComponent1.EasingFunction = functions[((RadioButton)sender).Name];
                linearScaleComponent1.EasingFunction = functions[((RadioButton)sender).Name];
            }
        }
        #region Animation
        int animationLockCounterCore = 0;
        Timer timer;
        Random random = new Random(DateTime.Now.Millisecond);

        bool IsAnimationLocked { get { return animationLockCounterCore > 0; } }
        void OnLoad(object sender, EventArgs e) {
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(OnTimerTick);
            timer.Start();
        }
        void OnTimerTick(object sender, EventArgs e) {
            if(IsAnimationLocked) return;
            LayoutGroup activePage = tabbedControlGroup2.SelectedTabPage;
            if(!tabbedControlGroup2.Visible || activePage == null) return;
            LockAnimation();
            List<GaugeControl> gauges = CollectChildGauges();
            foreach(GaugeControl gauge in gauges) DoAnimation(gauge);
            UnlockAnimation();
        }
        void UnlockAnimation() {
            animationLockCounterCore--;
        }
        void LockAnimation() {
            animationLockCounterCore++;
        }
        void DoAnimation(GaugeControl gauge) {
            foreach(IGauge gb in gauge.Gauges) {
                ICircularGauge cGauge = gb as ICircularGauge;
                if(cGauge != null) {
                    foreach(IScale scale in cGauge.Scales) scale.Value = AnimateScaleValue(scale);
                }
                ILinearGauge lGauge = gb as ILinearGauge;
                if(lGauge != null) {
                    foreach(IScale scale in lGauge.Scales) scale.Value = AnimateScaleValue(scale);
                }
            }
        }
        List<GaugeControl> CollectChildGauges() {
            List<GaugeControl> result = new List<GaugeControl>();
            foreach(var item in layoutControl1.Controls) {
                if(item is GaugeControl)
                    result.Add((GaugeControl)item);
            }
            return result;
        }
        float AnimateScaleValue(IScale scale) {
            Random r = new Random();
            return r.Next(0,100);
        }
        string AnimateStringValue(DigitalGauge dGauge) {
            int value = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            return value.ToString();
        }

        #endregion
    }
}

using System;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Core.Primitive;
using DevExpress.XtraGauges.Core.Base;
using System.Collections.Generic;
using DevExpress.XtraGauges.Win.Base;

namespace DevExpress.XtraGauges.Demos {
    public partial class CustomDrawFeature : TutorialControl {
        public CustomDrawFeature() {
            InitializeComponent();
            ceAllowCustomDraw.Checked = true;
            Load += OnLoad;
            //
            arcScale.CustomDrawElement += Scale_CustomDrawElement;
            linearScale.CustomDrawElement += Scale_CustomDrawElement;
            arcScaleNeedle.CustomDrawElement += arcScaleNeedle_CustomDrawElement;
            arcScaleBackgroundLayer.CustomDrawElement += arcScaleBackgroundLayer_CustomDrawElement;
            linearScaleLevel.CustomDrawElement += linearScaleLevel_CustomDrawElement;
            linearScaleBackgroundLayer.CustomDrawElement += linearScaleBackgroundLayer_CustomDrawElement;
        }
        public bool IsDisposing { get; set; }
        protected override void Dispose(bool disposing) {
            IsDisposing = true;
            if(disposing && (components != null)) {
                components.Dispose();
                timer.Stop();
            }
            base.Dispose(disposing);
        }
        bool handleCustomDraw = false;
        void ceAllowCustomDraw_CheckedChanged(object sender, EventArgs e) {
            handleCustomDraw = ceAllowCustomDraw.Checked;
            arcScaleBackgroundLayer.Self.ResetCache(CacheKeys.RenderedImage);
            linearScaleBackgroundLayer.Self.ResetCache(CacheKeys.RenderedImage);
        }
        #region CustomDraw
        void Scale_CustomDrawElement(object sender, CustomDrawElementEventArgs e) {
            if(!handleCustomDraw) return;
            e.Handled = true;
        }
        Pen pen = new Pen(Color.Black, 2f);
        void linearScaleLevel_CustomDrawElement(object sender, CustomDrawElementEventArgs e) {
            if(!handleCustomDraw) return;
            for(int i = 0; i < 5; i++)
                e.Context.Graphics.DrawLine(Pens.DarkGray, 60, 75 + i * 25, 190, 75 + i * 25);
            float pos = 75 + (float)Math.Round(linearScale.Percent * 8f) * 12.5f;
            e.Context.Graphics.FillEllipse(Brushes.Black, 102, pos - 8, 19, 16);
            e.Context.Graphics.DrawLine(pen, 120, pos - 45, 120, pos);
            e.Context.Graphics.FillEllipse(Brushes.Black, 127, pos - 20.5f, 19, 16);
            e.Context.Graphics.DrawLine(pen, 145, pos - 45, 145, pos - 12.5f);
            e.Context.Graphics.DrawLine(pen, 120, pos - 44, 145, pos - 44);
            e.Context.Graphics.DrawLine(pen, 120, pos - 36, 145, pos - 36);
            e.Handled = true;
        }
        void linearScaleBackgroundLayer_CustomDrawElement(object sender, CustomDrawElementEventArgs e) {
            if(!handleCustomDraw) return;
            e.Handled = true;
        }
        void arcScaleBackgroundLayer_CustomDrawElement(object sender, CustomDrawElementEventArgs e) {
            if(!handleCustomDraw) return;
            RectangleF bounds = RectangleF.Inflate(e.Info.BoundBox, -15, -15);
            e.Context.Graphics.FillEllipse(Brushes.Black, bounds);
            bounds.Inflate(-2, -2);
            e.Context.Graphics.SetClip(new RectangleF(bounds.Left + bounds.Width * 0.5f, bounds.Top, bounds.Width * 0.5f, bounds.Height));
            e.Context.Graphics.FillEllipse(Brushes.White, bounds);
            e.Context.Graphics.ResetClip();
            e.Context.Graphics.FillEllipse(Brushes.White, new RectangleF(
                bounds.Left + bounds.Width * 0.25f, bounds.Top,
                bounds.Width * 0.5f, bounds.Height * 0.5f));
            e.Context.Graphics.FillEllipse(Brushes.Black, new RectangleF(
                bounds.Left + bounds.Width * 0.25f, bounds.Top + bounds.Height * 0.5f,
                bounds.Width * 0.5f, bounds.Height * 0.5f));
            e.Handled = true;
        }
        void arcScaleNeedle_CustomDrawElement(object sender, CustomDrawElementEventArgs e) {
            if(!handleCustomDraw) return;
            e.Context.Graphics.FillEllipse(Brushes.White, new RectangleF(50, 112.5f, 25, 25));
            e.Context.Graphics.FillEllipse(Brushes.Black, new RectangleF(175, 112.5f, 25, 25));
            e.Handled = true;
        }
        #endregion CustomDraw
        #region Animation
        int animationLockCounterCore = 0;
        Timer timer;
        Random random = new Random(DateTime.Now.Millisecond);
        void OnLoad(object sender, EventArgs e) {
            timer = new Timer();
            timer.Interval = 350;
            timer.Tick += new EventHandler(OnTimerTick);
            timer.Start();
        }
        void OnTimerTick(object sender, EventArgs e) {
            if(animationLockCounterCore > 0 || !Visible || IsDisposing || IsDisposed) return;
            if(arcScale.IsDisposing || linearScale.IsDisposing) return;
            animationLockCounterCore++;
            arcScale.Value = AnimateScaleValue(arcScale, 0.05f);
            linearScale.Value = AnimateScaleValue(linearScale, 0.75f);
            animationLockCounterCore--;
        }
        float AnimateScaleValue(IBaseScale scale, float factor) {
            float deviation = ((float)random.NextDouble() - scale.Percent);
            return scale.Value + (scale.ScaleLength * factor) * deviation;
        }
        #endregion Animation
    }
}

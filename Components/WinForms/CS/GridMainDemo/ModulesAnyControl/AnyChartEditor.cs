using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraPrinting;
using System.Collections;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors.CustomEditor;

namespace DevExpress.XtraGrid.Demos {
    //<gridControl1>
    public class EmbeddedChartControl : Control, IAnyControlEdit, ICloneable {
        Size recommendedSize = new Size(30, 30);
        ChartControl chart = null;
        public EmbeddedChartControl() { }
        public EmbeddedChartControl(ChartControl chart) {
            AddChart(chart);
        }
        public void AddChart(ChartControl chart) {
            if(this.chart != null) this.chart.Dispose();
            this.chart = chart;
            this.recommendedSize = chart.Size;
            this.chart.Parent = this;
            this.chart.Dock = DockStyle.Fill;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public ChartControl Chart { get { return chart; } }
        public Size RecommendedSize {
            get { return recommendedSize; }
            set { recommendedSize = value; }
        }
        #region IAnyControlEdit Members
        object editValue = null;
        event EventHandler editValueChanged;
        object IAnyControlEdit.EditValue {
            get { return editValue; }
            set {
                if(value == editValue) return;
                editValue = value;
                OnEditValueChanging(value);
                
            }
        }

        private void OnEditValueChanging(object value) {
            if(Chart == null) return;
            if(value is IList || value == null) Chart.DataSource = value;
        }
        event EventHandler IAnyControlEdit.EditValueChanged {
            add { editValueChanged += value; }
            remove { editValueChanged -= value; }
        }
        void OnEditValueChanged() {
            if(editValueChanged != null) editValueChanged(this, EventArgs.Empty);
        }
        bool IAnyControlEdit.AllowBitmapCache { get { return true; } }

        bool IAnyControlEdit.IsNeededKey(KeyEventArgs e) { return false; }
        void IAnyControlEdit.SetupAsDrawControl() { }
        void IAnyControlEdit.SetupAsEditControl() { }
        Size IAnyControlEdit.CalcSize(Graphics g) {
            return RecommendedSize;
        }
        bool IAnyControlEdit.AllowClick(Point p) { return false; }
        bool IAnyControlEdit.SupportsDraw { get { return false; } }

        bool IAnyControlEdit.AllowBorder { get { return true; } }

        void IAnyControlEdit.Draw(GraphicsCache cache, AnyControlEditViewInfo viewInfo) {
            throw new NotImplementedException();
        }

        string IAnyControlEdit.GetDisplayText(object editValue) { return RepositoryItemAnyControl.GetBasicDisplayText(editValue); }
        #endregion

        object ICloneable.Clone() {
            EmbeddedChartControl c = new EmbeddedChartControl();
            if(Chart != null) {
                c.AddChart(Chart.Clone() as ChartControl);
                c.RecommendedSize = RecommendedSize;
            }
            return c;
        }
        protected override void OnBackColorChanged(EventArgs e) {
            base.OnBackColorChanged(e);
            if(Chart != null) Chart.BackColor = BackColor;
        }
    }
    //</gridControl1>
}

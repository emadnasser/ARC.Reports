using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraCharts.Demos.Miscellaneous {
    public partial class AnimationDemo : ChartDemoBase {
        public override ChartControl ChartControl { get { return chartControl1; } }

        public AnimationDemo() {
            InitializeComponent();
            ChartControl.AnimationStartMode = ChartAnimationMode.OnDataChanged;
            cbSeriesView.Properties.Items.AddRange(AnimationViewTypesItemsGenerator.CreateItems());
            cbSeriesView.SelectedItem = new ComboBoxSeriesViewItem(ViewType.Area);
            UpdateDemoControls(ViewType.Area);
        }

        void cbSeriesView_SelectedIndexChanged(object sender, EventArgs e) {
            barManager1.CloseMenus();
            ViewType selectedViewType = ((ComboBoxSeriesViewItem)cbSeriesView.SelectedItem).ViewType;
            UpdateDemoControls(selectedViewType);
        }
        void cheShowSeriesLabels_CheckedChanged(object sender, EventArgs e) {
            ChangeLabelsVisibility();
        }
        void sbAnimateChart_Click(object sender, EventArgs e) {
            ChartControl.Animate();
        }
        void cbeSeriesAnimation_SelectedValueChanged(object sender, EventArgs e) {
            SetAnimation(cbeSeriesAnimation.EditValue as IAnimationComboBoxItem);
        }
        void cbePointAnimation_SelectedIndexChanged(object sender, EventArgs e) {
            SetAnimation(cbePointAnimation.EditValue as IAnimationComboBoxItem);
        }
        void SetAnimation(IAnimationComboBoxItem comboBoxItem) {
            if (comboBoxItem != null)
                foreach (Series series in ChartControl.Series) {
                    comboBoxItem.ApplyAnimation(series.View);
                }
        }
        void bbiRotateDiagram_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            var xyDiagram = ChartControl.Diagram as XYDiagram;
            if (xyDiagram != null)
                xyDiagram.Rotated = !xyDiagram.Rotated;
        }
        void bbiChangeAxisXDirection_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            var xyDiagram = ChartControl.Diagram as XYDiagram;
            if (xyDiagram != null)
                xyDiagram.AxisX.Reverse = !xyDiagram.AxisX.Reverse;
        }
        void bbiChangeAxisYDirection_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            var xyDiagram = ChartControl.Diagram as XYDiagram;
            if (xyDiagram != null)
                xyDiagram.AxisY.Reverse = !xyDiagram.AxisY.Reverse;
        }
        void chartControl_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Right)
                return;
            if (ChartControl.Diagram is XYDiagram)
                pmContextMenu.ShowPopup(Cursor.Position);
        }
        void FillPointAnimationComboBoxEdit(ViewType selectedViewType) {
            FillAnimationComboBox(cbePointAnimation, Utils.GetPointAnimationTypes(selectedViewType));
        }
        void FillSeriesAnimationComboBoxEdit(ViewType selectedViewType) {
            FillAnimationComboBox(cbeSeriesAnimation, Utils.GetSeriesAnimationTypes(selectedViewType));
        }
        void FillAnimationComboBox(ComboBoxEdit comboBox, List<Type> animationTypes) {
            ComboBoxItemCollection comboBoxItems = comboBox.Properties.Items;
            comboBoxItems.Clear();
            if (animationTypes.Count == 0)
                comboBox.Enabled = false;
            else {
                comboBox.Enabled = true;
                foreach (Type animationType in animationTypes) {
                    comboBoxItems.AddRange(CreateAnimationItems(animationType));
                }
                comboBoxItems.AddRange(CreateAnimationItems(animationTypes[0], true));
            }
        }
        void ChangeLabelsVisibility() {
            foreach (Series series in ChartControl.Series) {
                series.LabelsVisibility = cheShowSeriesLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            }
        }
        void ChangeMarkersVisibility() {
            foreach (Series series in ChartControl.Series) {
                if (series.View is RangeAreaSeriesView) {
                    RangeAreaSeriesView rangeAreaView = (RangeAreaSeriesView)series.View;
                    rangeAreaView.Marker1Visibility = DefaultBoolean.True;
                    rangeAreaView.Marker2Visibility = DefaultBoolean.True;
                }
                else if (series.View is RadarRangeAreaSeriesView) {
                    RadarRangeAreaSeriesView rangeAreaView = (RadarRangeAreaSeriesView)series.View;
                    rangeAreaView.Marker1Visibility = DefaultBoolean.True;
                    rangeAreaView.Marker2Visibility = DefaultBoolean.True;
                }
                else if (series.View is PolarRangeAreaSeriesView) {
                    PolarRangeAreaSeriesView rangeAreaView = (PolarRangeAreaSeriesView)series.View;
                    rangeAreaView.Marker1Visibility = DefaultBoolean.True;
                    rangeAreaView.Marker2Visibility = DefaultBoolean.True;
                }
                else if (series.View is LineSeriesView)
                    ((LineSeriesView)series.View).MarkerVisibility = DefaultBoolean.True;
                else if (series.View is RadarLineSeriesView)
                    ((RadarLineSeriesView)series.View).MarkerVisibility = DefaultBoolean.True;
            }
        }
        void UpdateDemoControls(ViewType selectedViewType) {
            UpdateChart(selectedViewType);
            FillSeriesAnimationComboBoxEdit(selectedViewType);
            FillPointAnimationComboBoxEdit(selectedViewType);
            if (cbePointAnimation.Enabled)
                cbePointAnimation.SelectedIndex = 0;
            if (cbeSeriesAnimation.Enabled)
                cbeSeriesAnimation.SelectedIndex = 0;
            ChangeLabelsVisibility();
            ChangeMarkersVisibility();
        }
        void UpdateChart(ViewType selectedViewType) {
            ChartControl.Series.Clear();
            Series[] generatedSeries = SeriesGenerator.GenerateSeries(selectedViewType);
            if (generatedSeries != null)
                ChartControl.Series.AddRange(generatedSeries);
        }
        List<IAnimationComboBoxItem> CreateAnimationItems(Type type, bool isNoneItem = false) {
            PropertyInfo directionProperty = type.GetProperty("Direction");
            if (directionProperty != null && !isNoneItem) {
                List<IAnimationComboBoxItem> items = new List<IAnimationComboBoxItem>();
                Type propertyType = directionProperty.PropertyType;
                foreach (object directionValue in Enum.GetValues(propertyType)) {
                    items.Add(CreateAnimationItem(type, directionValue, isNoneItem));
                }
                return items;
            }
            return new List<IAnimationComboBoxItem>() { CreateAnimationItem(type, null, isNoneItem) };

        }
        IAnimationComboBoxItem CreateAnimationItem(Type type, object direction, bool isNoneItem = false) {
            if (type.IsSubclassOf(typeof(XYMarkerAnimationBase)))
                return new ComboBoxXYMarkerAnimationItem(type, isNoneItem, direction);
            else if (type.IsSubclassOf(typeof(BarAnimationBase)))
                return new ComboBoxBarAnimationItem(type, isNoneItem, direction);
            else if (type.IsSubclassOf(typeof(PieAnimationBase)))
                return new ComboBoxPieAnimationItem(type, isNoneItem, direction);
            else if (type.IsSubclassOf(typeof(FunnelAnimationBase)))
                return new ComboBoxFunnelAnimationItem(type, isNoneItem, direction);
            else if (type.IsSubclassOf(typeof(CircularMarkerAnimationBase)))
                return new ComboBoxCircularMarkerAnimationItem(type, isNoneItem, direction);
            else if (type.IsSubclassOf(typeof(FinancialAnimationBase)))
                return new ComboBoxFinancialPointAnimationItem(type, isNoneItem, direction);
            else if (type.IsSubclassOf(typeof(XYSeriesAnimationBase)))
                return new ComboBoxXYSeriesAnimationItem(type, isNoneItem, direction);
            else if (type.IsSubclassOf(typeof(CircularSeriesAnimationBase)))
                return new ComboBoxCircularSeriesAnimationItem(type, isNoneItem, direction);
            throw new AnimationDemoException(string.Format("Can't create ComboBoxItem. Unknown animation type: {0}", type.Name));
        }
    }

    #region ComboBoxItem classes
    interface IAnimationComboBoxItem {
        void ApplyAnimation(SeriesViewBase seriesView); 
    }

    abstract class AnimationComboBoxItem<TAnimation, TSeriesView> : IAnimationComboBoxItem
        where TAnimation : AnimationBase
        where TSeriesView : SeriesViewBase {

        Type type;
        string caption;
        bool isNoneItem;
        object direction;

        public AnimationComboBoxItem(Type type, bool isNoneItem, object direction) {
            this.direction = direction;
            this.caption = GetDisplayName(type, isNoneItem);
            this.type = type;
            this.isNoneItem = isNoneItem;
        }
        string GetDisplayName(Type type, bool isNoneItem) {
            if (isNoneItem)
                return "None";
            DisplayNameAttribute attribute = type.GetCustomAttribute(typeof(DisplayNameAttribute)) as DisplayNameAttribute;
            return attribute != null ? attribute.DisplayName : type.Name;
        }
        string ParseStringByLargeTokens(string sourceString) {
            string result = "";
            foreach (char symbol in sourceString) {
                if (Char.IsUpper(symbol))
                    result += ' ';
                result += symbol;
            }
            return result;
        }
        
        public void ApplyAnimation(SeriesViewBase seriesView) {
            TAnimation animation = (TAnimation)Activator.CreateInstance(type);
            animation.Enabled = !isNoneItem;
            ApplyAnimationInternal(animation, (TSeriesView)seriesView);
            if (direction != null) {
                PropertyInfo directionProperty = type.GetProperty("Direction");
                directionProperty.SetValue(animation, direction, null);
            }
        }
        public abstract void ApplyAnimationInternal(TAnimation animation, TSeriesView seriesView);
        public override string ToString() {
            if (direction == null || isNoneItem)
                return caption;
            else return caption + ParseStringByLargeTokens(direction.ToString());
        }
    }

    class ComboBoxXYSeriesAnimationItem : AnimationComboBoxItem<XYSeriesAnimationBase, LineSeriesView> {
        public ComboBoxXYSeriesAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(XYSeriesAnimationBase animation, LineSeriesView seriesView) {
            seriesView.SeriesAnimation = animation;
        }
    }

    class ComboBoxXYMarkerAnimationItem : AnimationComboBoxItem<XYMarkerAnimationBase, PointSeriesViewBase> {
        public ComboBoxXYMarkerAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(XYMarkerAnimationBase animation, PointSeriesViewBase seriesView) {
            seriesView.SeriesPointAnimation = animation;
        }

    }

    class ComboBoxBarAnimationItem : AnimationComboBoxItem<BarAnimationBase, BarSeriesView> {
        public ComboBoxBarAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(BarAnimationBase animation, BarSeriesView seriesView) {
            seriesView.Animation = animation;
        }
    }

    class ComboBoxPieAnimationItem : AnimationComboBoxItem<PieAnimationBase, PieSeriesView> {
        public ComboBoxPieAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(PieAnimationBase animation, PieSeriesView seriesView) {
            seriesView.Animation = animation;
        }
    }

    class ComboBoxFunnelAnimationItem : AnimationComboBoxItem<FunnelAnimationBase, FunnelSeriesView> {
        public ComboBoxFunnelAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(FunnelAnimationBase animation, FunnelSeriesView seriesView) {
            seriesView.Animation = animation;
        }
    }

    class ComboBoxCircularMarkerAnimationItem : AnimationComboBoxItem<CircularMarkerAnimationBase, RadarSeriesViewBase> {
        public ComboBoxCircularMarkerAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(CircularMarkerAnimationBase animation, RadarSeriesViewBase seriesView) {
            seriesView.SeriesPointAnimation = animation;
        }
    }

    class ComboBoxFinancialPointAnimationItem : AnimationComboBoxItem<FinancialAnimationBase, FinancialSeriesViewBase> {
        public ComboBoxFinancialPointAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(FinancialAnimationBase animation, FinancialSeriesViewBase seriesView) {
            seriesView.Animation = animation;
        }
    }

    class ComboBoxCircularSeriesAnimationItem : AnimationComboBoxItem<CircularSeriesAnimationBase, RadarLineSeriesView> {
        public ComboBoxCircularSeriesAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(CircularSeriesAnimationBase animation, RadarLineSeriesView seriesView) {
            seriesView.SeriesAnimation = animation;
        }
    }
    #endregion

    public class AnimationDemoException : Exception {
        public AnimationDemoException(string message) 
            : base(message) { }
    }
}

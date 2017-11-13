using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DevExpress.Core.Native;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.UI.Xaml.Map;
using Windows.UI.Xaml;

namespace HybridApp.Views {
    public class MapVectorItemsLayerBehavior : Behavior<VectorItemsLayer> {
        public DataTemplate ItemTemplate {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }
        public static readonly DependencyProperty ItemTemplateProperty =
            DependencyProperty.Register("ItemTemplate", typeof(DataTemplate), typeof(MapVectorItemsLayerBehavior), new PropertyMetadata(null, Update));
        public object ItemsSource {
            get { return (object)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(object), typeof(MapVectorItemsLayerBehavior), new PropertyMetadata(null, Update));
        public string LatitudeDataMember {
            get { return (string)GetValue(LatitudeDataMemberProperty); }
            set { SetValue(LatitudeDataMemberProperty, value); }
        }
        public static readonly DependencyProperty LatitudeDataMemberProperty =
            DependencyProperty.Register("LatitudeDataMember", typeof(string), typeof(MapVectorItemsLayerBehavior), new PropertyMetadata(null, Update));
        public string LongitudeDataMember {
            get { return (string)GetValue(LongitudeDataMemberProperty); }
            set { SetValue(LongitudeDataMemberProperty, value); }
        }
        public static readonly DependencyProperty LongitudeDataMemberProperty =
            DependencyProperty.Register("LongitudeDataMember", typeof(string), typeof(MapVectorItemsLayerBehavior), new PropertyMetadata(null, Update));
        static void Update(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            ((MapVectorItemsLayerBehavior)d).Update();
        }
        public object SelectedItem {
            get { return (object)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(object), typeof(MapVectorItemsLayerBehavior), new PropertyMetadata(null, UpdateSelectedItem));
        static void UpdateSelectedItem(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            ((MapVectorItemsLayerBehavior)d).UpdateSelectedItem();
        }
        protected override void OnAttached() {
            base.OnAttached();
            AssociatedObject.Loaded += AssociatedObject_Loaded;
        }
        void AssociatedObject_Loaded(object sender, RoutedEventArgs e) {
            Update();
            UpdateSelectedItem();
        }
        void Update() {
            if(AssociatedObject == null || ItemsSource == null || LatitudeDataMember == null || LongitudeDataMember == null)
                return;
            mapCustomElements = GetMapCustomElements();
            AssociatedObject.ItemsSource = mapCustomElements;
        }
        void UpdateSelectedItem() {
            if(AssociatedObject == null || mapCustomElements == null)
                return;
            var selectedCustomElement = mapCustomElements.FirstOrDefault(m => m.Content.Equals(SelectedItem));
            UpdateSelectedCustomElement(selectedCustomElement);
            AssociatedObject.SelectedItem = selectedCustomElement;
        }
        List<MapCustomElement> mapCustomElements;
        List<MapCustomElement> GetMapCustomElements() {
            var res = new List<MapCustomElement>();
            foreach(var item in ItemsSource as IEnumerable) {
                var element = new MapCustomElement();
                (element as ISelectableItem).IsSelected = false;
                element.PointerPressed += element_PointerPressed;
                element.Location = new GeoPoint(GetProperty(item, LatitudeDataMember), GetProperty(item, LongitudeDataMember));
                element.Content = item;
                element.ContentTemplate = ItemTemplate;
                res.Add(element);
            }
            return res;
        }
        void element_PointerPressed(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e) {
            var element = sender as MapCustomElement;
            SelectedItem = element.Content;
        }
        void UpdateSelectedCustomElement(MapCustomElement element) {
            if (element != null)
                element.Layer.SelectedItem = element;
            foreach(var el in mapCustomElements) {
                SetIsSelected(el, false);
            }
            SetIsSelected(element, true);
        }
        static void SetIsSelected(MapCustomElement el, bool isSelected) {
            if(el == null)
                return;
            (el as ISelectableItem).IsSelected = isSelected;
            if(el.Content is ISelectableItem) {
                (el.Content as ISelectableItem).IsSelected = isSelected;
            }
        }
        double GetProperty(object item, string dataMember) {
            string[] props = dataMember.Split('.');
            object currentObject = item;
            foreach(var prop in props.Take(props.Length - 1)) {
                currentObject = currentObject.GetType().GetProperty(prop).GetValue(currentObject, null);
            }
            return (double)currentObject.GetType().GetProperty(props.Last()).GetValue(currentObject, null);
        }
    }
}

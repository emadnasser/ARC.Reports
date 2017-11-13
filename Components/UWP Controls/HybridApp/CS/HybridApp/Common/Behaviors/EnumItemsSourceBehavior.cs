using System;
using System.Collections.Generic;
using DevExpress.Data.Helpers;
using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.UI.Interactivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;

namespace HybridApp.Views {
    public class EnumItemsSourceBehavior : Behavior<ItemsControl> {
        public object SelectedItem {
            get { return (object)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(object), typeof(EnumItemsSourceBehavior), new PropertyMetadata(null));
        public string EnumType {
            get { return (string)GetValue(EnumTypeProperty); }
            set { SetValue(EnumTypeProperty, value); }
        }
        public static readonly DependencyProperty EnumTypeProperty =
            DependencyProperty.Register("EnumType", typeof(string), typeof(EnumItemsSourceBehavior), new PropertyMetadata(null, (s, e) => ((EnumItemsSourceBehavior)s).Update()));
        public bool SplitNames {
            get { return (bool)GetValue(SplitNamesProperty); }
            set { SetValue(SplitNamesProperty, value); }
        }
        public static readonly DependencyProperty SplitNamesProperty =
            DependencyProperty.Register("SplitNames", typeof(bool), typeof(EnumItemsSourceBehavior), new PropertyMetadata(null, (s, e) => ((EnumItemsSourceBehavior)s).Update()));
        protected override void OnAttached() {
            base.OnAttached();
            AssociatedObject.Loaded += AssociatedObject_Loaded;
        }
        protected override void OnDetaching() {
            base.OnDetaching();
            AssociatedObject.Loaded -= AssociatedObject_Loaded;
        }
        void AssociatedObject_Loaded(object sender, RoutedEventArgs e) {
            Update();
        }
        protected Selector Selector { get { return AssociatedObject as Selector; } }
        void Update() {
            if(AssociatedObject == null)
                return;
            Type enumType = GetEnumType(EnumType);
            if(enumType == null)
                return;
            object seletedItem = Selector.With(x => x.SelectedItem);
            var itemSource = GetEnumSource(enumType, SplitNames);
            AssociatedObject.ItemsSource = itemSource;
            AssociatedObject.DisplayMemberPath = "Name";
            if (Selector == null)
                return;
            var converter = new EnumMemberInfoConverter(enumType, itemSource);
            Selector.SelectedValuePath = "Name";
            Selector.SelectedItem = seletedItem ?? converter.Convert(SelectedItem, null, null, null);
            BindingOperations.SetBinding(Selector, Selector.SelectedItemProperty, new Binding() { Path = new PropertyPath("SelectedItem"), Source = this, Converter = converter, Mode = BindingMode.TwoWay });
        }
        Type GetEnumType(string EnumType) {
            return Type.GetType(EnumType);
        }
        IEnumerable<EnumMemberInfo> GetEnumSource(Type enumType, bool splitNames) {
            var result = new List<EnumMemberInfo>();
            foreach(var item in Enum.GetValues(enumType)) {
                result.Add(new EnumMemberInfo(GetEnumName(item, splitNames), item));
            }
            return result;
        }
        string GetEnumName(object item, bool splitNames) {
            string name = item.ToString();
            if(splitNames)
                return SplitStringHelper.SplitPascalCaseString(name);
            return name;
        }
        public class EnumMemberInfoConverter : IValueConverter {
            Type enumType;
            IEnumerable<EnumMemberInfo> itemSource;
            public EnumMemberInfoConverter(Type enumType, IEnumerable<EnumMemberInfo> itemSource) {
                this.enumType = enumType;
                this.itemSource = itemSource;
            }
            public object Convert(object value, Type targetType, object parameter, string language) {
                if(value == null || value.GetType() != enumType)
                    return null;
                return new EnumMemberInfo(value.ToString(), value);
            }
            public object ConvertBack(object value, Type targetType, object parameter, string language) {
                var a = (value as EnumMemberInfo).With(x => x.Id);
                return a;
            }
        }
    }
    public class EnumMemberInfo {
        public EnumMemberInfo(string value, object id) {
            Id = id;
            Name = value;
        }
        public object Id { get; private set; }
        public string Name { get; private set; }
        public override bool Equals(object obj) {
            return (obj as EnumMemberInfo).If(x => x.Id.Equals(Id)).ReturnSuccess();
        }
        public override int GetHashCode() {
            return Id.GetHashCode();
        }
    }
}

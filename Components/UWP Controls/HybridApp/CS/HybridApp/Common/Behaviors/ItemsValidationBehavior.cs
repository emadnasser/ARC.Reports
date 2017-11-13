using System;
using System.Collections.Generic;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.UI.Xaml.Editors;
using DevExpress.UI.Xaml.Layout;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace HybridApp.Views {
    public class ItemsValidationBehavior : Behavior<LayoutControl> {
        static readonly DependencyProperty Validation0Property = DependencyProperty.Register("Validation0", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation1Property = DependencyProperty.Register("Validation1", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation2Property = DependencyProperty.Register("Validation2", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation3Property = DependencyProperty.Register("Validation3", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation4Property = DependencyProperty.Register("Validation4", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation5Property = DependencyProperty.Register("Validation5", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation6Property = DependencyProperty.Register("Validation6", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation7Property = DependencyProperty.Register("Validation7", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation8Property = DependencyProperty.Register("Validation8", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation9Property = DependencyProperty.Register("Validation9", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation10Property = DependencyProperty.Register("Validation10", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation11Property = DependencyProperty.Register("Validation11", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation12Property = DependencyProperty.Register("Validation12", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation13Property = DependencyProperty.Register("Validation13", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation14Property = DependencyProperty.Register("Validation14", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation15Property = DependencyProperty.Register("Validation15", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation16Property = DependencyProperty.Register("Validation16", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation17Property = DependencyProperty.Register("Validation17", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation18Property = DependencyProperty.Register("Validation18", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));
        static readonly DependencyProperty Validation19Property = DependencyProperty.Register("Validation19", typeof(bool), typeof(ItemsValidationBehavior),
            new PropertyMetadata(false, (s, e) => ((ItemsValidationBehavior)s).OnValidationChanged(e)));

        public static readonly DependencyProperty HasValidProperty = DependencyProperty.Register("HasValid", typeof(bool),
            typeof(ItemsValidationBehavior), new PropertyMetadata(true));
        public bool HasValid {
            get { return (bool)GetValue(HasValidProperty); }
            set { SetValue(HasValidProperty, value); }
        }
        bool justAttached;
        List<TextEdit> TextEditCollection;
        protected override void OnAttached() {
            base.OnAttached();
            justAttached = true;
            AssociatedObject.Loaded += AssociatedObject_Loaded;
        }
        protected override void OnDetaching() {
            base.OnDetaching();
            AssociatedObject.Loaded -= AssociatedObject_Loaded;
        }
        void AssociatedObject_Loaded(object sender, RoutedEventArgs e) {
            if(justAttached) {
                justAttached = false;
                TextEditCollection = new List<TextEdit>();
                GetItems(AssociatedObject.Items);
                if(TextEditCollection.Count > 20)
                    throw new Exception("Too many items.");
                int index = 0;
                foreach(var item in TextEditCollection)
                    BindingOperations.SetBinding(item, TextEdit.HasValidationErrorProperty,
                        new Binding() { Path = new PropertyPath("Validation" + (index++).ToString()), Source = this, Mode = BindingMode.TwoWay });
            }
            foreach(var item in TextEditCollection) {
                if(item.HasValidationError == true) {
                    HasValid = false;
                    return;
                }
            }
            HasValid = true;
        }
        void OnValidationChanged(DependencyPropertyChangedEventArgs e) {
            if((bool)(e.NewValue))
                HasValid = false;
            else {
                foreach(var item in TextEditCollection) {
                    if(item.HasValidationError == true)
                        return;
                }
                HasValid = true;
            }
        }
        void GetItems(ItemCollection collection) {
            foreach(var item in collection) {
                if(item as LayoutGroup != null)
                    GetItems(((LayoutGroup)item).Items);
                if(item as LayoutItem != null) {
                    LayoutItem element = (LayoutItem)item;
                    if(element.Content as TextEdit != null)
                        TextEditCollection.Add((TextEdit)element.Content);
                }
            }
        }
    }
}

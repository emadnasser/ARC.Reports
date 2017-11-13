using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Editors;
using DevExpress.DemoData.Models;
using DevExpress.Xpf.Core;
using System.Collections.ObjectModel;
using DevExpress.Xpf.PropertyGrid;
using DevExpress.Xpf.Bars;

namespace EditorsDemo {

    public partial class SimpleButtonModule : EditorsDemoModule {
        public ObservableCollection<string> EventsLog { get; set; }
        public SimpleButtonModule() {
            InitializeComponent();
            EventsLog = new ObservableCollection<string>();
            rbSimpleButton.IsChecked = true;
        }

        void OnRadioButtonChecked(object sender, RoutedEventArgs e) {
            RadioButton radioButton = sender as RadioButton;
            switch (radioButton.Name) {
                case "rbSimpleButton":
                    propertyGrid.SelectedObject = simpleButton;
                    break;
                case "rbSplitButton":
                    propertyGrid.SelectedObject = splitButton;
                    break;
                case "rbDropDownButton":
                    propertyGrid.SelectedObject = dropdownButton;
                    break;
            }
        }

        void AddStringInLog(object button) {
            if (button is BarButtonItem)
                EventsLog.Add(DateTime.Now.ToShortTimeString() + " - " + button.GetType().Name + " '" + (button as BarButtonItem).Content + "'" + " Click");
            else
                EventsLog.Add(DateTime.Now.ToShortTimeString() + " - " + button.GetType().Name + " Click");
            if (EventsLog.Count > 20)
                EventsLog.RemoveAt(0);
        }

        void OnButtonClick(object sender, RoutedEventArgs e) {
            var button = sender as SimpleButton;
            if (button != null && button.ButtonKind == ButtonKind.Toggle)
                EventsLog.Add(DateTime.Now.ToShortTimeString() + " - " + button.GetType().Name + " state is: " + button.IsChecked.ToString());
            AddStringInLog(sender);
        }

        void OnBarButtonItemClick(object sender, ItemClickEventArgs e) {
            AddStringInLog(sender);
        }
    }
}

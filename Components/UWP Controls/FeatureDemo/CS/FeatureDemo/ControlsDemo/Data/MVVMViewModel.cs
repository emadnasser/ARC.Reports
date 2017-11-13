using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Core;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ControlsDemo {
    public class ViewModel {
        public List<Item> Items { get; set; }
    }
    public class Container : Item {
        public List<Item> Items { get; set; }
    }
    public class Item {
        public Item() {
            Index = -1;
        }
        public string Label { get; set; }
        public Uri Uri { get; set; }
        public int Index { get; set; }
    }
}

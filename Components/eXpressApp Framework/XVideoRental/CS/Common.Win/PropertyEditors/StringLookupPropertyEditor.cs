using System;
using System.Collections.Generic;
using System.ComponentModel;
using Common.Win;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Linq;

[assembly: OnlineRepoLocation("http://goo.gl/86Aqu")]

namespace Common.Win.PropertyEditors {
    [PropertyEditor(typeof(string), false)]
    public class StringLookupPropertyEditor : StringPropertyEditorBase {
        private List<ComboBoxItem> comboBoxItems;
        public event EventHandler<HandledEventArgs> ItemsCalculating;

        protected virtual void OnItemsCalculating(HandledEventArgs e) {
            EventHandler<HandledEventArgs> handler = ItemsCalculating;
            if (handler != null) handler(this, e);
        }

        public StringLookupPropertyEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model) {
        }

        protected override List<ComboBoxItem> ComboBoxItems {
            get {
                if (comboBoxItems == null) {
                    comboBoxItems = new List<ComboBoxItem>();
                    ComboBoxItemsBuilder.Create()
                        .WithPropertyEditor(this)
                        .Build((enumerable, b) => {
                            if (enumerable != null) {
                                if (b)
                                    CreateItems(enumerable, ((ComboBoxEdit)Control).Properties.Items);
                                else {
                                    CreateItems(enumerable, comboBoxItems);
                                }
                            }
                        }, () => {
                            var handledEventArgs = new HandledEventArgs();
                            OnItemsCalculating(handledEventArgs);
                            return handledEventArgs.Handled;
                        });
                }
                return comboBoxItems;
            }
        }

        void CreateItems(IEnumerable<string> enumerable1, ComboBoxItemCollection boxItems) {
            boxItems.Clear();
            boxItems.AddRange(enumerable1.Select(s => new ComboBoxItem(s)).ToList());
        }

        void CreateItems(IEnumerable<string> enumerable1, List<ComboBoxItem> boxItems) {
            boxItems.Clear();
            boxItems.AddRange(enumerable1.Select(s => new ComboBoxItem(s)).ToList());
        }
    }
}

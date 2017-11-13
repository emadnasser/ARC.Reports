using System;
using System.Linq;
using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;

namespace DevExpress.MVVM.Demos.Views {
    public partial class TileCollectionViewModule : TutorialControl {
        public TileCollectionViewModule() {
            InitializeComponent();
            if(!DesignMode)
                InitBindings();
            LoadSourceCode(sourceCode, "InitBindings");
        }
        void InitBindings() {
            // All child Views, opened from this View, will be hosted within a Ribbon Form (double click rows to try this feature)
            mvvmContext.RegisterService(WindowedDocumentManagerService.CreateRibbonFormService(this));

            var fluentAPI = mvvmContext.OfType<AccountCollectionViewModel>();
            TileGroup group = tileControl1.Groups[0];
            // Populating the current TileGroup with tiles, generated from the Entities collection.
            //Using the Change and Dispose expressions allows these generated items to dynamically respond to modifying or removing records within the source
            fluentAPI.SetItemsSourceBinding(
                group, //Target 
                g => g.Items, //Items Selector 
                x => x.Entities, //Source Selector  
                (tileItem, entity) => object.Equals(tileItem.Tag, entity), //Match Expression - checks whether or not this tile's tag matches the current entity
                entity =>                                                  //Create Expression - creates a new tile based on the current entity
                {
                    TileItem item = new TileItem() { Tag = entity };
                    item.ItemSize = TileItemSize.Wide;
                    var account = new TileItemElement();
                    account.Appearance.Normal.Font = new System.Drawing.Font("Segoe", 24.0f, System.Drawing.GraphicsUnit.Point);
                    item.Elements.Add(account);
                    var amount = new TileItemElement();
                    amount.TextAlignment = TileItemContentAlignment.BottomRight;
                    item.Elements.Add(amount);
                    return item;
                },
                null,                   //Dispose Expression - removes a target tiles when its related source collection record is deleted 
                (tileItem, entity) =>   //Change Expression - modifies existing tiles
                {
                   tileItem.Elements[0].Text = entity.Name;
                   tileItem.Elements[1].Text = String.Format("{0:C}", entity.Amount);
               });
            // A two-way synchronization of the ViewModel.SelectedEntity and the TileControl.SelectedItem properties
            fluentAPI.SetBinding(tileControl1, tc => tc.SelectedItem, x => x.SelectedEntity,
                (entity) => (TileItem)group.Items.FirstOrDefault(i => object.ReferenceEquals(i.Tag, entity)),
                item => (item != null) ? (Model.Account)item.Tag : null);
            // A double-click on a tile should invoke the Edit command for the related entity
            fluentAPI.WithEvent<TileItemEventArgs>(tileControl1, "ItemDoubleClick")
                .EventToCommand(x => x.Edit(null), x => x.SelectedEntity);
        }
    }
}

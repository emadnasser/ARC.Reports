using System;
using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Demos;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates.ActionContainers;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.General;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace FeatureCenter.Module.Navigation {

	public enum DemoNavigationChildItemsDisplayStyle {
		Default,
		LargeIcons,
		List
	}
	[ImageName(NavigationDemoStrings.NavigationObjectImageName)]
	[NavigationItem(NavigationDemoStrings.NavBarGroupName)]
	[System.ComponentModel.DisplayName(NavigationDemoStrings.NavigationDemo)]
	[Hint(Hints.NavigationObjectHint, ViewType.DetailView, "Hint")]
	public class NavigationObject : BaseObject, INotifyPropertyChanged {
		private ItemsDisplayStyle defaultChildItemsDisplayStyle = ItemsDisplayStyle.List;
		private NavigationStyle navigationStyle = NavigationStyle.NavBar;
		private string logItems;
		private SingleChoiceAction action;
		private bool isWebApplication;
		private void action_Execute(object sender, SingleChoiceActionExecuteEventArgs e) {
			LogTrace(string.Format("The '{0}' navigation item is selected", e.SelectedChoiceActionItem.Caption));
		}
		private string GetComposedHint() {
			string navigationStyleHint = NavigationStyle == NavigationStyle.NavBar ? Hints.NavigationStyleNavBarHint : Hints.NavigationStyleTreeListHint;
			string defaultChildItemsDisplayStyleHint = DefaultChildItemsDisplayStyle == ItemsDisplayStyle.List ? Hints.DefaultNavigationChildItemsDisplayStyleListHint : Hints.DefaultNavigationChildItemsDisplayStyleIconsHint;
			return navigationStyleHint + (!isWebApplication ? "\r\n" + defaultChildItemsDisplayStyleHint : "");
		}
        private void ProcessItem(NavigationItem item, ChoiceActionItemCollection choiceActionItemCollection, ModelNode parentModel) {
            object objectKey = Session.GetKeyValue(item);
            IModelNavigationItem modelNavigaionItem = parentModel.AddNode<IModelNavigationItem>(objectKey.ToString());
            FillNavigationItemModel(item, modelNavigaionItem);
            ChoiceActionItem choiceActionItem = new ChoiceActionItem(modelNavigaionItem, item);
            choiceActionItem.ImageName = item.ImageName;
            choiceActionItemCollection.Add(choiceActionItem);
            SortItems(item.Items);
            foreach(NavigationItem childItem in item.Items) {
                ProcessItem(childItem, choiceActionItem.Items, (ModelNode)modelNavigaionItem);
            }
        }
        private void FillNavigationItemModel(NavigationItem item, IModelNavigationItem modelNavigaionItem) {
            modelNavigaionItem.Caption = item.Name;
            modelNavigaionItem.Index = item.Index;
            if(item.ChildItemsDisplayStyle == DemoNavigationChildItemsDisplayStyle.Default) {
                modelNavigaionItem.ChildItemsDisplayStyle = item.NavigationObject.DefaultChildItemsDisplayStyle;
            }
            else {
                modelNavigaionItem.ChildItemsDisplayStyle = item.ChildItemsDisplayStyle == DemoNavigationChildItemsDisplayStyle.List ? ItemsDisplayStyle.List : ItemsDisplayStyle.LargeIcons;
            }
            modelNavigaionItem.ImageName = item.ImageName;
        }
        protected virtual void OnPropertyChanged(string propertyName) {
			if(PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		protected override void OnLoaded() {
			base.OnLoaded();
			BuildAction();
		}
		internal void BuildAction() {
			//B152525
			Action.Items.Clear();
            SortItems(NavigationItems);

            ModelApplicationCreator creator = NavigationDemoWindowController.ModelCreatorInstance;
            if(creator != null) {
                ModelNode modelNavigationItems = creator.CreateNode(Guid.NewGuid().ToString(), typeof(IModelNavigationItems));
                foreach(NavigationItem item in NavigationItems) {
                    if(item.Parent == null) {
                        ProcessItem(item, Action.Items, modelNavigationItems);
                    }
                }
            }
		}
        private void SortItems(XPCollection<NavigationItem> items) {
            items.Sorting.Clear();
            items.Sorting.Add(new SortProperty("Index", DevExpress.Xpo.DB.SortingDirection.Ascending));
        }
		public NavigationObject(Session session)
			: base(session) {
			action = new SingleChoiceAction();
            action.Caption = "Navigation";
			action.Execute += new SingleChoiceActionExecuteEventHandler(action_Execute);
		}
		[Browsable(false), NonPersistent]
		public bool IsWebApplication {
			get { return isWebApplication; }
			set {
				isWebApplication = value;
			}
		}
		[NonPersistent, Browsable(false)]
		public string Hint {
			get { return GetComposedHint(); }
		}
		[ImmediatePostData]
		public ItemsDisplayStyle DefaultChildItemsDisplayStyle {
			get { return defaultChildItemsDisplayStyle; }
			set {
				SetPropertyValue<ItemsDisplayStyle>("DefaultChildItemsDisplayStyle", ref defaultChildItemsDisplayStyle, value);
				OnPropertyChanged("Hint");
			}
		}
		[ImmediatePostData]
		public NavigationStyle NavigationStyle {
			get { return navigationStyle; }
			set {
				SetPropertyValue<NavigationStyle>("NavigationStyle", ref navigationStyle, value);
				OnPropertyChanged("Hint");
			}
		}
		public SingleChoiceAction Action {
			get { return action; }
		}
		[Association("NavigationObject-NavigationItems"), Aggregated]
		public XPCollection<NavigationItem> NavigationItems {
			get { return GetCollection<NavigationItem>("NavigationItems"); }
		}
		public event PropertyChangedEventHandler PropertyChanged;
		[Size(SizeAttribute.Unlimited)]
        [ModelDefault("RowCount", "5")]
		public string Log {
			get { return logItems; }
		}
		public void LogTrace(string message) {
			logItems = message + "\r\n" + logItems;
			OnChanged("Log");
		}
	}

	[Hint("Nav item Hint", ViewType.DetailView, "Hint")]
	public class NavigationItem : BaseObject, INotifyPropertyChanged, ITreeNode, ITreeNodeImageProvider {
		private string hint;
		private string name;
        private int index;
		private NavigationItem parent;
		private NavigationObject navigationObject;
		private string imageName;
		private DemoNavigationChildItemsDisplayStyle childItemsDisplayStyle;
		private string GetEmptyImageName() {
			return Items.Count == 0 ? "BO_Unknown" : "BO_Folder";
		}
		protected virtual void OnPropertyChanged(string propertyName) {
			if(PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		public NavigationItem(Session session)
			: base(session) {
		}
		[Browsable(false)]
		[NonPersistent]
		public string Hint {
			get { return hint; }
			set {
				hint = value;
				OnPropertyChanged("Hint");
			}
		}
		public string Name {
			get { return name; }
			set {
				SetPropertyValue<string>("Name", ref name, value);
				OnPropertyChanged("Name");
			}
		}
        public int Index {
            get { return index; }
            set { SetPropertyValue<int>("Index", ref index, value); }
        }
		public string ImageName {
			get {
				if(string.IsNullOrEmpty(imageName)) {
					return GetEmptyImageName();
				}
				return imageName ; 
			}
			set {
				imageName = value;
			}
		}
		[ImmediatePostData]
		public DemoNavigationChildItemsDisplayStyle ChildItemsDisplayStyle {
			get { return childItemsDisplayStyle; }
			set {
				SetPropertyValue<DemoNavigationChildItemsDisplayStyle>("ChildItemsDisplayStyle", ref childItemsDisplayStyle, value);
			}
		}
		[Browsable(false)]
		[Association("NavigationObject-NavigationItems")]
		public NavigationObject NavigationObject {
			get { return navigationObject != null ? navigationObject : Parent != null ? Parent.NavigationObject : null; }
			set { SetPropertyValue<NavigationObject>("NavigationObject", ref navigationObject, value); }
		}
		[Browsable(false)]
		[Association("NavigationItem-NavigationItems")]
		public NavigationItem Parent {
			get { return parent; }
			set { SetPropertyValue<NavigationItem>("Parent", ref parent, value); }
		}
		[Association("NavigationItem-NavigationItems"), Aggregated]
		public XPCollection<NavigationItem> Items {
			get { return GetCollection<NavigationItem>("Items"); }
		}
		public event PropertyChangedEventHandler PropertyChanged;

		#region ITreeNode Members
		[Collection(typeof(NavigationItem))]
		[Browsable(false)]
		public IBindingList Children {
			get { return Items; }
		}
		[Browsable(false)]
		ITreeNode ITreeNode.Parent {
			get { return parent; }
		}
		string ITreeNode.Name {
			get { return Name; }
		}
		#endregion

		#region ITreeNodeImageProvider Members
		public System.Drawing.Image GetImage(out string imageName) {
			ImageInfo imageInfo = ImageLoader.Instance.GetImageInfo(ImageName);
			if(!imageInfo.IsEmpty) {
				imageName = this.ImageName;
				return imageInfo.Image;
			}
			else {
				imageName = GetEmptyImageName();
				return ImageLoader.Instance.GetImageInfo(imageName).Image;
			}
		}
		#endregion
	}
}

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Common.Win.ModelAdapter;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.XtraGrid;

namespace Common.Win.GridView.MasterDetail {
    public interface IMasterDetailColumnView {
        Window Window { get; set; }
        Frame MasterFrame { get; set; }
    }
    public class CustomGetSelectedObjectsArgs : HandledEventArgs {
        public CustomGetSelectedObjectsArgs(IList list) {
            List = list;
        }

        public IList List { get; set; }
    }
    public class CustomGridCreateEventArgs : HandledEventArgs {
        public GridControl Grid { get; set; }
    }
    public interface IModelMasterDetails : IModelNode, IModelList<IModelMasterDetail> {
        [DefaultValue(true)]
        bool SynchronizeActions { get; set; }
    }
    public interface IModelMasterDetail : IModelNode {
        [CriteriaOptions("ParentView.ModelClass.TypeInfo")]
        [Editor("DevExpress.ExpressApp.Win.Core.ModelEditor.CriteriaModelEditorControl, DevExpress.ExpressApp.Win" + XafApplication.CurrentVersion, typeof(System.Drawing.Design.UITypeEditor))]
        string Criteria { get; set; }
        [DataSourceProperty("ListViews")]
        [Required]
        IModelListViewMasterDetail ListView { get; set; }
        [Browsable(false)]
        IModelList<IModelListViewMasterDetail> ListViews { get; }
        [Browsable(false)]
        IModelList<IModelMember> CollectionMembers { get; }

        [DataSourceProperty("CollectionMembers")]
        [Required]
        IModelMember CollectionMember { get; set; }
        [Browsable(false)]
        IModelListView ParentView { get; set; }
    }
    [ModelAbstractClass]
    public interface IModelListViewMasterDetail : IModelListView {
        IModelMasterDetails MasterDetails { get; }
    }

    [DomainLogic(typeof(IModelMasterDetail))]
    public class MasterDetailRuleDomainLogic {
        public static IModelListView Get_ParentView(IModelMasterDetail modelDetail) {
            return ((IModelListView)modelDetail.Parent.Parent);
        }

        public static IModelList<IModelListViewMasterDetail> Get_ListViews(IModelMasterDetail modelDetail) {
            var calculatedModelNodeList = new CalculatedModelNodeList<IModelListViewMasterDetail>();
            var collectionMember = modelDetail.CollectionMember;
            if (collectionMember != null) {
                var listElementTypeInfo = collectionMember.MemberInfo.ListElementTypeInfo;
                var modelListViews = ModelListViews(modelDetail, listElementTypeInfo);
                calculatedModelNodeList.AddRange(modelListViews);
            }
            return calculatedModelNodeList;
        }

        static IEnumerable<IModelListViewMasterDetail> ModelListViews(IModelMasterDetail modelDetail, ITypeInfo listElementTypeInfo) {
            return modelDetail.Application.Views.OfType<IModelListViewMasterDetail>().Where(
                    view => view.ModelClass.TypeInfo == listElementTypeInfo);
        }

        public static IModelList<IModelMember> Get_CollectionMembers(IModelMasterDetail masterDetail) {
            var modelListView = masterDetail.GetParentNode<IModelListViewMasterDetail>();
            return new CalculatedModelNodeList<IModelMember>(CollectionModelMembers(modelListView));
        }

        static IEnumerable<IModelMember> CollectionModelMembers(IModelListViewMasterDetail listViewMasterDetail) {
            return listViewMasterDetail.ModelClass.AllMembers.Where(
                    member => member.MemberInfo.IsList && member.MemberInfo.ListElementTypeInfo.IsPersistent);
        }
    }
}

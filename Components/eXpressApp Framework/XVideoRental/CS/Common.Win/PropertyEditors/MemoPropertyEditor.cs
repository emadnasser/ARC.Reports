using System;
using System.Windows.Forms;
using Common.Win;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraEditors.Repository;

[assembly: OnlineRepoLocation("http://goo.gl/ko3A1")]

namespace Common.Win.PropertyEditors {
    [PropertyEditor(typeof(string), false)]
    public class MemoPropertyEditor : StringPropertyEditor {
        public MemoPropertyEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model) {
        }

        protected override RepositoryItem CreateRepositoryItem() {
            return new RepositoryItemMemoEdit { MaxLength = Model.MaxLength, ScrollBars = ScrollBars.Both };
        }
    }
}

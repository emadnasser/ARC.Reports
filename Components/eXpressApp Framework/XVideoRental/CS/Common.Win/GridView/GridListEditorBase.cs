/*using System;
using System.Collections.Generic;
using Common.Win;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.XtraEditors.Filtering;

[assembly: OnlineRepoLocation("http://goo.gl/oA79l")]

namespace Common.Win.GridView {
    internal class InternalXafWinFilterTreeNodeModel : WinFilterTreeNodeModelBase {
        protected override void OnCreateCustomRepositoryItem(DevExpress.XtraEditors.Filtering.CreateCustomRepositoryItemEventArgs args) {
            base.OnCreateCustomRepositoryItem(args);
            if(CreateCustomRepositoryItem != null) {
                CreateCustomRepositoryItem(this, args);
            }
        }

        public event EventHandler<DevExpress.XtraEditors.Filtering.CreateCustomRepositoryItemEventArgs> CreateCustomRepositoryItem;
    }

    internal class PatchXpoSpecificFieldNameForGridCriteriaProcessor : CriteriaProcessorBase {
        readonly List<string> existingLookupFieldNames;

        public PatchXpoSpecificFieldNameForGridCriteriaProcessor(List<string> existingLookupFieldNames) {
            this.existingLookupFieldNames = existingLookupFieldNames;
        }

        protected override void Process(OperandProperty theOperand) {
            if(AggregateLevel == 0 && !theOperand.PropertyName.EndsWith("!")) {
                string probeLookupFieldName = theOperand.PropertyName + '!';
                if(existingLookupFieldNames.Contains(probeLookupFieldName)) {
                    theOperand.PropertyName = probeLookupFieldName;
                }
            }
            base.Process(theOperand);
        }
    }
}*/

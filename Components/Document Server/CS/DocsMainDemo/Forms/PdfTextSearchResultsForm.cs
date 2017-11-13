using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.Docs.Demos {
	public partial class PdfTextSearchResultsForm : XtraForm {
		public PdfTextSearchResultsForm() {
			InitializeComponent();
            Icon = ResourceImageHelper.CreateIconFromResources("MainDemo.ico", typeof(frmMain).Assembly);
            CenterToParent();
		}
        public void SetItems(List<string> items) {
            ListBoxItemCollection itemCollection = listBoxControl.Items;
            itemCollection.Clear();
            itemCollection.AddRange(items.ToArray());
        }
	}
}

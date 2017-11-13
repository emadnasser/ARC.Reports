using System;

namespace DevExpress.Web.Demos.PdfPager {
    public class PdfPager : ASPxPager {
        protected override void CreateControlHierarchy()
        {
            base.CreateControlHierarchy();
            Summary.Text = "Page {0} of {1}";
        }
        protected override string GetItemElementOnClick(string id) {
            return String.Format("aspxPagerOnClick('{0}','{1}');", ClientID, id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Native;
using DevExpress.DemoData.Models;

namespace XtraReportsDemos.TreeView {
    public partial class TreeViewHolder : UserControl {
        IList<Hierarchy> regionsHierarchy;
        public TreeViewHolder() {
            InitializeComponent();

            imageList1.Images.Clear();
            Image bmp = XtraReportsDemos.Properties.Resources.continent;
            imageList1.ImageSize = bmp.Size;
            imageList1.Images.AddStrip(bmp);

            this.treeView1.TreeLevelWidth = bmp.Size.Width;
            using(CountriesEntities entities = new CountriesEntities(DevExpress.DemoReports.Properties.Settings.Default.countriesDBConnectionString))
                regionsHierarchy = entities.Hierarchy.ToList();

            PopulateTreeView();
        }
        static Image LoadImage(string name) {
            Bitmap bmp = (Bitmap)DevExpress.Utils.ResourceImageHelper.CreateImageFromResourcesEx("XtraReportsDemos." + name, System.Reflection.Assembly.GetExecutingAssembly());
            bmp.MakeTransparent(Color.Magenta);
            return bmp;
        }
        void PopulateTreeView() {
            treeView1.Nodes.Clear();
            Dictionary<string, TreeListNode> regions = new Dictionary<string, TreeListNode>();
            Dictionary<string, TreeListNode> subRegions = new Dictionary<string, TreeListNode>();

            TreeListNode nodeRegion = null;
            TreeListNode nodeSubRegion = null;

            foreach(Hierarchy hierarchy in regionsHierarchy) {
                if(!regions.TryGetValue(hierarchy.Region, out nodeRegion)) {
                    nodeRegion = CreateTreeNode(hierarchy.Region, 0, null);
                    regions.Add(hierarchy.Region, nodeRegion);
                }
                if(!subRegions.TryGetValue(hierarchy.SubRegion, out nodeSubRegion)) {
                    nodeSubRegion = CreateTreeNode(hierarchy.SubRegion, 0, nodeRegion);
                    subRegions.Add(hierarchy.SubRegion, nodeSubRegion);
                }
                int imageIndex = 0;
                try {
                    System.Drawing.Image img = DevExpress.XtraPrinting.Native.PSConvert.ImageFromArray(hierarchy.BFlag);
                    if(img != null)
                        imageList1.Images.Add(img);
                    imageIndex = imageList1.Images.Count - 1;
                } catch {
                }
                string countryName = hierarchy.OfficialName;
                if(countryName.Length > 60)
                    countryName = countryName.Substring(0, 60) + "...";
                TreeListNode node = CreateTreeNode(countryName, imageIndex, nodeSubRegion);
            }
        }
        TreeListNode CreateTreeNode(string text, int imageIndex, TreeListNode parentNode) {
            TreeListNode node = treeView1.AppendNode(new object[] { text }, parentNode);
            node.StateImageIndex = imageIndex;
            return node;
        }
    }
}

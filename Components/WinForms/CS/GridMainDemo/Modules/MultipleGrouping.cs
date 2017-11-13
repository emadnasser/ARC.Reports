using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for MultipleGrouping.
    /// </summary>
    public partial class MultipleGrouping : TutorialControl {
        public MultipleGrouping() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\MultipleGrouping.cs;CS\\GridMainDemo\\Modules\\Tasks.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.MultipleGrouping.xml";
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }


        //<gridControl1>
        //<sbGroup>
        GroupingControllerTasksWithCategories gc;
        //</sbGroup>

        private void MultipleGrouping_Load(object sender, System.EventArgs e) {
            gc = new GroupingControllerTasksWithCategories(gridControl1);
            gc.AfterGrouping += new EventHandler(gc_AfterGrouping);
            InitButtonCaption();
        }
        //</gridControl1>

        void InitButtonCaption() {
            sbGroup.Text = gc.IsCategoryGrouping ? Properties.Resources.UngroupCategory : Properties.Resources.GroupCategory;
        }

        //<sbGroup>
        private void sbGroup_Click(object sender, System.EventArgs e) {
            if (gc.CategoryColumn == null) {
                sbGroup.Enabled = false;
                return;
            }
            if (gc.CategoryColumn.GroupIndex == -1)
                gc.CategoryColumn.Group();
            else gc.CategoryColumn.UnGroup();
        }
        //</sbGroup>


        void gc_AfterGrouping(object sender, EventArgs e) {
            InitButtonCaption();
        }


    }
}

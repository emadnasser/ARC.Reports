using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraNavBar.Demos {
	/// <summary>
	/// Summary description for ViewStyles.
	/// </summary>
	public partial class ViewStyles : TutorialControl {
		public ViewStyles() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			InitComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private int IndexOf(ListBoxItemCollection itemsCollection, string s) {
			for(int i = 0; i < itemsCollection.Count; i++)
				if(itemsCollection[i].ToString() == s) return i;
			return -1;
		}

		private void InitComponent() {
			listBox1.Items.AddRange(navBarControl1.AvailableNavBarViews.ToArray(typeof(object)) as object[]);
			listBox1.SelectedIndex = IndexOf(listBox1.Items, navBarControl1.View.ToString());
		}

        //<listBox1>
		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e) {
			navBarControl1.View = listBox1.SelectedItem as DevExpress.XtraNavBar.ViewInfo.BaseViewInfoRegistrator;
			navBarControl1.ResetStyles();
		}
        //</listBox1>
	}
}

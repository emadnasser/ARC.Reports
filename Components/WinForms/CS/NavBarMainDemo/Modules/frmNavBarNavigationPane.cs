using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraNavBar;
using DevExpress.XtraEditors;

namespace DevExpress.XtraNavBar.Demos {
	/// <summary>
	/// Summary description for frmNavBarNavigationPane.
	/// </summary>
	public partial class frmNavBarNavigationPane : TutorialControl {
		public frmNavBarNavigationPane() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			navBarItem1.Tag = MailFilter.Inbox;
			navBarItem2.Tag = MailFilter.Outbox;
			navBarItem3.Tag = MailFilter.Sent;
			navBarItem4.Tag = MailFilter.Deleted;
			navBarItem5.Tag = MailFilter.Draft;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		void frmNavBarNavigationPane_Load(object sender, System.EventArgs e) {
			richTextBox1.LoadFile(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("NavBarMainDemo.Modules.Description.rtf"), RichTextBoxStreamType.RichText);
			InitControls();
			InitData();
            ImageList imgList = new ImageList();
            imgList.Images.AddRange(this.imageCollection2.Images.ToArray());
            this.treeView1.ImageList = imgList;
		}
		void InitData() {
			gridControl1.DataSource = OutlookData.CreateTaskTable();
			gridControl2.DataSource = OutlookData.CreateNotesTable();
			gridControl3.DataSource = OutlookData.CreateJournalTable();
		}

		void InitControls() {
			int selectedIndex = 0;
			NavBarGroup activeGroup = navBarGroup2;
			navBarControl1.ActiveGroup = activeGroup;
            //litter1.LocationChanged += new EventHandler(splitter1_LocationChanged);
			activeGroup.SelectedLinkIndex = selectedIndex;
			navBarControl1_ActiveGroupChanged(navBarControl1, new NavBarGroupEventArgs(activeGroup));
			navBarItem_LinkClicked(navBarControl1, new NavBarLinkEventArgs(activeGroup.ItemLinks[selectedIndex]));
            navBarControl1.OptionsNavPane.AllowOptionsMenuItem = true;
		}
        void splitter1_LocationChanged(object sender, EventArgs e) {
            CheckNavPaneState();
        }
        bool isProcessingLayout = false;
        protected void CheckNavPaneState() {
            if(navBarControl1.OptionsNavPane.IsAnimationInProgress) return;
            if(!isProcessingLayout) {
                try {
                    if(navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Expanded) {
                        if(navBarControl1.Width < navBarControl1.OptionsNavPane.ExpandedWidth) {
                            isProcessingLayout = true;
                            navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed;
                            return;
                        }
                    }
                    if(navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Collapsed) {
                        if(navBarControl1.Width > navBarControl1.CalcCollapsedPaneWidth()) {
                            isProcessingLayout = true;
                            navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded;
                            return;
                        }
                    }
                }
                finally {
                    isProcessingLayout = false;
                }
            }
        }
		void navBarControl1_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e) {
			ActiveGroupChanged(e.Group.Caption, e.Group.LargeImageIndex);
			if(e.Group.Caption == "Folder List") {
				treeView1.SelectedNode = treeView1.Nodes[0];
				treeView1.ExpandAll();	
			}
		}

		void ActiveGroupChanged(string caption, int index) {
			label1.Text = caption;
			pictureBox1.Image = imageCollection1.Images[index];
			ShowPanel(caption);
		}

		void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
			if(e.Link.Item.Tag != null)
				outlookStyle1.MailFilter = (MailFilter)e.Link.Item.Tag;
		}
 
		void ShowPanel(string caption) {
			foreach(Control c in pnlMain.Controls)
                if((c is Panel || c is XtraPanel) && c.Tag != null) {
					c.Dock = DockStyle.Fill;
					c.Visible = c.Tag.ToString() == caption;
				}
		}

		void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e) {
			string action = e.Node.Text;
			if("InboxOutboxDraftsSent ItemsDeleted Items".IndexOf(action) >= 0) {
				int selectedIndex = 0;
				NavBarGroup group = navBarGroup2;
				for(int i = 0; i < group.ItemLinks.Count; i++)
					if(group.ItemLinks[i].Item.Caption == action) {
						selectedIndex = i;
						break;
					}
				group.SelectedLinkIndex = selectedIndex;
				navBarItem_LinkClicked(navBarControl1, new NavBarLinkEventArgs(group.ItemLinks[selectedIndex]));
				action = "Mail";
			}
			for(int i = 0; i < navBarControl1.Groups.Count; i++)
				if(navBarControl1.Groups[i].Caption == action) {
					ActiveGroupChanged(action, navBarControl1.Groups[i].LargeImageIndex);
					ShowPanel(action);
					break;
				}
		}

		void button1_Click(object sender, System.EventArgs e) {
			if(textBox1.Text != "" || textBox2.Text != "")
				listBox1.Items.Add(textBox1.Text.Trim() + " " + textBox2.Text.Trim());
				textBox1.Text = textBox2.Text = textBox3.Text ="";
		}

		void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("www.devexpress.com");
		}

		void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e) {
			DataRow row = gridView1.GetDataRow(e.RowHandle);
			row["Image"] = 0;
			row["Check"] = false;
			row["Date"] = DateTime.Today;

		}
	}
}

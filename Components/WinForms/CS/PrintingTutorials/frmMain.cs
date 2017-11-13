using System;
using System.Windows.Forms;
using XtraPrintingDemos;
using XtraPrintingDemos.Tutorial1;
using DevExpress.Tutorials;
using DevExpress.LookAndFeel;
using DevExpress.DXperience.Demos;
using DevExpress.Skins;
using DevExpress.Utils;

namespace DevExpress.XtraBars.Demos.Tutorials {
	public partial class frmMain : DevExpress.Tutorials.FrmMain {
        [STAThread]
		static void Main() {
            DevExpress.UserSkins.BonusSkins.Register();

            Application.Run(new frmMain());
		}

        const string IntroDemoInfoName = "Intro";

        string[] descriptions = new string[] {
            "This lesson shows a Print Preview of a document, which contains a simple \"Product List\". To perform this task, it is necessary to handle a link's CreateReportHeaderArea event and use the e.Graph.DrawString method.",
            "This lesson illustrates how to draw a text with a custom font face, font size and horizontal and vertical alignment in a document header. This task is similar to Lesson 1, but modifies more properties of the Graphics object in the CreateReportHeaderArea event handler.",
			"This lesson demonstrates how to draw a simple single-cell table in a document's detail section. For this, you need to handle the CreateDetailArea event and draw a table cell with custom appearance settings.",
			"This lesson shows how to add a second cell to a table row in the detail band. The second cell is drawn to the right of the main cell and displays a price value with the applied currency format.",
			"This lesson shows how to add a third cell to a table row in the detail band. The third cell is drawn to the right of the previous two cells and displays a check box, drawn via the DrawCheckBox method.",
			"This lesson shows how to add a fourth cell to a table row in the detail band. The fourth cell is drawn to the right of the previous three cells and displays an image, drawn via the DrawImage method.",
			"This lesson demonstrates how to add a header row to the table. To perform this task, it is necessary to handle a link's CreateDetailHeaderArea event and draw four text bricks with the corresponding column names.",
			"This lesson shows how to draw a table with multiple rows, obtained from a datasource.\r\nIn addition, this tutorial illustrates how to insert page numbers and the current system date into page headers. For this, it is necessary to handle the CreateMarginalHeaderArea event and add system information via the DrawPageInfo method."
        };

		public frmMain() {
			InitializeComponent();
            Icon = ResourceImageHelper.CreateIconFromResources("PrintingTutorials.AppIcon.ico", typeof(frmMain).Assembly);
		}

        protected override DevExpress.DXperience.Demos.LookAndFeelMenu CreateMenu(BarManager manager, DefaultLookAndFeel lookAndFeel) {
            return new PrintingAppearanceMenu(manager, lookAndFeel, string.Empty, true);
        }

        void frmMain_Load(object sender, EventArgs e) {
            RegisterTutorials();
            TutorialsInfo.FillListBox(this.listBoxControl1, new string[] { IntroDemoInfoName });
			listBoxControl1.SortOrder = SortOrder.Ascending;
            listBoxControl1.SelectedIndex = -1;
            ShowModule(IntroDemoInfoName);
		}
        void RegisterTutorials() {
            TutorialsInfo.Add(IntroDemoInfoName, "XtraPrintingDemos.Tutorial1.LessonPreviewIntro");
            TutorialsInfo.Add("Lesson 1", "XtraPrintingDemos.Tutorial1.LessonPreviewControl1", descriptions[0]);
            TutorialsInfo.Add("Lesson 2", "XtraPrintingDemos.Tutorial1.LessonPreviewControl2", descriptions[1]);
            TutorialsInfo.Add("Lesson 3", "XtraPrintingDemos.Tutorial1.LessonPreviewControl3", descriptions[2]);
            TutorialsInfo.Add("Lesson 4", "XtraPrintingDemos.Tutorial1.LessonPreviewControl4", descriptions[3]);
            TutorialsInfo.Add("Lesson 5", "XtraPrintingDemos.Tutorial1.LessonPreviewControl5", descriptions[4]);
            TutorialsInfo.Add("Lesson 6", "XtraPrintingDemos.Tutorial1.LessonPreviewControl6", descriptions[5]);
            TutorialsInfo.Add("Lesson 7", "XtraPrintingDemos.Tutorial1.LessonPreviewControl7", descriptions[6]);
            TutorialsInfo.Add("Lesson 8", "XtraPrintingDemos.Tutorial1.LessonPreviewControl8", descriptions[7]);
        }
        void listBoxControl1_SelectedIndexChanged(object sender, System.EventArgs e) {
			if(listBoxControl1.SelectedItem != null)
				ShowModule(listBoxControl1.SelectedItem.ToString());
		}
        void ShowModule(string name) {
            pcMain.SuspendLayout();
            try {
                ModuleBase module = TutorialsInfo.ShowModuleEx(name, gcContainer, MainMenu, defaultLookAndFeel);
                SelectModule(module, true);
            } finally {
                pcMain.ResumeLayout();
            }
        }
	}
}

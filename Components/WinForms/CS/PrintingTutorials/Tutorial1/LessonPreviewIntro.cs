using System;
using System.ComponentModel;
using DevExpress.XtraPrinting;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.Tutorials;
using DevExpress.DXperience.Demos;

namespace XtraPrintingDemos.Tutorial1 {
    public class LessonPreviewIntro : ModuleBase {
        Container components;
        RichTextBox featuresRtf;

        public LessonPreviewIntro() {
            InitializeComponent();
            System.IO.Stream resourceStream = Assembly.GetAssembly(typeof(LessonPreviewIntro)).GetManifestResourceStream("PrintingTutorials.BaseForms.PrintingAbout.rtf");
            if(resourceStream != null)
                featuresRtf.LoadFile(resourceStream, RichTextBoxStreamType.RichText);
        }
        private void InitializeComponent() {
            components = new Container();
            featuresRtf = new RichTextBox();
            featuresRtf.Name = "featuresRtf";
            featuresRtf.Dock = DockStyle.Fill;

            Controls.Add(featuresRtf);
        }
    }
}

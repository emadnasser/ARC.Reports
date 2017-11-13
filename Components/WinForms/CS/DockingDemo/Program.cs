using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DevExpress.XtraBars.Demos.DockingDemo {
    static class Program {
        [STAThread]
        static void Main(string[] args) {
            bool isBarDemo = false;
            if(args.Length != 0) 
                isBarDemo = (args[0] == "-barDemo");
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            if(isBarDemo) DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
            else DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Blue");
            var splashScreenImage = new Bitmap(CurrentAssembly.GetManifestResourceStream("DockingDemo.Resources.splashScreen.png"));
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowImage(splashScreenImage, true, false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
        static Assembly currentAssemblyCore;
        static Assembly CurrentAssembly {
            get {
                if(currentAssemblyCore == null)
                    currentAssemblyCore = Assembly.GetExecutingAssembly();
                return currentAssemblyCore;
            }
        }
        internal static List<Stream> CreateResourceStreams() {
            List<Stream> fileStreams = new List<Stream>();
            fileStreams.Add(CurrentAssembly.GetManifestResourceStream("DockingDemo.Resources.ProgramText.rtf"));
            fileStreams.Add(CurrentAssembly.GetManifestResourceStream("DockingDemo.Resources.ProgramText2.rtf"));
            fileStreams.Add(CurrentAssembly.GetManifestResourceStream("DockingDemo.Resources.ProgramText3.rtf"));
            return fileStreams;
        }
        internal static Stream GetDocumentStream(string fileName) {
            return CurrentAssembly.GetManifestResourceStream(string.Format("DockingDemo.Resources.{0}.rtf", fileName));
        }
    }
}

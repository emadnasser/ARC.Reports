using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DevExpress.ApplicationUI.Demos {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Utils.Taskbar.Core.TaskbarAssistantCore.Initialize();
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
            fileStreams.Add(CurrentAssembly.GetManifestResourceStream("DevExpress.ApplicationUI.Demos.Resources.ucSolutionExplorer.rtf"));
            fileStreams.Add(CurrentAssembly.GetManifestResourceStream("DevExpress.ApplicationUI.Demos.Resources.ucToolbox.rtf"));
            fileStreams.Add(CurrentAssembly.GetManifestResourceStream("DevExpress.ApplicationUI.Demos.Resources.ucSolutionExplorer.rtf"));
            return fileStreams;
        }
        internal static Stream GetStream(string fileName) {
            return CurrentAssembly.GetManifestResourceStream(string.Format("DevExpress.ApplicationUI.Demos.Resources.{0}", fileName));
        }
    }
}

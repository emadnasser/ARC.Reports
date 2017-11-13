using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.VideoRent.Win.Forms;
using System.IO;
using System.Globalization;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace DevExpress.VideoRent.Win {
    static class Program {
        const string iniFilePath = "VideoRent.ini";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arguments) {
            WindowsFormsSettings.ApplyDemoSettings();
            DevExpress.Utils.LocalizationHelper.SetCurrentCulture(arguments);
            CultureInfo videoRentCI = (CultureInfo)Application.CurrentCulture.Clone();
            videoRentCI.NumberFormat.CurrencySymbol = "$";
            videoRentCI.NumberFormat.CurrencyDecimalDigits = 2;
            Application.CurrentCulture = videoRentCI;
            BonusSkins.Register();
            Skins.SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IniFile iniFile = new IniFile();
            if(File.Exists(iniFilePath)) iniFile.Load(iniFilePath);
            InitialDbCreator initialDbCreator = new InitialDbCreator(new CreateInitialDbDialog(), new ExceptionsProcesser(null));
            if(initialDbCreator.OpenDb(iniFile)) {
                iniFile.Save(iniFilePath);
                VideoRentCurrentUser.Login(XpoDefault.Session, ReferenceData.AdministratorString); //TODO Create Login-Dialog
                Application.Run(new frmMain());
            }
        }
    }
}

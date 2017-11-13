using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraSpreadsheet.Demos {
    public class SpreadSheetTutorialControlBase : DevExpress.DXperience.Demos.TutorialControlBase {
        CultureInfo defaultCulture = new CultureInfo("en-US");

        public override bool AutoMergeRibbon { get { return true; } set { } }
        public CultureInfo DefaultCulture { get { return defaultCulture; } }
    }

    public class DemoUtils {
        public static string GetRelativePath(string name) {
            name = "Data\\" + name;
            string path = System.Windows.Forms.Application.StartupPath;
            string s = "\\";
            for (int i = 0; i <= 10; i++) {
                if (System.IO.File.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            return "";
        }
        public static Bitmap LoadImageByName(string name) {
            Stream stream = typeof(frmMain).Assembly.GetManifestResourceStream("Modules." + name);
            if (stream == null)
                stream = typeof(frmMain).Assembly.GetManifestResourceStream(name);
            if (stream != null)
                return (Bitmap)DevExpress.Data.Utils.ImageTool.ImageFromStream(stream);
            return null;
        }
        //public static void SetConnectionString(System.Data.OleDb.OleDbConnection oleDbConnection, string path) {
        //    oleDbConnection.ConnectionString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path);
        //}
        public static void SetDatabasePath() {
            const string dbName = "nwind.mdb";
            const string pathToDbTag = "|pathToDb|";
            string path = GetRelativePath(dbName);
            if(String.IsNullOrEmpty(path))
                return;
            string connectionString = global::Properties.Settings.Default["nwindConnectionString"] as string;
            if(String.IsNullOrEmpty(connectionString))
                return;
            connectionString = connectionString.Replace(pathToDbTag, path);
            global::Properties.Settings.Default["nwindConnectionString"] = connectionString;
        }

        public static string GetLanguageString() {
            string result = DemoHelper.GetLanguageString(typeof(frmMain).Assembly);
            if(result == "CS")
                result = "C#";
            return result;
        }
    }
    public class DemoMenuManager {
        public static void SetMenuManager(Control.ControlCollection controls, IDXMenuManager menuManager) {
            int count = controls.Count;
            for (int i = 0; i < count; i++) {
                Control control = controls[i];
                BaseEdit baseEdit = control as BaseEdit;
                if (baseEdit != null)
                    baseEdit.MenuManager = menuManager;

                SetMenuManager(control.Controls, menuManager);
            }
        }
    }
}

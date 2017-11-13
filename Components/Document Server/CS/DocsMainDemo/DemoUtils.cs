using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using DevExpress.DXperience.Demos;

namespace DevExpress.Docs.Demos {
    /// <summary>
    /// Summary description for DemoUtils.
    /// </summary>
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
        public static string GetRelativeDirectoryPath(string name) {
            name = "Data\\" + name;
            string path = System.Windows.Forms.Application.StartupPath;
            string s = "\\";
            for (int i = 0; i <= 10; i++) {
                if (System.IO.Directory.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            return "";
        }
        public static void SetConnectionString(System.Data.OleDb.OleDbConnection oleDbConnection, string path) {
            oleDbConnection.ConnectionString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path);
        }
        public static void PreviewDocument(string fileName) {
            string extensionRegistryPathBase = @"HKEY_CLASSES_ROOT\";
            FileInfo info = new FileInfo(fileName);
            var extensionRegistryPath = string.Format("{0}{1}", extensionRegistryPathBase, info.Extension);
            string value = Registry.GetValue(extensionRegistryPath, string.Empty, string.Empty) as string;
            string execSwitch = (String.IsNullOrEmpty(value)) ? "/select" : "/p";
            System.Diagnostics.Process.Start("explorer.exe", String.Format("{0}, {1}", execSwitch, fileName));
        }

        public static string GetLanguageString() {
            string result = DemoHelper.GetLanguageString(typeof(frmMain).Assembly);
            if(result == "CS")
                result = "C#";
            return result;
        }
    }
}

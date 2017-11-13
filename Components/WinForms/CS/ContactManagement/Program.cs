using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace ContactManagement {
    static class Program {
        [STAThread]
        static void Main(string[] args) {

            try {
                using(MSSqlLocalDB2012Helper localDBHelper = new MSSqlLocalDB2012Helper()) {
                    string connectionString = null;
                    if(args != null && args.Length == 1) {
                        connectionString = args[0];
                    } else {
                        if(localDBHelper.Setup()) {
                            connectionString = MSSqlConnectionProvider.GetConnectionString(localDBHelper.LocalDBConnection, "CMDemo" + AssemblyInfo.Version);
                        } else {
                            connectionString = InMemoryDataStore.GetConnectionString(System.IO.Path.ChangeExtension(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    AppDomain.CurrentDomain.FriendlyName + "_DB"), "xml"));
                        }
                    }
                    XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
                    Application.Run(new MainForm());
                }
            } catch(Exception e) {
                MessageBox.Show(e.ToString(), "ContactManagement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

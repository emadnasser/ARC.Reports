using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo.DB;
using DevExpress.Utils;
using System.Reflection;

namespace DevExpress.Xpo.Demos {
    static class Program {
        [STAThread]
        static void Main() {
            DevExpress.UserSkins.BonusSkins.Register();
            
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(InMemoryDataStore.GetConnectionString("XpoTutorials.xml"), AutoCreateOption.DatabaseAndSchema);

            Application.Run(new frmMain());
        }
    }
}

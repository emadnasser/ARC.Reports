using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo.DB.Helpers;

namespace ContactManagement {
    public class MSSqlLocalDB2012Helper: IDisposable {
        string localDBConnection;
        public string LocalDBConnection {
            get { return localDBConnection; }
        }
        bool isMSSqlLocalDBApiExists;
        public const string LocalDBInstanceName = "XpoDemos";
        public bool Setup() {
            try {
                using(MSSqlLocalDBApi localdb = new MSSqlLocalDBApi()) {
                    MSSqlLocalDBInstanceInfo info = localdb.GetInstanceInfo(LocalDBInstanceName);
                    if(!info.Exists) {
                        string[] versions = localdb.GetVersions();
                        Array.Sort(versions);
                        localdb.CreateInstance(versions[versions.Length - 1], LocalDBInstanceName);
                    }
                    if(!info.IsRunning) {
                        localdb.StartInstance(LocalDBInstanceName, out localDBConnection);
                    }
                }
                isMSSqlLocalDBApiExists = true;
            } catch { }
            return isMSSqlLocalDBApiExists;
        }
        public void TearDown() {
            if(isMSSqlLocalDBApiExists) {
                try {
                    using(MSSqlLocalDBApi localdb = new MSSqlLocalDBApi()) {
                        MSSqlLocalDBInstanceInfo info = localdb.GetInstanceInfo(LocalDBInstanceName);
                        if(!info.Exists)
                            return;
                        if(info.IsRunning)
                            localdb.StopInstance(LocalDBInstanceName, MSSqlLocalDBShutdownFlags.None, 5000);
                    }
                } catch { }
            }
        }
        void IDisposable.Dispose() {
            TearDown();
        }
    }
}

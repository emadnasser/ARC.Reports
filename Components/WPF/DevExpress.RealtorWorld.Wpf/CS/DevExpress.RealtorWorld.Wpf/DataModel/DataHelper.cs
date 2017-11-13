using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using DevExpress.DemoData.Helpers;

namespace DevExpress.RealtorWorld.Xpf.DataModel {
    public static class DataHelper {
        public static ReusableStream GetDataFile(string name) {
            return DataFilesHelper.GetDataFile(name);
        }
    }
}

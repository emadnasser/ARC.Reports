using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos.Models {
    public class LargeDatabaseDataContextExt : LargeDatabaseDataContext {
        static string ConnectionString {
            get { return EmailDataGenerator.Table.ConnectionString; }
        }
        public LargeDatabaseDataContextExt() : base(ConnectionString) { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.Threading;

namespace DevExpress.Xpo.Demos {
    public class DelayedDataLayer: IDataLayer {
        IDataLayer dataLayer;
        public DelayedDataLayer(IDataLayer dataLayer) {
            if (dataLayer == null)
                throw new ArgumentException();
            this.dataLayer = dataLayer;
            dataLayer.SchemaInit += new SchemaInitEventHandler(dataLayer_SchemaInit);
        }

        void dataLayer_SchemaInit(object sender, SchemaInitEventArgs e) {
            if (SchemaInit != null) {
                SchemaInit(sender, e);
            }
        }
        public AutoCreateOption AutoCreateOption {
            get {
                return dataLayer.AutoCreateOption;
            }
        }

        public System.Data.IDbConnection Connection {
            get {
                throw new NotSupportedException();
            }
        }

        public System.Data.IDbCommand CreateCommand() {
            throw new NotSupportedException();
        }

        public object GetDataLayerWideData(object key) {
            return dataLayer.GetDataLayerWideData(key);
        }

        public ModificationResult ModifyData(params ModificationStatement[] dmlStatements) {
            Thread.Sleep(1000);
            return dataLayer.ModifyData(dmlStatements);
        }

        public event SchemaInitEventHandler SchemaInit;

        public SelectedData SelectData(params SelectStatement[] selects) {
            Thread.Sleep(1000);
            SelectedData data = dataLayer.SelectData(selects);
            return data;
        }

        public void SetDataLayerWideData(object key, object data) {
            dataLayer.SetDataLayerWideData(key, data);
        }

        public UpdateSchemaResult UpdateSchema(bool dontCreateIfFirstTableNotExist, params DevExpress.Xpo.Metadata.XPClassInfo[] types) {
            return dataLayer.UpdateSchema(dontCreateIfFirstTableNotExist, types);
        }

        public void Dispose() {
            if (dataLayer != null) {
                dataLayer.Dispose();
            }
        }

        public IDataLayer DataLayer {
            get { return this; }
        }

        public DevExpress.Xpo.Metadata.XPDictionary Dictionary {
            get {
                return dataLayer.Dictionary;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using Northwind;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.ServiceModel;
using System.IO;
using System.Web;

namespace DevExpress.Xpo.Demos {

    public class XpoDemoContext : XpoContext {
        public XpoDemoContext(string s1, string s2, IDataLayer dataLayer)
            : base(s1, s2, dataLayer) {
        }
    }
    public class MyFactory : DataServiceHostFactory {
        public MyFactory()
            : base() {
        }
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses) {
            return base.CreateServiceHost(serviceType, baseAddresses);
        }
    }
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class XpoDemoService : XpoDataServiceV3 {
        static readonly XpoContext context = new XpoContext("XpoContext", "Northwind", CreateDataLayer());

        public XpoDemoService() : base(context) { }

        static IDataLayer CreateDataLayer() {
            DevExpress.Xpo.Metadata.XPDictionary dict = new DevExpress.Xpo.Metadata.ReflectionDictionary();
            // Initialize the XPO dictionary. 
            dict.GetDataStoreSchema(typeof(Orders).Assembly);
            InMemoryDataStore store = new InMemoryDataStore(AutoCreateOption.SchemaOnly);
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(HttpRuntime.AppDomainAppPath, "Data\\nwind.xml");
            if(DBFileName != "") 
                store.ReadXml(DBFileName);
            IDataLayer dataLayer = new ThreadSafeDataLayer(dict, store);
            XpoDefault.DataLayer = dataLayer;
            XpoDefault.Session = null;
            return dataLayer;
        }
        protected override void OnStartProcessingRequest(ProcessRequestArgs args) {
            base.OnStartProcessingRequest(args);
        }
        public static void InitializeService(DataServiceConfiguration config) {
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.DataServiceBehavior.AcceptAnyAllRequests = true;
            config.UseVerboseErrors = true;
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
            config.SetServiceActionAccessRule("*", ServiceActionRights.Invoke);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
            config.DataServiceBehavior.AcceptProjectionRequests = true;
            config.DataServiceBehavior.AcceptCountRequests = true;
            config.AnnotationsBuilder = CreateAnnotationsBuilder(() => context);
            config.DataServiceBehavior.AcceptReplaceFunctionInQuery = true;
            config.DataServiceBehavior.AcceptSpatialLiteralsInQuery = true;
            config.DisableValidationOnMetadataWrite = true;            
        }
    }
}

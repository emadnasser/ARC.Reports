using System;
using System.Collections;
using System.IO;
using System.Linq;
using Common.Win.General.DashBoard.BusinessObjects;
using DevExpress.DashboardCommon;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;

namespace Common.Win.General.DashBoard.Helpers {
    public static class TemplateHelper {
        static Type DashBoardObjectType(IDashboardDefinition template, Dashboard dashboard, ITypeWrapper typeWrapper) {
            var wrapper = template.DashboardTypes.FirstOrDefault(type => type.Caption.Equals(dashboard.DataSources.First(ds => ds.Name.Equals(typeWrapper.Caption)).Name));
            return wrapper != null ? wrapper.Type : null;
        }

        public static Dashboard CreateDashBoard(this IDashboardDefinition template, IObjectSpace objectSpace, bool filter) {
            var dashboard = new Dashboard();
            try {
                LoadFromXml(template.Xml, dashboard);
                foreach (ITypeWrapper typeWrapper in template.DashboardTypes) {
                    ITypeWrapper wrapper = typeWrapper;
                    if (dashboard.DataSources.Contains(ds => ds.Name.Equals(wrapper.Caption))) {
                        Type dashBoardObjectType = DashBoardObjectType(template, dashboard, typeWrapper);
                        if (dashBoardObjectType != null) {
                            ITypeWrapper wrapper1 = typeWrapper;
                            var dataSource = dashboard.DataSources.First(ds => ds.Name.Equals(wrapper1.Caption));
                            dataSource.Data = GetObjects(objectSpace, dashBoardObjectType);
                        }
                    }
                    else if (!dashboard.DataSources.Contains(ds => ds.Name.Equals(wrapper.Caption)))
                        dashboard.DataSources.Add(new DashboardObjectDataSource(typeWrapper.Caption, GetObjects(objectSpace, typeWrapper.Type)));
                }
                if (filter)
                    Filter(template, dashboard);
            }
            catch (Exception e) {
                dashboard.Dispose();
                Tracing.Tracer.LogError(e);
            }
            return dashboard;
        }

        private static IList GetObjects(IObjectSpace objectSpace, Type dashBoardObjectType) {
            var proxyCollection = new ProxyCollection(objectSpace, XafTypesInfo.CastTypeToTypeInfo(dashBoardObjectType), objectSpace.GetObjects(dashBoardObjectType));
            proxyCollection.DisplayableMembers = string.Join(";", proxyCollection.DisplayableMembers.Split(';').Where(s => !s.EndsWith("!")));
            return proxyCollection;
        }

        public class ParameterLessProxyCollection : ProxyCollection{
            public ParameterLessProxyCollection(IObjectSpace objectSpace, ITypeInfo typeInfo, object collection)
                : base(objectSpace, typeInfo, collection){
            }

            public ParameterLessProxyCollection()
                : base(
                    ObjectSpaceInMemory.CreateNew(),
                    XafTypesInfo.Instance.FindTypeInfo(typeof(ParameterLessProxyCollection)), new object[0]){
            }
        }

        static void Filter(IDashboardDefinition template, Dashboard dashboard) {
            var types = template.DashboardTypes.Select(tw => tw.Caption).ToArray();
            for (int i = dashboard.DataSources.Count - 1; i >= 0; i--)
                if (!types.Contains(dashboard.DataSources[i].Name))
                    dashboard.DataSources.RemoveAt(i);
        }

        static void LoadFromXml(string xml, Dashboard dashboard) {
            if (xml != null) {
                using (var me = new MemoryStream()) {
                    var sw = new StreamWriter(me);
                    sw.Write(xml);
                    sw.Flush();
                    me.Seek(0, SeekOrigin.Begin);
                    dashboard.LoadFromXml(me);
                    sw.Close();
                    me.Close();
                }
            }
        }
    }
}

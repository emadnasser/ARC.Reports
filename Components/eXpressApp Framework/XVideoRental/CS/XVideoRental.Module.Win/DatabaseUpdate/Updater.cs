using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using Common.Win.General.DashBoard.BusinessObjects;
using Common.Win.General.Import;
using Common.Win.General.Security;
using Common.Win.General.Sequence;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.Strategy;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using XVideoRental.Module.Win.BusinessObjects;
using XVideoRental.Module.Win.BusinessObjects.Movie;
using XVideoRental.Module.Win.BusinessObjects.Rent;
using Country = XVideoRental.Module.Win.BusinessObjects.Movie.Country;

namespace XVideoRental.Module.Win.DatabaseUpdate {
    public enum PermissionBehavior {
        Admin,
        Settings,
        ReadOnlyAccess
    }

    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            VideoRentalBaseObject.Updating = true;
            SequenceGeneratorInitializer.Initialize();
            SequenceGenerator.RegisterSequences(XafTypesInfo.Instance.PersistentTypes);
            var employersRole = CreateUserData();
            if (employersRole != null) {
                var importHelper = new ImportHelper(ObjectSpace, this);
                importHelper.Import();
                SetPermissions(employersRole);
            }
            CreateDashboards();

            ObjectSpace.CommitChanges();
            VideoRentalBaseObject.Updating = false;
        }

        void CreateDashboards() {
            CreateDashboards("Rentals", 0, new[] { typeof(Rent), typeof(MovieItem) }, ImageLoader.Instance.GetLargeImageInfo("CustomerFilmRentsList").Image);
            CreateDashboards("Customer Revenue", 1, new[] { typeof(Rent), typeof(Receipt) }, ImageLoader.Instance.GetLargeImageInfo("CustomerRevenue").Image);
            CreateDashboards("Demographics", 2, new[] { typeof(Rent) }, ImageLoader.Instance.GetLargeImageInfo("CustomersKPI").Image);
        }

        private static string GetDashboardLayout(string dashboardName) {
            Type moduleType = typeof(XVideoRentalWindowsFormsCommonWindowsFormsModule);
            string name = moduleType.Namespace + ".Resources." + dashboardName + " Dashboard.txt";
            Stream manifestResourceStream = moduleType.Assembly.GetManifestResourceStream(name);
            if (manifestResourceStream == null)
                throw new ArgumentNullException(name);
            using (var reader = new StreamReader(manifestResourceStream))
                return reader.ReadLine();
        }

        private void CreateDashboards(string dashboardName, int index, IEnumerable<Type> types, Image icon) {
            UpdateStatus("CreateDashboard", "", String.Format("Creating dashboard: {0}", dashboardName));
            var dashboard = ObjectSpace.FindObject<DashboardDefinition>(new BinaryOperator("Name", dashboardName));
            if (dashboard == null) {
                dashboard = ObjectSpace.CreateObject<DashboardDefinition>();
                dashboard.Name = dashboardName;
                dashboard.Xml = GetDashboardLayout(dashboardName);
                dashboard.Icon = icon;
                dashboard.Index = index;
                dashboard.Active = true;
                foreach (var type in types)
                    dashboard.DashboardTypes.Add(new TypeWrapper(((XPObjectSpace)ObjectSpace).Session, type));
            }
            var dashboardRole = ObjectSpace.GetRole("Dashboard View Role");
            var dashboardCollection = (XPBaseCollection)dashboardRole.GetMemberValue(typeof(DashboardDefinition).Name + "s");
            dashboardRole.SetMemberValue("DashboardOperation", SecurityOperationsEnum.ReadOnlyAccess);
            dashboardCollection.BaseAdd(dashboard);
        }

        void SetPermissions(SecuritySystemRole employersRole) {
            employersRole.SetTypePermissions<ReportData>(SecurityOperations.ReadOnlyAccess, SecuritySystemModifier.Allow);
            employersRole.CreatePermissionBehaviour(PermissionBehavior.ReadOnlyAccess, (role, info) => role.SetTypePermissions(info.Type, SecurityOperations.ReadOnlyAccess, SecuritySystemModifier.Allow));
        }

        Stream GetResourceStream(string resource) {
            var moduleType = typeof(XVideoRentalWindowsFormsCommonWindowsFormsModule);
            return moduleType.Assembly.GetManifestResourceStream(string.Format(moduleType.Namespace + ".Resources.{0}", resource));
        }

        XRole CreateUserData() {
            InitAdminSecurityData();
            return InitVideoRentalSecurityData();
        }

        XRole InitVideoRentalSecurityData() {
            var defaultRole = ObjectSpace.GetDefaultRole<XRole>();
            if (ObjectSpace.IsNewObject(defaultRole)) {
                var employersRole = ObjectSpace.GetRole<XRole>("Employers");
                var dashboardRole = ObjectSpace.GetRole<XRole>("Dashboard View Role");

                SecuritySystemUser user1 = employersRole.GetUser("User");
                SecuritySystemUser user2 = dashboardRole.GetUser("DashboardUser");

                user1.Roles.Add(defaultRole);
                user2.Roles.Add(defaultRole);
                user2.Roles.Add(dashboardRole);

                employersRole.CreateFullPermissionAttributes();
                return employersRole;
            }
            return null;
        }

        void InitAdminSecurityData() {
            var securitySystemRole = ObjectSpace.GetAdminRole<XRole>("Administrator");
            securitySystemRole.GetUser("Admin");
        }

        public void CopyStream(Stream input, Stream output) {
            var buffer = new byte[8192];
            int bytesRead;
            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0) {
                output.Write(buffer, 0, bytesRead);
            }
        }

        public void SaveResource(string resource) {
            var resourceStream = GetResourceStream(resource);
            var path = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, resource);
            if (File.Exists(path))
                File.Delete(path);
            using (Stream output = File.Create(path)) {
                CopyStream(resourceStream, output);
            }
        }
    }

    class ImportHelper {
        readonly UnitOfWork _unitOfWork;
        readonly IObjectSpace _objectSpace;
        private readonly Updater _updater;

        public ImportHelper(IObjectSpace objectSpace, Updater updater) {
            _objectSpace = objectSpace;
            _updater = updater;
            _updater.UpdateStatus("Import", "", "Extracting initial data");
            _unitOfWork = ConnectToLegacyVideoRentDB();
        }


        UnitOfWork ConnectToLegacyVideoRentDB() {
            _updater.SaveResource("LegacyVideoRent.mdb");
            var unitOfWork = new UnitOfWork {
                ConnectionString = ConfigurationManager.ConnectionStrings["VideoRentLegacy"].ConnectionString,
                AutoCreateOption = AutoCreateOption.None
            };
            unitOfWork.Connect();
            return unitOfWork;
        }

        public UnitOfWork UnitOfWork {
            get { return _unitOfWork; }
        }

        public void Import() {
            _updater.UpdateStatus("Import", "", "");
            var initDataImporter = new InitDataImporter();
            initDataImporter.CreatingDynamicDictionary += (sender, args) => _updater.UpdateStatus("Import", "", "Creating a dynamic dictionary...");
            initDataImporter.TransformingRecords += (sender, args) => NotifyWhenTransform(args.InputClassName, args.Position);
            initDataImporter.CommitingData += (sender, args) => _updater.UpdateStatus("Import", "", "Commiting data...");

            initDataImporter.Import(() => new UnitOfWork(((XPObjectSpace)_objectSpace).Session.ObjectLayer), () => new UnitOfWork(_unitOfWork.ObjectLayer));
            UpdatePhotosFromReusableStorage();
        }

        private UnitOfWork GetXmlUnitOfWork() {
            var reflectionDictionary = new ReflectionDictionary();
            var appSetting = string.Format(ConfigurationManager.AppSettings["VideoRentLegacyPath"], AssemblyInfo.VersionShort);
            var fullPath = Environment.ExpandEnvironmentVariables(appSetting);

            var legacyAssembly = Assembly.LoadFrom(Path.Combine(fullPath + @"\bin", @"DevExpress.VideoRent.dll"));
            reflectionDictionary.CollectClassInfos(legacyAssembly);
            var inMemoryDataStore = new InMemoryDataStore();
            inMemoryDataStore.ReadXml(Path.Combine(fullPath + @"\CS\DevExpress.VideoRent\Data", @"VideoRent.xml"));
            var simpleDataLayer = new SimpleDataLayer(reflectionDictionary, inMemoryDataStore);
            return new UnitOfWork(simpleDataLayer);
        }

        private void UpdatePhotosFromReusableStorage() {
            try {
                var xmlUnitOfWork = GetXmlUnitOfWork();
                _objectSpace.CommitChanges();
                foreach (var type in new[] { typeof(Customer), typeof(Movie), typeof(Country), typeof(MoviePicture), typeof(ArtistPicture) }) {
                    string memberName = type.Name + "Id";
                    Func<VideoRentalBaseObject, object> parameters = o => o.GetMemberValue("Id");
                    if (type == typeof(Country)) {
                        memberName = "Name";
                        parameters = o => o.GetMemberValue(memberName);
                    }
                    else if (type == typeof(MoviePicture)) {
                        memberName = "Movie.MovieId";
                        parameters = o => ((XPBaseObject)o.GetMemberValue("Movie")).GetMemberValue("Id");
                    }
                    else if (type == typeof(ArtistPicture)) {
                        memberName = "Artist.ArtistId";
                        parameters = o => ((XPBaseObject)o.GetMemberValue("Artist")).GetMemberValue("Id");
                    }
                    UpdateImage(type, xmlUnitOfWork, memberName, parameters);
                }
                _objectSpace.CommitChanges();
            }
            catch (Exception e) {
                Tracing.Tracer.LogError(e);
            }
        }

        private void UpdateImage(Type type, UnitOfWork xmlUnitOfWork, string memberName, Func<VideoRentalBaseObject, object> parameters) {
            foreach (var rentalBaseObject in _objectSpace.GetObjects(type, null, true).Cast<VideoRentalBaseObject>()) {
                var classInfo = xmlUnitOfWork.Dictionary.Classes.OfType<XPClassInfo>().FirstOrDefault(info => info.TableName == type.Name);
                var baseObject = (XPBaseObject)xmlUnitOfWork.FindObject(classInfo, CriteriaOperator.Parse(memberName + "=?", parameters(rentalBaseObject)));
                var memberInfos = rentalBaseObject.ClassInfo.Members.Where(info => info.MemberType == typeof(Image) && info.IsPublic);
                foreach (var memberInfo in memberInfos) {
                    _updater.UpdateStatus("Import", "Import", "Updating " + type.Name + " " + memberInfo.Name + "s");
                    memberInfo.SetValue(rentalBaseObject, baseObject.GetMemberValue(memberInfo.Name));
                }
            }
        }


        void NotifyWhenTransform(string inputClassName, int position) {
            var statusMessage = position > -1
                                       ? string.Format("Transforming records from {0}: {1}", inputClassName, position)
                                       : string.Format("Transforming records from {0} ...", inputClassName);
            _updater.UpdateStatus("Import", "", statusMessage);
        }

    }
}

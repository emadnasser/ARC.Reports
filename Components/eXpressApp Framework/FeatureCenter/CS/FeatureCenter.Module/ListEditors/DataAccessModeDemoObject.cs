using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Collections.Generic;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Demos;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.EF.Updating;

namespace FeatureCenter.Module.ListEditors {
	public class TestDbContext : DbContext {
		private void DatabaseLog(String str) {
			if(str.Contains("SELECT") && (DatabaseSelectExecuted != null)) {
				DatabaseSelectExecuted(this, EventArgs.Empty);
			}
		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<DataAccessModeDemoReferenceObjectA>().ToTable("DataAccessModeDemoReferenceObjectsA");
			modelBuilder.Entity<DataAccessModeDemoReferenceObjectB>().ToTable("DataAccessModeDemoReferenceObjectsB");
			modelBuilder.Entity<DataAccessModeDemoReferenceObjectC>().ToTable("DataAccessModeDemoReferenceObjectsC");
			modelBuilder.Entity<ModuleInfo>().ToTable("ModulesInfo");
		}
		protected override void Dispose(Boolean disposing) {
			base.Dispose(disposing);
			Database.Log = null;
		}
		public TestDbContext(String connectionString)
			: base(connectionString) {
			Database.Log = DatabaseLog;
		}
		public TestDbContext(DbConnection connection)
			: base(connection, false) {
			Database.Log = DatabaseLog;
		}
		public DbSet<DataAccessModeDemoObject> DataAccessModeDemoObjects { get; set; }
		public DbSet<DataAccessModeDemoReferenceObjectA> DataAccessModeDemoReferenceObjectsA { get; set; }
		public DbSet<DataAccessModeDemoReferenceObjectB> DataAccessModeDemoReferenceObjectsB { get; set; }
		public DbSet<DataAccessModeDemoReferenceObjectC> DataAccessModeDemoReferenceObjectsC { get; set; }
        public DbSet<DevExpress.Persistent.BaseImpl.EF.DashboardData> DashboardData { get; set; }
        public DbSet<ContactBands> Contacts { get; set; }
        public DbSet<OrderBands> Orders { get; set; }
        public DbSet<ProductBands> Products { get; set; }

		public DbSet<ModuleInfo> ModulesInfo { get; set; }
		public static event EventHandler DatabaseSelectExecuted;
	}
	
	[Hint(Hints.DataAccessModeDemoObjectHint)]
	[ImageName("ListEditors.Demo_ListEditors_Grid_LargeData")]
	public class DataAccessModeDemoObject : IObjectSpaceLink, IObjectPropertiesInitializer {
		private IObjectSpace objectSpace;
		private Int32 index;
		private Int32 id;
		private String name;
		private Int32 intProperty;
		private Boolean booleanProperty;
		private SampleEnum enumProperty;
		private DataAccessModeDemoReferenceObjectA referenceObjectA;
		public DataAccessModeDemoObject() {
		}
		[Browsable(false)]
		public Int32 Index {
			get { return index; }
			set { index = value; }
		}
		public Int32 ID {
			get { return id; }
			set { id = value; }
		}
		public String Name {
			get { return name; }
			set { name = value; }
		}
		public Int32 IntegerProperty {
			get { return intProperty; }
			set { intProperty = value; }
		}
		public Boolean BooleanProperty {
			get { return booleanProperty; }
			set { booleanProperty = value; }
		}
		public SampleEnum EnumProperty {
			get { return enumProperty; }
			set { enumProperty = value; }
		}
		public virtual DataAccessModeDemoReferenceObjectA ReferenceObjectA {
			get { return referenceObjectA; }
			set { referenceObjectA = value; }
		}

		// IObjectSpaceLink
		IObjectSpace IObjectSpaceLink.ObjectSpace {
			get { return objectSpace; }
			set { objectSpace = value; }
		}

		// IObjectPropertiesInitializer
		void IObjectPropertiesInitializer.InitializeObject(Int32 index) {
			IntegerProperty = index;
			Name = "DataAccessModeDemoObject" + index.ToString("00000");
			Index = index;
			BooleanProperty = (index % 2 == 0);
			EnumProperty = BooleanProperty ? SampleEnum.First : ((index % 3 == 0) ? SampleEnum.Second : SampleEnum.Third);
			referenceObjectA = (DataAccessModeDemoReferenceObjectA)objectSpace.CreateObject(typeof(DataAccessModeDemoReferenceObjectA));
			referenceObjectA.ReferenceObjectB = (DataAccessModeDemoReferenceObjectB)objectSpace.CreateObject(typeof(DataAccessModeDemoReferenceObjectB));
			referenceObjectA.ReferenceObjectB.ReferenceObjectC = (DataAccessModeDemoReferenceObjectC)objectSpace.CreateObject(typeof(DataAccessModeDemoReferenceObjectC));
			referenceObjectA.Name = Name;
			referenceObjectA.ReferenceObjectB.Name = Name;
			referenceObjectA.ReferenceObjectB.ReferenceObjectC.Name = Name;
		}
	}

	public class DataAccessModeDemoReferenceObjectA {
		private Int32 id;
		private String name;
		private DataAccessModeDemoReferenceObjectB referenceObjectB;
		public DataAccessModeDemoReferenceObjectA() {
		}
		public Int32 ID {
			get { return id; }
			set { id = value; }
		}
		public String Name {
			get { return name; }
			set { name = value; }
		}
		public virtual DataAccessModeDemoReferenceObjectB ReferenceObjectB {
			get { return referenceObjectB; }
			set { referenceObjectB = value; }
		}
	}

	public class DataAccessModeDemoReferenceObjectB {
		private Int32 id;
		private String name;
		private DataAccessModeDemoReferenceObjectC referenceObjectC;
		public DataAccessModeDemoReferenceObjectB() {
		}
		public Int32 ID {
			get { return id; }
			set { id = value; }
		}
		public String Name {
			get { return name; }
			set { name = value; }
		}
		public virtual DataAccessModeDemoReferenceObjectC ReferenceObjectC {
			get { return referenceObjectC; }
			set { referenceObjectC = value; }
		}
	}

	public class DataAccessModeDemoReferenceObjectC {
		private Int32 id;
		private String name;
		public DataAccessModeDemoReferenceObjectC() {
		}
		public Int32 ID {
			get { return id; }
			set { id = value; }
		}
		public String Name {
			get { return name; }
			set { name = value; }
		}
	}
}

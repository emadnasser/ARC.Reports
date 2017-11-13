using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;

namespace EFDemo.Module.Data {
	[NavigationItem("Reports")]
	[MetadataType(typeof(AnalysisMetadata))]
	public partial class Analysis : IAnalysisInfo, IAnalysisInfoTestable, ISupportInitialize, IXafEntityObject {
		private const String propertiesSeparator = ";";
		private InitializeIndicator initializeIndicator;
		private DimensionPropertiesList dimensionProperties;

		private Boolean IsInitializing {
			get { return initializeIndicator.IsInitializing; }
		}
		private void OnAnalysisInfoChanged(AnalysisInfoChangeType changeType) {
			if(InfoChanged != null) {
				InfoChanged(this, new AnalysisInfoChangedEventEventArgs(changeType));
			}
		}
		private void dimensionProperties_ListChanged(Object sender, EventArgs e) {
			DimensionPropertiesString = String.Join(propertiesSeparator, dimensionProperties);
			OnAnalysisInfoChanged(AnalysisInfoChangeType.DimensionPropertiesChanged);
		}
		private void SetDimensionProperties(String[] dimensionProperties) {
			this.dimensionProperties.ListChanged -= new EventHandler(dimensionProperties_ListChanged);
			this.dimensionProperties.Clear();
			foreach(String dimensionProperty in dimensionProperties) {
				this.dimensionProperties.Add(dimensionProperty);
			}
			this.dimensionProperties.ListChanged += new EventHandler(dimensionProperties_ListChanged);
		}
		protected internal void UpdateDimensionProperties() {
			String[] dimensionProperties = null;
			if(!String.IsNullOrEmpty(DimensionPropertiesString)) {
				dimensionProperties = DimensionPropertiesString.Split(new String[] { propertiesSeparator }, StringSplitOptions.RemoveEmptyEntries);
			}
			else {
				dimensionProperties = new String[0];
			}
			SetDimensionProperties(dimensionProperties);
		}

		partial void OnCriteriaChanged() {
			OnAnalysisInfoChanged(AnalysisInfoChangeType.CriteriaChanged);
		}
		partial void OnObjectTypeNameChanged() {
			SetDimensionProperties(DimensionPropertyExtractor.Instance.GetDimensionProperties(DataType));
			OnAnalysisInfoChanged(AnalysisInfoChangeType.ObjectTypeChanged);
		}

		public Analysis() {
			dimensionProperties = new DimensionPropertiesList();
			initializeIndicator = new InitializeIndicator();
		}

		[ImmediatePostData, TypeConverter(typeof(LocalizedClassInfoTypeConverter))]
		public Type DataType {
			get {
				if(ObjectTypeName != null) {
					return ReflectionHelper.GetType(ObjectTypeName);
				}
				return null;
			}
			set {
				String stringValue = (value == null) ? null : value.FullName;
				String savedObjectTypeName = ObjectTypeName;
				try {
					if(stringValue != ObjectTypeName) {
						ObjectTypeName = stringValue;
					}
				}
				catch(Exception) {
					ObjectTypeName = savedObjectTypeName;
				}
				if(!IsInitializing) {
					Criteria = null;
				}
			}
		}
		[Browsable(false)]
		public IList<String> DimensionProperties {
			get { return dimensionProperties; }
		}
		[VisibleInListView(false)]
		public IAnalysisInfo Self {
			get { return this; }
		}
		[Browsable(false)]
		public Type ObjectType {
			get { return DataType; }
		}
		public event EventHandler<AnalysisInfoChangedEventEventArgs> InfoChanged;

		// ISupportInitialize
		public void BeginInit() {
			initializeIndicator.BeginInit();
		}
		public void EndInit() {
			initializeIndicator.EndInit();
			UpdateDimensionProperties();
		}

		// IXafEntityObject
		void IXafEntityObject.OnCreated() {
		}
		void IXafEntityObject.OnSaving() {
		}
		void IXafEntityObject.OnLoaded() {
			UpdateDimensionProperties();
		}
	}

	public class AnalysisMetadata {
		[Browsable(false)]
		public Int32 ID { get; set; }

		[CriteriaOptions("DataType")]
		[EditorAlias(EditorAliases.PopupCriteriaPropertyEditor)]
		[FieldSize(FieldSizeAttribute.Unlimited)]
		[VisibleInListView(true)]
		[ModelDefault("RowCount", "0")]
		public String Criteria { get; set; }

		[Browsable(false)]
		public String ObjectTypeName { get; set; }

		[Browsable(false)]
		[FieldSize(FieldSizeAttribute.Unlimited)]
		public String DimensionPropertiesString { get; set; }

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		public Byte[] ChartSettingsContent { get; set; }

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		public Byte[] PivotGridSettingsContent { get; set; }
        
	}
}

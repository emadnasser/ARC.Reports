using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraPivotGrid.Data;

namespace DevExpress.XtraPivotGrid.Demos.Helpers {
    public static class OLAPConfigurator {
        public const string QuantityFieldName = "[Measures].[Quantity]";
        public const string CategoriesFieldName = "[Categories].[Category Name].[Category Name]";
        public const string ProductsFieldName = "[Products].[Products].[Products]";
        public const string DiscountFieldName = "[Measures].[Discount]";
        public const string CountryFieldName = "[Customers].[Country].[Country]";

        public static bool CreateSampleOLAPConfiguration(PivotGridControl pivot) {
            try {
                pivot.OLAPConnectionString = OLAPConnectionDesigner.SampleConnectionString;
            } catch(OLAPConnectionException) {
                pivot.OLAPConnectionString = null;
                pivot.Enabled = false;
                return false;
            }
            ConfigureSampleFields(pivot);
            return true;
        }
        public static bool CreateSampleAdoConfiguration(PivotGridControl pivot) {
            if(!AdomdMetaGetter.IsProviderAvailable)
                return false;
            try {
                PivotGridAdomdDataSource ds = new PivotGridAdomdDataSource();
                ds.ConnectionString = OLAPConnectionDesigner.SampleConnectionString;
                pivot.DataSource = ds;
            } catch(OLAPConnectionException) {
                pivot.DataSource = null;
                pivot.Enabled = false;
                return false;
            }
            ConfigureSampleFields(pivot);
            return true;
        }
        static void ConfigureSampleFields(PivotGridControl pivot) {
            RetrieveFields(pivot);
            PivotGridField fieldQuantity = pivot.Fields[QuantityFieldName],
                fieldCategories = pivot.Fields[CategoriesFieldName],
                fieldProducts = pivot.Fields[ProductsFieldName];
            if(fieldQuantity != null) {
                fieldQuantity.Visible = true;
                fieldQuantity.Area = PivotArea.DataArea;
            }
            if(fieldCategories != null) {
                fieldCategories.Visible = true;
                fieldCategories.Area = PivotArea.RowArea;
            }
            if(fieldProducts != null) {
                fieldProducts.Visible = true;
                fieldProducts.Area = PivotArea.RowArea;
            }
        }
        public static void RetrieveFields(PivotGridControl pivot) {
            pivot.BeginUpdate();
            pivot.RetrieveFields(PivotArea.FilterArea, false);
            for(int i = 0; i < pivot.Fields.Count; i++) {
                pivot.Fields[i].SortMode = PivotSortMode.None;
            }
            pivot.EndUpdate();
        }
    }
}

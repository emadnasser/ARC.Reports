using System;
using System.Data;
using System.Reflection;
using DashboardMainDemo;

namespace DashboardMainDemo {

    public abstract class DataSchemaDataSet : DataSet {
        public DataSchemaDataSet(Type type) {
            DataTable table = new DataTable(type.Name);
            foreach(PropertyInfo info in type.GetProperties())
                table.Columns.Add(new DataColumn(info.Name, info.PropertyType));
            Tables.Add(table);
        }
    }

    public class SalesPerformanceDataGeneratorKeyMetricsItem : DataSchemaDataSet {
        public SalesPerformanceDataGeneratorKeyMetricsItem() : base(typeof(SalesPerformanceDataGenerator.KeyMetricsItem)) { }
    }

    public class SalesPerformanceDataGeneratorMonthlySalesItem : DataSchemaDataSet {
        public SalesPerformanceDataGeneratorMonthlySalesItem() : base(typeof(SalesPerformanceDataGenerator.MonthlySalesItem)) { }
    }

    public class SalesPerformanceDataGeneratorTotalSalesItem : DataSchemaDataSet {
        public SalesPerformanceDataGeneratorTotalSalesItem() : base(typeof(SalesPerformanceDataGenerator.TotalSalesItem)) { }
    }

    public class SalesOverviewDataGeneratorDataItem : DataSchemaDataSet {
        public SalesOverviewDataGeneratorDataItem() : base(typeof(SalesOverviewDataGenerator.DataItem)) { }
    }

    public class SalesDetailsDataGeneratorDataItem : DataSchemaDataSet {
        public SalesDetailsDataGeneratorDataItem() : base(typeof(SalesDetailsDataGenerator.DataItem)) { }
    }

    public class RevenueAnalysisDataGeneratorDataItem : DataSchemaDataSet {
        public RevenueAnalysisDataGeneratorDataItem() : base(typeof(RevenueAnalysisDataGenerator.DataItem)) { }
    }

    public class DepartmentDataSet : DataSchemaDataSet {
        public DepartmentDataSet() : base(typeof(DepartmentData)) { }
    }

    public class EmployeeDataSet : DataSchemaDataSet {
        public EmployeeDataSet() : base(typeof(EmployeeData)) { }
    }

    public class CustomerSupportDataSet : DataSchemaDataSet {
        public CustomerSupportDataSet() : base(typeof(CustomerSupportData.CustomerSupportItem)) { }
    }
}

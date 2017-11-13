using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess;
using DevExpress.DashboardCommon;

namespace DashboardMainDemo.Dashboards {
    public partial class HumanResources : Dashboard {
        public HumanResources() {
            InitializeComponent();
        }
        void HumanResources_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
            HumanResourcesData data = new HumanResourcesData(DataLoader.LoadEmployees());
            if(e.DataSource == dsEmployees)
                e.Data = data.EmployeeData;
            else if(e.DataSource == dsDepartments)
                e.Data = data.DepartmentData;
        }
    }
}

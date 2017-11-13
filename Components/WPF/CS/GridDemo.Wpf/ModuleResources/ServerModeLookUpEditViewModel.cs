using DevExpress.DemoData.Models;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Core.DataSources;
using DevExpress.Xpf.Core.ServerMode;
using System.Collections.Generic;
using System.Linq;

namespace GridDemo {
    [POCOViewModel]
    public class ServerModeLookUpEditViewModel {
        public virtual List<OrderData> Orders { get; set; }
        public virtual ListSourceDataSourceBase DataSource { get; set; }
        public virtual bool IsInstantfeedback { get; set; }

        protected ServerModeLookUpEditViewModel() {
            Orders = new OrderDataGenerator(200).GetOrders();
        }

        public void OnLoaded() {
            if(!ServerModeRecordsGeneratorProviderBase.IsDatabaseExists(ServerModeOptions.SQLConnectionString, ServerModeOptions.PersonTableName))
                ShowConnectionWizard("Start Demo");
            UpdateDataSource();
        }
        public void Configure() {
            ShowConnectionWizard("Return");
            UpdateDataSource();
        }
        void ShowConnectionWizard(string demoString) {
            if(DevExpress.Xpf.DemoBase.DemoTesting.DemoTestingHelper.IsTesting)
                return;
            SQLConnectionWindow window = new SQLConnectionWindow(demoString, new PeopleGeneratorProvider()) { Description = ServerModeOptions.GetLookUpDescription() };
            if(System.Windows.Application.Current != null)
                window.Owner = System.Windows.Application.Current.MainWindow;
            window.ShowDialog();
            ServerModeOptions.SQLConnectionString = window.GetDataBaseConnectionString();
        }

        void UpdateDataSource() {
            int count = new PeopleGeneratorProvider().CalcRecordCount(ServerModeOptions.SQLConnectionString);
            if(count > 0 && Orders != null && count < Orders.Count)
                Orders = new OrderDataGenerator(count).GetOrders();
            Dispose();
            IQueryable queryable = ServerModeOptions.IsCorrectConnection ? new Controls.PersonDataContext(ServerModeOptions.SQLConnectionString).Person : null;
            ListSourceDataSourceBase dataSource;
            if(IsInstantfeedback)
                dataSource = new LinqInstantFeedbackDataSource() { KeyExpression = "PersonID", QueryableSource = queryable };
            else
                dataSource = new LinqServerModeDataSource() { KeyExpression = "PersonID", QueryableSource = queryable };
            DataSource = dataSource;
        }
        protected virtual void OnIsInstantfeedbackChanged() {
            UpdateDataSource();
        }

        public void Dispose() {
            if(DataSource is LinqInstantFeedbackDataSource)
                ((LinqInstantFeedbackDataSource)DataSource).Dispose();
        }
    }
}

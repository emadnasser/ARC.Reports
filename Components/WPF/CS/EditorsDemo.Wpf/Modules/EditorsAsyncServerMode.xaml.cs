using System;
using System.ComponentModel;
using System.Windows;
using DevExpress.Xpf.DemoBase;
using EditorsDemo.ViewModels;
using GridDemo;
using GridDemo.Controls;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System.Collections.Generic;
using DevExpress.Xpf.Core.ServerMode;

namespace EditorsDemo {
    [CodeFile("ModuleResources/LookUpEditTemplates(.SL).xaml")]
    public partial class EditorsAsyncServerMode : EditorsDemoModule {
        public EditorsAsyncServerMode() {
            InitializeComponent();
        }
        protected override object GetModuleDataContext() {
            return DataContext;
        }
    }
    [POCOViewModel]
    public class EditorsAsyncServerModeViewModel {
        public virtual LinqInstantFeedbackDataSource LinqSource { get; set; }
        public virtual object EditValue { get; set; }

        public void OnLoaded() {
            if (string.IsNullOrEmpty(ServerModeOptions.SQLConnectionString))
                ShowConnectionWizard("Return");
            UpdatePeopleSource();
        }
        public void Configure() {
            ShowConnectionWizard("Start Demo");
            UpdatePeopleSource();
        }
        void ShowConnectionWizard(string demoString) {
            if (DevExpress.Xpf.DemoBase.DemoTesting.DemoTestingHelper.IsTesting)
                return;
            SQLConnectionWindow window = new SQLConnectionWindow("Return", new PeopleGeneratorProvider()) { Description = ServerModeOptions.GetComboBoxDescription() };
            if (System.Windows.Application.Current != null)
                window.Owner = System.Windows.Application.Current.MainWindow;
            var result = window.ShowDialog();
            if (result != null)
            ServerModeOptions.SQLConnectionString = window.GetDataBaseConnectionString();
        }
        void UpdatePeopleSource() {
            var linqSource = new LinqInstantFeedbackDataSource();
            linqSource.GetQueryable += (sender, args) => {
                args.KeyExpression = "PersonID";
                args.QueryableSource = ServerModeOptions.IsCorrectConnection ? new PersonDataContext(ServerModeOptions.SQLConnectionString).Person : null;
                args.Handled = true;
            };
            LinqSource = linqSource;
        }
    }
}

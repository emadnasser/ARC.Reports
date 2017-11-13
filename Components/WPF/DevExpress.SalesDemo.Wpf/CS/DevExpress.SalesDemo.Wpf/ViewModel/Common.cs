using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.SalesDemo.Model;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DevExpress.SalesDemo.Wpf.ViewModel {
    public enum ModuleType { Dashboard, Products, Sectors, Regions, Channels }
    public static class Regions {
        public static string Main { get { return "MainRegion"; } }
        public static string Navigation { get { return "NavigationRegion"; } }
    }
    public abstract class DataViewModel {
        protected DataViewModel() {
            if(this.IsInDesignMode())
                DataProvider = new SampleDataProvider();
            else DataProvider = DataSource.GetDataProvider();
        }
        public void RequestData<T>(string actionId, Func<IDataProvider, T> requestDataFunction, Action<T> callback) {
            if(this.IsInDesignMode()) {
                callback(requestDataFunction(DataProvider));
                return;
            }
            if(!tasks.ContainsKey(actionId)) {
                tasks.Add(actionId, new CancellationTokenSource());
                var task = new Task<T>(() => requestDataFunction(DataProvider), tasks[actionId].Token, TaskCreationOptions.LongRunning);
                task.ContinueWith(x => callback(x.Result), tasks[actionId].Token);
                task.Start();
                return;
            }
            if(tasks.ContainsKey(actionId)) {
                tasks[actionId].Cancel();
                tasks.Remove(actionId);
                RequestData(actionId, requestDataFunction, callback);
                return;
            }
        }
        IDataProvider DataProvider;
        Dictionary<string, CancellationTokenSource> tasks = new Dictionary<string,CancellationTokenSource>();
    }
    public abstract class PageViewModel {
        protected PageViewModel() {
            ViewInjectionManager.Default.RegisterNavigatedEventHandler(this, OnNavigated);
            if(this.IsInDesignMode())
                Initialize();
        }
        protected abstract void Initialize();
        void OnNavigated() {
            if(isInitialize) return;
            Initialize();
            isInitialize = true;
        }
        bool isInitialize = false;
    }
}

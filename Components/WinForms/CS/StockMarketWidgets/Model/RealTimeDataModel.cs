using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using StockMarketWidgets.StockDataServiceReference;
namespace StockMarketWidgets {
    public class PriceAscedingComparer : IComparer<TransactionData> {
        public int Compare(TransactionData x, TransactionData y) {
            if(x == null || y == null)
                return 0;
            if(x.Price == y.Price) {
                if(y.Bid == 0 && x.Ask == 0)
                    return -1;
                else return 1;
            }
            if(x.Price < y.Price)
                return -1;
            else
                return 1;
        }
    }
    public class PriceDescedingComparer : IComparer<TransactionData> {
        public int Compare(TransactionData x, TransactionData y) {
            if(x == null || y == null)
                return 0;
            if(x.Price == y.Price) {
                if(y.Ask == 0 && x.Bid == 0)
                    return -1;
                else return 1;
            }
            if(x.Price < y.Price)
                return 1;
            else
                return -1;
        }
    }
    public class RealTimeDataEventArgs : EventArgs {
        public RealTimeDataEventArgs(object data, string key, bool canNewUpdate) {
            this.Data = data;
            this.Key = key;
            this.CanNewUpdate = canNewUpdate;
        }
        public RealTimeDataEventArgs(string message) {
            this.ExceptionMessage = message;
        }
        public bool CanNewUpdate { get; set; }
        public string Key { get; set; }
        public string ExceptionMessage { get; set; }
        public object Data { get; set; }
    }
    public class RealTimeDataModel {
        Executor executor;
        NetworkMonitor networkMonitor;
        StockDataServiceClient server;
        Random rand;
        List<TransactionData> transactions;
        IComparer<TransactionData> comparer;
        int currentPriceIndex;

        public RealTimeDataModel() {
            this.networkMonitor = new NetworkMonitor();
            this.networkMonitor.IsAvailableChanged += new EventHandler(OnNetworkIsAvailableChanged);
            this.executor = new Executor();
            this.executor.ExecuteFailed += new EventHandler(OnExecuteFailed);
            this.transactions = new List<TransactionData>();
            this.comparer = new PriceAscedingComparer();
            rand = new Random();
            InitServer();
        }

        public event EventHandler<RealTimeDataEventArgs> GetDataCompleted;
        public event EventHandler<RealTimeDataEventArgs> UpdateFailed;

        public string NetworkState {
            get { return networkMonitor.IsAvailable ? "Connected" : "Disconnected"; }
        }
        public string TransactionsSortType {
            set {
                if(value == "Asceding")
                    comparer = new PriceAscedingComparer();
                else
                    comparer = new PriceDescedingComparer();
                transactions.Sort(comparer);
            }
        }
        public int CurrentPriceIndex { get { return currentPriceIndex; } set { currentPriceIndex = value; } }
        public void ChangeUserState() {
            executor.ChangeUserID();
        }
        public void BeginGetDates() {
            Func<AsyncCallback, object, IAsyncResult> method = new Func<AsyncCallback, object, IAsyncResult>(server.BeginGetDates);
            object[] args = new object[] { new AsyncCallback(executor.EndExecute), GetUserState(new AsyncCallback(EndGetDates)) };
            ExecutorAction action = new ExecutorAction(method, ActionPriority.Blocked, args);
            executor.AddAction(action);
        }
        public void BeginGetCompanies() {
            Func<AsyncCallback, object, IAsyncResult> method = new Func<AsyncCallback, object, IAsyncResult>(server.BeginGetCompaniesName);
            object[] args = new object[] { new AsyncCallback(executor.EndExecute), GetUserState(new AsyncCallback(EndGetCompanies)) };
            ExecutorAction action = new ExecutorAction(method, ActionPriority.Normal, args);
            executor.AddAction(action);
        }
        public void BeginGetStockDataByDate(DateTime date) {
            Func<DateTime, AsyncCallback, object, IAsyncResult> method = new Func<DateTime, AsyncCallback, object, IAsyncResult>(server.BeginGetStockDataByDate);
            object[] args = new object[] { date, new AsyncCallback(executor.EndExecute), GetUserState(new AsyncCallback(EndGetStockDataByDate)) };
            ExecutorAction action = new ExecutorAction(method, ActionPriority.Normal, args);
            executor.AddAction(action);
        }
        public void BeginGetCompanyMultipleDataFromPeriod(int currentDate, int count, int periodSize, string companyName) {
            Func<int, int, int, string, AsyncCallback, object, IAsyncResult> method =
                new Func<int, int, int, string, AsyncCallback, object, IAsyncResult>(server.BeginGetCompanyMultipleDataFromPeriod);
            object[] args =
                new object[] { currentDate, count, periodSize, companyName, new AsyncCallback(executor.EndExecute), GetUserState(new AsyncCallback(EndGetCompanyMultipleDataFromPeriod)) };
            ExecutorAction action = new ExecutorAction(method, ActionPriority.Normal, args);
            executor.AddAction(action);
        }
        public void BeginGetCompaniesVolumeFromPeriod(DateTime start, DateTime end) {
            Func<DateTime, DateTime, AsyncCallback, object, IAsyncResult> method =
                new Func<DateTime, DateTime, AsyncCallback, object, IAsyncResult>(server.BeginGetCompaniesVolumeFromPeriod);
            object[] args = new object[] { start, end, new AsyncCallback(executor.EndExecute), GetUserState(new AsyncCallback(EndGetCompaniesVolumeFromPeriod)) };
            ExecutorAction action = new ExecutorAction(method, ActionPriority.Normal, args);
            executor.AddAction(action);
        }
        public void BeginGetCompanyStockData(DateTime date, string companyName) {
            Func<DateTime, string, AsyncCallback, object, IAsyncResult> method =
                 new Func<DateTime, string, AsyncCallback, object, IAsyncResult>(server.BeginGetCompanyStockData);
            object[] args = new object[] { date, companyName, new AsyncCallback(executor.EndExecute), GetUserState(new AsyncCallback(EndGetCompanyStockData)) };
            ExecutorAction action = new ExecutorAction(method, ActionPriority.Normal, args);
            executor.AddAction(action);
        }
        public List<TransactionData> GetTransactions(double currentPrice) {
            int maxTransactionCount = 3;
            int numOfTransactions = 1 + rand.Next(maxTransactionCount);
            for(int i = 0; i < numOfTransactions; i++) {
                AddNewTransaction(currentPrice, "Bid");
                AddNewTransaction(currentPrice, "Ask");
            }
            currentPriceIndex = FindNewCurrentPriceIndex();
            CorrectTransactionData();
            CorrectOnOneTransactionTypeExists();
            return transactions;
        }
        public void ClearTransactions() {
            transactions.Clear();
        }

        private void EndGetCompanyStockData(IAsyncResult result) {
            StockData[] data = server.EndGetCompanyStockData(result);
            RaiseGetDataCompleted(data, "GetCompanyStockData");
        }
        private void EndGetCompaniesVolumeFromPeriod(IAsyncResult result) {
            CompaniesVolumeData[] data = server.EndGetCompaniesVolumeFromPeriod(result);
            RaiseGetDataCompleted(data, "GetCompaniesVolumeFromPeriod");
        }
        private void EndGetCompanyMultipleDataFromPeriod(IAsyncResult result) {
            CompanyData[] data = server.EndGetCompanyMultipleDataFromPeriod(result);
            RaiseGetDataCompleted(data, "GetCompanyMultipleDataFromPeriod");
        }
        private void EndGetStockDataByDate(IAsyncResult result) {
            StockData[] data = server.EndGetStockDataByDate(result);
            RaiseGetDataCompleted(data, "GetStockDataByDate");
        }
        private void EndGetDates(IAsyncResult result) {
            DateTime[] dates = server.EndGetDates(result);
            RaiseGetDataCompleted(dates, "GetDates");
        }
        private void EndGetCompanies(IAsyncResult result) {
            string[] companies = server.EndGetCompaniesName(result);
            RaiseGetDataCompleted(companies, "GetCompanies");
        }
        private UserStateParams GetUserState(Delegate callback) {
            return new UserStateParams(callback, executor.UserID);
        }
        private void RaiseGetDataCompleted(object data, string key) {
            bool canNewUpdate = executor.ExecutingActions == 0 ? true : false;
            this.GetDataCompleted(this, new RealTimeDataEventArgs(data, key, canNewUpdate));
        }
        private void OnNetworkIsAvailableChanged(object sender, EventArgs e) {
            executor.Status = networkMonitor.IsAvailable == true ? ExecutorStatus.Enabled : ExecutorStatus.Disabled;
            if(networkMonitor.IsAvailable == false)
                RaiseUpdateFailed("The remote server is not responding. Check your internet connection.");
        }
        private void RaiseUpdateFailed(string message) {
            this.UpdateFailed(this, new RealTimeDataEventArgs(message));
        }
        private void OnExecuteFailed(object sender, EventArgs e) {
            RaiseUpdateFailed("The remote server is not responding. Check your internet connection.");
        }
        private void InitServer() {
            try {
                this.server = CreateStockDataServiceClient();
                server.InitializeCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(OnServerInitializeCompleted);
                server.InitializeAsync();
            }
            catch {
                RaiseUpdateFailed("The remote server is not responding. Check your internet connection.");
            }
        }
        StockDataServiceClient CreateStockDataServiceClient() {
            return new StockDataServiceClient();
        }

        void OnServerInitializeCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
            executor.ForceExecute();
        }
        private void CorrectTransactionData() {
            if(transactions.Count > 30) {
                int transactionsCount = 0;
                if(currentPriceIndex > 0)
                    transactionsCount = transactions.Count - currentPriceIndex;
                bool isDominating = transactionsCount > (transactions.Count - transactionsCount) ? true : false;
                for(int i = 0; i < 4; i++) {
                    currentPriceIndex--;
                    if(isDominating)
                        transactions.RemoveAt(0);
                    else
                        transactions.RemoveAt(transactions.Count - 1);
                }
            }
        }
        private void CorrectOnOneTransactionTypeExists() {
            if(currentPriceIndex == -1 && transactions.Count != 0) {
                int lastIndex = transactions.Count - 1;
                string transantionType = transactions[0].Bid == 0 ? "Bid" : "Ask";
                int volume = transactions[lastIndex].Volume + 5;
                double price;
                if(comparer.GetType() == typeof(PriceAscedingComparer))
                    price = IsDownMoving(transantionType) ? transactions[lastIndex].Price + 0.5 : transactions[0].Price - 0.5;
                else
                    price = IsDownMoving(transantionType) ? transactions[lastIndex].Price - 0.5 : transactions[0].Price + 0.5;
                TransactionData tdvm = new TransactionData(transantionType, volume, price);
                transactions.Add(tdvm);
                currentPriceIndex = transactions.IndexOf(tdvm);
            }
        }
        private double GetNewTransactionPrice(double currentPrice) {
            double factor = currentPrice * 0.1 * rand.NextDouble();
            factor = rand.NextDouble() > 0.5 ? factor : -factor;
            double price = currentPrice + factor;
            return Math.Round(price, 2);
        }
        private void CheckTransactions(int currentIndex, double price, string trantctionType) {
            bool isDownMoving = IsDownMoving(trantctionType);
            int index = isDownMoving ? 1 : -1;
            int i = currentIndex + index;
            while((i < transactions.Count && i > -1) && transactions[i].TransactionType != transactions[currentIndex].TransactionType) {
                int delta = transactions[currentIndex].Volume - transactions[i].Volume;
                if(delta == 0) {
                    if(isDownMoving) {
                        transactions.Remove(transactions[i]);
                        transactions.Remove(transactions[currentIndex]);
                    }
                    else {
                        transactions.Remove(transactions[currentIndex]);
                        transactions.Remove(transactions[i]);
                    }
                    break;
                }
                if(delta < 0) {
                    transactions[i].Volume = -delta;
                    transactions.Remove(transactions[currentIndex]);
                    break;
                }
                else {
                    transactions[currentIndex].Volume = delta;
                    transactions.Remove(transactions[i]);
                    if(!isDownMoving) { currentIndex--; i--; }
                }
            }
        }
        private bool IsDownMoving(string trantctionType) {
            Type type = comparer.GetType();
            if((type == typeof(PriceAscedingComparer) && trantctionType == "Bid") || (type == typeof(PriceDescedingComparer) && trantctionType == "Ask"))
                return true;
            else
                return false;
        }
        private void AddNewTransaction(double currentPrice, string transactionType) {
            int maxVolumeValue = 100;
            double price = GetNewTransactionPrice(currentPrice);
            int volume = 1 + rand.Next(maxVolumeValue);
            TransactionData currentTransaction = new TransactionData(transactionType, volume, price);
            transactions.Add(currentTransaction);
            transactions.Sort(comparer);
            CheckTransactions(transactions.IndexOf(currentTransaction), price, transactionType);
        }
        private int FindNewCurrentPriceIndex() {
            for(int i = 0; i < transactions.Count; i++) {
                if(i < transactions.Count - 1 && transactions[i].TransactionType != transactions[i + 1].TransactionType)
                    return i;
            }
            return -1;
        }
    }
    public class NetworkMonitor {
        bool isAvailable;

        public event EventHandler IsAvailableChanged;
        public NetworkMonitor() {
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);
            CheckConnection();
        }

        public bool IsAvailable {
            get { return isAvailable; }
            private set {
                isAvailable = value;
                RaiseIsAvailableChanged();
            }
        }

        private void OnPingCompleted(object sender, PingCompletedEventArgs e) {
            IsAvailable = e.Reply == null || e.Reply.Status != IPStatus.Success ? false : true;
        }

        private void RaiseIsAvailableChanged() {
            this.IsAvailableChanged(this, EventArgs.Empty);
        }
        private void CheckConnection() {
            Ping ping = new Ping();
            ping.SendAsync("www.devexpress.com", null);
            ping.PingCompleted += new PingCompletedEventHandler(OnPingCompleted);

        }
        private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e) {
            IsAvailable = e.IsAvailable;
        }
    }


    public enum ActionPriority { Normal, High, Blocked }
    public enum ExecutorStatus { Enabled, Disabled }

    public class UserStateParams {
        public UserStateParams(Delegate callback, int actionID) {
            if(callback != null)
                this.Callback = callback;
            this.ActionID = actionID;
        }

        public Delegate Callback { get; private set; }
        public int ActionID { get; set; }
    }
    public class ExecutorAction {
        Delegate method;
        ActionPriority priority;
        object[] args;

        public ExecutorAction(Delegate method, ActionPriority priority, object[] args) {
            this.method = method;
            this.priority = priority;
            this.args = args;
        }

        public object[] Args { get { return args; } }
        public Delegate Method { get { return method; } }
        public ActionPriority Priority { get { return priority; } }

    }
    public class Executor {
        Stack<ExecutorAction> actions;
        ExecutorAction currentAction;
        ExecutorStatus status = ExecutorStatus.Disabled;
        int userID = 0, executingActions = 0;

        public Executor() {
            actions = new Stack<ExecutorAction>();
        }

        public event EventHandler ExecuteFailed;
        public ExecutorStatus Status {
            get { return status; }
            set {
                status = value;
                if(value == ExecutorStatus.Enabled)
                    TryExecute(false);
                if(value == ExecutorStatus.Disabled && currentAction != null)
                    actions.Push(currentAction);
            }
        }
        public int UserID { get { return userID; } }
        public int ExecutingActions { get { return executingActions; } }

        public void AddAction(ExecutorAction action) {
            if(CanAdd(action.Priority)) {
                actions.Push(action);
            }
            TryExecute(false);
        }
        public void ExecuteCompleted() {
            TryExecute(false);
        }
        public void ChangeUserID() {
            actions.Clear();
            userID++;
        }
        public void ForceExecute() {
            TryExecute(true);
        }
        public void EndExecute(IAsyncResult result) {
            try {
                executingActions--;
                UserStateParams state = result.AsyncState as UserStateParams;
                if(state.ActionID == userID && state.Callback != null && status != ExecutorStatus.Disabled) {
                    state.Callback.DynamicInvoke(new object[] { result });
                }
            }
            catch {
                RaiseExecuteFailed();
            }
        }
        private void RaiseExecuteFailed() {
            this.ExecuteFailed(this, EventArgs.Empty);
        }
        private bool CanAdd(ActionPriority priority) {
            return true;
        }
        private void TryExecute(bool isForceExecute) {
            if(actions.Count != 0 && (status != ExecutorStatus.Disabled && (actions.Peek().Priority != ActionPriority.Blocked || isForceExecute))) {
                currentAction = actions.Pop();
                BeginExecute(currentAction);
            }
        }
        private void BeginExecute(ExecutorAction action) {
            try {
                executingActions++;
                action.Method.DynamicInvoke(action.Args);
            }
            catch { RaiseExecuteFailed(); }
        }
        private void Completed(object sender, EventArgs e) {
            ExecuteCompleted();
        }
    }
}

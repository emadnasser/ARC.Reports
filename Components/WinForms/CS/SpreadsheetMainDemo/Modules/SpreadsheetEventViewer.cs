using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.Model;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class SpreadsheetEventViewerModule : SpreadSheetTutorialControlBase {
        #region Fields
        const string documentName = "UnitConverter_template.xlsx";
        const string customDrawRowText = "5";
        const string customDrawColumnText = "D";

        List<SpreadsheetEventHooker> hooks;
        List<string> customDrawCellEventsList;
        List<string> customDrawHeaderEventsList;
        CellPosition customDrawCellPosition = new CellPosition(2, 3); // C4
        #endregion

        public SpreadsheetEventViewerModule() {
            hooks = new List<SpreadsheetEventHooker>();
            customDrawCellEventsList = CreateCustomDrawCellEventsList();
            customDrawHeaderEventsList = CreateCustomDrawHeaderEventsList();
            InitializeComponent();
            this.spreadsheetControl1.Options.Culture = DefaultCulture;
            PrepareBookContent();
            EnumerateEvents();
            checkAllEdit.CheckState = CheckState.Checked;
            customDrawCellBarEdit.EditValue = customDrawCellPosition.ToString();
        }

        #region static helper functions
        static List<string> CreateCustomDrawCellEventsList() {
            List<string> result = new List<string>();
            result.Add("CustomDrawCell");
            result.Add("CustomDrawCellBackground");
            return result;
        }
        static List<string> CreateCustomDrawHeaderEventsList() {
            List<string> result = new List<string>();
            result.Add("CustomDrawColumnHeader");
            result.Add("CustomDrawColumnHeaderBackground");
            result.Add("CustomDrawRowHeader");
            result.Add("CustomDrawRowHeaderBackground");
            return result;
        }

        static int SortHooksByName(SpreadsheetEventHooker arg1, SpreadsheetEventHooker arg2) {
            return arg1.Name.CompareTo(arg2.Name);
        }
        #endregion

        void EnumerateEvents() {
            Type controlType = spreadsheetControl1.GetType();
            EventInfo[] events = controlType.GetEvents(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
            foreach (EventInfo item in events) {
                string eventName = item.Name;
                if (customDrawCellEventsList.Contains(eventName))
                    hooks.Add(new SpreadsheetCustomDrawCellEventHooker(eventName, this));
                else if (customDrawHeaderEventsList.Contains(eventName))
                    hooks.Add(new SpreadsheetCustomDrawHeaderEventHooker(eventName, this));
                else
                    hooks.Add(new SpreadsheetEventHooker(eventName, this));
            }
            hooks.Sort(SortHooksByName);
            for (int i = 0; i < hooks.Count; ++i) {
                string eventName = hooks[i].Name;
                eventsCheckedListBox.Items.Add(i, eventName); //, CheckState.Checked, true);
                //hooks[i].HookEvent(spreadsheetControl1);
            }
        }

        void PrepareBookContent() {
            IWorkbook book = spreadsheetControl1.Document;
            spreadsheetControl1.BeginUpdate();
            try {
                book.LoadDocument(DemoUtils.GetRelativePath(documentName));
            }
            finally {
                spreadsheetControl1.EndUpdate();
            }
        }

        string GetEventParameter(PropertyInfo item, object value) {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(item.Name);
            if (item.PropertyType == typeof(string)) {
                strBuilder.Append("=\'");
                strBuilder.Append(value);
                strBuilder.Append('\'');
            }
            else {
                strBuilder.Append('=');
                strBuilder.Append(value);
            }
            return strBuilder.ToString();
        }

        public void CustomDrawCellEventLogger(string eventName, object sender, CustomDrawCellEventArgsBase args) {
            if (customDrawCellPosition.IsValid &&
               (args.Cell.RowIndex == customDrawCellPosition.Row) &&
               (args.Cell.ColumnIndex == customDrawCellPosition.Column)) {
                EventLogger(eventName, sender, args);
            }
        }
        public void CustomDrawHeaderEventLogger(string eventName, object sender, CustomDrawHeaderEventArgsBase args) {
            string headerText = args.Text;
            if (headerText == customDrawColumnText || headerText == customDrawRowText)
                EventLogger(eventName, sender, args);
        }

        public void EventLogger(string eventName, object sender, EventArgs args) {
            Type argsType = args.GetType();
            string name = eventName;
            string argsTypeName = argsType.Name;
            PropertyInfo[] propInfoArray = argsType.GetProperties();
            TreeListNode rootListNode = null;
            TreeListNode firstLevelNode = loggerControl.AppendNode(new object[] { name, argsTypeName }, rootListNode);
            foreach (PropertyInfo item in propInfoArray) {
                string value = GetEventParameter(item, item.GetValue(args, null));
                TreeListNode secondLevelNode = loggerControl.AppendNode(new object[] { "", "", value }, firstLevelNode);
            }
            if (appendExpandedBox.Checked && (propInfoArray.Length > 0))
                firstLevelNode.ExpandAll();
            loggerControl.MakeNodeVisible(firstLevelNode);
        }

        void eventsCheckedListBox_ItemCheck(object sender, XtraEditors.Controls.ItemCheckEventArgs e) {
            int itemIndex = e.Index;
            bool state = e.State == CheckState.Checked;
            int hookIndex = Convert.ToInt32(eventsCheckedListBox.Items[itemIndex].Value);
            if (state)
                hooks[hookIndex].HookEvent(spreadsheetControl1);
            else
                hooks[hookIndex].UnhookEvent(spreadsheetControl1);
        }

        void checkAllEdit_CheckStateChanged(object sender, EventArgs e) {
            CheckState state = checkAllEdit.CheckState;
            switch (state) {
                case CheckState.Checked:
                    eventsCheckedListBox.CheckAll();
                    break;
                case CheckState.Unchecked:
                    eventsCheckedListBox.UnCheckAll();
                    break;
            }
        }

        void expandButtonItem_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            loggerControl.ExpandAll();
        }

        void collapseButtonItem_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            loggerControl.CollapseAll();
        }

        void clearButtonItem_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            loggerControl.ClearNodes();
        }

        void customDrawCellBarEdit_EditValueChanged(object sender, EventArgs e) {
            string newValue = customDrawCellBarEdit.EditValue.ToString();
            if (String.IsNullOrEmpty(newValue))
                customDrawCellPosition = CellPosition.InvalidValue;
            else {
                CellPosition newPosition = CellPosition.TryCreate(newValue);
                if (newPosition.IsValid)
                    customDrawCellPosition = newPosition;
            }
        }
    }

    #region SpreadsheetEventHooker
    public class SpreadsheetEventHooker {
        #region Fields
        string eventName;
        SpreadsheetEventViewerModule owner;
        Delegate handler;
        #endregion

        public SpreadsheetEventHooker(string eventName, SpreadsheetEventViewerModule owner) {
            this.eventName = eventName;
            this.owner = owner;
        }

        #region Properties
        public string Name { get { return eventName; } }
        protected virtual string MethodName { get { return "EventLogger"; } }
        #endregion

        #region CreateEventProxy
        Delegate CreateEventProxy(EventInfo eInfo) {
            Type eventHandlerType = eInfo.EventHandlerType;
            MethodInfo mInfo = eventHandlerType.GetMethod("Invoke");
            MethodInfo loggerMethodInfo = typeof(SpreadsheetEventViewerModule).GetMethod(MethodName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            ParameterInfo[] pInfo = mInfo.GetParameters();
            ParameterExpression eventSender = Expression.Parameter(typeof(object), "sender");
            ParameterExpression eventArgs = Expression.Parameter(pInfo[1].ParameterType, "args");
            return Expression.Lambda(eventHandlerType, Expression.Call(Expression.Constant(owner), loggerMethodInfo, Expression.Constant(eventName), eventSender, eventArgs), eventSender, eventArgs).Compile();
        }
        #endregion

        public bool HookEvent(SpreadsheetControl control) {
            Type controlType = typeof(SpreadsheetControl);
            EventInfo eInfo = controlType.GetEvent(eventName);

            if (handler == null)
                handler = CreateEventProxy(eInfo);

            try {
                eInfo.AddEventHandler(control, handler);
            }
            catch (ArgumentException e) {
                MessageBox.Show(e.Message, "Can't hook event", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void UnhookEvent(SpreadsheetControl control) {
            if (handler != null) {
                Type controlType = typeof(SpreadsheetControl);
                EventInfo eInfo = controlType.GetEvent(eventName);
                eInfo.RemoveEventHandler(control, handler);
            }
        }
    }

    public class SpreadsheetCustomDrawCellEventHooker : SpreadsheetEventHooker {
        public SpreadsheetCustomDrawCellEventHooker(string eventName, SpreadsheetEventViewerModule owner) :
            base(eventName, owner) {
        }
        protected override string MethodName { get { return "CustomDrawCellEventLogger"; } }
    }
    public class SpreadsheetCustomDrawHeaderEventHooker : SpreadsheetEventHooker {
        public SpreadsheetCustomDrawHeaderEventHooker(string eventName, SpreadsheetEventViewerModule owner) :
            base(eventName, owner) {
        }
        protected override string MethodName { get { return "CustomDrawHeaderEventLogger"; } }
    }
    #endregion
}

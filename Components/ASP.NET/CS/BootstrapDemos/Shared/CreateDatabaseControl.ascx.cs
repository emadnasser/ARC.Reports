using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Shared_CreateDatabaseControl : System.Web.UI.UserControl {
    string _tableKey;

    public string TableKey
    {
        get { return _tableKey; }
        set { _tableKey = value; }
    }

    public int RecordCount
    {
        get { return DatabaseGenerator.GetTable(TableKey).RecordCount; }
    }

    protected void Page_Load(object sender, EventArgs e) { }

    protected void Callback_Callback(object source, CallbackEventArgs e) {
        e.Result = DevExpress.Web.Internal.HtmlConvertor.ToJSON(GetCallbackResult(e.Parameter));
    }

    object GetCallbackResult(string parameter) {
        if(parameter == "create")
            return DatabaseGenerator.TryCreateDatabase(TableKey);
        if(parameter == "getRecordCount")
            return ((double)DatabaseGenerator.GetCreatingDatabaseRecordCount(TableKey) / RecordCount) * 100;
        throw new ArgumentException();
    }
}

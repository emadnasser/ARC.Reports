<%@ Control Language="C#" AutoEventWireup="true" %>
<script runat="server">
    string _tableKey;
    
    public string TableKey {
        get { return _tableKey; }
        set { _tableKey = value; }
    }
    
    public int RecordCount {
        get { return DatabaseGenerator.GetTable(TableKey).RecordCount; }
    }
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            Progress.Maximum = RecordCount;
    }
    protected void Callback_Callback(object source, CallbackEventArgs e) {
        e.Result = DevExpress.Web.Internal.HtmlConvertor.ToJSON(GetCallbackResult(e.Parameter));
    }
    object GetCallbackResult(string parameter) {
        if(parameter == "create")
            return DatabaseGenerator.TryCreateDatabase(TableKey);       
        if(parameter == "getRecordCount")
            return DatabaseGenerator.GetCreatingDatabaseRecordCount(TableKey);
        
        throw new ArgumentException();
    }
    
</script>
<script type="text/javascript">
    var createTimer = -1;
    var progressTimer = -1;
    function CreateDbButton_Click(s, e) {
        CreateDbMessage.SetText("Creating Database...");
        CreateDbButton.SetVisible(false);
        CreateDbProgress.SetVisible(true);
        CreateDbCallback.PerformCallback("create");
        window.setInterval(function() { CreateDbCallback.PerformCallback("getRecordCount") }, 1000);
    }
    
    function CreateDbCallback_CallbackComplete(s, e) {        
        if(e.parameter == "create") {
            window.clearTimeout(createTimer);
            if(eval(e.result)) {
                window.clearInterval(progressTimer);
                document.location.reload();                
            } else {
                createTimer = window.setTimeout(function() { CreateDbCallback.PerformCallback("create") }, 1000);
            }
        } else if(e.parameter == "getRecordCount") {
            CreateDbProgress.SetPosition(eval(e.result));
        }
    }
    
    function CreateDbCallback_CallbackError(s, e) {        
        e.handled = true;
        window.clearInterval(progressTimer);        
        alert(e.message);
        document.location.reload();
    }    
    
</script>
<div style="margin-bottom: 10px">
    <dx:ASPxLabel runat="server" ID="Label" ClientInstanceName="CreateDbMessage"
        Text="This demo requires a large database. To create a sample database, click the Create Database button below. This may take a few minutes." />
</div>
<dx:ASPxButton runat="server" ID="Button" ClientInstanceName="CreateDbButton" Text="Create Database"
    AutoPostBack="false">
    <ClientSideEvents Click="CreateDbButton_Click" />
</dx:ASPxButton>
<dx:ASPxProgressBar runat="server" ID="Progress" ClientInstanceName="CreateDbProgress" Width="100%" ClientVisible="false" DisplayFormatString="0" />
<dx:ASPxCallback runat="server" ID="Callback" ClientInstanceName="CreateDbCallback" OnCallback="Callback_Callback">
    <ClientSideEvents CallbackComplete="CreateDbCallback_CallbackComplete" CallbackError="CreateDbCallback_CallbackError"  />
</dx:ASPxCallback>

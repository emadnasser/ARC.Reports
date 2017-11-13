<%@ Import Namespace="DashboardDemos.Core" %>
<%@ Control Language="C#" AutoEventWireup="true" %>
<script runat="server">       
    protected void Callback_Callback(object source, DevExpress.Web.CallbackEventArgs e) {
        e.Result = DevExpress.Web.Internal.HtmlConvertor.ToJSON(GetCallbackResult(e.Parameter));
    }
    object GetCallbackResult(string parameter) {
        if (parameter == "create") {
            string dataFolder = HttpContext.Current.Server.MapPath("App_data");
            DashboardDemosUtils.CreateDatabasesWeb(dataFolder, DashboardDemosUtils.DashboardStorageConnectionString, DashboardDemosUtils.FinancialDemoConnectionString);
            return true;            
        }
        if (parameter == "getStep") {            
            return DashboardDemosUtils.DatabaseCreationCurrentStep;            
        }
        return false;         
    }
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            Progress.Maximum = DashboardDemosUtils.DatabaseCreationMaxStep;
        System.Data.SqlClient.SqlConnectionStringBuilder sb = new System.Data.SqlClient.SqlConnectionStringBuilder(DashboardDemosUtils.DashboardStorageConnectionString);
        Label.Text = string.Format("This demo requires a sample database. To create a database, click the Create Database button below. This may take a few minutes.\r\n The sample database will be created on the {0} server. To change the server, specify the server name within the connection strings in the connections.config file and refresh the page.", sb.DataSource);
        ASPxLabelErrorCaption.Text = string.Format("An error occurred when creating a demo database on the {0} SQL server instance:", sb.DataSource);
        }
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
        window.setInterval(function () { CreateDbCallback.PerformCallback("getStep") }, 1000);
    }
    function CreateDbCallback_CallbackComplete(s, e) {
        if(e.parameter == "create") {
            window.clearTimeout(createTimer);
            if(eval(e.result)) {
                window.clearInterval(progressTimer);
                window.location = window.location.toString().replace("DatabaseGenerationForm", "Default");                
            } else {
                
            }
        } else if(e.parameter == "getStep") {
            CreateDbProgress.SetPosition(eval(e.result));
        }
    }
    
    function CreateDbCallback_CallbackError(s, e) {        
        e.handled = true;
        window.clearInterval(progressTimer);
        debugger;
        memoErrorDetails.SetText(e.message);
        errorPopup.Show();        
    }    
    
</script>
<div style="margin-bottom: 10px">
    <dx:ASPxLabel runat="server" ID="Label" ClientInstanceName="CreateDbMessage" />
</div>
<dx:ASPxButton runat="server" ID="Button" ClientInstanceName="CreateDbButton" Text="Create Database"
    AutoPostBack="false">
    <ClientSideEvents Click="CreateDbButton_Click" />
</dx:ASPxButton>
<dx:ASPxProgressBar runat="server" ID="Progress" ClientInstanceName="CreateDbProgress" Width="100%" ClientVisible="false" DisplayFormatString="0" />
<dx:ASPxCallback runat="server" ID="Callback" ClientInstanceName="CreateDbCallback" OnCallback="Callback_Callback">
    <ClientSideEvents CallbackComplete="CreateDbCallback_CallbackComplete" CallbackError="CreateDbCallback_CallbackError"  />
</dx:ASPxCallback>
<dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" HeaderText="Financial Dashboard" Height="380px" Theme="Metropolis" Width="623px" ClientInstanceName="errorPopup" CloseAction="CloseButton" Modal="True" PopupVerticalAlign="WindowCenter" PopupHorizontalAlign="WindowCenter">
    <ClientSideEvents CloseUp="function(s, e) {
	document.location.reload();
}" />
    <ContentCollection>
<dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">    
    <dx:ASPxLabel ID="ASPxLabelErrorCaption" runat="server" Text="" Theme="Metropolis">
    </dx:ASPxLabel>
    
    <br />
    
    <br />
    <dx:ASPxMemo ID="ASPxMemoErrorDetails" runat="server" Height="173px" Width="456px" ClientInstanceName="memoErrorDetails" Theme="Metropolis"></dx:ASPxMemo>
    
    
    
    <br />
    
    
    
    <dx:ASPxLabel ID="ASPxLabel" runat="server" Text="To run this demo, do one of the following: 
        
        - Install SQL Server Express or SQL Server Express LocalDB on your computer. 
        - Specify the server name within connection strings in the connections.config file and run the demo again. 
        To view dashboard demos online, go to " Theme="Metropolis">
    </dx:ASPxLabel><a href="https://www.devexpress.com/products/net/dashboard/demos.xml">Dashboard Demos. </a>
    
        </dx:PopupControlContentControl>
</ContentCollection>
</dx:ASPxPopupControl>

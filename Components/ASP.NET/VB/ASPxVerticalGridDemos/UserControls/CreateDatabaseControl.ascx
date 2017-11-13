<%@ Control Language="vb" AutoEventWireup="true" %>
<script runat="server">
	Dim _tableKey As String

	Public Property TableKey() As String
		Get
			Return _tableKey
		End Get
		Set(ByVal value As String)
			_tableKey = value
		End Set
	End Property

	Public ReadOnly Property RecordCount() As Integer
		Get
			Return DatabaseGenerator.GetTable(TableKey).RecordCount
		End Get
	End Property
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Progress.Maximum = RecordCount
		End If
	End Sub
	Protected Sub Callback_Callback(ByVal source As Object, ByVal e As CallbackEventArgs)
		e.Result = DevExpress.Web.Internal.HtmlConvertor.ToJSON(GetCallbackResult(e.Parameter))
	End Sub
	Function GetCallbackResult(ByVal parameter As String) As Object
		If parameter = "create" Then
			Return DatabaseGenerator.TryCreateDatabase(TableKey)
		End If
		If parameter = "getRecordCount" Then
			Return DatabaseGenerator.GetCreatingDatabaseRecordCount(TableKey)
		End If

		Throw New ArgumentException()
	End Function

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
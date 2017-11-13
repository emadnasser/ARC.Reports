<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FilterServerMode.aspx.vb" 
	Inherits="ASPxGridLookup_FilterServerMode" EnableSessionState="ReadOnly" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<script type="text/javascript">
		var startTime;
		function OnBeginCallback(s, e) {
			startTime = new Date();
		}
		function OnEndCallback(s, e) {
			var result = new Date() - startTime;
			result /= 1000;
			result = result.toString();
			if(result.length > 4)
				result = result.substr(0, 4);
			ClientTimeLabel.SetText(result.toString() + " sec");
			ClientCaptionLabel.SetText("Time to retrieve the last data:");
		}
	</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">    
	<dx:CreateDatabaseControl runat="server" ID="CreateDatabaseControl" TableKey="GeneratedPersonTable" />
	<div runat="server" id="Demo">
		<div style="float: left; width: 400px;">
			<dx:ASPxLabel ID="GridLookupCaptionLabel" runat="server" Text="" AssociatedControlID="GridLookup" />
			<div class="TopPadding">
				<dx:ASPxGridLookup ID="GridLookup" runat="server" DataSourceID="XpoDataSource" KeyFieldName="ID" SelectionMode="Single" OnInit="ASPxGridLookup_Init" 
								   TextFormatString="{0} {1}" Width="200px" ClientInstanceName="ClientGridLookup">
					<ClearButton DisplayMode="OnHover"></ClearButton>
					<Columns>
						<dx:GridViewDataTextColumn FieldName="FirstName" Width="100px" />          
						<dx:GridViewDataTextColumn FieldName="LastName" Width="100px" />
						<dx:GridViewDataTextColumn FieldName="Phone" />
					</Columns>
					<ClientSideEvents BeginCallback="OnBeginCallback" EndCallback="OnEndCallback" />
					<GridViewProperties>
						<SettingsBehavior AllowDragDrop="False" EnableRowHotTrack="True" />
						<SettingsPager NumericButtonCount="3" />
					</GridViewProperties>
				</dx:ASPxGridLookup>
			</div>       
		</div>
		<div style="float: left;">
			Incremental filtering
			<div class="TopPadding">
				<dx:ASPxRadioButtonList ID="RadioButtonList" runat="server" AutoPostBack="True">
					<Items>
						<dx:ListEditItem Value="Contains" />
						<dx:ListEditItem Value="StartsWith" />
						<dx:ListEditItem Value="Filter Row" />
					</Items>
				</dx:ASPxRadioButtonList>
			</div>
			<div class="TopPadding">
				<dx:ASPxLabel ID="CaptionLabel" runat="server" ClientInstanceName="ClientCaptionLabel" />
				<dx:ASPxLabel ID="TimeLabel" runat="server" ClientInstanceName="ClientTimeLabel" Font-Bold="True" />
			</div>
		</div>
	</div>
	<dx:XpoDataSource ID="XpoDataSource" runat="server" ServerMode="True" TypeName="XpoPersonEntity" />
</asp:Content>
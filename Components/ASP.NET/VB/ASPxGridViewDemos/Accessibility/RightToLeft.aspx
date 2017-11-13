<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="RightToLeft.aspx.vb" Inherits="Accessibility_RightToLeft" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="text-align: right;">
		<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="DemoDataSource1"
			KeyFieldName="CustomerID" Width="100%" EnableRowsCache="False" RightToLeft="true">
			<Columns>
				<dx:GridViewCommandColumn ShowEditButton="true" VisibleIndex="0" />
				<dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="1" SortIndex="0" SortOrder="Ascending" />                    
				<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" />
				<dx:GridViewDataColumn FieldName="Country" VisibleIndex="3" GroupIndex="0" />
				<dx:GridViewDataColumn FieldName="City" VisibleIndex="4" />
				<dx:GridViewDataColumn FieldName="Region" VisibleIndex="5" />
			</Columns>
			<Settings ShowGroupPanel="true" />
			<SettingsBehavior AutoExpandAllGroups="true" />
			<SettingsPopup>
				<EditForm Width="600" />
			</SettingsPopup>
			<SettingsPager>
				<Summary Visible="false" />
			</SettingsPager>
		</dx:ASPxGridView>
	</div>
	<demo:DemoDataSource runat="server" ID="DemoDataSource1" DataSourceID="CustomersDataSource"></demo:DemoDataSource>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" EnableInsert="true" EnableUpdate="true" />
	<script type="text/javascript">
		if(ASPxClientUtils.ie && ASPxClientUtils.browserVersion > 7 && document.body.offsetWidth % 2 > 0)
			document.body.style.width = (document.body.offsetWidth - 1) + "px";
	</script>
</asp:Content>
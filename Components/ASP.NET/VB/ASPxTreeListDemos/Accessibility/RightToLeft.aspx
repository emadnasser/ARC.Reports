<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="RightToLeft.aspx.vb" Inherits="Accessibility_RightToLeft" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div dir="rtl" style="text-align: right;">
		<dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="false" Width="100%"
			DataSourceID="ObjectDataSource1" KeyFieldName="ID" ParentFieldName="ParentID"
			RightToLeft="True">
			<Settings GridLines="Both"/>
			<SettingsBehavior ExpandCollapseAction="NodeDblClick" />
			<SettingsEditing Mode="EditFormAndDisplayNode" />
			<SettingsPager Mode="ShowPager" PageSize="10">                
				<Summary Visible="false" />
			</SettingsPager>
			<Border BorderStyle="Solid" />
			<Styles>
				<PagerTopPanel>
					<BorderBottom BorderStyle="Solid" />
				</PagerTopPanel>
				<PagerBottomPanel>
					<BorderTop BorderStyle="Solid" />
				</PagerBottomPanel>
				<AlternatingNode Enabled="True" />
			</Styles>
			<Columns>
				<dx:TreeListTextColumn FieldName="From" />
				<dx:TreeListTextColumn FieldName="Subject" />
				<dx:TreeListDateTimeColumn FieldName="DateCreated" />
				<dx:TreeListCheckColumn FieldName="HasAttachment" Caption="Has Attachment" />
				<dx:TreeListCommandColumn ShowNewButtonInHeader="true">
					<EditButton Visible="true" />
					<NewButton Visible="true" />
				</dx:TreeListCommandColumn>
			</Columns>
		</dx:ASPxTreeList>
	</div>
	<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Thread"
		TypeName="NewsGroupDataProvider" DeleteMethod="Delete" InsertMethod="Insert"
		SelectMethod="Select" UpdateMethod="Update">
		<UpdateParameters>
			<asp:Parameter Name="ParentID" />
			<asp:Parameter Name="From" />
			<asp:Parameter Name="Subject" />
			<asp:Parameter Name="Text" />
			<asp:Parameter Name="DateCreated" />
			<asp:Parameter Name="HasAttachment" />
		</UpdateParameters>
	</asp:ObjectDataSource>
	<script type="text/javascript">
		if(ASPxClientUtils.ie && ASPxClientUtils.browserVersion > 7 && document.body.offsetWidth % 2 > 0)
			document.body.style.width = (document.body.offsetWidth - 1) + "px";
	</script>
</asp:Content>
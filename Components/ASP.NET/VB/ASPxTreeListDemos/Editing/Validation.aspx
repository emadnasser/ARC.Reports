<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Validation.aspx.vb"
	Inherits="Editing_Validation" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxTreeList ID="treeList" runat="server" Width="100%" AutoGenerateColumns="false"
		DataSourceID="ObjectDataSource1" KeyFieldName="ID" ParentFieldName="ParentID"
		OnHtmlRowPrepared="treeList_HtmlRowPrepared" OnNodeValidating="treeList_NodeValidating"
		OnStartNodeEditing="treeList_StartNodeEditing">
		<Settings GridLines="Both" />
		<SettingsBehavior ExpandCollapseAction="NodeDblClick" />
		<SettingsEditing Mode="EditFormAndDisplayNode" />
		<Columns>
			<dx:TreeListTextColumn FieldName="From" />
			<dx:TreeListTextColumn FieldName="Subject" />
			<dx:TreeListDateTimeColumn FieldName="DateCreated" />
			<dx:TreeListCheckColumn FieldName="HasAttachment" Caption="Has Attachment" />
			<dx:TreeListCommandColumn>
				<EditButton Visible="True" />
			</dx:TreeListCommandColumn>
		</Columns>
	</dx:ASPxTreeList>
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
</asp:Content>
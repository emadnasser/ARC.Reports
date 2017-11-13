<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TokenBoxColumn.aspx.vb" Inherits="ASPxTokenBox_TokenBoxColumn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="DemoDataSource1" KeyFieldName="ID" >
		<Columns>
			<dx:GridViewCommandColumn ShowEditButton="true" VisibleIndex="0" />
			<dx:GridViewDataTextColumn FieldName="UserName" Caption="User Name" ReadOnly="true" VisibleIndex="1">
			</dx:GridViewDataTextColumn>
			<dx:GridViewDataTokenBoxColumn FieldName="Roles" VisibleIndex="2">
				<PropertiesTokenBox DataSourceID="UserRolesDataSource" TextField="Name" ValueField="ID" AllowCustomTokens="false"></PropertiesTokenBox>
			</dx:GridViewDataTokenBoxColumn>
		</Columns>
		<SettingsEditing EditFormColumnCount="1" Mode="EditForm"></SettingsEditing>
	</dx:ASPxGridView>
	<demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="ID" DataSourceID="UsersDataSource" />
	<ef:EntityDataSource runat="server" ID="UsersDataSource" ContextTypeName="EditorsSampleDBContext" EntitySetName="Users" 
		EnableInsert="true" EnableDelete="true" EnableUpdate="true" />
	<ef:EntityDataSource runat="server" ID="UserRolesDataSource" ContextTypeName="EditorsSampleDBContext" EntitySetName="UserRoles" />
</asp:Content>
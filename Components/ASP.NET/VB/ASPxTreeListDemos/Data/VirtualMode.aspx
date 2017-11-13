<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="VirtualMode.aspx.vb"
	Inherits="Data_VirtualMode" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxTreeList ID="treeList" runat="server" Width="100%" OnVirtualModeCreateChildren="treeList_VirtualModeCreateChildren"
		OnVirtualModeNodeCreating="treeList_VirtualModeNodeCreating">
		<Columns>
			<dx:TreeListDataColumn FieldName="name" Caption="File name" />
			<dx:TreeListDataColumn FieldName="date" Caption="Creation Date" Width="10%" DisplayFormat="{0:g}" />
		</Columns>
		<SettingsBehavior ExpandCollapseAction="NodeDblClick" />
	</dx:ASPxTreeList>
</asp:Content>
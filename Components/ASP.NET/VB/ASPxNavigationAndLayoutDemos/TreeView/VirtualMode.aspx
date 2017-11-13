<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="VirtualMode.aspx.vb" Inherits="TreeView_VirtualMode" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxTreeView ID="treeView" runat="server" EnableCallBacks="true" OnVirtualModeCreateChildren="treeView_VirtualModeCreateChildren">
		<Images NodeImage-Width="13px">
		</Images>
		<Styles NodeImage-Paddings-PaddingTop="2px">
		</Styles>
	</dx:ASPxTreeView>
</asp:Content>
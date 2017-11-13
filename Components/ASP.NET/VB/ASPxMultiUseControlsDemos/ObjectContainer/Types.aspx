<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Types.aspx.vb"
	Inherits="ObjectContainer_Types" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="float: left; width: 75%">
		<asp:PlaceHolder ID="phAppearances" runat="server" EnableViewState="False" />
	</div>
	<div style="float: right; width: 23%">
		<div class="BottomPadding">
			<dx:ASPxLabel ID="Label1" runat="server" Text="Select ObjectType:" />
		</div>
		<dx:ASPxMenu ID="mSelector" EnableViewState="False" runat="server" DataSourceID="XmlDataSource1"
			EncodeHtml="False" Orientation="Vertical" Width="150px">
			</dx:ASPxMenu>
	</div>
	<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/ObjectContainerObjectTypes.xml"
		XPath="//Type" />
</asp:Content>
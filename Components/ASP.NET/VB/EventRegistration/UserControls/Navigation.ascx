<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Navigation.ascx.vb" Inherits="UserControls_Navigation" %>
<dx:ASPxMenu ID="MainMenu" runat="server" Orientation="Horizontal" AllowSelectItem="true"
	EnableTheming="false" CssClass="mainMenu" ItemLinkMode="TextAndImage"
	ItemSpacing="15px" SyncSelectionMode="CurrentPath">
	<ItemStyle CssClass="mainMenuItem"/>
	<Items>
		<dx:MenuItem Name="Home" Text="" NavigateUrl="~/Default.aspx" Image-Url="~/Images/header/home.png" Image-UrlSelected="~/Images/header/home_sel.png" />
		<dx:MenuItem Name="Registration" Text="" NavigateUrl="~/Registration.aspx" Image-Url="~/Images/header/registration.png" Image-UrlSelected="~/Images/header/registration_sel.png" />
		<dx:MenuItem Name="Schedule" Text="" NavigateUrl="~/Schedule.aspx" Image-Url="~/Images/header/schedule.png" Image-UrlSelected="~/Images/header/schedule_sel.png" />
		<dx:MenuItem Name="Contacts" Text="" NavigateUrl="~/Contacts.aspx" Image-Url="~/Images/header/contacts.png" Image-UrlSelected="~/Images/header/contacts_sel.png" />
	</Items>
</dx:ASPxMenu>
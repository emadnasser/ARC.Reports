﻿<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TextWithImages.aspx.vb"
	Inherits="RichEditDemoTextWithImages" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRichEdit ID="DemoRichEdit" runat="server" Width="100%" Height="700px"
		ActiveTabIndex="0" ShowConfirmOnLosingChanges="false" OnPreRender="DemoRichEdit_PreRender">
	</dx:ASPxRichEdit>
</asp:Content>
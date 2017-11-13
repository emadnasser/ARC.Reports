<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomImages.aspx.vb" Inherits="ListEditors_CustomImages" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.customCheckBoxList img
		{
			margin-bottom: -18px !important;
			padding-right: 5px;      
		}
		.customCheckBoxList label
		{
			height: 50px;
			padding-left: 5px;
			padding-top: 4px;
			display: inline-block;
		}
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<br />
	<dx:ASPxRadioButtonList ID="checkBoxList" runat="server" CssClass="customCheckBoxList" 
		RepeatColumns="2" Width="550px" Border-BorderWidth="0">
		<Items>
			<dx:ListEditItem Value="0" Text="WinForms Controls" ImageUrl="Images/WinForms.png" />
			<dx:ListEditItem Value="1" Text="ASP.NET AJAX Controls" ImageUrl="Images/ASP.NET.png" />
			<dx:ListEditItem Value="2" Text="WPF Controls and Libraries" ImageUrl="Images/WPF.png" />
			<dx:ListEditItem Value="3" Text="Silverlight Controls" ImageUrl="Images/SL.png" />
			<dx:ListEditItem Value="4" Text="VCL Controls" ImageUrl="Images/VCL.png" />            
			<dx:ListEditItem Value="5" Text="IDE Productivity Tools" ImageUrl="Images/IDE.png" />
			<dx:ListEditItem Value="6" Text="Application Frameworks" ImageUrl="Images/ApplicationFrameworks.png" />
		</Items>
	</dx:ASPxRadioButtonList>
</asp:Content>
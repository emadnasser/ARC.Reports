<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MultiMonth.aspx.vb"
	Inherits="ASPxCalendar_MultiMonth" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxComboBox ID="ddlColumnsPerRows" runat="server" SelectedIndex="0" AutoPostBack="True"
		Width="124px" OnSelectedIndexChanged="ddlDayNameFormat_SelectedIndexChanged" Caption="Columns per rows:">
		<CaptionCellStyle></CaptionCellStyle>
		<RootStyle CssClass="OptionsBottomMargin"/>
		<Items>
			<dx:ListEditItem Value="2x2" />
			<dx:ListEditItem Value="2x1" />
			<dx:ListEditItem Value="1x3" />
		</Items>
	</dx:ASPxComboBox>
	<dx:ASPxCalendar ID="calendar" runat="server" Columns="2" Rows="2" EnableMultiSelect="true" />
</asp:Content>
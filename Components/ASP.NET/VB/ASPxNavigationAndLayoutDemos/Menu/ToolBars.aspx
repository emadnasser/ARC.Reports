<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Toolbars.aspx.vb"
	Inherits="Menu_Toolbars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	Icons 16x16:
	<dx:ASPxMenu ID="ASPxMenu1" runat="server" ShowAsToolbar="true" ShowPopOutImages="true">
		<Items>
			<dx:MenuItem>
				<Image IconID="actions_new_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem>
				<Image IconID="edit_edit_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem>
				<Image IconID="actions_open_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem BeginGroup="true" GroupName="Bold">
				<Image IconID="format_bold_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem GroupName="Italic" Checked="true">
				<Image IconID="format_italic_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem GroupName="Underline">
				<Image IconID="format_underline_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem GroupName="Align" BeginGroup="true">
				<Image IconID="format_alignleft_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem GroupName="Align" Checked="true">
				<Image IconID="format_aligncenter_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem GroupName="Align">
				<Image IconID="format_alignright_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem GroupName="Align">
				<Image IconID="format_alignjustify_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem BeginGroup="true" DropDownMode="true">
				<Image IconID="zoom_zoom_16x16"></Image>
				<Items>
					<dx:MenuItem Text="Zoom in">
						<Image IconID="zoom_zoomin_16x16"></Image>
					</dx:MenuItem>
					<dx:MenuItem Text="Zoom out">
						<Image IconID="zoom_zoomout_16x16"></Image>
					</dx:MenuItem>
					<dx:MenuItem Text="100% zoom">
						<Image IconID="zoom_zoom100_16x16"></Image>
					</dx:MenuItem>
				</Items>
			</dx:MenuItem>
		</Items>
	</dx:ASPxMenu>
	<br />
	Icons 32x32:
	<dx:ASPxMenu ID="ASPxMenu2" runat="server" ShowAsToolbar="true" ShowPopOutImages="true">
		<Items>
			<dx:MenuItem>
				<Image IconID="navigation_backward_32x32"></Image>
			</dx:MenuItem>
			<dx:MenuItem>
				<Image IconID="navigation_forward_32x32"></Image>
			</dx:MenuItem>
			<dx:MenuItem BeginGroup="true">
				<Image IconID="save_save_32x32"></Image>
			</dx:MenuItem>
			<dx:MenuItem BeginGroup="true">
				<Image IconID="actions_refresh_32x32"></Image>
			</dx:MenuItem>
			<dx:MenuItem>
				<Image IconID="navigation_home_32x32"></Image>
			</dx:MenuItem>
			<dx:MenuItem BeginGroup="true" DropDownMode="true">
				<Image IconID="find_find_32x32"></Image>
				<Items>
					<dx:MenuItem Text="Find customer">
						<Image IconID="find_findcustomers_32x32"></Image>
					</dx:MenuItem>
					<dx:MenuItem Text="Find by ID">
						<Image IconID="find_findbyid_32x32"></Image>
					</dx:MenuItem>
				</Items>
			</dx:MenuItem>
			<dx:MenuItem BeginGroup="true">
				<Image IconID="setup_properties_32x32"></Image>
			</dx:MenuItem>
		</Items>
	</dx:ASPxMenu>
</asp:Content>
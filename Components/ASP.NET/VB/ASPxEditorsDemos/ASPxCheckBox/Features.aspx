<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.vb" Inherits="ASPxComboBox_Features" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.dxICheckBox_CustomImage {
			margin: 1px;
		}
		.dxICBFocused_CustomImage {
			margin: 0px;
			border: 1px dotted Orange;
		}
	</style>
	<%--start highlighted block--%>
	<script type="text/javascript">
		function OnValueChanged(s, e) {
			var checkState = checkBox.GetCheckState();
			var checked = checkBox.GetChecked();
			checkStateLabel.SetText("CheckState = " + checkState);
			checkedLabel.SetText("Checked = " + checked);
		}
	 </script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	 <div style="float: left; width: 100%">
		<div style="float: left; width: 290px">
			<%--start highlighted block--%>
			<dx:ASPxCheckBox ID="ASPxCheckBox" runat="server" ClientInstanceName="checkBox" Text="ASPxCheckBox (click to change state)" EnableViewState="false" Checked="true">
				<ClientSideEvents  ValueChanged="OnValueChanged" Init="OnValueChanged" />
			</dx:ASPxCheckBox>
			<%--end highlighted block--%>
			<br />
			<dx:ASPxLabel ID="CheckStateLabel" runat="server" ClientInstanceName="checkStateLabel" ForeColor="Gray" /><br />
			<dx:ASPxLabel ID="CheckedLabel" runat="server" ClientInstanceName="checkedLabel" ForeColor="Gray" />
		</div>
		<div style="float: left">
			<dx:ASPxCheckBox ID="NativeCheckBox" runat="server" Text="Native" AutoPostBack="true" Checked="false" EnableViewState="false" />
			<dx:ASPxCheckBox ID="CustomImagesCheckBox" runat="server" Text="Use custom images" AutoPostBack="true" Checked="false" EnableViewState="false" />
			<dx:ASPxCheckBox ID="AllowGrayedCheckBox" runat="server" Text="AllowGrayed" AutoPostBack="true" Checked="false" EnableViewState="false" />
			<dx:ASPxCheckBox ID="AllowGrayedByClickCheckBox" runat="server" Text="AllowGrayedByClick" AutoPostBack="true" Checked="true" EnableViewState="false" /><br />
			<dx:ASPxButton ID="SwitchButton" runat="server" Text="Switch CheckBox State" OnClick="OnSwitchButtonClick" EnableViewState="false"/>
		</div>
	</div>
</asp:Content>
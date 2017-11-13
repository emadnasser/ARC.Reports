<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="ServerSideResizing.aspx.vb" Inherits="ServerSideResizing" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<link rel="stylesheet" type="text/css" href="Css/ServerSideResizing.css">
	<script type="text/javascript">
		var FILE_SIZE_ELEMENT_ID = "fileSize", 
			IMAGE_SIZE_ELEMENT_ID = "imageSizes";
		var fileSizes = { 
			"640x480|0": 46, 
			"640x480|1": 46, 
			"640x480|2": 46, 
			"400x400|0": 22, 
			"400x400|1": 22, 
			"400x400|2": 28, 
			"300x0|0": 14,
			"300x0|1": 14,
			"300x0|2": 34
		};
		function onInitFormLayout() {
			updateImageInfo();
			CallbackPanel.PerformCallback();
		}
		function onComboBoxSelectedItemChanged() {
			updateImageInfo();
			CallbackPanel.PerformCallback();
		}
		function updateImageInfo() {
			var key = ComboBoxSize.GetValue() + "|" + ComboBoxImageSizeMode.GetValue();
			document.getElementById(FILE_SIZE_ELEMENT_ID).innerHTML = fileSizes[key];
			document.getElementById(IMAGE_SIZE_ELEMENT_ID).innerHTML = ComboBoxSize.GetText();
		}
	</script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxFormLayout runat="server" ColCount="2">
		<Items>
			<dx:LayoutItem Caption="ImageSizeMode:" CssClass="liClass" ParentContainerStyle-CssClass="liClass">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer>
						<dx:ASPxComboBox ID="ComboBoxImageSizeMode" ClientInstanceName="ComboBoxImageSizeMode" runat="server" ValueType="System.Int32" Width="150" SelectedIndex="0">
							<ClientSideEvents SelectedIndexChanged="onComboBoxSelectedItemChanged" />
							<Items>
								<dx:ListEditItem Text="ActualSizeOrFit" Value="0" />
								<dx:ListEditItem Text="FitProportional" Value="1" />
								<dx:ListEditItem Text="FillAndCrop" Value="2" />
							</Items>
						</dx:ASPxComboBox>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutItem Caption="Size:">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer>
						<dx:ASPxComboBox ID="ComboBoxSize" ClientInstanceName="ComboBoxSize" runat="server" ValueType="System.String" Width="150" SelectedIndex="0">
							<ClientSideEvents SelectedIndexChanged="onComboBoxSelectedItemChanged" />
							<Items>
								<dx:ListEditItem Text="640 x 480 px" Value="640x480" />
								<dx:ListEditItem Text="400 x 400 px" Value="400x400" />
								<dx:ListEditItem Text="Width = 300 px" Value="300x0" />
							</Items>
						</dx:ASPxComboBox>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
		</Items>
		<ClientSideEvents Init="onInitFormLayout" />
	</dx:ASPxFormLayout>
	<dx:ASPxCallbackPanel ID="CallbackPanel" ClientInstanceName="CallbackPanel" runat="server" CssClass="cbpClass">
		<PanelCollection>
			<dx:PanelContent>
				<dx:ASPxBinaryImage ID="BinaryImage" runat="server" CssClass="biClass" EnableServerResize="True" ShowLoadingImage="True"></dx:ASPxBinaryImage>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxCallbackPanel>
	<p>The origianl image file size is <b>328KB</b> (1200 x 900 px), the resized image file size is <b id="fileSize"></b><b> KB</b> for (<span id="imageSizes"></span>).</p>
</asp:Content>
<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BinaryImageEditing.aspx.vb" Inherits="ASPxBinaryImage_Editing" EnableViewState="false" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentHolder">
	<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="2" LeftAndRightCaptionsWidth="135" >
		<Items>
			<dx:LayoutGroup Caption="Control" AlignItemCaptions="true" GroupBoxDecoration="None" RowSpan="2">
				<Items>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxBinaryImage ID="BinaryImage" ClientInstanceName="ClientBinaryImage" Width="200" Height="200" ShowLoadingImage="true" LoadingImageUrl="~/Content/Loading.gif" runat="server">
									<EditingSettings Enabled="true">                                        
										<UploadSettings>
											<UploadValidationSettings MaxFileSize="4194304"></UploadValidationSettings>
										</UploadSettings>
									</EditingSettings>
								</dx:ASPxBinaryImage>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
						<ParentContainerStyle>
							<Paddings PaddingRight="60" />
						</ParentContainerStyle>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			<dx:LayoutGroup Caption="General Settings" GroupBoxDecoration="HeadingLine">
				<SettingsItemCaptions Location="Left" />
				<Items>
					<dx:LayoutItem Caption="AllowDropOnPreview">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="AllowDropOnPreview" AutoPostBack="true" Width="21" runat="server"></dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			<dx:LayoutGroup Caption="Button Panel Settings"  GroupBoxDecoration="HeadingLine">
				<SettingsItemCaptions Location="Left" />
				<Items>
					<dx:LayoutItem Caption="Visibility:">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ButtonPanelVisibility" AutoPostBack="true" runat="server" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Position:">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ButtonPanelPos" AutoPostBack="true" runat="server" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="ButtonPosition:">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ButtonPosition" AutoPostBack="true" runat="server" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
		</Items>
	</dx:ASPxFormLayout>
</asp:Content>
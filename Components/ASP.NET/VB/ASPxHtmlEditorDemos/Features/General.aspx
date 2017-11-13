<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="General.aspx.vb"
	Inherits="Features_General" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Height="370px">
		<SettingsDialogs>
			<InsertImageDialog>
				<SettingsImageUpload UploadFolder="~/UploadFiles/Images/">
					<ValidationSettings AllowedFileExtensions=".jpe,.jpeg,.jpg,.gif,.png" MaxFileSize="500000">
					</ValidationSettings>
				</SettingsImageUpload>
			</InsertImageDialog>
		</SettingsDialogs>
	</dx:ASPxHtmlEditor>
	<div style="margin-left: -14px; padding-top: 20px;">
		<dx:ASPxFormLayout ID="FormLayout" runat="server"  ShowItemCaptionColon="false" Width="224px" ColCount="2">
			<Items>
				<dx:LayoutGroup Caption="Content Filtering" GroupBoxDecoration="HeadingLine" ColCount="2">
					<ParentContainerStyle>
						<Paddings PaddingRight="20px"  />
					</ParentContainerStyle>
					<Items>
						<dx:LayoutItem ShowCaption="False">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer runat="server">
									<dx:ASPxCheckBox ID="cbAllowScripts" runat="server" AutoPostBack="True" Text="AllowScripts"  />
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:LayoutItem ShowCaption="False">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer runat="server">
									<dx:ASPxCheckBox ID="cbAllowIFrames" runat="server" AutoPostBack="True" Text="AllowIFrames"  />
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:LayoutItem ShowCaption="False">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer runat="server">
									<dx:ASPxCheckBox ID="cbAllowFormElements" runat="server" AutoPostBack="True" Text="AllowFormElements"  />
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:LayoutItem ShowCaption="False">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer runat="server">
									<dx:ASPxCheckBox ID="cbAllowIdAttributes" runat="server" AutoPostBack="True" Text="AllowIdAttributes"  />
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:LayoutItem ShowCaption="False">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer runat="server">
									<dx:ASPxCheckBox ID="cbAllowStyleAttributes" runat="server" AutoPostBack="True" Text="AllowStyleAttributes"  />
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:LayoutItem Caption="AllowedDocumentType:">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer runat="server">
									<dx:ASPxComboBox ID="cmbAllowedDocumentType" runat="server" AutoPostBack="True" Width="70px" ValueType="System.Int32" >
										<Items>
											<dx:ListEditItem Text="XHTML" Value="0" />
											<dx:ListEditItem Text="HTML5" Value="1" />
											<dx:ListEditItem Text="Both" Value="2" />
										</Items>
									</dx:ASPxComboBox>
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
					</Items>
				</dx:LayoutGroup>
				<dx:LayoutGroup Caption="Content Editing" GroupBoxDecoration="HeadingLine" ColCount="2">
					<Items>
						<dx:LayoutItem ShowCaption="False">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer runat="server">
									<dx:ASPxCheckBox ID="cbUpdateDeprecatedElements" runat="server" AutoPostBack="True" Text="UpdateDeprecatedElements"  />
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:LayoutItem ShowCaption="False">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer runat="server">
									<dx:ASPxCheckBox ID="cbUpdateBoldItalic" runat="server" AutoPostBack="True" Text="UpdateBoldItalic" />
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						 <dx:LayoutItem Caption="ResourcePathMode:">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer runat="server">
									<dx:ASPxComboBox ID="cbResourcePathMode" runat="server" AutoPostBack="True" Width="70px" ValueType="System.Int32" >
										<Items>
											<dx:ListEditItem Text="Absolute" Value="0" />
											<dx:ListEditItem Text="Relative" Value="1" />
											<dx:ListEditItem Text="RootRelative" Value="2" />
											<dx:ListEditItem Text="NotSet" Value="3" />
										</Items>
									</dx:ASPxComboBox>
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:LayoutItem ShowCaption="False">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer runat="server">
									<dx:ASPxCheckBox ID="cbAllowCustomColorsInColorPickers" runat="server" AutoPostBack="True" Text="AllowCustomColorsInColorPickers"  />
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:LayoutItem Caption="EnterMode:">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer runat="server">
									<dx:ASPxComboBox ID="cbEnterMode" runat="server" AutoPostBack="True" Width="70px" ValueType="System.Int32" >
										<Items>
											<dx:ListEditItem Text="Default" Value="0" />
											<dx:ListEditItem Text="BR" Value="1" />
											<dx:ListEditItem Text="P" Value="2" />
										</Items>
									</dx:ASPxComboBox>
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						 <dx:LayoutItem ShowCaption="False">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer runat="server">
									<dx:ASPxCheckBox ID="cbAllowEditFullDocument" runat="server" AutoPostBack="True" Text="AllowEditFullDocument"  />
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
					</Items>
				</dx:LayoutGroup>
			</Items>
		</dx:ASPxFormLayout>
	</div>
</asp:Content>
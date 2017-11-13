<%@ Page Language="vb" AutoEventWireup="true" CodeFile="BinaryImageAutoUpload.aspx.vb" Inherits="Features_BinaryImageAutoUpload" MasterPageFile="~/Site.master" %>
<asp:Content ID="Head" ContentPlaceHolderID="CustomHeadHolder" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div runat="server" id="WarningDiv">
		<p>
			To run the demo locally, register your Azure account using the AccountManager.RegisterAzure() method in the global.asax file 
			and set the AzureSettings.ContainerName property to your container name value.
		</p>
		<p>
			Or you can see this demo online at <a target="_blank" href='https://demos.devexpress.com/ASPxHtmlEditorDemos/Features/BinaryImageAutoUpload.aspx'>https://demos.devexpress.com/ASPxHtmlEditorDemos/Features/BinaryImageAutoUpload.aspx</a>
		</p>
	</div>
	<dx:ASPxFormLayout runat="server" ID="DemoFormLayout" ColCount="2">
		<Items>
			<dx:LayoutItem ShowCaption="False" Width="650px">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer>
						<dx:ASPxHtmlEditor runat="server" ID="DemoHtmlEditor" OnImageFileSaving="DemoHtmlEditor_ImageFileSaving" Width="100%" Height="600px">
							<Toolbars>
								<dx:HtmlEditorToolbar>
									<Items>
										<dx:ToolbarUndoButton></dx:ToolbarUndoButton>
										<dx:ToolbarRedoButton></dx:ToolbarRedoButton>
										<dx:ToolbarBoldButton BeginGroup="true"></dx:ToolbarBoldButton>
										<dx:ToolbarItalicButton></dx:ToolbarItalicButton>
										<dx:ToolbarUnderlineButton></dx:ToolbarUnderlineButton>
										<dx:ToolbarStrikethroughButton></dx:ToolbarStrikethroughButton>
										<dx:ToolbarFullscreenButton BeginGroup="true"></dx:ToolbarFullscreenButton>
									</Items>
								</dx:HtmlEditorToolbar>
							</Toolbars>
							<Settings AllowSaveBinaryImageToServer="true"></Settings>
							<SettingsDialogs>
								<InsertImageDialog ShowInsertFromWebSection="false">
									<SettingsImageUpload UploadStorage="Azure">
										<AzureSettings AccountName="UploadAzureAccount" ContainerName="uploadcontroldemo" />
									</SettingsImageUpload>
								</InsertImageDialog>
							</SettingsDialogs>
						</dx:ASPxHtmlEditor>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutGroup GroupBoxDecoration="None">
				<SettingsItemCaptions Location="Top" />
				<Items>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox runat="server" ID="AllowSaveBinaryImageToServerCb" ClientInstanceName="allowSaveCB" Checked="true"
									Text="AllowSaveBinaryImageToServer" AutoPostBack="true">
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Max width">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxSpinEdit ID="MaxWidthSpinEdit" ClientInstanceName="maxWidthSE" runat="server" MaxValue="1000" MinValue="100" Number="480"></dx:ASPxSpinEdit>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Max height">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxSpinEdit ID="MaxHeightSpinEdit" ClientInstanceName="maxHeightSE" runat="server" MaxValue="1000" MinValue="100" Number="320"></dx:ASPxSpinEdit>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
		</Items>
	</dx:ASPxFormLayout>
</asp:Content>
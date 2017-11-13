<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MailMergeViaDocumentServer.aspx.vb"
	Inherits="RichEditDemoMailMergeViaDocumentServer" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxFormLayout runat="server" ID="SettingsFormLayout" Width="100%">
		<Items>
			<dx:LayoutGroup Caption="Create invitation" GroupBoxDecoration="HeadingLine">
				<Items>
					<dx:LayoutItem Caption="City">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer runat="server">
								<dx:ASPxComboBox ID="cmbCity" runat="server" AutoPostBack="true"
									ValueType="System.String" SelectedIndex="0">
									<Items>
										<dx:ListEditItem Text="London" Value="London" />
										<dx:ListEditItem Text="Seattle" Value="Seattle" />
										<dx:ListEditItem Text="Tacoma" Value="Tacoma" />
										<dx:ListEditItem Text="Kirkland" Value="Kirkland" />
										<dx:ListEditItem Text="Redmond" Value="Redmond" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
		</Items>
	</dx:ASPxFormLayout>
	<dx:ASPxRichEdit ID="DemoRichEdit" runat="server"  ReadOnly="true" RibbonMode="None" ShowStatusBar="false"
		Settings-HorizontalRuler-Visibility="Hidden" ShowConfirmOnLosingChanges="false"
		Width="100%" Height="500px">
	</dx:ASPxRichEdit>
</asp:Content>
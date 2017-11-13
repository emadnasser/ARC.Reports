<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UICustomization.aspx.vb" Inherits="ToolbarsAndUI_UICustomization" %>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
	<script type="text/javascript">
		function ApplyVisibilitySettings(elementName) {
			CallbackPanel.PerformCallback(elementName);
		}
	</script>
	<style type="text/css">
		.externalRibbon {
			padding-bottom: 20px;
			border-bottom: solid 1px #d1d1d1;
		}
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="float: left; width: 565px;">
		<dx:ASPxCallbackPanel runat="server" ID="CallbackPanel" ClientInstanceName="CallbackPanel"
			OnCallback="CallbackPanel_Callback">
			<PanelCollection>
					<dx:PanelContent>
						<dx:ASPxRibbon ID="ExternalRibbon" runat="server" ShowFileTab="False" Visible="false" CssClass="externalRibbon">
						</dx:ASPxRibbon>
						<dx:ASPxSpreadsheet ID="Spreadsheet" runat="server" ClientInstanceName="Spreadsheet"
							ActiveTabIndex="0" Width="100%" Height="550px" ShowConfirmOnLosingChanges="False"
							RibbonMode="Ribbon">
						</dx:ASPxSpreadsheet>
				</dx:PanelContent>
			</PanelCollection>
		</dx:ASPxCallbackPanel>
	</div>
	<div style="float:left; width: 350px">
		<dx:ASPxFormLayout ID="formLayout" runat="server" ColCount="1">
			<items>
				<dx:LayoutGroup GroupBoxDecoration="None">
					<Items>
						<dx:LayoutItem Caption="Ribbon mode">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer>
									<dx:ASPxComboBox SelectedIndex="0" ID="RibbonMode" runat="server"
										Width="160px" IncrementalFilteringMode="None">
										<ClientSideEvents ValueChanged="function(s, e) { ApplyVisibilitySettings(''); }" />
										<Items>
											<dx:ListEditItem Value="Ribbon" Text="Ribbon" />
											<dx:ListEditItem Value="OneLineRibbon" Text="OneLineRibbon" />
											<dx:ListEditItem Value="Auto" Text="Auto" />
											<dx:ListEditItem Value="None" Text="None" />
											<dx:ListEditItem Value="ExternalRibbon" Text="ExternalRibbon" />
										</Items>
									</dx:ASPxComboBox>
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:LayoutItem Caption="Show formula bar">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer>
									<dx:ASPxCheckBox ID="ShowFormulaBar" runat="server" Checked="true">
										<ClientSideEvents CheckedChanged="function(s, e) { ApplyVisibilitySettings(''); }" />
									</dx:ASPxCheckBox>
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:LayoutItem Caption="Show sheet tabs">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer>
									<dx:ASPxCheckBox ID="ShowSheetTabs" runat="server" Checked="true"> 
										<ClientSideEvents CheckedChanged="function(s, e) { ApplyVisibilitySettings(''); }" />
									</dx:ASPxCheckBox>
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:LayoutItem ShowCaption="false">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer>
									<dx:ASPxButton runat="server" ID="ToggleGridLinesVisibility" Text="Show/hide grid lines" 
										Width="290px" AutoPostBack="false">
										<ClientSideEvents Click="function(s, e) {  ApplyVisibilitySettings('grid'); }" />
									</dx:ASPxButton>
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:LayoutItem ShowCaption="false">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer>
									<dx:ASPxButton runat="server" ID="ToggleHeadersVisibility" Text="Show/hide headings"
										Width="290px" AutoPostBack="false">
										<ClientSideEvents Click="function(s, e) {  ApplyVisibilitySettings('headings'); }" />
									</dx:ASPxButton>
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
					</Items>
				</dx:LayoutGroup>
			</items>
		</dx:ASPxFormLayout>
	</div>
</asp:Content>
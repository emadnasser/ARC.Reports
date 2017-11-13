<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="ContentElementFiltering.aspx.vb" Inherits="Features_ContentElementFiltering" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function onResetHtmlDocumentButtonClick(s, e) {
			HtmlEditor.PerformDataCallback(null, loadHtmlContent);
		}
		function loadHtmlContent(htmlEditor, result) {
			if(result != null)
				htmlEditor.SetHtml(result);
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxFormLayout ID="FormLayout" runat="server" ColCount="4" >
		<Paddings PaddingBottom="20px" />
		<Items>
			<dx:LayoutGroup GroupBoxDecoration="HeadingLine" Caption="Tag Filter Settings">
				<ParentContainerStyle>
					<Paddings PaddingLeft="0"/>
				</ParentContainerStyle>
				<Items>
					<dx:LayoutItem Caption="FilterMode" CaptionSettings-Location="Top">
						<layoutitemnestedcontrolcollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="TagFilterModeComboBox" runat="server" ValueType="System.Int32" >
									<Items>
										<dx:ListEditItem Text="BlackList" Value="0" />
										<dx:ListEditItem Text="WhiteList" Value="1" Selected="true" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</layoutitemnestedcontrolcollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Tags" CaptionSettings-Location="Top">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxTokenBox ID="TagTokenBox" runat="server" Tokens="a, div, img, li, p, ul, span, font, table, tbody, td, tr" >
								</dx:ASPxTokenBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			<dx:LayoutGroup GroupBoxDecoration="HeadingLine" Caption="Attribute Filter Settings">
				<Items>
					<dx:LayoutItem Caption="FilterMode" CaptionSettings-Location="Top">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox  ID="AttributeFilterModeComboBox" runat="server" ValueType="System.Int32" >
									<Items>
										<dx:ListEditItem Text="BlackList" Value="0" />
										<dx:ListEditItem Text="WhiteList" Value="1" Selected="true" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Attributes" CaptionSettings-Location="Top">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxTokenBox ID="AttributeTokenBox" runat="server" Tokens="cellspacing, cellpadding, href, style, src" >
								</dx:ASPxTokenBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			<dx:LayoutGroup GroupBoxDecoration="HeadingLine" Caption="Style Attribute Filter Settings">
				<Items>
					<dx:LayoutItem Caption="FilterMode" CaptionSettings-Location="Top">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox  ID="StyleAttributeFilterModeComboBox" runat="server" ValueType="System.Int32" >
									<Items>
										<dx:ListEditItem Text="BlackList" Value="0" Selected="true" />
										<dx:ListEditItem Text="WhiteList" Value="1" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="StyleAttributes" CaptionSettings-Location="Top">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxTokenBox ID="StyleAttributeTokenBox" runat="server" Tokens="background-color, float" >
								</dx:ASPxTokenBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			<dx:LayoutItem ShowCaption="False" VerticalAlign="Top">
			<ParentContainerStyle>
				<Paddings PaddingTop="20px" PaddingLeft="30px" />
			</ParentContainerStyle>
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer>
						<dx:ASPxButton ID="ApplySettingsButton" runat="server" Text="Apply Settings" Width="140px" >
						</dx:ASPxButton>
						<br />
						<br />
						<dx:ASPxButton ID="ResetHtmlDocumentButton" runat="server" Text="Reset Html Document" Width="140px" AutoPostBack="false">
							<ClientSideEvents Click="onResetHtmlDocumentButtonClick" />
						</dx:ASPxButton>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
		</Items>
	</dx:ASPxFormLayout>
	<dx:ASPxHtmlEditor ID="HtmlEditor" ClientInstanceName="HtmlEditor" runat="server" OnCustomDataCallback="HtmlEditor_CustomDataCallback" Width="797px" Height="430px">
		<SettingsHtmlEditing UpdateBoldItalic="false" UpdateDeprecatedElements="false" />
	</dx:ASPxHtmlEditor>
</asp:Content>
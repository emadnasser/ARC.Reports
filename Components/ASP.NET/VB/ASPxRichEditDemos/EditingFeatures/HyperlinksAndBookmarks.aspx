<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HyperlinksAndBookmarks.aspx.vb" Inherits="EditingFeatures_HyperlinksAndBookmarks" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxFormLayout ID="FormLayout" runat="server" CssClass="BottomLargeMargin">
		<Items>
			<dx:LayoutGroup Caption="Bookmarks" ColCount="2">
				<Items>
					<dx:LayoutItem Caption="Show bookmarks">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="chShowBookmarks" runat="server" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Bookmark color">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxColorEdit ID="ColorEdit" runat="server" AutoPostBack="true" Color="Blue"></dx:ASPxColorEdit>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
		</Items>
	</dx:ASPxFormLayout>
	<dx:ASPxRichEdit ID="DemoRichEdit" runat="server" Width="100%" Height="700px"
		ActiveTabIndex="0" ShowConfirmOnLosingChanges="false" OnPreRender="DemoRichEdit_PreRender">
	</dx:ASPxRichEdit>
</asp:Content>
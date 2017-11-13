<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Columns.aspx.vb" Inherits="FormLayout_Columns" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxFormLayout ID="formLayout" runat="server">
		<Items>
			<dx:LayoutGroup Caption="Group (ColCount=3)" ColCount="3" SettingsItemCaptions-Location="Top">
				<Items>
					<dx:LayoutItem Caption="Text Box 1">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxTextBox runat="server" Width="170" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Text Box 2">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxTextBox runat="server" Width="170" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Text Box 3">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxTextBox runat="server" Width="170" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Memo" ColSpan="3" HelpText="ColSpan=3">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer runat="server">
								<dx:ASPxMemo runat="server" Width="100%" Rows="4" />                                
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
		</Items>
	</dx:ASPxFormLayout>
</asp:Content>
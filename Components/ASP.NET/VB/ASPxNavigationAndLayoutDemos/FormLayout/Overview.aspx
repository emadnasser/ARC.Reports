<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"%>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" CssClass="layoutGroupBoxCaption">
		<Items>
			<dx:LayoutGroup Caption="Employees" Width="540px" >
				<Items>
					<dx:LayoutItem Caption="First Name">
						<LayoutItemNestedControlCollection >
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Text="Nancy" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Last Name">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer >
								<dx:ASPxTextBox ID="ASPxTextBox2" runat="server" Text="Davolio" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Note">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer >
								<dx:ASPxMemo ID="ASPxMemo1" runat="server" Width="100%" Text="Education includes a BA in psychology from Colorado State University in 1970. She also completed 'The Art of the Cold Call'. Nancy is a member of Toastmasters International." /> 
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
		</Items>
	</dx:ASPxFormLayout>
</asp:Content>
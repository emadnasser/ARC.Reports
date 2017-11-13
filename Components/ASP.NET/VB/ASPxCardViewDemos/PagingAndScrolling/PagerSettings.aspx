<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PagerSettings.aspx.vb" Inherits="PagingAndScrolling_PagerSettings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxFormLayout ID="Details" ClientInstanceName="Details" runat="server" ColCount="2">
		<Items>
			<dx:LayoutItem Caption="Position">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer runat="server">
						<dx:ASPxComboBox ID="Position" runat="server" AutoPostBack="true" SelectedIndex="2">
							<Items>
								<dx:ListEditItem Value="Bottom" Text="Bottom" />
								<dx:ListEditItem Value="Top" Text="Top" />
								<dx:ListEditItem Value="TopAndBottom" Text="TopAndBottom" /> 
							</Items>
						</dx:ASPxComboBox>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutItem Caption="ShowDisabledButtons">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer runat="server">
						<dx:ASPxCheckBox ID="ShowDisabledButtons" runat="server" AutoPostBack="true" Checked="true" />
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutItem Caption="PageSizeItem position">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer runat="server">
						<dx:ASPxComboBox ID="PageSizePosition" runat="server" AutoPostBack="true" SelectedIndex="1">
							<Items>
								<dx:ListEditItem Value="Left" Text="Left" />
								<dx:ListEditItem Value="Right" Text="Right" />
							</Items>
						</dx:ASPxComboBox>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutItem Caption="ShowNumericButtons">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer runat="server">
						<dx:ASPxCheckBox ID="ShowNumericButtons" runat="server" AutoPostBack="true" Checked="true" />
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutItem Caption="Show PageSizeItem">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer runat="server">
						<dx:ASPxCheckBox ID="ShowPageSizeItems" runat="server" Checked="true" AutoPostBack="true" />
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutItem Caption="ShowSeparators">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer runat="server">
						<dx:ASPxCheckBox ID="ShowSeparators" runat="server" AutoPostBack="true" Checked="true" />
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutItem Caption="Show Summary">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer runat="server">
						<dx:ASPxCheckBox ID="ShowSummary" runat="server" AutoPostBack="true" />
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
		</Items>
	</dx:ASPxFormLayout>
	<dx:ASPxCardView ID="CardView" runat="server" DataSourceID="CustomersDataSource" Width="100%">
		<Columns>
			<dx:CardViewColumn FieldName="ContactName" />
			<dx:CardViewColumn FieldName="CompanyName" />
			<dx:CardViewColumn FieldName="City" />
			<dx:CardViewColumn FieldName="Region" SortOrder="Ascending" />
			<dx:CardViewColumn FieldName="Country" />
		</Columns>
	</dx:ASPxCardView>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>
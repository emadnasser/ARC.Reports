<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="Bands.aspx.vb" Inherits="Columns_Bands" %>
<asp:Content id="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxGridView ID="Grid" runat="server" AutoGenerateColumns="false" KeyFieldName="OrderID" 
		DataSourceID="InvoicesDataSource" Width="100%">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="Salesperson" Caption="Sales Person" />
			<dx:GridViewBandColumn Caption="Order">
				<Columns>
					<dx:GridViewBandColumn Caption="Company">
						<Columns>
							<dx:GridViewDataTextColumn FieldName="CompanyName" Caption="Name" />
							<dx:GridViewDataTextColumn FieldName="Country" />
							<dx:GridViewDataTextColumn FieldName="Region" />
						</Columns>
					</dx:GridViewBandColumn>
					<dx:GridViewDataDateColumn FieldName="OrderDate" Caption="Date" />
					<dx:GridViewBandColumn Caption="Product">
						<Columns>
							<dx:GridViewDataTextColumn FieldName="ProductName" Caption="Name" />
							<dx:GridViewDataTextColumn FieldName="UnitPrice">
								<PropertiesTextEdit DisplayFormatString="c" />    
							</dx:GridViewDataTextColumn>
						</Columns>
					</dx:GridViewBandColumn>
					<dx:GridViewDataTextColumn FieldName="Quantity" Caption="Qty" />
				</Columns>
				<HeaderStyle HorizontalAlign="Center" />
			</dx:GridViewBandColumn>
		</Columns>
		<Settings ShowGroupPanel="true" />
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext"
		CommandText="SELECT c.CompanyName, i.Salesperson, i.Country, i.UnitPrice, i.Region, i.OrderDate, i.ProductName, i.Quantity  FROM Invoices AS i INNER JOIN Customers AS c ON i.CustomerID = c.CustomerId" OrderBy="it.OrderDate">
	</ef:EntityDataSource>
</asp:Content>
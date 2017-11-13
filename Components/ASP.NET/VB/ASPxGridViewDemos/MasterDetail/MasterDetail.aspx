<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MasterDetail.aspx.vb"
	Inherits="MasterDetail_MasterDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCheckBox ID="chkSingleExpanded" runat="server" Text="Keep a single expanded row at a time"
		AutoPostBack="true" OnCheckedChanged="chkSingleExpanded_CheckedChanged" />
	<br />
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
		KeyFieldName="CustomerID" Width="100%">
		<Columns>
			<dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="0" />
			<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="1" />
			<dx:GridViewDataColumn FieldName="City" VisibleIndex="2" />
			<dx:GridViewDataColumn FieldName="Country" VisibleIndex="3" />
		</Columns>
		<Templates>
			<DetailRow>
				Contact Phone: <b>
					<%#Eval("Phone")%></b>, Fax: <b>
						<%#Eval("Fax")%></b>
				<br />
				<br />
				<dx:ASPxGridView ID="detailGrid" runat="server" DataSourceID="InvoicesDataSource" KeyFieldName="OrderID;ProductID"
					Width="100%" OnBeforePerformDataSelect="detailGrid_DataSelect" OnCustomUnboundColumnData="detailGrid_CustomUnboundColumnData">
					<Columns>
						<dx:GridViewDataColumn FieldName="OrderID" Caption="Order Id" VisibleIndex="1" />
						<dx:GridViewDataColumn FieldName="OrderDate" VisibleIndex="2" />
						<dx:GridViewDataColumn FieldName="ShipName" VisibleIndex="2" />
						<dx:GridViewDataColumn FieldName="Quantity" VisibleIndex="5" Name="Quantity" />
						<dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="4">
							<PropertiesTextEdit DisplayFormatString="c" />
						</dx:GridViewDataTextColumn>
						<dx:GridViewDataTextColumn FieldName="Total" VisibleIndex="6" UnboundType="Decimal">
							<PropertiesTextEdit DisplayFormatString="c" />
						</dx:GridViewDataTextColumn>
					</Columns>
					<Settings ShowFooter="True" />
					<TotalSummary>
						<dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" />
						<dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
						<dx:ASPxSummaryItem FieldName="Quantity" SummaryType="Sum" />
					</TotalSummary>                    
				</dx:ASPxGridView>
			</DetailRow>
		</Templates>
		<SettingsDetail ShowDetailRow="true" />
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers"/>
	<ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Invoices" Where="it.CustomerID = @CustomerID">
		<WhereParameters>
			<asp:SessionParameter Name="CustomerID" SessionField="CustomerID" Type="String" />
		</WhereParameters>
	</ef:EntityDataSource>
</asp:Content>
<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Scrolling.aspx.vb"
	Inherits="PagingAndScrolling_Scrolling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<table class="OptionsTable BottomMargin">
		<tr>
			<td style="padding-left: 0">
				<dx:ASPxLabel ID="HorzScrollLabel" runat="server" AssociatedControlID="HorzScrollCombo" 
					Text="Horizontal ScrollBar Mode:" />
			</td>
			<td>
				<dx:ASPxComboBox runat="server" ID="HorzScrollCombo" AutoPostBack="true" />
			</td>
		</tr>
		<tr>
			<td style="padding-left: 0">
				<dx:ASPxLabel ID="VertScrollLabel" runat="server" AssociatedControlID="VertScrollCombo" 
					Text="Vertical ScrollBar Mode:" />
			</td>
			<td>
				<dx:ASPxComboBox runat="server" ID="VertScrollCombo" AutoPostBack="true" />
			</td>
		</tr>
	</table>
	<dx:ASPxGridView ID="Grid" runat="server" AutoGenerateColumns="False" Width="720"
		DataSourceID="OrdersDataSource" KeyFieldName="OrderID">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="OrderID" Width="90" VisibleIndex="0" />
			<dx:GridViewDataTextColumn FieldName="CustomerID" Width="120" VisibleIndex="1" />
			<dx:GridViewDataComboBoxColumn FieldName="EmployeeID" Width="120" VisibleIndex="2">
				<PropertiesComboBox DataSourceID="EmployeesDataSource" ValueType="System.Int32" ValueField="EmployeeID"
					TextField="LastName" />
			</dx:GridViewDataComboBoxColumn>
			<dx:GridViewDataDateColumn FieldName="OrderDate" Width="100" VisibleIndex="3" />
			<dx:GridViewDataDateColumn FieldName="RequiredDate" Width="130" VisibleIndex="4" />
			<dx:GridViewDataDateColumn FieldName="ShippedDate" Width="120" VisibleIndex="5" />
			<dx:GridViewDataTextColumn FieldName="Freight" Width="90" VisibleIndex="7" />
			<dx:GridViewDataTextColumn FieldName="ShipName" Width="200" VisibleIndex="8" />
			<dx:GridViewDataTextColumn FieldName="ShipCity" Width="100" VisibleIndex="9" />
			<dx:GridViewDataTextColumn FieldName="ShipRegion" Width="120" VisibleIndex="10" />
			<dx:GridViewDataTextColumn FieldName="ShipPostalCode" Width="140" VisibleIndex="11" />
			<dx:GridViewDataTextColumn FieldName="ShipCountry" Width="120" VisibleIndex="12" />
		</Columns>
		<Settings VerticalScrollableHeight="300" />
		<SettingsPager PageSize="20">
			<PageSizeItemSettings Visible="true" ShowAllItem="true" />
		</SettingsPager>
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="OrdersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Orders" />
	<ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" Select="it.EmployeeID, it.LastName" />
</asp:Content>
<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="IntervalGrouping.aspx.vb"
	Inherits="GroupingSorting_IntervalGrouping" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxComboBox runat="server" ID="cbGroupInterval" SelectedIndex="0" ValueType="System.String" Caption="Date group interval">
		<RootStyle CssClass="OptionsBottomMargin"></RootStyle>
		<Items>
			<dx:ListEditItem Text="By Year" Value="DateYear" />
			<dx:ListEditItem Text="By Months" Value="DateMonth" />
			<dx:ListEditItem Text="By Date" Value="Date" />
		</Items>
		<ClientSideEvents SelectedIndexChanged="function(s, e) { grid.PerformCallback(s.GetSelectedItem().value) }" />
	</dx:ASPxComboBox>
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="SalesPersonsDataSource"
		KeyFieldName="OrderID" OnCustomUnboundColumnData="grid_CustomUnboundColumnData"
		Width="100%" AutoGenerateColumns="False" OnCustomCallback="grid_CustomCallback">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="ProductName" VisibleIndex="0" />
			<dx:GridViewDataTextColumn FieldName="CategoryName" VisibleIndex="1" />
			<dx:GridViewDataTextColumn FieldName="Country" VisibleIndex="2" />
			<dx:GridViewDataDateColumn FieldName="OrderDate" VisibleIndex="3" GroupIndex="0">
				<Settings GroupInterval="DateYear" />
			</dx:GridViewDataDateColumn>
			<dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="4">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
			<dx:GridViewDataTextColumn FieldName="Quantity" VisibleIndex="5" />
			<dx:GridViewDataTextColumn FieldName="Total" VisibleIndex="6" UnboundType="Decimal">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
		</Columns>
		<TotalSummary>
			<dx:ASPxSummaryItem FieldName="Country" SummaryType="Count" />
			<dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
		</TotalSummary>
		<Settings ShowGroupPanel="True" ShowFooter="True" />
		<GroupSummary>
			<dx:ASPxSummaryItem FieldName="Country" SummaryType="Count" />
			<dx:ASPxSummaryItem FieldName="Quantity" SummaryType="Sum" />
			<dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
		</GroupSummary>
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons"/>
</asp:Content>
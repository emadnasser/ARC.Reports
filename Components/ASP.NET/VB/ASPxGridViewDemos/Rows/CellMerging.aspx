<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CellMerging.aspx.vb"
	Inherits="Rows_CellMerging" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="Grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
		KeyFieldName="CustomerID" Width="100%" OnHtmlDataCellPrepared="Grid_HtmlDataCellPrepared">
		<Columns>
			<dx:GridViewDataColumn FieldName="Country" SortOrder="Ascending" SortIndex="0" />
			<dx:GridViewDataColumn FieldName="City" />
			<dx:GridViewDataColumn FieldName="ContactName" />
			<dx:GridViewDataColumn FieldName="ContactTitle" Caption="Position" SortOrder="Ascending" SortIndex="1">
				<DataItemTemplate>
					<dx:ASPxImage ID="PositionIcon" runat="server" EmptyImage-IconID="businessobjects_boorder_16x16">
						<CaptionSettings ShowColon="false" Position="Right" />
					</dx:ASPxImage>
				</DataItemTemplate>
			</dx:GridViewDataColumn>
		</Columns>
		<SettingsBehavior AllowCellMerge="true" />
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>
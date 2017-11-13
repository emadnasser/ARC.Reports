<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Sorting.aspx.vb" Inherits="Sorting_Sorting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxVerticalGrid runat="server" ID="VerticalGrid" DataSourceID="HeadphonesDataSource" Width="100%">
		<Rows>
			<dx:VerticalGridImageRow FieldName="PhotoUrl" Caption="Photo">
				<PropertiesImage ImageHeight="180" />
			</dx:VerticalGridImageRow>
			<dx:VerticalGridDataRow FieldName="Brand" RecordStyle-HorizontalAlign="Center" />
			<dx:VerticalGridDataRow FieldName="Model" RecordStyle-HorizontalAlign="Center" />
			<dx:VerticalGridCategoryRow Caption="Pricing">
				<Rows>
					<dx:VerticalGridTextRow FieldName="Price">
						<PropertiesTextEdit DisplayFormatString="c" />
					</dx:VerticalGridTextRow>
					<dx:VerticalGridTextRow FieldName="Discount" SortOrder="Descending">
						<RecordStyle ForeColor="Red" />
						<PropertiesTextEdit DisplayFormatString="{0}%" />
					</dx:VerticalGridTextRow>
					<dx:VerticalGridTextRow FieldName="Total" UnboundType="Decimal" UnboundExpression="[Price]- [Price] * [Discount] / 100">
						<RecordStyle Font-Bold="true" />
						<PropertiesTextEdit DisplayFormatString="c" />
					</dx:VerticalGridTextRow>
				</Rows>
			</dx:VerticalGridCategoryRow>
			<dx:VerticalGridCategoryRow Caption="Specifications">
				<Rows>
					<dx:VerticalGridTextRow FieldName="Sensitivity" Caption="Sensitivity, dB" />
					<dx:VerticalGridTextRow FieldName="Power" Caption="Power, MW" />
					<dx:VerticalGridCheckRow FieldName="Wireless" />
				</Rows>
			</dx:VerticalGridCategoryRow>
		</Rows>
		<Settings ShowCategoryIndents="false" HeaderAreaWidth="150" RecordWidth="200" HorizontalScrollBarMode="Visible" />
	</dx:ASPxVerticalGrid>
	<asp:ObjectDataSource ID="HeadphonesDataSource" runat="server" SelectMethod="SelectHeadphones" TypeName="HeadphonesDataProvider" />
</asp:Content>
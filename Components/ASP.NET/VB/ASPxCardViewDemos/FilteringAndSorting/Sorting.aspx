<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Sorting.aspx.vb" Inherits="Sorting_Sorting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCardView ID="ASPxCardView1" runat="server" DataSourceID="HomesDataSource" EnableCardsCache="false" Width="100%">
		<Columns>
			<dx:CardViewColumn FieldName="Address" Settings-AllowSort="False" />
			<dx:CardViewColumn FieldName="Baths" />
			<dx:CardViewColumn FieldName="Beds" />
			<dx:CardViewColumn FieldName="HouseSize" />
			<dx:CardViewTextColumn FieldName="Price" SortOrder="Ascending">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:CardViewTextColumn>
			<dx:CardViewImageColumn FieldName="PhotoUrl" Settings-AllowSort="False">
				<PropertiesImage ImageWidth="250" />
			</dx:CardViewImageColumn>
		</Columns>
		<CardLayoutProperties ColCount="2">
			<Items>
				<dx:CardViewColumnLayoutItem ColumnName="PhotoUrl" ShowCaption="False" ColSpan="2" VerticalAlign="Top" HorizontalAlign="Center" />
				<dx:CardViewColumnLayoutItem ColumnName="Address" ColSpan="2" HorizontalAlign="Center" ShowCaption="False" >
					<ParentContainerStyle Font-Bold="true" />
				</dx:CardViewColumnLayoutItem>
				<dx:EmptyLayoutItem ColSpan="2" Height="5"/>
				<dx:CardViewColumnLayoutItem ColumnName="Baths" />
				<dx:CardViewColumnLayoutItem ColumnName="Beds" />
				<dx:CardViewColumnLayoutItem ColumnName="HouseSize" />
				<dx:CardViewColumnLayoutItem ColumnName="Price" />
			</Items>
		</CardLayoutProperties>
		<Settings ShowHeaderPanel="true" />
		<SettingsPager SettingsTableLayout-ColumnCount="3" SettingsTableLayout-RowsPerPage="2" />
	</dx:ASPxCardView>
	<asp:ObjectDataSource ID="HomesDataSource" runat="server" SelectMethod="SelectHomes" TypeName="HomesDataProvider" />
</asp:Content>
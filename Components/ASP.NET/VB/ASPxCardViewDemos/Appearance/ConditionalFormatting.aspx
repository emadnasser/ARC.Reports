<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConditionalFormatting.aspx.vb" Inherits="Cards_ConditionalFormatting" %>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="CustomHeadHolder">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCardView ID="CardView" runat="server" DataSourceID="HomesDataSource" EnableCardsCache="false" Width="100%">
		<Columns>
			<dx:CardViewColumn FieldName="Address" Settings-AllowSort="False" />
			<dx:CardViewColumn FieldName="Baths" />
			<dx:CardViewColumn FieldName="Beds" />
			<dx:CardViewColumn FieldName="HouseSize" />
			<dx:CardViewTextColumn FieldName="Price">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:CardViewTextColumn>
			<dx:CardViewColumn FieldName="Status" />
			<dx:CardViewImageColumn FieldName="PhotoUrl">
				<PropertiesImage ImageWidth="200" />
			</dx:CardViewImageColumn>
		</Columns>
		<CardLayoutProperties ColCount="2">
			<Items>
				<dx:CardViewColumnLayoutItem ColumnName="PhotoUrl" ShowCaption="False" RowSpan="6" VerticalAlign="Top" />
				<dx:CardViewColumnLayoutItem ColumnName="Baths" />
				<dx:CardViewColumnLayoutItem ColumnName="Beds" />
				<dx:CardViewColumnLayoutItem ColumnName="HouseSize" />
				<dx:CardViewColumnLayoutItem ColumnName="Price" />
				<dx:CardViewColumnLayoutItem ColumnName="Address" />
			</Items>
		</CardLayoutProperties>
		<FormatConditions>
			<dx:CardViewFormatConditionTopBottom Rule="BottomItems" Threshold="10" FieldName="Price" Format="BoldText" />
			<dx:CardViewFormatConditionTopBottom Rule="BottomItems" Threshold="10" FieldName="Price" Format="GreenText" />
			<dx:CardViewFormatConditionTopBottom Rule="TopItems"  Threshold="10" FieldName="Price" Format="BoldText" />
			<dx:CardViewFormatConditionTopBottom Rule="TopItems" Threshold="10" FieldName="Price" Format="RedText" />
			<dx:CardViewFormatConditionIconSet FieldName="Baths" Format="Arrows3Colored" />
			<dx:CardViewFormatConditionIconSet FieldName="Beds" Format="Arrows3Colored" />
			<dx:CardViewFormatConditionTopBottom FieldName="HouseSize" Rule="TopItems" Threshold="5" Format="GreenText" />
			<dx:CardViewFormatConditionTopBottom FieldName="HouseSize" Rule="BottomItems" Threshold="5" Format="RedText" />
		</FormatConditions>
		<Settings ShowHeaderPanel="true" />
		<SettingsPager SettingsTableLayout-ColumnCount="2" />
		<Styles>
			<Card Width="450" />
		</Styles>
	</dx:ASPxCardView>
	<asp:ObjectDataSource ID="HomesDataSource" runat="server" SelectMethod="SelectHomes" TypeName="HomesDataProvider" />
</asp:Content>
<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConditionalFormatting.aspx.vb" Inherits="Rows_ConditionalFormatting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxVerticalGrid ID="VerticalGrid" runat="server" DataSourceID="HomesDataSource"
		Width="800" EnableRecordsCache="False" AutoGenerateRows="false">
		<Rows>
			<dx:VerticalGridImageRow FieldName="PhotoUrl" Caption="Photo">
				<PropertiesImage ImageWidth="200" ImageHeight="132" />
			</dx:VerticalGridImageRow>
			<dx:VerticalGridTextRow FieldName="Price">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:VerticalGridTextRow>
			<dx:VerticalGridCategoryRow Caption="Information">
				<Rows>
					<dx:VerticalGridDataRow FieldName="Address" Settings-AllowSort="False" />
					<dx:VerticalGridDataRow FieldName="Status" />
				</Rows>
			</dx:VerticalGridCategoryRow>
			<dx:VerticalGridCategoryRow Caption="Features">
				<Rows>
					<dx:VerticalGridDataRow FieldName="Baths" />
					<dx:VerticalGridDataRow FieldName="Beds" />
					<dx:VerticalGridDataRow FieldName="HouseSize" />
				</Rows>
			</dx:VerticalGridCategoryRow>
		</Rows>
		<FormatConditions>
			<dx:VerticalGridFormatConditionTopBottom Rule="BottomItems" Threshold="10" FieldName="Price" Format="BoldText" />
			<dx:VerticalGridFormatConditionTopBottom Rule="BottomItems" Threshold="10" FieldName="Price" Format="GreenText" />
			<dx:VerticalGridFormatConditionTopBottom Rule="TopItems" Threshold="10" FieldName="Price" Format="BoldText" />
			<dx:VerticalGridFormatConditionTopBottom Rule="TopItems" Threshold="10" FieldName="Price" Format="RedText" />
			<dx:VerticalGridFormatConditionIconSet FieldName="Baths" Format="Arrows3Colored" />
			<dx:VerticalGridFormatConditionIconSet FieldName="Beds" Format="Arrows3Colored" />
			<dx:VerticalGridFormatConditionTopBottom FieldName="HouseSize" Rule="TopItems" Threshold="5" Format="GreenText" />
			<dx:VerticalGridFormatConditionTopBottom FieldName="HouseSize" Rule="BottomItems" Threshold="5" Format="RedText" />
		</FormatConditions>
		<Settings HorizontalScrollBarMode="Visible" HeaderAreaWidth="150" RecordWidth="220" ShowCategoryIndents="false" />
	</dx:ASPxVerticalGrid>
	<asp:ObjectDataSource ID="HomesDataSource" runat="server" SelectMethod="SelectHomes" TypeName="HomesDataProvider" />
</asp:Content>
<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ExportSelected.aspx.vb" Inherits="Export_ExportSelected" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ToolbarExport runat="server" ID="ToolbarExport" ExportItemTypes="Pdf,Xls,Xlsx,Rtf" IsDataAwareXls="true" IsDataAwareXlsx="true" OnItemClick="ToolbarExport_ItemClick" />
	<table class="OptionsBottomMargin">
		<tr>
			<td style="padding-right: 4px">
				<dx:ASPxButton ID="btnSelectAll" runat="server" Text="Select All" UseSubmitBehavior="False"
					AutoPostBack="false">
					<ClientSideEvents Click="function(s, e) { cardView.SelectCards(); }" />
				</dx:ASPxButton>
			</td>
			<td style="padding-right: 4px">
				<dx:ASPxButton ID="btnUnselectAll" runat="server" Text="Unselect All" UseSubmitBehavior="False"
					AutoPostBack="false">
					<ClientSideEvents Click="function(s, e) { cardView.UnselectCards(); }" />
				</dx:ASPxButton>
			</td>
			<td style="padding-right: 4px">
				<dx:ASPxButton ID="btnSelectAllOnPage" runat="server" Text="Select all on the page"
					UseSubmitBehavior="False" AutoPostBack="false">
					<ClientSideEvents Click="function(s, e) { cardView.SelectAllCardsOnPage(); }" />
				</dx:ASPxButton>
			</td>
			<td>
				<dx:ASPxButton ID="btnUnselectAllOnPage" runat="server" Text="Unselect all on the page"
					UseSubmitBehavior="False" AutoPostBack="false">
					<ClientSideEvents Click="function(s, e) { cardView.UnselectAllCardsOnPage(); }" />
				</dx:ASPxButton>
			</td>
		</tr>
	</table>
	<dx:ASPxCardView ID="cardView" ClientInstanceName="cardView" runat="server" DataSourceID="HomesDataSource" KeyFieldName="ID" EnableCardsCache="false" Width="100%">
		<ClientSideEvents Init="function(s, e) { cardView.SelectAllCardsOnPage(); }"
			SelectionChanged="function(s, e) { MenuExportButtons.SetEnabled(cardView.GetSelectedCardCount() > 0); }" />
		<Columns>
			<dx:CardViewColumn FieldName="Address" />
			<dx:CardViewColumn FieldName="Baths" />
			<dx:CardViewColumn FieldName="Beds" />
			<dx:CardViewColumn FieldName="HouseSize" />
			<dx:CardViewTextColumn FieldName="Price">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:CardViewTextColumn>
			<dx:CardViewColumn FieldName="Status" />
			<dx:CardViewImageColumn FieldName="PhotoUrl">
				<PropertiesImage ImageWidth="200">
					<ExportImageSettings Width="200" Height="133" />
				</PropertiesImage>
			</dx:CardViewImageColumn>
		</Columns>
		<Settings ShowSummaryPanel="true" />
		<CardLayoutProperties ColCount="2">
			<Items>
				<dx:CardViewColumnLayoutItem ColumnName="PhotoUrl" ShowCaption="False" RowSpan="6" />
				<dx:CardViewCommandLayoutItem ShowSelectCheckbox="true" HorizontalAlign="Right" />
				<dx:CardViewColumnLayoutItem ColumnName="Baths" />
				<dx:CardViewColumnLayoutItem ColumnName="Beds" />
				<dx:CardViewColumnLayoutItem ColumnName="HouseSize" />
				<dx:CardViewColumnLayoutItem ColumnName="Price" />
				<dx:CardViewColumnLayoutItem ColumnName="Address" />
			</Items>
		</CardLayoutProperties>
		<SettingsBehavior AllowSelectByCardClick="true" />
		<SettingsPager>
			<SettingsTableLayout ColumnCount="2" RowsPerPage="2" />
		</SettingsPager>
		<Styles>
			<Card Width="450" />
		</Styles>
		<TotalSummary>
			<dx:ASPxCardViewSummaryItem FieldName="Price" SummaryType="Min" ValueDisplayFormat="c0" />
			<dx:ASPxCardViewSummaryItem FieldName="Price" SummaryType="Max" ValueDisplayFormat="c0" />
		</TotalSummary>
	</dx:ASPxCardView>
	<dx:ASPxCardViewExporter ID="cardViewExport" runat="server" CardViewID="cardView" ExportSelectedCardsOnly="true" CardWidth="430" OnRenderBrick="cardViewExport_RenderBrick" />
	<asp:ObjectDataSource ID="HomesDataSource" runat="server" SelectMethod="SelectHomes" TypeName="HomesDataProvider" />
</asp:Content>
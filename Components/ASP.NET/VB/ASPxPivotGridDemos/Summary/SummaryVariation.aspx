<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SummaryVariation.aspx.vb"
	Inherits="SummaryVariationDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable BottomMargin">
		<tr>
			<td colspan="3">
				<dx:ASPxRadioButtonList ID="rgSummaryDisplayTypeGroups" runat="server" AutoPostBack="true"
					RepeatDirection="Horizontal" OnSelectedIndexChanged="rgSummaryDisplayTypeGroups_SelectedIndexChanged"
					border-borderstyle="None" SelectedIndex="0">
					<Items>
						<dx:ListEditItem Value="0" Text="Variation" Selected="True" />
						<dx:ListEditItem Value="1" Text="Percentage" />
						<dx:ListEditItem Value="2" Text="Rank" />
						<dx:ListEditItem Value="3" Text="Index" />
					</Items>
				</dx:ASPxRadioButtonList>
			</td>
		</tr>
		<tr>
			<td>
				Summary Display Type:
			</td>
			<td>
				<dx:ASPxComboBox ID="ddlSummaryDisplayType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSummaryDisplayType_SelectedIndexChanged"
					width="195" />
			</td>
			<td>
				<dx:ASPxCheckBox runat="server" ID="cbHideEmptyVariationItems" Text="Hide Empty Variation Items"
					AutoPostBack="True" OnCheckedChanged="cbHideEmptyVariationItems_CheckedChanged" />
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxCheckBox runat="server" ID="cbShowRawValues" Text="Show Raw Values" AutoPostBack="True"
					OnCheckedChanged="cbShowRawValues_CheckedChanged" />
			</td>
			<td>
			</td>
			<td>
				<dx:ASPxCheckBox runat="server" ID="cbAllowCrossGroupVariation" Text="Allow Cross-Group Variation"
					AutoPostBack="True" OnCheckedChanged="cbAllowCrossGroupVariation_CheckedChanged" />
			</td>
		</tr>
	</table>
	<dx:ASPxPivotGrid ID="pivotGrid" runat="server" width="100%">
		<OptionsView ShowFilterHeaders="false" HorizontalScrollBarMode="Auto" />
		<OptionsFilter NativeCheckBoxes="False" />
	</dx:ASPxPivotGrid>
	<input runat="server" id="cachedSourceDataFieldName" type="hidden" enableviewstate="true" />
	<ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
	<ef:EntityDataSource runat="server" ID="ProductReportsDataSource" ContextTypeName="NorthwindContext" Select="it.ProductName, it.CategoryName, it.ProductSales, it.ShippedDate" EntitySetName="ProductReports" />
</asp:Content>
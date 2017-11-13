<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PagerSettings.aspx.vb"
	Inherits="HorzScrollBar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
		<table class="OptionsTable BottomMargin">
			<tr>
				<td>Position:</td>
				<td>
					<dx:ASPxComboBox ID="ddlPosition" runat="server" AutoPostBack="true" ValueType="System.String" OnSelectedIndexChanged="ddlPosition_SelectedIndexChanged">
					</dx:ASPxComboBox>
				</td>
				<td>ShowDisabledButtons:</td>
				<td>
					<dx:ASPxCheckBox ID="cbShowDisabledButtons" runat="server" AutoPostBack="true" />
				</td>
			</tr>
			<tr>
				<td>PagerAlign:</td>
				<td>
					<dx:ASPxComboBox ID="ddlPagerAlign" runat="server" AutoPostBack="true" ValueType="System.String" OnSelectedIndexChanged="ddlPagerAlign_SelectedIndexChanged">
					</dx:ASPxComboBox>
				</td>
				<td>ShowNumericButtons:</td>
				<td>
					<dx:ASPxCheckBox ID="cbShowNumericButtons" runat="server" AutoPostBack="true" />
				</td>
			</tr>
			<tr>
				<td>PageSizeItemPosition:</td>
				<td>
					<dx:ASPxComboBox ID="ddlPageSizeItemPosition" runat="server" AutoPostBack="true" ValueType="System.String" OnSelectedIndexChanged="ddlPageSizeItemPosition_SelectedIndexChanged">
					</dx:ASPxComboBox>
				</td>
				<td>ShowPageSizeItem:</td>
				<td>
					<dx:ASPxCheckBox ID="cbShowPageSizeItem" runat="server" AutoPostBack="true" />
				</td>
			</tr>
			<tr>
				<td>ShowSeparators:</td>
				<td>
					<dx:ASPxCheckBox ID="cbShowSeparators" runat="server" AutoPostBack="true" />
				</td>
				<td>ShowSummary:</td>
				<td>
					<dx:ASPxCheckBox ID="cbShowSummary" runat="server" AutoPostBack="true" />
				</td>
			</tr>
		</table>
		<br />
		<dx:ASPxPivotGrid ID="pivotGrid" ClientInstanceName="pivotGrid" runat="server" DataSourceID="CustomerReportsDataSource"
			Width="100%" Height="300px" ClientIDMode="AutoID">
			<Fields>
				<dx:PivotGridField ID="fieldCompanyName" Area="RowArea" AreaIndex="0" FieldName="CompanyName" Caption="Company Name">
				</dx:PivotGridField>
				<dx:PivotGridField ID="fieldOrderDate" Area="ColumnArea" AreaIndex="0" FieldName="OrderDate" GroupInterval="DateYear" UnboundFieldName="fieldOrderDate" Caption="Year">
				</dx:PivotGridField>
				<dx:PivotGridField ID="fieldProductAmount" Area="DataArea" AreaIndex="0" FieldName="ProductAmount" Caption="Product Amount">
				</dx:PivotGridField>
				<dx:PivotGridField ID="fieldOrderDate1" AreaIndex="1" FieldName="OrderDate" GroupInterval="DateQuarter" UnboundFieldName="fieldOrderDate1" Caption="Quarter">
				</dx:PivotGridField>
				<dx:PivotGridField ID="fieldProductName1" AreaIndex="0" FieldName="ProductName" Caption="Product">
				</dx:PivotGridField>
			</Fields>
			<OptionsPager RowsPerPage="10" ColumnsPerPage="15" AlwaysShowPager="True" >
				<Summary Visible="False" />
				<PageSizeItemSettings Visible="True">
				</PageSizeItemSettings>
			</OptionsPager>
		</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="CustomerReportsDataSource" ContextTypeName="NorthwindContext" EntitySetName="CustomerReports" />
</asp:Content>
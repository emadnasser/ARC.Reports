<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="IncrementalFiltering.aspx.vb"
	Inherits="ASPxComboBox_IncrementalFiltering" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		td.param
		{
			padding-top: 5px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" runat="Server" ContentPlaceHolderID="ContentHolder">
	<div style="float: left; width: 100%">
		<div style="float: left; width: 200px">
			<dx:ASPxComboBox ID="ASPxComboBox1" runat="server" DropDownStyle="DropDownList" DataSourceID="CategoriesDataSource"
				ValueField="CategoryID" ValueType="System.String" TextFormatString="{0} ({1})" Width="100%">
				<Columns>
					<dx:ListBoxColumn FieldName="CategoryName" Width="100px" />
					<dx:ListBoxColumn FieldName="Description" Width="300px" />
				</Columns>
			</dx:ASPxComboBox>
		</div>
		<div style="float: left; margin-left: 2%">
			<div>
				IncrementalFilteringMode = Contains
			</div>
			<div class="TopPadding">
				DropDownStyle = DropDownList
			</div>
		</div>
	</div>
	<div style="float: left; width: 100%; clear: both; margin-top: 32px">
		<div style="float: left; width: 200px">
			<dx:ASPxComboBox ID="ASPxComboBox2" runat="server" DropDownStyle="DropDown" IncrementalFilteringMode="StartsWith"
				DataSourceID="ProductsDataSource" TextField="ProductName" ValueField="ProductName"
				Width="100%" />
		</div>
		<div style="float: left; margin-left: 2%">
			<div>
				IncrementalFilteringMode = StartsWith
			</div>
			<div class="TopPadding">
				DropDownStyle = DropDown
			</div>
		</div>
	</div>
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" />
	<ef:EntityDataSource runat="server" ID="ProductsDataSource" ContextTypeName="NorthwindContext" EntitySetName="Products" OrderBy="it.ProductName" />
</asp:Content>
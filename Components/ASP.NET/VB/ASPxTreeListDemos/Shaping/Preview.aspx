<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Preview.aspx.vb"
	Inherits="Shaping_Preview" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False" DataSourceID="FishDataSource"
		Width="100%" KeyFieldName="ID" ParentFieldName="ParentID" PreviewFieldName="Notes">
		<Columns>
			<dx:TreeListDataColumn Caption="Name" FieldName="Common_Name" VisibleIndex="0" />
			<dx:TreeListDataColumn FieldName="Category" VisibleIndex="1" />
			<dx:TreeListDataColumn Caption="Species Name" FieldName="Species_Name" VisibleIndex="2" />
		</Columns>
		<Settings ShowPreview="True" GridLines="Both" SuppressOuterGridLines="true" />
		<SettingsBehavior ExpandCollapseAction="NodeDblClick" />
		<SettingsPager Mode="ShowPager" PageSize="3" Position="Top" />
		<Border BorderStyle="Solid" />
		<Styles>
			<PagerTopPanel>
				<BorderBottom BorderStyle="Solid" />
			</PagerTopPanel>
		</Styles>
	</dx:ASPxTreeList>
	<ef:EntityDataSource runat="server" ID="FishDataSource" ContextTypeName="FishContext" EntitySetName="BioLives" />
</asp:Content>
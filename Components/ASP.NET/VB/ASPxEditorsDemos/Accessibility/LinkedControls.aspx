<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LinkedControls.aspx.vb"
	Inherits="Accessibility_LinkedControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<script src="<%=Page.ResolveClientUrl("~/Scripts/NotificationBridge.js")%>"></script>
	<link href="../css/LinkedControlsStyles.css" rel="Stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="CustomTopAreaHolder">
	<dx:SkipRepetitiveNavigationLinksControl ID="SkipRepetitiveNavigationLinksControl1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div role="application" aria-labelledby="par1">
		<p id="par1" class="BottomLargeMargin">
			To try the demo, run a screen reader (<a href="http://www.nvaccess.org/" target="_blank">NVDA</a> or <a href="http://www.freedomscientific.com/Products/Blindness/JAWS" target="_blank">JAWS</a> only),
			and click items within the <b>Categories</b> list box. Corresponding products will appear in the <b>Accepted products</b> grid.
			The screen reader will pronounce any changes in the <b>Categories</b> list box and the <b>Accepted products</b> grid.
		</p>
	</div>
	<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" SettingsItemCaptions-Location="Top" ColCount="3">
		<Styles>
			<LayoutGroup>
				<Cell CssClass="layoutItemCell" />
			</LayoutGroup>
		</Styles>
		<Items>
			<dx:LayoutItem Caption="Categories">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer>
						<div class="dxAIFE" tabindex="0">main content</div>
						<dx:ASPxListBox ID="lbCategories" runat="server" ClientInstanceName="lbCategories" CssClass="lbCategories" SelectionMode="CheckColumn"
							DataSourceID="CategoriesDataSource" ValueField="CategoryID" ValueType="System.Int32" TextField="CategoryName" AccessibilityCompliant="true">
							<ClientSideEvents SelectedIndexChanged="PerformSelection" />
						</dx:ASPxListBox>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutItem Caption="Accepted products" Width="320px">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer>
						<dx:ASPxGridView ID="gvProducts" runat="server" ClientInstanceName="gvProducts" CssClass="gvProducts" 
							KeyFieldName="ProductID" AccessibilityCompliant="true">
							<Columns>
								<dx:GridViewCommandColumn ShowSelectCheckbox="True" SelectAllCheckboxMode="Page" Width="30px" />
								<dx:GridViewDataColumn FieldName="ProductID" />
								<dx:GridViewDataColumn FieldName="ProductName" />
							</Columns>
							<ClientSideEvents EndCallback="OnEndCallback" />
						</dx:ASPxGridView>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
		</Items>
	</dx:ASPxFormLayout>
	<dx:AccessibilityValidatorLink ID="ValidatorLink" runat="server" />
	<ef:EntityDataSource runat="server" ID="ProductsDataSource" ContextTypeName="NorthwindContext" EntitySetName="Products" />
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" />
</asp:Content>
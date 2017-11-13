<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Selection.aspx.vb"
	Inherits="Selection_Selection" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function grid_SelectionChanged(s,e) {
			s.GetSelectedFieldValues("ContactName",GetSelectedFieldValuesCallback);
		}
		function GetSelectedFieldValuesCallback(values) {
			selList.BeginUpdate();
			try {
				selList.ClearItems();
				for(var i=0;i<values.length;i++) {
					selList.AddItem(values[i]);
				}
			} finally {
				selList.EndUpdate();
			}
			document.getElementById("selCount").innerHTML=grid.GetSelectedRowCount();
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="float: left; width: 20%">
		<div class="BottomPadding">
			Selected values:
		</div>
		<dx:ASPxListBox ID="ASPxListBox1" ClientInstanceName="selList" runat="server" Height="250px"
			Width="100%" />
		<div class="TopPadding">
			Selected count: <span id="selCount" style="font-weight: bold">0</span>
		</div>
	</div>
	<div style="float: right; width: 78%">
		<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
			KeyFieldName="CustomerID" Width="100%">
			<Columns>
				<dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0">
				</dx:GridViewCommandColumn>
				<dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="1" />
				<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" />
				<dx:GridViewDataColumn FieldName="City" VisibleIndex="3" />
				<dx:GridViewDataColumn FieldName="Region" VisibleIndex="4" />
				<dx:GridViewDataColumn FieldName="Country" VisibleIndex="5" />
			</Columns>
			<ClientSideEvents SelectionChanged="grid_SelectionChanged" />
		</dx:ASPxGridView>
	</div>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>
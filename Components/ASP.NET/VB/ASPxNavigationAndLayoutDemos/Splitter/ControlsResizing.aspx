<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ControlsResizing.aspx.vb"
	Inherits="Splitter_ControlsResizing" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		#editorsTable
		{
			margin: 2px;
			border-collapse: separate;
			border-spacing: 4px;
		}
		.metropolisPane
		{
			border: 1px solid #c0c0c0!important;
		}
		.youthfulPane
		{
			border: 1px solid #d3e4a6!important;
		}
	</style>
	<%--start highlighted block--%>
	<script type="text/javascript">
		function OnSplitterPaneResized(s, e) {
			var name = e.pane.name;
			if(name == 'listBoxContainer')
				ResizeControl(sampleListBox, e.pane);
			else if(name == 'gridContainer')
				ResizeControl(sampleGrid, e.pane);
			else if(name == 'editorsContainer')
				ResizeEditors(e.pane);
		}
		function ResizeControl(control, splitterPane) {
			control.SetWidth(splitterPane.GetClientWidth());
			control.SetHeight(splitterPane.GetClientHeight());
		}
		function ResizeEditors(splitterPane) {
			SetEditorsSize(1, 1);
			var memoTD = document.getElementById('memoCell');
			var memoHeight = memoTD.clientHeight + splitterPane.GetClientHeight() - document.getElementById('editorsTable').offsetHeight - 4;
			SetEditorsSize(memoTD.clientWidth, memoHeight);
		}
		function SetEditorsSize(width, height) {
			textBoxContactName.SetWidth(width);
			textBoxCompanyName.SetWidth(width);
			memoStuff.SetWidth(width);
			memoStuff.SetHeight(height);
		}
		function OnGridEndCallback() {
			sampleSplitter.GetPaneByName("gridContainer").RaiseResizedEvent();
		}
		function OnGetRowValues(values) {
			textBoxContactName.SetText(values[0]);
			textBoxCompanyName.SetText(values[1]);
			var memoText = '';
			if(values[2] != null) memoText += 'City: ' + values[2] + '\n';
			if(values[3] != null) memoText += 'Address: ' + values[3] + '\n';
			if(values[4] != null) memoText += 'Phone: ' + values[4] + '\n';
			if(values[5] != null) memoText += 'Fax: ' + values[5] + '\n';
			memoStuff.SetText(memoText);
		}
		function UpdateEditorsValues() {
			sampleGrid.GetRowValues(sampleGrid.GetFocusedRowIndex(), 'ContactName;CompanyName;City;Address;Phone;Fax', OnGetRowValues);
		}
		var updateEditorsOnEndCallback = false;
		function OnListBoxValueChanged() {
			sampleGrid.Refresh();
			updateEditorsOnEndCallback = true;
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxSplitter ID="ASPxSplitter1" runat="server" Height="400px" Width="100%" ClientInstanceName="sampleSplitter">
		<Styles>
			<Pane>
				<Paddings Padding="0px" />
			</Pane>
		</Styles>
		<Panes>
			<dx:SplitterPane Size="20%" Name="listBoxContainer" ShowCollapseBackwardButton="True">
				<ContentCollection>
					<dx:SplitterContentControl runat="server">
						<dx:ASPxListBox runat="server" ID="ASPxListBox1" ClientInstanceName="sampleListBox"
							DataSourceID="EmployeesDataSource" TextField="Name" ValueField="EmployeeID" ValueType="System.Int32"
							SelectedIndex="0" Height="100%">
							<Border BorderWidth="0px" />
							<ClientSideEvents ValueChanged="OnListBoxValueChanged" />
						</dx:ASPxListBox>
					</dx:SplitterContentControl>
				</ContentCollection>
			</dx:SplitterPane>
			<dx:SplitterPane MinSize="350px">
				<Panes>
					<dx:SplitterPane Name="gridContainer" Size="60%" MinSize="100px">
						<ContentCollection>
							<dx:SplitterContentControl runat="server">
								<dx:ASPxGridView runat="server" Width="100%" ID="ASPxGridView1" ClientInstanceName="sampleGrid"
									AutoGenerateColumns="False" DataSourceID="OrdersDataSource" KeyFieldName="OrderID">
									<Settings VerticalScrollBarMode="Visible" VerticalScrollableHeight="100" />
									<border borderwidth="0px"></border>
									<columns>
										<dx:GridViewDataTextColumn FieldName="OrderID" VisibleIndex="0">
											<EditFormSettings Visible="False" />
										</dx:GridViewDataTextColumn>
										<dx:GridViewDataTextColumn FieldName="ShipName" VisibleIndex="1" Width="200px">
										</dx:GridViewDataTextColumn>
										<dx:GridViewDataTextColumn FieldName="Quantity" VisibleIndex="2">
										</dx:GridViewDataTextColumn>
										<dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="3">
											<PropertiesTextEdit DisplayFormatString="c" />
										</dx:GridViewDataTextColumn>
										<dx:GridViewDataTextColumn FieldName="ContactName" Visible="False">
										</dx:GridViewDataTextColumn>
										<dx:GridViewDataTextColumn FieldName="CompanyName" Visible="False">
										</dx:GridViewDataTextColumn>
										<dx:GridViewDataTextColumn FieldName="City" Visible="False">
										</dx:GridViewDataTextColumn>
										<dx:GridViewDataTextColumn FieldName="Address" Visible="False">
										</dx:GridViewDataTextColumn>
										<dx:GridViewDataTextColumn FieldName="Phone" Visible="False">
										</dx:GridViewDataTextColumn>
										<dx:GridViewDataTextColumn FieldName="Fax" Visible="False">
										</dx:GridViewDataTextColumn>
									</columns>
									<settingsbehavior allowfocusedrow="True" />
									<settingspager Mode="ShowAllRecords" />
									<clientsideevents endcallback="function(s, e) {
										OnGridEndCallback();
										if(updateEditorsOnEndCallback) {
											updateEditorsOnEndCallback = false;
											UpdateEditorsValues();
										}
									}" focusedrowchanged="UpdateEditorsValues" />
								</dx:ASPxGridView>
							</dx:SplitterContentControl>
						</ContentCollection>
					</dx:SplitterPane>
					<dx:SplitterPane Name="editorsContainer" MinSize="100px" ShowCollapseForwardButton="True">
						<ContentCollection>
							<dx:SplitterContentControl runat="server">
								<table id="editorsTable">
									<tr>
										<td style="white-space: nowrap">
											<dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Customer name:">
											</dx:ASPxLabel>
										</td>
										<td style="width: 100%">
											<dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="170px" ClientInstanceName="textBoxContactName">
											</dx:ASPxTextBox>
										</td>
									</tr>
									<tr>
										<td style="white-space: nowrap">
											<dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Company name:">
											</dx:ASPxLabel>
										</td>
										<td>
											<dx:ASPxTextBox ID="ASPxTextBox2" runat="server" Width="170px" ClientInstanceName="textBoxCompanyName">
											</dx:ASPxTextBox>
										</td>
									</tr>
									<tr>
										<td style="vertical-align: text-top; white-space: nowrap; padding-top: 2px;">
											<dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Contacts:">
											</dx:ASPxLabel>
										</td>
										<td id="memoCell">
											<dx:ASPxMemo ID="ASPxMemo1" runat="server" Height="71px" Width="170px" ClientInstanceName="memoStuff">
											</dx:ASPxMemo>
										</td>
									</tr>
								</table>
							</dx:SplitterContentControl>
						</ContentCollection>
					</dx:SplitterPane>
				</Panes>
			</dx:SplitterPane>
		</Panes>
		<ClientSideEvents PaneResized="OnSplitterPaneResized" />
	</dx:ASPxSplitter>
	<ef:EntityDataSource ID="EmployeesDataSource" runat="server" ContextTypeName="NorthwindContext" 
		CommandText="SELECT e.EmployeeID, e.LastName + ' ' + e.FirstName AS Name FROM Employees as e" />
	<ef:EntityDataSource ID="OrdersDataSource" runat="server" ContextTypeName="NorthwindContext"
		CommandText="SELECT O.OrderID, O.ShipName, OD.Quantity, OD.UnitPrice, C.ContactName, C.CompanyName, C.City, C.Address, C.Phone, C.Fax FROM Orders AS O INNER JOIN OrderDetails AS OD ON O.OrderID = OD.OrderID INNER JOIN Customers AS C ON O.CustomerID = C.CustomerID WHERE O.EmployeeID = @EmployeeID">
		<CommandParameters>
			<asp:ControlParameter ControlID="ASPxSplitter1$ASPxListBox1" Name="EmployeeID" PropertyName="Value" Type="Int32" />
		</CommandParameters>
	</ef:EntityDataSource>
</asp:Content>
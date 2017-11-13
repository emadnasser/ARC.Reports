<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UpdatePanel.aspx.vb"
	Inherits="MSAjax_UpdatePanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<asp:ScriptManager ID="ScriptManager" runat="server" />
	<asp:UpdatePanel ID="UpdatePanel" runat="server">
		<contenttemplate>
			Country: <asp:DropDownList runat="server" ID="cbCountry" DataSourceID="CountriesDataSource" DataTextField="Country" AutoPostBack="true" OnSelectedIndexChanged="cbCountry_SelectedIndexChanged"></asp:DropDownList>
			Year: <asp:DropDownList runat="server" ID="cbYear" AutoPostBack="true" OnSelectedIndexChanged="cbYear_SelectedIndexChanged">
						<asp:ListItem Value="All" Selected="True"></asp:ListItem>
						<asp:ListItem Value="1994"></asp:ListItem>
						<asp:ListItem Value="1995"></asp:ListItem>
						<asp:ListItem Value="1996"></asp:ListItem>
				  </asp:DropDownList>
			Total for selected invoices: <%=GetSelectedAmount()%>
			<br/><br/>
			<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="OrdersDataSource" KeyFieldName="OrderID" 
				OnCustomUnboundColumnData="grid_CustomUnboundColumnData" Width="100%" AutoGenerateColumns="False" EnableCallBacks="False">
				<Columns>
					<dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" ></dx:GridViewCommandColumn>
					<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="1" />
					<dx:GridViewDataColumn FieldName="City" VisibleIndex="2" />
					<dx:GridViewDataColumn FieldName="Region" VisibleIndex="3" />
					<dx:GridViewDataColumn FieldName="OrderDate" VisibleIndex="4" />
					<dx:GridViewDataTextColumn FieldName="Total" VisibleIndex="7" UnboundType="Decimal">
						<FooterCellStyle ForeColor="Brown" />
						<PropertiesTextEdit DisplayFormatString="c" />
					</dx:GridViewDataTextColumn>
				</Columns>
				<Settings ShowGroupPanel="True" ShowFooter="True" />
				<SettingsBehavior ProcessSelectionChangedOnServer="True" />
				<TotalSummary>
					<dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count"/>
					<dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
				</TotalSummary>
			</dx:ASPxGridView>
			<br />
			<asp:UpdateProgress runat="server" ID="UpdateProgress" AssociatedUpdatePanelID="UpdatePanel" DisplayAfter="0" DynamicLayout="false">
				<ProgressTemplate>                    
					<img alt="In progress..." src="Images/progress.gif" />
				</ProgressTemplate>
			</asp:UpdateProgress>
		</contenttemplate>
	</asp:UpdatePanel>
	<ef:EntityDataSource runat="server" ID="OrdersDataSource" ContextTypeName="NorthwindContext" 
		CommandText="SELECT o.OrderID, o.OrderDate, o.ShipName as CompanyName, o.ShipCity as City, o.ShipRegion as Region, o.ShipCountry as Country,  Sum(d.Quantity * CAST(d.UnitPrice as System.Double) * (1 - d.Discount)) as Total From Orders AS o INNER JOIN OrderDetails AS d ON o.OrderID = d.OrderID WHERE o.ShipCountry=@Country and (Year(o.OrderDate) = @Year or @AllYears) Group By o.OrderID, o.OrderDate, o.ShipName, o.ShipCity, o.ShipRegion, o.ShipCountry">
		<CommandParameters>
			<asp:SessionParameter Name="Country" SessionField="Country" Type="String" DefaultValue="Argentina" />
			<asp:SessionParameter Name="Year" SessionField="Year" Type="int32" DefaultValue="1995" />
			<asp:SessionParameter Name="AllYears" SessionField="AllYears" Type="boolean" DefaultValue="true" />
		</CommandParameters>
	</ef:EntityDataSource>
	<ef:EntityDataSource runat="server" ID="CountriesDataSource" ContextTypeName="NorthwindContext" Select="DISTINCT it.Country" OrderBy="it.Country" EntitySetName="Invoices" />
</asp:Content>
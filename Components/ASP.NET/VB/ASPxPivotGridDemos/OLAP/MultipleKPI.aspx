<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MultipleKPI.aspx.vb"
	Inherits="OLAP_MultipleKPI" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" Visible="False"
		OLAPConnectionString="<%$ ConnectionStrings:AdventureWorksCubeFileConnection %>" >
		<OptionsFilter NativeCheckBoxes="False" />
	</dx:ASPxPivotGrid>
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="200px" Visible="False">
		<PanelCollection>
			<dx:PanelContent runat="server" _designerRegion="0" />
		</PanelCollection>
		<HeaderTemplate>
			<table style="width: 520px;">
				<tr>
					<th style="width: 200px;">
						KPI Name
					</th>
					<th style="width: 110px; text-align: center;">
						Value
					</th>
					<th style="width: 110px; text-align: center;">
						Goal
					</th>
					<th style="width: 50px; text-align: center;">
						Status
					</th>
					<th style="width: 50px; text-align: center;">
						Trend
					</th>
				</tr>
			</table>
		</HeaderTemplate>
	</dx:ASPxRoundPanel>
</asp:Content>
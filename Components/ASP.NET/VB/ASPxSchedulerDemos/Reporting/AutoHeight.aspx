<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AutoHeight.aspx.vb"
	Inherits="Reporting_AutoHeight" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<demo:ReportsDataSource runat="server" ID="ReportsDataSource1" />
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Auto Height Options" Theme="Metropolis"
		Height="70px">
		<PanelCollection>
			<dx:PanelContent runat="server">
				<table class="OptionsTable">
					<tr>
						<td>
							<dx:ASPxLabel ID="lblView" runat="server" Text="View:" AssociatedControlID="rbView" Theme="Metropolis" />
						</td>
						<td>
							<dx:ASPxRadioButtonList runat="server" ItemSpacing="2px" TextWrap="False" RepeatDirection="Horizontal" Theme="Metropolis"
								ValueType="System.Int32" SelectedIndex="1" EnableClientSideAPI="True" Width="40px"
								ID="rbView">
								<Paddings Padding="0px"></Paddings>
								<ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }">
								</ClientSideEvents>
								<Items>
									<dx:ListEditItem Text="Month" Value="0" Selected="True"></dx:ListEditItem>
									<dx:ListEditItem Text="Timeline" Value="1"></dx:ListEditItem>
								</Items>
								<Border BorderStyle="None"></Border>
							</dx:ASPxRadioButtonList>
						</td>
					</tr>
				</table>
				<table class="OptionsTable">
					<tr>
						<td>
							<dx:ASPxLabel ID="lblHeight" runat="server" Text="Cells Height:" AssociatedControlID="rbView" Theme="Metropolis" />
						</td>
						<td class="edit">
							<dx:ASPxSpinEdit ID="spinHeight" runat="server" MaxValue="300" MinValue="100" Theme="Metropolis"
								Number="100" ValueChangedDelay="100" Increment="10" NumberType="Integer" Width="103px">
								<ClientSideEvents ValueChanged="function(s, e) { ClientReportViewer.Refresh(); }">
								</ClientSideEvents>
							</dx:ASPxSpinEdit>
						</td>
						<td class="edit">
							<dx:ASPxCheckBox ID="chkCanShrink" runat="server" Text="Can Shrink" Wrap="False" Theme="Metropolis">
								<ClientSideEvents CheckedChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
							</dx:ASPxCheckBox>
						</td>
						<td class="edit">
							<dx:ASPxCheckBox ID="chkCanGrow" runat="server" Text="Can Grow" Wrap="False" Layout="Flow" Theme="Metropolis"
								Width="80px">
								<ClientSideEvents CheckedChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
							</dx:ASPxCheckBox>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<br /><br />
	<dx:ReportToolbar ID="ReportToolbar1" runat="server" ReportViewer="<%#ReportViewer%>"
		ShowDefaultButtons="False">
		<Items>
			<dx:ReportToolbarButton ItemKind="PrintReport" ToolTip="Print the report" />
			<dx:ReportToolbarButton ItemKind="PrintPage" ToolTip="Print the current page" />
			<dx:ReportToolbarSeparator />
			<dx:ReportToolbarButton ItemKind="FirstPage" ToolTip="First Page" />
			<dx:ReportToolbarButton ItemKind="PreviousPage" ToolTip="Previous Page" />
			<dx:ReportToolbarLabel ItemKind="PageLabel" />
			<dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
			</dx:ReportToolbarComboBox>
			<dx:ReportToolbarLabel ItemKind="OfLabel"/>
			<dx:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
			<dx:ReportToolbarButton ItemKind="NextPage" ToolTip="Next Page" />
			<dx:ReportToolbarButton ItemKind="LastPage" ToolTip="Last Page" />
			<dx:ReportToolbarSeparator />
			<dx:ReportToolbarButton ItemKind="SaveToDisk" ToolTip="Export a report and save it to the disk" />
			<dx:ReportToolbarButton ItemKind="SaveToWindow" ToolTip="Export a report and show it in a new window" />
			<dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
				<Elements>
					<dx:ListElement Text="Pdf" Value="pdf" />
					<dx:ListElement Text="Mht" Value="mht" />
					<dx:ListElement Text="Image" Value="png" />
				</Elements>
			</dx:ReportToolbarComboBox>
		</Items>
	</dx:ReportToolbar>
	<dx:ReportViewer ID="ReportViewer" runat="server" ClientInstanceName="ClientReportViewer">
	</dx:ReportViewer>
</asp:Content>
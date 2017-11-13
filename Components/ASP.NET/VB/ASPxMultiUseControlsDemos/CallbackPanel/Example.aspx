<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Example.aspx.vb"
	Inherits="CallbackPanel_Example" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		var postponedCallbackRequired = false;
		function OnListBoxIndexChanged(s, e) {
			if(CallbackPanel.InCallback())
				postponedCallbackRequired = true;
			else
				CallbackPanel.PerformCallback();
		}
		function OnEndCallback(s, e) {
			if(postponedCallbackRequired) {
				CallbackPanel.PerformCallback();
				postponedCallbackRequired = false;
			}
		}    
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCheckBox runat="server" ID="cbEnableAnimation" AutoPostBack="true" CssClass="DemoCheckBox OptionsBottomMargin" Text="EnableCallbackAnimation" Checked="True" />
	<div style="float: left; width: 28%">
		<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" HeaderText="Employee" Width="100%">
			<PanelCollection>
				<dx:PanelContent ID="PanelContent1" runat="server">
					<dx:ASPxListBox runat="server" Height="221px" Width="100%" TextField="Name" DataSourceID="EmployeesDataSource1"
						ValueField="EmployeeID" ID="ASPxListBox1" ClientInstanceName="ListBox" BackColor="Transparent">
						<Border BorderWidth="0px"></Border>
						<ItemStyle>
							<Border BorderWidth="0px"></Border>
						</ItemStyle>
						<ClientSideEvents SelectedIndexChanged="OnListBoxIndexChanged" />
					</dx:ASPxListBox>
				</dx:PanelContent>
			</PanelCollection>
		</dx:ASPxRoundPanel>
	</div>
	<div style="float: right; width: 70%">
		<dx:ASPxRoundPanel ID="ASPxRoundPanel2" runat="server" HeaderText="Personal information"
			Width="100%">
			<PanelCollection>
				<dx:PanelContent ID="PanelContent2" runat="server">
					<dx:ASPxCallbackPanel runat="server" ID="ASPxCallbackPanel1" Height="250px" ClientInstanceName="CallbackPanel" RenderMode="Table">
						<ClientSideEvents EndCallback="OnEndCallback"></ClientSideEvents>
						<PanelCollection>
							<dx:PanelContent ID="PanelContent3" runat="server">
								<asp:Repeater runat="server" DataSourceID="EmployeesDataSource2" ID="Repeater1">
									<ItemTemplate>
										<table>
											<tbody>
												<tr>
													<td style="padding-top: 7px; vertical-align: top;">
														<dx:ASPxBinaryImage ID="ASPxBinaryImage1" runat="server" Value='<%#Eval("Photo")%>' Width="160" Height="170">
														</dx:ASPxBinaryImage>
													</td>
													<td>
														<div class="Spacer" style="width: 13px;">
														</div>
													</td>
													<td>
														<table class="OptionsTable" style="border-collapse: separate">
															<tr>
																<td class="dxcp_tCategory">
																	ID:
																</td>
																<td class="dxcp_tInfo">
																	<dx:ASPxLabel ID="EmployeeIDLabel" runat="server" Text='<%#Eval("EmployeeID")%>'>
																	</dx:ASPxLabel>
																</td>
															</tr>
															<tr>
																<td class="dxcp_tCategory">
																	First Name:
																</td>
																<td class="dxcp_tInfo">
																	<dx:ASPxLabel ID="FirstNameLabel" runat="server" Text='<%#Eval("FirstName")%>'>
																	</dx:ASPxLabel>
																</td>
															</tr>
															<tr>
																<td class="dxcp_tCategory">
																	Last Name:
																</td>
																<td class="dxcp_tInfo">
																	<dx:ASPxLabel ID="LastNameLabel" runat="server" Text='<%#Eval("LastName")%>'>
																	</dx:ASPxLabel>
																</td>
															</tr>
															<tr>
																<td class="dxcp_tCategory">
																	Birth Date:
																</td>
																<td class="dxcp_tInfo">
																	<dx:ASPxLabel ID="BirthDateLabel" runat="server" Text='<%#String.Format("{0:d}",Eval("BirthDate"))%>'>
																	</dx:ASPxLabel>
																</td>
															</tr>
															<tr>
																<td class="dxcp_tCategory">
																	City:
																</td>
																<td class="dxcp_tInfo">
																	<dx:ASPxLabel ID="CityLabel" runat="server" Text='<%#Eval("City")%>'>
																	</dx:ASPxLabel>
																</td>
															</tr>
															<tr>
																<td class="dxcp_tCategory">
																	Region:
																</td>
																<td class="dxcp_tInfo">
																	<dx:ASPxLabel ID="RegionLabel" runat="server" Text='<%#Eval("Region")%>'>
																	</dx:ASPxLabel>
																</td>
															</tr>
															<tr>
																<td class="dxcp_tCategory">
																	Notes:
																</td>
																<td class="dxcp_tInfo">
																	<dx:ASPxLabel ID="NotesLabel" runat="server" Text='<%#Eval("Notes")%>'>
																	</dx:ASPxLabel>
																</td>
															</tr>
														</table>
													</td>
												</tr>
											</tbody>
										</table>
									</ItemTemplate>
								</asp:Repeater>
							</dx:PanelContent>
						</PanelCollection>
					</dx:ASPxCallbackPanel>
				</dx:PanelContent>
			</PanelCollection>
		</dx:ASPxRoundPanel>
	</div>
	<ef:EntityDataSource ID="EmployeesDataSource1" runat="server" ContextTypeName="NorthwindContext" EntitySetName="Employees" 
		Select="it.EmployeeID, it.FirstName + ' ' + it.LastName  AS Name" OrderBy="it.Name" />
	<ef:EntityDataSource ID="EmployeesDataSource2" runat="server" ContextTypeName="NorthwindContext" EntitySetName="Employees"
		Where="it.EmployeeID = @EmployeeId">
		<WhereParameters>
			<asp:Parameter DefaultValue="1" Name="EmployeeID" Type="Int32" />
		</WhereParameters>
	</ef:EntityDataSource>
</asp:Content>
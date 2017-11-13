<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MenuEmulation.aspx.vb"
	Inherits="Ribbon_MenuEmulation" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<script type="text/javascript">
		function onCheckBoxCheckedChanged(s, e) {
			document.getElementById("ribbonContainer").style.width = s.GetChecked() ? "430px" : "100%";
			ribbon.AdjustControl();
		}
		function onCheckboxInit(s, e) {
			s.SetChecked(false);
		}
	</script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCheckBox ID="ASPxCheckBox1" runat="server" Text="Demonstrate the ribbon adaptive layout functionality">
		<ClientSideEvents CheckedChanged="onCheckBoxCheckedChanged" Init="onCheckboxInit" />
	</dx:ASPxCheckBox>    
	<br />
	<div id="ribbonContainer">
		<dx:ASPxRibbon ID="ASPxRibbon1" runat="server" ClientInstanceName="ribbon" ShowGroupLabels="false" ShowFileTab="false" ShowTabs="false">
			<Styles>
				<Item Width="100px"></Item>
				<GroupExpandButton Width="100px"></GroupExpandButton>
			</Styles>
			<Tabs>
				<dx:RibbonTab Text="Menu">
					<Groups>
						<dx:RibbonGroup Text="Home">
							<Items>
								<dx:RibbonButtonItem Text="Home" Size="Large" NavigateUrl="javascript:void(1)">
									<LargeImage IconID="navigation_home_32x32"></LargeImage>
								</dx:RibbonButtonItem>
							</Items>
						</dx:RibbonGroup>
						<dx:RibbonGroup Text="Products & Services">
							<Items>
								<dx:RibbonDropDownButtonItem Text="Products" Size="Large" NavigateUrl="javascript:void(2)">
									<LargeImage IconID="support_packageproduct_32x32"></LargeImage>
									<Items>
										<dx:RibbonDropDownButtonItem Text="Grid" NavigateUrl="javascript:void(3)">
											<SmallImage IconID="grid_grid_16x16"></SmallImage>
										</dx:RibbonDropDownButtonItem>
										<dx:RibbonDropDownButtonItem Text="Gauges" NavigateUrl="javascript:void(4)">
											<SmallImage IconID="gauges_gaugestylefullcircular_16x16"></SmallImage>
										</dx:RibbonDropDownButtonItem>
										<dx:RibbonDropDownButtonItem Text="Charting" NavigateUrl="javascript:void(5)">
											<SmallImage IconID="chart_chart_16x16"></SmallImage>
										</dx:RibbonDropDownButtonItem>
										<dx:RibbonDropDownButtonItem Text="Mail Client" NavigateUrl="javascript:void(6)">
											<SmallImage IconID="mail_mail_16x16"></SmallImage>
										</dx:RibbonDropDownButtonItem>
									</Items>
								</dx:RibbonDropDownButtonItem>
								<dx:RibbonButtonItem Text="Services" Size="Large" NavigateUrl="javascript:void(7)">
									<LargeImage IconID="programming_ide_32x32"></LargeImage>
								</dx:RibbonButtonItem>
							</Items>
							<Image IconID="support_version_32x32"></Image>
						</dx:RibbonGroup>
						<dx:RibbonGroup Text="Downloads & Support">
							<Items>
								<dx:RibbonButtonItem Text="Downloads" Size="Large" NavigateUrl="javascript:void(8)">
									<LargeImage IconID="actions_download_32x32"></LargeImage>
								</dx:RibbonButtonItem>
								<dx:RibbonButtonItem Text="Support" Size="Large" NavigateUrl="javascript:void(9)">
									<LargeImage IconID="support_index_32x32"></LargeImage>
								</dx:RibbonButtonItem>
							</Items>
							<Image IconID="save_savedialog_32x32"></Image>
						</dx:RibbonGroup>
						<dx:RibbonGroup Text="My Account">
							<Items>
								<dx:RibbonButtonItem Text="My Account" Size="Large" NavigateUrl="javascript:void(10)">
									<LargeImage IconID="people_customer_32x32"></LargeImage>
								</dx:RibbonButtonItem>
							</Items>
						</dx:RibbonGroup>
					</Groups>
				</dx:RibbonTab>
			</Tabs>
		</dx:ASPxRibbon>
	</div>
</asp:Content>
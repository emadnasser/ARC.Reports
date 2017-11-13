<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RibbonContextTabs.aspx.vb" Inherits="Features_RibbonContextTabs" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<script type="text/javascript" src="../Scripts/RibbonContextTabs.js"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" ClientInstanceName="DemoHtmlEditor" ToolbarMode="Ribbon" Width="100%" Height="550px">
		<ClientSideEvents 
			CustomCommand="OnCustomCommand"
			SelectionChanged="OnSelectionChanged"
		/>
		<RibbonContextTabCategories>
			<dx:RibbonContextTabCategory Name="ImageFormat" Color="#17a300">
				<Tabs>
					<dx:RibbonTab Text="Format">
						<Groups>
							<dx:RibbonGroup Name="Image Text" Text="Image Text">
								<Items>
									<dx:RibbonButtonItem Name="AltText" Size="Large" Text="Alt-Text">
										<LargeImage IconID="actions_editname_32x32">
										</LargeImage>
									</dx:RibbonButtonItem>
								</Items>
							</dx:RibbonGroup>
							<dx:RibbonGroup Name="Image Style" Text="Image Style">
								<Items>
									<dx:RibbonDropDownButtonItem Name="BorderStyle" Text="Border Style" DropDownMode="false" Size="Large">
										<Items>
											<dx:RibbonDropDownButtonItem Name="Hidden" Text="Hidden">
											</dx:RibbonDropDownButtonItem>
											<dx:RibbonDropDownButtonItem Name="Dotted" Text="Dotted">
											</dx:RibbonDropDownButtonItem>
											<dx:RibbonDropDownButtonItem Name="Dashed" Text="Dashed">
											</dx:RibbonDropDownButtonItem>
											<dx:RibbonDropDownButtonItem Name="Solid" Text="Solid">
											</dx:RibbonDropDownButtonItem>
											<dx:RibbonDropDownButtonItem Name="Ridge" Text="Ridge">
											</dx:RibbonDropDownButtonItem>
										</Items>
										<LargeImage IconID="analysis_linestyle_32x32">
										</LargeImage>
									</dx:RibbonDropDownButtonItem>
									<dx:RibbonColorButtonItem Name="BackColor" Text="Background Color" AutomaticColorItemValue="Automatic">
										<SmallImage IconID="format_fillbackground_16x16">
										</SmallImage>
									</dx:RibbonColorButtonItem>
									<dx:RibbonColorButtonItem Name="BorderColor" Text="Border Color" AutomaticColorItemValue="Automatic">
										<SmallImage IconID="format_pictureshapeoutlinecolor_16x16">
										</SmallImage>
									</dx:RibbonColorButtonItem>
								</Items>
							</dx:RibbonGroup>
						</Groups>
					</dx:RibbonTab>
				</Tabs>
			</dx:RibbonContextTabCategory>
			<dx:HETableToolsRibbonTabCategory>
				<Tabs>
					<dx:HETableLayoutRibbonTab Text="Layout">
						<Groups>
							<dx:HEDeleteTableRibbonGroup>
								<Items>
									<dx:HEDeleteTableRibbonCommand Size="Large">
									</dx:HEDeleteTableRibbonCommand>
									<dx:HEDeleteTableRowRibbonCommand Size="Large">
									</dx:HEDeleteTableRowRibbonCommand>
									<dx:HEDeleteTableColumnRibbonCommand Size="Large">
									</dx:HEDeleteTableColumnRibbonCommand>
								</Items>
							</dx:HEDeleteTableRibbonGroup>
							<dx:HEInsertTableRibbonGroup>
								<Items>
									<dx:HEInsertTableRowAboveRibbonCommand Size="Large">
									</dx:HEInsertTableRowAboveRibbonCommand>
									<dx:HEInsertTableRowBelowRibbonCommand Size="Large">
									</dx:HEInsertTableRowBelowRibbonCommand>
									<dx:HEInsertTableColumnToLeftRibbonCommand Size="Large">
									</dx:HEInsertTableColumnToLeftRibbonCommand>
									<dx:HEInsertTableColumnToRightRibbonCommand Size="Large">
									</dx:HEInsertTableColumnToRightRibbonCommand>
								</Items>
							</dx:HEInsertTableRibbonGroup>
							<dx:HEMergeTableRibbonGroup>
								<Items>
									<dx:HEMergeTableCellDownRibbonCommand Size="Large">
									</dx:HEMergeTableCellDownRibbonCommand>
									<dx:HEMergeTableCellRightRibbonCommand>
									</dx:HEMergeTableCellRightRibbonCommand>
									<dx:HESplitTableCellHorizontallyRibbonCommand>
									</dx:HESplitTableCellHorizontallyRibbonCommand>
									<dx:HESplitTableCellVerticallyRibbonCommand>
									</dx:HESplitTableCellVerticallyRibbonCommand>
								</Items>
							</dx:HEMergeTableRibbonGroup>
							<dx:HETablePropertiesRibbonGroup>
								<Items>
									<dx:HETablePropertiesRibbonCommand Size="Large">
									</dx:HETablePropertiesRibbonCommand>
									<dx:HETableRowPropertiesRibbonCommand>
									</dx:HETableRowPropertiesRibbonCommand>
									<dx:HETableColumnPropertiesRibbonCommand>
									</dx:HETableColumnPropertiesRibbonCommand>
									<dx:HETableCellPropertiesRibbonCommand>
									</dx:HETableCellPropertiesRibbonCommand>
								</Items>
							</dx:HETablePropertiesRibbonGroup>
						</Groups>
					</dx:HETableLayoutRibbonTab>
				</Tabs>
			</dx:HETableToolsRibbonTabCategory>
		</RibbonContextTabCategories>
	</dx:ASPxHtmlEditor>
</asp:Content>
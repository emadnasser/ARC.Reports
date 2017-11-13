<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSide.aspx.vb"
	Inherits="Ribbon_ClientSide" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRibbon ID="ASPxRibbon1" runat="server">
		<Tabs>
			<dx:RibbonTab Text="Item Types" Name="ItemTypes">
				<Groups>
					<dx:RibbonGroup Name="Buttons" Text="Buttons" ShowDialogBoxLauncher="true">
						<Items>
							<dx:RibbonButtonItem Name="Cut" Text="Cut">
								<SmallImage IconID="edit_cut_16x16">
								</SmallImage>
							</dx:RibbonButtonItem>
							<dx:RibbonButtonItem Name="Copy" Text="Copy" ToolTip="Copy">
								<SmallImage IconID="edit_copy_16x16">
								</SmallImage>
							</dx:RibbonButtonItem>
							<dx:RibbonButtonItem Name="Paste" Text="Paste">
								<SmallImage IconID="edit_paste_16x16">
								</SmallImage>
							</dx:RibbonButtonItem>
							<dx:RibbonDropDownButtonItem Name="DropDownButton" Size="Large" Text="DropDown Button">
								<Items>
									<dx:RibbonDropDownButtonItem Name="Pdf" Size="Small" Text="Pdf">
										<SmallImage IconID="export_exporttopdf_16x16">
										</SmallImage>
									</dx:RibbonDropDownButtonItem>
									<dx:RibbonDropDownButtonItem Name="Txt" Size="Small" Text="Txt">
										<SmallImage IconID="export_exporttotxt_16x16">
										</SmallImage>
									</dx:RibbonDropDownButtonItem>
									<dx:RibbonDropDownButtonItem Name="Xml" Size="Small" Text="Xml">
										<SmallImage IconID="export_exporttoxml_16x16">
										</SmallImage>
									</dx:RibbonDropDownButtonItem>
								</Items>
								<LargeImage IconID="actions_open_32x32">
								</LargeImage>
							</dx:RibbonDropDownButtonItem>
						</Items>
					</dx:RibbonGroup>
					<dx:RibbonGroup Name="Editor Items" Text="Editor Items" ShowDialogBoxLauncher="true">
						<Items>
							<dx:RibbonComboBoxItem Name="ComboBox">
								<PropertiesComboBox Width="150px" NullText="ComboBox"></PropertiesComboBox>
								<Items>
									<dx:ListEditItem Text="Name" Value="Name" />
									<dx:ListEditItem Text="Last Name" Value="Last Name" />
									<dx:ListEditItem Text="City" Value="City" />
								</Items>
							</dx:RibbonComboBoxItem>
							<dx:RibbonSpinEditItem Name="SpinEdit">
								<PropertiesSpinEdit Width="150px" NullText="SpinEdit"></PropertiesSpinEdit>
							</dx:RibbonSpinEditItem>
							<dx:RibbonDateEditItem Name="DateEdit">
								<PropertiesDateEdit Width="150px" NullText="DateEdit"></PropertiesDateEdit>
							</dx:RibbonDateEditItem>
							<dx:RibbonTextBoxItem Name="TextBox">
								<PropertiesTextBox Width="150px" NullText="TextBox"></PropertiesTextBox>
							</dx:RibbonTextBoxItem>
						</Items>
					</dx:RibbonGroup>
					<dx:RibbonGroup Name="Toggle &amp; Options" Text="Toggle &amp; Options" ShowDialogBoxLauncher="true">
						<Items>
							<dx:RibbonOptionButtonItem Name="Option1" OptionGroupName="Group1" Text="Option 1">
								<SmallImage IconID="alignment_alignverticalleft2_16x16"></SmallImage>
							</dx:RibbonOptionButtonItem>
							<dx:RibbonOptionButtonItem Name="Option2" OptionGroupName="Group1" Text="Option 2">
								<SmallImage IconID="alignment_alignhorizontalcenter2_16x16"></SmallImage>
							</dx:RibbonOptionButtonItem>
							<dx:RibbonOptionButtonItem Name="Option3" OptionGroupName="Group1" Text="Option 3">
								<SmallImage IconID="alignment_alignhorizontalbottom2_16x16"></SmallImage>
							</dx:RibbonOptionButtonItem>
							<dx:RibbonToggleButtonItem Name="ToggleButton" Size="Large" Text="Toggle Button">
								<LargeImage IconID="programming_bugreport_32x32"></LargeImage>
							</dx:RibbonToggleButtonItem>
							<dx:RibbonDropDownButtonItem Size="Large" DropDownMode="false" Text="DropDown Toggle Buttons">
								<LargeImage IconID="setup_properties_32x32">
								</LargeImage>
								<Items>
									<dx:RibbonDropDownToggleButtonItem Name="DropDownToggleButton1" Text="DropDown Toggle Button 1">
									</dx:RibbonDropDownToggleButtonItem>
									<dx:RibbonDropDownToggleButtonItem Name="DropDownToggleButton2" Text="DropDown Toggle Button 2">
									<SmallImage IconID="content_checkbox_16x16"></SmallImage>
									</dx:RibbonDropDownToggleButtonItem>
								</Items>
							</dx:RibbonDropDownButtonItem>
						</Items>
					</dx:RibbonGroup>
					<dx:RibbonGroup Name="Color" Text="Color" ShowDialogBoxLauncher="true">
						<Items>
							<dx:RibbonColorButtonItem Name="ColorButton" Text="Color Button" Size="Large" Color="Red">
								<LargeImage IconID="format_changefontstyle_32x32">
								</LargeImage>
							</dx:RibbonColorButtonItem>
						</Items>
					</dx:RibbonGroup>
				</Groups>
			</dx:RibbonTab>
			<dx:RibbonTab Name="Misc" Text="Misc">
				<Groups>
					<dx:RibbonGroup Name="Find" Text="Find" ShowDialogBoxLauncher="true">
						<Items>
							<dx:RibbonButtonItem Name="Find" Size="Large" Text="Find">
								<LargeImage IconID="find_find_32x32">
								</LargeImage>
							</dx:RibbonButtonItem>
							<dx:RibbonToggleButtonItem Name="By ID">
								<SmallImage IconID="find_findbyid_16x16">
								</SmallImage>
							</dx:RibbonToggleButtonItem>
						</Items>
					</dx:RibbonGroup>
					<dx:RibbonGroup Name="Export" Text="Export" ShowDialogBoxLauncher="true">
						<Items>
							<dx:RibbonDropDownButtonItem Name="Export" Size="Large" Text="Export">
								<Items>
									<dx:RibbonDropDownButtonItem Name="DOC" Text="DOC">
										<SmallImage IconID="export_exporttodoc_16x16">
										</SmallImage>
									</dx:RibbonDropDownButtonItem>
									<dx:RibbonDropDownButtonItem Name="PDF" Text="PDF">
										<SmallImage IconID="export_exporttopdf_16x16">
										</SmallImage>
									</dx:RibbonDropDownButtonItem>
									<dx:RibbonDropDownButtonItem Name="TXT" Text="TXT">
										<SmallImage IconID="export_exporttotxt_16x16">
										</SmallImage>
									</dx:RibbonDropDownButtonItem>
								</Items>
								<LargeImage IconID="export_export_32x32">
								</LargeImage>
							</dx:RibbonDropDownButtonItem>
						</Items>
					</dx:RibbonGroup>
					<dx:RibbonGroup Name="Gallery" Text="Gallery" ShowDialogBoxLauncher="true">
						<Items>
							<dx:RibbonGalleryDropDownItem Size="Large" Text="Arrange" Name="Gallery">
								<LargeImage IconID="arrange_morelayoutoptions_32x32"></LargeImage>
								<PropertiesDropDownGallery ShowGroupText="false" ShowText="true" ColumnCount="3" RowCount="2" ImagePosition="Top" />
								<Groups>
										<dx:RibbonGalleryGroup>
											<Items>
												<dx:RibbonGalleryItem Text="Bottom left" Value="Bottom left">
													<Image IconID="arrange_withtextwrapping_bottomleft_32x32"></Image>
												</dx:RibbonGalleryItem>
												<dx:RibbonGalleryItem Text="Bottom right" Value="Bottom right">
													<Image IconID="arrange_withtextwrapping_bottomright_32x32"></Image>
												</dx:RibbonGalleryItem>
												<dx:RibbonGalleryItem Text="Center" Value="Center">
													<Image IconID="arrange_withtextwrapping_centercenter_32x32"></Image>
												</dx:RibbonGalleryItem>
												<dx:RibbonGalleryItem Text="Center left" Value="Center left">
													<Image IconID="arrange_withtextwrapping_centerleft_32x32"></Image>
												</dx:RibbonGalleryItem>
												<dx:RibbonGalleryItem Text="Center right" Value="Center right">
													<Image IconID="arrange_withtextwrapping_centerright_32x32"></Image>
												</dx:RibbonGalleryItem>
												<dx:RibbonGalleryItem Text="Top center" Value="Top center">
													<Image IconID="arrange_withtextwrapping_topcenter_32x32"></Image>
												</dx:RibbonGalleryItem>
												<dx:RibbonGalleryItem Text="Top left" Value="Top left">
													<Image IconID="arrange_withtextwrapping_topleft_32x32"></Image>
												</dx:RibbonGalleryItem>
												<dx:RibbonGalleryItem Text="Top right" Value="Top right">
													<Image IconID="arrange_withtextwrapping_topright_32x32"></Image>
												</dx:RibbonGalleryItem>
											</Items>
										</dx:RibbonGalleryGroup>
									</Groups>
							</dx:RibbonGalleryDropDownItem>
							</Items>
						</dx:RibbonGroup>
					<dx:RibbonGroup Text="Gallery Bar" ShowDialogBoxLauncher="true">
						<Items>
							<dx:RibbonGalleryBarItem ShowText="false" MaxColumnCount="4" Name="IconsGallery">
								<PropertiesDropDownGallery RowCount="2"></PropertiesDropDownGallery>                                
								<Groups>
									<dx:RibbonGalleryGroup Text="Arrows">
										<Items>
											<dx:RibbonGalleryItem Value="arrows_doublefirst">
												<Image IconID="arrows_doublefirst_32x32"></Image>
											</dx:RibbonGalleryItem>
											<dx:RibbonGalleryItem Value="arrows_doublelast">
												<Image IconID="arrows_doublelast_32x32"></Image>
											</dx:RibbonGalleryItem>
											<dx:RibbonGalleryItem Value="arrows_doublenext">
												<Image IconID="arrows_doublenext_32x32"></Image>
											</dx:RibbonGalleryItem>
											<dx:RibbonGalleryItem Value="actions_download">
												<Image IconID="actions_download_32x32"></Image>
											</dx:RibbonGalleryItem>
										</Items>
									</dx:RibbonGalleryGroup>
									<dx:RibbonGalleryGroup Text="Edit">
										<Items>
											<dx:RibbonGalleryItem Value="edit_copy">
												<Image IconID="edit_copy_32x32"></Image>
											</dx:RibbonGalleryItem>
											<dx:RibbonGalleryItem Value="edit_customization">
												<Image IconID="edit_customization_32x32"></Image>
											</dx:RibbonGalleryItem>
											<dx:RibbonGalleryItem Value="edit_cut">
												<Image IconID="edit_cut_32x32"></Image>
											</dx:RibbonGalleryItem>
											<dx:RibbonGalleryItem Value="edit_delete">
												<Image IconID="edit_delete_32x32"></Image>
											</dx:RibbonGalleryItem>
										</Items>
									</dx:RibbonGalleryGroup>
									<dx:RibbonGalleryGroup Text="Gauges">
										<Items>
											<dx:RibbonGalleryItem Value="gauges_gaugestylefullcircular">
												<Image IconID="gauges_gaugestylefullcircular_32x32"></Image>
											</dx:RibbonGalleryItem>
											<dx:RibbonGalleryItem Value="gauges_gaugestylehalfcircular">
												<Image IconID="gauges_gaugestylehalfcircular_32x32"></Image>
											</dx:RibbonGalleryItem>
											<dx:RibbonGalleryItem Value="gauges_gaugestyleleftquartercircular">
												<Image IconID="gauges_gaugestyleleftquartercircular_32x32"></Image>
											</dx:RibbonGalleryItem>
											<dx:RibbonGalleryItem Value="gauges_gaugestylelinearhorizontal">
												<Image IconID="gauges_gaugestylelinearhorizontal_32x32"></Image>
											</dx:RibbonGalleryItem>
											<dx:RibbonGalleryItem Value="gauges_gaugestylelinearvertical">
												<Image IconID="gauges_gaugestylelinearvertical_32x32"></Image>
											</dx:RibbonGalleryItem>
											<dx:RibbonGalleryItem Value="gauges_gaugestylerightquartercircular">
												<Image IconID="gauges_gaugestylerightquartercircular_32x32"></Image>
											</dx:RibbonGalleryItem>
										</Items>
									</dx:RibbonGalleryGroup>
								</Groups>
							</dx:RibbonGalleryBarItem>
						</Items>
					</dx:RibbonGroup>
				</Groups>
			</dx:RibbonTab>
		</Tabs>
		<ClientSideEvents ActiveTabChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'ActiveTabChanged') }" DialogBoxLauncherClicked="function(s, e) { DXEventMonitor.Trace(s, e, 'DialogBoxLauncherClicked') }"
			FileTabClicked="function(s, e) { DXEventMonitor.Trace(s, e, 'FileTabClicked') }" CommandExecuted="function(s, e) { DXEventMonitor.Trace(s, e, 'CommandExecuted') }"
			Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init') }" MinimizationStateChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'MinimizationStateChanged') }" />
	</dx:ASPxRibbon>
	<br />
	<dx:EventMonitor runat="server" ID="EventMonitor" EventNames="ActiveTabChanged FileTabClicked CommandExecuted Init MinimizationStateChanged DialogBoxLauncherClicked" EventLogWidth="540" />
</asp:Content>
<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="Features.aspx.vb" Inherits="ImageSlider_Features" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.dxisControl {
			margin: 8px 0 10px 0;
		}
	</style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxComboBox runat="server" ID="cbPredefinedScenarios" AutoPostBack="True" SelectedIndex="0" Width="156px"
		OnSelectedIndexChanged="cbPredefinedScenarios_SelectedIndexChanged" Caption="Predefined Scenarios">
		<RootStyle CssClass="OptionsBottomMargin"></RootStyle>
		<Items>
			<dx:ListEditItem Value="1" Text="Default" />
			<dx:ListEditItem Value="2" Text="Fill and Crop, Dots" />
			<dx:ListEditItem Value="3" Text="Vertical Scrolling" />
		</Items>
	</dx:ASPxComboBox>
	<dx:ASPxImageSlider ID="imageSlider" runat="server" ClientInstanceName="imageSlider" DataSourceID="xmlImages" EnableTheming="false">
		<ClientSideEvents Init="function(s, e) { s.Focus(); }" />
	</dx:ASPxImageSlider>
	<asp:XmlDataSource ID="xmlImages" runat="server" DataFile="~/App_Data/ImageSlider/people.xml"
		XPath="//items/*"></asp:XmlDataSource>
	<dx:ASPxFormLayout runat="server" ColCount="2">
		<Items>
			<dx:LayoutGroup Caption="Image Area Settings" GroupBoxDecoration="HeadingLine">
				<Items>
					<dx:LayoutItem Caption="EnableLoopNavigation">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="chEnableLoopNavigation" runat="server" AutoPostBack="true" Checked="false"></dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="ImageSizeMode">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlImageSizeMode" runat="server" AutoPostBack="True" Width="134px"
									ValueType="System.Int32" SelectedIndex="0" OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="ActualSizeOrFit" />
										<dx:ListEditItem Value="1" Text="FitProportional" />
										<dx:ListEditItem Value="2" Text="FillAndCrop" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="AnimationType">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlAnimationType" runat="server" AutoPostBack="True" Width="134px"
									ValueType="System.Int32" SelectedIndex="0" OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="Slide" />
										<dx:ListEditItem Value="1" Text="Fade" />
										<dx:ListEditItem Value="2" Text="None" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="NavigationDirection">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlNavigationDirection" runat="server" AutoPostBack="True"
									Width="134px" ValueType="System.Int32" SelectedIndex="0" OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="Horizontal" />
										<dx:ListEditItem Value="1" Text="Vertical" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="ItemTextVisibility">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox runat="server" ID="ddlItemTextVisibility" AutoPostBack="True" Width="134px"
									ValueType="System.Int32" SelectedIndex="0"
									OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="None" />
										<dx:ListEditItem Value="1" Text="Faded" />
										<dx:ListEditItem Value="2" Text="OnMouseOver" />
										<dx:ListEditItem Value="3" Text="Always" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="NavigationButtonVisibility">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlNavigationButtonsVisibility" runat="server" AutoPostBack="True"
									ValueType="System.Int32" Width="134px" SelectedIndex="0" OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="None" />
										<dx:ListEditItem Value="1" Text="Faded" />
										<dx:ListEditItem Value="2" Text="OnMouseOver" />
										<dx:ListEditItem Value="3" Text="Always" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
				<SettingsItemCaptions HorizontalAlign="Left" />
			</dx:LayoutGroup>
			<dx:LayoutGroup Caption="Navigation Bar Settings" GroupBoxDecoration="HeadingLine">
				<Items>
					<dx:LayoutItem Caption="Position">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlNavigationBarPosition" runat="server" AutoPostBack="True"
									Width="134px" ValueType="System.Int32" SelectedIndex="0" OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="Bottom" />
										<dx:ListEditItem Value="1" Text="Top" />
										<dx:ListEditItem Value="2" Text="Left" />
										<dx:ListEditItem Value="3" Text="Right" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Mode">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlThumbnailBarMode" runat="server" AutoPostBack="True" Width="134px"
									ValueType="System.Int32" SelectedIndex="0" OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="Thumbnails" />
										<dx:ListEditItem Value="1" Text="Dots" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="ThumbnailsModeNavigationButtonVisibility">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlNbNavigationButtonsVisibility" runat="server" AutoPostBack="True"
									ValueType="System.Int32" Width="134px" SelectedIndex="0" OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="None" />
										<dx:ListEditItem Value="1" Text="Faded" />
										<dx:ListEditItem Value="2" Text="OnMouseOver" />
										<dx:ListEditItem Value="3" Text="Always" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="ThumbnailsNavigationButtonPosition">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlNbNavigationButtonsPosition" runat="server" AutoPostBack="True" Width="134px"
									ValueType="System.Int32" SelectedIndex="0" OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="Inside" />
										<dx:ListEditItem Value="1" Text="Outside" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="PagingMode">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlNavigationBarPagingMode" runat="server" AutoPostBack="True" Width="134px"
									ValueType="System.Int32" SelectedIndex="0" OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="Page" />
										<dx:ListEditItem Value="1" Text="Single" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
				<SettingsItemCaptions HorizontalAlign="Left" />
			</dx:LayoutGroup>
			<dx:LayoutGroup Caption="Behavior Settings" GroupBoxDecoration="HeadingLine">
				<Items>
					<dx:LayoutItem Caption="AllowMouseWheel">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="chAllowMouseWheel" runat="server" AutoPostBack="true" Checked="false"></dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="EnablePagingGestures">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="chEnablePagingGestures" runat="server" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="EnablePagingByClick">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlEnablePagingByClick" runat="server" AutoPostBack="True"
									ValueType="System.Int32" Width="190px" SelectedIndex="0" OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="Auto" />
										<dx:ListEditItem Value="1" Text="True" />
										<dx:ListEditItem Value="2" Text="False" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="ImageLoadMode">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlImageLoadMode" runat="server" AutoPostBack="True"
									ValueType="System.Int32" Width="190px" SelectedIndex="3" OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="AllImages" />
										<dx:ListEditItem Value="1" Text="DynamicLoadAndCache" />
										<dx:ListEditItem Value="2" Text="DynamicLoad" />
										<dx:ListEditItem Value="3" Text="Auto" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="ExtremeItemClickMode">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlExtremeItemClickMode" runat="server" AutoPostBack="True"
									ValueType="System.Int32" Width="190px" SelectedIndex="0" OnSelectedIndexChanged="GeneralValueChanged">
									<Items>
										<dx:ListEditItem Value="0" Text="SelectAndSlide" />
										<dx:ListEditItem Value="1" Text="Select" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			<dx:LayoutGroup Caption="Appearance" GroupBoxDecoration="HeadingLine">
				<Items>
					<dx:LayoutItem Caption="ShowNavigationBar">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="chShowNavigationBar" runat="server" AutoPostBack="True" Checked="True"
									OnCheckedChanged="GeneralValueChanged" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
		</Items>
	</dx:ASPxFormLayout>
</asp:Content>
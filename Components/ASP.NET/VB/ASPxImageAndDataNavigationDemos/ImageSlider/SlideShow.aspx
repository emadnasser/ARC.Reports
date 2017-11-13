<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="SlideShow.aspx.vb" Inherits="ImageSlider_SlideShow" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
	<link href="css/SlideShow.css" rel="Stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" CssClass="OptionsBottomMargin">
		<Items>
			<dx:LayoutGroup Caption="Slide Show Settings" ColCount="2">
				<Items>
					<dx:LayoutItem Caption="AutoPlay">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="chAutoPlay" runat="server" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Interval (ms)">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlInterval" runat="server" AutoPostBack="true"
									ValueType="System.Int32" Width="124px" SelectedIndex="3">
									<Items>
										<dx:ListEditItem Value="1000" />
										<dx:ListEditItem Value="2000" />
										<dx:ListEditItem Value="3000" />
										<dx:ListEditItem Value="5000" />
									</Items>
								</dx:ASPxComboBox> 
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="StopPlayingWhenPaging">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="chStopPlayingWhenPaging" runat="server" AutoPostBack="true"></dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
						<dx:LayoutItem Caption="PlayPauseButtonVisibility">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="ddlPlayPauseButtonVisibility" runat="server" AutoPostBack="True"
									ValueType="System.Int32" Width="124px" SelectedIndex="1">
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
					<dx:LayoutItem Caption="PausePlayingWhenMouseOver">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="chPausePlayingWhenMouseOver" runat="server" AutoPostBack="true"></dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
		</Items>
	</dx:ASPxFormLayout>
	<dx:ASPxImageSlider ID="ASPxImageSlider1" runat="server" ClientInstanceName="ImageSlider"
		EnableViewState="False" EnableTheming="False" NavigateUrlFormatString="javascript:void({0});">
		<SettingsImageArea ImageSizeMode="ActualSizeOrFit" NavigationButtonVisibility="None"
			ItemTextVisibility="Always" EnableLoopNavigation="true" />
		<SettingsNavigationBar Mode="Dots" />
		<SettingsSlideShow AutoPlay="true" StopPlayingWhenPaging="false" PausePlayingWhenMouseOver="false" PlayPauseButtonVisibility="Faded"></SettingsSlideShow>
		<Items>
			<dx:ImageSliderItem ImageUrl="~/Content/Images/widescreen/woman-using-laptop.jpg"
				NavigateUrl="1">
				<TextTemplate>
					<h3 class='isdemoH3'>Smile</h3>
					<p>It takes 17 muscles to smile and 43 to frown. <a tabindex="-1" href='javascript:void(1);'>Details »</a></p>
				</TextTemplate>
			</dx:ImageSliderItem>
			<dx:ImageSliderItem ImageUrl="~/Content/Images/widescreen/swimmer-underwater.jpg"
				NavigateUrl="2">
				<TextTemplate>
					<h3 class='isdemoH3'>Dolphins</h3>
					<p>Dolphins sleep with one eye open. <a tabindex="-1" href='javascript:void(2);'>Details»</a></p>
				</TextTemplate>
			</dx:ImageSliderItem>
			<dx:ImageSliderItem ImageUrl="~/Content/Images/widescreen/typing-male-hands.jpg"
				NavigateUrl="3">
				<TextTemplate>
					<h3 class='isdemoH3'>Paper</h3>
					<p>No piece of paper can be folded in half more than eight times. <a tabindex="-1" href='javascript:void(3);'>Details »</a></p>
				</TextTemplate>
			</dx:ImageSliderItem>
			<dx:ImageSliderItem ImageUrl="~/Content/Images/widescreen/man-climbing-on-limestone-wall.jpg"
				NavigateUrl="4">
				<TextTemplate>
					<h3 class='isdemoH3'>Walking</h3>
					<p>In the average lifetime a person will walk the equivalent of five times around the equator. <a tabindex="-1" href='javascript:void(4);'>Details »</a></p>
				</TextTemplate>
			</dx:ImageSliderItem>
			<dx:ImageSliderItem ImageUrl="~/Content/Images/widescreen/woman-using-notebook.jpg"
				NavigateUrl="5">
				<TextTemplate>
					<h3 class='isdemoH3'>Calories</h3>
					<p>You burn more calories sleeping than you do watching TV. <a tabindex="-1" href='javascript:void(5);'>Details »</a></p>
				</TextTemplate>
			</dx:ImageSliderItem>
		</Items>
		<Styles>
			<ImageArea Width="800" Height="313" />
		</Styles>
	</dx:ASPxImageSlider>
</asp:Content>
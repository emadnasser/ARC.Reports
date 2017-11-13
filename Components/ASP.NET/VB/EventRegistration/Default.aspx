<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.vb"
	Theme="DXConnect" Inherits="_Default" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	<div class="home">
		<div class="home-top">
			<div class="content">
				<div class="featuredSession">
					<div class="arrowLeft">
						<dx:ASPxButton ID="btnPrevSession" runat="server" AutoPostBack="false" AllowFocus="false" EnableTheming="false"
							CssClass="clearBtn" Width="28px" Height="49px">
							<BackgroundImage ImageUrl="Images/arrow_left.png" />
							<HoverStyle BackgroundImage-ImageUrl="Images/arrow_left_hover.png" />
							<ClientSideEvents Click="ShowPrevSession" />
						</dx:ASPxButton>
					</div>
					<dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" ClientInstanceName="CallbackPanel"
						EnableCallbackAnimation="true" OnCallback="ASPxCallbackPanel1_Callback" CssClass="container"
						SettingsLoadingPanel-Text="">
						<PanelCollection>
							<dx:PanelContent>
								<div class="image">
									<dx:ASPxImage runat="server" ID="imgSessionPreview">
									</dx:ASPxImage>
								</div>
								<div class="info">
									<div class="session">
										<dx:ASPxLabel ID="lblPreviewTitle" runat="server" CssClass="title">
										</dx:ASPxLabel>
										<dx:ASPxLabel ID="lblPreviewDescription" runat="server" CssClass="description">
										</dx:ASPxLabel>
									</div>
									<div class="speaker">
										<dx:ASPxLabel ID="lblPreviewSpeakerName" runat="server" CssClass="name" />
										<dx:ASPxLabel ID="lblPreviewSpeakerDescr" runat="server" CssClass="description" />
									</div>
									<dx:ASPxButton ID="btnAttendSession" runat="server" AutoPostBack="true" Image-Url="~/Images/buttons/attend.png"
										CssClass="attendButton blue" HorizontalAlign="Center">
									</dx:ASPxButton>
								</div>
							</dx:PanelContent>
						</PanelCollection>
					</dx:ASPxCallbackPanel>
					<div class="arrowRight">
						<dx:ASPxButton ID="btnNextSession" runat="server" AutoPostBack="false" AllowFocus="false" EnableTheming="false"
							CssClass="clearBtn" Width="28px" Height="49px">
							<BackgroundImage ImageUrl="Images/arrow_right.png" />
							<HoverStyle BackgroundImage-ImageUrl="Images/arrow_right_hover.png" />
							<ClientSideEvents Click="ShowNextSession" />
						</dx:ASPxButton>
					</div>
				</div>
			</div>
		</div>
		<div class="home-center">
			<div class="content">
				<div class="home-center-main">
					<div class="registrationPreview">
						<div class="title">
							DXConnections</div>
						<div class="registrationPreview-content">
							<p>
								DevExpress proudly supports the global software developer community. We are committed
								to helping .NET community groups and developer events thrive.</p>
							<p>
								Whether you are attending a national code camp, a regional tech fest, or your local
								user group meeting, we look forward to meeting you and learning more about your
								business requirements.
							</p>
							<div class="doRegister" id="doRegister" runat="server">
								<span>If you haven't registered yet, do so...</span>
								<dx:ASPxButton ID="btnRegister" runat="server" CssClass="regButton withImage" Image-Url="~/Images/buttons/register.png"
									OnClick="btnRegister_Click" HorizontalAlign="Center">
								</dx:ASPxButton>
							</div>
						</div>
					</div>
					<div class="starsPreview">
						<asp:Repeater ID="repeaterStar" runat="server">
							<HeaderTemplate>
								<div class="title">
									Our Stars
								</div>
							</HeaderTemplate>
							<ItemTemplate>
								<div class="star">
									<div class="star-photo">
										<img src="<%#GetStarPhotoUrl(Eval("ImageName").ToString())%>" alt="<%#Eval("Name")%>" /></div>
									<div class="star-description">
										<div class="star-name">
											<%#Eval("Name")%></div>
										<div class="star-text">
											<%#Eval("Description")%>
										</div>
									</div>
								</div>
							</ItemTemplate>
						</asp:Repeater>
					</div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
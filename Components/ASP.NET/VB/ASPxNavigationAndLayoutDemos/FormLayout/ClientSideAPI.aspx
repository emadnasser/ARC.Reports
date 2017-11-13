<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSideAPI.aspx.vb" Inherits="FormLayout_ClientSideAPI" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function UpdateItemsVisibility(radioButtonList) {
			var isNewUser = radioButtonList.GetValue() === "NewUser";
			formLayout.GetItemByName("ConfirmPassword").SetVisible(isNewUser);
			formLayout.GetItemByName("SignUp").SetVisible(isNewUser);
			formLayout.GetItemByName("RememberMe").SetVisible(!isNewUser);
			formLayout.GetItemByName("SignIn").SetVisible(!isNewUser);
		}
		function OnInit(s, e) {
			UpdateItemsVisibility(s);
		}
		function OnUserTypeChanged(s, e) {
			UpdateItemsVisibility(s);
		}
		function OnConfirmPasswordValidation(s, e) {
			if(s.GetText() !== passwordTextBox.GetText()) {
				e.isValid = false;
				e.errorText = "The password you entered do not match";
			}
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="ContentHolder" runat="server">
	<table>
		<tr>
			<td>
				<dx:ASPxFormLayout ID="formLayout" runat="server" ClientInstanceName="formLayout">
					<Items>
						<dx:LayoutItem ShowCaption="False">
							<LayoutItemNestedControlCollection>
								<dx:LayoutItemNestedControlContainer>
									<dx:ASPxRadioButtonList runat="server" ID="radioButtonList" Border-BorderWidth="0" SelectedIndex="0">
										<Items>
											<dx:ListEditItem Text="I am a new user" Value="NewUser" />
											<dx:ListEditItem Text="I am a registered user" Value="RegisteredUser" />
										</Items>
										<ClientSideEvents Init="OnInit" SelectedIndexChanged="OnUserTypeChanged" />
									</dx:ASPxRadioButtonList>
								</dx:LayoutItemNestedControlContainer>
							</LayoutItemNestedControlCollection>
						</dx:LayoutItem>
						<dx:EmptyLayoutItem />
						<dx:LayoutGroup Name="UserInfo" GroupBoxDecoration="Box" Caption="User info">
							<Items>
								<dx:LayoutItem Caption="E-mail" Name="E-mail">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox runat="server" ID="eMailTextBox" Width="170">
												<ValidationSettings ErrorDisplayMode="Text" Display="Dynamic" ErrorTextPosition="Bottom" SetFocusOnError="true">
													<RegularExpression ErrorText="Invalid e-mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
													<RequiredField IsRequired="True" ErrorText="The value is required" />
												</ValidationSettings>
											</dx:ASPxTextBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Password" Name="Password">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox ID="passwordTextBox" runat="server" Password="true" Width="170" ClientInstanceName="passwordTextBox">
												<ValidationSettings ErrorTextPosition="Bottom" ErrorDisplayMode="Text" Display="Dynamic" SetFocusOnError="true">
													<RequiredField IsRequired="True" ErrorText="The value is required" />
												</ValidationSettings>
											</dx:ASPxTextBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Confirm password" Name="ConfirmPassword">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox ID="confirmPasswordTextBox" runat="server" Password="true" Width="170">
												<ValidationSettings ErrorTextPosition="Bottom" ErrorDisplayMode="Text" Display="Dynamic" SetFocusOnError="true">
													<RequiredField IsRequired="True" ErrorText="The value is required" />
												</ValidationSettings>
												<ClientSideEvents Validation="OnConfirmPasswordValidation" />
											</dx:ASPxTextBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Remember me" Name="RememberMe">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxCheckBox ID="rememberMeCheckBox" runat="server" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:EmptyLayoutItem />
								<dx:LayoutItem Caption=" " Name="SignUp">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxButton ID="signUpButton" runat="server" Text="Sign Up" Width="100" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption=" " Name="SignIn">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxButton ID="signInButton" runat="server" Text="Sign In" Width="100" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
							</Items>
						</dx:LayoutGroup>
					</Items>
				</dx:ASPxFormLayout>
			</td>
			<td>
				<dx:ASPxFormLayout runat="server">
					<Items>
						<dx:LayoutGroup GroupBoxDecoration="HeadingLine" Caption="Form Layout captions">
							<Items>
								<dx:LayoutItem Caption="'User info' Group Caption">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox runat="server" Text="User info" ID="userInfoCaption" MaxLength="30">
												<ClientSideEvents KeyUp="function(s,e) { formLayout.GetItemByName('UserInfo').SetCaption(s.GetText()); }" />
											</dx:ASPxTextBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="'Email' Item Caption">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox runat="server" Text="E-mail" ID="emailCaption" MaxLength="25">
												<ClientSideEvents KeyUp="function(s,e) { formLayout.GetItemByName('E-mail').SetCaption(s.GetText()); }" />
											</dx:ASPxTextBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="'Password' Item Caption">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox runat="server" Text="Password" ID="passwordCaption" MaxLength="25">
												<ClientSideEvents KeyUp="function(s,e) { formLayout.GetItemByName('Password').SetCaption(s.GetText()); }" />
											</dx:ASPxTextBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="'Confirm password' Item Caption">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox runat="server" Text="Confirm password" ID="confirmPasswordCaption" MaxLength="25">
												<ClientSideEvents KeyUp="function(s,e) { formLayout.GetItemByName('ConfirmPassword').SetCaption(s.GetText()); }" />
											</dx:ASPxTextBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="'Remember me' Item Caption">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox runat="server" Text="Remember me" ID="rememberMeCaption" MaxLength="24">
												<ClientSideEvents KeyUp="function(s,e) { formLayout.GetItemByName('RememberMe').SetCaption(s.GetText()); }" />
											</dx:ASPxTextBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
							</Items>
						</dx:LayoutGroup>
					</Items>
				</dx:ASPxFormLayout>
			</td>
		</tr>
	</table>
</asp:Content>
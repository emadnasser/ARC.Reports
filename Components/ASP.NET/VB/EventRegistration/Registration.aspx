<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Registration.aspx.vb"
	Theme="DXConnect" Inherits="Registration" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	<div class="mainContent registration">
		<div class="contentHeader">
			<div class="content">
				<img id="registrationTitle" src="Images/title_registration.png" alt="Schedule" />
			</div>
		</div>
		<div class="content">
			<dx:ASPxPageControl ID="pc" ClientInstanceName="pc" runat="server" ActiveTabIndex="0"
				EnableCallBacks="True" Width="100%" OnInit="pc_Init" CssClass="pageControl" Height="400px" SettingsLoadingPanel-Text="">
				<ClientSideEvents ActiveTabChanged="UpdateButtonsEnabled" ActiveTabChanging="OnActiveTabChanging" />
				<TabTemplate>
					<site:UnselectedTab ID="UnselectedTab1" runat="server" />
				</TabTemplate>
				<ActiveTabTemplate>
					<site:SelectedTab ID="SelectedTab1" runat="server" />
				</ActiveTabTemplate>
				<TabStyle>
					<Paddings Padding="0px" />
					<BorderBottom BorderStyle="None" BorderWidth="0px" />
				</TabStyle>
				<Paddings Padding="0px" />
				<TabPages>
					<dx:TabPage Name="Personal" Text="Personal information">
						<ContentCollection>
							<dx:ContentControl ID="ContentControlPersonalInfo" runat="server" SupportsDisabledAttribute="True">
								<div class="tabPageContent" id="Personal">
									<div class="regFields">
										<div class="regColumn left">
											<div class="regFieldHolder">
												<dx:ASPxLabel runat="server" ID="lblFirstName" AssociatedControlID="txtFirstName"
													Text="First Name:" CssClass="regLabel" />
												<dx:ASPxTextBox runat="server" ID="txtFirstName">
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
														<RequiredField IsRequired="true" />
													</ValidationSettings>
													<ClientSideEvents TextChanged="function(s, e) { SaveRegField(s, 'FirstName'); UpdateFullName(); }" 
													 Validation="OnValidation" />
												</dx:ASPxTextBox>
											</div>
											<div class="regFieldHolder">
												<dx:ASPxLabel ID="lblLastName" runat="server" AssociatedControlID="txtLastName" Text="Last Name:"
													CssClass="regLabel" />
												<dx:ASPxTextBox runat="server" ID="txtLastName">
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
														<RequiredField IsRequired="true" />
													</ValidationSettings>
													<ClientSideEvents TextChanged="function(s, e) { SaveRegField(s, 'LastName'); UpdateFullName(); }" Validation="OnValidation"/>
												</dx:ASPxTextBox>
											</div>
											<div class="regFieldHolder">
												<dx:ASPxLabel ID="lblJobTitle" runat="server" AssociatedControlID="txtJobTitle" Text="Job Title:"
													CssClass="regLabel" />
												<dx:ASPxTextBox runat="server" ID="txtJobTitle">
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
														<RequiredField IsRequired="true" />
													</ValidationSettings>
													<ClientSideEvents TextChanged="function(s, e) { SaveRegField(s, 'JobTitle'); }" Validation="OnValidation"/>
												</dx:ASPxTextBox>
											</div>
										</div>
										<div class="regColumn right">
											<div class="regFieldHolder">
												<dx:ASPxLabel ID="lblCompanyName" runat="server" AssociatedControlID="txtCompanyName"
													Text="Company Name:" CssClass="regLabel" />
												<dx:ASPxTextBox runat="server" ID="txtCompanyName">
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
														<RequiredField IsRequired="true" />
													</ValidationSettings>
													<ClientSideEvents TextChanged="function(s, e) { SaveRegField(s, 'CompanyName'); }" Validation="OnValidation"/>
												</dx:ASPxTextBox>
											</div>
											<div class="regFieldHolder">
												<dx:ASPxLabel ID="lblCity" runat="server" AssociatedControlID="txtCity" Text="City:"
													CssClass="regLabel" />
												<dx:ASPxTextBox runat="server" ID="txtCity">
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
														<RequiredField IsRequired="true" />
													</ValidationSettings>
													<ClientSideEvents TextChanged="function(s, e) { SaveRegField(s, 'City'); }" Validation="OnValidation"/>
												</dx:ASPxTextBox>
											</div>
											<div class="regFieldHolder">
												<dx:ASPxLabel ID="lblPhone" runat="server" AssociatedControlID="txtPhone" Text="Business Phone:"
													CssClass="regLabel" />
												<dx:ASPxTextBox runat="server" ID="txtPhone">
													<MaskSettings Mask="+1 ( 999 ) 000-0000" PromptChar="_" />
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
														<RegularExpression ValidationExpression="\+\d{1,3}\s?\(\s?\d{1,7}\s?\)s?([\d\-\s]{5,})" />
														<RequiredField IsRequired="true" />
													</ValidationSettings>
													<ClientSideEvents TextChanged="function(s, e) { SaveRegField(s, 'Phone'); }" Validation="OnValidation"/>
												</dx:ASPxTextBox>
											</div>
										</div>
									</div>
									<div class="regFields">
										<div class="regColumn left">
											<div class="regFieldHolder afterSpace">
												<dx:ASPxLabel ID="lblEmail" runat="server" AssociatedControlID="txtEmail" Text="Email:"
													CssClass="regLabel" />
												<dx:ASPxTextBox runat="server" ID="txtEmail">
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
														<RegularExpression ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
														<RequiredField IsRequired="true" />
													</ValidationSettings>
													<ClientSideEvents TextChanged="function(s, e) { SaveRegField(s, 'Email'); }" Validation="OnValidation"/>
												</dx:ASPxTextBox>
											</div>
											<div class="regFieldHolder afterSpace">
												<dx:ASPxCheckBox runat="server" ID="chbSendMail" Checked="true" CssClass="regCheckBox"
													Text="Send me email notifications from DXConnections" Width="400px">
													<ClientSideEvents CheckedChanged="function(s, e) { SaveRegField(s, 'SendCorrespondence'); }" />
												</dx:ASPxCheckBox>
											</div>
										</div>
									</div>
								</div>
							</dx:ContentControl>
						</ContentCollection>
					</dx:TabPage>
					<dx:TabPage ClientEnabled="False" Name="Payment" Text="Payment">
						<ContentCollection>
							<dx:ContentControl ID="ContentControlPayment" runat="server" SupportsDisabledAttribute="True">
								<div class="tabPageContent" id="Payment">
									<div class="regFields">
										<div class="regColumn left">
											<div class="regFieldHolder">
												<dx:ASPxLabel ID="lblCCType" runat="server" AssociatedControlID="cmbCCType" Text="Card Type:"
													CssClass="regLabel" />
												<dx:ASPxComboBox runat="server" ID="cmbCCType"
													ShowImageInEditBox="true" Width="234px">
													<Items>
														<dx:ListEditItem Text="Visa" Value="Visa" ImageUrl="Images/cc_visa.png" Selected="true" />
														<dx:ListEditItem Text="MasterCard" Value="MasterCard" ImageUrl="Images/cc_mastercard.png" />
													</Items>
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true" />
												</dx:ASPxComboBox>
											</div>
											<div class="regFieldHolder">
												<dx:ASPxLabel ID="lblCCNumber" runat="server" AssociatedControlID="txtCCNumber" Text="Card Number:"
													CssClass="regLabel" />
												<dx:ASPxTextBox runat="server" ID="txtCCNumber" ValidationSettings-ErrorDisplayMode="None"
													ClientInstanceName="s123">
													<MaskSettings Mask="0000 0000 0000 0000" IncludeLiterals="DecimalSymbol" ErrorText="Incorrect Number" />
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
														<RequiredField IsRequired="true" />
													</ValidationSettings>
													<ClientSideEvents Validation="OnValidation" />
												</dx:ASPxTextBox>
											</div>
											<div class="regFieldHolder">
												<dx:ASPxLabel ID="lblCardDate" runat="server" AssociatedControlID="cmbCardMonth"
													Text="Expiration Date:" CssClass="regLabel" />
												<div class="ccExpDate">
													<div class="month">
														<dx:ASPxComboBox runat="server" ID="cmbCardMonth" ClientInstanceName="cmbCardExpirationMonth"
															ValueType="System.Int32" ValidationSettings-ValidateOnLeave="true" Width="94px"
															DropDownRows="12">
															<Items>
																<dx:ListEditItem Text="01" Value="1" />
																<dx:ListEditItem Text="02" Value="2" />
																<dx:ListEditItem Text="03" Value="3" />
																<dx:ListEditItem Text="04" Value="4" />
																<dx:ListEditItem Text="05" Value="5" />
																<dx:ListEditItem Text="06" Value="6" />
																<dx:ListEditItem Text="07" Value="7" />
																<dx:ListEditItem Text="08" Value="8" />
																<dx:ListEditItem Text="09" Value="9" />
																<dx:ListEditItem Text="10" Value="10" />
																<dx:ListEditItem Text="11" Value="11" />
																<dx:ListEditItem Text="12" Value="12" />
															</Items>
															<ClientSideEvents Init="function(s, e) { if(s.GetValue() == null) s.SetText('Month'); }"
																Validation="function(s, e) { OnCardExpirationDateValidation(s, e, 'Month'); }" />
															<ValidationSettings ErrorDisplayMode="None" SetFocusOnError="true" />
														</dx:ASPxComboBox>
													</div>
													<div class="year">
														<dx:ASPxComboBox runat="server" ID="cmbCardYear" ValueType="System.Int32" ClientInstanceName="cmbCardExpirationYear"
															Width="80px" DropDownRows="10">
															<ClientSideEvents Init="function(s, e) { if(s.GetValue() == null) s.SetText('Year'); }"
																Validation="function(s, e) { OnCardExpirationDateValidation(s, e, 'Year'); }" />
															<ValidationSettings ValidateOnLeave="true" ErrorDisplayMode="None" SetFocusOnError="true">
																<RequiredField IsRequired="true" />
															</ValidationSettings>
														</dx:ASPxComboBox>
													</div>
												</div>
											</div>
											<div class="regFieldHolder">
												<dx:ASPxLabel ID="lblCVV2" runat="server" AssociatedControlID="txtCVV2" Text="CVV2/CVC2:"
													CssClass="regLabel" />
												<dx:ASPxTextBox runat="server" ID="txtCVV2" Width="50px" MaxLength="4">
													<MaskSettings IncludeLiterals="DecimalSymbol" />
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
														<RegularExpression ValidationExpression="\d{3,4}" />
														<RequiredField IsRequired="true" />
													</ValidationSettings>
													<ClientSideEvents Validation="OnValidation" />
												</dx:ASPxTextBox>
											</div>
										</div>
										<div class="regColumn right">
											<div class="regFieldHolder">
												<dx:ASPxLabel ID="lblCardHolder" runat="server" AssociatedControlID="txtCardHolder"
													Text="Cardholder Name:" CssClass="regLabel" />
												<dx:ASPxTextBox runat="server" ID="txtCardHolder">
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
														<RequiredField IsRequired="true" />
													</ValidationSettings>
													<ClientSideEvents Init="function(s, e) { LoadRegField(s, 'FullName'); s.Validate(); }" Validation="OnValidation" />
												</dx:ASPxTextBox>
											</div>
											<div class="regFieldHolder">
												<dx:ASPxLabel ID="lblBillingAddress" runat="server" AssociatedControlID="txtBillingAddress"
													Text="Billing Address:" CssClass="regLabel" />
												<dx:ASPxTextBox runat="server" ID="txtBillingAddress">
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
														<RequiredField IsRequired="true" />
													</ValidationSettings>
													<ClientSideEvents Init="function(s, e) { LoadRegField(s, 'Address'); }" ValueChanged="function(s, e) { SaveRegField(s, 'Address'); }" Validation="OnValidation"/>
												</dx:ASPxTextBox>
											</div>
											<div class="regFieldHolder">
												<dx:ASPxLabel ID="lblBillingZipcode" runat="server" AssociatedControlID="txtBillingZipCode"
													Text="Billing Zip Code:" CssClass="regLabel" />
												<dx:ASPxTextBox runat="server" ID="txtBillingZipCode">
													<MaskSettings Mask="00000" PromptChar="_" />
													<ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
														<RequiredField IsRequired="true" />
													</ValidationSettings>
													<ClientSideEvents Validation="OnValidation"/>
												</dx:ASPxTextBox>
											</div>
										</div>
									</div>
								</div>
							</dx:ContentControl>
						</ContentCollection>
					</dx:TabPage>
					<dx:TabPage ClientEnabled="False" Name="Confirmation" Text="Confirmation">
						<ContentCollection>
							<dx:ContentControl ID="ContentControlConfirm" runat="server" SupportsDisabledAttribute="True">
								<div class="tabPageContent confirmArea">
									<div class="confirmInfo">
										<dx:ASPxLabel ID="lblConfimInfo" runat="server" Text="Verify the information you have entered and click Finish" />
									</div>
									<div class="regFieldHolder">
										<dx:ASPxLabel AssociatedControlID="lblConfirmRegistrant" runat="server" Text="Registrant:"
											CssClass="regLabel" />
										<dx:ASPxLabel ID="lblConfirmRegistrant" runat="server" CssClass="regValue" />
									</div>
									<div class="regFieldHolder">
										<dx:ASPxLabel AssociatedControlID="lblConfirmAddress" runat="server" Text="Address:"
											CssClass="regLabel" />
										<dx:ASPxLabel ID="lblConfirmAddress" runat="server" CssClass="regValue" />
									</div>
									<div class="regFieldHolder">
										<dx:ASPxLabel AssociatedControlID="lblConfirmPhone" runat="server" Text="Business Phone:"
											CssClass="regLabel" />
										<dx:ASPxLabel ID="lblConfirmPhone" runat="server" CssClass="regValue" />
									</div>
									<div class="regFieldHolder">
										<dx:ASPxLabel AssociatedControlID="lblConfirmMail" runat="server" Text="Email:" CssClass="regLabel" />
										<dx:ASPxLabel ID="lblConfirmMail" runat="server" CssClass="regValue" />
									</div>
									<div class="regFieldHolder regDate">
										<dx:ASPxLabel AssociatedControlID="lblRegDate" runat="server" Text="Registration Date:"
											CssClass="regLabel" />
										<dx:ASPxLabel ID="lblRegDate" runat="server" CssClass="regValue" />
									</div>
								</div>
							</dx:ContentControl>
						</ContentCollection>
					</dx:TabPage>
					<dx:TabPage ClientEnabled="False" Name="Finish" Text="Finish">
						<ContentCollection>
							<dx:ContentControl ID="ContentControlFinish" runat="server">
								<div class="tabPageContent finishArea">
									<p>
										Congratulations!</p>
									<p>
										Your registration is complete.</p>
									<dx:ASPxButton ID="btnGoToSchedule" runat="server" Image-Url="~/Images/buttons/schedule.png"
										OnClick="btnGoToSchedule_Click" CssClass="finishAreaButton" HorizontalAlign="Center" UseSubmitBehavior="False">
									</dx:ASPxButton>
								</div>
							</dx:ContentControl>
						</ContentCollection>
					</dx:TabPage>
				</TabPages>
			</dx:ASPxPageControl>
			<div class="buttonsArea">
				<div class="buttons">
					<table class="buttonsTable">
						<tr>
							<td>
								<dx:ASPxButton ID="btnBack" ClientInstanceName="btnBack" runat="server" Image-Url="~/Images/buttons/back.png"
									AutoPostBack="false" ClientVisible="false" CausesValidation="false" UseSubmitBehavior="False" HorizontalAlign="Center">
									<ClientSideEvents Click="OnBackButtonClick" />
								</dx:ASPxButton>
							</td>
							<td>
								<dx:ASPxButton ID="btnNext" ClientInstanceName="btnNext" runat="server" Image-Url="~/Images/buttons/next.png"
									AutoPostBack="false" CausesValidation="false" UseSubmitBehavior="true" HorizontalAlign="Center">
									<ClientSideEvents Click="OnNextButtonClick" />
								</dx:ASPxButton>
							</td>
							<td>
								<dx:ASPxButton ID="btnFinish" ClientInstanceName="btnFinish" runat="server" Image-Url="~/Images/buttons/finish.png"
									AutoPostBack="false" ClientVisible="false" UseSubmitBehavior="false" HorizontalAlign="Center">
									<ClientSideEvents Click="OnFinishButtonClick"/>
								</dx:ASPxButton>
							</td>
						</tr>
					</table>
				</div>
			</div>
			<dx:ASPxPanel ID="dxpError" ClientInstanceName="dxpError" runat="server" CssClass="errorPanel"
				ClientVisible="false">
				<PanelCollection>
					<dx:PanelContent>
						Please complete or correct the fields highlighted in red.
					</dx:PanelContent>
				</PanelCollection>
			</dx:ASPxPanel>
			<dx:ASPxHiddenField ID="hfRegInfo" ClientInstanceName="hfRegInfo" runat="server"
				SyncWithServer="true" ViewStateMode="Enabled">
			</dx:ASPxHiddenField>
		</div>
	</div>
</asp:Content>
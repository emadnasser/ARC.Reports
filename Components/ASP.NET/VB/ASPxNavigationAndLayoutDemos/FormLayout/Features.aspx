<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.vb" Inherits="FormLayout_Features" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
	   .exampleFormLayoutContainer 
	   {
		   vertical-align: top; 
		   width: 100%
	   }
	   .settingsFormLayoutContainer 
	   {
		   vertical-align: top; 
		   width: 350px
	   }
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table>
		<tr>
			<td class="exampleFormLayoutContainer">
				<dx:ASPxFormLayout runat="server" ID="exampleFormLayout" RequiredMarkDisplayMode="RequiredOnly" EnableViewState="false" EncodeHtml="false">
					<Items>
						<dx:LayoutGroup Caption="Group Caption" SettingsItemHelpTexts-Position="Bottom">
							<Items>
								<dx:LayoutItem Caption="Name" HelpText="Please, enter your login name">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox runat="server" ID="nameTextBox" Width="200">
												<ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" ErrorDisplayMode="Text" />
											</dx:ASPxTextBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Email" HelpText="Please, enter your e-mail">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox runat="server" ID="emailTextBox" Width="200">
												<ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" ErrorDisplayMode="Text" />
											</dx:ASPxTextBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Description" HelpText="Leave a little bit of information<br/>about yourself">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxMemo runat="server" ID="descriptionMemo" Width="200" Height="50" HelpText="You can leave this form field unfilled">
												<HelpTextSettings DisplayMode="Popup" />
											</dx:ASPxMemo>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem ShowCaption="false" RequiredMarkDisplayMode="Hidden" HorizontalAlign="Right" Width="100">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxButton runat="server" ID="submitButton" Text="Submit" Width="100" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
							</Items>
						</dx:LayoutGroup>                
					</Items>
				</dx:ASPxFormLayout>
			</td>
			<td class="settingsFormLayoutContainer">
				<dx:ASPxFormLayout runat="server" ID="settingsFormLayout" AlignItemCaptionsInAllGroups="True" SettingsItemCaptions-HorizontalAlign="Left">
					<Items>
						<dx:LayoutGroup Caption="Group Settings" GroupBoxDecoration="HeadingLine">
							<Items>
								<dx:LayoutItem Caption="Group Box Decoration">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxComboBox runat="server" ID="groupBoxDecorationComboBox" Width="110" SelectedIndex="0" AutoPostBack="true">
												<Items>
													<dx:ListEditItem Text="Box" Value="0" />
													<dx:ListEditItem Text="HeadingLine" Value="1" />
													<dx:ListEditItem Text="None" Value="2" />
												</Items>
											</dx:ASPxComboBox>                            
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Show Caption">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxCheckBox runat="server" ID="showGroupCaptionCheckBox" Checked="true" AutoPostBack="true" />                            
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>                        
							</Items>
						</dx:LayoutGroup>
						<dx:LayoutGroup Caption="Item Caption Settings" GroupBoxDecoration="HeadingLine">
							<Items>
								<dx:LayoutItem Caption="Show Caption">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxCheckBox runat="server" ID="showItemsCaptionCheckBox" Checked="true" AutoPostBack="true" />                            
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Location">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>                            
											<dx:ASPxComboBox runat="server" ID="itemsCaptionLocationComboBox" Width="110" SelectedIndex="0" AutoPostBack="true">
												<Items>
													<dx:ListEditItem Text="Left" Value="0" />
													<dx:ListEditItem Text="Top" Value="1" />
													<dx:ListEditItem Text="Right" Value="2" />
													<dx:ListEditItem Text="Bottom" Value="3" />
												</Items>
											</dx:ASPxComboBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>    
								<dx:LayoutItem Caption="Horizontal Align">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>                            
											<dx:ASPxComboBox runat="server" ID="itemsCaptionHAlignComboBox" Width="110" SelectedIndex="0" AutoPostBack="true">
												<Items>
													<dx:ListEditItem Text="Left" Value="0" />
													<dx:ListEditItem Text="Center" Value="1" />
													<dx:ListEditItem Text="Right" Value="2" />                                    
												</Items>
											</dx:ASPxComboBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Vertical Align">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>                            
											<dx:ASPxComboBox runat="server" ID="itemsCaptionVAlignComboBox" Width="110" SelectedIndex="0" AutoPostBack="true">
												<Items>
													<dx:ListEditItem Text="Top" Value="0" />
													<dx:ListEditItem Text="Middle" Value="1" />
													<dx:ListEditItem Text="Bottom" Value="2" />                                    
												</Items>
											</dx:ASPxComboBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
							</Items>
						</dx:LayoutGroup>
						<dx:LayoutGroup Caption="Item HelpText Settings" GroupBoxDecoration="HeadingLine">
							<Items>
								<dx:LayoutItem Caption="Show HelpText">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxCheckBox runat="server" ID="showItemsHelpTextCheckBox" Checked="true" AutoPostBack="true" />                            
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Position">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>                            
											<dx:ASPxComboBox runat="server" ID="helpTextsPositionComboBox" Width="110" SelectedIndex="0" AutoPostBack="true">
												<Items>
													<dx:ListEditItem Text="Auto" Value="0" />
													<dx:ListEditItem Text="Left" Value="1" />
													<dx:ListEditItem Text="Top" Value="2" />
													<dx:ListEditItem Text="Right" Value="3" />
													<dx:ListEditItem Text="Bottom" Value="4" />
												</Items>
											</dx:ASPxComboBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Horizontal Align">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxComboBox runat="server" ID="helpTextsHAlignComboBox" Width="110" SelectedIndex="0" AutoPostBack="true">
												<Items>
													<dx:ListEditItem Text="Auto" Value="0" />
													<dx:ListEditItem Text="Left" Value="1" />
													<dx:ListEditItem Text="Center" Value="2" />
													<dx:ListEditItem Text="Right" Value="3" />
												</Items>
											</dx:ASPxComboBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Vertical Align">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxComboBox runat="server" ID="helpTextsVAlignComboBox" Width="110" SelectedIndex="0" AutoPostBack="true">
												<Items>
													<dx:ListEditItem Text="Auto" Value="0" />
													<dx:ListEditItem Text="Top" Value="1" />
													<dx:ListEditItem Text="Middle" Value="2" />
													<dx:ListEditItem Text="Bottom" Value="3" />
												</Items>
											</dx:ASPxComboBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
							</Items>
						</dx:LayoutGroup>
						<dx:LayoutGroup Caption="Required Mark Settings" GroupBoxDecoration="HeadingLine">
							<Items>
								<dx:LayoutItem Caption="Required Mark Display Mode">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>                                    
											<dx:ASPxComboBox runat="server" ID="requiredMarkDisplayModeComboBox" Width="110" SelectedIndex="3" AutoPostBack="true">
												<Items>
													<dx:ListEditItem Text="Auto" Value="0" />
													<dx:ListEditItem Text="None" Value="1" />
													<dx:ListEditItem Text="All" Value="2" />
													<dx:ListEditItem Text="RequiredOnly" Value="3" />
													<dx:ListEditItem Text="OptionalOnly" Value="4" />
												</Items>
											</dx:ASPxComboBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>                                   
								<dx:LayoutItem Caption="Required Mark">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox runat="server" ID="requiredMarkTextBox" Text="*" AutoPostBack="true" Width="110" />                            
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Optional Mark">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox runat="server" ID="optionalMarkTextBox" Text="(optional)" AutoPostBack="true"  Width="110" />                            
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
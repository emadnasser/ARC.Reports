<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CustomerEmployeeEditForm.ascx.cs" Inherits="UserControls_EditForms_CusomerEmployeeEditForm" %>
<dx:ASPxPopupControl ID="CustomerEmployeeEditPopup" ClientInstanceName="customerEmployeeEditPopup" runat="server" PopupHorizontalAlign="WindowCenter" Modal="true" PopupAnimationType="Fade" CloseOnEscape="true"
    PopupVerticalAlign="WindowCenter" CloseAction="None" OnWindowCallback="CustomerEmployeeEditPopup_WindowCallback" ShowCloseButton="false" CssClass="custEditFormPopup">
    <ClientSideEvents EndCallback="DevAV.CustomerEditPopup_EndCallback" />
    <ContentCollection>
        <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
            <dx:ASPxFormLayout ID="EmployeeEditFormLayout" runat="server" AlignItemCaptionsInAllGroups="True">
                <Styles>
                    <LayoutGroup CssClass="group"></LayoutGroup>
                </Styles>
                <Items>
                    <dx:LayoutGroup ColCount="2" GroupBoxDecoration="None">
                        <Items>
                            <dx:LayoutItem Caption="First Name">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <dx:ASPxTextBox ID="FirstNameTextBox" ClientInstanceName="firstNameTextBox" runat="server" Width="250px" MaxLength="30">
                                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField IsRequired="True" ErrorText="Name is required" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Last Name">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                        <dx:ASPxTextBox ID="LastNameTextBox" runat="server" Width="250px" MaxLength="30">
                                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField IsRequired="True" ErrorText="Last name is required" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Prefix">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                                        <dx:ASPxComboBox ID="PrefixComboBox" runat="server" Width="250px">
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Position">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                        <dx:ASPxTextBox ID="PositionTextBox" runat="server" Width="250px" MaxLength="30">
                                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField IsRequired="True" ErrorText="Position is required" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                        </Items>
                    </dx:LayoutGroup>
                    <dx:LayoutGroup GroupBoxDecoration="None" ShowCaption="False">
                        <Items>
                            <dx:LayoutItem Caption="Store" CssClass="fullWidthEditorContainer">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                                        <dx:ASPxComboBox ID="StoreComboBox" runat="server" ValueType="System.String" Width="100%" IncrementalFilteringMode="Contains">
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                            <dx:LayoutItem Caption="Address" CssClass="fullWidthEditorContainer">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                                        <dx:ASPxTextBox ID="AddressTextBox" runat="server" NullText="Address" Width="100%" MaxLength="50">
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption=" ">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                                        <table class="fullWidthTable">
                                            <tr>
                                                <td>
                                                    <dx:ASPxTextBox ID="CityTextBox" runat="server" NullText="City" Width="300px" MaxLength="30">
                                                    </dx:ASPxTextBox>
                                                </td>
                                                <td>
                                                    <dx:ASPxComboBox ID="StateComboBox" runat="server" NullText="State" Width="100px"  IncrementalFilteringMode="StartsWith">
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td class="fullWidthCell">
                                                    <dx:ASPxTextBox ID="ZipCodeTextBox" runat="server" NullText="Zipcode" Width="100%">
                                                        <MaskSettings Mask="00000" ErrorText="Invalid zipcode, format: #####" />
                                                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" />
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                        </Items>
                    </dx:LayoutGroup>
                    <dx:LayoutGroup ColCount="2" GroupBoxDecoration="None" ShowCaption="False">
                        <Items>
                            <dx:LayoutItem Caption="Business">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                        <dx:ASPxTextBox ID="BusinessPhoneTextBox" runat="server" Width="250px">
                                            <MaskSettings Mask="(999) 000-0000" ErrorText="Invalid number, format example: (818) 844-3383"  />
                                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip" />
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Email">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                        <dx:ASPxTextBox ID="EmailTextBox" runat="server" Width="250px" MaxLength="50">
                                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField IsRequired="True" ErrorText="Email is required" />
                                                <RegularExpression ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorText="Invalid email, format example: info@devexpress.com" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Mobile">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                                        <dx:ASPxTextBox ID="MobileNumberTextBox" runat="server" Width="250px">
                                            <MaskSettings Mask="(999) 000-0000" ErrorText="Invalid number, format example: (818) 844-3383" />
                                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip" />
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                                        <dx:ASPxCheckBox ID="PurchaseAuthorityCheckBox" runat="server" Text="Purchase authority?">
                                        </dx:ASPxCheckBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                        </Items>
                    </dx:LayoutGroup>
                </Items>
            </dx:ASPxFormLayout>
            <div class="buttonsContainer">
                <dx:ASPxButton ID="CustomerSaveButton" runat="server" AutoPostBack="false" Text="Save" Width="100px">
                    <ClientSideEvents Click="DevAV.CustomerSaveButton_Click" />
                </dx:ASPxButton>
                <dx:ASPxButton ID="CustomerCancelButton" runat="server" AutoPostBack="False" UseSubmitBehavior="False" Text="Cancel" Width="100px">
                    <ClientSideEvents Click="DevAV.CustomerCancelButton_Click" />
                </dx:ASPxButton>
            </div>
            <div style="clear: both">
            </div>
        </dx:PopupControlContentControl>
    </ContentCollection>
</dx:ASPxPopupControl>
